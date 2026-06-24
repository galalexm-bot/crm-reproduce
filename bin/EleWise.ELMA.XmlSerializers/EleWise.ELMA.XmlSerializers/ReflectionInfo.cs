using System;
using System.Collections;
using System.Reflection;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace EleWise.ELMA.XmlSerializers;

internal static class ReflectionInfo
{
	public static class Types
	{
		public static readonly Type XmlSchemaObjectComparer = typeof(XmlDocument).Assembly.GetType("System.Xml.Serialization.XmlSchemaObjectComparer", throwOnError: true);

		public static readonly Type SchemaObjectWriter = typeof(XmlDocument).Assembly.GetType("System.Xml.Serialization.SchemaObjectWriter", throwOnError: true);
	}

	public class SchemaObjectWriterWrapper
	{
		private object writer;

		private MethodInfo method_WriteXmlSchemaObject;

		public SchemaObjectWriterWrapper()
		{
			writer = Activator.CreateInstance(Types.SchemaObjectWriter);
			method_WriteXmlSchemaObject = Types.SchemaObjectWriter.GetMethod("WriteXmlSchemaObject", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
		}

		public string WriteXmlSchemaObject(XmlSchemaObject o)
		{
			return (string)method_WriteXmlSchemaObject.Invoke(writer, new object[1] { o });
		}
	}

	private static Func<XmlAnyElementAttribute, bool> _XmlAnyElementAttribute_get_NamespaceSpecified = ReflectionHelper.GetPropertyValueExpression<XmlAnyElementAttribute, bool>("NamespaceSpecified");

	private static Func<XmlArrayItemAttribute, bool> _XmlArrayItemAttribute_get_IsNullableSpecified = ReflectionHelper.GetPropertyValueExpression<XmlArrayItemAttribute, bool>("IsNullableSpecified");

	private static Action<XmlDocument, string> _XmlDocument_SetBaseURI = (Action<XmlDocument, string>)ReflectionHelper.InvokeMethodExpression<XmlDocument, string>("SetBaseURI");

	private static Func<XmlElementAttribute, bool> _XmlElementAttribute_get_IsNullableSpecified = ReflectionHelper.GetPropertyValueExpression<XmlElementAttribute, bool>("IsNullableSpecified");

	private static Func<XmlRootAttribute, bool> _XmlRootAttribute_get_IsNullableSpecified = ReflectionHelper.GetPropertyValueExpression<XmlRootAttribute, bool>("IsNullableSpecified");

	private static Func<XmlRootAttribute, string> _XmlRootAttribute_get_Key = ReflectionHelper.GetPropertyValueExpression<XmlRootAttribute, string>("Key");

	private static Action<XmlSchema, Uri> _XmlSchema_set_BaseUri = ReflectionHelper.SetPropertyValueAction<XmlSchema, Uri>("BaseUri");

	private static Action<XmlSchema, bool> _XmlSchema_set_IsPreprocessed = ReflectionHelper.SetPropertyValueAction<XmlSchema, bool>("IsPreprocessed");

	private static Func<XmlSchemaType, XmlSchemaType> _XmlSchemaType_get_Redefined = ReflectionHelper.GetPropertyValueExpression<XmlSchemaType, XmlSchemaType>("Redefined");

	private static Func<XmlSchemaType, XmlQualifiedName> _XmlSchemaType_get_DerivedFrom = ReflectionHelper.GetPropertyValueExpression<XmlSchemaType, XmlQualifiedName>("DerivedFrom");

	private static Func<XmlSerializerNamespaces, ArrayList> _XmlSerializerNamespaces_get_NamespaceList = ReflectionHelper.GetPropertyValueExpression<XmlSerializerNamespaces, ArrayList>("NamespaceList");

	private static Func<XmlSerializerNamespaces, Hashtable> _XmlSerializerNamespaces_get_Namespaces = ReflectionHelper.GetPropertyValueExpression<XmlSerializerNamespaces, Hashtable>("Namespaces");

	private static Action<XmlSerializerNamespaces, string, string> _XmlSerializerNamespaces_AddInternal = (Action<XmlSerializerNamespaces, string, string>)ReflectionHelper.InvokeMethodExpression<XmlSerializerNamespaces, string, string>("AddInternal");

	private static Func<XmlSerializerNamespaces, string, string> _XmlSerializerNamespaces_LookupPrefix = (Func<XmlSerializerNamespaces, string, string>)ReflectionHelper.InvokeMethodExpression<XmlSerializerNamespaces, string>("LookupPrefix");

	public static bool get_NamespaceSpecified(this XmlAnyElementAttribute obj)
	{
		return _XmlAnyElementAttribute_get_NamespaceSpecified(obj);
	}

	public static bool get_IsNullableSpecified(this XmlArrayItemAttribute obj)
	{
		return _XmlArrayItemAttribute_get_IsNullableSpecified(obj);
	}

	public static void SetBaseURI(this XmlDocument obj, string baseUri)
	{
		_XmlDocument_SetBaseURI(obj, baseUri);
	}

	public static bool get_IsNullableSpecified(this XmlElementAttribute obj)
	{
		return _XmlElementAttribute_get_IsNullableSpecified(obj);
	}

	public static bool get_IsNullableSpecified(this XmlRootAttribute obj)
	{
		return _XmlRootAttribute_get_IsNullableSpecified(obj);
	}

	public static string get_Key(this XmlRootAttribute obj)
	{
		return _XmlRootAttribute_get_Key(obj);
	}

	public static void set_BaseUri(this XmlSchema obj, Uri baseUri)
	{
		_XmlSchema_set_BaseUri(obj, baseUri);
	}

	public static void set_IsPreprocessed(this XmlSchema obj, bool value)
	{
		_XmlSchema_set_IsPreprocessed(obj, value);
	}

	public static XmlSchemaType get_Redefined(this XmlSchemaType obj)
	{
		return _XmlSchemaType_get_Redefined(obj);
	}

	public static XmlQualifiedName get_DerivedFrom(this XmlSchemaType obj)
	{
		return _XmlSchemaType_get_DerivedFrom(obj);
	}

	public static ArrayList get_NamespaceList(this XmlSerializerNamespaces obj)
	{
		return _XmlSerializerNamespaces_get_NamespaceList(obj);
	}

	public static Hashtable get_Namespaces(this XmlSerializerNamespaces obj)
	{
		return _XmlSerializerNamespaces_get_Namespaces(obj);
	}

	public static void AddInternal(this XmlSerializerNamespaces obj, string prefix, string ns)
	{
		_XmlSerializerNamespaces_AddInternal(obj, prefix, ns);
	}

	public static string LookupPrefix(this XmlSerializerNamespaces obj, string ns)
	{
		return _XmlSerializerNamespaces_LookupPrefix(obj, ns);
	}
}
