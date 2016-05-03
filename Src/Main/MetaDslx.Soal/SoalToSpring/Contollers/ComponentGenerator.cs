using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Soal.SoalToSpring.Contollers
{
    public class ComponentGenerator
    {
        private SpringInterfaceGenerator springInterfaceGen;
        private SpringClassGenerator springClassGen;
        private SpringConfigurationGenerator springConfigGen;
        private SpringViewGenerator springViewGen;
        private SpringGeneratorUtil generatorUtil;

        private BindingDiscoverer bindingGenerator;
        private DirectoryHandler directoryHandler;

        private DependencyDiscoverer dependencyDiscoverer;
        private DataAccessFinder dataAccessFinder;
        private JSFGenerator jSFGenerator;

        public ComponentGenerator(SpringInterfaceGenerator springInterfaceGen, SpringClassGenerator springClassGen,
            SpringConfigurationGenerator springConfigGen, SpringViewGenerator springViewGen, SpringGeneratorUtil generatorUtil,
            BindingDiscoverer bindingGenerator, DirectoryHandler directoryHandler,
            DependencyDiscoverer dependencyDiscoverer, DataAccessFinder dataAccessFinder, JSFGenerator jSFGenerator)
        {
            this.springInterfaceGen = springInterfaceGen;
            this.springClassGen = springClassGen;
            this.springConfigGen = springConfigGen;
            this.springViewGen = springViewGen;
            this.generatorUtil = generatorUtil;

            this.bindingGenerator = bindingGenerator;
            this.directoryHandler = directoryHandler;

            this.dependencyDiscoverer = dependencyDiscoverer;
            this.dataAccessFinder = dataAccessFinder;
            this.jSFGenerator = jSFGenerator;
        }

        public Dictionary<string, string> GenerateComponent(Namespace ns, List<Wire> wires, List<string> modules)
        {
            Dictionary<string, string> properties = new Dictionary<string, string>();
            foreach (Component component in ns.Declarations.OfType<Component>())
            {
                modules.Add(component.Name);
                ComponentType cType = ComponentType.IMPLEMENTATION;

                Dictionary<Reference, Component> dependencyMap = this.dependencyDiscoverer.GetherDependencyMap(ns, wires, component);
                List<string> dependencies = this.dependencyDiscoverer.GetherDependencies(dependencyMap);

                Reference dataReference = null;
                foreach (Component comp in ns.Declarations.OfType<Component>())
                {
                    foreach (Reference reference in component.References)
                    {
                        if (reference.Interface is Database)
                        {
                            dataReference = reference;
                        }
                    }
                }
                string dataModule = dataReference != null ? dependencyMap[dataReference].Name : "";
                bool directDataAccess = this.dataAccessFinder.HasDirectDataAccess(ns, wires, component, dataModule);

                if (component.Services.Any())
                {
                    this.GenerateServiceImplementations(ns, modules, wires, component, dependencies, dataModule);
                }
                else
                {
                    if (component.Implementation != null && component.Implementation.Name.Equals("JSF"))
                    {
                        cType = ComponentType.WEB;
                        this.jSFGenerator.GenerateWebTier(ns, component, directDataAccess);
                    }
                    if (component is Composite)
                    {
                        string facadeDir = this.directoryHandler.createJavaDirectory(ns, component.Name, generatorUtil.Properties.serviceFacadePackage);
                        string facadeFile = Path.Combine(facadeDir, component.Name + "Facade.java");
                        using (StreamWriter writer = new StreamWriter(facadeFile))
                        {
                            writer.WriteLine(this.springClassGen.GenerateComponent(component));
                        }
                    }
                }
                BindingTypeHolder clientFor = new BindingTypeHolder();
                if (component.References.Any())
                {
                    clientFor = this.GenerateReferenceAccessors(ns, component, directDataAccess, dependencyMap, properties);
                }

                // generate pom.xml and spring-config.xml of Business Logic module
                this.directoryHandler.createJavaDirectory(ns, component.Name, "");
                string fileName = Path.Combine(ns.Name + "-" + component.Name, "pom.xml");
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    string s = this.springConfigGen.GenerateComponentPom(ns, component, dependencies,
                        clientFor.HasRestBinding, clientFor.HasWebServiceBinding, clientFor.HasWebSocketBinding, cType);
                    writer.WriteLine(s);
                }

                string javaDir = this.directoryHandler.createJavaDirectory(ns, component.Name, "", false);
                fileName = Path.Combine(javaDir, "spring-config.xml");
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    writer.WriteLine(this.springConfigGen.GenerateComponentSpringConfig(ns));
                }
            }
            return properties;
        }

        private void GenerateServiceImplementations(Namespace ns, List<string> modules, List<Wire> wires, Component component,
            List<string> dependencies, string dataModule)
        {
            modules.Add(component.Name + "-API");
            BindingTypeHolder bindingsOfModule = new BindingTypeHolder();

            string dataBinding = "";
            foreach (Reference reference in component.References)
            {
                if (reference.Interface is Database)
                {
                    List<Binding> binds = bindingGenerator.GetBindings(ns, reference);
                    BindingTypeHolder binding = bindingGenerator.CheckForBindings(binds);
                    if (binding.HasRestBinding)
                        dataBinding = "Rest";
                    else if (binding.HasWebServiceBinding)
                        dataBinding = "WebService";
                    else if (binding.HasWebSocketBinding)
                        dataBinding = "WebSocket";
                }
            }
            bool hasDirectDataAccess = dataBinding == "" && this.dataAccessFinder.HasDirectDataAccess(ns, wires, component, dataModule);

            foreach (Service service in component.Services)
            {
                Interface iface = service.Interface;

                if (iface is Database) { continue; } // Repositry interfaces have been generated already

                string package = this.PackageOf(iface);
                string apiIfDirectory = this.directoryHandler.createJavaDirectory(ns, component.Name + "-API", package);
                string functionDirectory = this.directoryHandler.createJavaDirectory(ns, component.Name, component.Name.ToLower());

                string entityName = null;
                if (package == this.generatorUtil.Properties.interfacePackage)
                {
                    // interface goes to API
                    string interfaceFileName = Path.Combine(apiIfDirectory, iface.Name + ".java");
                    using (StreamWriter writer = new StreamWriter(interfaceFileName))
                    {
                        writer.WriteLine(this.springInterfaceGen.GenerateInterface(iface, "", package, null));
                    }

                    // implementaton goes to component
                    string javaFileName = Path.Combine(functionDirectory, iface.Name + "Impl.java");
                    using (StreamWriter writer = new StreamWriter(javaFileName))
                    {
                        writer.WriteLine(this.springInterfaceGen.GenerateInterfaceImplementation(iface, component.Name.ToLower(), dataBinding));
                    }
                }
                else // a Spring Repository
                {
                    Struct entity = null;
                    foreach (Operation op in iface.Operations)
                    {
                        if (op.Name == "delete")
                        {
                            if (op.Parameters.Count == 1)
                            {
                                SoalType type = op.Parameters[0].Type;
                                if (type is Struct)
                                {
                                    entity = type as Struct;
                                    break;
                                }
                            }
                        }
                    }
                    if (entity != null)
                    {
                        entityName = entity.Name;
                        string javaFileName = Path.Combine(apiIfDirectory, entityName + "Repository.java");
                        using (StreamWriter writer = new StreamWriter(javaFileName))
                        {
                            writer.WriteLine(this.springClassGen.GenerateRepository(entity));
                        }
                    }
                }

                List<Binding> bindings = this.bindingGenerator.GetBindings(ns, service);
                BindingTypeHolder bindingsOfService = this.bindingGenerator.CheckForBindings(bindings);

                this.CreateBindings(bindingsOfService, component, iface, apiIfDirectory, functionDirectory, package, entityName, dataBinding);

                bindingsOfModule.HasRestBinding |= bindingsOfService.HasRestBinding;
                bindingsOfModule.HasWebServiceBinding |= bindingsOfService.HasWebServiceBinding;
                bindingsOfModule.HasWebSocketBinding |= bindingsOfService.HasWebSocketBinding;

                foreach (Operation op in iface.Operations)
                {
                    foreach (Struct exception in op.Exceptions)
                    {
                        string apiExDirectory = this.directoryHandler.createJavaDirectory(ns, component.Name + "-API", generatorUtil.Properties.exceptionPackage);
                        string exFileName = Path.Combine(apiExDirectory, exception.Name + ".java");
                        using (StreamWriter writer = new StreamWriter(exFileName))
                        {
                            writer.WriteLine(this.springClassGen.GenerateException(exception));
                        }
                    }
                }
            }

            // pom.xml of API
            List<string> apiDependencies = new List<string>(dependencies);
            apiDependencies.Add("Model");
            this.directoryHandler.createJavaDirectory(ns, component.Name + "-API", "");
            string fileName = Path.Combine(ns.Name + "-" + component.Name + "-API", "pom.xml");
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                // remove dependency from data module
                apiDependencies.Remove(dataModule);
                apiDependencies.Remove(dataModule + "-API");

                Component c = new ComponentImpl();
                c.Name = component.Name + "-API";
                string output = this.springConfigGen.GenerateComponentPom(ns, c, apiDependencies,
                    bindingsOfModule.HasRestBinding, bindingsOfModule.HasWebServiceBinding, bindingsOfModule.HasWebSocketBinding, ComponentType.API);
                writer.WriteLine(output);
            }

            if (bindingsOfModule.hasAnyBinding())
            {
                GenerateRemoteAccessTier(ns, modules, component, dependencies, hasDirectDataAccess);
            }

            dependencies.Add(component.Name + "-API");
        }

        private void GenerateRemoteAccessTier(Namespace ns, List<string> modules, Component component, List<string> dependencies, bool hasDirectDataAccess)
        {
            Component c = new ComponentImpl();
            c.Name = component.Name + "-WEB";
            modules.Add(c.Name);

            List<string> deps = new List<string>();
            deps.Add(component.Name);
            this.directoryHandler.createJavaDirectory(ns, c.Name, "");
            string fileName = Path.Combine(ns.Name + "-" + c.Name, "pom.xml");
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine(this.springConfigGen.GenerateComponentPom(ns, c, deps, false, false, false, ComponentType.REMOTE));
            }

            // web.xml
            string webinfDir = this.directoryHandler.createWebDirectory(ns, c.Name, "");
            string webxmlFile = Path.Combine(webinfDir, "web.xml");
            using (StreamWriter writer = new StreamWriter(webxmlFile))
            {
                writer.WriteLine(this.springViewGen.GenerateWebXml(ComponentType.REMOTE));
            }

            // deployment-struture
            string jbossFile = Path.Combine(webinfDir, "jboss-deployment-structure.xml");
            using (StreamWriter writer = new StreamWriter(jbossFile))
            {
                writer.WriteLine(this.springViewGen.GenerateJboss());
            }

            // appCtx
            string ctxFile = Path.Combine(webinfDir, "applicationContext.xml");
            using (StreamWriter writer = new StreamWriter(ctxFile))
            {
                writer.WriteLine(this.springViewGen.GenerateAppCtx(ns, hasDirectDataAccess));
            }

            // servlet
            string servletFile = Path.Combine(webinfDir, "spring-servlet.xml");
            using (StreamWriter writer = new StreamWriter(servletFile))
            {
                writer.WriteLine(this.springViewGen.GenerateServlet(ns, ComponentType.REMOTE));
            }
        }

        private BindingTypeHolder GenerateReferenceAccessors(Namespace ns, Component component, bool directDataAccess,
            Dictionary<Reference, Component> dependencyMap, Dictionary<string, string> properties)
        {
            BindingTypeHolder clientFor = new BindingTypeHolder();
            foreach (Reference reference in component.References)
            {
                Component referencedComp = dependencyMap[reference];
                if (reference.Interface is Database)
                {
                    if (referencedComp.Name.EndsWith("API"))
                    {
                        referencedComp = referencedComp.BaseComponent;
                    }
                    foreach (Service service in referencedComp.Services)
                    {
                        if (!(service.Interface is Database))
                        {
                            List<Binding> binds = this.bindingGenerator.GetBindings(ns, reference);
                            BindingTypeHolder binding = this.bindingGenerator.CheckForBindings(binds);
                            this.GenerateAccessor(ns, component, referencedComp, binding, properties, clientFor, service);
                        }
                    }
                }
                else
                {
                    List<Binding> binds = this.bindingGenerator.GetBindings(ns, reference);
                    BindingTypeHolder binding = this.bindingGenerator.CheckForBindings(binds);
                    this.GenerateAccessor(ns, component, referencedComp, binding, properties, clientFor, reference);
                }
            }

            return clientFor;
        }

        private void GenerateAccessor(Namespace ns, Component component, Component referencedComp, BindingTypeHolder binding,
            Dictionary<string, string> properties, BindingTypeHolder clientFor, Port port)
        {
            if (binding.HasRestBinding)
            {
                clientFor.HasRestBinding = true;
                KeyValuePair<string, string> keyValue;
                keyValue = new KeyValuePair<string, string>(referencedComp.Name + "RestServer", "localhost");
                if (!properties.Contains(keyValue))
                {
                    properties.Add(keyValue.Key, keyValue.Value);
                }
                keyValue = new KeyValuePair<string, string>(referencedComp.Name + "RestPort", "8080");
                if (!properties.Contains(keyValue))
                {
                    properties.Add(keyValue.Key, keyValue.Value);
                }

                string package = this.PackageOf(port.Interface);
                string proxyDir = this.directoryHandler.createJavaDirectory(ns, component.Name, generatorUtil.Properties.proxyPackage);
                string accessorFile = Path.Combine(proxyDir, port.Interface.Name + "RestProxy.java");
                string currentComponent = component.Name;
                string targetComponent = referencedComp.Name;
                if (targetComponent.Contains("-API") || targetComponent.Contains("-WEB"))
                {
                    targetComponent = targetComponent.Split(new string[] { "-API", "-WEB" }, StringSplitOptions.RemoveEmptyEntries)[0];
                }

                using (StreamWriter writer = new StreamWriter(accessorFile))
                {
                    writer.WriteLine(this.springInterfaceGen.GenerateProxyForInterface(port.Interface, "Rest", package, currentComponent, targetComponent));
                }
            }
            // TODO Ws & Ws
        }

        private void CreateBindings(BindingTypeHolder bindings, Component component, Interface iface, string apiDirectory,
            string functionDirectory, string package, string entityName, string dataBinding)
        {
            if (bindings.HasRestBinding)
            {
                // interface extension goes to API
                string interfaceExtFileName = Path.Combine(apiDirectory, iface.Name + "Rest.java");
                using (StreamWriter writer = new StreamWriter(interfaceExtFileName))
                {
                    writer.WriteLine(this.springInterfaceGen.GenerateInterface(iface, "Rest", package, entityName));
                }

                // implementation of the above goes to component
                string implFileName = Path.Combine(functionDirectory, iface.Name + "RestImpl.java");
                using (StreamWriter writer = new StreamWriter(implFileName))
                {
                    writer.WriteLine(this.springInterfaceGen.GenerateProxyInterfaceImplementation(iface, component.Name.ToLower(), "Rest", package, dataBinding));
                }
            }

            if (bindings.HasWebServiceBinding)
            {
                // interface extension goes to API
                string interfaceExtFileName = Path.Combine(apiDirectory, iface.Name + "WebService.java");
                using (StreamWriter writer = new StreamWriter(interfaceExtFileName))
                {
                    writer.WriteLine(this.springInterfaceGen.GenerateInterface(iface, "WebService", package, entityName));
                }

                // implementation of the above goes to component
                string implFileName = Path.Combine(functionDirectory, iface.Name + "WebServiceImpl.java");
                using (StreamWriter writer = new StreamWriter(implFileName))
                {
                    writer.WriteLine(this.springInterfaceGen.GenerateProxyInterfaceImplementation(iface, component.Name.ToLower(), "WebService", package, dataBinding));
                }
            }

            if (bindings.HasWebSocketBinding)
            {
                // interface extension goes to API
                string interfaceExtFileName = Path.Combine(apiDirectory, iface.Name + "WebSocket.java");
                using (StreamWriter writer = new StreamWriter(interfaceExtFileName))
                {
                    writer.WriteLine(this.springInterfaceGen.GenerateInterface(iface, "WebSocket", package, entityName));
                }

                // implementation of the above goes to component
                string implFileName = Path.Combine(functionDirectory, iface.Name + "WebSocketImpl.java");
                using (StreamWriter writer = new StreamWriter(implFileName))
                {
                    writer.WriteLine(this.springInterfaceGen.GenerateProxyInterfaceImplementation(iface, component.Name.ToLower(), "WebSocket", package, dataBinding));
                }
            }
        }

        private string PackageOf(Interface iface)
        {
            return iface.Name.Contains("Repository") ? this.generatorUtil.Properties.repositoryPackage : this.generatorUtil.Properties.interfacePackage;
        }
    }
}
