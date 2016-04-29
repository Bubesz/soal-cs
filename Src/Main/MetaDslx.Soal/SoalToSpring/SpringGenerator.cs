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
    public class SpringGenerator
    {
        public static Namespace XsdNamespace { get; private set; }
        static SpringGenerator()
        {
            XsdNamespace = SoalFactory.Instance.CreateNamespace();
            XsdNamespace.Prefix = "xs";
            XsdNamespace.Uri = "http://www.w3.org/2001/XMLSchema";
        }


        public SpringGenerator(Model model, string outputDirectory, ModelCompilerDiagnostics diagnostics, string fileName)
        {
            this.FileName = fileName;
            this.OutputDirectory = outputDirectory;
            this.Model = model;
            this.Diagnostics = diagnostics;
            this.SeparateXsdWsdl = false;
            this.SingleFileWsdl = false;
        }

        public string FileName { get; private set; }
        public string OutputDirectory { get; private set; }
        public ModelCompilerDiagnostics Diagnostics { get; private set; }
        public Model Model { get; private set; }
        public bool SeparateXsdWsdl { get; set; }
        public bool SingleFileWsdl { get; set; }

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
            var namespaces = this.Model.Instances.OfType<Namespace>().ToList();
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
                        if (intf != null && !intf.HasAnnotation(SoalAnnotations.NoWrap) && !intf.HasAnnotation(SoalAnnotations.Rpc))
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
                                symbols.Add((ModelObject)op);
                            }
                        }
                        Struct stype = decl as Struct;
                        if (stype != null)
                        {
                            string key = stype.GetXsdName();
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
                            string key = etype.GetXsdName();
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
                                this.Diagnostics.AddError("XSD type named '" + key + "' is defined multiple times.", this.FileName, symbol);
                            }
                        }
                    }

                    foreach (Component component in ns.Declarations.OfType<Component>())
                    {
                        foreach (Component comp in ns.Declarations.OfType<Component>())
                        {
                            bool hasDataAccess = false;
                            foreach (Reference reference in component.References)
                            {
                                if (reference.Interface is Database)
                                {
                                    if (hasDataAccess)
                                    {
                                        this.Diagnostics.AddError("Multiple data components are not allowed to be referenced in one component.", this.FileName, comp);
                                    }
                                    hasDataAccess = true;
                                }
                            }
                        }
                    }

                    this.manipulateModel(ns);
                }
            }
        }

        private void manipulateModel(Namespace ns)
        {
            Dictionary<Component, List<Service>> databasesByComponent = new Dictionary<Component, List<Service>>();
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
                            databasesByComponent.Add(comp, new List<Service>());
                        }
                        databasesByComponent[comp].Add(service);
                    }
                }
            }

            foreach (KeyValuePair<Component, List<Service>> entry in databasesByComponent)
            {
                Component comp = entry.Key;
                foreach (Service dbServ in entry.Value)
                {
                    Database db = dbServ.Interface as Database;
                    using (new ModelContextScope(this.Model))
                    {
                        foreach (Struct entity in db.Entities)
                        {
                            SoalFactory f = SoalFactory.Instance;
                            Interface repository = f.CreateInterface();
                            repository.Name = entity.Name + "Repository";
                            Service repoServ = f.CreateService();
                            repoServ.Interface = repository;
                            repoServ.Binding = dbServ.Binding;
                            repository.Namespace = ns;
                            comp.Services.Add(repoServ);

                            // Operations ...
                            {
                                // count()
                                Operation op = f.CreateOperation();
                                op.Name = "count";
                                op.Action = "count";
                                op.Result.Type = SoalInstance.Long;
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

        public void Generate()
        {
            this.PrepareGeneration();
            if (this.Diagnostics.HasErrors()) return;

            var namespaces = this.Model.Instances.OfType<Namespace>();
            foreach (var ns in namespaces)
            {
                SpringClassGenerator springClassGen = new SpringClassGenerator(ns);
                SpringInterfaceGenerator springInterfaceGen = new SpringInterfaceGenerator(ns);
                SpringConfigurationGenerator springConfigGen = new SpringConfigurationGenerator(ns);
                SpringViewGenerator springViewGen = new SpringViewGenerator(ns);
                SpringGeneratorUtil generatorUtil = new SpringGeneratorUtil(ns);
                //generatorUtil.Properties.entityPackage = "asdasd";

                BindingDiscoverer bindingDiscoverer = new BindingDiscoverer();
                DirectoryHandler directoryHandler = new DirectoryHandler();
                DependencyDiscoverer dependencyDiscoverer = new DependencyDiscoverer(bindingDiscoverer);
                DataAccessFinder dataAccessFinder = new DataAccessFinder(bindingDiscoverer);
                ModelGenerator modelGenerator = new ModelGenerator(directoryHandler);
                JSFGenerator jSFGenerator = new JSFGenerator(springViewGen, generatorUtil, directoryHandler);

                ComponentGenerator componentGenerator =
                    new ComponentGenerator(springInterfaceGen, springClassGen, springConfigGen, springViewGen, generatorUtil,
                    bindingDiscoverer, directoryHandler, dependencyDiscoverer, dataAccessFinder, jSFGenerator);

                if (ns.Uri != null)
                {
                    List<string> modules = new List<string>();

                    List<Struct> entities = new List<Struct>();
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

                    Dictionary<string, string> properties = componentGenerator.GenerateComponent(ns, wires, modules);

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
