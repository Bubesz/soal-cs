using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Soal //1:1
{
    using __Hidden_SpringInterfaceGenerator_106952864;
    namespace __Hidden_SpringInterfaceGenerator_106952864
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

        public string GenerateProxyForInterface(Interface iface, string bindingType, string package, string currentComponent, string targetComponent) //107:1
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
            string __tmp12Line = "."; //123:57
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
            string __tmp15Line = ";"; //123:83
            if (__tmp15Line != null) __out.Append(__tmp15Line);
            __out.AppendLine(false); //123:84
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
            string __tmp27Line = "	private final String currentComponentName = \""; //134:1
            if (__tmp27Line != null) __out.Append(__tmp27Line);
            StringBuilder __tmp28 = new StringBuilder();
            __tmp28.Append(iface.Namespace.Name);
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
            string __tmp29Line = "-"; //134:69
            if (__tmp29Line != null) __out.Append(__tmp29Line);
            StringBuilder __tmp30 = new StringBuilder();
            __tmp30.Append(currentComponent);
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
            string __tmp31Line = "\";"; //134:88
            if (__tmp31Line != null) __out.Append(__tmp31Line);
            __out.AppendLine(false); //134:90
            string __tmp33Line = "    private final String targetComponentName = \""; //135:1
            if (__tmp33Line != null) __out.Append(__tmp33Line);
            StringBuilder __tmp34 = new StringBuilder();
            __tmp34.Append(iface.Namespace.Name);
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
            string __tmp35Line = "-"; //135:71
            if (__tmp35Line != null) __out.Append(__tmp35Line);
            StringBuilder __tmp36 = new StringBuilder();
            __tmp36.Append(targetComponent);
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
            string __tmp37Line = "\";"; //135:89
            if (__tmp37Line != null) __out.Append(__tmp37Line);
            __out.AppendLine(false); //135:91
            __out.AppendLine(true); //136:2
            int i = 1; //137:2
            var __loop6_results = 
                (from __loop6_var1 in __Enumerate((iface).GetEnumerator()) //138:7
                from op in __Enumerate((__loop6_var1.Operations).GetEnumerator()) //138:14
                select new { __loop6_var1 = __loop6_var1, op = op}
                ).ToList(); //138:2
            int __loop6_iteration = 0;
            foreach (var __tmp38 in __loop6_results)
            {
                ++__loop6_iteration;
                var __loop6_var1 = __tmp38.__loop6_var1;
                var op = __tmp38.op;
                string __tmp40Line = "	private String url"; //139:1
                if (__tmp40Line != null) __out.Append(__tmp40Line);
                StringBuilder __tmp41 = new StringBuilder();
                __tmp41.Append(i++);
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
                string __tmp42Line = "Of"; //139:25
                if (__tmp42Line != null) __out.Append(__tmp42Line);
                StringBuilder __tmp43 = new StringBuilder();
                __tmp43.Append(op.Name.ToPascalCase());
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
                string __tmp44Line = ";"; //139:51
                if (__tmp44Line != null) __out.Append(__tmp44Line);
                __out.AppendLine(false); //139:52
            }
            var __loop7_results = 
                (from __loop7_var1 in __Enumerate((iface).GetEnumerator()) //142:7
                from op in __Enumerate((__loop7_var1.Operations).GetEnumerator()) //142:14
                select new { __loop7_var1 = __loop7_var1, op = op}
                ).ToList(); //142:2
            int __loop7_iteration = 0;
            foreach (var __tmp45 in __loop7_results)
            {
                ++__loop7_iteration;
                var __loop7_var1 = __tmp45.__loop7_var1;
                var op = __tmp45.op;
                __out.AppendLine(true); //143:1
                string resultJavaName = op.Result.Type.GetJavaName(); //144:3
                __out.Append("	@Override"); //145:1
                __out.AppendLine(false); //145:11
                string __tmp47Line = "	public "; //146:1
                if (__tmp47Line != null) __out.Append(__tmp47Line);
                StringBuilder __tmp48 = new StringBuilder();
                __tmp48.Append(resultJavaName);
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
                string __tmp49Line = " "; //146:25
                if (__tmp49Line != null) __out.Append(__tmp49Line);
                StringBuilder __tmp50 = new StringBuilder();
                __tmp50.Append(op.Name.ToCamelCase());
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
                string __tmp51Line = "("; //146:49
                if (__tmp51Line != null) __out.Append(__tmp51Line);
                StringBuilder __tmp52 = new StringBuilder();
                __tmp52.Append(SpringGeneratorUtil.GetParameterList(op));
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
                string __tmp53Line = ")"; //146:92
                if (__tmp53Line != null) __out.Append(__tmp53Line);
                if (op.Exceptions.Any()) //147:3
                {
                    string __tmp55Line = " throws "; //148:1
                    if (__tmp55Line != null) __out.Append(__tmp55Line);
                    StringBuilder __tmp56 = new StringBuilder();
                    __tmp56.Append(SpringGeneratorUtil.GetExceptionList(op));
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
                }
                __out.Append(" {"); //150:1
                __out.AppendLine(false); //150:3
                string __tmp58Line = "		String url = getUrlOf"; //151:1
                if (__tmp58Line != null) __out.Append(__tmp58Line);
                StringBuilder __tmp59 = new StringBuilder();
                __tmp59.Append(op.Name.ToPascalCase());
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
                string __tmp60Line = "("; //151:48
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
                string __tmp62Line = ");"; //151:95
                if (__tmp62Line != null) __out.Append(__tmp62Line);
                __out.AppendLine(false); //151:97
                string method = "POST"; //153:3
                if (op.Name.ToPascalCase().StartsWith("Get")) //154:3
                {
                    method = "GET";
                }
                string extraVariable = ""; //158:3
                if (method == "POST") //159:3
                {
                    extraVariable = "request, ";
                    __out.Append("		HttpEntity<?> request = null;"); //161:1
                    __out.AppendLine(false); //161:32
                    __out.Append("		this.restTemplate.getMessageConverters().add(new MappingJackson2HttpMessageConverter());"); //162:1
                    __out.AppendLine(false); //162:91
                    var __loop8_results = 
                        (from __loop8_var1 in __Enumerate((op).GetEnumerator()) //163:9
                        from param in __Enumerate((__loop8_var1.Parameters).GetEnumerator()) //163:13
                        where !param.Type.IsJavaPrimitiveType() //163:30
                        select new { __loop8_var1 = __loop8_var1, param = param}
                        ).ToList(); //163:4
                    int __loop8_iteration = 0;
                    foreach (var __tmp63 in __loop8_results)
                    {
                        ++__loop8_iteration;
                        var __loop8_var1 = __tmp63.__loop8_var1;
                        var param = __tmp63.param;
                        string __tmp65Line = "		request = new HttpEntity<"; //164:1
                        if (__tmp65Line != null) __out.Append(__tmp65Line);
                        StringBuilder __tmp66 = new StringBuilder();
                        __tmp66.Append(param.Type.GetJavaName());
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
                        string __tmp67Line = ">("; //164:54
                        if (__tmp67Line != null) __out.Append(__tmp67Line);
                        StringBuilder __tmp68 = new StringBuilder();
                        __tmp68.Append(param.Name);
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
                        string __tmp69Line = ");"; //164:68
                        if (__tmp69Line != null) __out.Append(__tmp69Line);
                        __out.AppendLine(false); //164:70
                    }
                }
                ArrayType array = op.Result.Type as ArrayType; //168:3
                if (array != null) //169:3
                {
                    string __tmp70Prefix = "		"; //170:1
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
                            __out.Append(__tmp70Prefix);
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
                    string __tmp73Line = " response = restTemplate."; //170:40
                    if (__tmp73Line != null) __out.Append(__tmp73Line);
                    StringBuilder __tmp74 = new StringBuilder();
                    __tmp74.Append(method.ToLower());
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
                    string __tmp75Line = "ForObject(url, "; //170:83
                    if (__tmp75Line != null) __out.Append(__tmp75Line);
                    StringBuilder __tmp76 = new StringBuilder();
                    __tmp76.Append(extraVariable);
                    using(StreamReader __tmp76Reader = new StreamReader(this.__ToStream(__tmp76.ToString())))
                    {
                        bool __tmp76_first = true;
                        bool __tmp76_last = __tmp76Reader.EndOfStream;
                        while(__tmp76_first || !__tmp76_last)
                        {
                            __tmp76_first = false;
                            string __tmp76Line = __tmp76Reader.ReadLine();
                            __tmp76_last = __tmp76Reader.EndOfStream;
                            if (__tmp76Line != null) __out.Append(__tmp76Line);
                            if (!__tmp76_last) __out.AppendLine(true);
                        }
                    }
                    StringBuilder __tmp77 = new StringBuilder();
                    __tmp77.Append(array.InnerType.GetJavaName());
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
                    StringBuilder __tmp78 = new StringBuilder();
                    __tmp78.Append("[]");
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
                    string __tmp79Line = ".class);"; //170:150
                    if (__tmp79Line != null) __out.Append(__tmp79Line);
                    __out.AppendLine(false); //170:158
                }
                else if (resultJavaName != "void") //171:3
                {
                    string __tmp80Prefix = "		"; //172:1
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
                            __out.Append(__tmp80Prefix);
                            if (__tmp81Line != null) __out.Append(__tmp81Line);
                            if (!__tmp81_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp82Line = " response = restTemplate."; //172:19
                    if (__tmp82Line != null) __out.Append(__tmp82Line);
                    StringBuilder __tmp83 = new StringBuilder();
                    __tmp83.Append(method.ToLower());
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
                    string __tmp84Line = "ForObject(url, "; //172:62
                    if (__tmp84Line != null) __out.Append(__tmp84Line);
                    StringBuilder __tmp85 = new StringBuilder();
                    __tmp85.Append(extraVariable);
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
                    StringBuilder __tmp86 = new StringBuilder();
                    __tmp86.Append(resultJavaName);
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
                    string __tmp87Line = ".class);"; //172:108
                    if (__tmp87Line != null) __out.Append(__tmp87Line);
                    __out.AppendLine(false); //172:116
                }
                else //173:3
                {
                    string __tmp89Line = "		restTemplate."; //174:1
                    if (__tmp89Line != null) __out.Append(__tmp89Line);
                    StringBuilder __tmp90 = new StringBuilder();
                    __tmp90.Append(method.ToLower());
                    using(StreamReader __tmp90Reader = new StreamReader(this.__ToStream(__tmp90.ToString())))
                    {
                        bool __tmp90_first = true;
                        bool __tmp90_last = __tmp90Reader.EndOfStream;
                        while(__tmp90_first || !__tmp90_last)
                        {
                            __tmp90_first = false;
                            string __tmp90Line = __tmp90Reader.ReadLine();
                            __tmp90_last = __tmp90Reader.EndOfStream;
                            if (__tmp90Line != null) __out.Append(__tmp90Line);
                            if (!__tmp90_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp91Line = "ForObject(url, "; //174:34
                    if (__tmp91Line != null) __out.Append(__tmp91Line);
                    StringBuilder __tmp92 = new StringBuilder();
                    __tmp92.Append(extraVariable);
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
                    string __tmp93Line = "Object.class);"; //174:64
                    if (__tmp93Line != null) __out.Append(__tmp93Line);
                    __out.AppendLine(false); //174:78
                }
                if (array != null) //177:3
                {
                    __out.Append("		return Arrays.stream(response).collect(Collectors.toList());"); //178:1
                    __out.AppendLine(false); //178:63
                }
                else if (resultJavaName != "void") //179:3
                {
                    __out.Append("		return response;"); //180:1
                    __out.AppendLine(false); //180:19
                }
                else //181:3
                {
                    __out.Append("		return;"); //182:1
                    __out.AppendLine(false); //182:10
                }
                __out.Append("	}"); //184:1
                __out.AppendLine(false); //184:3
            }
            i = 1;
            var __loop9_results = 
                (from __loop9_var1 in __Enumerate((iface).GetEnumerator()) //188:7
                from op in __Enumerate((__loop9_var1.Operations).GetEnumerator()) //188:14
                select new { __loop9_var1 = __loop9_var1, op = op}
                ).ToList(); //188:2
            int __loop9_iteration = 0;
            foreach (var __tmp94 in __loop9_results)
            {
                ++__loop9_iteration;
                var __loop9_var1 = __tmp94.__loop9_var1;
                var op = __tmp94.op;
                __out.AppendLine(true); //189:2
                string __tmp96Line = "	private String getUrlOf"; //190:1
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
                string __tmp98Line = "("; //190:49
                if (__tmp98Line != null) __out.Append(__tmp98Line);
                StringBuilder __tmp99 = new StringBuilder();
                __tmp99.Append(SpringGeneratorUtil.GetParameterList(op));
                using(StreamReader __tmp99Reader = new StreamReader(this.__ToStream(__tmp99.ToString())))
                {
                    bool __tmp99_first = true;
                    bool __tmp99_last = __tmp99Reader.EndOfStream;
                    while(__tmp99_first || !__tmp99_last)
                    {
                        __tmp99_first = false;
                        string __tmp99Line = __tmp99Reader.ReadLine();
                        __tmp99_last = __tmp99Reader.EndOfStream;
                        if (__tmp99Line != null) __out.Append(__tmp99Line);
                        if (!__tmp99_last) __out.AppendLine(true);
                    }
                }
                string __tmp100Line = ") {"; //190:92
                if (__tmp100Line != null) __out.Append(__tmp100Line);
                __out.AppendLine(false); //190:95
                string __tmp102Line = "        if (this.url"; //191:1
                if (__tmp102Line != null) __out.Append(__tmp102Line);
                StringBuilder __tmp103 = new StringBuilder();
                __tmp103.Append(i);
                using(StreamReader __tmp103Reader = new StreamReader(this.__ToStream(__tmp103.ToString())))
                {
                    bool __tmp103_first = true;
                    bool __tmp103_last = __tmp103Reader.EndOfStream;
                    while(__tmp103_first || !__tmp103_last)
                    {
                        __tmp103_first = false;
                        string __tmp103Line = __tmp103Reader.ReadLine();
                        __tmp103_last = __tmp103Reader.EndOfStream;
                        if (__tmp103Line != null) __out.Append(__tmp103Line);
                        if (!__tmp103_last) __out.AppendLine(true);
                    }
                }
                string __tmp104Line = "Of"; //191:24
                if (__tmp104Line != null) __out.Append(__tmp104Line);
                StringBuilder __tmp105 = new StringBuilder();
                __tmp105.Append(op.Name.ToPascalCase());
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
                string __tmp106Line = " != null) {"; //191:50
                if (__tmp106Line != null) __out.Append(__tmp106Line);
                __out.AppendLine(false); //191:61
                string __tmp108Line = "            return this.url"; //192:1
                if (__tmp108Line != null) __out.Append(__tmp108Line);
                StringBuilder __tmp109 = new StringBuilder();
                __tmp109.Append(i);
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
                string __tmp110Line = "Of"; //192:31
                if (__tmp110Line != null) __out.Append(__tmp110Line);
                StringBuilder __tmp111 = new StringBuilder();
                __tmp111.Append(op.Name.ToPascalCase());
                using(StreamReader __tmp111Reader = new StreamReader(this.__ToStream(__tmp111.ToString())))
                {
                    bool __tmp111_first = true;
                    bool __tmp111_last = __tmp111Reader.EndOfStream;
                    while(__tmp111_first || !__tmp111_last)
                    {
                        __tmp111_first = false;
                        string __tmp111Line = __tmp111Reader.ReadLine();
                        __tmp111_last = __tmp111Reader.EndOfStream;
                        if (__tmp111Line != null) __out.Append(__tmp111Line);
                        if (!__tmp111_last) __out.AppendLine(true);
                    }
                }
                string __tmp112Line = ";"; //192:57
                if (__tmp112Line != null) __out.Append(__tmp112Line);
                __out.AppendLine(false); //192:58
                __out.Append("        }"); //193:1
                __out.AppendLine(false); //193:10
                __out.AppendLine(true); //194:3
                __out.Append("        // eg.: http://localhost/localapp-1.0/getMoviesFromReservation/"); //195:1
                __out.AppendLine(false); //195:72
                if (op.Result.Type.GetJavaName() == "void") //196:3
                {
                    __out.Append("		String url = null;"); //197:1
                    __out.AppendLine(false); //197:21
                    __out.Append("		try {"); //198:1
                    __out.AppendLine(false); //198:8
                    string __tmp114Line = "			java.lang.reflect.Method method = "; //199:1
                    if (__tmp114Line != null) __out.Append(__tmp114Line);
                    StringBuilder __tmp115 = new StringBuilder();
                    __tmp115.Append(iface.Name + bindingType);
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
                    string __tmp116Line = ".class.getMethod(\""; //199:64
                    if (__tmp116Line != null) __out.Append(__tmp116Line);
                    StringBuilder __tmp117 = new StringBuilder();
                    __tmp117.Append(op.Name.ToCamelCase());
                    using(StreamReader __tmp117Reader = new StreamReader(this.__ToStream(__tmp117.ToString())))
                    {
                        bool __tmp117_first = true;
                        bool __tmp117_last = __tmp117Reader.EndOfStream;
                        while(__tmp117_first || !__tmp117_last)
                        {
                            __tmp117_first = false;
                            string __tmp117Line = __tmp117Reader.ReadLine();
                            __tmp117_last = __tmp117Reader.EndOfStream;
                            if (__tmp117Line != null) __out.Append(__tmp117Line);
                            if (!__tmp117_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp118Line = "\""; //199:105
                    if (__tmp118Line != null) __out.Append(__tmp118Line);
                    StringBuilder __tmp119 = new StringBuilder();
                    __tmp119.Append(SpringGeneratorUtil.GetParameterTypeList(op));
                    using(StreamReader __tmp119Reader = new StreamReader(this.__ToStream(__tmp119.ToString())))
                    {
                        bool __tmp119_first = true;
                        bool __tmp119_last = __tmp119Reader.EndOfStream;
                        while(__tmp119_first || !__tmp119_last)
                        {
                            __tmp119_first = false;
                            string __tmp119Line = __tmp119Reader.ReadLine();
                            __tmp119_last = __tmp119Reader.EndOfStream;
                            if (__tmp119Line != null) __out.Append(__tmp119Line);
                            if (!__tmp119_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp120Line = ");"; //199:152
                    if (__tmp120Line != null) __out.Append(__tmp120Line);
                    __out.AppendLine(false); //199:154
                    string __tmp122Line = "			Link link = linkTo("; //200:1
                    if (__tmp122Line != null) __out.Append(__tmp122Line);
                    StringBuilder __tmp123 = new StringBuilder();
                    __tmp123.Append(iface.Name + bindingType);
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
                    string __tmp124Line = ".class, method"; //200:49
                    if (__tmp124Line != null) __out.Append(__tmp124Line);
                    if (SpringGeneratorUtil.GetParameterNameList(op).Any()) //201:2
                    {
                        string __tmp126Line = ", "; //202:1
                        if (__tmp126Line != null) __out.Append(__tmp126Line);
                        StringBuilder __tmp127 = new StringBuilder();
                        __tmp127.Append(SpringGeneratorUtil.GetParameterNameList(op));
                        using(StreamReader __tmp127Reader = new StreamReader(this.__ToStream(__tmp127.ToString())))
                        {
                            bool __tmp127_first = true;
                            bool __tmp127_last = __tmp127Reader.EndOfStream;
                            while(__tmp127_first || !__tmp127_last)
                            {
                                __tmp127_first = false;
                                string __tmp127Line = __tmp127Reader.ReadLine();
                                __tmp127_last = __tmp127Reader.EndOfStream;
                                if (__tmp127Line != null) __out.Append(__tmp127Line);
                                if (!__tmp127_last) __out.AppendLine(true);
                            }
                        }
                    }
                    __out.Append(").withSelfRel();"); //204:1
                    __out.AppendLine(false); //204:17
                    __out.Append("			url = link.getHref();"); //205:1
                    __out.AppendLine(false); //205:25
                    __out.Append("		} catch (NoSuchMethodException e) {"); //206:1
                    __out.AppendLine(false); //206:38
                    __out.Append("			// TODO handle execption properly"); //207:1
                    __out.AppendLine(false); //207:37
                    __out.Append("			throw new RuntimeException(e);"); //208:1
                    __out.AppendLine(false); //208:34
                    __out.Append("		}"); //209:1
                    __out.AppendLine(false); //209:4
                }
                else if (op.Exceptions.Any()) //211:3
                {
                    __out.Append("		String url = null;"); //212:1
                    __out.AppendLine(false); //212:21
                    __out.Append("		try {"); //213:1
                    __out.AppendLine(false); //213:8
                    string __tmp129Line = "			Link link = linkTo(methodOn("; //214:1
                    if (__tmp129Line != null) __out.Append(__tmp129Line);
                    StringBuilder __tmp130 = new StringBuilder();
                    __tmp130.Append(iface.Name + bindingType);
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
                    string __tmp131Line = ".class)."; //214:58
                    if (__tmp131Line != null) __out.Append(__tmp131Line);
                    StringBuilder __tmp132 = new StringBuilder();
                    __tmp132.Append(op.Name.ToCamelCase());
                    using(StreamReader __tmp132Reader = new StreamReader(this.__ToStream(__tmp132.ToString())))
                    {
                        bool __tmp132_first = true;
                        bool __tmp132_last = __tmp132Reader.EndOfStream;
                        while(__tmp132_first || !__tmp132_last)
                        {
                            __tmp132_first = false;
                            string __tmp132Line = __tmp132Reader.ReadLine();
                            __tmp132_last = __tmp132Reader.EndOfStream;
                            if (__tmp132Line != null) __out.Append(__tmp132Line);
                            if (!__tmp132_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp133Line = "("; //214:89
                    if (__tmp133Line != null) __out.Append(__tmp133Line);
                    StringBuilder __tmp134 = new StringBuilder();
                    __tmp134.Append(SpringGeneratorUtil.GetParameterNameList(op));
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
                    string __tmp135Line = ")).withSelfRel();"; //214:136
                    if (__tmp135Line != null) __out.Append(__tmp135Line);
                    __out.AppendLine(false); //214:153
                    __out.Append("			url = link.getHref();"); //215:1
                    __out.AppendLine(false); //215:25
                    var __loop10_results = 
                        (from __loop10_var1 in __Enumerate((op).GetEnumerator()) //216:9
                        from ex in __Enumerate((__loop10_var1.Exceptions).GetEnumerator()) //216:13
                        select new { __loop10_var1 = __loop10_var1, ex = ex}
                        ).ToList(); //216:4
                    int __loop10_iteration = 0;
                    foreach (var __tmp136 in __loop10_results)
                    {
                        ++__loop10_iteration;
                        var __loop10_var1 = __tmp136.__loop10_var1;
                        var ex = __tmp136.ex;
                        string __tmp138Line = "		} catch ("; //217:1
                        if (__tmp138Line != null) __out.Append(__tmp138Line);
                        StringBuilder __tmp139 = new StringBuilder();
                        __tmp139.Append(ex.GetJavaName());
                        using(StreamReader __tmp139Reader = new StreamReader(this.__ToStream(__tmp139.ToString())))
                        {
                            bool __tmp139_first = true;
                            bool __tmp139_last = __tmp139Reader.EndOfStream;
                            while(__tmp139_first || !__tmp139_last)
                            {
                                __tmp139_first = false;
                                string __tmp139Line = __tmp139Reader.ReadLine();
                                __tmp139_last = __tmp139Reader.EndOfStream;
                                if (__tmp139Line != null) __out.Append(__tmp139Line);
                                if (!__tmp139_last) __out.AppendLine(true);
                            }
                        }
                        string __tmp140Line = " e) {"; //217:30
                        if (__tmp140Line != null) __out.Append(__tmp140Line);
                        __out.AppendLine(false); //217:35
                        __out.Append("			// TODO handle execption properly"); //218:1
                        __out.AppendLine(false); //218:37
                        __out.Append("			throw new RuntimeException(e);"); //219:1
                        __out.AppendLine(false); //219:34
                    }
                    __out.Append("		}"); //221:1
                    __out.AppendLine(false); //221:4
                }
                else //222:3
                {
                    string __tmp142Line = "		Link link = linkTo(methodOn("; //223:1
                    if (__tmp142Line != null) __out.Append(__tmp142Line);
                    StringBuilder __tmp143 = new StringBuilder();
                    __tmp143.Append(iface.Name + bindingType);
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
                    string __tmp144Line = ".class)."; //223:57
                    if (__tmp144Line != null) __out.Append(__tmp144Line);
                    StringBuilder __tmp145 = new StringBuilder();
                    __tmp145.Append(op.Name.ToCamelCase());
                    using(StreamReader __tmp145Reader = new StreamReader(this.__ToStream(__tmp145.ToString())))
                    {
                        bool __tmp145_first = true;
                        bool __tmp145_last = __tmp145Reader.EndOfStream;
                        while(__tmp145_first || !__tmp145_last)
                        {
                            __tmp145_first = false;
                            string __tmp145Line = __tmp145Reader.ReadLine();
                            __tmp145_last = __tmp145Reader.EndOfStream;
                            if (__tmp145Line != null) __out.Append(__tmp145Line);
                            if (!__tmp145_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp146Line = "("; //223:88
                    if (__tmp146Line != null) __out.Append(__tmp146Line);
                    StringBuilder __tmp147 = new StringBuilder();
                    __tmp147.Append(SpringGeneratorUtil.GetParameterNameList(op));
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
                    string __tmp148Line = ")).withSelfRel();"; //223:135
                    if (__tmp148Line != null) __out.Append(__tmp148Line);
                    __out.AppendLine(false); //223:152
                    __out.Append("		String url = link.getHref();"); //224:1
                    __out.AppendLine(false); //224:31
                }
                __out.Append("        RequestAttributes requestAttributes = RequestContextHolder.currentRequestAttributes();"); //226:1
                __out.AppendLine(false); //226:95
                __out.Append("        HttpServletRequest curRequest = ((ServletRequestAttributes) requestAttributes).getRequest();"); //227:1
                __out.AppendLine(false); //227:101
                __out.Append("        String serverName = curRequest.getServerName();"); //228:1
                __out.AppendLine(false); //228:56
                __out.Append("        String serverPort = String.valueOf(curRequest.getServerPort());"); //229:1
                __out.AppendLine(false); //229:72
                __out.AppendLine(true); //230:3
                __out.Append("        // eg.: http://remotehost/remoteapp-1.0/getMoviesFromReservation/"); //231:1
                __out.AppendLine(false); //231:74
                string __tmp150Line = "        url = url.replace(serverName, Configuration.getString(\""; //232:1
                if (__tmp150Line != null) __out.Append(__tmp150Line);
                StringBuilder __tmp151 = new StringBuilder();
                __tmp151.Append(targetComponent);
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
                StringBuilder __tmp152 = new StringBuilder();
                __tmp152.Append(bindingType);
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
                string __tmp153Line = "Server\"));"; //232:94
                if (__tmp153Line != null) __out.Append(__tmp153Line);
                __out.AppendLine(false); //232:104
                string __tmp155Line = "        url = url.replace(\":\" + serverPort, \":\" + Configuration.getString(\""; //233:1
                if (__tmp155Line != null) __out.Append(__tmp155Line);
                StringBuilder __tmp156 = new StringBuilder();
                __tmp156.Append(targetComponent);
                using(StreamReader __tmp156Reader = new StreamReader(this.__ToStream(__tmp156.ToString())))
                {
                    bool __tmp156_first = true;
                    bool __tmp156_last = __tmp156Reader.EndOfStream;
                    while(__tmp156_first || !__tmp156_last)
                    {
                        __tmp156_first = false;
                        string __tmp156Line = __tmp156Reader.ReadLine();
                        __tmp156_last = __tmp156Reader.EndOfStream;
                        if (__tmp156Line != null) __out.Append(__tmp156Line);
                        if (!__tmp156_last) __out.AppendLine(true);
                    }
                }
                StringBuilder __tmp157 = new StringBuilder();
                __tmp157.Append(bindingType);
                using(StreamReader __tmp157Reader = new StreamReader(this.__ToStream(__tmp157.ToString())))
                {
                    bool __tmp157_first = true;
                    bool __tmp157_last = __tmp157Reader.EndOfStream;
                    while(__tmp157_first || !__tmp157_last)
                    {
                        __tmp157_first = false;
                        string __tmp157Line = __tmp157Reader.ReadLine();
                        __tmp157_last = __tmp157Reader.EndOfStream;
                        if (__tmp157Line != null) __out.Append(__tmp157Line);
                        if (!__tmp157_last) __out.AppendLine(true);
                    }
                }
                string __tmp158Line = "Port\"));"; //233:106
                if (__tmp158Line != null) __out.Append(__tmp158Line);
                __out.AppendLine(false); //233:114
                __out.Append("        url = url.replace(currentComponentName, targetComponentName);"); //234:1
                __out.AppendLine(false); //234:70
                __out.AppendLine(true); //235:3
                string __tmp160Line = "        this.url"; //236:1
                if (__tmp160Line != null) __out.Append(__tmp160Line);
                StringBuilder __tmp161 = new StringBuilder();
                __tmp161.Append(i++);
                using(StreamReader __tmp161Reader = new StreamReader(this.__ToStream(__tmp161.ToString())))
                {
                    bool __tmp161_first = true;
                    bool __tmp161_last = __tmp161Reader.EndOfStream;
                    while(__tmp161_first || !__tmp161_last)
                    {
                        __tmp161_first = false;
                        string __tmp161Line = __tmp161Reader.ReadLine();
                        __tmp161_last = __tmp161Reader.EndOfStream;
                        if (__tmp161Line != null) __out.Append(__tmp161Line);
                        if (!__tmp161_last) __out.AppendLine(true);
                    }
                }
                string __tmp162Line = "Of"; //236:22
                if (__tmp162Line != null) __out.Append(__tmp162Line);
                StringBuilder __tmp163 = new StringBuilder();
                __tmp163.Append(op.Name.ToPascalCase());
                using(StreamReader __tmp163Reader = new StreamReader(this.__ToStream(__tmp163.ToString())))
                {
                    bool __tmp163_first = true;
                    bool __tmp163_last = __tmp163Reader.EndOfStream;
                    while(__tmp163_first || !__tmp163_last)
                    {
                        __tmp163_first = false;
                        string __tmp163Line = __tmp163Reader.ReadLine();
                        __tmp163_last = __tmp163Reader.EndOfStream;
                        if (__tmp163Line != null) __out.Append(__tmp163Line);
                        if (!__tmp163_last) __out.AppendLine(true);
                    }
                }
                string __tmp164Line = " = url;"; //236:48
                if (__tmp164Line != null) __out.Append(__tmp164Line);
                __out.AppendLine(false); //236:55
                __out.Append("        return url;"); //237:1
                __out.AppendLine(false); //237:20
                __out.Append("    }"); //238:1
                __out.AppendLine(false); //238:6
            }
            __out.Append("}"); //240:1
            __out.AppendLine(false); //240:2
            return __out.ToString();
        }

        public string GenerateCrudRepositoryCopy(string namespaceName, string entityName, string bindingType) //245:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp2Line = "package "; //246:1
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
            string __tmp4Line = "."; //246:34
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
            string __tmp6Line = ";"; //246:84
            if (__tmp6Line != null) __out.Append(__tmp6Line);
            __out.AppendLine(false); //246:85
            __out.AppendLine(true); //247:1
            string __tmp8Line = "import "; //248:1
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
            string __tmp10Line = "."; //248:33
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
            string __tmp12Line = "."; //248:80
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
            string __tmp14Line = ";"; //248:93
            if (__tmp14Line != null) __out.Append(__tmp14Line);
            __out.AppendLine(false); //248:94
            __out.AppendLine(true); //249:1
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
                    __out.AppendLine(false); //250:41
                }
            }
            __out.AppendLine(true); //251:1
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
                    __out.AppendLine(false); //252:35
                }
            }
            string __tmp20Line = "public interface "; //253:1
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
            string __tmp22Line = "Repository"; //253:30
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
            string __tmp24Line = " {"; //253:53
            if (__tmp24Line != null) __out.Append(__tmp24Line);
            __out.AppendLine(false); //253:55
            string __tmp26Line = "	// should copy CrudRepository<"; //254:1
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
            string __tmp28Line = ", Long>"; //254:44
            if (__tmp28Line != null) __out.Append(__tmp28Line);
            __out.AppendLine(false); //254:51
            if (bindingType == "Rest") //256:3
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
                        __out.AppendLine(false); //257:41
                    }
                }
            }
            else //258:3
            {
                __out.AppendLine(true); //259:1
                __out.Append("	public long count();"); //260:1
                __out.AppendLine(false); //260:22
                __out.AppendLine(true); //261:1
                __out.Append("	public void delete(Long id);"); //262:1
                __out.AppendLine(false); //262:30
                __out.AppendLine(true); //263:1
                string __tmp32Line = "	public void delete("; //264:1
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
                string __tmp34Line = " entity);"; //264:33
                if (__tmp34Line != null) __out.Append(__tmp34Line);
                __out.AppendLine(false); //264:42
                __out.AppendLine(true); //265:1
                string __tmp36Line = "	public void delete(Iterable<? extends "; //266:1
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
                string __tmp38Line = "> entities);"; //266:52
                if (__tmp38Line != null) __out.Append(__tmp38Line);
                __out.AppendLine(false); //266:64
                __out.AppendLine(true); //267:1
                __out.Append("	public void deleteAll();"); //268:1
                __out.AppendLine(false); //268:26
                __out.AppendLine(true); //269:1
                __out.Append("	public boolean exists(Long id) ;"); //270:1
                __out.AppendLine(false); //270:34
                __out.AppendLine(true); //271:1
                string __tmp40Line = "	public Iterable<"; //272:1
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
                string __tmp42Line = "> findAll();"; //272:30
                if (__tmp42Line != null) __out.Append(__tmp42Line);
                __out.AppendLine(false); //272:42
                __out.AppendLine(true); //273:1
                string __tmp44Line = "	public Iterable<"; //274:1
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
                string __tmp46Line = "> findAll(Iterable<Long> entities);"; //274:30
                if (__tmp46Line != null) __out.Append(__tmp46Line);
                __out.AppendLine(false); //274:65
                __out.AppendLine(true); //275:1
                string __tmp48Line = "	public "; //276:1
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
                string __tmp50Line = " findOne(Long id);"; //276:21
                if (__tmp50Line != null) __out.Append(__tmp50Line);
                __out.AppendLine(false); //276:39
                __out.AppendLine(true); //277:1
                string __tmp52Line = "	public <S extends "; //278:1
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
                string __tmp54Line = "> S save(S entity);"; //278:32
                if (__tmp54Line != null) __out.Append(__tmp54Line);
                __out.AppendLine(false); //278:51
                __out.AppendLine(true); //279:1
                string __tmp56Line = "	public <S extends "; //280:1
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
                string __tmp58Line = "> Iterable<S> save(Iterable<S> entities);"; //280:32
                if (__tmp58Line != null) __out.Append(__tmp58Line);
                __out.AppendLine(false); //280:73
            }
            __out.AppendLine(true); //282:1
            __out.Append("}"); //283:1
            __out.AppendLine(false); //283:2
            return __out.ToString();
        }

        public string GenerateImportsForBinding(string bindingType) //287:1
        {
            StringBuilder __out = new StringBuilder();
            if (bindingType == "Rest") //288:3
            {
                __out.Append("import org.springframework.web.bind.annotation.PathVariable;"); //289:1
                __out.AppendLine(false); //289:61
                __out.Append("import org.springframework.web.bind.annotation.RequestMapping;"); //290:1
                __out.AppendLine(false); //290:63
                __out.Append("import org.springframework.web.bind.annotation.RequestMethod;"); //291:1
                __out.AppendLine(false); //291:62
                __out.Append("import org.springframework.web.bind.annotation.RestController;"); //292:1
                __out.AppendLine(false); //292:63
            }
            if (bindingType.Equals("WebService")) //294:3
            {
                __out.Append("//import ?;"); //295:1
                __out.AppendLine(false); //295:12
            }
            if (bindingType.Equals("WebSocket")) //297:3
            {
                __out.Append("//import ?;"); //298:1
                __out.AppendLine(false); //298:12
            }
            return __out.ToString();
        }

        public string GenerateCrudMethodsForRest(string entityName) //303:1
        {
            StringBuilder __out = new StringBuilder();
            __out.AppendLine(true); //304:1
            __out.Append("	@RequestMapping(value = \"/count\")"); //305:1
            __out.AppendLine(false); //305:35
            __out.Append("	public long count();"); //306:1
            __out.AppendLine(false); //306:22
            __out.AppendLine(true); //307:1
            __out.Append("	@RequestMapping(value = \"/delete/{id}\", method = RequestMethod.POST) // TODO Http.Delete method?"); //308:1
            __out.AppendLine(false); //308:98
            __out.Append("	public void delete(@PathVariable Long id);"); //309:1
            __out.AppendLine(false); //309:44
            __out.AppendLine(true); //310:1
            __out.Append("	@RequestMapping(value = \"/delete\", method = RequestMethod.POST) // TODO Http.Delete method?"); //311:1
            __out.AppendLine(false); //311:93
            string __tmp2Line = "	public void delete(@RequestBody "; //312:1
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
            string __tmp4Line = " entity);"; //312:46
            if (__tmp4Line != null) __out.Append(__tmp4Line);
            __out.AppendLine(false); //312:55
            __out.AppendLine(true); //313:1
            __out.Append("	@RequestMapping(value = \"/delete\", method = RequestMethod.POST) // TODO Http.Delete method?"); //314:1
            __out.AppendLine(false); //314:93
            string __tmp6Line = "	public void delete(@RequestBody Iterable<? extends "; //315:1
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
            string __tmp8Line = "> entities);"; //315:65
            if (__tmp8Line != null) __out.Append(__tmp8Line);
            __out.AppendLine(false); //315:77
            __out.AppendLine(true); //316:1
            __out.Append("	@RequestMapping(value = \"/deleteAll\", method = RequestMethod.POST) // TODO Http.Delete method?"); //317:1
            __out.AppendLine(false); //317:96
            __out.Append("	public void deleteAll();"); //318:1
            __out.AppendLine(false); //318:26
            __out.AppendLine(true); //319:1
            __out.Append("	@RequestMapping(value = \"/exists/{id}\")"); //320:1
            __out.AppendLine(false); //320:41
            __out.Append("	public boolean exists(@PathVariable Long id) ;"); //321:1
            __out.AppendLine(false); //321:48
            __out.AppendLine(true); //322:1
            __out.Append("	@RequestMapping(value = \"/findAll\")"); //323:1
            __out.AppendLine(false); //323:37
            string __tmp10Line = "	public Iterable<"; //324:1
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
            string __tmp12Line = "> findAll();"; //324:30
            if (__tmp12Line != null) __out.Append(__tmp12Line);
            __out.AppendLine(false); //324:42
            __out.AppendLine(true); //325:1
            __out.Append("	@RequestMapping(value = \"/findAll\")"); //326:1
            __out.AppendLine(false); //326:37
            string __tmp14Line = "	public Iterable<"; //327:1
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
            string __tmp16Line = "> findAll(@RequestBody Iterable<Long> entities);"; //327:30
            if (__tmp16Line != null) __out.Append(__tmp16Line);
            __out.AppendLine(false); //327:78
            __out.AppendLine(true); //328:1
            __out.Append("	@RequestMapping(value = \"/findOne/{id}\")"); //329:1
            __out.AppendLine(false); //329:42
            string __tmp18Line = "	public "; //330:1
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
            string __tmp20Line = " findOne(@PathVariable Long id);"; //330:21
            if (__tmp20Line != null) __out.Append(__tmp20Line);
            __out.AppendLine(false); //330:53
            __out.AppendLine(true); //331:1
            __out.Append("	@RequestMapping(value = \"/save\")"); //332:1
            __out.AppendLine(false); //332:34
            string __tmp22Line = "	public <S extends "; //333:1
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
            string __tmp24Line = "> S save(@RequestBody S entity);"; //333:32
            if (__tmp24Line != null) __out.Append(__tmp24Line);
            __out.AppendLine(false); //333:64
            __out.AppendLine(true); //334:1
            __out.Append("	@RequestMapping(value = \"/save\")"); //335:1
            __out.AppendLine(false); //335:34
            string __tmp26Line = "	public <S extends "; //336:1
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
            string __tmp28Line = "> Iterable<S> save(@RequestBody Iterable<S> entities);"; //336:32
            if (__tmp28Line != null) __out.Append(__tmp28Line);
            __out.AppendLine(false); //336:86
            return __out.ToString();
        }

        public string GenerateRepositoryProxyImpl(string namespaceName, string entityName, string bindingType) //340:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp2Line = "package "; //341:1
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
            string __tmp4Line = "."; //341:34
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
            string __tmp6Line = ";"; //341:85
            if (__tmp6Line != null) __out.Append(__tmp6Line);
            __out.AppendLine(false); //341:86
            __out.AppendLine(true); //342:1
            __out.Append("import org.springframework.beans.factory.annotation.Autowired;"); //343:1
            __out.AppendLine(false); //343:63
            __out.AppendLine(true); //344:1
            string __tmp8Line = "import "; //345:1
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
            string __tmp10Line = "."; //345:33
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
            string __tmp12Line = "."; //345:80
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
            string __tmp14Line = ";"; //345:93
            if (__tmp14Line != null) __out.Append(__tmp14Line);
            __out.AppendLine(false); //345:94
            string __tmp16Line = "import "; //346:1
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
            string __tmp18Line = "."; //346:33
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
            string __tmp20Line = "."; //346:84
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
            string __tmp22Line = "Repository;"; //346:97
            if (__tmp22Line != null) __out.Append(__tmp22Line);
            __out.AppendLine(false); //346:108
            string __tmp24Line = "import "; //347:1
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
            string __tmp26Line = "."; //347:33
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
            string __tmp28Line = "."; //347:83
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
            string __tmp30Line = "Repository"; //347:96
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
            string __tmp32Line = ";"; //347:119
            if (__tmp32Line != null) __out.Append(__tmp32Line);
            __out.AppendLine(false); //347:120
            __out.AppendLine(true); //348:1
            string __tmp34Line = "public class "; //349:1
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
            string __tmp36Line = "Repository"; //349:26
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
            string __tmp38Line = "Impl implements "; //349:49
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
            string __tmp40Line = "Repository"; //349:77
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
            string __tmp42Line = " {"; //349:100
            if (__tmp42Line != null) __out.Append(__tmp42Line);
            __out.AppendLine(false); //349:102
            __out.AppendLine(true); //350:1
            __out.Append("	@Autowired"); //351:1
            __out.AppendLine(false); //351:12
            string __tmp43Prefix = "	"; //352:1
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
            string __tmp45Line = "Repository repository;"; //352:14
            if (__tmp45Line != null) __out.Append(__tmp45Line);
            __out.AppendLine(false); //352:36
            __out.AppendLine(true); //353:1
            __out.Append("	@Override"); //354:1
            __out.AppendLine(false); //354:11
            __out.Append("	public long count() {"); //355:1
            __out.AppendLine(false); //355:23
            __out.Append("		return repository.count();"); //356:1
            __out.AppendLine(false); //356:29
            __out.Append("	}"); //357:1
            __out.AppendLine(false); //357:3
            __out.AppendLine(true); //358:1
            __out.Append("	@Override"); //359:1
            __out.AppendLine(false); //359:11
            __out.Append("	public void delete(Long id) {"); //360:1
            __out.AppendLine(false); //360:31
            __out.Append("		repository.delete(id);"); //361:1
            __out.AppendLine(false); //361:25
            __out.Append("	}"); //362:1
            __out.AppendLine(false); //362:3
            __out.AppendLine(true); //363:1
            __out.Append("	@Override"); //364:1
            __out.AppendLine(false); //364:11
            string __tmp47Line = "	public void delete("; //365:1
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
            string __tmp49Line = " entity) {"; //365:33
            if (__tmp49Line != null) __out.Append(__tmp49Line);
            __out.AppendLine(false); //365:43
            __out.Append("		repository.delete(entity);"); //366:1
            __out.AppendLine(false); //366:29
            __out.Append("	}"); //367:1
            __out.AppendLine(false); //367:3
            __out.AppendLine(true); //368:1
            __out.Append("	@Override"); //369:1
            __out.AppendLine(false); //369:11
            string __tmp51Line = "	public void delete(Iterable<? extends "; //370:1
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
            string __tmp53Line = "> entities) {"; //370:52
            if (__tmp53Line != null) __out.Append(__tmp53Line);
            __out.AppendLine(false); //370:65
            __out.Append("		repository.delete(entities);"); //371:1
            __out.AppendLine(false); //371:31
            __out.Append("	}"); //372:1
            __out.AppendLine(false); //372:3
            __out.AppendLine(true); //373:1
            __out.Append("	@Override"); //374:1
            __out.AppendLine(false); //374:11
            __out.Append("	public void deleteAll() {"); //375:1
            __out.AppendLine(false); //375:27
            __out.Append("		repository.deleteAll();"); //376:1
            __out.AppendLine(false); //376:26
            __out.Append("	}"); //377:1
            __out.AppendLine(false); //377:3
            __out.AppendLine(true); //378:1
            __out.Append("	@Override"); //379:1
            __out.AppendLine(false); //379:11
            __out.Append("	public boolean exists(Long id) {"); //380:1
            __out.AppendLine(false); //380:34
            __out.Append("		return repository.exists(id);"); //381:1
            __out.AppendLine(false); //381:32
            __out.Append("	}"); //382:1
            __out.AppendLine(false); //382:3
            __out.AppendLine(true); //383:1
            __out.Append("	@Override"); //384:1
            __out.AppendLine(false); //384:11
            string __tmp55Line = "	public Iterable<"; //385:1
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
            string __tmp57Line = "> findAll() {"; //385:30
            if (__tmp57Line != null) __out.Append(__tmp57Line);
            __out.AppendLine(false); //385:43
            __out.Append("		return repository.findAll();"); //386:1
            __out.AppendLine(false); //386:31
            __out.Append("	}"); //387:1
            __out.AppendLine(false); //387:3
            __out.AppendLine(true); //388:1
            __out.Append("	@Override"); //389:1
            __out.AppendLine(false); //389:11
            string __tmp59Line = "	public Iterable<"; //390:1
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
            string __tmp61Line = "> findAll(Iterable<Long> entities) {"; //390:30
            if (__tmp61Line != null) __out.Append(__tmp61Line);
            __out.AppendLine(false); //390:66
            __out.Append("		return repository.findAll(entities);"); //391:1
            __out.AppendLine(false); //391:39
            __out.Append("	}"); //392:1
            __out.AppendLine(false); //392:3
            __out.AppendLine(true); //393:1
            __out.Append("	@Override"); //394:1
            __out.AppendLine(false); //394:11
            string __tmp63Line = "	public "; //395:1
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
            string __tmp65Line = " findOne(Long id) {"; //395:21
            if (__tmp65Line != null) __out.Append(__tmp65Line);
            __out.AppendLine(false); //395:40
            __out.Append("		return repository.findOne(id);"); //396:1
            __out.AppendLine(false); //396:33
            __out.Append("	}"); //397:1
            __out.AppendLine(false); //397:3
            __out.AppendLine(true); //398:1
            __out.Append("	@Override"); //399:1
            __out.AppendLine(false); //399:11
            string __tmp67Line = "	public <S extends "; //400:1
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
            string __tmp69Line = "> S save(S entity) {"; //400:32
            if (__tmp69Line != null) __out.Append(__tmp69Line);
            __out.AppendLine(false); //400:52
            __out.Append("		return repository.save(entity);"); //401:1
            __out.AppendLine(false); //401:34
            __out.Append("	}"); //402:1
            __out.AppendLine(false); //402:3
            __out.AppendLine(true); //403:1
            __out.Append("	@Override"); //404:1
            __out.AppendLine(false); //404:11
            string __tmp71Line = "	public <S extends "; //405:1
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
            string __tmp73Line = "> Iterable<S> save(Iterable<S> entities) {"; //405:32
            if (__tmp73Line != null) __out.Append(__tmp73Line);
            __out.AppendLine(false); //405:74
            __out.Append("		return repository.save(entities);"); //406:1
            __out.AppendLine(false); //406:36
            __out.Append("	}"); //407:1
            __out.AppendLine(false); //407:3
            __out.AppendLine(true); //408:1
            __out.Append("}"); //409:1
            __out.AppendLine(false); //409:2
            return __out.ToString();
        }

        public string InterfaceAnnotation(string bindingType) //413:1
        {
            StringBuilder __out = new StringBuilder();
            if (bindingType.Equals("Rest")) //414:3
            {
                __out.Append("@RestController"); //415:1
                __out.AppendLine(false); //415:16
                __out.Append("@RequestMapping(method = RequestMethod.GET)"); //416:1
                __out.AppendLine(false); //416:44
            }
            else if (bindingType.Equals("WebService")) //417:3
            {
                __out.Append("//@WebService"); //418:1
                __out.AppendLine(false); //418:14
            }
            else if (bindingType.Equals("WebSockett")) //419:3
            {
                __out.Append("//@WebSocket"); //420:1
                __out.AppendLine(false); //420:13
            }
            return __out.ToString();
        }

        public string OperationAnnotation(Operation op, string bindingType) //426:1
        {
            StringBuilder __out = new StringBuilder();
            if (bindingType.Equals("Rest")) //427:3
            {
                string __tmp2Line = "	@RequestMapping(value = \"/"; //428:1
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
                var __loop11_results = 
                    (from __loop11_var1 in __Enumerate((op).GetEnumerator()) //429:9
                    from param in __Enumerate((__loop11_var1.Parameters).GetEnumerator()) //429:13
                    select new { __loop11_var1 = __loop11_var1, param = param}
                    ).ToList(); //429:4
                int __loop11_iteration = 0;
                foreach (var __tmp4 in __loop11_results)
                {
                    ++__loop11_iteration;
                    var __loop11_var1 = __tmp4.__loop11_var1;
                    var param = __tmp4.param;
                    if (param.Type.IsJavaPrimitiveType()) //430:5
                    {
                        string __tmp6Line = "/{"; //431:1
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
                        string __tmp8Line = "}"; //431:15
                        if (__tmp8Line != null) __out.Append(__tmp8Line);
                    }
                }
                __out.Append("\""); //434:1
                if (!op.Name.ToPascalCase().StartsWith("Get")) //435:4
                {
                    __out.Append(", method = RequestMethod.POST /* TODO consider other method */"); //436:1
                }
                __out.Append(")"); //438:1
                __out.AppendLine(false); //438:2
            }
            else if (bindingType.Equals("WebService")) //439:3
            {
                __out.Append("	//@WebService"); //440:1
                __out.AppendLine(false); //440:15
            }
            else if (bindingType.Equals("WebSockett")) //441:3
            {
                __out.Append("	//@WebSocket"); //442:1
                __out.AppendLine(false); //442:14
            }
            return __out.ToString();
        }

        public string ParameterAnnotation(InputParameter parameter, string bindingType) //448:1
        {
            StringBuilder __out = new StringBuilder();
            if (bindingType.Equals("Rest")) //449:3
            {
                if (parameter.Type.IsJavaPrimitiveType()) //450:4
                {
                    __out.Append("@PathVariable "); //451:1
                }
            }
            else if (bindingType.Equals("WebService")) //453:3
            {
            }
            else if (bindingType.Equals("WebSockett")) //455:3
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
