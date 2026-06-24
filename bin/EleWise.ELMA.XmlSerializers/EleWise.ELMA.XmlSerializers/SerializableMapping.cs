using System;
using System.Collections;
using System.Reflection;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace EleWise.ELMA.XmlSerializers;

internal class SerializableMapping : SpecialMapping
{
	private XmlSchema schema;

	private Type type;

	private bool needSchema = true;

	private MethodInfo getSchemaMethod;

	private XmlQualifiedName xsiType;

	private XmlSchemaType xsdType;

	private XmlSchemaSet schemas;

	private bool any;

	private string namespaces;

	private SerializableMapping baseMapping;

	private SerializableMapping derivedMappings;

	private SerializableMapping nextDerivedMapping;

	private SerializableMapping next;

	internal bool IsAny
	{
		get
		{
			if (any)
			{
				return true;
			}
			if (getSchemaMethod == null)
			{
				return false;
			}
			if (needSchema && typeof(XmlSchemaType).IsAssignableFrom(getSchemaMethod.ReturnType))
			{
				return false;
			}
			RetrieveSerializableSchema();
			return any;
		}
	}

	internal string NamespaceList
	{
		get
		{
			RetrieveSerializableSchema();
			if (namespaces == null)
			{
				if (schemas != null)
				{
					StringBuilder stringBuilder = new StringBuilder();
					foreach (XmlSchema item in schemas.Schemas())
					{
						if (item.TargetNamespace != null && item.TargetNamespace.Length > 0)
						{
							if (stringBuilder.Length > 0)
							{
								stringBuilder.Append(" ");
							}
							stringBuilder.Append(item.TargetNamespace);
						}
					}
					namespaces = stringBuilder.ToString();
				}
				else
				{
					namespaces = string.Empty;
				}
			}
			return namespaces;
		}
	}

	internal SerializableMapping DerivedMappings => derivedMappings;

	internal SerializableMapping NextDerivedMapping => nextDerivedMapping;

	internal SerializableMapping Next
	{
		get
		{
			return next;
		}
		set
		{
			next = value;
		}
	}

	internal Type Type
	{
		get
		{
			return type;
		}
		set
		{
			type = value;
		}
	}

	internal XmlSchemaSet Schemas
	{
		get
		{
			RetrieveSerializableSchema();
			return schemas;
		}
	}

	internal XmlSchema Schema
	{
		get
		{
			RetrieveSerializableSchema();
			return schema;
		}
	}

	internal XmlQualifiedName XsiType
	{
		get
		{
			if (!needSchema)
			{
				return xsiType;
			}
			if (getSchemaMethod == null)
			{
				return null;
			}
			if (typeof(XmlSchemaType).IsAssignableFrom(getSchemaMethod.ReturnType))
			{
				return null;
			}
			RetrieveSerializableSchema();
			return xsiType;
		}
	}

	internal XmlSchemaType XsdType
	{
		get
		{
			RetrieveSerializableSchema();
			return xsdType;
		}
	}

	internal SerializableMapping()
	{
	}

	internal SerializableMapping(MethodInfo getSchemaMethod, bool any, string ns)
	{
		this.getSchemaMethod = getSchemaMethod;
		this.any = any;
		base.Namespace = ns;
		needSchema = getSchemaMethod != null;
	}

	internal SerializableMapping(XmlQualifiedName xsiType, XmlSchemaSet schemas)
	{
		this.xsiType = xsiType;
		this.schemas = schemas;
		base.TypeName = xsiType.Name;
		base.Namespace = xsiType.Namespace;
		needSchema = false;
	}

	internal void SetBaseMapping(SerializableMapping mapping)
	{
		baseMapping = mapping;
		if (baseMapping != null)
		{
			nextDerivedMapping = baseMapping.derivedMappings;
			baseMapping.derivedMappings = this;
			if (this == nextDerivedMapping)
			{
				throw new InvalidOperationException(Res.GetString("XmlCircularDerivation", base.TypeDesc.FullName));
			}
		}
	}

	internal static void ValidationCallbackWithErrorCode(object sender, ValidationEventArgs args)
	{
		if (args.Severity == XmlSeverityType.Error)
		{
			throw new InvalidOperationException(Res.GetString("XmlSerializableSchemaError", typeof(IXmlSerializable).Name, args.Message));
		}
	}

