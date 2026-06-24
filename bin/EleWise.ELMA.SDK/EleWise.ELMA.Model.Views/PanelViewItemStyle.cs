using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Model.Views;

public enum PanelViewItemStyle
{
	[DisplayName(typeof(__PanelViewItemStyleLocalization), "None")]
	None = 0,
	[DisplayName(typeof(__PanelViewItemStyleLocalization), "GrayHeaderNoBorder")]
	GrayHeaderNoBorder = 1,
	[DisplayName(typeof(__PanelViewItemStyleLocalization), "Separator")]
	Separator = 2,
	[DisplayName(typeof(__PanelViewItemStyleLocalization), "YellowSeparator")]
	YellowSeparator = 3,
	[DisplayName(typeof(__PanelViewItemStyleLocalization), "MetroBrickBlue")]
	MetroBrickBlue = 100,
	[DisplayName(typeof(__PanelViewItemStyleLocalization), "Custom")]
	Custom = 100000,
	[DisplayName(typeof(__PanelViewItemStyleLocalization), "WhiteSeparator")]
	WhiteSeparator = 200
}
