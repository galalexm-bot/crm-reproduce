using System;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Messaging;

[Serializable]
public struct MessageObject : IPackSerializableItem
{
	private static object HggBa2hyBhUV3pORWxLC;

	public Guid TypeUid
	{
		[CompilerGenerated]
		get
		{
			return _003CTypeUid_003Ek__BackingField;
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
					_003CTypeUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string Id
	{
		[CompilerGenerated]
		get
		{
			return _003CId_003Ek__BackingField;
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
					_003CId_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
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

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return _003CName_003Ek__BackingField;
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
					_003CName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public MessageObject(string name, Guid typeUid, string id)
	{
		//Discarded unreachable code: IL_0005
		Bxs9yfhyb2wZbt6SvDHx();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 4:
				return;
			default:
				TypeUid = typeUid;
				num = 2;
				break;
			case 1:
				this = default(MessageObject);
				num = 3;
				break;
			case 2:
				Id = id;
				num = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
				{
					num = 4;
				}
				break;
			case 3:
				Name = name;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public override string ToString()
	{
		return (string)vCGUkBhyG31YuxYP0t2p(fJ941GhyhtYuRTMGm5nD(-70037984 ^ -70202896), TypeUid, Id, Name);
	}

	public string Serialize()
	{
		return (string)vCGUkBhyG31YuxYP0t2p(fJ941GhyhtYuRTMGm5nD(-1411196499 ^ -1411293631), TypeUid, Id, Name);
	}

	public void DeserializeFrom(string value)
	{
		int num = 1;
		int num2 = num;
		string[] array = default(string[]);
		while (true)
		{
			switch (num2)
			{
			case 3:
				Name = array[2];
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
				{
					num2 = 4;
				}
				break;
			case 1:
				array = (string[])jYCF8Qhyfq9hUAGdQdQy(value, at9rNxhyE4I8MIBTSWy0(fJ941GhyhtYuRTMGm5nD(0x637E299B ^ 0x637F78D9)), 3);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				return;
			default:
				TypeUid = new Guid(array[0]);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				Id = array[1];
				num2 = 3;
				break;
			}
		}
	}

	internal static bool NYJwmdhyWc7WUlNcHEpr()
	{
		return HggBa2hyBhUV3pORWxLC == null;
	}

	internal static object Uf4Xe4hyooFw409kyLWV()
	{
		return HggBa2hyBhUV3pORWxLC;
	}

	internal static void Bxs9yfhyb2wZbt6SvDHx()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object fJ941GhyhtYuRTMGm5nD(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object vCGUkBhyG31YuxYP0t2p(object P_0, object P_1, object P_2, object P_3)
	{
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	internal static object at9rNxhyE4I8MIBTSWy0(object P_0)
	{
		return ((string)P_0).ToCharArray();
	}

	internal static object jYCF8Qhyfq9hUAGdQdQy(object P_0, object P_1, int P_2)
	{
		return ((string)P_0).Split((char[])P_1, P_2);
	}
}
