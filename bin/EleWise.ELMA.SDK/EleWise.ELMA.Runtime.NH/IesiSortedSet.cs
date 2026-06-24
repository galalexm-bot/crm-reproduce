using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using Iesi.Collections;
using Iesi.Collections.Generic;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Runtime.NH;

public class IesiSortedSet<T> : SortedSet<T>, ISet<T>, ISet<T>, ICollection<T>, IEnumerable<T>, IEnumerable, ISet, ICollection
{
	internal static object bW9vdCWpNx9iVbI0R7rX;

	public bool IsEmpty => base.Count == 0;

	public IesiSortedSet()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public static IesiSortedSet<T> Create<TKey>(Func<T, TKey> propertyExpression, ListSortDirection order)
	{
		return new IesiSortedSet<T>(GetComparer(propertyExpression, order));
	}

	[Obsolete("Use Create<TKey>(Func<T, TKey>, ListSortDirection) instead", true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static IesiSortedSet<T> Create<TKey>(string typeUidProperty, string subTypeUidProperty, Func<T, TKey> propertyExpression, ListSortDirection order)
	{
		return new IesiSortedSet<T>(GetComparer(propertyExpression, order));
	}

	private static IComparer<T> GetComparer<TKey>(Func<T, TKey> propertyExpression, ListSortDirection order)
	{
		return ((ISortedProperty)MetadataServiceContext.Service.GetTypeDescriptor(typeof(TKey))).GetComparer(propertyExpression, order);
	}

	public IesiSortedSet(IComparer<T> comparer)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(comparer);
	}

	public IesiSortedSet(IEnumerable<T> collection)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(collection);
	}

