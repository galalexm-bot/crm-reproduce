using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace EleWise.ELMA.CAB.Utility;

public class ListDictionary<TKey, TValue> : IDictionary<TKey, List<TValue>>, ICollection<KeyValuePair<TKey, List<TValue>>>, IEnumerable<KeyValuePair<TKey, List<TValue>>>, IEnumerable
{
	private readonly Dictionary<TKey, List<TValue>> innerValues = new Dictionary<TKey, List<TValue>>();

	public List<TValue> Values
	{
		get
		{
			List<TValue> list = new List<TValue>();
			foreach (List<TValue> value in innerValues.Values)
			{
				list.AddRange(value);
			}
			return list;
		}
	}

	public ICollection<TKey> Keys
	{
		get
		{
			ICollection<TKey> keys = innerValues.Keys;
			ICollection<TKey> collection = keys;
			__ContractsRuntime.Ensures(collection != null, null, "Contract.Result<ICollection<TKey>>() != null");
			return collection;
		}
	}

	public List<TValue> this[TKey key]
	{
		get
		{
			if (!innerValues.ContainsKey(key))
			{
				innerValues.Add(key, new List<TValue>());
			}
			return innerValues[key];
		}
		set
		{
			innerValues[key] = value;
		}
	}

	public int Count
	{
		get
		{
			int count = innerValues.Count;
			int num = count;
			__ContractsRuntime.Ensures(num >= 0, null, "Contract.Result<int>() >= 0");
			return num;
		}
	}

	ICollection<List<TValue>> IDictionary<TKey, List<TValue>>.Values
	{
		get
		{
			ICollection<List<TValue>> values = innerValues.Values;
			ICollection<List<TValue>> collection = values;
			__ContractsRuntime.Ensures(collection != null, null, "Contract.Result<ICollection<TValue>>() != null");
			return collection;
		}
	}

	bool ICollection<KeyValuePair<TKey, List<TValue>>>.IsReadOnly => ((ICollection<KeyValuePair<TKey, List<TValue>>>)innerValues).IsReadOnly;

	public void Clear()
	{
		innerValues.Clear();
		if (__ContractsRuntime.insideContractEvaluation <= 4)
		{
			try
			{
				__ContractsRuntime.insideContractEvaluation++;
				__ContractsRuntime.Ensures(((ICollection<KeyValuePair<TKey, List<TValue>>>)this).Count == 0, null, "this.Count == 0");
			}
			finally
			{
				__ContractsRuntime.insideContractEvaluation--;
			}
		}
	}

	public bool ContainsKey(TKey key)
	{
		Guard.ArgumentNotNull(key, "key");
		bool flag = innerValues.ContainsKey(key);
		bool flag2 = flag;
		if (__ContractsRuntime.insideContractEvaluation <= 4)
		{
			try
			{
				__ContractsRuntime.insideContractEvaluation++;
				__ContractsRuntime.Ensures(!flag2 || ((ICollection<KeyValuePair<TKey, List<TValue>>>)this).Count > 0, null, "!Contract.Result<bool>() || @this.Count > 0");
				return flag2;
			}
			finally
			{
				__ContractsRuntime.insideContractEvaluation--;
			}
		}
		return flag2;
	}

	public bool Remove(TKey key)
	{
		Guard.ArgumentNotNull(key, "key");
		return innerValues.Remove(key);
	}

	public void Add(TKey key)
	{
		Guard.ArgumentNotNull(key, "key");
		CreateNewList(key);
	}

	public void Add(TKey key, TValue value)
	{
		Guard.ArgumentNotNull(key, "key");
		Guard.ArgumentNotNull(value, "value");
		if (innerValues.ContainsKey(key))
		{
			innerValues[key].Add(value);
			return;
		}
		List<TValue> list = CreateNewList(key);
		list.Add(value);
	}

	private List<TValue> CreateNewList(TKey key)
	{
		List<TValue> list = new List<TValue>();
		innerValues.Add(key, list);
		return list;
	}

	public bool ContainsValue(TValue value)
	{
		foreach (KeyValuePair<TKey, List<TValue>> innerValue in innerValues)
		{
			if (innerValue.Value.Contains(value))
			{
				return true;
			}
		}
		return false;
	}

	public IEnumerable<TValue> FindAllValuesByKey(Predicate<TKey> keyFilter)
	{
		foreach (KeyValuePair<TKey, List<TValue>> pair in (IEnumerable<KeyValuePair<TKey, List<TValue>>>)this)
		{
			KeyValuePair<TKey, List<TValue>> keyValuePair = pair;
			if (!keyFilter(keyValuePair.Key))
			{
				continue;
			}
			keyValuePair = pair;
			foreach (TValue item in keyValuePair.Value)
			{
				yield return item;
			}
		}
	}

	public IEnumerable<TValue> FindAllValues(Predicate<TValue> valueFilter)
	{
		foreach (KeyValuePair<TKey, List<TValue>> pair in (IEnumerable<KeyValuePair<TKey, List<TValue>>>)this)
		{
			KeyValuePair<TKey, List<TValue>> keyValuePair = pair;
			foreach (TValue value in keyValuePair.Value)
			{
				if (valueFilter(value))
				{
					yield return value;
				}
			}
		}
	}

