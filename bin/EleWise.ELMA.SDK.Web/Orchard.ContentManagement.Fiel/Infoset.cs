using System.Xml.Linq;

namespace Orchard.ContentManagement.FieldStorage.InfosetStorage;

public class Infoset
{
	private XElement _element;

	public XElement Element => _element ?? (_element = new XElement("Data"));

	public string Data
	{
		get
		{
			if (_element != null)
			{
				return Element.ToString(SaveOptions.DisableFormatting);
			}
			return null;
		}
		set
		{
			SetElement(string.IsNullOrEmpty(value) ? null : XElement.Parse(value, LoadOptions.PreserveWhitespace));
		}
	}

	private void SetElement(XElement value)
	{
		_element = value;
	}
}
