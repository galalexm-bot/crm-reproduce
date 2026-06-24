using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Xml.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Scheduling;

[Serializable]
public class MonthlySettings
{
	public enum MonthDaySelectionType
	{
		MonthDay,
		MonthWorkDay,
		MothDayOfWeek,
		LastDay
	}

	public static readonly Collection<int> AllMonths;

	public Collection<int> Months;

	public MonthDaySelectionType DaySelectionType;

	public int MonthDay;

	public int MonthWorkDay;

	public DayOfWeek DayOfWeek;

	public int WeekOfMonth;

	private static MonthlySettings OS1NYQBKO7GXl1S86Jci;

	[XmlIgnore]
	public Collection<int> MonthsProperty
	{
		get
		{
			return Months;
		}
		set
		{
			Months = value;
		}
	}

	[XmlIgnore]
	public MonthDaySelectionType DaySelectionTypeProperty
	{
		get
		{
			return DaySelectionType;
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
					DaySelectionType = value;
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

	[XmlIgnore]
	public int MonthDayProperty
	{
		get
		{
			return MonthDay;
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
					MonthDay = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlIgnore]
	public int MonthWorkDayProperty
	{
		get
		{
			return MonthWorkDay;
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
					MonthWorkDay = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlIgnore]
	public DayOfWeek DayOfWeekProperty
	{
		get
		{
			return DayOfWeek;
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
					DayOfWeek = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlIgnore]
	public int WeekOfMonthProperty
	{
		get
		{
			return WeekOfMonth;
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
					WeekOfMonth = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
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
		if (DaySelectionType == MonthDaySelectionType.MonthDay)
		{
			_003C_003Ec__DisplayClass26_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass26_0();
			CS_0024_003C_003E8__locals0.nowDate = DateTime.Now;
			int num = 31;
			if (Months.Count > 0)
			{
				num = Months.Select((int m) => _003C_003Ec__DisplayClass26_0.iZfYm4QZYQMha0c8iys4(CS_0024_003C_003E8__locals0.nowDate.Year, m)).Min();
			}
			if (MonthDay < 1 || MonthDay > num)
			{
				errors.Add(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-475857671 ^ -475800311), num));
				return false;
			}
		}
		if (DaySelectionType == MonthDaySelectionType.MonthWorkDay && (MonthWorkDay < 1 || MonthWorkDay > 24))
		{
			errors.Add(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345477128)));
			return false;
		}
		if (Months.Count == 0)
		{
			errors.Add(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x31326106 ^ 0x31334390)));
			return false;
		}
		return true;
	}

	public MonthlySettings()
	{
		//Discarded unreachable code: IL_006a, IL_006f
		z2fFRoBKP0rnm2xrfkJc();
		Months = new Collection<int>();
		MonthDay = 1;
		MonthWorkDay = 1;
		DayOfWeek = DayOfWeek.Monday;
		WeekOfMonth = 1;
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static MonthlySettings()
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
				SingletonReader.JJCZtPuTvSt();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 1:
				AllMonths = new Collection<int>
				{
					1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
					11, 12
				};
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool NuSgO7BK21gVTp0d0uFO()
	{
		return OS1NYQBKO7GXl1S86Jci == null;
	}

	internal static MonthlySettings vDjDgVBKetQFmRn5funr()
	{
		return OS1NYQBKO7GXl1S86Jci;
	}

	internal static void z2fFRoBKP0rnm2xrfkJc()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
