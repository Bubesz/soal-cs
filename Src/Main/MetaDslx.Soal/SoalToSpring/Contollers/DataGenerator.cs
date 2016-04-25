using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Soal.SoalToSpring.Contollers
{
    public class DataGenerator
    {
        private SpringInterfaceGenerator springInterfaceGen;
        private SpringClassGenerator springClassGen;
        private SpringConfigurationGenerator springConfigGen;
        private SpringGeneratorUtil generatorUtil;

        private BindingGenerator bindingGenerator;
        private DirectoryHandler directoryHandler;

        public DataGenerator(SpringInterfaceGenerator springInterfaceGen, SpringClassGenerator springClassGen,
            SpringConfigurationGenerator springConfigGen, SpringGeneratorUtil generatorUtil,
            BindingGenerator bindingGenerator, DirectoryHandler directoryHandler)
        {
            this.springInterfaceGen = springInterfaceGen;
            this.springClassGen = springClassGen;
            this.springConfigGen = springConfigGen;
            this.generatorUtil = generatorUtil;

            this.bindingGenerator = bindingGenerator;
            this.directoryHandler = directoryHandler;
        }

        public void GenerateDataModule(Namespace ns, Component component, List<Struct> entities, List<string> modules)
        {
            //pom.xml
            directoryHandler.createJavaDirectory(ns, component.Name, "");
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
            List<Binding> binds = bindingGenerator.GetBindings(ns, dbService, dbService.Interface);
            BindingTypeHolder bindings = bindingGenerator.CheckForBindings(binds);

            //entities
            foreach (Struct entity in entities)
            {
                // repository TODO bindings
                string repoDirectory = directoryHandler.createJavaDirectory(ns, component.Name + "-API", generatorUtil.Properties.repositoryPackage);
                string javaFileName = Path.Combine(repoDirectory, entity.Name + "Repository.java");
                using (StreamWriter writer = new StreamWriter(javaFileName))
                {
                    writer.WriteLine(springClassGen.GenerateRepository(entity));
                }

                string apiDirectory = directoryHandler.createJavaDirectory(ns, component.Name + "-API", generatorUtil.Properties.interfacePackage);
                string functionDirectory = directoryHandler.createJavaDirectory(ns, component.Name, generatorUtil.Properties.repositoryPackage);

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
    }
}
