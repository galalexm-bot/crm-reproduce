using System;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime.Settings;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Messaging.EmailFormat;

[Component]
public class EmailFormatSettingsModule : GlobalSettingsModuleBase<EmailFormatSettings>
{
	public static Guid UID;

	private static EmailFormatSettingsModule PIPfKbhy9mLDB5t3ylMW;

	public override Guid ModuleGuid => UID;

	public override string ModuleName => (string)OyRARdhygtSqUNxBeefw(QNXJg1hyrPja1gbXjV5M(--1360331293 ^ 0x51168A1B));

	public string GetPrefix(string emailFormatName)
	{
		//Discarded unreachable code: IL_0045, IL_0075
		int num = 2;
		int num2 = num;
		EmailFormatInfo emailFormatInfo = default(EmailFormatInfo);
		_003C_003Ec__DisplayClass5_0 _003C_003Ec__DisplayClass5_ = default(_003C_003Ec__DisplayClass5_0);
		while (true)
		{
			switch (num2)
			{
			case 5:
				if (emailFormatInfo != null)
				{
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
					{
						num2 = 3;
					}
					break;
				}
				return null;
			case 7:
				if (Settings.Formats != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 4;
			case 1:
				_003C_003Ec__DisplayClass5_.emailFormatName = emailFormatName;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
				{
					num2 = 3;
				}
				break;
			case 2:
				_003C_003Ec__DisplayClass5_ = new _003C_003Ec__DisplayClass5_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
				{
					num2 = 1;
				}
				break;
			case 4:
			case 6:
				return null;
			default:
				emailFormatInfo = Settings.Formats.FirstOrDefault(_003C_003Ec__DisplayClass5_._003CGetPrefix_003Eb__0);
				num2 = 5;
				break;
			case 3:
				if (Settings == null)
				{
					num2 = 4;
					break;
				}
				goto case 7;
			case 8:
				return (string)yKXZ8why5O1XvQw3AsIB(emailFormatInfo);
			}
		}
	}

	public EmailFormatSettingsModule()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		kc95kChyjlhcw91uFVbY();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static EmailFormatSettingsModule()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				kc95kChyjlhcw91uFVbY();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				UID = new Guid((string)QNXJg1hyrPja1gbXjV5M(0x6A81B9B4 ^ 0x6A8231E8));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static object QNXJg1hyrPja1gbXjV5M(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object OyRARdhygtSqUNxBeefw(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool UGoBGIhydWM01voGoIpx()
	{
		return PIPfKbhy9mLDB5t3ylMW == null;
	}

	internal static EmailFormatSettingsModule C5alQKhyleiFIcB3b41p()
	{
		return PIPfKbhy9mLDB5t3ylMW;
	}

	internal static object yKXZ8why5O1XvQw3AsIB(object P_0)
	{
		return ((EmailFormatInfo)P_0).SubjectPrefix;
	}

	internal static void kc95kChyjlhcw91uFVbY()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
