using System.Xml.Serialization;

namespace EleWise.ELMA.Web.Mvc.Models.Selectors;

[XmlRoot("CreatorParam")]
public class ObjectCreatorParam
{
	[XmlElement("Key")]
	public string Key { get; set; }

	[XmlElement("Value")]
	public string Value { get; set; }
}
