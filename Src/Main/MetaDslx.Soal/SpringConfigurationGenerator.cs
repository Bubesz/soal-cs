using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Soal //1:1
{
    using __Hidden_SpringConfigurationGenerator_191162711;
    namespace __Hidden_SpringConfigurationGenerator_191162711
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
            string __tmp6Line = "		<jta-data-source>java:jboss/datasources/"; //12:1
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
            string __tmp8Line = "DS</jta-data-source>"; //12:52
            if (__tmp8Line != null) __out.Append(__tmp8Line);
            __out.AppendLine(false); //12:72
            __out.AppendLine(true); //14:3
            var __loop1_results = 
                (from entity in __Enumerate((entities).GetEnumerator()) //15:9
                select new { entity = entity}
                ).ToList(); //15:3
            int __loop1_iteration = 0;
            foreach (var __tmp9 in __loop1_results)
            {
                ++__loop1_iteration;
                var entity = __tmp9.entity;
                string __tmp11Line = "		<class>"; //16:1
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
                string __tmp13Line = "."; //16:50
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
                string __tmp15Line = "."; //16:97
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
                string __tmp17Line = "</class>"; //16:111
                if (__tmp17Line != null) __out.Append(__tmp17Line);
                __out.AppendLine(false); //16:119
            }
            __out.AppendLine(true); //18:2
            __out.Append("        <class>iit.cinema.status.ReservationStatus</class>"); //19:1
            __out.AppendLine(false); //19:59
            __out.Append("        <class>iit.cinema.status.SeatStatus</class>"); //20:1
            __out.AppendLine(false); //20:52
            __out.AppendLine(true); //21:3
            __out.Append("        <shared-cache-mode>NONE</shared-cache-mode>"); //22:1
            __out.AppendLine(false); //22:52
            __out.AppendLine(true); //23:3
            __out.Append("        <properties>"); //24:1
            __out.AppendLine(false); //24:21
            __out.Append("            <!--for debug-->"); //25:1
            __out.AppendLine(false); //25:29
            __out.Append("            <property name=\"eclipselink.ddl-generation\" value=\"create-tables\"/>"); //26:1
            __out.AppendLine(false); //26:80
            __out.Append("            <!--<property name=\"eclipselink.logging.level\" value=\"FINE\"/>-->"); //27:1
            __out.AppendLine(false); //27:77
            __out.Append("        </properties>"); //28:1
            __out.AppendLine(false); //28:22
            __out.Append("    </persistence-unit>"); //29:1
            __out.AppendLine(false); //29:24
            __out.Append("</persistence>"); //30:1
            __out.AppendLine(false); //30:15
            return __out.ToString();
        }

        public string generateMasterPom(Namespace ns, List<string> modules) //33:1
        {
            StringBuilder __out = new StringBuilder();
            StringBuilder __tmp2 = new StringBuilder();
            __tmp2.Append(SpringGeneratorUtil.GeneratePomStart());
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
                    __out.AppendLine(false); //34:41
                }
            }
            __out.AppendLine(true); //35:1
            __out.Append("    <properties>"); //36:1
            __out.AppendLine(false); //36:17
            __out.Append("        <springframework.version>4.1.6.RELEASE</springframework.version>"); //37:1
            __out.AppendLine(false); //37:73
            __out.Append("		<springframework.ws.version>2.2.4.RELEASE</springframework.ws.version>"); //38:1
            __out.AppendLine(false); //38:73
            __out.Append("        <spring-data-jpa.version>1.9.0.RELEASE</spring-data-jpa.version>"); //39:1
            __out.AppendLine(false); //39:73
            __out.Append("		<wsdl4j.version>1.6.3</wsdl4j.version>"); //40:1
            __out.AppendLine(false); //40:41
            __out.Append("        <!--<spring-security.version>4.0.2.RELEASE</spring-security.version>-->"); //41:1
            __out.AppendLine(false); //41:80
            __out.Append("    </properties>"); //42:1
            __out.AppendLine(false); //42:18
            __out.AppendLine(true); //43:1
            string __tmp4Line = "    <groupId>"; //44:1
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
            string __tmp6Line = "</groupId>"; //44:23
            if (__tmp6Line != null) __out.Append(__tmp6Line);
            __out.AppendLine(false); //44:33
            string __tmp8Line = "    <artifactId>"; //45:1
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
            string __tmp10Line = "App</artifactId>"; //45:26
            if (__tmp10Line != null) __out.Append(__tmp10Line);
            __out.AppendLine(false); //45:42
            __out.Append("    <packaging>pom</packaging>"); //46:1
            __out.AppendLine(false); //46:31
            __out.Append("    <version>1.0</version>"); //47:1
            __out.AppendLine(false); //47:27
            __out.Append("    <modules>"); //48:1
            __out.AppendLine(false); //48:14
            var __loop2_results = 
                (from module in __Enumerate((modules).GetEnumerator()) //49:8
                select new { module = module}
                ).ToList(); //49:2
            int __loop2_iteration = 0;
            foreach (var __tmp11 in __loop2_results)
            {
                ++__loop2_iteration;
                var module = __tmp11.module;
                string __tmp13Line = "        <module>"; //50:1
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
                string __tmp15Line = "-"; //50:26
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
                string __tmp17Line = "</module>"; //50:35
                if (__tmp17Line != null) __out.Append(__tmp17Line);
                __out.AppendLine(false); //50:44
            }
            __out.Append("    </modules>"); //52:1
            __out.AppendLine(false); //52:15
            __out.AppendLine(true); //53:1
            __out.Append("    <dependencies>"); //54:1
            __out.AppendLine(false); //54:19
            __out.Append("        <!-- eclipseLink -->"); //55:1
            __out.AppendLine(false); //55:29
            string __tmp18Prefix = "		"; //56:1
            StringBuilder __tmp19 = new StringBuilder();
            __tmp19.Append(SpringGeneratorUtil.GeneratePomDependency("org.eclipse.persistence", "javax.persistence", "2.1.0"));
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
                    __out.AppendLine(false); //56:103
                }
            }
            string __tmp20Prefix = "		"; //57:1
            StringBuilder __tmp21 = new StringBuilder();
            __tmp21.Append(SpringGeneratorUtil.GeneratePomDependency("org.eclipse.persistence", "eclipselink", "2.6.2"));
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
                    __out.AppendLine(false); //57:97
                }
            }
            __out.Append("    </dependencies>"); //58:1
            __out.AppendLine(false); //58:20
            __out.Append("</project>"); //59:1
            __out.AppendLine(false); //59:11
            return __out.ToString();
        }

        public string generateComponentPom(Namespace ns, string moduleName, List<string> modules, bool rest, bool webService, bool webSocket) //62:1
        {
            StringBuilder __out = new StringBuilder();
            StringBuilder __tmp2 = new StringBuilder();
            __tmp2.Append(SpringGeneratorUtil.GeneratePomStart());
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
                    __out.AppendLine(false); //63:41
                }
            }
            __out.Append("    <parent>"); //64:1
            __out.AppendLine(false); //64:13
            string __tmp4Line = "        <artifactId>"; //65:1
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
            string __tmp6Line = "App</artifactId>"; //65:30
            if (__tmp6Line != null) __out.Append(__tmp6Line);
            __out.AppendLine(false); //65:46
            string __tmp8Line = "        <groupId>"; //66:1
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
            string __tmp10Line = "</groupId>"; //66:27
            if (__tmp10Line != null) __out.Append(__tmp10Line);
            __out.AppendLine(false); //66:37
            __out.Append("        <version>1.0</version>"); //67:1
            __out.AppendLine(false); //67:31
            __out.Append("    </parent>"); //68:1
            __out.AppendLine(false); //68:14
            string __tmp12Line = "    <artifactId>"; //70:1
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
            string __tmp14Line = "-"; //70:26
            if (__tmp14Line != null) __out.Append(__tmp14Line);
            StringBuilder __tmp15 = new StringBuilder();
            __tmp15.Append(moduleName);
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
            string __tmp16Line = "</artifactId>"; //70:39
            if (__tmp16Line != null) __out.Append(__tmp16Line);
            __out.AppendLine(false); //70:52
            __out.Append("    <dependencies>"); //72:1
            __out.AppendLine(false); //72:19
            var __loop3_results = 
                (from module in __Enumerate((modules).GetEnumerator()) //73:8
                select new { module = module}
                ).ToList(); //73:2
            int __loop3_iteration = 0;
            foreach (var __tmp17 in __loop3_results)
            {
                ++__loop3_iteration;
                var module = __tmp17.module;
                string __tmp18Prefix = "		"; //74:1
                StringBuilder __tmp19 = new StringBuilder();
                __tmp19.Append(SpringGeneratorUtil.GeneratePomDependency(ns.Name, ns.Name + "-" + module, "1.0"));
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
                        __out.AppendLine(false); //74:82
                    }
                }
            }
            string __tmp20Prefix = "		"; //77:1
            StringBuilder __tmp21 = new StringBuilder();
            __tmp21.Append(SpringGeneratorUtil.GeneratePomDependency("org.springframework", "spring-context", "${springframework.version}"));
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
                    __out.AppendLine(false); //77:117
                }
            }
            if (rest) //78:2
            {
                __out.Append("		<!-- for rest -->"); //79:1
                __out.AppendLine(false); //79:20
                string __tmp22Prefix = "		"; //80:1
                StringBuilder __tmp23 = new StringBuilder();
                __tmp23.Append(SpringGeneratorUtil.GeneratePomDependency("org.springframework", "spring-webmvc", "${springframework.version}"));
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
                        __out.AppendLine(false); //80:116
                    }
                }
            }
            if (webService) //82:2
            {
                __out.Append("		<!-- for SOAP -->"); //83:1
                __out.AppendLine(false); //83:20
                string __tmp24Prefix = "		"; //84:1
                StringBuilder __tmp25 = new StringBuilder();
                __tmp25.Append(SpringGeneratorUtil.GeneratePomDependency("org.springframework.ws", "spring-ws-core", "${springframework.ws.version}"));
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
                        __out.AppendLine(false); //84:123
                    }
                }
                string __tmp26Prefix = "		"; //85:1
                StringBuilder __tmp27 = new StringBuilder();
                __tmp27.Append(SpringGeneratorUtil.GeneratePomDependency("wsdl4j", "wsdl4j", "${wsdl4j.version}"));
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
                        __out.AppendLine(false); //85:87
                    }
                }
            }
            if (webSocket) //87:2
            {
                __out.Append("		<!-- for web socket -->"); //88:1
                __out.AppendLine(false); //88:26
                string __tmp28Prefix = "		"; //89:1
                StringBuilder __tmp29 = new StringBuilder();
                __tmp29.Append(SpringGeneratorUtil.GeneratePomDependency("org.springframework", "spring-messaging", "${springframework.version}"));
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
                        __out.AppendLine(false); //89:119
                    }
                }
            }
            __out.Append("    </dependencies>"); //91:1
            __out.AppendLine(false); //91:20
            __out.Append("</project>"); //92:1
            __out.AppendLine(false); //92:11
            return __out.ToString();
        }

        public string generateDataPom(Namespace ns, string moduleName, string dependency) //95:1
        {
            StringBuilder __out = new StringBuilder();
            StringBuilder __tmp2 = new StringBuilder();
            __tmp2.Append(SpringGeneratorUtil.GeneratePomStart());
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
                    __out.AppendLine(false); //96:41
                }
            }
            __out.Append("    <parent>"); //97:1
            __out.AppendLine(false); //97:13
            string __tmp4Line = "        <artifactId>"; //98:1
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
            string __tmp6Line = "App</artifactId>"; //98:30
            if (__tmp6Line != null) __out.Append(__tmp6Line);
            __out.AppendLine(false); //98:46
            string __tmp8Line = "        <groupId>"; //99:1
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
            string __tmp10Line = "</groupId>"; //99:27
            if (__tmp10Line != null) __out.Append(__tmp10Line);
            __out.AppendLine(false); //99:37
            __out.Append("        <version>1.0</version>"); //100:1
            __out.AppendLine(false); //100:31
            __out.Append("    </parent>"); //101:1
            __out.AppendLine(false); //101:14
            string __tmp12Line = "    <artifactId>"; //103:1
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
            string __tmp14Line = "-"; //103:26
            if (__tmp14Line != null) __out.Append(__tmp14Line);
            StringBuilder __tmp15 = new StringBuilder();
            __tmp15.Append(moduleName);
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
            string __tmp16Line = "</artifactId>"; //103:39
            if (__tmp16Line != null) __out.Append(__tmp16Line);
            __out.AppendLine(false); //103:52
            __out.Append("    <dependencies>"); //105:1
            __out.AppendLine(false); //105:19
            if (dependency.Any()) //106:3
            {
                string __tmp17Prefix = "		"; //107:1
                StringBuilder __tmp18 = new StringBuilder();
                __tmp18.Append(SpringGeneratorUtil.GeneratePomDependency(ns.Name, ns.Name + "-" + dependency, "1.0"));
                using(StreamReader __tmp18Reader = new StreamReader(this.__ToStream(__tmp18.ToString())))
                {
                    bool __tmp18_first = true;
                    bool __tmp18_last = __tmp18Reader.EndOfStream;
                    while(__tmp18_first || !__tmp18_last)
                    {
                        __tmp18_first = false;
                        string __tmp18Line = __tmp18Reader.ReadLine();
                        __tmp18_last = __tmp18Reader.EndOfStream;
                        __out.Append(__tmp17Prefix);
                        if (__tmp18Line != null) __out.Append(__tmp18Line);
                        if (!__tmp18_last) __out.AppendLine(true);
                        __out.AppendLine(false); //107:86
                    }
                }
            }
            __out.Append("		<!-- spring data -->"); //109:1
            __out.AppendLine(false); //109:23
            string __tmp19Prefix = "		"; //110:1
            StringBuilder __tmp20 = new StringBuilder();
            __tmp20.Append(SpringGeneratorUtil.GeneratePomDependency("org.springframework", "spring-orm", "${springframework.version}"));
            using(StreamReader __tmp20Reader = new StreamReader(this.__ToStream(__tmp20.ToString())))
            {
                bool __tmp20_first = true;
                bool __tmp20_last = __tmp20Reader.EndOfStream;
                while(__tmp20_first || !__tmp20_last)
                {
                    __tmp20_first = false;
                    string __tmp20Line = __tmp20Reader.ReadLine();
                    __tmp20_last = __tmp20Reader.EndOfStream;
                    __out.Append(__tmp19Prefix);
                    if (__tmp20Line != null) __out.Append(__tmp20Line);
                    if (!__tmp20_last) __out.AppendLine(true);
                    __out.AppendLine(false); //110:112
                }
            }
            string __tmp21Prefix = "		"; //111:1
            StringBuilder __tmp22 = new StringBuilder();
            __tmp22.Append(SpringGeneratorUtil.GeneratePomDependency("org.springframework.data", "spring-data-jpa", "${spring-data-jpa.version}"));
            using(StreamReader __tmp22Reader = new StreamReader(this.__ToStream(__tmp22.ToString())))
            {
                bool __tmp22_first = true;
                bool __tmp22_last = __tmp22Reader.EndOfStream;
                while(__tmp22_first || !__tmp22_last)
                {
                    __tmp22_first = false;
                    string __tmp22Line = __tmp22Reader.ReadLine();
                    __tmp22_last = __tmp22Reader.EndOfStream;
                    __out.Append(__tmp21Prefix);
                    if (__tmp22Line != null) __out.Append(__tmp22Line);
                    if (!__tmp22_last) __out.AppendLine(true);
                    __out.AppendLine(false); //111:123
                }
            }
            __out.Append("          <!--  <exclusions>"); //112:1
            __out.AppendLine(false); //112:29
            __out.Append("                <exclusion>"); //113:1
            __out.AppendLine(false); //113:28
            __out.Append("                    <groupId>org.springframework</groupId>"); //114:1
            __out.AppendLine(false); //114:59
            __out.Append("                    <artifactId>spring-orm</artifactId>"); //115:1
            __out.AppendLine(false); //115:56
            __out.Append("                </exclusion>"); //116:1
            __out.AppendLine(false); //116:29
            __out.Append("            </exclusions> -->"); //117:1
            __out.AppendLine(false); //117:30
            __out.Append("	</dependencies>"); //118:1
            __out.AppendLine(false); //118:17
            __out.Append("</project>"); //119:1
            __out.AppendLine(false); //119:11
            return __out.ToString();
        }

        public string generateComponentSpringConfig(Namespace ns) //122:1
        {
            StringBuilder __out = new StringBuilder();
            __out.Append("<?xml version=\"1.0\" encoding=\"UTF-8\"?>"); //123:1
            __out.AppendLine(false); //123:39
            __out.Append("<beans xmlns=\"http://www.springframework.org/schema/beans\""); //124:1
            __out.AppendLine(false); //124:59
            __out.Append("       xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\""); //125:1
            __out.AppendLine(false); //125:61
            __out.Append("       xmlns:context=\"http://www.springframework.org/schema/context\""); //126:1
            __out.AppendLine(false); //126:69
            __out.Append("       xmlns:jpa=\"http://www.springframework.org/schema/data/jpa\""); //127:1
            __out.AppendLine(false); //127:66
            __out.Append("       xsi:schemaLocation=\"http://www.springframework.org/schema/beans"); //128:1
            __out.AppendLine(false); //128:71
            __out.Append("       http://www.springframework.org/schema/beans/spring-beans.xsd"); //129:1
            __out.AppendLine(false); //129:68
            __out.Append("       http://www.springframework.org/schema/context"); //130:1
            __out.AppendLine(false); //130:53
            __out.Append("       http://www.springframework.org/schema/context/spring-context.xsd"); //131:1
            __out.AppendLine(false); //131:72
            __out.Append("       http://www.springframework.org/schema/data/jpa"); //132:1
            __out.AppendLine(false); //132:54
            __out.Append("       http://www.springframework.org/schema/data/jpa/spring-jpa.xsd\">"); //133:1
            __out.AppendLine(false); //133:71
            __out.AppendLine(true); //134:5
            string __tmp2Line = "       <jpa:repositories base-package=\""; //135:1
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
            string __tmp4Line = "."; //135:63
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
            string __tmp6Line = "\"/>"; //135:114
            if (__tmp6Line != null) __out.Append(__tmp6Line);
            __out.AppendLine(false); //135:117
            string __tmp8Line = "       <context:component-scan base-package=\""; //136:1
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
            string __tmp10Line = "."; //136:69
            if (__tmp10Line != null) __out.Append(__tmp10Line);
            StringBuilder __tmp11 = new StringBuilder();
            __tmp11.Append(SpringGeneratorUtil.Properties.serviceFacadePackage);
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
            string __tmp12Line = "\"/>"; //136:123
            if (__tmp12Line != null) __out.Append(__tmp12Line);
            __out.AppendLine(false); //136:126
            __out.Append("</beans>"); //137:1
            __out.AppendLine(false); //137:9
            return __out.ToString();
        }

        public string generateDataSpringConfig(Namespace ns) //140:1
        {
            StringBuilder __out = new StringBuilder();
            __out.Append("<?xml version=\"1.0\" encoding=\"UTF-8\"?>"); //141:1
            __out.AppendLine(false); //141:39
            __out.Append("<beans xmlns=\"http://www.springframework.org/schema/beans\""); //142:1
            __out.AppendLine(false); //142:59
            __out.Append("       xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\""); //143:1
            __out.AppendLine(false); //143:61
            __out.Append("       xmlns:jpa=\"http://www.springframework.org/schema/data/jpa\""); //144:1
            __out.AppendLine(false); //144:66
            __out.Append("       xsi:schemaLocation=\"http://www.springframework.org/schema/beans"); //145:1
            __out.AppendLine(false); //145:71
            __out.Append("       http://www.springframework.org/schema/beans/spring-beans.xsd"); //146:1
            __out.AppendLine(false); //146:68
            __out.Append("       http://www.springframework.org/schema/data/jpa"); //147:1
            __out.AppendLine(false); //147:54
            __out.Append("       http://www.springframework.org/schema/data/jpa/spring-jpa.xsd\">"); //148:1
            __out.AppendLine(false); //148:71
            __out.AppendLine(true); //149:5
            string __tmp2Line = "       <jpa:repositories base-package=\""; //150:1
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
            string __tmp4Line = "."; //150:63
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
            string __tmp6Line = "\"/>"; //150:114
            if (__tmp6Line != null) __out.Append(__tmp6Line);
            __out.AppendLine(false); //150:117
            __out.AppendLine(true); //151:8
            __out.Append("       <bean id=\"jpaVendorAdapter\" class=\"org.springframework.orm.jpa.vendor.EclipseLinkJpaVendorAdapter\"/>"); //152:1
            __out.AppendLine(false); //152:108
            __out.Append("       <bean id=\"entityManagerFactory\" class=\"org.springframework.orm.jpa.LocalEntityManagerFactoryBean\">"); //153:1
            __out.AppendLine(false); //153:106
            string __tmp8Line = "              <property name=\"persistenceUnitName\" value=\""; //154:1
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
            string __tmp10Line = "PU\"/>"; //154:68
            if (__tmp10Line != null) __out.Append(__tmp10Line);
            __out.AppendLine(false); //154:73
            __out.Append("              <property name=\"jpaVendorAdapter\" ref=\"jpaVendorAdapter\"/>"); //155:1
            __out.AppendLine(false); //155:73
            __out.Append("       </bean>"); //156:1
            __out.AppendLine(false); //156:15
            __out.Append("       <bean id=\"transactionManager\" class=\"org.springframework.orm.jpa.JpaTransactionManager\">"); //157:1
            __out.AppendLine(false); //157:96
            __out.Append("              <property name=\"entityManagerFactory\" ref=\"entityManagerFactory\"/>"); //158:1
            __out.AppendLine(false); //158:81
            __out.Append("       </bean>"); //159:1
            __out.AppendLine(false); //159:15
            __out.Append("</beans>"); //160:1
            __out.AppendLine(false); //160:9
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
