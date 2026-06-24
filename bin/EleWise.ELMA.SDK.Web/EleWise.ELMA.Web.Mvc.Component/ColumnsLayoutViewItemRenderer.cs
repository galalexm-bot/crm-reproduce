using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.Web.Mvc.Components;

[Component]
internal class ColumnsLayoutViewItemRenderer : ViewItemRendererBase<ColumnsLayoutViewItem>
{
	public override IEnumerable<ViewItem> GetItems(ViewItem viewItem)
	{
		ColumnsLayoutViewItem columnsLayoutViewItem = (ColumnsLayoutViewItem)viewItem;
		List<ColumnViewItem> columns = (from i in columnsLayoutViewItem.Items.OfType<ColumnViewItem>()
			where !i.Hide
			select i).ToList();
		int startColumnIndex = -1;
		(from i in columnsLayoutViewItem.Items.OfType<DefaultContainerViewItem>()
			where !i.Hide
			select i).Each(delegate(DefaultContainerViewItem defaultContainerViewItem)
		{
			if (columns.Count == 0)
			{
				ColumnViewItem item2 = new ColumnViewItem();
				columnsLayoutViewItem.Items.Add(item2);
				columns.Add(item2);
			}
			if (startColumnIndex == -1)
			{
				startColumnIndex = defaultContainerViewItem.StartColumnIndex;
			}
			defaultContainerViewItem.NotIncludedProperies(viewItem.FormViewItem, ViewItemRenderer.ViewType, ViewItemRenderer.ItemType, ViewItemRenderer.Entity).Each(delegate(PropertyViewItem item, int index)
			{
				int index2 = (startColumnIndex + index) % columns.Count;
				columns[index2].Items.Add(item);
				item.Parent = columns[index2];
			});
			startColumnIndex = (startColumnIndex + defaultContainerViewItem.NotIncludedProperies(viewItem.FormViewItem, ViewItemRenderer.ViewType, ViewItemRenderer.ItemType, ViewItemRenderer.Entity).Count()) % columns.Count;
		});
		return columns;
	}
}
