using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using EleWise.ELMA.CAB.Properties;

namespace EleWise.ELMA.CAB.Utility;

public class ReadOnlyDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable
{
	private readonly IDictionary<TKey, TValue> inner;

	public ICollection<TKey> Keys
	{
		get
		{
			ICollection<TKey> keys = inner.Keys;
			ICollection<TKey> collection = keys;
			__ContractsRuntime.Ensures(collection != null, null, "Contract.Result<ICollection<TKey>>() != null");
			return collection;
		}
	}

	public ICollection<TValue> Values
	{
		get
		{
			ICollection<TValue> values = inner.Values;
			ICollection<TValue> collection = values;
			__ContractsRuntime.Ensures(collection != null, null, "Contract.Result<ICollection<TValue>>() != null");
			return collection;
		}
	}

	public TValue this[TKey key]
	{
		get
		{
			return inner[key];
		}
		set
		{
			throw new NotSupportedException(Resources.DictionaryIsReadOnly);
		}
	}

	public int Count
	{
		get
		{
			int count = inner.Count;
			int num = count;
			__ContractsRuntime.Ensures(num >= 0, null, "Contract.Result<int>() >= 0");
			return num;
		}
	}

	bool ICollection<KeyValuePair<TKey, TValue>>.IsReadOnly => true;

	public ReadOnlyDictionary(IDictionary<TKey, TValue> innerDictionary)
	{
		Guard.ArgumentNotNull(innerDictionary, "innerDictionary");
		inner = innerDictionary;
	}

	void IDictionary<TKey, TValue>.Add(TKey key, TValue value)
	{
		throw new NotSupportedException(Resources.DictionaryIsReadOnly);
	}

	public bool ContainsKey(TKey key)
	{
		bool flag = inner.ContainsKey(key);
		bool flag2 = flag;
		if (__ContractsRuntime.insideContractEvaluation <= 4)
		{
			try
			{
				__ContractsRuntime.insideContractEvaluation++;
				__ContractsRuntime.Ensures(!flag2 || ((ICollection<KeyValuePair<TKey, TValue>>)this).Count > 0, null, "!Contract.Result<bool>() || @this.Count > 0");
				return flag2;
			}
			finally
			{
				__ContractsRuntime.insideContractEvaluation--;
			}
		}
		return flag2;
	}

	bool IDictionary<TKey, TValue>.Remove(TKey key)
	{
		throw new NotSupportedException(Resources.DictionaryIsReadOnly);
	}

	public bool TryGetValue(TKey key, out TValue value)
	{
		TKey key2 = default(TKey);
		try
		{
			key2 = key;
		}
		catch (Exception ex)
		{
			if (ex == null)
			{
				throw;
			}
		}
		bool flag = inner.TryGetValue(key, out value);
		bool flag2 = flag;
		if (__ContractsRuntime.insideContractEvaluation <= 4)
		{
			try
			{
				__ContractsRuntime.insideContractEvaluation++;
				__ContractsRuntime.Ensures(flag2 == ((IDictionary<TKey, TValue>)this).ContainsKey(key2), null, "Contract.Result<bool>() == @this.ContainsKey(key)");
				return flag2;
			}
			finally
			{
				__ContractsRuntime.insideContractEvaluation--;
			}
		}
		return flag2;
	}

	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> item)
	{
		//Discarded unreachable code: IL_0024, IL_002f, IL_0064
		try
		{
			int count = ((ICollection<KeyValuePair<TKey, TValue>>)this).Count;
		}
		catch (Exception ex)
		{
			if (ex == null)
			{
				throw;
			}
		}
		throw new NotSupportedException(Resources.DictionaryIsReadOnly);
	}

	void ICollection<KeyValuePair<TKey, TValue>>.Clear()
	{
		//Discarded unreachable code: IL_000c, IL_0017, IL_0049
		throw new NotSupportedException(Resources.DictionaryIsReadOnly);
	}

	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> item)
	{
		bool flag = inner.Contains(item);
		bool flag2 = flag;
		if (__ContractsRuntime.insideContractEvaluation <= 4)
		{
			try
			{
				__ContractsRuntime.insideContractEvaluation++;
				__ContractsRuntime.Ensures(!flag2 || ((ICollection<KeyValuePair<TKey, TValue>>)this).Count > 0, null, "!Contract.Result<bool>() || this.Count > 0");
				return flag2;
			}
			finally
			{
				__ContractsRuntime.insideContractEvaluation--;
			}
		}
		return flag2;
	}

	void ICollection<KeyValuePair<TKey, TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
	{
		if (__ContractsRuntime.insideContractEvaluation <= 4)
		{
			try
			{
				__ContractsRuntime.insideContractEvaluation++;
				__ContractsRuntime.Requires(array != null, null, "array != null");
				__ContractsRuntime.Requires(arrayIndex >= 0, null, "arrayIndex >= 0");
				__ContractsRuntime.Requires(arrayIndex + ((ICollection<KeyValuePair<TKey, TValue>>)this).Count <= array.Length, null, "arrayIndex + this.Count  <= array.Length");
			}
			finally
			{
				__ContractsRuntime.insideContractEvaluation--;
			}
		}
		inner.CopyTo(array, arrayIndex);
	}

	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> item)
	{
		throw new NotSupportedException(Resources.DictionaryIsReadOnly);
	}

	IEnumerator<KeyValuePair<TKey, TValue>> IEnumerable<KeyValuePair<TKey, TValue>>.GetEnumerator()
	{
		IEnumerator<KeyValuePair<TKey, TValue>> enumerator = inner.GetEnumerator();
		IEnumerator<KeyValuePair<TKey, TValue>> enumerator2 = enumerator;
		__ContractsRuntime.Ensures(enumerator2 != null, null, "Contract.Result<IEnumerator<T>>() != null");
		return enumerator2;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		IEnumerator enumerator = ((IEnumerable)inner).GetEnumerator();
		IEnumerator enumerator2 = enumerator;
		__ContractsRuntime.Ensures(enumerator2 != null, null, "Contract.Result<IEnumerator>() != null");
		return enumerator2;
	}
}
