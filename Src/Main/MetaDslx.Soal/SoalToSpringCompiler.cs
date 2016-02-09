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
            : base(source, outputDirectory, fileName)
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
            List<string> mvnPath = new List<string>();
            mvnPath.Add("src");
            mvnPath.Add("main");
            mvnPath.Add("java");
            this.mvnDir = Path.Combine(mvnPath.ToArray());

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
                        StructuredType stype = decl as StructuredType;
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
                                this.CheckXsdNamespace(op.ReturnType, (ModelObject)op);
                                foreach (var param in op.Parameters)
                                {
                                    this.CheckXsdNamespace(param.Type, (ModelObject)param);
                                }
                            }
                        }
                        StructuredType stype = decl as StructuredType;
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
                //final path: Path.Combine(this.OutputDirectory, projectDir, mvnDir, innerDir);

                //defined namespace
                List<string> innerPath = new List<string>();
                foreach (string nameSegment in ns.FullName.ToLower().Split('.')) {
                    innerPath.Add(nameSegment);
                }
                string innerDir = Path.Combine(innerPath.ToArray());

                //string componentDir = Path.Combine(mvnDir, innerDir);

                SpringGenerator springGen = new SpringGenerator(ns);
                SpringGeneratorUtil generatorUtil = new SpringGeneratorUtil(ns);
                //generatorUtil.Properties.entityPackage = "asdasd";
                //springGen.Properties.util = generatorUtil;

                if (ns.Uri != null)
                {
                    List<Entity> entities = new List<Entity>();
                    foreach (var dec in ns.Declarations)
                    {
                        Entity entity = dec as Entity;
                        if (entity != null)
                        {
                            entities.Add(entity); //TODO better collect the others as well

                            //entity
                            //TODO -Data ?
                            string entityDirectory = createDirectory(ns.Name, "Commons", innerDir, generatorUtil.Properties.entityPackage);
                            string javaFileName = Path.Combine(entityDirectory, entity.Name + ".java");
                            using (StreamWriter writer = new StreamWriter(javaFileName))
                            {
                                //springGen.Properties.SeparateXsdWsdl = asd;
                                writer.WriteLine(springGen.GenerateEntity(entity));
                            }

                            //repository
                            string repoDirectory = createDirectory(ns.Name, "Commons", innerDir, generatorUtil.Properties.repositoryPackage);
                            javaFileName = Path.Combine(repoDirectory, entity.Name + "Repository.java");
                            using (StreamWriter writer = new StreamWriter(javaFileName))
                            {
                                //springGen.Properties.SeparateXsdWsdl = asd;
                                writer.WriteLine(springGen.GenerateRepository(entity));
                            }
                        }

                        Exception ex = dec as Exception;
                        if (ex != null)
                        {
                            string exceptionDirectory = createDirectory(ns.Name, "Commons", innerDir, generatorUtil.Properties.exceptionPackage); 
                            string javaFileName = Path.Combine(exceptionDirectory, ex.Name + ".java");
                            using (StreamWriter writer = new StreamWriter(javaFileName))
                            {
                                //springGen.Properties.SeparateXsdWsdl = asd;
                                writer.WriteLine(springGen.GenerateException(ex));
                            }
                        }
                        
                        Interface iface = dec as Interface;
                        if (iface != null)
                        {
                            string interfaceDirectory = createDirectory(ns.Name, "Commons", innerDir, generatorUtil.Properties.interfacePackage);
                            string javaFileName = Path.Combine(interfaceDirectory, iface.Name + ".java");
                            using (StreamWriter writer = new StreamWriter(javaFileName))
                            {
                                //springGen.Properties.SeparateXsdWsdl = asd;
                                writer.WriteLine(springGen.GenerateInterface(iface));
                            }
                        }

                        Enum myEnum = dec as Enum;
                        if (myEnum != null)
                        {
                            string enumDirectory = createDirectory(ns.Name, "Commons", innerDir, generatorUtil.Properties.enumPackage);
                            string javaFileName = Path.Combine(enumDirectory, myEnum.Name + ".java");
                            using (StreamWriter writer = new StreamWriter(javaFileName))
                            {
                                //springGen.Properties.SeparateXsdWsdl = asd;
                                writer.WriteLine(springGen.GenerateEnum(myEnum));
                            }
                        }

                        Component component = dec as Component;
                        if (component != null)
                        {
                            string compDirectory = createDirectory(ns.Name, component.Name, innerDir, generatorUtil.Properties.serviceFacadePackage);
                            string javaFileName = Path.Combine(compDirectory, component.Name + ".java");
                            using (StreamWriter writer = new StreamWriter(javaFileName))
                            {
                                //springGen.Properties.SeparateXsdWsdl = asd;
                                writer.WriteLine(springGen.GenerateComponent(component));
                            }
                        }
                    }

                    //generate persistence.xml
                    if (entities.Any())
                    {
                        //TODO Data as suffix ?
                        string myDirectory = createDirectory(ns.Name, "Commons", innerDir, "");
                        string fileName = Path.Combine(myDirectory, "persistence.xml");
                        using (StreamWriter writer = new StreamWriter(fileName))
                        {
                            //springGen.Properties.SeparateXsdWsdl = asd;
                            writer.WriteLine(springGen.GeneratePersistence(ns));
                        }
                    }
                    /*foreach (Entity entity in entities)
                    {

                    }*/
                }
            }
        }

        private string createDirectory(string namespaceName, string projectSuffix, string innerDir, string subDir)
        {
            string projectDir = "";
            if (projectSuffix != null)
                projectDir = Path.Combine(this.OutputDirectory, namespaceName + "-"+ projectSuffix);
            else
                projectDir = Path.Combine(this.OutputDirectory, namespaceName);

            //string directory = Path.Combine(projectDir, this.mvnDir, innerDir, subDir);
            string directory = Path.Combine(projectDir, subDir); // TODO change

            Directory.CreateDirectory(directory);

            return directory;
        }
    }
}
