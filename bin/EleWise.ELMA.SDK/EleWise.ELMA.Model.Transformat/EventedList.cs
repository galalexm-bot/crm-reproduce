using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Transformations;

[Serializable]
[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(CollectionDebugView<>))]
[DataContract]
public abstract class EventedList<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable where T : class
{
	public EventHandler<EventedListEventArgs<T>> AddingItem;

	public EventHandler<EventedListEventArgs<T>> AddedItem;

	public EventHandler<EventedListEventArgs<T>> RemovingItem;

	public EventHandler<EventedListEventArgs<T>> RemovedItem;

	public EventHandler ClearingItems;

	public EventHandler ClearedItems;

	private readonly T parent;

	internal readonly List<T> items;

	private static object rTf4tyWLUCc7FRuiGdO7;

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
					RemovingItem(this, new EventedListEventArgs<T>
					{
						Item = item
					});
				}
				if (AddingItem != null)
				{
					AddingItem(this, new EventedListEventArgs<T>
					{
						Item = value
					});
				}
				SetParent(item, null);
				items[index] = value;
				SetParent(value, parent);
				if (RemovedItem != null)
				{
					RemovedItem(this, new EventedListEventArgs<T>
					{
						Item = item
					});
				}
				if (AddedItem != null)
				{
					AddedItem(this, new EventedListEventArgs<T>
					{
						Item = value
					});
				}
			}
		}
	}

	protected abstract Exception ListAddingException(T parent, T item);

	protected abstract T GetParent(T item);

	protected abstract void SetParent(T item, T parent);

	protected abstract void RemoveFromParent(T item);

	protected EventedList(T parent)
	{
		SingletonReader.JJCZtPuTvSt();
		items = new List<T>();
		base._002Ector();
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

	public IEnumerator<T> GetEnumerator()
	{
		return items.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	public void Add(T item)
	{
		if (IsParent(item, parent))
		{
			throw ListAddingException(parent, item);
		}
		if (AddingItem != null)
		{
			AddingItem(this, new EventedListEventArgs<T>
			{
				Item = item
			});
		}
		RemoveFromParent(item);
		items.Add(item);
		SetParent(item, parent);
		if (AddedItem != null)
		{
			AddedItem(this, new EventedListEventArgs<T>
			{
				Item = item
			});
		}
	}

	public void Clear()
	{
		//Discarded unreachable code: IL_00f1, IL_011b
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 4:
				ClearedItems(this, new EventArgs());
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				if (ClearingItems == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			case 1:
			case 5:
				items.ForEach(delegate(T i)
				{
					SetParent(i, null);
				});
				num2 = 3;
				continue;
			case 3:
				items.Clear();
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
				{
					num2 = 7;
				}
				continue;
			case 7:
				if (ClearedItems == null)
				{
					num2 = 8;
					continue;
				}
				goto case 4;
			case 0:
				return;
			case 8:
				return;
			case 6:
				break;
			}
			ClearingItems(this, new EventArgs());
			num2 = 5;
		}
	}

	public bool Contains(T item)
	{
		return items.Contains(item);
	}

	public void CopyTo(T[] array, int arrayIndex)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				items.CopyTo(array, arrayIndex);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public bool Remove(T item)
	{
		if (RemovingItem != null)
		{
			RemovingItem(this, new EventedListEventArgs<T>
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
			RemovedItem(this, new EventedListEventArgs<T>
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
			AddingItem(this, new EventedListEventArgs<T>
			{
				Item = item
			});
		}
		RemoveFromParent(item);
		items.Insert(index, item);
		SetParent(item, parent);
		if (AddedItem != null)
		{
			AddedItem(this, new EventedListEventArgs<T>
			{
				Item = item
			});
		}
	}

	public void RemoveAt(int index)
	{
		int num = 7;
		int num2 = num;
		T item = default(T);
		while (true)
		{
			switch (num2)
			{
			case 4:
				RemovedItem(this, new EventedListEventArgs<T>
				{
					Item = item
				});
				num2 = 2;
				break;
			case 7:
				item = items[index];
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
				{
					num2 = 6;
				}
				break;
			case 3:
				RemovingItem(this, new EventedListEventArgs<T>
				{
					Item = item
				});
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				return;
			default:
				items.RemoveAt(index);
				num2 = 5;
				break;
			case 1:
				SetParent(item, null);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
				{
					num2 = 0;
				}
				break;
			case 6:
				if (RemovingItem != null)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
					{
						num2 = 3;
					}
					break;
				}
				goto case 1;
			case 5:
				if (RemovedItem == null)
				{
					return;
				}
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
				{
					num2 = 3;
				}
				break;
			}
		}
	}

	internal static bool PfLwvKWLsfaGqqeDqQ2f()
	{
		return rTf4tyWLUCc7FRuiGdO7 == null;
	}

	internal static object LQbEqfWLcN11DlCrS3SS()
	{
		return rTf4tyWLUCc7FRuiGdO7;
	}
}
