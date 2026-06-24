using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Collections;

public class MultiKeyDictionary<K, L, V> : IDictionary<K, V>, ICollection<KeyValuePair<K, V>>, IEnumerable<KeyValuePair<K, V>>, IEnumerable
{
	internal readonly Dictionary<K, V> baseDictionary;

	internal readonly Dictionary<L, K> subDictionary;

	internal readonly Dictionary<K, L> primaryToSubkeyMapping;

	private readonly ReaderWriterLockSlim readerWriterLock;

	private static object en7F07mIOtOoowpqNrH;

	public V this[L subKey]
	{
		get
		{
			if (TryGetValue(subKey, out var val))
			{
				return val;
			}
			throw new KeyNotFoundException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837638465) + subKey.ToString());
		}
	}

	public V this[K primaryKey]
	{
		get
		{
			if (TryGetValue(primaryKey, out var val))
			{
				return val;
			}
			throw new KeyNotFoundException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C9495B4 ^ 0x1C94375A) + primaryKey.ToString());
		}
	}

	V IDictionary<K, V>.this[K key]
	{
		get
		{
			return baseDictionary[key];
		}
		set
		{
			Add(key, value);
		}
	}

	public ICollection<K> Keys => baseDictionary.Keys;

	ICollection<V> IDictionary<K, V>.Values => baseDictionary.Values;

	public List<V> Values
	{
		get
		{
			readerWriterLock.EnterReadLock();
			try
			{
				return baseDictionary.Values.ToList();
			}
			finally
			{
				readerWriterLock.ExitReadLock();
			}
		}
	}

	public int Count
	{
		get
		{
			//Discarded unreachable code: IL_0078, IL_00b4, IL_00c7, IL_00d6
			int num = 2;
			int num2 = num;
			int count = default(int);
			while (true)
			{
				switch (num2)
				{
				case 2:
					readerWriterLock.EnterReadLock();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
					{
						num2 = 1;
					}
					break;
				default:
					return count;
				case 1:
					try
					{
						count = baseDictionary.Count;
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
						{
							num3 = 0;
						}
						return num3 switch
						{
							0 => count, 
							_ => count, 
						};
					}
					finally
					{
						readerWriterLock.ExitReadLock();
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
				}
			}
		}
	}

	bool ICollection<KeyValuePair<K, V>>.IsReadOnly => false;

	public void Associate(L subKey, K primaryKey)
	{
		readerWriterLock.EnterUpgradeableReadLock();
		try
		{
			if (!baseDictionary.ContainsKey(primaryKey))
			{
				throw new KeyNotFoundException(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-218496594 ^ -218455410), primaryKey));
			}
			if (primaryToSubkeyMapping.ContainsKey(primaryKey))
			{
				readerWriterLock.EnterWriteLock();
				try
				{
					if (subDictionary.ContainsKey(primaryToSubkeyMapping[primaryKey]))
					{
						subDictionary.Remove(primaryToSubkeyMapping[primaryKey]);
					}
					primaryToSubkeyMapping.Remove(primaryKey);
				}
				finally
				{
					readerWriterLock.ExitWriteLock();
				}
			}
			subDictionary[subKey] = primaryKey;
			primaryToSubkeyMapping[primaryKey] = subKey;
		}
		finally
		{
			readerWriterLock.ExitUpgradeableReadLock();
		}
	}

	public bool TryGetValue(L subKey, out V val)
	{
		val = default(V);
		readerWriterLock.EnterReadLock();
		try
		{
			if (subDictionary.TryGetValue(subKey, out var value))
			{
				return baseDictionary.TryGetValue(value, out val);
			}
		}
		finally
		{
			readerWriterLock.ExitReadLock();
		}
		return false;
	}

	bool IDictionary<K, V>.Remove(K key)
	{
		return baseDictionary.Remove(key);
	}

	public bool TryGetValue(K primaryKey, out V val)
	{
		readerWriterLock.EnterReadLock();
		try
		{
			return baseDictionary.TryGetValue(primaryKey, out val);
		}
		finally
		{
			readerWriterLock.ExitReadLock();
		}
	}

	public bool ContainsKey(L subKey)
	{
		V val;
		return TryGetValue(subKey, out val);
	}

	public bool ContainsKey(K primaryKey)
	{
		V val;
		return TryGetValue(primaryKey, out val);
	}

	public void Remove(K primaryKey)
	{
		readerWriterLock.EnterWriteLock();
		try
		{
			if (primaryToSubkeyMapping.ContainsKey(primaryKey))
			{
				if (subDictionary.ContainsKey(primaryToSubkeyMapping[primaryKey]))
				{
					subDictionary.Remove(primaryToSubkeyMapping[primaryKey]);
				}
				primaryToSubkeyMapping.Remove(primaryKey);
			}
			baseDictionary.Remove(primaryKey);
		}
		finally
		{
			readerWriterLock.ExitWriteLock();
		}
	}

	public void Remove(L subKey)
	{
		readerWriterLock.EnterWriteLock();
		try
		{
			baseDictionary.Remove(subDictionary[subKey]);
			primaryToSubkeyMapping.Remove(subDictionary[subKey]);
			subDictionary.Remove(subKey);
		}
		finally
		{
			readerWriterLock.ExitWriteLock();
		}
	}

	public void Add(K primaryKey, V val)
	{
		readerWriterLock.EnterWriteLock();
		try
		{
			baseDictionary.Add(primaryKey, val);
		}
		finally
		{
			readerWriterLock.ExitWriteLock();
		}
	}

	public void Add(K primaryKey, L subKey, V val)
	{
		Add(primaryKey, val);
		Associate(subKey, primaryKey);
	}

	public V[] CloneValues()
	{
		//Discarded unreachable code: IL_005d, IL_00ec, IL_00ff, IL_010e
		int num = 1;
		int num2 = num;
		V[] result = default(V[]);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return result;
			case 1:
				readerWriterLock.EnterReadLock();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				V[] array = new V[baseDictionary.Values.Count];
				int num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
				{
					num3 = 1;
				}
				while (true)
				{
					switch (num3)
					{
					default:
						return result;
					case 0:
						return result;
					case 2:
						result = array;
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
						{
							num3 = 0;
						}
						break;
					case 1:
						baseDictionary.Values.CopyTo(array, 0);
						num3 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
						{
							num3 = 2;
						}
						break;
					}
				}
			}
			finally
			{
				readerWriterLock.ExitReadLock();
				int num4 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
				{
					num4 = 0;
				}
				switch (num4)
				{
				case 0:
					break;
				}
			}
		}
	}

	public K[] ClonePrimaryKeys()
	{
		//Discarded unreachable code: IL_0082, IL_0111, IL_0124, IL_0133
		int num = 1;
		int num2 = num;
		K[] result = default(K[]);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return result;
			case 1:
				readerWriterLock.EnterReadLock();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				K[] array = new K[baseDictionary.Keys.Count];
				int num3 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
				{
					num3 = 0;
				}
				while (true)
				{
					switch (num3)
					{
					default:
						return result;
					case 0:
						return result;
					case 1:
						result = array;
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
						{
							num3 = 0;
						}
						break;
					case 2:
						baseDictionary.Keys.CopyTo(array, 0);
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
						{
							num3 = 1;
						}
						break;
					}
				}
			}
			finally
			{
				readerWriterLock.ExitReadLock();
				int num4 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
				{
					num4 = 0;
				}
				switch (num4)
				{
				case 0:
					break;
				}
			}
		}
	}

	public L[] CloneSubKeys()
	{
		//Discarded unreachable code: IL_0082, IL_0111, IL_0124, IL_0133
		int num = 2;
		int num2 = num;
		L[] result = default(L[]);
		while (true)
		{
			switch (num2)
			{
			case 2:
				readerWriterLock.EnterReadLock();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
				{
					num2 = 1;
				}
				break;
			default:
				return result;
			case 1:
				try
				{
					L[] array = new L[subDictionary.Keys.Count];
					int num3 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
					{
						num3 = 1;
					}
					while (true)
					{
						switch (num3)
						{
						case 1:
							return result;
						default:
							result = array;
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
							{
								num3 = 1;
							}
							break;
						case 2:
							subDictionary.Keys.CopyTo(array, 0);
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
							{
								num3 = 0;
							}
							break;
						}
					}
				}
				finally
				{
					readerWriterLock.ExitReadLock();
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
			}
		}
	}

	public void Clear()
	{
		//Discarded unreachable code: IL_0074, IL_00f2, IL_0105, IL_0114
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				readerWriterLock.EnterWriteLock();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 1:
				try
				{
					baseDictionary.Clear();
					int num3 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
					{
						num3 = 1;
					}
					while (true)
					{
						switch (num3)
						{
						case 2:
							return;
						case 1:
							subDictionary.Clear();
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
							{
								num3 = 0;
							}
							break;
						default:
							primaryToSubkeyMapping.Clear();
							num3 = 2;
							break;
						}
					}
				}
				finally
				{
					readerWriterLock.ExitWriteLock();
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
			}
		}
	}

	public IEnumerator<KeyValuePair<K, V>> GetEnumerator()
	{
		readerWriterLock.EnterReadLock();
		try
		{
			return baseDictionary.GetEnumerator();
		}
		finally
		{
			readerWriterLock.ExitReadLock();
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable)baseDictionary).GetEnumerator();
	}

	void ICollection<KeyValuePair<K, V>>.Add(KeyValuePair<K, V> item)
	{
		Add(item.Key, item.Value);
	}

	bool ICollection<KeyValuePair<K, V>>.Contains(KeyValuePair<K, V> item)
	{
		readerWriterLock.EnterReadLock();
		try
		{
			return baseDictionary.Contains(item);
		}
		finally
		{
			readerWriterLock.ExitReadLock();
		}
	}

	void ICollection<KeyValuePair<K, V>>.CopyTo(KeyValuePair<K, V>[] array, int arrayIndex)
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
				((ICollection<KeyValuePair<K, V>>)baseDictionary).CopyTo(array, arrayIndex);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	bool ICollection<KeyValuePair<K, V>>.Remove(KeyValuePair<K, V> item)
	{
		Remove(item.Key);
		return true;
	}

	public MultiKeyDictionary()
	{
		//Discarded unreachable code: IL_006a, IL_006f
		SingletonReader.JJCZtPuTvSt();
		baseDictionary = new Dictionary<K, V>();
		subDictionary = new Dictionary<L, K>();
		primaryToSubkeyMapping = new Dictionary<K, L>();
		readerWriterLock = new ReaderWriterLockSlim();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool c5QGF1mVmoCyqI6ej0O()
	{
		return en7F07mIOtOoowpqNrH == null;
	}

	internal static object xxs14kmSBk5aete92Ck()
	{
		return en7F07mIOtOoowpqNrH;
	}
}
