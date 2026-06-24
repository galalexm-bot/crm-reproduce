using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using Bridge;
using EleWise.ELMA.Collections;

namespace EleWise.ELMA.Model.Transformations;

[DefaultMember("Item")]
public abstract class EventedList<T> : IReactiveCollection<T>, System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, IBridgeClass where T : class
{
	public EventHandler<EventedListEventArgs<T>> AddingItem;

	public EventHandler<EventedListEventArgs<T>> AddedItem;

	public EventHandler<EventedListEventArgs<T>> RemovingItem;

	public EventHandler<EventedListEventArgs<T>> RemovedItem;

	public EventHandler ClearingItems;

	public EventHandler ClearedItems;

	private T parent;

	internal readonly ReactiveCollection<T> items = new ReactiveCollection<T>();

	public int Count => items.Count;

	public bool IsReadOnly => false;

	public T this[int index]
	{
		get
		{
			return items[index];
		}
		set
		{
			if (items[index] != value)
			{
				T item = items[index];
				if (RemovingItem != null)
				{
					((EventHandler<EventedListEventArgs<EventedListEventArgs<T>>>)(object)RemovingItem).Invoke((object)this, (EventedListEventArgs<EventedListEventArgs<T>>)(object)new EventedListEventArgs<T>
					{
						Item = item
					});
				}
				if (AddingItem != null)
				{
					((EventHandler<EventedListEventArgs<EventedListEventArgs<T>>>)(object)AddingItem).Invoke((object)this, (EventedListEventArgs<EventedListEventArgs<T>>)(object)new EventedListEventArgs<T>
					{
						Item = value
					});
				}
				SetParent(item, null);
				items[index] = value;
				SetParent(value, parent);
				if (RemovedItem != null)
				{
					((EventHandler<EventedListEventArgs<EventedListEventArgs<T>>>)(object)RemovedItem).Invoke((object)this, (EventedListEventArgs<EventedListEventArgs<T>>)(object)new EventedListEventArgs<T>
					{
						Item = item
					});
				}
				if (AddedItem != null)
				{
					((EventHandler<EventedListEventArgs<EventedListEventArgs<T>>>)(object)AddedItem).Invoke((object)this, (EventedListEventArgs<EventedListEventArgs<T>>)(object)new EventedListEventArgs<T>
					{
						Item = value
					});
				}
			}
		}
	}

	protected abstract System.Exception ListAddingException(T parent, T item);

	protected abstract T GetParent(T item);

	protected abstract void SetParent(T item, T parent);

	protected abstract void RemoveFromParent(T item);

	public void SetParent(T parent)
	{
		this.parent = parent;
	}

	private bool IsParent(T parent, T item)
	{
		if (item != parent)
		{
			T item2;
			if ((item2 = GetParent(item)) != null)
			{
				return IsParent(parent, item2);
			}
			return false;
		}
		return true;
	}

	public System.Collections.Generic.IEnumerator<T> GetEnumerator()
	{
		return items.GetEnumerator();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return (System.Collections.IEnumerator)GetEnumerator();
	}

	public void Add(T item)
	{
		if (IsParent(item, parent))
		{
			throw ListAddingException(parent, item);
		}
		if (AddingItem != null)
		{
			((EventHandler<EventedListEventArgs<EventedListEventArgs<T>>>)(object)AddingItem).Invoke((object)this, (EventedListEventArgs<EventedListEventArgs<T>>)(object)new EventedListEventArgs<T>
			{
				Item = item
			});
		}
		RemoveFromParent(item);
		items.Add(item);
		SetParent(item, parent);
		if (AddedItem != null)
		{
			((EventHandler<EventedListEventArgs<EventedListEventArgs<T>>>)(object)AddedItem).Invoke((object)this, (EventedListEventArgs<EventedListEventArgs<T>>)(object)new EventedListEventArgs<T>
			{
				Item = item
			});
		}
	}

