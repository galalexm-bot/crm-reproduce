using System;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Files;

public class BinaryFileContentInfo
{
	internal static BinaryFileContentInfo DOURg0GKDAE85sVrrgTk;

	public long ContentLength
	{
		[CompilerGenerated]
		get
		{
			return _003CContentLength_003Ek__BackingField;
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
					_003CContentLength_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
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

	public Uri ContentLocation
	{
		[CompilerGenerated]
		get
		{
			return _003CContentLocation_003Ek__BackingField;
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
					_003CContentLocation_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public uint Crc
	{
		[CompilerGenerated]
		get
		{
			return _003CCrc_003Ek__BackingField;
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
					_003CCrc_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public override string ToString()
	{
		return (string)zUvH7MGK6euooDJ2p2jY(moBRUiGK4U6EqReYGPBt(0x48A7E34A ^ 0x48A43E8A), ContentLength, ContentLocation, Crc);
	}

	public BinaryFileContentInfo()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool TbSmcCGKthc2ldjLl6oE()
	{
		return DOURg0GKDAE85sVrrgTk == null;
	}

	internal static BinaryFileContentInfo qXcb5QGKw1Yq9D1UP4By()
	{
		return DOURg0GKDAE85sVrrgTk;
	}

	internal static object moBRUiGK4U6EqReYGPBt(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object zUvH7MGK6euooDJ2p2jY(object P_0, object P_1, object P_2, object P_3)
	{
		return string.Format((string)P_0, P_1, P_2, P_3);
	}
}
