using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Scheduling;

[Serializable]
public class NthIncludedDaySettings : ICloneable
{
	public DateTime StartDate;

	public DateTime? EndAt;

	public ScheduleType ScheduleType;

	[NotNull]
	public DailySettings DailySettings;

	[NotNull]
	public WeeklySettings WeeklySettings;

	[NotNull]
	public MonthlySettings MonthlySettings;

	[NotNull]
	public RepeatSettings RepeatSettings;

	[XmlIgnore]
	[NotNull]
	public TimeSpan OvertimeToRun;

	public static readonly TimeSpan DefaultOvertimeToRun;

	internal static NthIncludedDaySettings DY1hV4BK0o74iqkaWNK7;

	public long OvertimeToRunTicks
	{
		get
		{
			return OvertimeToRun.Ticks;
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
					OvertimeToRun = new TimeSpan(value);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
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

	[XmlIgnore]
	public DateTime StartDateProperty
	{
		get
		{
			return StartDate;
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
					StartDate = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlIgnore]
	public ScheduleType ScheduleTypeProperty
	{
		get
		{
			return ScheduleType;
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
					ScheduleType = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
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

	[XmlIgnore]
	public DailySettings DailySettingsProperty
	{
		get
		{
			return DailySettings;
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
					DailySettings = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlIgnore]
	public WeeklySettings WeeklySettingsProperty
	{
		get
		{
			return WeeklySettings;
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
					WeeklySettings = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
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

	[XmlIgnore]
	public MonthlySettings MonthlySettingsProperty
	{
		get
		{
			return MonthlySettings;
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
					MonthlySettings = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlIgnore]
	public RepeatSettings RepeatSettingsProperty
	{
		get
		{
			return RepeatSettings;
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
					RepeatSettings = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public object Clone()
	{
		return ClassSerializationHelper.CloneObject(this);
	}

	public bool Validate(List<string> errors)
	{
		return ScheduleType switch
		{
			ScheduleType.Daily => DailySettings.Validate(errors), 
			ScheduleType.Weekly => WeeklySettings.Validate(errors), 
			ScheduleType.Monthly => MonthlySettings.Validate(errors), 
			_ => true, 
		};
	}

	public NthIncludedDaySettings()
	{
		//Discarded unreachable code: IL_0096, IL_009b
		SingletonReader.JJCZtPuTvSt();
		StartDate = hchGSZBKMXulL5xOM3m0();
		ScheduleType = ScheduleType.Daily;
		DailySettings = new DailySettings();
		WeeklySettings = new WeeklySettings();
		MonthlySettings = new MonthlySettings();
		RepeatSettings = new RepeatSettings();
		OvertimeToRun = DefaultOvertimeToRun;
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static NthIncludedDaySettings()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				vgtb5vBKJK4QWuV7fP2c();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				DefaultOvertimeToRun = TimeSpan.FromMinutes(2.0);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool uSkUQ7BKmNAVnXebcqYw()
	{
		return DY1hV4BK0o74iqkaWNK7 == null;
	}

	internal static NthIncludedDaySettings EQMKY2BKyoprV5eQvWLt()
	{
		return DY1hV4BK0o74iqkaWNK7;
	}

	internal static DateTime hchGSZBKMXulL5xOM3m0()
	{
		return DateTime.Now;
	}

	internal static void vgtb5vBKJK4QWuV7fP2c()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
