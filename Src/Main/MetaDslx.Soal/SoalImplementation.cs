using MetaDslx.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Soal
{
    internal class SoalImplementation : SoalImplementationBase
    {
        public override string Namespace_FullName(Namespace @this)
        {
            if (@this.Namespace == null) return @this.Name;
            else return @this.Namespace.FullName + "." + @this.Name;
        }

        public override string InterfaceReference_Name(InterfaceReference @this)
        {
            if (((ModelObject)@this).MIsValueCreated(SoalDescriptor.InterfaceReference.InterfaceProperty))
            {
                return @this.OptionalName != null ? @this.OptionalName : @this.Interface.Name;
            }
            else
            {
                return @this.OptionalName ?? string.Empty;
            }
        }
    }

    internal static class SoalExtensions
    {
        public static string UriWithSlash(this Namespace ns)
        {
            string uri = ns.Uri;
            if (uri == null) return uri;
            if (!uri.EndsWith("/")) return uri + "/";
            else return uri;
        }

        public static List<Namespace> GetImportedNamespaces(this Namespace ns)
        {
            List<Namespace> result = new List<Namespace>();
            foreach (var decl in ns.Declarations)
            {
                StructuredType stype = decl as StructuredType;
                if (stype != null)
                {
                    foreach (var prop in stype.Properties)
                    {
                        Namespace extns = prop.Type.GetNamespace(ns);
                        if (!result.Contains(extns))
                        {
                            result.Add(extns);
                        }
                    }
                }
                Interface intf = decl as Interface;
                if (intf != null)
                {
                    foreach (var op in intf.Operations)
                    {
                        if (op.ReturnType is ArrayType)
                        {
                            Namespace extns = op.ReturnType.GetNamespace(ns);
                            if (!result.Contains(extns))
                            {
                                result.Add(extns);
                            }
                        }
                        foreach (var param in op.Parameters)
                        {
                            Namespace extns = param.Type.GetNamespace(ns);
                            if (!result.Contains(extns))
                            {
                                result.Add(extns);
                            }
                        }
                    }
                }
            }
            result.Remove(SoalCompiler.XsdNamespace);
            result.Remove(ns);
            result.Remove(null);
            return result;
        }

        public static List<ArrayType> GetArrayTypes(this Namespace ns)
        {
            HashSet<string> arrayNames = new HashSet<string>();
            List<ArrayType> result = new List<ArrayType>();
            foreach (var decl in ns.Declarations)
            {
                StructuredType stype = decl as StructuredType;
                if (stype != null)
                {
                    foreach (var prop in stype.Properties)
                    {
                        CheckArrayType(prop.Type, arrayNames, result);
                    }
                }
                Interface intf = decl as Interface;
                if (intf != null)
                {
                    foreach (var op in intf.Operations)
                    {
                        CheckArrayType(op.ReturnType, arrayNames, result);
                        foreach (var param in op.Parameters)
                        {
                            CheckArrayType(param.Type, arrayNames, result);
                        }
                    }
                }
            }
            return result;
        }

        private static void CheckArrayType(SoalType type, HashSet<string> arrayNames, List<ArrayType> arrayTypes)
        {
            if (type is ArrayType)
            {
                ArrayType atype = (ArrayType)type;
                string aname = atype.GetXsdName();
                if (atype.InnerType != SoalInstance.Byte && !arrayNames.Contains(aname))
                {
                    arrayNames.Add(aname);
                    arrayTypes.Add(atype);
                }
            }
            else if (type is NonNullableType)
            {
                ArrayType atype = ((NonNullableType)type).InnerType as ArrayType;
                if (atype != null)
                {
                    string aname = atype.GetXsdName();
                    if (atype.InnerType != SoalInstance.Byte && !arrayNames.Contains(aname))
                    {
                        arrayNames.Add(aname);
                        arrayTypes.Add(atype);
                    }
                }
            }
        }

        public static Namespace GetNamespace(this SoalType type, Namespace currentNamespace)
        {
            if (type is PrimitiveType) return SoalCompiler.XsdNamespace;
            if (type is NullableType) return GetNamespace(((NullableType)type).InnerType, currentNamespace);
            if (type is NonNullableType) return GetNamespace(((NonNullableType)type).InnerType, currentNamespace);
            if (type is ArrayType)
            {
                if (((ArrayType)type).InnerType == SoalInstance.Byte) return SoalCompiler.XsdNamespace;
                else return currentNamespace;
            }
            if (type is Enum)
            {
                Enum etype = (Enum)type;
                return etype.Namespace;
            }
            if (type is StructuredType)
            {
                StructuredType stype = (StructuredType)type;
                return stype.Namespace;
            }
            return null;
        }

        public static string GetXsdName(this SoalType type)
        {
            if (type is PrimitiveType)
            {
                string name = ((PrimitiveType)type).Name;
                switch (name)
                {
                    case "int":
                    case "long":
                    case "float":
                    case "double":
                    case "string":
                    case "byte":
                        return name;
                    case "object":
                        return "anyType";
                    case "bool":
                        return "boolean";
                    case "Date":
                        return "date";
                    case "Time":
                        return "time";
                    case "DateTime":
                        return "dateTime";
                    case "TimeSpan":
                        return "duration";
                    default:
                        break;
                }
            }
            if (type is NullableType) return GetXsdName(((NullableType)type).InnerType);
            if (type is NonNullableType) return GetXsdName(((NonNullableType)type).InnerType);
            if (type is ArrayType)
            {
                if (((ArrayType)type).InnerType == SoalInstance.Byte) return "base64Binary";
                else return (GetXsdName(((ArrayType)type).InnerType)+"List").ToPascalCase();
            }
            if (type is Enum)
            {
                Enum etype = (Enum)type;
                return etype.Name;
            }
            if (type is StructuredType)
            {
                StructuredType stype = (StructuredType)type;
                return stype.Name;
            }
            return null;
        }

        public static List<string> GetRepositories(this StructuredType type)
        {
            List<string> repos = new List<string>();
            List<string> imports = type.GetImports();
            foreach (string import in imports)
            {
                if (import.Contains("repository"))
                {
                    string[] parts = import.Split('.');
                    string lastPart = parts[parts.Length - 1];
                    lastPart = lastPart.Replace(";", "");
                    repos.Add(lastPart + " " + lastPart.ToCamelCase());
                }
            }

            return repos;
        }

        public static List<string> GetImports(this StructuredType type)
        {
            HashSet<string> imported = new HashSet<string>();
            List<string> repoImports;
            List<SoalType> imports = type.GetTypes(out repoImports);

            foreach (SoalType import in imports)
            {
                if (import is ArrayType)
                {
                    imported.Add("import java.util.List;");
                }
                imported.Add(import.GetImportString());
            }

            foreach (string repoImport in repoImports)
            {
                imported.Add(repoImport);
            }

            List<string> result = new List<string>(imported);
            //result.Remove("import");
            result.Remove(null);
            return result;
        }

        public static List<SoalType> GetTypes(this StructuredType type, out List<string> repoImports)
        {
            List<SoalType> result = new List<SoalType>();
            repoImports = new List<string>();

            foreach (Property prop in type.Properties)
            {
                result.AddRange(HandleArrayType(prop.Type));
            }

            Component component = type as Component;
            if (component != null)
            {
                foreach (Service service in component.Services)
                {
                    foreach (Operation operation in service.Interface.Operations)
                    {
                        foreach(Parameter param in operation.Parameters)
                        {
                            result.AddRange(HandleArrayType(param.Type));
                        }
                        List<SoalType> im = HandleArrayType(operation.ReturnType);
                        string entityImport = null;
                        foreach (SoalType s in im)
                        {
                            if (s != null && s is Entity)
                            {
                                entityImport = s.GetImportString();
                            }
                        }
                        if (entityImport != null)
                        {
                            repoImports.Add(entityImport.Replace("entity", "repository").Replace(";", "Repository;"));
                        }
                        result.AddRange(im);
                    }
                }
                result.Add(component.BaseComponent);
            }

            return result;
        }

        private static List<SoalType> HandleArrayType(SoalType type)
        {
            List<SoalType> result = new List<SoalType>();
            ArrayType array = type as ArrayType;
            if (array != null)
            {
                if (array.InnerType != SoalInstance.Byte)
                {
                    result.Add(array);
                    result.Add(array.InnerType);
                }
            }
            else
            {
                result.Add(type);
            }

            return result;
        }

        private static string SubPackage(SoalType type)
        {
            if (type is Interface)
                return ".facade";
            if (type is Exception)
                return ".exception";
            if (type is Enum)
                return ".enums";
            if (type is Entity)
                return ".entity";
            return null;
        }

        public static string GetImportString(this SoalType type)
        {
            string result = null;
            string package = type.GetJavaName().GetPackageOfJavaType();
            if (package == null || !package.Any())
            {
                StructuredType st = type as StructuredType;
                if (st != null)
                {
                    string subpackage = SubPackage(type);
                    package = st.Namespace.FullName.ToLower();
                    package = package + subpackage;
                }
            }
            if (package != null)
                result = "import " + package + "." + type.GetJavaName()+";";
            return result;
        }

        public static string GetJavaName(this SoalType type)
        {
            if (type is PrimitiveType)
            {
                string name = ((PrimitiveType)type).Name;
                switch (name)
                {
                    case "void":
                        return "void";
                    case "int":
                        return "Integer";
                    case "long":
                    case "float":
                    case "double":
                    case "byte":
                    case "string":
                    case "object":
                        return name.ToPascalCase();
                    case "bool":
                        return "Boolean";
                    case "Date":
                        return "LocalDate";
                    case "Time":
                        return "LocalTime";
                    case "DateTime":
                        return "LocalDateTime";
                    case "TimeSpan":
                        return "Duration";
                    default:
                        break;
                }
            }
            if (type is NullableType) return GetJavaName(((NullableType)type).InnerType);
            if (type is NonNullableType) return GetJavaName(((NonNullableType)type).InnerType);
            if (type is ArrayType)
            {
                if (((ArrayType)type).InnerType == SoalInstance.Byte) return "byte[]";
                else return ("List<"+GetJavaName(((ArrayType)type).InnerType) + ">");
            }
            if (type is Enum)
            {
                Enum etype = (Enum)type;
                return etype.Name;
            }
            if (type is StructuredType)
            {
                StructuredType stype = (StructuredType)type;
                return stype.Name;
            }
            return null;
        }


        public static string GetPackageOfJavaType(this string type)
        {
            switch (type)
            {
                case "Integer":
                case "Long":
                case "Float":
                case "Double":
                case "Byte":
                case "String":
                case "Object":
                case "Boolean":
                    return null; // no need to import
                case "LocalDate":
                case "LocalTime":
                case "LocalDateTime":
                case "Duration":
                    return "java.time";
                default:
                    return null;
            }
        }

        public static string ToPascalCase(this string identifier)
        {
            if (string.IsNullOrEmpty(identifier)) return identifier;
            return identifier.Substring(0, 1).ToUpper() + identifier.Substring(1);
        }

        public static string ToCamelCase(this string identifier)
        {
            if (string.IsNullOrEmpty(identifier)) return identifier;
            return identifier.Substring(0, 1).ToLower() + identifier.Substring(1);
        }

        public static bool HasXsdNamespace(this SoalType type)
        {
            if (type is PrimitiveType) return true;
            if (type is NullableType) return HasXsdNamespace(((NullableType)type).InnerType);
            if (type is NonNullableType) return HasXsdNamespace(((NonNullableType)type).InnerType);
            if (type is ArrayType) return HasXsdNamespace(((ArrayType)type).InnerType);
            if (type is Enum)
            {
                Enum etype = (Enum)type;
                return etype.Namespace != null && etype.Namespace.Uri != null;
            }
            if (type is StructuredType)
            {
                StructuredType stype = (StructuredType)type;
                return stype.Namespace != null && stype.Namespace.Uri != null;
            }
            return false;
        }

        public static bool IsNullable(this SoalType type)
        {
            if (type is PrimitiveType) return ((PrimitiveType)type).Nullable;
            if (type is NullableType) return true;
            if (type is NonNullableType) return false;
            if (type is ArrayType) return true;
            if (type is Enum) return false;
            if (type is StructuredType) return true;
            return false;
        }

        public static string IsNullableXsd(this SoalType type)
        {
            return type.IsNullable().ToString().ToLower();
        }

        public static List<Exception> GetInterfaceExceptions(this Interface intf)
        {
            List<Exception> result = new List<Exception>();
            foreach (var op in intf.Operations)
            {
                foreach (var ex in op.Exceptions)
                {
                    if (!result.Contains(ex))
                    {
                        result.Add(ex);
                    }
                }
            }
            return result;
        }

        public static List<Exception> GetInterfaceExceptions(this Namespace ns)
        {
            List<Exception> result = new List<Exception>();
            foreach (var intf in ns.Declarations.OfType<Interface>())
            {
                foreach (var op in intf.Operations)
                {
                    foreach (var ex in op.Exceptions)
                    {
                        if (!result.Contains(ex))
                        {
                            result.Add(ex);
                        }
                    }
                }
            }
            return result;
        }

        public static string GetSoapPrefix(this Binding binding)
        {
            foreach (var enc in binding.Encodings)
            {
                SoapEncodingBindingElement soap = enc as SoapEncodingBindingElement;
                if (soap != null)
                {
                    if (soap.Version == SoapVersion.Soap12) return "soap12";
                    else return "soap";
                }
            }
            return null;
        }

        public static bool HasPolicy(this Binding binding)
        {
            HttpTransportBindingElement http = binding.Transport as HttpTransportBindingElement;
            if (http != null && http.Ssl) return true;
            foreach (var enc in binding.Encodings)
            {
                SoapEncodingBindingElement soap = enc as SoapEncodingBindingElement;
                if (soap != null && soap.Mtom) return true;
            }
            foreach (var prot in binding.Protocols)
            {
                if (prot is WsAddressingBindingElement) return true;
            }
            return false;
        }

        public static bool HasOperationPolicy(this Binding binding)
        {
            foreach (var prot in binding.Protocols)
            {
                //if (prot is WsSecurityBindingElement) return true;
            }
            return false;
        }
    }
}
