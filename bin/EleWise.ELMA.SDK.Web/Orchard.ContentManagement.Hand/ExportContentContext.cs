using System.Xml.Linq;

namespace Orchard.ContentManagement.Handlers;

public class ExportContentContext : ContentContextBase
{
	public XElement Data { get; set; }

	public bool Exclude { get; set; }

	public ExportContentContext(ContentItem contentItem, XElement data)
		: base(contentItem)
	{
		Data = data;
	}

	public XElement Element(string elementName)
	{
		XElement xElement = Data.Element(elementName);
		if (xElement == null)
		{
			xElement = new XElement(elementName);
			Data.Add(xElement);
		}
		return xElement;
	}
}
