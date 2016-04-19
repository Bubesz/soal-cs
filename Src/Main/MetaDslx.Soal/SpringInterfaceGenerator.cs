using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Soal //1:1
{
    using __Hidden_SpringInterfaceGenerator_1706697084;
    namespace __Hidden_SpringInterfaceGenerator_1706697084
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
                __out.Append("import org.springframework.web.bind.annotation.RequestMethod;"); //13:1
                __out.AppendLine(false); //13:62
                __out.Append("import org.springframework.web.bind.annotation.RestController;"); //14:1
                __out.AppendLine(false); //14:63
            }
            if (bindingType.Equals("WebService")) //16:2
            {
                __out.Append("//import ?;"); //17:1
                __out.AppendLine(false); //17:12
            }
            if (bindingType.Equals("WebSockett")) //19:2
            {
                __out.Append("//import ?;"); //20:1
                __out.AppendLine(false); //20:12
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
                    __out.AppendLine(false); //23:52
                }
            }
            __out.AppendLine(true); //24:1
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
                    __out.AppendLine(false); //25:35
                }
            }
            string __tmp12Line = "public interface "; //26:1
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
            string __tmp15Line = " {"; //26:43
            if (__tmp15Line != null) __out.Append(__tmp15Line);
            __out.AppendLine(false); //26:45
            var __loop1_results = 
                (from __loop1_var1 in __Enumerate((iface).GetEnumerator()) //27:8
                from op in __Enumerate((__loop1_var1.Operations).GetEnumerator()) //27:15
                select new { __loop1_var1 = __loop1_var1, op = op}
                ).ToList(); //27:2
            int __loop1_iteration = 0;
            foreach (var __tmp16 in __loop1_results)
            {
                ++__loop1_iteration;
                var __loop1_var1 = __tmp16.__loop1_var1;
                var op = __tmp16.op;
                __out.AppendLine(true); //28:1
                StringBuilder __tmp18 = new StringBuilder();
                __tmp18.Append(OperationAnnotation(op, bindingType));
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
                        __out.AppendLine(false); //29:39
                    }
                }
                string __tmp19Prefix = "	"; //30:1
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
                string __tmp21Line = " "; //30:32
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
                string __tmp23Line = "("; //30:56
                if (__tmp23Line != null) __out.Append(__tmp23Line);
                var __loop2_results = 
                    (from __loop2_var1 in __Enumerate((op).GetEnumerator()) //31:9
                    from param in __Enumerate((__loop2_var1.Parameters).GetEnumerator()) //31:13
                    select new { __loop2_var1 = __loop2_var1, param = param}
                    ).ToList(); //31:3
                int __loop2_iteration = 0;
                string delimiter = ""; //31:31
                foreach (var __tmp24 in __loop2_results)
                {
                    ++__loop2_iteration;
                    if (__loop2_iteration >= 2) //31:54
                    {
                        delimiter = ", "; //31:54
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
                    __tmp27.Append(ParameterAnnotation(param, bindingType));
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
                    string __tmp29Line = " "; //32:79
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
                __out.Append(")"); //34:1
                if (op.Exceptions.Any()) //35:3
                {
                    string __tmp32Line = " throws "; //36:1
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
                __out.Append(";"); //38:1
                __out.AppendLine(false); //38:2
            }
            __out.Append("}"); //41:1
            __out.AppendLine(false); //41:2
            return __out.ToString();
        }

        public string GenerateInterfaceImplementation(Interface iface, string functionName) //46:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp2Line = "package "; //47:1
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
            string __tmp4Line = "."; //47:48
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
            string __tmp6Line = ";"; //47:63
            if (__tmp6Line != null) __out.Append(__tmp6Line);
            __out.AppendLine(false); //47:64
            __out.AppendLine(true); //48:1
            __out.Append("import org.springframework.beans.factory.annotation.Autowired;"); //49:1
            __out.AppendLine(false); //49:63
            __out.Append("import org.springframework.stereotype.Service;"); //50:1
            __out.AppendLine(false); //50:47
            __out.AppendLine(true); //51:1
            string __tmp8Line = "import "; //52:1
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
            string __tmp10Line = "."; //52:47
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
            string __tmp12Line = "."; //52:97
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
            string __tmp14Line = ";"; //52:110
            if (__tmp14Line != null) __out.Append(__tmp14Line);
            __out.AppendLine(false); //52:111
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
                    __out.AppendLine(false); //53:45
                }
            }
            __out.AppendLine(true); //54:1
            __out.Append("@Service"); //55:1
            __out.AppendLine(false); //55:9
            string __tmp18Line = "public class "; //56:1
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
            string __tmp20Line = "Impl implements "; //56:26
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
            string __tmp22Line = " {"; //56:54
            if (__tmp22Line != null) __out.Append(__tmp22Line);
            __out.AppendLine(false); //56:56
            var __loop3_results = 
                (from __loop3_var1 in __Enumerate((iface).GetEnumerator()) //57:8
                from repo in __Enumerate((__loop3_var1.GetRepositories()).GetEnumerator()) //57:15
                select new { __loop3_var1 = __loop3_var1, repo = repo}
                ).ToList(); //57:2
            int __loop3_iteration = 0;
            foreach (var __tmp23 in __loop3_results)
            {
                ++__loop3_iteration;
                var __loop3_var1 = __tmp23.__loop3_var1;
                var repo = __tmp23.repo;
                __out.AppendLine(true); //58:1
                __out.Append("	@Autowired"); //59:1
                __out.AppendLine(false); //59:12
                string __tmp25Line = "	private "; //60:1
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
                string __tmp27Line = ";"; //60:16
                if (__tmp27Line != null) __out.Append(__tmp27Line);
                __out.AppendLine(false); //60:17
            }
            var __loop4_results = 
                (from __loop4_var1 in __Enumerate((iface).GetEnumerator()) //62:7
                from op in __Enumerate((__loop4_var1.Operations).GetEnumerator()) //62:14
                select new { __loop4_var1 = __loop4_var1, op = op}
                ).ToList(); //62:2
            int __loop4_iteration = 0;
            foreach (var __tmp28 in __loop4_results)
            {
                ++__loop4_iteration;
                var __loop4_var1 = __tmp28.__loop4_var1;
                var op = __tmp28.op;
                __out.AppendLine(true); //63:1
                string __tmp30Line = "	public "; //64:1
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
                string __tmp32Line = " "; //64:39
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
                string __tmp34Line = "("; //64:63
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
                string __tmp36Line = ")"; //64:106
                if (__tmp36Line != null) __out.Append(__tmp36Line);
                if (op.Exceptions.Any()) //65:3
                {
                    string __tmp38Line = " throws "; //66:1
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
                    string __tmp40Line = " "; //66:51
                    if (__tmp40Line != null) __out.Append(__tmp40Line);
                }
                __out.Append("{"); //68:1
                __out.AppendLine(false); //68:2
                __out.Append("		// TODO implement method"); //69:1
                __out.AppendLine(false); //69:27
                __out.Append("		throw new UnsupportedOperationException(\"Not yet implemented.\");"); //70:1
                __out.AppendLine(false); //70:67
                __out.Append("	}"); //71:1
                __out.AppendLine(false); //71:3
            }
            __out.Append("}"); //73:1
            __out.AppendLine(false); //73:2
            return __out.ToString();
        }

        public string GenerateProxyInterfaceImplementation(Interface iface, string functionName, string bindingType) //78:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp2Line = "package "; //79:1
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
            string __tmp4Line = "."; //79:48
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
            string __tmp6Line = ";"; //79:63
            if (__tmp6Line != null) __out.Append(__tmp6Line);
            __out.AppendLine(false); //79:64
            __out.AppendLine(true); //80:1
            __out.Append("import org.springframework.beans.factory.annotation.Autowired;"); //81:1
            __out.AppendLine(false); //81:63
            __out.Append("import org.springframework.stereotype.Service;"); //82:1
            __out.AppendLine(false); //82:47
            __out.AppendLine(true); //83:1
            string __tmp8Line = "import "; //84:1
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
            string __tmp10Line = "."; //84:47
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
            string __tmp12Line = "."; //84:97
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
            string __tmp15Line = ";"; //84:123
            if (__tmp15Line != null) __out.Append(__tmp15Line);
            __out.AppendLine(false); //84:124
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
                    __out.AppendLine(false); //85:52
                }
            }
            __out.AppendLine(true); //86:1
            __out.Append("@Service"); //87:1
            __out.AppendLine(false); //87:9
            string __tmp19Line = "public class "; //88:1
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
            string __tmp22Line = "Impl implements "; //88:39
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
            string __tmp25Line = " {"; //88:80
            if (__tmp25Line != null) __out.Append(__tmp25Line);
            __out.AppendLine(false); //88:82
            __out.AppendLine(true); //89:1
            __out.Append("	@Autowired"); //90:1
            __out.AppendLine(false); //90:12
            string __tmp27Line = "	private "; //91:1
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
            string __tmp29Line = "Impl "; //91:22
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
            string __tmp31Line = "Impl;"; //91:53
            if (__tmp31Line != null) __out.Append(__tmp31Line);
            __out.AppendLine(false); //91:58
            var __loop5_results = 
                (from __loop5_var1 in __Enumerate((iface).GetEnumerator()) //93:7
                from op in __Enumerate((__loop5_var1.Operations).GetEnumerator()) //93:14
                select new { __loop5_var1 = __loop5_var1, op = op}
                ).ToList(); //93:2
            int __loop5_iteration = 0;
            foreach (var __tmp32 in __loop5_results)
            {
                ++__loop5_iteration;
                var __loop5_var1 = __tmp32.__loop5_var1;
                var op = __tmp32.op;
                __out.AppendLine(true); //94:1
                string __tmp34Line = "	public "; //95:1
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
                string __tmp36Line = " "; //95:39
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
                string __tmp38Line = "("; //95:63
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
                string __tmp40Line = ")"; //95:106
                if (__tmp40Line != null) __out.Append(__tmp40Line);
                if (op.Exceptions.Any()) //96:3
                {
                    string __tmp42Line = " throws "; //97:1
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
                    string __tmp44Line = " "; //97:51
                    if (__tmp44Line != null) __out.Append(__tmp44Line);
                }
                __out.Append("{"); //99:1
                __out.AppendLine(false); //99:2
                if (op.Result.Type.GetJavaName() != "void") //100:5
                {
                    string __tmp46Line = "		return "; //101:1
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
                    string __tmp48Line = "Impl."; //101:36
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
                    string __tmp50Line = "("; //101:64
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
                    string __tmp52Line = ");"; //101:111
                    if (__tmp52Line != null) __out.Append(__tmp52Line);
                    __out.AppendLine(false); //101:113
                }
                else //102:5
                {
                    string __tmp53Prefix = "		"; //103:1
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
                    string __tmp55Line = "Impl."; //103:29
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
                    string __tmp57Line = "("; //103:57
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
                    string __tmp59Line = ");"; //103:104
                    if (__tmp59Line != null) __out.Append(__tmp59Line);
                    __out.AppendLine(false); //103:106
                }
                __out.Append("	}"); //105:1
                __out.AppendLine(false); //105:3
            }
            __out.Append("}"); //107:1
            __out.AppendLine(false); //107:2
            return __out.ToString();
        }

        public string GenerateProxyForInterface(Interface iface, string bindingType, string currentComponent, string targetComponent) //112:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp2Line = "package "; //113:1
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
            string __tmp4Line = "."; //113:48
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
            string __tmp6Line = ";"; //113:94
            if (__tmp6Line != null) __out.Append(__tmp6Line);
            __out.AppendLine(false); //113:95
            __out.AppendLine(true); //114:1
            __out.Append("import static org.springframework.hateoas.mvc.ControllerLinkBuilder.linkTo;"); //115:1
            __out.AppendLine(false); //115:76
            __out.Append("import static org.springframework.hateoas.mvc.ControllerLinkBuilder.methodOn;"); //116:1
            __out.AppendLine(false); //116:78
            __out.AppendLine(true); //117:1
            __out.Append("import org.springframework.hateoas.Link;"); //118:1
            __out.AppendLine(false); //118:41
            __out.Append("import org.springframework.http.HttpEntity;"); //119:1
            __out.AppendLine(false); //119:44
            __out.Append("import org.springframework.http.converter.json.MappingJackson2HttpMessageConverter;"); //120:1
            __out.AppendLine(false); //120:84
            __out.Append("import org.springframework.stereotype.Service;"); //121:1
            __out.AppendLine(false); //121:47
            __out.Append("import org.springframework.web.client.RestTemplate;"); //122:1
            __out.AppendLine(false); //122:52
            __out.Append("import org.springframework.web.context.request.RequestAttributes;"); //123:1
            __out.AppendLine(false); //123:66
            __out.Append("import org.springframework.web.context.request.RequestContextHolder;"); //124:1
            __out.AppendLine(false); //124:69
            __out.Append("import org.springframework.web.context.request.ServletRequestAttributes;"); //125:1
            __out.AppendLine(false); //125:73
            __out.AppendLine(true); //126:1
            __out.Append("import cinema.Configuration;"); //127:1
            __out.AppendLine(false); //127:29
            string __tmp8Line = "import "; //128:1
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
            string __tmp10Line = "."; //128:47
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
            string __tmp12Line = "."; //128:97
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
            string __tmp15Line = ";"; //128:123
            if (__tmp15Line != null) __out.Append(__tmp15Line);
            __out.AppendLine(false); //128:124
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
                    __out.AppendLine(false); //129:52
                }
            }
            __out.AppendLine(true); //130:1
            __out.Append("import javax.servlet.http.HttpServletRequest;"); //131:1
            __out.AppendLine(false); //131:46
            __out.Append("import java.util.Arrays;"); //132:1
            __out.AppendLine(false); //132:25
            __out.Append("import java.util.stream.Collectors;"); //133:1
            __out.AppendLine(false); //133:36
            __out.AppendLine(true); //134:1
            __out.Append("@Service"); //135:1
            __out.AppendLine(false); //135:9
            string __tmp19Line = "public class "; //136:1
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
            string __tmp22Line = "Proxy implements "; //136:39
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
            string __tmp25Line = " {"; //136:81
            if (__tmp25Line != null) __out.Append(__tmp25Line);
            __out.AppendLine(false); //136:83
            __out.AppendLine(true); //137:1
            __out.Append("	private RestTemplate restTemplate = new RestTemplate();"); //138:1
            __out.AppendLine(false); //138:57
            string __tmp27Line = "	private final String currentComponentName = \"Cinema-"; //139:1
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
            string __tmp29Line = "\";"; //139:72
            if (__tmp29Line != null) __out.Append(__tmp29Line);
            __out.AppendLine(false); //139:74
            string __tmp31Line = "    private final String targetComponentName = \"Cinema-"; //140:1
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
            string __tmp33Line = "\";"; //140:73
            if (__tmp33Line != null) __out.Append(__tmp33Line);
            __out.AppendLine(false); //140:75
            __out.AppendLine(true); //141:2
            var __loop6_results = 
                (from __loop6_var1 in __Enumerate((iface).GetEnumerator()) //142:7
                from op in __Enumerate((__loop6_var1.Operations).GetEnumerator()) //142:14
                select new { __loop6_var1 = __loop6_var1, op = op}
                ).ToList(); //142:2
            int __loop6_iteration = 0;
            foreach (var __tmp34 in __loop6_results)
            {
                ++__loop6_iteration;
                var __loop6_var1 = __tmp34.__loop6_var1;
                var op = __tmp34.op;
                string __tmp36Line = "	private String urlOf"; //143:1
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
                string __tmp38Line = ";"; //143:46
                if (__tmp38Line != null) __out.Append(__tmp38Line);
                __out.AppendLine(false); //143:47
            }
            var __loop7_results = 
                (from __loop7_var1 in __Enumerate((iface).GetEnumerator()) //146:7
                from op in __Enumerate((__loop7_var1.Operations).GetEnumerator()) //146:14
                select new { __loop7_var1 = __loop7_var1, op = op}
                ).ToList(); //146:2
            int __loop7_iteration = 0;
            foreach (var __tmp39 in __loop7_results)
            {
                ++__loop7_iteration;
                var __loop7_var1 = __tmp39.__loop7_var1;
                var op = __tmp39.op;
                __out.AppendLine(true); //147:1
                string resultJavaName = op.Result.Type.GetJavaName(); //148:3
                __out.Append("	@Override"); //149:1
                __out.AppendLine(false); //149:11
                string __tmp41Line = "	public "; //150:1
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
                string __tmp43Line = " "; //150:25
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
                string __tmp45Line = "("; //150:49
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
                string __tmp47Line = ")"; //150:92
                if (__tmp47Line != null) __out.Append(__tmp47Line);
                if (op.Exceptions.Any()) //151:3
                {
                    string __tmp49Line = " throws "; //152:1
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
                    string __tmp51Line = " "; //152:51
                    if (__tmp51Line != null) __out.Append(__tmp51Line);
                }
                __out.Append("{"); //154:1
                __out.AppendLine(false); //154:2
                string __tmp53Line = "		String url = getUrlOf"; //155:1
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
                string __tmp55Line = "("; //155:48
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
                string __tmp57Line = ");"; //155:95
                if (__tmp57Line != null) __out.Append(__tmp57Line);
                __out.AppendLine(false); //155:97
                string method = "POST"; //157:3
                if (op.Name.ToPascalCase().StartsWith("Get")) //158:3
                {
                    method = "GET";
                }
                string extraVariable = ""; //162:3
                if (method == "POST") //163:3
                {
                    extraVariable = "request, ";
                    __out.Append("		HttpEntity<?> request = null;"); //165:1
                    __out.AppendLine(false); //165:32
                    __out.Append("		this.restTemplate.getMessageConverters().add(new MappingJackson2HttpMessageConverter());"); //166:1
                    __out.AppendLine(false); //166:91
                    var __loop8_results = 
                        (from __loop8_var1 in __Enumerate((op).GetEnumerator()) //167:9
                        from param in __Enumerate((__loop8_var1.Parameters).GetEnumerator()) //167:13
                        where !param.Type.IsJavaPrimitiveType() //167:30
                        select new { __loop8_var1 = __loop8_var1, param = param}
                        ).ToList(); //167:4
                    int __loop8_iteration = 0;
                    foreach (var __tmp58 in __loop8_results)
                    {
                        ++__loop8_iteration;
                        var __loop8_var1 = __tmp58.__loop8_var1;
                        var param = __tmp58.param;
                        string __tmp60Line = "		request = new HttpEntity<"; //168:1
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
                        string __tmp62Line = ">("; //168:54
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
                        string __tmp64Line = ");"; //168:68
                        if (__tmp64Line != null) __out.Append(__tmp64Line);
                        __out.AppendLine(false); //168:70
                    }
                }
                ArrayType array = op.Result.Type as ArrayType; //172:3
                if (array != null) //173:3
                {
                    string __tmp65Prefix = "		"; //174:1
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
                    string __tmp68Line = " response = restTemplate."; //174:40
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
                    string __tmp70Line = "ForObject(url, "; //174:83
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
                    string __tmp74Line = ".class);"; //174:150
                    if (__tmp74Line != null) __out.Append(__tmp74Line);
                    __out.AppendLine(false); //174:158
                }
                else if (resultJavaName != "void") //175:3
                {
                    string __tmp75Prefix = "		"; //176:1
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
                    string __tmp77Line = " response = restTemplate."; //176:19
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
                    string __tmp79Line = "ForObject(url, "; //176:62
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
                    string __tmp82Line = ".class);"; //176:108
                    if (__tmp82Line != null) __out.Append(__tmp82Line);
                    __out.AppendLine(false); //176:116
                }
                else //177:3
                {
                    string __tmp84Line = "		restTemplate."; //178:1
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
                    string __tmp86Line = "ForObject(url, "; //178:34
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
                    string __tmp88Line = "Object.class);"; //178:64
                    if (__tmp88Line != null) __out.Append(__tmp88Line);
                    __out.AppendLine(false); //178:78
                }
                if (array != null) //181:3
                {
                    __out.Append("		return Arrays.stream(response).collect(Collectors.toList());"); //182:1
                    __out.AppendLine(false); //182:63
                }
                else if (resultJavaName != "void") //183:3
                {
                    __out.Append("		return response;"); //184:1
                    __out.AppendLine(false); //184:19
                }
                else //185:3
                {
                    __out.Append("		return;"); //186:1
                    __out.AppendLine(false); //186:10
                }
                __out.Append("	}"); //188:1
                __out.AppendLine(false); //188:3
            }
            var __loop9_results = 
                (from __loop9_var1 in __Enumerate((iface).GetEnumerator()) //191:7
                from op in __Enumerate((__loop9_var1.Operations).GetEnumerator()) //191:14
                select new { __loop9_var1 = __loop9_var1, op = op}
                ).ToList(); //191:2
            int __loop9_iteration = 0;
            foreach (var __tmp89 in __loop9_results)
            {
                ++__loop9_iteration;
                var __loop9_var1 = __tmp89.__loop9_var1;
                var op = __tmp89.op;
                __out.AppendLine(true); //192:2
                string __tmp91Line = "	private String getUrlOf"; //193:1
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
                string __tmp93Line = "("; //193:49
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
                string __tmp95Line = ") {"; //193:92
                if (__tmp95Line != null) __out.Append(__tmp95Line);
                __out.AppendLine(false); //193:95
                string __tmp97Line = "        if (this.urlOf"; //194:1
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
                string __tmp99Line = " != null) {"; //194:47
                if (__tmp99Line != null) __out.Append(__tmp99Line);
                __out.AppendLine(false); //194:58
                string __tmp101Line = "            return this.urlOf"; //195:1
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
                string __tmp103Line = ";"; //195:54
                if (__tmp103Line != null) __out.Append(__tmp103Line);
                __out.AppendLine(false); //195:55
                __out.Append("        }"); //196:1
                __out.AppendLine(false); //196:10
                __out.AppendLine(true); //197:3
                __out.Append("        // eg.: http://localhost/localapp-1.0/getMoviesFromReservation/"); //198:1
                __out.AppendLine(false); //198:72
                if (op.Result.Type.GetJavaName() == "void") //199:3
                {
                    __out.Append("		String url = null;"); //200:1
                    __out.AppendLine(false); //200:21
                    __out.Append("		try {"); //201:1
                    __out.AppendLine(false); //201:8
                    string __tmp105Line = "			java.lang.reflect.Method method = "; //202:1
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
                    string __tmp107Line = ".class.getMethod(\""; //202:64
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
                    string __tmp109Line = "\", "; //202:105
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
                    string __tmp111Line = ");"; //202:154
                    if (__tmp111Line != null) __out.Append(__tmp111Line);
                    __out.AppendLine(false); //202:156
                    string __tmp113Line = "			Link link = linkTo("; //203:1
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
                    string __tmp115Line = ".class, method, "; //203:49
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
                    string __tmp117Line = ").withSelfRel();"; //203:111
                    if (__tmp117Line != null) __out.Append(__tmp117Line);
                    __out.AppendLine(false); //203:127
                    __out.Append("			url = link.getHref();"); //204:1
                    __out.AppendLine(false); //204:25
                    var __loop10_results = 
                        (from __loop10_var1 in __Enumerate((op).GetEnumerator()) //205:9
                        from ex in __Enumerate((__loop10_var1.Exceptions).GetEnumerator()) //205:13
                        select new { __loop10_var1 = __loop10_var1, ex = ex}
                        ).ToList(); //205:4
                    int __loop10_iteration = 0;
                    foreach (var __tmp118 in __loop10_results)
                    {
                        ++__loop10_iteration;
                        var __loop10_var1 = __tmp118.__loop10_var1;
                        var ex = __tmp118.ex;
                        __out.Append("		} catch (NoSuchMethodException e) {"); //206:1
                        __out.AppendLine(false); //206:38
                        __out.Append("			// TODO handle execption properly"); //207:1
                        __out.AppendLine(false); //207:37
                        __out.Append("			throw new RuntimeException(e);"); //208:1
                        __out.AppendLine(false); //208:34
                    }
                    __out.Append("		}"); //210:1
                    __out.AppendLine(false); //210:4
                }
                else if (op.Exceptions.Any()) //212:3
                {
                    __out.Append("		String url = null;"); //213:1
                    __out.AppendLine(false); //213:21
                    __out.Append("		try {"); //214:1
                    __out.AppendLine(false); //214:8
                    string __tmp120Line = "			Link link = linkTo(methodOn("; //215:1
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
                    string __tmp122Line = ".class)."; //215:58
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
                    string __tmp124Line = "("; //215:89
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
                    string __tmp126Line = ")).withSelfRel();"; //215:136
                    if (__tmp126Line != null) __out.Append(__tmp126Line);
                    __out.AppendLine(false); //215:153
                    __out.Append("			url = link.getHref();"); //216:1
                    __out.AppendLine(false); //216:25
                    var __loop11_results = 
                        (from __loop11_var1 in __Enumerate((op).GetEnumerator()) //217:9
                        from ex in __Enumerate((__loop11_var1.Exceptions).GetEnumerator()) //217:13
                        select new { __loop11_var1 = __loop11_var1, ex = ex}
                        ).ToList(); //217:4
                    int __loop11_iteration = 0;
                    foreach (var __tmp127 in __loop11_results)
                    {
                        ++__loop11_iteration;
                        var __loop11_var1 = __tmp127.__loop11_var1;
                        var ex = __tmp127.ex;
                        string __tmp129Line = "		} catch ("; //218:1
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
                        string __tmp131Line = " e) {"; //218:30
                        if (__tmp131Line != null) __out.Append(__tmp131Line);
                        __out.AppendLine(false); //218:35
                        __out.Append("			// TODO handle execption properly"); //219:1
                        __out.AppendLine(false); //219:37
                        __out.Append("			throw new RuntimeException(e);"); //220:1
                        __out.AppendLine(false); //220:34
                    }
                    __out.Append("		}"); //222:1
                    __out.AppendLine(false); //222:4
                }
                else //223:3
                {
                    string __tmp133Line = "		Link link = linkTo(methodOn("; //224:1
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
                    string __tmp135Line = ".class)."; //224:57
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
                    string __tmp137Line = "("; //224:88
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
                    string __tmp139Line = ")).withSelfRel();"; //224:135
                    if (__tmp139Line != null) __out.Append(__tmp139Line);
                    __out.AppendLine(false); //224:152
                    __out.Append("		String url = link.getHref();"); //225:1
                    __out.AppendLine(false); //225:31
                }
                __out.Append("        RequestAttributes requestAttributes = RequestContextHolder.currentRequestAttributes();"); //227:1
                __out.AppendLine(false); //227:95
                __out.Append("        HttpServletRequest curRequest = ((ServletRequestAttributes) requestAttributes).getRequest();"); //228:1
                __out.AppendLine(false); //228:101
                __out.Append("        String serverName = curRequest.getServerName();"); //229:1
                __out.AppendLine(false); //229:56
                __out.Append("        String serverPort = String.valueOf(curRequest.getServerPort());"); //230:1
                __out.AppendLine(false); //230:72
                __out.AppendLine(true); //231:3
                __out.Append("        // eg.: http://remotehost/remoteapp-1.0/getMoviesFromReservation/"); //232:1
                __out.AppendLine(false); //232:74
                string __tmp141Line = "        url = url.replace(serverName, Configuration.getString(\""; //233:1
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
                string __tmp144Line = "Server\"));"; //233:94
                if (__tmp144Line != null) __out.Append(__tmp144Line);
                __out.AppendLine(false); //233:104
                string __tmp146Line = "        url = url.replace(\":\" + serverPort, \":\" + Configuration.getString(\""; //234:1
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
                string __tmp149Line = "Port\"));"; //234:106
                if (__tmp149Line != null) __out.Append(__tmp149Line);
                __out.AppendLine(false); //234:114
                __out.Append("        url = url.replace(currentComponentName, targetComponentName);"); //235:1
                __out.AppendLine(false); //235:70
                __out.AppendLine(true); //236:3
                string __tmp151Line = "        this.urlOf"; //237:1
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
                string __tmp153Line = " = url;"; //237:43
                if (__tmp153Line != null) __out.Append(__tmp153Line);
                __out.AppendLine(false); //237:50
                __out.Append("        return url;"); //238:1
                __out.AppendLine(false); //238:20
                __out.Append("    }"); //239:1
                __out.AppendLine(false); //239:6
            }
            __out.Append("}"); //241:1
            __out.AppendLine(false); //241:2
            return __out.ToString();
        }

        public string GenerateCrudRepositoryCopy(string namespaceName, string entityName, string bindingType) //246:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp2Line = "package "; //247:1
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
            string __tmp4Line = "."; //247:34
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
            string __tmp6Line = ";"; //247:84
            if (__tmp6Line != null) __out.Append(__tmp6Line);
            __out.AppendLine(false); //247:85
            __out.AppendLine(true); //248:1
            string __tmp8Line = "import "; //249:1
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
            string __tmp10Line = "."; //249:33
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
            string __tmp12Line = "."; //249:80
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
            string __tmp14Line = ";"; //249:93
            if (__tmp14Line != null) __out.Append(__tmp14Line);
            __out.AppendLine(false); //249:94
            __out.AppendLine(true); //250:1
            string __tmp16Line = "public interface "; //251:1
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
            string __tmp18Line = "Repository"; //251:30
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
            string __tmp20Line = " {"; //251:53
            if (__tmp20Line != null) __out.Append(__tmp20Line);
            __out.AppendLine(false); //251:55
            string __tmp22Line = "	// should copy CrudRepository<"; //252:1
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
            string __tmp24Line = ", Long>"; //252:44
            if (__tmp24Line != null) __out.Append(__tmp24Line);
            __out.AppendLine(false); //252:51
            __out.AppendLine(true); //253:1
            __out.Append("	public long count();"); //254:1
            __out.AppendLine(false); //254:22
            __out.AppendLine(true); //255:1
            __out.Append("	public void delete(Long id);"); //256:1
            __out.AppendLine(false); //256:30
            __out.AppendLine(true); //257:1
            string __tmp26Line = "	public void delete("; //258:1
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
            string __tmp28Line = " entity);"; //258:33
            if (__tmp28Line != null) __out.Append(__tmp28Line);
            __out.AppendLine(false); //258:42
            __out.AppendLine(true); //259:1
            string __tmp30Line = "	public void delete(Iterable<? extends "; //260:1
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
            string __tmp32Line = "> entities);"; //260:52
            if (__tmp32Line != null) __out.Append(__tmp32Line);
            __out.AppendLine(false); //260:64
            __out.AppendLine(true); //261:1
            __out.Append("	public void deleteAll();"); //262:1
            __out.AppendLine(false); //262:26
            __out.AppendLine(true); //263:1
            __out.Append("	public boolean exists(Long id) ;"); //264:1
            __out.AppendLine(false); //264:34
            __out.AppendLine(true); //265:1
            string __tmp34Line = "	public Iterable<"; //266:1
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
            string __tmp36Line = "> findAll();"; //266:30
            if (__tmp36Line != null) __out.Append(__tmp36Line);
            __out.AppendLine(false); //266:42
            __out.AppendLine(true); //267:1
            string __tmp38Line = "	public Iterable<"; //268:1
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
            string __tmp40Line = "> findAll(Iterable<Long> entities);"; //268:30
            if (__tmp40Line != null) __out.Append(__tmp40Line);
            __out.AppendLine(false); //268:65
            __out.AppendLine(true); //269:1
            string __tmp42Line = "	public "; //270:1
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
            string __tmp44Line = " findOne(Long id);"; //270:21
            if (__tmp44Line != null) __out.Append(__tmp44Line);
            __out.AppendLine(false); //270:39
            __out.AppendLine(true); //271:1
            string __tmp46Line = "	public <S extends "; //272:1
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
            string __tmp48Line = "> S save(S entity);"; //272:32
            if (__tmp48Line != null) __out.Append(__tmp48Line);
            __out.AppendLine(false); //272:51
            __out.AppendLine(true); //273:1
            string __tmp50Line = "	public <S extends "; //274:1
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
            string __tmp52Line = "> Iterable<S> save(Iterable<S> entities);"; //274:32
            if (__tmp52Line != null) __out.Append(__tmp52Line);
            __out.AppendLine(false); //274:73
            __out.AppendLine(true); //275:1
            __out.Append("}"); //276:1
            __out.AppendLine(false); //276:2
            return __out.ToString();
        }

        public string GenerateRepositoryProxyImpl(string namespaceName, string entityName, string bindingType) //280:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp2Line = "package "; //281:1
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
            string __tmp4Line = "."; //281:34
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
            string __tmp6Line = ";"; //281:85
            if (__tmp6Line != null) __out.Append(__tmp6Line);
            __out.AppendLine(false); //281:86
            __out.AppendLine(true); //282:1
            __out.Append("import org.springframework.beans.factory.annotation.Autowired;"); //283:1
            __out.AppendLine(false); //283:63
            __out.AppendLine(true); //284:1
            string __tmp8Line = "import "; //285:1
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
            string __tmp10Line = "."; //285:33
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
            string __tmp12Line = "."; //285:80
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
            string __tmp14Line = ";"; //285:93
            if (__tmp14Line != null) __out.Append(__tmp14Line);
            __out.AppendLine(false); //285:94
            string __tmp16Line = "import "; //286:1
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
            string __tmp18Line = "."; //286:33
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
            string __tmp20Line = "."; //286:84
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
            string __tmp22Line = "Repository;"; //286:97
            if (__tmp22Line != null) __out.Append(__tmp22Line);
            __out.AppendLine(false); //286:108
            string __tmp24Line = "import "; //287:1
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
            string __tmp26Line = "."; //287:33
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
            string __tmp28Line = "."; //287:83
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
            string __tmp30Line = "Repository"; //287:96
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
            string __tmp32Line = ";"; //287:119
            if (__tmp32Line != null) __out.Append(__tmp32Line);
            __out.AppendLine(false); //287:120
            __out.AppendLine(true); //288:1
            string __tmp34Line = "public class "; //289:1
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
            string __tmp36Line = "Repository"; //289:26
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
            string __tmp38Line = "Impl implements "; //289:49
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
            string __tmp40Line = "Repository"; //289:77
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
            string __tmp42Line = " {"; //289:100
            if (__tmp42Line != null) __out.Append(__tmp42Line);
            __out.AppendLine(false); //289:102
            __out.AppendLine(true); //290:1
            __out.Append("	@Autowired"); //291:1
            __out.AppendLine(false); //291:12
            string __tmp43Prefix = "	"; //292:1
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
            string __tmp45Line = "Repository repository;"; //292:14
            if (__tmp45Line != null) __out.Append(__tmp45Line);
            __out.AppendLine(false); //292:36
            __out.AppendLine(true); //293:1
            __out.Append("	@Override"); //294:1
            __out.AppendLine(false); //294:11
            __out.Append("	public long count() {"); //295:1
            __out.AppendLine(false); //295:23
            __out.Append("		return repository.count();"); //296:1
            __out.AppendLine(false); //296:29
            __out.Append("	}"); //297:1
            __out.AppendLine(false); //297:3
            __out.AppendLine(true); //298:1
            __out.Append("	@Override"); //299:1
            __out.AppendLine(false); //299:11
            __out.Append("	public void delete(Long id) {"); //300:1
            __out.AppendLine(false); //300:31
            __out.Append("		repository.delete(id);"); //301:1
            __out.AppendLine(false); //301:25
            __out.Append("	}"); //302:1
            __out.AppendLine(false); //302:3
            __out.AppendLine(true); //303:1
            __out.Append("	@Override"); //304:1
            __out.AppendLine(false); //304:11
            string __tmp47Line = "	public void delete("; //305:1
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
            string __tmp49Line = " entity) {"; //305:33
            if (__tmp49Line != null) __out.Append(__tmp49Line);
            __out.AppendLine(false); //305:43
            __out.Append("		repository.delete(entity);"); //306:1
            __out.AppendLine(false); //306:29
            __out.Append("	}"); //307:1
            __out.AppendLine(false); //307:3
            __out.AppendLine(true); //308:1
            __out.Append("	@Override"); //309:1
            __out.AppendLine(false); //309:11
            string __tmp51Line = "	public void delete(Iterable<? extends "; //310:1
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
            string __tmp53Line = "> entities) {"; //310:52
            if (__tmp53Line != null) __out.Append(__tmp53Line);
            __out.AppendLine(false); //310:65
            __out.Append("		repository.delete(entities);"); //311:1
            __out.AppendLine(false); //311:31
            __out.Append("	}"); //312:1
            __out.AppendLine(false); //312:3
            __out.AppendLine(true); //313:1
            __out.Append("	@Override"); //314:1
            __out.AppendLine(false); //314:11
            __out.Append("	public void deleteAll() {"); //315:1
            __out.AppendLine(false); //315:27
            __out.Append("		repository.deleteAll();"); //316:1
            __out.AppendLine(false); //316:26
            __out.Append("	}"); //317:1
            __out.AppendLine(false); //317:3
            __out.AppendLine(true); //318:1
            __out.Append("	@Override"); //319:1
            __out.AppendLine(false); //319:11
            __out.Append("	public boolean exists(Long id) {"); //320:1
            __out.AppendLine(false); //320:34
            __out.Append("		return repository.exists(id);"); //321:1
            __out.AppendLine(false); //321:32
            __out.Append("	}"); //322:1
            __out.AppendLine(false); //322:3
            __out.AppendLine(true); //323:1
            __out.Append("	@Override"); //324:1
            __out.AppendLine(false); //324:11
            string __tmp55Line = "	public Iterable<"; //325:1
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
            string __tmp57Line = "> findAll() {"; //325:30
            if (__tmp57Line != null) __out.Append(__tmp57Line);
            __out.AppendLine(false); //325:43
            __out.Append("		return repository.findAll();"); //326:1
            __out.AppendLine(false); //326:31
            __out.Append("	}"); //327:1
            __out.AppendLine(false); //327:3
            __out.AppendLine(true); //328:1
            __out.Append("	@Override"); //329:1
            __out.AppendLine(false); //329:11
            string __tmp59Line = "	public Iterable<"; //330:1
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
            string __tmp61Line = "> findAll(Iterable<Long> entities) {"; //330:30
            if (__tmp61Line != null) __out.Append(__tmp61Line);
            __out.AppendLine(false); //330:66
            __out.Append("		return repository.findAll(entities);"); //331:1
            __out.AppendLine(false); //331:39
            __out.Append("	}"); //332:1
            __out.AppendLine(false); //332:3
            __out.AppendLine(true); //333:1
            __out.Append("	@Override"); //334:1
            __out.AppendLine(false); //334:11
            string __tmp63Line = "	public "; //335:1
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
            string __tmp65Line = " findOne(Long id) {"; //335:21
            if (__tmp65Line != null) __out.Append(__tmp65Line);
            __out.AppendLine(false); //335:40
            __out.Append("		return repository.findOne(id);"); //336:1
            __out.AppendLine(false); //336:33
            __out.Append("	}"); //337:1
            __out.AppendLine(false); //337:3
            __out.AppendLine(true); //338:1
            __out.Append("	@Override"); //339:1
            __out.AppendLine(false); //339:11
            string __tmp67Line = "	public <S extends "; //340:1
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
            string __tmp69Line = "> S save(S entity) {"; //340:32
            if (__tmp69Line != null) __out.Append(__tmp69Line);
            __out.AppendLine(false); //340:52
            __out.Append("		return repository.save(entity);"); //341:1
            __out.AppendLine(false); //341:34
            __out.Append("	}"); //342:1
            __out.AppendLine(false); //342:3
            __out.AppendLine(true); //343:1
            __out.Append("	@Override"); //344:1
            __out.AppendLine(false); //344:11
            string __tmp71Line = "	public <S extends "; //345:1
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
            string __tmp73Line = "> Iterable<S> save(Iterable<S> entities) {"; //345:32
            if (__tmp73Line != null) __out.Append(__tmp73Line);
            __out.AppendLine(false); //345:74
            __out.Append("		return repository.save(entities);"); //346:1
            __out.AppendLine(false); //346:36
            __out.Append("	}"); //347:1
            __out.AppendLine(false); //347:3
            __out.AppendLine(true); //348:1
            __out.Append("}"); //349:1
            __out.AppendLine(false); //349:2
            return __out.ToString();
        }

        public string InterfaceAnnotation(string bindingType) //353:1
        {
            StringBuilder __out = new StringBuilder();
            if (bindingType.Equals("Rest")) //354:3
            {
                __out.Append("@RestController"); //355:1
                __out.AppendLine(false); //355:16
                __out.Append("@RequestMapping(method = RequestMethod.GET)"); //356:1
                __out.AppendLine(false); //356:44
            }
            else if (bindingType.Equals("WebService")) //357:3
            {
                __out.Append("//@WebService"); //358:1
                __out.AppendLine(false); //358:14
            }
            else if (bindingType.Equals("WebSockett")) //359:3
            {
                __out.Append("//@WebSocket"); //360:1
                __out.AppendLine(false); //360:13
            }
            return __out.ToString();
        }

        public string OperationAnnotation(Operation op, string bindingType) //366:1
        {
            StringBuilder __out = new StringBuilder();
            if (bindingType.Equals("Rest")) //367:3
            {
                string __tmp2Line = "	@RequestMapping(value = \"/"; //368:1
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
                    (from __loop12_var1 in __Enumerate((op).GetEnumerator()) //369:9
                    from param in __Enumerate((__loop12_var1.Parameters).GetEnumerator()) //369:13
                    select new { __loop12_var1 = __loop12_var1, param = param}
                    ).ToList(); //369:4
                int __loop12_iteration = 0;
                foreach (var __tmp4 in __loop12_results)
                {
                    ++__loop12_iteration;
                    var __loop12_var1 = __tmp4.__loop12_var1;
                    var param = __tmp4.param;
                    if (param.Type.IsJavaPrimitiveType()) //370:5
                    {
                        string __tmp6Line = "/{"; //371:1
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
                        string __tmp8Line = "}"; //371:15
                        if (__tmp8Line != null) __out.Append(__tmp8Line);
                    }
                }
                __out.Append("\""); //374:1
                if (!op.Name.ToPascalCase().StartsWith("Get")) //375:4
                {
                    __out.Append(", method = RequestMethod.POST /* TODO consider other method */"); //376:1
                }
                __out.Append(")"); //378:1
                __out.AppendLine(false); //378:2
            }
            else if (bindingType.Equals("WebService")) //379:3
            {
                __out.Append("	//@WebService"); //380:1
                __out.AppendLine(false); //380:15
            }
            else if (bindingType.Equals("WebSockett")) //381:3
            {
                __out.Append("	//@WebSocket"); //382:1
                __out.AppendLine(false); //382:14
            }
            return __out.ToString();
        }

        public string ParameterAnnotation(InputParameter parameter, string bindingType) //388:1
        {
            StringBuilder __out = new StringBuilder();
            if (bindingType.Equals("Rest")) //389:3
            {
                if (parameter.Type.IsJavaPrimitiveType()) //390:4
                {
                    __out.Append("@PathVariable "); //391:1
                }
            }
            else if (bindingType.Equals("WebService")) //393:3
            {
            }
            else if (bindingType.Equals("WebSockett")) //395:3
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
