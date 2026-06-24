using System;
using System.ComponentModel;
using System.Reflection;
using EleWise.ELMA.Cache;
using EleWise.ELMA.Cache.Modules;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Runtime.Context;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Services;

public static class ContextBoundVariableServiceExtensions
{
	internal static ContextBoundVariableServiceExtensions ESKa0LBthgwlRTpeoFrp;

	public static T GetOrAdd<T>([NotNull] this IContextBoundVariableService contextBoundVariableService, [NotNull] string name, [NotNull] Func<T> factory)
	{
		return IAbstractBoundVariableServiceExtensions.GetOrAdd(contextBoundVariableService, name, factory);
	}

	public static void ClearFor<TResult>(this IContextBoundVariableService contextBoundVariableService, Func<TResult> func)
	{
		contextBoundVariableService.ClearFor(func.Method);
	}

	public static void ClearFor<T, TResult>(this IContextBoundVariableService contextBoundVariableService, Func<T, TResult> func)
	{
		contextBoundVariableService.ClearFor(func.Method);
	}

	public static void ClearFor<T1, T2, TResult>(this IContextBoundVariableService contextBoundVariableService, Func<T1, T2, TResult> func)
	{
		contextBoundVariableService.ClearFor(func.Method);
	}

	public static void ClearFor<T1, T2, T3, TResult>(this IContextBoundVariableService contextBoundVariableService, Func<T1, T2, T3, TResult> func)
	{
		contextBoundVariableService.ClearFor(func.Method);
	}

	public static void ClearFor(this IContextBoundVariableService contextBoundVariableService, MethodInfo method)
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
				zpJAtYBtQ5Gcg8In3Ld3(contextBoundVariableService, uonObpBtfI1dc98aALr1(method));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static void ClearRegion(this IContextBoundVariableService contextBoundVariableService, string region)
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
				hf9Bp5BtCDVZe4MUsIv6(contextBoundVariableService, region);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public static void Set<T>(this IContextBoundVariableService contextBoundVariableService, string key, string region, T value)
	{
		ContextCacheInterceptor.Set(contextBoundVariableService, key, region, value);
	}

	public static bool TryGetValue<T>(this IContextBoundVariableService contextBoundVariableService, string key, string region, out T result)
	{
		if (ContextCacheInterceptor.TryGetValue(contextBoundVariableService, key, region, out var result2))
		{
			result = (T)result2;
			return true;
		}
		result = default(T);
		return false;
	}

	public static bool Contains(this IContextBoundVariableService contextBoundVariableService, string key, string region)
	{
		object result;
		return ContextCacheInterceptor.TryGetValue(contextBoundVariableService, key, region, out result);
	}

	public static void Remove(this IContextBoundVariableService contextBoundVariableService, string key, string region)
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
				Xqjq5sBtvMESq3m46vsi(contextBoundVariableService, key, region);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static T Get<T>(this IContextBoundVariableService contextBoundVariableService, string key, string region)
	{
		if (!contextBoundVariableService.TryGetValue<T>(key, region, out var result))
		{
			throw new VariableNotFoundException(region + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1886646897 ^ -1886624293) + key);
		}
		return result;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public static void ClearCache(this IContextBoundVariableService contextBoundVariableService)
	{
		jK8ROFBt82xy4b8sudd4(contextBoundVariableService);
	}

	internal static object uonObpBtfI1dc98aALr1(object P_0)
	{
		return ((MethodInfo)P_0).GetCacheRegion();
	}

	internal static void zpJAtYBtQ5Gcg8In3Ld3(object P_0, object P_1)
	{
		((IContextBoundVariableService)P_0).ClearRegion((string)P_1);
	}

	internal static bool v9fppLBtGwTfGFSqLtfJ()
	{
		return ESKa0LBthgwlRTpeoFrp == null;
	}

	internal static ContextBoundVariableServiceExtensions g0qQVBBtEAmHuNK0TlXc()
	{
		return ESKa0LBthgwlRTpeoFrp;
	}

	internal static void hf9Bp5BtCDVZe4MUsIv6(object P_0, object P_1)
	{
		ContextCacheInterceptor.ClearRegion((IContextBoundVariableService)P_0, (string)P_1);
	}

	internal static void Xqjq5sBtvMESq3m46vsi(object P_0, object P_1, object P_2)
	{
		ContextCacheInterceptor.Remove((IContextBoundVariableService)P_0, (string)P_1, (string)P_2);
	}

	internal static void jK8ROFBt82xy4b8sudd4(object P_0)
	{
		ContextCacheInterceptor.Clear((IContextBoundVariableService)P_0);
	}
}
