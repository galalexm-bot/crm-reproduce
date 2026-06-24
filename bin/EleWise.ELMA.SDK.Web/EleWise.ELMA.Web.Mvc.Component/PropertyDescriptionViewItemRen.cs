using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.Web.Mvc.Components;

[Component]
internal class PropertyDescriptionViewItemRenderer : ViewItemRendererBase<PropertyDescriptionViewItem>
{
	public override IEnumerable<ViewItem> GetRenderItems(ViewItem viewItem, ViewItem parentViewItem)
	{
		PropertyViewItemRenderer.Adjust((PropertyViewItem)viewItem);
		yield return viewItem;
	}

	public override bool SupportParentRender(ViewItem viewItem, ViewItem parentViewItem)
	{
		return parentViewItem is ColumnViewItem;
	}
}
