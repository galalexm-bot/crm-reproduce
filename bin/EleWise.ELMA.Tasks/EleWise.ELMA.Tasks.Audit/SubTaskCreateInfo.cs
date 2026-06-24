using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace EleWise.ELMA.Tasks.Audit;

[Serializable]
[XmlRoot("SubTaskCreateInfo")]
public class SubTaskCreateInfo
{
	[XmlArray]
	public IEnumerable<long> SubTasksIds { get; set; }
}