	private bool Match(XmlSchemaElement e1, XmlSchemaElement e2)
	{
		if (e1.IsNillable != e2.IsNillable)
		{
			return false;
		}
		if (e1.RefName != e2.RefName)
		{
			return false;
		}
		if (e1.SchemaType != e2.SchemaType)
		{
			return false;
		}
		if (e1.SchemaTypeName != e2.SchemaTypeName)
		{
			return false;
		}
		if (e1.MinOccurs != e2.MinOccurs)
		{
			return false;
		}
		if (e1.MaxOccurs != e2.MaxOccurs)
		{
			return false;
		}
		if (e1.IsAbstract != e2.IsAbstract)
		{
			return false;
		}
		if (e1.DefaultValue != e2.DefaultValue)
		{
			return false;
		}
		if (e1.SubstitutionGroup != e2.SubstitutionGroup)
		{
			return false;
		}
		return true;
	}

	private void RetrieveSerializableSchema()
	{
		if (!needSchema)
		{
			return;
		}
		needSchema = false;
		if (getSchemaMethod != null)
		{
			if (schemas == null)
			{
				schemas = new XmlSchemaSet();
			}
			object obj = getSchemaMethod.Invoke(null, new object[1] { schemas });
			xsiType = XmlQualifiedName.Empty;
			if (obj != null)
			{
				if (typeof(XmlSchemaType).IsAssignableFrom(getSchemaMethod.ReturnType))
				{
					xsdType = (XmlSchemaType)obj;
					xsiType = xsdType.QualifiedName;
				}
				else
				{
					if (!typeof(XmlQualifiedName).IsAssignableFrom(getSchemaMethod.ReturnType))
					{
						throw new InvalidOperationException(Res.GetString("XmlGetSchemaMethodReturnType", type.Name, getSchemaMethod.Name, typeof(XmlSchemaProviderAttribute).Name, typeof(XmlQualifiedName).FullName));
					}
					xsiType = (XmlQualifiedName)obj;
					if (xsiType.IsEmpty)
					{
						throw new InvalidOperationException(Res.GetString("XmlGetSchemaEmptyTypeName", type.FullName, getSchemaMethod.Name));
					}
				}
			}
			else
			{
				any = true;
			}
			schemas.ValidationEventHandler += ValidationCallbackWithErrorCode;
			schemas.Compile();
			if (!xsiType.IsEmpty && xsiType.Namespace != "http://www.w3.org/2001/XMLSchema")
			{
				ArrayList arrayList = (ArrayList)schemas.Schemas(xsiType.Namespace);
				if (arrayList.Count == 0)
				{
					throw new InvalidOperationException(Res.GetString("XmlMissingSchema", xsiType.Namespace));
				}
				if (arrayList.Count > 1)
				{
					throw new InvalidOperationException(Res.GetString("XmlGetSchemaInclude", xsiType.Namespace, getSchemaMethod.DeclaringType.FullName, getSchemaMethod.Name));
				}
				XmlSchema xmlSchema = (XmlSchema)arrayList[0];
				if (xmlSchema == null)
				{
					throw new InvalidOperationException(Res.GetString("XmlMissingSchema", xsiType.Namespace));
				}
				xsdType = (XmlSchemaType)xmlSchema.SchemaTypes[xsiType];
				if (xsdType == null)
				{
					throw new InvalidOperationException(Res.GetString("XmlGetSchemaTypeMissing", getSchemaMethod.DeclaringType.FullName, getSchemaMethod.Name, xsiType.Name, xsiType.Namespace));
				}
				XmlSchemaType xmlSchemaType = xsdType.get_Redefined();
				xsdType = ((xmlSchemaType != null) ? xmlSchemaType : xsdType);
			}
		}
		else
		{
			IXmlSerializable xmlSerializable = (IXmlSerializable)Activator.CreateInstance(type);
			schema = xmlSerializable.GetSchema();
			if (schema != null && (schema.Id == null || schema.Id.Length == 0))
			{
				throw new InvalidOperationException(Res.GetString("XmlSerializableNameMissing1", type.FullName));
			}
		}
	}
}
