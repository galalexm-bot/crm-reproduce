using System;
using System.Xml.Serialization;

namespace EleWise.ELMA.Documents.Audit;

[Serializable]
[XmlRoot]
public class DocumentTasksInfo
{
	[XmlElement("ExecutorId")]
	public long ExecutorId { get; set; }

	[XmlElement("Status")]
	public int Status { get; set; }

	[XmlElement("TaskId")]
	public long TaskId { get; set; }

	[XmlElement("Comment")]
	public string Comment { get; set; }
}
