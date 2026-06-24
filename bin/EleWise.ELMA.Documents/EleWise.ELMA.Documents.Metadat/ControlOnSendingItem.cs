using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace EleWise.ELMA.Documents.Metadata;

[Serializable]
[XmlRoot]
public class ControlOnSendingItem
{
	[XmlElement]
	public Guid ParentMetadata { get; set; }

	[XmlArray]
	public List<Guid> ChildMetadata { get; set; }

	public ControlOnSendingItem()
	{
		ChildMetadata = new List<Guid>();
	}
}
