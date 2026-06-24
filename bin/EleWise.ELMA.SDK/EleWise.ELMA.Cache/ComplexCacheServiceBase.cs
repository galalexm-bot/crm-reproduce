using System;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Cache;

public abstract class ComplexCacheServiceBase
{
	protected class CacheEntry<T>
	{
		internal static object u0D6yR8YprvTVxG090Cl;

		public T Value { get; set; }

		public long Timestamp
		{
			[CompilerGenerated]
			get
			{
				return _003CTimestamp_003Ek__BackingField;
			}
			[CompilerGenerated]
			set
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
						_003CTimestamp_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public long RegionTimestamp
		{
			[CompilerGenerated]
			get
			{
				return _003CRegionTimestamp_003Ek__BackingField;
			}
			[CompilerGenerated]
			set
			{
				int num = 1;
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
						_003CRegionTimestamp_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public CacheEntry()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool TONmh58Ya3cGnZwsLKIb()
		{
			return u0D6yR8YprvTVxG090Cl == null;
		}

		internal static object RJiFJd8YD0cR8U97rHkr()
		{
			return u0D6yR8YprvTVxG090Cl;
		}
	}

	protected const string ContextCacheServiceRegion = "EleWise.ELMA.Cache.ComplexCacheService";

	protected ICacheService _cacheService;

	protected IMemoryCacheService _memoryCacheService;

	protected IContextBoundVariableService _contextCacheService;

	private IUnitOfWorkManager _unitOfWorkManager;

	internal static ComplexCacheServiceBase xDtsITfqfFhfDXK00uAv;

	protected IUnitOfWorkManager UnitOfWorkManager
	{
		get
		{
			//Discarded unreachable code: IL_0031, IL_0040
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (_unitOfWorkManager != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				default:
					return _unitOfWorkManager;
				case 2:
					break;
				}
				_unitOfWorkManager = (FH8UZOfqV3488GES9YYj() ? Locator.GetService<IUnitOfWorkManager>() : null);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
				{
					num2 = 0;
				}
			}
		}
	}

	protected ComplexCacheServiceBase(ICacheService cacheService, IMemoryCacheService memoryCacheService, IContextBoundVariableService contextCacheService)
	{
		//Discarded unreachable code: IL_002a, IL_0062
		fp6yx4fqv8e6IhPCpNPd();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 7:
				_contextCacheService = contextCacheService;
				num = 3;
				continue;
			case 4:
				throw new ArgumentNullException((string)MosiNWfq8x3WwHKKqRRl(-35995181 ^ -35683657));
			case 1:
				if (cacheService != null)
				{
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
					{
						num = 0;
					}
					continue;
				}
				goto case 5;
			case 3:
				return;
			case 2:
				_memoryCacheService = memoryCacheService;
				num = 7;
				continue;
			case 5:
				throw new ArgumentNullException((string)MosiNWfq8x3WwHKKqRRl(-16752921 ^ -16441913));
			case 6:
				throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-234299632 ^ -233989076));
			}
			int num2;
			if (memoryCacheService == null)
			{
				num2 = 6;
			}
			else
			{
				if (contextCacheService == null)
				{
					num = 4;
					continue;
				}
				_cacheService = cacheService;
				num2 = 2;
			}
			num = num2;
		}
	}

	public virtual T GetOrAdd<T>(string key, string timestampKey, Func<T> valueAccessor)
	{
		return GetOrAdd(key, timestampKey, null, valueAccessor, null);
	}

	public virtual T GetOrAdd<T>(string key, string timestampKey, Func<T> valueAccessor, TimeSpan timeout)
	{
		return GetOrAdd(key, timestampKey, (string)null, valueAccessor, (TimeSpan?)timeout);
	}

	public virtual T GetOrAdd<T>(string key, string timestampKey, string timestampRegionKey, Func<T> valueAccessor)
	{
		return GetOrAdd(key, timestampKey, timestampRegionKey, valueAccessor, null);
	}

	public virtual T GetOrAdd<T>(string key, string timestampKey, string timestampRegionKey, Func<T> valueAccessor, TimeSpan timeout)
	{
		return GetOrAdd(key, timestampKey, timestampRegionKey, valueAccessor, (TimeSpan?)timeout);
	}

	protected virtual T GetOrAdd<T>(string key, string timestampKey, string timestampRegionKey, Func<T> valueAccessor, TimeSpan? timeout)
	{
		if (string.IsNullOrEmpty(key))
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34A6D230 ^ 0x34A7A590));
		}
		if (string.IsNullOrEmpty(timestampKey))
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x638095EB ^ 0x6385D665));
		}
		if (valueAccessor == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x66F566B6 ^ 0x66F0251C));
		}
		if (TryGetFromContextCache<T>(key, timestampKey, timestampRegionKey, out var value))
		{
			return value;
		}
		if (!TryGetFromGlobalCache<T>(key, timestampKey, timestampRegionKey, out value))
		{
			value = valueAccessor();
			SaveToGlobalCache(key, timestampKey, timestampRegionKey, value, timeout);
		}
		SaveToContextCache(key, timestampKey, timestampRegionKey, value);
		return value;
	}

	public virtual void RefreshTimestamp(string timestampKey)
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
				PwtUxGfqZDmpBHvlNQh9(this, timestampKey, null);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public virtual void RefreshTimestamp(string timestampKey, string timestampRegionKey)
	{
		int num = 9;
		long ticks = default(long);
		DateTime now = default(DateTime);
		_003C_003Ec__DisplayClass8_0 _003C_003Ec__DisplayClass8_ = default(_003C_003Ec__DisplayClass8_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (UnitOfWorkManager != null)
					{
						num2 = 6;
						break;
					}
					return;
				case 1:
					ticks = now.Ticks;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
					{
						num2 = 0;
					}
					break;
				case 5:
					_003C_003Ec__DisplayClass8_.timestampKey = timestampKey;
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
					{
						num2 = 3;
					}
					break;
				case 3:
					_cacheService.Insert(_003C_003Ec__DisplayClass8_.timestampKey, ticks);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					_contextCacheService.Set(_003C_003Ec__DisplayClass8_.timestampKey, "EleWise.ELMA.Cache.ComplexCacheService", ticks);
					num2 = 3;
					break;
				case 10:
					yTLSpxfqIFu8xCB0nkri(UnitOfWorkManager, new Action(_003C_003Ec__DisplayClass8_._003CRefreshTimestamp_003Eb__0));
					num2 = 7;
					break;
				case 9:
					_003C_003Ec__DisplayClass8_ = new _003C_003Ec__DisplayClass8_0();
					num2 = 8;
					break;
				case 6:
					if (!UcOxcrfquSYVrKRZ7kFo(UnitOfWorkManager, ""))
					{
						return;
					}
					goto end_IL_0012;
				case 8:
					_003C_003Ec__DisplayClass8_._003C_003E4__this = this;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
					{
						num2 = 5;
					}
					break;
				case 7:
					return;
				case 4:
					now = DateTime.Now;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
					{
						num2 = 1;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 10;
		}
	}

	public virtual void RefreshTimestampRegion(string timestampRegionKey)
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
				PwtUxGfqZDmpBHvlNQh9(this, timestampRegionKey, null);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	protected virtual bool TryGetFromGlobalCache<T>(string key, string timestampKey, string timestampRegionKey, out T value)
	{
		long value2 = 0L;
		_cacheService.TryGetValue<long>(timestampKey, out var value3);
		if (timestampRegionKey != null)
		{
			_cacheService.TryGetValue<long>(timestampRegionKey, out value2);
		}
		if (_memoryCacheService.TryGetValue<CacheEntry<T>>(key, out var result) && result.Timestamp == value3 && result.RegionTimestamp == value2)
		{
			value = result.Value;
			return true;
		}
		value = default(T);
		return false;
	}

	protected virtual void SaveToGlobalCache<T>(string key, string timestampKey, string timestampRegionKey, T value, TimeSpan? timeout)
	{
		long value2 = 0L;
		_cacheService.TryGetValue<long>(timestampKey, out var value3);
		if (timestampRegionKey != null)
		{
			_cacheService.TryGetValue<long>(timestampRegionKey, out value2);
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

	private bool TryGetFromContextCache<T>(string key, string timestampKey, string timestampRegionKey, out T value)
	{
		long result = 0L;
		_contextCacheService.TryGetValue<long>(timestampKey, "EleWise.ELMA.Cache.ComplexCacheService", out var result2);
		if (timestampRegionKey != null)
		{
			_contextCacheService.TryGetValue<long>(timestampRegionKey, "EleWise.ELMA.Cache.ComplexCacheService", out result);
		}
		if (_contextCacheService.TryGetValue<CacheEntry<T>>(key, "EleWise.ELMA.Cache.ComplexCacheService", out var result3) && result3.Timestamp == result2 && result3.RegionTimestamp == result)
		{
			value = result3.Value;
			return true;
		}
		value = default(T);
		return false;
	}

	private void SaveToContextCache<T>(string key, string timestampKey, string timestampRegionKey, T value)
	{
		long result = 0L;
		_contextCacheService.TryGetValue<long>(timestampKey, "EleWise.ELMA.Cache.ComplexCacheService", out var result2);
		if (timestampRegionKey != null)
		{
			_contextCacheService.TryGetValue<long>(timestampRegionKey, "EleWise.ELMA.Cache.ComplexCacheService", out result);
		}
		_contextCacheService.Set(key, "EleWise.ELMA.Cache.ComplexCacheService", new CacheEntry<T>
		{
			Timestamp = result2,
			RegionTimestamp = result,
			Value = value
		});
	}

	internal static void fp6yx4fqv8e6IhPCpNPd()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object MosiNWfq8x3WwHKKqRRl(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool ouCrrHfqQ3e8gx71B8RB()
	{
		return xDtsITfqfFhfDXK00uAv == null;
	}

	internal static ComplexCacheServiceBase lboc4yfqCPSNE61W08Bt()
	{
		return xDtsITfqfFhfDXK00uAv;
	}

	internal static void PwtUxGfqZDmpBHvlNQh9(object P_0, object P_1, object P_2)
	{
		((ComplexCacheServiceBase)P_0).RefreshTimestamp((string)P_1, (string)P_2);
	}

	internal static bool UcOxcrfquSYVrKRZ7kFo(object P_0, object P_1)
	{
		return ((IUnitOfWorkManager)P_0).HasActiveTransaction((string)P_1);
	}

	internal static void yTLSpxfqIFu8xCB0nkri(object P_0, object P_1)
	{
		((IUnitOfWorkManager)P_0).RegisterPostCommitAction((Action)P_1);
	}

	internal static bool FH8UZOfqV3488GES9YYj()
	{
		return Locator.Initialized;
	}
}
