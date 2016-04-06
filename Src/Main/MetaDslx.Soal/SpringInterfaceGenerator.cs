using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Soal //1:1
{
    using __Hidden_SpringInterfaceGenerator_1390256131;
    namespace __Hidden_SpringInterfaceGenerator_1390256131
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
            string __tmp6Line = "import "; //124:1
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
            string __tmp8Line = "."; //124:47
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
            string __tmp10Line = "."; //124:97
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
            string __tmp13Line = ";"; //124:123
            if (__tmp13Line != null) __out.Append(__tmp13Line);
            __out.AppendLine(false); //124:124
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
                    __out.AppendLine(false); //125:52
                }
            }
            __out.AppendLine(true); //126:1
            __out.Append("import javax.servlet.http.HttpServletRequest;"); //127:1
            __out.AppendLine(false); //127:46
            __out.Append("import java.util.Arrays;"); //128:1
            __out.AppendLine(false); //128:25
            __out.Append("import java.util.List;"); //129:1
            __out.AppendLine(false); //129:23
            __out.Append("import java.util.stream.Collectors;"); //130:1
            __out.AppendLine(false); //130:36
            __out.AppendLine(true); //131:1
            __out.Append("@Service"); //132:1
            __out.AppendLine(false); //132:9
            string __tmp17Line = "public class "; //133:1
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
            string __tmp20Line = "Proxy implements "; //133:39
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
            string __tmp23Line = " {"; //133:81
            if (__tmp23Line != null) __out.Append(__tmp23Line);
            __out.AppendLine(false); //133:83
            __out.AppendLine(true); //134:1
            __out.Append("	private RestTemplate restTemplate = new RestTemplate();"); //135:1
            __out.AppendLine(false); //135:57
            var __loop6_results = 
                (from __loop6_var1 in __Enumerate((iface).GetEnumerator()) //137:7
                from op in __Enumerate((__loop6_var1.Operations).GetEnumerator()) //137:14
                select new { __loop6_var1 = __loop6_var1, op = op}
                ).ToList(); //137:2
            int __loop6_iteration = 0;
            foreach (var __tmp24 in __loop6_results)
            {
                ++__loop6_iteration;
                var __loop6_var1 = __tmp24.__loop6_var1;
                var op = __tmp24.op;
                __out.AppendLine(true); //138:2
                string __tmp26Line = "	private String urlOf"; //139:1
                if (__tmp26Line != null) __out.Append(__tmp26Line);
                StringBuilder __tmp27 = new StringBuilder();
                __tmp27.Append(op.Name.ToPascalCase());
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
                string __tmp28Line = ";"; //139:46
                if (__tmp28Line != null) __out.Append(__tmp28Line);
                __out.AppendLine(false); //139:47
            }
            var __loop7_results = 
                (from __loop7_var1 in __Enumerate((iface).GetEnumerator()) //142:7
                from op in __Enumerate((__loop7_var1.Operations).GetEnumerator()) //142:14
                select new { __loop7_var1 = __loop7_var1, op = op}
                ).ToList(); //142:2
            int __loop7_iteration = 0;
            foreach (var __tmp29 in __loop7_results)
            {
                ++__loop7_iteration;
                var __loop7_var1 = __tmp29.__loop7_var1;
                var op = __tmp29.op;
                __out.AppendLine(true); //143:1
                __out.Append("	@Override"); //144:1
                __out.AppendLine(false); //144:11
                string __tmp31Line = "	public "; //145:1
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
                string __tmp33Line = " "; //145:39
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
                string __tmp35Line = "("; //145:63
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
                string __tmp37Line = ")"; //145:106
                if (__tmp37Line != null) __out.Append(__tmp37Line);
                if (op.Exceptions.Any()) //146:3
                {
                    string __tmp39Line = " throws "; //147:1
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
                    string __tmp41Line = " "; //147:51
                    if (__tmp41Line != null) __out.Append(__tmp41Line);
                }
                __out.Append("{"); //149:1
                __out.AppendLine(false); //149:2
                string __tmp43Line = "		String url = getUrlOf"; //150:1
                if (__tmp43Line != null) __out.Append(__tmp43Line);
                StringBuilder __tmp44 = new StringBuilder();
                __tmp44.Append(op.Name.ToPascalCase());
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
                string __tmp45Line = "();"; //150:48
                if (__tmp45Line != null) __out.Append(__tmp45Line);
                __out.AppendLine(false); //150:51
                ArrayType array = op.Result.Type as ArrayType; //151:3
                if (array != null) //152:3
                {
                    string __tmp46Prefix = "		"; //153:1
                    StringBuilder __tmp47 = new StringBuilder();
                    __tmp47.Append(array.InnerType.GetJavaName());
                    using(StreamReader __tmp47Reader = new StreamReader(this.__ToStream(__tmp47.ToString())))
                    {
                        bool __tmp47_first = true;
                        bool __tmp47_last = __tmp47Reader.EndOfStream;
                        while(__tmp47_first || !__tmp47_last)
                        {
                            __tmp47_first = false;
                            string __tmp47Line = __tmp47Reader.ReadLine();
                            __tmp47_last = __tmp47Reader.EndOfStream;
                            __out.Append(__tmp46Prefix);
                            if (__tmp47Line != null) __out.Append(__tmp47Line);
                            if (!__tmp47_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp48Line = "\\"; //153:34
                    if (__tmp48Line != null) __out.Append(__tmp48Line);
                    string __tmp50Line = " response = restTemplate.getForObject(url, "; //153:38
                    if (__tmp50Line != null) __out.Append(__tmp50Line);
                    StringBuilder __tmp51 = new StringBuilder();
                    __tmp51.Append(array.InnerType.GetJavaName());
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
                    string __tmp52Line = "\\"; //153:112
                    if (__tmp52Line != null) __out.Append(__tmp52Line);
                    string __tmp54Line = ".class);"; //153:116
                    if (__tmp54Line != null) __out.Append(__tmp54Line);
                    __out.AppendLine(false); //153:124
                }
                else //154:3
                {
                    string __tmp55Prefix = "		"; //155:1
                    StringBuilder __tmp56 = new StringBuilder();
                    __tmp56.Append(op.Result.Type.GetJavaName());
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
                    string __tmp57Line = "\\"; //155:33
                    if (__tmp57Line != null) __out.Append(__tmp57Line);
                    string __tmp59Line = " response = restTemplate.getForObject(url, "; //155:37
                    if (__tmp59Line != null) __out.Append(__tmp59Line);
                    StringBuilder __tmp60 = new StringBuilder();
                    __tmp60.Append(op.Result.Type.GetJavaName());
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
                    string __tmp61Line = "\\"; //155:110
                    if (__tmp61Line != null) __out.Append(__tmp61Line);
                    string __tmp63Line = ".class);"; //155:114
                    if (__tmp63Line != null) __out.Append(__tmp63Line);
                    __out.AppendLine(false); //155:122
                }
                if (op.Result.Type.GetJavaName() != "void") //158:3
                {
                    __out.Append("		return Arrays.stream(response).collect(Collectors.toList());"); //159:1
                    __out.AppendLine(false); //159:63
                }
                else //160:3
                {
                    __out.Append("			//FIXME"); //161:1
                    __out.AppendLine(false); //161:11
                    string __tmp65Line = "		//"; //162:1
                    if (__tmp65Line != null) __out.Append(__tmp65Line);
                    StringBuilder __tmp66 = new StringBuilder();
                    __tmp66.Append(iface.Name.ToCamelCase());
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
                    string __tmp67Line = "Impl."; //162:31
                    if (__tmp67Line != null) __out.Append(__tmp67Line);
                    StringBuilder __tmp68 = new StringBuilder();
                    __tmp68.Append(op.Name.ToCamelCase());
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
                    string __tmp69Line = "("; //162:59
                    if (__tmp69Line != null) __out.Append(__tmp69Line);
                    StringBuilder __tmp70 = new StringBuilder();
                    __tmp70.Append(SpringGeneratorUtil.GetParameterNameList(op));
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
                    string __tmp71Line = ");"; //162:106
                    if (__tmp71Line != null) __out.Append(__tmp71Line);
                    __out.AppendLine(false); //162:108
                }
                __out.Append("	}"); //164:1
                __out.AppendLine(false); //164:3
            }
            var __loop8_results = 
                (from __loop8_var1 in __Enumerate((iface).GetEnumerator()) //167:7
                from op in __Enumerate((__loop8_var1.Operations).GetEnumerator()) //167:14
                select new { __loop8_var1 = __loop8_var1, op = op}
                ).ToList(); //167:2
            int __loop8_iteration = 0;
            foreach (var __tmp72 in __loop8_results)
            {
                ++__loop8_iteration;
                var __loop8_var1 = __tmp72.__loop8_var1;
                var op = __tmp72.op;
                __out.AppendLine(true); //168:2
                string __tmp74Line = "	private String getUrlOf"; //169:1
                if (__tmp74Line != null) __out.Append(__tmp74Line);
                StringBuilder __tmp75 = new StringBuilder();
                __tmp75.Append(op.Name.ToPascalCase());
                using(StreamReader __tmp75Reader = new StreamReader(this.__ToStream(__tmp75.ToString())))
                {
                    bool __tmp75_first = true;
                    bool __tmp75_last = __tmp75Reader.EndOfStream;
                    while(__tmp75_first || !__tmp75_last)
                    {
                        __tmp75_first = false;
                        string __tmp75Line = __tmp75Reader.ReadLine();
                        __tmp75_last = __tmp75Reader.EndOfStream;
                        if (__tmp75Line != null) __out.Append(__tmp75Line);
                        if (!__tmp75_last) __out.AppendLine(true);
                    }
                }
                string __tmp76Line = "() {"; //169:49
                if (__tmp76Line != null) __out.Append(__tmp76Line);
                __out.AppendLine(false); //169:53
                string __tmp78Line = "        if (this.urlOf"; //170:1
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
                string __tmp80Line = " != null) {"; //170:47
                if (__tmp80Line != null) __out.Append(__tmp80Line);
                __out.AppendLine(false); //170:58
                string __tmp82Line = "            return this.urlOf"; //171:1
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
                string __tmp84Line = ";"; //171:54
                if (__tmp84Line != null) __out.Append(__tmp84Line);
                __out.AppendLine(false); //171:55
                __out.Append("        }"); //172:1
                __out.AppendLine(false); //172:10
                __out.AppendLine(true); //173:3
                __out.Append("        // eg.: http://127.0.0.2:8080/Cinema-CinemaWeb-1.0/getMoviesFromReservation/"); //174:1
                __out.AppendLine(false); //174:85
                __out.Append("        Link link = linkTo(methodOn(IReservationLogicRest.class).getMoviesFromReservation()).withSelfRel();"); //175:1
                __out.AppendLine(false); //175:108
                string currentComponent = "CinemaWeb"; //176:4
                string targetComponent = "ReservationLogic"; //177:4
                string __tmp86Line = "        String currentComponentName = \"Cinema-"; //178:1
                if (__tmp86Line != null) __out.Append(__tmp86Line);
                StringBuilder __tmp87 = new StringBuilder();
                __tmp87.Append(currentComponent);
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
                string __tmp88Line = "\";"; //178:65
                if (__tmp88Line != null) __out.Append(__tmp88Line);
                __out.AppendLine(false); //178:67
                string __tmp90Line = "        String targetComponentName = \"Cinema-"; //179:1
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
                string __tmp92Line = "\";"; //179:63
                if (__tmp92Line != null) __out.Append(__tmp92Line);
                __out.AppendLine(false); //179:65
                __out.Append("        RequestAttributes requestAttributes = RequestContextHolder.currentRequestAttributes();"); //180:1
                __out.AppendLine(false); //180:95
                __out.Append("        HttpServletRequest curRequest = ((ServletRequestAttributes) requestAttributes).getRequest();"); //181:1
                __out.AppendLine(false); //181:101
                __out.Append("        String serverName = curRequest.getServerName();"); //182:1
                __out.AppendLine(false); //182:56
                __out.Append("        String serverPort = String.valueOf(curRequest.getServerPort());"); //183:1
                __out.AppendLine(false); //183:72
                __out.AppendLine(true); //184:3
                __out.Append("        // eg.: http://127.0.0.2:8080/Cinema-ReservationLogic-1.0/getMoviesFromReservation/"); //185:1
                __out.AppendLine(false); //185:92
                __out.Append("        String url = link.getHref();"); //186:1
                __out.AppendLine(false); //186:37
                string __tmp94Line = "        url = url.replace(serverName, Configuration.getString(\""; //187:1
                if (__tmp94Line != null) __out.Append(__tmp94Line);
                StringBuilder __tmp95 = new StringBuilder();
                __tmp95.Append(targetComponent);
                using(StreamReader __tmp95Reader = new StreamReader(this.__ToStream(__tmp95.ToString())))
                {
                    bool __tmp95_first = true;
                    bool __tmp95_last = __tmp95Reader.EndOfStream;
                    while(__tmp95_first || !__tmp95_last)
                    {
                        __tmp95_first = false;
                        string __tmp95Line = __tmp95Reader.ReadLine();
                        __tmp95_last = __tmp95Reader.EndOfStream;
                        if (__tmp95Line != null) __out.Append(__tmp95Line);
                        if (!__tmp95_last) __out.AppendLine(true);
                    }
                }
                StringBuilder __tmp96 = new StringBuilder();
                __tmp96.Append(bindingType);
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
                string __tmp97Line = "Server\"));"; //187:94
                if (__tmp97Line != null) __out.Append(__tmp97Line);
                __out.AppendLine(false); //187:104
                string __tmp99Line = "        url = url.replace(\":\" + serverPort, \":\" + Configuration.getString("; //188:1
                if (__tmp99Line != null) __out.Append(__tmp99Line);
                StringBuilder __tmp100 = new StringBuilder();
                __tmp100.Append(targetComponent);
                using(StreamReader __tmp100Reader = new StreamReader(this.__ToStream(__tmp100.ToString())))
                {
                    bool __tmp100_first = true;
                    bool __tmp100_last = __tmp100Reader.EndOfStream;
                    while(__tmp100_first || !__tmp100_last)
                    {
                        __tmp100_first = false;
                        string __tmp100Line = __tmp100Reader.ReadLine();
                        __tmp100_last = __tmp100Reader.EndOfStream;
                        if (__tmp100Line != null) __out.Append(__tmp100Line);
                        if (!__tmp100_last) __out.AppendLine(true);
                    }
                }
                StringBuilder __tmp101 = new StringBuilder();
                __tmp101.Append(bindingType);
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
                string __tmp102Line = "Port\"));"; //188:105
                if (__tmp102Line != null) __out.Append(__tmp102Line);
                __out.AppendLine(false); //188:113
                __out.Append("        url = url.replace(currentComponentName, targetComponentName);"); //189:1
                __out.AppendLine(false); //189:70
                __out.AppendLine(true); //190:3
                string __tmp104Line = "        this.urlOf"; //191:1
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
                string __tmp106Line = " = url;"; //191:43
                if (__tmp106Line != null) __out.Append(__tmp106Line);
                __out.AppendLine(false); //191:50
                __out.Append("        return url;"); //192:1
                __out.AppendLine(false); //192:20
                __out.Append("    }"); //193:1
                __out.AppendLine(false); //193:6
            }
            __out.Append("}"); //195:1
            __out.AppendLine(false); //195:2
            return __out.ToString();
        }

        public string GenerateCrudRepositoryCopy(string namespaceName, string entityName, string bindingType) //200:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp2Line = "package "; //201:1
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
            string __tmp4Line = "."; //201:34
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
            string __tmp6Line = ";"; //201:84
            if (__tmp6Line != null) __out.Append(__tmp6Line);
            __out.AppendLine(false); //201:85
            __out.AppendLine(true); //202:1
            string __tmp8Line = "import "; //203:1
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
            string __tmp10Line = "."; //203:33
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
            string __tmp12Line = "."; //203:80
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
            string __tmp14Line = ";"; //203:93
            if (__tmp14Line != null) __out.Append(__tmp14Line);
            __out.AppendLine(false); //203:94
            __out.AppendLine(true); //204:1
            string __tmp16Line = "public interface "; //205:1
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
            string __tmp18Line = "Repository"; //205:30
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
            string __tmp20Line = " {"; //205:53
            if (__tmp20Line != null) __out.Append(__tmp20Line);
            __out.AppendLine(false); //205:55
            string __tmp22Line = "	// should copy CrudRepository<"; //206:1
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
            string __tmp24Line = ", Long>"; //206:44
            if (__tmp24Line != null) __out.Append(__tmp24Line);
            __out.AppendLine(false); //206:51
            __out.AppendLine(true); //207:1
            __out.Append("	public long count();"); //208:1
            __out.AppendLine(false); //208:22
            __out.AppendLine(true); //209:1
            __out.Append("	public void delete(Long id);"); //210:1
            __out.AppendLine(false); //210:30
            __out.AppendLine(true); //211:1
            string __tmp26Line = "	public void delete("; //212:1
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
            string __tmp28Line = " entity);"; //212:33
            if (__tmp28Line != null) __out.Append(__tmp28Line);
            __out.AppendLine(false); //212:42
            __out.AppendLine(true); //213:1
            string __tmp30Line = "	public void delete(Iterable<? extends "; //214:1
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
            string __tmp32Line = "> entities);"; //214:52
            if (__tmp32Line != null) __out.Append(__tmp32Line);
            __out.AppendLine(false); //214:64
            __out.AppendLine(true); //215:1
            __out.Append("	public void deleteAll();"); //216:1
            __out.AppendLine(false); //216:26
            __out.AppendLine(true); //217:1
            __out.Append("	public boolean exists(Long id) ;"); //218:1
            __out.AppendLine(false); //218:34
            __out.AppendLine(true); //219:1
            string __tmp34Line = "	public Iterable<"; //220:1
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
            string __tmp36Line = "> findAll();"; //220:30
            if (__tmp36Line != null) __out.Append(__tmp36Line);
            __out.AppendLine(false); //220:42
            __out.AppendLine(true); //221:1
            string __tmp38Line = "	public Iterable<"; //222:1
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
            string __tmp40Line = "> findAll(Iterable<Long> entities);"; //222:30
            if (__tmp40Line != null) __out.Append(__tmp40Line);
            __out.AppendLine(false); //222:65
            __out.AppendLine(true); //223:1
            string __tmp42Line = "	public "; //224:1
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
            string __tmp44Line = " findOne(Long id);"; //224:21
            if (__tmp44Line != null) __out.Append(__tmp44Line);
            __out.AppendLine(false); //224:39
            __out.AppendLine(true); //225:1
            string __tmp46Line = "	public <S extends "; //226:1
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
            string __tmp48Line = "> S save(S entity);"; //226:32
            if (__tmp48Line != null) __out.Append(__tmp48Line);
            __out.AppendLine(false); //226:51
            __out.AppendLine(true); //227:1
            string __tmp50Line = "	public <S extends "; //228:1
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
            string __tmp52Line = "> Iterable<S> save(Iterable<S> entities);"; //228:32
            if (__tmp52Line != null) __out.Append(__tmp52Line);
            __out.AppendLine(false); //228:73
            __out.AppendLine(true); //229:1
            __out.Append("}"); //230:1
            __out.AppendLine(false); //230:2
            return __out.ToString();
        }

        public string GenerateRepositoryProxyImpl(string namespaceName, string entityName, string bindingType) //234:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp2Line = "package "; //235:1
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
            string __tmp4Line = "."; //235:34
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
            string __tmp6Line = ";"; //235:85
            if (__tmp6Line != null) __out.Append(__tmp6Line);
            __out.AppendLine(false); //235:86
            __out.AppendLine(true); //236:1
            __out.Append("import org.springframework.beans.factory.annotation.Autowired;"); //237:1
            __out.AppendLine(false); //237:63
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
            string __tmp16Line = "import "; //240:1
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
            string __tmp18Line = "."; //240:33
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
            string __tmp20Line = "."; //240:84
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
            string __tmp22Line = "Repository;"; //240:97
            if (__tmp22Line != null) __out.Append(__tmp22Line);
            __out.AppendLine(false); //240:108
            string __tmp24Line = "import "; //241:1
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
            string __tmp26Line = "."; //241:33
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
            string __tmp28Line = "."; //241:83
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
            string __tmp30Line = "Repository"; //241:96
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
            string __tmp32Line = ";"; //241:119
            if (__tmp32Line != null) __out.Append(__tmp32Line);
            __out.AppendLine(false); //241:120
            __out.AppendLine(true); //242:1
            string __tmp34Line = "public class "; //243:1
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
            string __tmp36Line = "Repository"; //243:26
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
            string __tmp38Line = "Impl implements "; //243:49
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
            string __tmp40Line = "Repository"; //243:77
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
            string __tmp42Line = " {"; //243:100
            if (__tmp42Line != null) __out.Append(__tmp42Line);
            __out.AppendLine(false); //243:102
            __out.AppendLine(true); //244:1
            __out.Append("	@Autowired"); //245:1
            __out.AppendLine(false); //245:12
            string __tmp43Prefix = "	"; //246:1
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
            string __tmp45Line = "Repository repository;"; //246:14
            if (__tmp45Line != null) __out.Append(__tmp45Line);
            __out.AppendLine(false); //246:36
            __out.AppendLine(true); //247:1
            __out.Append("	@Override"); //248:1
            __out.AppendLine(false); //248:11
            __out.Append("	public long count() {"); //249:1
            __out.AppendLine(false); //249:23
            __out.Append("		return repository.count();"); //250:1
            __out.AppendLine(false); //250:29
            __out.Append("	}"); //251:1
            __out.AppendLine(false); //251:3
            __out.AppendLine(true); //252:1
            __out.Append("	@Override"); //253:1
            __out.AppendLine(false); //253:11
            __out.Append("	public void delete(Long id) {"); //254:1
            __out.AppendLine(false); //254:31
            __out.Append("		repository.delete(id);"); //255:1
            __out.AppendLine(false); //255:25
            __out.Append("	}"); //256:1
            __out.AppendLine(false); //256:3
            __out.AppendLine(true); //257:1
            __out.Append("	@Override"); //258:1
            __out.AppendLine(false); //258:11
            string __tmp47Line = "	public void delete("; //259:1
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
            string __tmp49Line = " entity) {"; //259:33
            if (__tmp49Line != null) __out.Append(__tmp49Line);
            __out.AppendLine(false); //259:43
            __out.Append("		repository.delete(entity);"); //260:1
            __out.AppendLine(false); //260:29
            __out.Append("	}"); //261:1
            __out.AppendLine(false); //261:3
            __out.AppendLine(true); //262:1
            __out.Append("	@Override"); //263:1
            __out.AppendLine(false); //263:11
            string __tmp51Line = "	public void delete(Iterable<? extends "; //264:1
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
            string __tmp53Line = "> entities) {"; //264:52
            if (__tmp53Line != null) __out.Append(__tmp53Line);
            __out.AppendLine(false); //264:65
            __out.Append("		repository.delete(entities);"); //265:1
            __out.AppendLine(false); //265:31
            __out.Append("	}"); //266:1
            __out.AppendLine(false); //266:3
            __out.AppendLine(true); //267:1
            __out.Append("	@Override"); //268:1
            __out.AppendLine(false); //268:11
            __out.Append("	public void deleteAll() {"); //269:1
            __out.AppendLine(false); //269:27
            __out.Append("		repository.deleteAll();"); //270:1
            __out.AppendLine(false); //270:26
            __out.Append("	}"); //271:1
            __out.AppendLine(false); //271:3
            __out.AppendLine(true); //272:1
            __out.Append("	@Override"); //273:1
            __out.AppendLine(false); //273:11
            __out.Append("	public boolean exists(Long id) {"); //274:1
            __out.AppendLine(false); //274:34
            __out.Append("		return repository.exists(id);"); //275:1
            __out.AppendLine(false); //275:32
            __out.Append("	}"); //276:1
            __out.AppendLine(false); //276:3
            __out.AppendLine(true); //277:1
            __out.Append("	@Override"); //278:1
            __out.AppendLine(false); //278:11
            string __tmp55Line = "	public Iterable<"; //279:1
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
            string __tmp57Line = "> findAll() {"; //279:30
            if (__tmp57Line != null) __out.Append(__tmp57Line);
            __out.AppendLine(false); //279:43
            __out.Append("		return repository.findAll();"); //280:1
            __out.AppendLine(false); //280:31
            __out.Append("	}"); //281:1
            __out.AppendLine(false); //281:3
            __out.AppendLine(true); //282:1
            __out.Append("	@Override"); //283:1
            __out.AppendLine(false); //283:11
            string __tmp59Line = "	public Iterable<"; //284:1
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
            string __tmp61Line = "> findAll(Iterable<Long> entities) {"; //284:30
            if (__tmp61Line != null) __out.Append(__tmp61Line);
            __out.AppendLine(false); //284:66
            __out.Append("		return repository.findAll(entities);"); //285:1
            __out.AppendLine(false); //285:39
            __out.Append("	}"); //286:1
            __out.AppendLine(false); //286:3
            __out.AppendLine(true); //287:1
            __out.Append("	@Override"); //288:1
            __out.AppendLine(false); //288:11
            string __tmp63Line = "	public "; //289:1
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
            string __tmp65Line = " findOne(Long id) {"; //289:21
            if (__tmp65Line != null) __out.Append(__tmp65Line);
            __out.AppendLine(false); //289:40
            __out.Append("		return repository.findOne(id);"); //290:1
            __out.AppendLine(false); //290:33
            __out.Append("	}"); //291:1
            __out.AppendLine(false); //291:3
            __out.AppendLine(true); //292:1
            __out.Append("	@Override"); //293:1
            __out.AppendLine(false); //293:11
            string __tmp67Line = "	public <S extends "; //294:1
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
            string __tmp69Line = "> S save(S entity) {"; //294:32
            if (__tmp69Line != null) __out.Append(__tmp69Line);
            __out.AppendLine(false); //294:52
            __out.Append("		return repository.save(entity);"); //295:1
            __out.AppendLine(false); //295:34
            __out.Append("	}"); //296:1
            __out.AppendLine(false); //296:3
            __out.AppendLine(true); //297:1
            __out.Append("	@Override"); //298:1
            __out.AppendLine(false); //298:11
            string __tmp71Line = "	public <S extends "; //299:1
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
            string __tmp73Line = "> Iterable<S> save(Iterable<S> entities) {"; //299:32
            if (__tmp73Line != null) __out.Append(__tmp73Line);
            __out.AppendLine(false); //299:74
            __out.Append("		return repository.save(entities);"); //300:1
            __out.AppendLine(false); //300:36
            __out.Append("	}"); //301:1
            __out.AppendLine(false); //301:3
            __out.AppendLine(true); //302:1
            __out.Append("}"); //303:1
            __out.AppendLine(false); //303:2
            return __out.ToString();
        }

        public string InterfaceAnnotation(string bindingType) //307:1
        {
            StringBuilder __out = new StringBuilder();
            if (bindingType.Equals("Rest")) //308:3
            {
                __out.Append("@RestController"); //309:1
                __out.AppendLine(false); //309:16
            }
            else if (bindingType.Equals("WebService")) //310:3
            {
                __out.Append("//@WebService"); //311:1
                __out.AppendLine(false); //311:14
            }
            else if (bindingType.Equals("WebSockett")) //312:3
            {
                __out.Append("//@WebSocket"); //313:1
                __out.AppendLine(false); //313:13
            }
            return __out.ToString();
        }

        public string OperationAnnotation(string bindingType, Operation op) //319:1
        {
            StringBuilder __out = new StringBuilder();
            if (bindingType.Equals("Rest")) //320:3
            {
                string __tmp2Line = "	@RequestMapping(value=\""; //321:1
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
                string __tmp4Line = "\")"; //321:48
                if (__tmp4Line != null) __out.Append(__tmp4Line);
                __out.AppendLine(false); //321:50
            }
            else if (bindingType.Equals("WebService")) //322:3
            {
                __out.Append("	//@WebService"); //323:1
                __out.AppendLine(false); //323:15
            }
            else if (bindingType.Equals("WebSockett")) //324:3
            {
                __out.Append("	//@WebSocket"); //325:1
                __out.AppendLine(false); //325:14
            }
            return __out.ToString();
        }

        public string ParameterAnnotation(string bindingType) //331:1
        {
            StringBuilder __out = new StringBuilder();
            if (bindingType.Equals("Rest")) //332:3
            {
                __out.Append("@PathVariable "); //333:1
            }
            else if (bindingType.Equals("WebService")) //334:3
            {
            }
            else if (bindingType.Equals("WebSockett")) //336:3
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
