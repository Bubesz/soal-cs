using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Soal //1:1
{
    using __Hidden_SpringGenerator_2123174816;
    namespace __Hidden_SpringGenerator_2123174816
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

        private XsdGenerator XsdGenerator = new XsdGenerator(); //4:1

        public __Properties Properties { get; private set; } //6:1

        public class __Properties //6:1
        {
            internal __Properties()
            {
                this.SingleFileWsdl = false; //7:24
                this.SeparateXsdWsdl = false; //8:25
            }
            public bool SingleFileWsdl { get; set; } //7:2
            public bool SeparateXsdWsdl { get; set; } //8:2
        }

        public string GenerateInterface(Interface iface) //11:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp1Prefix = string.Empty; 
            string __tmp2Suffix = ".interface;"; //12:23
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(GetPackageRow(iface));
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
                    __out.AppendLine(); //12:34
                }
            }
            __out.AppendLine(); //13:1
            string __tmp4Prefix = "public interface "; //14:1
            string __tmp5Suffix = " {"; //14:30
            StringBuilder __tmp6 = new StringBuilder();
            __tmp6.Append(iface.Name);
            using(StreamReader __tmp6Reader = new StreamReader(this.__ToStream(__tmp6.ToString())))
            {
                bool __tmp6_first = true;
                while(__tmp6_first || !__tmp6Reader.EndOfStream)
                {
                    __tmp6_first = false;
                    string __tmp6Line = __tmp6Reader.ReadLine();
                    if (__tmp6Line == null)
                    {
                        __tmp6Line = "";
                    }
                    __out.Append(__tmp4Prefix);
                    __out.Append(__tmp6Line);
                    __out.Append(__tmp5Suffix);
                    __out.AppendLine(); //14:32
                }
            }
            var __loop1_results = 
                (from __loop1_var1 in __Enumerate((iface).GetEnumerator()) //15:8
                from op in __Enumerate((__loop1_var1.Operations).GetEnumerator()) //15:15
                select new { __loop1_var1 = __loop1_var1, op = op}
                ).ToList(); //15:2
            int __loop1_iteration = 0;
            foreach (var __tmp7 in __loop1_results)
            {
                ++__loop1_iteration;
                var __loop1_var1 = __tmp7.__loop1_var1;
                var op = __tmp7.op;
                string __tmp8Prefix = "	"; //16:1
                string __tmp9Suffix = ");"; //16:64
                StringBuilder __tmp10 = new StringBuilder();
                __tmp10.Append(op.ReturnType.GetJavaName());
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
                        __out.Append(__tmp8Prefix);
                        __out.Append(__tmp10Line);
                    }
                }
                string __tmp11Line = " "; //16:31
                __out.Append(__tmp11Line);
                StringBuilder __tmp12 = new StringBuilder();
                __tmp12.Append(op.Name);
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
                    }
                }
                string __tmp13Line = "("; //16:41
                __out.Append(__tmp13Line);
                StringBuilder __tmp14 = new StringBuilder();
                __tmp14.Append(GetParameterList(op));
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
                        __out.Append(__tmp9Suffix);
                        __out.AppendLine(); //16:66
                    }
                }
            }
            __out.Append("}"); //18:1
            __out.AppendLine(); //18:2
            return __out.ToString();
        }

        public string GenerateEnum(Enum myEnum) //21:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp1Prefix = string.Empty; 
            string __tmp2Suffix = ".enum;"; //22:24
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(GetPackageRow(myEnum));
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
                    __out.AppendLine(); //22:30
                }
            }
            __out.AppendLine(); //23:1
            string __tmp4Prefix = "public enum "; //24:1
            string __tmp5Suffix = " {"; //24:26
            StringBuilder __tmp6 = new StringBuilder();
            __tmp6.Append(myEnum.Name);
            using(StreamReader __tmp6Reader = new StreamReader(this.__ToStream(__tmp6.ToString())))
            {
                bool __tmp6_first = true;
                while(__tmp6_first || !__tmp6Reader.EndOfStream)
                {
                    __tmp6_first = false;
                    string __tmp6Line = __tmp6Reader.ReadLine();
                    if (__tmp6Line == null)
                    {
                        __tmp6Line = "";
                    }
                    __out.Append(__tmp4Prefix);
                    __out.Append(__tmp6Line);
                    __out.Append(__tmp5Suffix);
                    __out.AppendLine(); //24:28
                }
            }
            var __loop2_results = 
                (from __loop2_var1 in __Enumerate((myEnum).GetEnumerator()) //25:8
                from literal in __Enumerate((__loop2_var1.EnumLiterals).GetEnumerator()) //25:16
                select new { __loop2_var1 = __loop2_var1, literal = literal}
                ).ToList(); //25:2
            int __loop2_iteration = 0;
            string delimiter = ""; //25:38
            foreach (var __tmp7 in __loop2_results)
            {
                ++__loop2_iteration;
                if (__loop2_iteration >= 2) //25:59
                {
                    delimiter = ", "; //25:59
                }
                var __loop2_var1 = __tmp7.__loop2_var1;
                var literal = __tmp7.literal;
                string __tmp8Prefix = "	"; //26:1
                string __tmp9Suffix = string.Empty; 
                StringBuilder __tmp10 = new StringBuilder();
                __tmp10.Append(delimiter);
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
                        __out.Append(__tmp8Prefix);
                        __out.Append(__tmp10Line);
                    }
                }
                StringBuilder __tmp11 = new StringBuilder();
                __tmp11.Append(literal);
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
                        __out.Append(__tmp9Suffix);
                        __out.AppendLine(); //26:22
                    }
                }
            }
            __out.Append("}"); //28:1
            __out.AppendLine(); //28:2
            return __out.ToString();
        }

        public string GenerateEntity(StructuredType sType) //31:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp1Prefix = string.Empty; 
            string __tmp2Suffix = ".entity;"; //32:23
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(GetPackageRow(sType));
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
                    __out.AppendLine(); //32:31
                }
            }
            __out.AppendLine(); //33:1
            if (sType is Entity) //34:3
            {
                __out.Append("import javax.persistence.*;"); //35:1
                __out.AppendLine(); //35:28
                __out.AppendLine(); //36:1
                __out.Append("@Entity"); //37:1
                __out.AppendLine(); //37:8
            }
            string __tmp4Prefix = "public class "; //39:1
            string __tmp5Suffix = " {"; //39:26
            StringBuilder __tmp6 = new StringBuilder();
            __tmp6.Append(sType.Name);
            using(StreamReader __tmp6Reader = new StreamReader(this.__ToStream(__tmp6.ToString())))
            {
                bool __tmp6_first = true;
                while(__tmp6_first || !__tmp6Reader.EndOfStream)
                {
                    __tmp6_first = false;
                    string __tmp6Line = __tmp6Reader.ReadLine();
                    if (__tmp6Line == null)
                    {
                        __tmp6Line = "";
                    }
                    __out.Append(__tmp4Prefix);
                    __out.Append(__tmp6Line);
                    __out.Append(__tmp5Suffix);
                    __out.AppendLine(); //39:28
                }
            }
            int ids = GetNumberOfFieldWithIdSuffix(sType); //41:2
            if (ids != 1) //42:2
            {
                __out.AppendLine(); //43:2
                if (sType is Entity) //44:4
                {
                    __out.Append("	@Id"); //45:1
                    __out.AppendLine(); //45:5
                    __out.Append("	@GeneratedValue"); //46:1
                    __out.AppendLine(); //46:17
                }
                string __tmp7Prefix = "	private Long "; //48:1
                string __tmp8Suffix = "Id;"; //48:52
                StringBuilder __tmp9 = new StringBuilder();
                __tmp9.Append(sType.Name.ToString().ToCamelCase());
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
                        __out.Append(__tmp7Prefix);
                        __out.Append(__tmp9Line);
                        __out.Append(__tmp8Suffix);
                        __out.AppendLine(); //48:55
                    }
                }
            }
            var __loop3_results = 
                (from __loop3_var1 in __Enumerate((sType).GetEnumerator()) //51:8
                from prop in __Enumerate((__loop3_var1.Properties).GetEnumerator()) //51:15
                select new { __loop3_var1 = __loop3_var1, prop = prop}
                ).ToList(); //51:2
            int __loop3_iteration = 0;
            foreach (var __tmp10 in __loop3_results)
            {
                ++__loop3_iteration;
                var __loop3_var1 = __tmp10.__loop3_var1;
                var prop = __tmp10.prop;
                __out.AppendLine(); //52:2
                if (sType is Entity && ids == 1 && prop.Name.ToString().EndsWith("Id")) //53:4
                {
                    __out.Append("	@Id"); //54:1
                    __out.AppendLine(); //54:5
                    __out.Append("	@GeneratedValue"); //55:1
                    __out.AppendLine(); //55:17
                }
                string __tmp11Prefix = "	private "; //57:1
                string __tmp12Suffix = ";"; //57:72
                StringBuilder __tmp13 = new StringBuilder();
                __tmp13.Append(prop.Type.GetJavaName());
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
                string __tmp14Line = " "; //57:35
                __out.Append(__tmp14Line);
                StringBuilder __tmp15 = new StringBuilder();
                __tmp15.Append(prop.Name.ToString().ToCamelCase());
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
                        __out.AppendLine(); //57:73
                    }
                }
            }
            __out.AppendLine(); //61:2
            if (ids == 1) //62:2
            {
                var __loop4_results = 
                    (from __loop4_var1 in __Enumerate((sType).GetEnumerator()) //63:10
                    from id in __Enumerate((__loop4_var1.Properties).GetEnumerator()) //63:17
                    where id.Name.EndsWith("Id") //63:31
                    select new { __loop4_var1 = __loop4_var1, id = id}
                    ).ToList(); //63:4
                int __loop4_iteration = 0;
                foreach (var __tmp16 in __loop4_results)
                {
                    ++__loop4_iteration;
                    var __loop4_var1 = __tmp16.__loop4_var1;
                    var id = __tmp16.id;
                    string __tmp17Prefix = "	public "; //64:1
                    string __tmp18Suffix = "() {"; //64:71
                    StringBuilder __tmp19 = new StringBuilder();
                    __tmp19.Append(id.Type.GetJavaName());
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
                    string __tmp20Line = " get"; //64:32
                    __out.Append(__tmp20Line);
                    StringBuilder __tmp21 = new StringBuilder();
                    __tmp21.Append(id.Name.ToString().ToPascalCase());
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
                            __out.Append(__tmp18Suffix);
                            __out.AppendLine(); //64:75
                        }
                    }
                    string __tmp22Prefix = "		return this."; //65:1
                    string __tmp23Suffix = ";"; //65:49
                    StringBuilder __tmp24 = new StringBuilder();
                    __tmp24.Append(id.Name.ToString().ToCamelCase());
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
                            __out.Append(__tmp23Suffix);
                            __out.AppendLine(); //65:50
                        }
                    }
                    __out.Append("	}"); //66:1
                    __out.AppendLine(); //66:3
                    __out.AppendLine(); //67:2
                    string __tmp25Prefix = "	public void set"; //68:1
                    string __tmp26Suffix = ") {"; //68:111
                    StringBuilder __tmp27 = new StringBuilder();
                    __tmp27.Append(id.Name.ToString().ToPascalCase());
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
                    string __tmp28Line = "("; //68:52
                    __out.Append(__tmp28Line);
                    StringBuilder __tmp29 = new StringBuilder();
                    __tmp29.Append(id.Type.GetJavaName());
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
                        }
                    }
                    string __tmp30Line = " "; //68:76
                    __out.Append(__tmp30Line);
                    StringBuilder __tmp31 = new StringBuilder();
                    __tmp31.Append(id.Name.ToString().ToCamelCase());
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
                            __out.Append(__tmp26Suffix);
                            __out.AppendLine(); //68:114
                        }
                    }
                    string __tmp32Prefix = "		this."; //69:1
                    string __tmp33Suffix = ";"; //69:79
                    StringBuilder __tmp34 = new StringBuilder();
                    __tmp34.Append(id.Name.ToString().ToCamelCase());
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
                            __out.Append(__tmp32Prefix);
                            __out.Append(__tmp34Line);
                        }
                    }
                    string __tmp35Line = " = "; //69:42
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
                            __out.Append(__tmp33Suffix);
                            __out.AppendLine(); //69:80
                        }
                    }
                    __out.Append("	}"); //70:1
                    __out.AppendLine(); //70:3
                }
            }
            else //72:2
            {
                string __tmp37Prefix = "	public Long get"; //73:1
                string __tmp38Suffix = "Id() {"; //73:55
                StringBuilder __tmp39 = new StringBuilder();
                __tmp39.Append(sType.Name.ToString().ToPascalCase());
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
                        __out.Append(__tmp38Suffix);
                        __out.AppendLine(); //73:61
                    }
                }
                string __tmp40Prefix = "		return this."; //74:1
                string __tmp41Suffix = "Id;"; //74:52
                StringBuilder __tmp42 = new StringBuilder();
                __tmp42.Append(sType.Name.ToString().ToCamelCase());
                using(StreamReader __tmp42Reader = new StreamReader(this.__ToStream(__tmp42.ToString())))
                {
                    bool __tmp42_first = true;
                    while(__tmp42_first || !__tmp42Reader.EndOfStream)
                    {
                        __tmp42_first = false;
                        string __tmp42Line = __tmp42Reader.ReadLine();
                        if (__tmp42Line == null)
                        {
                            __tmp42Line = "";
                        }
                        __out.Append(__tmp40Prefix);
                        __out.Append(__tmp42Line);
                        __out.Append(__tmp41Suffix);
                        __out.AppendLine(); //74:55
                    }
                }
                __out.Append("	}"); //75:1
                __out.AppendLine(); //75:3
                __out.AppendLine(); //77:2
                string __tmp43Prefix = "	public void set"; //78:1
                string __tmp44Suffix = "Id) {"; //78:100
                StringBuilder __tmp45 = new StringBuilder();
                __tmp45.Append(sType.Name.ToString().ToPascalCase());
                using(StreamReader __tmp45Reader = new StreamReader(this.__ToStream(__tmp45.ToString())))
                {
                    bool __tmp45_first = true;
                    while(__tmp45_first || !__tmp45Reader.EndOfStream)
                    {
                        __tmp45_first = false;
                        string __tmp45Line = __tmp45Reader.ReadLine();
                        if (__tmp45Line == null)
                        {
                            __tmp45Line = "";
                        }
                        __out.Append(__tmp43Prefix);
                        __out.Append(__tmp45Line);
                    }
                }
                string __tmp46Line = "Id(Long "; //78:55
                __out.Append(__tmp46Line);
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
                        __out.Append(__tmp47Line);
                        __out.Append(__tmp44Suffix);
                        __out.AppendLine(); //78:105
                    }
                }
                string __tmp48Prefix = "		this."; //79:1
                string __tmp49Suffix = "Id;"; //79:87
                StringBuilder __tmp50 = new StringBuilder();
                __tmp50.Append(sType.Name.ToString().ToCamelCase());
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
                string __tmp51Line = "Id = "; //79:45
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
                        __out.AppendLine(); //79:90
                    }
                }
                __out.Append("	}"); //80:1
                __out.AppendLine(); //80:3
            }
            var __loop5_results = 
                (from __loop5_var1 in __Enumerate((sType).GetEnumerator()) //83:8
                from prop in __Enumerate((__loop5_var1.Properties).GetEnumerator()) //83:15
                where !prop.Name.EndsWith("Id") //83:31
                select new { __loop5_var1 = __loop5_var1, prop = prop}
                ).ToList(); //83:2
            int __loop5_iteration = 0;
            foreach (var __tmp53 in __loop5_results)
            {
                ++__loop5_iteration;
                var __loop5_var1 = __tmp53.__loop5_var1;
                var prop = __tmp53.prop;
                string __tmp54Prefix = "	"; //84:1
                string __tmp55Suffix = string.Empty; 
                StringBuilder __tmp56 = new StringBuilder();
                __tmp56.Append(GenerateGetter(prop));
                using(StreamReader __tmp56Reader = new StreamReader(this.__ToStream(__tmp56.ToString())))
                {
                    bool __tmp56_first = true;
                    while(__tmp56_first || !__tmp56Reader.EndOfStream)
                    {
                        __tmp56_first = false;
                        string __tmp56Line = __tmp56Reader.ReadLine();
                        if (__tmp56Line == null)
                        {
                            __tmp56Line = "";
                        }
                        __out.Append(__tmp54Prefix);
                        __out.Append(__tmp56Line);
                        __out.Append(__tmp55Suffix);
                        __out.AppendLine(); //84:24
                    }
                }
                string __tmp57Prefix = "	"; //85:1
                string __tmp58Suffix = string.Empty; 
                StringBuilder __tmp59 = new StringBuilder();
                __tmp59.Append(GenerateSetter(prop));
                using(StreamReader __tmp59Reader = new StreamReader(this.__ToStream(__tmp59.ToString())))
                {
                    bool __tmp59_first = true;
                    while(__tmp59_first || !__tmp59Reader.EndOfStream)
                    {
                        __tmp59_first = false;
                        string __tmp59Line = __tmp59Reader.ReadLine();
                        if (__tmp59Line == null)
                        {
                            __tmp59Line = "";
                        }
                        __out.Append(__tmp57Prefix);
                        __out.Append(__tmp59Line);
                        __out.Append(__tmp58Suffix);
                        __out.AppendLine(); //85:24
                    }
                }
            }
            __out.Append("}"); //88:1
            __out.AppendLine(); //88:2
            return __out.ToString();
        }

        public string GenerateException(Exception ex) //91:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp1Prefix = string.Empty; 
            string __tmp2Suffix = ".exception;"; //92:20
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(GetPackageRow(ex));
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
                    __out.AppendLine(); //92:31
                }
            }
            __out.AppendLine(); //93:1
            string __tmp4Prefix = "public class "; //94:1
            string __tmp5Suffix = " extends Exception {"; //94:23
            StringBuilder __tmp6 = new StringBuilder();
            __tmp6.Append(ex.Name);
            using(StreamReader __tmp6Reader = new StreamReader(this.__ToStream(__tmp6.ToString())))
            {
                bool __tmp6_first = true;
                while(__tmp6_first || !__tmp6Reader.EndOfStream)
                {
                    __tmp6_first = false;
                    string __tmp6Line = __tmp6Reader.ReadLine();
                    if (__tmp6Line == null)
                    {
                        __tmp6Line = "";
                    }
                    __out.Append(__tmp4Prefix);
                    __out.Append(__tmp6Line);
                    __out.Append(__tmp5Suffix);
                    __out.AppendLine(); //94:43
                }
            }
            var __loop6_results = 
                (from __loop6_var1 in __Enumerate((ex).GetEnumerator()) //96:8
                from prop in __Enumerate((__loop6_var1.Properties).GetEnumerator()) //96:12
                select new { __loop6_var1 = __loop6_var1, prop = prop}
                ).ToList(); //96:2
            int __loop6_iteration = 0;
            foreach (var __tmp7 in __loop6_results)
            {
                ++__loop6_iteration;
                var __loop6_var1 = __tmp7.__loop6_var1;
                var prop = __tmp7.prop;
                __out.AppendLine(); //97:2
                string __tmp8Prefix = "	private "; //98:1
                string __tmp9Suffix = ";"; //98:72
                StringBuilder __tmp10 = new StringBuilder();
                __tmp10.Append(prop.Type.GetJavaName());
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
                        __out.Append(__tmp8Prefix);
                        __out.Append(__tmp10Line);
                    }
                }
                string __tmp11Line = " "; //98:35
                __out.Append(__tmp11Line);
                StringBuilder __tmp12 = new StringBuilder();
                __tmp12.Append(prop.Name.ToString().ToCamelCase());
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
                        __out.Append(__tmp9Suffix);
                        __out.AppendLine(); //98:73
                    }
                }
            }
            __out.AppendLine(); //101:2
            string __tmp13Prefix = "	public "; //102:1
            string __tmp14Suffix = ") {"; //102:40
            StringBuilder __tmp15 = new StringBuilder();
            __tmp15.Append(ex.Name);
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
            string __tmp16Line = "("; //102:18
            __out.Append(__tmp16Line);
            StringBuilder __tmp17 = new StringBuilder();
            __tmp17.Append(GetPropertyList(ex));
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
                    __out.AppendLine(); //102:43
                }
            }
            var __loop7_results = 
                (from __loop7_var1 in __Enumerate((ex).GetEnumerator()) //103:8
                from prop in __Enumerate((__loop7_var1.Properties).GetEnumerator()) //103:12
                select new { __loop7_var1 = __loop7_var1, prop = prop}
                ).ToList(); //103:2
            int __loop7_iteration = 0;
            foreach (var __tmp18 in __loop7_results)
            {
                ++__loop7_iteration;
                var __loop7_var1 = __tmp18.__loop7_var1;
                var prop = __tmp18.prop;
                string __tmp19Prefix = "		this."; //104:1
                string __tmp20Suffix = ";"; //104:83
                StringBuilder __tmp21 = new StringBuilder();
                __tmp21.Append(prop.Name.ToString().ToCamelCase());
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
                string __tmp22Line = " = "; //104:44
                __out.Append(__tmp22Line);
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
                        __out.Append(__tmp23Line);
                        __out.Append(__tmp20Suffix);
                        __out.AppendLine(); //104:84
                    }
                }
            }
            __out.Append("	}"); //106:1
            __out.AppendLine(); //106:3
            var __loop8_results = 
                (from __loop8_var1 in __Enumerate((ex).GetEnumerator()) //108:8
                from prop in __Enumerate((__loop8_var1.Properties).GetEnumerator()) //108:12
                select new { __loop8_var1 = __loop8_var1, prop = prop}
                ).ToList(); //108:2
            int __loop8_iteration = 0;
            foreach (var __tmp24 in __loop8_results)
            {
                ++__loop8_iteration;
                var __loop8_var1 = __tmp24.__loop8_var1;
                var prop = __tmp24.prop;
                string __tmp25Prefix = "	"; //109:1
                string __tmp26Suffix = string.Empty; 
                StringBuilder __tmp27 = new StringBuilder();
                __tmp27.Append(GenerateGetter(prop));
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
                        __out.Append(__tmp26Suffix);
                        __out.AppendLine(); //109:24
                    }
                }
            }
            __out.Append("}"); //112:1
            __out.AppendLine(); //112:2
            return __out.ToString();
        }

        public string GetParameterList(Operation op) //115:1
        {
            string result = ""; //116:5
            var __loop9_results = 
                (from __loop9_var1 in __Enumerate((op).GetEnumerator()) //117:11
                from param in __Enumerate((__loop9_var1.Parameters).GetEnumerator()) //117:15
                select new { __loop9_var1 = __loop9_var1, param = param}
                ).ToList(); //117:5
            int __loop9_iteration = 0;
            string delimiter = ""; //117:33
            foreach (var __tmp1 in __loop9_results)
            {
                ++__loop9_iteration;
                if (__loop9_iteration >= 2) //117:56
                {
                    delimiter = ", "; //117:56
                }
                var __loop9_var1 = __tmp1.__loop9_var1;
                var param = __tmp1.param;
                result = result + delimiter + param.Type.GetJavaName() + " " + param.Name.ToString().ToCamelCase(); //118:9
            }
            return result; //120:5
        }

        public string GetPropertyList(StructuredType sType) //123:1
        {
            string result = ""; //124:5
            var __loop10_results = 
                (from __loop10_var1 in __Enumerate((sType).GetEnumerator()) //125:11
                from p in __Enumerate((__loop10_var1.Properties).GetEnumerator()) //125:18
                select new { __loop10_var1 = __loop10_var1, p = p}
                ).ToList(); //125:5
            int __loop10_iteration = 0;
            string delimiter = ""; //125:32
            foreach (var __tmp1 in __loop10_results)
            {
                ++__loop10_iteration;
                if (__loop10_iteration >= 2) //125:55
                {
                    delimiter = ", "; //125:55
                }
                var __loop10_var1 = __tmp1.__loop10_var1;
                var p = __tmp1.p;
                result = result + delimiter + p.Type.GetJavaName() + " " + p.Name.ToString().ToCamelCase(); //126:9
            }
            return result; //128:5
        }

        public int GetNumberOfFieldWithIdSuffix(StructuredType sType) //131:1
        {
            int result = 0; //132:2
            var __loop11_results = 
                (from __loop11_var1 in __Enumerate((sType).GetEnumerator()) //133:8
                from p in __Enumerate((__loop11_var1.Properties).GetEnumerator()) //133:15
                select new { __loop11_var1 = __loop11_var1, p = p}
                ).ToList(); //133:2
            int __loop11_iteration = 0;
            foreach (var __tmp1 in __loop11_results)
            {
                ++__loop11_iteration;
                var __loop11_var1 = __tmp1.__loop11_var1;
                var p = __tmp1.p;
                if (p.Name.ToString().EndsWith("Id")) //134:3
                {
                    result++; //135:4
                }
            }
            return result; //138:5
        }

        public string GetPackageRow(Declaration d) //141:1
        {
            return "package " + d.Namespace.FullName.ToLower(); //142:1
        }

        public string GenerateGetter(Property prop) //145:1
        {
            StringBuilder __out = new StringBuilder();
            __out.AppendLine(); //146:1
            string __tmp1Prefix = "public "; //147:1
            string __tmp2Suffix = "() {"; //147:74
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(prop.Type.GetJavaName());
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
            string __tmp4Line = " get"; //147:33
            __out.Append(__tmp4Line);
            StringBuilder __tmp5 = new StringBuilder();
            __tmp5.Append(prop.Name.ToString().ToPascalCase());
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
                    __out.AppendLine(); //147:78
                }
            }
            string __tmp6Prefix = "	return this."; //148:1
            string __tmp7Suffix = ";"; //148:50
            StringBuilder __tmp8 = new StringBuilder();
            __tmp8.Append(prop.Name.ToString().ToCamelCase());
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
                    __out.AppendLine(); //148:51
                }
            }
            __out.Append("}"); //149:1
            __out.AppendLine(); //149:2
            return __out.ToString();
        }

        public string GenerateSetter(Property prop) //152:1
        {
            StringBuilder __out = new StringBuilder();
            __out.AppendLine(); //153:1
            string __tmp1Prefix = "public void set"; //154:1
            string __tmp2Suffix = ") {"; //154:116
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(prop.Name.ToString().ToPascalCase());
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
            string __tmp4Line = "("; //154:53
            __out.Append(__tmp4Line);
            StringBuilder __tmp5 = new StringBuilder();
            __tmp5.Append(prop.Type.GetJavaName());
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
                }
            }
            string __tmp6Line = " "; //154:79
            __out.Append(__tmp6Line);
            StringBuilder __tmp7 = new StringBuilder();
            __tmp7.Append(prop.Name.ToString().ToCamelCase());
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
                    __out.Append(__tmp7Line);
                    __out.Append(__tmp2Suffix);
                    __out.AppendLine(); //154:119
                }
            }
            string __tmp8Prefix = "	this."; //155:1
            string __tmp9Suffix = ";"; //155:82
            StringBuilder __tmp10 = new StringBuilder();
            __tmp10.Append(prop.Name.ToString().ToCamelCase());
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
                    __out.Append(__tmp8Prefix);
                    __out.Append(__tmp10Line);
                }
            }
            string __tmp11Line = " = "; //155:43
            __out.Append(__tmp11Line);
            StringBuilder __tmp12 = new StringBuilder();
            __tmp12.Append(prop.Name.ToString().ToCamelCase());
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
                    __out.Append(__tmp9Suffix);
                    __out.AppendLine(); //155:83
                }
            }
            __out.Append("}"); //156:1
            __out.AppendLine(); //156:2
            return __out.ToString();
        }

    }
}
