using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using Nemerle.Builtins;
using Nemerle.Core;

namespace Nemerle.Collections;

[Serializable]
[DebuggerDisplay("Count = {Count}: {ToString()}")]
[ComVisible(false)]
[DebuggerNonUserCode]
public class Hashtable<TKey, TValue> : Dictionary<TKey, TValue>
{
	[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
	public Nemerle.Builtins.Tuple<TKey, TValue>[] KeyValuePairs
	{
		get
		{
			Nemerle.Builtins.Tuple<TKey, TValue>[] array = new Nemerle.Builtins.Tuple<TKey, TValue>[Count];
			int num = 0;
			using Enumerator enumerator = GetEnumerator();
			while (enumerator.MoveNext())
			{
				KeyValuePair<TKey, TValue> current = enumerator.Current;
				KeyValuePair<TKey, TValue> keyValuePair = current;
				ref Nemerle.Builtins.Tuple<TKey, TValue> reference = ref array[num];
				reference = new Nemerle.Builtins.Tuple<TKey, TValue>(keyValuePair.Key, keyValuePair.Value);
				num = checked(num + 1);
			}
			return array;
		}
	}

	public Hashtable()
	{
	}

	public Hashtable(IDictionary<TKey, TValue> dictionary)
		: base(dictionary)
	{
	}

	public Hashtable(IEnumerable<Nemerle.Builtins.Tuple<TKey, TValue>> generator)
	{
		IEnumerator<Nemerle.Builtins.Tuple<TKey, TValue>> enumerator = generator.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				TValue val = default(TValue);
				TKey val2 = default(TKey);
				Nemerle.Builtins.Tuple<TKey, TValue> current = enumerator.Current;
				val2 = current.Field0;
				val = current.Field1;
				Add(val2, val);
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
	}

	public Hashtable(IEqualityComparer<TKey> comparer)
		: base(comparer)
	{
	}

	public Hashtable(int capacity)
		: base(capacity)
	{
	}

	public Hashtable(IDictionary<TKey, TValue> dictionary, IEqualityComparer<TKey> comparer)
		: base(dictionary, comparer)
	{
	}

	public Hashtable(int capacity, IEqualityComparer<TKey> comparer)
		: base(capacity, comparer)
	{
	}

	protected Hashtable(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}

	public option<TValue> Get(TKey key)
	{
		TValue value = default(TValue);
		return (!TryGetValue(key, out value)) ? ((option<TValue>)option<TValue>.None._N_constant_object) : ((option<TValue>)new option<TValue>.Some(value));
	}

	public Nemerle.Builtins.Tuple<TValue, bool> TryGetValue(TKey key)
	{
		TValue value = default(TValue);
		return (!TryGetValue(key, out value)) ? new Nemerle.Builtins.Tuple<TValue, bool>(value, field1: false) : new Nemerle.Builtins.Tuple<TValue, bool>(value, field1: true);
	}

	public TValue GetValueOrDefault(TKey key)
	{
		TValue value = default(TValue);
		TryGetValue(key, out value);
		return value;
	}

	public TValue GetValueOrDefault(TKey key, TValue defaultValue)
	{
		TValue value = default(TValue);
		return (!TryGetValue(key, out value)) ? defaultValue : value;
	}

	public TValue GetValueOrGetDefault(TKey key, Function<TValue> getDefaultValue)
	{
		TValue value = default(TValue);
		return (!TryGetValue(key, out value)) ? getDefaultValue.apply() : value;
	}

	public TValue GetValue(TKey key, Function<TValue> getNewValue)
	{
		TValue value = default(TValue);
		TValue result;
		if (TryGetValue(key, out value))
		{
			result = value;
		}
		else
		{
			value = getNewValue.apply();
			Add(key, value);
			result = value;
		}
		return result;
	}

	public void Set(TKey key, TValue val)
	{
		this[key] = val;
	}

	public Hashtable<TKey, TValue> Update(TKey key, TValue defaultValue, Function<TValue, TValue> updateFn)
	{
		TValue value = default(TValue);
		if (!TryGetValue(key, out value))
		{
			value = defaultValue;
		}
		this[key] = updateFn.apply(value);
		return this;
	}

	public Hashtable<TKey, TValue> Update(TKey key, Function<TValue> newValue, Function<TValue, TValue> updateFn)
	{
		TValue value = default(TValue);
		if (!TryGetValue(key, out value))
		{
			value = newValue.apply();
		}
		this[key] = updateFn.apply(value);
		return this;
	}

	public Hashtable<TKey, TValue> Clone()
	{
		return new Hashtable<TKey, TValue>(this);
	}

	public bool Contains(TKey key)
	{
		return ContainsKey(key);
	}

	public _0027c Fold<_0027c>(_0027c s, Function<TKey, TValue, _0027c, _0027c> f)
	{
		_0027c val = s;
		using Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			KeyValuePair<TKey, TValue> current = enumerator.Current;
			KeyValuePair<TKey, TValue> keyValuePair = current;
			val = f.apply(keyValuePair.Key, keyValuePair.Value, val);
		}
		return val;
	}

