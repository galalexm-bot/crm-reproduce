using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Cache.ActorModel;

public struct CacheResult
{
	public static CacheResult Failed;

	public byte[] Value;

	public bool Success;

	internal static object C8u7eyfXyom1ARo0ZoxQ;

	public CacheResult(byte[] value)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		CANsA8fX9DFE50cEkyQC();
		this = new CacheResult(value, success: true);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public CacheResult(byte[] value, bool success)
	{
		//Discarded unreachable code: IL_0005
		CANsA8fX9DFE50cEkyQC();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				Success = success;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
				{
					num = 1;
				}
				break;
			case 2:
				Value = value;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
				{
					num = 0;
				}
				break;
			case 1:
				return;
			}
		}
	}

	static CacheResult()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				Failed = new CacheResult(null, success: false);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				return;
			case 1:
				CANsA8fX9DFE50cEkyQC();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void CANsA8fX9DFE50cEkyQC()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool hmKMjkfXMK3HuJkoC3Vc()
	{
		return C8u7eyfXyom1ARo0ZoxQ == null;
	}

	internal static object bo0ve3fXJRcgnTXwxvd3()
	{
		return C8u7eyfXyom1ARo0ZoxQ;
	}
}
