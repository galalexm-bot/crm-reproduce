using System;
using System.Collections;
using System.Collections.Generic;
using Bridge;

namespace EleWise.ELMA.Collections;

[External]
[Reflectable]
[Module("Reactive")]
internal class ReactiveSet<T> : System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, IBridgeClass, ISet<T>, System.Collections.ICollection
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

	internal extern ReactiveSet(string typeName);

	public extern void Add(T item);

	public extern void Clear();

	public extern bool Contains(T item);

	public extern void CopyTo(T[] array, int arrayIndex);

	public extern System.Collections.Generic.IEnumerator<T> GetEnumerator();

	public extern bool Remove(T item);

	public extern void Add(object item);

	public extern bool Contains(object value);

	public extern int IndexOf(object value);

	public extern void Insert(int index, object value);

	public extern void Remove(object value);

	extern bool ISet<T>.Add(T item);

	public extern void UnionWith(System.Collections.Generic.IEnumerable<T> other);

	public extern void IntersectWith(System.Collections.Generic.IEnumerable<T> other);

	public extern void ExceptWith(System.Collections.Generic.IEnumerable<T> other);

	public extern void SymmetricExceptWith(System.Collections.Generic.IEnumerable<T> other);

	public extern bool IsSubsetOf(System.Collections.Generic.IEnumerable<T> other);

	public extern bool IsSupersetOf(System.Collections.Generic.IEnumerable<T> other);

	public extern bool IsProperSupersetOf(System.Collections.Generic.IEnumerable<T> other);

	public extern bool IsProperSubsetOf(System.Collections.Generic.IEnumerable<T> other);

	public extern bool Overlaps(System.Collections.Generic.IEnumerable<T> other);

	public extern bool SetEquals(System.Collections.Generic.IEnumerable<T> other);

	extern System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();

	extern void System.Collections.ICollection.CopyTo(System.Array array, int arrayIndex);
}
