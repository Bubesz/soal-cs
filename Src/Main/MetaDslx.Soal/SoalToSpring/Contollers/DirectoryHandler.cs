using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Soal.SoalToSpring.Contollers
{
    public class DirectoryHandler
    {
        private string mvnJavaDir;
        private string mvnResDir;
        private string mvnWebDir;

        public DirectoryHandler()
        {
            //standard maven path
            this.mvnJavaDir = Path.Combine("src", "main", "java");
            this.mvnResDir = Path.Combine("src", "main", "resources");
            this.mvnWebDir = Path.Combine("src", "main", "webapp");
        }

        public string createResourceDirectory(Namespace ns, string projectSuffix, string subDir)
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

        public string createJavaDirectory(Namespace ns, string projectSuffix, string subDir, bool addInnerDir=true)
        {
            string innerDir = Path.Combine(ns.FullName.ToLower().Split('.'));
            string projectDir = "";
            if (projectSuffix != null)
                projectDir = ns.Name + "-" + projectSuffix;
            else
                projectDir = ns.Name;

            string directory;
            if (addInnerDir)
            {
                directory = Path.Combine(projectDir, this.mvnJavaDir, innerDir, subDir);
            }
            else
            {
                directory = Path.Combine(projectDir, this.mvnJavaDir, subDir);
            }
            Directory.CreateDirectory(directory);

            return directory;
        }

        public string createWebDirectory(Namespace ns, string projectSuffix, string subDir)
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
