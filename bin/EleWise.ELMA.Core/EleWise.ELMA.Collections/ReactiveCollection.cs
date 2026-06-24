using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using Bridge;

namespace EleWise.ELMA.Collections;

[DefaultMember("Item")]
[External]
[Reflectable]
[Module("Reactive")]
public class ReactiveCollection<T> : IReactiveCollection<T>, System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, IBridgeClass, IReactiveCollection, System.Collections.ICollection
{
	public extern int Count
	{
		[Template("getCount()")]
		get;
	}

	public extern bool IsReadOnly
	{
		[Template("getIsReadOnly()")]
		get;
	}

	public object SyncRoot => this;

	public bool IsSynchronized => false;

	[AccessorsIndexer]
	public extern T this[int index]
	{
		[Name("get")]
		get;
		[Name("set")]
		set;
	}

	public extern ReactiveCollection();

	public extern void Add(T item);

	public extern void Clear();

	public extern bool Contains(T item);

	public extern void CopyTo(T[] array, int arrayIndex);

	public extern System.Collections.Generic.IEnumerator<T> GetEnumerator();

	public extern bool Remove(T item);

	public extern void Insert(int index, T item);

	public extern int IndexOf(T item);

	public extern T[] RemoveAt(int index);

	public extern void AddRange(System.Collections.Generic.IEnumerable<T> collection);

	public extern void Add(object item);

	public extern bool Contains(object value);

	public extern int IndexOf(object value);

	public extern void Insert(int index, object value);

	public extern void Remove(object value);

	extern void IReactiveCollection.RemoveAt(int index);

	extern System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();

	extern void System.Collections.ICollection.CopyTo(System.Array array, int arrayIndex);
}
