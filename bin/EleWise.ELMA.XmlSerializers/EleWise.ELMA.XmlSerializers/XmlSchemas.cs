using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace EleWise.ELMA.XmlSerializers;

public class XmlSchemas : CollectionBase, IEnumerable<XmlSchema>, IEnumerable
{
	private XmlSchemaSet schemaSet;

	private Hashtable references;

	private SchemaObjectCache cache;

	internal Hashtable delayedSchemas = new Hashtable();

	private static volatile XmlSchema xsd;

	private static volatile XmlSchema xml;

	internal const string xmlSchema = "<?xml version='1.0' encoding='UTF-8' ?> \r\n<xs:schema targetNamespace='http://www.w3.org/XML/1998/namespace' xmlns:xs='http://www.w3.org/2001/XMLSchema' xml:lang='en'>\r\n <xs:attribute name='lang' type='xs:language'/>\r\n <xs:attribute name='space'>\r\n  <xs:simpleType>\r\n   <xs:restriction base='xs:NCName'>\r\n    <xs:enumeration value='default'/>\r\n    <xs:enumeration value='preserve'/>\r\n   </xs:restriction>\r\n  </xs:simpleType>\r\n </xs:attribute>\r\n <xs:attribute name='base' type='xs:anyURI'/>\r\n <xs:attribute name='id' type='xs:ID' />\r\n <xs:attributeGroup name='specialAttrs'>\r\n  <xs:attribute ref='xml:base'/>\r\n  <xs:attribute ref='xml:lang'/>\r\n  <xs:attribute ref='xml:space'/>\r\n </xs:attributeGroup>\r\n</xs:schema>";

	public XmlSchema this[int index]
	{
		get
		{
			return (XmlSchema)base.List[index];
		}
		set
		{
			base.List[index] = value;
		}
	}

	public XmlSchema this[string ns]
	{
		get
		{
			IList list = (IList)SchemaSet.Schemas(ns);
			if (list.Count == 0)
			{
				return null;
			}
			if (list.Count == 1)
			{
				return (XmlSchema)list[0];
			}
			throw new InvalidOperationException(Res.GetString("XmlSchemaDuplicateNamespace", ns));
		}
	}

	internal SchemaObjectCache Cache
	{
		get
		{
			if (cache == null)
			{
				cache = new SchemaObjectCache();
			}
			return cache;
		}
	}

	internal Hashtable References
	{
		get
		{
			if (references == null)
			{
				references = new Hashtable();
			}
			return references;
		}
	}

	internal XmlSchemaSet SchemaSet
	{
		get
		{
			if (schemaSet == null)
			{
				schemaSet = new XmlSchemaSet();
				schemaSet.XmlResolver = null;
				schemaSet.ValidationEventHandler += IgnoreCompileErrors;
			}
			return schemaSet;
		}
	}

	internal static XmlSchema XsdSchema
	{
		get
		{
			if (xsd == null)
			{
				xsd = CreateFakeXsdSchema("http://www.w3.org/2001/XMLSchema", "schema");
			}
			return xsd;
		}
	}

	internal static XmlSchema XmlSchema
	{
		get
		{
			if (xml == null)
			{
				xml = XmlSchema.Read(new StringReader("<?xml version='1.0' encoding='UTF-8' ?> \r\n<xs:schema targetNamespace='http://www.w3.org/XML/1998/namespace' xmlns:xs='http://www.w3.org/2001/XMLSchema' xml:lang='en'>\r\n <xs:attribute name='lang' type='xs:language'/>\r\n <xs:attribute name='space'>\r\n  <xs:simpleType>\r\n   <xs:restriction base='xs:NCName'>\r\n    <xs:enumeration value='default'/>\r\n    <xs:enumeration value='preserve'/>\r\n   </xs:restriction>\r\n  </xs:simpleType>\r\n </xs:attribute>\r\n <xs:attribute name='base' type='xs:anyURI'/>\r\n <xs:attribute name='id' type='xs:ID' />\r\n <xs:attributeGroup name='specialAttrs'>\r\n  <xs:attribute ref='xml:base'/>\r\n  <xs:attribute ref='xml:lang'/>\r\n  <xs:attribute ref='xml:space'/>\r\n </xs:attributeGroup>\r\n</xs:schema>"), null);
			}
			return xml;
		}
	}

