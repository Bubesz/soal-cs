using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Soal //1:1
{
    using __Hidden_SpringGeneratorUtil_1094748488;
    namespace __Hidden_SpringGeneratorUtil_1094748488
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

    public class SpringGeneratorUtil //2:1
    {
        private object Instances; //2:1

        public SpringGeneratorUtil() //2:1
        {
            this.Properties = new __Properties();
        }

        public SpringGeneratorUtil(object instances) : this() //2:1
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

        public __Properties Properties { get; private set; } //4:1

        public class __Properties //4:1
        {
            internal __Properties()
            {
                this.entityPackage = "entity"; //5:25
                this.repositoryPackage = "repository"; //6:29
                this.exceptionPackage = "exception"; //7:28
                this.interfacePackage = "interfaces"; //8:28
                this.enumPackage = "enums"; //9:23
                this.serviceFacadePackage = "facade"; //10:32
            }
            public string entityPackage { get; set; } //5:2
            public string repositoryPackage { get; set; } //6:2
            public string exceptionPackage { get; set; } //7:2
            public string interfacePackage { get; set; } //8:2
            public string enumPackage { get; set; } //9:2
            public string serviceFacadePackage { get; set; } //10:2
        }

        public string GenerateGetter(Property prop) //13:1
        {
            StringBuilder __out = new StringBuilder();
            __out.AppendLine(); //14:1
            string __tmp1Prefix = "public "; //15:1
            string __tmp2Suffix = "() {"; //15:74
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(prop.Type.GetJavaName());
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
            string __tmp4Line = " get"; //15:33
            __out.Append(__tmp4Line);
            StringBuilder __tmp5 = new StringBuilder();
            __tmp5.Append(prop.Name.ToString().ToPascalCase());
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
                    __out.AppendLine(); //15:78
                }
            }
            string __tmp6Prefix = "	return this."; //16:1
            string __tmp7Suffix = ";"; //16:50
            StringBuilder __tmp8 = new StringBuilder();
            __tmp8.Append(prop.Name.ToString().ToCamelCase());
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
                    __out.AppendLine(); //16:51
                }
            }
            __out.Append("}"); //17:1
            __out.AppendLine(); //17:2
            return __out.ToString();
        }

        public string GenerateSetter(Property prop) //20:1
        {
            StringBuilder __out = new StringBuilder();
            __out.AppendLine(); //21:1
            string __tmp1Prefix = "public void set"; //22:1
            string __tmp2Suffix = ") {"; //22:116
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(prop.Name.ToString().ToPascalCase());
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
            string __tmp4Line = "("; //22:53
            __out.Append(__tmp4Line);
            StringBuilder __tmp5 = new StringBuilder();
            __tmp5.Append(prop.Type.GetJavaName());
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
                }
            }
            string __tmp6Line = " "; //22:79
            __out.Append(__tmp6Line);
            StringBuilder __tmp7 = new StringBuilder();
            __tmp7.Append(prop.Name.ToString().ToCamelCase());
            using(StreamReader __tmp7Reader = new StreamReader(this.__ToStream(__tmp7.ToString())))
            {
                bool __tmp7_first = true;
                while(__tmp7_first || !__tmp7Reader.EndOfStream)
                {
                    __tmp7_first = false;
                    string __tmp7Line = __tmp7Reader.ReadLine();
                    if (__tmp7Line == null)
                    {
                        __tmp7Line = "";
                    }
                    __out.Append(__tmp7Line);
                    __out.Append(__tmp2Suffix);
                    __out.AppendLine(); //22:119
                }
            }
            string __tmp8Prefix = "	this."; //23:1
            string __tmp9Suffix = ";"; //23:82
            StringBuilder __tmp10 = new StringBuilder();
            __tmp10.Append(prop.Name.ToString().ToCamelCase());
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
            string __tmp11Line = " = "; //23:43
            __out.Append(__tmp11Line);
            StringBuilder __tmp12 = new StringBuilder();
            __tmp12.Append(prop.Name.ToString().ToCamelCase());
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
                    __out.Append(__tmp9Suffix);
                    __out.AppendLine(); //23:83
                }
            }
            __out.Append("}"); //24:1
            __out.AppendLine(); //24:2
            return __out.ToString();
        }

        public string GenerateImports(Declaration declaration) //27:1
        {
            StringBuilder __out = new StringBuilder();
            if (declaration.GetImports().Any()) //28:3
            {
                var __loop1_results = 
                    (from __loop1_var1 in __Enumerate((declaration).GetEnumerator()) //29:10
                    from import in __Enumerate((__loop1_var1.GetImports()).GetEnumerator()) //29:23
                    select new { __loop1_var1 = __loop1_var1, import = import}
                    ).ToList(); //29:4
                int __loop1_iteration = 0;
                foreach (var __tmp1 in __loop1_results)
                {
                    ++__loop1_iteration;
                    var __loop1_var1 = __tmp1.__loop1_var1;
                    var import = __tmp1.import;
                    string __tmp2Prefix = string.Empty;
                    string __tmp3Suffix = string.Empty;
                    StringBuilder __tmp4 = new StringBuilder();
                    __tmp4.Append(import);
                    using(StreamReader __tmp4Reader = new StreamReader(this.__ToStream(__tmp4.ToString())))
                    {
                        bool __tmp4_first = true;
                        while(__tmp4_first || !__tmp4Reader.EndOfStream)
                        {
                            __tmp4_first = false;
                            string __tmp4Line = __tmp4Reader.ReadLine();
                            if (__tmp4Line == null)
                            {
                                __tmp4Line = "";
                            }
                            __out.Append(__tmp2Prefix);
                            __out.Append(__tmp4Line);
                            __out.Append(__tmp3Suffix);
                            __out.AppendLine(); //30:9
                        }
                    }
                }
                __out.AppendLine(); //32:1
            }
            return __out.ToString();
        }

        public string GeneratePomStart() //36:1
        {
            StringBuilder __out = new StringBuilder();
            __out.Append("<?xml version=\"1.0\" encoding=\"UTF-8\"?>"); //37:1
            __out.AppendLine(); //37:39
            __out.Append("<project xmlns=\"http://maven.apache.org/POM/4.0.0\""); //38:1
            __out.AppendLine(); //38:51
            __out.Append("         xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\""); //39:1
            __out.AppendLine(); //39:63
            __out.Append("         xsi:schemaLocation=\"http://maven.apache.org/POM/4.0.0 http://maven.apache.org/xsd/maven-4.0.0.xsd\">"); //40:1
            __out.AppendLine(); //40:109
            __out.Append("	<modelVersion>4.0.0</modelVersion>"); //41:1
            __out.AppendLine(); //41:36
            return __out.ToString();
        }

        public string GeneratePomDependency(string group, string artifact, string version) //45:1
        {
            StringBuilder __out = new StringBuilder();
            __out.Append("<dependency>"); //46:1
            __out.AppendLine(); //46:13
            string __tmp1Prefix = "    <groupId>"; //47:1
            string __tmp2Suffix = "</groupId>"; //47:21
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(group);
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
                    __out.AppendLine(); //47:31
                }
            }
            string __tmp4Prefix = "    <artifactId>"; //48:1
            string __tmp5Suffix = "</artifactId>"; //48:27
            StringBuilder __tmp6 = new StringBuilder();
            __tmp6.Append(artifact);
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
                    __out.AppendLine(); //48:40
                }
            }
            string __tmp7Prefix = "    <version>"; //49:1
            string __tmp8Suffix = "</version>"; //49:23
            StringBuilder __tmp9 = new StringBuilder();
            __tmp9.Append(version);
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
                    __out.AppendLine(); //49:33
                }
            }
            __out.Append("</dependency>"); //50:1
            __out.AppendLine(); //50:14
            return __out.ToString();
        }

        public string GetParameterList(Operation op) //53:1
        {
            string result = ""; //54:5
            var __loop2_results = 
                (from __loop2_var1 in __Enumerate((op).GetEnumerator()) //55:11
                from param in __Enumerate((__loop2_var1.Parameters).GetEnumerator()) //55:15
                select new { __loop2_var1 = __loop2_var1, param = param}
                ).ToList(); //55:5
            int __loop2_iteration = 0;
            string delimiter = ""; //55:33
            foreach (var __tmp1 in __loop2_results)
            {
                ++__loop2_iteration;
                if (__loop2_iteration >= 2) //55:56
                {
                    delimiter = ", "; //55:56
                }
                var __loop2_var1 = __tmp1.__loop2_var1;
                var param = __tmp1.param;
                result = result + delimiter + param.Type.GetJavaName() + " " + param.Name.ToString().ToCamelCase(); //56:9
            }
            return result; //58:5
        }

        public string GetPropertyList(Struct sType) //61:1
        {
            string result = ""; //62:5
            var __loop3_results = 
                (from __loop3_var1 in __Enumerate((sType).GetEnumerator()) //63:11
                from p in __Enumerate((__loop3_var1.Properties).GetEnumerator()) //63:18
                select new { __loop3_var1 = __loop3_var1, p = p}
                ).ToList(); //63:5
            int __loop3_iteration = 0;
            string delimiter = ""; //63:32
            foreach (var __tmp1 in __loop3_results)
            {
                ++__loop3_iteration;
                if (__loop3_iteration >= 2) //63:55
                {
                    delimiter = ", "; //63:55
                }
                var __loop3_var1 = __tmp1.__loop3_var1;
                var p = __tmp1.p;
                result = result + delimiter + p.Type.GetJavaName() + " " + p.Name.ToString().ToCamelCase(); //64:9
            }
            return result; //66:5
        }

        public string GetInterfaceList(Component component) //69:1
        {
            string result = ""; //70:5
            HashSet<Service> services = new HashSet<Service>(component.Services); //71:2
            var __loop4_results = 
                (from __loop4_var1 in __Enumerate((services).GetEnumerator()) //72:7
                from i in __Enumerate((__loop4_var1.Interface).GetEnumerator()) //72:17
                select new { __loop4_var1 = __loop4_var1, i = i}
                ).ToList(); //72:2
            int __loop4_iteration = 0;
            string delimiter = ""; //72:30
            foreach (var __tmp1 in __loop4_results)
            {
                ++__loop4_iteration;
                if (__loop4_iteration >= 2) //72:53
                {
                    delimiter = ", "; //72:53
                }
                var __loop4_var1 = __tmp1.__loop4_var1;
                var i = __tmp1.i;
                result = result + delimiter + i.Name; //73:9
            }
            return result; //75:5
        }

        public int GetNumberOfFieldWithIdSuffix(Struct sType) //78:1
        {
            int result = 0; //79:2
            var __loop5_results = 
                (from __loop5_var1 in __Enumerate((sType).GetEnumerator()) //80:8
                from p in __Enumerate((__loop5_var1.Properties).GetEnumerator()) //80:15
                select new { __loop5_var1 = __loop5_var1, p = p}
                ).ToList(); //80:2
            int __loop5_iteration = 0;
            foreach (var __tmp1 in __loop5_results)
            {
                ++__loop5_iteration;
                var __loop5_var1 = __tmp1.__loop5_var1;
                var p = __tmp1.p;
                if (p.Name.ToString().EndsWith("Id")) //81:3
                {
                    result++; //82:4
                }
            }
            return result; //85:5
        }

        public string GetPackage(Declaration d) //88:1
        {
            return d.Namespace.FullName.ToLower(); //89:2
        }

    }
}
