using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Transformations;

namespace EleWise.ELMA.Model.Views;

public abstract class RootViewItem : ViewItem, IReadOnlyViewItem, IHideEmptyViewItem
{
	private sealed class _003C_003Ec__DisplayClass22_0<T> where T : ViewItem
	{
		public Func<T, bool> condition;

		internal bool _003CFindItem_003Eb__0(ViewItem item)
		{
			if (item is T)
			{
				return condition.Invoke((T)item);
			}
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass40_0
	{
		public Guid itemUid;

		internal bool _003CFindItem_003Eb__0(ViewItem item)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			return item.Uid == itemUid;
		}
	}

	private sealed class _003C_003Ec__DisplayClass43_0
	{
		public bool ignoreHide;

		public Func<ViewItem, bool> itemCondition;

		public Func<ViewItem, bool> deepCondition;

		internal bool _003CFindItems_003Eb__0(ViewItem i)
		{
			if (ignoreHide)
			{
				return !i.Hide;
			}
			return true;
		}

		internal System.Collections.Generic.IEnumerable<ViewItem> _003CFindItems_003Eb__1(ViewItem i)
		{
			_003C_003Ec__DisplayClass43_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass43_1();
			CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1 = this;
			CS_0024_003C_003E8__locals0.i = i;
			return ((System.Collections.Generic.IEnumerable<ViewItem>)Enumerable.Empty<ViewItem>()).If(itemCondition == null || itemCondition.Invoke(CS_0024_003C_003E8__locals0.i), (System.Collections.Generic.IEnumerable<ViewItem> enumerable) => (System.Collections.Generic.IEnumerable<ViewItem>)Enumerable.Concat<ViewItem>(enumerable, (System.Collections.Generic.IEnumerable<ViewItem>)new ViewItem[1] { CS_0024_003C_003E8__locals0.i })).If(deepCondition == null || deepCondition.Invoke(CS_0024_003C_003E8__locals0.i), (System.Collections.Generic.IEnumerable<ViewItem> enumerable) => (System.Collections.Generic.IEnumerable<ViewItem>)Enumerable.Concat<ViewItem>(enumerable, FindItems(CS_0024_003C_003E8__locals0.i, CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.ignoreHide, CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.itemCondition, CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.deepCondition)));
		}
	}

	private sealed class _003C_003Ec__DisplayClass43_1
	{
		public ViewItem i;

		public _003C_003Ec__DisplayClass43_0 CS_0024_003C_003E8__locals1;

		internal System.Collections.Generic.IEnumerable<ViewItem> _003CFindItems_003Eb__2(System.Collections.Generic.IEnumerable<ViewItem> enumerable)
		{
			return (System.Collections.Generic.IEnumerable<ViewItem>)Enumerable.Concat<ViewItem>(enumerable, (System.Collections.Generic.IEnumerable<ViewItem>)new ViewItem[1] { i });
		}

		internal System.Collections.Generic.IEnumerable<ViewItem> _003CFindItems_003Eb__3(System.Collections.Generic.IEnumerable<ViewItem> enumerable)
		{
			return (System.Collections.Generic.IEnumerable<ViewItem>)Enumerable.Concat<ViewItem>(enumerable, FindItems(i, CS_0024_003C_003E8__locals1.ignoreHide, CS_0024_003C_003E8__locals1.itemCondition, CS_0024_003C_003E8__locals1.deepCondition));
		}
	}

	private readonly ListViewItem _003CItems_003Ek__BackingField;

	private bool? _003CReadOnly_003Ek__BackingField;

	private Guid? _003CMetadataUid_003Ek__BackingField;

	private HideEmptyEnum _003CHideEmpty_003Ek__BackingField;

	private System.Collections.Generic.IEnumerable<ViewItem> oldItems;

	[NotResettable]
	public ListViewItem Items => _003CItems_003Ek__BackingField;

	[DynamicProperty(false)]
	public virtual bool? ReadOnly
	{
		get
		{
			return _003CReadOnly_003Ek__BackingField;
		}
		set
		{
			_003CReadOnly_003Ek__BackingField = value;
		}
	}

	public Guid? MetadataUid
	{
		get
		{
			return _003CMetadataUid_003Ek__BackingField;
		}
		set
		{
			_003CMetadataUid_003Ek__BackingField = value;
		}
	}

	public virtual bool ReadOnlyEnabled => true;

	public HideEmptyEnum HideEmpty
	{
		get
		{
			return _003CHideEmpty_003Ek__BackingField;
		}
		set
		{
			_003CHideEmpty_003Ek__BackingField = value;
		}
	}

	public virtual bool IsHideable => false;

	public ViewItem FindItem(Guid itemUid)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return FindItem(this, itemUid);
	}

