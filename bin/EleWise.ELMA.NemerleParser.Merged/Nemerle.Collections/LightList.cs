using System.Collections.Generic;
using Nemerle.Core;

namespace Nemerle.Collections;

public struct LightList<T>
{
	public struct Enumerator
	{
		private readonly LightList<T> _list;

		private int _i;

		public T Current { get; private set; }

		public Enumerator(LightList<T> list)
		{
			_list = list;
			_i = -1;
		}

		public bool MoveNext()
		{
			int result;
			checked
			{
				_i++;
				if (_i == 0 && _list._hasFirstItem)
				{
					Current = _list._firstItem;
					result = 1;
				}
				else if (_list._data != null)
				{
					if (_i < _list._data.Count)
					{
						Current = _list._data[_i];
						result = 1;
					}
					else
					{
						result = 0;
					}
				}
				else
				{
					result = 0;
				}
			}
			return (byte)result != 0;
		}

		public void Reset()
		{
			_i = -1;
		}
	}

	private List<T> _data;

	private T _firstItem;

	private bool _hasFirstItem;

	public T FirstItem => _firstItem;

	public int Count => (_data != null) ? _data.Count : (_hasFirstItem ? 1 : 0);

	public T this[int index]
	{
		get
		{
			T result;
			if (index == 0 && _hasFirstItem)
			{
				result = _firstItem;
			}
			else
			{
				if (_data == null)
				{
					throw new AssertionException("lib\\LightList.n", 67, "_data != null", "Index out of range");
				}
				result = _data[index];
			}
			return result;
		}
	}

	private void Init()
	{
		if (_data == null)
		{
			_data = new List<T>();
			if (_hasFirstItem)
			{
				_data.Add(_firstItem);
			}
		}
	}

	public void Add(T item)
	{
		if (_hasFirstItem)
		{
			Init();
			_data.Add(item);
		}
		else
		{
			_hasFirstItem = true;
			_firstItem = item;
		}
	}

	public void AddRange(IEnumerable<T> items)
	{
		Init();
		_data.AddRange(items);
	}

	public List<T> ToList()
	{
		Init();
		return _data;
	}

	public T[] ToArray()
	{
		return (_data != null) ? _data.ToArray() : ((!_hasFirstItem) ? new T[0] : new T[1] { _firstItem });
	}

	public list<T> ToNList()
	{
		return (_data != null) ? _data.ToNList() : ((!_hasFirstItem) ? ((list<T>)list<T>.Nil._N_constant_object) : ((list<T>)new list<T>.Cons(_firstItem, list<T>.Nil._N_constant_object)));
	}

	public Enumerator GetEnumerator()
	{
		return new Enumerator(this);
	}
}