	public void Clear()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		if (ClearingItems != null)
		{
			ClearingItems.Invoke((object)this, new EventArgs());
		}
		System.Collections.Generic.IEnumerator<T> enumerator = items.GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				T current = enumerator.get_Current();
				SetParent(current, null);
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		items.Clear();
		if (ClearedItems != null)
		{
			ClearedItems.Invoke((object)this, new EventArgs());
		}
	}

	public bool Contains(T item)
	{
		return items.Contains(item);
	}

	public void CopyTo(T[] array, int arrayIndex)
	{
		items.CopyTo(array, arrayIndex);
	}

	public bool Remove(T item)
	{
		if (RemovingItem != null)
		{
			((EventHandler<EventedListEventArgs<EventedListEventArgs<T>>>)(object)RemovingItem).Invoke((object)this, (EventedListEventArgs<EventedListEventArgs<T>>)(object)new EventedListEventArgs<T>
			{
				Item = item
			});
		}
		bool num = items.Remove(item);
		if (num)
		{
			SetParent(item, null);
		}
		if (RemovedItem != null)
		{
			((EventHandler<EventedListEventArgs<EventedListEventArgs<T>>>)(object)RemovedItem).Invoke((object)this, (EventedListEventArgs<EventedListEventArgs<T>>)(object)new EventedListEventArgs<T>
			{
				Item = item
			});
		}
		return num;
	}

	public int IndexOf(T item)
	{
		return items.IndexOf(item);
	}

	public void Insert(int index, T item)
	{
		if (IsParent(item, parent))
		{
			throw ListAddingException(parent, item);
		}
		if (GetParent(item) == parent)
		{
			int num = items.IndexOf(item);
			if (num == index)
			{
				return;
			}
			if (num < index)
			{
				index--;
			}
		}
		if (AddingItem != null)
		{
			((EventHandler<EventedListEventArgs<EventedListEventArgs<T>>>)(object)AddingItem).Invoke((object)this, (EventedListEventArgs<EventedListEventArgs<T>>)(object)new EventedListEventArgs<T>
			{
				Item = item
			});
		}
		RemoveFromParent(item);
		items.Insert(index, item);
		SetParent(item, parent);
		if (AddedItem != null)
		{
			((EventHandler<EventedListEventArgs<EventedListEventArgs<T>>>)(object)AddedItem).Invoke((object)this, (EventedListEventArgs<EventedListEventArgs<T>>)(object)new EventedListEventArgs<T>
			{
				Item = item
			});
		}
	}

	public T[] RemoveAt(int index)
	{
		T item = items[index];
		if (RemovingItem != null)
		{
			((EventHandler<EventedListEventArgs<EventedListEventArgs<T>>>)(object)RemovingItem).Invoke((object)this, (EventedListEventArgs<EventedListEventArgs<T>>)(object)new EventedListEventArgs<T>
			{
				Item = item
			});
		}
		SetParent(item, null);
		T[] result = items.RemoveAt(index);
		if (RemovedItem != null)
		{
			((EventHandler<EventedListEventArgs<EventedListEventArgs<T>>>)(object)RemovedItem).Invoke((object)this, (EventedListEventArgs<EventedListEventArgs<T>>)(object)new EventedListEventArgs<T>
			{
				Item = item
			});
		}
		return result;
	}

	public void AddRange(System.Collections.Generic.IEnumerable<T> collection)
	{
		items.AddRange(collection);
	}

	public int Add(object item)
	{
		Add((T)item);
		return items.Count;
	}

	public bool Contains(object item)
	{
		return Contains((T)item);
	}

	public int IndexOf(object item)
	{
		return IndexOf((T)item);
	}

	public void Insert(int index, object item)
	{
		Insert(index, (T)item);
	}

	public void Remove(object item)
	{
		Remove((T)item);
	}

	public void CopyTo(System.Array array, int arrayIndex)
	{
		CopyTo((T[])array, arrayIndex);
	}
}
