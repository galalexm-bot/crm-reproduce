using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace EleWise.ELMA.CAB.Utility;

public class Set<TItem> : ICollection<TItem>, IEnumerable<TItem>, IEnumerable
{
	private readonly Dictionary<TItem, object> dictionary;

	private readonly bool isReadOnly;

	public int Count
	{
		get
		{
			int count = dictionary.Count;
			int num = count;
			__ContractsRuntime.Ensures(num >= 0, null, "Contract.Result<int>() >= 0");
			return num;
		}
	}

	public bool IsReadOnly => isReadOnly;

	public Set()
	{
		dictionary = new Dictionary<TItem, object>();
		isReadOnly = false;
	}

	private Set(Set<TItem> innerSet)
	{
		dictionary = innerSet.dictionary;
		isReadOnly = true;
	}

	public void Add(TItem item)
	{
		int count = default(int);
		try
		{
			count = ((ICollection<TItem>)this).Count;
		}
		catch (Exception ex)
		{
			if (ex == null)
			{
				throw;
			}
		}
		if (IsReadOnly)
		{
			throw new NotSupportedException();
		}
		dictionary[item] = string.Empty;
		if (__ContractsRuntime.insideContractEvaluation <= 4)
		{
			try
			{
				__ContractsRuntime.insideContractEvaluation++;
				__ContractsRuntime.Ensures(((ICollection<TItem>)this).Count >= count, null, "this.Count >= Contract.OldValue(this.Count)");
			}
			finally
			{
				__ContractsRuntime.insideContractEvaluation--;
			}
		}
	}

	public void Clear()
	{
		if (IsReadOnly)
		{
			throw new NotSupportedException();
		}
		dictionary.Clear();
		if (__ContractsRuntime.insideContractEvaluation <= 4)
		{
			try
			{
				__ContractsRuntime.insideContractEvaluation++;
				__ContractsRuntime.Ensures(((ICollection<TItem>)this).Count == 0, null, "this.Count == 0");
			}
			finally
			{
				__ContractsRuntime.insideContractEvaluation--;
			}
		}
	}

	public bool Contains(TItem item)
	{
		bool flag = dictionary.ContainsKey(item);
		bool flag2 = flag;
		if (__ContractsRuntime.insideContractEvaluation <= 4)
		{
			try
			{
				__ContractsRuntime.insideContractEvaluation++;
				__ContractsRuntime.Ensures(!flag2 || ((ICollection<TItem>)this).Count > 0, null, "!Contract.Result<bool>() || this.Count > 0");
				return flag2;
			}
			finally
			{
				__ContractsRuntime.insideContractEvaluation--;
			}
		}
		return flag2;
	}

	public void CopyTo(TItem[] array, int arrayIndex)
	{
		//Discarded unreachable code: IL_0072
		if (__ContractsRuntime.insideContractEvaluation <= 4)
		{
			try
			{
				__ContractsRuntime.insideContractEvaluation++;
				__ContractsRuntime.Requires(array != null, null, "array != null");
				__ContractsRuntime.Requires(arrayIndex >= 0, null, "arrayIndex >= 0");
				__ContractsRuntime.Requires(arrayIndex + ((ICollection<TItem>)this).Count <= array.Length, null, "arrayIndex + this.Count  <= array.Length");
			}
			finally
			{
				__ContractsRuntime.insideContractEvaluation--;
			}
		}
		throw new NotImplementedException();
	}

	public bool Remove(TItem item)
	{
		if (IsReadOnly)
		{
			throw new NotSupportedException();
		}
		return dictionary.Remove(item);
	}

	public IEnumerator<TItem> GetEnumerator()
	{
		IEnumerator<TItem> enumerator = dictionary.Keys.GetEnumerator();
		IEnumerator<TItem> enumerator2 = enumerator;
		__ContractsRuntime.Ensures(enumerator2 != null, null, "Contract.Result<IEnumerator<T>>() != null");
		return enumerator2;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		IEnumerator enumerator = GetEnumerator();
		IEnumerator enumerator2 = enumerator;
		__ContractsRuntime.Ensures(enumerator2 != null, null, "Contract.Result<IEnumerator>() != null");
		return enumerator2;
	}

	public Set<TItem> AsReadOnly()
	{
		return new Set<TItem>(this);
	}
}
