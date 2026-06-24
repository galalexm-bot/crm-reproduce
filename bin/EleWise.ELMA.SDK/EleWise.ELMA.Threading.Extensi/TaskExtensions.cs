using System;
using System.Collections.Concurrent;
using System.Reflection;
using System.Threading.Tasks;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Threading.Extensions;

public static class TaskExtensions
{
	private static readonly MethodInfo FromResultGenericInfo;

	private static readonly ConcurrentDictionary<Type, MethodInfo> FromResultGenericConstructedMethodCache;

	internal static TaskExtensions yD7KbuBRgdJqZ8uBiXm7;

	public static object FromResult(object result, Type returnType)
	{
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = default(_003C_003Ec__DisplayClass2_0);
		while (true)
		{
			switch (num2)
			{
			case 1:
				_003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return cK0SPABRUyL68bTvSsFO(FromResultGenericConstructedMethodCache.GetOrAdd(_003C_003Ec__DisplayClass2_.returnType, _003C_003Ec__DisplayClass2_._003CFromResult_003Eb__0), null, new object[1] { result });
			case 2:
				gkkajfBRLidsHQlM3MKT(_003C_003Ec__DisplayClass2_.returnType, pVWlgoBRYTligrTpcLdl(0x49E27B8A ^ 0x49E3661A));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
				{
					num2 = 3;
				}
				break;
			default:
				_003C_003Ec__DisplayClass2_.returnType = returnType;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	private static Task<TResult> FromResultGeneric<TResult>(object result)
	{
		return Task.FromResult((TResult)result);
	}

	static TaskExtensions()
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				return;
			default:
				FromResultGenericConstructedMethodCache = new ConcurrentDictionary<Type, MethodInfo>();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				FromResultGenericInfo = typeof(TaskExtensions).GetMethod((string)pVWlgoBRYTligrTpcLdl(-138018305 ^ -137946025), BindingFlags.Static | BindingFlags.NonPublic);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				QbOa3yBRsH6Anb5xofnF();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static object pVWlgoBRYTligrTpcLdl(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void gkkajfBRLidsHQlM3MKT(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object cK0SPABRUyL68bTvSsFO(object P_0, object P_1, object P_2)
	{
		return ((MethodBase)P_0).Invoke(P_1, (object[])P_2);
	}

	internal static bool MFiHKvBR5CurWeSxLTZ6()
	{
		return yD7KbuBRgdJqZ8uBiXm7 == null;
	}

	internal static TaskExtensions XlehtxBRjW4IoRR10YNh()
	{
		return yD7KbuBRgdJqZ8uBiXm7;
	}

	internal static void QbOa3yBRsH6Anb5xofnF()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
