using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.Web.Mvc.Components;

[Component]
internal class CellViewItemRenderer : ViewItemRendererBase<CellViewItem>
{
	public override bool SupportParentRender(ViewItem viewItem, ViewItem parentViewItem)
	{
		return parentViewItem is RowViewItem;
	}
}
