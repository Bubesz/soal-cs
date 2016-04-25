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

        private BindingGenerator bindingGenerator;
        private DirectoryHandler directoryHandler;

        public ComponentGenerator(SpringInterfaceGenerator springInterfaceGen, SpringClassGenerator springClassGen,
            SpringConfigurationGenerator springConfigGen, SpringViewGenerator springViewGen,
            SpringGeneratorUtil generatorUtil, BindingGenerator bindingGenerator, DirectoryHandler directoryHandler)
        {
            this.springInterfaceGen = springInterfaceGen;
            this.springClassGen = springClassGen;
            this.springConfigGen = springConfigGen;
            this.springViewGen = springViewGen;
            this.generatorUtil = generatorUtil;

            this.bindingGenerator = bindingGenerator;
            this.directoryHandler = directoryHandler;
        }

        public void GenerateServiceImplementations(Namespace ns, List<string> modules, string dataModule, Component component, List<string> dependencies)
        {
            modules.Add(component.Name + "-API");
            BindingTypeHolder bindingsOfModule = new BindingTypeHolder();


            string dataBinding = "";
            foreach (Reference reference in component.References)
            {
                if (reference.Interface is Database)
                {
                    List<Binding> binds = bindingGenerator.GetBindings(ns, reference, reference.Interface);
                    BindingTypeHolder binding = bindingGenerator.CheckForBindings(binds);
                    if (binding.HasRestBinding)
                        dataBinding = "Rest";
                    else if (binding.HasWebServiceBinding)
                        dataBinding = "WebService";
                    else if (binding.HasWebSocketBinding)
                        dataBinding = "WebSocket";
                }
            }

            // TODO collect repo interfaces!
            foreach (Service service in component.Services)
            {
                Interface iface = service.Interface;

                Console.WriteLine(component.Name + ": " + service.Interface.Name);

                //if (iface is Database) { continue; } //handle very differently

                // interface goes to API
                string apiIfDirectory = directoryHandler.createJavaDirectory(ns, component.Name + "-API", generatorUtil.Properties.interfacePackage);
                string interfaceFileName = Path.Combine(apiIfDirectory, iface.Name + ".java");
                using (StreamWriter writer = new StreamWriter(interfaceFileName))
                {
                    writer.WriteLine(springInterfaceGen.GenerateInterface(iface, ""));
                }

                // implementaton goes to component
                string functionDirectory = directoryHandler.createJavaDirectory(ns, component.Name, component.Name.ToLower());
                string javaFileName = Path.Combine(functionDirectory, iface.Name + "Impl.java");
                using (StreamWriter writer = new StreamWriter(javaFileName))
                {
                    writer.WriteLine(springInterfaceGen.GenerateInterfaceImplementation(iface, component.Name.ToLower(), dataBinding));
                }

                List<Binding> bindings = bindingGenerator.GetBindings(ns, service, iface);
                BindingTypeHolder bindingsOfService = bindingGenerator.CheckForBindings(bindings);
                CreateBindings(bindingsOfService, component, apiIfDirectory, functionDirectory, iface);

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
                if (component.Name == dataModule)
                {
                    // TODO think it through (what is needed in data-api pom, where do i generate it, etc)
                    writer.WriteLine(springConfigGen.GenerateDataPom(ns, component.Name + "-API"));
                }
                else
                {
                    apiDependencies.Remove(dataModule);
                    apiDependencies.Remove(dataModule + "-API");
                    Component c = new ComponentImpl();
                    c.Name = component.Name + "-API";
                    string s = springConfigGen.GenerateComponentPom(ns, c, dependencies,
                        bindingsOfModule.HasRestBinding, bindingsOfModule.HasWebServiceBinding, bindingsOfModule.HasWebSocketBinding, ComponentType.API);
                    writer.WriteLine(s);
                }
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
                    writer.WriteLine(springViewGen.GenerateAppCtx(ns, dependencies.Contains(dataModule))); // FIXME hasDirectDataLink
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
                //if (reference.Interface is Database)
                //{
                //    continue;
                //}
                List<Binding> binds = bindingGenerator.GetBindings(ns, reference, reference.Interface);
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

        public void CreateBindings(BindingTypeHolder bindings, Component component, string apiDirectory, string functionDirectory, Interface iface)
        {
            if (bindings.HasRestBinding)
            {
                // interface extension goes to API
                string interfaceExtFileName = Path.Combine(apiDirectory, iface.Name + "Rest.java");
                using (StreamWriter writer = new StreamWriter(interfaceExtFileName))
                {
                    writer.WriteLine(springInterfaceGen.GenerateInterface(iface, "Rest"));
                }

                // implementation of the above goes to component
                string implFileName = Path.Combine(functionDirectory, iface.Name + "RestImpl.java");
                using (StreamWriter writer = new StreamWriter(implFileName))
                {
                    writer.WriteLine(springInterfaceGen.GenerateProxyInterfaceImplementation(iface, component.Name.ToLower(), "Rest"));
                }
            }

            if (bindings.HasWebServiceBinding)
            {
                // interface extension goes to API
                string interfaceExtFileName = Path.Combine(apiDirectory, iface.Name + "WebService.java");
                using (StreamWriter writer = new StreamWriter(interfaceExtFileName))
                {
                    writer.WriteLine(springInterfaceGen.GenerateInterface(iface, "WebService"));
                }

                // implementation of the above goes to component
                string implFileName = Path.Combine(functionDirectory, iface.Name + "WebServiceImpl.java");
                using (StreamWriter writer = new StreamWriter(implFileName))
                {
                    writer.WriteLine(springInterfaceGen.GenerateProxyInterfaceImplementation(iface, component.Name.ToLower(), "WebService"));
                }
            }

            if (bindings.HasWebSocketBinding)
            {
                // interface extension goes to API
                string interfaceExtFileName = Path.Combine(apiDirectory, iface.Name + "WebSocket.java");
                using (StreamWriter writer = new StreamWriter(interfaceExtFileName))
                {
                    writer.WriteLine(springInterfaceGen.GenerateInterface(iface, "WebSocket"));
                }

                // implementation of the above goes to component
                string implFileName = Path.Combine(functionDirectory, iface.Name + "WebSocketImpl.java");
                using (StreamWriter writer = new StreamWriter(implFileName))
                {
                    writer.WriteLine(springInterfaceGen.GenerateProxyInterfaceImplementation(iface, component.Name.ToLower(), "WebSocket"));
                }
            }
        }

    }
}
