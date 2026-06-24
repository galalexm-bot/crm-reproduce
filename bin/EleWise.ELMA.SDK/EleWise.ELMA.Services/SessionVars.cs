using System;
using System.Collections.Concurrent;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Model.Attributes;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Services;

[DeveloperApi(DeveloperApiType.Service)]
public static class SessionVars
{
	private static readonly ConcurrentDictionary<string, object> LockObjects;

	private static ISessionBoundVariableService service;

	private static SessionVars UJpcbQB0W8PVThLSdTNR;

	public static void SetImpl(ISessionBoundVariableService service)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				SessionVars.service = service;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			case 1:
				PfilT3B0G0UTJ6b7UNMu(service, RoJJKVB0hUT8M4x79glc(-35995181 ^ -35937869));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static bool Contains(string name)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return mSNbyDB0E6sbeaVm8f35(service, name);
			case 1:
				CheckImpl();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static T Get<T>(string name)
	{
		CheckImpl();
		return service.Get<T>(name);
	}

	public static bool TryGetValue<T>(string name, out T value)
	{
		CheckImpl();
		return service.TryGetValue<T>(name, out value);
	}

	public static T GetOrAdd<T>(string name, Func<T> val)
	{
		CheckImpl();
		if (service.TryGetValue<T>(name, out var value))
		{
			return value;
		}
		if (val == null)
		{
			throw new VariableNotFoundException(name);
		}
		lock (LockObjects.GetOrAdd(name, (string i) => new object()))
		{
			if (service.TryGetValue<T>(name, out value))
			{
				return value;
			}
			T val2 = val();
			service.Set(name, val2);
			LockObjects.TryRemove(name, out var _);
			return val2;
		}
	}

	public static void Set<T>(string name, T value)
	{
		CheckImpl();
		service.Set(name, value);
	}

	private static void CheckImpl()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (service == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			default:
				throw new NotInitializedException(SR.T((string)RoJJKVB0hUT8M4x79glc(-1852837372 ^ -1852927278)));
			}
		}
	}

	static SessionVars()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				LockObjects = new ConcurrentDictionary<string, object>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			case 1:
				SingletonReader.PushGlobal();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object RoJJKVB0hUT8M4x79glc(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void PfilT3B0G0UTJ6b7UNMu(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static bool hKcBK9B0ocKOJe4MJIgv()
	{
		return UJpcbQB0W8PVThLSdTNR == null;
	}

	internal static SessionVars WH7mHWB0bDmOcC5ZglRv()
	{
		return UJpcbQB0W8PVThLSdTNR;
	}

	internal static bool mSNbyDB0E6sbeaVm8f35(object P_0, object P_1)
	{
		return ((IAbstractBoundVariableService)P_0).Contains((string)P_1);
	}
}
