using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Soal //1:1
{
    using __Hidden_SpringGenerator_1999720204;
    namespace __Hidden_SpringGenerator_1999720204
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

    public class SpringGenerator //2:1
    {
        private object Instances; //2:1

        public SpringGenerator() //2:1
        {
            this.Properties = new __Properties();
        }

        public SpringGenerator(object instances) : this() //2:1
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

        public __Properties Properties { get; private set; } //6:1

        public class __Properties //6:1
        {
            internal __Properties()
            {
                this.util = new SpringGeneratorUtil(); //7:29
            }
            public SpringGeneratorUtil util { get; set; } //7:2
        }

        public string GenerateInterface(Interface iface) //10:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp1Prefix = "package "; //11:1
            string __tmp2Suffix = ";"; //11:94
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(SpringGeneratorUtil.GetPackage(iface));
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
            string __tmp4Line = "."; //11:48
            __out.Append(__tmp4Line);
            StringBuilder __tmp5 = new StringBuilder();
            __tmp5.Append(Properties.util.Properties.interfacePackage);
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
                    __out.AppendLine(); //11:95
                }
            }
            __out.AppendLine(); //12:1
            string __tmp6Prefix = "public interface "; //13:1
            string __tmp7Suffix = " {"; //13:30
            StringBuilder __tmp8 = new StringBuilder();
            __tmp8.Append(iface.Name);
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
                    __out.AppendLine(); //13:32
                }
            }
            var __loop1_results = 
                (from __loop1_var1 in __Enumerate((iface).GetEnumerator()) //14:8
                from op in __Enumerate((__loop1_var1.Operations).GetEnumerator()) //14:15
                select new { __loop1_var1 = __loop1_var1, op = op}
                ).ToList(); //14:2
            int __loop1_iteration = 0;
            foreach (var __tmp9 in __loop1_results)
            {
                ++__loop1_iteration;
                var __loop1_var1 = __tmp9.__loop1_var1;
                var op = __tmp9.op;
                string __tmp10Prefix = "	"; //15:1
                string __tmp11Suffix = ");"; //15:84
                StringBuilder __tmp12 = new StringBuilder();
                __tmp12.Append(op.ReturnType.GetJavaName());
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
                        __out.Append(__tmp10Prefix);
                        __out.Append(__tmp12Line);
                    }
                }
                string __tmp13Line = " "; //15:31
                __out.Append(__tmp13Line);
                StringBuilder __tmp14 = new StringBuilder();
                __tmp14.Append(op.Name);
                using(StreamReader __tmp14Reader = new StreamReader(this.__ToStream(__tmp14.ToString())))
                {
                    bool __tmp14_first = true;
                    while(__tmp14_first || !__tmp14Reader.EndOfStream)
                    {
                        __tmp14_first = false;
                        string __tmp14Line = __tmp14Reader.ReadLine();
                        if (__tmp14Line == null)
                        {
                            __tmp14Line = "";
                        }
                        __out.Append(__tmp14Line);
                    }
                }
                string __tmp15Line = "("; //15:41
                __out.Append(__tmp15Line);
                StringBuilder __tmp16 = new StringBuilder();
                __tmp16.Append(SpringGeneratorUtil.GetParameterList(op));
                using(StreamReader __tmp16Reader = new StreamReader(this.__ToStream(__tmp16.ToString())))
                {
                    bool __tmp16_first = true;
                    while(__tmp16_first || !__tmp16Reader.EndOfStream)
                    {
                        __tmp16_first = false;
                        string __tmp16Line = __tmp16Reader.ReadLine();
                        if (__tmp16Line == null)
                        {
                            __tmp16Line = "";
                        }
                        __out.Append(__tmp16Line);
                        __out.Append(__tmp11Suffix);
                        __out.AppendLine(); //15:86
                    }
                }
            }
            __out.Append("}"); //17:1
            __out.AppendLine(); //17:2
            return __out.ToString();
        }

        public string GenerateComponent(Component component) //20:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp1Prefix = "package "; //21:1
            string __tmp2Suffix = ";"; //21:106
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(SpringGeneratorUtil.GetPackage(component));
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
            string __tmp4Line = "."; //21:52
            __out.Append(__tmp4Line);
            StringBuilder __tmp5 = new StringBuilder();
            __tmp5.Append(SpringGeneratorUtil.Properties.serviceFacadePackage);
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
                    __out.AppendLine(); //21:107
                }
            }
            __out.AppendLine(); //22:1
            string __tmp6Prefix = "import "; //23:1
            string __tmp7Suffix = ".*;"; //23:98
            StringBuilder __tmp8 = new StringBuilder();
            __tmp8.Append(SpringGeneratorUtil.GetPackage(component));
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
                }
            }
            string __tmp9Line = "."; //23:51
            __out.Append(__tmp9Line);
            StringBuilder __tmp10 = new StringBuilder();
            __tmp10.Append(SpringGeneratorUtil.Properties.entityPackage);
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
                    __out.Append(__tmp10Line);
                    __out.Append(__tmp7Suffix);
                    __out.AppendLine(); //23:101
                }
            }
            string __tmp11Prefix = "import "; //24:1
            string __tmp12Suffix = ".*;"; //24:102
            StringBuilder __tmp13 = new StringBuilder();
            __tmp13.Append(SpringGeneratorUtil.GetPackage(component));
            using(StreamReader __tmp13Reader = new StreamReader(this.__ToStream(__tmp13.ToString())))
            {
                bool __tmp13_first = true;
                while(__tmp13_first || !__tmp13Reader.EndOfStream)
                {
                    __tmp13_first = false;
                    string __tmp13Line = __tmp13Reader.ReadLine();
                    if (__tmp13Line == null)
                    {
                        __tmp13Line = "";
                    }
                    __out.Append(__tmp11Prefix);
                    __out.Append(__tmp13Line);
                }
            }
            string __tmp14Line = "."; //24:51
            __out.Append(__tmp14Line);
            StringBuilder __tmp15 = new StringBuilder();
            __tmp15.Append(SpringGeneratorUtil.Properties.repositoryPackage);
            using(StreamReader __tmp15Reader = new StreamReader(this.__ToStream(__tmp15.ToString())))
            {
                bool __tmp15_first = true;
                while(__tmp15_first || !__tmp15Reader.EndOfStream)
                {
                    __tmp15_first = false;
                    string __tmp15Line = __tmp15Reader.ReadLine();
                    if (__tmp15Line == null)
                    {
                        __tmp15Line = "";
                    }
                    __out.Append(__tmp15Line);
                    __out.Append(__tmp12Suffix);
                    __out.AppendLine(); //24:105
                }
            }
            var __loop2_results = 
                (from __loop2_var1 in __Enumerate((component).GetEnumerator()) //25:8
                from s in __Enumerate((__loop2_var1.Services).GetEnumerator()) //25:19
                select new { __loop2_var1 = __loop2_var1, s = s}
                ).ToList(); //25:3
            int __loop2_iteration = 0;
            foreach (var __tmp16 in __loop2_results)
            {
                ++__loop2_iteration;
                var __loop2_var1 = __tmp16.__loop2_var1;
                var s = __tmp16.s;
                string __tmp17Prefix = "import "; //26:1
                string __tmp18Suffix = ";"; //26:120
                StringBuilder __tmp19 = new StringBuilder();
                __tmp19.Append(SpringGeneratorUtil.GetPackage(component));
                using(StreamReader __tmp19Reader = new StreamReader(this.__ToStream(__tmp19.ToString())))
                {
                    bool __tmp19_first = true;
                    while(__tmp19_first || !__tmp19Reader.EndOfStream)
                    {
                        __tmp19_first = false;
                        string __tmp19Line = __tmp19Reader.ReadLine();
                        if (__tmp19Line == null)
                        {
                            __tmp19Line = "";
                        }
                        __out.Append(__tmp17Prefix);
                        __out.Append(__tmp19Line);
                    }
                }
                string __tmp20Line = "."; //26:51
                __out.Append(__tmp20Line);
                StringBuilder __tmp21 = new StringBuilder();
                __tmp21.Append(SpringGeneratorUtil.Properties.interfacePackage);
                using(StreamReader __tmp21Reader = new StreamReader(this.__ToStream(__tmp21.ToString())))
                {
                    bool __tmp21_first = true;
                    while(__tmp21_first || !__tmp21Reader.EndOfStream)
                    {
                        __tmp21_first = false;
                        string __tmp21Line = __tmp21Reader.ReadLine();
                        if (__tmp21Line == null)
                        {
                            __tmp21Line = "";
                        }
                        __out.Append(__tmp21Line);
                    }
                }
                string __tmp22Line = "."; //26:101
                __out.Append(__tmp22Line);
                StringBuilder __tmp23 = new StringBuilder();
                __tmp23.Append(s.Interface.Name);
                using(StreamReader __tmp23Reader = new StreamReader(this.__ToStream(__tmp23.ToString())))
                {
                    bool __tmp23_first = true;
                    while(__tmp23_first || !__tmp23Reader.EndOfStream)
                    {
                        __tmp23_first = false;
                        string __tmp23Line = __tmp23Reader.ReadLine();
                        if (__tmp23Line == null)
                        {
                            __tmp23Line = "";
                        }
                        __out.Append(__tmp23Line);
                        __out.Append(__tmp18Suffix);
                        __out.AppendLine(); //26:121
                    }
                }
            }
            string __tmp24Prefix = "//import "; //28:1
            string __tmp25Suffix = ".util.ListUtil; TODO"; //28:53
            StringBuilder __tmp26 = new StringBuilder();
            __tmp26.Append(SpringGeneratorUtil.GetPackage(component));
            using(StreamReader __tmp26Reader = new StreamReader(this.__ToStream(__tmp26.ToString())))
            {
                bool __tmp26_first = true;
                while(__tmp26_first || !__tmp26Reader.EndOfStream)
                {
                    __tmp26_first = false;
                    string __tmp26Line = __tmp26Reader.ReadLine();
                    if (__tmp26Line == null)
                    {
                        __tmp26Line = "";
                    }
                    __out.Append(__tmp24Prefix);
                    __out.Append(__tmp26Line);
                    __out.Append(__tmp25Suffix);
                    __out.AppendLine(); //28:73
                }
            }
            __out.Append("import org.springframework.beans.factory.annotation.Autowired;"); //29:1
            __out.AppendLine(); //29:63
            __out.Append("import org.springframework.stereotype.Service;"); //30:1
            __out.AppendLine(); //30:47
            __out.AppendLine(); //31:1
            __out.Append("import java.util.List;"); //32:1
            __out.AppendLine(); //32:23
            __out.AppendLine(); //33:1
            __out.Append("@Service"); //34:1
            __out.AppendLine(); //34:9
            string __tmp27Prefix = "public class "; //35:1
            string __tmp28Suffix = " {"; //35:91
            StringBuilder __tmp29 = new StringBuilder();
            __tmp29.Append(component.Name);
            using(StreamReader __tmp29Reader = new StreamReader(this.__ToStream(__tmp29.ToString())))
            {
                bool __tmp29_first = true;
                while(__tmp29_first || !__tmp29Reader.EndOfStream)
                {
                    __tmp29_first = false;
                    string __tmp29Line = __tmp29Reader.ReadLine();
                    if (__tmp29Line == null)
                    {
                        __tmp29Line = "";
                    }
                    __out.Append(__tmp27Prefix);
                    __out.Append(__tmp29Line);
                }
            }
            string __tmp30Line = " implements "; //35:30
            __out.Append(__tmp30Line);
            StringBuilder __tmp31 = new StringBuilder();
            __tmp31.Append(SpringGeneratorUtil.GetInterfaceList(component));
            using(StreamReader __tmp31Reader = new StreamReader(this.__ToStream(__tmp31.ToString())))
            {
                bool __tmp31_first = true;
                while(__tmp31_first || !__tmp31Reader.EndOfStream)
                {
                    __tmp31_first = false;
                    string __tmp31Line = __tmp31Reader.ReadLine();
                    if (__tmp31Line == null)
                    {
                        __tmp31Line = "";
                    }
                    __out.Append(__tmp31Line);
                    __out.Append(__tmp28Suffix);
                    __out.AppendLine(); //35:93
                }
            }
            __out.Append("//TODO autowire by type :)"); //37:1
            __out.AppendLine(); //37:27
            __out.AppendLine(); //39:1
            var __loop3_results = 
                (from __loop3_var1 in __Enumerate((component).GetEnumerator()) //40:7
                from s in __Enumerate((__loop3_var1.Services).GetEnumerator()) //40:18
                select new { __loop3_var1 = __loop3_var1, s = s}
                ).ToList(); //40:2
            int __loop3_iteration = 0;
            foreach (var __tmp32 in __loop3_results)
            {
                ++__loop3_iteration;
                var __loop3_var1 = __tmp32.__loop3_var1;
                var s = __tmp32.s;
                Interface i = s.Interface; //41:2
                string __tmp33Prefix = "	//operations of "; //42:1
                string __tmp34Suffix = string.Empty; 
                StringBuilder __tmp35 = new StringBuilder();
                __tmp35.Append(i.Name);
                using(StreamReader __tmp35Reader = new StreamReader(this.__ToStream(__tmp35.ToString())))
                {
                    bool __tmp35_first = true;
                    while(__tmp35_first || !__tmp35Reader.EndOfStream)
                    {
                        __tmp35_first = false;
                        string __tmp35Line = __tmp35Reader.ReadLine();
                        if (__tmp35Line == null)
                        {
                            __tmp35Line = "";
                        }
                        __out.Append(__tmp33Prefix);
                        __out.Append(__tmp35Line);
                        __out.Append(__tmp34Suffix);
                        __out.AppendLine(); //42:26
                    }
                }
                var __loop4_results = 
                    (from __loop4_var1 in __Enumerate((i).GetEnumerator()) //43:9
                    from op in __Enumerate((__loop4_var1.Operations).GetEnumerator()) //43:12
                    select new { __loop4_var1 = __loop4_var1, op = op}
                    ).ToList(); //43:4
                int __loop4_iteration = 0;
                foreach (var __tmp36 in __loop4_results)
                {
                    ++__loop4_iteration;
                    var __loop4_var1 = __tmp36.__loop4_var1;
                    var op = __tmp36.op;
                    string __tmp37Prefix = "	public "; //44:1
                    string __tmp38Suffix = ") {"; //44:91
                    StringBuilder __tmp39 = new StringBuilder();
                    __tmp39.Append(op.ReturnType.GetJavaName());
                    using(StreamReader __tmp39Reader = new StreamReader(this.__ToStream(__tmp39.ToString())))
                    {
                        bool __tmp39_first = true;
                        while(__tmp39_first || !__tmp39Reader.EndOfStream)
                        {
                            __tmp39_first = false;
                            string __tmp39Line = __tmp39Reader.ReadLine();
                            if (__tmp39Line == null)
                            {
                                __tmp39Line = "";
                            }
                            __out.Append(__tmp37Prefix);
                            __out.Append(__tmp39Line);
                        }
                    }
                    string __tmp40Line = " "; //44:38
                    __out.Append(__tmp40Line);
                    StringBuilder __tmp41 = new StringBuilder();
                    __tmp41.Append(op.Name);
                    using(StreamReader __tmp41Reader = new StreamReader(this.__ToStream(__tmp41.ToString())))
                    {
                        bool __tmp41_first = true;
                        while(__tmp41_first || !__tmp41Reader.EndOfStream)
                        {
                            __tmp41_first = false;
                            string __tmp41Line = __tmp41Reader.ReadLine();
                            if (__tmp41Line == null)
                            {
                                __tmp41Line = "";
                            }
                            __out.Append(__tmp41Line);
                        }
                    }
                    string __tmp42Line = "("; //44:48
                    __out.Append(__tmp42Line);
                    StringBuilder __tmp43 = new StringBuilder();
                    __tmp43.Append(SpringGeneratorUtil.GetParameterList(op));
                    using(StreamReader __tmp43Reader = new StreamReader(this.__ToStream(__tmp43.ToString())))
                    {
                        bool __tmp43_first = true;
                        while(__tmp43_first || !__tmp43Reader.EndOfStream)
                        {
                            __tmp43_first = false;
                            string __tmp43Line = __tmp43Reader.ReadLine();
                            if (__tmp43Line == null)
                            {
                                __tmp43Line = "";
                            }
                            __out.Append(__tmp43Line);
                            __out.Append(__tmp38Suffix);
                            __out.AppendLine(); //44:94
                        }
                    }
                    __out.AppendLine(); //45:2
                    __out.Append("	}"); //46:1
                    __out.AppendLine(); //46:3
                    __out.AppendLine(); //47:2
                }
                __out.AppendLine(); //49:3
            }
            __out.Append("}"); //51:1
            __out.AppendLine(); //51:2
            return __out.ToString();
        }

        public string GenerateEnum(Enum myEnum) //54:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp1Prefix = "package "; //55:1
            string __tmp2Suffix = ";"; //55:94
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(SpringGeneratorUtil.GetPackage(myEnum));
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
            string __tmp4Line = "."; //55:49
            __out.Append(__tmp4Line);
            StringBuilder __tmp5 = new StringBuilder();
            __tmp5.Append(SpringGeneratorUtil.Properties.enumPackage);
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
                    __out.AppendLine(); //55:95
                }
            }
            __out.AppendLine(); //56:1
            string __tmp6Prefix = "public enum "; //57:1
            string __tmp7Suffix = " {"; //57:26
            StringBuilder __tmp8 = new StringBuilder();
            __tmp8.Append(myEnum.Name);
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
                    __out.AppendLine(); //57:28
                }
            }
            var __loop5_results = 
                (from __loop5_var1 in __Enumerate((myEnum).GetEnumerator()) //58:8
                from literal in __Enumerate((__loop5_var1.EnumLiterals).GetEnumerator()) //58:16
                select new { __loop5_var1 = __loop5_var1, literal = literal}
                ).ToList(); //58:2
            int __loop5_iteration = 0;
            string delimiter = ""; //58:38
            foreach (var __tmp9 in __loop5_results)
            {
                ++__loop5_iteration;
                if (__loop5_iteration >= 2) //58:59
                {
                    delimiter = ","; //58:59
                }
                var __loop5_var1 = __tmp9.__loop5_var1;
                var literal = __tmp9.literal;
                string __tmp10Prefix = string.Empty;
                string __tmp11Suffix = string.Empty;
                StringBuilder __tmp12 = new StringBuilder();
                __tmp12.Append(delimiter);
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
                        __out.Append(__tmp10Prefix);
                        __out.Append(__tmp12Line);
                        __out.Append(__tmp11Suffix);
                        __out.AppendLine(); //59:12
                    }
                }
                string __tmp13Prefix = "	"; //60:1
                string __tmp14Suffix = string.Empty; 
                StringBuilder __tmp15 = new StringBuilder();
                __tmp15.Append(literal.Name.ToUpper());
                using(StreamReader __tmp15Reader = new StreamReader(this.__ToStream(__tmp15.ToString())))
                {
                    bool __tmp15_first = true;
                    while(__tmp15_first || !__tmp15Reader.EndOfStream)
                    {
                        __tmp15_first = false;
                        string __tmp15Line = __tmp15Reader.ReadLine();
                        if (__tmp15Line == null)
                        {
                            __tmp15Line = "";
                        }
                        __out.Append(__tmp13Prefix);
                        __out.Append(__tmp15Line);
                        __out.Append(__tmp14Suffix);
                    }
                }
            }
            __out.AppendLine(); //62:1
            __out.AppendLine(); //63:1
            __out.Append("}"); //64:1
            __out.AppendLine(); //64:2
            return __out.ToString();
        }

        public string GenerateException(Exception ex) //67:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp1Prefix = "package "; //68:1
            string __tmp2Suffix = ";"; //68:95
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(SpringGeneratorUtil.GetPackage(ex));
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
            string __tmp4Line = "."; //68:45
            __out.Append(__tmp4Line);
            StringBuilder __tmp5 = new StringBuilder();
            __tmp5.Append(SpringGeneratorUtil.Properties.exceptionPackage);
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
                    __out.AppendLine(); //68:96
                }
            }
            __out.AppendLine(); //69:1
            string __tmp6Prefix = "public class "; //70:1
            string __tmp7Suffix = " extends Exception {"; //70:23
            StringBuilder __tmp8 = new StringBuilder();
            __tmp8.Append(ex.Name);
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
                    __out.AppendLine(); //70:43
                }
            }
            var __loop6_results = 
                (from __loop6_var1 in __Enumerate((ex).GetEnumerator()) //72:8
                from prop in __Enumerate((__loop6_var1.Properties).GetEnumerator()) //72:12
                select new { __loop6_var1 = __loop6_var1, prop = prop}
                ).ToList(); //72:2
            int __loop6_iteration = 0;
            foreach (var __tmp9 in __loop6_results)
            {
                ++__loop6_iteration;
                var __loop6_var1 = __tmp9.__loop6_var1;
                var prop = __tmp9.prop;
                __out.AppendLine(); //73:2
                string __tmp10Prefix = "	private "; //74:1
                string __tmp11Suffix = ";"; //74:72
                StringBuilder __tmp12 = new StringBuilder();
                __tmp12.Append(prop.Type.GetJavaName());
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
                        __out.Append(__tmp10Prefix);
                        __out.Append(__tmp12Line);
                    }
                }
                string __tmp13Line = " "; //74:35
                __out.Append(__tmp13Line);
                StringBuilder __tmp14 = new StringBuilder();
                __tmp14.Append(prop.Name.ToString().ToCamelCase());
                using(StreamReader __tmp14Reader = new StreamReader(this.__ToStream(__tmp14.ToString())))
                {
                    bool __tmp14_first = true;
                    while(__tmp14_first || !__tmp14Reader.EndOfStream)
                    {
                        __tmp14_first = false;
                        string __tmp14Line = __tmp14Reader.ReadLine();
                        if (__tmp14Line == null)
                        {
                            __tmp14Line = "";
                        }
                        __out.Append(__tmp14Line);
                        __out.Append(__tmp11Suffix);
                        __out.AppendLine(); //74:73
                    }
                }
            }
            __out.AppendLine(); //77:2
            string __tmp15Prefix = "	public "; //78:1
            string __tmp16Suffix = ") {"; //78:60
            StringBuilder __tmp17 = new StringBuilder();
            __tmp17.Append(ex.Name);
            using(StreamReader __tmp17Reader = new StreamReader(this.__ToStream(__tmp17.ToString())))
            {
                bool __tmp17_first = true;
                while(__tmp17_first || !__tmp17Reader.EndOfStream)
                {
                    __tmp17_first = false;
                    string __tmp17Line = __tmp17Reader.ReadLine();
                    if (__tmp17Line == null)
                    {
                        __tmp17Line = "";
                    }
                    __out.Append(__tmp15Prefix);
                    __out.Append(__tmp17Line);
                }
            }
            string __tmp18Line = "("; //78:18
            __out.Append(__tmp18Line);
            StringBuilder __tmp19 = new StringBuilder();
            __tmp19.Append(SpringGeneratorUtil.GetPropertyList(ex));
            using(StreamReader __tmp19Reader = new StreamReader(this.__ToStream(__tmp19.ToString())))
            {
                bool __tmp19_first = true;
                while(__tmp19_first || !__tmp19Reader.EndOfStream)
                {
                    __tmp19_first = false;
                    string __tmp19Line = __tmp19Reader.ReadLine();
                    if (__tmp19Line == null)
                    {
                        __tmp19Line = "";
                    }
                    __out.Append(__tmp19Line);
                    __out.Append(__tmp16Suffix);
                    __out.AppendLine(); //78:63
                }
            }
            var __loop7_results = 
                (from __loop7_var1 in __Enumerate((ex).GetEnumerator()) //79:8
                from prop in __Enumerate((__loop7_var1.Properties).GetEnumerator()) //79:12
                select new { __loop7_var1 = __loop7_var1, prop = prop}
                ).ToList(); //79:2
            int __loop7_iteration = 0;
            foreach (var __tmp20 in __loop7_results)
            {
                ++__loop7_iteration;
                var __loop7_var1 = __tmp20.__loop7_var1;
                var prop = __tmp20.prop;
                string __tmp21Prefix = "		this."; //80:1
                string __tmp22Suffix = ";"; //80:83
                StringBuilder __tmp23 = new StringBuilder();
                __tmp23.Append(prop.Name.ToString().ToCamelCase());
                using(StreamReader __tmp23Reader = new StreamReader(this.__ToStream(__tmp23.ToString())))
                {
                    bool __tmp23_first = true;
                    while(__tmp23_first || !__tmp23Reader.EndOfStream)
                    {
                        __tmp23_first = false;
                        string __tmp23Line = __tmp23Reader.ReadLine();
                        if (__tmp23Line == null)
                        {
                            __tmp23Line = "";
                        }
                        __out.Append(__tmp21Prefix);
                        __out.Append(__tmp23Line);
                    }
                }
                string __tmp24Line = " = "; //80:44
                __out.Append(__tmp24Line);
                StringBuilder __tmp25 = new StringBuilder();
                __tmp25.Append(prop.Name.ToString().ToCamelCase());
                using(StreamReader __tmp25Reader = new StreamReader(this.__ToStream(__tmp25.ToString())))
                {
                    bool __tmp25_first = true;
                    while(__tmp25_first || !__tmp25Reader.EndOfStream)
                    {
                        __tmp25_first = false;
                        string __tmp25Line = __tmp25Reader.ReadLine();
                        if (__tmp25Line == null)
                        {
                            __tmp25Line = "";
                        }
                        __out.Append(__tmp25Line);
                        __out.Append(__tmp22Suffix);
                        __out.AppendLine(); //80:84
                    }
                }
            }
            __out.Append("	}"); //82:1
            __out.AppendLine(); //82:3
            var __loop8_results = 
                (from __loop8_var1 in __Enumerate((ex).GetEnumerator()) //84:8
                from prop in __Enumerate((__loop8_var1.Properties).GetEnumerator()) //84:12
                select new { __loop8_var1 = __loop8_var1, prop = prop}
                ).ToList(); //84:2
            int __loop8_iteration = 0;
            foreach (var __tmp26 in __loop8_results)
            {
                ++__loop8_iteration;
                var __loop8_var1 = __tmp26.__loop8_var1;
                var prop = __tmp26.prop;
                string __tmp27Prefix = "	"; //85:1
                string __tmp28Suffix = string.Empty; 
                StringBuilder __tmp29 = new StringBuilder();
                __tmp29.Append(SpringGeneratorUtil.GenerateGetter(prop));
                using(StreamReader __tmp29Reader = new StreamReader(this.__ToStream(__tmp29.ToString())))
                {
                    bool __tmp29_first = true;
                    while(__tmp29_first || !__tmp29Reader.EndOfStream)
                    {
                        __tmp29_first = false;
                        string __tmp29Line = __tmp29Reader.ReadLine();
                        if (__tmp29Line == null)
                        {
                            __tmp29Line = "";
                        }
                        __out.Append(__tmp27Prefix);
                        __out.Append(__tmp29Line);
                        __out.Append(__tmp28Suffix);
                        __out.AppendLine(); //85:44
                    }
                }
            }
            __out.Append("}"); //88:1
            __out.AppendLine(); //88:2
            return __out.ToString();
        }

        public string GenerateEntity(StructuredType sType) //92:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp1Prefix = "package "; //93:1
            string __tmp2Suffix = ";"; //93:95
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(SpringGeneratorUtil.GetPackage(sType));
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
            string __tmp4Line = "."; //93:48
            __out.Append(__tmp4Line);
            StringBuilder __tmp5 = new StringBuilder();
            __tmp5.Append(SpringGeneratorUtil.Properties.entityPackage);
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
                    __out.AppendLine(); //93:96
                }
            }
            __out.AppendLine(); //94:1
            if (sType is Entity) //95:3
            {
                __out.Append("import javax.persistence.*;"); //96:1
                __out.AppendLine(); //96:28
                __out.AppendLine(); //97:1
                __out.Append("@Entity"); //98:1
                __out.AppendLine(); //98:8
            }
            string __tmp6Prefix = "public class "; //100:1
            string __tmp7Suffix = " {"; //100:26
            StringBuilder __tmp8 = new StringBuilder();
            __tmp8.Append(sType.Name);
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
                    __out.AppendLine(); //100:28
                }
            }
            int ids = SpringGeneratorUtil.GetNumberOfFieldWithIdSuffix(sType); //102:2
            if (ids != 1) //103:2
            {
                __out.AppendLine(); //104:2
                if (sType is Entity) //105:4
                {
                    __out.Append("	@Id"); //106:1
                    __out.AppendLine(); //106:5
                    __out.Append("	@GeneratedValue"); //107:1
                    __out.AppendLine(); //107:17
                }
                string __tmp9Prefix = "	private Long "; //109:1
                string __tmp10Suffix = "Id;"; //109:52
                StringBuilder __tmp11 = new StringBuilder();
                __tmp11.Append(sType.Name.ToString().ToCamelCase());
                using(StreamReader __tmp11Reader = new StreamReader(this.__ToStream(__tmp11.ToString())))
                {
                    bool __tmp11_first = true;
                    while(__tmp11_first || !__tmp11Reader.EndOfStream)
                    {
                        __tmp11_first = false;
                        string __tmp11Line = __tmp11Reader.ReadLine();
                        if (__tmp11Line == null)
                        {
                            __tmp11Line = "";
                        }
                        __out.Append(__tmp9Prefix);
                        __out.Append(__tmp11Line);
                        __out.Append(__tmp10Suffix);
                        __out.AppendLine(); //109:55
                    }
                }
            }
            var __loop9_results = 
                (from __loop9_var1 in __Enumerate((sType).GetEnumerator()) //112:8
                from prop in __Enumerate((__loop9_var1.Properties).GetEnumerator()) //112:15
                select new { __loop9_var1 = __loop9_var1, prop = prop}
                ).ToList(); //112:2
            int __loop9_iteration = 0;
            foreach (var __tmp12 in __loop9_results)
            {
                ++__loop9_iteration;
                var __loop9_var1 = __tmp12.__loop9_var1;
                var prop = __tmp12.prop;
                __out.AppendLine(); //113:2
                if (sType is Entity && ids == 1 && prop.Name.ToString().EndsWith("Id")) //114:4
                {
                    __out.Append("	@Id"); //115:1
                    __out.AppendLine(); //115:5
                    __out.Append("	@GeneratedValue"); //116:1
                    __out.AppendLine(); //116:17
                }
                string __tmp13Prefix = "	private "; //118:1
                string __tmp14Suffix = ";"; //118:72
                StringBuilder __tmp15 = new StringBuilder();
                __tmp15.Append(prop.Type.GetJavaName());
                using(StreamReader __tmp15Reader = new StreamReader(this.__ToStream(__tmp15.ToString())))
                {
                    bool __tmp15_first = true;
                    while(__tmp15_first || !__tmp15Reader.EndOfStream)
                    {
                        __tmp15_first = false;
                        string __tmp15Line = __tmp15Reader.ReadLine();
                        if (__tmp15Line == null)
                        {
                            __tmp15Line = "";
                        }
                        __out.Append(__tmp13Prefix);
                        __out.Append(__tmp15Line);
                    }
                }
                string __tmp16Line = " "; //118:35
                __out.Append(__tmp16Line);
                StringBuilder __tmp17 = new StringBuilder();
                __tmp17.Append(prop.Name.ToString().ToCamelCase());
                using(StreamReader __tmp17Reader = new StreamReader(this.__ToStream(__tmp17.ToString())))
                {
                    bool __tmp17_first = true;
                    while(__tmp17_first || !__tmp17Reader.EndOfStream)
                    {
                        __tmp17_first = false;
                        string __tmp17Line = __tmp17Reader.ReadLine();
                        if (__tmp17Line == null)
                        {
                            __tmp17Line = "";
                        }
                        __out.Append(__tmp17Line);
                        __out.Append(__tmp14Suffix);
                        __out.AppendLine(); //118:73
                    }
                }
            }
            __out.AppendLine(); //122:2
            if (ids == 1) //123:2
            {
                var __loop10_results = 
                    (from __loop10_var1 in __Enumerate((sType).GetEnumerator()) //124:10
                    from id in __Enumerate((__loop10_var1.Properties).GetEnumerator()) //124:17
                    where id.Name.EndsWith("Id") //124:31
                    select new { __loop10_var1 = __loop10_var1, id = id}
                    ).ToList(); //124:4
                int __loop10_iteration = 0;
                foreach (var __tmp18 in __loop10_results)
                {
                    ++__loop10_iteration;
                    var __loop10_var1 = __tmp18.__loop10_var1;
                    var id = __tmp18.id;
                    string __tmp19Prefix = "	public "; //125:1
                    string __tmp20Suffix = "() {"; //125:71
                    StringBuilder __tmp21 = new StringBuilder();
                    __tmp21.Append(id.Type.GetJavaName());
                    using(StreamReader __tmp21Reader = new StreamReader(this.__ToStream(__tmp21.ToString())))
                    {
                        bool __tmp21_first = true;
                        while(__tmp21_first || !__tmp21Reader.EndOfStream)
                        {
                            __tmp21_first = false;
                            string __tmp21Line = __tmp21Reader.ReadLine();
                            if (__tmp21Line == null)
                            {
                                __tmp21Line = "";
                            }
                            __out.Append(__tmp19Prefix);
                            __out.Append(__tmp21Line);
                        }
                    }
                    string __tmp22Line = " get"; //125:32
                    __out.Append(__tmp22Line);
                    StringBuilder __tmp23 = new StringBuilder();
                    __tmp23.Append(id.Name.ToString().ToPascalCase());
                    using(StreamReader __tmp23Reader = new StreamReader(this.__ToStream(__tmp23.ToString())))
                    {
                        bool __tmp23_first = true;
                        while(__tmp23_first || !__tmp23Reader.EndOfStream)
                        {
                            __tmp23_first = false;
                            string __tmp23Line = __tmp23Reader.ReadLine();
                            if (__tmp23Line == null)
                            {
                                __tmp23Line = "";
                            }
                            __out.Append(__tmp23Line);
                            __out.Append(__tmp20Suffix);
                            __out.AppendLine(); //125:75
                        }
                    }
                    string __tmp24Prefix = "		return this."; //126:1
                    string __tmp25Suffix = ";"; //126:49
                    StringBuilder __tmp26 = new StringBuilder();
                    __tmp26.Append(id.Name.ToString().ToCamelCase());
                    using(StreamReader __tmp26Reader = new StreamReader(this.__ToStream(__tmp26.ToString())))
                    {
                        bool __tmp26_first = true;
                        while(__tmp26_first || !__tmp26Reader.EndOfStream)
                        {
                            __tmp26_first = false;
                            string __tmp26Line = __tmp26Reader.ReadLine();
                            if (__tmp26Line == null)
                            {
                                __tmp26Line = "";
                            }
                            __out.Append(__tmp24Prefix);
                            __out.Append(__tmp26Line);
                            __out.Append(__tmp25Suffix);
                            __out.AppendLine(); //126:50
                        }
                    }
                    __out.Append("	}"); //127:1
                    __out.AppendLine(); //127:3
                    __out.AppendLine(); //128:2
                    string __tmp27Prefix = "	public void set"; //129:1
                    string __tmp28Suffix = ") {"; //129:111
                    StringBuilder __tmp29 = new StringBuilder();
                    __tmp29.Append(id.Name.ToString().ToPascalCase());
                    using(StreamReader __tmp29Reader = new StreamReader(this.__ToStream(__tmp29.ToString())))
                    {
                        bool __tmp29_first = true;
                        while(__tmp29_first || !__tmp29Reader.EndOfStream)
                        {
                            __tmp29_first = false;
                            string __tmp29Line = __tmp29Reader.ReadLine();
                            if (__tmp29Line == null)
                            {
                                __tmp29Line = "";
                            }
                            __out.Append(__tmp27Prefix);
                            __out.Append(__tmp29Line);
                        }
                    }
                    string __tmp30Line = "("; //129:52
                    __out.Append(__tmp30Line);
                    StringBuilder __tmp31 = new StringBuilder();
                    __tmp31.Append(id.Type.GetJavaName());
                    using(StreamReader __tmp31Reader = new StreamReader(this.__ToStream(__tmp31.ToString())))
                    {
                        bool __tmp31_first = true;
                        while(__tmp31_first || !__tmp31Reader.EndOfStream)
                        {
                            __tmp31_first = false;
                            string __tmp31Line = __tmp31Reader.ReadLine();
                            if (__tmp31Line == null)
                            {
                                __tmp31Line = "";
                            }
                            __out.Append(__tmp31Line);
                        }
                    }
                    string __tmp32Line = " "; //129:76
                    __out.Append(__tmp32Line);
                    StringBuilder __tmp33 = new StringBuilder();
                    __tmp33.Append(id.Name.ToString().ToCamelCase());
                    using(StreamReader __tmp33Reader = new StreamReader(this.__ToStream(__tmp33.ToString())))
                    {
                        bool __tmp33_first = true;
                        while(__tmp33_first || !__tmp33Reader.EndOfStream)
                        {
                            __tmp33_first = false;
                            string __tmp33Line = __tmp33Reader.ReadLine();
                            if (__tmp33Line == null)
                            {
                                __tmp33Line = "";
                            }
                            __out.Append(__tmp33Line);
                            __out.Append(__tmp28Suffix);
                            __out.AppendLine(); //129:114
                        }
                    }
                    string __tmp34Prefix = "		this."; //130:1
                    string __tmp35Suffix = ";"; //130:79
                    StringBuilder __tmp36 = new StringBuilder();
                    __tmp36.Append(id.Name.ToString().ToCamelCase());
                    using(StreamReader __tmp36Reader = new StreamReader(this.__ToStream(__tmp36.ToString())))
                    {
                        bool __tmp36_first = true;
                        while(__tmp36_first || !__tmp36Reader.EndOfStream)
                        {
                            __tmp36_first = false;
                            string __tmp36Line = __tmp36Reader.ReadLine();
                            if (__tmp36Line == null)
                            {
                                __tmp36Line = "";
                            }
                            __out.Append(__tmp34Prefix);
                            __out.Append(__tmp36Line);
                        }
                    }
                    string __tmp37Line = " = "; //130:42
                    __out.Append(__tmp37Line);
                    StringBuilder __tmp38 = new StringBuilder();
                    __tmp38.Append(id.Name.ToString().ToCamelCase());
                    using(StreamReader __tmp38Reader = new StreamReader(this.__ToStream(__tmp38.ToString())))
                    {
                        bool __tmp38_first = true;
                        while(__tmp38_first || !__tmp38Reader.EndOfStream)
                        {
                            __tmp38_first = false;
                            string __tmp38Line = __tmp38Reader.ReadLine();
                            if (__tmp38Line == null)
                            {
                                __tmp38Line = "";
                            }
                            __out.Append(__tmp38Line);
                            __out.Append(__tmp35Suffix);
                            __out.AppendLine(); //130:80
                        }
                    }
                    __out.Append("	}"); //131:1
                    __out.AppendLine(); //131:3
                }
            }
            else //133:2
            {
                string __tmp39Prefix = "	public Long get"; //134:1
                string __tmp40Suffix = "Id() {"; //134:55
                StringBuilder __tmp41 = new StringBuilder();
                __tmp41.Append(sType.Name.ToString().ToPascalCase());
                using(StreamReader __tmp41Reader = new StreamReader(this.__ToStream(__tmp41.ToString())))
                {
                    bool __tmp41_first = true;
                    while(__tmp41_first || !__tmp41Reader.EndOfStream)
                    {
                        __tmp41_first = false;
                        string __tmp41Line = __tmp41Reader.ReadLine();
                        if (__tmp41Line == null)
                        {
                            __tmp41Line = "";
                        }
                        __out.Append(__tmp39Prefix);
                        __out.Append(__tmp41Line);
                        __out.Append(__tmp40Suffix);
                        __out.AppendLine(); //134:61
                    }
                }
                string __tmp42Prefix = "		return this."; //135:1
                string __tmp43Suffix = "Id;"; //135:52
                StringBuilder __tmp44 = new StringBuilder();
                __tmp44.Append(sType.Name.ToString().ToCamelCase());
                using(StreamReader __tmp44Reader = new StreamReader(this.__ToStream(__tmp44.ToString())))
                {
                    bool __tmp44_first = true;
                    while(__tmp44_first || !__tmp44Reader.EndOfStream)
                    {
                        __tmp44_first = false;
                        string __tmp44Line = __tmp44Reader.ReadLine();
                        if (__tmp44Line == null)
                        {
                            __tmp44Line = "";
                        }
                        __out.Append(__tmp42Prefix);
                        __out.Append(__tmp44Line);
                        __out.Append(__tmp43Suffix);
                        __out.AppendLine(); //135:55
                    }
                }
                __out.Append("	}"); //136:1
                __out.AppendLine(); //136:3
                __out.AppendLine(); //138:2
                string __tmp45Prefix = "	public void set"; //139:1
                string __tmp46Suffix = "Id) {"; //139:100
                StringBuilder __tmp47 = new StringBuilder();
                __tmp47.Append(sType.Name.ToString().ToPascalCase());
                using(StreamReader __tmp47Reader = new StreamReader(this.__ToStream(__tmp47.ToString())))
                {
                    bool __tmp47_first = true;
                    while(__tmp47_first || !__tmp47Reader.EndOfStream)
                    {
                        __tmp47_first = false;
                        string __tmp47Line = __tmp47Reader.ReadLine();
                        if (__tmp47Line == null)
                        {
                            __tmp47Line = "";
                        }
                        __out.Append(__tmp45Prefix);
                        __out.Append(__tmp47Line);
                    }
                }
                string __tmp48Line = "Id(Long "; //139:55
                __out.Append(__tmp48Line);
                StringBuilder __tmp49 = new StringBuilder();
                __tmp49.Append(sType.Name.ToString().ToCamelCase());
                using(StreamReader __tmp49Reader = new StreamReader(this.__ToStream(__tmp49.ToString())))
                {
                    bool __tmp49_first = true;
                    while(__tmp49_first || !__tmp49Reader.EndOfStream)
                    {
                        __tmp49_first = false;
                        string __tmp49Line = __tmp49Reader.ReadLine();
                        if (__tmp49Line == null)
                        {
                            __tmp49Line = "";
                        }
                        __out.Append(__tmp49Line);
                        __out.Append(__tmp46Suffix);
                        __out.AppendLine(); //139:105
                    }
                }
                string __tmp50Prefix = "		this."; //140:1
                string __tmp51Suffix = "Id;"; //140:87
                StringBuilder __tmp52 = new StringBuilder();
                __tmp52.Append(sType.Name.ToString().ToCamelCase());
                using(StreamReader __tmp52Reader = new StreamReader(this.__ToStream(__tmp52.ToString())))
                {
                    bool __tmp52_first = true;
                    while(__tmp52_first || !__tmp52Reader.EndOfStream)
                    {
                        __tmp52_first = false;
                        string __tmp52Line = __tmp52Reader.ReadLine();
                        if (__tmp52Line == null)
                        {
                            __tmp52Line = "";
                        }
                        __out.Append(__tmp50Prefix);
                        __out.Append(__tmp52Line);
                    }
                }
                string __tmp53Line = "Id = "; //140:45
                __out.Append(__tmp53Line);
                StringBuilder __tmp54 = new StringBuilder();
                __tmp54.Append(sType.Name.ToString().ToCamelCase());
                using(StreamReader __tmp54Reader = new StreamReader(this.__ToStream(__tmp54.ToString())))
                {
                    bool __tmp54_first = true;
                    while(__tmp54_first || !__tmp54Reader.EndOfStream)
                    {
                        __tmp54_first = false;
                        string __tmp54Line = __tmp54Reader.ReadLine();
                        if (__tmp54Line == null)
                        {
                            __tmp54Line = "";
                        }
                        __out.Append(__tmp54Line);
                        __out.Append(__tmp51Suffix);
                        __out.AppendLine(); //140:90
                    }
                }
                __out.Append("	}"); //141:1
                __out.AppendLine(); //141:3
            }
            var __loop11_results = 
                (from __loop11_var1 in __Enumerate((sType).GetEnumerator()) //144:8
                from prop in __Enumerate((__loop11_var1.Properties).GetEnumerator()) //144:15
                where !prop.Name.EndsWith("Id") //144:31
                select new { __loop11_var1 = __loop11_var1, prop = prop}
                ).ToList(); //144:2
            int __loop11_iteration = 0;
            foreach (var __tmp55 in __loop11_results)
            {
                ++__loop11_iteration;
                var __loop11_var1 = __tmp55.__loop11_var1;
                var prop = __tmp55.prop;
                string __tmp56Prefix = "	"; //145:1
                string __tmp57Suffix = string.Empty; 
                StringBuilder __tmp58 = new StringBuilder();
                __tmp58.Append(SpringGeneratorUtil.GenerateGetter(prop));
                using(StreamReader __tmp58Reader = new StreamReader(this.__ToStream(__tmp58.ToString())))
                {
                    bool __tmp58_first = true;
                    while(__tmp58_first || !__tmp58Reader.EndOfStream)
                    {
                        __tmp58_first = false;
                        string __tmp58Line = __tmp58Reader.ReadLine();
                        if (__tmp58Line == null)
                        {
                            __tmp58Line = "";
                        }
                        __out.Append(__tmp56Prefix);
                        __out.Append(__tmp58Line);
                        __out.Append(__tmp57Suffix);
                        __out.AppendLine(); //145:44
                    }
                }
                string __tmp59Prefix = "	"; //146:1
                string __tmp60Suffix = string.Empty; 
                StringBuilder __tmp61 = new StringBuilder();
                __tmp61.Append(SpringGeneratorUtil.GenerateSetter(prop));
                using(StreamReader __tmp61Reader = new StreamReader(this.__ToStream(__tmp61.ToString())))
                {
                    bool __tmp61_first = true;
                    while(__tmp61_first || !__tmp61Reader.EndOfStream)
                    {
                        __tmp61_first = false;
                        string __tmp61Line = __tmp61Reader.ReadLine();
                        if (__tmp61Line == null)
                        {
                            __tmp61Line = "";
                        }
                        __out.Append(__tmp59Prefix);
                        __out.Append(__tmp61Line);
                        __out.Append(__tmp60Suffix);
                        __out.AppendLine(); //146:44
                    }
                }
            }
            __out.Append("}"); //149:1
            __out.AppendLine(); //149:2
            return __out.ToString();
        }

        public string GenerateRepository(Entity entity) //152:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp1Prefix = "package "; //153:1
            string __tmp2Suffix = ";"; //153:100
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(SpringGeneratorUtil.GetPackage(entity));
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
            string __tmp4Line = "."; //153:49
            __out.Append(__tmp4Line);
            StringBuilder __tmp5 = new StringBuilder();
            __tmp5.Append(SpringGeneratorUtil.Properties.repositoryPackage);
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
                    __out.AppendLine(); //153:101
                }
            }
            __out.AppendLine(); //154:1
            string __tmp6Prefix = "import "; //155:1
            string __tmp7Suffix = ";"; //155:109
            StringBuilder __tmp8 = new StringBuilder();
            __tmp8.Append(SpringGeneratorUtil.GetPackage(entity));
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
                }
            }
            string __tmp9Line = "."; //155:48
            __out.Append(__tmp9Line);
            StringBuilder __tmp10 = new StringBuilder();
            __tmp10.Append(SpringGeneratorUtil.Properties.entityPackage);
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
                    __out.Append(__tmp10Line);
                }
            }
            string __tmp11Line = "."; //155:95
            __out.Append(__tmp11Line);
            StringBuilder __tmp12 = new StringBuilder();
            __tmp12.Append(entity.Name);
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
                    __out.Append(__tmp7Suffix);
                    __out.AppendLine(); //155:110
                }
            }
            __out.Append("import org.springframework.data.repository.CrudRepository;"); //156:1
            __out.AppendLine(); //156:59
            __out.Append("import org.springframework.stereotype.Repository;"); //157:1
            __out.AppendLine(); //157:50
            __out.AppendLine(); //158:1
            __out.Append("@Repository"); //159:1
            __out.AppendLine(); //159:12
            string __tmp13Prefix = "public interface "; //160:1
            string __tmp14Suffix = ",Long> {"; //160:78
            StringBuilder __tmp15 = new StringBuilder();
            __tmp15.Append(entity.Name);
            using(StreamReader __tmp15Reader = new StreamReader(this.__ToStream(__tmp15.ToString())))
            {
                bool __tmp15_first = true;
                while(__tmp15_first || !__tmp15Reader.EndOfStream)
                {
                    __tmp15_first = false;
                    string __tmp15Line = __tmp15Reader.ReadLine();
                    if (__tmp15Line == null)
                    {
                        __tmp15Line = "";
                    }
                    __out.Append(__tmp13Prefix);
                    __out.Append(__tmp15Line);
                }
            }
            string __tmp16Line = "Repository extends CrudRepository<"; //160:31
            __out.Append(__tmp16Line);
            StringBuilder __tmp17 = new StringBuilder();
            __tmp17.Append(entity.Name);
            using(StreamReader __tmp17Reader = new StreamReader(this.__ToStream(__tmp17.ToString())))
            {
                bool __tmp17_first = true;
                while(__tmp17_first || !__tmp17Reader.EndOfStream)
                {
                    __tmp17_first = false;
                    string __tmp17Line = __tmp17Reader.ReadLine();
                    if (__tmp17Line == null)
                    {
                        __tmp17Line = "";
                    }
                    __out.Append(__tmp17Line);
                    __out.Append(__tmp14Suffix);
                    __out.AppendLine(); //160:86
                }
            }
            __out.AppendLine(); //161:1
            __out.Append("}"); //162:1
            __out.AppendLine(); //162:2
            return __out.ToString();
        }

        public string GeneratePersistence(Namespace ns) //165:1
        {
            StringBuilder __out = new StringBuilder();
            __out.Append("<?xml version=\"1.0\" encoding=\"UTF-8\"?>"); //166:1
            __out.AppendLine(); //166:39
            __out.Append("<persistence xmlns=\"http://java.sun.com/xml/ns/persistence\" version=\"2.0\">"); //167:1
            __out.AppendLine(); //167:75
            string __tmp1Prefix = "    <persistence-unit name=\""; //168:1
            string __tmp2Suffix = "PU\" transaction-type=\"RESOURCE_LOCAL\">"; //168:38
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(ns.Name);
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
                    __out.AppendLine(); //168:76
                }
            }
            __out.Append("        <provider>org.eclipse.persistence.jpa.PersistenceProvider</provider>"); //169:1
            __out.AppendLine(); //169:77
            __out.AppendLine(); //170:3
            var __loop12_results = 
                (from __loop12_var1 in __Enumerate((ns).GetEnumerator()) //171:9
                from entity in __Enumerate((__loop12_var1.Declarations).GetEnumerator()) //171:13
                where entity is Entity //171:33
                select new { __loop12_var1 = __loop12_var1, entity = entity}
                ).ToList(); //171:3
            int __loop12_iteration = 0;
            foreach (var __tmp4 in __loop12_results)
            {
                ++__loop12_iteration;
                var __loop12_var1 = __tmp4.__loop12_var1;
                var entity = __tmp4.entity;
                string __tmp5Prefix = "		<class>"; //172:1
                string __tmp6Suffix = "</class>"; //172:111
                StringBuilder __tmp7 = new StringBuilder();
                __tmp7.Append(SpringGeneratorUtil.GetPackage(entity));
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
                        __out.Append(__tmp5Prefix);
                        __out.Append(__tmp7Line);
                    }
                }
                string __tmp8Line = "."; //172:50
                __out.Append(__tmp8Line);
                StringBuilder __tmp9 = new StringBuilder();
                __tmp9.Append(SpringGeneratorUtil.Properties.entityPackage);
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
                        __out.Append(__tmp9Line);
                    }
                }
                string __tmp10Line = "."; //172:97
                __out.Append(__tmp10Line);
                StringBuilder __tmp11 = new StringBuilder();
                __tmp11.Append(entity.Name);
                using(StreamReader __tmp11Reader = new StreamReader(this.__ToStream(__tmp11.ToString())))
                {
                    bool __tmp11_first = true;
                    while(__tmp11_first || !__tmp11Reader.EndOfStream)
                    {
                        __tmp11_first = false;
                        string __tmp11Line = __tmp11Reader.ReadLine();
                        if (__tmp11Line == null)
                        {
                            __tmp11Line = "";
                        }
                        __out.Append(__tmp11Line);
                        __out.Append(__tmp6Suffix);
                        __out.AppendLine(); //172:119
                    }
                }
            }
            __out.AppendLine(); //174:2
            __out.Append("        <class>iit.cinema.status.ReservationStatus</class>"); //175:1
            __out.AppendLine(); //175:59
            __out.Append("        <class>iit.cinema.status.SeatStatus</class>"); //176:1
            __out.AppendLine(); //176:52
            __out.AppendLine(); //177:3
            __out.Append("        <shared-cache-mode>NONE</shared-cache-mode>"); //178:1
            __out.AppendLine(); //178:52
            __out.AppendLine(); //179:3
            __out.Append("        <properties>"); //180:1
            __out.AppendLine(); //180:21
            __out.Append("            <!--for debug-->"); //181:1
            __out.AppendLine(); //181:29
            __out.Append("            <property name=\"eclipselink.ddl-generation\" value=\"create-tables\"/>"); //182:1
            __out.AppendLine(); //182:80
            __out.Append("            <!--<property name=\"eclipselink.logging.level\" value=\"FINE\"/>-->"); //183:1
            __out.AppendLine(); //183:77
            __out.AppendLine(); //184:4
            __out.Append("            <property name=\"javax.persistence.jdbc.driver\" value=\"org.h2.Driver\"/>"); //185:1
            __out.AppendLine(); //185:83
            __out.Append("            <property name=\"javax.persistence.jdbc.url\""); //186:1
            __out.AppendLine(); //186:56
            string __tmp12Prefix = "                      value=\"jdbc:h2:mem/"; //187:1
            string __tmp13Suffix = "\"/>"; //187:51
            StringBuilder __tmp14 = new StringBuilder();
            __tmp14.Append(ns.Name);
            using(StreamReader __tmp14Reader = new StreamReader(this.__ToStream(__tmp14.ToString())))
            {
                bool __tmp14_first = true;
                while(__tmp14_first || !__tmp14Reader.EndOfStream)
                {
                    __tmp14_first = false;
                    string __tmp14Line = __tmp14Reader.ReadLine();
                    if (__tmp14Line == null)
                    {
                        __tmp14Line = "";
                    }
                    __out.Append(__tmp12Prefix);
                    __out.Append(__tmp14Line);
                    __out.Append(__tmp13Suffix);
                    __out.AppendLine(); //187:54
                }
            }
            __out.Append("            <property name=\"javax.persistence.jdbc.user\" value=\"sa\"/>"); //188:1
            __out.AppendLine(); //188:70
            __out.Append("            <property name=\"javax.persistence.jdbc.password\" value=\"\"/><!-- sa? -->"); //189:1
            __out.AppendLine(); //189:84
            __out.Append("        </properties>"); //190:1
            __out.AppendLine(); //190:22
            __out.Append("    </persistence-unit>"); //191:1
            __out.AppendLine(); //191:24
            __out.Append("</persistence>"); //192:1
            __out.AppendLine(); //192:15
            return __out.ToString();
        }

    }
}
