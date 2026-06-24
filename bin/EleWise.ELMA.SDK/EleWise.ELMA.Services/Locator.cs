using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Services;

public static class Locator
{
	private static ILocatorImpl _impl;

	internal static Locator kvf8HvB0voAmIXwCoRE5;

	public static bool Initialized => _impl != null;

	[CanBeNull]
	public static object GetService(Type type, string name, bool checkNotNull)
	{
		//Discarded unreachable code: IL_0035, IL_0048
		int num = 3;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int condition;
				switch (num2)
				{
				case 4:
					condition = ((name != null) ? 1 : 0);
					goto IL_0087;
				case 1:
					j4wacHB0Sj48FuCYCK1x();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					if (G07KT2B0uQxyPWH75Mfd(type, null))
					{
						break;
					}
					goto case 4;
				case 2:
					condition = 1;
					goto IL_0087;
				default:
					{
						object obj = XoJudvB0io80xr32GXDJ(_impl, type, name);
						if (obj == null && checkNotNull)
						{
							throw new ServiceNotFoundException(name ?? type.FullName);
						}
						return obj;
					}
					IL_0087:
					Vb1RxfB0VHLjrKdGwYXl((byte)condition != 0, LPMnLGB0I1icl4DMaIUm(-1334993905 ^ -1335034571));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
			num = 2;
		}
	}

	[CanBeNull]
	public static object GetService(Type type, string name)
	{
		return luw62pB0RLWWYwTO84gB(type, name, false);
	}

	[NotNull]
	public static object GetServiceNotNull(Type type, string name)
	{
		return luw62pB0RLWWYwTO84gB(type, name, true);
	}

	[CanBeNull]
	public static object GetService(Type type)
	{
		return GetService(type, null, checkNotNull: false);
	}

	[NotNull]
	public static object GetServiceNotNull(Type type)
	{
		return luw62pB0RLWWYwTO84gB(type, null, true);
	}

	[CanBeNull]
	public static T GetService<T>()
	{
		return (T)GetService(typeof(T), null, checkNotNull: false);
	}

	[NotNull]
	public static T GetServiceNotNull<T>()
	{
		return (T)GetService(typeof(T), null, checkNotNull: true);
	}

	[CanBeNull]
	public static T GetService<T>(string name)
	{
		return (T)GetService(typeof(T), name, checkNotNull: false);
	}

	[NotNull]
	public static T GetServiceNotNull<T>(string name)
	{
		return (T)GetService(typeof(T), name, checkNotNull: true);
	}

	public static void AddService(Type type, object obj)
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
				jNPF3fB0qEtcsIA2rGEk(type, obj, true);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public static void AddService(Type type, object obj, bool resolveProperties)
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
				RL1cGAB0KwslTrkK3kXf(_impl, type, obj, resolveProperties);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public static void AddService<T>(T obj)
	{
		AddService(typeof(T), obj);
	}

	public static void AddService<T>(T obj, bool resolveProperties)
	{
		AddService(typeof(T), obj, resolveProperties);
	}

	public static void RemoveService(Type type)
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
				_impl.RemoveService(type);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static void SetImpl(ILocatorImpl locatorImpl)
	{
		_impl = locatorImpl;
	}

	private static void CheckInitialized()
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				return;
			default:
				throw new NotInitializedException((string)QkVFsTB0XFDiaZMbaufN(LPMnLGB0I1icl4DMaIUm(-309639236 ^ -309713206)));
			case 2:
				if (_impl != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			}
		}
	}

	internal static bool G07KT2B0uQxyPWH75Mfd(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static object LPMnLGB0I1icl4DMaIUm(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void Vb1RxfB0VHLjrKdGwYXl(bool condition, object P_1)
	{
		Contract.CheckArgument(condition, (string)P_1);
	}

	internal static void j4wacHB0Sj48FuCYCK1x()
	{
		CheckInitialized();
	}

	internal static object XoJudvB0io80xr32GXDJ(object P_0, Type type, object P_2)
	{
		return ((ILocatorImpl)P_0).GetService(type, (string)P_2);
	}

	internal static bool Bm228hB08weaSA0IFoNS()
	{
		return kvf8HvB0voAmIXwCoRE5 == null;
	}

	internal static Locator rHb0fFB0ZFqnerGmX65S()
	{
		return kvf8HvB0voAmIXwCoRE5;
	}

	internal static object luw62pB0RLWWYwTO84gB(Type type, object P_1, bool checkNotNull)
	{
		return GetService(type, (string)P_1, checkNotNull);
	}

	internal static void jNPF3fB0qEtcsIA2rGEk(Type type, object P_1, bool resolveProperties)
	{
		AddService(type, P_1, resolveProperties);
	}

	internal static void RL1cGAB0KwslTrkK3kXf(object P_0, Type type, object P_2, bool resolveProperties)
	{
		((ILocatorImpl)P_0).AddService(type, P_2, resolveProperties);
	}

	internal static object QkVFsTB0XFDiaZMbaufN(object P_0)
	{
		return SR.T((string)P_0);
	}
}
