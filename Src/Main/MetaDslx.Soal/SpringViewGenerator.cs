using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Soal //1:1
{
    using __Hidden_SpringViewGenerator_2049079977;
    namespace __Hidden_SpringViewGenerator_2049079977
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
            string __tmp17Line = "public class "; //14:1
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
            string __tmp19Line = "Controller {"; //14:30
            if (__tmp19Line != null) __out.Append(__tmp19Line);
            __out.AppendLine(false); //14:42
            __out.AppendLine(true); //15:1
            __out.Append("	@Autowired"); //16:1
            __out.AppendLine(false); //16:12
            string __tmp21Line = "	private "; //17:1
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
            string __tmp24Line = " "; //17:83
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
            string __tmp26Line = ";"; //17:114
            if (__tmp26Line != null) __out.Append(__tmp26Line);
            __out.AppendLine(false); //17:115
            __out.AppendLine(true); //18:2
            var __loop1_results = 
                (from __loop1_var1 in __Enumerate((reference.Interface).GetEnumerator()) //19:9
                from op in __Enumerate((__loop1_var1.Operations).GetEnumerator()) //19:30
                select new { __loop1_var1 = __loop1_var1, op = op}
                ).ToList(); //19:4
            int __loop1_iteration = 0;
            foreach (var __tmp27 in __loop1_results)
            {
                ++__loop1_iteration;
                var __loop1_var1 = __tmp27.__loop1_var1;
                var op = __tmp27.op;
                string __tmp29Line = "	public "; //20:1
                if (__tmp29Line != null) __out.Append(__tmp29Line);
                StringBuilder __tmp30 = new StringBuilder();
                __tmp30.Append(op.Result.Type.GetJavaName());
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
                string __tmp31Line = " "; //20:39
                if (__tmp31Line != null) __out.Append(__tmp31Line);
                StringBuilder __tmp32 = new StringBuilder();
                __tmp32.Append(op.Name.ToCamelCase());
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
                string __tmp33Line = "("; //20:63
                if (__tmp33Line != null) __out.Append(__tmp33Line);
                StringBuilder __tmp34 = new StringBuilder();
                __tmp34.Append(SpringGeneratorUtil.GetParameterList(op));
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
                string __tmp35Line = ") {"; //20:106
                if (__tmp35Line != null) __out.Append(__tmp35Line);
                __out.AppendLine(false); //20:109
                __out.Append("		// TODO implement method"); //21:1
                __out.AppendLine(false); //21:27
                __out.Append("		throw new UnsupportedOperationException(\"Not yet implemented.\");"); //22:1
                __out.AppendLine(false); //22:67
                __out.Append("	}"); //23:1
                __out.AppendLine(false); //23:3
                __out.AppendLine(true); //24:2
            }
            __out.Append("}"); //26:1
            __out.AppendLine(false); //26:2
            return __out.ToString();
        }

        public string GenerateView(Reference reference) //31:1
        {
            StringBuilder __out = new StringBuilder();
            __out.Append("<!DOCTYPE html>"); //32:1
            __out.AppendLine(false); //32:16
            __out.Append("<html xmlns:th=\"http://www.thymeleaf.org\">"); //33:1
            __out.AppendLine(false); //33:43
            __out.Append("<head th:substituteby=\"_master :: head\">"); //34:1
            __out.AppendLine(false); //34:41
            __out.Append("    <title>Simple</title>"); //35:1
            __out.AppendLine(false); //35:26
            __out.Append("    <link rel=\"stylesheet\" href=\"../resources/css/foundation.min.css\"/>"); //36:1
            __out.AppendLine(false); //36:72
            __out.Append("    <link rel=\"stylesheet\" href=\"../resources/css/style.css\"/>"); //37:1
            __out.AppendLine(false); //37:63
            __out.Append("</head>"); //38:1
            __out.AppendLine(false); //38:8
            __out.Append("<body>"); //39:1
            __out.AppendLine(false); //39:7
            __out.AppendLine(true); //40:1
            __out.Append("<header class=\"template row\" th:substituteby=\"_master :: header\">"); //41:1
            __out.AppendLine(false); //41:66
            __out.Append("    <div class=\"small-10 columns\">"); //42:1
            __out.AppendLine(false); //42:35
            __out.Append("        <h1>//Title///h1>"); //43:1
            __out.AppendLine(false); //43:26
            __out.Append("    </div>"); //44:1
            __out.AppendLine(false); //44:11
            __out.Append("</header>"); //45:1
            __out.AppendLine(false); //45:10
            __out.AppendLine(true); //46:1
            __out.Append("<div class=\"row\">"); //47:1
            __out.AppendLine(false); //47:18
            __out.Append("    <div class=\"small-10 columns\">"); //48:1
            __out.AppendLine(false); //48:35
            __out.Append("        <h2>List of users in database</h2>"); //49:1
            __out.AppendLine(false); //49:43
            __out.AppendLine(true); //50:1
            __out.Append("        <table>"); //51:1
            __out.AppendLine(false); //51:16
            __out.Append("            <tr>"); //52:1
            __out.AppendLine(false); //52:17
            __out.Append("                <th>UserId</th>"); //53:1
            __out.AppendLine(false); //53:32
            __out.Append("                <th>Name</th>"); //54:1
            __out.AppendLine(false); //54:30
            __out.Append("            </tr>"); //55:1
            __out.AppendLine(false); //55:18
            __out.Append("            <tr th:each=\"user : ${users}\">"); //56:1
            __out.AppendLine(false); //56:43
            __out.Append("                <td th:text=\"${user.userId}\">12</td>"); //57:1
            __out.AppendLine(false); //57:53
            __out.Append("                <td th:text=\"${user.useName}\">Attila</td>"); //58:1
            __out.AppendLine(false); //58:58
            __out.Append("                <!--<td th:text=\"${#aggregates.sum(o.orderLines.{purchasePrice * amount})}\">23.32</td>-->"); //59:1
            __out.AppendLine(false); //59:106
            __out.Append("                <!--<td>-->"); //60:1
            __out.AppendLine(false); //60:28
            __out.Append("                    <!--<a href=\"details.html\" th:href=\"@{/order/details(orderId=${o.id})}\">view</a>-->"); //61:1
            __out.AppendLine(false); //61:104
            __out.Append("                <!--</td>-->"); //62:1
            __out.AppendLine(false); //62:29
            __out.Append("            </tr>"); //63:1
            __out.AppendLine(false); //63:18
            __out.Append("        </table>"); //64:1
            __out.AppendLine(false); //64:17
            __out.Append("    </div>"); //65:1
            __out.AppendLine(false); //65:11
            __out.Append("    <div class=\"small-2 columns template\" th:substituteby=\"_master :: sidebar\">"); //66:1
            __out.AppendLine(false); //66:80
            __out.Append("        //side-nav menu//"); //67:1
            __out.AppendLine(false); //67:26
            __out.Append("    </div>"); //68:1
            __out.AppendLine(false); //68:11
            __out.Append("</div>"); //69:1
            __out.AppendLine(false); //69:7
            __out.AppendLine(true); //70:1
            __out.Append("<footer class=\"template row\" th:substituteby=\"_master :: footer\">"); //71:1
            __out.AppendLine(false); //71:66
            __out.Append("    <div class=\"large-12 columns\">"); //72:1
            __out.AppendLine(false); //72:35
            __out.Append("        <hr/>"); //73:1
            __out.AppendLine(false); //73:14
            __out.Append("        <div class=\"row\">"); //74:1
            __out.AppendLine(false); //74:26
            __out.Append("            <div class=\"small-4 columns\">"); //75:1
            __out.AppendLine(false); //75:42
            __out.Append("                //copyright//"); //76:1
            __out.AppendLine(false); //76:30
            __out.Append("            </div>"); //77:1
            __out.AppendLine(false); //77:19
            __out.Append("            <div class=\"small-8 columns\">"); //78:1
            __out.AppendLine(false); //78:42
            __out.Append("                <span class=\"right\">//powered by//</span>"); //79:1
            __out.AppendLine(false); //79:58
            __out.Append("            </div>"); //80:1
            __out.AppendLine(false); //80:19
            __out.Append("        </div>"); //81:1
            __out.AppendLine(false); //81:15
            __out.Append("    </div>"); //82:1
            __out.AppendLine(false); //82:11
            __out.Append("</footer>"); //83:1
            __out.AppendLine(false); //83:10
            __out.AppendLine(true); //84:1
            __out.Append("</body>"); //85:1
            __out.AppendLine(false); //85:8
            __out.Append("</html>"); //86:1
            __out.AppendLine(false); //86:8
            return __out.ToString();
        }

        public string GenerateMasterView() //91:1
        {
            StringBuilder __out = new StringBuilder();
            __out.Append("<!DOCTYPE html>"); //92:1
            __out.AppendLine(false); //92:16
            __out.Append("<html xmlns:th=\"http://www.thymeleaf.org\">"); //93:1
            __out.AppendLine(false); //93:43
            __out.AppendLine(true); //94:1
            __out.Append("<head th:fragment=\"head\">"); //95:1
            __out.AppendLine(false); //95:26
            __out.Append("    <title>Simple</title>"); //96:1
            __out.AppendLine(false); //96:26
            __out.Append("    <meta name=\"viewport\" content=\"width=device-width\"/>"); //97:1
            __out.AppendLine(false); //97:57
            __out.Append("    <link rel=\"stylesheet\" href=\"../resources/css/normalize.css\""); //98:1
            __out.AppendLine(false); //98:65
            __out.Append("          th:href=\"@{/resources/css/normalize.css}\"/>"); //99:1
            __out.AppendLine(false); //99:54
            __out.Append("    <link rel=\"stylesheet\" href=\"../resources/css/foundation.min.css\""); //100:1
            __out.AppendLine(false); //100:70
            __out.Append("          th:href=\"@{/resources/css/foundation.min.css}\"/>"); //101:1
            __out.AppendLine(false); //101:59
            __out.Append("    <link rel=\"stylesheet\" href=\"../resources/css/style.css\""); //102:1
            __out.AppendLine(false); //102:61
            __out.Append("          th:href=\"@{/resources/css/style.css}\"/>"); //103:1
            __out.AppendLine(false); //103:50
            __out.Append("    <script type=\"text/javascript\" src=\"../resources/js/vendor/custom.modernizr.js\""); //104:1
            __out.AppendLine(false); //104:84
            __out.Append("            th:src=\"@{/resources/js/vendor/custom.modernizr.js}\" />"); //105:1
            __out.AppendLine(false); //105:68
            __out.Append("    <script type=\"text/javascript\" src=\"../resources/js/vendor/jquery.js\""); //106:1
            __out.AppendLine(false); //106:74
            __out.Append("            th:src=\"@{/resources/js/vendor/jquery.js}\" />"); //107:1
            __out.AppendLine(false); //107:58
            __out.Append("    <script type=\"text/javascript\" src=\"../resources/js/foundation.min.js\""); //108:1
            __out.AppendLine(false); //108:75
            __out.Append("            th:src=\"@{/resources/js/foundation.min.js}\" />"); //109:1
            __out.AppendLine(false); //109:59
            __out.Append("    <script type=\"text/javascript\" src=\"../resources/js/app.js\""); //110:1
            __out.AppendLine(false); //110:64
            __out.Append("            th:src=\"@{/resources/js/app.js}\" />"); //111:1
            __out.AppendLine(false); //111:48
            __out.Append("</head>"); //112:1
            __out.AppendLine(false); //112:8
            __out.AppendLine(true); //113:1
            __out.Append("<body>"); //114:1
            __out.AppendLine(false); //114:7
            __out.AppendLine(true); //115:1
            __out.Append("<header class=\"row\" th:fragment=\"header\">"); //116:1
            __out.AppendLine(false); //116:42
            __out.Append("    <div class=\"small-10 columns\">"); //117:1
            __out.AppendLine(false); //117:35
            __out.Append("        <h1>App Name</h1>"); //118:1
            __out.AppendLine(false); //118:26
            __out.Append("    </div>"); //119:1
            __out.AppendLine(false); //119:11
            __out.Append("</header>"); //120:1
            __out.AppendLine(false); //120:10
            __out.AppendLine(true); //121:1
            __out.Append("<div class=\"row\">"); //122:1
            __out.AppendLine(false); //122:18
            __out.Append("    <div class=\"small-10 columns template\">"); //123:1
            __out.AppendLine(false); //123:44
            __out.Append("        <h2>//content title//</h2>"); //124:1
            __out.AppendLine(false); //124:35
            __out.Append("        <p>//content//</p>"); //126:1
            __out.AppendLine(false); //126:27
            __out.Append("    </div>"); //127:1
            __out.AppendLine(false); //127:11
            __out.AppendLine(true); //128:1
            __out.Append("    <div class=\"small-2 columns\" th:fragment=\"sidebar\">"); //129:1
            __out.AppendLine(false); //129:56
            __out.Append("        <div style=\"width: 140px; margin: 0 auto\">"); //130:1
            __out.AppendLine(false); //130:51
            __out.Append("            <ul class=\"side-nav\">"); //131:1
            __out.AppendLine(false); //131:34
            __out.Append("                <!--<li><a href=\"post/list.html\" th:href=\"@{/refresh}\">Refresh</a></li>-->"); //132:1
            __out.AppendLine(false); //132:91
            __out.Append("                <li><a href=\"users.html\" th:href=\"@{/users}\" >Users</a></li>"); //133:1
            __out.AppendLine(false); //133:77
            __out.Append("                       <!--th:text=\"#{page.users}\">Users</a></li>-->"); //134:1
            __out.AppendLine(false); //134:69
            __out.Append("                <li class=\"divider\"></li>"); //135:1
            __out.AppendLine(false); //135:42
            __out.Append("                <li><a href=\"about.html\" th:href=\"@{/about}\">About</a></li>"); //136:1
            __out.AppendLine(false); //136:76
            __out.Append("            </ul>"); //137:1
            __out.AppendLine(false); //137:18
            __out.Append("        </div>"); //138:1
            __out.AppendLine(false); //138:15
            __out.Append("    </div>"); //139:1
            __out.AppendLine(false); //139:11
            __out.Append("</div>"); //140:1
            __out.AppendLine(false); //140:7
            __out.AppendLine(true); //141:1
            __out.Append("<footer class=\"row\" th:fragment=\"footer\">"); //142:1
            __out.AppendLine(false); //142:42
            __out.Append("    <div class=\"large-12 columns\">"); //143:1
            __out.AppendLine(false); //143:35
            __out.Append("        <hr/>"); //144:1
            __out.AppendLine(false); //144:14
            __out.Append("        <div class=\"row\">"); //145:1
            __out.AppendLine(false); //145:26
            __out.Append("            <div class=\"small-4 columns\">"); //146:1
            __out.AppendLine(false); //146:42
            __out.Append("                <p>&copy; Copyright BME IIT</p>"); //147:1
            __out.AppendLine(false); //147:48
            __out.Append("            </div>"); //148:1
            __out.AppendLine(false); //148:19
            __out.Append("            <div class=\"small-8 columns\">"); //149:1
            __out.AppendLine(false); //149:42
            __out.Append("                <ul class=\"inline-list right\">"); //150:1
            __out.AppendLine(false); //150:47
            __out.Append("                    <li>Powered by</li>"); //151:1
            __out.AppendLine(false); //151:40
            __out.Append("                    <li><a href=\"http://www.springsource.org/\">Spring</a></li>"); //152:1
            __out.AppendLine(false); //152:79
            __out.Append("                    <li><a href=\"http://www.thymeleaf.org/\">Thymeleaf</a></li>"); //153:1
            __out.AppendLine(false); //153:79
            __out.Append("                    <li><a href=\"http://foundation.zurb.com/\">Foundation</a></li>"); //154:1
            __out.AppendLine(false); //154:82
            __out.Append("                </ul>"); //155:1
            __out.AppendLine(false); //155:22
            __out.Append("            </div>"); //156:1
            __out.AppendLine(false); //156:19
            __out.Append("        </div>"); //157:1
            __out.AppendLine(false); //157:15
            __out.Append("    </div>"); //158:1
            __out.AppendLine(false); //158:11
            __out.Append("</footer>"); //159:1
            __out.AppendLine(false); //159:10
            __out.AppendLine(true); //160:1
            __out.Append("</body>"); //161:1
            __out.AppendLine(false); //161:8
            __out.Append("</html>"); //162:1
            __out.AppendLine(false); //162:8
            return __out.ToString();
        }

        public string GenerateWebXml() //167:1
        {
            StringBuilder __out = new StringBuilder();
            __out.Append("<?xml version=\"1.0\" encoding=\"UTF-8\"?>"); //168:1
            __out.AppendLine(false); //168:39
            __out.Append("<web-app xmlns=\"http://java.sun.com/xml/ns/javaee\""); //169:1
            __out.AppendLine(false); //169:51
            __out.Append("         xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\""); //170:1
            __out.AppendLine(false); //170:63
            __out.Append("         xsi:schemaLocation=\"http://java.sun.com/xml/ns/javaee"); //171:1
            __out.AppendLine(false); //171:63
            __out.Append("		                     http://java.sun.com/xml/ns/javaee/web-app_3_0.xsd\" version=\"3.0\">"); //172:1
            __out.AppendLine(false); //172:89
            __out.AppendLine(true); //173:1
            __out.Append("    <servlet>"); //174:1
            __out.AppendLine(false); //174:14
            __out.Append("        <servlet-name>spring</servlet-name>"); //175:1
            __out.AppendLine(false); //175:44
            __out.Append("        <servlet-class>org.springframework.web.servlet.DispatcherServlet</servlet-class>"); //176:1
            __out.AppendLine(false); //176:89
            __out.Append("        <load-on-startup>1</load-on-startup>"); //177:1
            __out.AppendLine(false); //177:45
            __out.Append("    </servlet>"); //178:1
            __out.AppendLine(false); //178:15
            __out.AppendLine(true); //179:1
            __out.Append("    <servlet-mapping>"); //180:1
            __out.AppendLine(false); //180:22
            __out.Append("        <servlet-name>spring</servlet-name>"); //181:1
            __out.AppendLine(false); //181:44
            __out.Append("        <url-pattern>/*</url-pattern>"); //182:1
            __out.AppendLine(false); //182:38
            __out.Append("    </servlet-mapping>"); //183:1
            __out.AppendLine(false); //183:23
            __out.AppendLine(true); //184:1
            __out.Append("    <context-param>"); //185:1
            __out.AppendLine(false); //185:20
            __out.Append("        <param-name>contextConfigLocation</param-name>"); //186:1
            __out.AppendLine(false); //186:55
            __out.Append("        <param-value>/WEB-INF/spring-config.xml</param-value>"); //187:1
            __out.AppendLine(false); //187:62
            __out.Append("    </context-param>"); //188:1
            __out.AppendLine(false); //188:21
            __out.AppendLine(true); //189:1
            __out.Append("    <listener>"); //190:1
            __out.AppendLine(false); //190:15
            __out.Append("        <listener-class>org.springframework.web.context.ContextLoaderListener</listener-class>"); //191:1
            __out.AppendLine(false); //191:95
            __out.Append("    </listener>"); //192:1
            __out.AppendLine(false); //192:16
            __out.AppendLine(true); //193:1
            __out.Append("    <filter>"); //194:1
            __out.AppendLine(false); //194:13
            __out.Append("        <filter-name>characterEncodingFilter</filter-name>"); //195:1
            __out.AppendLine(false); //195:59
            __out.Append("        <filter-class>org.springframework.web.filter.CharacterEncodingFilter</filter-class>"); //196:1
            __out.AppendLine(false); //196:92
            __out.Append("        <init-param>"); //197:1
            __out.AppendLine(false); //197:21
            __out.Append("            <param-name>encoding</param-name>"); //198:1
            __out.AppendLine(false); //198:46
            __out.Append("            <param-value>UTF-8</param-value>"); //199:1
            __out.AppendLine(false); //199:45
            __out.Append("        </init-param>"); //200:1
            __out.AppendLine(false); //200:22
            __out.Append("    </filter>"); //201:1
            __out.AppendLine(false); //201:14
            __out.AppendLine(true); //202:1
            __out.Append("    <filter-mapping>"); //203:1
            __out.AppendLine(false); //203:21
            __out.Append("        <filter-name>characterEncodingFilter</filter-name>"); //204:1
            __out.AppendLine(false); //204:59
            __out.Append("        <servlet-name>spring</servlet-name>"); //205:1
            __out.AppendLine(false); //205:44
            __out.Append("    </filter-mapping>"); //206:1
            __out.AppendLine(false); //206:22
            __out.AppendLine(true); //207:1
            __out.Append("</web-app>"); //208:1
            __out.AppendLine(false); //208:11
            return __out.ToString();
        }

        public string GenerateServlet(Namespace ns) //212:1
        {
            StringBuilder __out = new StringBuilder();
            __out.Append("<?xml version=\"1.0\" encoding=\"UTF-8\"?>"); //213:1
            __out.AppendLine(false); //213:39
            __out.Append("<beans xmlns=\"http://www.springframework.org/schema/beans\""); //214:1
            __out.AppendLine(false); //214:59
            __out.Append("       xmlns:mvc=\"http://www.springframework.org/schema/mvc\""); //215:1
            __out.AppendLine(false); //215:61
            __out.Append("       xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\""); //216:1
            __out.AppendLine(false); //216:61
            __out.Append("       xmlns:context=\"http://www.springframework.org/schema/context\""); //217:1
            __out.AppendLine(false); //217:69
            __out.Append("       xsi:schemaLocation=\"http://www.springframework.org/schema/beans"); //218:1
            __out.AppendLine(false); //218:71
            __out.Append("                           http://www.springframework.org/schema/beans/spring-beans.xsd"); //219:1
            __out.AppendLine(false); //219:88
            __out.Append("                           http://www.springframework.org/schema/context"); //220:1
            __out.AppendLine(false); //220:73
            __out.Append("                           http://www.springframework.org/schema/context/spring-context.xsd"); //221:1
            __out.AppendLine(false); //221:92
            __out.Append("                           http://www.springframework.org/schema/mvc"); //222:1
            __out.AppendLine(false); //222:69
            __out.Append("                           http://www.springframework.org/schema/mvc/spring-mvc.xsd\">"); //223:1
            __out.AppendLine(false); //223:86
            __out.AppendLine(true); //224:1
            string __tmp2Line = "    <context:component-scan base-package=\""; //225:1
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
            string __tmp4Line = "."; //225:56
            if (__tmp4Line != null) __out.Append(__tmp4Line);
            StringBuilder __tmp5 = new StringBuilder();
            __tmp5.Append(SpringGeneratorUtil.controllerPackage);
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
            string __tmp6Line = "\"/>"; //225:96
            if (__tmp6Line != null) __out.Append(__tmp6Line);
            __out.AppendLine(false); //225:99
            __out.AppendLine(true); //226:1
            __out.Append("    <mvc:annotation-driven/>"); //227:1
            __out.AppendLine(false); //227:29
            __out.AppendLine(true); //228:1
            __out.Append("    <!--<mvc:resources mapping=\"/favicon.ico\" location=\"/WEB-INF/resources/img/\"/>-->"); //229:1
            __out.AppendLine(false); //229:86
            __out.Append("    <mvc:resources mapping=\"/resources/**\" location=\"/WEB-INF/resources/\"/>"); //230:1
            __out.AppendLine(false); //230:76
            __out.AppendLine(true); //231:1
            __out.Append("    <mvc:interceptors>"); //232:1
            __out.AppendLine(false); //232:23
            __out.Append("        <bean class=\"org.springframework.web.servlet.i18n.LocaleChangeInterceptor\">"); //233:1
            __out.AppendLine(false); //233:84
            __out.Append("            <property name=\"paramName\" value=\"lang\"/>"); //234:1
            __out.AppendLine(false); //234:54
            __out.Append("        </bean>"); //235:1
            __out.AppendLine(false); //235:16
            __out.Append("    </mvc:interceptors>"); //236:1
            __out.AppendLine(false); //236:24
            __out.AppendLine(true); //237:1
            __out.Append("    <bean id=\"templateResolver\" class=\"org.thymeleaf.templateresolver.ServletContextTemplateResolver\">"); //238:1
            __out.AppendLine(false); //238:103
            __out.Append("        <property name=\"prefix\" value=\"/WEB-INF/view/\"/>"); //239:1
            __out.AppendLine(false); //239:57
            __out.Append("        <property name=\"suffix\" value=\".html\"/>"); //240:1
            __out.AppendLine(false); //240:48
            __out.Append("        <property name=\"characterEncoding\" value=\"UTF-8\"/>"); //241:1
            __out.AppendLine(false); //241:59
            __out.Append("        <property name=\"templateMode\" value=\"HTML5\"/>"); //242:1
            __out.AppendLine(false); //242:54
            __out.Append("        <property name=\"cacheable\" value=\"false\"/>"); //243:1
            __out.AppendLine(false); //243:51
            __out.Append("    </bean>"); //244:1
            __out.AppendLine(false); //244:12
            __out.AppendLine(true); //245:1
            __out.Append("    <bean id=\"templateEngine\" class=\"org.thymeleaf.spring4.SpringTemplateEngine\">"); //246:1
            __out.AppendLine(false); //246:82
            __out.Append("        <property name=\"templateResolver\" ref=\"templateResolver\"/>"); //247:1
            __out.AppendLine(false); //247:67
            __out.Append("    </bean>"); //248:1
            __out.AppendLine(false); //248:12
            __out.AppendLine(true); //249:1
            __out.Append("    <bean class=\"org.thymeleaf.spring4.view.ThymeleafViewResolver\">"); //250:1
            __out.AppendLine(false); //250:68
            __out.Append("        <property name=\"templateEngine\" ref=\"templateEngine\"/>"); //251:1
            __out.AppendLine(false); //251:63
            __out.Append("        <property name=\"contentType\" value=\"text/html; charset=UTF-8\"/>"); //252:1
            __out.AppendLine(false); //252:72
            __out.Append("        <property name=\"characterEncoding\" value=\"UTF-8\"/>"); //253:1
            __out.AppendLine(false); //253:59
            __out.Append("    </bean>"); //254:1
            __out.AppendLine(false); //254:12
            __out.AppendLine(true); //255:1
            __out.Append("    <bean id=\"localeResolver\" class=\"org.springframework.web.servlet.i18n.SessionLocaleResolver\"/>"); //256:1
            __out.AppendLine(false); //256:99
            __out.AppendLine(true); //257:1
            __out.Append("</beans>"); //258:1
            __out.AppendLine(false); //258:9
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
