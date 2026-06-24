using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Scheduling;

[Serializable]
public class WeeklySettings
{
	public int EveryTime;

	[NotNull]
	public List<DayOfWeek> DaysFoWeek;

	internal static WeeklySettings BKh6CIBK1Ooie0j3ojvY;

	[XmlIgnore]
	public int EveryTimeProperty
	{
		get
		{
			return EveryTime;
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
					EveryTime = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlIgnore]
	public List<DayOfWeek> DaysFoWeekProperty
	{
		get
		{
			return DaysFoWeek;
		}
		set
		{
			DaysFoWeek = value;
		}
	}

	public bool Validate(List<string> errors)
	{
		if (EveryTime < 1)
		{
			errors.Add(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488808135)));
			return false;
		}
		if (DaysFoWeek.Count == 0)
		{
			errors.Add(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3630F361 ^ 0x3631D0EF)));
			return false;
		}
		return true;
	}

	public WeeklySettings()
	{
		//Discarded unreachable code: IL_0046, IL_004b
		uUMDQGBKpENveM3AKL45();
		EveryTime = 1;
		DaysFoWeek = new List<DayOfWeek>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool FXKATyBKNQTZwNmM7Vi7()
	{
		return BKh6CIBK1Ooie0j3ojvY == null;
	}

	internal static WeeklySettings wxHrWwBK3G4rReX29Ex6()
	{
		return BKh6CIBK1Ooie0j3ojvY;
	}

	internal static void uUMDQGBKpENveM3AKL45()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
