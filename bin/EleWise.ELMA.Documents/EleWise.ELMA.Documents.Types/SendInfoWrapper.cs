using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.ExtensionPoints;

namespace EleWise.ELMA.Documents.Types;

[Component]
[XmlRoot("SendInfoValue")]
public class SendInfoWrapper : IXsiType
{
	[XmlElement("Info")]
	public SendInfo Info { get; set; }

	public SendInfoWrapper()
	{
	}

	public SendInfoWrapper(SendInfo info)
	{
		Info = info;
	}
}
