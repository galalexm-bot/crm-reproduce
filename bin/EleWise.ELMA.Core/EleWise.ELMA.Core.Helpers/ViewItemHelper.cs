using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Model.Views.Extensions;

namespace EleWise.ELMA.Core.Helpers;

public static class ViewItemHelper
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<PropertyInfo, bool> _003C_003E9__6_0;

		public static Func<PropertyInfo, string> _003C_003E9__6_1;

		public static Func<ComputedValue, bool> _003C_003E9__11_3;

		public static Func<DefaultContainerViewItem, bool> _003C_003E9__11_0;

		public static Func<PanelViewItem, bool> _003C_003E9__11_1;

		public static Func<ComputedValue, bool> _003C_003E9__11_4;

		public static Func<PropertyViewItem, bool> _003C_003E9__11_2;

		internal bool _003CCopyValues_003Eb__6_0(PropertyInfo p)
		{
			return !Enumerable.Any<object>((System.Collections.Generic.IEnumerable<object>)((MemberInfo)p).GetCustomAttributes(typeof(NotResettableAttribute), true));
		}

		internal string _003CCopyValues_003Eb__6_1(PropertyInfo p)
		{
			return ((MemberInfo)p).get_Name();
		}

		internal bool _003CForceRender_003Eb__11_0(DefaultContainerViewItem d)
		{
			if (d.ReadOnly)
			{
				return Enumerable.FirstOrDefault<ComputedValue>((System.Collections.Generic.IEnumerable<ComputedValue>)d.DynamicProperties, (Func<ComputedValue, bool>)((ComputedValue a) => a.ComputedValueType != 0)) != null;
			}
			return true;
		}

		internal bool _003CForceRender_003Eb__11_3(ComputedValue a)
		{
			return a.ComputedValueType != 0;
		}

		internal bool _003CForceRender_003Eb__11_1(PanelViewItem i)
		{
			return !string.IsNullOrWhiteSpace(i.CustomViewName);
		}

		internal bool _003CForceRender_003Eb__11_2(PropertyViewItem i)
		{
			if (i.IsReadOnly() ?? false)
			{
				return Enumerable.FirstOrDefault<ComputedValue>((System.Collections.Generic.IEnumerable<ComputedValue>)i.DynamicProperties, (Func<ComputedValue, bool>)((ComputedValue a) => a.ComputedValueType != 0)) != null;
			}
			return true;
		}

		internal bool _003CForceRender_003Eb__11_4(ComputedValue a)
		{
			return a.ComputedValueType != 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public Guid uid;

		internal bool _003CGetSlot_003Eb__0(SlotViewItem i)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			return i.PlaceholderUid == uid;
		}
	}

	public static bool CheckParent(this ViewItem child, System.Type parentType)
	{
		RootViewItem parent = child.Parent;
		if (parent == null)
		{
			return false;
		}
		if (((object)parent).GetType() != parentType)
		{
			return parent.CheckParent(parentType);
		}
		return true;
	}

	public static bool CheckParent<T>(this ViewItem child)
	{
		return child.CheckParent(typeof(T));
	}

	public static bool CheckParent(this ViewItem child, Guid parentUid)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		RootViewItem parent = child.Parent;
		if (parent == null)
		{
			return false;
		}
		if (!(parent.Uid == parentUid))
		{
			return parent.CheckParent(parentUid);
		}
		return true;
	}

	public static ViewItem FindParent(this ViewItem child, System.Type parentType)
	{
		RootViewItem parent = child.Parent;
		if (parent == null)
		{
			return null;
		}
		if (((object)parent).GetType() != parentType)
		{
			return parent.FindParent(parentType);
		}
		return parent;
	}

	public static T FindParent<T>(this ViewItem child)
	{
		ViewItem viewItem = child.FindParent(typeof(T));
		if (viewItem == null)
		{
			return default(T);
		}
		return ObjectExtensions.Cast<T>((object)viewItem);
	}

	public static ViewItem FindParent(this ViewItem child, Guid parentUid)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		RootViewItem parent = child.Parent;
		if (parent == null)
		{
			return null;
		}
		if (!(parent.Uid == parentUid))
		{
			return parent.FindParent(parentUid);
		}
		return parent;
	}

	public static void CopyValues(this ViewItem target, ViewItem source)
	{
		if (target != null && source != null)
		{
			string[] array = Enumerable.Where<PropertyInfo>((System.Collections.Generic.IEnumerable<PropertyInfo>)((object)target).GetType().GetProperties((BindingFlags)20), (Func<PropertyInfo, bool>)((PropertyInfo p) => !Enumerable.Any<object>((System.Collections.Generic.IEnumerable<object>)((MemberInfo)p).GetCustomAttributes(typeof(NotResettableAttribute), true)))).Select<string>((Func<PropertyInfo, string>)((PropertyInfo p) => ((MemberInfo)p).get_Name())).ToArray();
			foreach (string text in array)
			{
				((object)target).set_Item(text, ((object)source).get_Item(text));
			}
		}
	}

	internal static SlotViewItem GetSlot(this RootViewItem viewItem, Guid uid)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		_003C_003Ec__DisplayClass7_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass7_0();
		CS_0024_003C_003E8__locals0.uid = uid;
		return Enumerable.OfType<SlotViewItem>((System.Collections.IEnumerable)viewItem.Items).FirstOrDefault((Func<SlotViewItem, bool>)((SlotViewItem i) => i.PlaceholderUid == CS_0024_003C_003E8__locals0.uid));
	}

	public static bool IsHide(this ViewItem viewItem)
	{
		if (viewItem.Hide)
		{
			return true;
		}
		if (viewItem.Parent == null)
		{
			return false;
		}
		return viewItem.Parent.IsHide();
	}

	public static bool IsDynamicViewItem(ViewItem item, out Guid propertyUid, out Guid[] propertyParents)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		propertyUid = Guid.Empty;
		propertyParents = (Guid[])(object)new Guid[0];
		if (item is IDynamicViewItem || item is TableViewItem || item is GridViewItem)
		{
			if (item is IDynamicViewItem dynamicViewItem)
			{
				propertyUid = dynamicViewItem.PropertyUid;
				propertyParents = Enumerable.ToArray<Guid>((System.Collections.Generic.IEnumerable<Guid>)dynamicViewItem.PropertyParents);
			}
			else if (item is TableViewItem tableViewItem)
			{
				propertyUid = tableViewItem.PropertyUid;
				propertyParents = Enumerable.ToArray<Guid>((System.Collections.Generic.IEnumerable<Guid>)tableViewItem.PropertyParents);
			}
			else if (item is GridViewItem gridViewItem)
			{
				propertyUid = gridViewItem.Entity;
			}
			return true;
		}
		return false;
	}

	public static bool ViewItemInDynamic(ViewItem item)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		RootViewItem parent = item.Parent;
		bool flag = false;
		while (parent != null)
		{
			if (parent is DynamicSlotViewItem)
			{
				flag = true;
			}
			if (IsDynamicViewItem(parent, out var propertyUid, out var _))
			{
				if (flag && propertyUid != Guid.Empty)
				{
					return true;
				}
				flag = false;
			}
			parent = parent.Parent;
		}
		return false;
	}

	public static bool ForceRender(RootViewItem rootViewItem)
	{
		if (rootViewItem == null)
		{
			return true;
		}
		if (rootViewItem is IDynamicViewItem)
		{
			return true;
		}
		IViewItemLoading drawerParent = GetDrawerParent(rootViewItem.Parent);
		if (drawerParent != null && drawerParent.LoadingType == ViewItemLoadingType.SyncLoading)
		{
			return true;
		}
		ViewItem[] array = Enumerable.ToArray<ViewItem>(rootViewItem.GetAllItems(ignoreHide: false));
		if (Enumerable.OfType<DefaultContainerViewItem>((System.Collections.IEnumerable)(object)array).Any((Func<DefaultContainerViewItem, bool>)((DefaultContainerViewItem d) => !d.ReadOnly || Enumerable.FirstOrDefault<ComputedValue>((System.Collections.Generic.IEnumerable<ComputedValue>)d.DynamicProperties, (Func<ComputedValue, bool>)((ComputedValue a) => a.ComputedValueType != 0)) != null)) || Enumerable.OfType<PanelViewItem>((System.Collections.IEnumerable)(object)array).Any((Func<PanelViewItem, bool>)((PanelViewItem i) => !string.IsNullOrWhiteSpace(i.CustomViewName))) || Enumerable.OfType<PropertyViewItem>((System.Collections.IEnumerable)(object)array).Any((Func<PropertyViewItem, bool>)((PropertyViewItem i) => !(i.IsReadOnly() ?? false) || Enumerable.FirstOrDefault<ComputedValue>((System.Collections.Generic.IEnumerable<ComputedValue>)i.DynamicProperties, (Func<ComputedValue, bool>)((ComputedValue a) => a.ComputedValueType != 0)) != null)))
		{
			return true;
		}
		return false;
	}

	private static IViewItemLoading GetDrawerParent(RootViewItem rootViewItem)
	{
		if (rootViewItem == null)
		{
			return null;
		}
		RootViewItem parent = rootViewItem.Parent;
		if (parent is DrawerViewItem result)
		{
			return result;
		}
		return GetDrawerParent(parent);
	}
}
