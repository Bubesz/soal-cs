using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Soal //1:1
{
    using __Hidden_SpringInterfaceGenerator_1862267407;
    namespace __Hidden_SpringInterfaceGenerator_1862267407
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

        public string InterfaceAnnotation(string bindingType) //111:1
        {
            StringBuilder __out = new StringBuilder();
            if (bindingType.Equals("Rest")) //112:3
            {
                __out.Append("@RestController"); //113:1
                __out.AppendLine(false); //113:16
            }
            else if (bindingType.Equals("WebService")) //114:3
            {
                __out.Append("//@WebService"); //115:1
                __out.AppendLine(false); //115:14
            }
            else if (bindingType.Equals("WebSockett")) //116:3
            {
                __out.Append("//@WebSocket"); //117:1
                __out.AppendLine(false); //117:13
            }
            return __out.ToString();
        }

        public string OperationAnnotation(string bindingType, Operation op) //123:1
        {
            StringBuilder __out = new StringBuilder();
            if (bindingType.Equals("Rest")) //124:3
            {
                string __tmp2Line = "	@RequestMapping(value=\""; //125:1
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
                string __tmp4Line = "\")"; //125:48
                if (__tmp4Line != null) __out.Append(__tmp4Line);
                __out.AppendLine(false); //125:50
            }
            else if (bindingType.Equals("WebService")) //126:3
            {
                __out.Append("	//@WebService"); //127:1
                __out.AppendLine(false); //127:15
            }
            else if (bindingType.Equals("WebSockett")) //128:3
            {
                __out.Append("	//@WebSocket"); //129:1
                __out.AppendLine(false); //129:14
            }
            return __out.ToString();
        }

        public string ParameterAnnotation(string bindingType) //135:1
        {
            StringBuilder __out = new StringBuilder();
            if (bindingType.Equals("Rest")) //136:3
            {
                __out.Append("@PathVariable "); //137:1
            }
            else if (bindingType.Equals("WebService")) //138:3
            {
            }
            else if (bindingType.Equals("WebSockett")) //140:3
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
