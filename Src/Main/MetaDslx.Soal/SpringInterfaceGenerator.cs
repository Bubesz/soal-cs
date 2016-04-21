using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Soal //1:1
{
    using __Hidden_SpringInterfaceGenerator_1446272869;
    namespace __Hidden_SpringInterfaceGenerator_1446272869
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
            StringBuilder __tmp8 = new StringBuilder();
            __tmp8.Append(GenerateImportsForBinding(bindingType));
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
                    __out.AppendLine(false); //10:41
                }
            }
            StringBuilder __tmp10 = new StringBuilder();
            __tmp10.Append(SpringGeneratorUtil.GenerateImports(iface, false));
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
                    __out.AppendLine(false); //12:52
                }
            }
            __out.AppendLine(true); //13:1
            StringBuilder __tmp12 = new StringBuilder();
            __tmp12.Append(InterfaceAnnotation(bindingType));
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
                    __out.AppendLine(false); //14:35
                }
            }
            string __tmp14Line = "public interface "; //15:1
            if (__tmp14Line != null) __out.Append(__tmp14Line);
            StringBuilder __tmp15 = new StringBuilder();
            __tmp15.Append(iface.Name);
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
            StringBuilder __tmp16 = new StringBuilder();
            __tmp16.Append(bindingType);
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
            string __tmp17Line = " {"; //15:43
            if (__tmp17Line != null) __out.Append(__tmp17Line);
            __out.AppendLine(false); //15:45
            var __loop1_results = 
                (from __loop1_var1 in __Enumerate((iface).GetEnumerator()) //16:8
                from op in __Enumerate((__loop1_var1.Operations).GetEnumerator()) //16:15
                select new { __loop1_var1 = __loop1_var1, op = op}
                ).ToList(); //16:2
            int __loop1_iteration = 0;
            foreach (var __tmp18 in __loop1_results)
            {
                ++__loop1_iteration;
                var __loop1_var1 = __tmp18.__loop1_var1;
                var op = __tmp18.op;
                __out.AppendLine(true); //17:1
                StringBuilder __tmp20 = new StringBuilder();
                __tmp20.Append(OperationAnnotation(op, bindingType));
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
                        __out.AppendLine(false); //18:39
                    }
                }
                string __tmp21Prefix = "	"; //19:1
                StringBuilder __tmp22 = new StringBuilder();
                __tmp22.Append(op.Result.Type.GetJavaName());
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
                    }
                }
                string __tmp23Line = " "; //19:32
                if (__tmp23Line != null) __out.Append(__tmp23Line);
                StringBuilder __tmp24 = new StringBuilder();
                __tmp24.Append(op.Name.ToCamelCase());
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
                string __tmp25Line = "("; //19:56
                if (__tmp25Line != null) __out.Append(__tmp25Line);
                var __loop2_results = 
                    (from __loop2_var1 in __Enumerate((op).GetEnumerator()) //20:9
                    from param in __Enumerate((__loop2_var1.Parameters).GetEnumerator()) //20:13
                    select new { __loop2_var1 = __loop2_var1, param = param}
                    ).ToList(); //20:3
                int __loop2_iteration = 0;
                string delimiter = ""; //20:31
                foreach (var __tmp26 in __loop2_results)
                {
                    ++__loop2_iteration;
                    if (__loop2_iteration >= 2) //20:54
                    {
                        delimiter = ", "; //20:54
                    }
                    var __loop2_var1 = __tmp26.__loop2_var1;
                    var param = __tmp26.param;
                    StringBuilder __tmp28 = new StringBuilder();
                    __tmp28.Append(delimiter);
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
                    StringBuilder __tmp29 = new StringBuilder();
                    __tmp29.Append(ParameterAnnotation(param, bindingType));
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
                    StringBuilder __tmp30 = new StringBuilder();
                    __tmp30.Append(param.Type.GetJavaName());
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
                    string __tmp31Line = " "; //21:79
                    if (__tmp31Line != null) __out.Append(__tmp31Line);
                    StringBuilder __tmp32 = new StringBuilder();
                    __tmp32.Append(param.Name.ToString().ToCamelCase());
                    using(StreamReader __tmp32Reader = new StreamReader(this.__ToStream(__tmp32.ToString())))
                    {
                        bool __tmp32_first = true;
                        bool __tmp32_last = __tmp32Reader.EndOfStream;
                        while(__tmp32_first || !__tmp32_last)
                        {
                            __tmp32_first = false;
                            string __tmp32Line = __tmp32Reader.ReadLine();
                            __tmp32_last = __tmp32Reader.EndOfStream;
                            if (__tmp32Line != null) __out.Append(__tmp32Line);
                            if (!__tmp32_last) __out.AppendLine(true);
                        }
                    }
                }
                __out.Append(")"); //23:1
                if (op.Exceptions.Any()) //24:3
                {
                    string __tmp34Line = " throws "; //25:1
                    if (__tmp34Line != null) __out.Append(__tmp34Line);
                    StringBuilder __tmp35 = new StringBuilder();
                    __tmp35.Append(SpringGeneratorUtil.GetExceptionList(op));
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
                }
                __out.Append(";"); //27:1
                __out.AppendLine(false); //27:2
            }
            __out.Append("}"); //30:1
            __out.AppendLine(false); //30:2
            return __out.ToString();
        }

        public string GenerateInterfaceImplementation(Interface iface, string functionName, string dataBinding) //35:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp2Line = "package "; //36:1
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
            string __tmp4Line = "."; //36:48
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
            string __tmp6Line = ";"; //36:63
            if (__tmp6Line != null) __out.Append(__tmp6Line);
            __out.AppendLine(false); //36:64
            __out.AppendLine(true); //37:1
            __out.Append("import org.springframework.beans.factory.annotation.Autowired;"); //38:1
            __out.AppendLine(false); //38:63
            __out.Append("import org.springframework.stereotype.Service;"); //39:1
            __out.AppendLine(false); //39:47
            __out.AppendLine(true); //40:1
            string __tmp8Line = "import "; //41:1
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
            string __tmp10Line = "."; //41:47
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
            string __tmp12Line = "."; //41:97
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
            string __tmp14Line = ";"; //41:110
            if (__tmp14Line != null) __out.Append(__tmp14Line);
            __out.AppendLine(false); //41:111
            __out.AppendLine(true); //42:1
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
                    __out.AppendLine(false); //43:45
                }
            }
            __out.AppendLine(true); //44:1
            __out.Append("@Service"); //45:1
            __out.AppendLine(false); //45:9
            string __tmp18Line = "public class "; //46:1
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
            string __tmp20Line = "Impl implements "; //46:26
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
            string __tmp22Line = " {"; //46:54
            if (__tmp22Line != null) __out.Append(__tmp22Line);
            __out.AppendLine(false); //46:56
            var __loop3_results = 
                (from __loop3_var1 in __Enumerate((iface).GetEnumerator()) //47:8
                from repo in __Enumerate((__loop3_var1.GetRepositories()).GetEnumerator()) //47:15
                select new { __loop3_var1 = __loop3_var1, repo = repo}
                ).ToList(); //47:2
            int __loop3_iteration = 0;
            foreach (var __tmp23 in __loop3_results)
            {
                ++__loop3_iteration;
                var __loop3_var1 = __tmp23.__loop3_var1;
                var repo = __tmp23.repo;
                __out.AppendLine(true); //48:1
                __out.Append("	@Autowired"); //49:1
                __out.AppendLine(false); //49:12
                string __tmp25Line = "	private "; //50:1
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
                StringBuilder __tmp27 = new StringBuilder();
                __tmp27.Append(dataBinding);
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
                string __tmp28Line = ";"; //50:29
                if (__tmp28Line != null) __out.Append(__tmp28Line);
                __out.AppendLine(false); //50:30
            }
            var __loop4_results = 
                (from __loop4_var1 in __Enumerate((iface).GetEnumerator()) //52:7
                from op in __Enumerate((__loop4_var1.Operations).GetEnumerator()) //52:14
                select new { __loop4_var1 = __loop4_var1, op = op}
                ).ToList(); //52:2
            int __loop4_iteration = 0;
            foreach (var __tmp29 in __loop4_results)
            {
                ++__loop4_iteration;
                var __loop4_var1 = __tmp29.__loop4_var1;
                var op = __tmp29.op;
                __out.AppendLine(true); //53:1
                string __tmp31Line = "	public "; //54:1
                if (__tmp31Line != null) __out.Append(__tmp31Line);
                StringBuilder __tmp32 = new StringBuilder();
                __tmp32.Append(op.Result.Type.GetJavaName());
                using(StreamReader __tmp32Reader = new StreamReader(this.__ToStream(__tmp32.ToString())))
                {
                    bool __tmp32_first = true;
                    bool __tmp32_last = __tmp32Reader.EndOfStream;
                    while(__tmp32_first || !__tmp32_last)
                    {
                        __tmp32_first = false;
                        string __tmp32Line = __tmp32Reader.ReadLine();
                        __tmp32_last = __tmp32Reader.EndOfStream;
                        if (__tmp32Line != null) __out.Append(__tmp32Line);
                        if (!__tmp32_last) __out.AppendLine(true);
                    }
                }
                string __tmp33Line = " "; //54:39
                if (__tmp33Line != null) __out.Append(__tmp33Line);
                StringBuilder __tmp34 = new StringBuilder();
                __tmp34.Append(op.Name.ToCamelCase());
                using(StreamReader __tmp34Reader = new StreamReader(this.__ToStream(__tmp34.ToString())))
                {
                    bool __tmp34_first = true;
                    bool __tmp34_last = __tmp34Reader.EndOfStream;
                    while(__tmp34_first || !__tmp34_last)
                    {
                        __tmp34_first = false;
                        string __tmp34Line = __tmp34Reader.ReadLine();
                        __tmp34_last = __tmp34Reader.EndOfStream;
                        if (__tmp34Line != null) __out.Append(__tmp34Line);
                        if (!__tmp34_last) __out.AppendLine(true);
                    }
                }
                string __tmp35Line = "("; //54:63
                if (__tmp35Line != null) __out.Append(__tmp35Line);
                StringBuilder __tmp36 = new StringBuilder();
                __tmp36.Append(SpringGeneratorUtil.GetParameterList(op));
                using(StreamReader __tmp36Reader = new StreamReader(this.__ToStream(__tmp36.ToString())))
                {
                    bool __tmp36_first = true;
                    bool __tmp36_last = __tmp36Reader.EndOfStream;
                    while(__tmp36_first || !__tmp36_last)
                    {
                        __tmp36_first = false;
                        string __tmp36Line = __tmp36Reader.ReadLine();
                        __tmp36_last = __tmp36Reader.EndOfStream;
                        if (__tmp36Line != null) __out.Append(__tmp36Line);
                        if (!__tmp36_last) __out.AppendLine(true);
                    }
                }
                string __tmp37Line = ")"; //54:106
                if (__tmp37Line != null) __out.Append(__tmp37Line);
                if (op.Exceptions.Any()) //55:3
                {
                    string __tmp39Line = " throws "; //56:1
                    if (__tmp39Line != null) __out.Append(__tmp39Line);
                    StringBuilder __tmp40 = new StringBuilder();
                    __tmp40.Append(SpringGeneratorUtil.GetExceptionList(op));
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
                    string __tmp41Line = " "; //56:51
                    if (__tmp41Line != null) __out.Append(__tmp41Line);
                }
                __out.Append("{"); //58:1
                __out.AppendLine(false); //58:2
                __out.Append("		// TODO implement method"); //59:1
                __out.AppendLine(false); //59:27
                __out.Append("		throw new UnsupportedOperationException(\"Not yet implemented.\");"); //60:1
                __out.AppendLine(false); //60:67
                __out.Append("	}"); //61:1
                __out.AppendLine(false); //61:3
            }
            __out.Append("}"); //63:1
            __out.AppendLine(false); //63:2
            return __out.ToString();
        }

        public string GenerateProxyInterfaceImplementation(Interface iface, string functionName, string bindingType) //68:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp2Line = "package "; //69:1
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
            string __tmp4Line = "."; //69:48
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
            string __tmp6Line = ";"; //69:63
            if (__tmp6Line != null) __out.Append(__tmp6Line);
            __out.AppendLine(false); //69:64
            __out.AppendLine(true); //70:1
            __out.Append("import org.springframework.beans.factory.annotation.Autowired;"); //71:1
            __out.AppendLine(false); //71:63
            __out.Append("import org.springframework.stereotype.Service;"); //72:1
            __out.AppendLine(false); //72:47
            __out.AppendLine(true); //73:1
            string __tmp8Line = "import "; //74:1
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
            string __tmp10Line = "."; //74:47
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
            string __tmp12Line = "."; //74:97
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
            string __tmp15Line = ";"; //74:123
            if (__tmp15Line != null) __out.Append(__tmp15Line);
            __out.AppendLine(false); //74:124
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
                    __out.AppendLine(false); //75:52
                }
            }
            __out.AppendLine(true); //76:1
            __out.Append("@Service"); //77:1
            __out.AppendLine(false); //77:9
            string __tmp19Line = "public class "; //78:1
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
            string __tmp22Line = "Impl implements "; //78:39
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
            string __tmp25Line = " {"; //78:80
            if (__tmp25Line != null) __out.Append(__tmp25Line);
            __out.AppendLine(false); //78:82
            __out.AppendLine(true); //79:1
            __out.Append("	@Autowired"); //80:1
            __out.AppendLine(false); //80:12
            string __tmp27Line = "	private "; //81:1
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
            string __tmp29Line = "Impl "; //81:22
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
            string __tmp31Line = "Impl;"; //81:53
            if (__tmp31Line != null) __out.Append(__tmp31Line);
            __out.AppendLine(false); //81:58
            var __loop5_results = 
                (from __loop5_var1 in __Enumerate((iface).GetEnumerator()) //83:7
                from op in __Enumerate((__loop5_var1.Operations).GetEnumerator()) //83:14
                select new { __loop5_var1 = __loop5_var1, op = op}
                ).ToList(); //83:2
            int __loop5_iteration = 0;
            foreach (var __tmp32 in __loop5_results)
            {
                ++__loop5_iteration;
                var __loop5_var1 = __tmp32.__loop5_var1;
                var op = __tmp32.op;
                __out.AppendLine(true); //84:1
                string __tmp34Line = "	public "; //85:1
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
                string __tmp36Line = " "; //85:39
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
                string __tmp38Line = "("; //85:63
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
                string __tmp40Line = ")"; //85:106
                if (__tmp40Line != null) __out.Append(__tmp40Line);
                if (op.Exceptions.Any()) //86:3
                {
                    string __tmp42Line = " throws "; //87:1
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
                    string __tmp44Line = " "; //87:51
                    if (__tmp44Line != null) __out.Append(__tmp44Line);
                }
                __out.Append("{"); //89:1
                __out.AppendLine(false); //89:2
                if (op.Result.Type.GetJavaName() != "void") //90:5
                {
                    string __tmp46Line = "		return "; //91:1
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
                    string __tmp48Line = "Impl."; //91:36
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
                    string __tmp50Line = "("; //91:64
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
                    string __tmp52Line = ");"; //91:111
                    if (__tmp52Line != null) __out.Append(__tmp52Line);
                    __out.AppendLine(false); //91:113
                }
                else //92:5
                {
                    string __tmp53Prefix = "		"; //93:1
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
                    string __tmp55Line = "Impl."; //93:29
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
                    string __tmp57Line = "("; //93:57
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
                    string __tmp59Line = ");"; //93:104
                    if (__tmp59Line != null) __out.Append(__tmp59Line);
                    __out.AppendLine(false); //93:106
                }
                __out.Append("	}"); //95:1
                __out.AppendLine(false); //95:3
            }
            __out.Append("}"); //97:1
            __out.AppendLine(false); //97:2
            return __out.ToString();
        }

        public string GenerateProxyForInterface(Interface iface, string bindingType, string currentComponent, string targetComponent) //102:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp2Line = "package "; //103:1
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
            string __tmp4Line = "."; //103:48
            if (__tmp4Line != null) __out.Append(__tmp4Line);
            StringBuilder __tmp5 = new StringBuilder();
            __tmp5.Append(SpringGeneratorUtil.Properties.proxyPackage);
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
            string __tmp6Line = ";"; //103:94
            if (__tmp6Line != null) __out.Append(__tmp6Line);
            __out.AppendLine(false); //103:95
            __out.AppendLine(true); //104:1
            __out.Append("import static org.springframework.hateoas.mvc.ControllerLinkBuilder.linkTo;"); //105:1
            __out.AppendLine(false); //105:76
            __out.Append("import static org.springframework.hateoas.mvc.ControllerLinkBuilder.methodOn;"); //106:1
            __out.AppendLine(false); //106:78
            __out.AppendLine(true); //107:1
            __out.Append("import org.springframework.hateoas.Link;"); //108:1
            __out.AppendLine(false); //108:41
            __out.Append("import org.springframework.http.HttpEntity;"); //109:1
            __out.AppendLine(false); //109:44
            __out.Append("import org.springframework.http.converter.json.MappingJackson2HttpMessageConverter;"); //110:1
            __out.AppendLine(false); //110:84
            __out.Append("import org.springframework.stereotype.Service;"); //111:1
            __out.AppendLine(false); //111:47
            __out.Append("import org.springframework.web.client.RestTemplate;"); //112:1
            __out.AppendLine(false); //112:52
            __out.Append("import org.springframework.web.context.request.RequestAttributes;"); //113:1
            __out.AppendLine(false); //113:66
            __out.Append("import org.springframework.web.context.request.RequestContextHolder;"); //114:1
            __out.AppendLine(false); //114:69
            __out.Append("import org.springframework.web.context.request.ServletRequestAttributes;"); //115:1
            __out.AppendLine(false); //115:73
            __out.AppendLine(true); //116:1
            __out.Append("import cinema.Configuration;"); //117:1
            __out.AppendLine(false); //117:29
            string __tmp8Line = "import "; //118:1
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
            string __tmp10Line = "."; //118:47
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
            string __tmp12Line = "."; //118:97
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
            string __tmp15Line = ";"; //118:123
            if (__tmp15Line != null) __out.Append(__tmp15Line);
            __out.AppendLine(false); //118:124
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
                    __out.AppendLine(false); //119:52
                }
            }
            __out.AppendLine(true); //120:1
            __out.Append("import javax.servlet.http.HttpServletRequest;"); //121:1
            __out.AppendLine(false); //121:46
            __out.Append("import java.util.Arrays;"); //122:1
            __out.AppendLine(false); //122:25
            __out.Append("import java.util.stream.Collectors;"); //123:1
            __out.AppendLine(false); //123:36
            __out.AppendLine(true); //124:1
            __out.Append("@Service"); //125:1
            __out.AppendLine(false); //125:9
            string __tmp19Line = "public class "; //126:1
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
            string __tmp22Line = "Proxy implements "; //126:39
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
            string __tmp25Line = " {"; //126:81
            if (__tmp25Line != null) __out.Append(__tmp25Line);
            __out.AppendLine(false); //126:83
            __out.AppendLine(true); //127:1
            __out.Append("	private RestTemplate restTemplate = new RestTemplate();"); //128:1
            __out.AppendLine(false); //128:57
            string __tmp27Line = "	private final String currentComponentName = \"Cinema-"; //129:1
            if (__tmp27Line != null) __out.Append(__tmp27Line);
            StringBuilder __tmp28 = new StringBuilder();
            __tmp28.Append(currentComponent);
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
            string __tmp29Line = "\";"; //129:72
            if (__tmp29Line != null) __out.Append(__tmp29Line);
            __out.AppendLine(false); //129:74
            string __tmp31Line = "    private final String targetComponentName = \"Cinema-"; //130:1
            if (__tmp31Line != null) __out.Append(__tmp31Line);
            StringBuilder __tmp32 = new StringBuilder();
            __tmp32.Append(targetComponent);
            using(StreamReader __tmp32Reader = new StreamReader(this.__ToStream(__tmp32.ToString())))
            {
                bool __tmp32_first = true;
                bool __tmp32_last = __tmp32Reader.EndOfStream;
                while(__tmp32_first || !__tmp32_last)
                {
                    __tmp32_first = false;
                    string __tmp32Line = __tmp32Reader.ReadLine();
                    __tmp32_last = __tmp32Reader.EndOfStream;
                    if (__tmp32Line != null) __out.Append(__tmp32Line);
                    if (!__tmp32_last) __out.AppendLine(true);
                }
            }
            string __tmp33Line = "\";"; //130:73
            if (__tmp33Line != null) __out.Append(__tmp33Line);
            __out.AppendLine(false); //130:75
            __out.AppendLine(true); //131:2
            var __loop6_results = 
                (from __loop6_var1 in __Enumerate((iface).GetEnumerator()) //132:7
                from op in __Enumerate((__loop6_var1.Operations).GetEnumerator()) //132:14
                select new { __loop6_var1 = __loop6_var1, op = op}
                ).ToList(); //132:2
            int __loop6_iteration = 0;
            foreach (var __tmp34 in __loop6_results)
            {
                ++__loop6_iteration;
                var __loop6_var1 = __tmp34.__loop6_var1;
                var op = __tmp34.op;
                string __tmp36Line = "	private String urlOf"; //133:1
                if (__tmp36Line != null) __out.Append(__tmp36Line);
                StringBuilder __tmp37 = new StringBuilder();
                __tmp37.Append(op.Name.ToPascalCase());
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
                string __tmp38Line = ";"; //133:46
                if (__tmp38Line != null) __out.Append(__tmp38Line);
                __out.AppendLine(false); //133:47
            }
            var __loop7_results = 
                (from __loop7_var1 in __Enumerate((iface).GetEnumerator()) //136:7
                from op in __Enumerate((__loop7_var1.Operations).GetEnumerator()) //136:14
                select new { __loop7_var1 = __loop7_var1, op = op}
                ).ToList(); //136:2
            int __loop7_iteration = 0;
            foreach (var __tmp39 in __loop7_results)
            {
                ++__loop7_iteration;
                var __loop7_var1 = __tmp39.__loop7_var1;
                var op = __tmp39.op;
                __out.AppendLine(true); //137:1
                string resultJavaName = op.Result.Type.GetJavaName(); //138:3
                __out.Append("	@Override"); //139:1
                __out.AppendLine(false); //139:11
                string __tmp41Line = "	public "; //140:1
                if (__tmp41Line != null) __out.Append(__tmp41Line);
                StringBuilder __tmp42 = new StringBuilder();
                __tmp42.Append(resultJavaName);
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
                string __tmp43Line = " "; //140:25
                if (__tmp43Line != null) __out.Append(__tmp43Line);
                StringBuilder __tmp44 = new StringBuilder();
                __tmp44.Append(op.Name.ToCamelCase());
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
                string __tmp45Line = "("; //140:49
                if (__tmp45Line != null) __out.Append(__tmp45Line);
                StringBuilder __tmp46 = new StringBuilder();
                __tmp46.Append(SpringGeneratorUtil.GetParameterList(op));
                using(StreamReader __tmp46Reader = new StreamReader(this.__ToStream(__tmp46.ToString())))
                {
                    bool __tmp46_first = true;
                    bool __tmp46_last = __tmp46Reader.EndOfStream;
                    while(__tmp46_first || !__tmp46_last)
                    {
                        __tmp46_first = false;
                        string __tmp46Line = __tmp46Reader.ReadLine();
                        __tmp46_last = __tmp46Reader.EndOfStream;
                        if (__tmp46Line != null) __out.Append(__tmp46Line);
                        if (!__tmp46_last) __out.AppendLine(true);
                    }
                }
                string __tmp47Line = ")"; //140:92
                if (__tmp47Line != null) __out.Append(__tmp47Line);
                if (op.Exceptions.Any()) //141:3
                {
                    string __tmp49Line = " throws "; //142:1
                    if (__tmp49Line != null) __out.Append(__tmp49Line);
                    StringBuilder __tmp50 = new StringBuilder();
                    __tmp50.Append(SpringGeneratorUtil.GetExceptionList(op));
                    using(StreamReader __tmp50Reader = new StreamReader(this.__ToStream(__tmp50.ToString())))
                    {
                        bool __tmp50_first = true;
                        bool __tmp50_last = __tmp50Reader.EndOfStream;
                        while(__tmp50_first || !__tmp50_last)
                        {
                            __tmp50_first = false;
                            string __tmp50Line = __tmp50Reader.ReadLine();
                            __tmp50_last = __tmp50Reader.EndOfStream;
                            if (__tmp50Line != null) __out.Append(__tmp50Line);
                            if (!__tmp50_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp51Line = " "; //142:51
                    if (__tmp51Line != null) __out.Append(__tmp51Line);
                }
                __out.Append("{"); //144:1
                __out.AppendLine(false); //144:2
                string __tmp53Line = "		String url = getUrlOf"; //145:1
                if (__tmp53Line != null) __out.Append(__tmp53Line);
                StringBuilder __tmp54 = new StringBuilder();
                __tmp54.Append(op.Name.ToPascalCase());
                using(StreamReader __tmp54Reader = new StreamReader(this.__ToStream(__tmp54.ToString())))
                {
                    bool __tmp54_first = true;
                    bool __tmp54_last = __tmp54Reader.EndOfStream;
                    while(__tmp54_first || !__tmp54_last)
                    {
                        __tmp54_first = false;
                        string __tmp54Line = __tmp54Reader.ReadLine();
                        __tmp54_last = __tmp54Reader.EndOfStream;
                        if (__tmp54Line != null) __out.Append(__tmp54Line);
                        if (!__tmp54_last) __out.AppendLine(true);
                    }
                }
                string __tmp55Line = "("; //145:48
                if (__tmp55Line != null) __out.Append(__tmp55Line);
                StringBuilder __tmp56 = new StringBuilder();
                __tmp56.Append(SpringGeneratorUtil.GetParameterNameList(op));
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
                string __tmp57Line = ");"; //145:95
                if (__tmp57Line != null) __out.Append(__tmp57Line);
                __out.AppendLine(false); //145:97
                string method = "POST"; //147:3
                if (op.Name.ToPascalCase().StartsWith("Get")) //148:3
                {
                    method = "GET";
                }
                string extraVariable = ""; //152:3
                if (method == "POST") //153:3
                {
                    extraVariable = "request, ";
                    __out.Append("		HttpEntity<?> request = null;"); //155:1
                    __out.AppendLine(false); //155:32
                    __out.Append("		this.restTemplate.getMessageConverters().add(new MappingJackson2HttpMessageConverter());"); //156:1
                    __out.AppendLine(false); //156:91
                    var __loop8_results = 
                        (from __loop8_var1 in __Enumerate((op).GetEnumerator()) //157:9
                        from param in __Enumerate((__loop8_var1.Parameters).GetEnumerator()) //157:13
                        where !param.Type.IsJavaPrimitiveType() //157:30
                        select new { __loop8_var1 = __loop8_var1, param = param}
                        ).ToList(); //157:4
                    int __loop8_iteration = 0;
                    foreach (var __tmp58 in __loop8_results)
                    {
                        ++__loop8_iteration;
                        var __loop8_var1 = __tmp58.__loop8_var1;
                        var param = __tmp58.param;
                        string __tmp60Line = "		request = new HttpEntity<"; //158:1
                        if (__tmp60Line != null) __out.Append(__tmp60Line);
                        StringBuilder __tmp61 = new StringBuilder();
                        __tmp61.Append(param.Type.GetJavaName());
                        using(StreamReader __tmp61Reader = new StreamReader(this.__ToStream(__tmp61.ToString())))
                        {
                            bool __tmp61_first = true;
                            bool __tmp61_last = __tmp61Reader.EndOfStream;
                            while(__tmp61_first || !__tmp61_last)
                            {
                                __tmp61_first = false;
                                string __tmp61Line = __tmp61Reader.ReadLine();
                                __tmp61_last = __tmp61Reader.EndOfStream;
                                if (__tmp61Line != null) __out.Append(__tmp61Line);
                                if (!__tmp61_last) __out.AppendLine(true);
                            }
                        }
                        string __tmp62Line = ">("; //158:54
                        if (__tmp62Line != null) __out.Append(__tmp62Line);
                        StringBuilder __tmp63 = new StringBuilder();
                        __tmp63.Append(param.Name);
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
                        string __tmp64Line = ");"; //158:68
                        if (__tmp64Line != null) __out.Append(__tmp64Line);
                        __out.AppendLine(false); //158:70
                    }
                }
                ArrayType array = op.Result.Type as ArrayType; //162:3
                if (array != null) //163:3
                {
                    string __tmp65Prefix = "		"; //164:1
                    StringBuilder __tmp66 = new StringBuilder();
                    __tmp66.Append(array.InnerType.GetJavaName());
                    using(StreamReader __tmp66Reader = new StreamReader(this.__ToStream(__tmp66.ToString())))
                    {
                        bool __tmp66_first = true;
                        bool __tmp66_last = __tmp66Reader.EndOfStream;
                        while(__tmp66_first || !__tmp66_last)
                        {
                            __tmp66_first = false;
                            string __tmp66Line = __tmp66Reader.ReadLine();
                            __tmp66_last = __tmp66Reader.EndOfStream;
                            __out.Append(__tmp65Prefix);
                            if (__tmp66Line != null) __out.Append(__tmp66Line);
                            if (!__tmp66_last) __out.AppendLine(true);
                        }
                    }
                    StringBuilder __tmp67 = new StringBuilder();
                    __tmp67.Append("[]");
                    using(StreamReader __tmp67Reader = new StreamReader(this.__ToStream(__tmp67.ToString())))
                    {
                        bool __tmp67_first = true;
                        bool __tmp67_last = __tmp67Reader.EndOfStream;
                        while(__tmp67_first || !__tmp67_last)
                        {
                            __tmp67_first = false;
                            string __tmp67Line = __tmp67Reader.ReadLine();
                            __tmp67_last = __tmp67Reader.EndOfStream;
                            if (__tmp67Line != null) __out.Append(__tmp67Line);
                            if (!__tmp67_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp68Line = " response = restTemplate."; //164:40
                    if (__tmp68Line != null) __out.Append(__tmp68Line);
                    StringBuilder __tmp69 = new StringBuilder();
                    __tmp69.Append(method.ToLower());
                    using(StreamReader __tmp69Reader = new StreamReader(this.__ToStream(__tmp69.ToString())))
                    {
                        bool __tmp69_first = true;
                        bool __tmp69_last = __tmp69Reader.EndOfStream;
                        while(__tmp69_first || !__tmp69_last)
                        {
                            __tmp69_first = false;
                            string __tmp69Line = __tmp69Reader.ReadLine();
                            __tmp69_last = __tmp69Reader.EndOfStream;
                            if (__tmp69Line != null) __out.Append(__tmp69Line);
                            if (!__tmp69_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp70Line = "ForObject(url, "; //164:83
                    if (__tmp70Line != null) __out.Append(__tmp70Line);
                    StringBuilder __tmp71 = new StringBuilder();
                    __tmp71.Append(extraVariable);
                    using(StreamReader __tmp71Reader = new StreamReader(this.__ToStream(__tmp71.ToString())))
                    {
                        bool __tmp71_first = true;
                        bool __tmp71_last = __tmp71Reader.EndOfStream;
                        while(__tmp71_first || !__tmp71_last)
                        {
                            __tmp71_first = false;
                            string __tmp71Line = __tmp71Reader.ReadLine();
                            __tmp71_last = __tmp71Reader.EndOfStream;
                            if (__tmp71Line != null) __out.Append(__tmp71Line);
                            if (!__tmp71_last) __out.AppendLine(true);
                        }
                    }
                    StringBuilder __tmp72 = new StringBuilder();
                    __tmp72.Append(array.InnerType.GetJavaName());
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
                    StringBuilder __tmp73 = new StringBuilder();
                    __tmp73.Append("[]");
                    using(StreamReader __tmp73Reader = new StreamReader(this.__ToStream(__tmp73.ToString())))
                    {
                        bool __tmp73_first = true;
                        bool __tmp73_last = __tmp73Reader.EndOfStream;
                        while(__tmp73_first || !__tmp73_last)
                        {
                            __tmp73_first = false;
                            string __tmp73Line = __tmp73Reader.ReadLine();
                            __tmp73_last = __tmp73Reader.EndOfStream;
                            if (__tmp73Line != null) __out.Append(__tmp73Line);
                            if (!__tmp73_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp74Line = ".class);"; //164:150
                    if (__tmp74Line != null) __out.Append(__tmp74Line);
                    __out.AppendLine(false); //164:158
                }
                else if (resultJavaName != "void") //165:3
                {
                    string __tmp75Prefix = "		"; //166:1
                    StringBuilder __tmp76 = new StringBuilder();
                    __tmp76.Append(resultJavaName);
                    using(StreamReader __tmp76Reader = new StreamReader(this.__ToStream(__tmp76.ToString())))
                    {
                        bool __tmp76_first = true;
                        bool __tmp76_last = __tmp76Reader.EndOfStream;
                        while(__tmp76_first || !__tmp76_last)
                        {
                            __tmp76_first = false;
                            string __tmp76Line = __tmp76Reader.ReadLine();
                            __tmp76_last = __tmp76Reader.EndOfStream;
                            __out.Append(__tmp75Prefix);
                            if (__tmp76Line != null) __out.Append(__tmp76Line);
                            if (!__tmp76_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp77Line = " response = restTemplate."; //166:19
                    if (__tmp77Line != null) __out.Append(__tmp77Line);
                    StringBuilder __tmp78 = new StringBuilder();
                    __tmp78.Append(method.ToLower());
                    using(StreamReader __tmp78Reader = new StreamReader(this.__ToStream(__tmp78.ToString())))
                    {
                        bool __tmp78_first = true;
                        bool __tmp78_last = __tmp78Reader.EndOfStream;
                        while(__tmp78_first || !__tmp78_last)
                        {
                            __tmp78_first = false;
                            string __tmp78Line = __tmp78Reader.ReadLine();
                            __tmp78_last = __tmp78Reader.EndOfStream;
                            if (__tmp78Line != null) __out.Append(__tmp78Line);
                            if (!__tmp78_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp79Line = "ForObject(url, "; //166:62
                    if (__tmp79Line != null) __out.Append(__tmp79Line);
                    StringBuilder __tmp80 = new StringBuilder();
                    __tmp80.Append(extraVariable);
                    using(StreamReader __tmp80Reader = new StreamReader(this.__ToStream(__tmp80.ToString())))
                    {
                        bool __tmp80_first = true;
                        bool __tmp80_last = __tmp80Reader.EndOfStream;
                        while(__tmp80_first || !__tmp80_last)
                        {
                            __tmp80_first = false;
                            string __tmp80Line = __tmp80Reader.ReadLine();
                            __tmp80_last = __tmp80Reader.EndOfStream;
                            if (__tmp80Line != null) __out.Append(__tmp80Line);
                            if (!__tmp80_last) __out.AppendLine(true);
                        }
                    }
                    StringBuilder __tmp81 = new StringBuilder();
                    __tmp81.Append(resultJavaName);
                    using(StreamReader __tmp81Reader = new StreamReader(this.__ToStream(__tmp81.ToString())))
                    {
                        bool __tmp81_first = true;
                        bool __tmp81_last = __tmp81Reader.EndOfStream;
                        while(__tmp81_first || !__tmp81_last)
                        {
                            __tmp81_first = false;
                            string __tmp81Line = __tmp81Reader.ReadLine();
                            __tmp81_last = __tmp81Reader.EndOfStream;
                            if (__tmp81Line != null) __out.Append(__tmp81Line);
                            if (!__tmp81_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp82Line = ".class);"; //166:108
                    if (__tmp82Line != null) __out.Append(__tmp82Line);
                    __out.AppendLine(false); //166:116
                }
                else //167:3
                {
                    string __tmp84Line = "		restTemplate."; //168:1
                    if (__tmp84Line != null) __out.Append(__tmp84Line);
                    StringBuilder __tmp85 = new StringBuilder();
                    __tmp85.Append(method.ToLower());
                    using(StreamReader __tmp85Reader = new StreamReader(this.__ToStream(__tmp85.ToString())))
                    {
                        bool __tmp85_first = true;
                        bool __tmp85_last = __tmp85Reader.EndOfStream;
                        while(__tmp85_first || !__tmp85_last)
                        {
                            __tmp85_first = false;
                            string __tmp85Line = __tmp85Reader.ReadLine();
                            __tmp85_last = __tmp85Reader.EndOfStream;
                            if (__tmp85Line != null) __out.Append(__tmp85Line);
                            if (!__tmp85_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp86Line = "ForObject(url, "; //168:34
                    if (__tmp86Line != null) __out.Append(__tmp86Line);
                    StringBuilder __tmp87 = new StringBuilder();
                    __tmp87.Append(extraVariable);
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
                    string __tmp88Line = "Object.class);"; //168:64
                    if (__tmp88Line != null) __out.Append(__tmp88Line);
                    __out.AppendLine(false); //168:78
                }
                if (array != null) //171:3
                {
                    __out.Append("		return Arrays.stream(response).collect(Collectors.toList());"); //172:1
                    __out.AppendLine(false); //172:63
                }
                else if (resultJavaName != "void") //173:3
                {
                    __out.Append("		return response;"); //174:1
                    __out.AppendLine(false); //174:19
                }
                else //175:3
                {
                    __out.Append("		return;"); //176:1
                    __out.AppendLine(false); //176:10
                }
                __out.Append("	}"); //178:1
                __out.AppendLine(false); //178:3
            }
            var __loop9_results = 
                (from __loop9_var1 in __Enumerate((iface).GetEnumerator()) //181:7
                from op in __Enumerate((__loop9_var1.Operations).GetEnumerator()) //181:14
                select new { __loop9_var1 = __loop9_var1, op = op}
                ).ToList(); //181:2
            int __loop9_iteration = 0;
            foreach (var __tmp89 in __loop9_results)
            {
                ++__loop9_iteration;
                var __loop9_var1 = __tmp89.__loop9_var1;
                var op = __tmp89.op;
                __out.AppendLine(true); //182:2
                string __tmp91Line = "	private String getUrlOf"; //183:1
                if (__tmp91Line != null) __out.Append(__tmp91Line);
                StringBuilder __tmp92 = new StringBuilder();
                __tmp92.Append(op.Name.ToPascalCase());
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
                string __tmp93Line = "("; //183:49
                if (__tmp93Line != null) __out.Append(__tmp93Line);
                StringBuilder __tmp94 = new StringBuilder();
                __tmp94.Append(SpringGeneratorUtil.GetParameterList(op));
                using(StreamReader __tmp94Reader = new StreamReader(this.__ToStream(__tmp94.ToString())))
                {
                    bool __tmp94_first = true;
                    bool __tmp94_last = __tmp94Reader.EndOfStream;
                    while(__tmp94_first || !__tmp94_last)
                    {
                        __tmp94_first = false;
                        string __tmp94Line = __tmp94Reader.ReadLine();
                        __tmp94_last = __tmp94Reader.EndOfStream;
                        if (__tmp94Line != null) __out.Append(__tmp94Line);
                        if (!__tmp94_last) __out.AppendLine(true);
                    }
                }
                string __tmp95Line = ") {"; //183:92
                if (__tmp95Line != null) __out.Append(__tmp95Line);
                __out.AppendLine(false); //183:95
                string __tmp97Line = "        if (this.urlOf"; //184:1
                if (__tmp97Line != null) __out.Append(__tmp97Line);
                StringBuilder __tmp98 = new StringBuilder();
                __tmp98.Append(op.Name.ToPascalCase());
                using(StreamReader __tmp98Reader = new StreamReader(this.__ToStream(__tmp98.ToString())))
                {
                    bool __tmp98_first = true;
                    bool __tmp98_last = __tmp98Reader.EndOfStream;
                    while(__tmp98_first || !__tmp98_last)
                    {
                        __tmp98_first = false;
                        string __tmp98Line = __tmp98Reader.ReadLine();
                        __tmp98_last = __tmp98Reader.EndOfStream;
                        if (__tmp98Line != null) __out.Append(__tmp98Line);
                        if (!__tmp98_last) __out.AppendLine(true);
                    }
                }
                string __tmp99Line = " != null) {"; //184:47
                if (__tmp99Line != null) __out.Append(__tmp99Line);
                __out.AppendLine(false); //184:58
                string __tmp101Line = "            return this.urlOf"; //185:1
                if (__tmp101Line != null) __out.Append(__tmp101Line);
                StringBuilder __tmp102 = new StringBuilder();
                __tmp102.Append(op.Name.ToPascalCase());
                using(StreamReader __tmp102Reader = new StreamReader(this.__ToStream(__tmp102.ToString())))
                {
                    bool __tmp102_first = true;
                    bool __tmp102_last = __tmp102Reader.EndOfStream;
                    while(__tmp102_first || !__tmp102_last)
                    {
                        __tmp102_first = false;
                        string __tmp102Line = __tmp102Reader.ReadLine();
                        __tmp102_last = __tmp102Reader.EndOfStream;
                        if (__tmp102Line != null) __out.Append(__tmp102Line);
                        if (!__tmp102_last) __out.AppendLine(true);
                    }
                }
                string __tmp103Line = ";"; //185:54
                if (__tmp103Line != null) __out.Append(__tmp103Line);
                __out.AppendLine(false); //185:55
                __out.Append("        }"); //186:1
                __out.AppendLine(false); //186:10
                __out.AppendLine(true); //187:3
                __out.Append("        // eg.: http://localhost/localapp-1.0/getMoviesFromReservation/"); //188:1
                __out.AppendLine(false); //188:72
                if (op.Result.Type.GetJavaName() == "void") //189:3
                {
                    __out.Append("		String url = null;"); //190:1
                    __out.AppendLine(false); //190:21
                    __out.Append("		try {"); //191:1
                    __out.AppendLine(false); //191:8
                    string __tmp105Line = "			java.lang.reflect.Method method = "; //192:1
                    if (__tmp105Line != null) __out.Append(__tmp105Line);
                    StringBuilder __tmp106 = new StringBuilder();
                    __tmp106.Append(iface.Name + bindingType);
                    using(StreamReader __tmp106Reader = new StreamReader(this.__ToStream(__tmp106.ToString())))
                    {
                        bool __tmp106_first = true;
                        bool __tmp106_last = __tmp106Reader.EndOfStream;
                        while(__tmp106_first || !__tmp106_last)
                        {
                            __tmp106_first = false;
                            string __tmp106Line = __tmp106Reader.ReadLine();
                            __tmp106_last = __tmp106Reader.EndOfStream;
                            if (__tmp106Line != null) __out.Append(__tmp106Line);
                            if (!__tmp106_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp107Line = ".class.getMethod(\""; //192:64
                    if (__tmp107Line != null) __out.Append(__tmp107Line);
                    StringBuilder __tmp108 = new StringBuilder();
                    __tmp108.Append(op.Name.ToCamelCase());
                    using(StreamReader __tmp108Reader = new StreamReader(this.__ToStream(__tmp108.ToString())))
                    {
                        bool __tmp108_first = true;
                        bool __tmp108_last = __tmp108Reader.EndOfStream;
                        while(__tmp108_first || !__tmp108_last)
                        {
                            __tmp108_first = false;
                            string __tmp108Line = __tmp108Reader.ReadLine();
                            __tmp108_last = __tmp108Reader.EndOfStream;
                            if (__tmp108Line != null) __out.Append(__tmp108Line);
                            if (!__tmp108_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp109Line = "\", "; //192:105
                    if (__tmp109Line != null) __out.Append(__tmp109Line);
                    StringBuilder __tmp110 = new StringBuilder();
                    __tmp110.Append(SpringGeneratorUtil.GetParameterTypeList(op));
                    using(StreamReader __tmp110Reader = new StreamReader(this.__ToStream(__tmp110.ToString())))
                    {
                        bool __tmp110_first = true;
                        bool __tmp110_last = __tmp110Reader.EndOfStream;
                        while(__tmp110_first || !__tmp110_last)
                        {
                            __tmp110_first = false;
                            string __tmp110Line = __tmp110Reader.ReadLine();
                            __tmp110_last = __tmp110Reader.EndOfStream;
                            if (__tmp110Line != null) __out.Append(__tmp110Line);
                            if (!__tmp110_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp111Line = ");"; //192:154
                    if (__tmp111Line != null) __out.Append(__tmp111Line);
                    __out.AppendLine(false); //192:156
                    string __tmp113Line = "			Link link = linkTo("; //193:1
                    if (__tmp113Line != null) __out.Append(__tmp113Line);
                    StringBuilder __tmp114 = new StringBuilder();
                    __tmp114.Append(iface.Name + bindingType);
                    using(StreamReader __tmp114Reader = new StreamReader(this.__ToStream(__tmp114.ToString())))
                    {
                        bool __tmp114_first = true;
                        bool __tmp114_last = __tmp114Reader.EndOfStream;
                        while(__tmp114_first || !__tmp114_last)
                        {
                            __tmp114_first = false;
                            string __tmp114Line = __tmp114Reader.ReadLine();
                            __tmp114_last = __tmp114Reader.EndOfStream;
                            if (__tmp114Line != null) __out.Append(__tmp114Line);
                            if (!__tmp114_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp115Line = ".class, method, "; //193:49
                    if (__tmp115Line != null) __out.Append(__tmp115Line);
                    StringBuilder __tmp116 = new StringBuilder();
                    __tmp116.Append(SpringGeneratorUtil.GetParameterNameList(op));
                    using(StreamReader __tmp116Reader = new StreamReader(this.__ToStream(__tmp116.ToString())))
                    {
                        bool __tmp116_first = true;
                        bool __tmp116_last = __tmp116Reader.EndOfStream;
                        while(__tmp116_first || !__tmp116_last)
                        {
                            __tmp116_first = false;
                            string __tmp116Line = __tmp116Reader.ReadLine();
                            __tmp116_last = __tmp116Reader.EndOfStream;
                            if (__tmp116Line != null) __out.Append(__tmp116Line);
                            if (!__tmp116_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp117Line = ").withSelfRel();"; //193:111
                    if (__tmp117Line != null) __out.Append(__tmp117Line);
                    __out.AppendLine(false); //193:127
                    __out.Append("			url = link.getHref();"); //194:1
                    __out.AppendLine(false); //194:25
                    var __loop10_results = 
                        (from __loop10_var1 in __Enumerate((op).GetEnumerator()) //195:9
                        from ex in __Enumerate((__loop10_var1.Exceptions).GetEnumerator()) //195:13
                        select new { __loop10_var1 = __loop10_var1, ex = ex}
                        ).ToList(); //195:4
                    int __loop10_iteration = 0;
                    foreach (var __tmp118 in __loop10_results)
                    {
                        ++__loop10_iteration;
                        var __loop10_var1 = __tmp118.__loop10_var1;
                        var ex = __tmp118.ex;
                        __out.Append("		} catch (NoSuchMethodException e) {"); //196:1
                        __out.AppendLine(false); //196:38
                        __out.Append("			// TODO handle execption properly"); //197:1
                        __out.AppendLine(false); //197:37
                        __out.Append("			throw new RuntimeException(e);"); //198:1
                        __out.AppendLine(false); //198:34
                    }
                    __out.Append("		}"); //200:1
                    __out.AppendLine(false); //200:4
                }
                else if (op.Exceptions.Any()) //202:3
                {
                    __out.Append("		String url = null;"); //203:1
                    __out.AppendLine(false); //203:21
                    __out.Append("		try {"); //204:1
                    __out.AppendLine(false); //204:8
                    string __tmp120Line = "			Link link = linkTo(methodOn("; //205:1
                    if (__tmp120Line != null) __out.Append(__tmp120Line);
                    StringBuilder __tmp121 = new StringBuilder();
                    __tmp121.Append(iface.Name + bindingType);
                    using(StreamReader __tmp121Reader = new StreamReader(this.__ToStream(__tmp121.ToString())))
                    {
                        bool __tmp121_first = true;
                        bool __tmp121_last = __tmp121Reader.EndOfStream;
                        while(__tmp121_first || !__tmp121_last)
                        {
                            __tmp121_first = false;
                            string __tmp121Line = __tmp121Reader.ReadLine();
                            __tmp121_last = __tmp121Reader.EndOfStream;
                            if (__tmp121Line != null) __out.Append(__tmp121Line);
                            if (!__tmp121_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp122Line = ".class)."; //205:58
                    if (__tmp122Line != null) __out.Append(__tmp122Line);
                    StringBuilder __tmp123 = new StringBuilder();
                    __tmp123.Append(op.Name.ToCamelCase());
                    using(StreamReader __tmp123Reader = new StreamReader(this.__ToStream(__tmp123.ToString())))
                    {
                        bool __tmp123_first = true;
                        bool __tmp123_last = __tmp123Reader.EndOfStream;
                        while(__tmp123_first || !__tmp123_last)
                        {
                            __tmp123_first = false;
                            string __tmp123Line = __tmp123Reader.ReadLine();
                            __tmp123_last = __tmp123Reader.EndOfStream;
                            if (__tmp123Line != null) __out.Append(__tmp123Line);
                            if (!__tmp123_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp124Line = "("; //205:89
                    if (__tmp124Line != null) __out.Append(__tmp124Line);
                    StringBuilder __tmp125 = new StringBuilder();
                    __tmp125.Append(SpringGeneratorUtil.GetParameterNameList(op));
                    using(StreamReader __tmp125Reader = new StreamReader(this.__ToStream(__tmp125.ToString())))
                    {
                        bool __tmp125_first = true;
                        bool __tmp125_last = __tmp125Reader.EndOfStream;
                        while(__tmp125_first || !__tmp125_last)
                        {
                            __tmp125_first = false;
                            string __tmp125Line = __tmp125Reader.ReadLine();
                            __tmp125_last = __tmp125Reader.EndOfStream;
                            if (__tmp125Line != null) __out.Append(__tmp125Line);
                            if (!__tmp125_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp126Line = ")).withSelfRel();"; //205:136
                    if (__tmp126Line != null) __out.Append(__tmp126Line);
                    __out.AppendLine(false); //205:153
                    __out.Append("			url = link.getHref();"); //206:1
                    __out.AppendLine(false); //206:25
                    var __loop11_results = 
                        (from __loop11_var1 in __Enumerate((op).GetEnumerator()) //207:9
                        from ex in __Enumerate((__loop11_var1.Exceptions).GetEnumerator()) //207:13
                        select new { __loop11_var1 = __loop11_var1, ex = ex}
                        ).ToList(); //207:4
                    int __loop11_iteration = 0;
                    foreach (var __tmp127 in __loop11_results)
                    {
                        ++__loop11_iteration;
                        var __loop11_var1 = __tmp127.__loop11_var1;
                        var ex = __tmp127.ex;
                        string __tmp129Line = "		} catch ("; //208:1
                        if (__tmp129Line != null) __out.Append(__tmp129Line);
                        StringBuilder __tmp130 = new StringBuilder();
                        __tmp130.Append(ex.GetJavaName());
                        using(StreamReader __tmp130Reader = new StreamReader(this.__ToStream(__tmp130.ToString())))
                        {
                            bool __tmp130_first = true;
                            bool __tmp130_last = __tmp130Reader.EndOfStream;
                            while(__tmp130_first || !__tmp130_last)
                            {
                                __tmp130_first = false;
                                string __tmp130Line = __tmp130Reader.ReadLine();
                                __tmp130_last = __tmp130Reader.EndOfStream;
                                if (__tmp130Line != null) __out.Append(__tmp130Line);
                                if (!__tmp130_last) __out.AppendLine(true);
                            }
                        }
                        string __tmp131Line = " e) {"; //208:30
                        if (__tmp131Line != null) __out.Append(__tmp131Line);
                        __out.AppendLine(false); //208:35
                        __out.Append("			// TODO handle execption properly"); //209:1
                        __out.AppendLine(false); //209:37
                        __out.Append("			throw new RuntimeException(e);"); //210:1
                        __out.AppendLine(false); //210:34
                    }
                    __out.Append("		}"); //212:1
                    __out.AppendLine(false); //212:4
                }
                else //213:3
                {
                    string __tmp133Line = "		Link link = linkTo(methodOn("; //214:1
                    if (__tmp133Line != null) __out.Append(__tmp133Line);
                    StringBuilder __tmp134 = new StringBuilder();
                    __tmp134.Append(iface.Name + bindingType);
                    using(StreamReader __tmp134Reader = new StreamReader(this.__ToStream(__tmp134.ToString())))
                    {
                        bool __tmp134_first = true;
                        bool __tmp134_last = __tmp134Reader.EndOfStream;
                        while(__tmp134_first || !__tmp134_last)
                        {
                            __tmp134_first = false;
                            string __tmp134Line = __tmp134Reader.ReadLine();
                            __tmp134_last = __tmp134Reader.EndOfStream;
                            if (__tmp134Line != null) __out.Append(__tmp134Line);
                            if (!__tmp134_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp135Line = ".class)."; //214:57
                    if (__tmp135Line != null) __out.Append(__tmp135Line);
                    StringBuilder __tmp136 = new StringBuilder();
                    __tmp136.Append(op.Name.ToCamelCase());
                    using(StreamReader __tmp136Reader = new StreamReader(this.__ToStream(__tmp136.ToString())))
                    {
                        bool __tmp136_first = true;
                        bool __tmp136_last = __tmp136Reader.EndOfStream;
                        while(__tmp136_first || !__tmp136_last)
                        {
                            __tmp136_first = false;
                            string __tmp136Line = __tmp136Reader.ReadLine();
                            __tmp136_last = __tmp136Reader.EndOfStream;
                            if (__tmp136Line != null) __out.Append(__tmp136Line);
                            if (!__tmp136_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp137Line = "("; //214:88
                    if (__tmp137Line != null) __out.Append(__tmp137Line);
                    StringBuilder __tmp138 = new StringBuilder();
                    __tmp138.Append(SpringGeneratorUtil.GetParameterNameList(op));
                    using(StreamReader __tmp138Reader = new StreamReader(this.__ToStream(__tmp138.ToString())))
                    {
                        bool __tmp138_first = true;
                        bool __tmp138_last = __tmp138Reader.EndOfStream;
                        while(__tmp138_first || !__tmp138_last)
                        {
                            __tmp138_first = false;
                            string __tmp138Line = __tmp138Reader.ReadLine();
                            __tmp138_last = __tmp138Reader.EndOfStream;
                            if (__tmp138Line != null) __out.Append(__tmp138Line);
                            if (!__tmp138_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp139Line = ")).withSelfRel();"; //214:135
                    if (__tmp139Line != null) __out.Append(__tmp139Line);
                    __out.AppendLine(false); //214:152
                    __out.Append("		String url = link.getHref();"); //215:1
                    __out.AppendLine(false); //215:31
                }
                __out.Append("        RequestAttributes requestAttributes = RequestContextHolder.currentRequestAttributes();"); //217:1
                __out.AppendLine(false); //217:95
                __out.Append("        HttpServletRequest curRequest = ((ServletRequestAttributes) requestAttributes).getRequest();"); //218:1
                __out.AppendLine(false); //218:101
                __out.Append("        String serverName = curRequest.getServerName();"); //219:1
                __out.AppendLine(false); //219:56
                __out.Append("        String serverPort = String.valueOf(curRequest.getServerPort());"); //220:1
                __out.AppendLine(false); //220:72
                __out.AppendLine(true); //221:3
                __out.Append("        // eg.: http://remotehost/remoteapp-1.0/getMoviesFromReservation/"); //222:1
                __out.AppendLine(false); //222:74
                string __tmp141Line = "        url = url.replace(serverName, Configuration.getString(\""; //223:1
                if (__tmp141Line != null) __out.Append(__tmp141Line);
                StringBuilder __tmp142 = new StringBuilder();
                __tmp142.Append(targetComponent);
                using(StreamReader __tmp142Reader = new StreamReader(this.__ToStream(__tmp142.ToString())))
                {
                    bool __tmp142_first = true;
                    bool __tmp142_last = __tmp142Reader.EndOfStream;
                    while(__tmp142_first || !__tmp142_last)
                    {
                        __tmp142_first = false;
                        string __tmp142Line = __tmp142Reader.ReadLine();
                        __tmp142_last = __tmp142Reader.EndOfStream;
                        if (__tmp142Line != null) __out.Append(__tmp142Line);
                        if (!__tmp142_last) __out.AppendLine(true);
                    }
                }
                StringBuilder __tmp143 = new StringBuilder();
                __tmp143.Append(bindingType);
                using(StreamReader __tmp143Reader = new StreamReader(this.__ToStream(__tmp143.ToString())))
                {
                    bool __tmp143_first = true;
                    bool __tmp143_last = __tmp143Reader.EndOfStream;
                    while(__tmp143_first || !__tmp143_last)
                    {
                        __tmp143_first = false;
                        string __tmp143Line = __tmp143Reader.ReadLine();
                        __tmp143_last = __tmp143Reader.EndOfStream;
                        if (__tmp143Line != null) __out.Append(__tmp143Line);
                        if (!__tmp143_last) __out.AppendLine(true);
                    }
                }
                string __tmp144Line = "Server\"));"; //223:94
                if (__tmp144Line != null) __out.Append(__tmp144Line);
                __out.AppendLine(false); //223:104
                string __tmp146Line = "        url = url.replace(\":\" + serverPort, \":\" + Configuration.getString(\""; //224:1
                if (__tmp146Line != null) __out.Append(__tmp146Line);
                StringBuilder __tmp147 = new StringBuilder();
                __tmp147.Append(targetComponent);
                using(StreamReader __tmp147Reader = new StreamReader(this.__ToStream(__tmp147.ToString())))
                {
                    bool __tmp147_first = true;
                    bool __tmp147_last = __tmp147Reader.EndOfStream;
                    while(__tmp147_first || !__tmp147_last)
                    {
                        __tmp147_first = false;
                        string __tmp147Line = __tmp147Reader.ReadLine();
                        __tmp147_last = __tmp147Reader.EndOfStream;
                        if (__tmp147Line != null) __out.Append(__tmp147Line);
                        if (!__tmp147_last) __out.AppendLine(true);
                    }
                }
                StringBuilder __tmp148 = new StringBuilder();
                __tmp148.Append(bindingType);
                using(StreamReader __tmp148Reader = new StreamReader(this.__ToStream(__tmp148.ToString())))
                {
                    bool __tmp148_first = true;
                    bool __tmp148_last = __tmp148Reader.EndOfStream;
                    while(__tmp148_first || !__tmp148_last)
                    {
                        __tmp148_first = false;
                        string __tmp148Line = __tmp148Reader.ReadLine();
                        __tmp148_last = __tmp148Reader.EndOfStream;
                        if (__tmp148Line != null) __out.Append(__tmp148Line);
                        if (!__tmp148_last) __out.AppendLine(true);
                    }
                }
                string __tmp149Line = "Port\"));"; //224:106
                if (__tmp149Line != null) __out.Append(__tmp149Line);
                __out.AppendLine(false); //224:114
                __out.Append("        url = url.replace(currentComponentName, targetComponentName);"); //225:1
                __out.AppendLine(false); //225:70
                __out.AppendLine(true); //226:3
                string __tmp151Line = "        this.urlOf"; //227:1
                if (__tmp151Line != null) __out.Append(__tmp151Line);
                StringBuilder __tmp152 = new StringBuilder();
                __tmp152.Append(op.Name.ToPascalCase());
                using(StreamReader __tmp152Reader = new StreamReader(this.__ToStream(__tmp152.ToString())))
                {
                    bool __tmp152_first = true;
                    bool __tmp152_last = __tmp152Reader.EndOfStream;
                    while(__tmp152_first || !__tmp152_last)
                    {
                        __tmp152_first = false;
                        string __tmp152Line = __tmp152Reader.ReadLine();
                        __tmp152_last = __tmp152Reader.EndOfStream;
                        if (__tmp152Line != null) __out.Append(__tmp152Line);
                        if (!__tmp152_last) __out.AppendLine(true);
                    }
                }
                string __tmp153Line = " = url;"; //227:43
                if (__tmp153Line != null) __out.Append(__tmp153Line);
                __out.AppendLine(false); //227:50
                __out.Append("        return url;"); //228:1
                __out.AppendLine(false); //228:20
                __out.Append("    }"); //229:1
                __out.AppendLine(false); //229:6
            }
            __out.Append("}"); //231:1
            __out.AppendLine(false); //231:2
            return __out.ToString();
        }

        public string GenerateCrudRepositoryCopy(string namespaceName, string entityName, string bindingType) //236:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp2Line = "package "; //237:1
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
            string __tmp4Line = "."; //237:34
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
            string __tmp6Line = ";"; //237:84
            if (__tmp6Line != null) __out.Append(__tmp6Line);
            __out.AppendLine(false); //237:85
            __out.AppendLine(true); //238:1
            string __tmp8Line = "import "; //239:1
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
            string __tmp10Line = "."; //239:33
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
            string __tmp12Line = "."; //239:80
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
            string __tmp14Line = ";"; //239:93
            if (__tmp14Line != null) __out.Append(__tmp14Line);
            __out.AppendLine(false); //239:94
            __out.AppendLine(true); //240:1
            StringBuilder __tmp16 = new StringBuilder();
            __tmp16.Append(GenerateImportsForBinding(bindingType));
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
                    __out.AppendLine(false); //241:41
                }
            }
            __out.AppendLine(true); //242:1
            StringBuilder __tmp18 = new StringBuilder();
            __tmp18.Append(InterfaceAnnotation(bindingType));
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
                    __out.AppendLine(false); //243:35
                }
            }
            string __tmp20Line = "public interface "; //244:1
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
            string __tmp22Line = "Repository"; //244:30
            if (__tmp22Line != null) __out.Append(__tmp22Line);
            StringBuilder __tmp23 = new StringBuilder();
            __tmp23.Append(bindingType);
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
            string __tmp24Line = " {"; //244:53
            if (__tmp24Line != null) __out.Append(__tmp24Line);
            __out.AppendLine(false); //244:55
            string __tmp26Line = "	// should copy CrudRepository<"; //245:1
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
            string __tmp28Line = ", Long>"; //245:44
            if (__tmp28Line != null) __out.Append(__tmp28Line);
            __out.AppendLine(false); //245:51
            if (bindingType == "Rest") //247:3
            {
                StringBuilder __tmp30 = new StringBuilder();
                __tmp30.Append(GenerateCrudMethodsForRest(entityName));
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
                        __out.AppendLine(false); //248:41
                    }
                }
            }
            else //249:3
            {
                __out.AppendLine(true); //250:1
                __out.Append("	public long count();"); //251:1
                __out.AppendLine(false); //251:22
                __out.AppendLine(true); //252:1
                __out.Append("	public void delete(Long id);"); //253:1
                __out.AppendLine(false); //253:30
                __out.AppendLine(true); //254:1
                string __tmp32Line = "	public void delete("; //255:1
                if (__tmp32Line != null) __out.Append(__tmp32Line);
                StringBuilder __tmp33 = new StringBuilder();
                __tmp33.Append(entityName);
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
                string __tmp34Line = " entity);"; //255:33
                if (__tmp34Line != null) __out.Append(__tmp34Line);
                __out.AppendLine(false); //255:42
                __out.AppendLine(true); //256:1
                string __tmp36Line = "	public void delete(Iterable<? extends "; //257:1
                if (__tmp36Line != null) __out.Append(__tmp36Line);
                StringBuilder __tmp37 = new StringBuilder();
                __tmp37.Append(entityName);
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
                string __tmp38Line = "> entities);"; //257:52
                if (__tmp38Line != null) __out.Append(__tmp38Line);
                __out.AppendLine(false); //257:64
                __out.AppendLine(true); //258:1
                __out.Append("	public void deleteAll();"); //259:1
                __out.AppendLine(false); //259:26
                __out.AppendLine(true); //260:1
                __out.Append("	public boolean exists(Long id) ;"); //261:1
                __out.AppendLine(false); //261:34
                __out.AppendLine(true); //262:1
                string __tmp40Line = "	public Iterable<"; //263:1
                if (__tmp40Line != null) __out.Append(__tmp40Line);
                StringBuilder __tmp41 = new StringBuilder();
                __tmp41.Append(entityName);
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
                string __tmp42Line = "> findAll();"; //263:30
                if (__tmp42Line != null) __out.Append(__tmp42Line);
                __out.AppendLine(false); //263:42
                __out.AppendLine(true); //264:1
                string __tmp44Line = "	public Iterable<"; //265:1
                if (__tmp44Line != null) __out.Append(__tmp44Line);
                StringBuilder __tmp45 = new StringBuilder();
                __tmp45.Append(entityName);
                using(StreamReader __tmp45Reader = new StreamReader(this.__ToStream(__tmp45.ToString())))
                {
                    bool __tmp45_first = true;
                    bool __tmp45_last = __tmp45Reader.EndOfStream;
                    while(__tmp45_first || !__tmp45_last)
                    {
                        __tmp45_first = false;
                        string __tmp45Line = __tmp45Reader.ReadLine();
                        __tmp45_last = __tmp45Reader.EndOfStream;
                        if (__tmp45Line != null) __out.Append(__tmp45Line);
                        if (!__tmp45_last) __out.AppendLine(true);
                    }
                }
                string __tmp46Line = "> findAll(Iterable<Long> entities);"; //265:30
                if (__tmp46Line != null) __out.Append(__tmp46Line);
                __out.AppendLine(false); //265:65
                __out.AppendLine(true); //266:1
                string __tmp48Line = "	public "; //267:1
                if (__tmp48Line != null) __out.Append(__tmp48Line);
                StringBuilder __tmp49 = new StringBuilder();
                __tmp49.Append(entityName);
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
                string __tmp50Line = " findOne(Long id);"; //267:21
                if (__tmp50Line != null) __out.Append(__tmp50Line);
                __out.AppendLine(false); //267:39
                __out.AppendLine(true); //268:1
                string __tmp52Line = "	public <S extends "; //269:1
                if (__tmp52Line != null) __out.Append(__tmp52Line);
                StringBuilder __tmp53 = new StringBuilder();
                __tmp53.Append(entityName);
                using(StreamReader __tmp53Reader = new StreamReader(this.__ToStream(__tmp53.ToString())))
                {
                    bool __tmp53_first = true;
                    bool __tmp53_last = __tmp53Reader.EndOfStream;
                    while(__tmp53_first || !__tmp53_last)
                    {
                        __tmp53_first = false;
                        string __tmp53Line = __tmp53Reader.ReadLine();
                        __tmp53_last = __tmp53Reader.EndOfStream;
                        if (__tmp53Line != null) __out.Append(__tmp53Line);
                        if (!__tmp53_last) __out.AppendLine(true);
                    }
                }
                string __tmp54Line = "> S save(S entity);"; //269:32
                if (__tmp54Line != null) __out.Append(__tmp54Line);
                __out.AppendLine(false); //269:51
                __out.AppendLine(true); //270:1
                string __tmp56Line = "	public <S extends "; //271:1
                if (__tmp56Line != null) __out.Append(__tmp56Line);
                StringBuilder __tmp57 = new StringBuilder();
                __tmp57.Append(entityName);
                using(StreamReader __tmp57Reader = new StreamReader(this.__ToStream(__tmp57.ToString())))
                {
                    bool __tmp57_first = true;
                    bool __tmp57_last = __tmp57Reader.EndOfStream;
                    while(__tmp57_first || !__tmp57_last)
                    {
                        __tmp57_first = false;
                        string __tmp57Line = __tmp57Reader.ReadLine();
                        __tmp57_last = __tmp57Reader.EndOfStream;
                        if (__tmp57Line != null) __out.Append(__tmp57Line);
                        if (!__tmp57_last) __out.AppendLine(true);
                    }
                }
                string __tmp58Line = "> Iterable<S> save(Iterable<S> entities);"; //271:32
                if (__tmp58Line != null) __out.Append(__tmp58Line);
                __out.AppendLine(false); //271:73
            }
            __out.AppendLine(true); //273:1
            __out.Append("}"); //274:1
            __out.AppendLine(false); //274:2
            return __out.ToString();
        }

        public string GenerateImportsForBinding(string bindingType) //278:1
        {
            StringBuilder __out = new StringBuilder();
            if (bindingType == "Rest") //279:3
            {
                __out.Append("import org.springframework.web.bind.annotation.PathVariable;"); //280:1
                __out.AppendLine(false); //280:61
                __out.Append("import org.springframework.web.bind.annotation.RequestMapping;"); //281:1
                __out.AppendLine(false); //281:63
                __out.Append("import org.springframework.web.bind.annotation.RequestMethod;"); //282:1
                __out.AppendLine(false); //282:62
                __out.Append("import org.springframework.web.bind.annotation.RestController;"); //283:1
                __out.AppendLine(false); //283:63
            }
            if (bindingType.Equals("WebService")) //285:3
            {
                __out.Append("//import ?;"); //286:1
                __out.AppendLine(false); //286:12
            }
            if (bindingType.Equals("WebSocket")) //288:3
            {
                __out.Append("//import ?;"); //289:1
                __out.AppendLine(false); //289:12
            }
            return __out.ToString();
        }

        public string GenerateCrudMethodsForRest(string entityName) //294:1
        {
            StringBuilder __out = new StringBuilder();
            __out.AppendLine(true); //295:1
            __out.Append("	@RequestMapping(value = \"/count\")"); //296:1
            __out.AppendLine(false); //296:35
            __out.Append("	public long count();"); //297:1
            __out.AppendLine(false); //297:22
            __out.AppendLine(true); //298:1
            __out.Append("	@RequestMapping(value = \"/delete/{id}\", method = RequestMethod.POST) // TODO Http.Delete method?"); //299:1
            __out.AppendLine(false); //299:98
            __out.Append("	public void delete(@PathVariable Long id);"); //300:1
            __out.AppendLine(false); //300:44
            __out.AppendLine(true); //301:1
            __out.Append("	@RequestMapping(value = \"/delete\", method = RequestMethod.POST) // TODO Http.Delete method?"); //302:1
            __out.AppendLine(false); //302:93
            string __tmp2Line = "	public void delete(@RequestBody "; //303:1
            if (__tmp2Line != null) __out.Append(__tmp2Line);
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(entityName);
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
            string __tmp4Line = " entity);"; //303:46
            if (__tmp4Line != null) __out.Append(__tmp4Line);
            __out.AppendLine(false); //303:55
            __out.AppendLine(true); //304:1
            __out.Append("	@RequestMapping(value = \"/delete\", method = RequestMethod.POST) // TODO Http.Delete method?"); //305:1
            __out.AppendLine(false); //305:93
            string __tmp6Line = "	public void delete(@RequestBody Iterable<? extends "; //306:1
            if (__tmp6Line != null) __out.Append(__tmp6Line);
            StringBuilder __tmp7 = new StringBuilder();
            __tmp7.Append(entityName);
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
            string __tmp8Line = "> entities);"; //306:65
            if (__tmp8Line != null) __out.Append(__tmp8Line);
            __out.AppendLine(false); //306:77
            __out.AppendLine(true); //307:1
            __out.Append("	@RequestMapping(value = \"/deleteAll\", method = RequestMethod.POST) // TODO Http.Delete method?"); //308:1
            __out.AppendLine(false); //308:96
            __out.Append("	public void deleteAll();"); //309:1
            __out.AppendLine(false); //309:26
            __out.AppendLine(true); //310:1
            __out.Append("	@RequestMapping(value = \"/exists/{id}\")"); //311:1
            __out.AppendLine(false); //311:41
            __out.Append("	public boolean exists(@PathVariable Long id) ;"); //312:1
            __out.AppendLine(false); //312:48
            __out.AppendLine(true); //313:1
            __out.Append("	@RequestMapping(value = \"/findAll\")"); //314:1
            __out.AppendLine(false); //314:37
            string __tmp10Line = "	public Iterable<"; //315:1
            if (__tmp10Line != null) __out.Append(__tmp10Line);
            StringBuilder __tmp11 = new StringBuilder();
            __tmp11.Append(entityName);
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
            string __tmp12Line = "> findAll();"; //315:30
            if (__tmp12Line != null) __out.Append(__tmp12Line);
            __out.AppendLine(false); //315:42
            __out.AppendLine(true); //316:1
            __out.Append("	@RequestMapping(value = \"/findAll\")"); //317:1
            __out.AppendLine(false); //317:37
            string __tmp14Line = "	public Iterable<"; //318:1
            if (__tmp14Line != null) __out.Append(__tmp14Line);
            StringBuilder __tmp15 = new StringBuilder();
            __tmp15.Append(entityName);
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
            string __tmp16Line = "> findAll(@RequestBody Iterable<Long> entities);"; //318:30
            if (__tmp16Line != null) __out.Append(__tmp16Line);
            __out.AppendLine(false); //318:78
            __out.AppendLine(true); //319:1
            __out.Append("	@RequestMapping(value = \"/findOne/{id}\")"); //320:1
            __out.AppendLine(false); //320:42
            string __tmp18Line = "	public "; //321:1
            if (__tmp18Line != null) __out.Append(__tmp18Line);
            StringBuilder __tmp19 = new StringBuilder();
            __tmp19.Append(entityName);
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
            string __tmp20Line = " findOne(@PathVariable Long id);"; //321:21
            if (__tmp20Line != null) __out.Append(__tmp20Line);
            __out.AppendLine(false); //321:53
            __out.AppendLine(true); //322:1
            __out.Append("	@RequestMapping(value = \"/save\")"); //323:1
            __out.AppendLine(false); //323:34
            string __tmp22Line = "	public <S extends "; //324:1
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
            string __tmp24Line = "> S save(@RequestBody S entity);"; //324:32
            if (__tmp24Line != null) __out.Append(__tmp24Line);
            __out.AppendLine(false); //324:64
            __out.AppendLine(true); //325:1
            __out.Append("	@RequestMapping(value = \"/save\")"); //326:1
            __out.AppendLine(false); //326:34
            string __tmp26Line = "	public <S extends "; //327:1
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
            string __tmp28Line = "> Iterable<S> save(@RequestBody Iterable<S> entities);"; //327:32
            if (__tmp28Line != null) __out.Append(__tmp28Line);
            __out.AppendLine(false); //327:86
            return __out.ToString();
        }

        public string GenerateRepositoryProxyImpl(string namespaceName, string entityName, string bindingType) //331:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp2Line = "package "; //332:1
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
            string __tmp4Line = "."; //332:34
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
            string __tmp6Line = ";"; //332:85
            if (__tmp6Line != null) __out.Append(__tmp6Line);
            __out.AppendLine(false); //332:86
            __out.AppendLine(true); //333:1
            __out.Append("import org.springframework.beans.factory.annotation.Autowired;"); //334:1
            __out.AppendLine(false); //334:63
            __out.AppendLine(true); //335:1
            string __tmp8Line = "import "; //336:1
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
            string __tmp10Line = "."; //336:33
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
            string __tmp12Line = "."; //336:80
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
            string __tmp14Line = ";"; //336:93
            if (__tmp14Line != null) __out.Append(__tmp14Line);
            __out.AppendLine(false); //336:94
            string __tmp16Line = "import "; //337:1
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
            string __tmp18Line = "."; //337:33
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
            string __tmp20Line = "."; //337:84
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
            string __tmp22Line = "Repository;"; //337:97
            if (__tmp22Line != null) __out.Append(__tmp22Line);
            __out.AppendLine(false); //337:108
            string __tmp24Line = "import "; //338:1
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
            string __tmp26Line = "."; //338:33
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
            string __tmp28Line = "."; //338:83
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
            string __tmp30Line = "Repository"; //338:96
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
            string __tmp32Line = ";"; //338:119
            if (__tmp32Line != null) __out.Append(__tmp32Line);
            __out.AppendLine(false); //338:120
            __out.AppendLine(true); //339:1
            string __tmp34Line = "public class "; //340:1
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
            string __tmp36Line = "Repository"; //340:26
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
            string __tmp38Line = "Impl implements "; //340:49
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
            string __tmp40Line = "Repository"; //340:77
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
            string __tmp42Line = " {"; //340:100
            if (__tmp42Line != null) __out.Append(__tmp42Line);
            __out.AppendLine(false); //340:102
            __out.AppendLine(true); //341:1
            __out.Append("	@Autowired"); //342:1
            __out.AppendLine(false); //342:12
            string __tmp43Prefix = "	"; //343:1
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
            string __tmp45Line = "Repository repository;"; //343:14
            if (__tmp45Line != null) __out.Append(__tmp45Line);
            __out.AppendLine(false); //343:36
            __out.AppendLine(true); //344:1
            __out.Append("	@Override"); //345:1
            __out.AppendLine(false); //345:11
            __out.Append("	public long count() {"); //346:1
            __out.AppendLine(false); //346:23
            __out.Append("		return repository.count();"); //347:1
            __out.AppendLine(false); //347:29
            __out.Append("	}"); //348:1
            __out.AppendLine(false); //348:3
            __out.AppendLine(true); //349:1
            __out.Append("	@Override"); //350:1
            __out.AppendLine(false); //350:11
            __out.Append("	public void delete(Long id) {"); //351:1
            __out.AppendLine(false); //351:31
            __out.Append("		repository.delete(id);"); //352:1
            __out.AppendLine(false); //352:25
            __out.Append("	}"); //353:1
            __out.AppendLine(false); //353:3
            __out.AppendLine(true); //354:1
            __out.Append("	@Override"); //355:1
            __out.AppendLine(false); //355:11
            string __tmp47Line = "	public void delete("; //356:1
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
            string __tmp49Line = " entity) {"; //356:33
            if (__tmp49Line != null) __out.Append(__tmp49Line);
            __out.AppendLine(false); //356:43
            __out.Append("		repository.delete(entity);"); //357:1
            __out.AppendLine(false); //357:29
            __out.Append("	}"); //358:1
            __out.AppendLine(false); //358:3
            __out.AppendLine(true); //359:1
            __out.Append("	@Override"); //360:1
            __out.AppendLine(false); //360:11
            string __tmp51Line = "	public void delete(Iterable<? extends "; //361:1
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
            string __tmp53Line = "> entities) {"; //361:52
            if (__tmp53Line != null) __out.Append(__tmp53Line);
            __out.AppendLine(false); //361:65
            __out.Append("		repository.delete(entities);"); //362:1
            __out.AppendLine(false); //362:31
            __out.Append("	}"); //363:1
            __out.AppendLine(false); //363:3
            __out.AppendLine(true); //364:1
            __out.Append("	@Override"); //365:1
            __out.AppendLine(false); //365:11
            __out.Append("	public void deleteAll() {"); //366:1
            __out.AppendLine(false); //366:27
            __out.Append("		repository.deleteAll();"); //367:1
            __out.AppendLine(false); //367:26
            __out.Append("	}"); //368:1
            __out.AppendLine(false); //368:3
            __out.AppendLine(true); //369:1
            __out.Append("	@Override"); //370:1
            __out.AppendLine(false); //370:11
            __out.Append("	public boolean exists(Long id) {"); //371:1
            __out.AppendLine(false); //371:34
            __out.Append("		return repository.exists(id);"); //372:1
            __out.AppendLine(false); //372:32
            __out.Append("	}"); //373:1
            __out.AppendLine(false); //373:3
            __out.AppendLine(true); //374:1
            __out.Append("	@Override"); //375:1
            __out.AppendLine(false); //375:11
            string __tmp55Line = "	public Iterable<"; //376:1
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
            string __tmp57Line = "> findAll() {"; //376:30
            if (__tmp57Line != null) __out.Append(__tmp57Line);
            __out.AppendLine(false); //376:43
            __out.Append("		return repository.findAll();"); //377:1
            __out.AppendLine(false); //377:31
            __out.Append("	}"); //378:1
            __out.AppendLine(false); //378:3
            __out.AppendLine(true); //379:1
            __out.Append("	@Override"); //380:1
            __out.AppendLine(false); //380:11
            string __tmp59Line = "	public Iterable<"; //381:1
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
            string __tmp61Line = "> findAll(Iterable<Long> entities) {"; //381:30
            if (__tmp61Line != null) __out.Append(__tmp61Line);
            __out.AppendLine(false); //381:66
            __out.Append("		return repository.findAll(entities);"); //382:1
            __out.AppendLine(false); //382:39
            __out.Append("	}"); //383:1
            __out.AppendLine(false); //383:3
            __out.AppendLine(true); //384:1
            __out.Append("	@Override"); //385:1
            __out.AppendLine(false); //385:11
            string __tmp63Line = "	public "; //386:1
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
            string __tmp65Line = " findOne(Long id) {"; //386:21
            if (__tmp65Line != null) __out.Append(__tmp65Line);
            __out.AppendLine(false); //386:40
            __out.Append("		return repository.findOne(id);"); //387:1
            __out.AppendLine(false); //387:33
            __out.Append("	}"); //388:1
            __out.AppendLine(false); //388:3
            __out.AppendLine(true); //389:1
            __out.Append("	@Override"); //390:1
            __out.AppendLine(false); //390:11
            string __tmp67Line = "	public <S extends "; //391:1
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
            string __tmp69Line = "> S save(S entity) {"; //391:32
            if (__tmp69Line != null) __out.Append(__tmp69Line);
            __out.AppendLine(false); //391:52
            __out.Append("		return repository.save(entity);"); //392:1
            __out.AppendLine(false); //392:34
            __out.Append("	}"); //393:1
            __out.AppendLine(false); //393:3
            __out.AppendLine(true); //394:1
            __out.Append("	@Override"); //395:1
            __out.AppendLine(false); //395:11
            string __tmp71Line = "	public <S extends "; //396:1
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
            string __tmp73Line = "> Iterable<S> save(Iterable<S> entities) {"; //396:32
            if (__tmp73Line != null) __out.Append(__tmp73Line);
            __out.AppendLine(false); //396:74
            __out.Append("		return repository.save(entities);"); //397:1
            __out.AppendLine(false); //397:36
            __out.Append("	}"); //398:1
            __out.AppendLine(false); //398:3
            __out.AppendLine(true); //399:1
            __out.Append("}"); //400:1
            __out.AppendLine(false); //400:2
            return __out.ToString();
        }

        public string InterfaceAnnotation(string bindingType) //404:1
        {
            StringBuilder __out = new StringBuilder();
            if (bindingType.Equals("Rest")) //405:3
            {
                __out.Append("@RestController"); //406:1
                __out.AppendLine(false); //406:16
                __out.Append("@RequestMapping(method = RequestMethod.GET)"); //407:1
                __out.AppendLine(false); //407:44
            }
            else if (bindingType.Equals("WebService")) //408:3
            {
                __out.Append("//@WebService"); //409:1
                __out.AppendLine(false); //409:14
            }
            else if (bindingType.Equals("WebSockett")) //410:3
            {
                __out.Append("//@WebSocket"); //411:1
                __out.AppendLine(false); //411:13
            }
            return __out.ToString();
        }

        public string OperationAnnotation(Operation op, string bindingType) //417:1
        {
            StringBuilder __out = new StringBuilder();
            if (bindingType.Equals("Rest")) //418:3
            {
                string __tmp2Line = "	@RequestMapping(value = \"/"; //419:1
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
                var __loop12_results = 
                    (from __loop12_var1 in __Enumerate((op).GetEnumerator()) //420:9
                    from param in __Enumerate((__loop12_var1.Parameters).GetEnumerator()) //420:13
                    select new { __loop12_var1 = __loop12_var1, param = param}
                    ).ToList(); //420:4
                int __loop12_iteration = 0;
                foreach (var __tmp4 in __loop12_results)
                {
                    ++__loop12_iteration;
                    var __loop12_var1 = __tmp4.__loop12_var1;
                    var param = __tmp4.param;
                    if (param.Type.IsJavaPrimitiveType()) //421:5
                    {
                        string __tmp6Line = "/{"; //422:1
                        if (__tmp6Line != null) __out.Append(__tmp6Line);
                        StringBuilder __tmp7 = new StringBuilder();
                        __tmp7.Append(param.Name);
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
                        string __tmp8Line = "}"; //422:15
                        if (__tmp8Line != null) __out.Append(__tmp8Line);
                    }
                }
                __out.Append("\""); //425:1
                if (!op.Name.ToPascalCase().StartsWith("Get")) //426:4
                {
                    __out.Append(", method = RequestMethod.POST /* TODO consider other method */"); //427:1
                }
                __out.Append(")"); //429:1
                __out.AppendLine(false); //429:2
            }
            else if (bindingType.Equals("WebService")) //430:3
            {
                __out.Append("	//@WebService"); //431:1
                __out.AppendLine(false); //431:15
            }
            else if (bindingType.Equals("WebSockett")) //432:3
            {
                __out.Append("	//@WebSocket"); //433:1
                __out.AppendLine(false); //433:14
            }
            return __out.ToString();
        }

        public string ParameterAnnotation(InputParameter parameter, string bindingType) //439:1
        {
            StringBuilder __out = new StringBuilder();
            if (bindingType.Equals("Rest")) //440:3
            {
                if (parameter.Type.IsJavaPrimitiveType()) //441:4
                {
                    __out.Append("@PathVariable "); //442:1
                }
            }
            else if (bindingType.Equals("WebService")) //444:3
            {
            }
            else if (bindingType.Equals("WebSockett")) //446:3
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
