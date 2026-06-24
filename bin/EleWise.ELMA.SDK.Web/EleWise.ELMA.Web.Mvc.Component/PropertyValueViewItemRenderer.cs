using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.Web.Mvc.Components;

[Component]
internal class PropertyValueViewItemRenderer : ViewItemRendererBase<PropertyValueViewItem>
{
	public override IEnumerable<ViewItem> GetRenderItems(ViewItem viewItem, ViewItem parentViewItem)
	{
		PropertyViewItemRenderer.Adjust((PropertyViewItem)viewItem);
		yield return viewItem;
	}

	public override bool IsHideEmpty(ViewItem viewItem)
	{
		return false;
	}

	public override bool SupportParentRender(ViewItem viewItem, ViewItem parentViewItem)
	{
		return parentViewItem is ColumnViewItem;
	}
}
