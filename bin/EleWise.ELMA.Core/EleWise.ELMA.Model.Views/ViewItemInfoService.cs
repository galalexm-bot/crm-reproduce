using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Core.ComponentModel;

namespace EleWise.ELMA.Model.Views;

[Service]
internal sealed class ViewItemInfoService : IViewItemInfoService
{
	private sealed class _003C_003Ec__DisplayClass2_0
	{
		public System.Type viewItemType;

		internal bool _003CGetInfo_003Eb__0(ViewItemTypeInfo i)
		{
			return i.ViewItemType == viewItemType;
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<IViewItem, System.Type> _003C_003E9__4_0;

		public static Func<System.Type, bool> _003C_003E9__4_1;

		public static Func<ViewItemTypeInfo, string> _003C_003E9__5_0;

		public static Func<Grouping<string, ViewItemTypeInfo>, bool> _003C_003E9__5_1;

		public static Func<Grouping<string, ViewItemTypeInfo>, System.Collections.Generic.IEnumerable<ViewItemTypeInfo>> _003C_003E9__5_2;

		public static Func<ViewItemTypeInfo, string> _003C_003E9__5_3;

		internal System.Type _003CInitComplete_003Eb__4_0(IViewItem vi)
		{
			return ((object)vi).GetType();
		}

		internal bool _003CInitComplete_003Eb__4_1(System.Type t)
		{
			if (typeof(ViewItem).IsAssignableFrom(t) && !t.get_IsAbstract())
			{
				return !t.get_IsGenericTypeDefinition();
			}
			return false;
		}

		internal string _003CUpdateInfos_003Eb__5_0(ViewItemTypeInfo i)
		{
			return i.originalName;
		}

		internal bool _003CUpdateInfos_003Eb__5_1(Grouping<string, ViewItemTypeInfo> g)
		{
			return ((EnumerableInstance<ViewItemTypeInfo>)(object)g).Count() > 1;
		}

		internal System.Collections.Generic.IEnumerable<ViewItemTypeInfo> _003CUpdateInfos_003Eb__5_2(Grouping<string, ViewItemTypeInfo> g)
		{
			return (System.Collections.Generic.IEnumerable<ViewItemTypeInfo>)g;
		}

		internal string _003CUpdateInfos_003Eb__5_3(ViewItemTypeInfo i)
		{
			return i.Name;
		}
	}

	private readonly System.Collections.Generic.IEnumerable<IViewItem> _viewItems;

	private List<ViewItemTypeInfo> viewItemTypes = new List<ViewItemTypeInfo>();

	public ViewItemInfoService(System.Collections.Generic.IEnumerable<IViewItem> viewItems)
	{
		_viewItems = viewItems;
		InitComplete();
	}

	public ViewItemTypeInfo GetInfo(System.Type viewItemType)
	{
		_003C_003Ec__DisplayClass2_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass2_0();
		CS_0024_003C_003E8__locals0.viewItemType = viewItemType;
		ViewItemTypeInfo viewItemTypeInfo = Enumerable.FirstOrDefault<ViewItemTypeInfo>((System.Collections.Generic.IEnumerable<ViewItemTypeInfo>)viewItemTypes, (Func<ViewItemTypeInfo, bool>)((ViewItemTypeInfo i) => i.ViewItemType == CS_0024_003C_003E8__locals0.viewItemType));
		if (viewItemTypeInfo != null)
		{
			return viewItemTypeInfo;
		}
		lock (viewItemTypes)
		{
			viewItemTypeInfo = new ViewItemTypeInfo(CS_0024_003C_003E8__locals0.viewItemType);
			viewItemTypes.Add(viewItemTypeInfo);
			UpdateInfos();
			return viewItemTypeInfo;
		}
	}

	private void InitComplete()
	{
		lock (viewItemTypes)
		{
			System.Collections.Generic.IEnumerator<System.Type> enumerator = Enumerable.Select<IViewItem, System.Type>(_viewItems, (Func<IViewItem, System.Type>)((IViewItem vi) => ((object)vi).GetType())).Where((Func<System.Type, bool>)((System.Type t) => typeof(ViewItem).IsAssignableFrom(t) && !t.get_IsAbstract() && !t.get_IsGenericTypeDefinition())).GetEnumerator();
			try
			{
				while (((System.Collections.IEnumerator)enumerator).MoveNext())
				{
					System.Type current = enumerator.get_Current();
					viewItemTypes.Add(new ViewItemTypeInfo(current));
				}
			}
			finally
			{
				((System.IDisposable)enumerator)?.Dispose();
			}
			UpdateInfos();
		}
	}

	private void UpdateInfos()
	{
		System.Collections.Generic.IEnumerator<ViewItemTypeInfo> enumerator = Enumerable.GroupBy<ViewItemTypeInfo, string>((System.Collections.Generic.IEnumerable<ViewItemTypeInfo>)viewItemTypes, (Func<ViewItemTypeInfo, string>)((ViewItemTypeInfo i) => i.originalName)).Where((Func<Grouping<string, ViewItemTypeInfo>, bool>)((Grouping<string, ViewItemTypeInfo> g) => ((EnumerableInstance<ViewItemTypeInfo>)(object)g).Count() > 1)).SelectMany<ViewItemTypeInfo>((Func<Grouping<string, ViewItemTypeInfo>, System.Collections.Generic.IEnumerable<ViewItemTypeInfo>>)((Grouping<string, ViewItemTypeInfo> g) => (System.Collections.Generic.IEnumerable<ViewItemTypeInfo>)g))
			.GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				ViewItemTypeInfo current = enumerator.get_Current();
				current.name = current.originalName + " (" + current.ViewItemType.get_Name() + ")";
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		viewItemTypes = ((EnumerableInstance<ViewItemTypeInfo>)(object)Enumerable.OrderBy<ViewItemTypeInfo, string>((System.Collections.Generic.IEnumerable<ViewItemTypeInfo>)viewItemTypes, (Func<ViewItemTypeInfo, string>)((ViewItemTypeInfo i) => i.Name))).ToList();
	}
}
