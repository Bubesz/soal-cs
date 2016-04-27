using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Soal //1:1
{
    using __Hidden_SpringViewGenerator_46587992;
    namespace __Hidden_SpringViewGenerator_46587992
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
            __tmp17.Append(SpringGeneratorUtil.GenerateImports(reference.Interface));
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
                    __out.AppendLine(false); //39:59
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
                string method = "POST"; //57:5
                if (name.ToPascalCase().StartsWith("Get")) //58:5
                {
                    method = "GET";
                    name = op.Name.Substring(3);
                }
                if (method == "POST") //62:5
                {
                    string __tmp39Line = "	@RequestMapping(value = \"/"; //63:1
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
                    string __tmp41Line = "\", method = RequestMethod.POST) // TODO consider other method"; //63:34
                    if (__tmp41Line != null) __out.Append(__tmp41Line);
                    __out.AppendLine(false); //63:95
                }
                else if (method == "GET") //64:5
                {
                    string __tmp43Line = "	@RequestMapping(\"/"; //65:1
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
                    string __tmp45Line = "\")"; //65:26
                    if (__tmp45Line != null) __out.Append(__tmp45Line);
                    __out.AppendLine(false); //65:28
                }
                string __tmp47Line = "	public String "; //67:1
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
                string __tmp49Line = "(Model model"; //67:39
                if (__tmp49Line != null) __out.Append(__tmp49Line);
                var __loop2_results = 
                    (from __loop2_var1 in __Enumerate((op).GetEnumerator()) //68:11
                    from param in __Enumerate((__loop2_var1.Parameters).GetEnumerator()) //68:15
                    select new { __loop2_var1 = __loop2_var1, param = param}
                    ).ToList(); //68:5
                int __loop2_iteration = 0;
                foreach (var __tmp50 in __loop2_results)
                {
                    ++__loop2_iteration;
                    var __loop2_var1 = __tmp50.__loop2_var1;
                    var param = __tmp50.param;
                    __out.Append(","); //69:1
                    __out.AppendLine(false); //69:2
                    string __tmp51Prefix = "		"; //70:1
                    StringBuilder __tmp52 = new StringBuilder();
                    __tmp52.Append(MethodParameterAnnotated(param));
                    using(StreamReader __tmp52Reader = new StreamReader(this.__ToStream(__tmp52.ToString())))
                    {
                        bool __tmp52_first = true;
                        bool __tmp52_last = __tmp52Reader.EndOfStream;
                        while(__tmp52_first || !__tmp52_last)
                        {
                            __tmp52_first = false;
                            string __tmp52Line = __tmp52Reader.ReadLine();
                            __tmp52_last = __tmp52Reader.EndOfStream;
                            __out.Append(__tmp51Prefix);
                            if (__tmp52Line != null) __out.Append(__tmp52Line);
                            if (!__tmp52_last) __out.AppendLine(true);
                        }
                    }
                }
                __out.Append(") {"); //72:1
                __out.AppendLine(false); //72:4
                if (op.Exceptions.Any()) //73:3
                {
                    __out.Append("		try {"); //74:1
                    __out.AppendLine(false); //74:8
                    string __tmp53Prefix = "			"; //75:1
                    StringBuilder __tmp54 = new StringBuilder();
                    __tmp54.Append(ControllerMethodImpl(reference, op));
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
                            __out.AppendLine(false); //75:41
                        }
                    }
                    var __loop3_results = 
                        (from __loop3_var1 in __Enumerate((op).GetEnumerator()) //76:9
                        from ex in __Enumerate((__loop3_var1.Exceptions).GetEnumerator()) //76:13
                        select new { __loop3_var1 = __loop3_var1, ex = ex}
                        ).ToList(); //76:4
                    int __loop3_iteration = 0;
                    foreach (var __tmp55 in __loop3_results)
                    {
                        ++__loop3_iteration;
                        var __loop3_var1 = __tmp55.__loop3_var1;
                        var ex = __tmp55.ex;
                        string __tmp57Line = "		} catch ("; //77:1
                        if (__tmp57Line != null) __out.Append(__tmp57Line);
                        StringBuilder __tmp58 = new StringBuilder();
                        __tmp58.Append(ex.GetJavaName());
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
                        string __tmp59Line = " e) {"; //77:30
                        if (__tmp59Line != null) __out.Append(__tmp59Line);
                        __out.AppendLine(false); //77:35
                        __out.Append("			// TODO handle execption properly"); //78:1
                        __out.AppendLine(false); //78:37
                        __out.Append("			throw new RuntimeException(e);"); //79:1
                        __out.AppendLine(false); //79:34
                    }
                    __out.Append("		}"); //81:1
                    __out.AppendLine(false); //81:4
                }
                else //82:3
                {
                    string __tmp60Prefix = "		"; //83:1
                    StringBuilder __tmp61 = new StringBuilder();
                    __tmp61.Append(ControllerMethodImpl(reference, op));
                    using(StreamReader __tmp61Reader = new StreamReader(this.__ToStream(__tmp61.ToString())))
                    {
                        bool __tmp61_first = true;
                        bool __tmp61_last = __tmp61Reader.EndOfStream;
                        while(__tmp61_first || !__tmp61_last)
                        {
                            __tmp61_first = false;
                            string __tmp61Line = __tmp61Reader.ReadLine();
                            __tmp61_last = __tmp61Reader.EndOfStream;
                            __out.Append(__tmp60Prefix);
                            if (__tmp61Line != null) __out.Append(__tmp61Line);
                            if (!__tmp61_last) __out.AppendLine(true);
                            __out.AppendLine(false); //83:40
                        }
                    }
                }
                if (javaReturn.Contains("List")) //85:4
                {
                    string __tmp63Line = "		return \""; //86:1
                    if (__tmp63Line != null) __out.Append(__tmp63Line);
                    StringBuilder __tmp64 = new StringBuilder();
                    __tmp64.Append(name);
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
                    string __tmp65Line = "\";"; //86:17
                    if (__tmp65Line != null) __out.Append(__tmp65Line);
                    __out.AppendLine(false); //86:19
                }
                else //87:5
                {
                    string __tmp67Line = "		return \""; //88:1
                    if (__tmp67Line != null) __out.Append(__tmp67Line);
                    StringBuilder __tmp68 = new StringBuilder();
                    __tmp68.Append(reference.Name);
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
                    string __tmp69Line = "View\";"; //88:27
                    if (__tmp69Line != null) __out.Append(__tmp69Line);
                    __out.AppendLine(false); //88:33
                }
                __out.Append("	}"); //90:1
                __out.AppendLine(false); //90:3
                __out.AppendLine(true); //91:2
            }
            __out.Append("}"); //93:1
            __out.AppendLine(false); //93:2
            return __out.ToString();
        }

        public string ControllerMethodImpl(Reference reference, Operation op) //98:1
        {
            StringBuilder __out = new StringBuilder();
            if (op.Result.Type.GetJavaName() == "void") //99:3
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
                string __tmp3Line = "."; //100:31
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
                string __tmp5Line = "("; //100:55
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
                string __tmp7Line = ");"; //100:102
                if (__tmp7Line != null) __out.Append(__tmp7Line);
                __out.AppendLine(false); //100:104
            }
            else //101:3
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
                string __tmp10Line = " result = "; //102:31
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
                string __tmp12Line = "."; //102:71
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
                string __tmp14Line = "("; //102:95
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
                string __tmp16Line = ");"; //102:142
                if (__tmp16Line != null) __out.Append(__tmp16Line);
                __out.AppendLine(false); //102:144
                ArrayType array = (op.Result.Type as ArrayType); //103:2
                if (array != null) //104:4
                {
                    string __tmp18Line = "model.addAttribute(\""; //105:1
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
                    string __tmp20Line = "List\", result);"; //105:52
                    if (__tmp20Line != null) __out.Append(__tmp20Line);
                    __out.AppendLine(false); //105:67
                }
                else //106:4
                {
                    string __tmp22Line = "model.addAttribute(\""; //107:1
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
                    string __tmp24Line = "\", result);"; //107:51
                    if (__tmp24Line != null) __out.Append(__tmp24Line);
                    __out.AppendLine(false); //107:62
                }
            }
            return __out.ToString();
        }

        public string MethodParameterAnnotated(InputParameter param) //114:1
        {
            StringBuilder __out = new StringBuilder();
            if (param.Type.IsJavaPrimitiveType()) //115:3
            {
                string __tmp2Line = "@RequestParam(value=\""; //116:1
                if (__tmp2Line != null) __out.Append(__tmp2Line);
                StringBuilder __tmp3 = new StringBuilder();
                __tmp3.Append(param.Name.ToString().ToCamelCase());
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
                string __tmp4Line = "\") "; //116:59
                if (__tmp4Line != null) __out.Append(__tmp4Line);
            }
            StringBuilder __tmp6 = new StringBuilder();
            __tmp6.Append(param.Type.GetJavaName());
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
            string __tmp7Line = " "; //118:27
            if (__tmp7Line != null) __out.Append(__tmp7Line);
            StringBuilder __tmp8 = new StringBuilder();
            __tmp8.Append(param.Name.ToString().ToCamelCase());
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
                    __out.AppendLine(false); //118:65
                }
            }
            return __out.ToString();
        }

        public string GenerateIndexView(Namespace ns) //123:1
        {
            StringBuilder __out = new StringBuilder();
            __out.Append("<!DOCTYPE html>"); //124:1
            __out.AppendLine(false); //124:16
            __out.Append("<html xmlns:th=\"http://www.thymeleaf.org\">"); //125:1
            __out.AppendLine(false); //125:43
            __out.Append("<head th:substituteby=\"_master :: head\">"); //126:1
            __out.AppendLine(false); //126:41
            __out.Append("    <title>Simple</title>"); //127:1
            __out.AppendLine(false); //127:26
            __out.Append("    <link rel=\"stylesheet\" href=\"../resources/css/foundation.min.css\"/>"); //128:1
            __out.AppendLine(false); //128:72
            __out.Append("    <link rel=\"stylesheet\" href=\"../resources/css/style.css\"/>"); //129:1
            __out.AppendLine(false); //129:63
            __out.Append("</head>"); //130:1
            __out.AppendLine(false); //130:8
            __out.Append("<body>"); //131:1
            __out.AppendLine(false); //131:7
            __out.AppendLine(true); //132:1
            __out.Append("<header class=\"template row\" th:substituteby=\"_master :: header\">"); //133:1
            __out.AppendLine(false); //133:66
            __out.Append("    <div class=\"small-10 columns\">"); //134:1
            __out.AppendLine(false); //134:35
            __out.Append("        <h1>//Title//</h1>"); //135:1
            __out.AppendLine(false); //135:27
            __out.Append("    </div>"); //136:1
            __out.AppendLine(false); //136:11
            __out.Append("</header>"); //137:1
            __out.AppendLine(false); //137:10
            __out.AppendLine(true); //138:1
            __out.Append("<div class=\"row\">"); //139:1
            __out.AppendLine(false); //139:18
            __out.Append("    <div class=\"small-10 columns\">"); //140:1
            __out.AppendLine(false); //140:35
            string __tmp2Line = "		<h2>Hello World in "; //141:1
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
            string __tmp4Line = "</h2>"; //141:31
            if (__tmp4Line != null) __out.Append(__tmp4Line);
            __out.AppendLine(false); //141:36
            __out.AppendLine(true); //142:3
            __out.Append("		<div class=\"small-2 columns template\" th:substituteby=\"_master :: sidebar\">"); //143:1
            __out.AppendLine(false); //143:78
            __out.Append("			//side-nav menu//"); //144:1
            __out.AppendLine(false); //144:21
            __out.Append("		</div>"); //145:1
            __out.AppendLine(false); //145:9
            __out.Append("	</div>"); //146:1
            __out.AppendLine(false); //146:8
            __out.Append("</div>"); //147:1
            __out.AppendLine(false); //147:7
            __out.AppendLine(true); //148:1
            __out.Append("<footer class=\"template row\" th:substituteby=\"_master :: footer\">"); //149:1
            __out.AppendLine(false); //149:66
            __out.Append("    <div class=\"large-12 columns\">"); //150:1
            __out.AppendLine(false); //150:35
            __out.Append("        <hr/>"); //151:1
            __out.AppendLine(false); //151:14
            __out.Append("        <div class=\"row\">"); //152:1
            __out.AppendLine(false); //152:26
            __out.Append("            <div class=\"small-4 columns\">"); //153:1
            __out.AppendLine(false); //153:42
            __out.Append("                //copyright//"); //154:1
            __out.AppendLine(false); //154:30
            __out.Append("            </div>"); //155:1
            __out.AppendLine(false); //155:19
            __out.Append("            <div class=\"small-8 columns\">"); //156:1
            __out.AppendLine(false); //156:42
            __out.Append("                <span class=\"right\">//powered by//</span>"); //157:1
            __out.AppendLine(false); //157:58
            __out.Append("            </div>"); //158:1
            __out.AppendLine(false); //158:19
            __out.Append("        </div>"); //159:1
            __out.AppendLine(false); //159:15
            __out.Append("    </div>"); //160:1
            __out.AppendLine(false); //160:11
            __out.Append("</footer>"); //161:1
            __out.AppendLine(false); //161:10
            __out.AppendLine(true); //162:1
            __out.Append("</body>"); //163:1
            __out.AppendLine(false); //163:8
            __out.Append("</html>"); //164:1
            __out.AppendLine(false); //164:8
            return __out.ToString();
        }

        public string GenerateView(Reference reference) //169:1
        {
            StringBuilder __out = new StringBuilder();
            __out.Append("<!DOCTYPE html>"); //170:1
            __out.AppendLine(false); //170:16
            __out.Append("<html xmlns:th=\"http://www.thymeleaf.org\">"); //171:1
            __out.AppendLine(false); //171:43
            __out.Append("<head th:substituteby=\"_master :: head\">"); //172:1
            __out.AppendLine(false); //172:41
            __out.Append("    <title>Simple</title>"); //173:1
            __out.AppendLine(false); //173:26
            __out.Append("    <link rel=\"stylesheet\" href=\"../resources/css/foundation.min.css\"/>"); //174:1
            __out.AppendLine(false); //174:72
            __out.Append("    <link rel=\"stylesheet\" href=\"../resources/css/style.css\"/>"); //175:1
            __out.AppendLine(false); //175:63
            __out.Append("</head>"); //176:1
            __out.AppendLine(false); //176:8
            __out.Append("<body>"); //177:1
            __out.AppendLine(false); //177:7
            __out.AppendLine(true); //178:1
            __out.Append("<header class=\"template row\" th:substituteby=\"_master :: header\">"); //179:1
            __out.AppendLine(false); //179:66
            __out.Append("    <div class=\"small-10 columns\">"); //180:1
            __out.AppendLine(false); //180:35
            __out.Append("        <h1>//Title//</h1>"); //181:1
            __out.AppendLine(false); //181:27
            __out.Append("    </div>"); //182:1
            __out.AppendLine(false); //182:11
            __out.Append("</header>"); //183:1
            __out.AppendLine(false); //183:10
            __out.AppendLine(true); //184:1
            __out.Append("<div class=\"row\">"); //185:1
            __out.AppendLine(false); //185:18
            __out.Append("    <div class=\"small-10 columns\">"); //186:1
            __out.AppendLine(false); //186:35
            string __tmp2Line = "		<h2>"; //187:1
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
            string __tmp4Line = "</h2>"; //187:33
            if (__tmp4Line != null) __out.Append(__tmp4Line);
            __out.AppendLine(false); //187:38
            __out.AppendLine(true); //188:1
            int ids = 0; //189:2
            var __loop4_results = 
                (from __loop4_var1 in __Enumerate((reference.Interface).GetEnumerator()) //190:7
                from action in __Enumerate((__loop4_var1.Operations).GetEnumerator()) //190:28
                select new { __loop4_var1 = __loop4_var1, action = action}
                ).ToList(); //190:2
            int __loop4_iteration = 0;
            foreach (var __tmp5 in __loop4_results)
            {
                ++__loop4_iteration;
                var __loop4_var1 = __tmp5.__loop4_var1;
                var action = __tmp5.action;
                string actionName = action.Name; //191:3
                string method = "POST"; //192:3
                if (actionName.ToPascalCase().StartsWith("Get")) //193:3
                {
                    method = "POST";
                    actionName = actionName.Substring(3);
                }
                string javaReturn = action.Result.Type.GetJavaName(); //198:3
                if (javaReturn.Contains("List") && !action.Parameters.Any()) //200:3
                {
                    string __tmp7Line = "		<a href=\""; //201:1
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
                    string __tmp9Line = "\">"; //201:24
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
                    string __tmp11Line = "</a>"; //201:38
                    if (__tmp11Line != null) __out.Append(__tmp11Line);
                    __out.AppendLine(false); //201:42
                }
                else //202:3
                {
                    string __tmp13Line = "		<form action=\""; //203:1
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
                    string __tmp15Line = "\" method=\""; //203:29
                    if (__tmp15Line != null) __out.Append(__tmp15Line);
                    StringBuilder __tmp16 = new StringBuilder();
                    __tmp16.Append(method);
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
                    string __tmp17Line = "\">"; //203:47
                    if (__tmp17Line != null) __out.Append(__tmp17Line);
                    __out.AppendLine(false); //203:49
                    if (action.Parameters.Any()) //205:4
                    {
                        __out.Append("			<fieldset>"); //206:1
                        __out.AppendLine(false); //206:14
                        string __tmp19Line = "				<legend>"; //207:1
                        if (__tmp19Line != null) __out.Append(__tmp19Line);
                        StringBuilder __tmp20 = new StringBuilder();
                        __tmp20.Append(actionName);
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
                        string __tmp21Line = "</legend>"; //207:25
                        if (__tmp21Line != null) __out.Append(__tmp21Line);
                        __out.AppendLine(false); //207:34
                    }
                    var __loop5_results = 
                        (from __loop5_var1 in __Enumerate((action).GetEnumerator()) //210:9
                        from input in __Enumerate((__loop5_var1.Parameters).GetEnumerator()) //210:17
                        select new { __loop5_var1 = __loop5_var1, input = input}
                        ).ToList(); //210:4
                    int __loop5_iteration = 0;
                    foreach (var __tmp22 in __loop5_results)
                    {
                        ++__loop5_iteration;
                        var __loop5_var1 = __tmp22.__loop5_var1;
                        var input = __tmp22.input;
                        string id = (ids++).ToString(); //211:5
                        string __tmp24Line = "				<label for=\""; //212:1
                        if (__tmp24Line != null) __out.Append(__tmp24Line);
                        StringBuilder __tmp25 = new StringBuilder();
                        __tmp25.Append(id);
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
                        string __tmp26Line = "\">"; //212:21
                        if (__tmp26Line != null) __out.Append(__tmp26Line);
                        StringBuilder __tmp27 = new StringBuilder();
                        __tmp27.Append(input.Name);
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
                        string __tmp28Line = ": </label>"; //212:35
                        if (__tmp28Line != null) __out.Append(__tmp28Line);
                        __out.AppendLine(false); //212:45
                        string __tmp30Line = "				<input id=\""; //213:1
                        if (__tmp30Line != null) __out.Append(__tmp30Line);
                        StringBuilder __tmp31 = new StringBuilder();
                        __tmp31.Append(id);
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
                        string __tmp32Line = "\" type=\"text\" name=\""; //213:20
                        if (__tmp32Line != null) __out.Append(__tmp32Line);
                        StringBuilder __tmp33 = new StringBuilder();
                        __tmp33.Append(input.Name);
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
                        string __tmp34Line = "\" />"; //213:52
                        if (__tmp34Line != null) __out.Append(__tmp34Line);
                        __out.AppendLine(false); //213:56
                    }
                    string __tmp36Line = "				<input type=\"submit\" value=\""; //215:1
                    if (__tmp36Line != null) __out.Append(__tmp36Line);
                    StringBuilder __tmp37 = new StringBuilder();
                    __tmp37.Append(action.Name);
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
                    string __tmp38Line = "\" />"; //215:46
                    if (__tmp38Line != null) __out.Append(__tmp38Line);
                    __out.AppendLine(false); //215:50
                    if (javaReturn != "void" && !javaReturn.Contains("List")) //217:4
                    {
                        string id = (ids++).ToString(); //218:5
                        string __tmp40Line = "				<input id=\""; //219:1
                        if (__tmp40Line != null) __out.Append(__tmp40Line);
                        StringBuilder __tmp41 = new StringBuilder();
                        __tmp41.Append(id);
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
                        string __tmp42Line = "\" type=\"text\" name=\""; //219:20
                        if (__tmp42Line != null) __out.Append(__tmp42Line);
                        StringBuilder __tmp43 = new StringBuilder();
                        __tmp43.Append(actionName);
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
                        string __tmp44Line = "Result\" readonly=\"readonly\" />"; //219:52
                        if (__tmp44Line != null) __out.Append(__tmp44Line);
                        __out.AppendLine(false); //219:82
                    }
                    if (action.Parameters.Any()) //221:4
                    {
                        __out.Append("			</fieldset>"); //222:1
                        __out.AppendLine(false); //222:15
                    }
                    __out.Append("		</form>"); //224:1
                    __out.AppendLine(false); //224:10
                }
                __out.Append("		<br/>"); //226:1
                __out.AppendLine(false); //226:8
            }
            __out.Append("		<div class=\"small-2 columns template\" th:substituteby=\"_master :: sidebar\">"); //228:1
            __out.AppendLine(false); //228:78
            __out.Append("			//side-nav menu//"); //229:1
            __out.AppendLine(false); //229:21
            __out.Append("		</div>"); //230:1
            __out.AppendLine(false); //230:9
            __out.Append("	</div>"); //231:1
            __out.AppendLine(false); //231:8
            __out.Append("</div>"); //232:1
            __out.AppendLine(false); //232:7
            __out.AppendLine(true); //233:1
            __out.Append("<footer class=\"template row\" th:substituteby=\"_master :: footer\">"); //234:1
            __out.AppendLine(false); //234:66
            __out.Append("    <div class=\"large-12 columns\">"); //235:1
            __out.AppendLine(false); //235:35
            __out.Append("        <hr/>"); //236:1
            __out.AppendLine(false); //236:14
            __out.Append("        <div class=\"row\">"); //237:1
            __out.AppendLine(false); //237:26
            __out.Append("            <div class=\"small-4 columns\">"); //238:1
            __out.AppendLine(false); //238:42
            __out.Append("                //copyright//"); //239:1
            __out.AppendLine(false); //239:30
            __out.Append("            </div>"); //240:1
            __out.AppendLine(false); //240:19
            __out.Append("            <div class=\"small-8 columns\">"); //241:1
            __out.AppendLine(false); //241:42
            __out.Append("                <span class=\"right\">//powered by//</span>"); //242:1
            __out.AppendLine(false); //242:58
            __out.Append("            </div>"); //243:1
            __out.AppendLine(false); //243:19
            __out.Append("        </div>"); //244:1
            __out.AppendLine(false); //244:15
            __out.Append("    </div>"); //245:1
            __out.AppendLine(false); //245:11
            __out.Append("</footer>"); //246:1
            __out.AppendLine(false); //246:10
            __out.AppendLine(true); //247:1
            __out.Append("</body>"); //248:1
            __out.AppendLine(false); //248:8
            __out.Append("</html>"); //249:1
            __out.AppendLine(false); //249:8
            return __out.ToString();
        }

        public string GenerateListView(Struct entity) //254:1
        {
            StringBuilder __out = new StringBuilder();
            __out.Append("<!DOCTYPE html>"); //255:1
            __out.AppendLine(false); //255:16
            __out.Append("<html xmlns:th=\"http://www.thymeleaf.org\">"); //256:1
            __out.AppendLine(false); //256:43
            __out.Append("<head th:substituteby=\"_master :: head\">"); //257:1
            __out.AppendLine(false); //257:41
            __out.Append("    <title>Simple</title>"); //258:1
            __out.AppendLine(false); //258:26
            __out.Append("    <link rel=\"stylesheet\" href=\"../resources/css/foundation.min.css\"/>"); //259:1
            __out.AppendLine(false); //259:72
            __out.Append("    <link rel=\"stylesheet\" href=\"../resources/css/style.css\"/>"); //260:1
            __out.AppendLine(false); //260:63
            __out.Append("</head>"); //261:1
            __out.AppendLine(false); //261:8
            __out.Append("<body>"); //262:1
            __out.AppendLine(false); //262:7
            __out.AppendLine(true); //263:1
            __out.Append("<header class=\"template row\" th:substituteby=\"_master :: header\">"); //264:1
            __out.AppendLine(false); //264:66
            __out.Append("    <div class=\"small-10 columns\">"); //265:1
            __out.AppendLine(false); //265:35
            __out.Append("        <h1>//Title//</h1>"); //266:1
            __out.AppendLine(false); //266:27
            __out.Append("    </div>"); //267:1
            __out.AppendLine(false); //267:11
            __out.Append("</header>"); //268:1
            __out.AppendLine(false); //268:10
            __out.AppendLine(true); //269:1
            __out.Append("<div class=\"row\">"); //270:1
            __out.AppendLine(false); //270:18
            __out.Append("    <div class=\"small-10 columns\">"); //271:1
            __out.AppendLine(false); //271:35
            string __tmp2Line = "        <h2>"; //272:1
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
            string __tmp4Line = " list</h2>"; //272:26
            if (__tmp4Line != null) __out.Append(__tmp4Line);
            __out.AppendLine(false); //272:36
            __out.AppendLine(true); //273:1
            __out.Append("        <table>"); //274:1
            __out.AppendLine(false); //274:16
            __out.Append("            <tr>"); //275:1
            __out.AppendLine(false); //275:17
            var __loop6_results = 
                (from __loop6_var1 in __Enumerate((entity).GetEnumerator()) //276:9
                from property in __Enumerate((__loop6_var1.Properties).GetEnumerator()) //276:17
                select new { __loop6_var1 = __loop6_var1, property = property}
                ).ToList(); //276:4
            int __loop6_iteration = 0;
            foreach (var __tmp5 in __loop6_results)
            {
                ++__loop6_iteration;
                var __loop6_var1 = __tmp5.__loop6_var1;
                var property = __tmp5.property;
                string __tmp7Line = "                <th>"; //277:1
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
                string __tmp9Line = "</th>"; //277:36
                if (__tmp9Line != null) __out.Append(__tmp9Line);
                __out.AppendLine(false); //277:41
            }
            __out.Append("            </tr>"); //279:1
            __out.AppendLine(false); //279:18
            string __tmp11Line = "            <tr th:each=\""; //280:1
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
            string __tmp13Line = " : ${"; //280:53
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
            string __tmp15Line = "List}\">"; //280:85
            if (__tmp15Line != null) __out.Append(__tmp15Line);
            __out.AppendLine(false); //280:92
            var __loop7_results = 
                (from __loop7_var1 in __Enumerate((entity).GetEnumerator()) //281:9
                from property in __Enumerate((__loop7_var1.Properties).GetEnumerator()) //281:17
                select new { __loop7_var1 = __loop7_var1, property = property}
                ).ToList(); //281:4
            int __loop7_iteration = 0;
            foreach (var __tmp16 in __loop7_results)
            {
                ++__loop7_iteration;
                var __loop7_var1 = __tmp16.__loop7_var1;
                var property = __tmp16.property;
                string __tmp18Line = "				<td th:text=\"${"; //282:1
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
                string __tmp20Line = "."; //282:47
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
                string __tmp22Line = "}\">Data</td>"; //282:77
                if (__tmp22Line != null) __out.Append(__tmp22Line);
                __out.AppendLine(false); //282:89
            }
            __out.Append("            </tr>"); //284:1
            __out.AppendLine(false); //284:18
            __out.Append("        </table>"); //285:1
            __out.AppendLine(false); //285:17
            __out.Append("    </div>"); //286:1
            __out.AppendLine(false); //286:11
            __out.Append("    <div class=\"small-2 columns template\" th:substituteby=\"_master :: sidebar\">"); //287:1
            __out.AppendLine(false); //287:80
            __out.Append("        //side-nav menu//"); //288:1
            __out.AppendLine(false); //288:26
            __out.Append("    </div>"); //289:1
            __out.AppendLine(false); //289:11
            __out.Append("</div>"); //290:1
            __out.AppendLine(false); //290:7
            __out.AppendLine(true); //291:1
            __out.Append("<footer class=\"template row\" th:substituteby=\"_master :: footer\">"); //292:1
            __out.AppendLine(false); //292:66
            __out.Append("    <div class=\"large-12 columns\">"); //293:1
            __out.AppendLine(false); //293:35
            __out.Append("        <hr/>"); //294:1
            __out.AppendLine(false); //294:14
            __out.Append("        <div class=\"row\">"); //295:1
            __out.AppendLine(false); //295:26
            __out.Append("            <div class=\"small-4 columns\">"); //296:1
            __out.AppendLine(false); //296:42
            __out.Append("                //copyright//"); //297:1
            __out.AppendLine(false); //297:30
            __out.Append("            </div>"); //298:1
            __out.AppendLine(false); //298:19
            __out.Append("            <div class=\"small-8 columns\">"); //299:1
            __out.AppendLine(false); //299:42
            __out.Append("                <span class=\"right\">//powered by//</span>"); //300:1
            __out.AppendLine(false); //300:58
            __out.Append("            </div>"); //301:1
            __out.AppendLine(false); //301:19
            __out.Append("        </div>"); //302:1
            __out.AppendLine(false); //302:15
            __out.Append("    </div>"); //303:1
            __out.AppendLine(false); //303:11
            __out.Append("</footer>"); //304:1
            __out.AppendLine(false); //304:10
            __out.AppendLine(true); //305:1
            __out.Append("</body>"); //306:1
            __out.AppendLine(false); //306:8
            __out.Append("</html>"); //307:1
            __out.AppendLine(false); //307:8
            return __out.ToString();
        }

        public string GenerateMasterView(string applicationName, List<ViewInfoHolder> views) //312:1
        {
            StringBuilder __out = new StringBuilder();
            __out.Append("<!DOCTYPE html>"); //313:1
            __out.AppendLine(false); //313:16
            __out.Append("<html xmlns:th=\"http://www.thymeleaf.org\">"); //314:1
            __out.AppendLine(false); //314:43
            __out.AppendLine(true); //315:1
            __out.Append("<head th:fragment=\"head\">"); //316:1
            __out.AppendLine(false); //316:26
            string __tmp2Line = "    <title>"; //317:1
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
            string __tmp4Line = "</title>"; //317:29
            if (__tmp4Line != null) __out.Append(__tmp4Line);
            __out.AppendLine(false); //317:37
            __out.Append("    <meta name=\"viewport\" content=\"width=device-width\"/>"); //318:1
            __out.AppendLine(false); //318:57
            __out.Append("    <link rel=\"stylesheet\" href=\"../resources/css/normalize.css\""); //319:1
            __out.AppendLine(false); //319:65
            __out.Append("          th:href=\"@{/resources/css/normalize.css}\"/>"); //320:1
            __out.AppendLine(false); //320:54
            __out.Append("    <link rel=\"stylesheet\" href=\"../resources/css/foundation.min.css\""); //321:1
            __out.AppendLine(false); //321:70
            __out.Append("          th:href=\"@{/resources/css/foundation.min.css}\"/>"); //322:1
            __out.AppendLine(false); //322:59
            __out.Append("    <link rel=\"stylesheet\" href=\"../resources/css/style.css\""); //323:1
            __out.AppendLine(false); //323:61
            __out.Append("          th:href=\"@{/resources/css/style.css}\"/>"); //324:1
            __out.AppendLine(false); //324:50
            __out.Append("    <script type=\"text/javascript\" src=\"../resources/js/vendor/custom.modernizr.js\""); //325:1
            __out.AppendLine(false); //325:84
            __out.Append("            th:src=\"@{/resources/js/vendor/custom.modernizr.js}\"></script>"); //326:1
            __out.AppendLine(false); //326:75
            __out.Append("    <script type=\"text/javascript\" src=\"../resources/js/vendor/jquery.js\""); //327:1
            __out.AppendLine(false); //327:74
            __out.Append("            th:src=\"@{/resources/js/vendor/jquery.js}\"></script>"); //328:1
            __out.AppendLine(false); //328:65
            __out.Append("    <script type=\"text/javascript\" src=\"../resources/js/foundation.min.js\""); //329:1
            __out.AppendLine(false); //329:75
            __out.Append("            th:src=\"@{/resources/js/foundation.min.js}\"></script>"); //330:1
            __out.AppendLine(false); //330:66
            __out.Append("    <script type=\"text/javascript\" src=\"../resources/js/app.js\""); //331:1
            __out.AppendLine(false); //331:64
            __out.Append("            th:src=\"@{/resources/js/app.js}\"></script>"); //332:1
            __out.AppendLine(false); //332:55
            __out.Append("</head>"); //333:1
            __out.AppendLine(false); //333:8
            __out.AppendLine(true); //334:1
            __out.Append("<body>"); //335:1
            __out.AppendLine(false); //335:7
            __out.AppendLine(true); //336:1
            __out.Append("<header class=\"row\" th:fragment=\"header\">"); //337:1
            __out.AppendLine(false); //337:42
            __out.Append("    <div class=\"small-10 columns\">"); //338:1
            __out.AppendLine(false); //338:35
            string __tmp6Line = "        <h1>"; //339:1
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
            string __tmp8Line = "</h1>"; //339:30
            if (__tmp8Line != null) __out.Append(__tmp8Line);
            __out.AppendLine(false); //339:35
            __out.Append("    </div>"); //340:1
            __out.AppendLine(false); //340:11
            __out.Append("</header>"); //341:1
            __out.AppendLine(false); //341:10
            __out.AppendLine(true); //342:1
            __out.Append("<div class=\"row\">"); //343:1
            __out.AppendLine(false); //343:18
            __out.Append("    <div class=\"small-10 columns template\">"); //344:1
            __out.AppendLine(false); //344:44
            __out.Append("        <h2>//content title//</h2>"); //345:1
            __out.AppendLine(false); //345:35
            __out.Append("        <p>//content//</p>"); //347:1
            __out.AppendLine(false); //347:27
            __out.Append("    </div>"); //348:1
            __out.AppendLine(false); //348:11
            __out.AppendLine(true); //349:1
            __out.Append("    <div class=\"small-2 columns\" th:fragment=\"sidebar\">"); //350:1
            __out.AppendLine(false); //350:56
            __out.Append("        <div style=\"width: 140px; margin: 0 auto\">"); //351:1
            __out.AppendLine(false); //351:51
            __out.Append("            <ul class=\"side-nav\">"); //352:1
            __out.AppendLine(false); //352:34
            var __loop8_results = 
                (from view in __Enumerate((views).GetEnumerator()) //353:10
                select new { view = view}
                ).ToList(); //353:5
            int __loop8_iteration = 0;
            foreach (var __tmp9 in __loop8_results)
            {
                ++__loop8_iteration;
                var view = __tmp9.view;
                string __tmp11Line = "                <li><a href=\""; //354:1
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
                string __tmp13Line = "\" th:href=\"@{/"; //354:45
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
                string __tmp15Line = "/}\">"; //354:73
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
                string __tmp17Line = "</a></li>"; //354:88
                if (__tmp17Line != null) __out.Append(__tmp17Line);
                __out.AppendLine(false); //354:97
            }
            __out.Append("            </ul>"); //356:1
            __out.AppendLine(false); //356:18
            __out.Append("        </div>"); //357:1
            __out.AppendLine(false); //357:15
            __out.Append("    </div>"); //358:1
            __out.AppendLine(false); //358:11
            __out.Append("</div>"); //359:1
            __out.AppendLine(false); //359:7
            __out.AppendLine(true); //360:1
            __out.Append("<footer class=\"row\" th:fragment=\"footer\">"); //361:1
            __out.AppendLine(false); //361:42
            __out.Append("    <div class=\"large-12 columns\">"); //362:1
            __out.AppendLine(false); //362:35
            __out.Append("        <hr/>"); //363:1
            __out.AppendLine(false); //363:14
            __out.Append("        <div class=\"row\">"); //364:1
            __out.AppendLine(false); //364:26
            __out.Append("            <div class=\"small-4 columns\">"); //365:1
            __out.AppendLine(false); //365:42
            __out.Append("                <p>&copy; Copyright BME IIT</p>"); //366:1
            __out.AppendLine(false); //366:48
            __out.Append("            </div>"); //367:1
            __out.AppendLine(false); //367:19
            __out.Append("            <div class=\"small-8 columns\">"); //368:1
            __out.AppendLine(false); //368:42
            __out.Append("                <ul class=\"inline-list right\">"); //369:1
            __out.AppendLine(false); //369:47
            __out.Append("                    <li>Powered by</li>"); //370:1
            __out.AppendLine(false); //370:40
            __out.Append("                    <li><a href=\"http://www.spring.io/\">Spring</a></li>"); //371:1
            __out.AppendLine(false); //371:72
            __out.Append("                    <li><a href=\"http://www.thymeleaf.org/\">Thymeleaf</a></li>"); //372:1
            __out.AppendLine(false); //372:79
            __out.Append("                    <li><a href=\"http://foundation.zurb.com/\">Foundation</a></li>"); //373:1
            __out.AppendLine(false); //373:82
            __out.Append("                </ul>"); //374:1
            __out.AppendLine(false); //374:22
            __out.Append("            </div>"); //375:1
            __out.AppendLine(false); //375:19
            __out.Append("        </div>"); //376:1
            __out.AppendLine(false); //376:15
            __out.Append("    </div>"); //377:1
            __out.AppendLine(false); //377:11
            __out.Append("</footer>"); //378:1
            __out.AppendLine(false); //378:10
            __out.AppendLine(true); //379:1
            __out.Append("</body>"); //380:1
            __out.AppendLine(false); //380:8
            __out.Append("</html>"); //381:1
            __out.AppendLine(false); //381:8
            return __out.ToString();
        }

        public string GenerateWebXml(ComponentType cType) //386:1
        {
            StringBuilder __out = new StringBuilder();
            __out.Append("<?xml version=\"1.0\" encoding=\"UTF-8\"?>"); //387:1
            __out.AppendLine(false); //387:39
            __out.Append("<web-app xmlns=\"http://java.sun.com/xml/ns/javaee\""); //388:1
            __out.AppendLine(false); //388:51
            __out.Append("         xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\""); //389:1
            __out.AppendLine(false); //389:63
            __out.Append("         xsi:schemaLocation=\"http://java.sun.com/xml/ns/javaee"); //390:1
            __out.AppendLine(false); //390:63
            __out.Append("		 http://java.sun.com/xml/ns/javaee/web-app_3_0.xsd\" version=\"3.0\">"); //391:1
            __out.AppendLine(false); //391:69
            __out.AppendLine(true); //392:1
            __out.Append("    <servlet>"); //393:1
            __out.AppendLine(false); //393:14
            __out.Append("        <servlet-name>spring</servlet-name>"); //394:1
            __out.AppendLine(false); //394:44
            __out.Append("        <servlet-class>org.springframework.web.servlet.DispatcherServlet</servlet-class>"); //395:1
            __out.AppendLine(false); //395:89
            __out.Append("        <load-on-startup>1</load-on-startup>"); //396:1
            __out.AppendLine(false); //396:45
            __out.Append("    </servlet>"); //397:1
            __out.AppendLine(false); //397:15
            __out.AppendLine(true); //398:1
            __out.Append("    <servlet-mapping>"); //399:1
            __out.AppendLine(false); //399:22
            __out.Append("        <servlet-name>spring</servlet-name>"); //400:1
            __out.AppendLine(false); //400:44
            __out.Append("        <url-pattern>/*</url-pattern>"); //401:1
            __out.AppendLine(false); //401:38
            __out.Append("    </servlet-mapping>"); //402:1
            __out.AppendLine(false); //402:23
            __out.AppendLine(true); //403:1
            __out.Append("    <listener>"); //404:1
            __out.AppendLine(false); //404:15
            __out.Append("        <listener-class>org.springframework.web.context.ContextLoaderListener</listener-class>"); //405:1
            __out.AppendLine(false); //405:95
            __out.Append("    </listener>"); //406:1
            __out.AppendLine(false); //406:16
            if (cType == ComponentType.WEB) //407:2
            {
                __out.AppendLine(true); //408:1
                __out.Append("    <filter>"); //409:1
                __out.AppendLine(false); //409:13
                __out.Append("        <filter-name>characterEncodingFilter</filter-name>"); //410:1
                __out.AppendLine(false); //410:59
                __out.Append("        <filter-class>org.springframework.web.filter.CharacterEncodingFilter</filter-class>"); //411:1
                __out.AppendLine(false); //411:92
                __out.Append("        <init-param>"); //412:1
                __out.AppendLine(false); //412:21
                __out.Append("            <param-name>encoding</param-name>"); //413:1
                __out.AppendLine(false); //413:46
                __out.Append("            <param-value>UTF-8</param-value>"); //414:1
                __out.AppendLine(false); //414:45
                __out.Append("        </init-param>"); //415:1
                __out.AppendLine(false); //415:22
                __out.Append("    </filter>"); //416:1
                __out.AppendLine(false); //416:14
                __out.AppendLine(true); //417:1
                __out.Append("    <filter-mapping>"); //418:1
                __out.AppendLine(false); //418:21
                __out.Append("        <filter-name>characterEncodingFilter</filter-name>"); //419:1
                __out.AppendLine(false); //419:59
                __out.Append("        <servlet-name>spring</servlet-name>"); //420:1
                __out.AppendLine(false); //420:44
                __out.Append("    </filter-mapping>"); //421:1
                __out.AppendLine(false); //421:22
            }
            __out.AppendLine(true); //423:1
            __out.Append("</web-app>"); //424:1
            __out.AppendLine(false); //424:11
            return __out.ToString();
        }

        public string GenerateServlet(Namespace ns, ComponentType cType) //428:1
        {
            StringBuilder __out = new StringBuilder();
            __out.Append("<?xml version=\"1.0\" encoding=\"UTF-8\"?>"); //429:1
            __out.AppendLine(false); //429:39
            __out.Append("<beans xmlns=\"http://www.springframework.org/schema/beans\""); //430:1
            __out.AppendLine(false); //430:59
            __out.Append("       xmlns:mvc=\"http://www.springframework.org/schema/mvc\""); //431:1
            __out.AppendLine(false); //431:61
            __out.Append("       xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\""); //432:1
            __out.AppendLine(false); //432:61
            __out.Append("       xmlns:context=\"http://www.springframework.org/schema/context\""); //433:1
            __out.AppendLine(false); //433:69
            __out.Append("       xsi:schemaLocation=\"http://www.springframework.org/schema/beans"); //434:1
            __out.AppendLine(false); //434:71
            __out.Append("                           http://www.springframework.org/schema/beans/spring-beans.xsd"); //435:1
            __out.AppendLine(false); //435:88
            __out.Append("                           http://www.springframework.org/schema/context"); //436:1
            __out.AppendLine(false); //436:73
            __out.Append("                           http://www.springframework.org/schema/context/spring-context.xsd"); //437:1
            __out.AppendLine(false); //437:92
            __out.Append("                           http://www.springframework.org/schema/mvc"); //438:1
            __out.AppendLine(false); //438:69
            __out.Append("                           http://www.springframework.org/schema/mvc/spring-mvc.xsd\">"); //439:1
            __out.AppendLine(false); //439:86
            __out.AppendLine(true); //440:1
            string __tmp2Line = "    <context:component-scan base-package=\""; //441:1
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
            string __tmp4Line = "."; //441:66
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
            string __tmp6Line = "\"/>"; //441:117
            if (__tmp6Line != null) __out.Append(__tmp6Line);
            __out.AppendLine(false); //441:120
            __out.AppendLine(true); //442:1
            __out.Append("    <mvc:annotation-driven/>"); //443:1
            __out.AppendLine(false); //443:29
            if (cType == ComponentType.WEB) //444:2
            {
                __out.AppendLine(true); //445:1
                __out.Append("    <!--<mvc:resources mapping=\"/favicon.ico\" location=\"/WEB-INF/resources/img/\"/>-->"); //446:1
                __out.AppendLine(false); //446:86
                __out.Append("    <mvc:resources mapping=\"/resources/**\" location=\"/WEB-INF/resources/\"/>"); //447:1
                __out.AppendLine(false); //447:76
                __out.AppendLine(true); //448:1
                __out.Append("    <mvc:interceptors>"); //449:1
                __out.AppendLine(false); //449:23
                __out.Append("        <bean class=\"org.springframework.web.servlet.i18n.LocaleChangeInterceptor\">"); //450:1
                __out.AppendLine(false); //450:84
                __out.Append("            <property name=\"paramName\" value=\"lang\"/>"); //451:1
                __out.AppendLine(false); //451:54
                __out.Append("        </bean>"); //452:1
                __out.AppendLine(false); //452:16
                __out.Append("    </mvc:interceptors>"); //453:1
                __out.AppendLine(false); //453:24
                __out.AppendLine(true); //454:1
                __out.Append("    <bean id=\"templateResolver\" class=\"org.thymeleaf.templateresolver.ServletContextTemplateResolver\">"); //455:1
                __out.AppendLine(false); //455:103
                __out.Append("        <property name=\"prefix\" value=\"/WEB-INF/view/\"/>"); //456:1
                __out.AppendLine(false); //456:57
                __out.Append("        <property name=\"suffix\" value=\".html\"/>"); //457:1
                __out.AppendLine(false); //457:48
                __out.Append("        <property name=\"characterEncoding\" value=\"UTF-8\"/>"); //458:1
                __out.AppendLine(false); //458:59
                __out.Append("        <property name=\"templateMode\" value=\"HTML5\"/>"); //459:1
                __out.AppendLine(false); //459:54
                __out.Append("        <property name=\"cacheable\" value=\"false\"/>"); //460:1
                __out.AppendLine(false); //460:51
                __out.Append("    </bean>"); //461:1
                __out.AppendLine(false); //461:12
                __out.AppendLine(true); //462:1
                __out.Append("    <bean id=\"templateEngine\" class=\"org.thymeleaf.spring4.SpringTemplateEngine\">"); //463:1
                __out.AppendLine(false); //463:82
                __out.Append("        <property name=\"templateResolver\" ref=\"templateResolver\"/>"); //464:1
                __out.AppendLine(false); //464:67
                __out.Append("    </bean>"); //465:1
                __out.AppendLine(false); //465:12
                __out.AppendLine(true); //466:1
                __out.Append("    <bean class=\"org.thymeleaf.spring4.view.ThymeleafViewResolver\">"); //467:1
                __out.AppendLine(false); //467:68
                __out.Append("        <property name=\"templateEngine\" ref=\"templateEngine\"/>"); //468:1
                __out.AppendLine(false); //468:63
                __out.Append("        <property name=\"contentType\" value=\"text/html; charset=UTF-8\"/>"); //469:1
                __out.AppendLine(false); //469:72
                __out.Append("        <property name=\"characterEncoding\" value=\"UTF-8\"/>"); //470:1
                __out.AppendLine(false); //470:59
                __out.Append("    </bean>"); //471:1
                __out.AppendLine(false); //471:12
                __out.AppendLine(true); //472:1
                __out.Append("    <bean id=\"localeResolver\" class=\"org.springframework.web.servlet.i18n.SessionLocaleResolver\"/>"); //473:1
                __out.AppendLine(false); //473:99
            }
            __out.AppendLine(true); //475:1
            __out.Append("</beans>"); //476:1
            __out.AppendLine(false); //476:9
            return __out.ToString();
        }

        public string GenerateJboss() //481:1
        {
            StringBuilder __out = new StringBuilder();
            __out.Append("<?xml version=\"1.0\" encoding=\"UTF-8\"?>"); //482:1
            __out.AppendLine(false); //482:39
            __out.Append("<jboss-deployment-structure>"); //483:1
            __out.AppendLine(false); //483:29
            __out.Append("    <deployment>"); //484:1
            __out.AppendLine(false); //484:17
            __out.Append("        <dependencies>"); //485:1
            __out.AppendLine(false); //485:23
            __out.Append("            <module name=\"com.h2database.h2\" />"); //486:1
            __out.AppendLine(false); //486:48
            __out.Append("			<module name=\"org.eclipse.persistence\" />"); //487:1
            __out.AppendLine(false); //487:45
            __out.Append("        </dependencies>"); //488:1
            __out.AppendLine(false); //488:24
            __out.Append("    </deployment>"); //489:1
            __out.AppendLine(false); //489:18
            __out.Append("</jboss-deployment-structure>"); //490:1
            __out.AppendLine(false); //490:30
            return __out.ToString();
        }

        public string GenerateAppCtx(Namespace ns, bool hasDirectDataLink) //494:1
        {
            StringBuilder __out = new StringBuilder();
            __out.Append("<?xml version=\"1.0\" encoding=\"UTF-8\"?>"); //495:1
            __out.AppendLine(false); //495:39
            __out.Append("<beans xmlns=\"http://www.springframework.org/schema/beans\""); //496:1
            __out.AppendLine(false); //496:59
            __out.Append("       xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\""); //497:1
            __out.AppendLine(false); //497:61
            __out.Append("       xmlns:context=\"http://www.springframework.org/schema/context\""); //498:1
            __out.AppendLine(false); //498:69
            __out.Append("       xmlns:jpa=\"http://www.springframework.org/schema/data/jpa\""); //499:1
            __out.AppendLine(false); //499:66
            __out.Append("       xsi:schemaLocation=\"http://www.springframework.org/schema/beans"); //500:1
            __out.AppendLine(false); //500:71
            __out.Append("       http://www.springframework.org/schema/beans/spring-beans.xsd"); //501:1
            __out.AppendLine(false); //501:68
            __out.Append("       http://www.springframework.org/schema/context"); //502:1
            __out.AppendLine(false); //502:53
            __out.Append("       http://www.springframework.org/schema/context/spring-context.xsd"); //503:1
            __out.AppendLine(false); //503:72
            __out.Append("       http://www.springframework.org/schema/data/jpa"); //504:1
            __out.AppendLine(false); //504:54
            __out.Append("       http://www.springframework.org/schema/data/jpa/spring-jpa.xsd\">"); //505:1
            __out.AppendLine(false); //505:71
            __out.AppendLine(true); //506:5
            string __tmp2Line = "       <context:component-scan base-package=\""; //507:1
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
            string __tmp4Line = "\"/>"; //507:69
            if (__tmp4Line != null) __out.Append(__tmp4Line);
            __out.AppendLine(false); //507:72
            if (hasDirectDataLink) //508:2
            {
                __out.AppendLine(true); //509:5
                string __tmp6Line = "       <jpa:repositories base-package=\""; //510:1
                if (__tmp6Line != null) __out.Append(__tmp6Line);
                StringBuilder __tmp7 = new StringBuilder();
                __tmp7.Append(ns.FullName.ToLower());
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
                string __tmp8Line = "."; //510:63
                if (__tmp8Line != null) __out.Append(__tmp8Line);
                StringBuilder __tmp9 = new StringBuilder();
                __tmp9.Append(SpringGeneratorUtil.Properties.repositoryPackage);
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
                string __tmp10Line = "\"/>"; //510:114
                if (__tmp10Line != null) __out.Append(__tmp10Line);
                __out.AppendLine(false); //510:117
                __out.AppendLine(true); //511:5
                __out.Append("       <bean id=\"jpaVendorAdapter\" class=\"org.springframework.orm.jpa.vendor.EclipseLinkJpaVendorAdapter\"/>"); //512:1
                __out.AppendLine(false); //512:108
                __out.Append("       <bean id=\"entityManagerFactory\" class=\"org.springframework.orm.jpa.LocalEntityManagerFactoryBean\">"); //513:1
                __out.AppendLine(false); //513:106
                string __tmp12Line = "              <property name=\"persistenceUnitName\" value=\""; //514:1
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
                string __tmp14Line = "PU\"/>"; //514:68
                if (__tmp14Line != null) __out.Append(__tmp14Line);
                __out.AppendLine(false); //514:73
                __out.Append("              <property name=\"jpaVendorAdapter\" ref=\"jpaVendorAdapter\"/>"); //515:1
                __out.AppendLine(false); //515:73
                __out.Append("       </bean>"); //516:1
                __out.AppendLine(false); //516:15
                __out.Append("       <bean id=\"transactionManager\" class=\"org.springframework.orm.jpa.JpaTransactionManager\">"); //517:1
                __out.AppendLine(false); //517:96
                __out.Append("              <property name=\"entityManagerFactory\" ref=\"entityManagerFactory\"/>"); //518:1
                __out.AppendLine(false); //518:81
                __out.Append("       </bean>"); //519:1
                __out.AppendLine(false); //519:15
            }
            __out.AppendLine(true); //521:1
            __out.Append("</beans>"); //522:1
            __out.AppendLine(false); //522:9
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
