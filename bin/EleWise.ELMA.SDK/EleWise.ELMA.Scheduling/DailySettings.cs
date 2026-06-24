using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Scheduling;

[Serializable]
public class DailySettings
{
	public int EveryDay;

	public bool OnlyWorkDays;

	internal static DailySettings TC4rlDBKaAWt1NcYa6rK;

	[XmlIgnore]
	public int EveryDayProperty
	{
		get
		{
			return EveryDay;
		}
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
					EveryDay = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlIgnore]
	public bool OnlyWorkDaysProperty
	{
		get
		{
			return OnlyWorkDays;
		}
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
					OnlyWorkDays = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
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

	public bool Validate(List<string> errors)
	{
		if (EveryDay < 1)
		{
			errors.Add(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x18A6761F ^ 0x18A755F3)));
			return false;
		}
		return true;
	}

	public DailySettings()
	{
		//Discarded unreachable code: IL_0036, IL_003b
		dPWTtiBKwQ33eka4YKEB();
		EveryDay = 1;
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool aq8RTgBKDrZ5nyrCFkmS()
	{
		return TC4rlDBKaAWt1NcYa6rK == null;
	}

	internal static DailySettings K66gbOBKtHA3qK79BB2d()
	{
		return TC4rlDBKaAWt1NcYa6rK;
	}

	internal static void dPWTtiBKwQ33eka4YKEB()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
