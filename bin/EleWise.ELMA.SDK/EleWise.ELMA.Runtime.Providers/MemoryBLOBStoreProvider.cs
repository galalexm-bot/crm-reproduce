using System;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.Providers;

[Service(Type = ComponentType.Server)]
public class MemoryBLOBStoreProvider : BLOBStoreProvider
{
	private static PoolBasedSettingsService _impl;

	private static readonly Guid NullGuid;

	private IComplexCacheService _complexCacheService;

	internal static MemoryBLOBStoreProvider uOGFjSWEGOKynascqOEJ;

	private PoolBasedSettingsService Impl
	{
		get
		{
			int num = 1;
			int num2 = num;
			PoolBasedSettingsService poolBasedSettingsService;
			while (true)
			{
				switch (num2)
				{
				case 1:
					poolBasedSettingsService = _impl;
					if (poolBasedSettingsService != null)
					{
						break;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					poolBasedSettingsService = (_impl = Locator.GetServiceNotNull<PoolBasedSettingsService>());
					break;
				}
				break;
			}
			return poolBasedSettingsService;
		}
	}

	public ICacheService CacheService
	{
		[CompilerGenerated]
		get
		{
			return _003CCacheService_003Ek__BackingField;
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
					_003CCacheService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
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

	public IComplexCacheService ComplexCacheService
	{
		get
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return _complexCacheService;
				case 1:
					_complexCacheService = Locator.GetServiceNotNull<IComplexCacheService>();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					if (_complexCacheService == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto default;
				}
			}
		}
	}

	public IContextBoundVariableService ContextCacheService
	{
		[CompilerGenerated]
		get
		{
			return _003CContextCacheService_003Ek__BackingField;
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
					_003CContextCacheService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public override void SetBLOB<T>(Guid uid, string key, T value)
	{
		object value2 = WrapValue(value);
		Impl.SetObject(string.Concat(uid, key), value2);
		string cacheKey = GetCacheKey(uid, key);
		ComplexCacheService.RefreshTimestamp(cacheKey + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70100627));
	}

	public override T GetBLOB<T>(Guid uid, string key)
	{
		_003C_003Ec__DisplayClass16_0<T> CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass16_0<T>();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.uid = uid;
		CS_0024_003C_003E8__locals0.key = key;
		string cacheKey = GetCacheKey(CS_0024_003C_003E8__locals0.uid, CS_0024_003C_003E8__locals0.key);
		return UnwrapValue<T>(ComplexCacheService.GetOrAdd(cacheKey, cacheKey + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951543930), () => CS_0024_003C_003E8__locals0._003C_003E4__this.WrapValue(CS_0024_003C_003E8__locals0._003C_003E4__this.Impl.GetObject(string.Concat(CS_0024_003C_003E8__locals0.uid, CS_0024_003C_003E8__locals0.key)))));
	}

	public override void RemoveBLOB<T>(Guid uid, string key)
	{
		string cacheKey = GetCacheKey(uid, key);
		Impl.RemoveObject(string.Concat(uid, key));
		ComplexCacheService.RefreshTimestamp(cacheKey + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978446190));
	}

	private static string GetCacheKey(Guid uid, object key)
	{
		return (string)w66CyfWECMnCGBykP7uS(new object[4]
		{
			Bemco7WEQ5avycbh5H7g(-3333094 ^ -3360158),
			uid,
			Bemco7WEQ5avycbh5H7g(-1858887263 ^ -1858884133),
			key
		});
	}

	private object WrapValue<T>(T value)
	{
		if (value == null)
		{
			return NullGuid;
		}
		return value;
	}

	private T UnwrapValue<T>(object value)
	{
		if (value is Guid && (Guid)value == NullGuid)
		{
			return (T)(object)null;
		}
		return (T)value;
	}

	public MemoryBLOBStoreProvider()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static MemoryBLOBStoreProvider()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				OHdQnfWEv8IyvnVD7MCB();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 1:
				NullGuid = new Guid((string)Bemco7WEQ5avycbh5H7g(-1088304168 ^ -1088400078));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool qkoi2vWEEou8kIn6VsS6()
	{
		return uOGFjSWEGOKynascqOEJ == null;
	}

	internal static MemoryBLOBStoreProvider FoI2WaWEffRv8DdKHOMf()
	{
		return uOGFjSWEGOKynascqOEJ;
	}

	internal static object Bemco7WEQ5avycbh5H7g(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object w66CyfWECMnCGBykP7uS(object P_0)
	{
		return string.Concat((object[])P_0);
	}

	internal static void OHdQnfWEv8IyvnVD7MCB()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
