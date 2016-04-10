using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Soal //1:1
{
    using __Hidden_SpringInterfaceGenerator_1424065681;
    namespace __Hidden_SpringInterfaceGenerator_1424065681
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

    public class SpringInterfaceGenerator //2:1
    {
        private object Instances; //2:1

        public SpringInterfaceGenerator() //2:1
        {
        }

        public SpringInterfaceGenerator(object instances) : this() //2:1
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

        public string GenerateInterface(Interface iface, string bindingType) //7:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp2Line = "package "; //8:1
            if (__tmp2Line != null) __out.Append(__tmp2Line);
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(SpringGeneratorUtil.GetPackage(iface));
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
            string __tmp4Line = "."; //8:48
            if (__tmp4Line != null) __out.Append(__tmp4Line);
            StringBuilder __tmp5 = new StringBuilder();
            __tmp5.Append(SpringGeneratorUtil.Properties.interfacePackage);
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
            string __tmp6Line = ";"; //8:98
            if (__tmp6Line != null) __out.Append(__tmp6Line);
            __out.AppendLine(false); //8:99
            __out.AppendLine(true); //9:1
            if (bindingType.Equals("Rest")) //10:2
            {
                __out.Append("import org.springframework.web.bind.annotation.PathVariable;"); //11:1
                __out.AppendLine(false); //11:61
                __out.Append("import org.springframework.web.bind.annotation.RequestMapping;"); //12:1
                __out.AppendLine(false); //12:63
                __out.Append("import org.springframework.web.bind.annotation.RestController;"); //13:1
                __out.AppendLine(false); //13:63
            }
            if (bindingType.Equals("WebService")) //15:2
            {
                __out.Append("//import ?;"); //16:1
                __out.AppendLine(false); //16:12
            }
            if (bindingType.Equals("WebSockett")) //18:2
            {
                __out.Append("//import ?;"); //19:1
                __out.AppendLine(false); //19:12
            }
            StringBuilder __tmp8 = new StringBuilder();
            __tmp8.Append(SpringGeneratorUtil.GenerateImports(iface, false));
            using(StreamReader __tmp8Reader = new StreamReader(this.__ToStream(__tmp8.ToString())))
            {
                bool __tmp8_first = true;
                bool __tmp8_last = __tmp8Reader.EndOfStream;
                while(__tmp8_first || !__tmp8_last)
                {
                    __tmp8_first = false;
                    string __tmp8Line = __tmp8Reader.ReadLine();
                    __tmp8_last = __tmp8Reader.EndOfStream;
                    if (__tmp8Line != null) __out.Append(__tmp8Line);
                    if (!__tmp8_last) __out.AppendLine(true);
                    __out.AppendLine(false); //22:52
                }
            }
            __out.AppendLine(true); //23:1
            StringBuilder __tmp10 = new StringBuilder();
            __tmp10.Append(InterfaceAnnotation(bindingType));
            using(StreamReader __tmp10Reader = new StreamReader(this.__ToStream(__tmp10.ToString())))
            {
                bool __tmp10_first = true;
                bool __tmp10_last = __tmp10Reader.EndOfStream;
                while(__tmp10_first || !__tmp10_last)
                {
                    __tmp10_first = false;
                    string __tmp10Line = __tmp10Reader.ReadLine();
                    __tmp10_last = __tmp10Reader.EndOfStream;
                    if (__tmp10Line != null) __out.Append(__tmp10Line);
                    if (!__tmp10_last) __out.AppendLine(true);
                    __out.AppendLine(false); //24:35
                }
            }
            string __tmp12Line = "public interface "; //25:1
            if (__tmp12Line != null) __out.Append(__tmp12Line);
            StringBuilder __tmp13 = new StringBuilder();
            __tmp13.Append(iface.Name);
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
            StringBuilder __tmp14 = new StringBuilder();
            __tmp14.Append(bindingType);
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
            string __tmp15Line = " {"; //25:43
            if (__tmp15Line != null) __out.Append(__tmp15Line);
            __out.AppendLine(false); //25:45
            var __loop1_results = 
                (from __loop1_var1 in __Enumerate((iface).GetEnumerator()) //26:8
                from op in __Enumerate((__loop1_var1.Operations).GetEnumerator()) //26:15
                select new { __loop1_var1 = __loop1_var1, op = op}
                ).ToList(); //26:2
            int __loop1_iteration = 0;
            foreach (var __tmp16 in __loop1_results)
            {
                ++__loop1_iteration;
                var __loop1_var1 = __tmp16.__loop1_var1;
                var op = __tmp16.op;
                __out.AppendLine(true); //27:1
                StringBuilder __tmp18 = new StringBuilder();
                __tmp18.Append(OperationAnnotation(bindingType, op));
                using(StreamReader __tmp18Reader = new StreamReader(this.__ToStream(__tmp18.ToString())))
                {
                    bool __tmp18_first = true;
                    bool __tmp18_last = __tmp18Reader.EndOfStream;
                    while(__tmp18_first || !__tmp18_last)
                    {
                        __tmp18_first = false;
                        string __tmp18Line = __tmp18Reader.ReadLine();
                        __tmp18_last = __tmp18Reader.EndOfStream;
                        if (__tmp18Line != null) __out.Append(__tmp18Line);
                        if (!__tmp18_last) __out.AppendLine(true);
                        __out.AppendLine(false); //28:39
                    }
                }
                string __tmp19Prefix = "	"; //29:1
                StringBuilder __tmp20 = new StringBuilder();
                __tmp20.Append(op.Result.Type.GetJavaName());
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
                    }
                }
                string __tmp21Line = " "; //29:32
                if (__tmp21Line != null) __out.Append(__tmp21Line);
                StringBuilder __tmp22 = new StringBuilder();
                __tmp22.Append(op.Name.ToCamelCase());
                using(StreamReader __tmp22Reader = new StreamReader(this.__ToStream(__tmp22.ToString())))
                {
                    bool __tmp22_first = true;
                    bool __tmp22_last = __tmp22Reader.EndOfStream;
                    while(__tmp22_first || !__tmp22_last)
                    {
                        __tmp22_first = false;
                        string __tmp22Line = __tmp22Reader.ReadLine();
                        __tmp22_last = __tmp22Reader.EndOfStream;
                        if (__tmp22Line != null) __out.Append(__tmp22Line);
                        if (!__tmp22_last) __out.AppendLine(true);
                    }
                }
                string __tmp23Line = "("; //29:56
                if (__tmp23Line != null) __out.Append(__tmp23Line);
                var __loop2_results = 
                    (from __loop2_var1 in __Enumerate((op).GetEnumerator()) //30:9
                    from param in __Enumerate((__loop2_var1.Parameters).GetEnumerator()) //30:13
                    select new { __loop2_var1 = __loop2_var1, param = param}
                    ).ToList(); //30:3
                int __loop2_iteration = 0;
                string delimiter = ""; //30:31
                foreach (var __tmp24 in __loop2_results)
                {
                    ++__loop2_iteration;
                    if (__loop2_iteration >= 2) //30:54
                    {
                        delimiter = ", "; //30:54
                    }
                    var __loop2_var1 = __tmp24.__loop2_var1;
                    var param = __tmp24.param;
                    StringBuilder __tmp26 = new StringBuilder();
                    __tmp26.Append(delimiter);
                    using(StreamReader __tmp26Reader = new StreamReader(this.__ToStream(__tmp26.ToString())))
                    {
                        bool __tmp26_first = true;
                        bool __tmp26_last = __tmp26Reader.EndOfStream;
                        while(__tmp26_first || !__tmp26_last)
                        {
                            __tmp26_first = false;
                            string __tmp26Line = __tmp26Reader.ReadLine();
                            __tmp26_last = __tmp26Reader.EndOfStream;
                            if (__tmp26Line != null) __out.Append(__tmp26Line);
                            if (!__tmp26_last) __out.AppendLine(true);
                        }
                    }
                    StringBuilder __tmp27 = new StringBuilder();
                    __tmp27.Append(ParameterAnnotation(bindingType));
                    using(StreamReader __tmp27Reader = new StreamReader(this.__ToStream(__tmp27.ToString())))
                    {
                        bool __tmp27_first = true;
                        bool __tmp27_last = __tmp27Reader.EndOfStream;
                        while(__tmp27_first || !__tmp27_last)
                        {
                            __tmp27_first = false;
                            string __tmp27Line = __tmp27Reader.ReadLine();
                            __tmp27_last = __tmp27Reader.EndOfStream;
                            if (__tmp27Line != null) __out.Append(__tmp27Line);
                            if (!__tmp27_last) __out.AppendLine(true);
                        }
                    }
                    StringBuilder __tmp28 = new StringBuilder();
                    __tmp28.Append(param.Type.GetJavaName());
                    using(StreamReader __tmp28Reader = new StreamReader(this.__ToStream(__tmp28.ToString())))
                    {
                        bool __tmp28_first = true;
                        bool __tmp28_last = __tmp28Reader.EndOfStream;
                        while(__tmp28_first || !__tmp28_last)
                        {
                            __tmp28_first = false;
                            string __tmp28Line = __tmp28Reader.ReadLine();
                            __tmp28_last = __tmp28Reader.EndOfStream;
                            if (__tmp28Line != null) __out.Append(__tmp28Line);
                            if (!__tmp28_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp29Line = " "; //31:72
                    if (__tmp29Line != null) __out.Append(__tmp29Line);
                    StringBuilder __tmp30 = new StringBuilder();
                    __tmp30.Append(param.Name.ToString().ToCamelCase());
                    using(StreamReader __tmp30Reader = new StreamReader(this.__ToStream(__tmp30.ToString())))
                    {
                        bool __tmp30_first = true;
                        bool __tmp30_last = __tmp30Reader.EndOfStream;
                        while(__tmp30_first || !__tmp30_last)
                        {
                            __tmp30_first = false;
                            string __tmp30Line = __tmp30Reader.ReadLine();
                            __tmp30_last = __tmp30Reader.EndOfStream;
                            if (__tmp30Line != null) __out.Append(__tmp30Line);
                            if (!__tmp30_last) __out.AppendLine(true);
                        }
                    }
                }
                __out.Append(")"); //33:1
                if (op.Exceptions.Any()) //34:3
                {
                    string __tmp32Line = " throws "; //35:1
                    if (__tmp32Line != null) __out.Append(__tmp32Line);
                    StringBuilder __tmp33 = new StringBuilder();
                    __tmp33.Append(SpringGeneratorUtil.GetExceptionList(op));
                    using(StreamReader __tmp33Reader = new StreamReader(this.__ToStream(__tmp33.ToString())))
                    {
                        bool __tmp33_first = true;
                        bool __tmp33_last = __tmp33Reader.EndOfStream;
                        while(__tmp33_first || !__tmp33_last)
                        {
                            __tmp33_first = false;
                            string __tmp33Line = __tmp33Reader.ReadLine();
                            __tmp33_last = __tmp33Reader.EndOfStream;
                            if (__tmp33Line != null) __out.Append(__tmp33Line);
                            if (!__tmp33_last) __out.AppendLine(true);
                        }
                    }
                }
                __out.Append(";"); //37:1
                __out.AppendLine(false); //37:2
            }
            __out.Append("}"); //40:1
            __out.AppendLine(false); //40:2
            return __out.ToString();
        }

        public string GenerateInterfaceImplementation(Interface iface, string functionName) //45:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp2Line = "package "; //46:1
            if (__tmp2Line != null) __out.Append(__tmp2Line);
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(SpringGeneratorUtil.GetPackage(iface));
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
            string __tmp4Line = "."; //46:48
            if (__tmp4Line != null) __out.Append(__tmp4Line);
            StringBuilder __tmp5 = new StringBuilder();
            __tmp5.Append(functionName);
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
            string __tmp6Line = ";"; //46:63
            if (__tmp6Line != null) __out.Append(__tmp6Line);
            __out.AppendLine(false); //46:64
            __out.AppendLine(true); //47:1
            __out.Append("import org.springframework.beans.factory.annotation.Autowired;"); //48:1
            __out.AppendLine(false); //48:63
            __out.Append("import org.springframework.stereotype.Service;"); //49:1
            __out.AppendLine(false); //49:47
            __out.AppendLine(true); //50:1
            string __tmp8Line = "import "; //51:1
            if (__tmp8Line != null) __out.Append(__tmp8Line);
            StringBuilder __tmp9 = new StringBuilder();
            __tmp9.Append(SpringGeneratorUtil.GetPackage(iface));
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
            string __tmp10Line = "."; //51:47
            if (__tmp10Line != null) __out.Append(__tmp10Line);
            StringBuilder __tmp11 = new StringBuilder();
            __tmp11.Append(SpringGeneratorUtil.Properties.interfacePackage);
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
            string __tmp12Line = "."; //51:97
            if (__tmp12Line != null) __out.Append(__tmp12Line);
            StringBuilder __tmp13 = new StringBuilder();
            __tmp13.Append(iface.Name);
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
            string __tmp14Line = ";"; //51:110
            if (__tmp14Line != null) __out.Append(__tmp14Line);
            __out.AppendLine(false); //51:111
            StringBuilder __tmp16 = new StringBuilder();
            __tmp16.Append(SpringGeneratorUtil.GenerateImports(iface));
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
                    __out.AppendLine(false); //52:45
                }
            }
            __out.AppendLine(true); //53:1
            __out.Append("@Service"); //54:1
            __out.AppendLine(false); //54:9
            string __tmp18Line = "public class "; //55:1
            if (__tmp18Line != null) __out.Append(__tmp18Line);
            StringBuilder __tmp19 = new StringBuilder();
            __tmp19.Append(iface.Name);
            using(StreamReader __tmp19Reader = new StreamReader(this.__ToStream(__tmp19.ToString())))
            {
                bool __tmp19_first = true;
                bool __tmp19_last = __tmp19Reader.EndOfStream;
                while(__tmp19_first || !__tmp19_last)
                {
                    __tmp19_first = false;
                    string __tmp19Line = __tmp19Reader.ReadLine();
                    __tmp19_last = __tmp19Reader.EndOfStream;
                    if (__tmp19Line != null) __out.Append(__tmp19Line);
                    if (!__tmp19_last) __out.AppendLine(true);
                }
            }
            string __tmp20Line = "Impl implements "; //55:26
            if (__tmp20Line != null) __out.Append(__tmp20Line);
            StringBuilder __tmp21 = new StringBuilder();
            __tmp21.Append(iface.Name);
            using(StreamReader __tmp21Reader = new StreamReader(this.__ToStream(__tmp21.ToString())))
            {
                bool __tmp21_first = true;
                bool __tmp21_last = __tmp21Reader.EndOfStream;
                while(__tmp21_first || !__tmp21_last)
                {
                    __tmp21_first = false;
                    string __tmp21Line = __tmp21Reader.ReadLine();
                    __tmp21_last = __tmp21Reader.EndOfStream;
                    if (__tmp21Line != null) __out.Append(__tmp21Line);
                    if (!__tmp21_last) __out.AppendLine(true);
                }
            }
            string __tmp22Line = " {"; //55:54
            if (__tmp22Line != null) __out.Append(__tmp22Line);
            __out.AppendLine(false); //55:56
            var __loop3_results = 
                (from __loop3_var1 in __Enumerate((iface).GetEnumerator()) //56:8
                from repo in __Enumerate((__loop3_var1.GetRepositories()).GetEnumerator()) //56:15
                select new { __loop3_var1 = __loop3_var1, repo = repo}
                ).ToList(); //56:2
            int __loop3_iteration = 0;
            foreach (var __tmp23 in __loop3_results)
            {
                ++__loop3_iteration;
                var __loop3_var1 = __tmp23.__loop3_var1;
                var repo = __tmp23.repo;
                __out.AppendLine(true); //57:1
                __out.Append("	@Autowired"); //58:1
                __out.AppendLine(false); //58:12
                string __tmp25Line = "	private "; //59:1
                if (__tmp25Line != null) __out.Append(__tmp25Line);
                StringBuilder __tmp26 = new StringBuilder();
                __tmp26.Append(repo);
                using(StreamReader __tmp26Reader = new StreamReader(this.__ToStream(__tmp26.ToString())))
                {
                    bool __tmp26_first = true;
                    bool __tmp26_last = __tmp26Reader.EndOfStream;
                    while(__tmp26_first || !__tmp26_last)
                    {
                        __tmp26_first = false;
                        string __tmp26Line = __tmp26Reader.ReadLine();
                        __tmp26_last = __tmp26Reader.EndOfStream;
                        if (__tmp26Line != null) __out.Append(__tmp26Line);
                        if (!__tmp26_last) __out.AppendLine(true);
                    }
                }
                string __tmp27Line = ";"; //59:16
                if (__tmp27Line != null) __out.Append(__tmp27Line);
                __out.AppendLine(false); //59:17
            }
            var __loop4_results = 
                (from __loop4_var1 in __Enumerate((iface).GetEnumerator()) //61:7
                from op in __Enumerate((__loop4_var1.Operations).GetEnumerator()) //61:14
                select new { __loop4_var1 = __loop4_var1, op = op}
                ).ToList(); //61:2
            int __loop4_iteration = 0;
            foreach (var __tmp28 in __loop4_results)
            {
                ++__loop4_iteration;
                var __loop4_var1 = __tmp28.__loop4_var1;
                var op = __tmp28.op;
                __out.AppendLine(true); //62:1
                string __tmp30Line = "	public "; //63:1
                if (__tmp30Line != null) __out.Append(__tmp30Line);
                StringBuilder __tmp31 = new StringBuilder();
                __tmp31.Append(op.Result.Type.GetJavaName());
                using(StreamReader __tmp31Reader = new StreamReader(this.__ToStream(__tmp31.ToString())))
                {
                    bool __tmp31_first = true;
                    bool __tmp31_last = __tmp31Reader.EndOfStream;
                    while(__tmp31_first || !__tmp31_last)
                    {
                        __tmp31_first = false;
                        string __tmp31Line = __tmp31Reader.ReadLine();
                        __tmp31_last = __tmp31Reader.EndOfStream;
                        if (__tmp31Line != null) __out.Append(__tmp31Line);
                        if (!__tmp31_last) __out.AppendLine(true);
                    }
                }
                string __tmp32Line = " "; //63:39
                if (__tmp32Line != null) __out.Append(__tmp32Line);
                StringBuilder __tmp33 = new StringBuilder();
                __tmp33.Append(op.Name.ToCamelCase());
                using(StreamReader __tmp33Reader = new StreamReader(this.__ToStream(__tmp33.ToString())))
                {
                    bool __tmp33_first = true;
                    bool __tmp33_last = __tmp33Reader.EndOfStream;
                    while(__tmp33_first || !__tmp33_last)
                    {
                        __tmp33_first = false;
                        string __tmp33Line = __tmp33Reader.ReadLine();
                        __tmp33_last = __tmp33Reader.EndOfStream;
                        if (__tmp33Line != null) __out.Append(__tmp33Line);
                        if (!__tmp33_last) __out.AppendLine(true);
                    }
                }
                string __tmp34Line = "("; //63:63
                if (__tmp34Line != null) __out.Append(__tmp34Line);
                StringBuilder __tmp35 = new StringBuilder();
                __tmp35.Append(SpringGeneratorUtil.GetParameterList(op));
                using(StreamReader __tmp35Reader = new StreamReader(this.__ToStream(__tmp35.ToString())))
                {
                    bool __tmp35_first = true;
                    bool __tmp35_last = __tmp35Reader.EndOfStream;
                    while(__tmp35_first || !__tmp35_last)
                    {
                        __tmp35_first = false;
                        string __tmp35Line = __tmp35Reader.ReadLine();
                        __tmp35_last = __tmp35Reader.EndOfStream;
                        if (__tmp35Line != null) __out.Append(__tmp35Line);
                        if (!__tmp35_last) __out.AppendLine(true);
                    }
                }
                string __tmp36Line = ")"; //63:106
                if (__tmp36Line != null) __out.Append(__tmp36Line);
                if (op.Exceptions.Any()) //64:3
                {
                    string __tmp38Line = " throws "; //65:1
                    if (__tmp38Line != null) __out.Append(__tmp38Line);
                    StringBuilder __tmp39 = new StringBuilder();
                    __tmp39.Append(SpringGeneratorUtil.GetExceptionList(op));
                    using(StreamReader __tmp39Reader = new StreamReader(this.__ToStream(__tmp39.ToString())))
                    {
                        bool __tmp39_first = true;
                        bool __tmp39_last = __tmp39Reader.EndOfStream;
                        while(__tmp39_first || !__tmp39_last)
                        {
                            __tmp39_first = false;
                            string __tmp39Line = __tmp39Reader.ReadLine();
                            __tmp39_last = __tmp39Reader.EndOfStream;
                            if (__tmp39Line != null) __out.Append(__tmp39Line);
                            if (!__tmp39_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp40Line = " "; //65:51
                    if (__tmp40Line != null) __out.Append(__tmp40Line);
                }
                __out.Append("{"); //67:1
                __out.AppendLine(false); //67:2
                __out.Append("		// TODO implement method"); //68:1
                __out.AppendLine(false); //68:27
                __out.Append("		throw new UnsupportedOperationException(\"Not yet implemented.\");"); //69:1
                __out.AppendLine(false); //69:67
                __out.Append("	}"); //70:1
                __out.AppendLine(false); //70:3
            }
            __out.Append("}"); //72:1
            __out.AppendLine(false); //72:2
            return __out.ToString();
        }

        public string GenerateProxyInterfaceImplementation(Interface iface, string functionName, string bindingType) //77:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp2Line = "package "; //78:1
            if (__tmp2Line != null) __out.Append(__tmp2Line);
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(SpringGeneratorUtil.GetPackage(iface));
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
            string __tmp4Line = "."; //78:48
            if (__tmp4Line != null) __out.Append(__tmp4Line);
            StringBuilder __tmp5 = new StringBuilder();
            __tmp5.Append(functionName);
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
            string __tmp6Line = ";"; //78:63
            if (__tmp6Line != null) __out.Append(__tmp6Line);
            __out.AppendLine(false); //78:64
            __out.AppendLine(true); //79:1
            __out.Append("import org.springframework.beans.factory.annotation.Autowired;"); //80:1
            __out.AppendLine(false); //80:63
            __out.Append("import org.springframework.stereotype.Service;"); //81:1
            __out.AppendLine(false); //81:47
            __out.AppendLine(true); //82:1
            string __tmp8Line = "import "; //83:1
            if (__tmp8Line != null) __out.Append(__tmp8Line);
            StringBuilder __tmp9 = new StringBuilder();
            __tmp9.Append(SpringGeneratorUtil.GetPackage(iface));
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
            string __tmp10Line = "."; //83:47
            if (__tmp10Line != null) __out.Append(__tmp10Line);
            StringBuilder __tmp11 = new StringBuilder();
            __tmp11.Append(SpringGeneratorUtil.Properties.interfacePackage);
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
            string __tmp12Line = "."; //83:97
            if (__tmp12Line != null) __out.Append(__tmp12Line);
            StringBuilder __tmp13 = new StringBuilder();
            __tmp13.Append(iface.Name);
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
            StringBuilder __tmp14 = new StringBuilder();
            __tmp14.Append(bindingType);
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
            string __tmp15Line = ";"; //83:123
            if (__tmp15Line != null) __out.Append(__tmp15Line);
            __out.AppendLine(false); //83:124
            StringBuilder __tmp17 = new StringBuilder();
            __tmp17.Append(SpringGeneratorUtil.GenerateImports(iface, false));
            using(StreamReader __tmp17Reader = new StreamReader(this.__ToStream(__tmp17.ToString())))
            {
                bool __tmp17_first = true;
                bool __tmp17_last = __tmp17Reader.EndOfStream;
                while(__tmp17_first || !__tmp17_last)
                {
                    __tmp17_first = false;
                    string __tmp17Line = __tmp17Reader.ReadLine();
                    __tmp17_last = __tmp17Reader.EndOfStream;
                    if (__tmp17Line != null) __out.Append(__tmp17Line);
                    if (!__tmp17_last) __out.AppendLine(true);
                    __out.AppendLine(false); //84:52
                }
            }
            __out.AppendLine(true); //85:1
            __out.Append("@Service"); //86:1
            __out.AppendLine(false); //86:9
            string __tmp19Line = "public class "; //87:1
            if (__tmp19Line != null) __out.Append(__tmp19Line);
            StringBuilder __tmp20 = new StringBuilder();
            __tmp20.Append(iface.Name);
            using(StreamReader __tmp20Reader = new StreamReader(this.__ToStream(__tmp20.ToString())))
            {
                bool __tmp20_first = true;
                bool __tmp20_last = __tmp20Reader.EndOfStream;
                while(__tmp20_first || !__tmp20_last)
                {
                    __tmp20_first = false;
                    string __tmp20Line = __tmp20Reader.ReadLine();
                    __tmp20_last = __tmp20Reader.EndOfStream;
                    if (__tmp20Line != null) __out.Append(__tmp20Line);
                    if (!__tmp20_last) __out.AppendLine(true);
                }
            }
            StringBuilder __tmp21 = new StringBuilder();
            __tmp21.Append(bindingType);
            using(StreamReader __tmp21Reader = new StreamReader(this.__ToStream(__tmp21.ToString())))
            {
                bool __tmp21_first = true;
                bool __tmp21_last = __tmp21Reader.EndOfStream;
                while(__tmp21_first || !__tmp21_last)
                {
                    __tmp21_first = false;
                    string __tmp21Line = __tmp21Reader.ReadLine();
                    __tmp21_last = __tmp21Reader.EndOfStream;
                    if (__tmp21Line != null) __out.Append(__tmp21Line);
                    if (!__tmp21_last) __out.AppendLine(true);
                }
            }
            string __tmp22Line = "Impl implements "; //87:39
            if (__tmp22Line != null) __out.Append(__tmp22Line);
            StringBuilder __tmp23 = new StringBuilder();
            __tmp23.Append(iface.Name);
            using(StreamReader __tmp23Reader = new StreamReader(this.__ToStream(__tmp23.ToString())))
            {
                bool __tmp23_first = true;
                bool __tmp23_last = __tmp23Reader.EndOfStream;
                while(__tmp23_first || !__tmp23_last)
                {
                    __tmp23_first = false;
                    string __tmp23Line = __tmp23Reader.ReadLine();
                    __tmp23_last = __tmp23Reader.EndOfStream;
                    if (__tmp23Line != null) __out.Append(__tmp23Line);
                    if (!__tmp23_last) __out.AppendLine(true);
                }
            }
            StringBuilder __tmp24 = new StringBuilder();
            __tmp24.Append(bindingType);
            using(StreamReader __tmp24Reader = new StreamReader(this.__ToStream(__tmp24.ToString())))
            {
                bool __tmp24_first = true;
                bool __tmp24_last = __tmp24Reader.EndOfStream;
                while(__tmp24_first || !__tmp24_last)
                {
                    __tmp24_first = false;
                    string __tmp24Line = __tmp24Reader.ReadLine();
                    __tmp24_last = __tmp24Reader.EndOfStream;
                    if (__tmp24Line != null) __out.Append(__tmp24Line);
                    if (!__tmp24_last) __out.AppendLine(true);
                }
            }
            string __tmp25Line = " {"; //87:80
            if (__tmp25Line != null) __out.Append(__tmp25Line);
            __out.AppendLine(false); //87:82
            __out.AppendLine(true); //88:1
            __out.Append("	@Autowired"); //89:1
            __out.AppendLine(false); //89:12
            string __tmp27Line = "	private "; //90:1
            if (__tmp27Line != null) __out.Append(__tmp27Line);
            StringBuilder __tmp28 = new StringBuilder();
            __tmp28.Append(iface.Name);
            using(StreamReader __tmp28Reader = new StreamReader(this.__ToStream(__tmp28.ToString())))
            {
                bool __tmp28_first = true;
                bool __tmp28_last = __tmp28Reader.EndOfStream;
                while(__tmp28_first || !__tmp28_last)
                {
                    __tmp28_first = false;
                    string __tmp28Line = __tmp28Reader.ReadLine();
                    __tmp28_last = __tmp28Reader.EndOfStream;
                    if (__tmp28Line != null) __out.Append(__tmp28Line);
                    if (!__tmp28_last) __out.AppendLine(true);
                }
            }
            string __tmp29Line = "Impl "; //90:22
            if (__tmp29Line != null) __out.Append(__tmp29Line);
            StringBuilder __tmp30 = new StringBuilder();
            __tmp30.Append(iface.Name.ToCamelCase());
            using(StreamReader __tmp30Reader = new StreamReader(this.__ToStream(__tmp30.ToString())))
            {
                bool __tmp30_first = true;
                bool __tmp30_last = __tmp30Reader.EndOfStream;
                while(__tmp30_first || !__tmp30_last)
                {
                    __tmp30_first = false;
                    string __tmp30Line = __tmp30Reader.ReadLine();
                    __tmp30_last = __tmp30Reader.EndOfStream;
                    if (__tmp30Line != null) __out.Append(__tmp30Line);
                    if (!__tmp30_last) __out.AppendLine(true);
                }
            }
            string __tmp31Line = "Impl;"; //90:53
            if (__tmp31Line != null) __out.Append(__tmp31Line);
            __out.AppendLine(false); //90:58
            var __loop5_results = 
                (from __loop5_var1 in __Enumerate((iface).GetEnumerator()) //92:7
                from op in __Enumerate((__loop5_var1.Operations).GetEnumerator()) //92:14
                select new { __loop5_var1 = __loop5_var1, op = op}
                ).ToList(); //92:2
            int __loop5_iteration = 0;
            foreach (var __tmp32 in __loop5_results)
            {
                ++__loop5_iteration;
                var __loop5_var1 = __tmp32.__loop5_var1;
                var op = __tmp32.op;
                __out.AppendLine(true); //93:1
                string __tmp34Line = "	public "; //94:1
                if (__tmp34Line != null) __out.Append(__tmp34Line);
                StringBuilder __tmp35 = new StringBuilder();
                __tmp35.Append(op.Result.Type.GetJavaName());
                using(StreamReader __tmp35Reader = new StreamReader(this.__ToStream(__tmp35.ToString())))
                {
                    bool __tmp35_first = true;
                    bool __tmp35_last = __tmp35Reader.EndOfStream;
                    while(__tmp35_first || !__tmp35_last)
                    {
                        __tmp35_first = false;
                        string __tmp35Line = __tmp35Reader.ReadLine();
                        __tmp35_last = __tmp35Reader.EndOfStream;
                        if (__tmp35Line != null) __out.Append(__tmp35Line);
                        if (!__tmp35_last) __out.AppendLine(true);
                    }
                }
                string __tmp36Line = " "; //94:39
                if (__tmp36Line != null) __out.Append(__tmp36Line);
                StringBuilder __tmp37 = new StringBuilder();
                __tmp37.Append(op.Name.ToCamelCase());
                using(StreamReader __tmp37Reader = new StreamReader(this.__ToStream(__tmp37.ToString())))
                {
                    bool __tmp37_first = true;
                    bool __tmp37_last = __tmp37Reader.EndOfStream;
                    while(__tmp37_first || !__tmp37_last)
                    {
                        __tmp37_first = false;
                        string __tmp37Line = __tmp37Reader.ReadLine();
                        __tmp37_last = __tmp37Reader.EndOfStream;
                        if (__tmp37Line != null) __out.Append(__tmp37Line);
                        if (!__tmp37_last) __out.AppendLine(true);
                    }
                }
                string __tmp38Line = "("; //94:63
                if (__tmp38Line != null) __out.Append(__tmp38Line);
                StringBuilder __tmp39 = new StringBuilder();
                __tmp39.Append(SpringGeneratorUtil.GetParameterList(op));
                using(StreamReader __tmp39Reader = new StreamReader(this.__ToStream(__tmp39.ToString())))
                {
                    bool __tmp39_first = true;
                    bool __tmp39_last = __tmp39Reader.EndOfStream;
                    while(__tmp39_first || !__tmp39_last)
                    {
                        __tmp39_first = false;
                        string __tmp39Line = __tmp39Reader.ReadLine();
                        __tmp39_last = __tmp39Reader.EndOfStream;
                        if (__tmp39Line != null) __out.Append(__tmp39Line);
                        if (!__tmp39_last) __out.AppendLine(true);
                    }
                }
                string __tmp40Line = ")"; //94:106
                if (__tmp40Line != null) __out.Append(__tmp40Line);
                if (op.Exceptions.Any()) //95:3
                {
                    string __tmp42Line = " throws "; //96:1
                    if (__tmp42Line != null) __out.Append(__tmp42Line);
                    StringBuilder __tmp43 = new StringBuilder();
                    __tmp43.Append(SpringGeneratorUtil.GetExceptionList(op));
                    using(StreamReader __tmp43Reader = new StreamReader(this.__ToStream(__tmp43.ToString())))
                    {
                        bool __tmp43_first = true;
                        bool __tmp43_last = __tmp43Reader.EndOfStream;
                        while(__tmp43_first || !__tmp43_last)
                        {
                            __tmp43_first = false;
                            string __tmp43Line = __tmp43Reader.ReadLine();
                            __tmp43_last = __tmp43Reader.EndOfStream;
                            if (__tmp43Line != null) __out.Append(__tmp43Line);
                            if (!__tmp43_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp44Line = " "; //96:51
                    if (__tmp44Line != null) __out.Append(__tmp44Line);
                }
                __out.Append("{"); //98:1
                __out.AppendLine(false); //98:2
                if (op.Result.Type.GetJavaName() != "void") //99:5
                {
                    string __tmp46Line = "		return "; //100:1
                    if (__tmp46Line != null) __out.Append(__tmp46Line);
                    StringBuilder __tmp47 = new StringBuilder();
                    __tmp47.Append(iface.Name.ToCamelCase());
                    using(StreamReader __tmp47Reader = new StreamReader(this.__ToStream(__tmp47.ToString())))
                    {
                        bool __tmp47_first = true;
                        bool __tmp47_last = __tmp47Reader.EndOfStream;
                        while(__tmp47_first || !__tmp47_last)
                        {
                            __tmp47_first = false;
                            string __tmp47Line = __tmp47Reader.ReadLine();
                            __tmp47_last = __tmp47Reader.EndOfStream;
                            if (__tmp47Line != null) __out.Append(__tmp47Line);
                            if (!__tmp47_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp48Line = "Impl."; //100:36
                    if (__tmp48Line != null) __out.Append(__tmp48Line);
                    StringBuilder __tmp49 = new StringBuilder();
                    __tmp49.Append(op.Name.ToCamelCase());
                    using(StreamReader __tmp49Reader = new StreamReader(this.__ToStream(__tmp49.ToString())))
                    {
                        bool __tmp49_first = true;
                        bool __tmp49_last = __tmp49Reader.EndOfStream;
                        while(__tmp49_first || !__tmp49_last)
                        {
                            __tmp49_first = false;
                            string __tmp49Line = __tmp49Reader.ReadLine();
                            __tmp49_last = __tmp49Reader.EndOfStream;
                            if (__tmp49Line != null) __out.Append(__tmp49Line);
                            if (!__tmp49_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp50Line = "("; //100:64
                    if (__tmp50Line != null) __out.Append(__tmp50Line);
                    StringBuilder __tmp51 = new StringBuilder();
                    __tmp51.Append(SpringGeneratorUtil.GetParameterNameList(op));
                    using(StreamReader __tmp51Reader = new StreamReader(this.__ToStream(__tmp51.ToString())))
                    {
                        bool __tmp51_first = true;
                        bool __tmp51_last = __tmp51Reader.EndOfStream;
                        while(__tmp51_first || !__tmp51_last)
                        {
                            __tmp51_first = false;
                            string __tmp51Line = __tmp51Reader.ReadLine();
                            __tmp51_last = __tmp51Reader.EndOfStream;
                            if (__tmp51Line != null) __out.Append(__tmp51Line);
                            if (!__tmp51_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp52Line = ");"; //100:111
                    if (__tmp52Line != null) __out.Append(__tmp52Line);
                    __out.AppendLine(false); //100:113
                }
                else //101:5
                {
                    string __tmp53Prefix = "		"; //102:1
                    StringBuilder __tmp54 = new StringBuilder();
                    __tmp54.Append(iface.Name.ToCamelCase());
                    using(StreamReader __tmp54Reader = new StreamReader(this.__ToStream(__tmp54.ToString())))
                    {
                        bool __tmp54_first = true;
                        bool __tmp54_last = __tmp54Reader.EndOfStream;
                        while(__tmp54_first || !__tmp54_last)
                        {
                            __tmp54_first = false;
                            string __tmp54Line = __tmp54Reader.ReadLine();
                            __tmp54_last = __tmp54Reader.EndOfStream;
                            __out.Append(__tmp53Prefix);
                            if (__tmp54Line != null) __out.Append(__tmp54Line);
                            if (!__tmp54_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp55Line = "Impl."; //102:29
                    if (__tmp55Line != null) __out.Append(__tmp55Line);
                    StringBuilder __tmp56 = new StringBuilder();
                    __tmp56.Append(op.Name.ToCamelCase());
                    using(StreamReader __tmp56Reader = new StreamReader(this.__ToStream(__tmp56.ToString())))
                    {
                        bool __tmp56_first = true;
                        bool __tmp56_last = __tmp56Reader.EndOfStream;
                        while(__tmp56_first || !__tmp56_last)
                        {
                            __tmp56_first = false;
                            string __tmp56Line = __tmp56Reader.ReadLine();
                            __tmp56_last = __tmp56Reader.EndOfStream;
                            if (__tmp56Line != null) __out.Append(__tmp56Line);
                            if (!__tmp56_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp57Line = "("; //102:57
                    if (__tmp57Line != null) __out.Append(__tmp57Line);
                    StringBuilder __tmp58 = new StringBuilder();
                    __tmp58.Append(SpringGeneratorUtil.GetParameterNameList(op));
                    using(StreamReader __tmp58Reader = new StreamReader(this.__ToStream(__tmp58.ToString())))
                    {
                        bool __tmp58_first = true;
                        bool __tmp58_last = __tmp58Reader.EndOfStream;
                        while(__tmp58_first || !__tmp58_last)
                        {
                            __tmp58_first = false;
                            string __tmp58Line = __tmp58Reader.ReadLine();
                            __tmp58_last = __tmp58Reader.EndOfStream;
                            if (__tmp58Line != null) __out.Append(__tmp58Line);
                            if (!__tmp58_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp59Line = ");"; //102:104
                    if (__tmp59Line != null) __out.Append(__tmp59Line);
                    __out.AppendLine(false); //102:106
                }
                __out.Append("	}"); //104:1
                __out.AppendLine(false); //104:3
            }
            __out.Append("}"); //106:1
            __out.AppendLine(false); //106:2
            return __out.ToString();
        }

        public string GenerateProxyForInterface(Interface iface, string functionName, string bindingType) //111:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp2Line = "package "; //112:1
            if (__tmp2Line != null) __out.Append(__tmp2Line);
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(SpringGeneratorUtil.GetPackage(iface));
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
            string __tmp4Line = ".proxy;"; //112:48
            if (__tmp4Line != null) __out.Append(__tmp4Line);
            __out.AppendLine(false); //112:55
            __out.AppendLine(true); //113:1
            __out.Append("import static org.springframework.hateoas.mvc.ControllerLinkBuilder.linkTo;"); //114:1
            __out.AppendLine(false); //114:76
            __out.Append("import static org.springframework.hateoas.mvc.ControllerLinkBuilder.methodOn;"); //115:1
            __out.AppendLine(false); //115:78
            __out.AppendLine(true); //116:1
            __out.Append("import org.springframework.hateoas.Link;"); //117:1
            __out.AppendLine(false); //117:41
            __out.Append("import org.springframework.stereotype.Service;"); //118:1
            __out.AppendLine(false); //118:47
            __out.Append("import org.springframework.web.client.RestTemplate;"); //119:1
            __out.AppendLine(false); //119:52
            __out.Append("import org.springframework.web.context.request.RequestAttributes;"); //120:1
            __out.AppendLine(false); //120:66
            __out.Append("import org.springframework.web.context.request.RequestContextHolder;"); //121:1
            __out.AppendLine(false); //121:69
            __out.Append("import org.springframework.web.context.request.ServletRequestAttributes;"); //122:1
            __out.AppendLine(false); //122:73
            __out.AppendLine(true); //123:1
            __out.Append("import cinema.Configuration;"); //124:1
            __out.AppendLine(false); //124:29
            string __tmp6Line = "import "; //125:1
            if (__tmp6Line != null) __out.Append(__tmp6Line);
            StringBuilder __tmp7 = new StringBuilder();
            __tmp7.Append(SpringGeneratorUtil.GetPackage(iface));
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
            string __tmp8Line = "."; //125:47
            if (__tmp8Line != null) __out.Append(__tmp8Line);
            StringBuilder __tmp9 = new StringBuilder();
            __tmp9.Append(SpringGeneratorUtil.Properties.interfacePackage);
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
            string __tmp10Line = "."; //125:97
            if (__tmp10Line != null) __out.Append(__tmp10Line);
            StringBuilder __tmp11 = new StringBuilder();
            __tmp11.Append(iface.Name);
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
            StringBuilder __tmp12 = new StringBuilder();
            __tmp12.Append(bindingType);
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
            string __tmp13Line = ";"; //125:123
            if (__tmp13Line != null) __out.Append(__tmp13Line);
            __out.AppendLine(false); //125:124
            StringBuilder __tmp15 = new StringBuilder();
            __tmp15.Append(SpringGeneratorUtil.GenerateImports(iface, false));
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
                    __out.AppendLine(false); //126:52
                }
            }
            __out.AppendLine(true); //127:1
            __out.Append("import javax.servlet.http.HttpServletRequest;"); //128:1
            __out.AppendLine(false); //128:46
            __out.Append("import java.util.Arrays;"); //129:1
            __out.AppendLine(false); //129:25
            __out.Append("import java.util.List;"); //130:1
            __out.AppendLine(false); //130:23
            __out.Append("import java.util.stream.Collectors;"); //131:1
            __out.AppendLine(false); //131:36
            __out.AppendLine(true); //132:1
            __out.Append("@Service"); //133:1
            __out.AppendLine(false); //133:9
            string __tmp17Line = "public class "; //134:1
            if (__tmp17Line != null) __out.Append(__tmp17Line);
            StringBuilder __tmp18 = new StringBuilder();
            __tmp18.Append(iface.Name);
            using(StreamReader __tmp18Reader = new StreamReader(this.__ToStream(__tmp18.ToString())))
            {
                bool __tmp18_first = true;
                bool __tmp18_last = __tmp18Reader.EndOfStream;
                while(__tmp18_first || !__tmp18_last)
                {
                    __tmp18_first = false;
                    string __tmp18Line = __tmp18Reader.ReadLine();
                    __tmp18_last = __tmp18Reader.EndOfStream;
                    if (__tmp18Line != null) __out.Append(__tmp18Line);
                    if (!__tmp18_last) __out.AppendLine(true);
                }
            }
            StringBuilder __tmp19 = new StringBuilder();
            __tmp19.Append(bindingType);
            using(StreamReader __tmp19Reader = new StreamReader(this.__ToStream(__tmp19.ToString())))
            {
                bool __tmp19_first = true;
                bool __tmp19_last = __tmp19Reader.EndOfStream;
                while(__tmp19_first || !__tmp19_last)
                {
                    __tmp19_first = false;
                    string __tmp19Line = __tmp19Reader.ReadLine();
                    __tmp19_last = __tmp19Reader.EndOfStream;
                    if (__tmp19Line != null) __out.Append(__tmp19Line);
                    if (!__tmp19_last) __out.AppendLine(true);
                }
            }
            string __tmp20Line = "Proxy implements "; //134:39
            if (__tmp20Line != null) __out.Append(__tmp20Line);
            StringBuilder __tmp21 = new StringBuilder();
            __tmp21.Append(iface.Name);
            using(StreamReader __tmp21Reader = new StreamReader(this.__ToStream(__tmp21.ToString())))
            {
                bool __tmp21_first = true;
                bool __tmp21_last = __tmp21Reader.EndOfStream;
                while(__tmp21_first || !__tmp21_last)
                {
                    __tmp21_first = false;
                    string __tmp21Line = __tmp21Reader.ReadLine();
                    __tmp21_last = __tmp21Reader.EndOfStream;
                    if (__tmp21Line != null) __out.Append(__tmp21Line);
                    if (!__tmp21_last) __out.AppendLine(true);
                }
            }
            StringBuilder __tmp22 = new StringBuilder();
            __tmp22.Append(bindingType);
            using(StreamReader __tmp22Reader = new StreamReader(this.__ToStream(__tmp22.ToString())))
            {
                bool __tmp22_first = true;
                bool __tmp22_last = __tmp22Reader.EndOfStream;
                while(__tmp22_first || !__tmp22_last)
                {
                    __tmp22_first = false;
                    string __tmp22Line = __tmp22Reader.ReadLine();
                    __tmp22_last = __tmp22Reader.EndOfStream;
                    if (__tmp22Line != null) __out.Append(__tmp22Line);
                    if (!__tmp22_last) __out.AppendLine(true);
                }
            }
            string __tmp23Line = " {"; //134:81
            if (__tmp23Line != null) __out.Append(__tmp23Line);
            __out.AppendLine(false); //134:83
            __out.AppendLine(true); //135:1
            __out.Append("	private RestTemplate restTemplate = new RestTemplate();"); //136:1
            __out.AppendLine(false); //136:57
            string currentComponent = "CinemaWeb"; //137:3
            string targetComponent = "ReservationLogic"; //138:3
            string __tmp25Line = "	private String currentComponentName = \"Cinema-"; //139:1
            if (__tmp25Line != null) __out.Append(__tmp25Line);
            StringBuilder __tmp26 = new StringBuilder();
            __tmp26.Append(currentComponent);
            using(StreamReader __tmp26Reader = new StreamReader(this.__ToStream(__tmp26.ToString())))
            {
                bool __tmp26_first = true;
                bool __tmp26_last = __tmp26Reader.EndOfStream;
                while(__tmp26_first || !__tmp26_last)
                {
                    __tmp26_first = false;
                    string __tmp26Line = __tmp26Reader.ReadLine();
                    __tmp26_last = __tmp26Reader.EndOfStream;
                    if (__tmp26Line != null) __out.Append(__tmp26Line);
                    if (!__tmp26_last) __out.AppendLine(true);
                }
            }
            string __tmp27Line = "\";"; //139:66
            if (__tmp27Line != null) __out.Append(__tmp27Line);
            __out.AppendLine(false); //139:68
            string __tmp29Line = "    private String targetComponentName = \"Cinema-"; //140:1
            if (__tmp29Line != null) __out.Append(__tmp29Line);
            StringBuilder __tmp30 = new StringBuilder();
            __tmp30.Append(targetComponent);
            using(StreamReader __tmp30Reader = new StreamReader(this.__ToStream(__tmp30.ToString())))
            {
                bool __tmp30_first = true;
                bool __tmp30_last = __tmp30Reader.EndOfStream;
                while(__tmp30_first || !__tmp30_last)
                {
                    __tmp30_first = false;
                    string __tmp30Line = __tmp30Reader.ReadLine();
                    __tmp30_last = __tmp30Reader.EndOfStream;
                    if (__tmp30Line != null) __out.Append(__tmp30Line);
                    if (!__tmp30_last) __out.AppendLine(true);
                }
            }
            string __tmp31Line = "\";"; //140:67
            if (__tmp31Line != null) __out.Append(__tmp31Line);
            __out.AppendLine(false); //140:69
            var __loop6_results = 
                (from __loop6_var1 in __Enumerate((iface).GetEnumerator()) //142:7
                from op in __Enumerate((__loop6_var1.Operations).GetEnumerator()) //142:14
                select new { __loop6_var1 = __loop6_var1, op = op}
                ).ToList(); //142:2
            int __loop6_iteration = 0;
            foreach (var __tmp32 in __loop6_results)
            {
                ++__loop6_iteration;
                var __loop6_var1 = __tmp32.__loop6_var1;
                var op = __tmp32.op;
                __out.AppendLine(true); //143:2
                string __tmp34Line = "	private String urlOf"; //144:1
                if (__tmp34Line != null) __out.Append(__tmp34Line);
                StringBuilder __tmp35 = new StringBuilder();
                __tmp35.Append(op.Name.ToPascalCase());
                using(StreamReader __tmp35Reader = new StreamReader(this.__ToStream(__tmp35.ToString())))
                {
                    bool __tmp35_first = true;
                    bool __tmp35_last = __tmp35Reader.EndOfStream;
                    while(__tmp35_first || !__tmp35_last)
                    {
                        __tmp35_first = false;
                        string __tmp35Line = __tmp35Reader.ReadLine();
                        __tmp35_last = __tmp35Reader.EndOfStream;
                        if (__tmp35Line != null) __out.Append(__tmp35Line);
                        if (!__tmp35_last) __out.AppendLine(true);
                    }
                }
                string __tmp36Line = ";"; //144:46
                if (__tmp36Line != null) __out.Append(__tmp36Line);
                __out.AppendLine(false); //144:47
            }
            var __loop7_results = 
                (from __loop7_var1 in __Enumerate((iface).GetEnumerator()) //147:7
                from op in __Enumerate((__loop7_var1.Operations).GetEnumerator()) //147:14
                select new { __loop7_var1 = __loop7_var1, op = op}
                ).ToList(); //147:2
            int __loop7_iteration = 0;
            foreach (var __tmp37 in __loop7_results)
            {
                ++__loop7_iteration;
                var __loop7_var1 = __tmp37.__loop7_var1;
                var op = __tmp37.op;
                __out.AppendLine(true); //148:1
                __out.Append("	@Override"); //149:1
                __out.AppendLine(false); //149:11
                string __tmp39Line = "	public "; //150:1
                if (__tmp39Line != null) __out.Append(__tmp39Line);
                StringBuilder __tmp40 = new StringBuilder();
                __tmp40.Append(op.Result.Type.GetJavaName());
                using(StreamReader __tmp40Reader = new StreamReader(this.__ToStream(__tmp40.ToString())))
                {
                    bool __tmp40_first = true;
                    bool __tmp40_last = __tmp40Reader.EndOfStream;
                    while(__tmp40_first || !__tmp40_last)
                    {
                        __tmp40_first = false;
                        string __tmp40Line = __tmp40Reader.ReadLine();
                        __tmp40_last = __tmp40Reader.EndOfStream;
                        if (__tmp40Line != null) __out.Append(__tmp40Line);
                        if (!__tmp40_last) __out.AppendLine(true);
                    }
                }
                string __tmp41Line = " "; //150:39
                if (__tmp41Line != null) __out.Append(__tmp41Line);
                StringBuilder __tmp42 = new StringBuilder();
                __tmp42.Append(op.Name.ToCamelCase());
                using(StreamReader __tmp42Reader = new StreamReader(this.__ToStream(__tmp42.ToString())))
                {
                    bool __tmp42_first = true;
                    bool __tmp42_last = __tmp42Reader.EndOfStream;
                    while(__tmp42_first || !__tmp42_last)
                    {
                        __tmp42_first = false;
                        string __tmp42Line = __tmp42Reader.ReadLine();
                        __tmp42_last = __tmp42Reader.EndOfStream;
                        if (__tmp42Line != null) __out.Append(__tmp42Line);
                        if (!__tmp42_last) __out.AppendLine(true);
                    }
                }
                string __tmp43Line = "("; //150:63
                if (__tmp43Line != null) __out.Append(__tmp43Line);
                StringBuilder __tmp44 = new StringBuilder();
                __tmp44.Append(SpringGeneratorUtil.GetParameterList(op));
                using(StreamReader __tmp44Reader = new StreamReader(this.__ToStream(__tmp44.ToString())))
                {
                    bool __tmp44_first = true;
                    bool __tmp44_last = __tmp44Reader.EndOfStream;
                    while(__tmp44_first || !__tmp44_last)
                    {
                        __tmp44_first = false;
                        string __tmp44Line = __tmp44Reader.ReadLine();
                        __tmp44_last = __tmp44Reader.EndOfStream;
                        if (__tmp44Line != null) __out.Append(__tmp44Line);
                        if (!__tmp44_last) __out.AppendLine(true);
                    }
                }
                string __tmp45Line = ")"; //150:106
                if (__tmp45Line != null) __out.Append(__tmp45Line);
                if (op.Exceptions.Any()) //151:3
                {
                    string __tmp47Line = " throws "; //152:1
                    if (__tmp47Line != null) __out.Append(__tmp47Line);
                    StringBuilder __tmp48 = new StringBuilder();
                    __tmp48.Append(SpringGeneratorUtil.GetExceptionList(op));
                    using(StreamReader __tmp48Reader = new StreamReader(this.__ToStream(__tmp48.ToString())))
                    {
                        bool __tmp48_first = true;
                        bool __tmp48_last = __tmp48Reader.EndOfStream;
                        while(__tmp48_first || !__tmp48_last)
                        {
                            __tmp48_first = false;
                            string __tmp48Line = __tmp48Reader.ReadLine();
                            __tmp48_last = __tmp48Reader.EndOfStream;
                            if (__tmp48Line != null) __out.Append(__tmp48Line);
                            if (!__tmp48_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp49Line = " "; //152:51
                    if (__tmp49Line != null) __out.Append(__tmp49Line);
                }
                __out.Append("{"); //154:1
                __out.AppendLine(false); //154:2
                string __tmp51Line = "		String url = getUrlOf"; //155:1
                if (__tmp51Line != null) __out.Append(__tmp51Line);
                StringBuilder __tmp52 = new StringBuilder();
                __tmp52.Append(op.Name.ToPascalCase());
                using(StreamReader __tmp52Reader = new StreamReader(this.__ToStream(__tmp52.ToString())))
                {
                    bool __tmp52_first = true;
                    bool __tmp52_last = __tmp52Reader.EndOfStream;
                    while(__tmp52_first || !__tmp52_last)
                    {
                        __tmp52_first = false;
                        string __tmp52Line = __tmp52Reader.ReadLine();
                        __tmp52_last = __tmp52Reader.EndOfStream;
                        if (__tmp52Line != null) __out.Append(__tmp52Line);
                        if (!__tmp52_last) __out.AppendLine(true);
                    }
                }
                string __tmp53Line = "();"; //155:48
                if (__tmp53Line != null) __out.Append(__tmp53Line);
                __out.AppendLine(false); //155:51
                ArrayType array = op.Result.Type as ArrayType; //156:3
                if (array != null) //157:3
                {
                    string __tmp54Prefix = "		"; //158:1
                    StringBuilder __tmp55 = new StringBuilder();
                    __tmp55.Append(array.InnerType.GetJavaName());
                    using(StreamReader __tmp55Reader = new StreamReader(this.__ToStream(__tmp55.ToString())))
                    {
                        bool __tmp55_first = true;
                        bool __tmp55_last = __tmp55Reader.EndOfStream;
                        while(__tmp55_first || !__tmp55_last)
                        {
                            __tmp55_first = false;
                            string __tmp55Line = __tmp55Reader.ReadLine();
                            __tmp55_last = __tmp55Reader.EndOfStream;
                            __out.Append(__tmp54Prefix);
                            if (__tmp55Line != null) __out.Append(__tmp55Line);
                            if (!__tmp55_last) __out.AppendLine(true);
                        }
                    }
                    StringBuilder __tmp56 = new StringBuilder();
                    __tmp56.Append("[]");
                    using(StreamReader __tmp56Reader = new StreamReader(this.__ToStream(__tmp56.ToString())))
                    {
                        bool __tmp56_first = true;
                        bool __tmp56_last = __tmp56Reader.EndOfStream;
                        while(__tmp56_first || !__tmp56_last)
                        {
                            __tmp56_first = false;
                            string __tmp56Line = __tmp56Reader.ReadLine();
                            __tmp56_last = __tmp56Reader.EndOfStream;
                            if (__tmp56Line != null) __out.Append(__tmp56Line);
                            if (!__tmp56_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp57Line = " response = restTemplate.getForObject(url, "; //158:40
                    if (__tmp57Line != null) __out.Append(__tmp57Line);
                    StringBuilder __tmp58 = new StringBuilder();
                    __tmp58.Append(array.InnerType.GetJavaName());
                    using(StreamReader __tmp58Reader = new StreamReader(this.__ToStream(__tmp58.ToString())))
                    {
                        bool __tmp58_first = true;
                        bool __tmp58_last = __tmp58Reader.EndOfStream;
                        while(__tmp58_first || !__tmp58_last)
                        {
                            __tmp58_first = false;
                            string __tmp58Line = __tmp58Reader.ReadLine();
                            __tmp58_last = __tmp58Reader.EndOfStream;
                            if (__tmp58Line != null) __out.Append(__tmp58Line);
                            if (!__tmp58_last) __out.AppendLine(true);
                        }
                    }
                    StringBuilder __tmp59 = new StringBuilder();
                    __tmp59.Append("[]");
                    using(StreamReader __tmp59Reader = new StreamReader(this.__ToStream(__tmp59.ToString())))
                    {
                        bool __tmp59_first = true;
                        bool __tmp59_last = __tmp59Reader.EndOfStream;
                        while(__tmp59_first || !__tmp59_last)
                        {
                            __tmp59_first = false;
                            string __tmp59Line = __tmp59Reader.ReadLine();
                            __tmp59_last = __tmp59Reader.EndOfStream;
                            if (__tmp59Line != null) __out.Append(__tmp59Line);
                            if (!__tmp59_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp60Line = ".class);"; //158:120
                    if (__tmp60Line != null) __out.Append(__tmp60Line);
                    __out.AppendLine(false); //158:128
                }
                else //159:3
                {
                    string __tmp61Prefix = "		"; //160:1
                    StringBuilder __tmp62 = new StringBuilder();
                    __tmp62.Append(op.Result.Type.GetJavaName());
                    using(StreamReader __tmp62Reader = new StreamReader(this.__ToStream(__tmp62.ToString())))
                    {
                        bool __tmp62_first = true;
                        bool __tmp62_last = __tmp62Reader.EndOfStream;
                        while(__tmp62_first || !__tmp62_last)
                        {
                            __tmp62_first = false;
                            string __tmp62Line = __tmp62Reader.ReadLine();
                            __tmp62_last = __tmp62Reader.EndOfStream;
                            __out.Append(__tmp61Prefix);
                            if (__tmp62Line != null) __out.Append(__tmp62Line);
                            if (!__tmp62_last) __out.AppendLine(true);
                        }
                    }
                    StringBuilder __tmp63 = new StringBuilder();
                    __tmp63.Append("[]");
                    using(StreamReader __tmp63Reader = new StreamReader(this.__ToStream(__tmp63.ToString())))
                    {
                        bool __tmp63_first = true;
                        bool __tmp63_last = __tmp63Reader.EndOfStream;
                        while(__tmp63_first || !__tmp63_last)
                        {
                            __tmp63_first = false;
                            string __tmp63Line = __tmp63Reader.ReadLine();
                            __tmp63_last = __tmp63Reader.EndOfStream;
                            if (__tmp63Line != null) __out.Append(__tmp63Line);
                            if (!__tmp63_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp64Line = " response = restTemplate.getForObject(url, "; //160:39
                    if (__tmp64Line != null) __out.Append(__tmp64Line);
                    StringBuilder __tmp65 = new StringBuilder();
                    __tmp65.Append(op.Result.Type.GetJavaName());
                    using(StreamReader __tmp65Reader = new StreamReader(this.__ToStream(__tmp65.ToString())))
                    {
                        bool __tmp65_first = true;
                        bool __tmp65_last = __tmp65Reader.EndOfStream;
                        while(__tmp65_first || !__tmp65_last)
                        {
                            __tmp65_first = false;
                            string __tmp65Line = __tmp65Reader.ReadLine();
                            __tmp65_last = __tmp65Reader.EndOfStream;
                            if (__tmp65Line != null) __out.Append(__tmp65Line);
                            if (!__tmp65_last) __out.AppendLine(true);
                        }
                    }
                    StringBuilder __tmp66 = new StringBuilder();
                    __tmp66.Append("[]");
                    using(StreamReader __tmp66Reader = new StreamReader(this.__ToStream(__tmp66.ToString())))
                    {
                        bool __tmp66_first = true;
                        bool __tmp66_last = __tmp66Reader.EndOfStream;
                        while(__tmp66_first || !__tmp66_last)
                        {
                            __tmp66_first = false;
                            string __tmp66Line = __tmp66Reader.ReadLine();
                            __tmp66_last = __tmp66Reader.EndOfStream;
                            if (__tmp66Line != null) __out.Append(__tmp66Line);
                            if (!__tmp66_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp67Line = ".class);"; //160:118
                    if (__tmp67Line != null) __out.Append(__tmp67Line);
                    __out.AppendLine(false); //160:126
                }
                if (op.Result.Type.GetJavaName() != "void") //163:3
                {
                    __out.Append("		return Arrays.stream(response).collect(Collectors.toList());"); //164:1
                    __out.AppendLine(false); //164:63
                }
                else //165:3
                {
                    __out.Append("			//FIXME"); //166:1
                    __out.AppendLine(false); //166:11
                    string __tmp69Line = "		//"; //167:1
                    if (__tmp69Line != null) __out.Append(__tmp69Line);
                    StringBuilder __tmp70 = new StringBuilder();
                    __tmp70.Append(iface.Name.ToCamelCase());
                    using(StreamReader __tmp70Reader = new StreamReader(this.__ToStream(__tmp70.ToString())))
                    {
                        bool __tmp70_first = true;
                        bool __tmp70_last = __tmp70Reader.EndOfStream;
                        while(__tmp70_first || !__tmp70_last)
                        {
                            __tmp70_first = false;
                            string __tmp70Line = __tmp70Reader.ReadLine();
                            __tmp70_last = __tmp70Reader.EndOfStream;
                            if (__tmp70Line != null) __out.Append(__tmp70Line);
                            if (!__tmp70_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp71Line = "Impl."; //167:31
                    if (__tmp71Line != null) __out.Append(__tmp71Line);
                    StringBuilder __tmp72 = new StringBuilder();
                    __tmp72.Append(op.Name.ToCamelCase());
                    using(StreamReader __tmp72Reader = new StreamReader(this.__ToStream(__tmp72.ToString())))
                    {
                        bool __tmp72_first = true;
                        bool __tmp72_last = __tmp72Reader.EndOfStream;
                        while(__tmp72_first || !__tmp72_last)
                        {
                            __tmp72_first = false;
                            string __tmp72Line = __tmp72Reader.ReadLine();
                            __tmp72_last = __tmp72Reader.EndOfStream;
                            if (__tmp72Line != null) __out.Append(__tmp72Line);
                            if (!__tmp72_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp73Line = "("; //167:59
                    if (__tmp73Line != null) __out.Append(__tmp73Line);
                    StringBuilder __tmp74 = new StringBuilder();
                    __tmp74.Append(SpringGeneratorUtil.GetParameterNameList(op));
                    using(StreamReader __tmp74Reader = new StreamReader(this.__ToStream(__tmp74.ToString())))
                    {
                        bool __tmp74_first = true;
                        bool __tmp74_last = __tmp74Reader.EndOfStream;
                        while(__tmp74_first || !__tmp74_last)
                        {
                            __tmp74_first = false;
                            string __tmp74Line = __tmp74Reader.ReadLine();
                            __tmp74_last = __tmp74Reader.EndOfStream;
                            if (__tmp74Line != null) __out.Append(__tmp74Line);
                            if (!__tmp74_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp75Line = ");"; //167:106
                    if (__tmp75Line != null) __out.Append(__tmp75Line);
                    __out.AppendLine(false); //167:108
                }
                __out.Append("	}"); //169:1
                __out.AppendLine(false); //169:3
            }
            var __loop8_results = 
                (from __loop8_var1 in __Enumerate((iface).GetEnumerator()) //172:7
                from op in __Enumerate((__loop8_var1.Operations).GetEnumerator()) //172:14
                select new { __loop8_var1 = __loop8_var1, op = op}
                ).ToList(); //172:2
            int __loop8_iteration = 0;
            foreach (var __tmp76 in __loop8_results)
            {
                ++__loop8_iteration;
                var __loop8_var1 = __tmp76.__loop8_var1;
                var op = __tmp76.op;
                __out.AppendLine(true); //173:2
                string __tmp78Line = "	private String getUrlOf"; //174:1
                if (__tmp78Line != null) __out.Append(__tmp78Line);
                StringBuilder __tmp79 = new StringBuilder();
                __tmp79.Append(op.Name.ToPascalCase());
                using(StreamReader __tmp79Reader = new StreamReader(this.__ToStream(__tmp79.ToString())))
                {
                    bool __tmp79_first = true;
                    bool __tmp79_last = __tmp79Reader.EndOfStream;
                    while(__tmp79_first || !__tmp79_last)
                    {
                        __tmp79_first = false;
                        string __tmp79Line = __tmp79Reader.ReadLine();
                        __tmp79_last = __tmp79Reader.EndOfStream;
                        if (__tmp79Line != null) __out.Append(__tmp79Line);
                        if (!__tmp79_last) __out.AppendLine(true);
                    }
                }
                string __tmp80Line = "() {"; //174:49
                if (__tmp80Line != null) __out.Append(__tmp80Line);
                __out.AppendLine(false); //174:53
                string __tmp82Line = "        if (this.urlOf"; //175:1
                if (__tmp82Line != null) __out.Append(__tmp82Line);
                StringBuilder __tmp83 = new StringBuilder();
                __tmp83.Append(op.Name.ToPascalCase());
                using(StreamReader __tmp83Reader = new StreamReader(this.__ToStream(__tmp83.ToString())))
                {
                    bool __tmp83_first = true;
                    bool __tmp83_last = __tmp83Reader.EndOfStream;
                    while(__tmp83_first || !__tmp83_last)
                    {
                        __tmp83_first = false;
                        string __tmp83Line = __tmp83Reader.ReadLine();
                        __tmp83_last = __tmp83Reader.EndOfStream;
                        if (__tmp83Line != null) __out.Append(__tmp83Line);
                        if (!__tmp83_last) __out.AppendLine(true);
                    }
                }
                string __tmp84Line = " != null) {"; //175:47
                if (__tmp84Line != null) __out.Append(__tmp84Line);
                __out.AppendLine(false); //175:58
                string __tmp86Line = "            return this.urlOf"; //176:1
                if (__tmp86Line != null) __out.Append(__tmp86Line);
                StringBuilder __tmp87 = new StringBuilder();
                __tmp87.Append(op.Name.ToPascalCase());
                using(StreamReader __tmp87Reader = new StreamReader(this.__ToStream(__tmp87.ToString())))
                {
                    bool __tmp87_first = true;
                    bool __tmp87_last = __tmp87Reader.EndOfStream;
                    while(__tmp87_first || !__tmp87_last)
                    {
                        __tmp87_first = false;
                        string __tmp87Line = __tmp87Reader.ReadLine();
                        __tmp87_last = __tmp87Reader.EndOfStream;
                        if (__tmp87Line != null) __out.Append(__tmp87Line);
                        if (!__tmp87_last) __out.AppendLine(true);
                    }
                }
                string __tmp88Line = ";"; //176:54
                if (__tmp88Line != null) __out.Append(__tmp88Line);
                __out.AppendLine(false); //176:55
                __out.Append("        }"); //177:1
                __out.AppendLine(false); //177:10
                __out.AppendLine(true); //178:3
                __out.Append("        // eg.: http://127.0.0.2:8080/Cinema-CinemaWeb-1.0/getMoviesFromReservation/"); //179:1
                __out.AppendLine(false); //179:85
                __out.Append("        Link link = linkTo(methodOn(IReservationLogicRest.class).getMoviesFromReservation()).withSelfRel();"); //180:1
                __out.AppendLine(false); //180:108
                __out.Append("        RequestAttributes requestAttributes = RequestContextHolder.currentRequestAttributes();"); //181:1
                __out.AppendLine(false); //181:95
                __out.Append("        HttpServletRequest curRequest = ((ServletRequestAttributes) requestAttributes).getRequest();"); //182:1
                __out.AppendLine(false); //182:101
                __out.Append("        String serverName = curRequest.getServerName();"); //183:1
                __out.AppendLine(false); //183:56
                __out.Append("        String serverPort = String.valueOf(curRequest.getServerPort());"); //184:1
                __out.AppendLine(false); //184:72
                __out.AppendLine(true); //185:3
                __out.Append("        // eg.: http://127.0.0.2:8080/Cinema-ReservationLogic-1.0/getMoviesFromReservation/"); //186:1
                __out.AppendLine(false); //186:92
                __out.Append("        String url = link.getHref();"); //187:1
                __out.AppendLine(false); //187:37
                string __tmp90Line = "        url = url.replace(serverName, Configuration.getString(\""; //188:1
                if (__tmp90Line != null) __out.Append(__tmp90Line);
                StringBuilder __tmp91 = new StringBuilder();
                __tmp91.Append(targetComponent);
                using(StreamReader __tmp91Reader = new StreamReader(this.__ToStream(__tmp91.ToString())))
                {
                    bool __tmp91_first = true;
                    bool __tmp91_last = __tmp91Reader.EndOfStream;
                    while(__tmp91_first || !__tmp91_last)
                    {
                        __tmp91_first = false;
                        string __tmp91Line = __tmp91Reader.ReadLine();
                        __tmp91_last = __tmp91Reader.EndOfStream;
                        if (__tmp91Line != null) __out.Append(__tmp91Line);
                        if (!__tmp91_last) __out.AppendLine(true);
                    }
                }
                StringBuilder __tmp92 = new StringBuilder();
                __tmp92.Append(bindingType);
                using(StreamReader __tmp92Reader = new StreamReader(this.__ToStream(__tmp92.ToString())))
                {
                    bool __tmp92_first = true;
                    bool __tmp92_last = __tmp92Reader.EndOfStream;
                    while(__tmp92_first || !__tmp92_last)
                    {
                        __tmp92_first = false;
                        string __tmp92Line = __tmp92Reader.ReadLine();
                        __tmp92_last = __tmp92Reader.EndOfStream;
                        if (__tmp92Line != null) __out.Append(__tmp92Line);
                        if (!__tmp92_last) __out.AppendLine(true);
                    }
                }
                string __tmp93Line = "Server\"));"; //188:94
                if (__tmp93Line != null) __out.Append(__tmp93Line);
                __out.AppendLine(false); //188:104
                string __tmp95Line = "        url = url.replace(\":\" + serverPort, \":\" + Configuration.getString(\""; //189:1
                if (__tmp95Line != null) __out.Append(__tmp95Line);
                StringBuilder __tmp96 = new StringBuilder();
                __tmp96.Append(targetComponent);
                using(StreamReader __tmp96Reader = new StreamReader(this.__ToStream(__tmp96.ToString())))
                {
                    bool __tmp96_first = true;
                    bool __tmp96_last = __tmp96Reader.EndOfStream;
                    while(__tmp96_first || !__tmp96_last)
                    {
                        __tmp96_first = false;
                        string __tmp96Line = __tmp96Reader.ReadLine();
                        __tmp96_last = __tmp96Reader.EndOfStream;
                        if (__tmp96Line != null) __out.Append(__tmp96Line);
                        if (!__tmp96_last) __out.AppendLine(true);
                    }
                }
                StringBuilder __tmp97 = new StringBuilder();
                __tmp97.Append(bindingType);
                using(StreamReader __tmp97Reader = new StreamReader(this.__ToStream(__tmp97.ToString())))
                {
                    bool __tmp97_first = true;
                    bool __tmp97_last = __tmp97Reader.EndOfStream;
                    while(__tmp97_first || !__tmp97_last)
                    {
                        __tmp97_first = false;
                        string __tmp97Line = __tmp97Reader.ReadLine();
                        __tmp97_last = __tmp97Reader.EndOfStream;
                        if (__tmp97Line != null) __out.Append(__tmp97Line);
                        if (!__tmp97_last) __out.AppendLine(true);
                    }
                }
                string __tmp98Line = "Port\"));"; //189:106
                if (__tmp98Line != null) __out.Append(__tmp98Line);
                __out.AppendLine(false); //189:114
                __out.Append("        url = url.replace(currentComponentName, targetComponentName);"); //190:1
                __out.AppendLine(false); //190:70
                __out.AppendLine(true); //191:3
                string __tmp100Line = "        this.urlOf"; //192:1
                if (__tmp100Line != null) __out.Append(__tmp100Line);
                StringBuilder __tmp101 = new StringBuilder();
                __tmp101.Append(op.Name.ToPascalCase());
                using(StreamReader __tmp101Reader = new StreamReader(this.__ToStream(__tmp101.ToString())))
                {
                    bool __tmp101_first = true;
                    bool __tmp101_last = __tmp101Reader.EndOfStream;
                    while(__tmp101_first || !__tmp101_last)
                    {
                        __tmp101_first = false;
                        string __tmp101Line = __tmp101Reader.ReadLine();
                        __tmp101_last = __tmp101Reader.EndOfStream;
                        if (__tmp101Line != null) __out.Append(__tmp101Line);
                        if (!__tmp101_last) __out.AppendLine(true);
                    }
                }
                string __tmp102Line = " = url;"; //192:43
                if (__tmp102Line != null) __out.Append(__tmp102Line);
                __out.AppendLine(false); //192:50
                __out.Append("        return url;"); //193:1
                __out.AppendLine(false); //193:20
                __out.Append("    }"); //194:1
                __out.AppendLine(false); //194:6
            }
            __out.Append("}"); //196:1
            __out.AppendLine(false); //196:2
            return __out.ToString();
        }

        public string GenerateCrudRepositoryCopy(string namespaceName, string entityName, string bindingType) //201:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp2Line = "package "; //202:1
            if (__tmp2Line != null) __out.Append(__tmp2Line);
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(namespaceName.ToLower());
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
            string __tmp4Line = "."; //202:34
            if (__tmp4Line != null) __out.Append(__tmp4Line);
            StringBuilder __tmp5 = new StringBuilder();
            __tmp5.Append(SpringGeneratorUtil.Properties.interfacePackage);
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
            string __tmp6Line = ";"; //202:84
            if (__tmp6Line != null) __out.Append(__tmp6Line);
            __out.AppendLine(false); //202:85
            __out.AppendLine(true); //203:1
            string __tmp8Line = "import "; //204:1
            if (__tmp8Line != null) __out.Append(__tmp8Line);
            StringBuilder __tmp9 = new StringBuilder();
            __tmp9.Append(namespaceName.ToLower());
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
            string __tmp10Line = "."; //204:33
            if (__tmp10Line != null) __out.Append(__tmp10Line);
            StringBuilder __tmp11 = new StringBuilder();
            __tmp11.Append(SpringGeneratorUtil.Properties.entityPackage);
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
            string __tmp12Line = "."; //204:80
            if (__tmp12Line != null) __out.Append(__tmp12Line);
            StringBuilder __tmp13 = new StringBuilder();
            __tmp13.Append(entityName);
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
            string __tmp14Line = ";"; //204:93
            if (__tmp14Line != null) __out.Append(__tmp14Line);
            __out.AppendLine(false); //204:94
            __out.AppendLine(true); //205:1
            string __tmp16Line = "public interface "; //206:1
            if (__tmp16Line != null) __out.Append(__tmp16Line);
            StringBuilder __tmp17 = new StringBuilder();
            __tmp17.Append(entityName);
            using(StreamReader __tmp17Reader = new StreamReader(this.__ToStream(__tmp17.ToString())))
            {
                bool __tmp17_first = true;
                bool __tmp17_last = __tmp17Reader.EndOfStream;
                while(__tmp17_first || !__tmp17_last)
                {
                    __tmp17_first = false;
                    string __tmp17Line = __tmp17Reader.ReadLine();
                    __tmp17_last = __tmp17Reader.EndOfStream;
                    if (__tmp17Line != null) __out.Append(__tmp17Line);
                    if (!__tmp17_last) __out.AppendLine(true);
                }
            }
            string __tmp18Line = "Repository"; //206:30
            if (__tmp18Line != null) __out.Append(__tmp18Line);
            StringBuilder __tmp19 = new StringBuilder();
            __tmp19.Append(bindingType);
            using(StreamReader __tmp19Reader = new StreamReader(this.__ToStream(__tmp19.ToString())))
            {
                bool __tmp19_first = true;
                bool __tmp19_last = __tmp19Reader.EndOfStream;
                while(__tmp19_first || !__tmp19_last)
                {
                    __tmp19_first = false;
                    string __tmp19Line = __tmp19Reader.ReadLine();
                    __tmp19_last = __tmp19Reader.EndOfStream;
                    if (__tmp19Line != null) __out.Append(__tmp19Line);
                    if (!__tmp19_last) __out.AppendLine(true);
                }
            }
            string __tmp20Line = " {"; //206:53
            if (__tmp20Line != null) __out.Append(__tmp20Line);
            __out.AppendLine(false); //206:55
            string __tmp22Line = "	// should copy CrudRepository<"; //207:1
            if (__tmp22Line != null) __out.Append(__tmp22Line);
            StringBuilder __tmp23 = new StringBuilder();
            __tmp23.Append(entityName);
            using(StreamReader __tmp23Reader = new StreamReader(this.__ToStream(__tmp23.ToString())))
            {
                bool __tmp23_first = true;
                bool __tmp23_last = __tmp23Reader.EndOfStream;
                while(__tmp23_first || !__tmp23_last)
                {
                    __tmp23_first = false;
                    string __tmp23Line = __tmp23Reader.ReadLine();
                    __tmp23_last = __tmp23Reader.EndOfStream;
                    if (__tmp23Line != null) __out.Append(__tmp23Line);
                    if (!__tmp23_last) __out.AppendLine(true);
                }
            }
            string __tmp24Line = ", Long>"; //207:44
            if (__tmp24Line != null) __out.Append(__tmp24Line);
            __out.AppendLine(false); //207:51
            __out.AppendLine(true); //208:1
            __out.Append("	public long count();"); //209:1
            __out.AppendLine(false); //209:22
            __out.AppendLine(true); //210:1
            __out.Append("	public void delete(Long id);"); //211:1
            __out.AppendLine(false); //211:30
            __out.AppendLine(true); //212:1
            string __tmp26Line = "	public void delete("; //213:1
            if (__tmp26Line != null) __out.Append(__tmp26Line);
            StringBuilder __tmp27 = new StringBuilder();
            __tmp27.Append(entityName);
            using(StreamReader __tmp27Reader = new StreamReader(this.__ToStream(__tmp27.ToString())))
            {
                bool __tmp27_first = true;
                bool __tmp27_last = __tmp27Reader.EndOfStream;
                while(__tmp27_first || !__tmp27_last)
                {
                    __tmp27_first = false;
                    string __tmp27Line = __tmp27Reader.ReadLine();
                    __tmp27_last = __tmp27Reader.EndOfStream;
                    if (__tmp27Line != null) __out.Append(__tmp27Line);
                    if (!__tmp27_last) __out.AppendLine(true);
                }
            }
            string __tmp28Line = " entity);"; //213:33
            if (__tmp28Line != null) __out.Append(__tmp28Line);
            __out.AppendLine(false); //213:42
            __out.AppendLine(true); //214:1
            string __tmp30Line = "	public void delete(Iterable<? extends "; //215:1
            if (__tmp30Line != null) __out.Append(__tmp30Line);
            StringBuilder __tmp31 = new StringBuilder();
            __tmp31.Append(entityName);
            using(StreamReader __tmp31Reader = new StreamReader(this.__ToStream(__tmp31.ToString())))
            {
                bool __tmp31_first = true;
                bool __tmp31_last = __tmp31Reader.EndOfStream;
                while(__tmp31_first || !__tmp31_last)
                {
                    __tmp31_first = false;
                    string __tmp31Line = __tmp31Reader.ReadLine();
                    __tmp31_last = __tmp31Reader.EndOfStream;
                    if (__tmp31Line != null) __out.Append(__tmp31Line);
                    if (!__tmp31_last) __out.AppendLine(true);
                }
            }
            string __tmp32Line = "> entities);"; //215:52
            if (__tmp32Line != null) __out.Append(__tmp32Line);
            __out.AppendLine(false); //215:64
            __out.AppendLine(true); //216:1
            __out.Append("	public void deleteAll();"); //217:1
            __out.AppendLine(false); //217:26
            __out.AppendLine(true); //218:1
            __out.Append("	public boolean exists(Long id) ;"); //219:1
            __out.AppendLine(false); //219:34
            __out.AppendLine(true); //220:1
            string __tmp34Line = "	public Iterable<"; //221:1
            if (__tmp34Line != null) __out.Append(__tmp34Line);
            StringBuilder __tmp35 = new StringBuilder();
            __tmp35.Append(entityName);
            using(StreamReader __tmp35Reader = new StreamReader(this.__ToStream(__tmp35.ToString())))
            {
                bool __tmp35_first = true;
                bool __tmp35_last = __tmp35Reader.EndOfStream;
                while(__tmp35_first || !__tmp35_last)
                {
                    __tmp35_first = false;
                    string __tmp35Line = __tmp35Reader.ReadLine();
                    __tmp35_last = __tmp35Reader.EndOfStream;
                    if (__tmp35Line != null) __out.Append(__tmp35Line);
                    if (!__tmp35_last) __out.AppendLine(true);
                }
            }
            string __tmp36Line = "> findAll();"; //221:30
            if (__tmp36Line != null) __out.Append(__tmp36Line);
            __out.AppendLine(false); //221:42
            __out.AppendLine(true); //222:1
            string __tmp38Line = "	public Iterable<"; //223:1
            if (__tmp38Line != null) __out.Append(__tmp38Line);
            StringBuilder __tmp39 = new StringBuilder();
            __tmp39.Append(entityName);
            using(StreamReader __tmp39Reader = new StreamReader(this.__ToStream(__tmp39.ToString())))
            {
                bool __tmp39_first = true;
                bool __tmp39_last = __tmp39Reader.EndOfStream;
                while(__tmp39_first || !__tmp39_last)
                {
                    __tmp39_first = false;
                    string __tmp39Line = __tmp39Reader.ReadLine();
                    __tmp39_last = __tmp39Reader.EndOfStream;
                    if (__tmp39Line != null) __out.Append(__tmp39Line);
                    if (!__tmp39_last) __out.AppendLine(true);
                }
            }
            string __tmp40Line = "> findAll(Iterable<Long> entities);"; //223:30
            if (__tmp40Line != null) __out.Append(__tmp40Line);
            __out.AppendLine(false); //223:65
            __out.AppendLine(true); //224:1
            string __tmp42Line = "	public "; //225:1
            if (__tmp42Line != null) __out.Append(__tmp42Line);
            StringBuilder __tmp43 = new StringBuilder();
            __tmp43.Append(entityName);
            using(StreamReader __tmp43Reader = new StreamReader(this.__ToStream(__tmp43.ToString())))
            {
                bool __tmp43_first = true;
                bool __tmp43_last = __tmp43Reader.EndOfStream;
                while(__tmp43_first || !__tmp43_last)
                {
                    __tmp43_first = false;
                    string __tmp43Line = __tmp43Reader.ReadLine();
                    __tmp43_last = __tmp43Reader.EndOfStream;
                    if (__tmp43Line != null) __out.Append(__tmp43Line);
                    if (!__tmp43_last) __out.AppendLine(true);
                }
            }
            string __tmp44Line = " findOne(Long id);"; //225:21
            if (__tmp44Line != null) __out.Append(__tmp44Line);
            __out.AppendLine(false); //225:39
            __out.AppendLine(true); //226:1
            string __tmp46Line = "	public <S extends "; //227:1
            if (__tmp46Line != null) __out.Append(__tmp46Line);
            StringBuilder __tmp47 = new StringBuilder();
            __tmp47.Append(entityName);
            using(StreamReader __tmp47Reader = new StreamReader(this.__ToStream(__tmp47.ToString())))
            {
                bool __tmp47_first = true;
                bool __tmp47_last = __tmp47Reader.EndOfStream;
                while(__tmp47_first || !__tmp47_last)
                {
                    __tmp47_first = false;
                    string __tmp47Line = __tmp47Reader.ReadLine();
                    __tmp47_last = __tmp47Reader.EndOfStream;
                    if (__tmp47Line != null) __out.Append(__tmp47Line);
                    if (!__tmp47_last) __out.AppendLine(true);
                }
            }
            string __tmp48Line = "> S save(S entity);"; //227:32
            if (__tmp48Line != null) __out.Append(__tmp48Line);
            __out.AppendLine(false); //227:51
            __out.AppendLine(true); //228:1
            string __tmp50Line = "	public <S extends "; //229:1
            if (__tmp50Line != null) __out.Append(__tmp50Line);
            StringBuilder __tmp51 = new StringBuilder();
            __tmp51.Append(entityName);
            using(StreamReader __tmp51Reader = new StreamReader(this.__ToStream(__tmp51.ToString())))
            {
                bool __tmp51_first = true;
                bool __tmp51_last = __tmp51Reader.EndOfStream;
                while(__tmp51_first || !__tmp51_last)
                {
                    __tmp51_first = false;
                    string __tmp51Line = __tmp51Reader.ReadLine();
                    __tmp51_last = __tmp51Reader.EndOfStream;
                    if (__tmp51Line != null) __out.Append(__tmp51Line);
                    if (!__tmp51_last) __out.AppendLine(true);
                }
            }
            string __tmp52Line = "> Iterable<S> save(Iterable<S> entities);"; //229:32
            if (__tmp52Line != null) __out.Append(__tmp52Line);
            __out.AppendLine(false); //229:73
            __out.AppendLine(true); //230:1
            __out.Append("}"); //231:1
            __out.AppendLine(false); //231:2
            return __out.ToString();
        }

        public string GenerateRepositoryProxyImpl(string namespaceName, string entityName, string bindingType) //235:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp2Line = "package "; //236:1
            if (__tmp2Line != null) __out.Append(__tmp2Line);
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(namespaceName.ToLower());
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
            string __tmp4Line = "."; //236:34
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
            string __tmp6Line = ";"; //236:85
            if (__tmp6Line != null) __out.Append(__tmp6Line);
            __out.AppendLine(false); //236:86
            __out.AppendLine(true); //237:1
            __out.Append("import org.springframework.beans.factory.annotation.Autowired;"); //238:1
            __out.AppendLine(false); //238:63
            __out.AppendLine(true); //239:1
            string __tmp8Line = "import "; //240:1
            if (__tmp8Line != null) __out.Append(__tmp8Line);
            StringBuilder __tmp9 = new StringBuilder();
            __tmp9.Append(namespaceName.ToLower());
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
            string __tmp10Line = "."; //240:33
            if (__tmp10Line != null) __out.Append(__tmp10Line);
            StringBuilder __tmp11 = new StringBuilder();
            __tmp11.Append(SpringGeneratorUtil.Properties.entityPackage);
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
            string __tmp12Line = "."; //240:80
            if (__tmp12Line != null) __out.Append(__tmp12Line);
            StringBuilder __tmp13 = new StringBuilder();
            __tmp13.Append(entityName);
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
            string __tmp14Line = ";"; //240:93
            if (__tmp14Line != null) __out.Append(__tmp14Line);
            __out.AppendLine(false); //240:94
            string __tmp16Line = "import "; //241:1
            if (__tmp16Line != null) __out.Append(__tmp16Line);
            StringBuilder __tmp17 = new StringBuilder();
            __tmp17.Append(namespaceName.ToLower());
            using(StreamReader __tmp17Reader = new StreamReader(this.__ToStream(__tmp17.ToString())))
            {
                bool __tmp17_first = true;
                bool __tmp17_last = __tmp17Reader.EndOfStream;
                while(__tmp17_first || !__tmp17_last)
                {
                    __tmp17_first = false;
                    string __tmp17Line = __tmp17Reader.ReadLine();
                    __tmp17_last = __tmp17Reader.EndOfStream;
                    if (__tmp17Line != null) __out.Append(__tmp17Line);
                    if (!__tmp17_last) __out.AppendLine(true);
                }
            }
            string __tmp18Line = "."; //241:33
            if (__tmp18Line != null) __out.Append(__tmp18Line);
            StringBuilder __tmp19 = new StringBuilder();
            __tmp19.Append(SpringGeneratorUtil.Properties.repositoryPackage);
            using(StreamReader __tmp19Reader = new StreamReader(this.__ToStream(__tmp19.ToString())))
            {
                bool __tmp19_first = true;
                bool __tmp19_last = __tmp19Reader.EndOfStream;
                while(__tmp19_first || !__tmp19_last)
                {
                    __tmp19_first = false;
                    string __tmp19Line = __tmp19Reader.ReadLine();
                    __tmp19_last = __tmp19Reader.EndOfStream;
                    if (__tmp19Line != null) __out.Append(__tmp19Line);
                    if (!__tmp19_last) __out.AppendLine(true);
                }
            }
            string __tmp20Line = "."; //241:84
            if (__tmp20Line != null) __out.Append(__tmp20Line);
            StringBuilder __tmp21 = new StringBuilder();
            __tmp21.Append(entityName);
            using(StreamReader __tmp21Reader = new StreamReader(this.__ToStream(__tmp21.ToString())))
            {
                bool __tmp21_first = true;
                bool __tmp21_last = __tmp21Reader.EndOfStream;
                while(__tmp21_first || !__tmp21_last)
                {
                    __tmp21_first = false;
                    string __tmp21Line = __tmp21Reader.ReadLine();
                    __tmp21_last = __tmp21Reader.EndOfStream;
                    if (__tmp21Line != null) __out.Append(__tmp21Line);
                    if (!__tmp21_last) __out.AppendLine(true);
                }
            }
            string __tmp22Line = "Repository;"; //241:97
            if (__tmp22Line != null) __out.Append(__tmp22Line);
            __out.AppendLine(false); //241:108
            string __tmp24Line = "import "; //242:1
            if (__tmp24Line != null) __out.Append(__tmp24Line);
            StringBuilder __tmp25 = new StringBuilder();
            __tmp25.Append(namespaceName.ToLower());
            using(StreamReader __tmp25Reader = new StreamReader(this.__ToStream(__tmp25.ToString())))
            {
                bool __tmp25_first = true;
                bool __tmp25_last = __tmp25Reader.EndOfStream;
                while(__tmp25_first || !__tmp25_last)
                {
                    __tmp25_first = false;
                    string __tmp25Line = __tmp25Reader.ReadLine();
                    __tmp25_last = __tmp25Reader.EndOfStream;
                    if (__tmp25Line != null) __out.Append(__tmp25Line);
                    if (!__tmp25_last) __out.AppendLine(true);
                }
            }
            string __tmp26Line = "."; //242:33
            if (__tmp26Line != null) __out.Append(__tmp26Line);
            StringBuilder __tmp27 = new StringBuilder();
            __tmp27.Append(SpringGeneratorUtil.Properties.interfacePackage);
            using(StreamReader __tmp27Reader = new StreamReader(this.__ToStream(__tmp27.ToString())))
            {
                bool __tmp27_first = true;
                bool __tmp27_last = __tmp27Reader.EndOfStream;
                while(__tmp27_first || !__tmp27_last)
                {
                    __tmp27_first = false;
                    string __tmp27Line = __tmp27Reader.ReadLine();
                    __tmp27_last = __tmp27Reader.EndOfStream;
                    if (__tmp27Line != null) __out.Append(__tmp27Line);
                    if (!__tmp27_last) __out.AppendLine(true);
                }
            }
            string __tmp28Line = "."; //242:83
            if (__tmp28Line != null) __out.Append(__tmp28Line);
            StringBuilder __tmp29 = new StringBuilder();
            __tmp29.Append(entityName);
            using(StreamReader __tmp29Reader = new StreamReader(this.__ToStream(__tmp29.ToString())))
            {
                bool __tmp29_first = true;
                bool __tmp29_last = __tmp29Reader.EndOfStream;
                while(__tmp29_first || !__tmp29_last)
                {
                    __tmp29_first = false;
                    string __tmp29Line = __tmp29Reader.ReadLine();
                    __tmp29_last = __tmp29Reader.EndOfStream;
                    if (__tmp29Line != null) __out.Append(__tmp29Line);
                    if (!__tmp29_last) __out.AppendLine(true);
                }
            }
            string __tmp30Line = "Repository"; //242:96
            if (__tmp30Line != null) __out.Append(__tmp30Line);
            StringBuilder __tmp31 = new StringBuilder();
            __tmp31.Append(bindingType);
            using(StreamReader __tmp31Reader = new StreamReader(this.__ToStream(__tmp31.ToString())))
            {
                bool __tmp31_first = true;
                bool __tmp31_last = __tmp31Reader.EndOfStream;
                while(__tmp31_first || !__tmp31_last)
                {
                    __tmp31_first = false;
                    string __tmp31Line = __tmp31Reader.ReadLine();
                    __tmp31_last = __tmp31Reader.EndOfStream;
                    if (__tmp31Line != null) __out.Append(__tmp31Line);
                    if (!__tmp31_last) __out.AppendLine(true);
                }
            }
            string __tmp32Line = ";"; //242:119
            if (__tmp32Line != null) __out.Append(__tmp32Line);
            __out.AppendLine(false); //242:120
            __out.AppendLine(true); //243:1
            string __tmp34Line = "public class "; //244:1
            if (__tmp34Line != null) __out.Append(__tmp34Line);
            StringBuilder __tmp35 = new StringBuilder();
            __tmp35.Append(entityName);
            using(StreamReader __tmp35Reader = new StreamReader(this.__ToStream(__tmp35.ToString())))
            {
                bool __tmp35_first = true;
                bool __tmp35_last = __tmp35Reader.EndOfStream;
                while(__tmp35_first || !__tmp35_last)
                {
                    __tmp35_first = false;
                    string __tmp35Line = __tmp35Reader.ReadLine();
                    __tmp35_last = __tmp35Reader.EndOfStream;
                    if (__tmp35Line != null) __out.Append(__tmp35Line);
                    if (!__tmp35_last) __out.AppendLine(true);
                }
            }
            string __tmp36Line = "Repository"; //244:26
            if (__tmp36Line != null) __out.Append(__tmp36Line);
            StringBuilder __tmp37 = new StringBuilder();
            __tmp37.Append(bindingType);
            using(StreamReader __tmp37Reader = new StreamReader(this.__ToStream(__tmp37.ToString())))
            {
                bool __tmp37_first = true;
                bool __tmp37_last = __tmp37Reader.EndOfStream;
                while(__tmp37_first || !__tmp37_last)
                {
                    __tmp37_first = false;
                    string __tmp37Line = __tmp37Reader.ReadLine();
                    __tmp37_last = __tmp37Reader.EndOfStream;
                    if (__tmp37Line != null) __out.Append(__tmp37Line);
                    if (!__tmp37_last) __out.AppendLine(true);
                }
            }
            string __tmp38Line = "Impl implements "; //244:49
            if (__tmp38Line != null) __out.Append(__tmp38Line);
            StringBuilder __tmp39 = new StringBuilder();
            __tmp39.Append(entityName);
            using(StreamReader __tmp39Reader = new StreamReader(this.__ToStream(__tmp39.ToString())))
            {
                bool __tmp39_first = true;
                bool __tmp39_last = __tmp39Reader.EndOfStream;
                while(__tmp39_first || !__tmp39_last)
                {
                    __tmp39_first = false;
                    string __tmp39Line = __tmp39Reader.ReadLine();
                    __tmp39_last = __tmp39Reader.EndOfStream;
                    if (__tmp39Line != null) __out.Append(__tmp39Line);
                    if (!__tmp39_last) __out.AppendLine(true);
                }
            }
            string __tmp40Line = "Repository"; //244:77
            if (__tmp40Line != null) __out.Append(__tmp40Line);
            StringBuilder __tmp41 = new StringBuilder();
            __tmp41.Append(bindingType);
            using(StreamReader __tmp41Reader = new StreamReader(this.__ToStream(__tmp41.ToString())))
            {
                bool __tmp41_first = true;
                bool __tmp41_last = __tmp41Reader.EndOfStream;
                while(__tmp41_first || !__tmp41_last)
                {
                    __tmp41_first = false;
                    string __tmp41Line = __tmp41Reader.ReadLine();
                    __tmp41_last = __tmp41Reader.EndOfStream;
                    if (__tmp41Line != null) __out.Append(__tmp41Line);
                    if (!__tmp41_last) __out.AppendLine(true);
                }
            }
            string __tmp42Line = " {"; //244:100
            if (__tmp42Line != null) __out.Append(__tmp42Line);
            __out.AppendLine(false); //244:102
            __out.AppendLine(true); //245:1
            __out.Append("	@Autowired"); //246:1
            __out.AppendLine(false); //246:12
            string __tmp43Prefix = "	"; //247:1
            StringBuilder __tmp44 = new StringBuilder();
            __tmp44.Append(entityName);
            using(StreamReader __tmp44Reader = new StreamReader(this.__ToStream(__tmp44.ToString())))
            {
                bool __tmp44_first = true;
                bool __tmp44_last = __tmp44Reader.EndOfStream;
                while(__tmp44_first || !__tmp44_last)
                {
                    __tmp44_first = false;
                    string __tmp44Line = __tmp44Reader.ReadLine();
                    __tmp44_last = __tmp44Reader.EndOfStream;
                    __out.Append(__tmp43Prefix);
                    if (__tmp44Line != null) __out.Append(__tmp44Line);
                    if (!__tmp44_last) __out.AppendLine(true);
                }
            }
            string __tmp45Line = "Repository repository;"; //247:14
            if (__tmp45Line != null) __out.Append(__tmp45Line);
            __out.AppendLine(false); //247:36
            __out.AppendLine(true); //248:1
            __out.Append("	@Override"); //249:1
            __out.AppendLine(false); //249:11
            __out.Append("	public long count() {"); //250:1
            __out.AppendLine(false); //250:23
            __out.Append("		return repository.count();"); //251:1
            __out.AppendLine(false); //251:29
            __out.Append("	}"); //252:1
            __out.AppendLine(false); //252:3
            __out.AppendLine(true); //253:1
            __out.Append("	@Override"); //254:1
            __out.AppendLine(false); //254:11
            __out.Append("	public void delete(Long id) {"); //255:1
            __out.AppendLine(false); //255:31
            __out.Append("		repository.delete(id);"); //256:1
            __out.AppendLine(false); //256:25
            __out.Append("	}"); //257:1
            __out.AppendLine(false); //257:3
            __out.AppendLine(true); //258:1
            __out.Append("	@Override"); //259:1
            __out.AppendLine(false); //259:11
            string __tmp47Line = "	public void delete("; //260:1
            if (__tmp47Line != null) __out.Append(__tmp47Line);
            StringBuilder __tmp48 = new StringBuilder();
            __tmp48.Append(entityName);
            using(StreamReader __tmp48Reader = new StreamReader(this.__ToStream(__tmp48.ToString())))
            {
                bool __tmp48_first = true;
                bool __tmp48_last = __tmp48Reader.EndOfStream;
                while(__tmp48_first || !__tmp48_last)
                {
                    __tmp48_first = false;
                    string __tmp48Line = __tmp48Reader.ReadLine();
                    __tmp48_last = __tmp48Reader.EndOfStream;
                    if (__tmp48Line != null) __out.Append(__tmp48Line);
                    if (!__tmp48_last) __out.AppendLine(true);
                }
            }
            string __tmp49Line = " entity) {"; //260:33
            if (__tmp49Line != null) __out.Append(__tmp49Line);
            __out.AppendLine(false); //260:43
            __out.Append("		repository.delete(entity);"); //261:1
            __out.AppendLine(false); //261:29
            __out.Append("	}"); //262:1
            __out.AppendLine(false); //262:3
            __out.AppendLine(true); //263:1
            __out.Append("	@Override"); //264:1
            __out.AppendLine(false); //264:11
            string __tmp51Line = "	public void delete(Iterable<? extends "; //265:1
            if (__tmp51Line != null) __out.Append(__tmp51Line);
            StringBuilder __tmp52 = new StringBuilder();
            __tmp52.Append(entityName);
            using(StreamReader __tmp52Reader = new StreamReader(this.__ToStream(__tmp52.ToString())))
            {
                bool __tmp52_first = true;
                bool __tmp52_last = __tmp52Reader.EndOfStream;
                while(__tmp52_first || !__tmp52_last)
                {
                    __tmp52_first = false;
                    string __tmp52Line = __tmp52Reader.ReadLine();
                    __tmp52_last = __tmp52Reader.EndOfStream;
                    if (__tmp52Line != null) __out.Append(__tmp52Line);
                    if (!__tmp52_last) __out.AppendLine(true);
                }
            }
            string __tmp53Line = "> entities) {"; //265:52
            if (__tmp53Line != null) __out.Append(__tmp53Line);
            __out.AppendLine(false); //265:65
            __out.Append("		repository.delete(entities);"); //266:1
            __out.AppendLine(false); //266:31
            __out.Append("	}"); //267:1
            __out.AppendLine(false); //267:3
            __out.AppendLine(true); //268:1
            __out.Append("	@Override"); //269:1
            __out.AppendLine(false); //269:11
            __out.Append("	public void deleteAll() {"); //270:1
            __out.AppendLine(false); //270:27
            __out.Append("		repository.deleteAll();"); //271:1
            __out.AppendLine(false); //271:26
            __out.Append("	}"); //272:1
            __out.AppendLine(false); //272:3
            __out.AppendLine(true); //273:1
            __out.Append("	@Override"); //274:1
            __out.AppendLine(false); //274:11
            __out.Append("	public boolean exists(Long id) {"); //275:1
            __out.AppendLine(false); //275:34
            __out.Append("		return repository.exists(id);"); //276:1
            __out.AppendLine(false); //276:32
            __out.Append("	}"); //277:1
            __out.AppendLine(false); //277:3
            __out.AppendLine(true); //278:1
            __out.Append("	@Override"); //279:1
            __out.AppendLine(false); //279:11
            string __tmp55Line = "	public Iterable<"; //280:1
            if (__tmp55Line != null) __out.Append(__tmp55Line);
            StringBuilder __tmp56 = new StringBuilder();
            __tmp56.Append(entityName);
            using(StreamReader __tmp56Reader = new StreamReader(this.__ToStream(__tmp56.ToString())))
            {
                bool __tmp56_first = true;
                bool __tmp56_last = __tmp56Reader.EndOfStream;
                while(__tmp56_first || !__tmp56_last)
                {
                    __tmp56_first = false;
                    string __tmp56Line = __tmp56Reader.ReadLine();
                    __tmp56_last = __tmp56Reader.EndOfStream;
                    if (__tmp56Line != null) __out.Append(__tmp56Line);
                    if (!__tmp56_last) __out.AppendLine(true);
                }
            }
            string __tmp57Line = "> findAll() {"; //280:30
            if (__tmp57Line != null) __out.Append(__tmp57Line);
            __out.AppendLine(false); //280:43
            __out.Append("		return repository.findAll();"); //281:1
            __out.AppendLine(false); //281:31
            __out.Append("	}"); //282:1
            __out.AppendLine(false); //282:3
            __out.AppendLine(true); //283:1
            __out.Append("	@Override"); //284:1
            __out.AppendLine(false); //284:11
            string __tmp59Line = "	public Iterable<"; //285:1
            if (__tmp59Line != null) __out.Append(__tmp59Line);
            StringBuilder __tmp60 = new StringBuilder();
            __tmp60.Append(entityName);
            using(StreamReader __tmp60Reader = new StreamReader(this.__ToStream(__tmp60.ToString())))
            {
                bool __tmp60_first = true;
                bool __tmp60_last = __tmp60Reader.EndOfStream;
                while(__tmp60_first || !__tmp60_last)
                {
                    __tmp60_first = false;
                    string __tmp60Line = __tmp60Reader.ReadLine();
                    __tmp60_last = __tmp60Reader.EndOfStream;
                    if (__tmp60Line != null) __out.Append(__tmp60Line);
                    if (!__tmp60_last) __out.AppendLine(true);
                }
            }
            string __tmp61Line = "> findAll(Iterable<Long> entities) {"; //285:30
            if (__tmp61Line != null) __out.Append(__tmp61Line);
            __out.AppendLine(false); //285:66
            __out.Append("		return repository.findAll(entities);"); //286:1
            __out.AppendLine(false); //286:39
            __out.Append("	}"); //287:1
            __out.AppendLine(false); //287:3
            __out.AppendLine(true); //288:1
            __out.Append("	@Override"); //289:1
            __out.AppendLine(false); //289:11
            string __tmp63Line = "	public "; //290:1
            if (__tmp63Line != null) __out.Append(__tmp63Line);
            StringBuilder __tmp64 = new StringBuilder();
            __tmp64.Append(entityName);
            using(StreamReader __tmp64Reader = new StreamReader(this.__ToStream(__tmp64.ToString())))
            {
                bool __tmp64_first = true;
                bool __tmp64_last = __tmp64Reader.EndOfStream;
                while(__tmp64_first || !__tmp64_last)
                {
                    __tmp64_first = false;
                    string __tmp64Line = __tmp64Reader.ReadLine();
                    __tmp64_last = __tmp64Reader.EndOfStream;
                    if (__tmp64Line != null) __out.Append(__tmp64Line);
                    if (!__tmp64_last) __out.AppendLine(true);
                }
            }
            string __tmp65Line = " findOne(Long id) {"; //290:21
            if (__tmp65Line != null) __out.Append(__tmp65Line);
            __out.AppendLine(false); //290:40
            __out.Append("		return repository.findOne(id);"); //291:1
            __out.AppendLine(false); //291:33
            __out.Append("	}"); //292:1
            __out.AppendLine(false); //292:3
            __out.AppendLine(true); //293:1
            __out.Append("	@Override"); //294:1
            __out.AppendLine(false); //294:11
            string __tmp67Line = "	public <S extends "; //295:1
            if (__tmp67Line != null) __out.Append(__tmp67Line);
            StringBuilder __tmp68 = new StringBuilder();
            __tmp68.Append(entityName);
            using(StreamReader __tmp68Reader = new StreamReader(this.__ToStream(__tmp68.ToString())))
            {
                bool __tmp68_first = true;
                bool __tmp68_last = __tmp68Reader.EndOfStream;
                while(__tmp68_first || !__tmp68_last)
                {
                    __tmp68_first = false;
                    string __tmp68Line = __tmp68Reader.ReadLine();
                    __tmp68_last = __tmp68Reader.EndOfStream;
                    if (__tmp68Line != null) __out.Append(__tmp68Line);
                    if (!__tmp68_last) __out.AppendLine(true);
                }
            }
            string __tmp69Line = "> S save(S entity) {"; //295:32
            if (__tmp69Line != null) __out.Append(__tmp69Line);
            __out.AppendLine(false); //295:52
            __out.Append("		return repository.save(entity);"); //296:1
            __out.AppendLine(false); //296:34
            __out.Append("	}"); //297:1
            __out.AppendLine(false); //297:3
            __out.AppendLine(true); //298:1
            __out.Append("	@Override"); //299:1
            __out.AppendLine(false); //299:11
            string __tmp71Line = "	public <S extends "; //300:1
            if (__tmp71Line != null) __out.Append(__tmp71Line);
            StringBuilder __tmp72 = new StringBuilder();
            __tmp72.Append(entityName);
            using(StreamReader __tmp72Reader = new StreamReader(this.__ToStream(__tmp72.ToString())))
            {
                bool __tmp72_first = true;
                bool __tmp72_last = __tmp72Reader.EndOfStream;
                while(__tmp72_first || !__tmp72_last)
                {
                    __tmp72_first = false;
                    string __tmp72Line = __tmp72Reader.ReadLine();
                    __tmp72_last = __tmp72Reader.EndOfStream;
                    if (__tmp72Line != null) __out.Append(__tmp72Line);
                    if (!__tmp72_last) __out.AppendLine(true);
                }
            }
            string __tmp73Line = "> Iterable<S> save(Iterable<S> entities) {"; //300:32
            if (__tmp73Line != null) __out.Append(__tmp73Line);
            __out.AppendLine(false); //300:74
            __out.Append("		return repository.save(entities);"); //301:1
            __out.AppendLine(false); //301:36
            __out.Append("	}"); //302:1
            __out.AppendLine(false); //302:3
            __out.AppendLine(true); //303:1
            __out.Append("}"); //304:1
            __out.AppendLine(false); //304:2
            return __out.ToString();
        }

        public string InterfaceAnnotation(string bindingType) //308:1
        {
            StringBuilder __out = new StringBuilder();
            if (bindingType.Equals("Rest")) //309:3
            {
                __out.Append("@RestController"); //310:1
                __out.AppendLine(false); //310:16
            }
            else if (bindingType.Equals("WebService")) //311:3
            {
                __out.Append("//@WebService"); //312:1
                __out.AppendLine(false); //312:14
            }
            else if (bindingType.Equals("WebSockett")) //313:3
            {
                __out.Append("//@WebSocket"); //314:1
                __out.AppendLine(false); //314:13
            }
            return __out.ToString();
        }

        public string OperationAnnotation(string bindingType, Operation op) //320:1
        {
            StringBuilder __out = new StringBuilder();
            if (bindingType.Equals("Rest")) //321:3
            {
                string __tmp2Line = "	@RequestMapping(value=\""; //322:1
                if (__tmp2Line != null) __out.Append(__tmp2Line);
                StringBuilder __tmp3 = new StringBuilder();
                __tmp3.Append(op.Name.ToCamelCase());
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
                string __tmp4Line = "\")"; //322:48
                if (__tmp4Line != null) __out.Append(__tmp4Line);
                __out.AppendLine(false); //322:50
            }
            else if (bindingType.Equals("WebService")) //323:3
            {
                __out.Append("	//@WebService"); //324:1
                __out.AppendLine(false); //324:15
            }
            else if (bindingType.Equals("WebSockett")) //325:3
            {
                __out.Append("	//@WebSocket"); //326:1
                __out.AppendLine(false); //326:14
            }
            return __out.ToString();
        }

        public string ParameterAnnotation(string bindingType) //332:1
        {
            StringBuilder __out = new StringBuilder();
            if (bindingType.Equals("Rest")) //333:3
            {
                __out.Append("@PathVariable "); //334:1
            }
            else if (bindingType.Equals("WebService")) //335:3
            {
            }
            else if (bindingType.Equals("WebSockett")) //337:3
            {
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
