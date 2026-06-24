using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Models;

namespace EleWise.ELMA.Web.Mvc.Components;

[Component]
public abstract class PropertyViewItemRenderer<T> : PropertyViewItemRenderer where T : PropertyViewItem
{
	public override bool CanRender(ViewItem viewItem)
	{
		return viewItem.GetType() == typeof(T);
	}
}
[Component]
public class PropertyViewItemRenderer : ViewItemRendererBase<PropertyViewItem>
{
	public override bool? IsEmpty(ViewItem viewItem)
	{
		IEnumerable<IPropertyIsEmptyOrDefault> extensionPoints = ComponentManager.Current.GetExtensionPoints<IPropertyIsEmptyOrDefault>();
		ObjectViewData current = ObjectViewData.GetCurrent();
		if (current == null)
		{
			throw new Exception(SR.T("Не удалось получить текущий объект"));
		}
		foreach (IPropertyIsEmptyOrDefault item in extensionPoints)
		{
			if (item.IsEmptyOrDefault(viewItem as PropertyViewItem, current.Model, current.Metadata as EntityMetadata) == false)
			{
				return false;
			}
		}
		return true;
	}

	public override bool SupportParentRender(ViewItem viewItem, ViewItem parentViewItem)
	{
		return parentViewItem is ColumnViewItem;
	}

	public override IEnumerable<ViewItem> GetRenderItems(ViewItem viewItem, ViewItem parentViewItem)
	{
		Adjust((PropertyViewItem)viewItem);
		yield return viewItem;
	}

	public override bool IsHideEmpty(ViewItem viewItem)
	{
		return false;
	}

	public static void Adjust(PropertyViewItem propertyViewItem)
	{
		ContextVars.GetOrAdd(string.Concat("IsItemAdjusted_", propertyViewItem.Uid, "_", ViewItemRenderer.ViewType, "_", (ViewItemRenderer.Entity != null) ? new int?(ViewItemRenderer.Entity.GetHashCode()) : null), delegate
		{
			ComponentManager.Current.GetExtensionPoints<IPropertyViewItemAdjustment>().Each(delegate(IPropertyViewItemAdjustment p)
			{
				p.Adjust(propertyViewItem, ViewItemRenderer.Entity, ViewItemRenderer.ViewType);
			});
			return true;
		});
	}
}
