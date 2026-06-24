using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.Web.Mvc.Components;

[Component]
internal class ExtensionZoneViewItemRenderer : ViewItemRendererBase<ExtensionZoneViewItem>
{
	public override bool SupportParentRender(ViewItem viewItem, ViewItem parentViewItem)
	{
		if (((ExtensionZoneViewItem)viewItem).SupportInColumnRender)
		{
			return parentViewItem is ColumnViewItem;
		}
		return false;
	}
}
