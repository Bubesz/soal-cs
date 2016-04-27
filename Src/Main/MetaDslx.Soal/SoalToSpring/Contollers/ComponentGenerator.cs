﻿using System;
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

                string dataModule = "";
                foreach (Component comp in ns.Declarations.OfType<Component>())
                {
                    foreach (Reference reference in component.References)
                    {
                        if (reference.Interface is Database)
                        {
                            dataModule = component.Name;
                        }
                    }
                }

                Dictionary<Reference, Component> dependencyMap = dependencyDiscoverer.GetherDependencyMap(ns, wires, component);
                List<string> dependencies = dependencyDiscoverer.GetherDependencies(dependencyMap);
                bool directDataAccess = dataAccessFinder.HasDirectDataAccess(ns, wires, component, dataModule);

                if (component.Services.Any())
                {
                    this.GenerateServiceImplementations(ns, modules, wires, component, dependencies, dataModule);
                }
                else
                {
                    if (component.Implementation != null && component.Implementation.Name.Equals("JSF"))
                    {
                        cType = ComponentType.WEB;
                        jSFGenerator.GenerateWebTier(ns, component, directDataAccess);
                    }
                    if (component is Composite)
                    {
                        string facadeDir = directoryHandler.createJavaDirectory(ns, component.Name, generatorUtil.Properties.serviceFacadePackage);
                        string facadeFile = Path.Combine(facadeDir, component.Name + "Facade.java");
                        using (StreamWriter writer = new StreamWriter(facadeFile))
                        {
                            writer.WriteLine(springClassGen.GenerateComponent(component));
                        }
                    }
                }
                BindingTypeHolder clientFor = new BindingTypeHolder();
                if (component.References.Any())
                {
                    clientFor = this.GenerateReferenceAccessors(ns, component, dependencyMap, properties, springInterfaceGen, generatorUtil);
                }

                // generate pom.xml and spring-config.xml of Business Logic module
                directoryHandler.createJavaDirectory(ns, component.Name, "");
                string fileName = Path.Combine(ns.Name + "-" + component.Name, "pom.xml");
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    string s = springConfigGen.GenerateComponentPom(ns, component, dependencies,
                        clientFor.HasRestBinding, clientFor.HasWebServiceBinding, clientFor.HasWebSocketBinding, cType);
                    writer.WriteLine(s);
                }

                string javaDir = directoryHandler.createJavaDirectory(ns, component.Name, "", false);
                fileName = Path.Combine(javaDir, "spring-config.xml");
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    writer.WriteLine(springConfigGen.GenerateComponentSpringConfig(ns));
                }
            }
            return properties;
        }

        public void GenerateServiceImplementations(Namespace ns, List<string> modules, List<Wire> wires, Component component, List<string> dependencies, string dataModule)
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
            bool hasDirectDataAccess = dataBinding == "" && dataAccessFinder.HasDirectDataAccess(ns, wires, component, dataModule);

            foreach (Service service in component.Services)
            {
                Interface iface = service.Interface;

                if (iface is Database) { continue; } // Repositry interfaces have been generated already

                string package = iface.Name.Contains("Repository") ? generatorUtil.Properties.repositoryPackage : generatorUtil.Properties.interfacePackage;
                string apiIfDirectory = directoryHandler.createJavaDirectory(ns, component.Name + "-API", package);
                string functionDirectory = directoryHandler.createJavaDirectory(ns, component.Name, component.Name.ToLower());

                if (package == generatorUtil.Properties.interfacePackage)
                {
                    // interface goes to API
                    string interfaceFileName = Path.Combine(apiIfDirectory, iface.Name + ".java");
                    using (StreamWriter writer = new StreamWriter(interfaceFileName))
                    {
                        writer.WriteLine(springInterfaceGen.GenerateInterface(iface, "", package));
                    }
                
                    // implementaton goes to component
                    string javaFileName = Path.Combine(functionDirectory, iface.Name + "Impl.java");
                    using (StreamWriter writer = new StreamWriter(javaFileName))
                    {
                        writer.WriteLine(springInterfaceGen.GenerateInterfaceImplementation(iface, component.Name.ToLower(), dataBinding));
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
                        string javaFileName = Path.Combine(apiIfDirectory, entity.Name + "Repository.java");
                        using (StreamWriter writer = new StreamWriter(javaFileName))
                        {
                            writer.WriteLine(springClassGen.GenerateRepository(entity));
                        }
                    }
                }

                List<Binding> bindings = bindingGenerator.GetBindings(ns, service);
                BindingTypeHolder bindingsOfService = bindingGenerator.CheckForBindings(bindings);

                this.CreateBindings(bindingsOfService, component, iface, apiIfDirectory, functionDirectory, package, dataBinding);

                bindingsOfModule.HasRestBinding |= bindingsOfService.HasRestBinding;
                bindingsOfModule.HasWebServiceBinding |= bindingsOfService.HasWebServiceBinding;
                bindingsOfModule.HasWebSocketBinding |= bindingsOfService.HasWebSocketBinding;

                foreach (Operation op in iface.Operations)
                {
                    foreach (Struct exception in op.Exceptions)
                    {
                        string apiExDirectory = directoryHandler.createJavaDirectory(ns, component.Name + "-API", generatorUtil.Properties.exceptionPackage);
                        string exFileName = Path.Combine(apiExDirectory, exception.Name + ".java");
                        using (StreamWriter writer = new StreamWriter(exFileName))
                        {
                            writer.WriteLine(springClassGen.GenerateException(exception));
                        }
                    }
                }
            }

            // pom.xml of API
            List<string> apiDependencies = new List<string>(dependencies);
            apiDependencies.Add("Model");
            directoryHandler.createJavaDirectory(ns, component.Name + "-API", "");
            string fileName = Path.Combine(ns.Name + "-" + component.Name + "-API", "pom.xml");
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                // remove dependency from data module
                apiDependencies.Remove(dataModule);
                apiDependencies.Remove(dataModule + "-API");

                Component c = new ComponentImpl();
                c.Name = component.Name + "-API";
                string output = springConfigGen.GenerateComponentPom(ns, c, apiDependencies,
                    bindingsOfModule.HasRestBinding, bindingsOfModule.HasWebServiceBinding, bindingsOfModule.HasWebSocketBinding, ComponentType.API);
                writer.WriteLine(output);
            }
            dependencies.Add(component.Name + "-API");

            if (bindingsOfModule.hasAnyBinding())
            {
                // generate web tier for remote access
                Component c = new ComponentImpl();
                c.Name = component.Name + "-WEB";
                modules.Add(c.Name);

                List<string> deps = new List<string>();
                deps.Add(component.Name + "-API");
                directoryHandler.createJavaDirectory(ns, c.Name, "");
                fileName = Path.Combine(ns.Name + "-" + c.Name, "pom.xml");
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    writer.WriteLine(springConfigGen.GenerateComponentPom(ns, c, deps, false, false, false, ComponentType.REMOTE));
                }

                // web.xml
                string webinfDir = directoryHandler.createWebDirectory(ns, c.Name, "");
                string webxmlFile = Path.Combine(webinfDir, "web.xml");
                using (StreamWriter writer = new StreamWriter(webxmlFile))
                {
                    writer.WriteLine(springViewGen.GenerateWebXml(ComponentType.REMOTE));
                }

                // deployment-struture
                string jbossFile = Path.Combine(webinfDir, "jboss-deployment-structure.xml");
                using (StreamWriter writer = new StreamWriter(jbossFile))
                {
                    writer.WriteLine(springViewGen.GenerateJboss());
                }

                // appCtx
                string ctxFile = Path.Combine(webinfDir, "applicationContext.xml");
                using (StreamWriter writer = new StreamWriter(ctxFile))
                {
                    writer.WriteLine(springViewGen.GenerateAppCtx(ns, hasDirectDataAccess));
                }

                // servlet
                string servletFile = Path.Combine(webinfDir, "spring-servlet.xml");
                using (StreamWriter writer = new StreamWriter(servletFile))
                {
                    writer.WriteLine(springViewGen.GenerateServlet(ns, ComponentType.REMOTE));
                }
            }
        }

        public BindingTypeHolder GenerateReferenceAccessors(Namespace ns, Component component, Dictionary<Reference, Component> dependencyMap, Dictionary<string, string> properties, SpringInterfaceGenerator springInterfaceGen, SpringGeneratorUtil generatorUtil)
        {
            BindingTypeHolder clientFor = new BindingTypeHolder();
            foreach (Reference reference in component.References)
            {
                if (reference.Interface is Database)
                {
                    continue;
                }
                List<Binding> binds = bindingGenerator.GetBindings(ns, reference);
                BindingTypeHolder binding = bindingGenerator.CheckForBindings(binds);
                if (binding.HasRestBinding)
                {
                    clientFor.HasRestBinding = true;
                    KeyValuePair<string, string> keyValue;
                    keyValue = new KeyValuePair<string, string>(reference.Interface.Name + "RestServer", "localhost");
                    if (!properties.Contains(keyValue))
                    {
                        properties.Add(keyValue.Key, keyValue.Value);
                    }
                    keyValue = new KeyValuePair<string, string>(reference.Interface.Name + "RestPort", "8080");
                    if (!properties.Contains(keyValue))
                    {
                        properties.Add(keyValue.Key, keyValue.Value);
                    }

                    string proxyDir = directoryHandler.createJavaDirectory(ns, component.Name, generatorUtil.Properties.proxyPackage);
                    string accessorFile = Path.Combine(proxyDir, reference.Interface.Name + "RestProxy.java");
                    string currentComponent = component.Name;
                    string targetComponent = dependencyMap[reference].Name;
                    if (targetComponent.Contains("-API") || targetComponent.Contains("-WEB"))
                    {
                        targetComponent = targetComponent.Split(new string[] { "-API", "-WEB" }, StringSplitOptions.RemoveEmptyEntries)[0];
                    }

                    using (StreamWriter writer = new StreamWriter(accessorFile))
                    {
                        writer.WriteLine(springInterfaceGen.GenerateProxyForInterface(reference.Interface, "Rest", currentComponent, targetComponent));
                    }
                }
                // TODO Ws & Ws
            }

            return clientFor;
        }

        public void CreateBindings(BindingTypeHolder bindings, Component component, Interface iface, string apiDirectory, string functionDirectory, string package, string dataBinding)
        {
            if (bindings.HasRestBinding)
            {
                // interface extension goes to API
                string interfaceExtFileName = Path.Combine(apiDirectory, iface.Name + "Rest.java");
                using (StreamWriter writer = new StreamWriter(interfaceExtFileName))
                {
                    writer.WriteLine(springInterfaceGen.GenerateInterface(iface, "Rest", package));
                }

                // implementation of the above goes to component
                string implFileName = Path.Combine(functionDirectory, iface.Name + "RestImpl.java");
                using (StreamWriter writer = new StreamWriter(implFileName))
                {
                    writer.WriteLine(springInterfaceGen.GenerateProxyInterfaceImplementation(iface, component.Name.ToLower(), "Rest", package, dataBinding));
                }
            }

            if (bindings.HasWebServiceBinding)
            {
                // interface extension goes to API
                string interfaceExtFileName = Path.Combine(apiDirectory, iface.Name + "WebService.java");
                using (StreamWriter writer = new StreamWriter(interfaceExtFileName))
                {
                    writer.WriteLine(springInterfaceGen.GenerateInterface(iface, "WebService", package));
                }

                // implementation of the above goes to component
                string implFileName = Path.Combine(functionDirectory, iface.Name + "WebServiceImpl.java");
                using (StreamWriter writer = new StreamWriter(implFileName))
                {
                    writer.WriteLine(springInterfaceGen.GenerateProxyInterfaceImplementation(iface, component.Name.ToLower(), "WebService", package, dataBinding));
                }
            }

            if (bindings.HasWebSocketBinding)
            {
                // interface extension goes to API
                string interfaceExtFileName = Path.Combine(apiDirectory, iface.Name + "WebSocket.java");
                using (StreamWriter writer = new StreamWriter(interfaceExtFileName))
                {
                    writer.WriteLine(springInterfaceGen.GenerateInterface(iface, "WebSocket", package));
                }

                // implementation of the above goes to component
                string implFileName = Path.Combine(functionDirectory, iface.Name + "WebSocketImpl.java");
                using (StreamWriter writer = new StreamWriter(implFileName))
                {
                    writer.WriteLine(springInterfaceGen.GenerateProxyInterfaceImplementation(iface, component.Name.ToLower(), "WebSocket", package, dataBinding));
                }
            }
        }

    }
}
