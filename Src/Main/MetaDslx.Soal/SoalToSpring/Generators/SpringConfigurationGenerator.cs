using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Soal //1:1
{
    using __Hidden_SpringConfigurationGenerator_279590198;
    namespace __Hidden_SpringConfigurationGenerator_279590198
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
            __out.AppendLine(false); //7:39
            __out.Append("<persistence xmlns=\"http://java.sun.com/xml/ns/persistence\" version=\"2.0\">"); //8:1
            __out.AppendLine(false); //8:75
            string __tmp2Line = "    <persistence-unit name=\""; //9:1
            if (__tmp2Line != null) __out.Append(__tmp2Line);
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(ns.Name);
            using(StreamReader __tmp3Reader = new StreamReader(this.__ToStream(__tmp3.ToString())))
            {
                bool __tmp3_first = true;
                bool __tmp3_last = __tmp3Reader.EndOfStream;
                while(__tmp3_first || !__tmp3_last)
                {
                    __tmp3_first = false;
                    string __tmp3Line = __tmp3Reader.ReadLine();
                    __tmp3_last = __tmp3Reader.EndOfStream;
                    if (__tmp3Line != null) __out.Append(__tmp3Line);
                    if (!__tmp3_last) __out.AppendLine(true);
                }
            }
            string __tmp4Line = "PU\" transaction-type=\"RESOURCE_LOCAL\">"; //9:38
            if (__tmp4Line != null) __out.Append(__tmp4Line);
            __out.AppendLine(false); //9:76
            __out.Append("        <provider>org.eclipse.persistence.jpa.PersistenceProvider</provider>"); //10:1
            __out.AppendLine(false); //10:77
            __out.AppendLine(true); //11:3
            string __tmp6Line = "		<non-jta-data-source>java:jboss/datasources/"; //12:1
            if (__tmp6Line != null) __out.Append(__tmp6Line);
            StringBuilder __tmp7 = new StringBuilder();
            __tmp7.Append(ns.Name);
            using(StreamReader __tmp7Reader = new StreamReader(this.__ToStream(__tmp7.ToString())))
            {
                bool __tmp7_first = true;
                bool __tmp7_last = __tmp7Reader.EndOfStream;
                while(__tmp7_first || !__tmp7_last)
                {
                    __tmp7_first = false;
                    string __tmp7Line = __tmp7Reader.ReadLine();
                    __tmp7_last = __tmp7Reader.EndOfStream;
                    if (__tmp7Line != null) __out.Append(__tmp7Line);
                    if (!__tmp7_last) __out.AppendLine(true);
                }
            }
            string __tmp8Line = "DS</non-jta-data-source>"; //12:56
            if (__tmp8Line != null) __out.Append(__tmp8Line);
            __out.AppendLine(false); //12:80
            __out.AppendLine(true); //13:3
            var __loop1_results = 
                (from entity in __Enumerate((entities).GetEnumerator()) //14:9
                select new { entity = entity}
                ).ToList(); //14:3
            int __loop1_iteration = 0;
            foreach (var __tmp9 in __loop1_results)
            {
                ++__loop1_iteration;
                var entity = __tmp9.entity;
                string __tmp11Line = "		<class>"; //15:1
                if (__tmp11Line != null) __out.Append(__tmp11Line);
                StringBuilder __tmp12 = new StringBuilder();
                __tmp12.Append(SpringGeneratorUtil.GetPackage(entity));
                using(StreamReader __tmp12Reader = new StreamReader(this.__ToStream(__tmp12.ToString())))
                {
                    bool __tmp12_first = true;
                    bool __tmp12_last = __tmp12Reader.EndOfStream;
                    while(__tmp12_first || !__tmp12_last)
                    {
                        __tmp12_first = false;
                        string __tmp12Line = __tmp12Reader.ReadLine();
                        __tmp12_last = __tmp12Reader.EndOfStream;
                        if (__tmp12Line != null) __out.Append(__tmp12Line);
                        if (!__tmp12_last) __out.AppendLine(true);
                    }
                }
                string __tmp13Line = "."; //15:50
                if (__tmp13Line != null) __out.Append(__tmp13Line);
                StringBuilder __tmp14 = new StringBuilder();
                __tmp14.Append(SpringGeneratorUtil.Properties.entityPackage);
                using(StreamReader __tmp14Reader = new StreamReader(this.__ToStream(__tmp14.ToString())))
                {
                    bool __tmp14_first = true;
                    bool __tmp14_last = __tmp14Reader.EndOfStream;
                    while(__tmp14_first || !__tmp14_last)
                    {
                        __tmp14_first = false;
                        string __tmp14Line = __tmp14Reader.ReadLine();
                        __tmp14_last = __tmp14Reader.EndOfStream;
                        if (__tmp14Line != null) __out.Append(__tmp14Line);
                        if (!__tmp14_last) __out.AppendLine(true);
                    }
                }
                string __tmp15Line = "."; //15:97
                if (__tmp15Line != null) __out.Append(__tmp15Line);
                StringBuilder __tmp16 = new StringBuilder();
                __tmp16.Append(entity.Name);
                using(StreamReader __tmp16Reader = new StreamReader(this.__ToStream(__tmp16.ToString())))
                {
                    bool __tmp16_first = true;
                    bool __tmp16_last = __tmp16Reader.EndOfStream;
                    while(__tmp16_first || !__tmp16_last)
                    {
                        __tmp16_first = false;
                        string __tmp16Line = __tmp16Reader.ReadLine();
                        __tmp16_last = __tmp16Reader.EndOfStream;
                        if (__tmp16Line != null) __out.Append(__tmp16Line);
                        if (!__tmp16_last) __out.AppendLine(true);
                    }
                }
                string __tmp17Line = "</class>"; //15:111
                if (__tmp17Line != null) __out.Append(__tmp17Line);
                __out.AppendLine(false); //15:119
            }
            __out.AppendLine(true); //17:3
            __out.Append("        <shared-cache-mode>NONE</shared-cache-mode>"); //18:1
            __out.AppendLine(false); //18:52
            __out.AppendLine(true); //19:3
            __out.Append("        <properties>"); //20:1
            __out.AppendLine(false); //20:21
            __out.Append("            <!--for debug-->"); //21:1
            __out.AppendLine(false); //21:29
            __out.Append("            <property name=\"eclipselink.ddl-generation\" value=\"create-tables\"/>"); //22:1
            __out.AppendLine(false); //22:80
            __out.Append("            <!--<property name=\"eclipselink.logging.level\" value=\"FINE\"/>-->"); //23:1
            __out.AppendLine(false); //23:77
            __out.Append("        </properties>"); //24:1
            __out.AppendLine(false); //24:22
            __out.Append("    </persistence-unit>"); //25:1
            __out.AppendLine(false); //25:24
            __out.Append("</persistence>"); //26:1
            __out.AppendLine(false); //26:15
            return __out.ToString();
        }

        public string GenerateMasterPom(Namespace ns, List<string> modules) //29:1
        {
            StringBuilder __out = new StringBuilder();
            StringBuilder __tmp2 = new StringBuilder();
            __tmp2.Append(GeneratePomStart());
            using(StreamReader __tmp2Reader = new StreamReader(this.__ToStream(__tmp2.ToString())))
            {
                bool __tmp2_first = true;
                bool __tmp2_last = __tmp2Reader.EndOfStream;
                while(__tmp2_first || !__tmp2_last)
                {
                    __tmp2_first = false;
                    string __tmp2Line = __tmp2Reader.ReadLine();
                    __tmp2_last = __tmp2Reader.EndOfStream;
                    if (__tmp2Line != null) __out.Append(__tmp2Line);
                    if (!__tmp2_last) __out.AppendLine(true);
                    __out.AppendLine(false); //30:21
                }
            }
            __out.AppendLine(true); //31:1
            __out.Append("    <properties>"); //32:1
            __out.AppendLine(false); //32:17
            __out.Append("        <springframework.version>4.1.6.RELEASE</springframework.version>"); //33:1
            __out.AppendLine(false); //33:73
            __out.Append("		<springframework.hateoas.version>0.19.0.RELEASE</springframework.hateoas.version>"); //34:1
            __out.AppendLine(false); //34:84
            __out.Append("		<springframework.ws.version>2.2.4.RELEASE</springframework.ws.version>"); //35:1
            __out.AppendLine(false); //35:73
            __out.Append("        <spring-data-jpa.version>1.9.0.RELEASE</spring-data-jpa.version>"); //36:1
            __out.AppendLine(false); //36:73
            __out.Append("		<jackson.version>2.7.4</jackson.version>"); //37:1
            __out.AppendLine(false); //37:43
            __out.Append("		<wsdl4j.version>1.6.3</wsdl4j.version>"); //38:1
            __out.AppendLine(false); //38:41
            __out.Append("		<thymeleaf.version>2.1.4.RELEASE</thymeleaf.version>"); //39:1
            __out.AppendLine(false); //39:55
            __out.Append("        <!--<spring-security.version>4.0.2.RELEASE</spring-security.version>-->"); //40:1
            __out.AppendLine(false); //40:80
            __out.Append("    </properties>"); //41:1
            __out.AppendLine(false); //41:18
            __out.AppendLine(true); //42:1
            string __tmp4Line = "    <groupId>"; //43:1
            if (__tmp4Line != null) __out.Append(__tmp4Line);
            StringBuilder __tmp5 = new StringBuilder();
            __tmp5.Append(ns.Name);
            using(StreamReader __tmp5Reader = new StreamReader(this.__ToStream(__tmp5.ToString())))
            {
                bool __tmp5_first = true;
                bool __tmp5_last = __tmp5Reader.EndOfStream;
                while(__tmp5_first || !__tmp5_last)
                {
                    __tmp5_first = false;
                    string __tmp5Line = __tmp5Reader.ReadLine();
                    __tmp5_last = __tmp5Reader.EndOfStream;
                    if (__tmp5Line != null) __out.Append(__tmp5Line);
                    if (!__tmp5_last) __out.AppendLine(true);
                }
            }
            string __tmp6Line = "</groupId>"; //43:23
            if (__tmp6Line != null) __out.Append(__tmp6Line);
            __out.AppendLine(false); //43:33
            string __tmp8Line = "    <artifactId>"; //44:1
            if (__tmp8Line != null) __out.Append(__tmp8Line);
            StringBuilder __tmp9 = new StringBuilder();
            __tmp9.Append(ns.Name);
            using(StreamReader __tmp9Reader = new StreamReader(this.__ToStream(__tmp9.ToString())))
            {
                bool __tmp9_first = true;
                bool __tmp9_last = __tmp9Reader.EndOfStream;
                while(__tmp9_first || !__tmp9_last)
                {
                    __tmp9_first = false;
                    string __tmp9Line = __tmp9Reader.ReadLine();
                    __tmp9_last = __tmp9Reader.EndOfStream;
                    if (__tmp9Line != null) __out.Append(__tmp9Line);
                    if (!__tmp9_last) __out.AppendLine(true);
                }
            }
            string __tmp10Line = "App</artifactId>"; //44:26
            if (__tmp10Line != null) __out.Append(__tmp10Line);
            __out.AppendLine(false); //44:42
            __out.Append("    <packaging>pom</packaging>"); //45:1
            __out.AppendLine(false); //45:31
            __out.Append("    <version>1.0</version>"); //46:1
            __out.AppendLine(false); //46:27
            __out.Append("    <modules>"); //47:1
            __out.AppendLine(false); //47:14
            var __loop2_results = 
                (from module in __Enumerate((modules).GetEnumerator()) //48:8
                select new { module = module}
                ).ToList(); //48:2
            int __loop2_iteration = 0;
            foreach (var __tmp11 in __loop2_results)
            {
                ++__loop2_iteration;
                var module = __tmp11.module;
                string __tmp13Line = "        <module>"; //49:1
                if (__tmp13Line != null) __out.Append(__tmp13Line);
                StringBuilder __tmp14 = new StringBuilder();
                __tmp14.Append(ns.Name);
                using(StreamReader __tmp14Reader = new StreamReader(this.__ToStream(__tmp14.ToString())))
                {
                    bool __tmp14_first = true;
                    bool __tmp14_last = __tmp14Reader.EndOfStream;
                    while(__tmp14_first || !__tmp14_last)
                    {
                        __tmp14_first = false;
                        string __tmp14Line = __tmp14Reader.ReadLine();
                        __tmp14_last = __tmp14Reader.EndOfStream;
                        if (__tmp14Line != null) __out.Append(__tmp14Line);
                        if (!__tmp14_last) __out.AppendLine(true);
                    }
                }
                string __tmp15Line = "-"; //49:26
                if (__tmp15Line != null) __out.Append(__tmp15Line);
                StringBuilder __tmp16 = new StringBuilder();
                __tmp16.Append(module);
                using(StreamReader __tmp16Reader = new StreamReader(this.__ToStream(__tmp16.ToString())))
                {
                    bool __tmp16_first = true;
                    bool __tmp16_last = __tmp16Reader.EndOfStream;
                    while(__tmp16_first || !__tmp16_last)
                    {
                        __tmp16_first = false;
                        string __tmp16Line = __tmp16Reader.ReadLine();
                        __tmp16_last = __tmp16Reader.EndOfStream;
                        if (__tmp16Line != null) __out.Append(__tmp16Line);
                        if (!__tmp16_last) __out.AppendLine(true);
                    }
                }
                string __tmp17Line = "</module>"; //49:35
                if (__tmp17Line != null) __out.Append(__tmp17Line);
                __out.AppendLine(false); //49:44
            }
            __out.Append("    </modules>"); //51:1
            __out.AppendLine(false); //51:15
            __out.AppendLine(true); //52:1
            __out.Append("    <dependencies>"); //53:1
            __out.AppendLine(false); //53:19
            __out.Append("        <!-- eclipseLink -->"); //54:1
            __out.AppendLine(false); //54:29
            string __tmp18Prefix = "		"; //55:1
            StringBuilder __tmp19 = new StringBuilder();
            __tmp19.Append(GeneratePomDependency("org.eclipse.persistence", "javax.persistence", "2.1.0", false));
            using(StreamReader __tmp19Reader = new StreamReader(this.__ToStream(__tmp19.ToString())))
            {
                bool __tmp19_first = true;
                bool __tmp19_last = __tmp19Reader.EndOfStream;
                while(__tmp19_first || !__tmp19_last)
                {
                    __tmp19_first = false;
                    string __tmp19Line = __tmp19Reader.ReadLine();
                    __tmp19_last = __tmp19Reader.EndOfStream;
                    __out.Append(__tmp18Prefix);
                    if (__tmp19Line != null) __out.Append(__tmp19Line);
                    if (!__tmp19_last) __out.AppendLine(true);
                    __out.AppendLine(false); //55:90
                }
            }
            string __tmp20Prefix = "		"; //56:1
            StringBuilder __tmp21 = new StringBuilder();
            __tmp21.Append(GeneratePomDependency("org.eclipse.persistence", "eclipselink", "2.6.2", true));
            using(StreamReader __tmp21Reader = new StreamReader(this.__ToStream(__tmp21.ToString())))
            {
                bool __tmp21_first = true;
                bool __tmp21_last = __tmp21Reader.EndOfStream;
                while(__tmp21_first || !__tmp21_last)
                {
                    __tmp21_first = false;
                    string __tmp21Line = __tmp21Reader.ReadLine();
                    __tmp21_last = __tmp21Reader.EndOfStream;
                    __out.Append(__tmp20Prefix);
                    if (__tmp21Line != null) __out.Append(__tmp21Line);
                    if (!__tmp21_last) __out.AppendLine(true);
                    __out.AppendLine(false); //56:83
                }
            }
            __out.Append("    </dependencies>"); //57:1
            __out.AppendLine(false); //57:20
            __out.Append("	<build>"); //58:1
            __out.AppendLine(false); //58:9
            __out.Append("		<plugins>"); //59:1
            __out.AppendLine(false); //59:12
            __out.Append("			<plugin>"); //60:1
            __out.AppendLine(false); //60:12
            __out.Append("				<groupId>org.apache.maven.plugins</groupId>"); //61:1
            __out.AppendLine(false); //61:48
            __out.Append("				<artifactId>maven-compiler-plugin</artifactId>"); //62:1
            __out.AppendLine(false); //62:51
            __out.Append("				<version>3.5.1</version>"); //63:1
            __out.AppendLine(false); //63:29
            __out.Append("				<configuration>"); //64:1
            __out.AppendLine(false); //64:20
            __out.Append("					<source>1.8</source>"); //65:1
            __out.AppendLine(false); //65:26
            __out.Append("					<target>1.8</target>"); //66:1
            __out.AppendLine(false); //66:26
            __out.Append("				</configuration>"); //67:1
            __out.AppendLine(false); //67:21
            __out.Append("			</plugin>"); //68:1
            __out.AppendLine(false); //68:13
            __out.Append("		</plugins>"); //69:1
            __out.AppendLine(false); //69:13
            __out.Append("	</build>"); //70:1
            __out.AppendLine(false); //70:10
            __out.Append("</project>"); //71:1
            __out.AppendLine(false); //71:11
            return __out.ToString();
        }

        public string GenerateComponentPom(Namespace ns, Component component, List<string> modules, bool rest, bool webService, bool webSocket, ComponentType cType) //74:1
        {
            StringBuilder __out = new StringBuilder();
            StringBuilder __tmp2 = new StringBuilder();
            __tmp2.Append(GeneratePomStart());
            using(StreamReader __tmp2Reader = new StreamReader(this.__ToStream(__tmp2.ToString())))
            {
                bool __tmp2_first = true;
                bool __tmp2_last = __tmp2Reader.EndOfStream;
                while(__tmp2_first || !__tmp2_last)
                {
                    __tmp2_first = false;
                    string __tmp2Line = __tmp2Reader.ReadLine();
                    __tmp2_last = __tmp2Reader.EndOfStream;
                    if (__tmp2Line != null) __out.Append(__tmp2Line);
                    if (!__tmp2_last) __out.AppendLine(true);
                    __out.AppendLine(false); //75:21
                }
            }
            __out.Append("    <parent>"); //76:1
            __out.AppendLine(false); //76:13
            string __tmp4Line = "        <artifactId>"; //77:1
            if (__tmp4Line != null) __out.Append(__tmp4Line);
            StringBuilder __tmp5 = new StringBuilder();
            __tmp5.Append(ns.Name);
            using(StreamReader __tmp5Reader = new StreamReader(this.__ToStream(__tmp5.ToString())))
            {
                bool __tmp5_first = true;
                bool __tmp5_last = __tmp5Reader.EndOfStream;
                while(__tmp5_first || !__tmp5_last)
                {
                    __tmp5_first = false;
                    string __tmp5Line = __tmp5Reader.ReadLine();
                    __tmp5_last = __tmp5Reader.EndOfStream;
                    if (__tmp5Line != null) __out.Append(__tmp5Line);
                    if (!__tmp5_last) __out.AppendLine(true);
                }
            }
            string __tmp6Line = "App</artifactId>"; //77:30
            if (__tmp6Line != null) __out.Append(__tmp6Line);
            __out.AppendLine(false); //77:46
            string __tmp8Line = "        <groupId>"; //78:1
            if (__tmp8Line != null) __out.Append(__tmp8Line);
            StringBuilder __tmp9 = new StringBuilder();
            __tmp9.Append(ns.Name);
            using(StreamReader __tmp9Reader = new StreamReader(this.__ToStream(__tmp9.ToString())))
            {
                bool __tmp9_first = true;
                bool __tmp9_last = __tmp9Reader.EndOfStream;
                while(__tmp9_first || !__tmp9_last)
                {
                    __tmp9_first = false;
                    string __tmp9Line = __tmp9Reader.ReadLine();
                    __tmp9_last = __tmp9Reader.EndOfStream;
                    if (__tmp9Line != null) __out.Append(__tmp9Line);
                    if (!__tmp9_last) __out.AppendLine(true);
                }
            }
            string __tmp10Line = "</groupId>"; //78:27
            if (__tmp10Line != null) __out.Append(__tmp10Line);
            __out.AppendLine(false); //78:37
            __out.Append("        <version>1.0</version>"); //79:1
            __out.AppendLine(false); //79:31
            __out.Append("    </parent>"); //80:1
            __out.AppendLine(false); //80:14
            __out.AppendLine(true); //81:2
            string __tmp12Line = "    <artifactId>"; //82:1
            if (__tmp12Line != null) __out.Append(__tmp12Line);
            StringBuilder __tmp13 = new StringBuilder();
            __tmp13.Append(ns.Name);
            using(StreamReader __tmp13Reader = new StreamReader(this.__ToStream(__tmp13.ToString())))
            {
                bool __tmp13_first = true;
                bool __tmp13_last = __tmp13Reader.EndOfStream;
                while(__tmp13_first || !__tmp13_last)
                {
                    __tmp13_first = false;
                    string __tmp13Line = __tmp13Reader.ReadLine();
                    __tmp13_last = __tmp13Reader.EndOfStream;
                    if (__tmp13Line != null) __out.Append(__tmp13Line);
                    if (!__tmp13_last) __out.AppendLine(true);
                }
            }
            string __tmp14Line = "-"; //82:26
            if (__tmp14Line != null) __out.Append(__tmp14Line);
            StringBuilder __tmp15 = new StringBuilder();
            __tmp15.Append(component.Name);
            using(StreamReader __tmp15Reader = new StreamReader(this.__ToStream(__tmp15.ToString())))
            {
                bool __tmp15_first = true;
                bool __tmp15_last = __tmp15Reader.EndOfStream;
                while(__tmp15_first || !__tmp15_last)
                {
                    __tmp15_first = false;
                    string __tmp15Line = __tmp15Reader.ReadLine();
                    __tmp15_last = __tmp15Reader.EndOfStream;
                    if (__tmp15Line != null) __out.Append(__tmp15Line);
                    if (!__tmp15_last) __out.AppendLine(true);
                }
            }
            string __tmp16Line = "</artifactId>"; //82:43
            if (__tmp16Line != null) __out.Append(__tmp16Line);
            __out.AppendLine(false); //82:56
            if (cType == ComponentType.WEB || cType == ComponentType.REMOTE) //83:3
            {
                __out.Append("	<packaging>war</packaging>"); //84:1
                __out.AppendLine(false); //84:28
            }
            __out.AppendLine(true); //86:2
            __out.Append("    <dependencies>"); //87:1
            __out.AppendLine(false); //87:19
            var __loop3_results = 
                (from module in __Enumerate((modules).GetEnumerator()) //88:8
                select new { module = module}
                ).ToList(); //88:2
            int __loop3_iteration = 0;
            foreach (var __tmp17 in __loop3_results)
            {
                ++__loop3_iteration;
                var module = __tmp17.module;
                string __tmp18Prefix = "		"; //89:1
                StringBuilder __tmp19 = new StringBuilder();
                __tmp19.Append(GeneratePomDependency(ns.Name, ns.Name + "-" + module, "1.0", false));
                using(StreamReader __tmp19Reader = new StreamReader(this.__ToStream(__tmp19.ToString())))
                {
                    bool __tmp19_first = true;
                    bool __tmp19_last = __tmp19Reader.EndOfStream;
                    while(__tmp19_first || !__tmp19_last)
                    {
                        __tmp19_first = false;
                        string __tmp19Line = __tmp19Reader.ReadLine();
                        __tmp19_last = __tmp19Reader.EndOfStream;
                        __out.Append(__tmp18Prefix);
                        if (__tmp19Line != null) __out.Append(__tmp19Line);
                        if (!__tmp19_last) __out.AppendLine(true);
                        __out.AppendLine(false); //89:69
                    }
                }
            }
            bool webmvc = false; //91:2
            bool jackson = false; //92:2
            if (cType == ComponentType.WEB || cType == ComponentType.REMOTE) //94:2
            {
                __out.AppendLine(true); //95:3
                webmvc = true;
                __out.Append("		<!-- web -->"); //97:1
                __out.AppendLine(false); //97:15
                string __tmp20Prefix = "		"; //98:1
                StringBuilder __tmp21 = new StringBuilder();
                __tmp21.Append(GeneratePomDependency("org.springframework", "spring-web", "${springframework.version}", false));
                using(StreamReader __tmp21Reader = new StreamReader(this.__ToStream(__tmp21.ToString())))
                {
                    bool __tmp21_first = true;
                    bool __tmp21_last = __tmp21Reader.EndOfStream;
                    while(__tmp21_first || !__tmp21_last)
                    {
                        __tmp21_first = false;
                        string __tmp21Line = __tmp21Reader.ReadLine();
                        __tmp21_last = __tmp21Reader.EndOfStream;
                        __out.Append(__tmp20Prefix);
                        if (__tmp21Line != null) __out.Append(__tmp21Line);
                        if (!__tmp21_last) __out.AppendLine(true);
                        __out.AppendLine(false); //98:100
                    }
                }
                string __tmp22Prefix = "		"; //99:1
                StringBuilder __tmp23 = new StringBuilder();
                __tmp23.Append(GeneratePomDependency("org.springframework", "spring-webmvc", "${springframework.version}", false));
                using(StreamReader __tmp23Reader = new StreamReader(this.__ToStream(__tmp23.ToString())))
                {
                    bool __tmp23_first = true;
                    bool __tmp23_last = __tmp23Reader.EndOfStream;
                    while(__tmp23_first || !__tmp23_last)
                    {
                        __tmp23_first = false;
                        string __tmp23Line = __tmp23Reader.ReadLine();
                        __tmp23_last = __tmp23Reader.EndOfStream;
                        __out.Append(__tmp22Prefix);
                        if (__tmp23Line != null) __out.Append(__tmp23Line);
                        if (!__tmp23_last) __out.AppendLine(true);
                        __out.AppendLine(false); //99:103
                    }
                }
                if (cType == ComponentType.WEB) //100:3
                {
                    __out.AppendLine(true); //101:3
                    __out.Append("		<!-- thymeleaf -->"); //102:1
                    __out.AppendLine(false); //102:21
                    string __tmp24Prefix = "		"; //103:1
                    StringBuilder __tmp25 = new StringBuilder();
                    __tmp25.Append(GeneratePomDependency("org.thymeleaf", "thymeleaf", "${thymeleaf.version}", false));
                    using(StreamReader __tmp25Reader = new StreamReader(this.__ToStream(__tmp25.ToString())))
                    {
                        bool __tmp25_first = true;
                        bool __tmp25_last = __tmp25Reader.EndOfStream;
                        while(__tmp25_first || !__tmp25_last)
                        {
                            __tmp25_first = false;
                            string __tmp25Line = __tmp25Reader.ReadLine();
                            __tmp25_last = __tmp25Reader.EndOfStream;
                            __out.Append(__tmp24Prefix);
                            if (__tmp25Line != null) __out.Append(__tmp25Line);
                            if (!__tmp25_last) __out.AppendLine(true);
                            __out.AppendLine(false); //103:87
                        }
                    }
                    string __tmp26Prefix = "		"; //104:1
                    StringBuilder __tmp27 = new StringBuilder();
                    __tmp27.Append(GeneratePomDependency("org.thymeleaf", "thymeleaf-spring4", "${thymeleaf.version}", false));
                    using(StreamReader __tmp27Reader = new StreamReader(this.__ToStream(__tmp27.ToString())))
                    {
                        bool __tmp27_first = true;
                        bool __tmp27_last = __tmp27Reader.EndOfStream;
                        while(__tmp27_first || !__tmp27_last)
                        {
                            __tmp27_first = false;
                            string __tmp27Line = __tmp27Reader.ReadLine();
                            __tmp27_last = __tmp27Reader.EndOfStream;
                            __out.Append(__tmp26Prefix);
                            if (__tmp27Line != null) __out.Append(__tmp27Line);
                            if (!__tmp27_last) __out.AppendLine(true);
                            __out.AppendLine(false); //104:95
                        }
                    }
                }
            }
            if (rest) //108:2
            {
                __out.AppendLine(true); //109:3
                __out.Append("		<!-- for rest service -->"); //110:1
                __out.AppendLine(false); //110:28
                if (!webmvc) //111:3
                {
                    string __tmp28Prefix = "		"; //112:1
                    StringBuilder __tmp29 = new StringBuilder();
                    __tmp29.Append(GeneratePomDependency("org.springframework", "spring-webmvc", "${springframework.version}", false));
                    using(StreamReader __tmp29Reader = new StreamReader(this.__ToStream(__tmp29.ToString())))
                    {
                        bool __tmp29_first = true;
                        bool __tmp29_last = __tmp29Reader.EndOfStream;
                        while(__tmp29_first || !__tmp29_last)
                        {
                            __tmp29_first = false;
                            string __tmp29Line = __tmp29Reader.ReadLine();
                            __tmp29_last = __tmp29Reader.EndOfStream;
                            __out.Append(__tmp28Prefix);
                            if (__tmp29Line != null) __out.Append(__tmp29Line);
                            if (!__tmp29_last) __out.AppendLine(true);
                            __out.AppendLine(false); //112:103
                        }
                    }
                }
                string __tmp30Prefix = "		"; //114:1
                StringBuilder __tmp31 = new StringBuilder();
                __tmp31.Append(GeneratePomDependency("com.fasterxml.jackson.datatype", "jackson-datatype-jsr310", "${jackson.version}", false));
                using(StreamReader __tmp31Reader = new StreamReader(this.__ToStream(__tmp31.ToString())))
                {
                    bool __tmp31_first = true;
                    bool __tmp31_last = __tmp31Reader.EndOfStream;
                    while(__tmp31_first || !__tmp31_last)
                    {
                        __tmp31_first = false;
                        string __tmp31Line = __tmp31Reader.ReadLine();
                        __tmp31_last = __tmp31Reader.EndOfStream;
                        __out.Append(__tmp30Prefix);
                        if (__tmp31Line != null) __out.Append(__tmp31Line);
                        if (!__tmp31_last) __out.AppendLine(true);
                        __out.AppendLine(false); //114:116
                    }
                }
                jackson = true;
            }
            if (webService) //117:2
            {
                __out.AppendLine(true); //118:3
                __out.Append("		<!-- for SOAP service -->"); //119:1
                __out.AppendLine(false); //119:28
                string __tmp32Prefix = "		"; //120:1
                StringBuilder __tmp33 = new StringBuilder();
                __tmp33.Append(GeneratePomDependency("org.springframework.ws", "spring-ws-core", "${springframework.ws.version}", false));
                using(StreamReader __tmp33Reader = new StreamReader(this.__ToStream(__tmp33.ToString())))
                {
                    bool __tmp33_first = true;
                    bool __tmp33_last = __tmp33Reader.EndOfStream;
                    while(__tmp33_first || !__tmp33_last)
                    {
                        __tmp33_first = false;
                        string __tmp33Line = __tmp33Reader.ReadLine();
                        __tmp33_last = __tmp33Reader.EndOfStream;
                        __out.Append(__tmp32Prefix);
                        if (__tmp33Line != null) __out.Append(__tmp33Line);
                        if (!__tmp33_last) __out.AppendLine(true);
                        __out.AppendLine(false); //120:110
                    }
                }
                string __tmp34Prefix = "		"; //121:1
                StringBuilder __tmp35 = new StringBuilder();
                __tmp35.Append(GeneratePomDependency("wsdl4j", "wsdl4j", "${wsdl4j.version}", false));
                using(StreamReader __tmp35Reader = new StreamReader(this.__ToStream(__tmp35.ToString())))
                {
                    bool __tmp35_first = true;
                    bool __tmp35_last = __tmp35Reader.EndOfStream;
                    while(__tmp35_first || !__tmp35_last)
                    {
                        __tmp35_first = false;
                        string __tmp35Line = __tmp35Reader.ReadLine();
                        __tmp35_last = __tmp35Reader.EndOfStream;
                        __out.Append(__tmp34Prefix);
                        if (__tmp35Line != null) __out.Append(__tmp35Line);
                        if (!__tmp35_last) __out.AppendLine(true);
                        __out.AppendLine(false); //121:74
                    }
                }
            }
            if (webSocket) //123:2
            {
                __out.AppendLine(true); //124:3
                __out.Append("		<!-- for web socket service -->"); //125:1
                __out.AppendLine(false); //125:34
                string __tmp36Prefix = "		"; //126:1
                StringBuilder __tmp37 = new StringBuilder();
                __tmp37.Append(GeneratePomDependency("org.springframework", "spring-messaging", "${springframework.version}", false));
                using(StreamReader __tmp37Reader = new StreamReader(this.__ToStream(__tmp37.ToString())))
                {
                    bool __tmp37_first = true;
                    bool __tmp37_last = __tmp37Reader.EndOfStream;
                    while(__tmp37_first || !__tmp37_last)
                    {
                        __tmp37_first = false;
                        string __tmp37Line = __tmp37Reader.ReadLine();
                        __tmp37_last = __tmp37Reader.EndOfStream;
                        __out.Append(__tmp36Prefix);
                        if (__tmp37Line != null) __out.Append(__tmp37Line);
                        if (!__tmp37_last) __out.AppendLine(true);
                        __out.AppendLine(false); //126:106
                    }
                }
            }
            if (cType == ComponentType.WEB || cType == ComponentType.IMPLEMENTATION) //129:2
            {
                if (rest) //130:3
                {
                    __out.AppendLine(true); //131:3
                    __out.Append("		<!-- for rest client -->"); //132:1
                    __out.AppendLine(false); //132:27
                    string __tmp38Prefix = "		"; //133:1
                    StringBuilder __tmp39 = new StringBuilder();
                    __tmp39.Append(GeneratePomDependency("org.springframework.hateoas", "spring-hateoas", "${springframework.hateoas.version}", false));
                    using(StreamReader __tmp39Reader = new StreamReader(this.__ToStream(__tmp39.ToString())))
                    {
                        bool __tmp39_first = true;
                        bool __tmp39_last = __tmp39Reader.EndOfStream;
                        while(__tmp39_first || !__tmp39_last)
                        {
                            __tmp39_first = false;
                            string __tmp39Line = __tmp39Reader.ReadLine();
                            __tmp39_last = __tmp39Reader.EndOfStream;
                            __out.Append(__tmp38Prefix);
                            if (__tmp39Line != null) __out.Append(__tmp39Line);
                            if (!__tmp39_last) __out.AppendLine(true);
                            __out.AppendLine(false); //133:120
                        }
                    }
                    string __tmp40Prefix = "		"; //134:1
                    StringBuilder __tmp41 = new StringBuilder();
                    __tmp41.Append(GeneratePomDependency("javax.servlet", "javax.servlet-api", "3.1.0", true));
                    using(StreamReader __tmp41Reader = new StreamReader(this.__ToStream(__tmp41.ToString())))
                    {
                        bool __tmp41_first = true;
                        bool __tmp41_last = __tmp41Reader.EndOfStream;
                        while(__tmp41_first || !__tmp41_last)
                        {
                            __tmp41_first = false;
                            string __tmp41Line = __tmp41Reader.ReadLine();
                            __tmp41_last = __tmp41Reader.EndOfStream;
                            __out.Append(__tmp40Prefix);
                            if (__tmp41Line != null) __out.Append(__tmp41Line);
                            if (!__tmp41_last) __out.AppendLine(true);
                            __out.AppendLine(false); //134:79
                        }
                    }
                }
                if (!jackson) //136:3
                {
                    string __tmp42Prefix = "	"; //137:1
                    StringBuilder __tmp43 = new StringBuilder();
                    __tmp43.Append(GeneratePomDependency("com.fasterxml.jackson.datatype", "jackson-datatype-jsr310", "${jackson.version}", false));
                    using(StreamReader __tmp43Reader = new StreamReader(this.__ToStream(__tmp43.ToString())))
                    {
                        bool __tmp43_first = true;
                        bool __tmp43_last = __tmp43Reader.EndOfStream;
                        while(__tmp43_first || !__tmp43_last)
                        {
                            __tmp43_first = false;
                            string __tmp43Line = __tmp43Reader.ReadLine();
                            __tmp43_last = __tmp43Reader.EndOfStream;
                            __out.Append(__tmp42Prefix);
                            if (__tmp43Line != null) __out.Append(__tmp43Line);
                            if (!__tmp43_last) __out.AppendLine(true);
                            __out.AppendLine(false); //137:115
                        }
                    }
                }
            }
            if (cType == ComponentType.DATA) //141:2
            {
                __out.AppendLine(true); //142:3
                __out.Append("		<!-- spring data -->"); //143:1
                __out.AppendLine(false); //143:23
                string __tmp44Prefix = "		"; //144:1
                StringBuilder __tmp45 = new StringBuilder();
                __tmp45.Append(GeneratePomDependency("org.springframework", "spring-orm", "${springframework.version}", false));
                using(StreamReader __tmp45Reader = new StreamReader(this.__ToStream(__tmp45.ToString())))
                {
                    bool __tmp45_first = true;
                    bool __tmp45_last = __tmp45Reader.EndOfStream;
                    while(__tmp45_first || !__tmp45_last)
                    {
                        __tmp45_first = false;
                        string __tmp45Line = __tmp45Reader.ReadLine();
                        __tmp45_last = __tmp45Reader.EndOfStream;
                        __out.Append(__tmp44Prefix);
                        if (__tmp45Line != null) __out.Append(__tmp45Line);
                        if (!__tmp45_last) __out.AppendLine(true);
                        __out.AppendLine(false); //144:100
                    }
                }
                string __tmp46Prefix = "		"; //145:1
                StringBuilder __tmp47 = new StringBuilder();
                __tmp47.Append(GeneratePomDependency("org.springframework.data", "spring-data-jpa", "${spring-data-jpa.version}", false));
                using(StreamReader __tmp47Reader = new StreamReader(this.__ToStream(__tmp47.ToString())))
                {
                    bool __tmp47_first = true;
                    bool __tmp47_last = __tmp47Reader.EndOfStream;
                    while(__tmp47_first || !__tmp47_last)
                    {
                        __tmp47_first = false;
                        string __tmp47Line = __tmp47Reader.ReadLine();
                        __tmp47_last = __tmp47Reader.EndOfStream;
                        __out.Append(__tmp46Prefix);
                        if (__tmp47Line != null) __out.Append(__tmp47Line);
                        if (!__tmp47_last) __out.AppendLine(true);
                        __out.AppendLine(false); //145:110
                    }
                }
                __out.Append("          <!--  <exclusions>"); //146:1
                __out.AppendLine(false); //146:29
                __out.Append("                <exclusion>"); //147:1
                __out.AppendLine(false); //147:28
                __out.Append("                    <groupId>org.springframework</groupId>"); //148:1
                __out.AppendLine(false); //148:59
                __out.Append("                    <artifactId>spring-orm</artifactId>"); //149:1
                __out.AppendLine(false); //149:56
                __out.Append("                </exclusion>"); //150:1
                __out.AppendLine(false); //150:29
                __out.Append("            </exclusions> -->"); //151:1
                __out.AppendLine(false); //151:30
            }
            __out.Append("    </dependencies>"); //153:1
            __out.AppendLine(false); //153:20
            __out.Append("</project>"); //154:1
            __out.AppendLine(false); //154:11
            return __out.ToString();
        }

        public string GenerateComponentSpringConfig(Namespace ns) //157:1
        {
            StringBuilder __out = new StringBuilder();
            __out.Append("<?xml version=\"1.0\" encoding=\"UTF-8\"?>"); //158:1
            __out.AppendLine(false); //158:39
            __out.Append("<beans xmlns=\"http://www.springframework.org/schema/beans\""); //159:1
            __out.AppendLine(false); //159:59
            __out.Append("       xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\""); //160:1
            __out.AppendLine(false); //160:61
            __out.Append("       xmlns:context=\"http://www.springframework.org/schema/context\""); //161:1
            __out.AppendLine(false); //161:69
            __out.Append("       xmlns:jpa=\"http://www.springframework.org/schema/data/jpa\""); //162:1
            __out.AppendLine(false); //162:66
            __out.Append("       xsi:schemaLocation=\"http://www.springframework.org/schema/beans"); //163:1
            __out.AppendLine(false); //163:71
            __out.Append("       http://www.springframework.org/schema/beans/spring-beans.xsd"); //164:1
            __out.AppendLine(false); //164:68
            __out.Append("       http://www.springframework.org/schema/context"); //165:1
            __out.AppendLine(false); //165:53
            __out.Append("       http://www.springframework.org/schema/context/spring-context.xsd"); //166:1
            __out.AppendLine(false); //166:72
            __out.Append("       http://www.springframework.org/schema/data/jpa"); //167:1
            __out.AppendLine(false); //167:54
            __out.Append("       http://www.springframework.org/schema/data/jpa/spring-jpa.xsd\">"); //168:1
            __out.AppendLine(false); //168:71
            __out.AppendLine(true); //169:5
            string __tmp2Line = "       <jpa:repositories base-package=\""; //170:1
            if (__tmp2Line != null) __out.Append(__tmp2Line);
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(ns.FullName.ToLower());
            using(StreamReader __tmp3Reader = new StreamReader(this.__ToStream(__tmp3.ToString())))
            {
                bool __tmp3_first = true;
                bool __tmp3_last = __tmp3Reader.EndOfStream;
                while(__tmp3_first || !__tmp3_last)
                {
                    __tmp3_first = false;
                    string __tmp3Line = __tmp3Reader.ReadLine();
                    __tmp3_last = __tmp3Reader.EndOfStream;
                    if (__tmp3Line != null) __out.Append(__tmp3Line);
                    if (!__tmp3_last) __out.AppendLine(true);
                }
            }
            string __tmp4Line = "."; //170:63
            if (__tmp4Line != null) __out.Append(__tmp4Line);
            StringBuilder __tmp5 = new StringBuilder();
            __tmp5.Append(SpringGeneratorUtil.Properties.repositoryPackage);
            using(StreamReader __tmp5Reader = new StreamReader(this.__ToStream(__tmp5.ToString())))
            {
                bool __tmp5_first = true;
                bool __tmp5_last = __tmp5Reader.EndOfStream;
                while(__tmp5_first || !__tmp5_last)
                {
                    __tmp5_first = false;
                    string __tmp5Line = __tmp5Reader.ReadLine();
                    __tmp5_last = __tmp5Reader.EndOfStream;
                    if (__tmp5Line != null) __out.Append(__tmp5Line);
                    if (!__tmp5_last) __out.AppendLine(true);
                }
            }
            string __tmp6Line = "\"/>"; //170:114
            if (__tmp6Line != null) __out.Append(__tmp6Line);
            __out.AppendLine(false); //170:117
            string __tmp8Line = "       <context:component-scan base-package=\""; //171:1
            if (__tmp8Line != null) __out.Append(__tmp8Line);
            StringBuilder __tmp9 = new StringBuilder();
            __tmp9.Append(ns.FullName.ToLower());
            using(StreamReader __tmp9Reader = new StreamReader(this.__ToStream(__tmp9.ToString())))
            {
                bool __tmp9_first = true;
                bool __tmp9_last = __tmp9Reader.EndOfStream;
                while(__tmp9_first || !__tmp9_last)
                {
                    __tmp9_first = false;
                    string __tmp9Line = __tmp9Reader.ReadLine();
                    __tmp9_last = __tmp9Reader.EndOfStream;
                    if (__tmp9Line != null) __out.Append(__tmp9Line);
                    if (!__tmp9_last) __out.AppendLine(true);
                }
            }
            string __tmp10Line = "\"/>"; //171:69
            if (__tmp10Line != null) __out.Append(__tmp10Line);
            __out.AppendLine(false); //171:72
            __out.Append("</beans>"); //172:1
            __out.AppendLine(false); //172:9
            return __out.ToString();
        }

        public string GeneratePomStart() //177:1
        {
            StringBuilder __out = new StringBuilder();
            __out.Append("<?xml version=\"1.0\" encoding=\"UTF-8\"?>"); //178:1
            __out.AppendLine(false); //178:39
            __out.Append("<project xmlns=\"http://maven.apache.org/POM/4.0.0\""); //179:1
            __out.AppendLine(false); //179:51
            __out.Append("         xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\""); //180:1
            __out.AppendLine(false); //180:63
            __out.Append("         xsi:schemaLocation=\"http://maven.apache.org/POM/4.0.0 http://maven.apache.org/xsd/maven-4.0.0.xsd\">"); //181:1
            __out.AppendLine(false); //181:109
            __out.Append("	<modelVersion>4.0.0</modelVersion>"); //182:1
            __out.AppendLine(false); //182:36
            return __out.ToString();
        }

        public string GeneratePomDependency(string group, string artifact, string version, bool provided) //188:1
        {
            StringBuilder __out = new StringBuilder();
            __out.Append("<dependency>"); //189:1
            __out.AppendLine(false); //189:13
            string __tmp2Line = "    <groupId>"; //190:1
            if (__tmp2Line != null) __out.Append(__tmp2Line);
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(group);
            using(StreamReader __tmp3Reader = new StreamReader(this.__ToStream(__tmp3.ToString())))
            {
                bool __tmp3_first = true;
                bool __tmp3_last = __tmp3Reader.EndOfStream;
                while(__tmp3_first || !__tmp3_last)
                {
                    __tmp3_first = false;
                    string __tmp3Line = __tmp3Reader.ReadLine();
                    __tmp3_last = __tmp3Reader.EndOfStream;
                    if (__tmp3Line != null) __out.Append(__tmp3Line);
                    if (!__tmp3_last) __out.AppendLine(true);
                }
            }
            string __tmp4Line = "</groupId>"; //190:21
            if (__tmp4Line != null) __out.Append(__tmp4Line);
            __out.AppendLine(false); //190:31
            string __tmp6Line = "    <artifactId>"; //191:1
            if (__tmp6Line != null) __out.Append(__tmp6Line);
            StringBuilder __tmp7 = new StringBuilder();
            __tmp7.Append(artifact);
            using(StreamReader __tmp7Reader = new StreamReader(this.__ToStream(__tmp7.ToString())))
            {
                bool __tmp7_first = true;
                bool __tmp7_last = __tmp7Reader.EndOfStream;
                while(__tmp7_first || !__tmp7_last)
                {
                    __tmp7_first = false;
                    string __tmp7Line = __tmp7Reader.ReadLine();
                    __tmp7_last = __tmp7Reader.EndOfStream;
                    if (__tmp7Line != null) __out.Append(__tmp7Line);
                    if (!__tmp7_last) __out.AppendLine(true);
                }
            }
            string __tmp8Line = "</artifactId>"; //191:27
            if (__tmp8Line != null) __out.Append(__tmp8Line);
            __out.AppendLine(false); //191:40
            string __tmp10Line = "    <version>"; //192:1
            if (__tmp10Line != null) __out.Append(__tmp10Line);
            StringBuilder __tmp11 = new StringBuilder();
            __tmp11.Append(version);
            using(StreamReader __tmp11Reader = new StreamReader(this.__ToStream(__tmp11.ToString())))
            {
                bool __tmp11_first = true;
                bool __tmp11_last = __tmp11Reader.EndOfStream;
                while(__tmp11_first || !__tmp11_last)
                {
                    __tmp11_first = false;
                    string __tmp11Line = __tmp11Reader.ReadLine();
                    __tmp11_last = __tmp11Reader.EndOfStream;
                    if (__tmp11Line != null) __out.Append(__tmp11Line);
                    if (!__tmp11_last) __out.AppendLine(true);
                }
            }
            string __tmp12Line = "</version>"; //192:23
            if (__tmp12Line != null) __out.Append(__tmp12Line);
            __out.AppendLine(false); //192:33
            if (provided) //193:3
            {
                __out.Append("	<scope>provided</scope>"); //194:1
                __out.AppendLine(false); //194:25
            }
            __out.Append("</dependency>"); //196:1
            __out.AppendLine(false); //196:14
            return __out.ToString();
        }

        public string GenerateConfigClass(Namespace ns) //201:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp2Line = "package "; //202:1
            if (__tmp2Line != null) __out.Append(__tmp2Line);
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(ns.FullName.ToLower());
            using(StreamReader __tmp3Reader = new StreamReader(this.__ToStream(__tmp3.ToString())))
            {
                bool __tmp3_first = true;
                bool __tmp3_last = __tmp3Reader.EndOfStream;
                while(__tmp3_first || !__tmp3_last)
                {
                    __tmp3_first = false;
                    string __tmp3Line = __tmp3Reader.ReadLine();
                    __tmp3_last = __tmp3Reader.EndOfStream;
                    if (__tmp3Line != null) __out.Append(__tmp3Line);
                    if (!__tmp3_last) __out.AppendLine(true);
                }
            }
            string __tmp4Line = ";"; //202:32
            if (__tmp4Line != null) __out.Append(__tmp4Line);
            __out.AppendLine(false); //202:33
            __out.AppendLine(true); //203:1
            __out.Append("import java.util.MissingResourceException;"); //204:1
            __out.AppendLine(false); //204:43
            __out.Append("import java.util.ResourceBundle;"); //205:1
            __out.AppendLine(false); //205:33
            __out.AppendLine(true); //206:1
            __out.Append("public class Configuration {"); //207:1
            __out.AppendLine(false); //207:29
            string __tmp6Line = "	private static final String BUNDLE_NAME = \""; //208:1
            if (__tmp6Line != null) __out.Append(__tmp6Line);
            StringBuilder __tmp7 = new StringBuilder();
            __tmp7.Append(ns.FullName.ToLower());
            using(StreamReader __tmp7Reader = new StreamReader(this.__ToStream(__tmp7.ToString())))
            {
                bool __tmp7_first = true;
                bool __tmp7_last = __tmp7Reader.EndOfStream;
                while(__tmp7_first || !__tmp7_last)
                {
                    __tmp7_first = false;
                    string __tmp7Line = __tmp7Reader.ReadLine();
                    __tmp7_last = __tmp7Reader.EndOfStream;
                    if (__tmp7Line != null) __out.Append(__tmp7Line);
                    if (!__tmp7_last) __out.AppendLine(true);
                }
            }
            string __tmp8Line = ".configuration\";"; //208:68
            if (__tmp8Line != null) __out.Append(__tmp8Line);
            __out.AppendLine(false); //208:84
            __out.AppendLine(true); //209:2
            __out.Append("	private static final ResourceBundle RESOURCE_BUNDLE = ResourceBundle.getBundle(BUNDLE_NAME);"); //210:1
            __out.AppendLine(false); //210:94
            __out.AppendLine(true); //211:2
            __out.Append("	private Configuration() {"); //212:1
            __out.AppendLine(false); //212:27
            __out.Append("	}"); //213:1
            __out.AppendLine(false); //213:3
            __out.AppendLine(true); //214:2
            __out.Append("	public static String getString(String key) {"); //215:1
            __out.AppendLine(false); //215:46
            __out.Append("		try {"); //216:1
            __out.AppendLine(false); //216:8
            __out.Append("			return RESOURCE_BUNDLE.getString(key);"); //217:1
            __out.AppendLine(false); //217:42
            __out.Append("		} catch (MissingResourceException e) {"); //218:1
            __out.AppendLine(false); //218:41
            __out.Append("			return '!' + key + '!';"); //219:1
            __out.AppendLine(false); //219:27
            __out.Append("		}"); //220:1
            __out.AppendLine(false); //220:4
            __out.Append("	}"); //221:1
            __out.AppendLine(false); //221:3
            __out.Append("}"); //222:1
            __out.AppendLine(false); //222:2
            return __out.ToString();
        }

        public string GenerateConfig(Dictionary<string,string> properties) //227:1
        {
            StringBuilder __out = new StringBuilder();
            var __loop4_results = 
                (from keyValue in __Enumerate((properties).GetEnumerator()) //228:8
                select new { keyValue = keyValue}
                ).ToList(); //228:3
            int __loop4_iteration = 0;
            foreach (var __tmp1 in __loop4_results)
            {
                ++__loop4_iteration;
                var keyValue = __tmp1.keyValue;
                StringBuilder __tmp3 = new StringBuilder();
                __tmp3.Append(keyValue.Key);
                using(StreamReader __tmp3Reader = new StreamReader(this.__ToStream(__tmp3.ToString())))
                {
                    bool __tmp3_first = true;
                    bool __tmp3_last = __tmp3Reader.EndOfStream;
                    while(__tmp3_first || !__tmp3_last)
                    {
                        __tmp3_first = false;
                        string __tmp3Line = __tmp3Reader.ReadLine();
                        __tmp3_last = __tmp3Reader.EndOfStream;
                        if (__tmp3Line != null) __out.Append(__tmp3Line);
                        if (!__tmp3_last) __out.AppendLine(true);
                    }
                }
                string __tmp4Line = "="; //229:15
                if (__tmp4Line != null) __out.Append(__tmp4Line);
                StringBuilder __tmp5 = new StringBuilder();
                __tmp5.Append(keyValue.Value);
                using(StreamReader __tmp5Reader = new StreamReader(this.__ToStream(__tmp5.ToString())))
                {
                    bool __tmp5_first = true;
                    bool __tmp5_last = __tmp5Reader.EndOfStream;
                    while(__tmp5_first || !__tmp5_last)
                    {
                        __tmp5_first = false;
                        string __tmp5Line = __tmp5Reader.ReadLine();
                        __tmp5_last = __tmp5Reader.EndOfStream;
                        if (__tmp5Line != null) __out.Append(__tmp5Line);
                        if (!__tmp5_last) __out.AppendLine(true);
                        __out.AppendLine(false); //229:32
                    }
                }
            }
            return __out.ToString();
        }

        private class StringBuilder
        {
            private bool newLine;
            private System.Text.StringBuilder builder = new System.Text.StringBuilder();
            
            public StringBuilder()
            {
                this.newLine = true;
            }
            
            public void Append(string str)
            {
                if (str == null) return;
                if (!string.IsNullOrEmpty(str))
                {
                    this.newLine = false;
                }
                builder.Append(str);
            }
            
            public void Append(object obj)
            {
                if (obj == null) return;
                string text = obj.ToString();
                this.Append(text);
            }
            
            public void AppendLine(bool force = false)
            {
                if (force || !this.newLine)
                {
                    builder.AppendLine();
                    this.newLine = true;
                }
            }
            
            public override string ToString()
            {
                return builder.ToString();
            }
        }
    }
}
