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
                List<string> pathes = new List<string>();
                pathes.Add(this.OutputDirectory);
                /*foreach (string nameSegment in ns.FullName.ToLower().Split('.')) {
                    pathes.Add(nameSegment);
                }
                pathes.Add("src");
                pathes.Add("main");
                pathes.Add("java");*/
                string componentDirectory = Path.Combine(pathes.ToArray());

                string entityDirectory = Path.Combine(componentDirectory, "entity");
                string exceptionDirectory = Path.Combine(componentDirectory, "exception");
                string interfaceDirectory = Path.Combine(componentDirectory, "interface");
                string enumDirectory = Path.Combine(componentDirectory, "enum");

                if (ns.Uri != null)
                {
                    foreach (var dec in ns.Declarations)
                    {
                        Entity entity = dec as Entity;
                        if (entity != null)
                        {
                            Directory.CreateDirectory(entityDirectory);
                            
                            string javaFileName = Path.Combine(entityDirectory, entity.Name + ".java");
                            using (StreamWriter writer = new StreamWriter(javaFileName))
                            {
                                SpringGenerator springGen = new SpringGenerator(ns);
                                //springGen.Properties.SeparateXsdWsdl = asd;
                                writer.WriteLine(springGen.GenerateEntity(entity));
                            }
                        }

                        Exception ex = dec as Exception;
                        if (ex != null)
                        {
                            Directory.CreateDirectory(exceptionDirectory);
                            
                            string javaFileName = Path.Combine(exceptionDirectory, ex.Name + ".java");
                            using (StreamWriter writer = new StreamWriter(javaFileName))
                            {
                                SpringGenerator springGen = new SpringGenerator(ns);
                                //springGen.Properties.SeparateXsdWsdl = asd;
                                writer.WriteLine(springGen.GenerateException(ex));
                            }
                        }
                        
                        Interface iface = dec as Interface;
                        if (iface != null)
                        {
                            Directory.CreateDirectory(interfaceDirectory);

                            string javaFileName = Path.Combine(interfaceDirectory, iface.Name + ".java");
                            using (StreamWriter writer = new StreamWriter(javaFileName))
                            {
                                SpringGenerator springGen = new SpringGenerator(ns);
                                //springGen.Properties.SeparateXsdWsdl = asd;
                                writer.WriteLine(springGen.GenerateInterface(iface));
                            }
                        }

                        Enum myEnum = dec as Enum;
                        if (myEnum != null)
                        {
                            Directory.CreateDirectory(enumDirectory);

                            string javaFileName = Path.Combine(enumDirectory, myEnum.Name + ".java");
                            using (StreamWriter writer = new StreamWriter(javaFileName))
                            {
                                SpringGenerator springGen = new SpringGenerator(ns);
                                //springGen.Properties.SeparateXsdWsdl = asd;
                                writer.WriteLine(springGen.GenerateEnum(myEnum));
                            }
                        }
                    }
                }
            }
        }
    }
}