	public T FindItem<T>(Guid itemUid) where T : ViewItem
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return FindItem(this, itemUid) as T;
	}

	public ViewItem FindItem(Func<ViewItem, bool> condition)
	{
		return FindItem(this, condition);
	}

	public T FindItem<T>(Func<T, bool> condition) where T : ViewItem
	{
		_003C_003Ec__DisplayClass22_0<T> CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass22_0<T>();
		CS_0024_003C_003E8__locals0.condition = condition;
		return FindItem((ViewItem)this, (Func<ViewItem, bool>)((ViewItem item) => item is T && CS_0024_003C_003E8__locals0.condition.Invoke((T)item))) as T;
	}

	public System.Collections.Generic.IEnumerable<ViewItem> GetAllItems(bool ignoreHide = true)
	{
		return FindItems(this, ignoreHide, null, null);
	}

	public System.Collections.Generic.IEnumerable<ViewItem> FindItems(bool ignoreHide = true, Func<ViewItem, bool> itemCondition = null, Func<ViewItem, bool> deepCondition = null)
	{
		return FindItems(this, ignoreHide, itemCondition, deepCondition);
	}

	public override bool IsEmpty()
	{
		if (Items != null)
		{
			System.Collections.Generic.IEnumerator<ViewItem> enumerator = Items.GetEnumerator();
			try
			{
				while (((System.Collections.IEnumerator)enumerator).MoveNext())
				{
					ViewItem current = enumerator.get_Current();
					if (current.Hide || !current.IsEmpty())
					{
						return false;
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator)?.Dispose();
			}
		}
		return true;
	}

	protected internal override void SetReadOnly()
	{
		System.Collections.Generic.IEnumerator<ViewItem> enumerator = Items.GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				enumerator.get_Current().SetReadOnly();
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
	}

	protected RootViewItem()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		_003CItems_003Ek__BackingField = new ListViewItem();
		Items.SetParent(this);
		ListViewItem items = Items;
		items.ClearingItems = (EventHandler)System.Delegate.Combine((System.Delegate)(object)items.ClearingItems, (System.Delegate)new EventHandler(ClearingItems));
		ListViewItem items2 = Items;
		items2.ClearedItems = (EventHandler)System.Delegate.Combine((System.Delegate)(object)items2.ClearedItems, (System.Delegate)new EventHandler(ClearedItems));
		ListViewItem items3 = Items;
		items3.AddingItem = (EventHandler<EventedListEventArgs<ViewItem>>)(object)System.Delegate.Combine((System.Delegate)(object)items3.AddingItem, (System.Delegate)(object)new EventHandler<EventedListEventArgs<ViewItem>>(AddingItem));
		ListViewItem items4 = Items;
		items4.AddedItem = (EventHandler<EventedListEventArgs<ViewItem>>)(object)System.Delegate.Combine((System.Delegate)(object)items4.AddedItem, (System.Delegate)(object)new EventHandler<EventedListEventArgs<ViewItem>>(AddedItem));
		ListViewItem items5 = Items;
		items5.RemovingItem = (EventHandler<EventedListEventArgs<ViewItem>>)(object)System.Delegate.Combine((System.Delegate)(object)items5.RemovingItem, (System.Delegate)(object)new EventHandler<EventedListEventArgs<ViewItem>>(RemovingItem));
		ListViewItem items6 = Items;
		items6.RemovedItem = (EventHandler<EventedListEventArgs<ViewItem>>)(object)System.Delegate.Combine((System.Delegate)(object)items6.RemovedItem, (System.Delegate)(object)new EventHandler<EventedListEventArgs<ViewItem>>(RemovedItem));
	}

	private void ClearingItems(object sender, EventArgs eventArgs)
	{
		System.Collections.Generic.IEnumerator<ViewItem> enumerator = Items.GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				enumerator.get_Current().OnRemoving(this);
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		oldItems = Enumerable.ToArray<ViewItem>((System.Collections.Generic.IEnumerable<ViewItem>)Items);
	}

	private void ClearedItems(object sender, EventArgs eventArgs)
	{
		System.Collections.Generic.IEnumerator<ViewItem> enumerator = oldItems.GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				enumerator.get_Current().OnRemoved(this);
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
	}

	private void AddingItem(object sender, EventedListEventArgs<ViewItem> listViewItemEventArgs)
	{
		listViewItemEventArgs.Item.OnAdding(this);
	}

	private void AddedItem(object sender, EventedListEventArgs<ViewItem> listViewItemEventArgs)
	{
		listViewItemEventArgs.Item.OnAdded(this);
	}

	private void RemovingItem(object sender, EventedListEventArgs<ViewItem> listViewItemEventArgs)
	{
		listViewItemEventArgs.Item.OnRemoving(this);
	}

	private void RemovedItem(object sender, EventedListEventArgs<ViewItem> listViewItemEventArgs)
	{
		listViewItemEventArgs.Item.OnRemoved(this);
	}

	public override void OnAdding(RootViewItem parent)
	{
		base.OnAdding(parent);
		System.Collections.Generic.IEnumerator<ViewItem> enumerator = Items.GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				enumerator.get_Current().OnAdding(parent);
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
	}

	public override void OnAdded(RootViewItem parent)
	{
		base.OnAdded(parent);
		System.Collections.Generic.IEnumerator<ViewItem> enumerator = Items.GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				enumerator.get_Current().OnAdded(parent);
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
	}

	public override void OnRemoving(RootViewItem parent)
	{
		System.Collections.Generic.IEnumerator<ViewItem> enumerator = Items.GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				enumerator.get_Current().OnRemoving(parent);
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		base.OnRemoving(parent);
	}

	public override void OnRemoved(RootViewItem parent)
	{
		System.Collections.Generic.IEnumerator<ViewItem> enumerator = Items.GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				enumerator.get_Current().OnRemoved(parent);
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		base.OnRemoved(parent);
	}

	internal static ViewItem FindItem(ViewItem viewItem, Guid itemUid)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		RootViewItem container;
		return FindItem(viewItem, itemUid, out container);
	}

	internal static ViewItem FindItem(ViewItem viewItem, Guid itemUid, out RootViewItem container)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		_003C_003Ec__DisplayClass40_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass40_0();
		CS_0024_003C_003E8__locals0.itemUid = itemUid;
		return FindItem(viewItem, (Func<ViewItem, bool>)((ViewItem item) => item.Uid == CS_0024_003C_003E8__locals0.itemUid), out container);
	}

	internal static ViewItem FindItem(ViewItem viewItem, Func<ViewItem, bool> condition)
	{
		RootViewItem container;
		return FindItem(viewItem, condition, out container);
	}

	internal static ViewItem FindItem(ViewItem viewItem, Func<ViewItem, bool> condition, out RootViewItem container)
	{
		container = null;
		if (condition == null)
		{
			return null;
		}
		if (condition.Invoke(viewItem))
		{
			return viewItem;
		}
		RootViewItem rootViewItem = viewItem as RootViewItem;
		if (rootViewItem?.Items == null)
		{
			return null;
		}
		System.Collections.Generic.IEnumerator<ViewItem> enumerator = rootViewItem.Items.GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				ViewItem viewItem2 = FindItem(enumerator.get_Current(), condition, out container);
				if (viewItem2 != null)
				{
					if (container == null)
					{
						container = rootViewItem;
					}
					return viewItem2;
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		return null;
	}

	private static System.Collections.Generic.IEnumerable<ViewItem> FindItems(ViewItem viewItem, bool ignoreHide, Func<ViewItem, bool> itemCondition, Func<ViewItem, bool> deepCondition)
	{
		_003C_003Ec__DisplayClass43_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass43_0();
		CS_0024_003C_003E8__locals0.ignoreHide = ignoreHide;
		CS_0024_003C_003E8__locals0.itemCondition = itemCondition;
		CS_0024_003C_003E8__locals0.deepCondition = deepCondition;
		if (!(viewItem is RootViewItem rootViewItem))
		{
			return new ViewItem[0];
		}
		return (System.Collections.Generic.IEnumerable<ViewItem>)Enumerable.Where<ViewItem>((System.Collections.Generic.IEnumerable<ViewItem>)rootViewItem.Items, (Func<ViewItem, bool>)((ViewItem i) => !CS_0024_003C_003E8__locals0.ignoreHide || !i.Hide)).SelectMany<ViewItem>((Func<ViewItem, System.Collections.Generic.IEnumerable<ViewItem>>)delegate(ViewItem i)
		{
			CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass43_1();
			CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1 = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.i = i;
			return ((System.Collections.Generic.IEnumerable<ViewItem>)Enumerable.Empty<ViewItem>()).If(CS_0024_003C_003E8__locals0.itemCondition == null || CS_0024_003C_003E8__locals0.itemCondition.Invoke(CS_0024_003C_003E8__locals0.i), (System.Collections.Generic.IEnumerable<ViewItem> enumerable) => (System.Collections.Generic.IEnumerable<ViewItem>)Enumerable.Concat<ViewItem>(enumerable, (System.Collections.Generic.IEnumerable<ViewItem>)new ViewItem[1] { CS_0024_003C_003E8__locals0.i })).If(CS_0024_003C_003E8__locals0.deepCondition == null || CS_0024_003C_003E8__locals0.deepCondition.Invoke(CS_0024_003C_003E8__locals0.i), (System.Collections.Generic.IEnumerable<ViewItem> enumerable) => (System.Collections.Generic.IEnumerable<ViewItem>)Enumerable.Concat<ViewItem>(enumerable, FindItems(CS_0024_003C_003E8__locals0.i, CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.ignoreHide, CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.itemCondition, CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.deepCondition)));
		});
	}
}
