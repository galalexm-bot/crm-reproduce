using System;
using System.Xml.Linq;

namespace Orchard.ContentManagement.Handlers;

public class ImportContentContext : ContentContextBase
{
	public XElement Data { get; set; }

	private ImportContentSession Session { get; set; }

	public ImportContentContext(ContentItem contentItem, XElement data, ImportContentSession importContentSession)
		: base(contentItem)
	{
		Data = data;
		Session = importContentSession;
	}

	public string Attribute(string elementName, string attributeName)
	{
		XElement xElement = Data.Element(elementName);
		if (xElement != null)
		{
			XAttribute xAttribute = xElement.Attribute(attributeName);
			if (xAttribute != null)
			{
				return xAttribute.Value;
			}
		}
		return null;
	}

	public string ChildEl(string elementName, string childElementName)
	{
		return Data.Element(elementName)?.El(childElementName);
	}

	public void ImportAttribute(string elementName, string attributeName, Action<string> value)
	{
		ImportAttribute(elementName, attributeName, value, delegate
		{
		});
	}

	public void ImportAttribute(string elementName, string attributeName, Action<string> value, Action empty)
	{
		string text = Attribute(elementName, attributeName);
		if (text != null)
		{
			try
			{
				value(text);
				return;
			}
			catch
			{
				empty();
				return;
			}
		}
		empty();
	}

	public void ImportChildEl(string elementName, string childElementName, Action<string> value)
	{
		ImportChildEl(elementName, childElementName, value, delegate
		{
		});
	}

	public void ImportChildEl(string elementName, string childElementName, Action<string> value, Action empty)
	{
		string text = ChildEl(elementName, childElementName);
		if (text != null)
		{
			try
			{
				value(text);
				return;
			}
			catch
			{
				empty();
				return;
			}
		}
		empty();
	}

	public ContentItem GetItemFromSession(string id)
	{
		return Session.Get(id);
	}
}
