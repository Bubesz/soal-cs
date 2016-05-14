using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Soal.SoalToSpring.Contollers
{
    public class ModelGenerator
    {
        private DirectoryHandler directoryHandler;

        private SpringClassGenerator springClassGen;
        private SpringConfigurationGenerator springConfigGen;
        private SpringGeneratorUtil generatorUtil;


        public ModelGenerator(DirectoryHandler directoryHandler, SpringClassGenerator springClassGen, SpringConfigurationGenerator springConfigGen, SpringGeneratorUtil generatorUtil)
        {
            this.directoryHandler = directoryHandler;
            this.springClassGen = springClassGen;
            this.springConfigGen = springConfigGen;
            this.generatorUtil = generatorUtil;
        }

        public void GenerateModelModule(Namespace ns, List<Struct> entities, Dictionary<string, string> properties)
        {
            string baseJavaDir = directoryHandler.createJavaDirectory(ns, "Model", "");
            //pom.xml
            string filename = Path.Combine(ns.Name + "-Model", "pom.xml");
            Component comp = new ComponentImpl();
            comp.Name = "Model";

            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine(this.springConfigGen.GenerateComponentPom(ns, comp, new List<string>(), false, false, false, ComponentType.DATA));
            }

            // generate persistence.xml
            if (entities.Any())
            {
                string metaFolder = Path.Combine(ns.Name + "-Model", "src", "main", "resources", "META-INF");
                Directory.CreateDirectory(metaFolder);
                filename = Path.Combine(metaFolder, "persistence.xml");
                using (StreamWriter writer = new StreamWriter(filename))
                {
                    writer.WriteLine(this.springConfigGen.GeneratePersistence(ns, entities));
                }
            }

            //entities
            foreach (Struct entity in entities)
            {
                // entity
                string entityDirectory = directoryHandler.createJavaDirectory(ns, "Model", this.generatorUtil.Properties.entityPackage);
                string javaFileName = Path.Combine(entityDirectory, entity.Name + ".java");

                using (StreamWriter writer = new StreamWriter(javaFileName))
                {
                    writer.WriteLine(this.springClassGen.GenerateEntity(entity));
                }
            }

            //enums
            foreach (Enum myEnum in ns.Declarations.OfType<Enum>())
            {
                string enumDirectory = directoryHandler.createJavaDirectory(ns, "Model", this.generatorUtil.Properties.enumPackage);
                string javaFileName = Path.Combine(enumDirectory, myEnum.Name + ".java");

                using (StreamWriter writer = new StreamWriter(javaFileName))
                {
                    writer.WriteLine(this.springClassGen.GenerateEnum(myEnum));

                }
            }

            // manual config
            string dir = directoryHandler.createResourceDirectory(ns, "Model", "");
            filename = Path.Combine(dir, "configuration.properties");
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine(this.springConfigGen.GenerateConfig(properties));
            }

            filename = Path.Combine(baseJavaDir, "Configuration.java");
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine(this.springConfigGen.GenerateConfigClass(ns));
            }
        }
    }
}
