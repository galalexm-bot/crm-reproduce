using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Locking;

[Service(EnableInterceptors = false, InjectProperties = false)]
internal sealed class LockKeyFactory : ILockKeyFactory
{
	private sealed class KeyObject : IDisposable
	{
		private readonly object keyName;

		private readonly object lockKeyFactory;

		private long keyCount;

		private static object hSHgHXv7qbHKaIhI2ux3;

		public KeyObject(string keyName, LockKeyFactory lockKeyFactory)
		{
			//Discarded unreachable code: IL_002a, IL_002f
			S6Sy5ev7Tkp6CiMAmCxc();
			base._002Ector();
			int num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					this.keyName = keyName;
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
					{
						num = 0;
					}
					break;
				case 2:
					keyCount = 1L;
					num = 3;
					break;
				case 3:
					return;
				default:
					this.lockKeyFactory = lockKeyFactory;
					num = 2;
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void AddRef()
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
					Interlocked.Increment(ref keyCount);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}

		public void Dispose()
		{
			//Discarded unreachable code: IL_0050, IL_009d, IL_00ac, IL_0108, IL_011b, IL_012a
			switch (1)
			{
			case 0:
				break;
			case 1:
				try
				{
					((LockKeyFactory)lockKeyFactory).poolLock.Wait();
					int num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
					{
						num = 0;
					}
					while (true)
					{
						switch (num)
						{
						case 2:
							return;
						case 3:
							return;
						default:
							if (Interlocked.Decrement(ref keyCount) != 0L)
							{
								num = 3;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
								{
									num = 0;
								}
								continue;
							}
							break;
						case 1:
							break;
						}
						((LockKeyFactory)lockKeyFactory).pool.Remove((string)keyName);
						num = 2;
					}
				}
				finally
				{
					qG6p6Kv7kjQkw6yJbmw8(((LockKeyFactory)lockKeyFactory).poolLock);
					int num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
					{
						num2 = 0;
					}
					switch (num2)
					{
					case 0:
						break;
					}
				}
			}
		}

		public override bool Equals(object obj)
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (!(obj is KeyObject keyObject))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
						{
							num2 = 0;
						}
						break;
					}
					return RqJJfvv7nabeo5C0N01e(keyObject.keyName, keyName);
				default:
					return false;
				}
			}
		}

		public override int GetHashCode()
		{
			return keyName.GetHashCode();
		}

		internal static void S6Sy5ev7Tkp6CiMAmCxc()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool HB0dBxv7Kl3ot4Z5meUb()
		{
			return hSHgHXv7qbHKaIhI2ux3 == null;
		}

		internal static KeyObject eJRl7vv7XTOSikr5m5Gb()
		{
			return (KeyObject)hSHgHXv7qbHKaIhI2ux3;
		}

		internal static int qG6p6Kv7kjQkw6yJbmw8(object P_0)
		{
			return ((SemaphoreSlim)P_0).Release();
		}

		internal static bool RqJJfvv7nabeo5C0N01e(object P_0, object P_1)
		{
			return (string)P_0 == (string)P_1;
		}
	}

	private readonly IDictionary<string, KeyObject> pool;

	private readonly SemaphoreSlim poolLock;

	internal static LockKeyFactory pO5Ytfhrkgnce4XoW9PB;

	public IDisposable Get(string keyName)
	{
		//Discarded unreachable code: IL_003d, IL_006c, IL_00f9, IL_014c, IL_015f, IL_016e
		IDisposable result = default(IDisposable);
		switch (1)
		{
		default:
			return result;
		case 1:
			try
			{
				LKDsMPhr2Tl4IbjMZqK6(poolLock);
				int num = 3;
				KeyObject value = default(KeyObject);
				while (true)
				{
					switch (num)
					{
					case 2:
						return result;
					case 1:
					case 5:
						pool.Add(keyName, value = new KeyObject(keyName, this));
						num = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
						{
							num = 4;
						}
						break;
					case 3:
						if (!pool.TryGetValue(keyName, out value))
						{
							num = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
							{
								num = 1;
							}
							break;
						}
						goto case 6;
					case 6:
						XhRqguhrel9TNWeloduX(value);
						num = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
						{
							num = 0;
						}
						break;
					default:
						result = value;
						num = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
						{
							num = 2;
						}
						break;
					}
				}
			}
			finally
			{
				aBiQ6IhrPPV9PxQcsd7R(poolLock);
				int num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				case 0:
					break;
				}
			}
		}
	}

	public LockKeyFactory()
	{
		//Discarded unreachable code: IL_004c, IL_0051
		hqhiXIhr1kDpdQ0lH7LC();
		pool = new Dictionary<string, KeyObject>();
		poolLock = new SemaphoreSlim(1, 1);
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void LKDsMPhr2Tl4IbjMZqK6(object P_0)
	{
		((SemaphoreSlim)P_0).Wait();
	}

	internal static void XhRqguhrel9TNWeloduX(object P_0)
	{
		((KeyObject)P_0).AddRef();
	}

	internal static int aBiQ6IhrPPV9PxQcsd7R(object P_0)
	{
		return ((SemaphoreSlim)P_0).Release();
	}

	internal static bool WpiFpMhrncHPYwH6QD97()
	{
		return pO5Ytfhrkgnce4XoW9PB == null;
	}

	internal static LockKeyFactory TOMesBhrO4PCVsSiGI9d()
	{
		return pO5Ytfhrkgnce4XoW9PB;
	}

	internal static void hqhiXIhr1kDpdQ0lH7LC()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
