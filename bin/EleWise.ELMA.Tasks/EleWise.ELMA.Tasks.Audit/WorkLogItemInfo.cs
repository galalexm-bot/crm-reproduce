using System;
using System.Xml.Serialization;

namespace EleWise.ELMA.Tasks.Audit;

[Serializable]
[XmlRoot]
public class WorkLogItemInfo
{
	[XmlElement("Comment")]
	public string Comment { get; set; }
}
