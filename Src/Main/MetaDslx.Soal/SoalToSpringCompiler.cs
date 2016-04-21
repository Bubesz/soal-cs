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
        private string mvnJavaDir;
        private string mvnResDir;
        private string mvnWebDir;

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
            this.mvnJavaDir = Path.Combine("src", "main", "java");
            this.mvnResDir = Path.Combine("src", "main", "resources");
            this.mvnWebDir = Path.Combine("src", "main", "webapp");

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
                SpringClassGenerator springClassGen = new SpringClassGenerator(ns);
                SpringInterfaceGenerator springInterfaceGen = new SpringInterfaceGenerator(ns);
                SpringConfigurationGenerator springConfigGen = new SpringConfigurationGenerator(ns);
                SpringViewGenerator springViewGen = new SpringViewGenerator(ns);
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

                    List<Wire> wires = new List<Wire>();

                    foreach (Composite comppsoite in ns.Declarations.OfType<Composite>())
                    {
                        foreach (Wire wire in comppsoite.Wires)
                        {
                            wires.Add(wire);
                        }
                    }

                    Dictionary<string, string> properties = new Dictionary<string, string>();
                    foreach (Component component in ns.Declarations.OfType<Component>())
                    {
                        modules.Add(component.Name);
                        ComponentType cType = ComponentType.IMPLEMENTATION;

                        Dictionary<Reference, Component> dependencyMap = GetherDependencyMap(ns, wires, component);
                        List<string> dependencies = GetherDependencies(dependencyMap);
                        bool directDataAccess = HasDirectDataAccess(ns, wires, component, dataModule);

                        if (component.Services.Any())
                        {
                            GenerateServiceImplementations(ns, springInterfaceGen, springClassGen, springConfigGen, springViewGen, generatorUtil, modules, dataModule, component, dependencies);
                        }
                        else
                        {
                            if (component.Implementation != null && component.Implementation.Name.Equals("JSF"))
                            {
                                cType = ComponentType.WEB;
                                GenerateWebTier(ns, springViewGen, generatorUtil, component, directDataAccess);
                            }
                            if (component is Composite)
                            {
                                string facadeDir = createJavaDirectory(ns, component.Name, generatorUtil.Properties.serviceFacadePackage);
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
                            clientFor = GenerateReferenceAccessors(ns, component, dependencyMap, properties, springInterfaceGen, generatorUtil);
                        }

                        if (component.Name == dataModule)
                        {
                            GenerateDataModule(ns, component, springClassGen, springConfigGen, generatorUtil, springInterfaceGen, entities, modules);
                        }

                        // generate pom.xml and spring-config.xml
                        createJavaDirectory(ns, component.Name, "");
                        string fileName = Path.Combine(ns.Name + "-" + component.Name, "pom.xml");
                        using (StreamWriter writer = new StreamWriter(fileName))
                        {
                            string s = springConfigGen.GenerateComponentPom(ns, component, dependencies,
                                clientFor.HasRestBinding, clientFor.HasWebServiceBinding, clientFor.HasWebSocketBinding, cType);
                            writer.WriteLine(s);
                        }

                        fileName = Path.Combine(ns.Name + "-" + component.Name, this.mvnJavaDir, "spring-config.xml");
                        using (StreamWriter writer = new StreamWriter(fileName))
                        {
                            writer.WriteLine(springConfigGen.GenerateComponentSpringConfig(ns));
                        }
                    }

                    if (entities.Any() || ns.Declarations.OfType<Enum>().Any())
                    {
                        modules.Add("Model");
                        GenerateModelModule(ns, entities, properties, springClassGen, springConfigGen, generatorUtil);
                    }

                    // generate master pom.xml
                    if (modules.Any())
                    {
                        using (StreamWriter writer = new StreamWriter("pom.xml"))
                        {
                            writer.WriteLine(springConfigGen.GenerateMasterPom(ns, modules));
                        }
                    }
                }
            }
        }

        private bool HasDirectDataAccess(Namespace ns, List<Wire> wires, Component component, string dataModule)
        {
            // collecting module dependencies
            bool hasDirectDataAccess = false;
            foreach (Reference reference in component.References)
            {
                if (hasDirectDataAccess) // stop algorithm if found a direct access
                {
                    return true;
                }

                bool referenceStatisfied = false;
                foreach (Wire wire in wires)
                {
                    // Component comp = (Component)((ModelObject)port).MParent;
                    if (wire.Source.Equals(reference))
                    {
                        foreach (Component comp in ns.Declarations.OfType<Component>())
                        {
                            foreach (Service serv in comp.Services)
                            {
                                if (wire.Target.Equals(serv))
                                {
                                    referenceStatisfied = true;
                                    hasDirectDataAccess = CheckDirectDataAccess(ns, wires, dataModule, reference, comp, serv);
                                }
                            }
                        }
                    }
                }
                if (!referenceStatisfied)
                {
                    foreach (Component comp in ns.Declarations.OfType<Component>())
                    {
                        foreach (Service serv in comp.Services)
                        {
                            if (serv.Interface.Equals(reference.Interface))
                            {
                                hasDirectDataAccess = CheckDirectDataAccess(ns, wires, dataModule, reference, comp, serv);
                            }
                        }
                    }
                }
            }
            return hasDirectDataAccess;
        }

        private bool CheckDirectDataAccess(Namespace ns, List<Wire> wires, string dataModule, Reference reference, Component comp, Service serv)
        {
            bool hasDirectDataAccess = false;
            List<Binding> bindings = new List<Binding>();
            if (serv.Binding != null)
                bindings.Add(serv.Binding);
            if (reference.Binding != null)
                bindings.Add(reference.Binding);
            BindingTypeHolder binding = CheckForBindings(bindings);

            if (!binding.hasAnyBinding())
            {
                // direct access
                if (comp.Name == dataModule)
                {
                    hasDirectDataAccess = true;
                }
                else
                {
                    // need to check
                    hasDirectDataAccess = HasDirectDataAccess(ns, wires, comp, dataModule);
                }
            }

            return hasDirectDataAccess;
        }

        private List<string> GetherDependencies(Dictionary<Reference, Component> dependecyMap)
        {
            // collecting module dependencies
            List<string> dependencies = new List<string>();
            foreach (KeyValuePair<Reference, Component> entry in dependecyMap)
            {
                List<Binding> bindings = new List<Binding>();
                Reference reference = entry.Key;
                Component comp = entry.Value;
                string businessComponentName = comp.Name;
                if (businessComponentName.Contains("-API") || businessComponentName.Contains("-WEB"))
                {
                    businessComponentName = businessComponentName.Split(new string[] { "-API", "-WEB" }, StringSplitOptions.RemoveEmptyEntries)[0];
                }
                foreach (Service service in entry.Value.Services)
                {
                    if (service.Interface.Equals(reference.Interface) && service.Binding != null)
                    {
                        bindings.Add(service.Binding);
                    }
                }
                if (reference.Binding != null)
                    bindings.Add(reference.Binding);
                BindingTypeHolder binding = CheckForBindings(bindings);

                if (binding.hasAnyBinding())
                {
                    if (!dependencies.Contains(businessComponentName + "-API") && !dependencies.Contains(businessComponentName))
                    {
                        dependencies.Add(businessComponentName + "-API");
                    }
                }
                else
                {
                    if (!dependencies.Contains(businessComponentName))
                    {
                        dependencies.Add(businessComponentName);
                        dependencies.Remove(businessComponentName + "-API");
                    }
                }
            }
            return dependencies;
        }

        private Dictionary<Reference, Component> GetherDependencyMap(Namespace ns, List<Wire> wires, Component component)
        {
            // collecting module dependencies
            Dictionary<Reference, Component> dependencies = new Dictionary<Reference, Component>();
            foreach (Reference reference in component.References)
            {
                bool referenceStatisfied = false;
                foreach (Wire wire in wires)
                {
                    // Component comp = (Component)((ModelObject)port).MParent;
                    if (wire.Source.Equals(reference))
                    {
                        foreach (Component comp in ns.Declarations.OfType<Component>())
                        {
                            foreach (Service serv in comp.Services)
                            {
                                if (wire.Target.Equals(serv))
                                {
                                    referenceStatisfied = true;
                                    PutDependecy(dependencies, reference, serv, comp);

                                }
                            }
                        }
                    }
                }
                if (!referenceStatisfied)
                {
                    foreach (Component comp in ns.Declarations.OfType<Component>())
                    {
                        foreach (Service serv in comp.Services)
                        {
                            if (serv.Interface.Equals(reference.Interface))
                            {
                                PutDependecy(dependencies, reference, serv, comp);
                            }
                        }
                    }
                }
            }
            return dependencies;
        }

        private static void PutDependecy(Dictionary<Reference, Component> dependencies, Reference reference, Service serv, Component comp)
        {
            List<Binding> bindings = new List<Binding>();
            if (serv.Binding != null)
                bindings.Add(serv.Binding);
            if (reference.Binding != null)
                bindings.Add(reference.Binding);
            BindingTypeHolder binding = CheckForBindings(bindings);

            Component api = new ComponentImpl();
            api.Name = comp.Name + "-API";

            if (binding.hasAnyBinding())
            {
                dependencies.Add(reference, api);
            }
            else
            {
                dependencies.Add(reference, comp);
            }
        }

        private void GenerateWebTier(Namespace ns, SpringViewGenerator springViewGen, SpringGeneratorUtil generatorUtil, Component component, bool directDataAccess)
        {
            string contollerDir = createJavaDirectory(ns, component.Name, generatorUtil.Properties.controllerPackage);
            string viewDir = createWebDirectory(ns, component.Name, "view");

            // indexController
            string contollerFile = Path.Combine(contollerDir, "IndexController.java");
            using (StreamWriter writer = new StreamWriter(contollerFile))
            {
                writer.WriteLine(springViewGen.GenerateIndexController(ns));
            }

            // index view
            string viewFile = Path.Combine(viewDir, "index.html");
            using (StreamWriter writer = new StreamWriter(viewFile))
            {
                writer.WriteLine(springViewGen.GenerateIndexView(ns));
            }

            List<ViewInfoHolder> views = new List<ViewInfoHolder>();
            foreach (Reference reference in component.References)
            {
                // controllers
                contollerFile = Path.Combine(contollerDir, reference.Name + "Controller.java");
                using (StreamWriter writer = new StreamWriter(contollerFile))
                {
                    writer.WriteLine(springViewGen.GenerateController(reference));
                }

                // views
                viewFile = Path.Combine(viewDir, reference.Name + "View.html");
                using (StreamWriter writer = new StreamWriter(viewFile))
                {
                    writer.WriteLine(springViewGen.GenerateView(reference));
                }

                // list views
                foreach (Operation operation in reference.Interface.Operations)
                {
                    SoalType type = operation.Result.Type;
                    if (type.IsArrayType())
                    {
                        ArrayType array = type as ArrayType;
                        Struct entity = array.InnerType as Struct;
                        if (entity != null)
                        {
                            string actionName = operation.Name;
                            if (actionName.Contains("Get"))
                            {
                                actionName = actionName.Substring(3);
                            }
                            string listFile = Path.Combine(viewDir, actionName + ".html");
                            using (StreamWriter writer = new StreamWriter(listFile))
                            {
                                writer.WriteLine(springViewGen.GenerateListView(entity));
                            }
                        }
                    }
                }

                ViewInfoHolder view = new ViewInfoHolder();
                view.FileName = reference.Name + "View.html";
                string name = reference.Name; // TODO get rid of I, etc
                view.Mapping = name; // TODO mapping separately?
                view.Name = name;
                views.Add(view);
            }

            // master view
            if (views.Any())
            {
                viewDir = createWebDirectory(ns, component.Name, "view");
                viewFile = Path.Combine(viewDir, "_master.html");
                using (StreamWriter writer = new StreamWriter(viewFile))
                {
                    writer.WriteLine(springViewGen.GenerateMasterView(component.Name, views));
                }
            }

            // web.xml
            string webinfDir = createWebDirectory(ns, component.Name, "");
            string webxmlFile = Path.Combine(webinfDir, "web.xml");
            using (StreamWriter writer = new StreamWriter(webxmlFile))
            {
                writer.WriteLine(springViewGen.GenerateWebXml(ComponentType.WEB));
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
                writer.WriteLine(springViewGen.GenerateAppCtx(ns, directDataAccess));
            }

            // servlet
            string servletFile = Path.Combine(webinfDir, "spring-servlet.xml");
            using (StreamWriter writer = new StreamWriter(servletFile))
            {
                writer.WriteLine(springViewGen.GenerateServlet(ns, ComponentType.WEB));
            }
        }

        private void GenerateDataModule(Namespace ns, Component component, SpringClassGenerator springClassGen,
            SpringConfigurationGenerator springConfigGen, SpringGeneratorUtil generatorUtil, SpringInterfaceGenerator springInterfaceGen,
            List<Struct> entities, List<string> modules)
        {
            //pom.xml
            createJavaDirectory(ns, component.Name, "");
            string filename = Path.Combine(ns.Name + "-" + component.Name, "pom.xml");
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine(springConfigGen.GenerateDataPom(ns, component.Name));
            }

            Service dbService = null;
            foreach (Service s in component.Services)
            {
                if (s.Interface is Database)
                {
                    dbService = s;
                }
            }
            List<Binding> binds = GetBindings(ns, dbService, dbService.Interface);
            BindingTypeHolder bindings = CheckForBindings(binds);

            //entities
            foreach (Struct entity in entities)
            {
                // repository TODO bindings
                string repoDirectory = createJavaDirectory(ns, component.Name + "-API", generatorUtil.Properties.repositoryPackage);
                string javaFileName = Path.Combine(repoDirectory, entity.Name + "Repository.java");
                using (StreamWriter writer = new StreamWriter(javaFileName))
                {
                    writer.WriteLine(springClassGen.GenerateRepository(entity));
                }

                string apiDirectory = createJavaDirectory(ns, component.Name + "-API", generatorUtil.Properties.interfacePackage);
                string functionDirectory = createJavaDirectory(ns, component.Name, generatorUtil.Properties.repositoryPackage);


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
                    // interface copy goes to API
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
                    // interface copy goes to API
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

        private void GenerateModelModule(Namespace ns, List<Struct> entities, Dictionary<string, string> properties,
            SpringClassGenerator springClassGen, SpringConfigurationGenerator springConfigGen, SpringGeneratorUtil generatorUtil)
        {
            string baseJavaDir = createJavaDirectory(ns, "Model", "");
            //pom.xml
            string filename = Path.Combine(ns.Name + "-Model", "pom.xml");
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine(springConfigGen.GenerateDataPom(ns, "Model"));
            }

            // generate persistence.xml
            if (entities.Any())
            {
                string metaFolder = Path.Combine(ns.Name + "-Model", "src", "main", "resources", "META-INF");
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
                string entityDirectory = createJavaDirectory(ns, "Model", generatorUtil.Properties.entityPackage);
                string javaFileName = Path.Combine(entityDirectory, entity.Name + ".java");

                using (StreamWriter writer = new StreamWriter(javaFileName))
                {
                    writer.WriteLine(springClassGen.GenerateEntity(entity));
                }
            }

            //enums
            foreach (Enum myEnum in ns.Declarations.OfType<Enum>())
            {
                string enumDirectory = createJavaDirectory(ns, "Model", generatorUtil.Properties.enumPackage);
                string javaFileName = Path.Combine(enumDirectory, myEnum.Name + ".java");

                using (StreamWriter writer = new StreamWriter(javaFileName))
                {
                    writer.WriteLine(springClassGen.GenerateEnum(myEnum));

                }
            }

            // manual config
            string dir = createResourceDirectory(ns, "Model", "");
            filename = Path.Combine(dir, "configuration.properties");
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine(springConfigGen.GenerateConfig(properties));
            }

            filename = Path.Combine(baseJavaDir, "Configuration.java");
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine(springConfigGen.GenerateConfigClass(ns));
            }
        }

        private void GenerateServiceImplementations(Namespace ns,
            SpringInterfaceGenerator springInterfaceGen, SpringClassGenerator springClassGen,
            SpringConfigurationGenerator springConfigGen, SpringViewGenerator springViewGen, SpringGeneratorUtil generatorUtil,
            List<string> modules, string dataModule, Component component, List<string> dependencies)
        {
            modules.Add(component.Name + "-API");
            BindingTypeHolder bindingsOfModule = new BindingTypeHolder();


            string dataBinding = "";
            foreach (Reference reference in component.References)
            {
                if (reference.Interface is Database)
                {
                    List<Binding> binds = GetBindings(ns, reference, reference.Interface);
                    BindingTypeHolder binding = CheckForBindings(binds);
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

                if (iface is Database) { continue; } //handle very differently

                // interface goes to API
                string apiIfDirectory = createJavaDirectory(ns, component.Name + "-API", generatorUtil.Properties.interfacePackage);
                string interfaceFileName = Path.Combine(apiIfDirectory, iface.Name + ".java");
                using (StreamWriter writer = new StreamWriter(interfaceFileName))
                {
                    writer.WriteLine(springInterfaceGen.GenerateInterface(iface, ""));
                }

                // implementaton goes to component
                string functionDirectory = createJavaDirectory(ns, component.Name, component.Name.ToLower());
                string javaFileName = Path.Combine(functionDirectory, iface.Name + "Impl.java");
                using (StreamWriter writer = new StreamWriter(javaFileName))
                {
                    writer.WriteLine(springInterfaceGen.GenerateInterfaceImplementation(iface, component.Name.ToLower(), dataBinding));
                }

                List<Binding> bindings = GetBindings(ns, service, iface);
                BindingTypeHolder bindingsOfService = CheckForBindings(bindings);
                CreateBindings(bindingsOfService, springInterfaceGen, component, apiIfDirectory, functionDirectory, iface);

                bindingsOfModule.HasRestBinding         |= bindingsOfService.HasRestBinding;
                bindingsOfModule.HasWebServiceBinding   |= bindingsOfService.HasWebServiceBinding;
                bindingsOfModule.HasWebSocketBinding    |= bindingsOfService.HasWebSocketBinding;

                foreach (Operation op in iface.Operations)
                {
                    foreach(Struct exception in op.Exceptions)
                    {
                        string apiExDirectory = createJavaDirectory(ns, component.Name + "-API", generatorUtil.Properties.exceptionPackage);
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
            createJavaDirectory(ns, component.Name + "-API", "");
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
                createJavaDirectory(ns, c.Name, "");
                fileName = Path.Combine(ns.Name + "-" + c.Name, "pom.xml");
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    writer.WriteLine(springConfigGen.GenerateComponentPom(ns, c, deps, false, false, false, ComponentType.REMOTE));
                }

                // web.xml
                string webinfDir = createWebDirectory(ns, c.Name, "");
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
                    writer.WriteLine(springViewGen.GenerateAppCtx(ns, dependencies.Contains(dataModule)));
                }

                // servlet
                string servletFile = Path.Combine(webinfDir, "spring-servlet.xml");
                using (StreamWriter writer = new StreamWriter(servletFile))
                {
                    writer.WriteLine(springViewGen.GenerateServlet(ns, ComponentType.REMOTE));
                }
            }
        }

        private BindingTypeHolder GenerateReferenceAccessors(Namespace ns, Component component, Dictionary<Reference, Component> dependencyMap, Dictionary<string, string> properties, SpringInterfaceGenerator springInterfaceGen, SpringGeneratorUtil generatorUtil)
        {
            BindingTypeHolder clientFor = new BindingTypeHolder();
            foreach (Reference reference in component.References)
            {
                if (reference.Interface is Database)
                {
                    continue;
                }
                List<Binding> binds = GetBindings(ns, reference, reference.Interface);
                BindingTypeHolder binding = CheckForBindings(binds);
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

                    string proxyDir = createJavaDirectory(ns, component.Name, generatorUtil.Properties.proxyPackage);
                    string accessorFile = Path.Combine(proxyDir, reference.Interface.Name+"RestProxy.java");
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

        private static BindingTypeHolder CheckForBindings(List<Binding> bindings)
        {
            BindingTypeHolder result = new BindingTypeHolder();

            foreach (Binding binding in bindings)
            {
                if (binding.Transport is RestTransportBindingElement)
                {
                    result.HasRestBinding = true;
                }
                else if (binding.Transport is WebSocketTransportBindingElement)
                {
                    result.HasWebSocketBinding = true;
                }
                else
                {
                    foreach (EncodingBindingElement encoding in binding.Encodings)
                    {
                        if (encoding is SoapEncodingBindingElement)
                        {
                            result.HasWebServiceBinding = true;
                        }
                    }
                }
            }

            return result;
        }

        private static List<Binding> GetBindings(Namespace ns, Port interfaceReference, Interface iface)
        {
            HashSet<Binding> bindings = new HashSet<Binding>();

            if (interfaceReference.Binding != null)
            {
                bindings.Add(interfaceReference.Binding);
            }

            foreach (Composite composite in ns.Declarations.OfType<Composite>())
            {
                foreach (Wire wire in composite.Wires)
                {
                    Port port = null;
                    if (wire.Source.Equals(interfaceReference))
                    {
                        port = wire.Target;
                    }
                    if (wire.Target.Equals(interfaceReference))
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

        private string createResourceDirectory(Namespace ns, string projectSuffix, string subDir)
        {
            string innerDir = Path.Combine(ns.FullName.ToLower().Split('.'));
            string projectDir = "";
            if (projectSuffix != null)
                projectDir = ns.Name + "-" + projectSuffix;
            else
                projectDir = ns.Name;

            string directory = Path.Combine(projectDir, this.mvnResDir, innerDir, subDir);
            Directory.CreateDirectory(directory);

            return directory;
        }

        private string createJavaDirectory(Namespace ns, string projectSuffix, string subDir)
        {
            string innerDir = Path.Combine(ns.FullName.ToLower().Split('.'));
            string projectDir = "";
            if (projectSuffix != null)
                projectDir = ns.Name + "-" + projectSuffix;
            else
                projectDir = ns.Name;

            string directory = Path.Combine(projectDir, this.mvnJavaDir, innerDir, subDir);
            Directory.CreateDirectory(directory);

            return directory;
        }

        private string createWebDirectory(Namespace ns, string projectSuffix, string subDir)
        {
            string projectDir = "";
            if (projectSuffix != null)
                projectDir = ns.Name + "-" + projectSuffix;
            else
                projectDir = ns.Name;

            string directory = Path.Combine(projectDir, this.mvnWebDir, "WEB-INF", subDir);
            //string directory = Path.Combine(projectDir, "WEB-INF", subDir); // TODO change

            Directory.CreateDirectory(directory);

            return directory;
        }
    }
}
