using System.Drawing;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Web.Mvc.Models;

[DataContract]
public class EntitySelectGroupStyles
{
	[DataMember]
	public FontStyle? FontStyle { get; set; }

	[DataMember]
	public Color? FontColor { get; set; }

	[DataMember]
	public Color? BackgroundColor { get; set; }

	[DataMember]
	public string IconUrl { get; set; }
}
