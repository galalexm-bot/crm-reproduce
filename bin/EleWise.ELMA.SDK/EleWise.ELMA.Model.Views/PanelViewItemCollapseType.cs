using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Views;

public enum PanelViewItemCollapseType
{
	[XmlEnum("false")]
	DefaultExpanded,
	[XmlEnum("true")]
	DefaultCollapsed,
	[XmlEnum("collapsedIfEmpty")]
	CollapsedIfEmpty
}