	public void Remove(TKey key, TValue value)
	{
		Guard.ArgumentNotNull(key, "key");
		Guard.ArgumentNotNull(value, "value");
		if (innerValues.ContainsKey(key))
		{
			innerValues[key].RemoveAll((TValue item) => value.Equals(item));
		}
	}

	public void Remove(TValue value)
	{
		foreach (KeyValuePair<TKey, List<TValue>> innerValue in innerValues)
		{
			Remove(innerValue.Key, value);
		}
	}

	void IDictionary<TKey, List<TValue>>.Add(TKey key, List<TValue> value)
	{
		Guard.ArgumentNotNull(key, "key");
		Guard.ArgumentNotNull(value, "value");
		innerValues.Add(key, value);
	}

	bool IDictionary<TKey, List<TValue>>.TryGetValue(TKey key, out List<TValue> value)
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
		value = this[key];
		bool flag = true;
		bool flag2 = flag;
		if (__ContractsRuntime.insideContractEvaluation <= 4)
		{
			try
			{
				__ContractsRuntime.insideContractEvaluation++;
				__ContractsRuntime.Ensures(flag2 == ((IDictionary<TKey, List<TValue>>)this).ContainsKey(key2), null, "Contract.Result<bool>() == @this.ContainsKey(key)");
				return flag2;
			}
			finally
			{
				__ContractsRuntime.insideContractEvaluation--;
			}
		}
		return flag2;
	}

	void ICollection<KeyValuePair<TKey, List<TValue>>>.Add(KeyValuePair<TKey, List<TValue>> item)
	{
		int count = default(int);
		try
		{
			count = ((ICollection<KeyValuePair<TKey, List<TValue>>>)this).Count;
		}
		catch (Exception ex)
		{
			if (ex == null)
			{
				throw;
			}
		}
		((ICollection<KeyValuePair<TKey, List<TValue>>>)innerValues).Add(item);
		if (__ContractsRuntime.insideContractEvaluation <= 4)
		{
			try
			{
				__ContractsRuntime.insideContractEvaluation++;
				__ContractsRuntime.Ensures(((ICollection<KeyValuePair<TKey, List<TValue>>>)this).Count >= count, null, "this.Count >= Contract.OldValue(this.Count)");
			}
			finally
			{
				__ContractsRuntime.insideContractEvaluation--;
			}
		}
	}

	bool ICollection<KeyValuePair<TKey, List<TValue>>>.Contains(KeyValuePair<TKey, List<TValue>> item)
	{
		bool flag = ((ICollection<KeyValuePair<TKey, List<TValue>>>)innerValues).Contains(item);
		bool flag2 = flag;
		if (__ContractsRuntime.insideContractEvaluation <= 4)
		{
			try
			{
				__ContractsRuntime.insideContractEvaluation++;
				__ContractsRuntime.Ensures(!flag2 || ((ICollection<KeyValuePair<TKey, List<TValue>>>)this).Count > 0, null, "!Contract.Result<bool>() || this.Count > 0");
				return flag2;
			}
			finally
			{
				__ContractsRuntime.insideContractEvaluation--;
			}
		}
		return flag2;
	}

	void ICollection<KeyValuePair<TKey, List<TValue>>>.CopyTo(KeyValuePair<TKey, List<TValue>>[] array, int arrayIndex)
	{
		if (__ContractsRuntime.insideContractEvaluation <= 4)
		{
			try
			{
				__ContractsRuntime.insideContractEvaluation++;
				__ContractsRuntime.Requires(array != null, null, "array != null");
				__ContractsRuntime.Requires(arrayIndex >= 0, null, "arrayIndex >= 0");
				__ContractsRuntime.Requires(arrayIndex + ((ICollection<KeyValuePair<TKey, List<TValue>>>)this).Count <= array.Length, null, "arrayIndex + this.Count  <= array.Length");
			}
			finally
			{
				__ContractsRuntime.insideContractEvaluation--;
			}
		}
		((ICollection<KeyValuePair<TKey, List<TValue>>>)innerValues).CopyTo(array, arrayIndex);
	}

	bool ICollection<KeyValuePair<TKey, List<TValue>>>.Remove(KeyValuePair<TKey, List<TValue>> item)
	{
		return ((ICollection<KeyValuePair<TKey, List<TValue>>>)innerValues).Remove(item);
	}

	IEnumerator<KeyValuePair<TKey, List<TValue>>> IEnumerable<KeyValuePair<TKey, List<TValue>>>.GetEnumerator()
	{
		IEnumerator<KeyValuePair<TKey, List<TValue>>> enumerator = innerValues.GetEnumerator();
		IEnumerator<KeyValuePair<TKey, List<TValue>>> enumerator2 = enumerator;
		__ContractsRuntime.Ensures(enumerator2 != null, null, "Contract.Result<IEnumerator<T>>() != null");
		return enumerator2;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		IEnumerator enumerator = innerValues.GetEnumerator();
		IEnumerator enumerator2 = enumerator;
		__ContractsRuntime.Ensures(enumerator2 != null, null, "Contract.Result<IEnumerator>() != null");
		return enumerator2;
	}
}
