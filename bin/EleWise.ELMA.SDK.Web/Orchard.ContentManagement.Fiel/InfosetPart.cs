using System.Xml;
using System.Xml.Linq;
using Autofac;
using Orchard.ContentManagement.Records;

namespace Orchard.ContentManagement.FieldStorage.InfosetStorage;

public class InfosetPart : ContentPart
{
	public Infoset Infoset { get; set; }

	public Infoset VersionInfoset { get; set; }

	public InfosetPart()
	{
		Infoset = new Infoset();
		VersionInfoset = new Infoset();
	}

	public string Get<TPart>(string fieldName)
	{
		return Get<TPart>(fieldName, null);
	}

	public string Get<TPart>(string fieldName, string valueName)
	{
		return Get(typeof(TPart).Name, fieldName, valueName, TypeExtensions.IsAssignableTo<ContentItemVersionRecord>(typeof(TPart)));
	}

	public string Get(string partName, string fieldName)
	{
		return Get(partName, fieldName, null);
	}

	public string GetVersioned(string partName, string fieldName)
	{
		return Get(partName, fieldName, null, versionable: true);
	}

	public string Get(string partName, string fieldName, string valueName, bool versionable = false)
	{
		XElement xElement = (versionable ? VersionInfoset.Element : Infoset.Element).Element(XmlConvert.EncodeName(partName));
		if (xElement == null)
		{
			return null;
		}
		XElement xElement2 = xElement.Element(XmlConvert.EncodeName(fieldName));
		if (xElement2 == null)
		{
			return null;
		}
		if (string.IsNullOrEmpty(valueName))
		{
			return xElement2.Value;
		}
		return xElement2.Attribute(XmlConvert.EncodeName(valueName))?.Value;
	}

	public void Set<TPart>(string fieldName, string valueName, string value)
	{
		Set<TPart>(fieldName, value);
	}

	public void Set<TPart>(string fieldName, string value)
	{
		Set(typeof(TPart).Name, fieldName, null, value, TypeExtensions.IsAssignableTo<ContentItemVersionRecord>(typeof(TPart)));
	}

	public void Set(string partName, string fieldName, string value)
	{
		Set(partName, fieldName, null, value);
	}

	public void SetVersioned(string partName, string fieldName, string value)
	{
		Set(partName, fieldName, null, value, versionable: true);
	}

	public void Set(string partName, string fieldName, string valueName, string value, bool versionable = false)
	{
		XElement obj = (versionable ? VersionInfoset.Element : Infoset.Element);
		string text = XmlConvert.EncodeName(partName);
		XElement xElement = obj.Element(text);
		if (xElement == null)
		{
			xElement = new XElement(text);
			Infoset.Element.Add(xElement);
		}
		string text2 = XmlConvert.EncodeName(fieldName);
		XElement xElement2 = xElement.Element(text2);
		if (xElement2 == null)
		{
			xElement2 = new XElement(text2);
			xElement.Add(xElement2);
		}
		if (string.IsNullOrEmpty(valueName))
		{
			xElement2.Value = value ?? "";
		}
		else
		{
			xElement2.SetAttributeValue(XmlConvert.EncodeName(valueName), value);
		}
	}
}
