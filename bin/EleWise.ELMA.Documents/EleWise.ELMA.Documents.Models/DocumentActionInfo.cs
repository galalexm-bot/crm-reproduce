using System;
using System.Xml.Serialization;

namespace EleWise.ELMA.Documents.Models;

[XmlRoot]
public class DocumentActionInfo
{
	[XmlElement]
	public Guid ActionUid { get; set; }

	[XmlElement]
	public string ActionName { get; set; }

	[XmlElement]
	public Guid ActionChapterUid { get; set; }

	[XmlElement]
	public string Image { get; set; }

	[XmlElement]
	public long Order { get; set; }
}
