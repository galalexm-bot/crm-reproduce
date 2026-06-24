using System;
using System.Xml.Serialization;

namespace EleWise.ELMA.Documents.Models;

[XmlRoot]
public class DocumentActionState
{
	[XmlElement("ActionUid")]
	public Guid ActionUid { get; set; }

	[XmlElement("ChapterUid")]
	public Guid ChapterUid { get; set; }

	[XmlElement("Visible")]
	public string VisibleStr { get; set; }

	[XmlIgnore]
	public bool? Visible
	{
		get
		{
			if (string.IsNullOrEmpty(VisibleStr))
			{
				return null;
			}
			if (bool.TryParse(VisibleStr, out var result))
			{
				return result;
			}
			return null;
		}
		set
		{
			VisibleStr = (value.HasValue ? value.Value.ToString() : string.Empty);
		}
	}
}
