using System;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Mappings.ReplaceUidsAtPropertyMapService;

internal sealed class ExtendedReplaceUidAtPropertyMapServiceExtension : IReplaceUidAtPropertyMapServiceExtension
{
	private IReplaceUidAtPropertyMapServiceExtension source;

	private static ExtendedReplaceUidAtPropertyMapServiceExtension YDIZBihhn9m1NN0VBKMo;

	public ExtendedReplaceUidAtPropertyMapServiceExtension(IReplaceUidAtPropertyMapServiceExtension service)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		fsmht0hhe0vOCYd9iWMD();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				source = service;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public void Init(object objLeft, object objRight)
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
				if (source is ExtendedReplaceUidAtPropertyMapServiceExtension)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
					{
						num2 = 0;
					}
					break;
				}
				mJdCekhhP01O5UvKWr0D(source, objLeft, objRight);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
				{
					num2 = 2;
				}
				break;
			case 0:
				return;
			case 2:
				return;
			}
		}
	}

	public bool GetUidReplace(Guid uid, out Guid? newUid)
	{
		return source.GetUidReplace(uid, out newUid);
	}

	public void EndWork()
	{
		//Discarded unreachable code: IL_0072, IL_0081
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			default:
				WqSApnhh1s0h4Vf1yRKF(source);
				num2 = 3;
				break;
			case 3:
				return;
			case 1:
				if (source is ExtendedReplaceUidAtPropertyMapServiceExtension)
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void fsmht0hhe0vOCYd9iWMD()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool FtZieFhhOGlaXJpuu7f1()
	{
		return YDIZBihhn9m1NN0VBKMo == null;
	}

	internal static ExtendedReplaceUidAtPropertyMapServiceExtension b1R4M9hh25lvKlHAhF63()
	{
		return YDIZBihhn9m1NN0VBKMo;
	}

	internal static void mJdCekhhP01O5UvKWr0D(object P_0, object P_1, object P_2)
	{
		((IReplaceUidAtPropertyMapServiceExtension)P_0).Init(P_1, P_2);
	}

	internal static void WqSApnhh1s0h4Vf1yRKF(object P_0)
	{
		((IReplaceUidAtPropertyMapServiceExtension)P_0).EndWork();
	}
}
