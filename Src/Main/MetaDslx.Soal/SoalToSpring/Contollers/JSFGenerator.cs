using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Soal.SoalToSpring.Contollers
{
    public class JSFGenerator
    {
        private SpringViewGenerator springViewGen;
        private SpringGeneratorUtil generatorUtil;
        private DirectoryHandler directoryHandler;

        public JSFGenerator(SpringViewGenerator springViewGen, SpringGeneratorUtil generatorUtil, DirectoryHandler directoryHandler)
        {
            this.springViewGen = springViewGen;
            this.generatorUtil = generatorUtil;
            this.directoryHandler = directoryHandler;
        }

        public void GenerateWebTier(Namespace ns, Component component, bool directDataAccess)
        {
            string contollerDir = directoryHandler.createJavaDirectory(ns, component.Name, generatorUtil.Properties.controllerPackage);
            string viewDir = directoryHandler.createWebDirectory(ns, component.Name, "view");

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
                viewDir = directoryHandler.createWebDirectory(ns, component.Name, "view");
                viewFile = Path.Combine(viewDir, "_master.html");
                using (StreamWriter writer = new StreamWriter(viewFile))
                {
                    writer.WriteLine(springViewGen.GenerateMasterView(component.Name, views));
                }
            }

            // web.xml
            string webinfDir = directoryHandler.createWebDirectory(ns, component.Name, "");
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
    }
}
