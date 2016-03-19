using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Soal //1:1
{
    using __Hidden_SpringClassGenerator_1295978090;
    namespace __Hidden_SpringClassGenerator_1295978090
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

        public string GenerateStruct(Struct sType) //8:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp2Line = "package "; //9:1
            if (__tmp2Line != null) __out.Append(__tmp2Line);
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(SpringGeneratorUtil.GetPackage(sType));
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
            string __tmp4Line = "."; //9:48
            if (__tmp4Line != null) __out.Append(__tmp4Line);
            StringBuilder __tmp5 = new StringBuilder();
            __tmp5.Append(SpringGeneratorUtil.Properties.entityPackage);
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
            string __tmp6Line = ";"; //9:95
            if (__tmp6Line != null) __out.Append(__tmp6Line);
            __out.AppendLine(false); //9:96
            __out.AppendLine(true); //10:1
            StringBuilder __tmp8 = new StringBuilder();
            __tmp8.Append(SpringGeneratorUtil.GenerateImports(sType));
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
                    __out.AppendLine(false); //11:45
                }
            }
            __out.AppendLine(true); //12:1
            string __tmp10Line = "public class "; //13:1
            if (__tmp10Line != null) __out.Append(__tmp10Line);
            StringBuilder __tmp11 = new StringBuilder();
            __tmp11.Append(sType.Name);
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
            string __tmp12Line = " {"; //13:26
            if (__tmp12Line != null) __out.Append(__tmp12Line);
            __out.AppendLine(false); //13:28
            var __loop1_results = 
                (from __loop1_var1 in __Enumerate((sType).GetEnumerator()) //15:8
                from prop in __Enumerate((__loop1_var1.Properties).GetEnumerator()) //15:15
                select new { __loop1_var1 = __loop1_var1, prop = prop}
                ).ToList(); //15:2
            int __loop1_iteration = 0;
            foreach (var __tmp13 in __loop1_results)
            {
                ++__loop1_iteration;
                var __loop1_var1 = __tmp13.__loop1_var1;
                var prop = __tmp13.prop;
                __out.AppendLine(true); //16:2
                string __tmp15Line = "	private "; //17:1
                if (__tmp15Line != null) __out.Append(__tmp15Line);
                StringBuilder __tmp16 = new StringBuilder();
                __tmp16.Append(prop.Type.GetJavaName());
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
                string __tmp17Line = " "; //17:35
                if (__tmp17Line != null) __out.Append(__tmp17Line);
                StringBuilder __tmp18 = new StringBuilder();
                __tmp18.Append(prop.Name.ToString().ToCamelCase());
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
                string __tmp19Line = ";"; //17:72
                if (__tmp19Line != null) __out.Append(__tmp19Line);
                __out.AppendLine(false); //17:73
            }
            var __loop2_results = 
                (from __loop2_var1 in __Enumerate((sType).GetEnumerator()) //20:8
                from prop in __Enumerate((__loop2_var1.Properties).GetEnumerator()) //20:15
                select new { __loop2_var1 = __loop2_var1, prop = prop}
                ).ToList(); //20:2
            int __loop2_iteration = 0;
            foreach (var __tmp20 in __loop2_results)
            {
                ++__loop2_iteration;
                var __loop2_var1 = __tmp20.__loop2_var1;
                var prop = __tmp20.prop;
                string __tmp21Prefix = "	"; //21:1
                StringBuilder __tmp22 = new StringBuilder();
                __tmp22.Append(SpringGeneratorUtil.GenerateGetter(prop));
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
                        __out.AppendLine(false); //21:44
                    }
                }
                string __tmp23Prefix = "	"; //22:1
                StringBuilder __tmp24 = new StringBuilder();
                __tmp24.Append(SpringGeneratorUtil.GenerateSetter(prop));
                using(StreamReader __tmp24Reader = new StreamReader(this.__ToStream(__tmp24.ToString())))
                {
                    bool __tmp24_first = true;
                    bool __tmp24_last = __tmp24Reader.EndOfStream;
                    while(__tmp24_first || !__tmp24_last)
                    {
                        __tmp24_first = false;
                        string __tmp24Line = __tmp24Reader.ReadLine();
                        __tmp24_last = __tmp24Reader.EndOfStream;
                        __out.Append(__tmp23Prefix);
                        if (__tmp24Line != null) __out.Append(__tmp24Line);
                        if (!__tmp24_last) __out.AppendLine(true);
                        __out.AppendLine(false); //22:44
                    }
                }
            }
            __out.Append("}"); //25:1
            __out.AppendLine(false); //25:2
            return __out.ToString();
        }

        public string GenerateEnum(Enum myEnum) //30:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp2Line = "package "; //31:1
            if (__tmp2Line != null) __out.Append(__tmp2Line);
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(SpringGeneratorUtil.GetPackage(myEnum));
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
            string __tmp4Line = "."; //31:49
            if (__tmp4Line != null) __out.Append(__tmp4Line);
            StringBuilder __tmp5 = new StringBuilder();
            __tmp5.Append(SpringGeneratorUtil.Properties.enumPackage);
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
            string __tmp6Line = ";"; //31:94
            if (__tmp6Line != null) __out.Append(__tmp6Line);
            __out.AppendLine(false); //31:95
            __out.AppendLine(true); //32:1
            string __tmp8Line = "public enum "; //33:1
            if (__tmp8Line != null) __out.Append(__tmp8Line);
            StringBuilder __tmp9 = new StringBuilder();
            __tmp9.Append(myEnum.Name);
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
            string __tmp10Line = " {"; //33:26
            if (__tmp10Line != null) __out.Append(__tmp10Line);
            __out.AppendLine(false); //33:28
            var __loop3_results = 
                (from __loop3_var1 in __Enumerate((myEnum).GetEnumerator()) //34:8
                from literal in __Enumerate((__loop3_var1.EnumLiterals).GetEnumerator()) //34:16
                select new { __loop3_var1 = __loop3_var1, literal = literal}
                ).ToList(); //34:2
            int __loop3_iteration = 0;
            string delimiter = ""; //34:38
            foreach (var __tmp11 in __loop3_results)
            {
                ++__loop3_iteration;
                if (__loop3_iteration >= 2) //34:59
                {
                    delimiter = ","; //34:59
                }
                var __loop3_var1 = __tmp11.__loop3_var1;
                var literal = __tmp11.literal;
                StringBuilder __tmp13 = new StringBuilder();
                __tmp13.Append(delimiter);
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
                        __out.AppendLine(false); //35:12
                    }
                }
                string __tmp14Prefix = "	"; //36:1
                StringBuilder __tmp15 = new StringBuilder();
                __tmp15.Append(literal.Name.ToUpper());
                using(StreamReader __tmp15Reader = new StreamReader(this.__ToStream(__tmp15.ToString())))
                {
                    bool __tmp15_first = true;
                    bool __tmp15_last = __tmp15Reader.EndOfStream;
                    while(__tmp15_first || !__tmp15_last)
                    {
                        __tmp15_first = false;
                        string __tmp15Line = __tmp15Reader.ReadLine();
                        __tmp15_last = __tmp15Reader.EndOfStream;
                        __out.Append(__tmp14Prefix);
                        if (__tmp15Line != null) __out.Append(__tmp15Line);
                        if (!__tmp15_last) __out.AppendLine(true);
                    }
                }
            }
            __out.Append(";"); //38:1
            __out.AppendLine(true); //38:2
            var __loop4_results = 
                (from __loop4_var1 in __Enumerate((myEnum).GetEnumerator()) //39:8
                from literal in __Enumerate((__loop4_var1.EnumLiterals).GetEnumerator()) //39:16
                select new { __loop4_var1 = __loop4_var1, literal = literal}
                ).ToList(); //39:2
            int __loop4_iteration = 0;
            foreach (var __tmp16 in __loop4_results)
            {
                ++__loop4_iteration;
                var __loop4_var1 = __tmp16.__loop4_var1;
                var literal = __tmp16.literal;
                __out.AppendLine(true); //40:1
                string __tmp18Line = "	public boolean is"; //41:1
                if (__tmp18Line != null) __out.Append(__tmp18Line);
                StringBuilder __tmp19 = new StringBuilder();
                __tmp19.Append(literal.Name.ToPascalCase());
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
                string __tmp20Line = "() {"; //41:48
                if (__tmp20Line != null) __out.Append(__tmp20Line);
                __out.AppendLine(false); //41:52
                string __tmp22Line = "		return "; //42:1
                if (__tmp22Line != null) __out.Append(__tmp22Line);
                StringBuilder __tmp23 = new StringBuilder();
                __tmp23.Append(literal.Name.ToUpper());
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
                string __tmp24Line = ".equals(this);"; //42:34
                if (__tmp24Line != null) __out.Append(__tmp24Line);
                __out.AppendLine(false); //42:48
                __out.Append("	}"); //43:1
                __out.AppendLine(false); //43:3
            }
            __out.AppendLine(true); //46:1
            __out.Append("}"); //47:1
            __out.AppendLine(false); //47:2
            return __out.ToString();
        }

        public string GenerateException(Struct ex) //52:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp2Line = "package "; //53:1
            if (__tmp2Line != null) __out.Append(__tmp2Line);
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(SpringGeneratorUtil.GetPackage(ex));
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
            string __tmp4Line = "."; //53:45
            if (__tmp4Line != null) __out.Append(__tmp4Line);
            StringBuilder __tmp5 = new StringBuilder();
            __tmp5.Append(SpringGeneratorUtil.Properties.exceptionPackage);
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
            string __tmp6Line = ";"; //53:95
            if (__tmp6Line != null) __out.Append(__tmp6Line);
            __out.AppendLine(false); //53:96
            __out.AppendLine(true); //54:1
            StringBuilder __tmp8 = new StringBuilder();
            __tmp8.Append(SpringGeneratorUtil.GenerateImports(ex));
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
                    __out.AppendLine(false); //55:42
                }
            }
            __out.AppendLine(true); //56:1
            string __tmp10Line = "public class "; //57:1
            if (__tmp10Line != null) __out.Append(__tmp10Line);
            StringBuilder __tmp11 = new StringBuilder();
            __tmp11.Append(ex.Name);
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
            string __tmp12Line = " extends Exception {"; //57:23
            if (__tmp12Line != null) __out.Append(__tmp12Line);
            __out.AppendLine(false); //57:43
            __out.Append("	private static final long serialVersionUID = 1L;"); //58:1
            __out.AppendLine(false); //58:50
            var __loop5_results = 
                (from __loop5_var1 in __Enumerate((ex).GetEnumerator()) //59:8
                from prop in __Enumerate((__loop5_var1.Properties).GetEnumerator()) //59:12
                select new { __loop5_var1 = __loop5_var1, prop = prop}
                ).ToList(); //59:2
            int __loop5_iteration = 0;
            foreach (var __tmp13 in __loop5_results)
            {
                ++__loop5_iteration;
                var __loop5_var1 = __tmp13.__loop5_var1;
                var prop = __tmp13.prop;
                __out.AppendLine(true); //60:2
                string __tmp15Line = "	private "; //61:1
                if (__tmp15Line != null) __out.Append(__tmp15Line);
                StringBuilder __tmp16 = new StringBuilder();
                __tmp16.Append(prop.Type.GetJavaName());
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
                string __tmp17Line = " "; //61:35
                if (__tmp17Line != null) __out.Append(__tmp17Line);
                StringBuilder __tmp18 = new StringBuilder();
                __tmp18.Append(prop.Name.ToString().ToCamelCase());
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
                string __tmp19Line = ";"; //61:72
                if (__tmp19Line != null) __out.Append(__tmp19Line);
                __out.AppendLine(false); //61:73
            }
            __out.AppendLine(true); //64:2
            string __tmp21Line = "	public "; //65:1
            if (__tmp21Line != null) __out.Append(__tmp21Line);
            StringBuilder __tmp22 = new StringBuilder();
            __tmp22.Append(ex.Name);
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
            string __tmp23Line = "("; //65:18
            if (__tmp23Line != null) __out.Append(__tmp23Line);
            StringBuilder __tmp24 = new StringBuilder();
            __tmp24.Append(SpringGeneratorUtil.GetPropertyList(ex));
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
            string __tmp25Line = ") {"; //65:60
            if (__tmp25Line != null) __out.Append(__tmp25Line);
            __out.AppendLine(false); //65:63
            var __loop6_results = 
                (from __loop6_var1 in __Enumerate((ex).GetEnumerator()) //66:8
                from prop in __Enumerate((__loop6_var1.Properties).GetEnumerator()) //66:12
                select new { __loop6_var1 = __loop6_var1, prop = prop}
                ).ToList(); //66:2
            int __loop6_iteration = 0;
            foreach (var __tmp26 in __loop6_results)
            {
                ++__loop6_iteration;
                var __loop6_var1 = __tmp26.__loop6_var1;
                var prop = __tmp26.prop;
                string __tmp28Line = "		this."; //67:1
                if (__tmp28Line != null) __out.Append(__tmp28Line);
                StringBuilder __tmp29 = new StringBuilder();
                __tmp29.Append(prop.Name.ToString().ToCamelCase());
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
                string __tmp30Line = " = "; //67:44
                if (__tmp30Line != null) __out.Append(__tmp30Line);
                StringBuilder __tmp31 = new StringBuilder();
                __tmp31.Append(prop.Name.ToString().ToCamelCase());
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
                string __tmp32Line = ";"; //67:83
                if (__tmp32Line != null) __out.Append(__tmp32Line);
                __out.AppendLine(false); //67:84
            }
            __out.Append("	}"); //69:1
            __out.AppendLine(false); //69:3
            var __loop7_results = 
                (from __loop7_var1 in __Enumerate((ex).GetEnumerator()) //71:8
                from prop in __Enumerate((__loop7_var1.Properties).GetEnumerator()) //71:12
                select new { __loop7_var1 = __loop7_var1, prop = prop}
                ).ToList(); //71:2
            int __loop7_iteration = 0;
            foreach (var __tmp33 in __loop7_results)
            {
                ++__loop7_iteration;
                var __loop7_var1 = __tmp33.__loop7_var1;
                var prop = __tmp33.prop;
                string __tmp34Prefix = "	"; //72:1
                StringBuilder __tmp35 = new StringBuilder();
                __tmp35.Append(SpringGeneratorUtil.GenerateGetter(prop));
                using(StreamReader __tmp35Reader = new StreamReader(this.__ToStream(__tmp35.ToString())))
                {
                    bool __tmp35_first = true;
                    bool __tmp35_last = __tmp35Reader.EndOfStream;
                    while(__tmp35_first || !__tmp35_last)
                    {
                        __tmp35_first = false;
                        string __tmp35Line = __tmp35Reader.ReadLine();
                        __tmp35_last = __tmp35Reader.EndOfStream;
                        __out.Append(__tmp34Prefix);
                        if (__tmp35Line != null) __out.Append(__tmp35Line);
                        if (!__tmp35_last) __out.AppendLine(true);
                        __out.AppendLine(false); //72:44
                    }
                }
            }
            __out.Append("}"); //75:1
            __out.AppendLine(false); //75:2
            return __out.ToString();
        }

        public string GenerateRepository(Struct entity) //80:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp2Line = "package "; //81:1
            if (__tmp2Line != null) __out.Append(__tmp2Line);
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(SpringGeneratorUtil.GetPackage(entity));
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
            string __tmp4Line = "."; //81:49
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
            string __tmp6Line = ";"; //81:100
            if (__tmp6Line != null) __out.Append(__tmp6Line);
            __out.AppendLine(false); //81:101
            __out.AppendLine(true); //82:1
            string __tmp8Line = "import "; //83:1
            if (__tmp8Line != null) __out.Append(__tmp8Line);
            StringBuilder __tmp9 = new StringBuilder();
            __tmp9.Append(SpringGeneratorUtil.GetPackage(entity));
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
            string __tmp10Line = "."; //83:48
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
            string __tmp12Line = "."; //83:95
            if (__tmp12Line != null) __out.Append(__tmp12Line);
            StringBuilder __tmp13 = new StringBuilder();
            __tmp13.Append(entity.Name);
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
            string __tmp14Line = ";"; //83:109
            if (__tmp14Line != null) __out.Append(__tmp14Line);
            __out.AppendLine(false); //83:110
            __out.Append("import org.springframework.data.repository.CrudRepository;"); //84:1
            __out.AppendLine(false); //84:59
            __out.Append("import org.springframework.stereotype.Repository;"); //85:1
            __out.AppendLine(false); //85:50
            __out.AppendLine(true); //86:1
            __out.Append("@Repository"); //87:1
            __out.AppendLine(false); //87:12
            string __tmp16Line = "public interface "; //88:1
            if (__tmp16Line != null) __out.Append(__tmp16Line);
            StringBuilder __tmp17 = new StringBuilder();
            __tmp17.Append(entity.Name);
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
            string __tmp18Line = "Repository extends CrudRepository<"; //88:31
            if (__tmp18Line != null) __out.Append(__tmp18Line);
            StringBuilder __tmp19 = new StringBuilder();
            __tmp19.Append(entity.Name);
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
            string __tmp20Line = ",Long> {"; //88:78
            if (__tmp20Line != null) __out.Append(__tmp20Line);
            __out.AppendLine(false); //88:86
            __out.AppendLine(true); //89:1
            __out.Append("}"); //90:1
            __out.AppendLine(false); //90:2
            return __out.ToString();
        }

        public string GenerateEntity(Struct sType) //95:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp2Line = "package "; //96:1
            if (__tmp2Line != null) __out.Append(__tmp2Line);
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(SpringGeneratorUtil.GetPackage(sType));
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
            string __tmp4Line = "."; //96:48
            if (__tmp4Line != null) __out.Append(__tmp4Line);
            StringBuilder __tmp5 = new StringBuilder();
            __tmp5.Append(SpringGeneratorUtil.Properties.entityPackage);
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
            string __tmp6Line = ";"; //96:95
            if (__tmp6Line != null) __out.Append(__tmp6Line);
            __out.AppendLine(false); //96:96
            __out.AppendLine(true); //97:1
            StringBuilder __tmp8 = new StringBuilder();
            __tmp8.Append(SpringGeneratorUtil.GenerateImports(sType));
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
                    __out.AppendLine(false); //98:45
                }
            }
            __out.AppendLine(true); //99:1
            __out.Append("import javax.persistence.*;"); //100:1
            __out.AppendLine(false); //100:28
            __out.AppendLine(true); //101:1
            __out.Append("@Entity"); //102:1
            __out.AppendLine(false); //102:8
            string __tmp10Line = "public class "; //103:1
            if (__tmp10Line != null) __out.Append(__tmp10Line);
            StringBuilder __tmp11 = new StringBuilder();
            __tmp11.Append(sType.Name);
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
            string __tmp12Line = " {"; //103:26
            if (__tmp12Line != null) __out.Append(__tmp12Line);
            __out.AppendLine(false); //103:28
            int ids = SpringGeneratorUtil.GetNumberOfFieldWithIdSuffix(sType); //105:2
            if (ids != 1) //106:2
            {
                __out.AppendLine(true); //107:2
                __out.Append("	@Id"); //108:1
                __out.AppendLine(false); //108:5
                __out.Append("	@GeneratedValue"); //109:1
                __out.AppendLine(false); //109:17
                string __tmp14Line = "	private Long "; //110:1
                if (__tmp14Line != null) __out.Append(__tmp14Line);
                StringBuilder __tmp15 = new StringBuilder();
                __tmp15.Append(sType.Name.ToString().ToCamelCase());
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
                string __tmp16Line = "Id;"; //110:52
                if (__tmp16Line != null) __out.Append(__tmp16Line);
                __out.AppendLine(false); //110:55
            }
            var __loop8_results = 
                (from __loop8_var1 in __Enumerate((sType).GetEnumerator()) //113:8
                from prop in __Enumerate((__loop8_var1.Properties).GetEnumerator()) //113:15
                select new { __loop8_var1 = __loop8_var1, prop = prop}
                ).ToList(); //113:2
            int __loop8_iteration = 0;
            foreach (var __tmp17 in __loop8_results)
            {
                ++__loop8_iteration;
                var __loop8_var1 = __tmp17.__loop8_var1;
                var prop = __tmp17.prop;
                __out.AppendLine(true); //114:2
                if (ids == 1 && prop.Name.ToString().EndsWith("Id")) //115:4
                {
                    __out.Append("	@Id"); //116:1
                    __out.AppendLine(false); //116:5
                    __out.Append("	@GeneratedValue"); //117:1
                    __out.AppendLine(false); //117:17
                }
                else if (prop.Type is Enum) //118:4
                {
                    __out.Append("	@Enumerated"); //119:1
                    __out.AppendLine(false); //119:13
                }
                string mapping = sType.GetEntityMappingString(prop.Type); //121:3
                if (mapping.Any()) //122:4
                {
                    string __tmp18Prefix = "	"; //123:1
                    StringBuilder __tmp19 = new StringBuilder();
                    __tmp19.Append(mapping);
                    using(StreamReader __tmp19Reader = new StreamReader(this.__ToStream(__tmp19.ToString())))
                    {
                        bool __tmp19_first = true;
                        bool __tmp19_last = __tmp19Reader.EndOfStream;
                        while(__tmp19_first || !__tmp19_last)
                        {
                            __tmp19_first = false;
                            string __tmp19Line = __tmp19Reader.ReadLine();
                            __tmp19_last = __tmp19Reader.EndOfStream;
                            __out.Append(__tmp18Prefix);
                            if (__tmp19Line != null) __out.Append(__tmp19Line);
                            if (!__tmp19_last) __out.AppendLine(true);
                            __out.AppendLine(false); //123:11
                        }
                    }
                }
                string __tmp21Line = "	private "; //125:1
                if (__tmp21Line != null) __out.Append(__tmp21Line);
                StringBuilder __tmp22 = new StringBuilder();
                __tmp22.Append(prop.Type.GetJavaName());
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
                string __tmp23Line = " "; //125:35
                if (__tmp23Line != null) __out.Append(__tmp23Line);
                StringBuilder __tmp24 = new StringBuilder();
                __tmp24.Append(prop.Name.ToString().ToCamelCase());
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
                string __tmp25Line = ";"; //125:72
                if (__tmp25Line != null) __out.Append(__tmp25Line);
                __out.AppendLine(false); //125:73
            }
            __out.AppendLine(true); //128:2
            if (ids == 1) //129:2
            {
                var __loop9_results = 
                    (from __loop9_var1 in __Enumerate((sType).GetEnumerator()) //130:10
                    from id in __Enumerate((__loop9_var1.Properties).GetEnumerator()) //130:17
                    where id.Name.EndsWith("Id") //130:31
                    select new { __loop9_var1 = __loop9_var1, id = id}
                    ).ToList(); //130:4
                int __loop9_iteration = 0;
                foreach (var __tmp26 in __loop9_results)
                {
                    ++__loop9_iteration;
                    var __loop9_var1 = __tmp26.__loop9_var1;
                    var id = __tmp26.id;
                    string __tmp28Line = "	public "; //131:1
                    if (__tmp28Line != null) __out.Append(__tmp28Line);
                    StringBuilder __tmp29 = new StringBuilder();
                    __tmp29.Append(id.Type.GetJavaName());
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
                    string __tmp30Line = " get"; //131:32
                    if (__tmp30Line != null) __out.Append(__tmp30Line);
                    StringBuilder __tmp31 = new StringBuilder();
                    __tmp31.Append(id.Name.ToString().ToPascalCase());
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
                    string __tmp32Line = "() {"; //131:71
                    if (__tmp32Line != null) __out.Append(__tmp32Line);
                    __out.AppendLine(false); //131:75
                    string __tmp34Line = "		return this."; //132:1
                    if (__tmp34Line != null) __out.Append(__tmp34Line);
                    StringBuilder __tmp35 = new StringBuilder();
                    __tmp35.Append(id.Name.ToString().ToCamelCase());
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
                    string __tmp36Line = ";"; //132:49
                    if (__tmp36Line != null) __out.Append(__tmp36Line);
                    __out.AppendLine(false); //132:50
                    __out.Append("	}"); //133:1
                    __out.AppendLine(false); //133:3
                    __out.AppendLine(true); //134:2
                    string __tmp38Line = "	public void set"; //135:1
                    if (__tmp38Line != null) __out.Append(__tmp38Line);
                    StringBuilder __tmp39 = new StringBuilder();
                    __tmp39.Append(id.Name.ToString().ToPascalCase());
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
                    string __tmp40Line = "("; //135:52
                    if (__tmp40Line != null) __out.Append(__tmp40Line);
                    StringBuilder __tmp41 = new StringBuilder();
                    __tmp41.Append(id.Type.GetJavaName());
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
                    string __tmp42Line = " "; //135:76
                    if (__tmp42Line != null) __out.Append(__tmp42Line);
                    StringBuilder __tmp43 = new StringBuilder();
                    __tmp43.Append(id.Name.ToString().ToCamelCase());
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
                    string __tmp44Line = ") {"; //135:111
                    if (__tmp44Line != null) __out.Append(__tmp44Line);
                    __out.AppendLine(false); //135:114
                    string __tmp46Line = "		this."; //136:1
                    if (__tmp46Line != null) __out.Append(__tmp46Line);
                    StringBuilder __tmp47 = new StringBuilder();
                    __tmp47.Append(id.Name.ToString().ToCamelCase());
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
                    string __tmp48Line = " = "; //136:42
                    if (__tmp48Line != null) __out.Append(__tmp48Line);
                    StringBuilder __tmp49 = new StringBuilder();
                    __tmp49.Append(id.Name.ToString().ToCamelCase());
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
                    string __tmp50Line = ";"; //136:79
                    if (__tmp50Line != null) __out.Append(__tmp50Line);
                    __out.AppendLine(false); //136:80
                    __out.Append("	}"); //137:1
                    __out.AppendLine(false); //137:3
                }
            }
            else //139:2
            {
                string __tmp52Line = "	public Long get"; //140:1
                if (__tmp52Line != null) __out.Append(__tmp52Line);
                StringBuilder __tmp53 = new StringBuilder();
                __tmp53.Append(sType.Name.ToString().ToPascalCase());
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
                string __tmp54Line = "Id() {"; //140:55
                if (__tmp54Line != null) __out.Append(__tmp54Line);
                __out.AppendLine(false); //140:61
                string __tmp56Line = "		return this."; //141:1
                if (__tmp56Line != null) __out.Append(__tmp56Line);
                StringBuilder __tmp57 = new StringBuilder();
                __tmp57.Append(sType.Name.ToString().ToCamelCase());
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
                string __tmp58Line = "Id;"; //141:52
                if (__tmp58Line != null) __out.Append(__tmp58Line);
                __out.AppendLine(false); //141:55
                __out.Append("	}"); //142:1
                __out.AppendLine(false); //142:3
                __out.AppendLine(true); //144:2
                string __tmp60Line = "	public void set"; //145:1
                if (__tmp60Line != null) __out.Append(__tmp60Line);
                StringBuilder __tmp61 = new StringBuilder();
                __tmp61.Append(sType.Name.ToString().ToPascalCase());
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
                string __tmp62Line = "Id(Long "; //145:55
                if (__tmp62Line != null) __out.Append(__tmp62Line);
                StringBuilder __tmp63 = new StringBuilder();
                __tmp63.Append(sType.Name.ToString().ToCamelCase());
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
                string __tmp64Line = "Id) {"; //145:100
                if (__tmp64Line != null) __out.Append(__tmp64Line);
                __out.AppendLine(false); //145:105
                string __tmp66Line = "		this."; //146:1
                if (__tmp66Line != null) __out.Append(__tmp66Line);
                StringBuilder __tmp67 = new StringBuilder();
                __tmp67.Append(sType.Name.ToString().ToCamelCase());
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
                string __tmp68Line = "Id = "; //146:45
                if (__tmp68Line != null) __out.Append(__tmp68Line);
                StringBuilder __tmp69 = new StringBuilder();
                __tmp69.Append(sType.Name.ToString().ToCamelCase());
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
                string __tmp70Line = "Id;"; //146:87
                if (__tmp70Line != null) __out.Append(__tmp70Line);
                __out.AppendLine(false); //146:90
                __out.Append("	}"); //147:1
                __out.AppendLine(false); //147:3
            }
            var __loop10_results = 
                (from __loop10_var1 in __Enumerate((sType).GetEnumerator()) //150:8
                from prop in __Enumerate((__loop10_var1.Properties).GetEnumerator()) //150:15
                where !prop.Name.EndsWith("Id") //150:31
                select new { __loop10_var1 = __loop10_var1, prop = prop}
                ).ToList(); //150:2
            int __loop10_iteration = 0;
            foreach (var __tmp71 in __loop10_results)
            {
                ++__loop10_iteration;
                var __loop10_var1 = __tmp71.__loop10_var1;
                var prop = __tmp71.prop;
                string __tmp72Prefix = "	"; //151:1
                StringBuilder __tmp73 = new StringBuilder();
                __tmp73.Append(SpringGeneratorUtil.GenerateGetter(prop));
                using(StreamReader __tmp73Reader = new StreamReader(this.__ToStream(__tmp73.ToString())))
                {
                    bool __tmp73_first = true;
                    bool __tmp73_last = __tmp73Reader.EndOfStream;
                    while(__tmp73_first || !__tmp73_last)
                    {
                        __tmp73_first = false;
                        string __tmp73Line = __tmp73Reader.ReadLine();
                        __tmp73_last = __tmp73Reader.EndOfStream;
                        __out.Append(__tmp72Prefix);
                        if (__tmp73Line != null) __out.Append(__tmp73Line);
                        if (!__tmp73_last) __out.AppendLine(true);
                        __out.AppendLine(false); //151:44
                    }
                }
                string __tmp74Prefix = "	"; //152:1
                StringBuilder __tmp75 = new StringBuilder();
                __tmp75.Append(SpringGeneratorUtil.GenerateSetter(prop));
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
                        __out.AppendLine(false); //152:44
                    }
                }
            }
            __out.Append("}"); //155:1
            __out.AppendLine(false); //155:2
            return __out.ToString();
        }

        public string GenerateComponent(Component component) //160:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp2Line = "package "; //161:1
            if (__tmp2Line != null) __out.Append(__tmp2Line);
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(SpringGeneratorUtil.GetPackage(component));
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
            string __tmp4Line = "."; //161:52
            if (__tmp4Line != null) __out.Append(__tmp4Line);
            StringBuilder __tmp5 = new StringBuilder();
            __tmp5.Append(SpringGeneratorUtil.Properties.serviceFacadePackage);
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
            string __tmp6Line = ";"; //161:106
            if (__tmp6Line != null) __out.Append(__tmp6Line);
            __out.AppendLine(false); //161:107
            __out.AppendLine(true); //162:1
            string __tmp8Line = "//import "; //163:1
            if (__tmp8Line != null) __out.Append(__tmp8Line);
            StringBuilder __tmp9 = new StringBuilder();
            __tmp9.Append(SpringGeneratorUtil.GetPackage(component));
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
            string __tmp10Line = ".util.ListUtil; TODO"; //163:53
            if (__tmp10Line != null) __out.Append(__tmp10Line);
            __out.AppendLine(false); //163:73
            __out.Append("import org.springframework.beans.factory.annotation.Autowired;"); //164:1
            __out.AppendLine(false); //164:63
            __out.Append("import org.springframework.stereotype.Service;"); //165:1
            __out.AppendLine(false); //165:47
            __out.AppendLine(true); //166:1
            StringBuilder __tmp12 = new StringBuilder();
            __tmp12.Append(SpringGeneratorUtil.GenerateImports(component));
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
                    __out.AppendLine(false); //167:49
                }
            }
            var __loop11_results = 
                (from __loop11_var1 in __Enumerate((component).GetEnumerator()) //168:8
                from reference in __Enumerate((__loop11_var1.References).GetEnumerator()) //168:19
                select new { __loop11_var1 = __loop11_var1, reference = reference}
                ).ToList(); //168:2
            int __loop11_iteration = 0;
            foreach (var __tmp13 in __loop11_results)
            {
                ++__loop11_iteration;
                var __loop11_var1 = __tmp13.__loop11_var1;
                var reference = __tmp13.reference;
                string __tmp15Line = "import "; //169:1
                if (__tmp15Line != null) __out.Append(__tmp15Line);
                StringBuilder __tmp16 = new StringBuilder();
                __tmp16.Append(SpringGeneratorUtil.GetPackage(reference.Interface));
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
                string __tmp17Line = "."; //169:61
                if (__tmp17Line != null) __out.Append(__tmp17Line);
                StringBuilder __tmp18 = new StringBuilder();
                __tmp18.Append(SpringGeneratorUtil.Properties.interfacePackage);
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
                string __tmp19Line = "."; //169:111
                if (__tmp19Line != null) __out.Append(__tmp19Line);
                StringBuilder __tmp20 = new StringBuilder();
                __tmp20.Append(reference.Interface.Name);
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
                __tmp21.Append(SpringGeneratorUtil.GetBindingType(reference));
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
                string __tmp22Line = ";"; //169:185
                if (__tmp22Line != null) __out.Append(__tmp22Line);
                __out.AppendLine(false); //169:186
            }
            __out.AppendLine(true); //171:1
            __out.Append("@Service"); //172:1
            __out.AppendLine(false); //172:9
            string __tmp24Line = "public class "; //173:1
            if (__tmp24Line != null) __out.Append(__tmp24Line);
            StringBuilder __tmp25 = new StringBuilder();
            __tmp25.Append(component.Name);
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
            string __tmp26Line = "Facade {"; //173:30
            if (__tmp26Line != null) __out.Append(__tmp26Line);
            __out.AppendLine(false); //173:38
            __out.AppendLine(true); //174:1
            var __loop12_results = 
                (from __loop12_var1 in __Enumerate((component).GetEnumerator()) //175:8
                from repo in __Enumerate((__loop12_var1.GetRepositories()).GetEnumerator()) //175:19
                select new { __loop12_var1 = __loop12_var1, repo = repo}
                ).ToList(); //175:2
            int __loop12_iteration = 0;
            foreach (var __tmp27 in __loop12_results)
            {
                ++__loop12_iteration;
                var __loop12_var1 = __tmp27.__loop12_var1;
                var repo = __tmp27.repo;
                __out.Append("	@Autowired"); //176:1
                __out.AppendLine(false); //176:12
                string __tmp28Prefix = "	"; //177:1
                StringBuilder __tmp29 = new StringBuilder();
                __tmp29.Append(repo);
                using(StreamReader __tmp29Reader = new StreamReader(this.__ToStream(__tmp29.ToString())))
                {
                    bool __tmp29_first = true;
                    bool __tmp29_last = __tmp29Reader.EndOfStream;
                    while(__tmp29_first || !__tmp29_last)
                    {
                        __tmp29_first = false;
                        string __tmp29Line = __tmp29Reader.ReadLine();
                        __tmp29_last = __tmp29Reader.EndOfStream;
                        __out.Append(__tmp28Prefix);
                        if (__tmp29Line != null) __out.Append(__tmp29Line);
                        if (!__tmp29_last) __out.AppendLine(true);
                    }
                }
                string __tmp30Line = ";"; //177:8
                if (__tmp30Line != null) __out.Append(__tmp30Line);
                __out.AppendLine(false); //177:9
                __out.AppendLine(true); //178:1
            }
            var __loop13_results = 
                (from __loop13_var1 in __Enumerate((component).GetEnumerator()) //181:8
                from reference in __Enumerate((__loop13_var1.References).GetEnumerator()) //181:19
                select new { __loop13_var1 = __loop13_var1, reference = reference}
                ).ToList(); //181:2
            int __loop13_iteration = 0;
            foreach (var __tmp31 in __loop13_results)
            {
                ++__loop13_iteration;
                var __loop13_var1 = __tmp31.__loop13_var1;
                var reference = __tmp31.reference;
                __out.Append("	@Autowired"); //182:1
                __out.AppendLine(false); //182:12
                string __tmp33Line = "	private "; //183:1
                if (__tmp33Line != null) __out.Append(__tmp33Line);
                StringBuilder __tmp34 = new StringBuilder();
                __tmp34.Append(reference.Interface.Name);
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
                StringBuilder __tmp35 = new StringBuilder();
                __tmp35.Append(SpringGeneratorUtil.GetBindingType(reference));
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
                string __tmp36Line = " "; //183:83
                if (__tmp36Line != null) __out.Append(__tmp36Line);
                StringBuilder __tmp37 = new StringBuilder();
                __tmp37.Append(reference.Name.ToCamelCase());
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
                string __tmp38Line = ";"; //183:114
                if (__tmp38Line != null) __out.Append(__tmp38Line);
                __out.AppendLine(false); //183:115
                __out.AppendLine(true); //184:2
            }
            var __loop14_results = 
                (from __loop14_var1 in __Enumerate((component).GetEnumerator()) //187:7
                from s in __Enumerate((__loop14_var1.Services).GetEnumerator()) //187:18
                select new { __loop14_var1 = __loop14_var1, s = s}
                ).ToList(); //187:2
            int __loop14_iteration = 0;
            foreach (var __tmp39 in __loop14_results)
            {
                ++__loop14_iteration;
                var __loop14_var1 = __tmp39.__loop14_var1;
                var s = __tmp39.s;
                Interface i = s.Interface; //188:2
                string __tmp41Line = "	//operations of "; //189:1
                if (__tmp41Line != null) __out.Append(__tmp41Line);
                StringBuilder __tmp42 = new StringBuilder();
                __tmp42.Append(i.Name);
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
                        __out.AppendLine(false); //189:26
                    }
                }
                var __loop15_results = 
                    (from __loop15_var1 in __Enumerate((i).GetEnumerator()) //190:9
                    from op in __Enumerate((__loop15_var1.Operations).GetEnumerator()) //190:12
                    select new { __loop15_var1 = __loop15_var1, op = op}
                    ).ToList(); //190:4
                int __loop15_iteration = 0;
                foreach (var __tmp43 in __loop15_results)
                {
                    ++__loop15_iteration;
                    var __loop15_var1 = __tmp43.__loop15_var1;
                    var op = __tmp43.op;
                    string __tmp45Line = "	public "; //191:1
                    if (__tmp45Line != null) __out.Append(__tmp45Line);
                    StringBuilder __tmp46 = new StringBuilder();
                    __tmp46.Append(op.Result.Type.GetJavaName());
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
                    string __tmp47Line = " "; //191:39
                    if (__tmp47Line != null) __out.Append(__tmp47Line);
                    StringBuilder __tmp48 = new StringBuilder();
                    __tmp48.Append(op.Name.ToCamelCase());
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
                    string __tmp49Line = "("; //191:63
                    if (__tmp49Line != null) __out.Append(__tmp49Line);
                    StringBuilder __tmp50 = new StringBuilder();
                    __tmp50.Append(SpringGeneratorUtil.GetParameterList(op));
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
                    string __tmp51Line = ") {"; //191:106
                    if (__tmp51Line != null) __out.Append(__tmp51Line);
                    __out.AppendLine(false); //191:109
                    __out.Append("		// TODO implement method"); //192:1
                    __out.AppendLine(false); //192:27
                    __out.Append("		throw new UnsupportedOperationException(\"Not yet implemented.\");"); //193:1
                    __out.AppendLine(false); //193:67
                    __out.Append("	}"); //194:1
                    __out.AppendLine(false); //194:3
                    __out.AppendLine(true); //195:2
                }
            }
            __out.Append("}"); //198:1
            __out.AppendLine(false); //198:2
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
