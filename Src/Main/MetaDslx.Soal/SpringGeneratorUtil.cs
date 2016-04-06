using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Soal //1:1
{
    using __Hidden_SpringGeneratorUtil_268159518;
    namespace __Hidden_SpringGeneratorUtil_268159518
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

        public __Properties Properties { get; private set; } //6:1

        public class __Properties //6:1
        {
            internal __Properties()
            {
                this.entityPackage = "entity"; //7:25
                this.repositoryPackage = "repository"; //8:29
                this.exceptionPackage = "exception"; //9:28
                this.interfacePackage = "interfaces"; //10:28
                this.enumPackage = "enums"; //11:23
                this.serviceFacadePackage = "facade"; //12:32
                this.controllerPackage = "controller"; //13:29
            }
            public string entityPackage { get; set; } //7:2
            public string repositoryPackage { get; set; } //8:2
            public string exceptionPackage { get; set; } //9:2
            public string interfacePackage { get; set; } //10:2
            public string enumPackage { get; set; } //11:2
            public string serviceFacadePackage { get; set; } //12:2
            public string controllerPackage { get; set; } //13:2
        }

        public string GenerateGetter(Property prop) //18:1
        {
            StringBuilder __out = new StringBuilder();
            __out.AppendLine(true); //19:1
            string __tmp2Line = "public "; //20:1
            if (__tmp2Line != null) __out.Append(__tmp2Line);
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(prop.Type.GetJavaName());
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
            string __tmp4Line = " get"; //20:33
            if (__tmp4Line != null) __out.Append(__tmp4Line);
            StringBuilder __tmp5 = new StringBuilder();
            __tmp5.Append(prop.Name.ToString().ToPascalCase());
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
            string __tmp6Line = "() {"; //20:74
            if (__tmp6Line != null) __out.Append(__tmp6Line);
            __out.AppendLine(false); //20:78
            string __tmp8Line = "	return this."; //21:1
            if (__tmp8Line != null) __out.Append(__tmp8Line);
            StringBuilder __tmp9 = new StringBuilder();
            __tmp9.Append(prop.Name.ToString().ToCamelCase());
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
            string __tmp10Line = ";"; //21:50
            if (__tmp10Line != null) __out.Append(__tmp10Line);
            __out.AppendLine(false); //21:51
            __out.Append("}"); //22:1
            __out.AppendLine(false); //22:2
            return __out.ToString();
        }

        public string GenerateSetter(Property prop) //27:1
        {
            StringBuilder __out = new StringBuilder();
            __out.AppendLine(true); //28:1
            string __tmp2Line = "public void set"; //29:1
            if (__tmp2Line != null) __out.Append(__tmp2Line);
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(prop.Name.ToString().ToPascalCase());
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
            string __tmp4Line = "("; //29:53
            if (__tmp4Line != null) __out.Append(__tmp4Line);
            StringBuilder __tmp5 = new StringBuilder();
            __tmp5.Append(prop.Type.GetJavaName());
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
            string __tmp6Line = " "; //29:79
            if (__tmp6Line != null) __out.Append(__tmp6Line);
            StringBuilder __tmp7 = new StringBuilder();
            __tmp7.Append(prop.Name.ToString().ToCamelCase());
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
            string __tmp8Line = ") {"; //29:116
            if (__tmp8Line != null) __out.Append(__tmp8Line);
            __out.AppendLine(false); //29:119
            string __tmp10Line = "	this."; //30:1
            if (__tmp10Line != null) __out.Append(__tmp10Line);
            StringBuilder __tmp11 = new StringBuilder();
            __tmp11.Append(prop.Name.ToString().ToCamelCase());
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
            string __tmp12Line = " = "; //30:43
            if (__tmp12Line != null) __out.Append(__tmp12Line);
            StringBuilder __tmp13 = new StringBuilder();
            __tmp13.Append(prop.Name.ToString().ToCamelCase());
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
            string __tmp14Line = ";"; //30:82
            if (__tmp14Line != null) __out.Append(__tmp14Line);
            __out.AppendLine(false); //30:83
            __out.Append("}"); //31:1
            __out.AppendLine(false); //31:2
            return __out.ToString();
        }

        public string GenerateImports(Declaration declaration) //36:1
        {
            StringBuilder __out = new StringBuilder();
            StringBuilder __tmp2 = new StringBuilder();
            __tmp2.Append(GenerateImports(declaration, true));
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
                    __out.AppendLine(false); //37:37
                }
            }
            return __out.ToString();
        }

        public string GenerateImports(Declaration declaration, bool reposNeeded) //42:1
        {
            StringBuilder __out = new StringBuilder();
            if (declaration.GetImports().Any()) //43:3
            {
                var __loop1_results = 
                    (from __loop1_var1 in __Enumerate((declaration).GetEnumerator()) //44:10
                    from import in __Enumerate((__loop1_var1.GetImports()).GetEnumerator()) //44:23
                    select new { __loop1_var1 = __loop1_var1, import = import}
                    ).ToList(); //44:4
                int __loop1_iteration = 0;
                foreach (var __tmp1 in __loop1_results)
                {
                    ++__loop1_iteration;
                    var __loop1_var1 = __tmp1.__loop1_var1;
                    var import = __tmp1.import;
                    if (!(import.Contains("repo") && reposNeeded == false)) //45:5
                    {
                        StringBuilder __tmp3 = new StringBuilder();
                        __tmp3.Append(import);
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
                                __out.AppendLine(false); //46:9
                            }
                        }
                    }
                }
                __out.AppendLine(true); //49:1
            }
            return __out.ToString();
        }

        public string GetParameterList(Operation op) //55:1
        {
            string result = ""; //56:5
            var __loop2_results = 
                (from __loop2_var1 in __Enumerate((op).GetEnumerator()) //57:11
                from param in __Enumerate((__loop2_var1.Parameters).GetEnumerator()) //57:15
                select new { __loop2_var1 = __loop2_var1, param = param}
                ).ToList(); //57:5
            int __loop2_iteration = 0;
            string delimiter = ""; //57:33
            foreach (var __tmp1 in __loop2_results)
            {
                ++__loop2_iteration;
                if (__loop2_iteration >= 2) //57:56
                {
                    delimiter = ", "; //57:56
                }
                var __loop2_var1 = __tmp1.__loop2_var1;
                var param = __tmp1.param;
                result = result + delimiter + param.Type.GetJavaName() + " " + param.Name.ToString().ToCamelCase(); //58:9
            }
            return result; //60:5
        }

        public string GetParameterNameList(Operation op) //65:1
        {
            string result = ""; //66:5
            var __loop3_results = 
                (from __loop3_var1 in __Enumerate((op).GetEnumerator()) //67:11
                from param in __Enumerate((__loop3_var1.Parameters).GetEnumerator()) //67:15
                select new { __loop3_var1 = __loop3_var1, param = param}
                ).ToList(); //67:5
            int __loop3_iteration = 0;
            string delimiter = ""; //67:33
            foreach (var __tmp1 in __loop3_results)
            {
                ++__loop3_iteration;
                if (__loop3_iteration >= 2) //67:56
                {
                    delimiter = ", "; //67:56
                }
                var __loop3_var1 = __tmp1.__loop3_var1;
                var param = __tmp1.param;
                result = result + delimiter + param.Name.ToString().ToCamelCase(); //68:9
            }
            return result; //70:5
        }

        public string GetExceptionList(Operation op) //75:1
        {
            string result = ""; //76:5
            var __loop4_results = 
                (from __loop4_var1 in __Enumerate((op).GetEnumerator()) //77:11
                from exc in __Enumerate((__loop4_var1.Exceptions).GetEnumerator()) //77:15
                select new { __loop4_var1 = __loop4_var1, exc = exc}
                ).ToList(); //77:5
            int __loop4_iteration = 0;
            string delimiter = ""; //77:31
            foreach (var __tmp1 in __loop4_results)
            {
                ++__loop4_iteration;
                if (__loop4_iteration >= 2) //77:54
                {
                    delimiter = ", "; //77:54
                }
                var __loop4_var1 = __tmp1.__loop4_var1;
                var exc = __tmp1.exc;
                result = result + delimiter + exc.GetJavaName(); //78:9
            }
            return result; //80:5
        }

        public string GetPropertyList(Struct sType) //85:1
        {
            string result = ""; //86:5
            var __loop5_results = 
                (from __loop5_var1 in __Enumerate((sType).GetEnumerator()) //87:11
                from p in __Enumerate((__loop5_var1.Properties).GetEnumerator()) //87:18
                select new { __loop5_var1 = __loop5_var1, p = p}
                ).ToList(); //87:5
            int __loop5_iteration = 0;
            string delimiter = ""; //87:32
            foreach (var __tmp1 in __loop5_results)
            {
                ++__loop5_iteration;
                if (__loop5_iteration >= 2) //87:55
                {
                    delimiter = ", "; //87:55
                }
                var __loop5_var1 = __tmp1.__loop5_var1;
                var p = __tmp1.p;
                result = result + delimiter + p.Type.GetJavaName() + " " + p.Name.ToString().ToCamelCase(); //88:9
            }
            return result; //90:5
        }

        public int GetNumberOfFieldWithIdSuffix(Struct sType) //95:1
        {
            int result = 0; //96:2
            var __loop6_results = 
                (from __loop6_var1 in __Enumerate((sType).GetEnumerator()) //97:8
                from p in __Enumerate((__loop6_var1.Properties).GetEnumerator()) //97:15
                select new { __loop6_var1 = __loop6_var1, p = p}
                ).ToList(); //97:2
            int __loop6_iteration = 0;
            foreach (var __tmp1 in __loop6_results)
            {
                ++__loop6_iteration;
                var __loop6_var1 = __tmp1.__loop6_var1;
                var p = __tmp1.p;
                if (p.Name.ToString().EndsWith("Id")) //98:3
                {
                    result++; //99:4
                }
            }
            return result; //102:5
        }

        public string GetPackage(Declaration d) //107:1
        {
            return d.Namespace.FullName.ToLower(); //108:2
        }

        public string GetBindingType(Reference reference) //113:1
        {
            Binding binding = reference.Binding; //114:2
            if (binding == null) //115:2
            {
                return ""; //116:3
            }
            if (binding.Transport is RestTransportBindingElement) //118:2
            {
                return "Rest"; //119:3
            }
            if (binding.Transport is WebSocketTransportBindingElement) //121:2
            {
                return "WebSocket"; //122:3
            }
            var __loop7_results = 
                (from __loop7_var1 in __Enumerate((binding).GetEnumerator()) //124:8
                from encoding in __Enumerate((__loop7_var1.Encodings).GetEnumerator()) //124:17
                select new { __loop7_var1 = __loop7_var1, encoding = encoding}
                ).ToList(); //124:2
            int __loop7_iteration = 0;
            foreach (var __tmp1 in __loop7_results)
            {
                ++__loop7_iteration;
                var __loop7_var1 = __tmp1.__loop7_var1;
                var encoding = __tmp1.encoding;
                if (encoding is SoapEncodingBindingElement) //125:3
                {
                    return "WebService"; //126:4
                }
            }
            return ""; //129:2
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
