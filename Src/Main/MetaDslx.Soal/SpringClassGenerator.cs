﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Soal //1:1
{
    using __Hidden_SpringClassGenerator_620251226;
    namespace __Hidden_SpringClassGenerator_620251226
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
            string __tmp2Line = "package "; //7:1
            if (__tmp2Line != null) __out.Append(__tmp2Line);
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(SpringGeneratorUtil.GetPackage(iface));
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
            string __tmp4Line = "."; //7:48
            if (__tmp4Line != null) __out.Append(__tmp4Line);
            StringBuilder __tmp5 = new StringBuilder();
            __tmp5.Append(SpringGeneratorUtil.Properties.interfacePackage);
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
            string __tmp6Line = ";"; //7:98
            if (__tmp6Line != null) __out.Append(__tmp6Line);
            __out.AppendLine(false); //7:99
            __out.AppendLine(true); //8:1
            StringBuilder __tmp8 = new StringBuilder();
            __tmp8.Append(SpringGeneratorUtil.GenerateImports(iface));
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
                    __out.AppendLine(false); //9:45
                }
            }
            __out.AppendLine(true); //10:1
            string __tmp10Line = "public interface "; //11:1
            if (__tmp10Line != null) __out.Append(__tmp10Line);
            StringBuilder __tmp11 = new StringBuilder();
            __tmp11.Append(iface.Name);
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
            string __tmp12Line = " {"; //11:30
            if (__tmp12Line != null) __out.Append(__tmp12Line);
            __out.AppendLine(false); //11:32
            var __loop1_results = 
                (from __loop1_var1 in __Enumerate((iface).GetEnumerator()) //12:8
                from op in __Enumerate((__loop1_var1.Operations).GetEnumerator()) //12:15
                select new { __loop1_var1 = __loop1_var1, op = op}
                ).ToList(); //12:2
            int __loop1_iteration = 0;
            foreach (var __tmp13 in __loop1_results)
            {
                ++__loop1_iteration;
                var __loop1_var1 = __tmp13.__loop1_var1;
                var op = __tmp13.op;
                string __tmp14Prefix = "	"; //13:1
                StringBuilder __tmp15 = new StringBuilder();
                __tmp15.Append(op.Result.Type.GetJavaName());
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
                string __tmp16Line = " "; //13:32
                if (__tmp16Line != null) __out.Append(__tmp16Line);
                StringBuilder __tmp17 = new StringBuilder();
                __tmp17.Append(op.Name.ToCamelCase());
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
                string __tmp18Line = "("; //13:56
                if (__tmp18Line != null) __out.Append(__tmp18Line);
                StringBuilder __tmp19 = new StringBuilder();
                __tmp19.Append(SpringGeneratorUtil.GetParameterList(op));
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
                string __tmp20Line = ")"; //13:99
                if (__tmp20Line != null) __out.Append(__tmp20Line);
                if (op.Exceptions.Any()) //14:3
                {
                    string __tmp22Line = " throws "; //15:1
                    if (__tmp22Line != null) __out.Append(__tmp22Line);
                    StringBuilder __tmp23 = new StringBuilder();
                    __tmp23.Append(SpringGeneratorUtil.GetExceptionList(op));
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
                }
                __out.Append(";"); //17:1
                __out.AppendLine(false); //17:2
            }
            __out.Append("}"); //20:1
            __out.AppendLine(false); //20:2
            return __out.ToString();
        }

        public string GenerateComponent(Component component) //23:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp2Line = "package "; //24:1
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
            string __tmp4Line = "."; //24:52
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
            string __tmp6Line = ";"; //24:106
            if (__tmp6Line != null) __out.Append(__tmp6Line);
            __out.AppendLine(false); //24:107
            __out.AppendLine(true); //25:1
            string __tmp8Line = "//import "; //26:1
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
            string __tmp10Line = ".util.ListUtil; TODO"; //26:53
            if (__tmp10Line != null) __out.Append(__tmp10Line);
            __out.AppendLine(false); //26:73
            __out.Append("import org.springframework.beans.factory.annotation.Autowired;"); //27:1
            __out.AppendLine(false); //27:63
            __out.Append("import org.springframework.stereotype.Service;"); //28:1
            __out.AppendLine(false); //28:47
            __out.AppendLine(true); //29:1
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
                    __out.AppendLine(false); //30:49
                }
            }
            __out.AppendLine(true); //31:1
            __out.Append("@Service"); //32:1
            __out.AppendLine(false); //32:9
            string interfaces = SpringGeneratorUtil.GetInterfaceList(component); //33:2
            if (interfaces.Any()) //34:2
            {
                string __tmp14Line = "public class "; //35:1
                if (__tmp14Line != null) __out.Append(__tmp14Line);
                StringBuilder __tmp15 = new StringBuilder();
                __tmp15.Append(component.Name);
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
                string __tmp16Line = " implements "; //35:30
                if (__tmp16Line != null) __out.Append(__tmp16Line);
                StringBuilder __tmp17 = new StringBuilder();
                __tmp17.Append(interfaces);
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
                string __tmp18Line = " {"; //35:54
                if (__tmp18Line != null) __out.Append(__tmp18Line);
                __out.AppendLine(false); //35:56
            }
            else //36:2
            {
                string __tmp20Line = "public class "; //37:1
                if (__tmp20Line != null) __out.Append(__tmp20Line);
                StringBuilder __tmp21 = new StringBuilder();
                __tmp21.Append(component.Name);
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
                string __tmp22Line = " {"; //37:30
                if (__tmp22Line != null) __out.Append(__tmp22Line);
                __out.AppendLine(false); //37:32
            }
            __out.AppendLine(true); //39:1
            var __loop2_results = 
                (from __loop2_var1 in __Enumerate((component).GetEnumerator()) //40:8
                from repo in __Enumerate((__loop2_var1.GetRepositories()).GetEnumerator()) //40:19
                select new { __loop2_var1 = __loop2_var1, repo = repo}
                ).ToList(); //40:2
            int __loop2_iteration = 0;
            foreach (var __tmp23 in __loop2_results)
            {
                ++__loop2_iteration;
                var __loop2_var1 = __tmp23.__loop2_var1;
                var repo = __tmp23.repo;
                __out.Append("	@Autowired"); //41:1
                __out.AppendLine(false); //41:12
                string __tmp24Prefix = "	"; //42:1
                StringBuilder __tmp25 = new StringBuilder();
                __tmp25.Append(repo);
                using(StreamReader __tmp25Reader = new StreamReader(this.__ToStream(__tmp25.ToString())))
                {
                    bool __tmp25_first = true;
                    bool __tmp25_last = __tmp25Reader.EndOfStream;
                    while(__tmp25_first || !__tmp25_last)
                    {
                        __tmp25_first = false;
                        string __tmp25Line = __tmp25Reader.ReadLine();
                        __tmp25_last = __tmp25Reader.EndOfStream;
                        __out.Append(__tmp24Prefix);
                        if (__tmp25Line != null) __out.Append(__tmp25Line);
                        if (!__tmp25_last) __out.AppendLine(true);
                    }
                }
                string __tmp26Line = ";"; //42:8
                if (__tmp26Line != null) __out.Append(__tmp26Line);
                __out.AppendLine(false); //42:9
            }
            __out.AppendLine(true); //44:1
            var __loop3_results = 
                (from __loop3_var1 in __Enumerate((component).GetEnumerator()) //45:8
                from reference in __Enumerate((__loop3_var1.References).GetEnumerator()) //45:19
                select new { __loop3_var1 = __loop3_var1, reference = reference}
                ).ToList(); //45:2
            int __loop3_iteration = 0;
            foreach (var __tmp27 in __loop3_results)
            {
                ++__loop3_iteration;
                var __loop3_var1 = __tmp27.__loop3_var1;
                var reference = __tmp27.reference;
                __out.Append("	@Autowired"); //46:1
                __out.AppendLine(false); //46:12
                string __tmp29Line = "	private "; //47:1
                if (__tmp29Line != null) __out.Append(__tmp29Line);
                StringBuilder __tmp30 = new StringBuilder();
                __tmp30.Append(reference.Interface.Name);
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
                string __tmp31Line = " "; //47:36
                if (__tmp31Line != null) __out.Append(__tmp31Line);
                StringBuilder __tmp32 = new StringBuilder();
                __tmp32.Append(reference.Name);
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
                string __tmp33Line = ";"; //47:53
                if (__tmp33Line != null) __out.Append(__tmp33Line);
                __out.AppendLine(false); //47:54
            }
            __out.AppendLine(true); //49:1
            var __loop4_results = 
                (from __loop4_var1 in __Enumerate((component).GetEnumerator()) //50:7
                from s in __Enumerate((__loop4_var1.Services).GetEnumerator()) //50:18
                select new { __loop4_var1 = __loop4_var1, s = s}
                ).ToList(); //50:2
            int __loop4_iteration = 0;
            foreach (var __tmp34 in __loop4_results)
            {
                ++__loop4_iteration;
                var __loop4_var1 = __tmp34.__loop4_var1;
                var s = __tmp34.s;
                Interface i = s.Interface; //51:2
                string __tmp36Line = "	//operations of "; //52:1
                if (__tmp36Line != null) __out.Append(__tmp36Line);
                StringBuilder __tmp37 = new StringBuilder();
                __tmp37.Append(i.Name);
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
                        __out.AppendLine(false); //52:26
                    }
                }
                var __loop5_results = 
                    (from __loop5_var1 in __Enumerate((i).GetEnumerator()) //53:9
                    from op in __Enumerate((__loop5_var1.Operations).GetEnumerator()) //53:12
                    select new { __loop5_var1 = __loop5_var1, op = op}
                    ).ToList(); //53:4
                int __loop5_iteration = 0;
                foreach (var __tmp38 in __loop5_results)
                {
                    ++__loop5_iteration;
                    var __loop5_var1 = __tmp38.__loop5_var1;
                    var op = __tmp38.op;
                    string __tmp40Line = "	public "; //54:1
                    if (__tmp40Line != null) __out.Append(__tmp40Line);
                    StringBuilder __tmp41 = new StringBuilder();
                    __tmp41.Append(op.Result.Type.GetJavaName());
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
                    string __tmp42Line = " "; //54:39
                    if (__tmp42Line != null) __out.Append(__tmp42Line);
                    StringBuilder __tmp43 = new StringBuilder();
                    __tmp43.Append(op.Name);
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
                    string __tmp44Line = "("; //54:49
                    if (__tmp44Line != null) __out.Append(__tmp44Line);
                    StringBuilder __tmp45 = new StringBuilder();
                    __tmp45.Append(SpringGeneratorUtil.GetParameterList(op));
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
                    string __tmp46Line = ") {"; //54:92
                    if (__tmp46Line != null) __out.Append(__tmp46Line);
                    __out.AppendLine(false); //54:95
                    if (op.Result.Type.GetJavaName() != "void") //55:3
                    {
                        __out.Append("		return null; // TODO implement method"); //56:1
                        __out.AppendLine(false); //56:40
                    }
                    else //57:3
                    {
                        __out.AppendLine(true); //58:3
                    }
                    __out.Append("	}"); //60:1
                    __out.AppendLine(false); //60:3
                    __out.AppendLine(true); //61:2
                }
            }
            __out.Append("}"); //64:1
            __out.AppendLine(false); //64:2
            return __out.ToString();
        }

        public string GenerateEnum(Enum myEnum) //67:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp2Line = "package "; //68:1
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
            string __tmp4Line = "."; //68:49
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
            string __tmp6Line = ";"; //68:94
            if (__tmp6Line != null) __out.Append(__tmp6Line);
            __out.AppendLine(false); //68:95
            __out.AppendLine(true); //69:1
            string __tmp8Line = "public enum "; //70:1
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
            string __tmp10Line = " {"; //70:26
            if (__tmp10Line != null) __out.Append(__tmp10Line);
            __out.AppendLine(false); //70:28
            var __loop6_results = 
                (from __loop6_var1 in __Enumerate((myEnum).GetEnumerator()) //71:8
                from literal in __Enumerate((__loop6_var1.EnumLiterals).GetEnumerator()) //71:16
                select new { __loop6_var1 = __loop6_var1, literal = literal}
                ).ToList(); //71:2
            int __loop6_iteration = 0;
            string delimiter = ""; //71:38
            foreach (var __tmp11 in __loop6_results)
            {
                ++__loop6_iteration;
                if (__loop6_iteration >= 2) //71:59
                {
                    delimiter = ","; //71:59
                }
                var __loop6_var1 = __tmp11.__loop6_var1;
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
                        __out.AppendLine(false); //72:12
                    }
                }
                string __tmp14Prefix = "	"; //73:1
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
            __out.Append(";"); //75:1
            __out.AppendLine(true); //75:2
            var __loop7_results = 
                (from __loop7_var1 in __Enumerate((myEnum).GetEnumerator()) //76:8
                from literal in __Enumerate((__loop7_var1.EnumLiterals).GetEnumerator()) //76:16
                select new { __loop7_var1 = __loop7_var1, literal = literal}
                ).ToList(); //76:2
            int __loop7_iteration = 0;
            foreach (var __tmp16 in __loop7_results)
            {
                ++__loop7_iteration;
                var __loop7_var1 = __tmp16.__loop7_var1;
                var literal = __tmp16.literal;
                __out.AppendLine(true); //77:1
                string __tmp18Line = "	public boolean is"; //78:1
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
                string __tmp20Line = "() {"; //78:48
                if (__tmp20Line != null) __out.Append(__tmp20Line);
                __out.AppendLine(false); //78:52
                string __tmp22Line = "		return "; //79:1
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
                string __tmp24Line = ".equals(this);"; //79:34
                if (__tmp24Line != null) __out.Append(__tmp24Line);
                __out.AppendLine(false); //79:48
                __out.Append("	}"); //80:1
                __out.AppendLine(false); //80:3
            }
            __out.AppendLine(true); //83:1
            __out.Append("}"); //84:1
            __out.AppendLine(false); //84:2
            return __out.ToString();
        }

        public string GenerateException(Struct ex) //87:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp2Line = "package "; //88:1
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
            string __tmp4Line = "."; //88:45
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
            string __tmp6Line = ";"; //88:95
            if (__tmp6Line != null) __out.Append(__tmp6Line);
            __out.AppendLine(false); //88:96
            __out.AppendLine(true); //89:1
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
                    __out.AppendLine(false); //90:42
                }
            }
            __out.AppendLine(true); //91:1
            string __tmp10Line = "public class "; //92:1
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
            string __tmp12Line = " extends Exception {"; //92:23
            if (__tmp12Line != null) __out.Append(__tmp12Line);
            __out.AppendLine(false); //92:43
            var __loop8_results = 
                (from __loop8_var1 in __Enumerate((ex).GetEnumerator()) //94:8
                from prop in __Enumerate((__loop8_var1.Properties).GetEnumerator()) //94:12
                select new { __loop8_var1 = __loop8_var1, prop = prop}
                ).ToList(); //94:2
            int __loop8_iteration = 0;
            foreach (var __tmp13 in __loop8_results)
            {
                ++__loop8_iteration;
                var __loop8_var1 = __tmp13.__loop8_var1;
                var prop = __tmp13.prop;
                __out.AppendLine(true); //95:2
                string __tmp15Line = "	private "; //96:1
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
                string __tmp17Line = " "; //96:35
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
                string __tmp19Line = ";"; //96:72
                if (__tmp19Line != null) __out.Append(__tmp19Line);
                __out.AppendLine(false); //96:73
            }
            __out.AppendLine(true); //99:2
            string __tmp21Line = "	public "; //100:1
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
            string __tmp23Line = "("; //100:18
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
            string __tmp25Line = ") {"; //100:60
            if (__tmp25Line != null) __out.Append(__tmp25Line);
            __out.AppendLine(false); //100:63
            var __loop9_results = 
                (from __loop9_var1 in __Enumerate((ex).GetEnumerator()) //101:8
                from prop in __Enumerate((__loop9_var1.Properties).GetEnumerator()) //101:12
                select new { __loop9_var1 = __loop9_var1, prop = prop}
                ).ToList(); //101:2
            int __loop9_iteration = 0;
            foreach (var __tmp26 in __loop9_results)
            {
                ++__loop9_iteration;
                var __loop9_var1 = __tmp26.__loop9_var1;
                var prop = __tmp26.prop;
                string __tmp28Line = "		this."; //102:1
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
                string __tmp30Line = " = "; //102:44
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
                string __tmp32Line = ";"; //102:83
                if (__tmp32Line != null) __out.Append(__tmp32Line);
                __out.AppendLine(false); //102:84
            }
            __out.Append("	}"); //104:1
            __out.AppendLine(false); //104:3
            var __loop10_results = 
                (from __loop10_var1 in __Enumerate((ex).GetEnumerator()) //106:8
                from prop in __Enumerate((__loop10_var1.Properties).GetEnumerator()) //106:12
                select new { __loop10_var1 = __loop10_var1, prop = prop}
                ).ToList(); //106:2
            int __loop10_iteration = 0;
            foreach (var __tmp33 in __loop10_results)
            {
                ++__loop10_iteration;
                var __loop10_var1 = __tmp33.__loop10_var1;
                var prop = __tmp33.prop;
                string __tmp34Prefix = "	"; //107:1
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
                        __out.AppendLine(false); //107:44
                    }
                }
            }
            __out.Append("}"); //110:1
            __out.AppendLine(false); //110:2
            return __out.ToString();
        }

        public string GenerateEntity(Struct sType) //113:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp2Line = "package "; //114:1
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
            string __tmp4Line = "."; //114:48
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
            string __tmp6Line = ";"; //114:95
            if (__tmp6Line != null) __out.Append(__tmp6Line);
            __out.AppendLine(false); //114:96
            __out.AppendLine(true); //115:1
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
                    __out.AppendLine(false); //116:45
                }
            }
            __out.AppendLine(true); //117:1
            __out.Append("import javax.persistence.*;"); //118:1
            __out.AppendLine(false); //118:28
            __out.AppendLine(true); //119:1
            __out.Append("@Entity"); //120:1
            __out.AppendLine(false); //120:8
            string __tmp10Line = "public class "; //121:1
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
            string __tmp12Line = " {"; //121:26
            if (__tmp12Line != null) __out.Append(__tmp12Line);
            __out.AppendLine(false); //121:28
            int ids = SpringGeneratorUtil.GetNumberOfFieldWithIdSuffix(sType); //123:2
            if (ids != 1) //124:2
            {
                __out.AppendLine(true); //125:2
                __out.Append("	@Id"); //126:1
                __out.AppendLine(false); //126:5
                __out.Append("	@GeneratedValue"); //127:1
                __out.AppendLine(false); //127:17
                string __tmp14Line = "	private Long "; //128:1
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
                string __tmp16Line = "Id;"; //128:52
                if (__tmp16Line != null) __out.Append(__tmp16Line);
                __out.AppendLine(false); //128:55
            }
            var __loop11_results = 
                (from __loop11_var1 in __Enumerate((sType).GetEnumerator()) //131:8
                from prop in __Enumerate((__loop11_var1.Properties).GetEnumerator()) //131:15
                select new { __loop11_var1 = __loop11_var1, prop = prop}
                ).ToList(); //131:2
            int __loop11_iteration = 0;
            foreach (var __tmp17 in __loop11_results)
            {
                ++__loop11_iteration;
                var __loop11_var1 = __tmp17.__loop11_var1;
                var prop = __tmp17.prop;
                __out.AppendLine(true); //132:2
                if (ids == 1 && prop.Name.ToString().EndsWith("Id")) //133:4
                {
                    __out.Append("	@Id"); //134:1
                    __out.AppendLine(false); //134:5
                    __out.Append("	@GeneratedValue"); //135:1
                    __out.AppendLine(false); //135:17
                }
                else if (prop.Type is Enum) //136:4
                {
                    __out.Append("	@Enumerated"); //137:1
                    __out.AppendLine(false); //137:13
                }
                string __tmp19Line = "	private "; //139:1
                if (__tmp19Line != null) __out.Append(__tmp19Line);
                StringBuilder __tmp20 = new StringBuilder();
                __tmp20.Append(prop.Type.GetJavaName());
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
                string __tmp21Line = " "; //139:35
                if (__tmp21Line != null) __out.Append(__tmp21Line);
                StringBuilder __tmp22 = new StringBuilder();
                __tmp22.Append(prop.Name.ToString().ToCamelCase());
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
                string __tmp23Line = ";"; //139:72
                if (__tmp23Line != null) __out.Append(__tmp23Line);
                __out.AppendLine(false); //139:73
            }
            __out.AppendLine(true); //142:2
            if (ids == 1) //143:2
            {
                var __loop12_results = 
                    (from __loop12_var1 in __Enumerate((sType).GetEnumerator()) //144:10
                    from id in __Enumerate((__loop12_var1.Properties).GetEnumerator()) //144:17
                    where id.Name.EndsWith("Id") //144:31
                    select new { __loop12_var1 = __loop12_var1, id = id}
                    ).ToList(); //144:4
                int __loop12_iteration = 0;
                foreach (var __tmp24 in __loop12_results)
                {
                    ++__loop12_iteration;
                    var __loop12_var1 = __tmp24.__loop12_var1;
                    var id = __tmp24.id;
                    string __tmp26Line = "	public "; //145:1
                    if (__tmp26Line != null) __out.Append(__tmp26Line);
                    StringBuilder __tmp27 = new StringBuilder();
                    __tmp27.Append(id.Type.GetJavaName());
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
                    string __tmp28Line = " get"; //145:32
                    if (__tmp28Line != null) __out.Append(__tmp28Line);
                    StringBuilder __tmp29 = new StringBuilder();
                    __tmp29.Append(id.Name.ToString().ToPascalCase());
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
                    string __tmp30Line = "() {"; //145:71
                    if (__tmp30Line != null) __out.Append(__tmp30Line);
                    __out.AppendLine(false); //145:75
                    string __tmp32Line = "		return this."; //146:1
                    if (__tmp32Line != null) __out.Append(__tmp32Line);
                    StringBuilder __tmp33 = new StringBuilder();
                    __tmp33.Append(id.Name.ToString().ToCamelCase());
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
                    string __tmp34Line = ";"; //146:49
                    if (__tmp34Line != null) __out.Append(__tmp34Line);
                    __out.AppendLine(false); //146:50
                    __out.Append("	}"); //147:1
                    __out.AppendLine(false); //147:3
                    __out.AppendLine(true); //148:2
                    string __tmp36Line = "	public void set"; //149:1
                    if (__tmp36Line != null) __out.Append(__tmp36Line);
                    StringBuilder __tmp37 = new StringBuilder();
                    __tmp37.Append(id.Name.ToString().ToPascalCase());
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
                    string __tmp38Line = "("; //149:52
                    if (__tmp38Line != null) __out.Append(__tmp38Line);
                    StringBuilder __tmp39 = new StringBuilder();
                    __tmp39.Append(id.Type.GetJavaName());
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
                    string __tmp40Line = " "; //149:76
                    if (__tmp40Line != null) __out.Append(__tmp40Line);
                    StringBuilder __tmp41 = new StringBuilder();
                    __tmp41.Append(id.Name.ToString().ToCamelCase());
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
                    string __tmp42Line = ") {"; //149:111
                    if (__tmp42Line != null) __out.Append(__tmp42Line);
                    __out.AppendLine(false); //149:114
                    string __tmp44Line = "		this."; //150:1
                    if (__tmp44Line != null) __out.Append(__tmp44Line);
                    StringBuilder __tmp45 = new StringBuilder();
                    __tmp45.Append(id.Name.ToString().ToCamelCase());
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
                    string __tmp46Line = " = "; //150:42
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
                    string __tmp48Line = ";"; //150:79
                    if (__tmp48Line != null) __out.Append(__tmp48Line);
                    __out.AppendLine(false); //150:80
                    __out.Append("	}"); //151:1
                    __out.AppendLine(false); //151:3
                }
            }
            else //153:2
            {
                string __tmp50Line = "	public Long get"; //154:1
                if (__tmp50Line != null) __out.Append(__tmp50Line);
                StringBuilder __tmp51 = new StringBuilder();
                __tmp51.Append(sType.Name.ToString().ToPascalCase());
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
                string __tmp52Line = "Id() {"; //154:55
                if (__tmp52Line != null) __out.Append(__tmp52Line);
                __out.AppendLine(false); //154:61
                string __tmp54Line = "		return this."; //155:1
                if (__tmp54Line != null) __out.Append(__tmp54Line);
                StringBuilder __tmp55 = new StringBuilder();
                __tmp55.Append(sType.Name.ToString().ToCamelCase());
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
                string __tmp56Line = "Id;"; //155:52
                if (__tmp56Line != null) __out.Append(__tmp56Line);
                __out.AppendLine(false); //155:55
                __out.Append("	}"); //156:1
                __out.AppendLine(false); //156:3
                __out.AppendLine(true); //158:2
                string __tmp58Line = "	public void set"; //159:1
                if (__tmp58Line != null) __out.Append(__tmp58Line);
                StringBuilder __tmp59 = new StringBuilder();
                __tmp59.Append(sType.Name.ToString().ToPascalCase());
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
                string __tmp60Line = "Id(Long "; //159:55
                if (__tmp60Line != null) __out.Append(__tmp60Line);
                StringBuilder __tmp61 = new StringBuilder();
                __tmp61.Append(sType.Name.ToString().ToCamelCase());
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
                string __tmp62Line = "Id) {"; //159:100
                if (__tmp62Line != null) __out.Append(__tmp62Line);
                __out.AppendLine(false); //159:105
                string __tmp64Line = "		this."; //160:1
                if (__tmp64Line != null) __out.Append(__tmp64Line);
                StringBuilder __tmp65 = new StringBuilder();
                __tmp65.Append(sType.Name.ToString().ToCamelCase());
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
                string __tmp66Line = "Id = "; //160:45
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
                string __tmp68Line = "Id;"; //160:87
                if (__tmp68Line != null) __out.Append(__tmp68Line);
                __out.AppendLine(false); //160:90
                __out.Append("	}"); //161:1
                __out.AppendLine(false); //161:3
            }
            var __loop13_results = 
                (from __loop13_var1 in __Enumerate((sType).GetEnumerator()) //164:8
                from prop in __Enumerate((__loop13_var1.Properties).GetEnumerator()) //164:15
                where !prop.Name.EndsWith("Id") //164:31
                select new { __loop13_var1 = __loop13_var1, prop = prop}
                ).ToList(); //164:2
            int __loop13_iteration = 0;
            foreach (var __tmp69 in __loop13_results)
            {
                ++__loop13_iteration;
                var __loop13_var1 = __tmp69.__loop13_var1;
                var prop = __tmp69.prop;
                string __tmp70Prefix = "	"; //165:1
                StringBuilder __tmp71 = new StringBuilder();
                __tmp71.Append(SpringGeneratorUtil.GenerateGetter(prop));
                using(StreamReader __tmp71Reader = new StreamReader(this.__ToStream(__tmp71.ToString())))
                {
                    bool __tmp71_first = true;
                    bool __tmp71_last = __tmp71Reader.EndOfStream;
                    while(__tmp71_first || !__tmp71_last)
                    {
                        __tmp71_first = false;
                        string __tmp71Line = __tmp71Reader.ReadLine();
                        __tmp71_last = __tmp71Reader.EndOfStream;
                        __out.Append(__tmp70Prefix);
                        if (__tmp71Line != null) __out.Append(__tmp71Line);
                        if (!__tmp71_last) __out.AppendLine(true);
                        __out.AppendLine(false); //165:44
                    }
                }
                string __tmp72Prefix = "	"; //166:1
                StringBuilder __tmp73 = new StringBuilder();
                __tmp73.Append(SpringGeneratorUtil.GenerateSetter(prop));
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
                        __out.AppendLine(false); //166:44
                    }
                }
            }
            __out.Append("}"); //169:1
            __out.AppendLine(false); //169:2
            return __out.ToString();
        }

        public string GenerateRepository(Struct entity) //172:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp2Line = "package "; //173:1
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
            string __tmp4Line = "."; //173:49
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
            string __tmp6Line = ";"; //173:100
            if (__tmp6Line != null) __out.Append(__tmp6Line);
            __out.AppendLine(false); //173:101
            __out.AppendLine(true); //174:1
            string __tmp8Line = "import "; //175:1
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
            string __tmp10Line = "."; //175:48
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
            string __tmp12Line = "."; //175:95
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
            string __tmp14Line = ";"; //175:109
            if (__tmp14Line != null) __out.Append(__tmp14Line);
            __out.AppendLine(false); //175:110
            __out.Append("import org.springframework.data.repository.CrudRepository;"); //176:1
            __out.AppendLine(false); //176:59
            __out.Append("import org.springframework.stereotype.Repository;"); //177:1
            __out.AppendLine(false); //177:50
            __out.AppendLine(true); //178:1
            __out.Append("@Repository"); //179:1
            __out.AppendLine(false); //179:12
            string __tmp16Line = "public interface "; //180:1
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
            string __tmp18Line = "Repository extends CrudRepository<"; //180:31
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
            string __tmp20Line = ",Long> {"; //180:78
            if (__tmp20Line != null) __out.Append(__tmp20Line);
            __out.AppendLine(false); //180:86
            __out.AppendLine(true); //181:1
            __out.Append("}"); //182:1
            __out.AppendLine(false); //182:2
            return __out.ToString();
        }

        public string GenerateStruct(Struct sType) //185:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp2Line = "package "; //186:1
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
            string __tmp4Line = "."; //186:48
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
            string __tmp6Line = ";"; //186:95
            if (__tmp6Line != null) __out.Append(__tmp6Line);
            __out.AppendLine(false); //186:96
            __out.AppendLine(true); //187:1
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
                    __out.AppendLine(false); //188:45
                }
            }
            __out.AppendLine(true); //189:1
            string __tmp10Line = "public class "; //190:1
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
            string __tmp12Line = " {"; //190:26
            if (__tmp12Line != null) __out.Append(__tmp12Line);
            __out.AppendLine(false); //190:28
            var __loop14_results = 
                (from __loop14_var1 in __Enumerate((sType).GetEnumerator()) //192:8
                from prop in __Enumerate((__loop14_var1.Properties).GetEnumerator()) //192:15
                select new { __loop14_var1 = __loop14_var1, prop = prop}
                ).ToList(); //192:2
            int __loop14_iteration = 0;
            foreach (var __tmp13 in __loop14_results)
            {
                ++__loop14_iteration;
                var __loop14_var1 = __tmp13.__loop14_var1;
                var prop = __tmp13.prop;
                __out.AppendLine(true); //193:2
                string __tmp15Line = "	private "; //194:1
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
                string __tmp17Line = " "; //194:35
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
                string __tmp19Line = ";"; //194:72
                if (__tmp19Line != null) __out.Append(__tmp19Line);
                __out.AppendLine(false); //194:73
            }
            var __loop15_results = 
                (from __loop15_var1 in __Enumerate((sType).GetEnumerator()) //197:8
                from prop in __Enumerate((__loop15_var1.Properties).GetEnumerator()) //197:15
                select new { __loop15_var1 = __loop15_var1, prop = prop}
                ).ToList(); //197:2
            int __loop15_iteration = 0;
            foreach (var __tmp20 in __loop15_results)
            {
                ++__loop15_iteration;
                var __loop15_var1 = __tmp20.__loop15_var1;
                var prop = __tmp20.prop;
                string __tmp21Prefix = "	"; //198:1
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
                        __out.AppendLine(false); //198:44
                    }
                }
                string __tmp23Prefix = "	"; //199:1
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
                        __out.AppendLine(false); //199:44
                    }
                }
            }
            __out.Append("}"); //202:1
            __out.AppendLine(false); //202:2
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
