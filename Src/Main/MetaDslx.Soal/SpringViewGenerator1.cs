using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Soal //1:1
{
    using __Hidden_SpringViewGenerator_418060360;
    namespace __Hidden_SpringViewGenerator_418060360
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

        public string GenerateIndexController(Namespace ns) //8:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp2Line = "package "; //9:1
            if (__tmp2Line != null) __out.Append(__tmp2Line);
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(ns.FullName.ToLower());
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
            string __tmp4Line = "."; //9:32
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
            string __tmp6Line = ";"; //9:83
            if (__tmp6Line != null) __out.Append(__tmp6Line);
            __out.AppendLine(false); //9:84
            __out.AppendLine(true); //10:1
            __out.Append("import org.springframework.stereotype.Controller;"); //11:1
            __out.AppendLine(false); //11:50
            __out.Append("import org.springframework.web.bind.annotation.RequestMapping;"); //12:1
            __out.AppendLine(false); //12:63
            __out.Append("import org.springframework.web.bind.annotation.RequestMethod;"); //13:1
            __out.AppendLine(false); //13:62
            __out.AppendLine(true); //14:1
            __out.Append("@Controller"); //15:1
            __out.AppendLine(false); //15:12
            __out.Append("@RequestMapping(method = RequestMethod.GET)"); //16:1
            __out.AppendLine(false); //16:44
            __out.Append("public class IndexController {"); //17:1
            __out.AppendLine(false); //17:31
            __out.AppendLine(true); //18:2
            __out.Append("	@RequestMapping(\"/\")"); //19:1
            __out.AppendLine(false); //19:22
            __out.Append("	public String index() {"); //20:1
            __out.AppendLine(false); //20:25
            __out.Append("		return \"index\";"); //21:1
            __out.AppendLine(false); //21:18
            __out.Append("	}"); //22:1
            __out.AppendLine(false); //22:3
            __out.Append("}"); //23:1
            __out.AppendLine(false); //23:2
            return __out.ToString();
        }

        public string GenerateController(Reference reference) //28:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp2Line = "package "; //29:1
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
            string __tmp4Line = "."; //29:62
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
            string __tmp6Line = ";"; //29:113
            if (__tmp6Line != null) __out.Append(__tmp6Line);
            __out.AppendLine(false); //29:114
            __out.AppendLine(true); //30:1
            __out.Append("import org.springframework.beans.factory.annotation.Autowired;"); //31:1
            __out.AppendLine(false); //31:63
            __out.Append("import org.springframework.stereotype.Controller;"); //32:1
            __out.AppendLine(false); //32:50
            __out.Append("import org.springframework.ui.Model;"); //33:1
            __out.AppendLine(false); //33:37
            __out.Append("import org.springframework.web.bind.annotation.RequestMapping;"); //34:1
            __out.AppendLine(false); //34:63
            __out.Append("import org.springframework.web.bind.annotation.RequestMethod;"); //35:1
            __out.AppendLine(false); //35:62
            __out.Append("import org.springframework.web.bind.annotation.RequestParam;"); //36:1
            __out.AppendLine(false); //36:61
            __out.AppendLine(true); //37:1
            string __tmp8Line = "import "; //38:1
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
            string __tmp10Line = "."; //38:61
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
            string __tmp12Line = "."; //38:111
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
            string __tmp15Line = ";"; //38:185
            if (__tmp15Line != null) __out.Append(__tmp15Line);
            __out.AppendLine(false); //38:186
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
                    __out.AppendLine(false); //39:66
                }
            }
            __out.AppendLine(true); //40:1
            __out.Append("@Controller"); //41:1
            __out.AppendLine(false); //41:12
            string __tmp19Line = "@RequestMapping(value = \""; //42:1
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
            string __tmp21Line = "\", method = RequestMethod.GET)"; //42:42
            if (__tmp21Line != null) __out.Append(__tmp21Line);
            __out.AppendLine(false); //42:72
            string __tmp23Line = "public class "; //43:1
            if (__tmp23Line != null) __out.Append(__tmp23Line);
            StringBuilder __tmp24 = new StringBuilder();
            __tmp24.Append(reference.Name);
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
            string __tmp25Line = "Controller {"; //43:30
            if (__tmp25Line != null) __out.Append(__tmp25Line);
            __out.AppendLine(false); //43:42
            __out.AppendLine(true); //44:1
            __out.Append("	@Autowired"); //45:1
            __out.AppendLine(false); //45:12
            string __tmp27Line = "	private "; //46:1
            if (__tmp27Line != null) __out.Append(__tmp27Line);
            StringBuilder __tmp28 = new StringBuilder();
            __tmp28.Append(reference.Interface.Name);
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
            __tmp29.Append(SpringGeneratorUtil.GetBindingType(reference));
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
            string __tmp30Line = " "; //46:83
            if (__tmp30Line != null) __out.Append(__tmp30Line);
            StringBuilder __tmp31 = new StringBuilder();
            __tmp31.Append(reference.Name.ToCamelCase());
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
            string __tmp32Line = ";"; //46:114
            if (__tmp32Line != null) __out.Append(__tmp32Line);
            __out.AppendLine(false); //46:115
            __out.AppendLine(true); //47:2
            __out.Append("	@RequestMapping(\"/\")"); //48:1
            __out.AppendLine(false); //48:22
            __out.Append("	public String index() {"); //49:1
            __out.AppendLine(false); //49:25
            string __tmp34Line = "		return \""; //50:1
            if (__tmp34Line != null) __out.Append(__tmp34Line);
            StringBuilder __tmp35 = new StringBuilder();
            __tmp35.Append(reference.Name);
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
            string __tmp36Line = "View\";"; //50:27
            if (__tmp36Line != null) __out.Append(__tmp36Line);
            __out.AppendLine(false); //50:33
            __out.Append("	}"); //51:1
            __out.AppendLine(false); //51:3
            __out.AppendLine(true); //52:2
            var __loop1_results = 
                (from __loop1_var1 in __Enumerate((reference.Interface).GetEnumerator()) //53:9
                from op in __Enumerate((__loop1_var1.Operations).GetEnumerator()) //53:30
                select new { __loop1_var1 = __loop1_var1, op = op}
                ).ToList(); //53:4
            int __loop1_iteration = 0;
            foreach (var __tmp37 in __loop1_results)
            {
                ++__loop1_iteration;
                var __loop1_var1 = __tmp37.__loop1_var1;
                var op = __tmp37.op;
                string javaReturn = op.Result.Type.GetJavaName(); //55:5
                string name = op.Name; //56:5
                if (name.StartsWith("Get")) //57:5
                {
                    name = op.Name.Substring(3);
                }
                if (javaReturn.Contains("List")) //61:5
                {
                    string __tmp39Line = "	@RequestMapping(\"/"; //62:1
                    if (__tmp39Line != null) __out.Append(__tmp39Line);
                    StringBuilder __tmp40 = new StringBuilder();
                    __tmp40.Append(name);
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
                    string __tmp41Line = "\")  // + POST"; //62:26
                    if (__tmp41Line != null) __out.Append(__tmp41Line);
                    __out.AppendLine(false); //62:39
                }
                else //63:5
                {
                    string __tmp43Line = "	@RequestMapping(value=\"/\", params={\"action="; //64:1
                    if (__tmp43Line != null) __out.Append(__tmp43Line);
                    StringBuilder __tmp44 = new StringBuilder();
                    __tmp44.Append(name);
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
                    string __tmp45Line = "\"})"; //64:51
                    if (__tmp45Line != null) __out.Append(__tmp45Line);
                    __out.AppendLine(false); //64:54
                }
                string __tmp47Line = "	public String "; //66:1
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
                string __tmp49Line = "(Model model"; //66:39
                if (__tmp49Line != null) __out.Append(__tmp49Line);
                var __loop2_results = 
                    (from __loop2_var1 in __Enumerate((op).GetEnumerator()) //67:11
                    from param in __Enumerate((__loop2_var1.Parameters).GetEnumerator()) //67:15
                    select new { __loop2_var1 = __loop2_var1, param = param}
                    ).ToList(); //67:5
                int __loop2_iteration = 0;
                foreach (var __tmp50 in __loop2_results)
                {
                    ++__loop2_iteration;
                    var __loop2_var1 = __tmp50.__loop2_var1;
                    var param = __tmp50.param;
                    __out.Append(","); //68:1
                    __out.AppendLine(false); //68:2
                    string __tmp52Line = "		@RequestParam(value=\""; //69:1
                    if (__tmp52Line != null) __out.Append(__tmp52Line);
                    StringBuilder __tmp53 = new StringBuilder();
                    __tmp53.Append(param.Name.ToString().ToCamelCase());
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
                    string __tmp54Line = "\") "; //69:61
                    if (__tmp54Line != null) __out.Append(__tmp54Line);
                    StringBuilder __tmp55 = new StringBuilder();
                    __tmp55.Append(param.Type.GetJavaName());
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
                    string __tmp56Line = " "; //69:90
                    if (__tmp56Line != null) __out.Append(__tmp56Line);
                    StringBuilder __tmp57 = new StringBuilder();
                    __tmp57.Append(param.Name.ToString().ToCamelCase());
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
                }
                __out.Append(") {"); //71:1
                __out.AppendLine(false); //71:4
                if (op.Exceptions.Any()) //72:3
                {
                    __out.Append("		try {"); //73:1
                    __out.AppendLine(false); //73:8
                    string __tmp58Prefix = "			"; //74:1
                    StringBuilder __tmp59 = new StringBuilder();
                    __tmp59.Append(ControllerMethodImpl(reference, op));
                    using(StreamReader __tmp59Reader = new StreamReader(this.__ToStream(__tmp59.ToString())))
                    {
                        bool __tmp59_first = true;
                        bool __tmp59_last = __tmp59Reader.EndOfStream;
                        while(__tmp59_first || !__tmp59_last)
                        {
                            __tmp59_first = false;
                            string __tmp59Line = __tmp59Reader.ReadLine();
                            __tmp59_last = __tmp59Reader.EndOfStream;
                            __out.Append(__tmp58Prefix);
                            if (__tmp59Line != null) __out.Append(__tmp59Line);
                            if (!__tmp59_last) __out.AppendLine(true);
                            __out.AppendLine(false); //74:41
                        }
                    }
                    var __loop3_results = 
                        (from __loop3_var1 in __Enumerate((op).GetEnumerator()) //75:9
                        from ex in __Enumerate((__loop3_var1.Exceptions).GetEnumerator()) //75:13
                        select new { __loop3_var1 = __loop3_var1, ex = ex}
                        ).ToList(); //75:4
                    int __loop3_iteration = 0;
                    foreach (var __tmp60 in __loop3_results)
                    {
                        ++__loop3_iteration;
                        var __loop3_var1 = __tmp60.__loop3_var1;
                        var ex = __tmp60.ex;
                        string __tmp62Line = "		} catch ("; //76:1
                        if (__tmp62Line != null) __out.Append(__tmp62Line);
                        StringBuilder __tmp63 = new StringBuilder();
                        __tmp63.Append(ex.GetJavaName());
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
                        string __tmp64Line = " e) {"; //76:30
                        if (__tmp64Line != null) __out.Append(__tmp64Line);
                        __out.AppendLine(false); //76:35
                        __out.Append("			throw new RuntimeException(e);"); //77:1
                        __out.AppendLine(false); //77:34
                    }
                    __out.Append("		}"); //79:1
                    __out.AppendLine(false); //79:4
                }
                else //80:3
                {
                    string __tmp65Prefix = "		"; //81:1
                    StringBuilder __tmp66 = new StringBuilder();
                    __tmp66.Append(ControllerMethodImpl(reference, op));
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
                            __out.AppendLine(false); //81:40
                        }
                    }
                }
                if (javaReturn.Contains("List")) //83:4
                {
                    string __tmp68Line = "		return \""; //84:1
                    if (__tmp68Line != null) __out.Append(__tmp68Line);
                    StringBuilder __tmp69 = new StringBuilder();
                    __tmp69.Append(name);
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
                    string __tmp70Line = "\";"; //84:17
                    if (__tmp70Line != null) __out.Append(__tmp70Line);
                    __out.AppendLine(false); //84:19
                }
                else //85:5
                {
                    string __tmp72Line = "		return \""; //86:1
                    if (__tmp72Line != null) __out.Append(__tmp72Line);
                    StringBuilder __tmp73 = new StringBuilder();
                    __tmp73.Append(reference.Name);
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
                    string __tmp74Line = "View\";"; //86:27
                    if (__tmp74Line != null) __out.Append(__tmp74Line);
                    __out.AppendLine(false); //86:33
                }
                __out.Append("	}"); //88:1
                __out.AppendLine(false); //88:3
                __out.AppendLine(true); //89:2
            }
            __out.Append("}"); //91:1
            __out.AppendLine(false); //91:2
            return __out.ToString();
        }

        public string ControllerMethodImpl(Reference reference, Operation op) //96:1
        {
            StringBuilder __out = new StringBuilder();
            if (op.Result.Type.GetJavaName() == "void") //97:3
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
                string __tmp3Line = "."; //98:31
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
                string __tmp5Line = "("; //98:55
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
                string __tmp7Line = ");"; //98:102
                if (__tmp7Line != null) __out.Append(__tmp7Line);
                __out.AppendLine(false); //98:104
            }
            else //99:3
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
                string __tmp10Line = " result = "; //100:31
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
                string __tmp12Line = "."; //100:71
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
                string __tmp14Line = "("; //100:95
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
                string __tmp16Line = ");"; //100:142
                if (__tmp16Line != null) __out.Append(__tmp16Line);
                __out.AppendLine(false); //100:144
                ArrayType array = (op.Result.Type as ArrayType); //101:2
                if (array != null) //102:4
                {
                    string __tmp18Line = "model.addAttribute(\""; //103:1
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
                    string __tmp20Line = "List\", result);"; //103:52
                    if (__tmp20Line != null) __out.Append(__tmp20Line);
                    __out.AppendLine(false); //103:67
                }
                else //104:4
                {
                    string __tmp22Line = "model.addAttribute(\""; //105:1
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
                    string __tmp24Line = "\", result);"; //105:51
                    if (__tmp24Line != null) __out.Append(__tmp24Line);
                    __out.AppendLine(false); //105:62
                }
            }
            return __out.ToString();
        }

        public string GenerateIndexView(Namespace ns) //112:1
        {
            StringBuilder __out = new StringBuilder();
            __out.Append("<!DOCTYPE html>"); //113:1
            __out.AppendLine(false); //113:16
            __out.Append("<html xmlns:th=\"http://www.thymeleaf.org\">"); //114:1
            __out.AppendLine(false); //114:43
            __out.Append("<head th:substituteby=\"_master :: head\">"); //115:1
            __out.AppendLine(false); //115:41
            __out.Append("    <title>Simple</title>"); //116:1
            __out.AppendLine(false); //116:26
            __out.Append("    <link rel=\"stylesheet\" href=\"../resources/css/foundation.min.css\"/>"); //117:1
            __out.AppendLine(false); //117:72
            __out.Append("    <link rel=\"stylesheet\" href=\"../resources/css/style.css\"/>"); //118:1
            __out.AppendLine(false); //118:63
            __out.Append("</head>"); //119:1
            __out.AppendLine(false); //119:8
            __out.Append("<body>"); //120:1
            __out.AppendLine(false); //120:7
            __out.AppendLine(true); //121:1
            __out.Append("<header class=\"template row\" th:substituteby=\"_master :: header\">"); //122:1
            __out.AppendLine(false); //122:66
            __out.Append("    <div class=\"small-10 columns\">"); //123:1
            __out.AppendLine(false); //123:35
            __out.Append("        <h1>//Title//</h1>"); //124:1
            __out.AppendLine(false); //124:27
            __out.Append("    </div>"); //125:1
            __out.AppendLine(false); //125:11
            __out.Append("</header>"); //126:1
            __out.AppendLine(false); //126:10
            __out.AppendLine(true); //127:1
            __out.Append("<div class=\"row\">"); //128:1
            __out.AppendLine(false); //128:18
            __out.Append("    <div class=\"small-10 columns\">"); //129:1
            __out.AppendLine(false); //129:35
            string __tmp2Line = "		<h2>Hello World in "; //130:1
            if (__tmp2Line != null) __out.Append(__tmp2Line);
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(ns.Name);
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
            string __tmp4Line = "</h2>"; //130:31
            if (__tmp4Line != null) __out.Append(__tmp4Line);
            __out.AppendLine(false); //130:36
            __out.AppendLine(true); //131:3
            __out.Append("		<div class=\"small-2 columns template\" th:substituteby=\"_master :: sidebar\">"); //132:1
            __out.AppendLine(false); //132:78
            __out.Append("			//side-nav menu//"); //133:1
            __out.AppendLine(false); //133:21
            __out.Append("		</div>"); //134:1
            __out.AppendLine(false); //134:9
            __out.Append("	</div>"); //135:1
            __out.AppendLine(false); //135:8
            __out.Append("</div>"); //136:1
            __out.AppendLine(false); //136:7
            __out.AppendLine(true); //137:1
            __out.Append("<footer class=\"template row\" th:substituteby=\"_master :: footer\">"); //138:1
            __out.AppendLine(false); //138:66
            __out.Append("    <div class=\"large-12 columns\">"); //139:1
            __out.AppendLine(false); //139:35
            __out.Append("        <hr/>"); //140:1
            __out.AppendLine(false); //140:14
            __out.Append("        <div class=\"row\">"); //141:1
            __out.AppendLine(false); //141:26
            __out.Append("            <div class=\"small-4 columns\">"); //142:1
            __out.AppendLine(false); //142:42
            __out.Append("                //copyright//"); //143:1
            __out.AppendLine(false); //143:30
            __out.Append("            </div>"); //144:1
            __out.AppendLine(false); //144:19
            __out.Append("            <div class=\"small-8 columns\">"); //145:1
            __out.AppendLine(false); //145:42
            __out.Append("                <span class=\"right\">//powered by//</span>"); //146:1
            __out.AppendLine(false); //146:58
            __out.Append("            </div>"); //147:1
            __out.AppendLine(false); //147:19
            __out.Append("        </div>"); //148:1
            __out.AppendLine(false); //148:15
            __out.Append("    </div>"); //149:1
            __out.AppendLine(false); //149:11
            __out.Append("</footer>"); //150:1
            __out.AppendLine(false); //150:10
            __out.AppendLine(true); //151:1
            __out.Append("</body>"); //152:1
            __out.AppendLine(false); //152:8
            __out.Append("</html>"); //153:1
            __out.AppendLine(false); //153:8
            return __out.ToString();
        }

        public string GenerateView(Reference reference) //158:1
        {
            StringBuilder __out = new StringBuilder();
            __out.Append("<!DOCTYPE html>"); //159:1
            __out.AppendLine(false); //159:16
            __out.Append("<html xmlns:th=\"http://www.thymeleaf.org\">"); //160:1
            __out.AppendLine(false); //160:43
            __out.Append("<head th:substituteby=\"_master :: head\">"); //161:1
            __out.AppendLine(false); //161:41
            __out.Append("    <title>Simple</title>"); //162:1
            __out.AppendLine(false); //162:26
            __out.Append("    <link rel=\"stylesheet\" href=\"../resources/css/foundation.min.css\"/>"); //163:1
            __out.AppendLine(false); //163:72
            __out.Append("    <link rel=\"stylesheet\" href=\"../resources/css/style.css\"/>"); //164:1
            __out.AppendLine(false); //164:63
            __out.Append("</head>"); //165:1
            __out.AppendLine(false); //165:8
            __out.Append("<body>"); //166:1
            __out.AppendLine(false); //166:7
            __out.AppendLine(true); //167:1
            __out.Append("<header class=\"template row\" th:substituteby=\"_master :: header\">"); //168:1
            __out.AppendLine(false); //168:66
            __out.Append("    <div class=\"small-10 columns\">"); //169:1
            __out.AppendLine(false); //169:35
            __out.Append("        <h1>//Title//</h1>"); //170:1
            __out.AppendLine(false); //170:27
            __out.Append("    </div>"); //171:1
            __out.AppendLine(false); //171:11
            __out.Append("</header>"); //172:1
            __out.AppendLine(false); //172:10
            __out.AppendLine(true); //173:1
            __out.Append("<div class=\"row\">"); //174:1
            __out.AppendLine(false); //174:18
            __out.Append("    <div class=\"small-10 columns\">"); //175:1
            __out.AppendLine(false); //175:35
            string __tmp2Line = "		<h2>"; //176:1
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
            string __tmp4Line = "</h2>"; //176:33
            if (__tmp4Line != null) __out.Append(__tmp4Line);
            __out.AppendLine(false); //176:38
            __out.AppendLine(true); //177:1
            int ids = 0; //178:2
            var __loop4_results = 
                (from __loop4_var1 in __Enumerate((reference.Interface).GetEnumerator()) //179:7
                from action in __Enumerate((__loop4_var1.Operations).GetEnumerator()) //179:28
                select new { __loop4_var1 = __loop4_var1, action = action}
                ).ToList(); //179:2
            int __loop4_iteration = 0;
            foreach (var __tmp5 in __loop4_results)
            {
                ++__loop4_iteration;
                var __loop4_var1 = __tmp5.__loop4_var1;
                var action = __tmp5.action;
                string actionName = action.Name; //180:3
                if (actionName.StartsWith("Get")) //181:3
                {
                    actionName = actionName.Substring(3);
                }
                string javaReturn = action.Result.Type.GetJavaName(); //185:3
                if (javaReturn.Contains("List") && !action.Parameters.Any()) //187:3
                {
                    string __tmp7Line = "		<a href=\""; //188:1
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
                    string __tmp9Line = ".html\">"; //188:24
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
                    string __tmp11Line = "</a>"; //188:43
                    if (__tmp11Line != null) __out.Append(__tmp11Line);
                    __out.AppendLine(false); //188:47
                }
                else //189:3
                {
                    if (javaReturn.Contains("List")) //190:4
                    {
                        string __tmp13Line = "		<form action=\""; //191:1
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
                        string __tmp15Line = ".html\">"; //191:29
                        if (__tmp15Line != null) __out.Append(__tmp15Line);
                        __out.AppendLine(false); //191:36
                    }
                    else //192:4
                    {
                        __out.Append("		<form>"); //193:1
                        __out.AppendLine(false); //193:9
                    }
                    if (action.Parameters.Any()) //196:4
                    {
                        __out.Append("			<fieldset>"); //197:1
                        __out.AppendLine(false); //197:14
                        string __tmp17Line = "				<legend>"; //198:1
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
                        string __tmp19Line = "</legend>"; //198:25
                        if (__tmp19Line != null) __out.Append(__tmp19Line);
                        __out.AppendLine(false); //198:34
                    }
                    if (javaReturn != "void" && !javaReturn.Contains("List")) //201:4
                    {
                        string __tmp21Line = "				<input type=\"hidden\" name=\"action\" value=\""; //202:1
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
                        string __tmp23Line = "\" />"; //202:59
                        if (__tmp23Line != null) __out.Append(__tmp23Line);
                        __out.AppendLine(false); //202:63
                    }
                    var __loop5_results = 
                        (from __loop5_var1 in __Enumerate((action).GetEnumerator()) //205:9
                        from input in __Enumerate((__loop5_var1.Parameters).GetEnumerator()) //205:17
                        select new { __loop5_var1 = __loop5_var1, input = input}
                        ).ToList(); //205:4
                    int __loop5_iteration = 0;
                    foreach (var __tmp24 in __loop5_results)
                    {
                        ++__loop5_iteration;
                        var __loop5_var1 = __tmp24.__loop5_var1;
                        var input = __tmp24.input;
                        string id = (ids++).ToString(); //206:5
                        string __tmp26Line = "				<label for=\""; //207:1
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
                        string __tmp28Line = "\">"; //207:21
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
                        string __tmp30Line = ": </label>"; //207:35
                        if (__tmp30Line != null) __out.Append(__tmp30Line);
                        __out.AppendLine(false); //207:45
                        string __tmp32Line = "				<input id=\""; //208:1
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
                        string __tmp34Line = "\" type=\"text\" name=\""; //208:20
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
                        string __tmp36Line = "\" />"; //208:52
                        if (__tmp36Line != null) __out.Append(__tmp36Line);
                        __out.AppendLine(false); //208:56
                    }
                    string __tmp38Line = "				<input type=\"submit\" value=\""; //210:1
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
                    string __tmp40Line = "\" />"; //210:46
                    if (__tmp40Line != null) __out.Append(__tmp40Line);
                    __out.AppendLine(false); //210:50
                    if (javaReturn != "void" && !javaReturn.Contains("List")) //212:4
                    {
                        string id = (ids++).ToString(); //213:5
                        string __tmp42Line = "				<input id=\""; //214:1
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
                        string __tmp44Line = "\" type=\"text\" name=\""; //214:20
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
                        string __tmp46Line = "Result\" readonly=\"readonly\" />"; //214:52
                        if (__tmp46Line != null) __out.Append(__tmp46Line);
                        __out.AppendLine(false); //214:82
                    }
                    if (action.Parameters.Any()) //216:4
                    {
                        __out.Append("			</fieldset>"); //217:1
                        __out.AppendLine(false); //217:15
                    }
                    __out.Append("		</form>"); //219:1
                    __out.AppendLine(false); //219:10
                }
                __out.Append("		<br/>"); //221:1
                __out.AppendLine(false); //221:8
            }
            __out.Append("		<div class=\"small-2 columns template\" th:substituteby=\"_master :: sidebar\">"); //223:1
            __out.AppendLine(false); //223:78
            __out.Append("			//side-nav menu//"); //224:1
            __out.AppendLine(false); //224:21
            __out.Append("		</div>"); //225:1
            __out.AppendLine(false); //225:9
            __out.Append("	</div>"); //226:1
            __out.AppendLine(false); //226:8
            __out.Append("</div>"); //227:1
            __out.AppendLine(false); //227:7
            __out.AppendLine(true); //228:1
            __out.Append("<footer class=\"template row\" th:substituteby=\"_master :: footer\">"); //229:1
            __out.AppendLine(false); //229:66
            __out.Append("    <div class=\"large-12 columns\">"); //230:1
            __out.AppendLine(false); //230:35
            __out.Append("        <hr/>"); //231:1
            __out.AppendLine(false); //231:14
            __out.Append("        <div class=\"row\">"); //232:1
            __out.AppendLine(false); //232:26
            __out.Append("            <div class=\"small-4 columns\">"); //233:1
            __out.AppendLine(false); //233:42
            __out.Append("                //copyright//"); //234:1
            __out.AppendLine(false); //234:30
            __out.Append("            </div>"); //235:1
            __out.AppendLine(false); //235:19
            __out.Append("            <div class=\"small-8 columns\">"); //236:1
            __out.AppendLine(false); //236:42
            __out.Append("                <span class=\"right\">//powered by//</span>"); //237:1
            __out.AppendLine(false); //237:58
            __out.Append("            </div>"); //238:1
            __out.AppendLine(false); //238:19
            __out.Append("        </div>"); //239:1
            __out.AppendLine(false); //239:15
            __out.Append("    </div>"); //240:1
            __out.AppendLine(false); //240:11
            __out.Append("</footer>"); //241:1
            __out.AppendLine(false); //241:10
            __out.AppendLine(true); //242:1
            __out.Append("</body>"); //243:1
            __out.AppendLine(false); //243:8
            __out.Append("</html>"); //244:1
            __out.AppendLine(false); //244:8
            return __out.ToString();
        }

        public string GenerateListView(Struct entity) //249:1
        {
            StringBuilder __out = new StringBuilder();
            __out.Append("<!DOCTYPE html>"); //250:1
            __out.AppendLine(false); //250:16
            __out.Append("<html xmlns:th=\"http://www.thymeleaf.org\">"); //251:1
            __out.AppendLine(false); //251:43
            __out.Append("<head th:substituteby=\"_master :: head\">"); //252:1
            __out.AppendLine(false); //252:41
            __out.Append("    <title>Simple</title>"); //253:1
            __out.AppendLine(false); //253:26
            __out.Append("    <link rel=\"stylesheet\" href=\"../resources/css/foundation.min.css\"/>"); //254:1
            __out.AppendLine(false); //254:72
            __out.Append("    <link rel=\"stylesheet\" href=\"../resources/css/style.css\"/>"); //255:1
            __out.AppendLine(false); //255:63
            __out.Append("</head>"); //256:1
            __out.AppendLine(false); //256:8
            __out.Append("<body>"); //257:1
            __out.AppendLine(false); //257:7
            __out.AppendLine(true); //258:1
            __out.Append("<header class=\"template row\" th:substituteby=\"_master :: header\">"); //259:1
            __out.AppendLine(false); //259:66
            __out.Append("    <div class=\"small-10 columns\">"); //260:1
            __out.AppendLine(false); //260:35
            __out.Append("        <h1>//Title//</h1>"); //261:1
            __out.AppendLine(false); //261:27
            __out.Append("    </div>"); //262:1
            __out.AppendLine(false); //262:11
            __out.Append("</header>"); //263:1
            __out.AppendLine(false); //263:10
            __out.AppendLine(true); //264:1
            __out.Append("<div class=\"row\">"); //265:1
            __out.AppendLine(false); //265:18
            __out.Append("    <div class=\"small-10 columns\">"); //266:1
            __out.AppendLine(false); //266:35
            string __tmp2Line = "        <h2>"; //267:1
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
            string __tmp4Line = " list</h2>"; //267:26
            if (__tmp4Line != null) __out.Append(__tmp4Line);
            __out.AppendLine(false); //267:36
            __out.AppendLine(true); //268:1
            __out.Append("        <table>"); //269:1
            __out.AppendLine(false); //269:16
            __out.Append("            <tr>"); //270:1
            __out.AppendLine(false); //270:17
            var __loop6_results = 
                (from __loop6_var1 in __Enumerate((entity).GetEnumerator()) //271:9
                from property in __Enumerate((__loop6_var1.Properties).GetEnumerator()) //271:17
                select new { __loop6_var1 = __loop6_var1, property = property}
                ).ToList(); //271:4
            int __loop6_iteration = 0;
            foreach (var __tmp5 in __loop6_results)
            {
                ++__loop6_iteration;
                var __loop6_var1 = __tmp5.__loop6_var1;
                var property = __tmp5.property;
                string __tmp7Line = "                <th>"; //272:1
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
                string __tmp9Line = "</th>"; //272:36
                if (__tmp9Line != null) __out.Append(__tmp9Line);
                __out.AppendLine(false); //272:41
            }
            __out.Append("            </tr>"); //274:1
            __out.AppendLine(false); //274:18
            string __tmp11Line = "            <tr th:each=\""; //275:1
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
            string __tmp13Line = " : ${"; //275:53
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
            string __tmp15Line = "List}\">"; //275:85
            if (__tmp15Line != null) __out.Append(__tmp15Line);
            __out.AppendLine(false); //275:92
            var __loop7_results = 
                (from __loop7_var1 in __Enumerate((entity).GetEnumerator()) //276:9
                from property in __Enumerate((__loop7_var1.Properties).GetEnumerator()) //276:17
                select new { __loop7_var1 = __loop7_var1, property = property}
                ).ToList(); //276:4
            int __loop7_iteration = 0;
            foreach (var __tmp16 in __loop7_results)
            {
                ++__loop7_iteration;
                var __loop7_var1 = __tmp16.__loop7_var1;
                var property = __tmp16.property;
                string __tmp18Line = "				<td th:text=\"${"; //277:1
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
                string __tmp20Line = "."; //277:47
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
                string __tmp22Line = "}\">Data</td>"; //277:77
                if (__tmp22Line != null) __out.Append(__tmp22Line);
                __out.AppendLine(false); //277:89
            }
            __out.Append("            </tr>"); //279:1
            __out.AppendLine(false); //279:18
            __out.Append("        </table>"); //280:1
            __out.AppendLine(false); //280:17
            __out.Append("    </div>"); //281:1
            __out.AppendLine(false); //281:11
            __out.Append("    <div class=\"small-2 columns template\" th:substituteby=\"_master :: sidebar\">"); //282:1
            __out.AppendLine(false); //282:80
            __out.Append("        //side-nav menu//"); //283:1
            __out.AppendLine(false); //283:26
            __out.Append("    </div>"); //284:1
            __out.AppendLine(false); //284:11
            __out.Append("</div>"); //285:1
            __out.AppendLine(false); //285:7
            __out.AppendLine(true); //286:1
            __out.Append("<footer class=\"template row\" th:substituteby=\"_master :: footer\">"); //287:1
            __out.AppendLine(false); //287:66
            __out.Append("    <div class=\"large-12 columns\">"); //288:1
            __out.AppendLine(false); //288:35
            __out.Append("        <hr/>"); //289:1
            __out.AppendLine(false); //289:14
            __out.Append("        <div class=\"row\">"); //290:1
            __out.AppendLine(false); //290:26
            __out.Append("            <div class=\"small-4 columns\">"); //291:1
            __out.AppendLine(false); //291:42
            __out.Append("                //copyright//"); //292:1
            __out.AppendLine(false); //292:30
            __out.Append("            </div>"); //293:1
            __out.AppendLine(false); //293:19
            __out.Append("            <div class=\"small-8 columns\">"); //294:1
            __out.AppendLine(false); //294:42
            __out.Append("                <span class=\"right\">//powered by//</span>"); //295:1
            __out.AppendLine(false); //295:58
            __out.Append("            </div>"); //296:1
            __out.AppendLine(false); //296:19
            __out.Append("        </div>"); //297:1
            __out.AppendLine(false); //297:15
            __out.Append("    </div>"); //298:1
            __out.AppendLine(false); //298:11
            __out.Append("</footer>"); //299:1
            __out.AppendLine(false); //299:10
            __out.AppendLine(true); //300:1
            __out.Append("</body>"); //301:1
            __out.AppendLine(false); //301:8
            __out.Append("</html>"); //302:1
            __out.AppendLine(false); //302:8
            return __out.ToString();
        }

        public string GenerateMasterView(string applicationName, List<ViewInfoHolder> views) //307:1
        {
            StringBuilder __out = new StringBuilder();
            __out.Append("<!DOCTYPE html>"); //308:1
            __out.AppendLine(false); //308:16
            __out.Append("<html xmlns:th=\"http://www.thymeleaf.org\">"); //309:1
            __out.AppendLine(false); //309:43
            __out.AppendLine(true); //310:1
            __out.Append("<head th:fragment=\"head\">"); //311:1
            __out.AppendLine(false); //311:26
            string __tmp2Line = "    <title>"; //312:1
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
            string __tmp4Line = "</title>"; //312:29
            if (__tmp4Line != null) __out.Append(__tmp4Line);
            __out.AppendLine(false); //312:37
            __out.Append("    <meta name=\"viewport\" content=\"width=device-width\"/>"); //313:1
            __out.AppendLine(false); //313:57
            __out.Append("    <link rel=\"stylesheet\" href=\"../resources/css/normalize.css\""); //314:1
            __out.AppendLine(false); //314:65
            __out.Append("          th:href=\"@{/resources/css/normalize.css}\"/>"); //315:1
            __out.AppendLine(false); //315:54
            __out.Append("    <link rel=\"stylesheet\" href=\"../resources/css/foundation.min.css\""); //316:1
            __out.AppendLine(false); //316:70
            __out.Append("          th:href=\"@{/resources/css/foundation.min.css}\"/>"); //317:1
            __out.AppendLine(false); //317:59
            __out.Append("    <link rel=\"stylesheet\" href=\"../resources/css/style.css\""); //318:1
            __out.AppendLine(false); //318:61
            __out.Append("          th:href=\"@{/resources/css/style.css}\"/>"); //319:1
            __out.AppendLine(false); //319:50
            __out.Append("    <script type=\"text/javascript\" src=\"../resources/js/vendor/custom.modernizr.js\""); //320:1
            __out.AppendLine(false); //320:84
            __out.Append("            th:src=\"@{/resources/js/vendor/custom.modernizr.js}\"></script>"); //321:1
            __out.AppendLine(false); //321:75
            __out.Append("    <script type=\"text/javascript\" src=\"../resources/js/vendor/jquery.js\""); //322:1
            __out.AppendLine(false); //322:74
            __out.Append("            th:src=\"@{/resources/js/vendor/jquery.js}\"></script>"); //323:1
            __out.AppendLine(false); //323:65
            __out.Append("    <script type=\"text/javascript\" src=\"../resources/js/foundation.min.js\""); //324:1
            __out.AppendLine(false); //324:75
            __out.Append("            th:src=\"@{/resources/js/foundation.min.js}\"></script>"); //325:1
            __out.AppendLine(false); //325:66
            __out.Append("    <script type=\"text/javascript\" src=\"../resources/js/app.js\""); //326:1
            __out.AppendLine(false); //326:64
            __out.Append("            th:src=\"@{/resources/js/app.js}\"></script>"); //327:1
            __out.AppendLine(false); //327:55
            __out.Append("</head>"); //328:1
            __out.AppendLine(false); //328:8
            __out.AppendLine(true); //329:1
            __out.Append("<body>"); //330:1
            __out.AppendLine(false); //330:7
            __out.AppendLine(true); //331:1
            __out.Append("<header class=\"row\" th:fragment=\"header\">"); //332:1
            __out.AppendLine(false); //332:42
            __out.Append("    <div class=\"small-10 columns\">"); //333:1
            __out.AppendLine(false); //333:35
            string __tmp6Line = "        <h1>"; //334:1
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
            string __tmp8Line = "</h1>"; //334:30
            if (__tmp8Line != null) __out.Append(__tmp8Line);
            __out.AppendLine(false); //334:35
            __out.Append("    </div>"); //335:1
            __out.AppendLine(false); //335:11
            __out.Append("</header>"); //336:1
            __out.AppendLine(false); //336:10
            __out.AppendLine(true); //337:1
            __out.Append("<div class=\"row\">"); //338:1
            __out.AppendLine(false); //338:18
            __out.Append("    <div class=\"small-10 columns template\">"); //339:1
            __out.AppendLine(false); //339:44
            __out.Append("        <h2>//content title//</h2>"); //340:1
            __out.AppendLine(false); //340:35
            __out.Append("        <p>//content//</p>"); //342:1
            __out.AppendLine(false); //342:27
            __out.Append("    </div>"); //343:1
            __out.AppendLine(false); //343:11
            __out.AppendLine(true); //344:1
            __out.Append("    <div class=\"small-2 columns\" th:fragment=\"sidebar\">"); //345:1
            __out.AppendLine(false); //345:56
            __out.Append("        <div style=\"width: 140px; margin: 0 auto\">"); //346:1
            __out.AppendLine(false); //346:51
            __out.Append("            <ul class=\"side-nav\">"); //347:1
            __out.AppendLine(false); //347:34
            var __loop8_results = 
                (from view in __Enumerate((views).GetEnumerator()) //348:10
                select new { view = view}
                ).ToList(); //348:5
            int __loop8_iteration = 0;
            foreach (var __tmp9 in __loop8_results)
            {
                ++__loop8_iteration;
                var view = __tmp9.view;
                string __tmp11Line = "                <li><a href=\""; //349:1
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
                string __tmp13Line = "\" th:href=\"@{/"; //349:45
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
                string __tmp15Line = "/}\">"; //349:73
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
                string __tmp17Line = "</a></li>"; //349:88
                if (__tmp17Line != null) __out.Append(__tmp17Line);
                __out.AppendLine(false); //349:97
            }
            __out.Append("            </ul>"); //351:1
            __out.AppendLine(false); //351:18
            __out.Append("        </div>"); //352:1
            __out.AppendLine(false); //352:15
            __out.Append("    </div>"); //353:1
            __out.AppendLine(false); //353:11
            __out.Append("</div>"); //354:1
            __out.AppendLine(false); //354:7
            __out.AppendLine(true); //355:1
            __out.Append("<footer class=\"row\" th:fragment=\"footer\">"); //356:1
            __out.AppendLine(false); //356:42
            __out.Append("    <div class=\"large-12 columns\">"); //357:1
            __out.AppendLine(false); //357:35
            __out.Append("        <hr/>"); //358:1
            __out.AppendLine(false); //358:14
            __out.Append("        <div class=\"row\">"); //359:1
            __out.AppendLine(false); //359:26
            __out.Append("            <div class=\"small-4 columns\">"); //360:1
            __out.AppendLine(false); //360:42
            __out.Append("                <p>&copy; Copyright BME IIT</p>"); //361:1
            __out.AppendLine(false); //361:48
            __out.Append("            </div>"); //362:1
            __out.AppendLine(false); //362:19
            __out.Append("            <div class=\"small-8 columns\">"); //363:1
            __out.AppendLine(false); //363:42
            __out.Append("                <ul class=\"inline-list right\">"); //364:1
            __out.AppendLine(false); //364:47
            __out.Append("                    <li>Powered by</li>"); //365:1
            __out.AppendLine(false); //365:40
            __out.Append("                    <li><a href=\"http://www.spring.io/\">Spring</a></li>"); //366:1
            __out.AppendLine(false); //366:72
            __out.Append("                    <li><a href=\"http://www.thymeleaf.org/\">Thymeleaf</a></li>"); //367:1
            __out.AppendLine(false); //367:79
            __out.Append("                    <li><a href=\"http://foundation.zurb.com/\">Foundation</a></li>"); //368:1
            __out.AppendLine(false); //368:82
            __out.Append("                </ul>"); //369:1
            __out.AppendLine(false); //369:22
            __out.Append("            </div>"); //370:1
            __out.AppendLine(false); //370:19
            __out.Append("        </div>"); //371:1
            __out.AppendLine(false); //371:15
            __out.Append("    </div>"); //372:1
            __out.AppendLine(false); //372:11
            __out.Append("</footer>"); //373:1
            __out.AppendLine(false); //373:10
            __out.AppendLine(true); //374:1
            __out.Append("</body>"); //375:1
            __out.AppendLine(false); //375:8
            __out.Append("</html>"); //376:1
            __out.AppendLine(false); //376:8
            return __out.ToString();
        }

        public string GenerateWebXml() //381:1
        {
            StringBuilder __out = new StringBuilder();
            __out.Append("<?xml version=\"1.0\" encoding=\"UTF-8\"?>"); //382:1
            __out.AppendLine(false); //382:39
            __out.Append("<web-app xmlns=\"http://java.sun.com/xml/ns/javaee\""); //383:1
            __out.AppendLine(false); //383:51
            __out.Append("         xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\""); //384:1
            __out.AppendLine(false); //384:63
            __out.Append("         xsi:schemaLocation=\"http://java.sun.com/xml/ns/javaee"); //385:1
            __out.AppendLine(false); //385:63
            __out.Append("		 http://java.sun.com/xml/ns/javaee/web-app_3_0.xsd\" version=\"3.0\">"); //386:1
            __out.AppendLine(false); //386:69
            __out.AppendLine(true); //387:1
            __out.Append("    <servlet>"); //388:1
            __out.AppendLine(false); //388:14
            __out.Append("        <servlet-name>spring</servlet-name>"); //389:1
            __out.AppendLine(false); //389:44
            __out.Append("        <servlet-class>org.springframework.web.servlet.DispatcherServlet</servlet-class>"); //390:1
            __out.AppendLine(false); //390:89
            __out.Append("        <load-on-startup>1</load-on-startup>"); //391:1
            __out.AppendLine(false); //391:45
            __out.Append("    </servlet>"); //392:1
            __out.AppendLine(false); //392:15
            __out.AppendLine(true); //393:1
            __out.Append("    <servlet-mapping>"); //394:1
            __out.AppendLine(false); //394:22
            __out.Append("        <servlet-name>spring</servlet-name>"); //395:1
            __out.AppendLine(false); //395:44
            __out.Append("        <url-pattern>/*</url-pattern>"); //396:1
            __out.AppendLine(false); //396:38
            __out.Append("    </servlet-mapping>"); //397:1
            __out.AppendLine(false); //397:23
            __out.AppendLine(true); //398:1
            __out.Append("    <listener>"); //399:1
            __out.AppendLine(false); //399:15
            __out.Append("        <listener-class>org.springframework.web.context.ContextLoaderListener</listener-class>"); //400:1
            __out.AppendLine(false); //400:95
            __out.Append("    </listener>"); //401:1
            __out.AppendLine(false); //401:16
            __out.AppendLine(true); //402:1
            __out.Append("    <filter>"); //403:1
            __out.AppendLine(false); //403:13
            __out.Append("        <filter-name>characterEncodingFilter</filter-name>"); //404:1
            __out.AppendLine(false); //404:59
            __out.Append("        <filter-class>org.springframework.web.filter.CharacterEncodingFilter</filter-class>"); //405:1
            __out.AppendLine(false); //405:92
            __out.Append("        <init-param>"); //406:1
            __out.AppendLine(false); //406:21
            __out.Append("            <param-name>encoding</param-name>"); //407:1
            __out.AppendLine(false); //407:46
            __out.Append("            <param-value>UTF-8</param-value>"); //408:1
            __out.AppendLine(false); //408:45
            __out.Append("        </init-param>"); //409:1
            __out.AppendLine(false); //409:22
            __out.Append("    </filter>"); //410:1
            __out.AppendLine(false); //410:14
            __out.AppendLine(true); //411:1
            __out.Append("    <filter-mapping>"); //412:1
            __out.AppendLine(false); //412:21
            __out.Append("        <filter-name>characterEncodingFilter</filter-name>"); //413:1
            __out.AppendLine(false); //413:59
            __out.Append("        <servlet-name>spring</servlet-name>"); //414:1
            __out.AppendLine(false); //414:44
            __out.Append("    </filter-mapping>"); //415:1
            __out.AppendLine(false); //415:22
            __out.AppendLine(true); //416:1
            __out.Append("</web-app>"); //417:1
            __out.AppendLine(false); //417:11
            return __out.ToString();
        }

        public string GenerateServlet(Namespace ns) //421:1
        {
            StringBuilder __out = new StringBuilder();
            __out.Append("<?xml version=\"1.0\" encoding=\"UTF-8\"?>"); //422:1
            __out.AppendLine(false); //422:39
            __out.Append("<beans xmlns=\"http://www.springframework.org/schema/beans\""); //423:1
            __out.AppendLine(false); //423:59
            __out.Append("       xmlns:mvc=\"http://www.springframework.org/schema/mvc\""); //424:1
            __out.AppendLine(false); //424:61
            __out.Append("       xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\""); //425:1
            __out.AppendLine(false); //425:61
            __out.Append("       xmlns:context=\"http://www.springframework.org/schema/context\""); //426:1
            __out.AppendLine(false); //426:69
            __out.Append("       xsi:schemaLocation=\"http://www.springframework.org/schema/beans"); //427:1
            __out.AppendLine(false); //427:71
            __out.Append("                           http://www.springframework.org/schema/beans/spring-beans.xsd"); //428:1
            __out.AppendLine(false); //428:88
            __out.Append("                           http://www.springframework.org/schema/context"); //429:1
            __out.AppendLine(false); //429:73
            __out.Append("                           http://www.springframework.org/schema/context/spring-context.xsd"); //430:1
            __out.AppendLine(false); //430:92
            __out.Append("                           http://www.springframework.org/schema/mvc"); //431:1
            __out.AppendLine(false); //431:69
            __out.Append("                           http://www.springframework.org/schema/mvc/spring-mvc.xsd\">"); //432:1
            __out.AppendLine(false); //432:86
            __out.AppendLine(true); //433:1
            string __tmp2Line = "    <context:component-scan base-package=\""; //434:1
            if (__tmp2Line != null) __out.Append(__tmp2Line);
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(ns.FullName.ToLower());
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
            string __tmp4Line = "."; //434:66
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
            string __tmp6Line = "\"/>"; //434:117
            if (__tmp6Line != null) __out.Append(__tmp6Line);
            __out.AppendLine(false); //434:120
            __out.AppendLine(true); //435:1
            __out.Append("    <mvc:annotation-driven/>"); //436:1
            __out.AppendLine(false); //436:29
            __out.AppendLine(true); //437:1
            __out.Append("    <!--<mvc:resources mapping=\"/favicon.ico\" location=\"/WEB-INF/resources/img/\"/>-->"); //438:1
            __out.AppendLine(false); //438:86
            __out.Append("    <mvc:resources mapping=\"/resources/**\" location=\"/WEB-INF/resources/\"/>"); //439:1
            __out.AppendLine(false); //439:76
            __out.AppendLine(true); //440:1
            __out.Append("    <mvc:interceptors>"); //441:1
            __out.AppendLine(false); //441:23
            __out.Append("        <bean class=\"org.springframework.web.servlet.i18n.LocaleChangeInterceptor\">"); //442:1
            __out.AppendLine(false); //442:84
            __out.Append("            <property name=\"paramName\" value=\"lang\"/>"); //443:1
            __out.AppendLine(false); //443:54
            __out.Append("        </bean>"); //444:1
            __out.AppendLine(false); //444:16
            __out.Append("    </mvc:interceptors>"); //445:1
            __out.AppendLine(false); //445:24
            __out.AppendLine(true); //446:1
            __out.Append("    <bean id=\"templateResolver\" class=\"org.thymeleaf.templateresolver.ServletContextTemplateResolver\">"); //447:1
            __out.AppendLine(false); //447:103
            __out.Append("        <property name=\"prefix\" value=\"/WEB-INF/view/\"/>"); //448:1
            __out.AppendLine(false); //448:57
            __out.Append("        <property name=\"suffix\" value=\".html\"/>"); //449:1
            __out.AppendLine(false); //449:48
            __out.Append("        <property name=\"characterEncoding\" value=\"UTF-8\"/>"); //450:1
            __out.AppendLine(false); //450:59
            __out.Append("        <property name=\"templateMode\" value=\"HTML5\"/>"); //451:1
            __out.AppendLine(false); //451:54
            __out.Append("        <property name=\"cacheable\" value=\"false\"/>"); //452:1
            __out.AppendLine(false); //452:51
            __out.Append("    </bean>"); //453:1
            __out.AppendLine(false); //453:12
            __out.AppendLine(true); //454:1
            __out.Append("    <bean id=\"templateEngine\" class=\"org.thymeleaf.spring4.SpringTemplateEngine\">"); //455:1
            __out.AppendLine(false); //455:82
            __out.Append("        <property name=\"templateResolver\" ref=\"templateResolver\"/>"); //456:1
            __out.AppendLine(false); //456:67
            __out.Append("    </bean>"); //457:1
            __out.AppendLine(false); //457:12
            __out.AppendLine(true); //458:1
            __out.Append("    <bean class=\"org.thymeleaf.spring4.view.ThymeleafViewResolver\">"); //459:1
            __out.AppendLine(false); //459:68
            __out.Append("        <property name=\"templateEngine\" ref=\"templateEngine\"/>"); //460:1
            __out.AppendLine(false); //460:63
            __out.Append("        <property name=\"contentType\" value=\"text/html; charset=UTF-8\"/>"); //461:1
            __out.AppendLine(false); //461:72
            __out.Append("        <property name=\"characterEncoding\" value=\"UTF-8\"/>"); //462:1
            __out.AppendLine(false); //462:59
            __out.Append("    </bean>"); //463:1
            __out.AppendLine(false); //463:12
            __out.AppendLine(true); //464:1
            __out.Append("    <bean id=\"localeResolver\" class=\"org.springframework.web.servlet.i18n.SessionLocaleResolver\"/>"); //465:1
            __out.AppendLine(false); //465:99
            __out.AppendLine(true); //466:1
            __out.Append("</beans>"); //467:1
            __out.AppendLine(false); //467:9
            return __out.ToString();
        }

        public string GenerateJboss() //472:1
        {
            StringBuilder __out = new StringBuilder();
            __out.Append("<?xml version=\"1.0\" encoding=\"UTF-8\"?>"); //473:1
            __out.AppendLine(false); //473:39
            __out.Append("<jboss-deployment-structure>"); //474:1
            __out.AppendLine(false); //474:29
            __out.Append("    <deployment>"); //475:1
            __out.AppendLine(false); //475:17
            __out.Append("        <dependencies>"); //476:1
            __out.AppendLine(false); //476:23
            __out.Append("            <module name=\"com.h2database.h2\" />"); //477:1
            __out.AppendLine(false); //477:48
            __out.Append("			<module name=\"org.eclipse.persistence\" />"); //478:1
            __out.AppendLine(false); //478:45
            __out.Append("        </dependencies>"); //479:1
            __out.AppendLine(false); //479:24
            __out.Append("    </deployment>"); //480:1
            __out.AppendLine(false); //480:18
            __out.Append("</jboss-deployment-structure>"); //481:1
            __out.AppendLine(false); //481:30
            return __out.ToString();
        }

        public string GenerateAppCtx(Namespace ns) //485:1
        {
            StringBuilder __out = new StringBuilder();
            __out.Append("<?xml version=\"1.0\" encoding=\"UTF-8\"?>"); //486:1
            __out.AppendLine(false); //486:39
            __out.Append("<beans xmlns=\"http://www.springframework.org/schema/beans\""); //487:1
            __out.AppendLine(false); //487:59
            __out.Append("       xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\""); //488:1
            __out.AppendLine(false); //488:61
            __out.Append("       xmlns:context=\"http://www.springframework.org/schema/context\""); //489:1
            __out.AppendLine(false); //489:69
            __out.Append("       xmlns:jpa=\"http://www.springframework.org/schema/data/jpa\""); //490:1
            __out.AppendLine(false); //490:66
            __out.Append("       xsi:schemaLocation=\"http://www.springframework.org/schema/beans"); //491:1
            __out.AppendLine(false); //491:71
            __out.Append("       http://www.springframework.org/schema/beans/spring-beans.xsd"); //492:1
            __out.AppendLine(false); //492:68
            __out.Append("       http://www.springframework.org/schema/context"); //493:1
            __out.AppendLine(false); //493:53
            __out.Append("       http://www.springframework.org/schema/context/spring-context.xsd"); //494:1
            __out.AppendLine(false); //494:72
            __out.Append("       http://www.springframework.org/schema/data/jpa"); //495:1
            __out.AppendLine(false); //495:54
            __out.Append("       http://www.springframework.org/schema/data/jpa/spring-jpa.xsd\">"); //496:1
            __out.AppendLine(false); //496:71
            __out.AppendLine(true); //497:5
            string __tmp2Line = "       <jpa:repositories base-package=\""; //498:1
            if (__tmp2Line != null) __out.Append(__tmp2Line);
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(ns.FullName.ToLower());
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
            string __tmp4Line = "."; //498:63
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
            string __tmp6Line = "\"/>"; //498:114
            if (__tmp6Line != null) __out.Append(__tmp6Line);
            __out.AppendLine(false); //498:117
            string __tmp8Line = "       <context:component-scan base-package=\""; //499:1
            if (__tmp8Line != null) __out.Append(__tmp8Line);
            StringBuilder __tmp9 = new StringBuilder();
            __tmp9.Append(ns.FullName.ToLower());
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
            string __tmp10Line = "\"/>"; //499:69
            if (__tmp10Line != null) __out.Append(__tmp10Line);
            __out.AppendLine(false); //499:72
            __out.AppendLine(true); //500:8
            __out.AppendLine(true); //501:5
            __out.Append("       <bean id=\"jpaVendorAdapter\" class=\"org.springframework.orm.jpa.vendor.EclipseLinkJpaVendorAdapter\"/>"); //502:1
            __out.AppendLine(false); //502:108
            __out.Append("       <bean id=\"entityManagerFactory\" class=\"org.springframework.orm.jpa.LocalEntityManagerFactoryBean\">"); //503:1
            __out.AppendLine(false); //503:106
            string __tmp12Line = "              <property name=\"persistenceUnitName\" value=\""; //504:1
            if (__tmp12Line != null) __out.Append(__tmp12Line);
            StringBuilder __tmp13 = new StringBuilder();
            __tmp13.Append(ns.Name);
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
            string __tmp14Line = "PU\"/>"; //504:68
            if (__tmp14Line != null) __out.Append(__tmp14Line);
            __out.AppendLine(false); //504:73
            __out.Append("              <property name=\"jpaVendorAdapter\" ref=\"jpaVendorAdapter\"/>"); //505:1
            __out.AppendLine(false); //505:73
            __out.Append("       </bean>"); //506:1
            __out.AppendLine(false); //506:15
            __out.Append("       <bean id=\"transactionManager\" class=\"org.springframework.orm.jpa.JpaTransactionManager\">"); //507:1
            __out.AppendLine(false); //507:96
            __out.Append("              <property name=\"entityManagerFactory\" ref=\"entityManagerFactory\"/>"); //508:1
            __out.AppendLine(false); //508:81
            __out.Append("       </bean>"); //509:1
            __out.AppendLine(false); //509:15
            __out.Append("</beans>"); //510:1
            __out.AppendLine(false); //510:9
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
