using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Soal //1:1
{
    using __Hidden_SpringConfigurationGenerator_737942986;
    namespace __Hidden_SpringConfigurationGenerator_737942986
    {
        internal static class __Extensions
        {
            internal static IEnumerator<T> GetEnumerator<T>(this T item)
            {
                if (item == null) return new List<T>().GetEnumerator();
                else return new List<T> { item }.GetEnumerator();
            }
        }
    }

    public class SpringConfigurationGenerator //2:1
    {
        private object Instances; //2:1

        public SpringConfigurationGenerator() //2:1
        {
        }

        public SpringConfigurationGenerator(object instances) : this() //2:1
        {
            this.Instances = instances;
        }

        private Stream __ToStream(string text)
        {
            MemoryStream stream = new MemoryStream();
            StreamWriter writer = new StreamWriter(stream);
            writer.Write(text);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }

        private static IEnumerable<T> __Enumerate<T>(IEnumerator<T> items)
        {
            while (items.MoveNext())
            {
                yield return items.Current;
            }
        }

        private int counter = 0;
        private int NextCounter()
        {
            return ++counter;
        }

        private SpringGeneratorUtil SpringGeneratorUtil = new SpringGeneratorUtil(); //4:1

        public string GeneratePersistence(Namespace ns, List<Struct> entities) //6:1
        {
            StringBuilder __out = new StringBuilder();
            __out.Append("<?xml version=\"1.0\" encoding=\"UTF-8\"?>"); //7:1
            __out.AppendLine(); //7:39
            __out.Append("<persistence xmlns=\"http://java.sun.com/xml/ns/persistence\" version=\"2.0\">"); //8:1
            __out.AppendLine(); //8:75
            string __tmp1Prefix = "    <persistence-unit name=\""; //9:1
            string __tmp2Suffix = "PU\" transaction-type=\"RESOURCE_LOCAL\">"; //9:38
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(ns.Name);
            using(StreamReader __tmp3Reader = new StreamReader(this.__ToStream(__tmp3.ToString())))
            {
                bool __tmp3_first = true;
                while(__tmp3_first || !__tmp3Reader.EndOfStream)
                {
                    __tmp3_first = false;
                    string __tmp3Line = __tmp3Reader.ReadLine();
                    if (__tmp3Line == null)
                    {
                        __tmp3Line = "";
                    }
                    __out.Append(__tmp1Prefix);
                    __out.Append(__tmp3Line);
                    __out.Append(__tmp2Suffix);
                    __out.AppendLine(); //9:76
                }
            }
            __out.Append("        <provider>org.eclipse.persistence.jpa.PersistenceProvider</provider>"); //10:1
            __out.AppendLine(); //10:77
            string __tmp4Prefix = "		<jta-data-source>java:jboss/datasources/"; //12:1
            string __tmp5Suffix = "DS</jta-data-source>"; //12:52
            StringBuilder __tmp6 = new StringBuilder();
            __tmp6.Append(ns.Name);
            using(StreamReader __tmp6Reader = new StreamReader(this.__ToStream(__tmp6.ToString())))
            {
                bool __tmp6_first = true;
                while(__tmp6_first || !__tmp6Reader.EndOfStream)
                {
                    __tmp6_first = false;
                    string __tmp6Line = __tmp6Reader.ReadLine();
                    if (__tmp6Line == null)
                    {
                        __tmp6Line = "";
                    }
                    __out.Append(__tmp4Prefix);
                    __out.Append(__tmp6Line);
                    __out.Append(__tmp5Suffix);
                    __out.AppendLine(); //12:72
                }
            }
            __out.AppendLine(); //14:3
            var __loop1_results = 
                (from entity in __Enumerate((entities).GetEnumerator()) //15:9
                select new { entity = entity}
                ).ToList(); //15:3
            int __loop1_iteration = 0;
            foreach (var __tmp7 in __loop1_results)
            {
                ++__loop1_iteration;
                var entity = __tmp7.entity;
                string __tmp8Prefix = "		<class>"; //16:1
                string __tmp9Suffix = "</class>"; //16:111
                StringBuilder __tmp10 = new StringBuilder();
                __tmp10.Append(SpringGeneratorUtil.GetPackage(entity));
                using(StreamReader __tmp10Reader = new StreamReader(this.__ToStream(__tmp10.ToString())))
                {
                    bool __tmp10_first = true;
                    while(__tmp10_first || !__tmp10Reader.EndOfStream)
                    {
                        __tmp10_first = false;
                        string __tmp10Line = __tmp10Reader.ReadLine();
                        if (__tmp10Line == null)
                        {
                            __tmp10Line = "";
                        }
                        __out.Append(__tmp8Prefix);
                        __out.Append(__tmp10Line);
                    }
                }
                string __tmp11Line = "."; //16:50
                __out.Append(__tmp11Line);
                StringBuilder __tmp12 = new StringBuilder();
                __tmp12.Append(SpringGeneratorUtil.Properties.entityPackage);
                using(StreamReader __tmp12Reader = new StreamReader(this.__ToStream(__tmp12.ToString())))
                {
                    bool __tmp12_first = true;
                    while(__tmp12_first || !__tmp12Reader.EndOfStream)
                    {
                        __tmp12_first = false;
                        string __tmp12Line = __tmp12Reader.ReadLine();
                        if (__tmp12Line == null)
                        {
                            __tmp12Line = "";
                        }
                        __out.Append(__tmp12Line);
                    }
                }
                string __tmp13Line = "."; //16:97
                __out.Append(__tmp13Line);
                StringBuilder __tmp14 = new StringBuilder();
                __tmp14.Append(entity.Name);
                using(StreamReader __tmp14Reader = new StreamReader(this.__ToStream(__tmp14.ToString())))
                {
                    bool __tmp14_first = true;
                    while(__tmp14_first || !__tmp14Reader.EndOfStream)
                    {
                        __tmp14_first = false;
                        string __tmp14Line = __tmp14Reader.ReadLine();
                        if (__tmp14Line == null)
                        {
                            __tmp14Line = "";
                        }
                        __out.Append(__tmp14Line);
                        __out.Append(__tmp9Suffix);
                        __out.AppendLine(); //16:119
                    }
                }
            }
            __out.AppendLine(); //18:2
            __out.Append("        <class>iit.cinema.status.ReservationStatus</class>"); //19:1
            __out.AppendLine(); //19:59
            __out.Append("        <class>iit.cinema.status.SeatStatus</class>"); //20:1
            __out.AppendLine(); //20:52
            __out.AppendLine(); //21:3
            __out.Append("        <shared-cache-mode>NONE</shared-cache-mode>"); //22:1
            __out.AppendLine(); //22:52
            __out.AppendLine(); //23:3
            __out.Append("        <properties>"); //24:1
            __out.AppendLine(); //24:21
            __out.Append("            <!--for debug-->"); //25:1
            __out.AppendLine(); //25:29
            __out.Append("            <property name=\"eclipselink.ddl-generation\" value=\"create-tables\"/>"); //26:1
            __out.AppendLine(); //26:80
            __out.Append("            <!--<property name=\"eclipselink.logging.level\" value=\"FINE\"/>-->"); //27:1
            __out.AppendLine(); //27:77
            __out.Append("        </properties>"); //28:1
            __out.AppendLine(); //28:22
            __out.Append("    </persistence-unit>"); //29:1
            __out.AppendLine(); //29:24
            __out.Append("</persistence>"); //30:1
            __out.AppendLine(); //30:15
            return __out.ToString();
        }

        public string generateMasterPom(Namespace ns, List<string> modules) //33:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp1Prefix = string.Empty;
            string __tmp2Suffix = string.Empty;
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(SpringGeneratorUtil.GeneratePomStart());
            using(StreamReader __tmp3Reader = new StreamReader(this.__ToStream(__tmp3.ToString())))
            {
                bool __tmp3_first = true;
                while(__tmp3_first || !__tmp3Reader.EndOfStream)
                {
                    __tmp3_first = false;
                    string __tmp3Line = __tmp3Reader.ReadLine();
                    if (__tmp3Line == null)
                    {
                        __tmp3Line = "";
                    }
                    __out.Append(__tmp1Prefix);
                    __out.Append(__tmp3Line);
                    __out.Append(__tmp2Suffix);
                    __out.AppendLine(); //34:41
                }
            }
            __out.AppendLine(); //35:1
            __out.Append("    <properties>"); //36:1
            __out.AppendLine(); //36:17
            __out.Append("        <springframework.version>4.1.6.RELEASE</springframework.version>"); //37:1
            __out.AppendLine(); //37:73
            __out.Append("        <spring-data-jpa.version>1.9.0.RELEASE</spring-data-jpa.version>"); //38:1
            __out.AppendLine(); //38:73
            __out.Append("        <!--<spring-security.version>4.0.2.RELEASE</spring-security.version>-->"); //39:1
            __out.AppendLine(); //39:80
            __out.Append("    </properties>"); //40:1
            __out.AppendLine(); //40:18
            __out.AppendLine(); //41:1
            string __tmp4Prefix = "    <groupId>"; //42:1
            string __tmp5Suffix = "</groupId>"; //42:23
            StringBuilder __tmp6 = new StringBuilder();
            __tmp6.Append(ns.Name);
            using(StreamReader __tmp6Reader = new StreamReader(this.__ToStream(__tmp6.ToString())))
            {
                bool __tmp6_first = true;
                while(__tmp6_first || !__tmp6Reader.EndOfStream)
                {
                    __tmp6_first = false;
                    string __tmp6Line = __tmp6Reader.ReadLine();
                    if (__tmp6Line == null)
                    {
                        __tmp6Line = "";
                    }
                    __out.Append(__tmp4Prefix);
                    __out.Append(__tmp6Line);
                    __out.Append(__tmp5Suffix);
                    __out.AppendLine(); //42:33
                }
            }
            string __tmp7Prefix = "    <artifactId>"; //43:1
            string __tmp8Suffix = "App</artifactId>"; //43:26
            StringBuilder __tmp9 = new StringBuilder();
            __tmp9.Append(ns.Name);
            using(StreamReader __tmp9Reader = new StreamReader(this.__ToStream(__tmp9.ToString())))
            {
                bool __tmp9_first = true;
                while(__tmp9_first || !__tmp9Reader.EndOfStream)
                {
                    __tmp9_first = false;
                    string __tmp9Line = __tmp9Reader.ReadLine();
                    if (__tmp9Line == null)
                    {
                        __tmp9Line = "";
                    }
                    __out.Append(__tmp7Prefix);
                    __out.Append(__tmp9Line);
                    __out.Append(__tmp8Suffix);
                    __out.AppendLine(); //43:42
                }
            }
            __out.Append("    <packaging>pom</packaging>"); //44:1
            __out.AppendLine(); //44:31
            __out.Append("    <version>1.0</version>"); //45:1
            __out.AppendLine(); //45:27
            __out.Append("    <modules>"); //46:1
            __out.AppendLine(); //46:14
            var __loop2_results = 
                (from module in __Enumerate((modules).GetEnumerator()) //47:8
                select new { module = module}
                ).ToList(); //47:2
            int __loop2_iteration = 0;
            foreach (var __tmp10 in __loop2_results)
            {
                ++__loop2_iteration;
                var module = __tmp10.module;
                string __tmp11Prefix = "        <module>"; //48:1
                string __tmp12Suffix = "</module>"; //48:35
                StringBuilder __tmp13 = new StringBuilder();
                __tmp13.Append(ns.Name);
                using(StreamReader __tmp13Reader = new StreamReader(this.__ToStream(__tmp13.ToString())))
                {
                    bool __tmp13_first = true;
                    while(__tmp13_first || !__tmp13Reader.EndOfStream)
                    {
                        __tmp13_first = false;
                        string __tmp13Line = __tmp13Reader.ReadLine();
                        if (__tmp13Line == null)
                        {
                            __tmp13Line = "";
                        }
                        __out.Append(__tmp11Prefix);
                        __out.Append(__tmp13Line);
                    }
                }
                string __tmp14Line = "-"; //48:26
                __out.Append(__tmp14Line);
                StringBuilder __tmp15 = new StringBuilder();
                __tmp15.Append(module);
                using(StreamReader __tmp15Reader = new StreamReader(this.__ToStream(__tmp15.ToString())))
                {
                    bool __tmp15_first = true;
                    while(__tmp15_first || !__tmp15Reader.EndOfStream)
                    {
                        __tmp15_first = false;
                        string __tmp15Line = __tmp15Reader.ReadLine();
                        if (__tmp15Line == null)
                        {
                            __tmp15Line = "";
                        }
                        __out.Append(__tmp15Line);
                        __out.Append(__tmp12Suffix);
                        __out.AppendLine(); //48:44
                    }
                }
            }
            __out.Append("    </modules>"); //50:1
            __out.AppendLine(); //50:15
            __out.AppendLine(); //51:1
            __out.Append("    <dependencies>"); //52:1
            __out.AppendLine(); //52:19
            __out.Append("        <!-- eclipseLink -->"); //53:1
            __out.AppendLine(); //53:29
            string __tmp16Prefix = "		"; //54:1
            string __tmp17Suffix = string.Empty; 
            StringBuilder __tmp18 = new StringBuilder();
            __tmp18.Append(SpringGeneratorUtil.GeneratePomDependency("org.eclipse.persistence", "javax.persistence", "2.1.0"));
            using(StreamReader __tmp18Reader = new StreamReader(this.__ToStream(__tmp18.ToString())))
            {
                bool __tmp18_first = true;
                while(__tmp18_first || !__tmp18Reader.EndOfStream)
                {
                    __tmp18_first = false;
                    string __tmp18Line = __tmp18Reader.ReadLine();
                    if (__tmp18Line == null)
                    {
                        __tmp18Line = "";
                    }
                    __out.Append(__tmp16Prefix);
                    __out.Append(__tmp18Line);
                    __out.Append(__tmp17Suffix);
                    __out.AppendLine(); //54:103
                }
            }
            string __tmp19Prefix = "		"; //55:1
            string __tmp20Suffix = string.Empty; 
            StringBuilder __tmp21 = new StringBuilder();
            __tmp21.Append(SpringGeneratorUtil.GeneratePomDependency("org.eclipse.persistence", "eclipselink", "2.6.2"));
            using(StreamReader __tmp21Reader = new StreamReader(this.__ToStream(__tmp21.ToString())))
            {
                bool __tmp21_first = true;
                while(__tmp21_first || !__tmp21Reader.EndOfStream)
                {
                    __tmp21_first = false;
                    string __tmp21Line = __tmp21Reader.ReadLine();
                    if (__tmp21Line == null)
                    {
                        __tmp21Line = "";
                    }
                    __out.Append(__tmp19Prefix);
                    __out.Append(__tmp21Line);
                    __out.Append(__tmp20Suffix);
                    __out.AppendLine(); //55:97
                }
            }
            __out.Append("    </dependencies>"); //56:1
            __out.AppendLine(); //56:20
            __out.Append("</project>"); //57:1
            __out.AppendLine(); //57:11
            return __out.ToString();
        }

        public string generateComponentPom(Namespace ns, string moduleName, List<string> modules) //60:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp1Prefix = string.Empty;
            string __tmp2Suffix = string.Empty;
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(SpringGeneratorUtil.GeneratePomStart());
            using(StreamReader __tmp3Reader = new StreamReader(this.__ToStream(__tmp3.ToString())))
            {
                bool __tmp3_first = true;
                while(__tmp3_first || !__tmp3Reader.EndOfStream)
                {
                    __tmp3_first = false;
                    string __tmp3Line = __tmp3Reader.ReadLine();
                    if (__tmp3Line == null)
                    {
                        __tmp3Line = "";
                    }
                    __out.Append(__tmp1Prefix);
                    __out.Append(__tmp3Line);
                    __out.Append(__tmp2Suffix);
                    __out.AppendLine(); //61:41
                }
            }
            __out.Append("    <parent>"); //62:1
            __out.AppendLine(); //62:13
            string __tmp4Prefix = "        <artifactId>"; //63:1
            string __tmp5Suffix = "App</artifactId>"; //63:30
            StringBuilder __tmp6 = new StringBuilder();
            __tmp6.Append(ns.Name);
            using(StreamReader __tmp6Reader = new StreamReader(this.__ToStream(__tmp6.ToString())))
            {
                bool __tmp6_first = true;
                while(__tmp6_first || !__tmp6Reader.EndOfStream)
                {
                    __tmp6_first = false;
                    string __tmp6Line = __tmp6Reader.ReadLine();
                    if (__tmp6Line == null)
                    {
                        __tmp6Line = "";
                    }
                    __out.Append(__tmp4Prefix);
                    __out.Append(__tmp6Line);
                    __out.Append(__tmp5Suffix);
                    __out.AppendLine(); //63:46
                }
            }
            string __tmp7Prefix = "        <groupId>"; //64:1
            string __tmp8Suffix = "</groupId>"; //64:27
            StringBuilder __tmp9 = new StringBuilder();
            __tmp9.Append(ns.Name);
            using(StreamReader __tmp9Reader = new StreamReader(this.__ToStream(__tmp9.ToString())))
            {
                bool __tmp9_first = true;
                while(__tmp9_first || !__tmp9Reader.EndOfStream)
                {
                    __tmp9_first = false;
                    string __tmp9Line = __tmp9Reader.ReadLine();
                    if (__tmp9Line == null)
                    {
                        __tmp9Line = "";
                    }
                    __out.Append(__tmp7Prefix);
                    __out.Append(__tmp9Line);
                    __out.Append(__tmp8Suffix);
                    __out.AppendLine(); //64:37
                }
            }
            __out.Append("        <version>1.0</version>"); //65:1
            __out.AppendLine(); //65:31
            __out.Append("    </parent>"); //66:1
            __out.AppendLine(); //66:14
            string __tmp10Prefix = "    <artifactId>"; //68:1
            string __tmp11Suffix = "</artifactId>"; //68:39
            StringBuilder __tmp12 = new StringBuilder();
            __tmp12.Append(ns.Name);
            using(StreamReader __tmp12Reader = new StreamReader(this.__ToStream(__tmp12.ToString())))
            {
                bool __tmp12_first = true;
                while(__tmp12_first || !__tmp12Reader.EndOfStream)
                {
                    __tmp12_first = false;
                    string __tmp12Line = __tmp12Reader.ReadLine();
                    if (__tmp12Line == null)
                    {
                        __tmp12Line = "";
                    }
                    __out.Append(__tmp10Prefix);
                    __out.Append(__tmp12Line);
                }
            }
            string __tmp13Line = "-"; //68:26
            __out.Append(__tmp13Line);
            StringBuilder __tmp14 = new StringBuilder();
            __tmp14.Append(moduleName);
            using(StreamReader __tmp14Reader = new StreamReader(this.__ToStream(__tmp14.ToString())))
            {
                bool __tmp14_first = true;
                while(__tmp14_first || !__tmp14Reader.EndOfStream)
                {
                    __tmp14_first = false;
                    string __tmp14Line = __tmp14Reader.ReadLine();
                    if (__tmp14Line == null)
                    {
                        __tmp14Line = "";
                    }
                    __out.Append(__tmp14Line);
                    __out.Append(__tmp11Suffix);
                    __out.AppendLine(); //68:52
                }
            }
            __out.Append("    <dependencies>"); //70:1
            __out.AppendLine(); //70:19
            string __tmp15Prefix = "        "; //71:1
            string __tmp16Suffix = string.Empty; 
            StringBuilder __tmp17 = new StringBuilder();
            __tmp17.Append(SpringGeneratorUtil.GeneratePomDependency(ns.Name, ns.Name + "-Commons", "1.0"));
            using(StreamReader __tmp17Reader = new StreamReader(this.__ToStream(__tmp17.ToString())))
            {
                bool __tmp17_first = true;
                while(__tmp17_first || !__tmp17Reader.EndOfStream)
                {
                    __tmp17_first = false;
                    string __tmp17Line = __tmp17Reader.ReadLine();
                    if (__tmp17Line == null)
                    {
                        __tmp17Line = "";
                    }
                    __out.Append(__tmp15Prefix);
                    __out.Append(__tmp17Line);
                    __out.Append(__tmp16Suffix);
                    __out.AppendLine(); //71:88
                }
            }
            string __tmp18Prefix = "		"; //72:1
            string __tmp19Suffix = string.Empty; 
            StringBuilder __tmp20 = new StringBuilder();
            __tmp20.Append(SpringGeneratorUtil.GeneratePomDependency(ns.Name, ns.Name + "-Data", "1.0"));
            using(StreamReader __tmp20Reader = new StreamReader(this.__ToStream(__tmp20.ToString())))
            {
                bool __tmp20_first = true;
                while(__tmp20_first || !__tmp20Reader.EndOfStream)
                {
                    __tmp20_first = false;
                    string __tmp20Line = __tmp20Reader.ReadLine();
                    if (__tmp20Line == null)
                    {
                        __tmp20Line = "";
                    }
                    __out.Append(__tmp18Prefix);
                    __out.Append(__tmp20Line);
                    __out.Append(__tmp19Suffix);
                    __out.AppendLine(); //72:79
                }
            }
            var __loop3_results = 
                (from module in __Enumerate((modules).GetEnumerator()) //74:8
                select new { module = module}
                ).ToList(); //74:2
            int __loop3_iteration = 0;
            foreach (var __tmp21 in __loop3_results)
            {
                ++__loop3_iteration;
                var module = __tmp21.module;
                string __tmp22Prefix = "		"; //75:1
                string __tmp23Suffix = string.Empty; 
                StringBuilder __tmp24 = new StringBuilder();
                __tmp24.Append(SpringGeneratorUtil.GeneratePomDependency(ns.Name, ns.Name + "-" + module, "1.0"));
                using(StreamReader __tmp24Reader = new StreamReader(this.__ToStream(__tmp24.ToString())))
                {
                    bool __tmp24_first = true;
                    while(__tmp24_first || !__tmp24Reader.EndOfStream)
                    {
                        __tmp24_first = false;
                        string __tmp24Line = __tmp24Reader.ReadLine();
                        if (__tmp24Line == null)
                        {
                            __tmp24Line = "";
                        }
                        __out.Append(__tmp22Prefix);
                        __out.Append(__tmp24Line);
                        __out.Append(__tmp23Suffix);
                        __out.AppendLine(); //75:82
                    }
                }
            }
            string __tmp25Prefix = "        "; //78:1
            string __tmp26Suffix = string.Empty; 
            StringBuilder __tmp27 = new StringBuilder();
            __tmp27.Append(SpringGeneratorUtil.GeneratePomDependency("org.springframework", "spring-context", "${springframework.version}"));
            using(StreamReader __tmp27Reader = new StreamReader(this.__ToStream(__tmp27.ToString())))
            {
                bool __tmp27_first = true;
                while(__tmp27_first || !__tmp27Reader.EndOfStream)
                {
                    __tmp27_first = false;
                    string __tmp27Line = __tmp27Reader.ReadLine();
                    if (__tmp27Line == null)
                    {
                        __tmp27Line = "";
                    }
                    __out.Append(__tmp25Prefix);
                    __out.Append(__tmp27Line);
                    __out.Append(__tmp26Suffix);
                    __out.AppendLine(); //78:123
                }
            }
            __out.Append("    </dependencies>"); //79:1
            __out.AppendLine(); //79:20
            __out.Append("</project>"); //80:1
            __out.AppendLine(); //80:11
            return __out.ToString();
        }

        public string generateDataPom(Namespace ns) //83:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp1Prefix = string.Empty;
            string __tmp2Suffix = string.Empty;
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(SpringGeneratorUtil.GeneratePomStart());
            using(StreamReader __tmp3Reader = new StreamReader(this.__ToStream(__tmp3.ToString())))
            {
                bool __tmp3_first = true;
                while(__tmp3_first || !__tmp3Reader.EndOfStream)
                {
                    __tmp3_first = false;
                    string __tmp3Line = __tmp3Reader.ReadLine();
                    if (__tmp3Line == null)
                    {
                        __tmp3Line = "";
                    }
                    __out.Append(__tmp1Prefix);
                    __out.Append(__tmp3Line);
                    __out.Append(__tmp2Suffix);
                    __out.AppendLine(); //84:41
                }
            }
            __out.Append("    <parent>"); //85:1
            __out.AppendLine(); //85:13
            string __tmp4Prefix = "        <artifactId>"; //86:1
            string __tmp5Suffix = "App</artifactId>"; //86:30
            StringBuilder __tmp6 = new StringBuilder();
            __tmp6.Append(ns.Name);
            using(StreamReader __tmp6Reader = new StreamReader(this.__ToStream(__tmp6.ToString())))
            {
                bool __tmp6_first = true;
                while(__tmp6_first || !__tmp6Reader.EndOfStream)
                {
                    __tmp6_first = false;
                    string __tmp6Line = __tmp6Reader.ReadLine();
                    if (__tmp6Line == null)
                    {
                        __tmp6Line = "";
                    }
                    __out.Append(__tmp4Prefix);
                    __out.Append(__tmp6Line);
                    __out.Append(__tmp5Suffix);
                    __out.AppendLine(); //86:46
                }
            }
            string __tmp7Prefix = "        <groupId>"; //87:1
            string __tmp8Suffix = "</groupId>"; //87:27
            StringBuilder __tmp9 = new StringBuilder();
            __tmp9.Append(ns.Name);
            using(StreamReader __tmp9Reader = new StreamReader(this.__ToStream(__tmp9.ToString())))
            {
                bool __tmp9_first = true;
                while(__tmp9_first || !__tmp9Reader.EndOfStream)
                {
                    __tmp9_first = false;
                    string __tmp9Line = __tmp9Reader.ReadLine();
                    if (__tmp9Line == null)
                    {
                        __tmp9Line = "";
                    }
                    __out.Append(__tmp7Prefix);
                    __out.Append(__tmp9Line);
                    __out.Append(__tmp8Suffix);
                    __out.AppendLine(); //87:37
                }
            }
            __out.Append("        <version>1.0</version>"); //88:1
            __out.AppendLine(); //88:31
            __out.Append("    </parent>"); //89:1
            __out.AppendLine(); //89:14
            string __tmp10Prefix = "    <artifactId>"; //91:1
            string __tmp11Suffix = "-Data</artifactId>"; //91:26
            StringBuilder __tmp12 = new StringBuilder();
            __tmp12.Append(ns.Name);
            using(StreamReader __tmp12Reader = new StreamReader(this.__ToStream(__tmp12.ToString())))
            {
                bool __tmp12_first = true;
                while(__tmp12_first || !__tmp12Reader.EndOfStream)
                {
                    __tmp12_first = false;
                    string __tmp12Line = __tmp12Reader.ReadLine();
                    if (__tmp12Line == null)
                    {
                        __tmp12Line = "";
                    }
                    __out.Append(__tmp10Prefix);
                    __out.Append(__tmp12Line);
                    __out.Append(__tmp11Suffix);
                    __out.AppendLine(); //91:44
                }
            }
            __out.Append("    <dependencies>"); //93:1
            __out.AppendLine(); //93:19
            string __tmp13Prefix = "		"; //94:1
            string __tmp14Suffix = string.Empty; 
            StringBuilder __tmp15 = new StringBuilder();
            __tmp15.Append(SpringGeneratorUtil.GeneratePomDependency(ns.Name, ns.Name + "-Commons", "1.0"));
            using(StreamReader __tmp15Reader = new StreamReader(this.__ToStream(__tmp15.ToString())))
            {
                bool __tmp15_first = true;
                while(__tmp15_first || !__tmp15Reader.EndOfStream)
                {
                    __tmp15_first = false;
                    string __tmp15Line = __tmp15Reader.ReadLine();
                    if (__tmp15Line == null)
                    {
                        __tmp15Line = "";
                    }
                    __out.Append(__tmp13Prefix);
                    __out.Append(__tmp15Line);
                    __out.Append(__tmp14Suffix);
                    __out.AppendLine(); //94:82
                }
            }
            __out.Append("		<!-- spring data -->"); //95:1
            __out.AppendLine(); //95:23
            string __tmp16Prefix = "		"; //96:1
            string __tmp17Suffix = string.Empty; 
            StringBuilder __tmp18 = new StringBuilder();
            __tmp18.Append(SpringGeneratorUtil.GeneratePomDependency("org.springframework", "spring-orm", "${springframework.version}"));
            using(StreamReader __tmp18Reader = new StreamReader(this.__ToStream(__tmp18.ToString())))
            {
                bool __tmp18_first = true;
                while(__tmp18_first || !__tmp18Reader.EndOfStream)
                {
                    __tmp18_first = false;
                    string __tmp18Line = __tmp18Reader.ReadLine();
                    if (__tmp18Line == null)
                    {
                        __tmp18Line = "";
                    }
                    __out.Append(__tmp16Prefix);
                    __out.Append(__tmp18Line);
                    __out.Append(__tmp17Suffix);
                    __out.AppendLine(); //96:112
                }
            }
            string __tmp19Prefix = "		"; //97:1
            string __tmp20Suffix = string.Empty; 
            StringBuilder __tmp21 = new StringBuilder();
            __tmp21.Append(SpringGeneratorUtil.GeneratePomDependency("org.springframework.data", "spring-data-jpa", "${spring-data-jpa.version}"));
            using(StreamReader __tmp21Reader = new StreamReader(this.__ToStream(__tmp21.ToString())))
            {
                bool __tmp21_first = true;
                while(__tmp21_first || !__tmp21Reader.EndOfStream)
                {
                    __tmp21_first = false;
                    string __tmp21Line = __tmp21Reader.ReadLine();
                    if (__tmp21Line == null)
                    {
                        __tmp21Line = "";
                    }
                    __out.Append(__tmp19Prefix);
                    __out.Append(__tmp21Line);
                    __out.Append(__tmp20Suffix);
                    __out.AppendLine(); //97:123
                }
            }
            __out.Append("          <!--  <exclusions>"); //98:1
            __out.AppendLine(); //98:29
            __out.Append("                <exclusion>"); //99:1
            __out.AppendLine(); //99:28
            __out.Append("                    <groupId>org.springframework</groupId>"); //100:1
            __out.AppendLine(); //100:59
            __out.Append("                    <artifactId>spring-orm</artifactId>"); //101:1
            __out.AppendLine(); //101:56
            __out.Append("                </exclusion>"); //102:1
            __out.AppendLine(); //102:29
            __out.Append("            </exclusions> -->"); //103:1
            __out.AppendLine(); //103:30
            __out.Append("	</dependencies>"); //104:1
            __out.AppendLine(); //104:17
            __out.Append("</project>"); //105:1
            __out.AppendLine(); //105:11
            return __out.ToString();
        }

        public string generateComponentSpringConfig(Namespace ns) //108:1
        {
            StringBuilder __out = new StringBuilder();
            __out.Append("<?xml version=\"1.0\" encoding=\"UTF-8\"?>"); //109:1
            __out.AppendLine(); //109:39
            __out.Append("<beans xmlns=\"http://www.springframework.org/schema/beans\""); //110:1
            __out.AppendLine(); //110:59
            __out.Append("       xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\""); //111:1
            __out.AppendLine(); //111:61
            __out.Append("       xmlns:context=\"http://www.springframework.org/schema/context\""); //112:1
            __out.AppendLine(); //112:69
            __out.Append("       xmlns:jpa=\"http://www.springframework.org/schema/data/jpa\""); //113:1
            __out.AppendLine(); //113:66
            __out.Append("       xsi:schemaLocation=\"http://www.springframework.org/schema/beans"); //114:1
            __out.AppendLine(); //114:71
            __out.Append("       http://www.springframework.org/schema/beans/spring-beans.xsd"); //115:1
            __out.AppendLine(); //115:68
            __out.Append("       http://www.springframework.org/schema/context"); //116:1
            __out.AppendLine(); //116:53
            __out.Append("       http://www.springframework.org/schema/context/spring-context.xsd"); //117:1
            __out.AppendLine(); //117:72
            __out.Append("       http://www.springframework.org/schema/data/jpa"); //118:1
            __out.AppendLine(); //118:54
            __out.Append("       http://www.springframework.org/schema/data/jpa/spring-jpa.xsd\">"); //119:1
            __out.AppendLine(); //119:71
            __out.AppendLine(); //120:5
            string __tmp1Prefix = "       <jpa:repositories base-package=\""; //121:1
            string __tmp2Suffix = "\"/>"; //121:114
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(ns.FullName.ToLower());
            using(StreamReader __tmp3Reader = new StreamReader(this.__ToStream(__tmp3.ToString())))
            {
                bool __tmp3_first = true;
                while(__tmp3_first || !__tmp3Reader.EndOfStream)
                {
                    __tmp3_first = false;
                    string __tmp3Line = __tmp3Reader.ReadLine();
                    if (__tmp3Line == null)
                    {
                        __tmp3Line = "";
                    }
                    __out.Append(__tmp1Prefix);
                    __out.Append(__tmp3Line);
                }
            }
            string __tmp4Line = "."; //121:63
            __out.Append(__tmp4Line);
            StringBuilder __tmp5 = new StringBuilder();
            __tmp5.Append(SpringGeneratorUtil.Properties.repositoryPackage);
            using(StreamReader __tmp5Reader = new StreamReader(this.__ToStream(__tmp5.ToString())))
            {
                bool __tmp5_first = true;
                while(__tmp5_first || !__tmp5Reader.EndOfStream)
                {
                    __tmp5_first = false;
                    string __tmp5Line = __tmp5Reader.ReadLine();
                    if (__tmp5Line == null)
                    {
                        __tmp5Line = "";
                    }
                    __out.Append(__tmp5Line);
                    __out.Append(__tmp2Suffix);
                    __out.AppendLine(); //121:117
                }
            }
            string __tmp6Prefix = "       <context:component-scan base-package=\""; //122:1
            string __tmp7Suffix = "\"/>"; //122:123
            StringBuilder __tmp8 = new StringBuilder();
            __tmp8.Append(ns.FullName.ToLower());
            using(StreamReader __tmp8Reader = new StreamReader(this.__ToStream(__tmp8.ToString())))
            {
                bool __tmp8_first = true;
                while(__tmp8_first || !__tmp8Reader.EndOfStream)
                {
                    __tmp8_first = false;
                    string __tmp8Line = __tmp8Reader.ReadLine();
                    if (__tmp8Line == null)
                    {
                        __tmp8Line = "";
                    }
                    __out.Append(__tmp6Prefix);
                    __out.Append(__tmp8Line);
                }
            }
            string __tmp9Line = "."; //122:69
            __out.Append(__tmp9Line);
            StringBuilder __tmp10 = new StringBuilder();
            __tmp10.Append(SpringGeneratorUtil.Properties.serviceFacadePackage);
            using(StreamReader __tmp10Reader = new StreamReader(this.__ToStream(__tmp10.ToString())))
            {
                bool __tmp10_first = true;
                while(__tmp10_first || !__tmp10Reader.EndOfStream)
                {
                    __tmp10_first = false;
                    string __tmp10Line = __tmp10Reader.ReadLine();
                    if (__tmp10Line == null)
                    {
                        __tmp10Line = "";
                    }
                    __out.Append(__tmp10Line);
                    __out.Append(__tmp7Suffix);
                    __out.AppendLine(); //122:126
                }
            }
            __out.Append("</beans>"); //123:1
            __out.AppendLine(); //123:9
            return __out.ToString();
        }

        public string generateDataSpringConfig(Namespace ns) //126:1
        {
            StringBuilder __out = new StringBuilder();
            __out.Append("<?xml version=\"1.0\" encoding=\"UTF-8\"?>"); //127:1
            __out.AppendLine(); //127:39
            __out.Append("<beans xmlns=\"http://www.springframework.org/schema/beans\""); //128:1
            __out.AppendLine(); //128:59
            __out.Append("       xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\""); //129:1
            __out.AppendLine(); //129:61
            __out.Append("       xmlns:jpa=\"http://www.springframework.org/schema/data/jpa\""); //130:1
            __out.AppendLine(); //130:66
            __out.Append("       xsi:schemaLocation=\"http://www.springframework.org/schema/beans"); //131:1
            __out.AppendLine(); //131:71
            __out.Append("       http://www.springframework.org/schema/beans/spring-beans.xsd"); //132:1
            __out.AppendLine(); //132:68
            __out.Append("       http://www.springframework.org/schema/data/jpa"); //133:1
            __out.AppendLine(); //133:54
            __out.Append("       http://www.springframework.org/schema/data/jpa/spring-jpa.xsd\">"); //134:1
            __out.AppendLine(); //134:71
            __out.AppendLine(); //135:5
            string __tmp1Prefix = "       <jpa:repositories base-package=\""; //136:1
            string __tmp2Suffix = "\"/>"; //136:114
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(ns.FullName.ToLower());
            using(StreamReader __tmp3Reader = new StreamReader(this.__ToStream(__tmp3.ToString())))
            {
                bool __tmp3_first = true;
                while(__tmp3_first || !__tmp3Reader.EndOfStream)
                {
                    __tmp3_first = false;
                    string __tmp3Line = __tmp3Reader.ReadLine();
                    if (__tmp3Line == null)
                    {
                        __tmp3Line = "";
                    }
                    __out.Append(__tmp1Prefix);
                    __out.Append(__tmp3Line);
                }
            }
            string __tmp4Line = "."; //136:63
            __out.Append(__tmp4Line);
            StringBuilder __tmp5 = new StringBuilder();
            __tmp5.Append(SpringGeneratorUtil.Properties.repositoryPackage);
            using(StreamReader __tmp5Reader = new StreamReader(this.__ToStream(__tmp5.ToString())))
            {
                bool __tmp5_first = true;
                while(__tmp5_first || !__tmp5Reader.EndOfStream)
                {
                    __tmp5_first = false;
                    string __tmp5Line = __tmp5Reader.ReadLine();
                    if (__tmp5Line == null)
                    {
                        __tmp5Line = "";
                    }
                    __out.Append(__tmp5Line);
                    __out.Append(__tmp2Suffix);
                    __out.AppendLine(); //136:117
                }
            }
            __out.AppendLine(); //137:8
            __out.Append("       <bean id=\"jpaVendorAdapter\" class=\"org.springframework.orm.jpa.vendor.EclipseLinkJpaVendorAdapter\"/>"); //138:1
            __out.AppendLine(); //138:108
            __out.Append("       <bean id=\"entityManagerFactory\" class=\"org.springframework.orm.jpa.LocalEntityManagerFactoryBean\">"); //139:1
            __out.AppendLine(); //139:106
            string __tmp6Prefix = "              <property name=\"persistenceUnitName\" value=\""; //140:1
            string __tmp7Suffix = "PU\"/>"; //140:68
            StringBuilder __tmp8 = new StringBuilder();
            __tmp8.Append(ns.Name);
            using(StreamReader __tmp8Reader = new StreamReader(this.__ToStream(__tmp8.ToString())))
            {
                bool __tmp8_first = true;
                while(__tmp8_first || !__tmp8Reader.EndOfStream)
                {
                    __tmp8_first = false;
                    string __tmp8Line = __tmp8Reader.ReadLine();
                    if (__tmp8Line == null)
                    {
                        __tmp8Line = "";
                    }
                    __out.Append(__tmp6Prefix);
                    __out.Append(__tmp8Line);
                    __out.Append(__tmp7Suffix);
                    __out.AppendLine(); //140:73
                }
            }
            __out.Append("              <property name=\"jpaVendorAdapter\" ref=\"jpaVendorAdapter\"/>"); //141:1
            __out.AppendLine(); //141:73
            __out.Append("       </bean>"); //142:1
            __out.AppendLine(); //142:15
            __out.Append("       <bean id=\"transactionManager\" class=\"org.springframework.orm.jpa.JpaTransactionManager\">"); //143:1
            __out.AppendLine(); //143:96
            __out.Append("              <property name=\"entityManagerFactory\" ref=\"entityManagerFactory\"/>"); //144:1
            __out.AppendLine(); //144:81
            __out.Append("       </bean>"); //145:1
            __out.AppendLine(); //145:15
            __out.Append("</beans>"); //146:1
            __out.AppendLine(); //146:9
            return __out.ToString();
        }

    }
}
