using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Soal //1:1
{
    using __Hidden_SpringInterfaceGenerator_316435626;
    namespace __Hidden_SpringInterfaceGenerator_316435626
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

        public string GenerateInterface(Interface iface, string bindingType, string package) //7:1
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
            __tmp5.Append(package);
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
            string __tmp6Line = ";"; //8:58
            if (__tmp6Line != null) __out.Append(__tmp6Line);
            __out.AppendLine(false); //8:59
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
            __tmp10.Append(SpringGeneratorUtil.GenerateImports(iface));
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
                    __out.AppendLine(false); //12:45
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
            __tmp16.Append(SpringGeneratorUtil.GenerateImports(iface, true, dataBinding));
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
                    __out.AppendLine(false); //43:64
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
                from repo in __Enumerate((__loop3_var1.GetRepositories(dataBinding)).GetEnumerator()) //47:15
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
                string __tmp27Line = " "; //50:16
                if (__tmp27Line != null) __out.Append(__tmp27Line);
                StringBuilder __tmp28 = new StringBuilder();
                __tmp28.Append(repo.ToLower());
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
                string __tmp29Line = ";"; //50:33
                if (__tmp29Line != null) __out.Append(__tmp29Line);
                __out.AppendLine(false); //50:34
            }
            var __loop4_results = 
                (from __loop4_var1 in __Enumerate((iface).GetEnumerator()) //52:7
                from op in __Enumerate((__loop4_var1.Operations).GetEnumerator()) //52:14
                select new { __loop4_var1 = __loop4_var1, op = op}
                ).ToList(); //52:2
            int __loop4_iteration = 0;
            foreach (var __tmp30 in __loop4_results)
            {
                ++__loop4_iteration;
                var __loop4_var1 = __tmp30.__loop4_var1;
                var op = __tmp30.op;
                __out.AppendLine(true); //53:1
                string __tmp32Line = "	public "; //54:1
                if (__tmp32Line != null) __out.Append(__tmp32Line);
                StringBuilder __tmp33 = new StringBuilder();
                __tmp33.Append(op.Result.Type.GetJavaName());
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
                string __tmp34Line = " "; //54:39
                if (__tmp34Line != null) __out.Append(__tmp34Line);
                StringBuilder __tmp35 = new StringBuilder();
                __tmp35.Append(op.Name.ToCamelCase());
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
                string __tmp36Line = "("; //54:63
                if (__tmp36Line != null) __out.Append(__tmp36Line);
                StringBuilder __tmp37 = new StringBuilder();
                __tmp37.Append(SpringGeneratorUtil.GetParameterList(op));
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
                string __tmp38Line = ")"; //54:106
                if (__tmp38Line != null) __out.Append(__tmp38Line);
                if (op.Exceptions.Any()) //55:3
                {
                    string __tmp40Line = " throws "; //56:1
                    if (__tmp40Line != null) __out.Append(__tmp40Line);
                    StringBuilder __tmp41 = new StringBuilder();
                    __tmp41.Append(SpringGeneratorUtil.GetExceptionList(op));
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
                }
                __out.Append(" {"); //58:1
                __out.AppendLine(false); //58:3
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

        public string GenerateProxyInterfaceImplementation(Interface iface, string functionName, string bindingType, string package, string dataBinding) //68:1
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
            __tmp11.Append(package);
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
            string __tmp12Line = "."; //74:57
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
            string __tmp15Line = ";"; //74:83
            if (__tmp15Line != null) __out.Append(__tmp15Line);
            __out.AppendLine(false); //74:84
            StringBuilder __tmp17 = new StringBuilder();
            __tmp17.Append(SpringGeneratorUtil.GenerateImports(iface, true, dataBinding));
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
                    __out.AppendLine(false); //75:64
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
            string impl = ""; //80:3
            if (package == SpringGeneratorUtil.Properties.interfacePackage) //81:3
            {
                impl = "Impl";
            }
            __out.Append("	@Autowired"); //85:1
            __out.AppendLine(false); //85:12
            string __tmp27Line = "	private "; //86:1
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
            StringBuilder __tmp29 = new StringBuilder();
            __tmp29.Append(impl);
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
            string __tmp30Line = " "; //86:28
            if (__tmp30Line != null) __out.Append(__tmp30Line);
            StringBuilder __tmp31 = new StringBuilder();
            __tmp31.Append(iface.Name.ToCamelCase());
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
            StringBuilder __tmp32 = new StringBuilder();
            __tmp32.Append(impl);
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
            string __tmp33Line = ";"; //86:61
            if (__tmp33Line != null) __out.Append(__tmp33Line);
            __out.AppendLine(false); //86:62
            var __loop5_results = 
                (from __loop5_var1 in __Enumerate((iface).GetEnumerator()) //88:7
                from op in __Enumerate((__loop5_var1.Operations).GetEnumerator()) //88:14
                select new { __loop5_var1 = __loop5_var1, op = op}
                ).ToList(); //88:2
            int __loop5_iteration = 0;
            foreach (var __tmp34 in __loop5_results)
            {
                ++__loop5_iteration;
                var __loop5_var1 = __tmp34.__loop5_var1;
                var op = __tmp34.op;
                __out.AppendLine(true); //89:1
                string __tmp36Line = "	public "; //90:1
                if (__tmp36Line != null) __out.Append(__tmp36Line);
                StringBuilder __tmp37 = new StringBuilder();
                __tmp37.Append(op.Result.Type.GetJavaName());
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
                string __tmp38Line = " "; //90:39
                if (__tmp38Line != null) __out.Append(__tmp38Line);
                StringBuilder __tmp39 = new StringBuilder();
                __tmp39.Append(op.Name.ToCamelCase());
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
                string __tmp40Line = "("; //90:63
                if (__tmp40Line != null) __out.Append(__tmp40Line);
                StringBuilder __tmp41 = new StringBuilder();
                __tmp41.Append(SpringGeneratorUtil.GetParameterList(op));
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
                string __tmp42Line = ") "; //90:106
                if (__tmp42Line != null) __out.Append(__tmp42Line);
                if (op.Exceptions.Any()) //91:3
                {
                    string __tmp44Line = " throws "; //92:1
                    if (__tmp44Line != null) __out.Append(__tmp44Line);
                    StringBuilder __tmp45 = new StringBuilder();
                    __tmp45.Append(SpringGeneratorUtil.GetExceptionList(op));
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
                }
                __out.Append(" {"); //94:1
                __out.AppendLine(false); //94:3
                if (op.Result.Type.GetJavaName() != "void") //95:5
                {
                    string __tmp47Line = "		return "; //96:1
                    if (__tmp47Line != null) __out.Append(__tmp47Line);
                    StringBuilder __tmp48 = new StringBuilder();
                    __tmp48.Append(iface.Name.ToCamelCase());
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
                    StringBuilder __tmp49 = new StringBuilder();
                    __tmp49.Append(impl);
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
                    string __tmp50Line = "."; //96:42
                    if (__tmp50Line != null) __out.Append(__tmp50Line);
                    StringBuilder __tmp51 = new StringBuilder();
                    __tmp51.Append(op.Name.ToCamelCase());
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
                    string __tmp52Line = "("; //96:66
                    if (__tmp52Line != null) __out.Append(__tmp52Line);
                    StringBuilder __tmp53 = new StringBuilder();
                    __tmp53.Append(SpringGeneratorUtil.GetParameterNameList(op));
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
                    string __tmp54Line = ");"; //96:113
                    if (__tmp54Line != null) __out.Append(__tmp54Line);
                    __out.AppendLine(false); //96:115
                }
                else //97:5
                {
                    string __tmp55Prefix = "		"; //98:1
                    StringBuilder __tmp56 = new StringBuilder();
                    __tmp56.Append(iface.Name.ToCamelCase());
                    using(StreamReader __tmp56Reader = new StreamReader(this.__ToStream(__tmp56.ToString())))
                    {
                        bool __tmp56_first = true;
                        bool __tmp56_last = __tmp56Reader.EndOfStream;
                        while(__tmp56_first || !__tmp56_last)
                        {
                            __tmp56_first = false;
                            string __tmp56Line = __tmp56Reader.ReadLine();
                            __tmp56_last = __tmp56Reader.EndOfStream;
                            __out.Append(__tmp55Prefix);
                            if (__tmp56Line != null) __out.Append(__tmp56Line);
                            if (!__tmp56_last) __out.AppendLine(true);
                        }
                    }
                    StringBuilder __tmp57 = new StringBuilder();
                    __tmp57.Append(impl);
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
                    string __tmp58Line = "."; //98:35
                    if (__tmp58Line != null) __out.Append(__tmp58Line);
                    StringBuilder __tmp59 = new StringBuilder();
                    __tmp59.Append(op.Name.ToCamelCase());
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
                    string __tmp60Line = "("; //98:59
                    if (__tmp60Line != null) __out.Append(__tmp60Line);
                    StringBuilder __tmp61 = new StringBuilder();
                    __tmp61.Append(SpringGeneratorUtil.GetParameterNameList(op));
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
                    string __tmp62Line = ");"; //98:106
                    if (__tmp62Line != null) __out.Append(__tmp62Line);
                    __out.AppendLine(false); //98:108
                }
                __out.Append("	}"); //100:1
                __out.AppendLine(false); //100:3
            }
            __out.Append("}"); //102:1
            __out.AppendLine(false); //102:2
            return __out.ToString();
        }

        public string GenerateProxyForInterface(Interface iface, string bindingType, string currentComponent, string targetComponent) //107:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp2Line = "package "; //108:1
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
            string __tmp4Line = "."; //108:48
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
            string __tmp6Line = ";"; //108:94
            if (__tmp6Line != null) __out.Append(__tmp6Line);
            __out.AppendLine(false); //108:95
            __out.AppendLine(true); //109:1
            __out.Append("import static org.springframework.hateoas.mvc.ControllerLinkBuilder.linkTo;"); //110:1
            __out.AppendLine(false); //110:76
            __out.Append("import static org.springframework.hateoas.mvc.ControllerLinkBuilder.methodOn;"); //111:1
            __out.AppendLine(false); //111:78
            __out.AppendLine(true); //112:1
            __out.Append("import org.springframework.hateoas.Link;"); //113:1
            __out.AppendLine(false); //113:41
            __out.Append("import org.springframework.http.HttpEntity;"); //114:1
            __out.AppendLine(false); //114:44
            __out.Append("import org.springframework.http.converter.json.MappingJackson2HttpMessageConverter;"); //115:1
            __out.AppendLine(false); //115:84
            __out.Append("import org.springframework.stereotype.Service;"); //116:1
            __out.AppendLine(false); //116:47
            __out.Append("import org.springframework.web.client.RestTemplate;"); //117:1
            __out.AppendLine(false); //117:52
            __out.Append("import org.springframework.web.context.request.RequestAttributes;"); //118:1
            __out.AppendLine(false); //118:66
            __out.Append("import org.springframework.web.context.request.RequestContextHolder;"); //119:1
            __out.AppendLine(false); //119:69
            __out.Append("import org.springframework.web.context.request.ServletRequestAttributes;"); //120:1
            __out.AppendLine(false); //120:73
            __out.AppendLine(true); //121:1
            __out.Append("import cinema.Configuration;"); //122:1
            __out.AppendLine(false); //122:29
            string __tmp8Line = "import "; //123:1
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
            string __tmp10Line = "."; //123:47
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
            string __tmp12Line = "."; //123:97
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
            string __tmp15Line = ";"; //123:123
            if (__tmp15Line != null) __out.Append(__tmp15Line);
            __out.AppendLine(false); //123:124
            StringBuilder __tmp17 = new StringBuilder();
            __tmp17.Append(SpringGeneratorUtil.GenerateImports(iface));
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
                    __out.AppendLine(false); //124:45
                }
            }
            __out.AppendLine(true); //125:1
            __out.Append("import javax.servlet.http.HttpServletRequest;"); //126:1
            __out.AppendLine(false); //126:46
            __out.Append("import java.util.Arrays;"); //127:1
            __out.AppendLine(false); //127:25
            __out.Append("import java.util.stream.Collectors;"); //128:1
            __out.AppendLine(false); //128:36
            __out.AppendLine(true); //129:1
            __out.Append("@Service"); //130:1
            __out.AppendLine(false); //130:9
            string __tmp19Line = "public class "; //131:1
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
            string __tmp22Line = "Proxy implements "; //131:39
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
            string __tmp25Line = " {"; //131:81
            if (__tmp25Line != null) __out.Append(__tmp25Line);
            __out.AppendLine(false); //131:83
            __out.AppendLine(true); //132:1
            __out.Append("	private RestTemplate restTemplate = new RestTemplate();"); //133:1
            __out.AppendLine(false); //133:57
            string __tmp27Line = "	private final String currentComponentName = \"Cinema-"; //134:1
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
            string __tmp29Line = "\";"; //134:72
            if (__tmp29Line != null) __out.Append(__tmp29Line);
            __out.AppendLine(false); //134:74
            string __tmp31Line = "    private final String targetComponentName = \"Cinema-"; //135:1
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
            string __tmp33Line = "\";"; //135:73
            if (__tmp33Line != null) __out.Append(__tmp33Line);
            __out.AppendLine(false); //135:75
            __out.AppendLine(true); //136:2
            var __loop6_results = 
                (from __loop6_var1 in __Enumerate((iface).GetEnumerator()) //137:7
                from op in __Enumerate((__loop6_var1.Operations).GetEnumerator()) //137:14
                select new { __loop6_var1 = __loop6_var1, op = op}
                ).ToList(); //137:2
            int __loop6_iteration = 0;
            foreach (var __tmp34 in __loop6_results)
            {
                ++__loop6_iteration;
                var __loop6_var1 = __tmp34.__loop6_var1;
                var op = __tmp34.op;
                string __tmp36Line = "	private String urlOf"; //138:1
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
                string __tmp38Line = ";"; //138:46
                if (__tmp38Line != null) __out.Append(__tmp38Line);
                __out.AppendLine(false); //138:47
            }
            var __loop7_results = 
                (from __loop7_var1 in __Enumerate((iface).GetEnumerator()) //141:7
                from op in __Enumerate((__loop7_var1.Operations).GetEnumerator()) //141:14
                select new { __loop7_var1 = __loop7_var1, op = op}
                ).ToList(); //141:2
            int __loop7_iteration = 0;
            foreach (var __tmp39 in __loop7_results)
            {
                ++__loop7_iteration;
                var __loop7_var1 = __tmp39.__loop7_var1;
                var op = __tmp39.op;
                __out.AppendLine(true); //142:1
                string resultJavaName = op.Result.Type.GetJavaName(); //143:3
                __out.Append("	@Override"); //144:1
                __out.AppendLine(false); //144:11
                string __tmp41Line = "	public "; //145:1
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
                string __tmp43Line = " "; //145:25
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
                string __tmp45Line = "("; //145:49
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
                string __tmp47Line = ")"; //145:92
                if (__tmp47Line != null) __out.Append(__tmp47Line);
                if (op.Exceptions.Any()) //146:3
                {
                    string __tmp49Line = " throws "; //147:1
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
                }
                __out.Append(" {"); //149:1
                __out.AppendLine(false); //149:3
                string __tmp52Line = "		String url = getUrlOf"; //150:1
                if (__tmp52Line != null) __out.Append(__tmp52Line);
                StringBuilder __tmp53 = new StringBuilder();
                __tmp53.Append(op.Name.ToPascalCase());
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
                string __tmp54Line = "("; //150:48
                if (__tmp54Line != null) __out.Append(__tmp54Line);
                StringBuilder __tmp55 = new StringBuilder();
                __tmp55.Append(SpringGeneratorUtil.GetParameterNameList(op));
                using(StreamReader __tmp55Reader = new StreamReader(this.__ToStream(__tmp55.ToString())))
                {
                    bool __tmp55_first = true;
                    bool __tmp55_last = __tmp55Reader.EndOfStream;
                    while(__tmp55_first || !__tmp55_last)
                    {
                        __tmp55_first = false;
                        string __tmp55Line = __tmp55Reader.ReadLine();
                        __tmp55_last = __tmp55Reader.EndOfStream;
                        if (__tmp55Line != null) __out.Append(__tmp55Line);
                        if (!__tmp55_last) __out.AppendLine(true);
                    }
                }
                string __tmp56Line = ");"; //150:95
                if (__tmp56Line != null) __out.Append(__tmp56Line);
                __out.AppendLine(false); //150:97
                string method = "POST"; //152:3
                if (op.Name.ToPascalCase().StartsWith("Get")) //153:3
                {
                    method = "GET";
                }
                string extraVariable = ""; //157:3
                if (method == "POST") //158:3
                {
                    extraVariable = "request, ";
                    __out.Append("		HttpEntity<?> request = null;"); //160:1
                    __out.AppendLine(false); //160:32
                    __out.Append("		this.restTemplate.getMessageConverters().add(new MappingJackson2HttpMessageConverter());"); //161:1
                    __out.AppendLine(false); //161:91
                    var __loop8_results = 
                        (from __loop8_var1 in __Enumerate((op).GetEnumerator()) //162:9
                        from param in __Enumerate((__loop8_var1.Parameters).GetEnumerator()) //162:13
                        where !param.Type.IsJavaPrimitiveType() //162:30
                        select new { __loop8_var1 = __loop8_var1, param = param}
                        ).ToList(); //162:4
                    int __loop8_iteration = 0;
                    foreach (var __tmp57 in __loop8_results)
                    {
                        ++__loop8_iteration;
                        var __loop8_var1 = __tmp57.__loop8_var1;
                        var param = __tmp57.param;
                        string __tmp59Line = "		request = new HttpEntity<"; //163:1
                        if (__tmp59Line != null) __out.Append(__tmp59Line);
                        StringBuilder __tmp60 = new StringBuilder();
                        __tmp60.Append(param.Type.GetJavaName());
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
                        string __tmp61Line = ">("; //163:54
                        if (__tmp61Line != null) __out.Append(__tmp61Line);
                        StringBuilder __tmp62 = new StringBuilder();
                        __tmp62.Append(param.Name);
                        using(StreamReader __tmp62Reader = new StreamReader(this.__ToStream(__tmp62.ToString())))
                        {
                            bool __tmp62_first = true;
                            bool __tmp62_last = __tmp62Reader.EndOfStream;
                            while(__tmp62_first || !__tmp62_last)
                            {
                                __tmp62_first = false;
                                string __tmp62Line = __tmp62Reader.ReadLine();
                                __tmp62_last = __tmp62Reader.EndOfStream;
                                if (__tmp62Line != null) __out.Append(__tmp62Line);
                                if (!__tmp62_last) __out.AppendLine(true);
                            }
                        }
                        string __tmp63Line = ");"; //163:68
                        if (__tmp63Line != null) __out.Append(__tmp63Line);
                        __out.AppendLine(false); //163:70
                    }
                }
                ArrayType array = op.Result.Type as ArrayType; //167:3
                if (array != null) //168:3
                {
                    string __tmp64Prefix = "		"; //169:1
                    StringBuilder __tmp65 = new StringBuilder();
                    __tmp65.Append(array.InnerType.GetJavaName());
                    using(StreamReader __tmp65Reader = new StreamReader(this.__ToStream(__tmp65.ToString())))
                    {
                        bool __tmp65_first = true;
                        bool __tmp65_last = __tmp65Reader.EndOfStream;
                        while(__tmp65_first || !__tmp65_last)
                        {
                            __tmp65_first = false;
                            string __tmp65Line = __tmp65Reader.ReadLine();
                            __tmp65_last = __tmp65Reader.EndOfStream;
                            __out.Append(__tmp64Prefix);
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
                    string __tmp67Line = " response = restTemplate."; //169:40
                    if (__tmp67Line != null) __out.Append(__tmp67Line);
                    StringBuilder __tmp68 = new StringBuilder();
                    __tmp68.Append(method.ToLower());
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
                    string __tmp69Line = "ForObject(url, "; //169:83
                    if (__tmp69Line != null) __out.Append(__tmp69Line);
                    StringBuilder __tmp70 = new StringBuilder();
                    __tmp70.Append(extraVariable);
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
                    StringBuilder __tmp71 = new StringBuilder();
                    __tmp71.Append(array.InnerType.GetJavaName());
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
                    __tmp72.Append("[]");
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
                    string __tmp73Line = ".class);"; //169:150
                    if (__tmp73Line != null) __out.Append(__tmp73Line);
                    __out.AppendLine(false); //169:158
                }
                else if (resultJavaName != "void") //170:3
                {
                    string __tmp74Prefix = "		"; //171:1
                    StringBuilder __tmp75 = new StringBuilder();
                    __tmp75.Append(resultJavaName);
                    using(StreamReader __tmp75Reader = new StreamReader(this.__ToStream(__tmp75.ToString())))
                    {
                        bool __tmp75_first = true;
                        bool __tmp75_last = __tmp75Reader.EndOfStream;
                        while(__tmp75_first || !__tmp75_last)
                        {
                            __tmp75_first = false;
                            string __tmp75Line = __tmp75Reader.ReadLine();
                            __tmp75_last = __tmp75Reader.EndOfStream;
                            __out.Append(__tmp74Prefix);
                            if (__tmp75Line != null) __out.Append(__tmp75Line);
                            if (!__tmp75_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp76Line = " response = restTemplate."; //171:19
                    if (__tmp76Line != null) __out.Append(__tmp76Line);
                    StringBuilder __tmp77 = new StringBuilder();
                    __tmp77.Append(method.ToLower());
                    using(StreamReader __tmp77Reader = new StreamReader(this.__ToStream(__tmp77.ToString())))
                    {
                        bool __tmp77_first = true;
                        bool __tmp77_last = __tmp77Reader.EndOfStream;
                        while(__tmp77_first || !__tmp77_last)
                        {
                            __tmp77_first = false;
                            string __tmp77Line = __tmp77Reader.ReadLine();
                            __tmp77_last = __tmp77Reader.EndOfStream;
                            if (__tmp77Line != null) __out.Append(__tmp77Line);
                            if (!__tmp77_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp78Line = "ForObject(url, "; //171:62
                    if (__tmp78Line != null) __out.Append(__tmp78Line);
                    StringBuilder __tmp79 = new StringBuilder();
                    __tmp79.Append(extraVariable);
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
                    StringBuilder __tmp80 = new StringBuilder();
                    __tmp80.Append(resultJavaName);
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
                    string __tmp81Line = ".class);"; //171:108
                    if (__tmp81Line != null) __out.Append(__tmp81Line);
                    __out.AppendLine(false); //171:116
                }
                else //172:3
                {
                    string __tmp83Line = "		restTemplate."; //173:1
                    if (__tmp83Line != null) __out.Append(__tmp83Line);
                    StringBuilder __tmp84 = new StringBuilder();
                    __tmp84.Append(method.ToLower());
                    using(StreamReader __tmp84Reader = new StreamReader(this.__ToStream(__tmp84.ToString())))
                    {
                        bool __tmp84_first = true;
                        bool __tmp84_last = __tmp84Reader.EndOfStream;
                        while(__tmp84_first || !__tmp84_last)
                        {
                            __tmp84_first = false;
                            string __tmp84Line = __tmp84Reader.ReadLine();
                            __tmp84_last = __tmp84Reader.EndOfStream;
                            if (__tmp84Line != null) __out.Append(__tmp84Line);
                            if (!__tmp84_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp85Line = "ForObject(url, "; //173:34
                    if (__tmp85Line != null) __out.Append(__tmp85Line);
                    StringBuilder __tmp86 = new StringBuilder();
                    __tmp86.Append(extraVariable);
                    using(StreamReader __tmp86Reader = new StreamReader(this.__ToStream(__tmp86.ToString())))
                    {
                        bool __tmp86_first = true;
                        bool __tmp86_last = __tmp86Reader.EndOfStream;
                        while(__tmp86_first || !__tmp86_last)
                        {
                            __tmp86_first = false;
                            string __tmp86Line = __tmp86Reader.ReadLine();
                            __tmp86_last = __tmp86Reader.EndOfStream;
                            if (__tmp86Line != null) __out.Append(__tmp86Line);
                            if (!__tmp86_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp87Line = "Object.class);"; //173:64
                    if (__tmp87Line != null) __out.Append(__tmp87Line);
                    __out.AppendLine(false); //173:78
                }
                if (array != null) //176:3
                {
                    __out.Append("		return Arrays.stream(response).collect(Collectors.toList());"); //177:1
                    __out.AppendLine(false); //177:63
                }
                else if (resultJavaName != "void") //178:3
                {
                    __out.Append("		return response;"); //179:1
                    __out.AppendLine(false); //179:19
                }
                else //180:3
                {
                    __out.Append("		return;"); //181:1
                    __out.AppendLine(false); //181:10
                }
                __out.Append("	}"); //183:1
                __out.AppendLine(false); //183:3
            }
            var __loop9_results = 
                (from __loop9_var1 in __Enumerate((iface).GetEnumerator()) //186:7
                from op in __Enumerate((__loop9_var1.Operations).GetEnumerator()) //186:14
                select new { __loop9_var1 = __loop9_var1, op = op}
                ).ToList(); //186:2
            int __loop9_iteration = 0;
            foreach (var __tmp88 in __loop9_results)
            {
                ++__loop9_iteration;
                var __loop9_var1 = __tmp88.__loop9_var1;
                var op = __tmp88.op;
                __out.AppendLine(true); //187:2
                string __tmp90Line = "	private String getUrlOf"; //188:1
                if (__tmp90Line != null) __out.Append(__tmp90Line);
                StringBuilder __tmp91 = new StringBuilder();
                __tmp91.Append(op.Name.ToPascalCase());
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
                string __tmp92Line = "("; //188:49
                if (__tmp92Line != null) __out.Append(__tmp92Line);
                StringBuilder __tmp93 = new StringBuilder();
                __tmp93.Append(SpringGeneratorUtil.GetParameterList(op));
                using(StreamReader __tmp93Reader = new StreamReader(this.__ToStream(__tmp93.ToString())))
                {
                    bool __tmp93_first = true;
                    bool __tmp93_last = __tmp93Reader.EndOfStream;
                    while(__tmp93_first || !__tmp93_last)
                    {
                        __tmp93_first = false;
                        string __tmp93Line = __tmp93Reader.ReadLine();
                        __tmp93_last = __tmp93Reader.EndOfStream;
                        if (__tmp93Line != null) __out.Append(__tmp93Line);
                        if (!__tmp93_last) __out.AppendLine(true);
                    }
                }
                string __tmp94Line = ") {"; //188:92
                if (__tmp94Line != null) __out.Append(__tmp94Line);
                __out.AppendLine(false); //188:95
                string __tmp96Line = "        if (this.urlOf"; //189:1
                if (__tmp96Line != null) __out.Append(__tmp96Line);
                StringBuilder __tmp97 = new StringBuilder();
                __tmp97.Append(op.Name.ToPascalCase());
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
                string __tmp98Line = " != null) {"; //189:47
                if (__tmp98Line != null) __out.Append(__tmp98Line);
                __out.AppendLine(false); //189:58
                string __tmp100Line = "            return this.urlOf"; //190:1
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
                string __tmp102Line = ";"; //190:54
                if (__tmp102Line != null) __out.Append(__tmp102Line);
                __out.AppendLine(false); //190:55
                __out.Append("        }"); //191:1
                __out.AppendLine(false); //191:10
                __out.AppendLine(true); //192:3
                __out.Append("        // eg.: http://localhost/localapp-1.0/getMoviesFromReservation/"); //193:1
                __out.AppendLine(false); //193:72
                if (op.Result.Type.GetJavaName() == "void") //194:3
                {
                    __out.Append("		String url = null;"); //195:1
                    __out.AppendLine(false); //195:21
                    __out.Append("		try {"); //196:1
                    __out.AppendLine(false); //196:8
                    string __tmp104Line = "			java.lang.reflect.Method method = "; //197:1
                    if (__tmp104Line != null) __out.Append(__tmp104Line);
                    StringBuilder __tmp105 = new StringBuilder();
                    __tmp105.Append(iface.Name + bindingType);
                    using(StreamReader __tmp105Reader = new StreamReader(this.__ToStream(__tmp105.ToString())))
                    {
                        bool __tmp105_first = true;
                        bool __tmp105_last = __tmp105Reader.EndOfStream;
                        while(__tmp105_first || !__tmp105_last)
                        {
                            __tmp105_first = false;
                            string __tmp105Line = __tmp105Reader.ReadLine();
                            __tmp105_last = __tmp105Reader.EndOfStream;
                            if (__tmp105Line != null) __out.Append(__tmp105Line);
                            if (!__tmp105_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp106Line = ".class.getMethod(\""; //197:64
                    if (__tmp106Line != null) __out.Append(__tmp106Line);
                    StringBuilder __tmp107 = new StringBuilder();
                    __tmp107.Append(op.Name.ToCamelCase());
                    using(StreamReader __tmp107Reader = new StreamReader(this.__ToStream(__tmp107.ToString())))
                    {
                        bool __tmp107_first = true;
                        bool __tmp107_last = __tmp107Reader.EndOfStream;
                        while(__tmp107_first || !__tmp107_last)
                        {
                            __tmp107_first = false;
                            string __tmp107Line = __tmp107Reader.ReadLine();
                            __tmp107_last = __tmp107Reader.EndOfStream;
                            if (__tmp107Line != null) __out.Append(__tmp107Line);
                            if (!__tmp107_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp108Line = "\", "; //197:105
                    if (__tmp108Line != null) __out.Append(__tmp108Line);
                    StringBuilder __tmp109 = new StringBuilder();
                    __tmp109.Append(SpringGeneratorUtil.GetParameterTypeList(op));
                    using(StreamReader __tmp109Reader = new StreamReader(this.__ToStream(__tmp109.ToString())))
                    {
                        bool __tmp109_first = true;
                        bool __tmp109_last = __tmp109Reader.EndOfStream;
                        while(__tmp109_first || !__tmp109_last)
                        {
                            __tmp109_first = false;
                            string __tmp109Line = __tmp109Reader.ReadLine();
                            __tmp109_last = __tmp109Reader.EndOfStream;
                            if (__tmp109Line != null) __out.Append(__tmp109Line);
                            if (!__tmp109_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp110Line = ");"; //197:154
                    if (__tmp110Line != null) __out.Append(__tmp110Line);
                    __out.AppendLine(false); //197:156
                    string __tmp112Line = "			Link link = linkTo("; //198:1
                    if (__tmp112Line != null) __out.Append(__tmp112Line);
                    StringBuilder __tmp113 = new StringBuilder();
                    __tmp113.Append(iface.Name + bindingType);
                    using(StreamReader __tmp113Reader = new StreamReader(this.__ToStream(__tmp113.ToString())))
                    {
                        bool __tmp113_first = true;
                        bool __tmp113_last = __tmp113Reader.EndOfStream;
                        while(__tmp113_first || !__tmp113_last)
                        {
                            __tmp113_first = false;
                            string __tmp113Line = __tmp113Reader.ReadLine();
                            __tmp113_last = __tmp113Reader.EndOfStream;
                            if (__tmp113Line != null) __out.Append(__tmp113Line);
                            if (!__tmp113_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp114Line = ".class, method, "; //198:49
                    if (__tmp114Line != null) __out.Append(__tmp114Line);
                    StringBuilder __tmp115 = new StringBuilder();
                    __tmp115.Append(SpringGeneratorUtil.GetParameterNameList(op));
                    using(StreamReader __tmp115Reader = new StreamReader(this.__ToStream(__tmp115.ToString())))
                    {
                        bool __tmp115_first = true;
                        bool __tmp115_last = __tmp115Reader.EndOfStream;
                        while(__tmp115_first || !__tmp115_last)
                        {
                            __tmp115_first = false;
                            string __tmp115Line = __tmp115Reader.ReadLine();
                            __tmp115_last = __tmp115Reader.EndOfStream;
                            if (__tmp115Line != null) __out.Append(__tmp115Line);
                            if (!__tmp115_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp116Line = ").withSelfRel();"; //198:111
                    if (__tmp116Line != null) __out.Append(__tmp116Line);
                    __out.AppendLine(false); //198:127
                    __out.Append("			url = link.getHref();"); //199:1
                    __out.AppendLine(false); //199:25
                    var __loop10_results = 
                        (from __loop10_var1 in __Enumerate((op).GetEnumerator()) //200:9
                        from ex in __Enumerate((__loop10_var1.Exceptions).GetEnumerator()) //200:13
                        select new { __loop10_var1 = __loop10_var1, ex = ex}
                        ).ToList(); //200:4
                    int __loop10_iteration = 0;
                    foreach (var __tmp117 in __loop10_results)
                    {
                        ++__loop10_iteration;
                        var __loop10_var1 = __tmp117.__loop10_var1;
                        var ex = __tmp117.ex;
                        __out.Append("		} catch (NoSuchMethodException e) {"); //201:1
                        __out.AppendLine(false); //201:38
                        __out.Append("			// TODO handle execption properly"); //202:1
                        __out.AppendLine(false); //202:37
                        __out.Append("			throw new RuntimeException(e);"); //203:1
                        __out.AppendLine(false); //203:34
                    }
                    __out.Append("		}"); //205:1
                    __out.AppendLine(false); //205:4
                }
                else if (op.Exceptions.Any()) //207:3
                {
                    __out.Append("		String url = null;"); //208:1
                    __out.AppendLine(false); //208:21
                    __out.Append("		try {"); //209:1
                    __out.AppendLine(false); //209:8
                    string __tmp119Line = "			Link link = linkTo(methodOn("; //210:1
                    if (__tmp119Line != null) __out.Append(__tmp119Line);
                    StringBuilder __tmp120 = new StringBuilder();
                    __tmp120.Append(iface.Name + bindingType);
                    using(StreamReader __tmp120Reader = new StreamReader(this.__ToStream(__tmp120.ToString())))
                    {
                        bool __tmp120_first = true;
                        bool __tmp120_last = __tmp120Reader.EndOfStream;
                        while(__tmp120_first || !__tmp120_last)
                        {
                            __tmp120_first = false;
                            string __tmp120Line = __tmp120Reader.ReadLine();
                            __tmp120_last = __tmp120Reader.EndOfStream;
                            if (__tmp120Line != null) __out.Append(__tmp120Line);
                            if (!__tmp120_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp121Line = ".class)."; //210:58
                    if (__tmp121Line != null) __out.Append(__tmp121Line);
                    StringBuilder __tmp122 = new StringBuilder();
                    __tmp122.Append(op.Name.ToCamelCase());
                    using(StreamReader __tmp122Reader = new StreamReader(this.__ToStream(__tmp122.ToString())))
                    {
                        bool __tmp122_first = true;
                        bool __tmp122_last = __tmp122Reader.EndOfStream;
                        while(__tmp122_first || !__tmp122_last)
                        {
                            __tmp122_first = false;
                            string __tmp122Line = __tmp122Reader.ReadLine();
                            __tmp122_last = __tmp122Reader.EndOfStream;
                            if (__tmp122Line != null) __out.Append(__tmp122Line);
                            if (!__tmp122_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp123Line = "("; //210:89
                    if (__tmp123Line != null) __out.Append(__tmp123Line);
                    StringBuilder __tmp124 = new StringBuilder();
                    __tmp124.Append(SpringGeneratorUtil.GetParameterNameList(op));
                    using(StreamReader __tmp124Reader = new StreamReader(this.__ToStream(__tmp124.ToString())))
                    {
                        bool __tmp124_first = true;
                        bool __tmp124_last = __tmp124Reader.EndOfStream;
                        while(__tmp124_first || !__tmp124_last)
                        {
                            __tmp124_first = false;
                            string __tmp124Line = __tmp124Reader.ReadLine();
                            __tmp124_last = __tmp124Reader.EndOfStream;
                            if (__tmp124Line != null) __out.Append(__tmp124Line);
                            if (!__tmp124_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp125Line = ")).withSelfRel();"; //210:136
                    if (__tmp125Line != null) __out.Append(__tmp125Line);
                    __out.AppendLine(false); //210:153
                    __out.Append("			url = link.getHref();"); //211:1
                    __out.AppendLine(false); //211:25
                    var __loop11_results = 
                        (from __loop11_var1 in __Enumerate((op).GetEnumerator()) //212:9
                        from ex in __Enumerate((__loop11_var1.Exceptions).GetEnumerator()) //212:13
                        select new { __loop11_var1 = __loop11_var1, ex = ex}
                        ).ToList(); //212:4
                    int __loop11_iteration = 0;
                    foreach (var __tmp126 in __loop11_results)
                    {
                        ++__loop11_iteration;
                        var __loop11_var1 = __tmp126.__loop11_var1;
                        var ex = __tmp126.ex;
                        string __tmp128Line = "		} catch ("; //213:1
                        if (__tmp128Line != null) __out.Append(__tmp128Line);
                        StringBuilder __tmp129 = new StringBuilder();
                        __tmp129.Append(ex.GetJavaName());
                        using(StreamReader __tmp129Reader = new StreamReader(this.__ToStream(__tmp129.ToString())))
                        {
                            bool __tmp129_first = true;
                            bool __tmp129_last = __tmp129Reader.EndOfStream;
                            while(__tmp129_first || !__tmp129_last)
                            {
                                __tmp129_first = false;
                                string __tmp129Line = __tmp129Reader.ReadLine();
                                __tmp129_last = __tmp129Reader.EndOfStream;
                                if (__tmp129Line != null) __out.Append(__tmp129Line);
                                if (!__tmp129_last) __out.AppendLine(true);
                            }
                        }
                        string __tmp130Line = " e) {"; //213:30
                        if (__tmp130Line != null) __out.Append(__tmp130Line);
                        __out.AppendLine(false); //213:35
                        __out.Append("			// TODO handle execption properly"); //214:1
                        __out.AppendLine(false); //214:37
                        __out.Append("			throw new RuntimeException(e);"); //215:1
                        __out.AppendLine(false); //215:34
                    }
                    __out.Append("		}"); //217:1
                    __out.AppendLine(false); //217:4
                }
                else //218:3
                {
                    string __tmp132Line = "		Link link = linkTo(methodOn("; //219:1
                    if (__tmp132Line != null) __out.Append(__tmp132Line);
                    StringBuilder __tmp133 = new StringBuilder();
                    __tmp133.Append(iface.Name + bindingType);
                    using(StreamReader __tmp133Reader = new StreamReader(this.__ToStream(__tmp133.ToString())))
                    {
                        bool __tmp133_first = true;
                        bool __tmp133_last = __tmp133Reader.EndOfStream;
                        while(__tmp133_first || !__tmp133_last)
                        {
                            __tmp133_first = false;
                            string __tmp133Line = __tmp133Reader.ReadLine();
                            __tmp133_last = __tmp133Reader.EndOfStream;
                            if (__tmp133Line != null) __out.Append(__tmp133Line);
                            if (!__tmp133_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp134Line = ".class)."; //219:57
                    if (__tmp134Line != null) __out.Append(__tmp134Line);
                    StringBuilder __tmp135 = new StringBuilder();
                    __tmp135.Append(op.Name.ToCamelCase());
                    using(StreamReader __tmp135Reader = new StreamReader(this.__ToStream(__tmp135.ToString())))
                    {
                        bool __tmp135_first = true;
                        bool __tmp135_last = __tmp135Reader.EndOfStream;
                        while(__tmp135_first || !__tmp135_last)
                        {
                            __tmp135_first = false;
                            string __tmp135Line = __tmp135Reader.ReadLine();
                            __tmp135_last = __tmp135Reader.EndOfStream;
                            if (__tmp135Line != null) __out.Append(__tmp135Line);
                            if (!__tmp135_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp136Line = "("; //219:88
                    if (__tmp136Line != null) __out.Append(__tmp136Line);
                    StringBuilder __tmp137 = new StringBuilder();
                    __tmp137.Append(SpringGeneratorUtil.GetParameterNameList(op));
                    using(StreamReader __tmp137Reader = new StreamReader(this.__ToStream(__tmp137.ToString())))
                    {
                        bool __tmp137_first = true;
                        bool __tmp137_last = __tmp137Reader.EndOfStream;
                        while(__tmp137_first || !__tmp137_last)
                        {
                            __tmp137_first = false;
                            string __tmp137Line = __tmp137Reader.ReadLine();
                            __tmp137_last = __tmp137Reader.EndOfStream;
                            if (__tmp137Line != null) __out.Append(__tmp137Line);
                            if (!__tmp137_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp138Line = ")).withSelfRel();"; //219:135
                    if (__tmp138Line != null) __out.Append(__tmp138Line);
                    __out.AppendLine(false); //219:152
                    __out.Append("		String url = link.getHref();"); //220:1
                    __out.AppendLine(false); //220:31
                }
                __out.Append("        RequestAttributes requestAttributes = RequestContextHolder.currentRequestAttributes();"); //222:1
                __out.AppendLine(false); //222:95
                __out.Append("        HttpServletRequest curRequest = ((ServletRequestAttributes) requestAttributes).getRequest();"); //223:1
                __out.AppendLine(false); //223:101
                __out.Append("        String serverName = curRequest.getServerName();"); //224:1
                __out.AppendLine(false); //224:56
                __out.Append("        String serverPort = String.valueOf(curRequest.getServerPort());"); //225:1
                __out.AppendLine(false); //225:72
                __out.AppendLine(true); //226:3
                __out.Append("        // eg.: http://remotehost/remoteapp-1.0/getMoviesFromReservation/"); //227:1
                __out.AppendLine(false); //227:74
                string __tmp140Line = "        url = url.replace(serverName, Configuration.getString(\""; //228:1
                if (__tmp140Line != null) __out.Append(__tmp140Line);
                StringBuilder __tmp141 = new StringBuilder();
                __tmp141.Append(targetComponent);
                using(StreamReader __tmp141Reader = new StreamReader(this.__ToStream(__tmp141.ToString())))
                {
                    bool __tmp141_first = true;
                    bool __tmp141_last = __tmp141Reader.EndOfStream;
                    while(__tmp141_first || !__tmp141_last)
                    {
                        __tmp141_first = false;
                        string __tmp141Line = __tmp141Reader.ReadLine();
                        __tmp141_last = __tmp141Reader.EndOfStream;
                        if (__tmp141Line != null) __out.Append(__tmp141Line);
                        if (!__tmp141_last) __out.AppendLine(true);
                    }
                }
                StringBuilder __tmp142 = new StringBuilder();
                __tmp142.Append(bindingType);
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
                string __tmp143Line = "Server\"));"; //228:94
                if (__tmp143Line != null) __out.Append(__tmp143Line);
                __out.AppendLine(false); //228:104
                string __tmp145Line = "        url = url.replace(\":\" + serverPort, \":\" + Configuration.getString(\""; //229:1
                if (__tmp145Line != null) __out.Append(__tmp145Line);
                StringBuilder __tmp146 = new StringBuilder();
                __tmp146.Append(targetComponent);
                using(StreamReader __tmp146Reader = new StreamReader(this.__ToStream(__tmp146.ToString())))
                {
                    bool __tmp146_first = true;
                    bool __tmp146_last = __tmp146Reader.EndOfStream;
                    while(__tmp146_first || !__tmp146_last)
                    {
                        __tmp146_first = false;
                        string __tmp146Line = __tmp146Reader.ReadLine();
                        __tmp146_last = __tmp146Reader.EndOfStream;
                        if (__tmp146Line != null) __out.Append(__tmp146Line);
                        if (!__tmp146_last) __out.AppendLine(true);
                    }
                }
                StringBuilder __tmp147 = new StringBuilder();
                __tmp147.Append(bindingType);
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
                string __tmp148Line = "Port\"));"; //229:106
                if (__tmp148Line != null) __out.Append(__tmp148Line);
                __out.AppendLine(false); //229:114
                __out.Append("        url = url.replace(currentComponentName, targetComponentName);"); //230:1
                __out.AppendLine(false); //230:70
                __out.AppendLine(true); //231:3
                string __tmp150Line = "        this.urlOf"; //232:1
                if (__tmp150Line != null) __out.Append(__tmp150Line);
                StringBuilder __tmp151 = new StringBuilder();
                __tmp151.Append(op.Name.ToPascalCase());
                using(StreamReader __tmp151Reader = new StreamReader(this.__ToStream(__tmp151.ToString())))
                {
                    bool __tmp151_first = true;
                    bool __tmp151_last = __tmp151Reader.EndOfStream;
                    while(__tmp151_first || !__tmp151_last)
                    {
                        __tmp151_first = false;
                        string __tmp151Line = __tmp151Reader.ReadLine();
                        __tmp151_last = __tmp151Reader.EndOfStream;
                        if (__tmp151Line != null) __out.Append(__tmp151Line);
                        if (!__tmp151_last) __out.AppendLine(true);
                    }
                }
                string __tmp152Line = " = url;"; //232:43
                if (__tmp152Line != null) __out.Append(__tmp152Line);
                __out.AppendLine(false); //232:50
                __out.Append("        return url;"); //233:1
                __out.AppendLine(false); //233:20
                __out.Append("    }"); //234:1
                __out.AppendLine(false); //234:6
            }
            __out.Append("}"); //236:1
            __out.AppendLine(false); //236:2
            return __out.ToString();
        }

        public string GenerateCrudRepositoryCopy(string namespaceName, string entityName, string bindingType) //241:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp2Line = "package "; //242:1
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
            string __tmp4Line = "."; //242:34
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
            string __tmp6Line = ";"; //242:84
            if (__tmp6Line != null) __out.Append(__tmp6Line);
            __out.AppendLine(false); //242:85
            __out.AppendLine(true); //243:1
            string __tmp8Line = "import "; //244:1
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
            string __tmp10Line = "."; //244:33
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
            string __tmp12Line = "."; //244:80
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
            string __tmp14Line = ";"; //244:93
            if (__tmp14Line != null) __out.Append(__tmp14Line);
            __out.AppendLine(false); //244:94
            __out.AppendLine(true); //245:1
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
                    __out.AppendLine(false); //246:41
                }
            }
            __out.AppendLine(true); //247:1
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
                    __out.AppendLine(false); //248:35
                }
            }
            string __tmp20Line = "public interface "; //249:1
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
            string __tmp22Line = "Repository"; //249:30
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
            string __tmp24Line = " {"; //249:53
            if (__tmp24Line != null) __out.Append(__tmp24Line);
            __out.AppendLine(false); //249:55
            string __tmp26Line = "	// should copy CrudRepository<"; //250:1
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
            string __tmp28Line = ", Long>"; //250:44
            if (__tmp28Line != null) __out.Append(__tmp28Line);
            __out.AppendLine(false); //250:51
            if (bindingType == "Rest") //252:3
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
                        __out.AppendLine(false); //253:41
                    }
                }
            }
            else //254:3
            {
                __out.AppendLine(true); //255:1
                __out.Append("	public long count();"); //256:1
                __out.AppendLine(false); //256:22
                __out.AppendLine(true); //257:1
                __out.Append("	public void delete(Long id);"); //258:1
                __out.AppendLine(false); //258:30
                __out.AppendLine(true); //259:1
                string __tmp32Line = "	public void delete("; //260:1
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
                string __tmp34Line = " entity);"; //260:33
                if (__tmp34Line != null) __out.Append(__tmp34Line);
                __out.AppendLine(false); //260:42
                __out.AppendLine(true); //261:1
                string __tmp36Line = "	public void delete(Iterable<? extends "; //262:1
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
                string __tmp38Line = "> entities);"; //262:52
                if (__tmp38Line != null) __out.Append(__tmp38Line);
                __out.AppendLine(false); //262:64
                __out.AppendLine(true); //263:1
                __out.Append("	public void deleteAll();"); //264:1
                __out.AppendLine(false); //264:26
                __out.AppendLine(true); //265:1
                __out.Append("	public boolean exists(Long id) ;"); //266:1
                __out.AppendLine(false); //266:34
                __out.AppendLine(true); //267:1
                string __tmp40Line = "	public Iterable<"; //268:1
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
                string __tmp42Line = "> findAll();"; //268:30
                if (__tmp42Line != null) __out.Append(__tmp42Line);
                __out.AppendLine(false); //268:42
                __out.AppendLine(true); //269:1
                string __tmp44Line = "	public Iterable<"; //270:1
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
                string __tmp46Line = "> findAll(Iterable<Long> entities);"; //270:30
                if (__tmp46Line != null) __out.Append(__tmp46Line);
                __out.AppendLine(false); //270:65
                __out.AppendLine(true); //271:1
                string __tmp48Line = "	public "; //272:1
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
                string __tmp50Line = " findOne(Long id);"; //272:21
                if (__tmp50Line != null) __out.Append(__tmp50Line);
                __out.AppendLine(false); //272:39
                __out.AppendLine(true); //273:1
                string __tmp52Line = "	public <S extends "; //274:1
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
                string __tmp54Line = "> S save(S entity);"; //274:32
                if (__tmp54Line != null) __out.Append(__tmp54Line);
                __out.AppendLine(false); //274:51
                __out.AppendLine(true); //275:1
                string __tmp56Line = "	public <S extends "; //276:1
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
                string __tmp58Line = "> Iterable<S> save(Iterable<S> entities);"; //276:32
                if (__tmp58Line != null) __out.Append(__tmp58Line);
                __out.AppendLine(false); //276:73
            }
            __out.AppendLine(true); //278:1
            __out.Append("}"); //279:1
            __out.AppendLine(false); //279:2
            return __out.ToString();
        }

        public string GenerateImportsForBinding(string bindingType) //283:1
        {
            StringBuilder __out = new StringBuilder();
            if (bindingType == "Rest") //284:3
            {
                __out.Append("import org.springframework.web.bind.annotation.PathVariable;"); //285:1
                __out.AppendLine(false); //285:61
                __out.Append("import org.springframework.web.bind.annotation.RequestMapping;"); //286:1
                __out.AppendLine(false); //286:63
                __out.Append("import org.springframework.web.bind.annotation.RequestMethod;"); //287:1
                __out.AppendLine(false); //287:62
                __out.Append("import org.springframework.web.bind.annotation.RestController;"); //288:1
                __out.AppendLine(false); //288:63
            }
            if (bindingType.Equals("WebService")) //290:3
            {
                __out.Append("//import ?;"); //291:1
                __out.AppendLine(false); //291:12
            }
            if (bindingType.Equals("WebSocket")) //293:3
            {
                __out.Append("//import ?;"); //294:1
                __out.AppendLine(false); //294:12
            }
            return __out.ToString();
        }

        public string GenerateCrudMethodsForRest(string entityName) //299:1
        {
            StringBuilder __out = new StringBuilder();
            __out.AppendLine(true); //300:1
            __out.Append("	@RequestMapping(value = \"/count\")"); //301:1
            __out.AppendLine(false); //301:35
            __out.Append("	public long count();"); //302:1
            __out.AppendLine(false); //302:22
            __out.AppendLine(true); //303:1
            __out.Append("	@RequestMapping(value = \"/delete/{id}\", method = RequestMethod.POST) // TODO Http.Delete method?"); //304:1
            __out.AppendLine(false); //304:98
            __out.Append("	public void delete(@PathVariable Long id);"); //305:1
            __out.AppendLine(false); //305:44
            __out.AppendLine(true); //306:1
            __out.Append("	@RequestMapping(value = \"/delete\", method = RequestMethod.POST) // TODO Http.Delete method?"); //307:1
            __out.AppendLine(false); //307:93
            string __tmp2Line = "	public void delete(@RequestBody "; //308:1
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
            string __tmp4Line = " entity);"; //308:46
            if (__tmp4Line != null) __out.Append(__tmp4Line);
            __out.AppendLine(false); //308:55
            __out.AppendLine(true); //309:1
            __out.Append("	@RequestMapping(value = \"/delete\", method = RequestMethod.POST) // TODO Http.Delete method?"); //310:1
            __out.AppendLine(false); //310:93
            string __tmp6Line = "	public void delete(@RequestBody Iterable<? extends "; //311:1
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
            string __tmp8Line = "> entities);"; //311:65
            if (__tmp8Line != null) __out.Append(__tmp8Line);
            __out.AppendLine(false); //311:77
            __out.AppendLine(true); //312:1
            __out.Append("	@RequestMapping(value = \"/deleteAll\", method = RequestMethod.POST) // TODO Http.Delete method?"); //313:1
            __out.AppendLine(false); //313:96
            __out.Append("	public void deleteAll();"); //314:1
            __out.AppendLine(false); //314:26
            __out.AppendLine(true); //315:1
            __out.Append("	@RequestMapping(value = \"/exists/{id}\")"); //316:1
            __out.AppendLine(false); //316:41
            __out.Append("	public boolean exists(@PathVariable Long id) ;"); //317:1
            __out.AppendLine(false); //317:48
            __out.AppendLine(true); //318:1
            __out.Append("	@RequestMapping(value = \"/findAll\")"); //319:1
            __out.AppendLine(false); //319:37
            string __tmp10Line = "	public Iterable<"; //320:1
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
            string __tmp12Line = "> findAll();"; //320:30
            if (__tmp12Line != null) __out.Append(__tmp12Line);
            __out.AppendLine(false); //320:42
            __out.AppendLine(true); //321:1
            __out.Append("	@RequestMapping(value = \"/findAll\")"); //322:1
            __out.AppendLine(false); //322:37
            string __tmp14Line = "	public Iterable<"; //323:1
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
            string __tmp16Line = "> findAll(@RequestBody Iterable<Long> entities);"; //323:30
            if (__tmp16Line != null) __out.Append(__tmp16Line);
            __out.AppendLine(false); //323:78
            __out.AppendLine(true); //324:1
            __out.Append("	@RequestMapping(value = \"/findOne/{id}\")"); //325:1
            __out.AppendLine(false); //325:42
            string __tmp18Line = "	public "; //326:1
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
            string __tmp20Line = " findOne(@PathVariable Long id);"; //326:21
            if (__tmp20Line != null) __out.Append(__tmp20Line);
            __out.AppendLine(false); //326:53
            __out.AppendLine(true); //327:1
            __out.Append("	@RequestMapping(value = \"/save\")"); //328:1
            __out.AppendLine(false); //328:34
            string __tmp22Line = "	public <S extends "; //329:1
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
            string __tmp24Line = "> S save(@RequestBody S entity);"; //329:32
            if (__tmp24Line != null) __out.Append(__tmp24Line);
            __out.AppendLine(false); //329:64
            __out.AppendLine(true); //330:1
            __out.Append("	@RequestMapping(value = \"/save\")"); //331:1
            __out.AppendLine(false); //331:34
            string __tmp26Line = "	public <S extends "; //332:1
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
            string __tmp28Line = "> Iterable<S> save(@RequestBody Iterable<S> entities);"; //332:32
            if (__tmp28Line != null) __out.Append(__tmp28Line);
            __out.AppendLine(false); //332:86
            return __out.ToString();
        }

        public string GenerateRepositoryProxyImpl(string namespaceName, string entityName, string bindingType) //336:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp2Line = "package "; //337:1
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
            string __tmp4Line = "."; //337:34
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
            string __tmp6Line = ";"; //337:85
            if (__tmp6Line != null) __out.Append(__tmp6Line);
            __out.AppendLine(false); //337:86
            __out.AppendLine(true); //338:1
            __out.Append("import org.springframework.beans.factory.annotation.Autowired;"); //339:1
            __out.AppendLine(false); //339:63
            __out.AppendLine(true); //340:1
            string __tmp8Line = "import "; //341:1
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
            string __tmp10Line = "."; //341:33
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
            string __tmp12Line = "."; //341:80
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
            string __tmp14Line = ";"; //341:93
            if (__tmp14Line != null) __out.Append(__tmp14Line);
            __out.AppendLine(false); //341:94
            string __tmp16Line = "import "; //342:1
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
            string __tmp18Line = "."; //342:33
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
            string __tmp20Line = "."; //342:84
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
            string __tmp22Line = "Repository;"; //342:97
            if (__tmp22Line != null) __out.Append(__tmp22Line);
            __out.AppendLine(false); //342:108
            string __tmp24Line = "import "; //343:1
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
            string __tmp26Line = "."; //343:33
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
            string __tmp28Line = "."; //343:83
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
            string __tmp30Line = "Repository"; //343:96
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
            string __tmp32Line = ";"; //343:119
            if (__tmp32Line != null) __out.Append(__tmp32Line);
            __out.AppendLine(false); //343:120
            __out.AppendLine(true); //344:1
            string __tmp34Line = "public class "; //345:1
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
            string __tmp36Line = "Repository"; //345:26
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
            string __tmp38Line = "Impl implements "; //345:49
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
            string __tmp40Line = "Repository"; //345:77
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
            string __tmp42Line = " {"; //345:100
            if (__tmp42Line != null) __out.Append(__tmp42Line);
            __out.AppendLine(false); //345:102
            __out.AppendLine(true); //346:1
            __out.Append("	@Autowired"); //347:1
            __out.AppendLine(false); //347:12
            string __tmp43Prefix = "	"; //348:1
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
            string __tmp45Line = "Repository repository;"; //348:14
            if (__tmp45Line != null) __out.Append(__tmp45Line);
            __out.AppendLine(false); //348:36
            __out.AppendLine(true); //349:1
            __out.Append("	@Override"); //350:1
            __out.AppendLine(false); //350:11
            __out.Append("	public long count() {"); //351:1
            __out.AppendLine(false); //351:23
            __out.Append("		return repository.count();"); //352:1
            __out.AppendLine(false); //352:29
            __out.Append("	}"); //353:1
            __out.AppendLine(false); //353:3
            __out.AppendLine(true); //354:1
            __out.Append("	@Override"); //355:1
            __out.AppendLine(false); //355:11
            __out.Append("	public void delete(Long id) {"); //356:1
            __out.AppendLine(false); //356:31
            __out.Append("		repository.delete(id);"); //357:1
            __out.AppendLine(false); //357:25
            __out.Append("	}"); //358:1
            __out.AppendLine(false); //358:3
            __out.AppendLine(true); //359:1
            __out.Append("	@Override"); //360:1
            __out.AppendLine(false); //360:11
            string __tmp47Line = "	public void delete("; //361:1
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
            string __tmp49Line = " entity) {"; //361:33
            if (__tmp49Line != null) __out.Append(__tmp49Line);
            __out.AppendLine(false); //361:43
            __out.Append("		repository.delete(entity);"); //362:1
            __out.AppendLine(false); //362:29
            __out.Append("	}"); //363:1
            __out.AppendLine(false); //363:3
            __out.AppendLine(true); //364:1
            __out.Append("	@Override"); //365:1
            __out.AppendLine(false); //365:11
            string __tmp51Line = "	public void delete(Iterable<? extends "; //366:1
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
            string __tmp53Line = "> entities) {"; //366:52
            if (__tmp53Line != null) __out.Append(__tmp53Line);
            __out.AppendLine(false); //366:65
            __out.Append("		repository.delete(entities);"); //367:1
            __out.AppendLine(false); //367:31
            __out.Append("	}"); //368:1
            __out.AppendLine(false); //368:3
            __out.AppendLine(true); //369:1
            __out.Append("	@Override"); //370:1
            __out.AppendLine(false); //370:11
            __out.Append("	public void deleteAll() {"); //371:1
            __out.AppendLine(false); //371:27
            __out.Append("		repository.deleteAll();"); //372:1
            __out.AppendLine(false); //372:26
            __out.Append("	}"); //373:1
            __out.AppendLine(false); //373:3
            __out.AppendLine(true); //374:1
            __out.Append("	@Override"); //375:1
            __out.AppendLine(false); //375:11
            __out.Append("	public boolean exists(Long id) {"); //376:1
            __out.AppendLine(false); //376:34
            __out.Append("		return repository.exists(id);"); //377:1
            __out.AppendLine(false); //377:32
            __out.Append("	}"); //378:1
            __out.AppendLine(false); //378:3
            __out.AppendLine(true); //379:1
            __out.Append("	@Override"); //380:1
            __out.AppendLine(false); //380:11
            string __tmp55Line = "	public Iterable<"; //381:1
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
            string __tmp57Line = "> findAll() {"; //381:30
            if (__tmp57Line != null) __out.Append(__tmp57Line);
            __out.AppendLine(false); //381:43
            __out.Append("		return repository.findAll();"); //382:1
            __out.AppendLine(false); //382:31
            __out.Append("	}"); //383:1
            __out.AppendLine(false); //383:3
            __out.AppendLine(true); //384:1
            __out.Append("	@Override"); //385:1
            __out.AppendLine(false); //385:11
            string __tmp59Line = "	public Iterable<"; //386:1
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
            string __tmp61Line = "> findAll(Iterable<Long> entities) {"; //386:30
            if (__tmp61Line != null) __out.Append(__tmp61Line);
            __out.AppendLine(false); //386:66
            __out.Append("		return repository.findAll(entities);"); //387:1
            __out.AppendLine(false); //387:39
            __out.Append("	}"); //388:1
            __out.AppendLine(false); //388:3
            __out.AppendLine(true); //389:1
            __out.Append("	@Override"); //390:1
            __out.AppendLine(false); //390:11
            string __tmp63Line = "	public "; //391:1
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
            string __tmp65Line = " findOne(Long id) {"; //391:21
            if (__tmp65Line != null) __out.Append(__tmp65Line);
            __out.AppendLine(false); //391:40
            __out.Append("		return repository.findOne(id);"); //392:1
            __out.AppendLine(false); //392:33
            __out.Append("	}"); //393:1
            __out.AppendLine(false); //393:3
            __out.AppendLine(true); //394:1
            __out.Append("	@Override"); //395:1
            __out.AppendLine(false); //395:11
            string __tmp67Line = "	public <S extends "; //396:1
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
            string __tmp69Line = "> S save(S entity) {"; //396:32
            if (__tmp69Line != null) __out.Append(__tmp69Line);
            __out.AppendLine(false); //396:52
            __out.Append("		return repository.save(entity);"); //397:1
            __out.AppendLine(false); //397:34
            __out.Append("	}"); //398:1
            __out.AppendLine(false); //398:3
            __out.AppendLine(true); //399:1
            __out.Append("	@Override"); //400:1
            __out.AppendLine(false); //400:11
            string __tmp71Line = "	public <S extends "; //401:1
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
            string __tmp73Line = "> Iterable<S> save(Iterable<S> entities) {"; //401:32
            if (__tmp73Line != null) __out.Append(__tmp73Line);
            __out.AppendLine(false); //401:74
            __out.Append("		return repository.save(entities);"); //402:1
            __out.AppendLine(false); //402:36
            __out.Append("	}"); //403:1
            __out.AppendLine(false); //403:3
            __out.AppendLine(true); //404:1
            __out.Append("}"); //405:1
            __out.AppendLine(false); //405:2
            return __out.ToString();
        }

        public string InterfaceAnnotation(string bindingType) //409:1
        {
            StringBuilder __out = new StringBuilder();
            if (bindingType.Equals("Rest")) //410:3
            {
                __out.Append("@RestController"); //411:1
                __out.AppendLine(false); //411:16
                __out.Append("@RequestMapping(method = RequestMethod.GET)"); //412:1
                __out.AppendLine(false); //412:44
            }
            else if (bindingType.Equals("WebService")) //413:3
            {
                __out.Append("//@WebService"); //414:1
                __out.AppendLine(false); //414:14
            }
            else if (bindingType.Equals("WebSockett")) //415:3
            {
                __out.Append("//@WebSocket"); //416:1
                __out.AppendLine(false); //416:13
            }
            return __out.ToString();
        }

        public string OperationAnnotation(Operation op, string bindingType) //422:1
        {
            StringBuilder __out = new StringBuilder();
            if (bindingType.Equals("Rest")) //423:3
            {
                string __tmp2Line = "	@RequestMapping(value = \"/"; //424:1
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
                    (from __loop12_var1 in __Enumerate((op).GetEnumerator()) //425:9
                    from param in __Enumerate((__loop12_var1.Parameters).GetEnumerator()) //425:13
                    select new { __loop12_var1 = __loop12_var1, param = param}
                    ).ToList(); //425:4
                int __loop12_iteration = 0;
                foreach (var __tmp4 in __loop12_results)
                {
                    ++__loop12_iteration;
                    var __loop12_var1 = __tmp4.__loop12_var1;
                    var param = __tmp4.param;
                    if (param.Type.IsJavaPrimitiveType()) //426:5
                    {
                        string __tmp6Line = "/{"; //427:1
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
                        string __tmp8Line = "}"; //427:15
                        if (__tmp8Line != null) __out.Append(__tmp8Line);
                    }
                }
                __out.Append("\""); //430:1
                if (!op.Name.ToPascalCase().StartsWith("Get")) //431:4
                {
                    __out.Append(", method = RequestMethod.POST /* TODO consider other method */"); //432:1
                }
                __out.Append(")"); //434:1
                __out.AppendLine(false); //434:2
            }
            else if (bindingType.Equals("WebService")) //435:3
            {
                __out.Append("	//@WebService"); //436:1
                __out.AppendLine(false); //436:15
            }
            else if (bindingType.Equals("WebSockett")) //437:3
            {
                __out.Append("	//@WebSocket"); //438:1
                __out.AppendLine(false); //438:14
            }
            return __out.ToString();
        }

        public string ParameterAnnotation(InputParameter parameter, string bindingType) //444:1
        {
            StringBuilder __out = new StringBuilder();
            if (bindingType.Equals("Rest")) //445:3
            {
                if (parameter.Type.IsJavaPrimitiveType()) //446:4
                {
                    __out.Append("@PathVariable "); //447:1
                }
            }
            else if (bindingType.Equals("WebService")) //449:3
            {
            }
            else if (bindingType.Equals("WebSockett")) //451:3
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
