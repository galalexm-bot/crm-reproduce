using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Cache;

[Service(EnableInterceptors = false, Type = ComponentType.Server)]
public class UnionComplexCacheService : ComplexCacheServiceBase, IUnionComplexCacheService
{
	private readonly string _timestampKey;

	private readonly string _timestampsKey;

	internal static UnionComplexCacheService clssTdfq6QiHBcYZZ0KN;

	public UnionComplexCacheService(ICacheService cacheService, IMemoryCacheService memoryCacheService, IContextBoundVariableService contextCacheService)
	{
		//Discarded unreachable code: IL_006f, IL_0074
		SingletonReader.JJCZtPuTvSt();
		_timestampKey = z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x10E41EDB ^ 0x10E15D09);
		_timestampsKey = (string)lNt5ULfq74kyoXdQct0D(0x53FA00CE ^ 0x53FF44D4);
		base._002Ector(cacheService, memoryCacheService, contextCacheService);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public override void RefreshTimestamp(string timestampKey, string timestampRegionKey)
	{
		//Discarded unreachable code: IL_009d
		int num = 6;
		int num2 = num;
		_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = default(_003C_003Ec__DisplayClass1_0);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				setTimestamps(_003C_003Ec__DisplayClass1_.timestampKey, DateTime.Now.Ticks);
				num2 = 7;
				break;
			case 3:
				base.UnitOfWorkManager.RegisterPostCommitAction(_003C_003Ec__DisplayClass1_._003CRefreshTimestamp_003Eb__0);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 4:
				return;
			case 6:
				_003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_0();
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				_003C_003Ec__DisplayClass1_.timestampKey = timestampKey;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
				{
					num2 = 0;
				}
				break;
			case 8:
				if (!base.UnitOfWorkManager.HasActiveTransaction(""))
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 3;
			case 7:
				if (base.UnitOfWorkManager == null)
				{
					return;
				}
				num2 = 8;
				break;
			case 5:
				_003C_003Ec__DisplayClass1_._003C_003E4__this = this;
				num2 = 2;
				break;
			}
		}
	}

	protected SerializableDictionary<string, long> getTimestamps()
	{
		if (_contextCacheService.TryGetValue<SerializableDictionary<string, long>>(_timestampsKey, out var value))
		{
			return value;
		}
		_cacheService.TryGetValue<long>(_timestampKey, out var value2);
		if (_memoryCacheService.TryGetValue<CacheEntry<SerializableDictionary<string, long>>>(_timestampsKey, out var result) && result.Timestamp == value2)
		{
			value = result.Value;
		}
		else
		{
			if (!_cacheService.TryGetValue<SerializableDictionary<string, long>>(_timestampsKey, out value))
			{
				value = new SerializableDictionary<string, long>();
			}
			_memoryCacheService.Insert(_timestampsKey, new CacheEntry<SerializableDictionary<string, long>>
			{
				Timestamp = value2,
				Value = value
			});
		}
		_contextCacheService.Set(_timestampsKey, value);
		return value;
	}

	private void setTimestamps(string timestampKey, long timestamp)
	{
		int num = 2;
		int num2 = num;
		SerializableDictionary<string, long> serializableDictionary = default(SerializableDictionary<string, long>);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				_contextCacheService.Set(timestampKey, "EleWise.ELMA.Cache.ComplexCacheService", timestamp);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 6:
				_cacheService.Insert(_timestampKey, timestamp);
				num2 = 3;
				break;
			case 1:
				serializableDictionary = new SerializableDictionary<string, long>(getTimestamps());
				num2 = 5;
				break;
			case 4:
				h0HXpYfqxKg49cuBCf1I(_contextCacheService, _timestampsKey, serializableDictionary);
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
				{
					num2 = 6;
				}
				break;
			case 3:
			{
				IMemoryCacheService memoryCacheService = _memoryCacheService;
				string timestampsKey = _timestampsKey;
				CacheEntry<SerializableDictionary<string, long>> cacheEntry = new CacheEntry<SerializableDictionary<string, long>>();
				r8iAyAfq0G1eB2P40wwG(cacheEntry, timestamp);
				cacheEntry.Value = serializableDictionary;
				memoryCacheService.Insert(timestampsKey, cacheEntry);
				num2 = 7;
				break;
			}
			case 5:
				serializableDictionary[timestampKey] = timestamp;
				num2 = 4;
				break;
			case 7:
				_cacheService.Insert(_timestampsKey, serializableDictionary);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected override bool TryGetFromGlobalCache<T>(string key, string timestampKey, string timestampRegionKey, out T value)
	{
		SerializableDictionary<string, long> timestamps = getTimestamps();
		long value2 = 0L;
		timestamps.TryGetValue(timestampKey, out var value3);
		if (timestampRegionKey != null)
		{
			timestamps.TryGetValue(timestampRegionKey, out value2);
		}
		if (_memoryCacheService.TryGetValue<CacheEntry<T>>(key, out var result) && result.Timestamp == value3 && result.RegionTimestamp == value2)
		{
			value = result.Value;
			return true;
		}
		value = default(T);
		return false;
	}

	protected override void SaveToGlobalCache<T>(string key, string timestampKey, string timestampRegionKey, T value, TimeSpan? timeout)
	{
		SerializableDictionary<string, long> timestamps = getTimestamps();
		long value2 = 0L;
		timestamps.TryGetValue(timestampKey, out var value3);
		if (timestampRegionKey != null)
		{
			timestamps.TryGetValue(timestampRegionKey, out value2);
		}
		if (timeout.HasValue)
		{
			_memoryCacheService.Insert(key, new CacheEntry<T>
			{
				Timestamp = value3,
				RegionTimestamp = value2,
				Value = value
			}, timeout.Value);
		}
		else
		{
			_memoryCacheService.Insert(key, new CacheEntry<T>
			{
				Timestamp = value3,
				RegionTimestamp = value2,
				Value = value
			});
		}
	}

	internal static object lNt5ULfq74kyoXdQct0D(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool M0kIT3fqH9IXrr9Qpeya()
	{
		return clssTdfq6QiHBcYZZ0KN == null;
	}

	internal static UnionComplexCacheService qtIXprfqAQvNekq0Zrj5()
	{
		return clssTdfq6QiHBcYZZ0KN;
	}

	internal static void h0HXpYfqxKg49cuBCf1I(object P_0, object P_1, object P_2)
	{
		((IAbstractBoundVariableService)P_0).Set((string)P_1, P_2);
	}

	internal static void r8iAyAfq0G1eB2P40wwG(object P_0, long P_1)
	{
		((CacheEntry<SerializableDictionary<string, long>>)P_0).Timestamp = P_1;
	}
}
