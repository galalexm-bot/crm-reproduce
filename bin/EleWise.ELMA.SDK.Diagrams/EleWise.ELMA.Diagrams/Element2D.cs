using System;
using System.Drawing;
using System.Xml.Serialization;

namespace EleWise.ELMA.Diagrams;

[Serializable]
public class Element2D : Element
{
	[XmlElement("Location")]
	public PointF Location { get; set; }

	[XmlElement("Size")]
	public SizeF Size { get; set; }
}
