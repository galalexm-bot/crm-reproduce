using System;
using System.Collections;
using System.Collections.Generic;
using EleWise.ELMA.Core.Serialization;
using EleWise.ELMA.Model.Views.Toolbar;
using EleWise.ELMA.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace EleWise.ELMA.Model.Views.Extensions;

public static class ViewItemExtensions
{
	public static bool? IsReadOnly(this ViewItem viewItem)
	{
		return (viewItem as IReadOnlyViewItem)?.ReadOnly ?? viewItem?.Parent?.IsReadOnly();
	}

	public static void Refresh(this ViewItem viewItem, RootViewItem root)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		viewItem.Name = "";
		viewItem.Uid = Guid.Empty;
		viewItem.InitNew(root);
		if (!(viewItem is RootViewItem rootViewItem))
		{
			return;
		}
		System.Collections.Generic.IEnumerator<ViewItem> enumerator = rootViewItem.Items.GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				enumerator.get_Current().Refresh(rootViewItem);
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
	}

	public static ViewItem FindItemWithToolbar(this FormViewItem formViewItem, Guid itemUid)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		ViewItem viewItem = formViewItem.FindItem(itemUid);
		if (viewItem == null && formViewItem.Toolbar != null)
		{
			ToolbarViewItem toolbar = formViewItem.Toolbar;
			if (toolbar != null)
			{
				viewItem = ((toolbar.Uid == itemUid) ? toolbar : toolbar.FindItem(itemUid));
			}
		}
		return viewItem;
	}

	public static string Serialize(this ViewItem viewItem)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		JsonSerializerSettings val = new JsonSerializerSettings();
		val.set_TypeNameHandling((TypeNameHandling)1);
		val.set_SerializationBinder((ISerializationBinder)(object)new KnownTypesBinder());
		JsonSerializerSettings settings = val;
		return SerializationHelper.SerializeObjectByJson(viewItem, settings);
	}
}
