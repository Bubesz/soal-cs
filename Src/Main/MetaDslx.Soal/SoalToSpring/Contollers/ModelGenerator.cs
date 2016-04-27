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

        public ModelGenerator(DirectoryHandler directoryHandler)
        {
            this.directoryHandler = directoryHandler;
        }

        public void GenerateModelModule(Namespace ns, List<Struct> entities, Dictionary<string, string> properties,
            SpringClassGenerator springClassGen, SpringConfigurationGenerator springConfigGen, SpringGeneratorUtil generatorUtil)
        {
            string baseJavaDir = directoryHandler.createJavaDirectory(ns, "Model", "");
            //pom.xml
            string filename = Path.Combine(ns.Name + "-Model", "pom.xml");
            Component comp = new ComponentImpl();
            comp.Name = "Model";

            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine(springConfigGen.GenerateComponentPom(ns, comp, new List<string>(), false, false, false, ComponentType.DATA));
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
                string entityDirectory = directoryHandler.createJavaDirectory(ns, "Model", generatorUtil.Properties.entityPackage);
                string javaFileName = Path.Combine(entityDirectory, entity.Name + ".java");

                using (StreamWriter writer = new StreamWriter(javaFileName))
                {
                    writer.WriteLine(springClassGen.GenerateEntity(entity));
                }
            }

            //enums
            foreach (Enum myEnum in ns.Declarations.OfType<Enum>())
            {
                string enumDirectory = directoryHandler.createJavaDirectory(ns, "Model", generatorUtil.Properties.enumPackage);
                string javaFileName = Path.Combine(enumDirectory, myEnum.Name + ".java");

                using (StreamWriter writer = new StreamWriter(javaFileName))
                {
                    writer.WriteLine(springClassGen.GenerateEnum(myEnum));

                }
            }

            // manual config
            string dir = directoryHandler.createResourceDirectory(ns, "Model", "");
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
    }
}
