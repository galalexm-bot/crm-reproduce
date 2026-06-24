using System;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Messaging;

[Serializable]
public struct MessageRecipient : IPackSerializableItem
{
	private static object dWwpamhyQVqXSVPJTMXr;

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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
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
				case 0:
					return;
				case 1:
					_003CId_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
					{
						num2 = 0;
					}
					break;
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public MessageRecipient(string name, Guid typeUid, string id)
	{
		//Discarded unreachable code: IL_0005
		SingletonReader.JJCZtPuTvSt();
		int num = 4;
		while (true)
		{
			switch (num)
			{
			default:
				TypeUid = typeUid;
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
				{
					num = 2;
				}
				break;
			case 1:
				Name = name;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
				{
					num = 0;
				}
				break;
			case 2:
				Id = id;
				num = 3;
				break;
			case 4:
				this = default(MessageRecipient);
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
				{
					num = 1;
				}
				break;
			case 3:
				return;
			}
		}
	}

	public override string ToString()
	{
		return (string)j9h7rwhyZQe8iEmvFF9Y(YsI2ybhy8D5FBUDqlL9N(-2107978722 ^ -2108077106), TypeUid, Id, Name);
	}

	public string Serialize()
	{
		return (string)j9h7rwhyZQe8iEmvFF9Y(YsI2ybhy8D5FBUDqlL9N(0x4A1640F ^ 0x4A2E3E3), TypeUid, Id, Name);
	}

	public void DeserializeFrom(string value)
	{
		int num = 3;
		int num2 = num;
		string[] array = default(string[]);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				Id = array[1];
				num2 = 4;
				break;
			case 4:
				Name = array[2];
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				TypeUid = new Guid(array[0]);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				array = (string[])KeLWGyhyIaZhTrkSAUgK(value, FMNqFPhyurPo9P1aIWkq(YsI2ybhy8D5FBUDqlL9N(0x31326106 ^ 0x31333044)), 3);
				num2 = 2;
				break;
			case 0:
				return;
			}
		}
	}

	internal static bool O4fwRHhyCmbvTAfkEmkn()
	{
		return dWwpamhyQVqXSVPJTMXr == null;
	}

	internal static object tomTndhyv0dBGEPbKIiH()
	{
		return dWwpamhyQVqXSVPJTMXr;
	}

	internal static object YsI2ybhy8D5FBUDqlL9N(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object j9h7rwhyZQe8iEmvFF9Y(object P_0, object P_1, object P_2, object P_3)
	{
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	internal static object FMNqFPhyurPo9P1aIWkq(object P_0)
	{
		return ((string)P_0).ToCharArray();
	}

	internal static object KeLWGyhyIaZhTrkSAUgK(object P_0, object P_1, int P_2)
	{
		return ((string)P_0).Split((char[])P_1, P_2);
	}
}
