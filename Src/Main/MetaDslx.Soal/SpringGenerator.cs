using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Soal //1:1
{
    using __Hidden_SpringGenerator_2081094028;
    namespace __Hidden_SpringGenerator_2081094028
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

        public string Generate(Namespace ns) //11:1
        {
            StringBuilder __out = new StringBuilder();
            var __loop1_results = 
                (from ins in __Enumerate((ns.GetImportedNamespaces()).GetEnumerator()) //13:8
                select new { ins = ins}
                ).ToList(); //13:3
            int __loop1_iteration = 0;
            foreach (var __tmp1 in __loop1_results)
            {
                ++__loop1_iteration;
                var ins = __tmp1.ins;
            }
            return __out.ToString();
        }

        public string GenerateEntity(StructuredType sType) //20:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp1Prefix = "package "; //21:1
            string __tmp2Suffix = ".entity"; //21:35
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(sType.Namespace.FullName);
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
                    __out.AppendLine(); //21:42
                }
            }
            __out.AppendLine(); //22:1
            __out.Append("import javax.persistence.*;"); //23:1
            __out.AppendLine(); //23:28
            __out.AppendLine(); //24:1
            __out.Append("	"); //25:1
            if (!(sType is Exception)) //25:3
            {
                __out.Append(" //TODO is entity?"); //25:30
                __out.AppendLine(); //25:48
                __out.Append("@Entity"); //26:1
                __out.AppendLine(); //26:8
                string __tmp4Prefix = "public class "; //27:1
                string __tmp5Suffix = " {"; //27:26
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
                        __out.AppendLine(); //27:28
                    }
                }
            }
            else //28:3
            {
                string __tmp7Prefix = "public class "; //29:1
                string __tmp8Suffix = " extends Exception {"; //29:26
                StringBuilder __tmp9 = new StringBuilder();
                __tmp9.Append(sType.Name);
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
                        __out.AppendLine(); //29:46
                    }
                }
            }
            if (!(sType is Exception)) //32:2
            {
                __out.AppendLine(); //33:2
                __out.Append("	@Id"); //34:1
                __out.AppendLine(); //34:5
                __out.Append("	@GeneratedValue"); //35:1
                __out.AppendLine(); //35:17
                string __tmp10Prefix = "	private Long "; //36:1
                string __tmp11Suffix = "Id;"; //36:52
                StringBuilder __tmp12 = new StringBuilder();
                __tmp12.Append(sType.Name.ToString().ToCamelCase());
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
                        __out.AppendLine(); //36:55
                    }
                }
            }
            var __loop2_results = 
                (from __loop2_var1 in __Enumerate((sType).GetEnumerator()) //39:8
                from prop in __Enumerate((__loop2_var1.Properties).GetEnumerator()) //39:15
                select new { __loop2_var1 = __loop2_var1, prop = prop}
                ).ToList(); //39:2
            int __loop2_iteration = 0;
            foreach (var __tmp13 in __loop2_results)
            {
                ++__loop2_iteration;
                var __loop2_var1 = __tmp13.__loop2_var1;
                var prop = __tmp13.prop;
                __out.AppendLine(); //40:2
                string __tmp14Prefix = "	private "; //41:1
                string __tmp15Suffix = ";"; //41:72
                StringBuilder __tmp16 = new StringBuilder();
                __tmp16.Append(prop.Type.GetJavaName());
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
                        __out.Append(__tmp14Prefix);
                        __out.Append(__tmp16Line);
                    }
                }
                string __tmp17Line = " "; //41:35
                __out.Append(__tmp17Line);
                StringBuilder __tmp18 = new StringBuilder();
                __tmp18.Append(prop.Name.ToString().ToCamelCase());
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
                        __out.Append(__tmp18Line);
                        __out.Append(__tmp15Suffix);
                        __out.AppendLine(); //41:73
                    }
                }
            }
            if (sType is Exception) //44:2
            {
                __out.AppendLine(); //45:2
                string __tmp19Prefix = "	public "; //46:1
                string __tmp20Suffix = ") {"; //46:46
                StringBuilder __tmp21 = new StringBuilder();
                __tmp21.Append(sType.Name);
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
                string __tmp22Line = "("; //46:21
                __out.Append(__tmp22Line);
                StringBuilder __tmp23 = new StringBuilder();
                __tmp23.Append(GetPropertyList(sType));
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
                        __out.AppendLine(); //46:49
                    }
                }
                var __loop3_results = 
                    (from __loop3_var1 in __Enumerate((sType).GetEnumerator()) //47:8
                    from prop in __Enumerate((__loop3_var1.Properties).GetEnumerator()) //47:15
                    select new { __loop3_var1 = __loop3_var1, prop = prop}
                    ).ToList(); //47:2
                int __loop3_iteration = 0;
                foreach (var __tmp24 in __loop3_results)
                {
                    ++__loop3_iteration;
                    var __loop3_var1 = __tmp24.__loop3_var1;
                    var prop = __tmp24.prop;
                    string __tmp25Prefix = "		this."; //48:1
                    string __tmp26Suffix = ";"; //48:83
                    StringBuilder __tmp27 = new StringBuilder();
                    __tmp27.Append(prop.Name.ToString().ToCamelCase());
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
                    string __tmp28Line = " = "; //48:44
                    __out.Append(__tmp28Line);
                    StringBuilder __tmp29 = new StringBuilder();
                    __tmp29.Append(prop.Name.ToString().ToCamelCase());
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
                            __out.AppendLine(); //48:84
                        }
                    }
                }
                __out.Append("	}"); //50:1
                __out.AppendLine(); //50:3
            }
            if (sType is Struct) //55:2
            {
                __out.AppendLine(); //56:2
                if ((from __loop4_var1 in __Enumerate((sType).GetEnumerator()) //57:17
                from id in __Enumerate((__loop4_var1.Properties).GetEnumerator()) //57:24
                where id.Name.EndsWith("Id") //57:38
                select new { __loop4_var1 = __loop4_var1, id = id}
                ).GetEnumerator().MoveNext()) //57:4
                {
                    var __loop5_results = 
                        (from __loop5_var1 in __Enumerate((sType).GetEnumerator()) //58:11
                        from id in __Enumerate((__loop5_var1.Properties).GetEnumerator()) //58:18
                        where id.Name.EndsWith("Id") //58:32
                        select new { __loop5_var1 = __loop5_var1, id = id}
                        ).ToList(); //58:5
                    int __loop5_iteration = 0;
                    foreach (var __tmp30 in __loop5_results)
                    {
                        ++__loop5_iteration;
                        var __loop5_var1 = __tmp30.__loop5_var1;
                        var id = __tmp30.id;
                        string __tmp31Prefix = "	public "; //59:1
                        string __tmp32Suffix = "() {"; //59:71
                        StringBuilder __tmp33 = new StringBuilder();
                        __tmp33.Append(id.Type.GetJavaName());
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
                            }
                        }
                        string __tmp34Line = " get"; //59:32
                        __out.Append(__tmp34Line);
                        StringBuilder __tmp35 = new StringBuilder();
                        __tmp35.Append(id.Name.ToString().ToPascalCase());
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
                                __out.Append(__tmp35Line);
                                __out.Append(__tmp32Suffix);
                                __out.AppendLine(); //59:75
                            }
                        }
                        string __tmp36Prefix = "		return this."; //60:1
                        string __tmp37Suffix = ";"; //60:49
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
                                __out.Append(__tmp36Prefix);
                                __out.Append(__tmp38Line);
                                __out.Append(__tmp37Suffix);
                                __out.AppendLine(); //60:50
                            }
                        }
                        __out.Append("	}"); //61:1
                        __out.AppendLine(); //61:3
                        __out.AppendLine(); //62:2
                        string __tmp39Prefix = "	public void set"; //63:1
                        string __tmp40Suffix = ") {"; //63:111
                        StringBuilder __tmp41 = new StringBuilder();
                        __tmp41.Append(id.Name.ToString().ToPascalCase());
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
                            }
                        }
                        string __tmp42Line = "("; //63:52
                        __out.Append(__tmp42Line);
                        StringBuilder __tmp43 = new StringBuilder();
                        __tmp43.Append(id.Type.GetJavaName());
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
                            }
                        }
                        string __tmp44Line = " "; //63:76
                        __out.Append(__tmp44Line);
                        StringBuilder __tmp45 = new StringBuilder();
                        __tmp45.Append(id.Name.ToString().ToCamelCase());
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
                                __out.Append(__tmp45Line);
                                __out.Append(__tmp40Suffix);
                                __out.AppendLine(); //63:114
                            }
                        }
                        string __tmp46Prefix = "		this."; //64:1
                        string __tmp47Suffix = ";"; //64:79
                        StringBuilder __tmp48 = new StringBuilder();
                        __tmp48.Append(id.Name.ToString().ToCamelCase());
                        using(StreamReader __tmp48Reader = new StreamReader(this.__ToStream(__tmp48.ToString())))
                        {
                            bool __tmp48_first = true;
                            while(__tmp48_first || !__tmp48Reader.EndOfStream)
                            {
                                __tmp48_first = false;
                                string __tmp48Line = __tmp48Reader.ReadLine();
                                if (__tmp48Line == null)
                                {
                                    __tmp48Line = "";
                                }
                                __out.Append(__tmp46Prefix);
                                __out.Append(__tmp48Line);
                            }
                        }
                        string __tmp49Line = " = "; //64:42
                        __out.Append(__tmp49Line);
                        StringBuilder __tmp50 = new StringBuilder();
                        __tmp50.Append(id.Name.ToString().ToCamelCase());
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
                                __out.Append(__tmp50Line);
                                __out.Append(__tmp47Suffix);
                                __out.AppendLine(); //64:80
                            }
                        }
                        __out.Append("	}"); //65:1
                        __out.AppendLine(); //65:3
                    }
                }
                else //67:4
                {
                    string __tmp51Prefix = "	public Long get"; //68:1
                    string __tmp52Suffix = "Id() {"; //68:55
                    StringBuilder __tmp53 = new StringBuilder();
                    __tmp53.Append(sType.Name.ToString().ToPascalCase());
                    using(StreamReader __tmp53Reader = new StreamReader(this.__ToStream(__tmp53.ToString())))
                    {
                        bool __tmp53_first = true;
                        while(__tmp53_first || !__tmp53Reader.EndOfStream)
                        {
                            __tmp53_first = false;
                            string __tmp53Line = __tmp53Reader.ReadLine();
                            if (__tmp53Line == null)
                            {
                                __tmp53Line = "";
                            }
                            __out.Append(__tmp51Prefix);
                            __out.Append(__tmp53Line);
                            __out.Append(__tmp52Suffix);
                            __out.AppendLine(); //68:61
                        }
                    }
                    string __tmp54Prefix = "		return this."; //69:1
                    string __tmp55Suffix = "Id;"; //69:52
                    StringBuilder __tmp56 = new StringBuilder();
                    __tmp56.Append(sType.Name.ToString().ToCamelCase());
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
                            __out.AppendLine(); //69:55
                        }
                    }
                    __out.Append("	}"); //70:1
                    __out.AppendLine(); //70:3
                    __out.AppendLine(); //72:2
                    string __tmp57Prefix = "	public void set"; //73:1
                    string __tmp58Suffix = "Id) {"; //73:100
                    StringBuilder __tmp59 = new StringBuilder();
                    __tmp59.Append(sType.Name.ToString().ToPascalCase());
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
                        }
                    }
                    string __tmp60Line = "Id(Long "; //73:55
                    __out.Append(__tmp60Line);
                    StringBuilder __tmp61 = new StringBuilder();
                    __tmp61.Append(sType.Name.ToString().ToCamelCase());
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
                            __out.Append(__tmp61Line);
                            __out.Append(__tmp58Suffix);
                            __out.AppendLine(); //73:105
                        }
                    }
                    string __tmp62Prefix = "		this."; //74:1
                    string __tmp63Suffix = "Id;"; //74:87
                    StringBuilder __tmp64 = new StringBuilder();
                    __tmp64.Append(sType.Name.ToString().ToCamelCase());
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
                        }
                    }
                    string __tmp65Line = "Id = "; //74:45
                    __out.Append(__tmp65Line);
                    StringBuilder __tmp66 = new StringBuilder();
                    __tmp66.Append(sType.Name.ToString().ToCamelCase());
                    using(StreamReader __tmp66Reader = new StreamReader(this.__ToStream(__tmp66.ToString())))
                    {
                        bool __tmp66_first = true;
                        while(__tmp66_first || !__tmp66Reader.EndOfStream)
                        {
                            __tmp66_first = false;
                            string __tmp66Line = __tmp66Reader.ReadLine();
                            if (__tmp66Line == null)
                            {
                                __tmp66Line = "";
                            }
                            __out.Append(__tmp66Line);
                            __out.Append(__tmp63Suffix);
                            __out.AppendLine(); //74:90
                        }
                    }
                    __out.Append("	}"); //75:1
                    __out.AppendLine(); //75:3
                }
            }
            var __loop6_results = 
                (from __loop6_var1 in __Enumerate((sType).GetEnumerator()) //80:8
                from prop in __Enumerate((__loop6_var1.Properties).GetEnumerator()) //80:15
                where !prop.Name.EndsWith("Id") //80:31
                select new { __loop6_var1 = __loop6_var1, prop = prop}
                ).ToList(); //80:2
            int __loop6_iteration = 0;
            foreach (var __tmp67 in __loop6_results)
            {
                ++__loop6_iteration;
                var __loop6_var1 = __tmp67.__loop6_var1;
                var prop = __tmp67.prop;
                __out.AppendLine(); //81:2
                string __tmp68Prefix = "	public "; //82:1
                string __tmp69Suffix = "() {"; //82:75
                StringBuilder __tmp70 = new StringBuilder();
                __tmp70.Append(prop.Type.GetJavaName());
                using(StreamReader __tmp70Reader = new StreamReader(this.__ToStream(__tmp70.ToString())))
                {
                    bool __tmp70_first = true;
                    while(__tmp70_first || !__tmp70Reader.EndOfStream)
                    {
                        __tmp70_first = false;
                        string __tmp70Line = __tmp70Reader.ReadLine();
                        if (__tmp70Line == null)
                        {
                            __tmp70Line = "";
                        }
                        __out.Append(__tmp68Prefix);
                        __out.Append(__tmp70Line);
                    }
                }
                string __tmp71Line = " get"; //82:34
                __out.Append(__tmp71Line);
                StringBuilder __tmp72 = new StringBuilder();
                __tmp72.Append(prop.Name.ToString().ToPascalCase());
                using(StreamReader __tmp72Reader = new StreamReader(this.__ToStream(__tmp72.ToString())))
                {
                    bool __tmp72_first = true;
                    while(__tmp72_first || !__tmp72Reader.EndOfStream)
                    {
                        __tmp72_first = false;
                        string __tmp72Line = __tmp72Reader.ReadLine();
                        if (__tmp72Line == null)
                        {
                            __tmp72Line = "";
                        }
                        __out.Append(__tmp72Line);
                        __out.Append(__tmp69Suffix);
                        __out.AppendLine(); //82:79
                    }
                }
                string __tmp73Prefix = "		return this."; //83:1
                string __tmp74Suffix = ";"; //83:51
                StringBuilder __tmp75 = new StringBuilder();
                __tmp75.Append(prop.Name.ToString().ToCamelCase());
                using(StreamReader __tmp75Reader = new StreamReader(this.__ToStream(__tmp75.ToString())))
                {
                    bool __tmp75_first = true;
                    while(__tmp75_first || !__tmp75Reader.EndOfStream)
                    {
                        __tmp75_first = false;
                        string __tmp75Line = __tmp75Reader.ReadLine();
                        if (__tmp75Line == null)
                        {
                            __tmp75Line = "";
                        }
                        __out.Append(__tmp73Prefix);
                        __out.Append(__tmp75Line);
                        __out.Append(__tmp74Suffix);
                        __out.AppendLine(); //83:52
                    }
                }
                __out.Append("	}"); //84:1
                __out.AppendLine(); //84:3
                if (sType is Struct) //85:4
                {
                    __out.AppendLine(); //86:2
                    string __tmp76Prefix = "	public void set"; //87:1
                    string __tmp77Suffix = ") {"; //87:117
                    StringBuilder __tmp78 = new StringBuilder();
                    __tmp78.Append(prop.Name.ToString().ToPascalCase());
                    using(StreamReader __tmp78Reader = new StreamReader(this.__ToStream(__tmp78.ToString())))
                    {
                        bool __tmp78_first = true;
                        while(__tmp78_first || !__tmp78Reader.EndOfStream)
                        {
                            __tmp78_first = false;
                            string __tmp78Line = __tmp78Reader.ReadLine();
                            if (__tmp78Line == null)
                            {
                                __tmp78Line = "";
                            }
                            __out.Append(__tmp76Prefix);
                            __out.Append(__tmp78Line);
                        }
                    }
                    string __tmp79Line = "("; //87:54
                    __out.Append(__tmp79Line);
                    StringBuilder __tmp80 = new StringBuilder();
                    __tmp80.Append(prop.Type.GetJavaName());
                    using(StreamReader __tmp80Reader = new StreamReader(this.__ToStream(__tmp80.ToString())))
                    {
                        bool __tmp80_first = true;
                        while(__tmp80_first || !__tmp80Reader.EndOfStream)
                        {
                            __tmp80_first = false;
                            string __tmp80Line = __tmp80Reader.ReadLine();
                            if (__tmp80Line == null)
                            {
                                __tmp80Line = "";
                            }
                            __out.Append(__tmp80Line);
                        }
                    }
                    string __tmp81Line = " "; //87:80
                    __out.Append(__tmp81Line);
                    StringBuilder __tmp82 = new StringBuilder();
                    __tmp82.Append(prop.Name.ToString().ToCamelCase());
                    using(StreamReader __tmp82Reader = new StreamReader(this.__ToStream(__tmp82.ToString())))
                    {
                        bool __tmp82_first = true;
                        while(__tmp82_first || !__tmp82Reader.EndOfStream)
                        {
                            __tmp82_first = false;
                            string __tmp82Line = __tmp82Reader.ReadLine();
                            if (__tmp82Line == null)
                            {
                                __tmp82Line = "";
                            }
                            __out.Append(__tmp82Line);
                            __out.Append(__tmp77Suffix);
                            __out.AppendLine(); //87:120
                        }
                    }
                    string __tmp83Prefix = "		this."; //88:1
                    string __tmp84Suffix = ";"; //88:83
                    StringBuilder __tmp85 = new StringBuilder();
                    __tmp85.Append(prop.Name.ToString().ToCamelCase());
                    using(StreamReader __tmp85Reader = new StreamReader(this.__ToStream(__tmp85.ToString())))
                    {
                        bool __tmp85_first = true;
                        while(__tmp85_first || !__tmp85Reader.EndOfStream)
                        {
                            __tmp85_first = false;
                            string __tmp85Line = __tmp85Reader.ReadLine();
                            if (__tmp85Line == null)
                            {
                                __tmp85Line = "";
                            }
                            __out.Append(__tmp83Prefix);
                            __out.Append(__tmp85Line);
                        }
                    }
                    string __tmp86Line = " = "; //88:44
                    __out.Append(__tmp86Line);
                    StringBuilder __tmp87 = new StringBuilder();
                    __tmp87.Append(prop.Name.ToString().ToCamelCase());
                    using(StreamReader __tmp87Reader = new StreamReader(this.__ToStream(__tmp87.ToString())))
                    {
                        bool __tmp87_first = true;
                        while(__tmp87_first || !__tmp87Reader.EndOfStream)
                        {
                            __tmp87_first = false;
                            string __tmp87Line = __tmp87Reader.ReadLine();
                            if (__tmp87Line == null)
                            {
                                __tmp87Line = "";
                            }
                            __out.Append(__tmp87Line);
                            __out.Append(__tmp84Suffix);
                            __out.AppendLine(); //88:84
                        }
                    }
                    __out.Append("	}"); //89:1
                    __out.AppendLine(); //89:3
                }
            }
            __out.Append("}"); //93:1
            __out.AppendLine(); //93:2
            return __out.ToString();
        }

        public string GetPropertyList(StructuredType sType) //96:1
        {
            string result = ""; //97:5
            var __loop7_results = 
                (from __loop7_var1 in __Enumerate((sType).GetEnumerator()) //98:11
                from p in __Enumerate((__loop7_var1.Properties).GetEnumerator()) //98:18
                select new { __loop7_var1 = __loop7_var1, p = p}
                ).ToList(); //98:5
            int __loop7_iteration = 0;
            string delimiter = ""; //98:32
            foreach (var __tmp1 in __loop7_results)
            {
                ++__loop7_iteration;
                if (__loop7_iteration >= 2) //98:55
                {
                    delimiter = ", "; //98:55
                }
                var __loop7_var1 = __tmp1.__loop7_var1;
                var p = __tmp1.p;
                result = result + delimiter + p.Type.GetJavaName() + " " + p.Name.ToString().ToCamelCase(); //99:9
            }
            return result; //101:5
        }

        public string GenerateWsdlAbstractPart(Namespace ns) //105:1
        {
            StringBuilder __out = new StringBuilder();
            var __loop8_results = 
                (from __loop8_var1 in __Enumerate((ns.Declarations).GetEnumerator()) //106:7
                from intf in __Enumerate((__loop8_var1).GetEnumerator()).OfType<Interface>() //106:24
                select new { __loop8_var1 = __loop8_var1, intf = intf}
                ).ToList(); //106:2
            int __loop8_iteration = 0;
            foreach (var __tmp1 in __loop8_results)
            {
                ++__loop8_iteration;
                var __loop8_var1 = __tmp1.__loop8_var1;
                var intf = __tmp1.intf;
                string __tmp2Prefix = string.Empty;
                string __tmp3Suffix = string.Empty;
                StringBuilder __tmp4 = new StringBuilder();
                __tmp4.Append(GenerateMessages(intf));
                using(StreamReader __tmp4Reader = new StreamReader(this.__ToStream(__tmp4.ToString())))
                {
                    bool __tmp4_first = true;
                    while(__tmp4_first || !__tmp4Reader.EndOfStream)
                    {
                        __tmp4_first = false;
                        string __tmp4Line = __tmp4Reader.ReadLine();
                        if (__tmp4Line == null)
                        {
                            __tmp4Line = "";
                        }
                        __out.Append(__tmp2Prefix);
                        __out.Append(__tmp4Line);
                        __out.Append(__tmp3Suffix);
                        __out.AppendLine(); //107:25
                    }
                }
            }
            string __tmp5Prefix = string.Empty;
            string __tmp6Suffix = string.Empty;
            StringBuilder __tmp7 = new StringBuilder();
            __tmp7.Append(GenerateFaultMessages(ns));
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
                    __out.Append(__tmp6Suffix);
                    __out.AppendLine(); //109:28
                }
            }
            var __loop9_results = 
                (from __loop9_var1 in __Enumerate((ns.Declarations).GetEnumerator()) //110:7
                from intf in __Enumerate((__loop9_var1).GetEnumerator()).OfType<Interface>() //110:24
                select new { __loop9_var1 = __loop9_var1, intf = intf}
                ).ToList(); //110:2
            int __loop9_iteration = 0;
            foreach (var __tmp8 in __loop9_results)
            {
                ++__loop9_iteration;
                var __loop9_var1 = __tmp8.__loop9_var1;
                var intf = __tmp8.intf;
                string __tmp9Prefix = string.Empty;
                string __tmp10Suffix = string.Empty;
                StringBuilder __tmp11 = new StringBuilder();
                __tmp11.Append(GeneratePortType(intf));
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
                        __out.AppendLine(); //111:25
                    }
                }
            }
            return __out.ToString();
        }

        public string GenerateWsdlAbstractPart(Interface intf) //115:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp1Prefix = string.Empty;
            string __tmp2Suffix = string.Empty;
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(GenerateMessages(intf));
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
                    __out.AppendLine(); //116:25
                }
            }
            string __tmp4Prefix = string.Empty;
            string __tmp5Suffix = string.Empty;
            StringBuilder __tmp6 = new StringBuilder();
            __tmp6.Append(GenerateFaultMessages(intf));
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
                    __out.AppendLine(); //117:30
                }
            }
            string __tmp7Prefix = string.Empty;
            string __tmp8Suffix = string.Empty;
            StringBuilder __tmp9 = new StringBuilder();
            __tmp9.Append(GeneratePortType(intf));
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
                    __out.AppendLine(); //118:25
                }
            }
            return __out.ToString();
        }

        public string GenerateMessages(Interface intf) //121:1
        {
            StringBuilder __out = new StringBuilder();
            var __loop10_results = 
                (from __loop10_var1 in __Enumerate((intf.Operations).GetEnumerator()) //122:7
                from op in __Enumerate((__loop10_var1).GetEnumerator()).OfType<Operation>() //122:24
                select new { __loop10_var1 = __loop10_var1, op = op}
                ).ToList(); //122:2
            int __loop10_iteration = 0;
            foreach (var __tmp1 in __loop10_results)
            {
                ++__loop10_iteration;
                var __loop10_var1 = __tmp1.__loop10_var1;
                var op = __tmp1.op;
                __out.AppendLine(); //123:1
                string __tmp2Prefix = "<wsdl:message name=\""; //124:1
                string __tmp3Suffix = "_InputMessage\">"; //124:42
                StringBuilder __tmp4 = new StringBuilder();
                __tmp4.Append(intf.Name);
                using(StreamReader __tmp4Reader = new StreamReader(this.__ToStream(__tmp4.ToString())))
                {
                    bool __tmp4_first = true;
                    while(__tmp4_first || !__tmp4Reader.EndOfStream)
                    {
                        __tmp4_first = false;
                        string __tmp4Line = __tmp4Reader.ReadLine();
                        if (__tmp4Line == null)
                        {
                            __tmp4Line = "";
                        }
                        __out.Append(__tmp2Prefix);
                        __out.Append(__tmp4Line);
                    }
                }
                string __tmp5Line = "_"; //124:32
                __out.Append(__tmp5Line);
                StringBuilder __tmp6 = new StringBuilder();
                __tmp6.Append(op.Name);
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
                        __out.Append(__tmp6Line);
                        __out.Append(__tmp3Suffix);
                        __out.AppendLine(); //124:57
                    }
                }
                string __tmp7Prefix = "	<wsdl:part name=\"parameters\" element=\""; //125:1
                string __tmp8Suffix = "\"/>"; //125:73
                StringBuilder __tmp9 = new StringBuilder();
                __tmp9.Append(intf.Namespace.Prefix);
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
                    }
                }
                string __tmp10Line = ":"; //125:63
                __out.Append(__tmp10Line);
                StringBuilder __tmp11 = new StringBuilder();
                __tmp11.Append(op.Name);
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
                        __out.Append(__tmp8Suffix);
                        __out.AppendLine(); //125:76
                    }
                }
                __out.Append("</wsdl:message>"); //126:1
                __out.AppendLine(); //126:16
                if (!op.IsOneway) //127:2
                {
                    __out.AppendLine(); //128:1
                    string __tmp12Prefix = "<wsdl:message name=\""; //129:1
                    string __tmp13Suffix = "_OutputMessage\">"; //129:42
                    StringBuilder __tmp14 = new StringBuilder();
                    __tmp14.Append(intf.Name);
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
                    string __tmp15Line = "_"; //129:32
                    __out.Append(__tmp15Line);
                    StringBuilder __tmp16 = new StringBuilder();
                    __tmp16.Append(op.Name);
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
                            __out.AppendLine(); //129:58
                        }
                    }
                    string __tmp17Prefix = "	<wsdl:part name=\"parameters\" element=\""; //130:1
                    string __tmp18Suffix = "Response\"/>"; //130:73
                    StringBuilder __tmp19 = new StringBuilder();
                    __tmp19.Append(intf.Namespace.Prefix);
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
                    string __tmp20Line = ":"; //130:63
                    __out.Append(__tmp20Line);
                    StringBuilder __tmp21 = new StringBuilder();
                    __tmp21.Append(op.Name);
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
                            __out.AppendLine(); //130:84
                        }
                    }
                    __out.Append("</wsdl:message>"); //131:1
                    __out.AppendLine(); //131:16
                }
            }
            return __out.ToString();
        }

        public string GenerateFaultMessages(Namespace ns) //136:1
        {
            StringBuilder __out = new StringBuilder();
            var __loop11_results = 
                (from ex in __Enumerate((ns.GetInterfaceExceptions()).GetEnumerator()) //137:7
                select new { ex = ex}
                ).ToList(); //137:2
            int __loop11_iteration = 0;
            foreach (var __tmp1 in __loop11_results)
            {
                ++__loop11_iteration;
                var ex = __tmp1.ex;
                __out.AppendLine(); //138:1
                string __tmp2Prefix = "<wsdl:message name=\""; //139:1
                string __tmp3Suffix = "_FaultMessage\">"; //139:30
                StringBuilder __tmp4 = new StringBuilder();
                __tmp4.Append(ex.Name);
                using(StreamReader __tmp4Reader = new StreamReader(this.__ToStream(__tmp4.ToString())))
                {
                    bool __tmp4_first = true;
                    while(__tmp4_first || !__tmp4Reader.EndOfStream)
                    {
                        __tmp4_first = false;
                        string __tmp4Line = __tmp4Reader.ReadLine();
                        if (__tmp4Line == null)
                        {
                            __tmp4Line = "";
                        }
                        __out.Append(__tmp2Prefix);
                        __out.Append(__tmp4Line);
                        __out.Append(__tmp3Suffix);
                        __out.AppendLine(); //139:45
                    }
                }
                string __tmp5Prefix = "	<wsdl:part name=\"fault\" element=\""; //140:1
                string __tmp6Suffix = "\"/>"; //140:66
                StringBuilder __tmp7 = new StringBuilder();
                __tmp7.Append(ex.Namespace.Prefix);
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
                string __tmp8Line = ":"; //140:56
                __out.Append(__tmp8Line);
                StringBuilder __tmp9 = new StringBuilder();
                __tmp9.Append(ex.Name);
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
                        __out.Append(__tmp6Suffix);
                        __out.AppendLine(); //140:69
                    }
                }
                __out.Append("</wsdl:message>"); //141:1
                __out.AppendLine(); //141:16
            }
            return __out.ToString();
        }

        public string GenerateFaultMessages(Interface intf) //145:1
        {
            StringBuilder __out = new StringBuilder();
            var __loop12_results = 
                (from ex in __Enumerate((intf.GetInterfaceExceptions()).GetEnumerator()) //146:7
                select new { ex = ex}
                ).ToList(); //146:2
            int __loop12_iteration = 0;
            foreach (var __tmp1 in __loop12_results)
            {
                ++__loop12_iteration;
                var ex = __tmp1.ex;
                __out.AppendLine(); //147:1
                string __tmp2Prefix = "<wsdl:message name=\""; //148:1
                string __tmp3Suffix = "_FaultMessage\">"; //148:30
                StringBuilder __tmp4 = new StringBuilder();
                __tmp4.Append(ex.Name);
                using(StreamReader __tmp4Reader = new StreamReader(this.__ToStream(__tmp4.ToString())))
                {
                    bool __tmp4_first = true;
                    while(__tmp4_first || !__tmp4Reader.EndOfStream)
                    {
                        __tmp4_first = false;
                        string __tmp4Line = __tmp4Reader.ReadLine();
                        if (__tmp4Line == null)
                        {
                            __tmp4Line = "";
                        }
                        __out.Append(__tmp2Prefix);
                        __out.Append(__tmp4Line);
                        __out.Append(__tmp3Suffix);
                        __out.AppendLine(); //148:45
                    }
                }
                string __tmp5Prefix = "	<wsdl:part name=\"fault\" element=\""; //149:1
                string __tmp6Suffix = "\"/>"; //149:66
                StringBuilder __tmp7 = new StringBuilder();
                __tmp7.Append(ex.Namespace.Prefix);
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
                string __tmp8Line = ":"; //149:56
                __out.Append(__tmp8Line);
                StringBuilder __tmp9 = new StringBuilder();
                __tmp9.Append(ex.Name);
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
                        __out.Append(__tmp6Suffix);
                        __out.AppendLine(); //149:69
                    }
                }
                __out.Append("</wsdl:message>"); //150:1
                __out.AppendLine(); //150:16
            }
            return __out.ToString();
        }

        public string GeneratePortType(Interface intf) //154:1
        {
            StringBuilder __out = new StringBuilder();
            __out.AppendLine(); //155:1
            string __tmp1Prefix = "<wsdl:portType name=\""; //156:1
            string __tmp2Suffix = "\">"; //156:33
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(intf.Name);
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
                    __out.AppendLine(); //156:35
                }
            }
            string __tmp4Prefix = "	"; //157:1
            string __tmp5Suffix = string.Empty; 
            StringBuilder __tmp6 = new StringBuilder();
            __tmp6.Append(GenerateOperations(intf));
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
                    __out.AppendLine(); //157:28
                }
            }
            __out.Append("</wsdl:portType>"); //158:1
            __out.AppendLine(); //158:17
            return __out.ToString();
        }

        public string GenerateOperations(Interface intf) //161:1
        {
            StringBuilder __out = new StringBuilder();
            var __loop13_results = 
                (from __loop13_var1 in __Enumerate((intf.Operations).GetEnumerator()) //162:7
                from op in __Enumerate((__loop13_var1).GetEnumerator()).OfType<Operation>() //162:24
                select new { __loop13_var1 = __loop13_var1, op = op}
                ).ToList(); //162:2
            int __loop13_iteration = 0;
            foreach (var __tmp1 in __loop13_results)
            {
                ++__loop13_iteration;
                var __loop13_var1 = __tmp1.__loop13_var1;
                var op = __tmp1.op;
                string __tmp2Prefix = "<wsdl:operation name=\""; //163:1
                string __tmp3Suffix = "\">"; //163:32
                StringBuilder __tmp4 = new StringBuilder();
                __tmp4.Append(op.Name);
                using(StreamReader __tmp4Reader = new StreamReader(this.__ToStream(__tmp4.ToString())))
                {
                    bool __tmp4_first = true;
                    while(__tmp4_first || !__tmp4Reader.EndOfStream)
                    {
                        __tmp4_first = false;
                        string __tmp4Line = __tmp4Reader.ReadLine();
                        if (__tmp4Line == null)
                        {
                            __tmp4Line = "";
                        }
                        __out.Append(__tmp2Prefix);
                        __out.Append(__tmp4Line);
                        __out.Append(__tmp3Suffix);
                        __out.AppendLine(); //163:34
                    }
                }
                string __tmp5Prefix = "	<wsdl:input wsaw:action=\""; //164:1
                string __tmp6Suffix = "_InputMessage\"/>"; //164:174
                StringBuilder __tmp7 = new StringBuilder();
                __tmp7.Append(op.Interface.Namespace.UriWithSlash() + op.Interface.Name + "/" + op.Name);
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
                string __tmp8Line = "\" message=\""; //164:102
                __out.Append(__tmp8Line);
                StringBuilder __tmp9 = new StringBuilder();
                __tmp9.Append(op.Interface.Namespace.Prefix);
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
                string __tmp10Line = ":"; //164:144
                __out.Append(__tmp10Line);
                StringBuilder __tmp11 = new StringBuilder();
                __tmp11.Append(op.Interface.Name);
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
                    }
                }
                string __tmp12Line = "_"; //164:164
                __out.Append(__tmp12Line);
                StringBuilder __tmp13 = new StringBuilder();
                __tmp13.Append(op.Name);
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
                        __out.Append(__tmp13Line);
                        __out.Append(__tmp6Suffix);
                        __out.AppendLine(); //164:190
                    }
                }
                if (!op.IsOneway) //165:2
                {
                    string __tmp14Prefix = "	<wsdl:output wsaw:action=\""; //166:1
                    string __tmp15Suffix = "_OutputMessage\"/>"; //166:188
                    StringBuilder __tmp16 = new StringBuilder();
                    __tmp16.Append(op.Interface.Namespace.UriWithSlash() + op.Interface.Name + "/" + op.Name + "Response");
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
                            __out.Append(__tmp14Prefix);
                            __out.Append(__tmp16Line);
                        }
                    }
                    string __tmp17Line = "\" message=\""; //166:116
                    __out.Append(__tmp17Line);
                    StringBuilder __tmp18 = new StringBuilder();
                    __tmp18.Append(op.Interface.Namespace.Prefix);
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
                            __out.Append(__tmp18Line);
                        }
                    }
                    string __tmp19Line = ":"; //166:158
                    __out.Append(__tmp19Line);
                    StringBuilder __tmp20 = new StringBuilder();
                    __tmp20.Append(op.Interface.Name);
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
                        }
                    }
                    string __tmp21Line = "_"; //166:178
                    __out.Append(__tmp21Line);
                    StringBuilder __tmp22 = new StringBuilder();
                    __tmp22.Append(op.Name);
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
                            __out.Append(__tmp15Suffix);
                            __out.AppendLine(); //166:205
                        }
                    }
                    var __loop14_results = 
                        (from ex in __Enumerate((op.Exceptions).GetEnumerator()) //167:8
                        select new { ex = ex}
                        ).ToList(); //167:3
                    int __loop14_iteration = 0;
                    foreach (var __tmp23 in __loop14_results)
                    {
                        ++__loop14_iteration;
                        var ex = __tmp23.ex;
                        string __tmp24Prefix = "	<wsdl:fault wsaw:action=\""; //168:1
                        string __tmp25Suffix = "\"/>"; //168:205
                        StringBuilder __tmp26 = new StringBuilder();
                        __tmp26.Append(op.Interface.Namespace.UriWithSlash() + op.Interface.Name + "/" + op.Name + "Fault/" + ex.Name);
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
                        string __tmp27Line = "\" message=\""; //168:123
                        __out.Append(__tmp27Line);
                        StringBuilder __tmp28 = new StringBuilder();
                        __tmp28.Append(op.Interface.Namespace.Prefix);
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
                            }
                        }
                        string __tmp29Line = ":"; //168:165
                        __out.Append(__tmp29Line);
                        StringBuilder __tmp30 = new StringBuilder();
                        __tmp30.Append(ex.Name);
                        using(StreamReader __tmp30Reader = new StreamReader(this.__ToStream(__tmp30.ToString())))
                        {
                            bool __tmp30_first = true;
                            while(__tmp30_first || !__tmp30Reader.EndOfStream)
                            {
                                __tmp30_first = false;
                                string __tmp30Line = __tmp30Reader.ReadLine();
                                if (__tmp30Line == null)
                                {
                                    __tmp30Line = "";
                                }
                                __out.Append(__tmp30Line);
                            }
                        }
                        string __tmp31Line = "_FaultMessage\" name=\""; //168:175
                        __out.Append(__tmp31Line);
                        StringBuilder __tmp32 = new StringBuilder();
                        __tmp32.Append(ex.Name);
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
                                __out.Append(__tmp32Line);
                                __out.Append(__tmp25Suffix);
                                __out.AppendLine(); //168:208
                            }
                        }
                    }
                }
                __out.Append("</wsdl:operation>"); //171:1
                __out.AppendLine(); //171:18
            }
            return __out.ToString();
        }

        public string GenerateWsdlBindingPart(Namespace ns) //175:1
        {
            StringBuilder __out = new StringBuilder();
            var __loop15_results = 
                (from __loop15_var1 in __Enumerate((ns.Declarations).GetEnumerator()) //176:7
                from endp in __Enumerate((__loop15_var1).GetEnumerator()).OfType<Endpoint>() //176:24
                select new { __loop15_var1 = __loop15_var1, endp = endp}
                ).ToList(); //176:2
            int __loop15_iteration = 0;
            foreach (var __tmp1 in __loop15_results)
            {
                ++__loop15_iteration;
                var __loop15_var1 = __tmp1.__loop15_var1;
                var endp = __tmp1.endp;
                string __tmp2Prefix = string.Empty;
                string __tmp3Suffix = string.Empty;
                StringBuilder __tmp4 = new StringBuilder();
                __tmp4.Append(GenerateWsdlBinding(endp));
                using(StreamReader __tmp4Reader = new StreamReader(this.__ToStream(__tmp4.ToString())))
                {
                    bool __tmp4_first = true;
                    while(__tmp4_first || !__tmp4Reader.EndOfStream)
                    {
                        __tmp4_first = false;
                        string __tmp4Line = __tmp4Reader.ReadLine();
                        if (__tmp4Line == null)
                        {
                            __tmp4Line = "";
                        }
                        __out.Append(__tmp2Prefix);
                        __out.Append(__tmp4Line);
                        __out.Append(__tmp3Suffix);
                        __out.AppendLine(); //177:28
                    }
                }
            }
            return __out.ToString();
        }

        public string GenerateWsdlBinding(Endpoint endp) //181:1
        {
            StringBuilder __out = new StringBuilder();
            __out.AppendLine(); //182:1
            string soapPrefix = endp.Binding.GetSoapPrefix(); //183:2
            string __tmp1Prefix = "<wsdl:binding name=\""; //184:1
            string __tmp2Suffix = "\">"; //184:133
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(endp.Interface.Name);
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
            string __tmp4Line = "_"; //184:42
            __out.Append(__tmp4Line);
            StringBuilder __tmp5 = new StringBuilder();
            __tmp5.Append(endp.Binding.Name);
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
            string __tmp6Line = "_Binding\" type=\""; //184:62
            __out.Append(__tmp6Line);
            StringBuilder __tmp7 = new StringBuilder();
            __tmp7.Append(endp.Interface.Namespace.Prefix);
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
                }
            }
            string __tmp8Line = ":"; //184:111
            __out.Append(__tmp8Line);
            StringBuilder __tmp9 = new StringBuilder();
            __tmp9.Append(endp.Interface.Name);
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
                    __out.Append(__tmp2Suffix);
                    __out.AppendLine(); //184:135
                }
            }
            if (endp.Binding.HasPolicy()) //185:3
            {
                string __tmp10Prefix = "	<wsp:PolicyReference URI=\"#"; //186:1
                string __tmp11Suffix = "_Policy\"/>"; //186:48
                StringBuilder __tmp12 = new StringBuilder();
                __tmp12.Append(endp.Binding.Name);
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
                        __out.AppendLine(); //186:58
                    }
                }
            }
            if (soapPrefix != null) //188:3
            {
                if (endp.Binding.Transport is HttpTransportBindingElement) //189:4
                {
                    string __tmp13Prefix = "	<"; //190:1
                    string __tmp14Suffix = ":binding style=\"document\" transport=\"http://schemas.xmlsoap.org/soap/http\"/>"; //190:15
                    StringBuilder __tmp15 = new StringBuilder();
                    __tmp15.Append(soapPrefix);
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
                            __out.AppendLine(); //190:91
                        }
                    }
                }
                else //191:4
                {
                    string __tmp16Prefix = "	<"; //192:1
                    string __tmp17Suffix = ":binding style=\"document\"/>"; //192:15
                    StringBuilder __tmp18 = new StringBuilder();
                    __tmp18.Append(soapPrefix);
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
                            __out.Append(__tmp17Suffix);
                            __out.AppendLine(); //192:42
                        }
                    }
                }
            }
            var __loop16_results = 
                (from op in __Enumerate((endp.Interface.Operations).GetEnumerator()) //195:8
                select new { op = op}
                ).ToList(); //195:3
            int __loop16_iteration = 0;
            foreach (var __tmp19 in __loop16_results)
            {
                ++__loop16_iteration;
                var op = __tmp19.op;
                string __tmp20Prefix = "	<wsdl:operation name=\""; //196:1
                string __tmp21Suffix = "\">"; //196:33
                StringBuilder __tmp22 = new StringBuilder();
                __tmp22.Append(op.Name);
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
                        __out.AppendLine(); //196:35
                    }
                }
                if (soapPrefix != null) //197:4
                {
                    string __tmp23Prefix = "		<"; //198:1
                    string __tmp24Suffix = "\"/>"; //198:131
                    StringBuilder __tmp25 = new StringBuilder();
                    __tmp25.Append(soapPrefix);
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
                            __out.Append(__tmp23Prefix);
                            __out.Append(__tmp25Line);
                        }
                    }
                    string __tmp26Line = ":operation style=\"document\" soapAction=\""; //198:16
                    __out.Append(__tmp26Line);
                    StringBuilder __tmp27 = new StringBuilder();
                    __tmp27.Append(op.Interface.Namespace.UriWithSlash() + op.Interface.Name + "/" + op.Name);
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
                            __out.Append(__tmp27Line);
                            __out.Append(__tmp24Suffix);
                            __out.AppendLine(); //198:134
                        }
                    }
                }
                __out.Append("		<wsdl:input>"); //200:1
                __out.AppendLine(); //200:15
                if (endp.Binding.HasOperationPolicy()) //201:4
                {
                    string __tmp28Prefix = "			<wsp:PolicyReference URI=\"#"; //202:1
                    string __tmp29Suffix = "_Input_Policy\"/>"; //202:50
                    StringBuilder __tmp30 = new StringBuilder();
                    __tmp30.Append(endp.Binding.Name);
                    using(StreamReader __tmp30Reader = new StreamReader(this.__ToStream(__tmp30.ToString())))
                    {
                        bool __tmp30_first = true;
                        while(__tmp30_first || !__tmp30Reader.EndOfStream)
                        {
                            __tmp30_first = false;
                            string __tmp30Line = __tmp30Reader.ReadLine();
                            if (__tmp30Line == null)
                            {
                                __tmp30Line = "";
                            }
                            __out.Append(__tmp28Prefix);
                            __out.Append(__tmp30Line);
                            __out.Append(__tmp29Suffix);
                            __out.AppendLine(); //202:66
                        }
                    }
                }
                if (soapPrefix != null) //204:4
                {
                    string __tmp31Prefix = "			<"; //205:1
                    string __tmp32Suffix = ":body use=\"literal\"/>"; //205:17
                    StringBuilder __tmp33 = new StringBuilder();
                    __tmp33.Append(soapPrefix);
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
                            __out.AppendLine(); //205:38
                        }
                    }
                }
                __out.Append("		</wsdl:input>"); //207:1
                __out.AppendLine(); //207:16
                if (!op.IsOneway) //208:4
                {
                    __out.Append("		<wsdl:output>"); //209:1
                    __out.AppendLine(); //209:16
                    if (endp.Binding.HasOperationPolicy()) //210:5
                    {
                        string __tmp34Prefix = "			<wsp:PolicyReference URI=\"#"; //211:1
                        string __tmp35Suffix = "_Output_Policy\"/>"; //211:50
                        StringBuilder __tmp36 = new StringBuilder();
                        __tmp36.Append(endp.Binding.Name);
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
                                __out.Append(__tmp35Suffix);
                                __out.AppendLine(); //211:67
                            }
                        }
                    }
                    if (soapPrefix != null) //213:5
                    {
                        string __tmp37Prefix = "			<"; //214:1
                        string __tmp38Suffix = ":body use=\"literal\"/>"; //214:17
                        StringBuilder __tmp39 = new StringBuilder();
                        __tmp39.Append(soapPrefix);
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
                                __out.AppendLine(); //214:38
                            }
                        }
                    }
                    __out.Append("		</wsdl:output>"); //216:1
                    __out.AppendLine(); //216:17
                    var __loop17_results = 
                        (from ex in __Enumerate((op.Exceptions).GetEnumerator()) //217:10
                        select new { ex = ex}
                        ).ToList(); //217:5
                    int __loop17_iteration = 0;
                    foreach (var __tmp40 in __loop17_results)
                    {
                        ++__loop17_iteration;
                        var ex = __tmp40.ex;
                        string __tmp41Prefix = "		<wsdl:fault name=\""; //218:1
                        string __tmp42Suffix = "\">"; //218:30
                        StringBuilder __tmp43 = new StringBuilder();
                        __tmp43.Append(ex.Name);
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
                                __out.Append(__tmp41Prefix);
                                __out.Append(__tmp43Line);
                                __out.Append(__tmp42Suffix);
                                __out.AppendLine(); //218:32
                            }
                        }
                        if (soapPrefix != null) //219:5
                        {
                            string __tmp44Prefix = "			<"; //220:1
                            string __tmp45Suffix = "\" use=\"literal\"/>"; //220:39
                            StringBuilder __tmp46 = new StringBuilder();
                            __tmp46.Append(soapPrefix);
                            using(StreamReader __tmp46Reader = new StreamReader(this.__ToStream(__tmp46.ToString())))
                            {
                                bool __tmp46_first = true;
                                while(__tmp46_first || !__tmp46Reader.EndOfStream)
                                {
                                    __tmp46_first = false;
                                    string __tmp46Line = __tmp46Reader.ReadLine();
                                    if (__tmp46Line == null)
                                    {
                                        __tmp46Line = "";
                                    }
                                    __out.Append(__tmp44Prefix);
                                    __out.Append(__tmp46Line);
                                }
                            }
                            string __tmp47Line = ":fault name=\""; //220:17
                            __out.Append(__tmp47Line);
                            StringBuilder __tmp48 = new StringBuilder();
                            __tmp48.Append(ex.Name);
                            using(StreamReader __tmp48Reader = new StreamReader(this.__ToStream(__tmp48.ToString())))
                            {
                                bool __tmp48_first = true;
                                while(__tmp48_first || !__tmp48Reader.EndOfStream)
                                {
                                    __tmp48_first = false;
                                    string __tmp48Line = __tmp48Reader.ReadLine();
                                    if (__tmp48Line == null)
                                    {
                                        __tmp48Line = "";
                                    }
                                    __out.Append(__tmp48Line);
                                    __out.Append(__tmp45Suffix);
                                    __out.AppendLine(); //220:56
                                }
                            }
                        }
                        __out.Append("		</wsdl:fault>"); //222:1
                        __out.AppendLine(); //222:16
                    }
                }
                __out.Append("	</wsdl:operation>"); //225:1
                __out.AppendLine(); //225:19
            }
            __out.Append("</wsdl:binding>"); //227:1
            __out.AppendLine(); //227:16
            return __out.ToString();
        }

        public string GenerateWsdlEndpointPart(Namespace ns) //230:1
        {
            StringBuilder __out = new StringBuilder();
            var __loop18_results = 
                (from __loop18_var1 in __Enumerate((ns.Declarations).GetEnumerator()) //231:7
                from endp in __Enumerate((__loop18_var1).GetEnumerator()).OfType<Endpoint>() //231:24
                select new { __loop18_var1 = __loop18_var1, endp = endp}
                ).ToList(); //231:2
            int __loop18_iteration = 0;
            foreach (var __tmp1 in __loop18_results)
            {
                ++__loop18_iteration;
                var __loop18_var1 = __tmp1.__loop18_var1;
                var endp = __tmp1.endp;
                string __tmp2Prefix = string.Empty;
                string __tmp3Suffix = string.Empty;
                StringBuilder __tmp4 = new StringBuilder();
                __tmp4.Append(GenerateWsdlEndpoint(endp));
                using(StreamReader __tmp4Reader = new StreamReader(this.__ToStream(__tmp4.ToString())))
                {
                    bool __tmp4_first = true;
                    while(__tmp4_first || !__tmp4Reader.EndOfStream)
                    {
                        __tmp4_first = false;
                        string __tmp4Line = __tmp4Reader.ReadLine();
                        if (__tmp4Line == null)
                        {
                            __tmp4Line = "";
                        }
                        __out.Append(__tmp2Prefix);
                        __out.Append(__tmp4Line);
                        __out.Append(__tmp3Suffix);
                        __out.AppendLine(); //232:29
                    }
                }
            }
            return __out.ToString();
        }

        public string GenerateWsdlEndpoint(Endpoint endp) //236:1
        {
            StringBuilder __out = new StringBuilder();
            __out.AppendLine(); //237:1
            string soapPrefix = endp.Binding.GetSoapPrefix(); //238:2
            string __tmp1Prefix = "<wsdl:service name=\""; //239:1
            string __tmp2Suffix = "\">"; //239:32
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(endp.Name);
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
                    __out.AppendLine(); //239:34
                }
            }
            string __tmp4Prefix = "	<wsdl:port name=\""; //240:1
            string __tmp5Suffix = "_Binding\">"; //240:141
            StringBuilder __tmp6 = new StringBuilder();
            __tmp6.Append(endp.Interface.Name);
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
                }
            }
            string __tmp7Line = "_"; //240:40
            __out.Append(__tmp7Line);
            StringBuilder __tmp8 = new StringBuilder();
            __tmp8.Append(endp.Binding.Name);
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
                    __out.Append(__tmp8Line);
                }
            }
            string __tmp9Line = "_Port\" binding=\""; //240:60
            __out.Append(__tmp9Line);
            StringBuilder __tmp10 = new StringBuilder();
            __tmp10.Append(endp.Namespace.Prefix);
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
            string __tmp11Line = ":"; //240:99
            __out.Append(__tmp11Line);
            StringBuilder __tmp12 = new StringBuilder();
            __tmp12.Append(endp.Interface.Name);
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
            string __tmp13Line = "_"; //240:121
            __out.Append(__tmp13Line);
            StringBuilder __tmp14 = new StringBuilder();
            __tmp14.Append(endp.Binding.Name);
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
                    __out.Append(__tmp5Suffix);
                    __out.AppendLine(); //240:151
                }
            }
            if (soapPrefix != null) //241:3
            {
                string __tmp15Prefix = "		<"; //242:1
                string __tmp16Suffix = "\"/>"; //242:49
                StringBuilder __tmp17 = new StringBuilder();
                __tmp17.Append(soapPrefix);
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
                string __tmp18Line = ":address location=\""; //242:16
                __out.Append(__tmp18Line);
                StringBuilder __tmp19 = new StringBuilder();
                __tmp19.Append(endp.Address);
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
                        __out.AppendLine(); //242:52
                    }
                }
            }
            __out.Append("	</wsdl:port>"); //244:1
            __out.AppendLine(); //244:14
            __out.Append("</wsdl:service>"); //245:1
            __out.AppendLine(); //245:16
            return __out.ToString();
        }

        public string GenerateWsdlPoliciesPart(Namespace ns) //250:1
        {
            StringBuilder __out = new StringBuilder();
            var __loop19_results = 
                (from __loop19_var1 in __Enumerate((ns.Declarations).GetEnumerator()) //251:7
                from binding in __Enumerate((__loop19_var1).GetEnumerator()).OfType<Binding>() //251:24
                select new { __loop19_var1 = __loop19_var1, binding = binding}
                ).ToList(); //251:2
            int __loop19_iteration = 0;
            foreach (var __tmp1 in __loop19_results)
            {
                ++__loop19_iteration;
                var __loop19_var1 = __tmp1.__loop19_var1;
                var binding = __tmp1.binding;
                string __tmp2Prefix = string.Empty;
                string __tmp3Suffix = string.Empty;
                StringBuilder __tmp4 = new StringBuilder();
                __tmp4.Append(GenerateWsdlPolicy(binding));
                using(StreamReader __tmp4Reader = new StreamReader(this.__ToStream(__tmp4.ToString())))
                {
                    bool __tmp4_first = true;
                    while(__tmp4_first || !__tmp4Reader.EndOfStream)
                    {
                        __tmp4_first = false;
                        string __tmp4Line = __tmp4Reader.ReadLine();
                        if (__tmp4Line == null)
                        {
                            __tmp4Line = "";
                        }
                        __out.Append(__tmp2Prefix);
                        __out.Append(__tmp4Line);
                        __out.Append(__tmp3Suffix);
                        __out.AppendLine(); //252:30
                    }
                }
            }
            return __out.ToString();
        }

        public string GenerateWsdlPolicy(Binding binding) //256:1
        {
            StringBuilder __out = new StringBuilder();
            if (binding.HasPolicy()) //257:2
            {
                __out.AppendLine(); //258:1
                string __tmp1Prefix = "<wsp:Policy wsu:Id=\""; //259:1
                string __tmp2Suffix = "_Policy\">"; //259:35
                StringBuilder __tmp3 = new StringBuilder();
                __tmp3.Append(binding.Name);
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
                        __out.AppendLine(); //259:44
                    }
                }
                string __tmp4Prefix = "	"; //260:1
                string __tmp5Suffix = string.Empty; 
                StringBuilder __tmp6 = new StringBuilder();
                __tmp6.Append(GenerateHttpsPolicy(binding));
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
                        __out.AppendLine(); //260:32
                    }
                }
                string __tmp7Prefix = "	"; //261:1
                string __tmp8Suffix = string.Empty; 
                StringBuilder __tmp9 = new StringBuilder();
                __tmp9.Append(GenerateMtomPolicy(binding));
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
                        __out.AppendLine(); //261:31
                    }
                }
                string __tmp10Prefix = "	"; //262:1
                string __tmp11Suffix = string.Empty; 
                StringBuilder __tmp12 = new StringBuilder();
                __tmp12.Append(GenerateAddressingPolicy(binding));
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
                        __out.AppendLine(); //262:37
                    }
                }
                __out.Append("</wsp:Policy>"); //263:1
                __out.AppendLine(); //263:14
            }
            return __out.ToString();
        }

        public string GenerateHttpsPolicy(Binding binding) //267:1
        {
            StringBuilder __out = new StringBuilder();
            if (binding.Transport is HttpTransportBindingElement && ((HttpTransportBindingElement)binding.Transport).Ssl) //268:2
            {
                __out.Append("<sp:TransportBinding>"); //269:1
                __out.AppendLine(); //269:22
                __out.Append("	<wsp:Policy>"); //270:1
                __out.AppendLine(); //270:14
                __out.Append("		<sp:TransportToken>"); //271:1
                __out.AppendLine(); //271:22
                __out.Append("			<wsp:Policy>"); //272:1
                __out.AppendLine(); //272:16
                if (((HttpTransportBindingElement)binding.Transport).ClientAuthentication) //273:5
                {
                    __out.Append("				<sp:HttpsToken RequireClientCertificate=\"true\"/>"); //274:1
                    __out.AppendLine(); //274:53
                }
                else //275:5
                {
                    __out.Append("				<sp:HttpsToken RequireClientCertificate=\"false\"/>"); //276:1
                    __out.AppendLine(); //276:54
                }
                __out.Append("			</wsp:Policy>"); //278:1
                __out.AppendLine(); //278:17
                __out.Append("		</sp:TransportToken>"); //279:1
                __out.AppendLine(); //279:23
                __out.Append("		<sp:AlgorithmSuite>"); //280:1
                __out.AppendLine(); //280:22
                __out.Append("			<wsp:Policy>"); //281:1
                __out.AppendLine(); //281:16
                __out.Append("				<sp:Basic256/>"); //282:1
                __out.AppendLine(); //282:19
                __out.Append("			</wsp:Policy>"); //283:1
                __out.AppendLine(); //283:17
                __out.Append("		</sp:AlgorithmSuite>"); //284:1
                __out.AppendLine(); //284:23
                __out.Append("		<sp:Layout>"); //285:1
                __out.AppendLine(); //285:14
                __out.Append("			<wsp:Policy>"); //286:1
                __out.AppendLine(); //286:16
                __out.Append("				<sp:Strict/>"); //287:1
                __out.AppendLine(); //287:17
                __out.Append("			</wsp:Policy>"); //288:1
                __out.AppendLine(); //288:17
                __out.Append("		</sp:Layout> "); //289:1
                __out.AppendLine(); //289:16
                __out.Append("	</wsp:Policy>"); //290:1
                __out.AppendLine(); //290:15
                __out.Append("</sp:TransportBinding>"); //291:1
                __out.AppendLine(); //291:23
            }
            return __out.ToString();
        }

        public string GenerateMtomPolicy(Binding binding) //295:1
        {
            StringBuilder __out = new StringBuilder();
            if ((from __loop20_var1 in __Enumerate((binding).GetEnumerator()) //296:13
            from Encodings in __Enumerate((__loop20_var1.Encodings).GetEnumerator()) //296:22
            from enc in __Enumerate((Encodings).GetEnumerator()).OfType<SoapEncodingBindingElement>() //296:33
            where enc.Mtom //296:72
            select new { __loop20_var1 = __loop20_var1, Encodings = Encodings, enc = enc}
            ).GetEnumerator().MoveNext()) //296:2
            {
                __out.Append("<wsoma:OptimizedMimeSerialization/>"); //297:1
                __out.AppendLine(); //297:36
            }
            return __out.ToString();
        }

        public string GenerateAddressingPolicy(Binding binding) //301:1
        {
            StringBuilder __out = new StringBuilder();
            if ((from __loop21_var1 in __Enumerate((binding).GetEnumerator()) //302:13
            from Protocols in __Enumerate((__loop21_var1.Protocols).GetEnumerator()) //302:22
            from __loop21_var2 in __Enumerate((Protocols).GetEnumerator()).OfType<WsAddressingBindingElement>() //302:33
            select new { __loop21_var1 = __loop21_var1, Protocols = Protocols, __loop21_var2 = __loop21_var2}
            ).GetEnumerator().MoveNext()) //302:2
            {
                __out.Append("<wsam:Addressing/>"); //303:1
                __out.AppendLine(); //303:19
            }
            return __out.ToString();
        }

    }
}
