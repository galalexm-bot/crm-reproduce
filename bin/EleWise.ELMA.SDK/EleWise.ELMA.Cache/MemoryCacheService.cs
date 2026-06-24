using System;
using System.Linq;
using System.Runtime.Caching;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Cache;

[Service(EnableInterceptors = false, Type = ComponentType.Server)]
public class MemoryCacheService : IMemoryCacheService
{
	[Serializable]
	internal struct NullValue
	{
		public static readonly NullValue Null;

		[UsedImplicitly]
		private byte value;

		internal static object aY9shu8LVeL0kR47jtsu;

		private NullValue(byte value)
		{
			JGwCfA8LRxDBGyiCyNrc();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				default:
				{
					this = default(NullValue);
					int num2 = 2;
					num = num2;
					break;
				}
				case 1:
					return;
				case 2:
					this.value = value;
					num = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
					{
						num = 0;
					}
					break;
				}
			}
		}

		static NullValue()
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					Null = new NullValue(0);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					JGwCfA8LRxDBGyiCyNrc();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}

		internal static void JGwCfA8LRxDBGyiCyNrc()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool l1xuUG8LS6PB13tRU8ig()
		{
			return aY9shu8LVeL0kR47jtsu == null;
		}

		internal static object jfGsLS8LiccWt1el3XpX()
		{
			return aY9shu8LVeL0kR47jtsu;
		}
	}

	private readonly MemoryCache privateCache;

	private static MemoryCacheService F6VVuSfKT7lecTocaah5;

	public bool TryGetValue<T>(string key, out T result)
	{
		if (key == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-889460160 ^ -889545248));
		}
		result = default(T);
		CacheItem cacheItem = privateCache.GetCacheItem(key);
		if (cacheItem != null)
		{
			object value = cacheItem.Value;
			if (value is NullValue)
			{
				result = default(T);
			}
			else
			{
				result = (T)value;
			}
		}
		return cacheItem != null;
	}

	public bool Contains(string key)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (key == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return kPrMvVfKO3nn58aVUdOm(privateCache, key, null);
			default:
				throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5DD55050 ^ 0x5DD427F0));
			}
		}
	}

	public void Insert<T>(string key, T value)
	{
		if (key == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-195614443 ^ -195666251));
		}
		Insert(key, value, TimeSpan.Zero);
	}

	public void Insert<T>(string key, T value, TimeSpan timeout)
	{
		if (key == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1751176224 ^ -1751229376));
		}
		object obj = value;
		if (obj == null)
		{
			obj = NullValue.Null;
		}
		privateCache.Set(key, obj, (timeout.Ticks > 0) ? DateTimeOffset.Now.Add(timeout) : ObjectCache.InfiniteAbsoluteExpiration);
	}

	public void Remove(string key)
	{
		//Discarded unreachable code: IL_0031, IL_0040
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (key != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			case 3:
				return;
			default:
				throw new ArgumentNullException((string)Swn6mIfK2X6TU80pMeEd(-606654180 ^ -606714180));
			case 1:
				cxh54BfKeShbHGUxXeBm(privateCache, key, null);
				num2 = 3;
				break;
			}
		}
	}

	public void RemoveBySubkey(string subkey)
	{
		//Discarded unreachable code: IL_004f, IL_005e
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass5_0 _003C_003Ec__DisplayClass5_ = default(_003C_003Ec__DisplayClass5_0);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 4:
				_003C_003Ec__DisplayClass5_._003C_003E4__this = this;
				num2 = 3;
				break;
			case 5:
				throw new ArgumentNullException((string)Swn6mIfK2X6TU80pMeEd(0x26FFCB59 ^ 0x26FA8FED));
			case 6:
				privateCache.Where(_003C_003Ec__DisplayClass5_._003CRemoveBySubkey_003Eb__0).ForEach(_003C_003Ec__DisplayClass5_._003CRemoveBySubkey_003Eb__1);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				_003C_003Ec__DisplayClass5_ = new _003C_003Ec__DisplayClass5_0();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 3:
				if (_003C_003Ec__DisplayClass5_.subkey != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
					{
						num2 = 6;
					}
					break;
				}
				goto case 5;
			case 1:
				_003C_003Ec__DisplayClass5_.subkey = subkey;
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
				{
					num2 = 3;
				}
				break;
			}
		}
	}

	public MemoryCacheService()
	{
		//Discarded unreachable code: IL_0040, IL_0045
		E0AFbLfKPvuBUA1GH9hM();
		privateCache = new MemoryCache("EleWise.ELMA.Cache.MemoryCacheService");
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool kPrMvVfKO3nn58aVUdOm(object P_0, object P_1, object P_2)
	{
		return ((ObjectCache)P_0).Contains((string)P_1, (string)P_2);
	}

	internal static bool zDHsCAfKk6FZGNW3pvQx()
	{
		return F6VVuSfKT7lecTocaah5 == null;
	}

	internal static MemoryCacheService qSMdxRfKn05Vth7i8Jyb()
	{
		return F6VVuSfKT7lecTocaah5;
	}

	internal static object Swn6mIfK2X6TU80pMeEd(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object cxh54BfKeShbHGUxXeBm(object P_0, object P_1, object P_2)
	{
		return ((ObjectCache)P_0).Remove((string)P_1, (string)P_2);
	}

	internal static void E0AFbLfKPvuBUA1GH9hM()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
