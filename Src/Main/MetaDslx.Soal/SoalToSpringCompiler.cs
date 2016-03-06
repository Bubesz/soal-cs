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
        public static Namespace XsdNamespace;

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

            this.SeparateXsdWsdl = false;
            this.SingleFileWsdl = false;
        }

        protected override void DoCompile()
        {
            XsdNamespace = SoalFactory.Instance.CreateNamespace();
            XsdNamespace.Prefix = "xs";
            XsdNamespace.Uri = "http://www.w3.org/2001/XMLSchema";
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

        public bool SeparateXsdWsdl { get; set; }
        public bool SingleFileWsdl { get; set; }

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
            foreach (var ns in namespaces)
            {
                if (ns.Uri != null)
                {
                    foreach (var decl in ns.Declarations)
                    {
                        Interface intf = decl as Interface;
                        if (intf != null)
                        {
                            foreach (var op in intf.Operations)
                            {
                                this.CheckXsdNamespace(op.Result.Type, (ModelObject)op);
                                foreach (var param in op.Parameters)
                                {
                                    this.CheckXsdNamespace(param.Type, (ModelObject)param);
                                }
                            }
                        }
                        Struct stype = decl as Struct;
                        if (stype != null)
                        {
                            foreach (var prop in stype.Properties)
                            {
                                this.CheckXsdNamespace(prop.Type, (ModelObject)prop);
                            }
                        }
                    }
                }
            }
        }

        private void CheckXsdNamespace(SoalType type, ModelObject symbol)
        {
            if (!type.HasXsdNamespace())
            {
                this.Diagnostics.AddError("The type of this element has no XSD namespace.", this.FileName, symbol);
            }
        }


        private void Generate()
        {
            if (this.SingleFileWsdl)
            {
                this.SeparateXsdWsdl = false;
            }


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
                    List<Struct> exceptions = new List<Struct>();
                    List<string> modules = new List<string>();
                    string dataModule = "Data";

                    foreach (Component component in ns.Declarations.OfType<Component>())
                    {
                        if (component.Services.OfType<Database>().Any())
                            dataModule = component.Name;
                    }

                    foreach (Database db in ns.Declarations.OfType<Database>())
                    {
                        entities.AddRange(db.Entities);
                    }

                    foreach (Struct exception in ns.Declarations.OfType<Struct>())
                    {
                        if (exception.IsException())
                        {
                            exceptions.Add(exception);
                        }
                    }

                    // Commons module
                    if (exceptions.Any())
                    {
                        string module = "Commons";
                        modules.Add(module);

                        foreach (Struct exception in exceptions)
                        {
                            string exceptionDirectory = createDirectory(ns.Name, module, innerDir, generatorUtil.Properties.exceptionPackage);
                            string javaFileName = Path.Combine(exceptionDirectory, exception.Name + ".java");
                            using (StreamWriter writer = new StreamWriter(javaFileName))
                            {
                                writer.WriteLine(springClassGen.GenerateException(exception));
                            }
                        }

                        // pom.xml and spring.config.xml for Commons module
                        string fileName = Path.Combine(ns.Name + "-"+module, "pom.xml");
                        using (StreamWriter writer = new StreamWriter(fileName))
                        {
                            List<string> dependencies = new List<string>();
                            dependencies.Add(dataModule);
                            writer.WriteLine(springConfigGen.generateComponentPom(ns, module, dependencies));
                        }

                        fileName = Path.Combine(ns.Name + "-"+module, this.mvnDir, "spring-config.xml");
                        using (StreamWriter writer = new StreamWriter(fileName))
                        {
                            writer.WriteLine(springConfigGen.generateComponentSpringConfig(ns));
                        }
                    }


                    foreach (Component component in ns.Declarations.OfType<Component>())
                    {
                        modules.Add(component.Name);
                        string apiDirectory = createDirectory(ns.Name, component.Name + "-API", innerDir, generatorUtil.Properties.interfacePackage);
                        List<string> dependencies = new List<string>();

                        if (component.Services.Any())
                        {
                            // TODO collect module dependencies
                            GenerateServiceImplementations(ns, innerDir, springInterfaceGen, springConfigGen, modules, dataModule, component, apiDirectory, dependencies);
                        }

                        // generate pom.xml and spring-config.xml
                        if (component.Name != dataModule)
                        {
                            dependencies.Add("Commons"); // TODO eliminate
                            dependencies.Add(component.Name+"-API");
                            dependencies.Add(dataModule);
                            dependencies.Add(dataModule+"-API");
                        }
                        else
                        {
                            GenerateDataModule(ns, innerDir, springClassGen, springConfigGen, generatorUtil, entities, modules, dataModule);
                        }

                        createDirectory(ns.Name, component.Name, innerDir, "");
                        string fileName = Path.Combine(ns.Name + "-" + component.Name, "pom.xml");
                        using (StreamWriter writer = new StreamWriter(fileName))
                        {
                            writer.WriteLine(springConfigGen.generateComponentPom(ns, component.Name, dependencies));
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

        private void GenerateDataModule(Namespace ns, string innerDir, SpringClassGenerator springClassGen, SpringConfigurationGenerator springConfigGen, SpringGeneratorUtil generatorUtil, List<Struct> entities, List<string> modules, string dataModule)
        {
            //pom.xml
            string filename = Path.Combine(ns.Name + "-" + dataModule, "pom.xml");
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine(springConfigGen.generateDataPom(ns, dataModule, ""));
            }

            filename = Path.Combine(ns.Name + "-" + dataModule, this.mvnDir, "spring-config.xml");
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine(springConfigGen.generateDataSpringConfig(ns));
            }

            //enums
            foreach (Enum myEnum in ns.Declarations.OfType<Enum>())
            {
                string enumDirectory = createDirectory(ns.Name, dataModule, innerDir, generatorUtil.Properties.enumPackage);
                string javaFileName = Path.Combine(enumDirectory, myEnum.Name + ".java");
                if (!modules.Contains(dataModule))
                    modules.Add(dataModule);

                using (StreamWriter writer = new StreamWriter(javaFileName))
                {
                    writer.WriteLine(springClassGen.GenerateEnum(myEnum));
                }
            }

            // generate persistence.xml
            if (entities.Any())
            {
                string metaFolder = Path.Combine(ns.Name + "-" + dataModule, "src", "main", "resources", "META - INF");
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
                string entityDirectory = createDirectory(ns.Name, dataModule, innerDir, generatorUtil.Properties.entityPackage);
                string javaFileName = Path.Combine(entityDirectory, entity.Name + ".java");

                using (StreamWriter writer = new StreamWriter(javaFileName))
                {
                    writer.WriteLine(springClassGen.GenerateEntity(entity));
                }

                // repository TODO bindings
                string repoDirectory = createDirectory(ns.Name, dataModule+"-API", innerDir, generatorUtil.Properties.repositoryPackage);
                javaFileName = Path.Combine(repoDirectory, entity.Name + "Repository.java");
                using (StreamWriter writer = new StreamWriter(javaFileName))
                {
                    writer.WriteLine(springClassGen.GenerateRepository(entity));
                }
            }
        }

        private void GenerateServiceImplementations(Namespace ns, string innerDir, SpringInterfaceGenerator springInterfaceGen, SpringConfigurationGenerator springConfigGen, List<string> modules, string dataModule, Component component, string apiDirectory, List<string> dependencies)
        {
            modules.Add(component.Name + "-API");
            string functionDirectory = createDirectory(ns.Name, component.Name, innerDir, component.Name.ToLower());

            // pom.xml
            dependencies.Add(dataModule);

            string fileName = Path.Combine(ns.Name + "-" + component.Name + "-API", "pom.xml");
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                if (component.Name == dataModule)
                {
                    writer.WriteLine(springConfigGen.generateDataPom(ns, component.Name + "-API", dataModule));
                }
                else
                {
                    writer.WriteLine(springConfigGen.generateComponentPom(ns, component.Name + "-API", dependencies));
                }
            }

            dependencies.Remove(dataModule);

            // TODO collect repo interfaces!
            foreach (Service service in component.Services)
            {
                Interface iface = service.Interface;

                if (iface is Database) { continue; }

                // interface goes to API
                string interfaceFileName = Path.Combine(apiDirectory, iface.Name + ".java");
                using (StreamWriter writer = new StreamWriter(interfaceFileName))
                {
                    writer.WriteLine(springInterfaceGen.GenerateInterface(iface));
                }

                // implementaton goes to component
                string javaFileName = Path.Combine(functionDirectory, iface.Name + "Impl.java");
                using (StreamWriter writer = new StreamWriter(javaFileName))
                {
                    writer.WriteLine(springInterfaceGen.GenerateInterfaceImplementation(iface, component.Name.ToLower()));
                }

                CheckAndCreateBindings(ns, springInterfaceGen, component, apiDirectory, functionDirectory, service, iface);
            }
        }

        private static void CheckAndCreateBindings(Namespace ns, SpringInterfaceGenerator springInterfaceGen, Component component, string apiDirectory, string functionDirectory, Service service, Interface iface)
        {
            List<string> bindings = new List<string>();
            foreach (Binding binding in GetBindings(ns, service, iface))
            {
                if (binding.Transport is RestTransportBindingElement)
                {
                    bindings.Add("Rest");
                    // interface extension goes to API
                    string interfaceExtFileName = Path.Combine(apiDirectory, iface.Name + "Rest.java");
                    using (StreamWriter writer = new StreamWriter(interfaceExtFileName))
                    {
                        writer.WriteLine(springInterfaceGen.GenerateRestInterface(iface));
                    }

                    // implementation of the above goes to component
                    string implFileName = Path.Combine(functionDirectory, iface.Name + "RestImpl.java");
                    using (StreamWriter writer = new StreamWriter(implFileName))
                    {
                        writer.WriteLine(springInterfaceGen.GenerateRestInterfaceImplementation(iface, component.Name.ToLower()));
                    }
                }
                else if (binding.Transport is WebSocketTransportBindingElement)
                {
                    bindings.Add("WebSocket");
                    // interface extension goes to API
                    string interfaceExtFileName = Path.Combine(apiDirectory, iface.Name + "WebSocket.java");
                    using (StreamWriter writer = new StreamWriter(interfaceExtFileName))
                    {
                        writer.WriteLine(springInterfaceGen.GenerateWebSocketInterface(iface));
                    }

                    // implementation of the above goes to component
                    string implFileName = Path.Combine(functionDirectory, iface.Name + "WebSocketImpl.java");
                    using (StreamWriter writer = new StreamWriter(implFileName))
                    {
                        writer.WriteLine(springInterfaceGen.GenerateWebSocketInterfaceImplementation(iface, component.Name.ToLower()));
                    }
                }
                else
                {
                    foreach (EncodingBindingElement encoding in binding.Encodings)
                    {
                        if (encoding is SoapEncodingBindingElement)
                        {
                            bindings.Add("WebService");
                            // interface extension goes to API
                            string interfaceExtFileName = Path.Combine(apiDirectory, iface.Name + "WebService.java");
                            using (StreamWriter writer = new StreamWriter(interfaceExtFileName))
                            {
                                writer.WriteLine(springInterfaceGen.GenerateWebServiceInterface(iface));
                            }

                            // implementation of the above goes to component
                            string implFileName = Path.Combine(functionDirectory, iface.Name + "WebServiceImpl.java");
                            using (StreamWriter writer = new StreamWriter(implFileName))
                            {
                                writer.WriteLine(springInterfaceGen.GenerateWebServiceInterfaceImplementation(iface, component.Name.ToLower()));
                            }
                        }
                    }
                }
            }
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
