using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Soal //1:1
{
    using __Hidden_SpringClassGenerator_986920096;
    namespace __Hidden_SpringClassGenerator_986920096
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

    public class SpringClassGenerator //2:1
    {
        private object Instances; //2:1

        public SpringClassGenerator() //2:1
        {
        }

        public SpringClassGenerator(object instances) : this() //2:1
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

        public string GenerateInterface(Interface iface) //6:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp1Prefix = "package "; //7:1
            string __tmp2Suffix = ";"; //7:98
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
            string __tmp4Line = "."; //7:48
            __out.Append(__tmp4Line);
            StringBuilder __tmp5 = new StringBuilder();
            __tmp5.Append(SpringGeneratorUtil.Properties.interfacePackage);
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
                    __out.AppendLine(); //7:99
                }
            }
            __out.AppendLine(); //8:1
            string __tmp6Prefix = string.Empty;
            string __tmp7Suffix = string.Empty;
            StringBuilder __tmp8 = new StringBuilder();
            __tmp8.Append(SpringGeneratorUtil.GenerateImports(iface));
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
                    __out.AppendLine(); //9:45
                }
            }
            string __tmp9Prefix = "public interface "; //10:1
            string __tmp10Suffix = " {"; //10:30
            StringBuilder __tmp11 = new StringBuilder();
            __tmp11.Append(iface.Name);
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
                    __out.AppendLine(); //10:32
                }
            }
            var __loop1_results = 
                (from __loop1_var1 in __Enumerate((iface).GetEnumerator()) //11:8
                from op in __Enumerate((__loop1_var1.Operations).GetEnumerator()) //11:15
                select new { __loop1_var1 = __loop1_var1, op = op}
                ).ToList(); //11:2
            int __loop1_iteration = 0;
            foreach (var __tmp12 in __loop1_results)
            {
                ++__loop1_iteration;
                var __loop1_var1 = __tmp12.__loop1_var1;
                var op = __tmp12.op;
                string __tmp13Prefix = "	"; //12:1
                string __tmp14Suffix = ");"; //12:84
                StringBuilder __tmp15 = new StringBuilder();
                __tmp15.Append(op.ReturnType.GetJavaName());
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
                string __tmp16Line = " "; //12:31
                __out.Append(__tmp16Line);
                StringBuilder __tmp17 = new StringBuilder();
                __tmp17.Append(op.Name);
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
                    }
                }
                string __tmp18Line = "("; //12:41
                __out.Append(__tmp18Line);
                StringBuilder __tmp19 = new StringBuilder();
                __tmp19.Append(SpringGeneratorUtil.GetParameterList(op));
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
                        __out.Append(__tmp14Suffix);
                        __out.AppendLine(); //12:86
                    }
                }
            }
            __out.Append("}"); //14:1
            __out.AppendLine(); //14:2
            return __out.ToString();
        }

        public string GenerateComponent(Component component) //17:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp1Prefix = "package "; //18:1
            string __tmp2Suffix = ";"; //18:106
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
            string __tmp4Line = "."; //18:52
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
                    __out.AppendLine(); //18:107
                }
            }
            __out.AppendLine(); //19:1
            string __tmp6Prefix = "//import "; //20:1
            string __tmp7Suffix = ".util.ListUtil; TODO"; //20:53
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
                    __out.Append(__tmp7Suffix);
                    __out.AppendLine(); //20:73
                }
            }
            __out.Append("import org.springframework.beans.factory.annotation.Autowired;"); //21:1
            __out.AppendLine(); //21:63
            __out.Append("import org.springframework.stereotype.Service;"); //22:1
            __out.AppendLine(); //22:47
            __out.AppendLine(); //23:1
            string __tmp9Prefix = string.Empty;
            string __tmp10Suffix = string.Empty;
            StringBuilder __tmp11 = new StringBuilder();
            __tmp11.Append(SpringGeneratorUtil.GenerateImports(component));
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
                    __out.AppendLine(); //24:49
                }
            }
            __out.Append("@Service"); //25:1
            __out.AppendLine(); //25:9
            string interfaces = SpringGeneratorUtil.GetInterfaceList(component); //26:2
            if (interfaces.Any()) //27:2
            {
                string __tmp12Prefix = "public class "; //28:1
                string __tmp13Suffix = " {"; //28:54
                StringBuilder __tmp14 = new StringBuilder();
                __tmp14.Append(component.Name);
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
                    }
                }
                string __tmp15Line = " implements "; //28:30
                __out.Append(__tmp15Line);
                StringBuilder __tmp16 = new StringBuilder();
                __tmp16.Append(interfaces);
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
                        __out.Append(__tmp13Suffix);
                        __out.AppendLine(); //28:56
                    }
                }
            }
            else //29:2
            {
                string __tmp17Prefix = "public class "; //30:1
                string __tmp18Suffix = " {"; //30:30
                StringBuilder __tmp19 = new StringBuilder();
                __tmp19.Append(component.Name);
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
                        __out.Append(__tmp18Suffix);
                        __out.AppendLine(); //30:32
                    }
                }
            }
            __out.AppendLine(); //32:1
            var __loop2_results = 
                (from __loop2_var1 in __Enumerate((component).GetEnumerator()) //33:8
                from repo in __Enumerate((__loop2_var1.GetRepositories()).GetEnumerator()) //33:19
                select new { __loop2_var1 = __loop2_var1, repo = repo}
                ).ToList(); //33:2
            int __loop2_iteration = 0;
            foreach (var __tmp20 in __loop2_results)
            {
                ++__loop2_iteration;
                var __loop2_var1 = __tmp20.__loop2_var1;
                var repo = __tmp20.repo;
                __out.Append("	@Autowired"); //34:1
                __out.AppendLine(); //34:12
                string __tmp21Prefix = "	"; //35:1
                string __tmp22Suffix = ";"; //35:8
                StringBuilder __tmp23 = new StringBuilder();
                __tmp23.Append(repo);
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
                        __out.Append(__tmp22Suffix);
                        __out.AppendLine(); //35:9
                    }
                }
            }
            __out.AppendLine(); //37:1
            var __loop3_results = 
                (from __loop3_var1 in __Enumerate((component).GetEnumerator()) //38:8
                from reference in __Enumerate((__loop3_var1.References).GetEnumerator()) //38:19
                select new { __loop3_var1 = __loop3_var1, reference = reference}
                ).ToList(); //38:2
            int __loop3_iteration = 0;
            foreach (var __tmp24 in __loop3_results)
            {
                ++__loop3_iteration;
                var __loop3_var1 = __tmp24.__loop3_var1;
                var reference = __tmp24.reference;
                __out.Append("	@Autowired"); //39:1
                __out.AppendLine(); //39:12
                string __tmp25Prefix = "	private "; //40:1
                string __tmp26Suffix = ";"; //40:53
                StringBuilder __tmp27 = new StringBuilder();
                __tmp27.Append(reference.Interface.Name);
                using(StreamReader __tmp27Reader = new StreamReader(this.__ToStream(__tmp27.ToString())))
                {
                    bool __tmp27_first = true;
                    while(__tmp27_first || !__tmp27Reader.EndOfStream)
                    {
                        __tmp27_first = false;
                        string __tmp27Line = __tmp27Reader.ReadLine();
                        if (__tmp27Line == null)
                        {
                            __tmp27Line = "";
                        }
                        __out.Append(__tmp25Prefix);
                        __out.Append(__tmp27Line);
                    }
                }
                string __tmp28Line = " "; //40:36
                __out.Append(__tmp28Line);
                StringBuilder __tmp29 = new StringBuilder();
                __tmp29.Append(reference.Name);
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
                        __out.Append(__tmp29Line);
                        __out.Append(__tmp26Suffix);
                        __out.AppendLine(); //40:54
                    }
                }
            }
            __out.AppendLine(); //42:1
            var __loop4_results = 
                (from __loop4_var1 in __Enumerate((component).GetEnumerator()) //43:7
                from s in __Enumerate((__loop4_var1.Services).GetEnumerator()) //43:18
                select new { __loop4_var1 = __loop4_var1, s = s}
                ).ToList(); //43:2
            int __loop4_iteration = 0;
            foreach (var __tmp30 in __loop4_results)
            {
                ++__loop4_iteration;
                var __loop4_var1 = __tmp30.__loop4_var1;
                var s = __tmp30.s;
                Interface i = s.Interface; //44:2
                string __tmp31Prefix = "	//operations of "; //45:1
                string __tmp32Suffix = string.Empty; 
                StringBuilder __tmp33 = new StringBuilder();
                __tmp33.Append(i.Name);
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
                        __out.Append(__tmp31Prefix);
                        __out.Append(__tmp33Line);
                        __out.Append(__tmp32Suffix);
                        __out.AppendLine(); //45:26
                    }
                }
                var __loop5_results = 
                    (from __loop5_var1 in __Enumerate((i).GetEnumerator()) //46:9
                    from op in __Enumerate((__loop5_var1.Operations).GetEnumerator()) //46:12
                    select new { __loop5_var1 = __loop5_var1, op = op}
                    ).ToList(); //46:4
                int __loop5_iteration = 0;
                foreach (var __tmp34 in __loop5_results)
                {
                    ++__loop5_iteration;
                    var __loop5_var1 = __tmp34.__loop5_var1;
                    var op = __tmp34.op;
                    string __tmp35Prefix = "	public "; //47:1
                    string __tmp36Suffix = ") {"; //47:91
                    StringBuilder __tmp37 = new StringBuilder();
                    __tmp37.Append(op.ReturnType.GetJavaName());
                    using(StreamReader __tmp37Reader = new StreamReader(this.__ToStream(__tmp37.ToString())))
                    {
                        bool __tmp37_first = true;
                        while(__tmp37_first || !__tmp37Reader.EndOfStream)
                        {
                            __tmp37_first = false;
                            string __tmp37Line = __tmp37Reader.ReadLine();
                            if (__tmp37Line == null)
                            {
                                __tmp37Line = "";
                            }
                            __out.Append(__tmp35Prefix);
                            __out.Append(__tmp37Line);
                        }
                    }
                    string __tmp38Line = " "; //47:38
                    __out.Append(__tmp38Line);
                    StringBuilder __tmp39 = new StringBuilder();
                    __tmp39.Append(op.Name);
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
                            __out.Append(__tmp39Line);
                        }
                    }
                    string __tmp40Line = "("; //47:48
                    __out.Append(__tmp40Line);
                    StringBuilder __tmp41 = new StringBuilder();
                    __tmp41.Append(SpringGeneratorUtil.GetParameterList(op));
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
                            __out.Append(__tmp36Suffix);
                            __out.AppendLine(); //47:94
                        }
                    }
                    __out.AppendLine(); //48:2
                    __out.Append("	}"); //49:1
                    __out.AppendLine(); //49:3
                    __out.AppendLine(); //50:2
                }
                __out.AppendLine(); //52:3
            }
            __out.Append("}"); //54:1
            __out.AppendLine(); //54:2
            return __out.ToString();
        }

        public string GenerateEnum(Enum myEnum) //57:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp1Prefix = "package "; //58:1
            string __tmp2Suffix = ";"; //58:94
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
            string __tmp4Line = "."; //58:49
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
                    __out.AppendLine(); //58:95
                }
            }
            __out.AppendLine(); //59:1
            string __tmp6Prefix = "public enum "; //60:1
            string __tmp7Suffix = " {"; //60:26
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
                    __out.AppendLine(); //60:28
                }
            }
            var __loop6_results = 
                (from __loop6_var1 in __Enumerate((myEnum).GetEnumerator()) //61:8
                from literal in __Enumerate((__loop6_var1.EnumLiterals).GetEnumerator()) //61:16
                select new { __loop6_var1 = __loop6_var1, literal = literal}
                ).ToList(); //61:2
            int __loop6_iteration = 0;
            string delimiter = ""; //61:38
            foreach (var __tmp9 in __loop6_results)
            {
                ++__loop6_iteration;
                if (__loop6_iteration >= 2) //61:59
                {
                    delimiter = ","; //61:59
                }
                var __loop6_var1 = __tmp9.__loop6_var1;
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
                        __out.AppendLine(); //62:12
                    }
                }
                string __tmp13Prefix = "	"; //63:1
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
            __out.Append(";"); //65:1
            __out.AppendLine(); //65:2
            var __loop7_results = 
                (from __loop7_var1 in __Enumerate((myEnum).GetEnumerator()) //66:8
                from literal in __Enumerate((__loop7_var1.EnumLiterals).GetEnumerator()) //66:16
                select new { __loop7_var1 = __loop7_var1, literal = literal}
                ).ToList(); //66:2
            int __loop7_iteration = 0;
            foreach (var __tmp16 in __loop7_results)
            {
                ++__loop7_iteration;
                var __loop7_var1 = __tmp16.__loop7_var1;
                var literal = __tmp16.literal;
                __out.AppendLine(); //67:1
                string __tmp17Prefix = "	public boolean is"; //68:1
                string __tmp18Suffix = "() {"; //68:48
                StringBuilder __tmp19 = new StringBuilder();
                __tmp19.Append(literal.Name.ToPascalCase());
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
                        __out.Append(__tmp18Suffix);
                        __out.AppendLine(); //68:52
                    }
                }
                string __tmp20Prefix = "		return "; //69:1
                string __tmp21Suffix = ".equals(this);"; //69:34
                StringBuilder __tmp22 = new StringBuilder();
                __tmp22.Append(literal.Name.ToUpper());
                using(StreamReader __tmp22Reader = new StreamReader(this.__ToStream(__tmp22.ToString())))
                {
                    bool __tmp22_first = true;
                    while(__tmp22_first || !__tmp22Reader.EndOfStream)
                    {
                        __tmp22_first = false;
                        string __tmp22Line = __tmp22Reader.ReadLine();
                        if (__tmp22Line == null)
                        {
                            __tmp22Line = "";
                        }
                        __out.Append(__tmp20Prefix);
                        __out.Append(__tmp22Line);
                        __out.Append(__tmp21Suffix);
                        __out.AppendLine(); //69:48
                    }
                }
                __out.Append("	}"); //70:1
                __out.AppendLine(); //70:3
            }
            __out.AppendLine(); //73:1
            __out.Append("}"); //74:1
            __out.AppendLine(); //74:2
            return __out.ToString();
        }

        public string GenerateException(Exception ex) //77:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp1Prefix = "package "; //78:1
            string __tmp2Suffix = ";"; //78:95
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
            string __tmp4Line = "."; //78:45
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
                    __out.AppendLine(); //78:96
                }
            }
            __out.AppendLine(); //79:1
            string __tmp6Prefix = string.Empty;
            string __tmp7Suffix = string.Empty;
            StringBuilder __tmp8 = new StringBuilder();
            __tmp8.Append(SpringGeneratorUtil.GenerateImports(ex));
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
                    __out.AppendLine(); //80:42
                }
            }
            __out.AppendLine(); //81:1
            string __tmp9Prefix = "public class "; //82:1
            string __tmp10Suffix = " extends Exception {"; //82:23
            StringBuilder __tmp11 = new StringBuilder();
            __tmp11.Append(ex.Name);
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
                    __out.AppendLine(); //82:43
                }
            }
            var __loop8_results = 
                (from __loop8_var1 in __Enumerate((ex).GetEnumerator()) //84:8
                from prop in __Enumerate((__loop8_var1.Properties).GetEnumerator()) //84:12
                select new { __loop8_var1 = __loop8_var1, prop = prop}
                ).ToList(); //84:2
            int __loop8_iteration = 0;
            foreach (var __tmp12 in __loop8_results)
            {
                ++__loop8_iteration;
                var __loop8_var1 = __tmp12.__loop8_var1;
                var prop = __tmp12.prop;
                __out.AppendLine(); //85:2
                string __tmp13Prefix = "	private "; //86:1
                string __tmp14Suffix = ";"; //86:72
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
                string __tmp16Line = " "; //86:35
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
                        __out.AppendLine(); //86:73
                    }
                }
            }
            __out.AppendLine(); //89:2
            string __tmp18Prefix = "	public "; //90:1
            string __tmp19Suffix = ") {"; //90:60
            StringBuilder __tmp20 = new StringBuilder();
            __tmp20.Append(ex.Name);
            using(StreamReader __tmp20Reader = new StreamReader(this.__ToStream(__tmp20.ToString())))
            {
                bool __tmp20_first = true;
                while(__tmp20_first || !__tmp20Reader.EndOfStream)
                {
                    __tmp20_first = false;
                    string __tmp20Line = __tmp20Reader.ReadLine();
                    if (__tmp20Line == null)
                    {
                        __tmp20Line = "";
                    }
                    __out.Append(__tmp18Prefix);
                    __out.Append(__tmp20Line);
                }
            }
            string __tmp21Line = "("; //90:18
            __out.Append(__tmp21Line);
            StringBuilder __tmp22 = new StringBuilder();
            __tmp22.Append(SpringGeneratorUtil.GetPropertyList(ex));
            using(StreamReader __tmp22Reader = new StreamReader(this.__ToStream(__tmp22.ToString())))
            {
                bool __tmp22_first = true;
                while(__tmp22_first || !__tmp22Reader.EndOfStream)
                {
                    __tmp22_first = false;
                    string __tmp22Line = __tmp22Reader.ReadLine();
                    if (__tmp22Line == null)
                    {
                        __tmp22Line = "";
                    }
                    __out.Append(__tmp22Line);
                    __out.Append(__tmp19Suffix);
                    __out.AppendLine(); //90:63
                }
            }
            var __loop9_results = 
                (from __loop9_var1 in __Enumerate((ex).GetEnumerator()) //91:8
                from prop in __Enumerate((__loop9_var1.Properties).GetEnumerator()) //91:12
                select new { __loop9_var1 = __loop9_var1, prop = prop}
                ).ToList(); //91:2
            int __loop9_iteration = 0;
            foreach (var __tmp23 in __loop9_results)
            {
                ++__loop9_iteration;
                var __loop9_var1 = __tmp23.__loop9_var1;
                var prop = __tmp23.prop;
                string __tmp24Prefix = "		this."; //92:1
                string __tmp25Suffix = ";"; //92:83
                StringBuilder __tmp26 = new StringBuilder();
                __tmp26.Append(prop.Name.ToString().ToCamelCase());
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
                    }
                }
                string __tmp27Line = " = "; //92:44
                __out.Append(__tmp27Line);
                StringBuilder __tmp28 = new StringBuilder();
                __tmp28.Append(prop.Name.ToString().ToCamelCase());
                using(StreamReader __tmp28Reader = new StreamReader(this.__ToStream(__tmp28.ToString())))
                {
                    bool __tmp28_first = true;
                    while(__tmp28_first || !__tmp28Reader.EndOfStream)
                    {
                        __tmp28_first = false;
                        string __tmp28Line = __tmp28Reader.ReadLine();
                        if (__tmp28Line == null)
                        {
                            __tmp28Line = "";
                        }
                        __out.Append(__tmp28Line);
                        __out.Append(__tmp25Suffix);
                        __out.AppendLine(); //92:84
                    }
                }
            }
            __out.Append("	}"); //94:1
            __out.AppendLine(); //94:3
            var __loop10_results = 
                (from __loop10_var1 in __Enumerate((ex).GetEnumerator()) //96:8
                from prop in __Enumerate((__loop10_var1.Properties).GetEnumerator()) //96:12
                select new { __loop10_var1 = __loop10_var1, prop = prop}
                ).ToList(); //96:2
            int __loop10_iteration = 0;
            foreach (var __tmp29 in __loop10_results)
            {
                ++__loop10_iteration;
                var __loop10_var1 = __tmp29.__loop10_var1;
                var prop = __tmp29.prop;
                string __tmp30Prefix = "	"; //97:1
                string __tmp31Suffix = string.Empty; 
                StringBuilder __tmp32 = new StringBuilder();
                __tmp32.Append(SpringGeneratorUtil.GenerateGetter(prop));
                using(StreamReader __tmp32Reader = new StreamReader(this.__ToStream(__tmp32.ToString())))
                {
                    bool __tmp32_first = true;
                    while(__tmp32_first || !__tmp32Reader.EndOfStream)
                    {
                        __tmp32_first = false;
                        string __tmp32Line = __tmp32Reader.ReadLine();
                        if (__tmp32Line == null)
                        {
                            __tmp32Line = "";
                        }
                        __out.Append(__tmp30Prefix);
                        __out.Append(__tmp32Line);
                        __out.Append(__tmp31Suffix);
                        __out.AppendLine(); //97:44
                    }
                }
            }
            __out.Append("}"); //100:1
            __out.AppendLine(); //100:2
            return __out.ToString();
        }

        public string GenerateEntity(StructuredType sType) //104:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp1Prefix = "package "; //105:1
            string __tmp2Suffix = ";"; //105:95
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
            string __tmp4Line = "."; //105:48
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
                    __out.AppendLine(); //105:96
                }
            }
            __out.AppendLine(); //106:1
            string __tmp6Prefix = string.Empty;
            string __tmp7Suffix = string.Empty;
            StringBuilder __tmp8 = new StringBuilder();
            __tmp8.Append(SpringGeneratorUtil.GenerateImports(sType));
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
                    __out.AppendLine(); //107:45
                }
            }
            __out.AppendLine(); //108:1
            if (sType is Entity) //109:3
            {
                __out.Append("import javax.persistence.*;"); //110:1
                __out.AppendLine(); //110:28
                __out.AppendLine(); //111:1
                __out.Append("@Entity"); //112:1
                __out.AppendLine(); //112:8
            }
            string __tmp9Prefix = "public class "; //114:1
            string __tmp10Suffix = " {"; //114:26
            StringBuilder __tmp11 = new StringBuilder();
            __tmp11.Append(sType.Name);
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
                    __out.AppendLine(); //114:28
                }
            }
            int ids = SpringGeneratorUtil.GetNumberOfFieldWithIdSuffix(sType); //116:2
            if (ids != 1) //117:2
            {
                __out.AppendLine(); //118:2
                if (sType is Entity) //119:4
                {
                    __out.Append("	@Id"); //120:1
                    __out.AppendLine(); //120:5
                    __out.Append("	@GeneratedValue"); //121:1
                    __out.AppendLine(); //121:17
                }
                string __tmp12Prefix = "	private Long "; //123:1
                string __tmp13Suffix = "Id;"; //123:52
                StringBuilder __tmp14 = new StringBuilder();
                __tmp14.Append(sType.Name.ToString().ToCamelCase());
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
                        __out.AppendLine(); //123:55
                    }
                }
            }
            var __loop11_results = 
                (from __loop11_var1 in __Enumerate((sType).GetEnumerator()) //126:8
                from prop in __Enumerate((__loop11_var1.Properties).GetEnumerator()) //126:15
                select new { __loop11_var1 = __loop11_var1, prop = prop}
                ).ToList(); //126:2
            int __loop11_iteration = 0;
            foreach (var __tmp15 in __loop11_results)
            {
                ++__loop11_iteration;
                var __loop11_var1 = __tmp15.__loop11_var1;
                var prop = __tmp15.prop;
                __out.AppendLine(); //127:2
                if (sType is Entity && ids == 1 && prop.Name.ToString().EndsWith("Id")) //128:4
                {
                    __out.Append("	@Id"); //129:1
                    __out.AppendLine(); //129:5
                    __out.Append("	@GeneratedValue"); //130:1
                    __out.AppendLine(); //130:17
                }
                if (sType is Entity && prop.Type is Enum) //132:4
                {
                    __out.Append("	@Enumarated"); //133:1
                    __out.AppendLine(); //133:13
                }
                string __tmp16Prefix = "	private "; //135:1
                string __tmp17Suffix = ";"; //135:72
                StringBuilder __tmp18 = new StringBuilder();
                __tmp18.Append(prop.Type.GetJavaName());
                using(StreamReader __tmp18Reader = new StreamReader(this.__ToStream(__tmp18.ToString())))
                {
                    bool __tmp18_first = true;
                    while(__tmp18_first || !__tmp18Reader.EndOfStream)
                    {
                        __tmp18_first = false;
                        string __tmp18Line = __tmp18Reader.ReadLine();
                        if (__tmp18Line == null)
                        {
                            __tmp18Line = "";
                        }
                        __out.Append(__tmp16Prefix);
                        __out.Append(__tmp18Line);
                    }
                }
                string __tmp19Line = " "; //135:35
                __out.Append(__tmp19Line);
                StringBuilder __tmp20 = new StringBuilder();
                __tmp20.Append(prop.Name.ToString().ToCamelCase());
                using(StreamReader __tmp20Reader = new StreamReader(this.__ToStream(__tmp20.ToString())))
                {
                    bool __tmp20_first = true;
                    while(__tmp20_first || !__tmp20Reader.EndOfStream)
                    {
                        __tmp20_first = false;
                        string __tmp20Line = __tmp20Reader.ReadLine();
                        if (__tmp20Line == null)
                        {
                            __tmp20Line = "";
                        }
                        __out.Append(__tmp20Line);
                        __out.Append(__tmp17Suffix);
                        __out.AppendLine(); //135:73
                    }
                }
            }
            __out.AppendLine(); //139:2
            if (ids == 1) //140:2
            {
                var __loop12_results = 
                    (from __loop12_var1 in __Enumerate((sType).GetEnumerator()) //141:10
                    from id in __Enumerate((__loop12_var1.Properties).GetEnumerator()) //141:17
                    where id.Name.EndsWith("Id") //141:31
                    select new { __loop12_var1 = __loop12_var1, id = id}
                    ).ToList(); //141:4
                int __loop12_iteration = 0;
                foreach (var __tmp21 in __loop12_results)
                {
                    ++__loop12_iteration;
                    var __loop12_var1 = __tmp21.__loop12_var1;
                    var id = __tmp21.id;
                    string __tmp22Prefix = "	public "; //142:1
                    string __tmp23Suffix = "() {"; //142:71
                    StringBuilder __tmp24 = new StringBuilder();
                    __tmp24.Append(id.Type.GetJavaName());
                    using(StreamReader __tmp24Reader = new StreamReader(this.__ToStream(__tmp24.ToString())))
                    {
                        bool __tmp24_first = true;
                        while(__tmp24_first || !__tmp24Reader.EndOfStream)
                        {
                            __tmp24_first = false;
                            string __tmp24Line = __tmp24Reader.ReadLine();
                            if (__tmp24Line == null)
                            {
                                __tmp24Line = "";
                            }
                            __out.Append(__tmp22Prefix);
                            __out.Append(__tmp24Line);
                        }
                    }
                    string __tmp25Line = " get"; //142:32
                    __out.Append(__tmp25Line);
                    StringBuilder __tmp26 = new StringBuilder();
                    __tmp26.Append(id.Name.ToString().ToPascalCase());
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
                            __out.Append(__tmp26Line);
                            __out.Append(__tmp23Suffix);
                            __out.AppendLine(); //142:75
                        }
                    }
                    string __tmp27Prefix = "		return this."; //143:1
                    string __tmp28Suffix = ";"; //143:49
                    StringBuilder __tmp29 = new StringBuilder();
                    __tmp29.Append(id.Name.ToString().ToCamelCase());
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
                            __out.AppendLine(); //143:50
                        }
                    }
                    __out.Append("	}"); //144:1
                    __out.AppendLine(); //144:3
                    __out.AppendLine(); //145:2
                    string __tmp30Prefix = "	public void set"; //146:1
                    string __tmp31Suffix = ") {"; //146:111
                    StringBuilder __tmp32 = new StringBuilder();
                    __tmp32.Append(id.Name.ToString().ToPascalCase());
                    using(StreamReader __tmp32Reader = new StreamReader(this.__ToStream(__tmp32.ToString())))
                    {
                        bool __tmp32_first = true;
                        while(__tmp32_first || !__tmp32Reader.EndOfStream)
                        {
                            __tmp32_first = false;
                            string __tmp32Line = __tmp32Reader.ReadLine();
                            if (__tmp32Line == null)
                            {
                                __tmp32Line = "";
                            }
                            __out.Append(__tmp30Prefix);
                            __out.Append(__tmp32Line);
                        }
                    }
                    string __tmp33Line = "("; //146:52
                    __out.Append(__tmp33Line);
                    StringBuilder __tmp34 = new StringBuilder();
                    __tmp34.Append(id.Type.GetJavaName());
                    using(StreamReader __tmp34Reader = new StreamReader(this.__ToStream(__tmp34.ToString())))
                    {
                        bool __tmp34_first = true;
                        while(__tmp34_first || !__tmp34Reader.EndOfStream)
                        {
                            __tmp34_first = false;
                            string __tmp34Line = __tmp34Reader.ReadLine();
                            if (__tmp34Line == null)
                            {
                                __tmp34Line = "";
                            }
                            __out.Append(__tmp34Line);
                        }
                    }
                    string __tmp35Line = " "; //146:76
                    __out.Append(__tmp35Line);
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
                            __out.Append(__tmp36Line);
                            __out.Append(__tmp31Suffix);
                            __out.AppendLine(); //146:114
                        }
                    }
                    string __tmp37Prefix = "		this."; //147:1
                    string __tmp38Suffix = ";"; //147:79
                    StringBuilder __tmp39 = new StringBuilder();
                    __tmp39.Append(id.Name.ToString().ToCamelCase());
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
                    string __tmp40Line = " = "; //147:42
                    __out.Append(__tmp40Line);
                    StringBuilder __tmp41 = new StringBuilder();
                    __tmp41.Append(id.Name.ToString().ToCamelCase());
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
                            __out.Append(__tmp38Suffix);
                            __out.AppendLine(); //147:80
                        }
                    }
                    __out.Append("	}"); //148:1
                    __out.AppendLine(); //148:3
                }
            }
            else //150:2
            {
                string __tmp42Prefix = "	public Long get"; //151:1
                string __tmp43Suffix = "Id() {"; //151:55
                StringBuilder __tmp44 = new StringBuilder();
                __tmp44.Append(sType.Name.ToString().ToPascalCase());
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
                        __out.AppendLine(); //151:61
                    }
                }
                string __tmp45Prefix = "		return this."; //152:1
                string __tmp46Suffix = "Id;"; //152:52
                StringBuilder __tmp47 = new StringBuilder();
                __tmp47.Append(sType.Name.ToString().ToCamelCase());
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
                        __out.Append(__tmp46Suffix);
                        __out.AppendLine(); //152:55
                    }
                }
                __out.Append("	}"); //153:1
                __out.AppendLine(); //153:3
                __out.AppendLine(); //155:2
                string __tmp48Prefix = "	public void set"; //156:1
                string __tmp49Suffix = "Id) {"; //156:100
                StringBuilder __tmp50 = new StringBuilder();
                __tmp50.Append(sType.Name.ToString().ToPascalCase());
                using(StreamReader __tmp50Reader = new StreamReader(this.__ToStream(__tmp50.ToString())))
                {
                    bool __tmp50_first = true;
                    while(__tmp50_first || !__tmp50Reader.EndOfStream)
                    {
                        __tmp50_first = false;
                        string __tmp50Line = __tmp50Reader.ReadLine();
                        if (__tmp50Line == null)
                        {
                            __tmp50Line = "";
                        }
                        __out.Append(__tmp48Prefix);
                        __out.Append(__tmp50Line);
                    }
                }
                string __tmp51Line = "Id(Long "; //156:55
                __out.Append(__tmp51Line);
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
                        __out.Append(__tmp52Line);
                        __out.Append(__tmp49Suffix);
                        __out.AppendLine(); //156:105
                    }
                }
                string __tmp53Prefix = "		this."; //157:1
                string __tmp54Suffix = "Id;"; //157:87
                StringBuilder __tmp55 = new StringBuilder();
                __tmp55.Append(sType.Name.ToString().ToCamelCase());
                using(StreamReader __tmp55Reader = new StreamReader(this.__ToStream(__tmp55.ToString())))
                {
                    bool __tmp55_first = true;
                    while(__tmp55_first || !__tmp55Reader.EndOfStream)
                    {
                        __tmp55_first = false;
                        string __tmp55Line = __tmp55Reader.ReadLine();
                        if (__tmp55Line == null)
                        {
                            __tmp55Line = "";
                        }
                        __out.Append(__tmp53Prefix);
                        __out.Append(__tmp55Line);
                    }
                }
                string __tmp56Line = "Id = "; //157:45
                __out.Append(__tmp56Line);
                StringBuilder __tmp57 = new StringBuilder();
                __tmp57.Append(sType.Name.ToString().ToCamelCase());
                using(StreamReader __tmp57Reader = new StreamReader(this.__ToStream(__tmp57.ToString())))
                {
                    bool __tmp57_first = true;
                    while(__tmp57_first || !__tmp57Reader.EndOfStream)
                    {
                        __tmp57_first = false;
                        string __tmp57Line = __tmp57Reader.ReadLine();
                        if (__tmp57Line == null)
                        {
                            __tmp57Line = "";
                        }
                        __out.Append(__tmp57Line);
                        __out.Append(__tmp54Suffix);
                        __out.AppendLine(); //157:90
                    }
                }
                __out.Append("	}"); //158:1
                __out.AppendLine(); //158:3
            }
            var __loop13_results = 
                (from __loop13_var1 in __Enumerate((sType).GetEnumerator()) //161:8
                from prop in __Enumerate((__loop13_var1.Properties).GetEnumerator()) //161:15
                where !prop.Name.EndsWith("Id") //161:31
                select new { __loop13_var1 = __loop13_var1, prop = prop}
                ).ToList(); //161:2
            int __loop13_iteration = 0;
            foreach (var __tmp58 in __loop13_results)
            {
                ++__loop13_iteration;
                var __loop13_var1 = __tmp58.__loop13_var1;
                var prop = __tmp58.prop;
                string __tmp59Prefix = "	"; //162:1
                string __tmp60Suffix = string.Empty; 
                StringBuilder __tmp61 = new StringBuilder();
                __tmp61.Append(SpringGeneratorUtil.GenerateGetter(prop));
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
                        __out.AppendLine(); //162:44
                    }
                }
                string __tmp62Prefix = "	"; //163:1
                string __tmp63Suffix = string.Empty; 
                StringBuilder __tmp64 = new StringBuilder();
                __tmp64.Append(SpringGeneratorUtil.GenerateSetter(prop));
                using(StreamReader __tmp64Reader = new StreamReader(this.__ToStream(__tmp64.ToString())))
                {
                    bool __tmp64_first = true;
                    while(__tmp64_first || !__tmp64Reader.EndOfStream)
                    {
                        __tmp64_first = false;
                        string __tmp64Line = __tmp64Reader.ReadLine();
                        if (__tmp64Line == null)
                        {
                            __tmp64Line = "";
                        }
                        __out.Append(__tmp62Prefix);
                        __out.Append(__tmp64Line);
                        __out.Append(__tmp63Suffix);
                        __out.AppendLine(); //163:44
                    }
                }
            }
            __out.Append("}"); //166:1
            __out.AppendLine(); //166:2
            return __out.ToString();
        }

        public string GenerateRepository(Entity entity) //169:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp1Prefix = "package "; //170:1
            string __tmp2Suffix = ";"; //170:100
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
            string __tmp4Line = "."; //170:49
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
                    __out.AppendLine(); //170:101
                }
            }
            __out.AppendLine(); //171:1
            string __tmp6Prefix = "import "; //172:1
            string __tmp7Suffix = ";"; //172:109
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
            string __tmp9Line = "."; //172:48
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
            string __tmp11Line = "."; //172:95
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
                    __out.AppendLine(); //172:110
                }
            }
            __out.Append("import org.springframework.data.repository.CrudRepository;"); //173:1
            __out.AppendLine(); //173:59
            __out.Append("import org.springframework.stereotype.Repository;"); //174:1
            __out.AppendLine(); //174:50
            __out.AppendLine(); //175:1
            __out.Append("@Repository"); //176:1
            __out.AppendLine(); //176:12
            string __tmp13Prefix = "public interface "; //177:1
            string __tmp14Suffix = ",Long> {"; //177:78
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
            string __tmp16Line = "Repository extends CrudRepository<"; //177:31
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
                    __out.AppendLine(); //177:86
                }
            }
            __out.AppendLine(); //178:1
            __out.Append("}"); //179:1
            __out.AppendLine(); //179:2
            return __out.ToString();
        }

    }
}
