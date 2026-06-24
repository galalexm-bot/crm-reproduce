using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace EleWise.ELMA.Documents.Metadata;

[Serializable]
[XmlRoot]
public class ControlOnSendingInfo
{
	public static string BLOBKey = "EleWise.ELMA.Documents.Metadata.ControlOnSendingInfo";

	[XmlArray]
	public List<ControlOnSendingItem> Infos { get; set; }

	public ControlOnSendingInfo()
	{
		Infos = new List<ControlOnSendingItem>();
	}
}