	public IList GetSchemas(string ns)
	{
		return (IList)SchemaSet.Schemas(ns);
	}

	internal int Add(XmlSchema schema, bool delay)
	{
		if (delay)
		{
			if (delayedSchemas[schema] == null)
			{
				delayedSchemas.Add(schema, schema);
			}
			return -1;
		}
		return Add(schema);
	}

	public int Add(XmlSchema schema)
	{
		if (base.List.Contains(schema))
		{
			return base.List.IndexOf(schema);
		}
		return base.List.Add(schema);
	}

	public int Add(XmlSchema schema, Uri baseUri)
	{
		if (base.List.Contains(schema))
		{
			return base.List.IndexOf(schema);
		}
		if (baseUri != null)
		{
			schema.set_BaseUri(baseUri);
		}
		return base.List.Add(schema);
	}

	public void Add(XmlSchemas schemas)
	{
		foreach (XmlSchema schema in schemas)
		{
			Add(schema);
		}
	}

	public void AddReference(XmlSchema schema)
	{
		References[schema] = schema;
	}

	public void Insert(int index, XmlSchema schema)
	{
		base.List.Insert(index, schema);
	}

	public int IndexOf(XmlSchema schema)
	{
		return base.List.IndexOf(schema);
	}

	public bool Contains(XmlSchema schema)
	{
		return base.List.Contains(schema);
	}

	public bool Contains(string targetNamespace)
	{
		return SchemaSet.Contains(targetNamespace);
	}

	public void Remove(XmlSchema schema)
	{
		base.List.Remove(schema);
	}

	public void CopyTo(XmlSchema[] array, int index)
	{
		base.List.CopyTo(array, index);
	}

	protected override void OnInsert(int index, object value)
	{
		AddName((XmlSchema)value);
	}

	protected override void OnRemove(int index, object value)
	{
		RemoveName((XmlSchema)value);
	}

	protected override void OnClear()
	{
		schemaSet = null;
	}

	protected override void OnSet(int index, object oldValue, object newValue)
	{
		RemoveName((XmlSchema)oldValue);
		AddName((XmlSchema)newValue);
	}

	private void AddName(XmlSchema schema)
	{
		if (SchemaSet.Contains(schema))
		{
			SchemaSet.Reprocess(schema);
			return;
		}
		Prepare(schema);
		SchemaSet.Add(schema);
	}

	private void Prepare(XmlSchema schema)
	{
		ArrayList arrayList = new ArrayList();
		string targetNamespace = schema.TargetNamespace;
		foreach (XmlSchemaExternal include in schema.Includes)
		{
			if (include is XmlSchemaImport && targetNamespace == ((XmlSchemaImport)include).Namespace)
			{
				arrayList.Add(include);
			}
		}
		foreach (XmlSchemaObject item in arrayList)
		{
			schema.Includes.Remove(item);
		}
	}

	private void RemoveName(XmlSchema schema)
	{
		SchemaSet.Remove(schema);
	}

	IEnumerator<XmlSchema> IEnumerable<XmlSchema>.GetEnumerator()
	{
		return new XmlSchemaEnumerator(this);
	}

	public static bool IsDataSet(XmlSchema schema)
	{
		foreach (XmlSchemaObject item in schema.Items)
		{
			if (!(item is XmlSchemaElement))
			{
				continue;
			}
			XmlSchemaElement xmlSchemaElement = (XmlSchemaElement)item;
			if (xmlSchemaElement.UnhandledAttributes == null)
			{
				continue;
			}
			XmlAttribute[] unhandledAttributes = xmlSchemaElement.UnhandledAttributes;
			foreach (XmlAttribute xmlAttribute in unhandledAttributes)
			{
				if (xmlAttribute.LocalName == "IsDataSet" && xmlAttribute.NamespaceURI == "urn:schemas-microsoft-com:xml-msdata" && (xmlAttribute.Value == "True" || xmlAttribute.Value == "true" || xmlAttribute.Value == "1"))
				{
					return true;
				}
			}
		}
		return false;
	}

