using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics;

[Serializable]
public class CacheReadInfo : CacheQueryInfo
{
	private static CacheReadInfo OcZkW5EBSRSNFBKpYaW8;

	public bool Success
	{
		[CompilerGenerated]
		get
		{
			return _003CSuccess_003Ek__BackingField;
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
					_003CSuccess_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public CacheReadInfo()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		oQm334EBqYDNdZPLbs0C();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
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
				base.Operation = (string)znKF79EBK4ur7WIcaq4v(0x4DC2B14D ^ 0x4DC699F3);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	protected override void GetObjectData(SerializationInfo info, StreamingContext context)
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
				base.GetObjectData(info, context);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				VIdG9cEBXKt45juZXWNn(info, znKF79EBK4ur7WIcaq4v(0x269E5FCA ^ 0x269A7700), Success);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	internal static void oQm334EBqYDNdZPLbs0C()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object znKF79EBK4ur7WIcaq4v(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool Wdt7vLEBialO89j0wCIf()
	{
		return OcZkW5EBSRSNFBKpYaW8 == null;
	}

	internal static CacheReadInfo vwZvNGEBRlKSa2DLEfpw()
	{
		return OcZkW5EBSRSNFBKpYaW8;
	}

	internal static void VIdG9cEBXKt45juZXWNn(object P_0, object P_1, bool P_2)
	{
		((SerializationInfo)P_0).AddValue((string)P_1, P_2);
	}
}
