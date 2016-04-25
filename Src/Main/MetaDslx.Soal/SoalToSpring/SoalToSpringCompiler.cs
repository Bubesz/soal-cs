using MetaDslx.Core;
using MetaDslx.Soal.SoalToSpring.Contollers;
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
                                //this.Diagnostics.AddError("Java type named '" + key + "' is defined multiple times.", this.FileName, symbol);
                            }
                        }
                    }
                }

                Dictionary<Component, List<Database>> databasesByComponent = new Dictionary<Component, List<Database>>();
                var components = ns.Declarations.OfType<Component>();
                foreach (Component comp in components)
                {
                    foreach (Service service in comp.Services)
                    {
                        Database db = service.Interface as Database;
                        if (db != null)
                        {
                            if (!databasesByComponent.ContainsKey(comp))
                            {
                                databasesByComponent.Add(comp, new List<Database>());
                            }
                            databasesByComponent[comp].Add(db);
                        }
                    }
                }

                foreach (KeyValuePair<Component, List<Database>> entry in databasesByComponent)
                {
                    Component comp = entry.Key;
                    foreach (Database db in entry.Value)
                    {
                        using (new ModelContextScope(this.Model))
                        {
                            foreach (Struct entity in db.Entities)
                            {
                                SoalFactory f = SoalFactory.Instance;
                                Interface repository = f.CreateInterface();
                                repository.Name = entity.Name + "Repository";
                                Service repoServ = f.CreateService();
                                //repoServ.Name = "asd"; FIXME (read only)
                                repoServ.OptionalName = "asd";
                                //((ModelObject)repoServ).
                                repoServ.Interface = repository;
                                repository.Namespace = ns;
                                comp.Services.Add(repoServ);

                                // Operations ...
                                {
                                    // count()
                                    Operation op = f.CreateOperation();
                                    op.Name = "count";
                                    op.Action = "count";
                                    op.Result.Type = SoalInstance.Void;
                                    repository.Operations.Add(op);
                                }
                                {
                                    // delete(id);
                                    Operation op = f.CreateOperation();
                                    op.Name = "delete";
                                    op.Action = "count";
                                    op.Result.Type = SoalInstance.Void;
                                    InputParameter param = f.CreateInputParameter();
                                    param.Type = SoalInstance.Long;
                                    param.Name = "id";
                                    op.Parameters.Add(param);
                                    repository.Operations.Add(op);
                                }
                                {
                                    // delete(entity);
                                    Operation op = f.CreateOperation();
                                    op.Name = "delete";
                                    op.Action = "count";
                                    op.Result.Type = SoalInstance.Void;
                                    InputParameter param = f.CreateInputParameter();
                                    param.Type = entity;
                                    param.Name = "entity";
                                    op.Parameters.Add(param);
                                    repository.Operations.Add(op);
                                }
                                {
                                    // delete(entities);
                                    Operation op = f.CreateOperation();
                                    op.Name = "delete";
                                    op.Action = "count";
                                    op.Result.Type = SoalInstance.Void;
                                    InputParameter param = f.CreateInputParameter();
                                    ArrayType array = f.CreateArrayType();
                                    array.InnerType = entity;
                                    param.Type = array;
                                    param.Name = "entities";
                                    op.Parameters.Add(param);
                                    repository.Operations.Add(op);
                                }
                                {
                                    // deleteAll();
                                    Operation op = f.CreateOperation();
                                    op.Name = "deleteAll";
                                    op.Action = "count";
                                    op.Result.Type = SoalInstance.Void;
                                    repository.Operations.Add(op);
                                }
                                {
                                    // exists(id);
                                    Operation op = f.CreateOperation();
                                    op.Name = "exists";
                                    op.Action = "count";
                                    op.Result.Type = SoalInstance.Bool;
                                    InputParameter param = f.CreateInputParameter();
                                    param.Type = SoalInstance.Long;
                                    op.Parameters.Add(param);
                                    param.Name = "id";
                                    repository.Operations.Add(op);
                                }
                                {
                                    // findAll();
                                    Operation op = f.CreateOperation();
                                    op.Name = "findAll";
                                    op.Action = "count";
                                    ArrayType array = f.CreateArrayType();
                                    array.InnerType = entity;
                                    op.Result.Type = array;
                                    repository.Operations.Add(op);
                                }
                                {
                                    // findAll(ids);
                                    Operation op = f.CreateOperation();
                                    op.Name = "findAll";
                                    op.Action = "count";
                                    ArrayType array = f.CreateArrayType();
                                    array.InnerType = entity;
                                    op.Result.Type = array;
                                    InputParameter param = f.CreateInputParameter();
                                    ArrayType array2 = f.CreateArrayType();
                                    array2.InnerType = SoalInstance.Long;
                                    param.Type = array2;
                                    param.Name = "ids";
                                    op.Parameters.Add(param);
                                    repository.Operations.Add(op);
                                }
                                {
                                    // findOne(id);
                                    Operation op = f.CreateOperation();
                                    op.Name = "findOne";
                                    op.Action = "count";
                                    op.Result.Type = entity;
                                    InputParameter param = f.CreateInputParameter();
                                    param.Type = SoalInstance.Long;
                                    param.Name = "id";
                                    op.Parameters.Add(param);
                                    repository.Operations.Add(op);
                                }
                                {
                                    // save(entity);
                                    Operation op = f.CreateOperation();
                                    op.Name = "save";
                                    op.Action = "count";
                                    op.Result.Type = entity;
                                    InputParameter param = f.CreateInputParameter();
                                    param.Type = entity;
                                    param.Name = "entity";
                                    op.Parameters.Add(param);
                                    repository.Operations.Add(op);
                                }
                                {
                                    // save(entities);
                                    Operation op = f.CreateOperation();
                                    op.Name = "save";
                                    op.Action = "count";
                                    ArrayType array = f.CreateArrayType();
                                    array.InnerType = entity;
                                    op.Result.Type = array;
                                    InputParameter param = f.CreateInputParameter();
                                    ArrayType array2 = f.CreateArrayType();
                                    array2.InnerType = entity;
                                    param.Type = array2;
                                    param.Name = "entities";
                                    op.Parameters.Add(param);
                                    repository.Operations.Add(op);
                                }
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

                
                BindingGenerator bindingGenerator = new BindingGenerator(springInterfaceGen);
                DirectoryHandler directoryHandler = new DirectoryHandler();
                DependencyDiscoverer dependencyDiscoverer = new DependencyDiscoverer(bindingGenerator);
                DataAccessFinder dataAccessFinder = new DataAccessFinder(bindingGenerator);
                ModelGenerator modelGenerator = new ModelGenerator(directoryHandler);
                JSFGenerator jSFGenerator = new JSFGenerator(springViewGen, generatorUtil, directoryHandler);
                ComponentGenerator componentGenerator =
                    new ComponentGenerator(springInterfaceGen, springClassGen, springConfigGen, springViewGen, generatorUtil, bindingGenerator, directoryHandler);
                DataGenerator dataGenerator =
                    new DataGenerator(springInterfaceGen, springClassGen, springConfigGen, generatorUtil, bindingGenerator, directoryHandler);


                if (ns.Uri != null)
                {
                    List<Struct> entities = new List<Struct>();
                    List<string> modules = new List<string>();
                    string dataModule = ""; // FIXME

                    //foreach (Component component in ns.Declarations.OfType<Component>())
                    //{
                    //    foreach (Service service in component.Services)
                    //    {
                    //        if (service.Interface is Database)
                    //        {
                    //            if (dataModule != "")
                    //            {
                    //                Console.WriteLine("Multiple data components are not allowed.");
                    //                return;
                    //            }
                    //            dataModule = component.Name;
                    //        }
                    //    }
                    //}

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

                        Dictionary<Reference, Component> dependencyMap = dependencyDiscoverer.GetherDependencyMap(ns, wires, component);
                        List<string> dependencies = dependencyDiscoverer.GetherDependencies(dependencyMap);
                        bool directDataAccess = dataAccessFinder.HasDirectDataAccess(ns, wires, component, dataModule);


                        if (component.Services.Any())
                        {
                            componentGenerator.GenerateServiceImplementations(ns, modules, dataModule, component, dependencies);
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
                            clientFor = componentGenerator.GenerateReferenceAccessors(ns, component, dependencyMap, properties, springInterfaceGen, generatorUtil);
                        }

                        if (component.Name == dataModule)
                        {
                            //GenerateDataModule(ns, component, springClassGen, springConfigGen, generatorUtil, springInterfaceGen, entities, modules);
                        }

                        // generate pom.xml and spring-config.xml
                        directoryHandler.createJavaDirectory(ns, component.Name, "");
                        string fileName = Path.Combine(ns.Name + "-" + component.Name, "pom.xml");
                        using (StreamWriter writer = new StreamWriter(fileName))
                        {
                            string s = springConfigGen.GenerateComponentPom(ns, component, dependencies,
                                clientFor.HasRestBinding, clientFor.HasWebServiceBinding, clientFor.HasWebSocketBinding, cType);
                            writer.WriteLine(s);
                        }

                        string mvnJavaDir = Path.Combine("src", "main", "java"); // FIXME
                        fileName = Path.Combine(ns.Name + "-" + component.Name, mvnJavaDir, "spring-config.xml");
                        using (StreamWriter writer = new StreamWriter(fileName))
                        {
                            writer.WriteLine(springConfigGen.GenerateComponentSpringConfig(ns));
                        }
                    }

                    if (entities.Any() || ns.Declarations.OfType<Enum>().Any())
                    {
                        modules.Add("Model");
                        modelGenerator.GenerateModelModule(ns, entities, properties, springClassGen, springConfigGen, generatorUtil);
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
    }
}
