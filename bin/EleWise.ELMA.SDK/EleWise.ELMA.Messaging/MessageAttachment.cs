using System;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Messaging;

[Serializable]
public struct MessageAttachment : IPackSerializableItem
{
	internal static object yfCfswhmYsFOZNRK6Iw8;

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
				case 1:
					_003CTypeUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public MessageAttachment(string name, Guid typeUid, string id)
	{
		SingletonReader.JJCZtPuTvSt();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				TypeUid = typeUid;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
				{
					num = 0;
				}
				break;
			case 4:
			{
				Name = name;
				int num2 = 2;
				num = num2;
				break;
			}
			default:
				Id = id;
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
				{
					num = 3;
				}
				break;
			case 1:
				this = default(MessageAttachment);
				num = 4;
				break;
			case 3:
				return;
			}
		}
	}

	public override string ToString()
	{
		return (string)PUO3UThmstn44YYqgjxK(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1411196499 ^ -1411293571), TypeUid, Id, Name);
	}

	public string Serialize()
	{
		return string.Format((string)B9trXZhmcjw3tW1l0exX(-542721635 ^ -542818703), TypeUid, Id, Name);
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
			case 4:
				Name = array[2];
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 1:
				Id = array[1];
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				TypeUid = new Guid(array[0]);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				array = (string[])Qo3145hyFnnlkch9GAtK(value, aocsKWhmzkhJ4MlwlPL5(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606707618)), 3);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static bool c6my5BhmLVrsC0qcAU8B()
	{
		return yfCfswhmYsFOZNRK6Iw8 == null;
	}

	internal static object EAQXNghmUEdGD5WxRBOq()
	{
		return yfCfswhmYsFOZNRK6Iw8;
	}

	internal static object PUO3UThmstn44YYqgjxK(object P_0, object P_1, object P_2, object P_3)
	{
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	internal static object B9trXZhmcjw3tW1l0exX(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object aocsKWhmzkhJ4MlwlPL5(object P_0)
	{
		return ((string)P_0).ToCharArray();
	}

	internal static object Qo3145hyFnnlkch9GAtK(object P_0, object P_1, int P_2)
	{
		return ((string)P_0).Split((char[])P_1, P_2);
	}
}
