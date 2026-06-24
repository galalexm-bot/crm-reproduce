using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Collections;

internal class ConcurrentHashSet<T> : ISet<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyCollection<T>
{
	private readonly ConcurrentDictionary<T, byte> hashSet;

	private static object ufR1es0xPfwsk844TAK;

	public int Count => hashSet.Count;

	public bool IsReadOnly => false;

	public ConcurrentHashSet()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			hashSet = new ConcurrentDictionary<T, byte>();
			num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
			{
				num = 1;
			}
		}
	}

	public ConcurrentHashSet(IEnumerable<T> collection)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		Contract.NotNull(collection, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -812001002));
		hashSet = new ConcurrentDictionary<T, byte>(collection.Select((T i) => new KeyValuePair<T, byte>(i, 0)));
	}

	public ConcurrentHashSet(IEqualityComparer<T> comparer)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		hashSet = new ConcurrentDictionary<T, byte>(comparer);
	}

	public ConcurrentHashSet(IEnumerable<T> collection, IEqualityComparer<T> comparer)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		Contract.NotNull(collection, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1633514411 ^ -1633538803));
		hashSet = new ConcurrentDictionary<T, byte>(collection.Select((T i) => new KeyValuePair<T, byte>(i, 0)), comparer);
	}

	public bool Add(T item)
	{
		return hashSet.TryAdd(item, 0);
	}

	public void Clear()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				hashSet.Clear();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public bool Contains(T item)
	{
		return hashSet.ContainsKey(item);
	}

	public bool Remove(T item)
	{
		byte value;
		return hashSet.TryRemove(item, out value);
	}

	void ICollection<T>.Add(T item)
	{
		Add(item);
	}

	public void CopyTo(T[] array, int arrayIndex)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				hashSet.Keys.CopyTo(array, arrayIndex);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public void UnionWith(IEnumerable<T> other)
	{
		throw new NotImplementedException();
	}

	public void IntersectWith(IEnumerable<T> other)
	{
		throw new NotImplementedException();
	}

	public void ExceptWith(IEnumerable<T> other)
	{
		throw new NotImplementedException();
	}

	public void SymmetricExceptWith(IEnumerable<T> other)
	{
		throw new NotImplementedException();
	}

	public bool IsSubsetOf(IEnumerable<T> other)
	{
		throw new NotImplementedException();
	}

	public bool IsSupersetOf(IEnumerable<T> other)
	{
		throw new NotImplementedException();
	}

	public bool IsProperSupersetOf(IEnumerable<T> other)
	{
		throw new NotImplementedException();
	}

	public bool IsProperSubsetOf(IEnumerable<T> other)
	{
		throw new NotImplementedException();
	}

	public bool Overlaps(IEnumerable<T> other)
	{
		throw new NotImplementedException();
	}

	public bool SetEquals(IEnumerable<T> other)
	{
		throw new NotImplementedException();
	}

	public IEnumerator<T> GetEnumerator()
	{
		return hashSet.Select((KeyValuePair<T, byte> x) => x.Key).GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	internal static bool NiXWCS00vWrLdWaEP6k()
	{
		return ufR1es0xPfwsk844TAK == null;
	}

	internal static object JXBH5Y0m8Ey2dhLwbNL()
	{
		return ufR1es0xPfwsk844TAK;
	}
}
