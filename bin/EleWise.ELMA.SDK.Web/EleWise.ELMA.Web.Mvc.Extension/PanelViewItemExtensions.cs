using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Web.Mvc.Extensions;

public static class PanelViewItemExtensions
{
	public static string GetCssClass(this PanelViewItem viewItem)
	{
		string empty = string.Empty;
		return viewItem.Style switch
		{
			PanelViewItemStyle.GrayHeaderNoBorder => "separator-gray", 
			PanelViewItemStyle.Separator => "separator-blue", 
			PanelViewItemStyle.YellowSeparator => "separator-yellow", 
			PanelViewItemStyle.Custom => viewItem.CssClass, 
			_ => "separator-trasparent", 
		};
	}

	public static bool IsPanelExpanded(this PanelViewItem viewItem)
	{
		if (viewItem.DefaultCollapseState != PanelViewItemCollapseType.CollapsedIfEmpty)
		{
			return viewItem.DefaultCollapseState != PanelViewItemCollapseType.DefaultCollapsed;
		}
		return !viewItem.IsEmpty();
	}
}
