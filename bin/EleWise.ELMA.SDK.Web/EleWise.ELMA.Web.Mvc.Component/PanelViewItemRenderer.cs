using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Extensions;

namespace EleWise.ELMA.Web.Mvc.Components;

[Component]
internal class PanelViewItemRenderer : ViewItemRendererBase<PanelViewItem>
{
	private static readonly IList<Type> SupportedTypes = new Type[1] { typeof(PanelViewItem) };

	public override bool CanRender(ViewItem viewItem)
	{
		return SupportedTypes.Contains(viewItem.GetType());
	}

	public override IEnumerable<ViewItem> GetRenderItems(ViewItem viewItem, ViewItem parentViewItem)
	{
		PanelViewItem panelViewItem = viewItem as PanelViewItem;
		if (parentViewItem is ColumnViewItem && panelViewItem != null && string.IsNullOrWhiteSpace(panelViewItem.CustomViewName) && panelViewItem.Items.Count == 1)
		{
			ColumnViewItem columnViewItem = panelViewItem.Items[0] as ColumnViewItem;
			if (columnViewItem == null && panelViewItem.Items[0] is ColumnsLayoutViewItem && ((ColumnsLayoutViewItem)panelViewItem.Items[0]).Items.Count == 1)
			{
				columnViewItem = ((ColumnsLayoutViewItem)panelViewItem.Items[0]).Items[0] as ColumnViewItem;
			}
			if (string.IsNullOrWhiteSpace(panelViewItem.Caption) && columnViewItem != null)
			{
				return panelViewItem.GetRenderItems();
			}
			return base.GetRenderItems(viewItem, parentViewItem);
		}
		return base.GetRenderItems(viewItem, parentViewItem);
	}

	public override bool SupportParentRender(ViewItem viewItem, ViewItem parentViewItem)
	{
		if (!(parentViewItem is ColumnViewItem))
		{
			return true;
		}
		if (!(viewItem is PanelViewItem panelViewItem) || !string.IsNullOrWhiteSpace(panelViewItem.CustomViewName) || panelViewItem.Items.Count != 1)
		{
			return false;
		}
		ColumnViewItem columnViewItem = panelViewItem.Items[0] as ColumnViewItem;
		if (columnViewItem == null && panelViewItem.Items[0] is ColumnsLayoutViewItem && ((ColumnsLayoutViewItem)panelViewItem.Items[0]).Items.Count == 1)
		{
			columnViewItem = ((ColumnsLayoutViewItem)panelViewItem.Items[0]).Items[0] as ColumnViewItem;
		}
		if (string.IsNullOrWhiteSpace(panelViewItem.Caption))
		{
			return columnViewItem != null;
		}
		return false;
	}

	public override bool IsHideEmpty(ViewItem viewItem)
	{
		return base.IsHideEmpty(viewItem);
	}
}
