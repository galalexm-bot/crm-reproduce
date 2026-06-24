using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Views;

public enum HideEmptyEnum
{
	[XmlEnum("inherit")]
	Inherit,
	[XmlEnum("false")]
	ShowEmpty,
	[XmlEnum("true")]
	HideEmpty
}
