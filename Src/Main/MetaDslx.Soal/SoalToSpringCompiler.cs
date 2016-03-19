using MetaDslx.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Soal
{
    public class SoalToSpringCompiler : SoalCompilerBase
    {
        private string mvnDir;

        public SoalToSpringCompiler(string source, string outputDirectory, string fileName)
            : base(source, fileName)
        {
            this.GlobalScope.BuiltInEntries.Add((ModelObject)SoalInstance.Object);
            this.GlobalScope.BuiltInEntries.Add((ModelObject)SoalInstance.String);
            this.GlobalScope.BuiltInEntries.Add((ModelObject)SoalInstance.Int);
            this.GlobalScope.BuiltInEntries.Add((ModelObject)SoalInstance.Long);
            this.GlobalScope.BuiltInEntries.Add((ModelObject)SoalInstance.Float);
            this.GlobalScope.BuiltInEntries.Add((ModelObject)SoalInstance.Double);
            this.GlobalScope.BuiltInEntries.Add((ModelObject)SoalInstance.Byte);
            this.GlobalScope.BuiltInEntries.Add((ModelObject)SoalInstance.Bool);
            this.GlobalScope.BuiltInEntries.Add((ModelObject)SoalInstance.Void);
            this.GlobalScope.BuiltInEntries.Add((ModelObject)SoalInstance.Date);
            this.GlobalScope.BuiltInEntries.Add((ModelObject)SoalInstance.Time);
            this.GlobalScope.BuiltInEntries.Add((ModelObject)SoalInstance.DateTime);
            this.GlobalScope.BuiltInEntries.Add((ModelObject)SoalInstance.TimeSpan);
        }

        protected override void DoCompile()
        {
            base.DoCompile();
            if (!this.Diagnostics.HasErrors())
            {
                this.PrepareGeneration();
                if (!this.Diagnostics.HasErrors())
                {
                    this.Generate();
                }
            }
        }

        private void PrepareGeneration()
        {
            //standard maven path
            this.mvnDir = Path.Combine("src", "main", "java");

            HashSet<string> prefixes = new HashSet<string>();
            prefixes.Add("xs");
            prefixes.Add("wsdl");
            prefixes.Add("soap");
            prefixes.Add("soap12");
            prefixes.Add("wsp");
            prefixes.Add("wsu");
            prefixes.Add("wsoma");
            prefixes.Add("wsam");
            prefixes.Add("wsaw");
            prefixes.Add("wsrmp");
            prefixes.Add("wsat");
            prefixes.Add("sp");
            prefixes.Add("wst");
            prefixes.Add("wsx");
            int prefixCounter = 0;
            var namespaces = this.Data.GetSymbols().OfType<Namespace>().ToList();
            foreach (var ns in namespaces)
            {
                Dictionary<string, List<ModelObject>> typeNames = new Dictionary<string, List<ModelObject>>();
                if (ns.Uri != null)
                {
                    if (ns.Prefix == null || prefixes.Contains(ns.Prefix))
                    {
                        while (prefixes.Contains("ns" + prefixCounter)) ++prefixCounter;
                        ns.Prefix = "ns" + prefixCounter;
                    }
                    foreach (var decl in ns.Declarations)
                    {
                        Interface intf = decl as Interface;
                        if (intf != null)
                        {
                            foreach (var op in intf.Operations)
                            {
                                string key = op.Name;
                                List<ModelObject> symbols = null;
                                if (!typeNames.TryGetValue(key, out symbols))
                                {
                                    symbols = new List<ModelObject>();
                                    typeNames.Add(key, symbols);
                                }
                                symbols.Add((ModelObject)op);
                                key = op.Name + "Response";
                                symbols = null;
                                if (!typeNames.TryGetValue(key, out symbols))
                                {
                                    symbols = new List<ModelObject>();
                                    typeNames.Add(key, symbols);
                                }
                            }
                        }
                        Struct stype = decl as Struct;
                        if (stype != null)
                        {
                            string key = stype.GetJavaName();
                            List<ModelObject> symbols = null;
                            if (!typeNames.TryGetValue(key, out symbols))
                            {
                                symbols = new List<ModelObject>();
                                typeNames.Add(key, symbols);
                            }
                            symbols.Add((ModelObject)stype);
                        }
                        Enum etype = decl as Enum;
                        if (etype != null)
                        {
                            string key = etype.GetJavaName();
                            List<ModelObject> symbols = null;
                            if (!typeNames.TryGetValue(key, out symbols))
                            {
                                symbols = new List<ModelObject>();
                                typeNames.Add(key, symbols);
                            }
                            symbols.Add((ModelObject)etype);
                        }
                    }
                    foreach (var key in typeNames.Keys)
                    {
                        List<ModelObject> symbols = typeNames[key];
                        if (symbols.Count > 1)
                        {
                            foreach (var symbol in symbols)
                            {
                                this.Diagnostics.AddError("Java type named '" + key + "' is defined multiple times.", this.FileName, symbol);
                            }
                        }
                    }
                }
            }
        }


        private void Generate()
        {
            var namespaces = this.Data.GetSymbols().OfType<Namespace>().ToList();
            foreach (var ns in namespaces)
            {
                // final path: Path.Combine(this.OutputDirectory, projectDir, mvnDir, innerDir);

                // defined namespace
                List<string> innerPath = new List<string>();
                foreach (string nameSegment in ns.FullName.ToLower().Split('.')) {
                    innerPath.Add(nameSegment);
                }
                string innerDir = Path.Combine(innerPath.ToArray());

                //string componentDir = Path.Combine(mvnDir, innerDir);

                SpringClassGenerator springClassGen = new SpringClassGenerator(ns);
                SpringInterfaceGenerator springInterfaceGen = new SpringInterfaceGenerator(ns);
                SpringConfigurationGenerator springConfigGen = new SpringConfigurationGenerator(ns);
                SpringGeneratorUtil generatorUtil = new SpringGeneratorUtil(ns);
                //generatorUtil.Properties.entityPackage = "asdasd";

                if (ns.Uri != null)
                {
                    List<Struct> entities = new List<Struct>();
                    List<string> modules = new List<string>();
                    string dataModule = "";

                    foreach (Component component in ns.Declarations.OfType<Component>())
                    {
                        foreach (Service service in component.Services)
                        {
                            if (service.Interface is Database)
                            {
                                if (dataModule != "")
                                {
                                    Console.WriteLine("Multiple data components are not allowed.");
                                    return;
                                }
                                dataModule = component.Name;
                            }
                        }
                    }

                    foreach (Database db in ns.Declarations.OfType<Database>())
                    {
                        entities.AddRange(db.Entities);
                    }

                    if (entities.Any() || ns.Declarations.OfType<Enum>().Any())
                    {
                        modules.Add("Model");
                        GenerateModelModule(ns, entities, innerDir, springClassGen, springConfigGen, generatorUtil);
                    }

                    List<Wire> wires = new List<Wire>();

                    foreach (Composite comppsoite in ns.Declarations.OfType<Composite>())
                    {
                        foreach (Wire wire in comppsoite.Wires)
                        {
                            wires.Add(wire);
                        }
                    }

                    foreach (Component component in ns.Declarations.OfType<Component>())
                    {
                        modules.Add(component.Name);
                        List<string> dependencies = new List<string>();

                        // collecting module dependencies
                        foreach (Reference reference in component.References)
                        {
                            foreach (Wire wire in wires)
                            {
                                if (wire.Source.Equals(reference))
                                {
                                    foreach (Component comp in ns.Declarations.OfType<Component>())
                                    {
                                        foreach (Service serv in comp.Services)
                                        {
                                            if (wire.Target.Equals(serv))
                                            {
                                                if (!dependencies.Contains(comp.Name))
                                                {
                                                    dependencies.Add(comp.Name);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }

                        if (component.Services.Any())
                        {
                            GenerateServiceImplementations(ns, innerDir, springInterfaceGen, springClassGen, springConfigGen, generatorUtil, modules, dataModule, component, dependencies);
                        }
                        else
                        {
                            if (component.Implementation != null && component.Implementation.Name.Equals("JSF"))
                            {
                                // generate web tier
                                Console.WriteLine("web tier: "+component.Name);
                            }
                            if (component is Composite)
                            {
                                string facadeDir = createDirectory(ns.Name, component.Name, innerDir, generatorUtil.Properties.serviceFacadePackage);
                                string facadeFile = Path.Combine(facadeDir, component.Name+"Facade.java");
                                using (StreamWriter writer = new StreamWriter(facadeFile))
                                {
                                    writer.WriteLine(springClassGen.GenerateComponent(component));
                                }
                            }
                        }

                        if (component.Services.Any())
                        {
                            dependencies.Add(component.Name + "-API");
                        }

                        // generate pom.xml and spring-config.xml
                        if (component.Name != dataModule)
                        {
                            // if uses DB TODO
                            dependencies.Add(dataModule+"-API");
                        }
                        else
                        {
                            GenerateDataModule(ns, component, innerDir, springClassGen, springConfigGen, generatorUtil, springInterfaceGen, entities, modules);
                        }

                        createDirectory(ns.Name, component.Name, "", "");
                        string fileName = Path.Combine(ns.Name + "-" + component.Name, "pom.xml");
                        using (StreamWriter writer = new StreamWriter(fileName))
                        {
                            // bindingsOfModule.HasRestBinding, bindingsOfModule.HasWebServiceBinding, bindingsOfModule.HasWebSocketBinding
                            string s = springConfigGen.generateComponentPom(ns, component.Name, dependencies, false, false, false);
                            writer.WriteLine(s);
                        }

                        fileName = Path.Combine(ns.Name + "-" + component.Name, this.mvnDir, "spring-config.xml");
                        using (StreamWriter writer = new StreamWriter(fileName))
                        {
                            writer.WriteLine(springConfigGen.generateComponentSpringConfig(ns));
                        }
                    }

                    // generate master pom.xml
                    if (modules.Any())
                    {
                        string myDirectory = "";
                        string fileName = Path.Combine(myDirectory, "pom.xml");
                        using (StreamWriter writer = new StreamWriter(fileName))
                        {
                            writer.WriteLine(springConfigGen.generateMasterPom(ns, modules));
                        }
                    }
                }
            }
        }

        private void GenerateDataModule(Namespace ns, Component component, string innerDir, SpringClassGenerator springClassGen,
            SpringConfigurationGenerator springConfigGen, SpringGeneratorUtil generatorUtil, SpringInterfaceGenerator springInterfaceGen,
            List<Struct> entities, List<string> modules)
        {
            //pom.xml
            createDirectory(ns.Name, component.Name, "", "");
            string filename = Path.Combine(ns.Name + "-" + component.Name, "pom.xml");
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine(springConfigGen.generateDataPom(ns, component.Name));
            }

            filename = Path.Combine(ns.Name + "-" + component.Name, this.mvnDir, "spring-config.xml");
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine(springConfigGen.generateDataSpringConfig(ns));
            }

            Service dbService = null;
            foreach (Service s in component.Services)
            {
                if (s.Interface is Database)
                {
                    dbService = s;
                }
            }
            BindingTypeHolder bindings = CheckForBindings(ns, dbService, dbService.Interface);

            //entities
            foreach (Struct entity in entities)
            {
                // repository TODO bindings
                string repoDirectory = createDirectory(ns.Name, component.Name + "-API", innerDir, generatorUtil.Properties.repositoryPackage);
                string javaFileName = Path.Combine(repoDirectory, entity.Name + "Repository.java");
                using (StreamWriter writer = new StreamWriter(javaFileName))
                {
                    writer.WriteLine(springClassGen.GenerateRepository(entity));
                }

                string apiDirectory = createDirectory(ns.Name, component.Name + "-API", innerDir, generatorUtil.Properties.interfacePackage);
                string functionDirectory = createDirectory(ns.Name, component.Name, innerDir, generatorUtil.Properties.repositoryPackage);


                if (bindings.HasRestBinding)
                {
                    // interface copy goes to API
                    string interfaceExtFileName = Path.Combine(apiDirectory, entity.Name + "RepositoryRest.java");
                    using (StreamWriter writer = new StreamWriter(interfaceExtFileName))
                    {
                        writer.WriteLine(springInterfaceGen.GenerateCrudRepositoryCopy(ns.FullName, entity.Name, "Rest"));
                    }

                    // implementation of the above goes to component
                    string implFileName = Path.Combine(functionDirectory, entity.Name + "RepositoryRestImpl.java");
                    using (StreamWriter writer = new StreamWriter(implFileName))
                    {
                        writer.WriteLine(springInterfaceGen.GenerateRepositoryProxyImpl(ns.FullName, entity.Name, "Rest"));
                    }
                }

                if (bindings.HasWebServiceBinding)
                {
                    // interface extension goes to API
                    string interfaceExtFileName = Path.Combine(apiDirectory, entity.Name + "RepositoryWebService.java");
                    using (StreamWriter writer = new StreamWriter(interfaceExtFileName))
                    {
                        writer.WriteLine(springInterfaceGen.GenerateCrudRepositoryCopy(ns.FullName, entity.Name, "WebService"));
                    }

                    // implementation of the above goes to component
                    string implFileName = Path.Combine(functionDirectory, entity.Name + "RepositoryWebServiceImpl.java");
                    using (StreamWriter writer = new StreamWriter(implFileName))
                    {
                        writer.WriteLine(springInterfaceGen.GenerateRepositoryProxyImpl(ns.FullName, entity.Name, "WebService"));
                    }
                }

                if (bindings.HasWebSocketBinding)
                {
                    // interface extension goes to API
                    string interfaceExtFileName = Path.Combine(apiDirectory, entity.Name + "RepositoryWebSocket.java");
                    using (StreamWriter writer = new StreamWriter(interfaceExtFileName))
                    {
                        writer.WriteLine(springInterfaceGen.GenerateCrudRepositoryCopy(ns.FullName, entity.Name, "WebSocket"));
                    }

                    // implementation of the above goes to component
                    string implFileName = Path.Combine(functionDirectory, entity.Name + "RepositoryWebSocketImpl.java");
                    using (StreamWriter writer = new StreamWriter(implFileName))
                    {
                        writer.WriteLine(springInterfaceGen.GenerateRepositoryProxyImpl(ns.FullName, entity.Name, "WebSocket"));
                    }
                }
            }
             
        }

        private void GenerateModelModule(Namespace ns, List<Struct> entities, string innerDir, SpringClassGenerator springClassGen,
            SpringConfigurationGenerator springConfigGen, SpringGeneratorUtil generatorUtil)
        {
            createDirectory(ns.Name, "Model", "", "");
            //pom.xml
            string filename = Path.Combine(ns.Name + "-Model", "pom.xml");
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine(springConfigGen.generateDataPom(ns, "Model"));
            }

            // generate persistence.xml
            if (entities.Any())
            {
                string metaFolder = Path.Combine(ns.Name + "-Model", "src", "main", "resources", "META - INF");
                Directory.CreateDirectory(metaFolder);
                filename = Path.Combine(metaFolder, "persistence.xml");
                using (StreamWriter writer = new StreamWriter(filename))
                {
                    writer.WriteLine(springConfigGen.GeneratePersistence(ns, entities));
                }
            }

            //entities
            foreach (Struct entity in entities)
            {
                // entity
                string entityDirectory = createDirectory(ns.Name, "Model", innerDir, generatorUtil.Properties.entityPackage);
                string javaFileName = Path.Combine(entityDirectory, entity.Name + ".java");

                using (StreamWriter writer = new StreamWriter(javaFileName))
                {
                    writer.WriteLine(springClassGen.GenerateEntity(entity));
                }
            }

            //enums
            foreach (Enum myEnum in ns.Declarations.OfType<Enum>())
            {
                string enumDirectory = createDirectory(ns.Name, "Model", innerDir, generatorUtil.Properties.enumPackage);
                string javaFileName = Path.Combine(enumDirectory, myEnum.Name + ".java");

                using (StreamWriter writer = new StreamWriter(javaFileName))
                {
                    writer.WriteLine(springClassGen.GenerateEnum(myEnum));

                }
            }
        }

        private void GenerateServiceImplementations(Namespace ns, string innerDir,
            SpringInterfaceGenerator springInterfaceGen, SpringClassGenerator springClassGen,
            SpringConfigurationGenerator springConfigGen, SpringGeneratorUtil generatorUtil,
            List<string> modules, string dataModule, Component component, List<string> dependencies)
        {
            modules.Add(component.Name + "-API");
            BindingTypeHolder bindingsOfModule = new BindingTypeHolder();

            // TODO collect repo interfaces!
            foreach (Service service in component.Services)
            {
                Interface iface = service.Interface;

                if (iface is Database) { continue; } //handle very differently

                // interface goes to API
                string apiIfDirectory = createDirectory(ns.Name, component.Name + "-API", innerDir, generatorUtil.Properties.interfacePackage);
                string interfaceFileName = Path.Combine(apiIfDirectory, iface.Name + ".java");
                using (StreamWriter writer = new StreamWriter(interfaceFileName))
                {
                    writer.WriteLine(springInterfaceGen.GenerateInterface(iface, ""));
                }

                // implementaton goes to component
                string functionDirectory = createDirectory(ns.Name, component.Name, innerDir, component.Name.ToLower());
                string javaFileName = Path.Combine(functionDirectory, iface.Name + "Impl.java");
                using (StreamWriter writer = new StreamWriter(javaFileName))
                {
                    writer.WriteLine(springInterfaceGen.GenerateInterfaceImplementation(iface, component.Name.ToLower()));
                }

                BindingTypeHolder bindingsOfService = CheckForBindings(ns, service, iface);
                CreateBindings(bindingsOfService, springInterfaceGen, component, apiIfDirectory, functionDirectory, iface);

                bindingsOfModule.HasRestBinding         |= bindingsOfService.HasRestBinding;
                bindingsOfModule.HasWebServiceBinding   |= bindingsOfService.HasWebServiceBinding;
                bindingsOfModule.HasWebSocketBinding    |= bindingsOfService.HasWebSocketBinding;

                foreach (Operation op in iface.Operations)
                {
                    foreach(Struct exception in op.Exceptions)
                    {
                        string apiExDirectory = createDirectory(ns.Name, component.Name + "-API", innerDir, generatorUtil.Properties.exceptionPackage);
                        string exFileName = Path.Combine(apiExDirectory, exception.Name + ".java");
                        using (StreamWriter writer = new StreamWriter(exFileName))
                        {
                            writer.WriteLine(springClassGen.GenerateException(exception));
                        }
                    }
                }
            }

            // pom.xml of API
            dependencies.Add("Model");
            createDirectory(ns.Name, component.Name + "-API", "", "");
            string fileName = Path.Combine(ns.Name + "-" + component.Name + "-API", "pom.xml");
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                if (component.Name == dataModule)
                {
                    writer.WriteLine(springConfigGen.generateDataPom(ns, component.Name + "-API")); // TODO think it through
                }
                else
                {
                    string s = springConfigGen.generateComponentPom(ns, component.Name + "-API", dependencies,
                        bindingsOfModule.HasRestBinding, bindingsOfModule.HasWebServiceBinding, bindingsOfModule.HasWebSocketBinding);
                    writer.WriteLine(s);
                }
            }
            dependencies.Remove("Model");
        }

        private static void CreateBindings(BindingTypeHolder bindings, SpringInterfaceGenerator springInterfaceGen,
            Component component, string apiDirectory, string functionDirectory, Interface iface)
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

        private static BindingTypeHolder CheckForBindings(Namespace ns, Service service, Interface iface)
        {
            BindingTypeHolder bindings = new BindingTypeHolder();
            foreach (Binding binding in GetBindings(ns, service, iface))
            {
                if (binding.Transport is RestTransportBindingElement)
                {
                    bindings.HasRestBinding = true;
                }
                else if (binding.Transport is WebSocketTransportBindingElement)
                {
                    bindings.HasWebSocketBinding = true;
                }
                else
                {
                    foreach (EncodingBindingElement encoding in binding.Encodings)
                    {
                        if (encoding is SoapEncodingBindingElement)
                        {
                            bindings.HasWebServiceBinding = true;
                        }
                    }
                }
            }

            return bindings;
        }

        private static List<Binding> GetBindings(Namespace ns, Service service, Interface iface)
        {
            HashSet<Binding> bindings = new HashSet<Binding>();

            if (service.Binding != null)
            {
                bindings.Add(service.Binding);
            }

            foreach (Composite composite in ns.Declarations.OfType<Composite>())
            {
                foreach (Wire wire in composite.Wires)
                {
                    Port port = null;
                    if (wire.Source.Equals(service))
                    {
                        port = wire.Target;
                    }
                    if (wire.Target.Equals(service))
                    {
                        port = wire.Source;
                    }
                    if (port != null)
                    {
                        if (port.Binding != null)
                        {
                            bindings.Add(port.Binding);
                        }
                    }
                }
            }

            foreach (Component component in ns.Declarations.OfType<Component>())
            {
                foreach (Reference reference in component.References)
                {
                    if (reference.Interface.Equals(iface))              
                    {
                        if (reference.Binding != null)
                        {                          
                            bindings.Add(reference.Binding);
                        }
                    }
                }
            }

            return new List<Binding>(bindings);
        }

        private string createDirectory(string namespaceName, string projectSuffix, string innerDir, string subDir)
        {
            string projectDir = "";
            if (projectSuffix != null)
                projectDir = namespaceName + "-" + projectSuffix;
            else
                projectDir = namespaceName;

            string directory = Path.Combine(projectDir, this.mvnDir, innerDir, subDir);
            //string directory = Path.Combine(projectDir, subDir); // TODO change

            Directory.CreateDirectory(directory);

            return directory;
        }
    }
}
