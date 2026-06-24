using System;
using System.Xml.Serialization;

namespace EleWise.ELMA.Diagrams;

[Serializable]
public class Plug
{
	[XmlAttribute("ElementUid")]
	public Guid ElementUid { get; set; }

	[XmlAttribute("PortName")]
	public string PortName { get; set; }
}
