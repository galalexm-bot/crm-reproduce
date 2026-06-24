using System;
using System.Xml.Serialization;

namespace EleWise.ELMA.Documents.Models;

[XmlRoot]
public class DocumentActionChapterInfo
{
	[XmlElement]
	public Guid Uid { get; set; }

	[XmlElement]
	public string Name { get; set; }
}
