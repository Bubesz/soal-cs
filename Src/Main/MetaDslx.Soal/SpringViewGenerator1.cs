using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Soal //1:1
{
    using __Hidden_SpringViewGenerator_799142797;
    namespace __Hidden_SpringViewGenerator_799142797
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
            string __tmp8Line = "import "; //11:1
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
            string __tmp10Line = "."; //11:61
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
            string __tmp12Line = "."; //11:111
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
            string __tmp15Line = ";"; //11:185
            if (__tmp15Line != null) __out.Append(__tmp15Line);
            __out.AppendLine(false); //11:186
            __out.AppendLine(true); //12:1
            __out.Append("@Controller"); //13:1
            __out.AppendLine(false); //13:12
            __out.Append("@RequestMapping(method = RequestMethod.GET)"); //14:1
            __out.AppendLine(false); //14:44
            string __tmp17Line = "public class "; //15:1
            if (__tmp17Line != null) __out.Append(__tmp17Line);
            StringBuilder __tmp18 = new StringBuilder();
            __tmp18.Append(reference.Name);
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
            string __tmp19Line = "Controller {"; //15:30
            if (__tmp19Line != null) __out.Append(__tmp19Line);
            __out.AppendLine(false); //15:42
            __out.AppendLine(true); //16:1
            __out.Append("	@Autowired"); //17:1
            __out.AppendLine(false); //17:12
            string __tmp21Line = "	private "; //18:1
            if (__tmp21Line != null) __out.Append(__tmp21Line);
            StringBuilder __tmp22 = new StringBuilder();
            __tmp22.Append(reference.Interface.Name);
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
            StringBuilder __tmp23 = new StringBuilder();
            __tmp23.Append(SpringGeneratorUtil.GetBindingType(reference));
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
            string __tmp24Line = " "; //18:83
            if (__tmp24Line != null) __out.Append(__tmp24Line);
            StringBuilder __tmp25 = new StringBuilder();
            __tmp25.Append(reference.Name.ToCamelCase());
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
            string __tmp26Line = ";"; //18:114
            if (__tmp26Line != null) __out.Append(__tmp26Line);
            __out.AppendLine(false); //18:115
            __out.AppendLine(true); //19:2
            var __loop1_results = 
                (from __loop1_var1 in __Enumerate((reference.Interface).GetEnumerator()) //20:9
                from op in __Enumerate((__loop1_var1.Operations).GetEnumerator()) //20:30
                select new { __loop1_var1 = __loop1_var1, op = op}
                ).ToList(); //20:4
            int __loop1_iteration = 0;
            foreach (var __tmp27 in __loop1_results)
            {
                ++__loop1_iteration;
                var __loop1_var1 = __tmp27.__loop1_var1;
                var op = __tmp27.op;
                string javaReturn = op.Result.Type.GetJavaName(); //22:5
                string name = op.Name; //23:5
                if (name.StartsWith("Get")) //24:5
                {
                    name = op.Name.Substring(3);
                }
                if (javaReturn.Contains("List")) //28:5
                {
                    string __tmp29Line = "	@RequestMapping(\"/"; //29:1
                    if (__tmp29Line != null) __out.Append(__tmp29Line);
                    StringBuilder __tmp30 = new StringBuilder();
                    __tmp30.Append(name);
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
                    string __tmp31Line = "\")"; //29:26
                    if (__tmp31Line != null) __out.Append(__tmp31Line);
                    __out.AppendLine(false); //29:28
                }
                else if (javaReturn != "void") //30:5
                {
                    string __tmp33Line = "	@RequestMapping(path=\"/\", params={action="; //31:1
                    if (__tmp33Line != null) __out.Append(__tmp33Line);
                    StringBuilder __tmp34 = new StringBuilder();
                    __tmp34.Append(name);
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
                    string __tmp35Line = "})"; //31:49
                    if (__tmp35Line != null) __out.Append(__tmp35Line);
                    __out.AppendLine(false); //31:51
                }
                else //32:5
                {
                    __out.Append("	@RequestMapping(\"/\") // + POST"); //33:1
                    __out.AppendLine(false); //33:32
                }
                string __tmp37Line = "	public String "; //35:1
                if (__tmp37Line != null) __out.Append(__tmp37Line);
                StringBuilder __tmp38 = new StringBuilder();
                __tmp38.Append(op.Name.ToCamelCase());
                using(StreamReader __tmp38Reader = new StreamReader(this.__ToStream(__tmp38.ToString())))
                {
                    bool __tmp38_first = true;
                    bool __tmp38_last = __tmp38Reader.EndOfStream;
                    while(__tmp38_first || !__tmp38_last)
                    {
                        __tmp38_first = false;
                        string __tmp38Line = __tmp38Reader.ReadLine();
                        __tmp38_last = __tmp38Reader.EndOfStream;
                        if (__tmp38Line != null) __out.Append(__tmp38Line);
                        if (!__tmp38_last) __out.AppendLine(true);
                    }
                }
                string __tmp39Line = "(Model model"; //35:39
                if (__tmp39Line != null) __out.Append(__tmp39Line);
                var __loop2_results = 
                    (from __loop2_var1 in __Enumerate((op).GetEnumerator()) //36:11
                    from param in __Enumerate((__loop2_var1.Parameters).GetEnumerator()) //36:15
                    select new { __loop2_var1 = __loop2_var1, param = param}
                    ).ToList(); //36:5
                int __loop2_iteration = 0;
                foreach (var __tmp40 in __loop2_results)
                {
                    ++__loop2_iteration;
                    var __loop2_var1 = __tmp40.__loop2_var1;
                    var param = __tmp40.param;
                    __out.Append(","); //37:1
                    __out.AppendLine(false); //37:2
                    string __tmp42Line = "		@RequestParam(value=\""; //38:1
                    if (__tmp42Line != null) __out.Append(__tmp42Line);
                    StringBuilder __tmp43 = new StringBuilder();
                    __tmp43.Append(param.Name.ToString().ToCamelCase());
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
                    string __tmp44Line = "\") "; //38:61
                    if (__tmp44Line != null) __out.Append(__tmp44Line);
                    StringBuilder __tmp45 = new StringBuilder();
                    __tmp45.Append(param.Type.GetJavaName());
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
                    string __tmp46Line = " "; //38:90
                    if (__tmp46Line != null) __out.Append(__tmp46Line);
                    StringBuilder __tmp47 = new StringBuilder();
                    __tmp47.Append(param.Name.ToString().ToCamelCase());
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
                }
                __out.Append(") {"); //40:1
                __out.AppendLine(false); //40:4
                string __tmp48Prefix = "		"; //41:1
                StringBuilder __tmp49 = new StringBuilder();
                __tmp49.Append(op.Result.Type.GetJavaName());
                using(StreamReader __tmp49Reader = new StreamReader(this.__ToStream(__tmp49.ToString())))
                {
                    bool __tmp49_first = true;
                    bool __tmp49_last = __tmp49Reader.EndOfStream;
                    while(__tmp49_first || !__tmp49_last)
                    {
                        __tmp49_first = false;
                        string __tmp49Line = __tmp49Reader.ReadLine();
                        __tmp49_last = __tmp49Reader.EndOfStream;
                        __out.Append(__tmp48Prefix);
                        if (__tmp49Line != null) __out.Append(__tmp49Line);
                        if (!__tmp49_last) __out.AppendLine(true);
                    }
                }
                string __tmp50Line = " result = "; //41:33
                if (__tmp50Line != null) __out.Append(__tmp50Line);
                StringBuilder __tmp51 = new StringBuilder();
                __tmp51.Append(reference.Name.ToCamelCase());
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
                string __tmp52Line = "."; //41:73
                if (__tmp52Line != null) __out.Append(__tmp52Line);
                StringBuilder __tmp53 = new StringBuilder();
                __tmp53.Append(op.Name.ToCamelCase());
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
                string __tmp54Line = "("; //41:97
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
                string __tmp56Line = ");"; //41:144
                if (__tmp56Line != null) __out.Append(__tmp56Line);
                __out.AppendLine(false); //41:146
                ArrayType array = (op.Result.Type as ArrayType); //42:10
                if (array != null) //43:4
                {
                    string __tmp58Line = "		model.addAttribute(\""; //44:1
                    if (__tmp58Line != null) __out.Append(__tmp58Line);
                    StringBuilder __tmp59 = new StringBuilder();
                    __tmp59.Append(array.InnerType.GetJavaName());
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
                    string __tmp60Line = "List\", result);"; //44:54
                    if (__tmp60Line != null) __out.Append(__tmp60Line);
                    __out.AppendLine(false); //44:69
                }
                else //45:4
                {
                    string __tmp62Line = "		model.addAttribute(\""; //46:1
                    if (__tmp62Line != null) __out.Append(__tmp62Line);
                    StringBuilder __tmp63 = new StringBuilder();
                    __tmp63.Append(op.Result.Type.GetJavaName());
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
                    string __tmp64Line = "\", result);"; //46:53
                    if (__tmp64Line != null) __out.Append(__tmp64Line);
                    __out.AppendLine(false); //46:64
                }
                if (javaReturn.Contains("List")) //48:4
                {
                    string __tmp66Line = "		return \""; //49:1
                    if (__tmp66Line != null) __out.Append(__tmp66Line);
                    StringBuilder __tmp67 = new StringBuilder();
                    __tmp67.Append(name);
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
                    string __tmp68Line = "\";"; //49:17
                    if (__tmp68Line != null) __out.Append(__tmp68Line);
                    __out.AppendLine(false); //49:19
                }
                else //50:5
                {
                    string __tmp70Line = "		return \""; //51:1
                    if (__tmp70Line != null) __out.Append(__tmp70Line);
                    StringBuilder __tmp71 = new StringBuilder();
                    __tmp71.Append(reference.Name);
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
                    string __tmp72Line = "View\";"; //51:27
                    if (__tmp72Line != null) __out.Append(__tmp72Line);
                    __out.AppendLine(false); //51:33
                }
                __out.Append("	}"); //53:1
                __out.AppendLine(false); //53:3
                __out.AppendLine(true); //54:2
            }
            __out.Append("}"); //56:1
            __out.AppendLine(false); //56:2
            return __out.ToString();
        }

        public string GenerateView(Reference reference) //61:1
        {
            StringBuilder __out = new StringBuilder();
            __out.Append("<!DOCTYPE html>"); //62:1
            __out.AppendLine(false); //62:16
            __out.Append("<html xmlns:th=\"http://www.thymeleaf.org\">"); //63:1
            __out.AppendLine(false); //63:43
            __out.Append("<head th:substituteby=\"_master :: head\">"); //64:1
            __out.AppendLine(false); //64:41
            __out.Append("    <title>Simple</title>"); //65:1
            __out.AppendLine(false); //65:26
            __out.Append("    <link rel=\"stylesheet\" href=\"../resources/css/foundation.min.css\"/>"); //66:1
            __out.AppendLine(false); //66:72
            __out.Append("    <link rel=\"stylesheet\" href=\"../resources/css/style.css\"/>"); //67:1
            __out.AppendLine(false); //67:63
            __out.Append("</head>"); //68:1
            __out.AppendLine(false); //68:8
            __out.Append("<body>"); //69:1
            __out.AppendLine(false); //69:7
            __out.AppendLine(true); //70:1
            __out.Append("<header class=\"template row\" th:substituteby=\"_master :: header\">"); //71:1
            __out.AppendLine(false); //71:66
            __out.Append("    <div class=\"small-10 columns\">"); //72:1
            __out.AppendLine(false); //72:35
            __out.Append("        <h1>//Title//</h1>"); //73:1
            __out.AppendLine(false); //73:27
            __out.Append("    </div>"); //74:1
            __out.AppendLine(false); //74:11
            __out.Append("</header>"); //75:1
            __out.AppendLine(false); //75:10
            __out.AppendLine(true); //76:1
            __out.Append("<div class=\"row\">"); //77:1
            __out.AppendLine(false); //77:18
            __out.Append("    <div class=\"small-10 columns\">"); //78:1
            __out.AppendLine(false); //78:35
            string __tmp2Line = "		<h2>"; //79:1
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
            string __tmp4Line = "</h2>"; //79:33
            if (__tmp4Line != null) __out.Append(__tmp4Line);
            __out.AppendLine(false); //79:38
            __out.AppendLine(true); //80:1
            int ids = 0; //81:2
            var __loop3_results = 
                (from __loop3_var1 in __Enumerate((reference.Interface).GetEnumerator()) //82:7
                from action in __Enumerate((__loop3_var1.Operations).GetEnumerator()) //82:28
                select new { __loop3_var1 = __loop3_var1, action = action}
                ).ToList(); //82:2
            int __loop3_iteration = 0;
            foreach (var __tmp5 in __loop3_results)
            {
                ++__loop3_iteration;
                var __loop3_var1 = __tmp5.__loop3_var1;
                var action = __tmp5.action;
                string actionName = action.Name; //83:3
                if (actionName.StartsWith("Get")) //84:3
                {
                    actionName = actionName.Substring(3);
                }
                string javaReturn = action.Result.Type.GetJavaName(); //88:3
                if (javaReturn.Contains("List") && !action.Parameters.Any()) //90:3
                {
                    string __tmp7Line = "		<a href=\""; //91:1
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
                    string __tmp9Line = ".html\">"; //91:24
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
                    string __tmp11Line = "</a>"; //91:43
                    if (__tmp11Line != null) __out.Append(__tmp11Line);
                    __out.AppendLine(false); //91:47
                }
                else //92:3
                {
                    if (javaReturn.Contains("List")) //93:4
                    {
                        string __tmp13Line = "		<form action=\""; //94:1
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
                        string __tmp15Line = ".html\">"; //94:29
                        if (__tmp15Line != null) __out.Append(__tmp15Line);
                        __out.AppendLine(false); //94:36
                    }
                    else //95:4
                    {
                        __out.Append("		<form>"); //96:1
                        __out.AppendLine(false); //96:9
                    }
                    if (action.Parameters.Any()) //99:4
                    {
                        __out.Append("			<fieldset>"); //100:1
                        __out.AppendLine(false); //100:14
                        string __tmp17Line = "				<legend>"; //101:1
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
                        string __tmp19Line = "</legend>"; //101:25
                        if (__tmp19Line != null) __out.Append(__tmp19Line);
                        __out.AppendLine(false); //101:34
                    }
                    if (javaReturn != "void" && !javaReturn.Contains("List")) //104:4
                    {
                        string __tmp21Line = "				<input type=\"hidden\" name=\"action\" value=\""; //105:1
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
                        string __tmp23Line = "\" />"; //105:59
                        if (__tmp23Line != null) __out.Append(__tmp23Line);
                        __out.AppendLine(false); //105:63
                    }
                    var __loop4_results = 
                        (from __loop4_var1 in __Enumerate((action).GetEnumerator()) //108:9
                        from input in __Enumerate((__loop4_var1.Parameters).GetEnumerator()) //108:17
                        select new { __loop4_var1 = __loop4_var1, input = input}
                        ).ToList(); //108:4
                    int __loop4_iteration = 0;
                    foreach (var __tmp24 in __loop4_results)
                    {
                        ++__loop4_iteration;
                        var __loop4_var1 = __tmp24.__loop4_var1;
                        var input = __tmp24.input;
                        string id = (ids++).ToString(); //109:5
                        string __tmp26Line = "				<label for=\""; //110:1
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
                        string __tmp28Line = "\">"; //110:21
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
                        string __tmp30Line = ": </label>"; //110:35
                        if (__tmp30Line != null) __out.Append(__tmp30Line);
                        __out.AppendLine(false); //110:45
                        string __tmp32Line = "				<input id=\""; //111:1
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
                        string __tmp34Line = "\" type=\"text\" name=\""; //111:20
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
                        string __tmp36Line = "\" />"; //111:52
                        if (__tmp36Line != null) __out.Append(__tmp36Line);
                        __out.AppendLine(false); //111:56
                    }
                    string __tmp38Line = "				<input type=\"submit\" value=\""; //113:1
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
                    string __tmp40Line = "\" />"; //113:46
                    if (__tmp40Line != null) __out.Append(__tmp40Line);
                    __out.AppendLine(false); //113:50
                    if (javaReturn != "void" && !javaReturn.Contains("List")) //115:4
                    {
                        string id = (ids++).ToString(); //116:5
                        string __tmp42Line = "				<input id=\""; //117:1
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
                        string __tmp44Line = "\" type=\"text\" name=\""; //117:20
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
                        string __tmp46Line = "Result\" disabled />"; //117:52
                        if (__tmp46Line != null) __out.Append(__tmp46Line);
                        __out.AppendLine(false); //117:71
                    }
                    if (action.Parameters.Any()) //119:4
                    {
                        __out.Append("			</fieldset>"); //120:1
                        __out.AppendLine(false); //120:15
                    }
                    __out.Append("		</form>"); //122:1
                    __out.AppendLine(false); //122:10
                }
                __out.Append("		<br/>"); //124:1
                __out.AppendLine(false); //124:8
            }
            __out.Append("    <div class=\"small-2 columns template\" th:substituteby=\"_master :: sidebar\">"); //126:1
            __out.AppendLine(false); //126:80
            __out.Append("        //side-nav menu//"); //127:1
            __out.AppendLine(false); //127:26
            __out.Append("    </div>"); //128:1
            __out.AppendLine(false); //128:11
            __out.Append("</div>"); //129:1
            __out.AppendLine(false); //129:7
            __out.AppendLine(true); //130:1
            __out.Append("<footer class=\"template row\" th:substituteby=\"_master :: footer\">"); //131:1
            __out.AppendLine(false); //131:66
            __out.Append("    <div class=\"large-12 columns\">"); //132:1
            __out.AppendLine(false); //132:35
            __out.Append("        <hr/>"); //133:1
            __out.AppendLine(false); //133:14
            __out.Append("        <div class=\"row\">"); //134:1
            __out.AppendLine(false); //134:26
            __out.Append("            <div class=\"small-4 columns\">"); //135:1
            __out.AppendLine(false); //135:42
            __out.Append("                //copyright//"); //136:1
            __out.AppendLine(false); //136:30
            __out.Append("            </div>"); //137:1
            __out.AppendLine(false); //137:19
            __out.Append("            <div class=\"small-8 columns\">"); //138:1
            __out.AppendLine(false); //138:42
            __out.Append("                <span class=\"right\">//powered by//</span>"); //139:1
            __out.AppendLine(false); //139:58
            __out.Append("            </div>"); //140:1
            __out.AppendLine(false); //140:19
            __out.Append("        </div>"); //141:1
            __out.AppendLine(false); //141:15
            __out.Append("    </div>"); //142:1
            __out.AppendLine(false); //142:11
            __out.Append("</footer>"); //143:1
            __out.AppendLine(false); //143:10
            __out.AppendLine(true); //144:1
            __out.Append("</body>"); //145:1
            __out.AppendLine(false); //145:8
            __out.Append("</html>"); //146:1
            __out.AppendLine(false); //146:8
            return __out.ToString();
        }

        public string GenerateListView(Struct entity) //151:1
        {
            StringBuilder __out = new StringBuilder();
            __out.Append("<!DOCTYPE html>"); //152:1
            __out.AppendLine(false); //152:16
            __out.Append("<html xmlns:th=\"http://www.thymeleaf.org\">"); //153:1
            __out.AppendLine(false); //153:43
            __out.Append("<head th:substituteby=\"_master :: head\">"); //154:1
            __out.AppendLine(false); //154:41
            __out.Append("    <title>Simple</title>"); //155:1
            __out.AppendLine(false); //155:26
            __out.Append("    <link rel=\"stylesheet\" href=\"../resources/css/foundation.min.css\"/>"); //156:1
            __out.AppendLine(false); //156:72
            __out.Append("    <link rel=\"stylesheet\" href=\"../resources/css/style.css\"/>"); //157:1
            __out.AppendLine(false); //157:63
            __out.Append("</head>"); //158:1
            __out.AppendLine(false); //158:8
            __out.Append("<body>"); //159:1
            __out.AppendLine(false); //159:7
            __out.AppendLine(true); //160:1
            __out.Append("<header class=\"template row\" th:substituteby=\"_master :: header\">"); //161:1
            __out.AppendLine(false); //161:66
            __out.Append("    <div class=\"small-10 columns\">"); //162:1
            __out.AppendLine(false); //162:35
            __out.Append("        <h1>//Title//</h1>"); //163:1
            __out.AppendLine(false); //163:27
            __out.Append("    </div>"); //164:1
            __out.AppendLine(false); //164:11
            __out.Append("</header>"); //165:1
            __out.AppendLine(false); //165:10
            __out.AppendLine(true); //166:1
            __out.Append("<div class=\"row\">"); //167:1
            __out.AppendLine(false); //167:18
            __out.Append("    <div class=\"small-10 columns\">"); //168:1
            __out.AppendLine(false); //168:35
            string __tmp2Line = "        <h2>"; //169:1
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
            string __tmp4Line = " list</h2>"; //169:26
            if (__tmp4Line != null) __out.Append(__tmp4Line);
            __out.AppendLine(false); //169:36
            __out.AppendLine(true); //170:1
            __out.Append("        <table>"); //171:1
            __out.AppendLine(false); //171:16
            __out.Append("            <tr>"); //172:1
            __out.AppendLine(false); //172:17
            var __loop5_results = 
                (from __loop5_var1 in __Enumerate((entity).GetEnumerator()) //173:9
                from property in __Enumerate((__loop5_var1.Properties).GetEnumerator()) //173:17
                select new { __loop5_var1 = __loop5_var1, property = property}
                ).ToList(); //173:4
            int __loop5_iteration = 0;
            foreach (var __tmp5 in __loop5_results)
            {
                ++__loop5_iteration;
                var __loop5_var1 = __tmp5.__loop5_var1;
                var property = __tmp5.property;
                string __tmp7Line = "                <th>"; //174:1
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
                string __tmp9Line = "</th>"; //174:36
                if (__tmp9Line != null) __out.Append(__tmp9Line);
                __out.AppendLine(false); //174:41
            }
            __out.Append("            </tr>"); //176:1
            __out.AppendLine(false); //176:18
            string __tmp11Line = "            <tr th:each=\""; //177:1
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
            string __tmp13Line = " : ${"; //177:53
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
            string __tmp15Line = "List}\">"; //177:85
            if (__tmp15Line != null) __out.Append(__tmp15Line);
            __out.AppendLine(false); //177:92
            var __loop6_results = 
                (from __loop6_var1 in __Enumerate((entity).GetEnumerator()) //178:9
                from property in __Enumerate((__loop6_var1.Properties).GetEnumerator()) //178:17
                select new { __loop6_var1 = __loop6_var1, property = property}
                ).ToList(); //178:4
            int __loop6_iteration = 0;
            foreach (var __tmp16 in __loop6_results)
            {
                ++__loop6_iteration;
                var __loop6_var1 = __tmp16.__loop6_var1;
                var property = __tmp16.property;
                string __tmp18Line = "				<td th:text=\"${"; //179:1
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
                string __tmp20Line = "."; //179:47
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
                string __tmp22Line = "}\">Data</td>"; //179:77
                if (__tmp22Line != null) __out.Append(__tmp22Line);
                __out.AppendLine(false); //179:89
            }
            __out.Append("            </tr>"); //181:1
            __out.AppendLine(false); //181:18
            __out.Append("        </table>"); //182:1
            __out.AppendLine(false); //182:17
            __out.Append("    </div>"); //183:1
            __out.AppendLine(false); //183:11
            __out.Append("    <div class=\"small-2 columns template\" th:substituteby=\"_master :: sidebar\">"); //184:1
            __out.AppendLine(false); //184:80
            __out.Append("        //side-nav menu//"); //185:1
            __out.AppendLine(false); //185:26
            __out.Append("    </div>"); //186:1
            __out.AppendLine(false); //186:11
            __out.Append("</div>"); //187:1
            __out.AppendLine(false); //187:7
            __out.AppendLine(true); //188:1
            __out.Append("<footer class=\"template row\" th:substituteby=\"_master :: footer\">"); //189:1
            __out.AppendLine(false); //189:66
            __out.Append("    <div class=\"large-12 columns\">"); //190:1
            __out.AppendLine(false); //190:35
            __out.Append("        <hr/>"); //191:1
            __out.AppendLine(false); //191:14
            __out.Append("        <div class=\"row\">"); //192:1
            __out.AppendLine(false); //192:26
            __out.Append("            <div class=\"small-4 columns\">"); //193:1
            __out.AppendLine(false); //193:42
            __out.Append("                //copyright//"); //194:1
            __out.AppendLine(false); //194:30
            __out.Append("            </div>"); //195:1
            __out.AppendLine(false); //195:19
            __out.Append("            <div class=\"small-8 columns\">"); //196:1
            __out.AppendLine(false); //196:42
            __out.Append("                <span class=\"right\">//powered by//</span>"); //197:1
            __out.AppendLine(false); //197:58
            __out.Append("            </div>"); //198:1
            __out.AppendLine(false); //198:19
            __out.Append("        </div>"); //199:1
            __out.AppendLine(false); //199:15
            __out.Append("    </div>"); //200:1
            __out.AppendLine(false); //200:11
            __out.Append("</footer>"); //201:1
            __out.AppendLine(false); //201:10
            __out.AppendLine(true); //202:1
            __out.Append("</body>"); //203:1
            __out.AppendLine(false); //203:8
            __out.Append("</html>"); //204:1
            __out.AppendLine(false); //204:8
            return __out.ToString();
        }

        public string GenerateMasterView(string applicationName, List<ViewInfoHolder> views) //209:1
        {
            StringBuilder __out = new StringBuilder();
            __out.Append("<!DOCTYPE html>"); //210:1
            __out.AppendLine(false); //210:16
            __out.Append("<html xmlns:th=\"http://www.thymeleaf.org\">"); //211:1
            __out.AppendLine(false); //211:43
            __out.AppendLine(true); //212:1
            __out.Append("<head th:fragment=\"head\">"); //213:1
            __out.AppendLine(false); //213:26
            string __tmp2Line = "    <title>"; //214:1
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
            string __tmp4Line = "</title>"; //214:29
            if (__tmp4Line != null) __out.Append(__tmp4Line);
            __out.AppendLine(false); //214:37
            __out.Append("    <meta name=\"viewport\" content=\"width=device-width\"/>"); //215:1
            __out.AppendLine(false); //215:57
            __out.Append("    <link rel=\"stylesheet\" href=\"../resources/css/normalize.css\""); //216:1
            __out.AppendLine(false); //216:65
            __out.Append("          th:href=\"@{/resources/css/normalize.css}\"/>"); //217:1
            __out.AppendLine(false); //217:54
            __out.Append("    <link rel=\"stylesheet\" href=\"../resources/css/foundation.min.css\""); //218:1
            __out.AppendLine(false); //218:70
            __out.Append("          th:href=\"@{/resources/css/foundation.min.css}\"/>"); //219:1
            __out.AppendLine(false); //219:59
            __out.Append("    <link rel=\"stylesheet\" href=\"../resources/css/style.css\""); //220:1
            __out.AppendLine(false); //220:61
            __out.Append("          th:href=\"@{/resources/css/style.css}\"/>"); //221:1
            __out.AppendLine(false); //221:50
            __out.Append("    <script type=\"text/javascript\" src=\"../resources/js/vendor/custom.modernizr.js\""); //222:1
            __out.AppendLine(false); //222:84
            __out.Append("            th:src=\"@{/resources/js/vendor/custom.modernizr.js}\"></script>"); //223:1
            __out.AppendLine(false); //223:75
            __out.Append("    <script type=\"text/javascript\" src=\"../resources/js/vendor/jquery.js\""); //224:1
            __out.AppendLine(false); //224:74
            __out.Append("            th:src=\"@{/resources/js/vendor/jquery.js}\"></script>"); //225:1
            __out.AppendLine(false); //225:65
            __out.Append("    <script type=\"text/javascript\" src=\"../resources/js/foundation.min.js\""); //226:1
            __out.AppendLine(false); //226:75
            __out.Append("            th:src=\"@{/resources/js/foundation.min.js}\"></script>"); //227:1
            __out.AppendLine(false); //227:66
            __out.Append("    <script type=\"text/javascript\" src=\"../resources/js/app.js\""); //228:1
            __out.AppendLine(false); //228:64
            __out.Append("            th:src=\"@{/resources/js/app.js}\"></script>"); //229:1
            __out.AppendLine(false); //229:55
            __out.Append("</head>"); //230:1
            __out.AppendLine(false); //230:8
            __out.AppendLine(true); //231:1
            __out.Append("<body>"); //232:1
            __out.AppendLine(false); //232:7
            __out.AppendLine(true); //233:1
            __out.Append("<header class=\"row\" th:fragment=\"header\">"); //234:1
            __out.AppendLine(false); //234:42
            __out.Append("    <div class=\"small-10 columns\">"); //235:1
            __out.AppendLine(false); //235:35
            string __tmp6Line = "        <h1>"; //236:1
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
            string __tmp8Line = "</h1>"; //236:30
            if (__tmp8Line != null) __out.Append(__tmp8Line);
            __out.AppendLine(false); //236:35
            __out.Append("    </div>"); //237:1
            __out.AppendLine(false); //237:11
            __out.Append("</header>"); //238:1
            __out.AppendLine(false); //238:10
            __out.AppendLine(true); //239:1
            __out.Append("<div class=\"row\">"); //240:1
            __out.AppendLine(false); //240:18
            __out.Append("    <div class=\"small-10 columns template\">"); //241:1
            __out.AppendLine(false); //241:44
            __out.Append("        <h2>//content title//</h2>"); //242:1
            __out.AppendLine(false); //242:35
            __out.Append("        <p>//content//</p>"); //244:1
            __out.AppendLine(false); //244:27
            __out.Append("    </div>"); //245:1
            __out.AppendLine(false); //245:11
            __out.AppendLine(true); //246:1
            __out.Append("    <div class=\"small-2 columns\" th:fragment=\"sidebar\">"); //247:1
            __out.AppendLine(false); //247:56
            __out.Append("        <div style=\"width: 140px; margin: 0 auto\">"); //248:1
            __out.AppendLine(false); //248:51
            __out.Append("            <ul class=\"side-nav\">"); //249:1
            __out.AppendLine(false); //249:34
            var __loop7_results = 
                (from view in __Enumerate((views).GetEnumerator()) //250:10
                select new { view = view}
                ).ToList(); //250:5
            int __loop7_iteration = 0;
            foreach (var __tmp9 in __loop7_results)
            {
                ++__loop7_iteration;
                var view = __tmp9.view;
                string __tmp11Line = "                <li><a href=\""; //251:1
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
                string __tmp13Line = "\" th:href=\"@{/"; //251:45
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
                string __tmp15Line = "}\" th:text=\"#{page."; //251:73
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
                string __tmp17Line = "}\">"; //251:103
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
                string __tmp19Line = "</a></li>"; //251:117
                if (__tmp19Line != null) __out.Append(__tmp19Line);
                __out.AppendLine(false); //251:126
            }
            __out.Append("            </ul>"); //253:1
            __out.AppendLine(false); //253:18
            __out.Append("        </div>"); //254:1
            __out.AppendLine(false); //254:15
            __out.Append("    </div>"); //255:1
            __out.AppendLine(false); //255:11
            __out.Append("</div>"); //256:1
            __out.AppendLine(false); //256:7
            __out.AppendLine(true); //257:1
            __out.Append("<footer class=\"row\" th:fragment=\"footer\">"); //258:1
            __out.AppendLine(false); //258:42
            __out.Append("    <div class=\"large-12 columns\">"); //259:1
            __out.AppendLine(false); //259:35
            __out.Append("        <hr/>"); //260:1
            __out.AppendLine(false); //260:14
            __out.Append("        <div class=\"row\">"); //261:1
            __out.AppendLine(false); //261:26
            __out.Append("            <div class=\"small-4 columns\">"); //262:1
            __out.AppendLine(false); //262:42
            __out.Append("                <p>&copy; Copyright BME IIT</p>"); //263:1
            __out.AppendLine(false); //263:48
            __out.Append("            </div>"); //264:1
            __out.AppendLine(false); //264:19
            __out.Append("            <div class=\"small-8 columns\">"); //265:1
            __out.AppendLine(false); //265:42
            __out.Append("                <ul class=\"inline-list right\">"); //266:1
            __out.AppendLine(false); //266:47
            __out.Append("                    <li>Powered by</li>"); //267:1
            __out.AppendLine(false); //267:40
            __out.Append("                    <li><a href=\"http://www.spring.io/\">Spring</a></li>"); //268:1
            __out.AppendLine(false); //268:72
            __out.Append("                    <li><a href=\"http://www.thymeleaf.org/\">Thymeleaf</a></li>"); //269:1
            __out.AppendLine(false); //269:79
            __out.Append("                    <li><a href=\"http://foundation.zurb.com/\">Foundation</a></li>"); //270:1
            __out.AppendLine(false); //270:82
            __out.Append("                </ul>"); //271:1
            __out.AppendLine(false); //271:22
            __out.Append("            </div>"); //272:1
            __out.AppendLine(false); //272:19
            __out.Append("        </div>"); //273:1
            __out.AppendLine(false); //273:15
            __out.Append("    </div>"); //274:1
            __out.AppendLine(false); //274:11
            __out.Append("</footer>"); //275:1
            __out.AppendLine(false); //275:10
            __out.AppendLine(true); //276:1
            __out.Append("</body>"); //277:1
            __out.AppendLine(false); //277:8
            __out.Append("</html>"); //278:1
            __out.AppendLine(false); //278:8
            return __out.ToString();
        }

        public string GenerateWebXml() //283:1
        {
            StringBuilder __out = new StringBuilder();
            __out.Append("<?xml version=\"1.0\" encoding=\"UTF-8\"?>"); //284:1
            __out.AppendLine(false); //284:39
            __out.Append("<web-app xmlns=\"http://java.sun.com/xml/ns/javaee\""); //285:1
            __out.AppendLine(false); //285:51
            __out.Append("         xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\""); //286:1
            __out.AppendLine(false); //286:63
            __out.Append("         xsi:schemaLocation=\"http://java.sun.com/xml/ns/javaee"); //287:1
            __out.AppendLine(false); //287:63
            __out.Append("		 http://java.sun.com/xml/ns/javaee/web-app_3_0.xsd\" version=\"3.0\">"); //288:1
            __out.AppendLine(false); //288:69
            __out.AppendLine(true); //289:1
            __out.Append("    <servlet>"); //290:1
            __out.AppendLine(false); //290:14
            __out.Append("        <servlet-name>spring</servlet-name>"); //291:1
            __out.AppendLine(false); //291:44
            __out.Append("        <servlet-class>org.springframework.web.servlet.DispatcherServlet</servlet-class>"); //292:1
            __out.AppendLine(false); //292:89
            __out.Append("        <load-on-startup>1</load-on-startup>"); //293:1
            __out.AppendLine(false); //293:45
            __out.Append("    </servlet>"); //294:1
            __out.AppendLine(false); //294:15
            __out.AppendLine(true); //295:1
            __out.Append("    <servlet-mapping>"); //296:1
            __out.AppendLine(false); //296:22
            __out.Append("        <servlet-name>spring</servlet-name>"); //297:1
            __out.AppendLine(false); //297:44
            __out.Append("        <url-pattern>/*</url-pattern>"); //298:1
            __out.AppendLine(false); //298:38
            __out.Append("    </servlet-mapping>"); //299:1
            __out.AppendLine(false); //299:23
            __out.AppendLine(true); //300:1
            __out.Append("    <context-param>"); //301:1
            __out.AppendLine(false); //301:20
            __out.Append("        <param-name>contextConfigLocation</param-name>"); //302:1
            __out.AppendLine(false); //302:55
            __out.Append("        <param-value>/WEB-INF/spring-config.xml</param-value>"); //303:1
            __out.AppendLine(false); //303:62
            __out.Append("    </context-param>"); //304:1
            __out.AppendLine(false); //304:21
            __out.AppendLine(true); //305:1
            __out.Append("    <listener>"); //306:1
            __out.AppendLine(false); //306:15
            __out.Append("        <listener-class>org.springframework.web.context.ContextLoaderListener</listener-class>"); //307:1
            __out.AppendLine(false); //307:95
            __out.Append("    </listener>"); //308:1
            __out.AppendLine(false); //308:16
            __out.AppendLine(true); //309:1
            __out.Append("    <filter>"); //310:1
            __out.AppendLine(false); //310:13
            __out.Append("        <filter-name>characterEncodingFilter</filter-name>"); //311:1
            __out.AppendLine(false); //311:59
            __out.Append("        <filter-class>org.springframework.web.filter.CharacterEncodingFilter</filter-class>"); //312:1
            __out.AppendLine(false); //312:92
            __out.Append("        <init-param>"); //313:1
            __out.AppendLine(false); //313:21
            __out.Append("            <param-name>encoding</param-name>"); //314:1
            __out.AppendLine(false); //314:46
            __out.Append("            <param-value>UTF-8</param-value>"); //315:1
            __out.AppendLine(false); //315:45
            __out.Append("        </init-param>"); //316:1
            __out.AppendLine(false); //316:22
            __out.Append("    </filter>"); //317:1
            __out.AppendLine(false); //317:14
            __out.AppendLine(true); //318:1
            __out.Append("    <filter-mapping>"); //319:1
            __out.AppendLine(false); //319:21
            __out.Append("        <filter-name>characterEncodingFilter</filter-name>"); //320:1
            __out.AppendLine(false); //320:59
            __out.Append("        <servlet-name>spring</servlet-name>"); //321:1
            __out.AppendLine(false); //321:44
            __out.Append("    </filter-mapping>"); //322:1
            __out.AppendLine(false); //322:22
            __out.AppendLine(true); //323:1
            __out.Append("</web-app>"); //324:1
            __out.AppendLine(false); //324:11
            return __out.ToString();
        }

        public string GenerateServlet(Namespace ns) //328:1
        {
            StringBuilder __out = new StringBuilder();
            __out.Append("<?xml version=\"1.0\" encoding=\"UTF-8\"?>"); //329:1
            __out.AppendLine(false); //329:39
            __out.Append("<beans xmlns=\"http://www.springframework.org/schema/beans\""); //330:1
            __out.AppendLine(false); //330:59
            __out.Append("       xmlns:mvc=\"http://www.springframework.org/schema/mvc\""); //331:1
            __out.AppendLine(false); //331:61
            __out.Append("       xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\""); //332:1
            __out.AppendLine(false); //332:61
            __out.Append("       xmlns:context=\"http://www.springframework.org/schema/context\""); //333:1
            __out.AppendLine(false); //333:69
            __out.Append("       xsi:schemaLocation=\"http://www.springframework.org/schema/beans"); //334:1
            __out.AppendLine(false); //334:71
            __out.Append("                           http://www.springframework.org/schema/beans/spring-beans.xsd"); //335:1
            __out.AppendLine(false); //335:88
            __out.Append("                           http://www.springframework.org/schema/context"); //336:1
            __out.AppendLine(false); //336:73
            __out.Append("                           http://www.springframework.org/schema/context/spring-context.xsd"); //337:1
            __out.AppendLine(false); //337:92
            __out.Append("                           http://www.springframework.org/schema/mvc"); //338:1
            __out.AppendLine(false); //338:69
            __out.Append("                           http://www.springframework.org/schema/mvc/spring-mvc.xsd\">"); //339:1
            __out.AppendLine(false); //339:86
            __out.AppendLine(true); //340:1
            string __tmp2Line = "    <context:component-scan base-package=\""; //341:1
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
            string __tmp4Line = "."; //341:56
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
            string __tmp6Line = "\"/>"; //341:107
            if (__tmp6Line != null) __out.Append(__tmp6Line);
            __out.AppendLine(false); //341:110
            __out.AppendLine(true); //342:1
            __out.Append("    <mvc:annotation-driven/>"); //343:1
            __out.AppendLine(false); //343:29
            __out.AppendLine(true); //344:1
            __out.Append("    <!--<mvc:resources mapping=\"/favicon.ico\" location=\"/WEB-INF/resources/img/\"/>-->"); //345:1
            __out.AppendLine(false); //345:86
            __out.Append("    <mvc:resources mapping=\"/resources/**\" location=\"/WEB-INF/resources/\"/>"); //346:1
            __out.AppendLine(false); //346:76
            __out.AppendLine(true); //347:1
            __out.Append("    <mvc:interceptors>"); //348:1
            __out.AppendLine(false); //348:23
            __out.Append("        <bean class=\"org.springframework.web.servlet.i18n.LocaleChangeInterceptor\">"); //349:1
            __out.AppendLine(false); //349:84
            __out.Append("            <property name=\"paramName\" value=\"lang\"/>"); //350:1
            __out.AppendLine(false); //350:54
            __out.Append("        </bean>"); //351:1
            __out.AppendLine(false); //351:16
            __out.Append("    </mvc:interceptors>"); //352:1
            __out.AppendLine(false); //352:24
            __out.AppendLine(true); //353:1
            __out.Append("    <bean id=\"templateResolver\" class=\"org.thymeleaf.templateresolver.ServletContextTemplateResolver\">"); //354:1
            __out.AppendLine(false); //354:103
            __out.Append("        <property name=\"prefix\" value=\"/WEB-INF/view/\"/>"); //355:1
            __out.AppendLine(false); //355:57
            __out.Append("        <property name=\"suffix\" value=\".html\"/>"); //356:1
            __out.AppendLine(false); //356:48
            __out.Append("        <property name=\"characterEncoding\" value=\"UTF-8\"/>"); //357:1
            __out.AppendLine(false); //357:59
            __out.Append("        <property name=\"templateMode\" value=\"HTML5\"/>"); //358:1
            __out.AppendLine(false); //358:54
            __out.Append("        <property name=\"cacheable\" value=\"false\"/>"); //359:1
            __out.AppendLine(false); //359:51
            __out.Append("    </bean>"); //360:1
            __out.AppendLine(false); //360:12
            __out.AppendLine(true); //361:1
            __out.Append("    <bean id=\"templateEngine\" class=\"org.thymeleaf.spring4.SpringTemplateEngine\">"); //362:1
            __out.AppendLine(false); //362:82
            __out.Append("        <property name=\"templateResolver\" ref=\"templateResolver\"/>"); //363:1
            __out.AppendLine(false); //363:67
            __out.Append("    </bean>"); //364:1
            __out.AppendLine(false); //364:12
            __out.AppendLine(true); //365:1
            __out.Append("    <bean class=\"org.thymeleaf.spring4.view.ThymeleafViewResolver\">"); //366:1
            __out.AppendLine(false); //366:68
            __out.Append("        <property name=\"templateEngine\" ref=\"templateEngine\"/>"); //367:1
            __out.AppendLine(false); //367:63
            __out.Append("        <property name=\"contentType\" value=\"text/html; charset=UTF-8\"/>"); //368:1
            __out.AppendLine(false); //368:72
            __out.Append("        <property name=\"characterEncoding\" value=\"UTF-8\"/>"); //369:1
            __out.AppendLine(false); //369:59
            __out.Append("    </bean>"); //370:1
            __out.AppendLine(false); //370:12
            __out.AppendLine(true); //371:1
            __out.Append("    <bean id=\"localeResolver\" class=\"org.springframework.web.servlet.i18n.SessionLocaleResolver\"/>"); //372:1
            __out.AppendLine(false); //372:99
            __out.AppendLine(true); //373:1
            __out.Append("</beans>"); //374:1
            __out.AppendLine(false); //374:9
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