	public void Iter(FunctionVoid<TKey, TValue> f)
	{
		using Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			KeyValuePair<TKey, TValue> current = enumerator.Current;
			KeyValuePair<TKey, TValue> keyValuePair = current;
			f.apply_void(new Nemerle.Builtins.Tuple<TKey, TValue>(keyValuePair.Key, keyValuePair.Value));
		}
	}

	public Hashtable<_0027c, _0027d> Map<_0027c, _0027d>(Function<TKey, TValue, Nemerle.Builtins.Tuple<_0027c, _0027d>> f)
	{
		Hashtable<_0027c, _0027d> hashtable = new Hashtable<_0027c, _0027d>(Count);
		using Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			KeyValuePair<TKey, TValue> current = enumerator.Current;
			KeyValuePair<TKey, TValue> keyValuePair = current;
			_0027d val = default(_0027d);
			_0027c val2 = default(_0027c);
			Nemerle.Builtins.Tuple<_0027c, _0027d> tuple = f.apply(keyValuePair.Key, keyValuePair.Value);
			val2 = tuple.Field0;
			val = tuple.Field1;
			hashtable.Add(val2, val);
		}
		return hashtable;
	}

	public Hashtable<TKey, TValue> Filter(Function<TKey, TValue, bool> f)
	{
		Hashtable<TKey, TValue> hashtable = new Hashtable<TKey, TValue>();
		using Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			KeyValuePair<TKey, TValue> current = enumerator.Current;
			KeyValuePair<TKey, TValue> keyValuePair = current;
			if (f.apply(keyValuePair.Key, keyValuePair.Value))
			{
				hashtable.Add(keyValuePair.Key, keyValuePair.Value);
			}
		}
		return hashtable;
	}

	public new void Remove(TKey key)
	{
		bool flag = base.Remove(key);
	}

	internal static string better_to_string(object x)
	{
		return (x is string) ? string.Concat("\"" + (string)x, "\"") : ((x is char) ? string.Concat("'" + (char)x, "'") : ((x != null) ? x.ToString() : "<null>"));
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder("{");
		using (Enumerator enumerator = GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				KeyValuePair<TKey, TValue> current = enumerator.Current;
				KeyValuePair<TKey, TValue> keyValuePair = current;
				stringBuilder.Append(better_to_string(keyValuePair.Key));
				stringBuilder.Append(": ");
				stringBuilder.Append(better_to_string(keyValuePair.Value));
				stringBuilder.Append(", ");
			}
		}
		checked
		{
			if (stringBuilder.Length > 1)
			{
				stringBuilder.Length -= 2;
			}
			stringBuilder.Append('}');
			return stringBuilder.ToString();
		}
	}
}
