using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Extensions;

namespace EleWise.ELMA.Web.Mvc.Components;

[Component]
internal class DefaultContainerViewItemRenderer : ViewItemRendererBase<DefaultContainerViewItem>
{
	public override bool CanRender(ViewItem viewItem)
	{
		return viewItem is DefaultContainerViewItem;
	}

	public override IEnumerable<ViewItem> GetRenderItems(ViewItem viewItem, ViewItem parentViewItem)
	{
		return viewItem.GetRenderItems();
	}

	public override IEnumerable<ViewItem> GetItems(ViewItem viewItem)
	{
		if (viewItem.Parent is ColumnsLayoutViewItem)
		{
			return Enumerable.Empty<ViewItem>();
		}
		ColumnViewItem columnViewItem = (viewItem.Parent as ColumnViewItem) ?? new ColumnViewItem();
		IEnumerable<ViewItem> enumerable = ((DefaultContainerViewItem)viewItem).NotIncludedProperies(viewItem.FormViewItem, ViewItemRenderer.ViewType, ViewItemRenderer.ItemType, ViewItemRenderer.Entity, columnViewItem);
		if (!(viewItem.Parent is ColumnViewItem))
		{
			enumerable.Each(columnViewItem.Items.Add);
			IEnumerable<ViewItem> enumerable2;
			if (columnViewItem.Items.Count <= 0)
			{
				enumerable2 = Enumerable.Empty<ViewItem>();
			}
			else
			{
				IEnumerable<ViewItem> enumerable3 = new ColumnViewItem[1] { columnViewItem };
				enumerable2 = enumerable3;
			}
			enumerable = enumerable2;
		}
		return enumerable;
	}
}
