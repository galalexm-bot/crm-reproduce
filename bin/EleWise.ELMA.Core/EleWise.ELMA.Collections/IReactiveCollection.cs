using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using Bridge;

namespace EleWise.ELMA.Collections;

[External]
[Reflectable]
[Module("Reactive")]
public interface IReactiveCollection : System.Collections.ICollection, System.Collections.IEnumerable, IBridgeClass
{
	void Add(object value);

	void Clear();

	bool Contains(object value);

	int IndexOf(object value);

	void Insert(int index, object value);

	void Remove(object value);

	void RemoveAt(int index);
}
[DefaultMember("Item")]
[External]
[Reflectable]
[Module("Reactive")]
public interface IReactiveCollection<T> : System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, IBridgeClass
{
	T this[int index] { get; set; }

	int IndexOf(T item);

	void Insert(int index, T item);

	T[] RemoveAt(int index);

	void AddRange(System.Collections.Generic.IEnumerable<T> collection);
}
