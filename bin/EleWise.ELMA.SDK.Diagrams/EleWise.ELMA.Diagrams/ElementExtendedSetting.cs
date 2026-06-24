using System.Xml.Serialization;

namespace EleWise.ELMA.Diagrams;

[XmlRoot("ElementExtendedSetting")]
public class ElementExtendedSetting
{
	[XmlElement("Key")]
	public string Key { get; set; }

	[XmlElement("Value")]
	public object Value { get; set; }
}
