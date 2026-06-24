using System;
using System.Collections.Concurrent;
using System.Reflection;
using System.Threading.Tasks;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Threading.Extensions;

public static class ValueTaskExtensions
{
	private static readonly MethodInfo FromResultGenericInfo;

	private static readonly ConcurrentDictionary<Type, MethodInfo> FromResultGenericConstructedMethodCache;

	internal static ValueTaskExtensions ebbqkwBRcGcTP2aSZ824;

	public static object FromResult(object result, Type returnType)
	{
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = default(_003C_003Ec__DisplayClass2_0);
		while (true)
		{
			switch (num2)
			{
			case 2:
				_003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
				{
					num2 = 1;
				}
				break;
			default:
				return STpe4RBqonEFC8uDxRAX(FromResultGenericConstructedMethodCache.GetOrAdd(_003C_003Ec__DisplayClass2_.returnType, _003C_003Ec__DisplayClass2_._003CFromResult_003Eb__0), null, new object[1] { result });
			case 1:
				_003C_003Ec__DisplayClass2_.returnType = returnType;
				num2 = 3;
				break;
			case 3:
				imattcBqWBxSrrwnQA5V(_003C_003Ec__DisplayClass2_.returnType, TRsQxOBqB5qaOWHwGUMO(-889460160 ^ -889522224));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private static System.Threading.Tasks.ValueTask<TResult> FromResultGeneric<TResult>(object result)
	{
		return new System.Threading.Tasks.ValueTask<TResult>((TResult)result);
	}

	static ValueTaskExtensions()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				SingletonReader.JJCZtPuTvSt();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				FromResultGenericInfo = typeof(ValueTaskExtensions).GetMethod((string)TRsQxOBqB5qaOWHwGUMO(0x637E299B ^ 0x637F3433), BindingFlags.Static | BindingFlags.NonPublic);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
				{
					num2 = 3;
				}
				break;
			case 3:
				FromResultGenericConstructedMethodCache = new ConcurrentDictionary<Type, MethodInfo>();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static object TRsQxOBqB5qaOWHwGUMO(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void imattcBqWBxSrrwnQA5V(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object STpe4RBqonEFC8uDxRAX(object P_0, object P_1, object P_2)
	{
		return ((MethodBase)P_0).Invoke(P_1, (object[])P_2);
	}

	internal static bool B0uhirBRzSJyZtsI3QAB()
	{
		return ebbqkwBRcGcTP2aSZ824 == null;
	}

	internal static ValueTaskExtensions XJeljIBqFfFntOlWgZoE()
	{
		return ebbqkwBRcGcTP2aSZ824;
	}
}
