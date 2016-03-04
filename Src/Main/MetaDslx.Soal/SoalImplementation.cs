using MetaDslx.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MetaDslx.Soal
{
    public class SoalAnnotations
    {
        public const string All = "All";
        public const string Choice = "Choice";
        public const string NoWrap = "NoWrap";
        public const string Rpc = "Rpc";
        public const string Enum = "Enum";
        public const string Type = "Type";
        public const string Element = "Element";
        public const string Attribute = "Attribute";
        public const string Restriction = "Restriction";
    }

    public class SoalAnnotationProperties
    {
        public const string Wrapped = "wrapped";
        public const string Items = "items";
        public const string Sap = "sap";
        public const string Name = "name";
        public const string Optional = "optional";
        public const string Required = "required";
        public const string Pattern = "pattern";
        public const string Length = "length";
        public const string MinLength = "minLength";
        public const string MaxLength = "maxLength";
        public const string MaxExclusive = "maxExclusive";
        public const string MinExclusive = "minExclusive";
        public const string MaxInclusive = "maxInclusive";
        public const string MinInclusive = "minInclusive";
        public const string TotalDigits = "totalDigits";
        public const string FractionDigits = "fractionDigits";

    }

    internal class SoalImplementation : SoalImplementationBase
    {
        public override string Namespace_FullName(Namespace @this)
        {
            if (@this.Namespace == null) return @this.Name;
            else return @this.Namespace.FullName + "." + @this.Name;
        }

        public override void Operation(Operation @this)
        {
            base.Operation(@this);
            ((ModelObject)@this).MSet(SoalDescriptor.Operation.ResultProperty, SoalFactory.Instance.CreateOutputParameter());
            //@this.Result = SoalFactory.Instance.CreateOutputParameter();
        }

        public override string Port_Name(Port @this)
        {
            if (((ModelObject)@this).MIsValueCreated(SoalDescriptor.Port.InterfaceProperty))
            {
                if (@this.OptionalName != null)
                {
                    return @this.OptionalName;
                }
                else
                {
                    if (@this.Interface != null) return @this.Interface.Name;
                    else return string.Empty;
                }
            }
            else
            {
                return @this.OptionalName ?? string.Empty;
            }
        }

        public override Annotation AnnotatedElement_AddAnnotation(AnnotatedElement @this, string name)
        {
            Annotation result = @this.GetAnnotation(name);
            if (result == null)
            {
                result = SoalFactory.Instance.CreateAnnotation();
                result.Name = name;
                @this.Annotations.Add(result);
            }
            return result;
        }

        public override IList<Annotation> AnnotatedElement_GetAnnotations(AnnotatedElement @this, string name)
        {
            List<Annotation> result = new List<Soal.Annotation>();
            if (@this == null) return result;
            foreach (var annot in @this.Annotations)
            {
                if (annot.Name == name)
                {
                    result.Add(annot);
                }
            }
            return result;
        }

        public override Annotation AnnotatedElement_GetAnnotation(AnnotatedElement @this, string name)
        {
            return @this.GetAnnotations(name).FirstOrDefault();
        }

        public override bool AnnotatedElement_HasAnnotation(AnnotatedElement @this, string name)
        {
            return @this.GetAnnotation(name) != null;
        }

        public override bool AnnotatedElement_HasAnnotationProperty(AnnotatedElement @this, string annotationName, string propertyName)
        {
            if (@this == null) return false;
            Annotation annot = @this.GetAnnotation(annotationName);
            if (annot != null)
            { 
                return annot.HasProperty(propertyName);
            }
            return false;
        }

        public override object AnnotatedElement_GetAnnotationPropertyValue(AnnotatedElement @this, string annotationName, string propertyName)
        {
            if (@this == null) return null;
            Annotation annot = @this.GetAnnotation(annotationName);
            if (annot != null)
            {
                return annot.GetPropertyValue(propertyName);
            }
            return null;
        }

        public override AnnotationProperty AnnotatedElement_SetAnnotationPropertyValue(AnnotatedElement @this, string annotationName, string propertyName, object propertyValue)
        {
            if (@this == null) return null;
            Annotation annot = @this.AddAnnotation(annotationName);
            return annot.SetPropertyValue(propertyName, propertyValue);
        }

        public override AnnotationProperty Annotation_GetProperty(Annotation @this, string name)
        {
            if (@this == null) return null;
            foreach (var prop in @this.Properties)
            {
                if (prop.Name == name) return prop;
            }
            return null;
        }

        public override bool Annotation_HasProperty(Annotation @this, string name)
        {
            return @this.GetProperty(name) != null;
        }

        public override object Annotation_GetPropertyValue(Annotation @this, string name)
        {
            if (@this == null) return null;
            AnnotationProperty prop = @this.GetProperty(name);
            if (prop != null)
            {
                return prop.Value;
            }
            return null;
        }

        public override AnnotationProperty Annotation_SetPropertyValue(Annotation @this, string name, object value)
        {
            if (@this == null) return null;
            AnnotationProperty prop = @this.GetProperty(name);
            if (prop == null)
            {
                prop = SoalFactory.Instance.CreateAnnotationProperty();
                prop.Name = name;
                @this.Properties.Add(prop);
            }
            prop.Value = value;
            return prop;
        }

    }

    internal static class SoalExtensions
    {
        public static string FullName(this Declaration declaration)
        {
            if (declaration == null) return string.Empty;
            if (declaration.Namespace == null) return declaration.Name;
            return declaration.Namespace.FullName + "." + declaration.Name;
        }

        public static bool IsIdentifier(this string name)
        {
            return Regex.IsMatch(name, @"[a-zA-Z\_][0-9a-zA-Z\_]*");
        }

        public static bool IsArrayType(this SoalType type)
        {
            if (type == null) return false;
            if (type is NonNullableType) return ((NonNullableType)type).InnerType.IsArrayType();
            if (type is NullableType) return ((NullableType)type).InnerType.IsArrayType();
            if (type is ArrayType) return true;
            return false;
        }

        public static SoalType GetCoreType(this SoalType type)
        {
            if (type == null) return null;
            if (type is NonNullableType) return ((NonNullableType)type).InnerType.GetCoreType();
            if (type is NullableType) return ((NullableType)type).InnerType.GetCoreType();
            if (type is ArrayType) return ((ArrayType)type).InnerType.GetCoreType();
            return type;
        }

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
                Struct stype = decl as Struct;
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
                        if (op.Result.Type is ArrayType)
                        {
                            Namespace extns = op.Result.Type.GetNamespace(ns);
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
            result.Remove(SoalGenerator.XsdNamespace);
            result.Remove(ns);
            result.Remove(null);
            return result;
        }

        private static void CheckArrayType(SoalType type, IList<Annotation> annotations, HashSet<string> arrayNames, List<ArrayType> arrayTypes)
        {
            if (annotations.Any(a => a.Name == SoalAnnotations.Element && !(bool)a.GetPropertyValue(SoalAnnotationProperties.Wrapped))) return;
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
            if (type is PrimitiveType) return SoalGenerator.XsdNamespace;
            if (type is NullableType) return GetNamespace(((NullableType)type).InnerType, currentNamespace);
            if (type is NonNullableType) return GetNamespace(((NonNullableType)type).InnerType, currentNamespace);
            if (type is ArrayType)
            {
                if (((ArrayType)type).InnerType == SoalInstance.Byte) return SoalGenerator.XsdNamespace;
                else return currentNamespace;
            }
            if (type is Enum)
            {
                Enum etype = (Enum)type;
                return etype.Namespace;
            }
            if (type is Struct)
            {
                Struct stype = (Struct)type;
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
                else return (GetXsdName(((ArrayType)type).InnerType) + "List").ToPascalCase();
            }
            if (type is Enum)
            {
                Enum etype = (Enum)type;
                string newName = etype.GetAnnotationPropertyValue(SoalAnnotations.Type, SoalAnnotationProperties.Name) as string;
                return newName ?? etype.Name;
            }
            if (type is Struct)
            {
                Struct stype = (Struct)type;
                string newName = stype.GetAnnotationPropertyValue(SoalAnnotations.Type, SoalAnnotationProperties.Name) as string;
                return newName ?? stype.Name;
            }
            return null;
        }

        public static List<string> GetRepositories(this Declaration type)
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

        public static List<string> GetImports(this Declaration declaration)
        {
            HashSet<string> imported = new HashSet<string>();
            List<string> repoImports;
            List<SoalType> imports = declaration.GetTypes(out repoImports);

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
            result.Remove(null);
            return result;
        }

        public static List<SoalType> GetTypes(this Declaration declaration, out List<string> repoImports)
        {
            List<SoalType> result = new List<SoalType>();
            repoImports = new List<string>();

            Struct sType = declaration as Struct;
            if (sType != null)
            {
                foreach (Property prop in sType.Properties)
                {
                    result.AddRange(HandleArrayType(prop.Type));
                }
            }

            Interface iface = declaration as Interface;
            if (iface != null)
            {
                foreach (Operation operation in iface.Operations)
                {
                    GetImportsOfOperation(repoImports, result, operation);
                }
            }

            Component component = declaration as Component;
            if (component != null)
            {
                List<Port> referencesAndServices = new List<Port>();
                referencesAndServices.AddRange(component.Services);
                referencesAndServices.AddRange(component.References);

                foreach (Port iref in referencesAndServices)
                {
                    result.Add(iref.Interface);
                }

                foreach (Service service in component.Services)
                {
                    foreach (Operation operation in service.Interface.Operations)
                    {
                        GetImportsOfOperation(repoImports, result, operation);
                    }
                }
                //result.Add(component.BaseComponent); TODO mi volt eddig?
            }

            return result;
        }

        private static void GetImportsOfOperation(List<string> repoImports, List<SoalType> result, Operation operation)
        {
            foreach (InputParameter param in operation.Parameters)
            {
                result.AddRange(HandleArrayType(param.Type));
            }
            List<SoalType> im = HandleArrayType(operation.Result.Type);
            string entityImport = null;
            foreach (SoalType s in im)
            {
                if (s != null)
                {
                    Struct myStruct = s as Struct;
                    if (myStruct != null && myStruct.IsEntity())
                    {
                        entityImport = s.GetImportString();
                    }
                }
            }
            if (entityImport != null)
            {
                repoImports.Add(entityImport.Replace("entity", "repository").Replace(";", "Repository;"));
            }
            result.AddRange(im);

            foreach (Struct excception in operation.Exceptions)
            {
                result.Add(excception);
            }
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
                return ".interfaces";
            if (type is Enum)
                return ".enums";
            Struct str = type as Struct;
            if (str != null)
            {
                if (str.IsException())
                    return ".exception";
                if (str.IsEntity())
                    return ".entity";
            }
            return null;
        }

        private static string GetImportString(this SoalType type)
        {
            string javaName = type.GetJavaName();
            string package = null;

            if (type is PrimitiveType)
            {
                package = javaName.GetPackageOfJavaType();
            }
            else
            {
                Declaration dec = type as Declaration;
                if (dec != null)
                {
                    string subpackage = SubPackage(type);
                    package = dec.Namespace.FullName.ToLower();
                    package = package + subpackage;
                    if (javaName == null)
                    {
                        javaName = dec.Name;
                    }
                } else
                {
                    //Console.WriteLine(type.GetJavaName() +" is not dec");
                }
            }
            
            if (package != null)
                return "import " + package + "." + javaName + ";";

            return null;
        }

        public static bool IsEntity(this Struct myStruct)
        {
            Namespace myNamespace = myStruct.Namespace;
            foreach (Database db in myNamespace.Declarations.OfType<Database>())
            {
                if (db.Entities.Contains(myStruct)) {
                    return true;
                }
            }
            return false;
        }

        public static bool IsException(this Struct myStruct)
        {
            Namespace myNamespace = myStruct.Namespace;
            foreach (Interface iface in myNamespace.Declarations.OfType<Interface>())
            {
                foreach (Operation op in iface.Operations)
                {
                    if (op.Exceptions.Contains(myStruct)) {
                        return true;
                    }
                }
            }
            return false;
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
            ArrayType aType = type as ArrayType;
            if (aType != null)
            {
                if (aType.InnerType == SoalInstance.Byte) return "byte[]";
                else return ("List<"+GetJavaName(((ArrayType)type).InnerType) + ">");
            }
            Enum etype = type as Enum;
            if (etype != null)
            {
                return etype.Name;
            }
            Struct stype = type as Struct;
            if (stype != null)
            {
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
            if (type is Struct)
            {
                Struct stype = (Struct)type;
                return stype.Namespace != null && stype.Namespace.Uri != null;
            }
            return false;
        }

        public static bool IsNullable(this SoalType type)
        {
            if (type is NonNullableType) return false;
            if (type is NullableType) return true;
            if (type is PrimitiveType) return ((PrimitiveType)type).Nullable;
            if (type is ArrayType) return true;
            if (type is Enum) return false;
            if (type is Struct) return true;
            return false;
        }

        public static string IsNullableXsd(this SoalType type)
        {
            return type.IsNullable().ToString().ToLower();
        }

        public static List<Struct> GetInterfaceExceptions(this Interface intf)
        {
            List<Struct> result = new List<Struct>();
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

        public static List<Struct> GetInterfaceExceptions(this Namespace ns)
        {
            List<Struct> result = new List<Struct>();
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

        public static string GetWsdlSoapDocRpcStyle(this Binding binding)
        {
            if (binding != null)
            {
                SoapEncodingBindingElement enc = binding.Encodings.OfType<SoapEncodingBindingElement>().FirstOrDefault();
                if (enc != null)
                {
                    if (enc.Style == SoapEncodingStyle.RpcEncoded || enc.Style == SoapEncodingStyle.RpcLiteral) return "rpc";
                }
            }
            return "document";
        }

        public static string GetWsdlSoapEncLitStyle(this Binding binding)
        {
            if (binding != null)
            {
                SoapEncodingBindingElement enc = binding.Encodings.OfType<SoapEncodingBindingElement>().FirstOrDefault();
                if (enc != null)
                {
                    if (enc.Style == SoapEncodingStyle.RpcEncoded) return "encoded";
                }
            }
            return "literal";
        }
    }
}
