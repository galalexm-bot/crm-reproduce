using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.Web.Mvc.Components;

[Component(Order = 1000000)]
public class TabViewItemRenderer : ViewItemRendererBase<TabViewItem>
{
	public override bool CanRender(ViewItem viewItem)
	{
		return viewItem is TabViewItem;
	}

	public override string ViewName(ViewItem viewItem)
	{
		return "ViewItems/TabViewItem";
	}

	public override string ViewNameSubItems(ViewItem viewItem)
	{
		return "ViewItems/TabViewItemSubItems";
	}
}
