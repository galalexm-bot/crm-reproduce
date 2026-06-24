using System;
using System.Xml;
using System.Xml.Linq;
using Orchard.ContentManagement.MetaData.Models;

namespace Orchard.ContentManagement.FieldStorage.InfosetStorage;

public class InfosetStorageProvider : IFieldStorageProvider, IDependency
{
	public string ProviderName => "Infoset";

	public IFieldStorage BindStorage(ContentPart contentPart, ContentPartFieldDefinition partFieldDefinition)
	{
		string partName = XmlConvert.EncodeLocalName(contentPart.PartDefinition.Name);
		string fieldName = XmlConvert.EncodeLocalName(partFieldDefinition.Name);
		InfosetPart infosetPart = contentPart.As<InfosetPart>();
		return new SimpleFieldStorage((string name, Type valueType) => Get((infosetPart.ContentItem.VersionRecord == null) ? infosetPart.Infoset.Element : infosetPart.VersionInfoset.Element, partName, fieldName, name), delegate(string name, Type valueType, string value)
		{
			Set((infosetPart.ContentItem.VersionRecord == null) ? infosetPart.Infoset.Element : infosetPart.VersionInfoset.Element, partName, fieldName, name, value);
		});
	}

	private static string Get(XElement element, string partName, string fieldName, string valueName)
	{
		XElement xElement = element.Element(partName);
		if (xElement == null)
		{
			return null;
		}
		XElement xElement2 = xElement.Element(fieldName);
		if (xElement2 == null)
		{
			return null;
		}
		if (string.IsNullOrEmpty(valueName))
		{
			return xElement2.Value;
		}
		return xElement2.Attribute(XmlConvert.EncodeLocalName(valueName))?.Value;
	}

	private void Set(XElement element, string partName, string fieldName, string valueName, string value)
	{
		XElement xElement = element.Element(partName);
		if (xElement == null)
		{
			xElement = new XElement(partName);
			element.Add(xElement);
		}
		XElement xElement2 = xElement.Element(fieldName);
		if (xElement2 == null)
		{
			xElement2 = new XElement(fieldName);
			xElement.Add(xElement2);
		}
		if (string.IsNullOrEmpty(valueName))
		{
			xElement2.Value = value;
		}
		else
		{
			xElement2.SetAttributeValue(XmlConvert.EncodeLocalName(valueName), value);
		}
	}
}
