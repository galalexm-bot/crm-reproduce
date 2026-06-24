using System;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Services;

internal sealed class DisposableCallContext : IDisposable
{
	private sealed class EmptyCallContext : IDisposable
	{
		internal static object C2n0hJQXErMnd1wTkSv2;

		public void Dispose()
		{
		}

		public EmptyCallContext()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			uijutRQXC6DuBk9F5tV3();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static void uijutRQXC6DuBk9F5tV3()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool wGlT2HQXfSM1tQTlAXFb()
		{
			return C2n0hJQXErMnd1wTkSv2 == null;
		}

		internal static EmptyCallContext JJk0j6QXQrVZ3knYDB0t()
		{
			return (EmptyCallContext)C2n0hJQXErMnd1wTkSv2;
		}
	}

	private readonly object oldInstance;

	private readonly string key;

	private static IContextBoundVariableService contextBoundVariableService;

	internal static DisposableCallContext yWKKkMBD1oOBxmXYrTFx;

	private static IContextBoundVariableService ContextBoundVariableService
	{
		get
		{
			int num = 1;
			int num2 = num;
			IContextBoundVariableService obj;
			while (true)
			{
				switch (num2)
				{
				case 1:
					obj = contextBoundVariableService;
					if (obj == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				default:
					obj = (contextBoundVariableService = Locator.GetServiceNotNull<IContextBoundVariableService>());
					break;
				}
				break;
			}
			return obj;
		}
	}

	private DisposableCallContext(string key, object oldInstance)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		HPPXBaBDpWB7vbaE9mDP();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			case 2:
				this.oldInstance = oldInstance;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
				{
					num = 1;
				}
				break;
			default:
				this.key = key;
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	public static IDisposable Create(string key, object newInstance)
	{
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass6_0 _003C_003Ec__DisplayClass6_ = default(_003C_003Ec__DisplayClass6_0);
		while (true)
		{
			switch (num2)
			{
			case 2:
				_003C_003Ec__DisplayClass6_ = new _003C_003Ec__DisplayClass6_0();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass6_.newInstance = newInstance;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return Create<object>(key, _003C_003Ec__DisplayClass6_._003CCreate_003Eb__0);
			}
		}
	}

	public static IDisposable Create<T>(string key, Func<T, T> instanceFunc)
	{
		ContextBoundVariableService.TryGetValue<T>(key, out var value);
		ContextBoundVariableService.Set(key, instanceFunc(value));
		return new DisposableCallContext(key, value);
	}

	public static T GetCurrent<T>(string key)
	{
		ContextBoundVariableService.TryGetValue<T>(key, out var value);
		return value;
	}

	public static IDisposable CreateEmptyCallContext()
	{
		return new EmptyCallContext();
	}

	public void Dispose()
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
				kT6S8fBDDnwMAvr488qF(v2EHGEBDa3v2G1oO7PSU(), key, oldInstance);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool sDc8WRBDNhxVsjhIV6vN()
	{
		return yWKKkMBD1oOBxmXYrTFx == null;
	}

	internal static DisposableCallContext jXcJmVBD3dsPV6GKl6vS()
	{
		return yWKKkMBD1oOBxmXYrTFx;
	}

	internal static void HPPXBaBDpWB7vbaE9mDP()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object v2EHGEBDa3v2G1oO7PSU()
	{
		return ContextBoundVariableService;
	}

	internal static void kT6S8fBDDnwMAvr488qF(object P_0, object P_1, object P_2)
	{
		((IAbstractBoundVariableService)P_0).Set((string)P_1, P_2);
	}
}
