using System;
using EleWise.ELMA.Model.Common;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Managers;

public class MemoryEntityManagerMaker : IManagerMaker
{
	internal static MemoryEntityManagerMaker iWrsTHhGA7865EpEUW8B;

	public Type MakeManager(Type objectType)
	{
		//Discarded unreachable code: IL_0076, IL_0085
		int num = 2;
		int num2 = num;
		Type entityIdType = default(Type);
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (!PQC3IvhG040AP8JxI4C7(objectType, null))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 3;
			default:
				return UpxAQphGyDRmReNBWKp1(typeof(MemoryEntityManager<, >).TypeHandle).MakeGenericType(objectType, entityIdType);
			case 3:
				throw new ArgumentNullException((string)t29LathGmWWsAQA9loAW(-1921202237 ^ -1921081647));
			case 1:
				entityIdType = ModelHelper.GetEntityIdType(objectType);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public MemoryEntityManagerMaker()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		rwF0S8hGM7BiTIiEKVdk();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool PQC3IvhG040AP8JxI4C7(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static object t29LathGmWWsAQA9loAW(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static Type UpxAQphGyDRmReNBWKp1(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool KjtnCShG7jiOqRgmmXD0()
	{
		return iWrsTHhGA7865EpEUW8B == null;
	}

	internal static MemoryEntityManagerMaker YUCucqhGxX0ViUlpeuLm()
	{
		return iWrsTHhGA7865EpEUW8B;
	}

	internal static void rwF0S8hGM7BiTIiEKVdk()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
