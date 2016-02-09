using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Soal //1:1
{
    using __Hidden_SpringGeneratorUtil_401790369;
    namespace __Hidden_SpringGeneratorUtil_401790369
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

        public string GetParameterList(Operation op) //27:1
        {
            string result = ""; //28:5
            var __loop1_results = 
                (from __loop1_var1 in __Enumerate((op).GetEnumerator()) //29:11
                from param in __Enumerate((__loop1_var1.Parameters).GetEnumerator()) //29:15
                select new { __loop1_var1 = __loop1_var1, param = param}
                ).ToList(); //29:5
            int __loop1_iteration = 0;
            string delimiter = ""; //29:33
            foreach (var __tmp1 in __loop1_results)
            {
                ++__loop1_iteration;
                if (__loop1_iteration >= 2) //29:56
                {
                    delimiter = ", "; //29:56
                }
                var __loop1_var1 = __tmp1.__loop1_var1;
                var param = __tmp1.param;
                result = result + delimiter + param.Type.GetJavaName() + " " + param.Name.ToString().ToCamelCase(); //30:9
            }
            return result; //32:5
        }

        public string GetPropertyList(StructuredType sType) //35:1
        {
            string result = ""; //36:5
            var __loop2_results = 
                (from __loop2_var1 in __Enumerate((sType).GetEnumerator()) //37:11
                from p in __Enumerate((__loop2_var1.Properties).GetEnumerator()) //37:18
                select new { __loop2_var1 = __loop2_var1, p = p}
                ).ToList(); //37:5
            int __loop2_iteration = 0;
            string delimiter = ""; //37:32
            foreach (var __tmp1 in __loop2_results)
            {
                ++__loop2_iteration;
                if (__loop2_iteration >= 2) //37:55
                {
                    delimiter = ", "; //37:55
                }
                var __loop2_var1 = __tmp1.__loop2_var1;
                var p = __tmp1.p;
                result = result + delimiter + p.Type.GetJavaName() + " " + p.Name.ToString().ToCamelCase(); //38:9
            }
            return result; //40:5
        }

        public string GetInterfaceList(Component comp) //43:1
        {
            string result = ""; //44:5
            var __loop3_results = 
                (from __loop3_var1 in __Enumerate((comp).GetEnumerator()) //45:11
                from service in __Enumerate((__loop3_var1.Services).GetEnumerator()) //45:17
                select new { __loop3_var1 = __loop3_var1, service = service}
                ).ToList(); //45:5
            int __loop3_iteration = 0;
            string delimiter = ""; //45:35
            foreach (var __tmp1 in __loop3_results)
            {
                ++__loop3_iteration;
                if (__loop3_iteration >= 2) //45:58
                {
                    delimiter = ", "; //45:58
                }
                var __loop3_var1 = __tmp1.__loop3_var1;
                var service = __tmp1.service;
                result = result + delimiter + service.Interface.Name; //46:9
            }
            return result; //48:5
        }

        public int GetNumberOfFieldWithIdSuffix(StructuredType sType) //51:1
        {
            int result = 0; //52:2
            var __loop4_results = 
                (from __loop4_var1 in __Enumerate((sType).GetEnumerator()) //53:8
                from p in __Enumerate((__loop4_var1.Properties).GetEnumerator()) //53:15
                select new { __loop4_var1 = __loop4_var1, p = p}
                ).ToList(); //53:2
            int __loop4_iteration = 0;
            foreach (var __tmp1 in __loop4_results)
            {
                ++__loop4_iteration;
                var __loop4_var1 = __tmp1.__loop4_var1;
                var p = __tmp1.p;
                if (p.Name.ToString().EndsWith("Id")) //54:3
                {
                    result++; //55:4
                }
            }
            return result; //58:5
        }

        public string GetPackage(Declaration d) //61:1
        {
            return d.Namespace.FullName.ToLower(); //62:2
        }

    }
}