	private void AddImport(IList schemas, string ns)
	{
		foreach (XmlSchema schema in schemas)
		{
			bool flag = true;
			foreach (XmlSchemaExternal include in schema.Includes)
			{
				if (include is XmlSchemaImport && ((XmlSchemaImport)include).Namespace == ns)
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				XmlSchemaImport xmlSchemaImport = new XmlSchemaImport();
				xmlSchemaImport.Namespace = ns;
				schema.Includes.Add(xmlSchemaImport);
			}
		}
	}

	private static string ItemName(XmlSchemaObject o)
	{
		if (o is XmlSchemaNotation)
		{
			return ((XmlSchemaNotation)o).Name;
		}
		if (o is XmlSchemaGroup)
		{
			return ((XmlSchemaGroup)o).Name;
		}
		if (o is XmlSchemaElement)
		{
			return ((XmlSchemaElement)o).Name;
		}
		if (o is XmlSchemaType)
		{
			return ((XmlSchemaType)o).Name;
		}
		if (o is XmlSchemaAttributeGroup)
		{
			return ((XmlSchemaAttributeGroup)o).Name;
		}
		if (o is XmlSchemaAttribute)
		{
			return ((XmlSchemaAttribute)o).Name;
		}
		return null;
	}

	internal static XmlQualifiedName GetParentName(XmlSchemaObject item)
	{
		while (item.Parent != null)
		{
			if (item.Parent is XmlSchemaType)
			{
				XmlSchemaType xmlSchemaType = (XmlSchemaType)item.Parent;
				if (xmlSchemaType.Name != null && xmlSchemaType.Name.Length != 0)
				{
					return xmlSchemaType.QualifiedName;
				}
			}
			item = item.Parent;
		}
		return XmlQualifiedName.Empty;
	}

	private static string GetSchemaItem(XmlSchemaObject o, string ns, string details)
	{
		if (o == null)
		{
			return null;
		}
		while (o.Parent != null && !(o.Parent is XmlSchema))
		{
			o = o.Parent;
		}
		if (ns == null || ns.Length == 0)
		{
			XmlSchemaObject xmlSchemaObject = o;
			while (xmlSchemaObject.Parent != null)
			{
				xmlSchemaObject = xmlSchemaObject.Parent;
			}
			if (xmlSchemaObject is XmlSchema)
			{
				ns = ((XmlSchema)xmlSchemaObject).TargetNamespace;
			}
		}
		string text = null;
		if (o is XmlSchemaNotation)
		{
			return Res.GetString("XmlSchemaNamedItem", ns, "notation", ((XmlSchemaNotation)o).Name, details);
		}
		if (o is XmlSchemaGroup)
		{
			return Res.GetString("XmlSchemaNamedItem", ns, "group", ((XmlSchemaGroup)o).Name, details);
		}
		if (o is XmlSchemaElement)
		{
			XmlSchemaElement xmlSchemaElement = (XmlSchemaElement)o;
			if (xmlSchemaElement.Name == null || xmlSchemaElement.Name.Length == 0)
			{
				XmlQualifiedName parentName = GetParentName(o);
				return Res.GetString("XmlSchemaElementReference", xmlSchemaElement.RefName.ToString(), parentName.Name, parentName.Namespace);
			}
			return Res.GetString("XmlSchemaNamedItem", ns, "element", xmlSchemaElement.Name, details);
		}
		if (o is XmlSchemaType)
		{
			return Res.GetString("XmlSchemaNamedItem", ns, (o.GetType() == typeof(XmlSchemaSimpleType)) ? "simpleType" : "complexType", ((XmlSchemaType)o).Name, null);
		}
		if (o is XmlSchemaAttributeGroup)
		{
			return Res.GetString("XmlSchemaNamedItem", ns, "attributeGroup", ((XmlSchemaAttributeGroup)o).Name, details);
		}
		if (o is XmlSchemaAttribute)
		{
			XmlSchemaAttribute xmlSchemaAttribute = (XmlSchemaAttribute)o;
			if (xmlSchemaAttribute.Name == null || xmlSchemaAttribute.Name.Length == 0)
			{
				XmlQualifiedName parentName2 = GetParentName(o);
				return Res.GetString("XmlSchemaAttributeReference", xmlSchemaAttribute.RefName.ToString(), parentName2.Name, parentName2.Namespace);
			}
			return Res.GetString("XmlSchemaNamedItem", ns, "attribute", xmlSchemaAttribute.Name, details);
		}
		if (o is XmlSchemaContent)
		{
			XmlQualifiedName parentName3 = GetParentName(o);
			return Res.GetString("XmlSchemaContentDef", parentName3.Name, parentName3.Namespace, null);
		}
		if (o is XmlSchemaExternal)
		{
			string text2 = ((o is XmlSchemaImport) ? "import" : ((o is XmlSchemaInclude) ? "include" : ((o is XmlSchemaRedefine) ? "redefine" : o.GetType().Name)));
			return Res.GetString("XmlSchemaItem", ns, text2, details);
		}
		if (o is XmlSchema)
		{
			return Res.GetString("XmlSchema", ns, details);
		}
		return Res.GetString("XmlSchemaNamedItem", ns, o.GetType().Name, null, details);
	}

