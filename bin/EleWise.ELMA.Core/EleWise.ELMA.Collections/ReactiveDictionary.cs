using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using Bridge;

namespace EleWise.ELMA.Collections;

[External]
[Module("Reactive")]
[Reflectable]
[DefaultMember("Item")]
[Convention(/*Could not decode attribute arguments.*/)]
public class ReactiveDictionary<TKey, TValue> : IReactiveDictionary<TKey, TValue>, IDictionary<TKey, TValue>, System.Collections.Generic.ICollection<KeyValuePair<TKey, TValue>>, System.Collections.Generic.IEnumerable<KeyValuePair<TKey, TValue>>, System.Collections.IEnumerable, IBridgeClass, IDictionary, System.Collections.ICollection, IReadOnlyDictionary<TKey, TValue>, System.Collections.Generic.IReadOnlyCollection<KeyValuePair<TKey, TValue>>
{
	private readonly System.Collections.Generic.IEnumerable<TKey> _003CSystem_002ECollections_002EGeneric_002EIReadOnlyDictionary_003CTKey_002CTValue_003E_002EKeys_003Ek__BackingField;

	private readonly System.Collections.Generic.IEnumerable<TValue> _003CSystem_002ECollections_002EGeneric_002EIReadOnlyDictionary_003CTKey_002CTValue_003E_002EValues_003Ek__BackingField;

	[Convention(/*Could not decode attribute arguments.*/)]
	public extern IEqualityComparer<TKey> Comparer { get; }

	[Convention(/*Could not decode attribute arguments.*/)]
	public extern int Count { get; }

	public extern System.Collections.Generic.ICollection<TKey> Keys
	{
		[Template("getKeys()")]
		get;
	}

	System.Collections.Generic.IEnumerable<TKey> Keys
	{
		[Template("getKeys()")]
		get
		{
			return _003CSystem_002ECollections_002EGeneric_002EIReadOnlyDictionary_003CTKey_002CTValue_003E_002EKeys_003Ek__BackingField;
		}
	}

	public extern System.Collections.Generic.ICollection<TValue> Values
	{
		[Template("getValues()")]
		get;
	}

	System.Collections.Generic.IEnumerable<TValue> Values
	{
		[Template("getValues()")]
		get
		{
			return _003CSystem_002ECollections_002EGeneric_002EIReadOnlyDictionary_003CTKey_002CTValue_003E_002EValues_003Ek__BackingField;
		}
	}

	[AccessorsIndexer]
	public extern TValue this[TKey key]
	{
		[Name("get")]
		get;
		[Name("set")]
		set;
	}

	public extern bool IsReadOnly
	{
		[Template("getIsReadOnly()")]
		get;
	}

	[AccessorsIndexer]
	extern object Item
	{
		[Name("get")]
		get;
		[Name("set")]
		set;
	}

	extern System.Collections.ICollection Values { get; }

	extern System.Collections.ICollection Keys { get; }

	bool IsFixedSize => false;

	object SyncRoot => this;

	bool IsSynchronized => false;

	public extern ReactiveDictionary();

	[Template("new (EleWise.ELMA.Collections.ReactiveDictionary$2({TKey}, {TValue}))()")]
	public extern ReactiveDictionary(int capacity);

	[Template("new (EleWise.ELMA.Collections.ReactiveDictionary$2({TKey}, {TValue}))(null, {comparer})")]
	public extern ReactiveDictionary(int capacity, IEqualityComparer<TKey> comparer);

	public extern ReactiveDictionary(object obj);

	public extern ReactiveDictionary(object obj, IEqualityComparer<TKey> comparer);

	[Template("new (EleWise.ELMA.Collections.ReactiveDictionary$2({TKey}, {TValue}))(null, {comparer})")]
	public extern ReactiveDictionary(IEqualityComparer<TKey> comparer);

	public extern ReactiveDictionary(IDictionary<TKey, TValue> dictionary);

	public extern ReactiveDictionary(IDictionary<TKey, TValue> dictionary, IEqualityComparer<TKey> comparer);

	public extern void Add(TKey key, TValue value);

	private extern TValue Items(TKey key);

	public extern void Clear();

	public extern bool ContainsKey(TKey key);

	public extern bool ContainsValue(TValue value);

	public extern System.Collections.Generic.IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator();

	extern System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();

	public extern bool Remove(TKey key);

	public extern bool TryGetValue(TKey key, out TValue value);

	extern void System.Collections.Generic.ICollection<KeyValuePair<KeyValuePair<TKey, TValue>, _003F>>.Add(KeyValuePair<TKey, TValue> item);

	extern void System.Collections.Generic.ICollection<KeyValuePair<KeyValuePair<TKey, TValue>, _003F>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex);

	extern bool System.Collections.Generic.ICollection<KeyValuePair<KeyValuePair<TKey, TValue>, _003F>>.Contains(KeyValuePair<TKey, TValue> item);

	extern bool System.Collections.Generic.ICollection<KeyValuePair<KeyValuePair<TKey, TValue>, _003F>>.Remove(KeyValuePair<TKey, TValue> item);

	extern void System.Collections.ICollection.CopyTo(System.Array array, int arrayIndex);

	private extern bool ContainsKey(object key);

	extern void IDictionary.Add(object key, object value);

	extern void IDictionary.Remove(object key);

	extern bool IDictionary.Contains(object key);

	extern IDictionaryEnumerator IDictionary.GetEnumerator();
}