	public IesiSortedSet(IEnumerable<T> collection, IComparer<T> comparer)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(collection, comparer);
	}

	public bool ContainsAll(ICollection<T> c)
	{
		foreach (T item in (IEnumerable)c)
		{
			if (!Contains(item))
			{
				return false;
			}
		}
		return true;
	}

	public bool AddAll(ICollection<T> c)
	{
		bool flag = false;
		foreach (T item in (IEnumerable)c)
		{
			flag |= Add(item);
		}
		return flag;
	}

	public bool RemoveAll(ICollection<T> c)
	{
		bool flag = false;
		foreach (T item in (IEnumerable)c)
		{
			flag |= Remove(item);
		}
		return flag;
	}

	public bool RetainAll(ICollection<T> c)
	{
		_003C_003Ec__DisplayClass10_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass10_0();
		CS_0024_003C_003E8__locals0.cSet = new HashSet<T>((IEnumerable<T>)c);
		return RemoveWhere((T o) => !((Set<T>)(object)CS_0024_003C_003E8__locals0.cSet).Contains(o)) > 0;
	}

	bool ISet.Contains(object o)
	{
		return Contains((T)o);
	}

	bool ISet.ContainsAll(ICollection c)
	{
		//Discarded unreachable code: IL_002e, IL_0038, IL_00b4, IL_00c3, IL_00d3, IL_012a, IL_0187, IL_0196
		int num = 1;
		int num2 = num;
		IEnumerator enumerator = default(IEnumerator);
		T item = default(T);
		bool result = default(bool);
		while (true)
		{
			switch (num2)
			{
			default:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
							{
								num3 = 4;
							}
							goto IL_003c;
						}
						goto IL_00ea;
						IL_00ea:
						item = (T)enumerator.Current;
						num3 = 6;
						goto IL_003c;
						IL_003c:
						while (true)
						{
							switch (num3)
							{
							case 6:
								if (Contains(item))
								{
									num3 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
									{
										num3 = 0;
									}
									continue;
								}
								goto default;
							case 1:
							case 3:
								break;
							default:
								result = false;
								num3 = 2;
								continue;
							case 5:
								goto IL_00ea;
							case 4:
								goto end_IL_0089;
							case 2:
								return result;
							}
							break;
						}
						continue;
						end_IL_0089:
						break;
					}
				}
				finally
				{
					IDisposable disposable = enumerator as IDisposable;
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
					{
						num4 = 0;
					}
					while (true)
					{
						switch (num4)
						{
						default:
							if (disposable != null)
							{
								num4 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
								{
									num4 = 1;
								}
								continue;
							}
							break;
						case 2:
							disposable.Dispose();
							num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
							{
								num4 = 1;
							}
							continue;
						case 1:
							break;
						}
						break;
					}
				}
				break;
			case 1:
				enumerator = c.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				break;
			}
			break;
		}
		return true;
	}

	bool ISet.Add(object o)
	{
		return Add((T)o);
	}

	bool ISet.AddAll(ICollection c)
	{
		//Discarded unreachable code: IL_0032, IL_0041, IL_004c, IL_00e7, IL_0144, IL_0153
		int num = 3;
		int num2 = num;
		IEnumerator enumerator = default(IEnumerator);
		bool flag = default(bool);
		T item = default(T);
		while (true)
		{
			switch (num2)
			{
			case 1:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 3;
							goto IL_0050;
						}
						goto IL_00a7;
						IL_0050:
						while (true)
						{
							switch (num3)
							{
							case 2:
								flag |= Add(item);
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
								{
									num3 = 1;
								}
								continue;
							case 1:
								break;
							default:
								goto IL_00a7;
							case 3:
								return flag;
							}
							break;
						}
						continue;
						IL_00a7:
						item = (T)enumerator.Current;
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
						{
							num3 = 2;
						}
						goto IL_0050;
					}
				}
				finally
				{
					IDisposable disposable = enumerator as IDisposable;
					int num4 = 2;
					while (true)
					{
						switch (num4)
						{
						case 1:
							disposable.Dispose();
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
							{
								num4 = 0;
							}
							continue;
						case 2:
							if (disposable != null)
							{
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
								{
									num4 = 1;
								}
								continue;
							}
							break;
						case 0:
							break;
						}
						break;
					}
				}
			default:
				return flag;
			case 2:
				enumerator = c.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				flag = false;
				num2 = 2;
				break;
			}
		}
	}

	bool ISet.Remove(object o)
	{
		return Remove((T)o);
	}

	bool ISet.RemoveAll(ICollection c)
	{
		//Discarded unreachable code: IL_0064, IL_0073, IL_007e, IL_0119, IL_0176, IL_0185
		int num = 3;
		int num2 = num;
		bool flag = default(bool);
		IEnumerator enumerator = default(IEnumerator);
		T item = default(T);
		while (true)
		{
			switch (num2)
			{
			default:
				return flag;
			case 2:
				enumerator = c.GetEnumerator();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				flag = false;
				num2 = 2;
				break;
			case 1:
				try
				{
					while (true)
					{
						IL_00db:
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
							{
								num3 = 1;
							}
							goto IL_0082;
						}
						goto IL_009c;
						IL_009c:
						item = (T)enumerator.Current;
						num3 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
						{
							num3 = 2;
						}
						goto IL_0082;
						IL_0082:
						while (true)
						{
							switch (num3)
							{
							case 1:
								return flag;
							case 2:
								flag |= Remove(item);
								num3 = 3;
								continue;
							case 3:
								goto IL_00db;
							}
							break;
						}
						goto IL_009c;
					}
				}
				finally
				{
					IDisposable disposable = enumerator as IDisposable;
					int num4 = 2;
					while (true)
					{
						switch (num4)
						{
						case 2:
							if (disposable != null)
							{
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
								{
									num4 = 0;
								}
								continue;
							}
							break;
						default:
							disposable.Dispose();
							num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
							{
								num4 = 0;
							}
							continue;
						case 1:
							break;
						}
						break;
					}
				}
			}
		}
	}

	bool ISet.RetainAll(ICollection c)
	{
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass19_0 _003C_003Ec__DisplayClass19_ = default(_003C_003Ec__DisplayClass19_0);
		while (true)
		{
			switch (num2)
			{
			default:
				_003C_003Ec__DisplayClass19_.cSet = new HashSet<T>((IEnumerable<T>)c);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return RemoveWhere(_003C_003Ec__DisplayClass19_._003CIesi_002ECollections_002EISet_002ERetainAll_003Eb__0) > 0;
			case 1:
				_003C_003Ec__DisplayClass19_ = new _003C_003Ec__DisplayClass19_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool GGEcZaWp3b6oo8964IoI()
	{
		return bW9vdCWpNx9iVbI0R7rX == null;
	}

	internal static object zM2si7Wpp83gE0VxlmEF()
	{
		return bW9vdCWpNx9iVbI0R7rX;
	}
}