	private static string Dump(XmlSchemaObject o)
	{
		XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
		xmlWriterSettings.OmitXmlDeclaration = true;
		xmlWriterSettings.Indent = true;
		XmlSerializer xmlSerializer = new XmlSerializer(o.GetType());
		StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture);
		XmlWriter xmlWriter = XmlWriter.Create(stringWriter, xmlWriterSettings);
		XmlSerializerNamespaces xmlSerializerNamespaces = new XmlSerializerNamespaces();
		xmlSerializerNamespaces.Add("xs", "http://www.w3.org/2001/XMLSchema");
		xmlSerializer.Serialize(xmlWriter, o, xmlSerializerNamespaces);
		return stringWriter.ToString();
	}

	private static string MergeFailedMessage(XmlSchemaObject src, XmlSchemaObject dest, string ns)
	{
		return string.Concat(Res.GetString("XmlSerializableMergeItem", ns, GetSchemaItem(src, ns, null)) + "\r\n" + Dump(src), "\r\n", Dump(dest));
	}

	internal XmlSchemaObject Find(XmlSchemaObject o, IList originals)
	{
		string text = ItemName(o);
		if (text == null)
		{
			return null;
		}
		Type type = o.GetType();
		foreach (XmlSchema original in originals)
		{
			foreach (XmlSchemaObject item in original.Items)
			{
				if (item.GetType() == type && text == ItemName(item))
				{
					return item;
				}
			}
		}
		return null;
	}

	internal static Exception CreateValidationException(XmlSchemaException exception, string message)
	{
		XmlSchemaObject xmlSchemaObject = exception.SourceSchemaObject;
		if (exception.LineNumber == 0 && exception.LinePosition == 0)
		{
			throw new InvalidOperationException(GetSchemaItem(xmlSchemaObject, null, message), exception);
		}
		string text = null;
		if (xmlSchemaObject != null)
		{
			while (xmlSchemaObject.Parent != null)
			{
				xmlSchemaObject = xmlSchemaObject.Parent;
			}
			if (xmlSchemaObject is XmlSchema)
			{
				text = ((XmlSchema)xmlSchemaObject).TargetNamespace;
			}
		}
		throw new InvalidOperationException(Res.GetString("XmlSchemaSyntaxErrorDetails", text, message, exception.LineNumber, exception.LinePosition), exception);
	}

	internal static void IgnoreCompileErrors(object sender, ValidationEventArgs args)
	{
	}

	private static XmlSchema CreateFakeXsdSchema(string ns, string name)
	{
		XmlSchema obj = new XmlSchema
		{
			TargetNamespace = ns
		};
		XmlSchemaElement xmlSchemaElement = new XmlSchemaElement
		{
			Name = name
		};
		XmlSchemaComplexType xmlSchemaComplexType = (XmlSchemaComplexType)(xmlSchemaElement.SchemaType = new XmlSchemaComplexType());
		obj.Items.Add(xmlSchemaElement);
		return obj;
	}

	internal bool IsReference(XmlSchemaObject type)
	{
		XmlSchemaObject xmlSchemaObject = type;
		while (xmlSchemaObject.Parent != null)
		{
			xmlSchemaObject = xmlSchemaObject.Parent;
		}
		return References.Contains(xmlSchemaObject);
	}
}
