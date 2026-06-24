using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Components;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Models;
using EleWise.ELMA.Web.Mvc.Views.ViewItem;

namespace EleWise.ELMA.Web.Mvc.Extensions;

public static class ViewItemExtensions
{
	[NotNull]
	private static IViewItemRenderer GetRenderer(this ViewItem viewItem)
	{
		IViewItemRenderer orAdd = ContextVars.GetOrAdd("ViewItemRenderer_" + viewItem.Uid, () => ComponentManager.Current.GetExtensionPoints<IViewItemRenderer>().FirstOrDefault((IViewItemRenderer p) => p.CanRender(viewItem)));
		if (orAdd == null)
		{
			throw new Exception(SR.T("Не найдена точка расширения для отрисовки элемента представления формы {0}", viewItem.GetType()));
		}
		return orAdd;
	}

	public static bool IsEmpty(this ViewItem viewItem)
	{
		if (!(viewItem.GetRenderer() is IViewItemRendererCheckEmpty viewItemRendererCheckEmpty))
		{
			return false;
		}
		return viewItemRendererCheckEmpty.IsEmpty(viewItem) ?? false;
	}

	public static IEnumerable<ViewItem> GetRenderItems(this ViewItem viewItem)
	{
		return ContextVars.GetOrAdd(string.Concat("GetRenderItems_", (viewItem.FormViewItem != null) ? new Guid?(viewItem.FormViewItem.Uid) : null, "_", viewItem.Uid, "_", ViewItemControl<FormViewItem, object, object>.ViewType, "_", FormViewItemControl.ItemType, "_", (FormViewItemControl.Entity != null) ? new int?(FormViewItemControl.Entity.GetHashCode()) : null), () => (from item in viewItem.GetRenderer().GetItems(viewItem).SelectMany((ViewItem item) => item.GetRenderer().GetRenderItems(item, viewItem))
			where !item.Hide && (!item.GetRenderer().IsHideEmpty(item) || !item.GetRenderItems().All((ViewItem i) => i.GetRenderer().IgnoreOnHideEmpty(i)))
			select item).ToArray());
	}

	public static long? Count(this ICountViewItem viewItem, object model)
	{
		if (!(((ViewItem)viewItem).GetRenderer() is ICountViewItemRenderer countViewItemRenderer))
		{
			return null;
		}
		return countViewItemRenderer.Count(model, viewItem);
	}

	[Obsolete]
	public static void Adjust(this PropertyViewItem propertyViewItem)
	{
		PropertyViewItemRenderer.Adjust(propertyViewItem);
	}

	[Obsolete]
	public static bool HasItems(this RootViewItem rootViewItem)
	{
		return rootViewItem.GetRenderItems().Any();
	}

	public static RootViewItem GetViewItem(this ObjectViewData data)
	{
		if (data == null)
		{
			return null;
		}
		IObjectViewItemProvider objectViewItemProvider = ComponentManager.Current.GetExtensionPoints<IObjectViewItemProvider>().FirstOrDefault((IObjectViewItemProvider p) => p.ProviderUid == data.ViewProviderUid);
		if (objectViewItemProvider == null)
		{
			return null;
		}
		return objectViewItemProvider.GetViewItem(data.ViewItemId) as RootViewItem;
	}

	public static T GetViewItem<T>(this ObjectViewData data, Guid? viewItemUid, ViewItemTransformation viewItemTransformation = null) where T : ViewItem
	{
		if (!viewItemUid.HasValue)
		{
			return null;
		}
		RootViewItem viewItem = data.GetViewItem();
		if (viewItem == null)
		{
			return null;
		}
		ViewItem viewItem2 = viewItem.FindItem(viewItemUid.Value);
		if (viewItem2 != null && viewItemTransformation != null)
		{
			viewItem2 = viewItem2.Transformate(viewItemTransformation);
		}
		return viewItem2 as T;
	}
}
