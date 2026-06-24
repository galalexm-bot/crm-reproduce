using System;
using System.Drawing;
using System.Xml.Serialization;

namespace EleWise.ELMA.Diagrams;

[Serializable]
public class ConnectorHV : Connector
{
	[XmlArray("Points")]
	public PointF[] Points { get; set; }
}
