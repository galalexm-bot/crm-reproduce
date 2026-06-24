using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Nemerle.Collections;

[Serializable]
[DebuggerNonUserCode]
[DebuggerDisplay("Count = {Count}: {ToString()}")]
[ComVisible(false)]
public class HashSetEx<T> : IEnumerable, IEnumerable<T>
{
	private readonly Hashtable<T, T> _hashtable = new Hashtable<T, T>();

	[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
	public Dictionary<T, T>.KeyCollection Items => _hashtable.Keys;

	public bool IsEmpty => _hashtable.Count == 0;

	public int Count => _hashtable.Count;

	public bool Contains(T item)
	{
		return _hashtable.ContainsKey(item);
	}

	public bool Add(T item)
	{
		return AddOrGetFirstAddedItem(ref item);
	}

	public bool AddOrGetFirstAddedItem(ref T item)
	{
		T value = default(T);
		int result;
		if (_hashtable.TryGetValue(item, out value))
		{
			item = value;
			result = 0;
		}
		else
		{
			_hashtable.Add(item, item);
			result = 1;
		}
		return (byte)result != 0;
	}

	public bool TryGetFirstAddedItem(T item, out T oldItem)
	{
		return _hashtable.TryGetValue(item, out oldItem);
	}

	public IEnumerator<T> GetEnumerator()
	{
		return _hashtable.Keys.GetEnumerator();
	}

	[SpecialName]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}
