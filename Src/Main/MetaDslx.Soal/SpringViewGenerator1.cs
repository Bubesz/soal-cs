using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Soal //1:1
{
    using __Hidden_SpringViewGenerator_222283555;
    namespace __Hidden_SpringViewGenerator_222283555
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

    public class SpringViewGenerator //2:1
    {
        private object Instances; //2:1

        public SpringViewGenerator() //2:1
        {
        }

        public SpringViewGenerator(object instances) : this() //2:1
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

        public string GenerateController(Reference reference) //8:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp2Line = "package "; //9:1
            if (__tmp2Line != null) __out.Append(__tmp2Line);
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(SpringGeneratorUtil.GetPackage(reference.Interface));
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
            string __tmp4Line = "."; //9:62
            if (__tmp4Line != null) __out.Append(__tmp4Line);
            StringBuilder __tmp5 = new StringBuilder();
            __tmp5.Append(SpringGeneratorUtil.Properties.controllerPackage);
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
            string __tmp6Line = ";"; //9:113
            if (__tmp6Line != null) __out.Append(__tmp6Line);
            __out.AppendLine(false); //9:114
            __out.AppendLine(true); //10:1
            __out.Append("import org.springframework.beans.factory.annotation.Autowired;"); //11:1
            __out.AppendLine(false); //11:63
            __out.Append("import org.springframework.stereotype.Controller;"); //12:1
            __out.AppendLine(false); //12:50
            __out.Append("import org.springframework.ui.Model;"); //13:1
            __out.AppendLine(false); //13:37
            __out.Append("import org.springframework.web.bind.annotation.RequestMapping;"); //14:1
            __out.AppendLine(false); //14:63
            __out.Append("import org.springframework.web.bind.annotation.RequestMethod;"); //15:1
            __out.AppendLine(false); //15:62
            __out.Append("import org.springframework.web.bind.annotation.RequestParam;"); //16:1
            __out.AppendLine(false); //16:61
            __out.AppendLine(true); //17:1
            string __tmp8Line = "import "; //18:1
            if (__tmp8Line != null) __out.Append(__tmp8Line);
            StringBuilder __tmp9 = new StringBuilder();
            __tmp9.Append(SpringGeneratorUtil.GetPackage(reference.Interface));
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
            string __tmp10Line = "."; //18:61
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
            string __tmp12Line = "."; //18:111
            if (__tmp12Line != null) __out.Append(__tmp12Line);
            StringBuilder __tmp13 = new StringBuilder();
            __tmp13.Append(reference.Interface.Name);
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
            __tmp14.Append(SpringGeneratorUtil.GetBindingType(reference));
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
            string __tmp15Line = ";"; //18:185
            if (__tmp15Line != null) __out.Append(__tmp15Line);
            __out.AppendLine(false); //18:186
            StringBuilder __tmp17 = new StringBuilder();
            __tmp17.Append(SpringGeneratorUtil.GenerateImports(reference.Interface, false));
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
                    __out.AppendLine(false); //19:66
                }
            }
            __out.AppendLine(true); //20:1
            __out.Append("@Controller"); //21:1
            __out.AppendLine(false); //21:12
            __out.Append("@RequestMapping(method = RequestMethod.GET)"); //22:1
            __out.AppendLine(false); //22:44
            string __tmp19Line = "public class "; //23:1
            if (__tmp19Line != null) __out.Append(__tmp19Line);
            StringBuilder __tmp20 = new StringBuilder();
            __tmp20.Append(reference.Name);
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
            string __tmp21Line = "Controller {"; //23:30
            if (__tmp21Line != null) __out.Append(__tmp21Line);
            __out.AppendLine(false); //23:42
            __out.AppendLine(true); //24:1
            __out.Append("	@Autowired"); //25:1
            __out.AppendLine(false); //25:12
            string __tmp23Line = "	private "; //26:1
            if (__tmp23Line != null) __out.Append(__tmp23Line);
            StringBuilder __tmp24 = new StringBuilder();
            __tmp24.Append(reference.Interface.Name);
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
            StringBuilder __tmp25 = new StringBuilder();
            __tmp25.Append(SpringGeneratorUtil.GetBindingType(reference));
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
            string __tmp26Line = " "; //26:83
            if (__tmp26Line != null) __out.Append(__tmp26Line);
            StringBuilder __tmp27 = new StringBuilder();
            __tmp27.Append(reference.Name.ToCamelCase());
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
            string __tmp28Line = ";"; //26:114
            if (__tmp28Line != null) __out.Append(__tmp28Line);
            __out.AppendLine(false); //26:115
            __out.AppendLine(true); //27:2
            var __loop1_results = 
                (from __loop1_var1 in __Enumerate((reference.Interface).GetEnumerator()) //28:9
                from op in __Enumerate((__loop1_var1.Operations).GetEnumerator()) //28:30
                select new { __loop1_var1 = __loop1_var1, op = op}
                ).ToList(); //28:4
            int __loop1_iteration = 0;
            foreach (var __tmp29 in __loop1_results)
            {
                ++__loop1_iteration;
                var __loop1_var1 = __tmp29.__loop1_var1;
                var op = __tmp29.op;
                string javaReturn = op.Result.Type.GetJavaName(); //30:5
                string name = op.Name; //31:5
                if (name.StartsWith("Get")) //32:5
                {
                    name = op.Name.Substring(3);
                }
                if (javaReturn.Contains("List")) //36:5
                {
                    string __tmp31Line = "	@RequestMapping(\"/"; //37:1
                    if (__tmp31Line != null) __out.Append(__tmp31Line);
                    StringBuilder __tmp32 = new StringBuilder();
                    __tmp32.Append(name);
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
                    string __tmp33Line = "\")"; //37:26
                    if (__tmp33Line != null) __out.Append(__tmp33Line);
                    __out.AppendLine(false); //37:28
                }
                else if (javaReturn != "void") //38:5
                {
                    string __tmp35Line = "	@RequestMapping(value=\"/\", params={\"action="; //39:1
                    if (__tmp35Line != null) __out.Append(__tmp35Line);
                    StringBuilder __tmp36 = new StringBuilder();
                    __tmp36.Append(name);
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
                    string __tmp37Line = "\"})"; //39:51
                    if (__tmp37Line != null) __out.Append(__tmp37Line);
                    __out.AppendLine(false); //39:54
                }
                else //40:5
                {
                    __out.Append("	@RequestMapping(\"/\") // + POST"); //41:1
                    __out.AppendLine(false); //41:32
                }
                string __tmp39Line = "	public String "; //43:1
                if (__tmp39Line != null) __out.Append(__tmp39Line);
                StringBuilder __tmp40 = new StringBuilder();
                __tmp40.Append(op.Name.ToCamelCase());
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
                string __tmp41Line = "(Model model"; //43:39
                if (__tmp41Line != null) __out.Append(__tmp41Line);
                var __loop2_results = 
                    (from __loop2_var1 in __Enumerate((op).GetEnumerator()) //44:11
                    from param in __Enumerate((__loop2_var1.Parameters).GetEnumerator()) //44:15
                    select new { __loop2_var1 = __loop2_var1, param = param}
                    ).ToList(); //44:5
                int __loop2_iteration = 0;
                foreach (var __tmp42 in __loop2_results)
                {
                    ++__loop2_iteration;
                    var __loop2_var1 = __tmp42.__loop2_var1;
                    var param = __tmp42.param;
                    __out.Append(","); //45:1
                    __out.AppendLine(false); //45:2
                    string __tmp44Line = "		@RequestParam(value=\""; //46:1
                    if (__tmp44Line != null) __out.Append(__tmp44Line);
                    StringBuilder __tmp45 = new StringBuilder();
                    __tmp45.Append(param.Name.ToString().ToCamelCase());
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
                    string __tmp46Line = "\") "; //46:61
                    if (__tmp46Line != null) __out.Append(__tmp46Line);
                    StringBuilder __tmp47 = new StringBuilder();
                    __tmp47.Append(param.Type.GetJavaName());
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
                    string __tmp48Line = " "; //46:90
                    if (__tmp48Line != null) __out.Append(__tmp48Line);
                    StringBuilder __tmp49 = new StringBuilder();
                    __tmp49.Append(param.Name.ToString().ToCamelCase());
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
                }
                __out.Append(") {"); //48:1
                __out.AppendLine(false); //48:4
                if (op.Exceptions.Any()) //49:3
                {
                    __out.Append("		try {"); //50:1
                    __out.AppendLine(false); //50:8
                    string __tmp50Prefix = "			"; //51:1
                    StringBuilder __tmp51 = new StringBuilder();
                    __tmp51.Append(ControllerMethodImpl(reference, op));
                    using(StreamReader __tmp51Reader = new StreamReader(this.__ToStream(__tmp51.ToString())))
                    {
                        bool __tmp51_first = true;
                        bool __tmp51_last = __tmp51Reader.EndOfStream;
                        while(__tmp51_first || !__tmp51_last)
                        {
                            __tmp51_first = false;
                            string __tmp51Line = __tmp51Reader.ReadLine();
                            __tmp51_last = __tmp51Reader.EndOfStream;
                            __out.Append(__tmp50Prefix);
                            if (__tmp51Line != null) __out.Append(__tmp51Line);
                            if (!__tmp51_last) __out.AppendLine(true);
                            __out.AppendLine(false); //51:41
                        }
                    }
                    var __loop3_results = 
                        (from __loop3_var1 in __Enumerate((op).GetEnumerator()) //52:9
                        from ex in __Enumerate((__loop3_var1.Exceptions).GetEnumerator()) //52:13
                        select new { __loop3_var1 = __loop3_var1, ex = ex}
                        ).ToList(); //52:4
                    int __loop3_iteration = 0;
                    foreach (var __tmp52 in __loop3_results)
                    {
                        ++__loop3_iteration;
                        var __loop3_var1 = __tmp52.__loop3_var1;
                        var ex = __tmp52.ex;
                        string __tmp54Line = "		} catch ("; //53:1
                        if (__tmp54Line != null) __out.Append(__tmp54Line);
                        StringBuilder __tmp55 = new StringBuilder();
                        __tmp55.Append(ex.GetJavaName());
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
                        string __tmp56Line = " e) {"; //53:30
                        if (__tmp56Line != null) __out.Append(__tmp56Line);
                        __out.AppendLine(false); //53:35
                        __out.Append("			throw new RuntimeException(e);"); //54:1
                        __out.AppendLine(false); //54:34
                    }
                    __out.Append("		}"); //56:1
                    __out.AppendLine(false); //56:4
                }
                else //57:3
                {
                    string __tmp57Prefix = "		"; //58:1
                    StringBuilder __tmp58 = new StringBuilder();
                    __tmp58.Append(ControllerMethodImpl(reference, op));
                    using(StreamReader __tmp58Reader = new StreamReader(this.__ToStream(__tmp58.ToString())))
                    {
                        bool __tmp58_first = true;
                        bool __tmp58_last = __tmp58Reader.EndOfStream;
                        while(__tmp58_first || !__tmp58_last)
                        {
                            __tmp58_first = false;
                            string __tmp58Line = __tmp58Reader.ReadLine();
                            __tmp58_last = __tmp58Reader.EndOfStream;
                            __out.Append(__tmp57Prefix);
                            if (__tmp58Line != null) __out.Append(__tmp58Line);
                            if (!__tmp58_last) __out.AppendLine(true);
                            __out.AppendLine(false); //58:40
                        }
                    }
                }
                if (javaReturn.Contains("List")) //60:4
                {
                    string __tmp60Line = "		return \""; //61:1
                    if (__tmp60Line != null) __out.Append(__tmp60Line);
                    StringBuilder __tmp61 = new StringBuilder();
                    __tmp61.Append(name);
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
                    string __tmp62Line = "\";"; //61:17
                    if (__tmp62Line != null) __out.Append(__tmp62Line);
                    __out.AppendLine(false); //61:19
                }
                else //62:5
                {
                    string __tmp64Line = "		return \""; //63:1
                    if (__tmp64Line != null) __out.Append(__tmp64Line);
                    StringBuilder __tmp65 = new StringBuilder();
                    __tmp65.Append(reference.Name);
                    using(StreamReader __tmp65Reader = new StreamReader(this.__ToStream(__tmp65.ToString())))
                    {
                        bool __tmp65_first = true;
                        bool __tmp65_last = __tmp65Reader.EndOfStream;
                        while(__tmp65_first || !__tmp65_last)
                        {
                            __tmp65_first = false;
                            string __tmp65Line = __tmp65Reader.ReadLine();
                            __tmp65_last = __tmp65Reader.EndOfStream;
                            if (__tmp65Line != null) __out.Append(__tmp65Line);
                            if (!__tmp65_last) __out.AppendLine(true);
                        }
                    }
                    string __tmp66Line = "View\";"; //63:27
                    if (__tmp66Line != null) __out.Append(__tmp66Line);
                    __out.AppendLine(false); //63:33
                }
                __out.Append("	}"); //65:1
                __out.AppendLine(false); //65:3
                __out.AppendLine(true); //66:2
            }
            __out.Append("}"); //68:1
            __out.AppendLine(false); //68:2
            return __out.ToString();
        }

        public string ControllerMethodImpl(Reference reference, Operation op) //73:1
        {
            StringBuilder __out = new StringBuilder();
            if (op.Result.Type.GetJavaName() == "void") //74:3
            {
                StringBuilder __tmp2 = new StringBuilder();
                __tmp2.Append(reference.Name.ToCamelCase());
                using(StreamReader __tmp2Reader = new StreamReader(this.__ToStream(__tmp2.ToString())))
                {
                    bool __tmp2_first = true;
                    bool __tmp2_last = __tmp2Reader.EndOfStream;
                    while(__tmp2_first || !__tmp2_last)
                    {
                        __tmp2_first = false;
                        string __tmp2Line = __tmp2Reader.ReadLine();
                        __tmp2_last = __tmp2Reader.EndOfStream;
                        if (__tmp2Line != null) __out.Append(__tmp2Line);
                        if (!__tmp2_last) __out.AppendLine(true);
                    }
                }
                string __tmp3Line = "."; //75:31
                if (__tmp3Line != null) __out.Append(__tmp3Line);
                StringBuilder __tmp4 = new StringBuilder();
                __tmp4.Append(op.Name.ToCamelCase());
                using(StreamReader __tmp4Reader = new StreamReader(this.__ToStream(__tmp4.ToString())))
                {
                    bool __tmp4_first = true;
                    bool __tmp4_last = __tmp4Reader.EndOfStream;
                    while(__tmp4_first || !__tmp4_last)
                    {
                        __tmp4_first = false;
                        string __tmp4Line = __tmp4Reader.ReadLine();
                        __tmp4_last = __tmp4Reader.EndOfStream;
                        if (__tmp4Line != null) __out.Append(__tmp4Line);
                        if (!__tmp4_last) __out.AppendLine(true);
                    }
                }
                string __tmp5Line = "("; //75:55
                if (__tmp5Line != null) __out.Append(__tmp5Line);
                StringBuilder __tmp6 = new StringBuilder();
                __tmp6.Append(SpringGeneratorUtil.GetParameterNameList(op));
                using(StreamReader __tmp6Reader = new StreamReader(this.__ToStream(__tmp6.ToString())))
                {
                    bool __tmp6_first = true;
                    bool __tmp6_last = __tmp6Reader.EndOfStream;
                    while(__tmp6_first || !__tmp6_last)
                    {
                        __tmp6_first = false;
                        string __tmp6Line = __tmp6Reader.ReadLine();
                        __tmp6_last = __tmp6Reader.EndOfStream;
                        if (__tmp6Line != null) __out.Append(__tmp6Line);
                        if (!__tmp6_last) __out.AppendLine(true);
                    }
                }
                string __tmp7Line = ");"; //75:102
                if (__tmp7Line != null) __out.Append(__tmp7Line);
                __out.AppendLine(false); //75:104
            }
            else //76:3
            {
                StringBuilder __tmp9 = new StringBuilder();
                __tmp9.Append(op.Result.Type.GetJavaName());
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
                string __tmp10Line = " result = "; //77:31
                if (__tmp10Line != null) __out.Append(__tmp10Line);
                StringBuilder __tmp11 = new StringBuilder();
                __tmp11.Append(reference.Name.ToCamelCase());
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
                string __tmp12Line = "."; //77:71
                if (__tmp12Line != null) __out.Append(__tmp12Line);
                StringBuilder __tmp13 = new StringBuilder();
                __tmp13.Append(op.Name.ToCamelCase());
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
                string __tmp14Line = "("; //77:95
                if (__tmp14Line != null) __out.Append(__tmp14Line);
                StringBuilder __tmp15 = new StringBuilder();
                __tmp15.Append(SpringGeneratorUtil.GetParameterNameList(op));
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
                string __tmp16Line = ");"; //77:142
                if (__tmp16Line != null) __out.Append(__tmp16Line);
                __out.AppendLine(false); //77:144
                ArrayType array = (op.Result.Type as ArrayType); //78:2
                if (array != null) //79:4
                {
                    string __tmp18Line = "model.addAttribute(\""; //80:1
                    if (__tmp18Line != null) __out.Append(__tmp18Line);
                    StringBuilder __tmp19 = new StringBuilder();
                    __tmp19.Append(array.InnerType.GetJavaName());
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
                    string __tmp20Line = "List\", result);"; //80:52
                    if (__tmp20Line != null) __out.Append(__tmp20Line);
                    __out.AppendLine(false); //80:67
                }
                else //81:4
                {
                    string __tmp22Line = "model.addAttribute(\""; //82:1
                    if (__tmp22Line != null) __out.Append(__tmp22Line);
                    StringBuilder __tmp23 = new StringBuilder();
                    __tmp23.Append(op.Result.Type.GetJavaName());
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
                    string __tmp24Line = "\", result);"; //82:51
                    if (__tmp24Line != null) __out.Append(__tmp24Line);
                    __out.AppendLine(false); //82:62
                }
            }
            return __out.ToString();
        }

        public string GenerateView(Reference reference) //89:1
        {
            StringBuilder __out = new StringBuilder();
            __out.Append("<!DOCTYPE html>"); //90:1
            __out.AppendLine(false); //90:16
            __out.Append("<html xmlns:th=\"http://www.thymeleaf.org\">"); //91:1
            __out.AppendLine(false); //91:43
            __out.Append("<head th:substituteby=\"_master :: head\">"); //92:1
            __out.AppendLine(false); //92:41
            __out.Append("    <title>Simple</title>"); //93:1
            __out.AppendLine(false); //93:26
            __out.Append("    <link rel=\"stylesheet\" href=\"../resources/css/foundation.min.css\"/>"); //94:1
            __out.AppendLine(false); //94:72
            __out.Append("    <link rel=\"stylesheet\" href=\"../resources/css/style.css\"/>"); //95:1
            __out.AppendLine(false); //95:63
            __out.Append("</head>"); //96:1
            __out.AppendLine(false); //96:8
            __out.Append("<body>"); //97:1
            __out.AppendLine(false); //97:7
            __out.AppendLine(true); //98:1
            __out.Append("<header class=\"template row\" th:substituteby=\"_master :: header\">"); //99:1
            __out.AppendLine(false); //99:66
            __out.Append("    <div class=\"small-10 columns\">"); //100:1
            __out.AppendLine(false); //100:35
            __out.Append("        <h1>//Title//</h1>"); //101:1
            __out.AppendLine(false); //101:27
            __out.Append("    </div>"); //102:1
            __out.AppendLine(false); //102:11
            __out.Append("</header>"); //103:1
            __out.AppendLine(false); //103:10
            __out.AppendLine(true); //104:1
            __out.Append("<div class=\"row\">"); //105:1
            __out.AppendLine(false); //105:18
            __out.Append("    <div class=\"small-10 columns\">"); //106:1
            __out.AppendLine(false); //106:35
            string __tmp2Line = "		<h2>"; //107:1
            if (__tmp2Line != null) __out.Append(__tmp2Line);
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(reference.Interface.Name);
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
            string __tmp4Line = "</h2>"; //107:33
            if (__tmp4Line != null) __out.Append(__tmp4Line);
            __out.AppendLine(false); //107:38
            __out.AppendLine(true); //108:1
            int ids = 0; //109:2
            var __loop4_results = 
                (from __loop4_var1 in __Enumerate((reference.Interface).GetEnumerator()) //110:7
                from action in __Enumerate((__loop4_var1.Operations).GetEnumerator()) //110:28
                select new { __loop4_var1 = __loop4_var1, action = action}
                ).ToList(); //110:2
            int __loop4_iteration = 0;
            foreach (var __tmp5 in __loop4_results)
            {
                ++__loop4_iteration;
                var __loop4_var1 = __tmp5.__loop4_var1;
                var action = __tmp5.action;
                string actionName = action.Name; //111:3
                if (actionName.StartsWith("Get")) //112:3
                {
                    actionName = actionName.Substring(3);
                }
                string javaReturn = action.Result.Type.GetJavaName(); //116:3
                if (javaReturn.Contains("List") && !action.Parameters.Any()) //118:3
                {
                    string __tmp7Line = "		<a href=\""; //119:1
                    if (__tmp7Line != null) __out.Append(__tmp7Line);
                    StringBuilder __tmp8 = new StringBuilder();
                    __tmp8.Append(actionName);
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
                        }
                    }
                    string __tmp9Line = ".html\">"; //119:24
                    if (__tmp9Line != null) __out.Append(__tmp9Line);
                    StringBuilder __tmp10 = new StringBuilder();
                    __tmp10.Append(actionName);
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
                        }
                    }
                    string __tmp11Line = "</a>"; //119:43
                    if (__tmp11Line != null) __out.Append(__tmp11Line);
                    __out.AppendLine(false); //119:47
                }
                else //120:3
                {
                    if (javaReturn.Contains("List")) //121:4
                    {
                        string __tmp13Line = "		<form action=\""; //122:1
                        if (__tmp13Line != null) __out.Append(__tmp13Line);
                        StringBuilder __tmp14 = new StringBuilder();
                        __tmp14.Append(actionName);
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
                        string __tmp15Line = ".html\">"; //122:29
                        if (__tmp15Line != null) __out.Append(__tmp15Line);
                        __out.AppendLine(false); //122:36
                    }
                    else //123:4
                    {
                        __out.Append("		<form>"); //124:1
                        __out.AppendLine(false); //124:9
                    }
                    if (action.Parameters.Any()) //127:4
                    {
                        __out.Append("			<fieldset>"); //128:1
                        __out.AppendLine(false); //128:14
                        string __tmp17Line = "				<legend>"; //129:1
                        if (__tmp17Line != null) __out.Append(__tmp17Line);
                        StringBuilder __tmp18 = new StringBuilder();
                        __tmp18.Append(actionName);
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
                        string __tmp19Line = "</legend>"; //129:25
                        if (__tmp19Line != null) __out.Append(__tmp19Line);
                        __out.AppendLine(false); //129:34
                    }
                    if (javaReturn != "void" && !javaReturn.Contains("List")) //132:4
                    {
                        string __tmp21Line = "				<input type=\"hidden\" name=\"action\" value=\""; //133:1
                        if (__tmp21Line != null) __out.Append(__tmp21Line);
                        StringBuilder __tmp22 = new StringBuilder();
                        __tmp22.Append(actionName);
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
                        string __tmp23Line = "\" />"; //133:59
                        if (__tmp23Line != null) __out.Append(__tmp23Line);
                        __out.AppendLine(false); //133:63
                    }
                    var __loop5_results = 
                        (from __loop5_var1 in __Enumerate((action).GetEnumerator()) //136:9
                        from input in __Enumerate((__loop5_var1.Parameters).GetEnumerator()) //136:17
                        select new { __loop5_var1 = __loop5_var1, input = input}
                        ).ToList(); //136:4
                    int __loop5_iteration = 0;
                    foreach (var __tmp24 in __loop5_results)
                    {
                        ++__loop5_iteration;
                        var __loop5_var1 = __tmp24.__loop5_var1;
                        var input = __tmp24.input;
                        string id = (ids++).ToString(); //137:5
                        string __tmp26Line = "				<label for=\""; //138:1
                        if (__tmp26Line != null) __out.Append(__tmp26Line);
                        StringBuilder __tmp27 = new StringBuilder();
                        __tmp27.Append(id);
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
                        string __tmp28Line = "\">"; //138:21
                        if (__tmp28Line != null) __out.Append(__tmp28Line);
                        StringBuilder __tmp29 = new StringBuilder();
                        __tmp29.Append(input.Name);
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
                        string __tmp30Line = ": </label>"; //138:35
                        if (__tmp30Line != null) __out.Append(__tmp30Line);
                        __out.AppendLine(false); //138:45
                        string __tmp32Line = "				<input id=\""; //139:1
                        if (__tmp32Line != null) __out.Append(__tmp32Line);
                        StringBuilder __tmp33 = new StringBuilder();
                        __tmp33.Append(id);
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
                        string __tmp34Line = "\" type=\"text\" name=\""; //139:20
                        if (__tmp34Line != null) __out.Append(__tmp34Line);
                        StringBuilder __tmp35 = new StringBuilder();
                        __tmp35.Append(input.Name);
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
                        string __tmp36Line = "\" />"; //139:52
                        if (__tmp36Line != null) __out.Append(__tmp36Line);
                        __out.AppendLine(false); //139:56
                    }
                    string __tmp38Line = "				<input type=\"submit\" value=\""; //141:1
                    if (__tmp38Line != null) __out.Append(__tmp38Line);
                    StringBuilder __tmp39 = new StringBuilder();
                    __tmp39.Append(action.Name);
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
                    string __tmp40Line = "\" />"; //141:46
                    if (__tmp40Line != null) __out.Append(__tmp40Line);
                    __out.AppendLine(false); //141:50
                    if (javaReturn != "void" && !javaReturn.Contains("List")) //143:4
                    {
                        string id = (ids++).ToString(); //144:5
                        string __tmp42Line = "				<input id=\""; //145:1
                        if (__tmp42Line != null) __out.Append(__tmp42Line);
                        StringBuilder __tmp43 = new StringBuilder();
                        __tmp43.Append(id);
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
                        string __tmp44Line = "\" type=\"text\" name=\""; //145:20
                        if (__tmp44Line != null) __out.Append(__tmp44Line);
                        StringBuilder __tmp45 = new StringBuilder();
                        __tmp45.Append(actionName);
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
                        string __tmp46Line = "Result\" disabled />"; //145:52
                        if (__tmp46Line != null) __out.Append(__tmp46Line);
                        __out.AppendLine(false); //145:71
                    }
                    if (action.Parameters.Any()) //147:4
                    {
                        __out.Append("			</fieldset>"); //148:1
                        __out.AppendLine(false); //148:15
                    }
                    __out.Append("		</form>"); //150:1
                    __out.AppendLine(false); //150:10
                }
                __out.Append("		<br/>"); //152:1
                __out.AppendLine(false); //152:8
            }
            __out.Append("    <div class=\"small-2 columns template\" th:substituteby=\"_master :: sidebar\">"); //154:1
            __out.AppendLine(false); //154:80
            __out.Append("        //side-nav menu//"); //155:1
            __out.AppendLine(false); //155:26
            __out.Append("    </div>"); //156:1
            __out.AppendLine(false); //156:11
            __out.Append("</div>"); //157:1
            __out.AppendLine(false); //157:7
            __out.AppendLine(true); //158:1
            __out.Append("<footer class=\"template row\" th:substituteby=\"_master :: footer\">"); //159:1
            __out.AppendLine(false); //159:66
            __out.Append("    <div class=\"large-12 columns\">"); //160:1
            __out.AppendLine(false); //160:35
            __out.Append("        <hr/>"); //161:1
            __out.AppendLine(false); //161:14
            __out.Append("        <div class=\"row\">"); //162:1
            __out.AppendLine(false); //162:26
            __out.Append("            <div class=\"small-4 columns\">"); //163:1
            __out.AppendLine(false); //163:42
            __out.Append("                //copyright//"); //164:1
            __out.AppendLine(false); //164:30
            __out.Append("            </div>"); //165:1
            __out.AppendLine(false); //165:19
            __out.Append("            <div class=\"small-8 columns\">"); //166:1
            __out.AppendLine(false); //166:42
            __out.Append("                <span class=\"right\">//powered by//</span>"); //167:1
            __out.AppendLine(false); //167:58
            __out.Append("            </div>"); //168:1
            __out.AppendLine(false); //168:19
            __out.Append("        </div>"); //169:1
            __out.AppendLine(false); //169:15
            __out.Append("    </div>"); //170:1
            __out.AppendLine(false); //170:11
            __out.Append("</footer>"); //171:1
            __out.AppendLine(false); //171:10
            __out.AppendLine(true); //172:1
            __out.Append("</body>"); //173:1
            __out.AppendLine(false); //173:8
            __out.Append("</html>"); //174:1
            __out.AppendLine(false); //174:8
            return __out.ToString();
        }

        public string GenerateListView(Struct entity) //179:1
        {
            StringBuilder __out = new StringBuilder();
            __out.Append("<!DOCTYPE html>"); //180:1
            __out.AppendLine(false); //180:16
            __out.Append("<html xmlns:th=\"http://www.thymeleaf.org\">"); //181:1
            __out.AppendLine(false); //181:43
            __out.Append("<head th:substituteby=\"_master :: head\">"); //182:1
            __out.AppendLine(false); //182:41
            __out.Append("    <title>Simple</title>"); //183:1
            __out.AppendLine(false); //183:26
            __out.Append("    <link rel=\"stylesheet\" href=\"../resources/css/foundation.min.css\"/>"); //184:1
            __out.AppendLine(false); //184:72
            __out.Append("    <link rel=\"stylesheet\" href=\"../resources/css/style.css\"/>"); //185:1
            __out.AppendLine(false); //185:63
            __out.Append("</head>"); //186:1
            __out.AppendLine(false); //186:8
            __out.Append("<body>"); //187:1
            __out.AppendLine(false); //187:7
            __out.AppendLine(true); //188:1
            __out.Append("<header class=\"template row\" th:substituteby=\"_master :: header\">"); //189:1
            __out.AppendLine(false); //189:66
            __out.Append("    <div class=\"small-10 columns\">"); //190:1
            __out.AppendLine(false); //190:35
            __out.Append("        <h1>//Title//</h1>"); //191:1
            __out.AppendLine(false); //191:27
            __out.Append("    </div>"); //192:1
            __out.AppendLine(false); //192:11
            __out.Append("</header>"); //193:1
            __out.AppendLine(false); //193:10
            __out.AppendLine(true); //194:1
            __out.Append("<div class=\"row\">"); //195:1
            __out.AppendLine(false); //195:18
            __out.Append("    <div class=\"small-10 columns\">"); //196:1
            __out.AppendLine(false); //196:35
            string __tmp2Line = "        <h2>"; //197:1
            if (__tmp2Line != null) __out.Append(__tmp2Line);
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(entity.Name);
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
            string __tmp4Line = " list</h2>"; //197:26
            if (__tmp4Line != null) __out.Append(__tmp4Line);
            __out.AppendLine(false); //197:36
            __out.AppendLine(true); //198:1
            __out.Append("        <table>"); //199:1
            __out.AppendLine(false); //199:16
            __out.Append("            <tr>"); //200:1
            __out.AppendLine(false); //200:17
            var __loop6_results = 
                (from __loop6_var1 in __Enumerate((entity).GetEnumerator()) //201:9
                from property in __Enumerate((__loop6_var1.Properties).GetEnumerator()) //201:17
                select new { __loop6_var1 = __loop6_var1, property = property}
                ).ToList(); //201:4
            int __loop6_iteration = 0;
            foreach (var __tmp5 in __loop6_results)
            {
                ++__loop6_iteration;
                var __loop6_var1 = __tmp5.__loop6_var1;
                var property = __tmp5.property;
                string __tmp7Line = "                <th>"; //202:1
                if (__tmp7Line != null) __out.Append(__tmp7Line);
                StringBuilder __tmp8 = new StringBuilder();
                __tmp8.Append(property.Name);
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
                    }
                }
                string __tmp9Line = "</th>"; //202:36
                if (__tmp9Line != null) __out.Append(__tmp9Line);
                __out.AppendLine(false); //202:41
            }
            __out.Append("            </tr>"); //204:1
            __out.AppendLine(false); //204:18
            string __tmp11Line = "            <tr th:each=\""; //205:1
            if (__tmp11Line != null) __out.Append(__tmp11Line);
            StringBuilder __tmp12 = new StringBuilder();
            __tmp12.Append(entity.Name.ToCamelCase());
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
            string __tmp13Line = " : ${"; //205:53
            if (__tmp13Line != null) __out.Append(__tmp13Line);
            StringBuilder __tmp14 = new StringBuilder();
            __tmp14.Append(entity.Name.ToCamelCase());
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
            string __tmp15Line = "List}\">"; //205:85
            if (__tmp15Line != null) __out.Append(__tmp15Line);
            __out.AppendLine(false); //205:92
            var __loop7_results = 
                (from __loop7_var1 in __Enumerate((entity).GetEnumerator()) //206:9
                from property in __Enumerate((__loop7_var1.Properties).GetEnumerator()) //206:17
                select new { __loop7_var1 = __loop7_var1, property = property}
                ).ToList(); //206:4
            int __loop7_iteration = 0;
            foreach (var __tmp16 in __loop7_results)
            {
                ++__loop7_iteration;
                var __loop7_var1 = __tmp16.__loop7_var1;
                var property = __tmp16.property;
                string __tmp18Line = "				<td th:text=\"${"; //207:1
                if (__tmp18Line != null) __out.Append(__tmp18Line);
                StringBuilder __tmp19 = new StringBuilder();
                __tmp19.Append(entity.Name.ToCamelCase());
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
                string __tmp20Line = "."; //207:47
                if (__tmp20Line != null) __out.Append(__tmp20Line);
                StringBuilder __tmp21 = new StringBuilder();
                __tmp21.Append(property.Name.ToCamelCase());
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
                string __tmp22Line = "}\">Data</td>"; //207:77
                if (__tmp22Line != null) __out.Append(__tmp22Line);
                __out.AppendLine(false); //207:89
            }
            __out.Append("            </tr>"); //209:1
            __out.AppendLine(false); //209:18
            __out.Append("        </table>"); //210:1
            __out.AppendLine(false); //210:17
            __out.Append("    </div>"); //211:1
            __out.AppendLine(false); //211:11
            __out.Append("    <div class=\"small-2 columns template\" th:substituteby=\"_master :: sidebar\">"); //212:1
            __out.AppendLine(false); //212:80
            __out.Append("        //side-nav menu//"); //213:1
            __out.AppendLine(false); //213:26
            __out.Append("    </div>"); //214:1
            __out.AppendLine(false); //214:11
            __out.Append("</div>"); //215:1
            __out.AppendLine(false); //215:7
            __out.AppendLine(true); //216:1
            __out.Append("<footer class=\"template row\" th:substituteby=\"_master :: footer\">"); //217:1
            __out.AppendLine(false); //217:66
            __out.Append("    <div class=\"large-12 columns\">"); //218:1
            __out.AppendLine(false); //218:35
            __out.Append("        <hr/>"); //219:1
            __out.AppendLine(false); //219:14
            __out.Append("        <div class=\"row\">"); //220:1
            __out.AppendLine(false); //220:26
            __out.Append("            <div class=\"small-4 columns\">"); //221:1
            __out.AppendLine(false); //221:42
            __out.Append("                //copyright//"); //222:1
            __out.AppendLine(false); //222:30
            __out.Append("            </div>"); //223:1
            __out.AppendLine(false); //223:19
            __out.Append("            <div class=\"small-8 columns\">"); //224:1
            __out.AppendLine(false); //224:42
            __out.Append("                <span class=\"right\">//powered by//</span>"); //225:1
            __out.AppendLine(false); //225:58
            __out.Append("            </div>"); //226:1
            __out.AppendLine(false); //226:19
            __out.Append("        </div>"); //227:1
            __out.AppendLine(false); //227:15
            __out.Append("    </div>"); //228:1
            __out.AppendLine(false); //228:11
            __out.Append("</footer>"); //229:1
            __out.AppendLine(false); //229:10
            __out.AppendLine(true); //230:1
            __out.Append("</body>"); //231:1
            __out.AppendLine(false); //231:8
            __out.Append("</html>"); //232:1
            __out.AppendLine(false); //232:8
            return __out.ToString();
        }

        public string GenerateMasterView(string applicationName, List<ViewInfoHolder> views) //237:1
        {
            StringBuilder __out = new StringBuilder();
            __out.Append("<!DOCTYPE html>"); //238:1
            __out.AppendLine(false); //238:16
            __out.Append("<html xmlns:th=\"http://www.thymeleaf.org\">"); //239:1
            __out.AppendLine(false); //239:43
            __out.AppendLine(true); //240:1
            __out.Append("<head th:fragment=\"head\">"); //241:1
            __out.AppendLine(false); //241:26
            string __tmp2Line = "    <title>"; //242:1
            if (__tmp2Line != null) __out.Append(__tmp2Line);
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(applicationName);
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
            string __tmp4Line = "</title>"; //242:29
            if (__tmp4Line != null) __out.Append(__tmp4Line);
            __out.AppendLine(false); //242:37
            __out.Append("    <meta name=\"viewport\" content=\"width=device-width\"/>"); //243:1
            __out.AppendLine(false); //243:57
            __out.Append("    <link rel=\"stylesheet\" href=\"../resources/css/normalize.css\""); //244:1
            __out.AppendLine(false); //244:65
            __out.Append("          th:href=\"@{/resources/css/normalize.css}\"/>"); //245:1
            __out.AppendLine(false); //245:54
            __out.Append("    <link rel=\"stylesheet\" href=\"../resources/css/foundation.min.css\""); //246:1
            __out.AppendLine(false); //246:70
            __out.Append("          th:href=\"@{/resources/css/foundation.min.css}\"/>"); //247:1
            __out.AppendLine(false); //247:59
            __out.Append("    <link rel=\"stylesheet\" href=\"../resources/css/style.css\""); //248:1
            __out.AppendLine(false); //248:61
            __out.Append("          th:href=\"@{/resources/css/style.css}\"/>"); //249:1
            __out.AppendLine(false); //249:50
            __out.Append("    <script type=\"text/javascript\" src=\"../resources/js/vendor/custom.modernizr.js\""); //250:1
            __out.AppendLine(false); //250:84
            __out.Append("            th:src=\"@{/resources/js/vendor/custom.modernizr.js}\"></script>"); //251:1
            __out.AppendLine(false); //251:75
            __out.Append("    <script type=\"text/javascript\" src=\"../resources/js/vendor/jquery.js\""); //252:1
            __out.AppendLine(false); //252:74
            __out.Append("            th:src=\"@{/resources/js/vendor/jquery.js}\"></script>"); //253:1
            __out.AppendLine(false); //253:65
            __out.Append("    <script type=\"text/javascript\" src=\"../resources/js/foundation.min.js\""); //254:1
            __out.AppendLine(false); //254:75
            __out.Append("            th:src=\"@{/resources/js/foundation.min.js}\"></script>"); //255:1
            __out.AppendLine(false); //255:66
            __out.Append("    <script type=\"text/javascript\" src=\"../resources/js/app.js\""); //256:1
            __out.AppendLine(false); //256:64
            __out.Append("            th:src=\"@{/resources/js/app.js}\"></script>"); //257:1
            __out.AppendLine(false); //257:55
            __out.Append("</head>"); //258:1
            __out.AppendLine(false); //258:8
            __out.AppendLine(true); //259:1
            __out.Append("<body>"); //260:1
            __out.AppendLine(false); //260:7
            __out.AppendLine(true); //261:1
            __out.Append("<header class=\"row\" th:fragment=\"header\">"); //262:1
            __out.AppendLine(false); //262:42
            __out.Append("    <div class=\"small-10 columns\">"); //263:1
            __out.AppendLine(false); //263:35
            string __tmp6Line = "        <h1>"; //264:1
            if (__tmp6Line != null) __out.Append(__tmp6Line);
            StringBuilder __tmp7 = new StringBuilder();
            __tmp7.Append(applicationName);
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
            string __tmp8Line = "</h1>"; //264:30
            if (__tmp8Line != null) __out.Append(__tmp8Line);
            __out.AppendLine(false); //264:35
            __out.Append("    </div>"); //265:1
            __out.AppendLine(false); //265:11
            __out.Append("</header>"); //266:1
            __out.AppendLine(false); //266:10
            __out.AppendLine(true); //267:1
            __out.Append("<div class=\"row\">"); //268:1
            __out.AppendLine(false); //268:18
            __out.Append("    <div class=\"small-10 columns template\">"); //269:1
            __out.AppendLine(false); //269:44
            __out.Append("        <h2>//content title//</h2>"); //270:1
            __out.AppendLine(false); //270:35
            __out.Append("        <p>//content//</p>"); //272:1
            __out.AppendLine(false); //272:27
            __out.Append("    </div>"); //273:1
            __out.AppendLine(false); //273:11
            __out.AppendLine(true); //274:1
            __out.Append("    <div class=\"small-2 columns\" th:fragment=\"sidebar\">"); //275:1
            __out.AppendLine(false); //275:56
            __out.Append("        <div style=\"width: 140px; margin: 0 auto\">"); //276:1
            __out.AppendLine(false); //276:51
            __out.Append("            <ul class=\"side-nav\">"); //277:1
            __out.AppendLine(false); //277:34
            var __loop8_results = 
                (from view in __Enumerate((views).GetEnumerator()) //278:10
                select new { view = view}
                ).ToList(); //278:5
            int __loop8_iteration = 0;
            foreach (var __tmp9 in __loop8_results)
            {
                ++__loop8_iteration;
                var view = __tmp9.view;
                string __tmp11Line = "                <li><a href=\""; //279:1
                if (__tmp11Line != null) __out.Append(__tmp11Line);
                StringBuilder __tmp12 = new StringBuilder();
                __tmp12.Append(view.FileName);
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
                string __tmp13Line = "\" th:href=\"@{/"; //279:45
                if (__tmp13Line != null) __out.Append(__tmp13Line);
                StringBuilder __tmp14 = new StringBuilder();
                __tmp14.Append(view.Mapping);
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
                string __tmp15Line = "}\" th:text=\"#{page."; //279:73
                if (__tmp15Line != null) __out.Append(__tmp15Line);
                StringBuilder __tmp16 = new StringBuilder();
                __tmp16.Append(view.Name);
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
                string __tmp17Line = "}\">"; //279:103
                if (__tmp17Line != null) __out.Append(__tmp17Line);
                StringBuilder __tmp18 = new StringBuilder();
                __tmp18.Append(view.Name);
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
                string __tmp19Line = "</a></li>"; //279:117
                if (__tmp19Line != null) __out.Append(__tmp19Line);
                __out.AppendLine(false); //279:126
            }
            __out.Append("            </ul>"); //281:1
            __out.AppendLine(false); //281:18
            __out.Append("        </div>"); //282:1
            __out.AppendLine(false); //282:15
            __out.Append("    </div>"); //283:1
            __out.AppendLine(false); //283:11
            __out.Append("</div>"); //284:1
            __out.AppendLine(false); //284:7
            __out.AppendLine(true); //285:1
            __out.Append("<footer class=\"row\" th:fragment=\"footer\">"); //286:1
            __out.AppendLine(false); //286:42
            __out.Append("    <div class=\"large-12 columns\">"); //287:1
            __out.AppendLine(false); //287:35
            __out.Append("        <hr/>"); //288:1
            __out.AppendLine(false); //288:14
            __out.Append("        <div class=\"row\">"); //289:1
            __out.AppendLine(false); //289:26
            __out.Append("            <div class=\"small-4 columns\">"); //290:1
            __out.AppendLine(false); //290:42
            __out.Append("                <p>&copy; Copyright BME IIT</p>"); //291:1
            __out.AppendLine(false); //291:48
            __out.Append("            </div>"); //292:1
            __out.AppendLine(false); //292:19
            __out.Append("            <div class=\"small-8 columns\">"); //293:1
            __out.AppendLine(false); //293:42
            __out.Append("                <ul class=\"inline-list right\">"); //294:1
            __out.AppendLine(false); //294:47
            __out.Append("                    <li>Powered by</li>"); //295:1
            __out.AppendLine(false); //295:40
            __out.Append("                    <li><a href=\"http://www.spring.io/\">Spring</a></li>"); //296:1
            __out.AppendLine(false); //296:72
            __out.Append("                    <li><a href=\"http://www.thymeleaf.org/\">Thymeleaf</a></li>"); //297:1
            __out.AppendLine(false); //297:79
            __out.Append("                    <li><a href=\"http://foundation.zurb.com/\">Foundation</a></li>"); //298:1
            __out.AppendLine(false); //298:82
            __out.Append("                </ul>"); //299:1
            __out.AppendLine(false); //299:22
            __out.Append("            </div>"); //300:1
            __out.AppendLine(false); //300:19
            __out.Append("        </div>"); //301:1
            __out.AppendLine(false); //301:15
            __out.Append("    </div>"); //302:1
            __out.AppendLine(false); //302:11
            __out.Append("</footer>"); //303:1
            __out.AppendLine(false); //303:10
            __out.AppendLine(true); //304:1
            __out.Append("</body>"); //305:1
            __out.AppendLine(false); //305:8
            __out.Append("</html>"); //306:1
            __out.AppendLine(false); //306:8
            return __out.ToString();
        }

        public string GenerateWebXml() //311:1
        {
            StringBuilder __out = new StringBuilder();
            __out.Append("<?xml version=\"1.0\" encoding=\"UTF-8\"?>"); //312:1
            __out.AppendLine(false); //312:39
            __out.Append("<web-app xmlns=\"http://java.sun.com/xml/ns/javaee\""); //313:1
            __out.AppendLine(false); //313:51
            __out.Append("         xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\""); //314:1
            __out.AppendLine(false); //314:63
            __out.Append("         xsi:schemaLocation=\"http://java.sun.com/xml/ns/javaee"); //315:1
            __out.AppendLine(false); //315:63
            __out.Append("		 http://java.sun.com/xml/ns/javaee/web-app_3_0.xsd\" version=\"3.0\">"); //316:1
            __out.AppendLine(false); //316:69
            __out.AppendLine(true); //317:1
            __out.Append("    <servlet>"); //318:1
            __out.AppendLine(false); //318:14
            __out.Append("        <servlet-name>spring</servlet-name>"); //319:1
            __out.AppendLine(false); //319:44
            __out.Append("        <servlet-class>org.springframework.web.servlet.DispatcherServlet</servlet-class>"); //320:1
            __out.AppendLine(false); //320:89
            __out.Append("        <load-on-startup>1</load-on-startup>"); //321:1
            __out.AppendLine(false); //321:45
            __out.Append("    </servlet>"); //322:1
            __out.AppendLine(false); //322:15
            __out.AppendLine(true); //323:1
            __out.Append("    <servlet-mapping>"); //324:1
            __out.AppendLine(false); //324:22
            __out.Append("        <servlet-name>spring</servlet-name>"); //325:1
            __out.AppendLine(false); //325:44
            __out.Append("        <url-pattern>/*</url-pattern>"); //326:1
            __out.AppendLine(false); //326:38
            __out.Append("    </servlet-mapping>"); //327:1
            __out.AppendLine(false); //327:23
            __out.AppendLine(true); //328:1
            __out.Append("    <context-param>"); //329:1
            __out.AppendLine(false); //329:20
            __out.Append("        <param-name>contextConfigLocation</param-name>"); //330:1
            __out.AppendLine(false); //330:55
            __out.Append("        <param-value>/WEB-INF/spring-config.xml</param-value>"); //331:1
            __out.AppendLine(false); //331:62
            __out.Append("    </context-param>"); //332:1
            __out.AppendLine(false); //332:21
            __out.AppendLine(true); //333:1
            __out.Append("    <listener>"); //334:1
            __out.AppendLine(false); //334:15
            __out.Append("        <listener-class>org.springframework.web.context.ContextLoaderListener</listener-class>"); //335:1
            __out.AppendLine(false); //335:95
            __out.Append("    </listener>"); //336:1
            __out.AppendLine(false); //336:16
            __out.AppendLine(true); //337:1
            __out.Append("    <filter>"); //338:1
            __out.AppendLine(false); //338:13
            __out.Append("        <filter-name>characterEncodingFilter</filter-name>"); //339:1
            __out.AppendLine(false); //339:59
            __out.Append("        <filter-class>org.springframework.web.filter.CharacterEncodingFilter</filter-class>"); //340:1
            __out.AppendLine(false); //340:92
            __out.Append("        <init-param>"); //341:1
            __out.AppendLine(false); //341:21
            __out.Append("            <param-name>encoding</param-name>"); //342:1
            __out.AppendLine(false); //342:46
            __out.Append("            <param-value>UTF-8</param-value>"); //343:1
            __out.AppendLine(false); //343:45
            __out.Append("        </init-param>"); //344:1
            __out.AppendLine(false); //344:22
            __out.Append("    </filter>"); //345:1
            __out.AppendLine(false); //345:14
            __out.AppendLine(true); //346:1
            __out.Append("    <filter-mapping>"); //347:1
            __out.AppendLine(false); //347:21
            __out.Append("        <filter-name>characterEncodingFilter</filter-name>"); //348:1
            __out.AppendLine(false); //348:59
            __out.Append("        <servlet-name>spring</servlet-name>"); //349:1
            __out.AppendLine(false); //349:44
            __out.Append("    </filter-mapping>"); //350:1
            __out.AppendLine(false); //350:22
            __out.AppendLine(true); //351:1
            __out.Append("</web-app>"); //352:1
            __out.AppendLine(false); //352:11
            return __out.ToString();
        }

        public string GenerateServlet(Namespace ns) //356:1
        {
            StringBuilder __out = new StringBuilder();
            __out.Append("<?xml version=\"1.0\" encoding=\"UTF-8\"?>"); //357:1
            __out.AppendLine(false); //357:39
            __out.Append("<beans xmlns=\"http://www.springframework.org/schema/beans\""); //358:1
            __out.AppendLine(false); //358:59
            __out.Append("       xmlns:mvc=\"http://www.springframework.org/schema/mvc\""); //359:1
            __out.AppendLine(false); //359:61
            __out.Append("       xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\""); //360:1
            __out.AppendLine(false); //360:61
            __out.Append("       xmlns:context=\"http://www.springframework.org/schema/context\""); //361:1
            __out.AppendLine(false); //361:69
            __out.Append("       xsi:schemaLocation=\"http://www.springframework.org/schema/beans"); //362:1
            __out.AppendLine(false); //362:71
            __out.Append("                           http://www.springframework.org/schema/beans/spring-beans.xsd"); //363:1
            __out.AppendLine(false); //363:88
            __out.Append("                           http://www.springframework.org/schema/context"); //364:1
            __out.AppendLine(false); //364:73
            __out.Append("                           http://www.springframework.org/schema/context/spring-context.xsd"); //365:1
            __out.AppendLine(false); //365:92
            __out.Append("                           http://www.springframework.org/schema/mvc"); //366:1
            __out.AppendLine(false); //366:69
            __out.Append("                           http://www.springframework.org/schema/mvc/spring-mvc.xsd\">"); //367:1
            __out.AppendLine(false); //367:86
            __out.AppendLine(true); //368:1
            string __tmp2Line = "    <context:component-scan base-package=\""; //369:1
            if (__tmp2Line != null) __out.Append(__tmp2Line);
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(ns.FullName);
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
            string __tmp4Line = "."; //369:56
            if (__tmp4Line != null) __out.Append(__tmp4Line);
            StringBuilder __tmp5 = new StringBuilder();
            __tmp5.Append(SpringGeneratorUtil.Properties.controllerPackage);
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
            string __tmp6Line = "\"/>"; //369:107
            if (__tmp6Line != null) __out.Append(__tmp6Line);
            __out.AppendLine(false); //369:110
            __out.AppendLine(true); //370:1
            __out.Append("    <mvc:annotation-driven/>"); //371:1
            __out.AppendLine(false); //371:29
            __out.AppendLine(true); //372:1
            __out.Append("    <!--<mvc:resources mapping=\"/favicon.ico\" location=\"/WEB-INF/resources/img/\"/>-->"); //373:1
            __out.AppendLine(false); //373:86
            __out.Append("    <mvc:resources mapping=\"/resources/**\" location=\"/WEB-INF/resources/\"/>"); //374:1
            __out.AppendLine(false); //374:76
            __out.AppendLine(true); //375:1
            __out.Append("    <mvc:interceptors>"); //376:1
            __out.AppendLine(false); //376:23
            __out.Append("        <bean class=\"org.springframework.web.servlet.i18n.LocaleChangeInterceptor\">"); //377:1
            __out.AppendLine(false); //377:84
            __out.Append("            <property name=\"paramName\" value=\"lang\"/>"); //378:1
            __out.AppendLine(false); //378:54
            __out.Append("        </bean>"); //379:1
            __out.AppendLine(false); //379:16
            __out.Append("    </mvc:interceptors>"); //380:1
            __out.AppendLine(false); //380:24
            __out.AppendLine(true); //381:1
            __out.Append("    <bean id=\"templateResolver\" class=\"org.thymeleaf.templateresolver.ServletContextTemplateResolver\">"); //382:1
            __out.AppendLine(false); //382:103
            __out.Append("        <property name=\"prefix\" value=\"/WEB-INF/view/\"/>"); //383:1
            __out.AppendLine(false); //383:57
            __out.Append("        <property name=\"suffix\" value=\".html\"/>"); //384:1
            __out.AppendLine(false); //384:48
            __out.Append("        <property name=\"characterEncoding\" value=\"UTF-8\"/>"); //385:1
            __out.AppendLine(false); //385:59
            __out.Append("        <property name=\"templateMode\" value=\"HTML5\"/>"); //386:1
            __out.AppendLine(false); //386:54
            __out.Append("        <property name=\"cacheable\" value=\"false\"/>"); //387:1
            __out.AppendLine(false); //387:51
            __out.Append("    </bean>"); //388:1
            __out.AppendLine(false); //388:12
            __out.AppendLine(true); //389:1
            __out.Append("    <bean id=\"templateEngine\" class=\"org.thymeleaf.spring4.SpringTemplateEngine\">"); //390:1
            __out.AppendLine(false); //390:82
            __out.Append("        <property name=\"templateResolver\" ref=\"templateResolver\"/>"); //391:1
            __out.AppendLine(false); //391:67
            __out.Append("    </bean>"); //392:1
            __out.AppendLine(false); //392:12
            __out.AppendLine(true); //393:1
            __out.Append("    <bean class=\"org.thymeleaf.spring4.view.ThymeleafViewResolver\">"); //394:1
            __out.AppendLine(false); //394:68
            __out.Append("        <property name=\"templateEngine\" ref=\"templateEngine\"/>"); //395:1
            __out.AppendLine(false); //395:63
            __out.Append("        <property name=\"contentType\" value=\"text/html; charset=UTF-8\"/>"); //396:1
            __out.AppendLine(false); //396:72
            __out.Append("        <property name=\"characterEncoding\" value=\"UTF-8\"/>"); //397:1
            __out.AppendLine(false); //397:59
            __out.Append("    </bean>"); //398:1
            __out.AppendLine(false); //398:12
            __out.AppendLine(true); //399:1
            __out.Append("    <bean id=\"localeResolver\" class=\"org.springframework.web.servlet.i18n.SessionLocaleResolver\"/>"); //400:1
            __out.AppendLine(false); //400:99
            __out.AppendLine(true); //401:1
            __out.Append("</beans>"); //402:1
            __out.AppendLine(false); //402:9
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
