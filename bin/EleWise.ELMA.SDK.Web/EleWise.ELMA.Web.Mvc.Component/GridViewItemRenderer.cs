using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Web.Mvc.Controllers;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.Web.Mvc.Components;

[Component(Order = 1000000)]
internal class GridViewItemRenderer : ViewItemRendererBase<GridViewItem>, ICountViewItemRenderer
{
	public override bool CanRender(ViewItem viewItem)
	{
		return viewItem is GridViewItem;
	}

	public override bool IsHideEmpty(ViewItem viewItem)
	{
		if (base.IsHideEmpty(viewItem))
		{
			return GridController.Count((IEntity)ViewItemRenderer.Entity, (GridViewItem)viewItem) == 0;
		}
		return false;
	}

	public override string ViewName(ViewItem viewItem)
	{
		return "ViewItems/GridViewItem";
	}

	public override string ViewNameSubItems(ViewItem viewItem)
	{
		return "ViewItems/GridViewItemSubItems";
	}

	public long? Count(object model, ICountViewItem viewItem)
	{
		if (!(model is IEntity) || !(viewItem is GridViewItem))
		{
			return null;
		}
		return GridController.Count((IEntity)model, (GridViewItem)viewItem);
	}

	public override IEnumerable<ViewItem> GetItems(ViewItem viewItem)
	{
		return Enumerable.Empty<ViewItem>();
	}
}
