using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Views.ViewItem;

namespace EleWise.ELMA.Web.Mvc.ExtensionPoints;

public abstract class ViewItemRenderer : IViewItemRenderer, IViewItemRendererCheckEmpty
{
	protected static ViewType ViewType => ViewItemControl<FormViewItem, object, object>.ViewType;

	protected static ItemType ItemType => FormViewItemControl.ItemType;

	protected static object Entity => FormViewItemControl.Entity;

	public abstract bool CanRender(ViewItem viewItem);

	public abstract MvcHtmlString Render(HtmlHelper html, ViewItem viewItem, object model);

	public virtual MvcHtmlString RenderSubItems(HtmlHelper html, ViewItem viewItem, object model)
	{
		return MvcHtmlString.Empty;
	}

	public virtual bool SupportParentRender(ViewItem viewItem, ViewItem parentViewItem)
	{
		return false;
	}

	public virtual IEnumerable<ViewItem> GetRenderItems(ViewItem viewItem, ViewItem parentViewItem)
	{
		yield return viewItem;
	}

	public virtual IEnumerable<ViewItem> GetItems(ViewItem viewItem)
	{
		if (!(viewItem is RootViewItem rootViewItem))
		{
			return Enumerable.Empty<ViewItem>();
		}
		return rootViewItem.Items.Where((ViewItem i) => !i.Hide);
	}

	public virtual bool IsHideEmpty(ViewItem viewItem)
	{
		if (viewItem is IHideEmptyViewItem)
		{
			return ((IHideEmptyViewItem)viewItem).IsHideEmpty();
		}
		return false;
	}

	public virtual bool IgnoreOnHideEmpty(ViewItem viewItem)
	{
		return false;
	}

	public virtual bool? IsEmpty(ViewItem viewItem)
	{
		IEnumerable<ViewItem> items = GetItems(viewItem);
		if (items != null)
		{
			foreach (ViewItem item in items)
			{
				if (!item.IsEmpty())
				{
					return false;
				}
			}
		}
		return true;
	}
}
