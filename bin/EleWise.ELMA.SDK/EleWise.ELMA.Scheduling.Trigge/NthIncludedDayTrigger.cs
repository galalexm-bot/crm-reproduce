using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using Castle.Core;
using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Scheduling.Triggers;

public class NthIncludedDayTrigger : ITriggerExtension, ITrigger
{
	private readonly IProductionSchedule productionSchedule;

	private readonly NthIncludedDaySettings nthIncludedDaySettings;

	internal static NthIncludedDayTrigger lhlLrJBXKE03VMTkGiFs;

	public TimeSpan OvertimeToRun => nthIncludedDaySettings.OvertimeToRun;

	public Guid Id
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public int? JobResultTimeout
	{
		get
		{
			if (nthIncludedDaySettings.RepeatSettings.Enabled)
			{
				return (nthIncludedDaySettings.RepeatSettings.RepeatEvery.Minutes <= 0) ? 1 : nthIncludedDaySettings.RepeatSettings.RepeatEvery.Minutes;
			}
			return null;
		}
	}

	[Obsolete("Использовать конструктор с параметрами типов NthIncludedDaySettings, IProductionSchedule")]
	public NthIncludedDayTrigger(NthIncludedDaySettings nthIncludedDaySettings, IProductionCalendarService productionCalendar)
	{
		//Discarded unreachable code: IL_001a
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				productionSchedule = (IProductionSchedule)GmxUBMBXn9CnMOTyonLX(productionCalendar);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			case 4:
				throw new ArgumentNullException((string)llAYy0BXkYTDeUCpIa2c(-541731959 ^ -541788495));
			case 2:
				if (nthIncludedDaySettings == null)
				{
					int num2 = 4;
					num = num2;
					break;
				}
				if (productionCalendar == null)
				{
					num = 3;
					break;
				}
				this.nthIncludedDaySettings = nthIncludedDaySettings;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
				{
					num = 0;
				}
				break;
			case 3:
				throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x49E27B8A ^ 0x49E35EE2));
			}
		}
	}

	public NthIncludedDayTrigger(NthIncludedDaySettings nthIncludedDaySettings, IProductionSchedule productionSchedule)
	{
		//Discarded unreachable code: IL_001a, IL_001f, IL_007a, IL_0089, IL_00e1, IL_00f0
		s1vxEoBXOeaIu6OP2MQa();
		base._002Ector();
		int num = 4;
		while (true)
		{
			switch (num)
			{
			default:
				throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-957824448 ^ -957749384));
			case 2:
				if (productionSchedule != null)
				{
					num = 5;
					break;
				}
				goto case 1;
			case 6:
				this.productionSchedule = productionSchedule;
				num = 3;
				break;
			case 1:
				throw new ArgumentNullException((string)llAYy0BXkYTDeUCpIa2c(-1638402543 ^ -1638476927));
			case 5:
				this.nthIncludedDaySettings = nthIncludedDaySettings;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
				{
					num = 6;
				}
				break;
			case 4:
				if (nthIncludedDaySettings != null)
				{
					num = 2;
					break;
				}
				goto default;
			case 3:
				return;
			}
		}
	}

	public virtual DateTime? GetNextTimeAfter(DateTime? dateTime, DateTime now)
	{
		_003C_003Ec__DisplayClass4_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass4_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.dateTime = dateTime;
		if (!CS_0024_003C_003E8__locals0.dateTime.HasValue)
		{
			return GetFirstStartTime();
		}
		DateTime dateTime2 = ((CS_0024_003C_003E8__locals0.dateTime.Value > nthIncludedDaySettings.StartDate) ? CS_0024_003C_003E8__locals0.dateTime.Value : nthIncludedDaySettings.StartDate);
		DateTime arg = dateTime2.Add(-dateTime2.TimeOfDay).Add(nthIncludedDaySettings.StartDate.TimeOfDay);
		Func<DateTime, IEnumerable<DateTime>> func;
		if (nthIncludedDaySettings.ScheduleType == ScheduleType.Daily)
		{
			func = GetDailySequenseDays;
		}
		else if (nthIncludedDaySettings.ScheduleType == ScheduleType.Weekly)
		{
			func = GetWeeklySequenseDays;
		}
		else if (nthIncludedDaySettings.ScheduleType == ScheduleType.Monthly)
		{
			func = GetMonthlySequenseDays;
		}
		else
		{
			if (nthIncludedDaySettings.ScheduleType != 0)
			{
				throw new NotImplementedException();
			}
			func = (DateTime time) => (time <= CS_0024_003C_003E8__locals0._003C_003E4__this.nthIncludedDaySettings.StartDate) ? new DateTime[1] { CS_0024_003C_003E8__locals0._003C_003E4__this.nthIncludedDaySettings.StartDate } : new DateTime[0];
		}
		return func(arg).SelectMany(delegate(DateTime d)
		{
			CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass4_1();
			if (!CS_0024_003C_003E8__locals0._003C_003E4__this.nthIncludedDaySettings.RepeatSettings.Enabled)
			{
				return new DateTime[1] { d };
			}
			if (CS_0024_003C_003E8__locals0._003C_003E4__this.nthIncludedDaySettings.RepeatSettings.RepeatEvery.TotalSeconds <= 0.0)
			{
				throw new InvalidOperationException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138361396)));
			}
			CS_0024_003C_003E8__locals0.repeatTo = d.Add(-d.TimeOfDay).Add(CS_0024_003C_003E8__locals0._003C_003E4__this.nthIncludedDaySettings.RepeatSettings.RepeatTo);
			return CollectionExtensions.Unfold(d, (DateTime v) => _003C_003Ec__DisplayClass4_0.QE1W0PQuQxNqSvE1glTJ(v, CS_0024_003C_003E8__locals0._003C_003E4__this.nthIncludedDaySettings.RepeatSettings.RepeatEvery), (DateTime v) => _003C_003Ec__DisplayClass4_1.N19dLpQuID1sNUIjbEsj(v, CS_0024_003C_003E8__locals0.repeatTo));
		}).TakeWhile(delegate(DateTime v)
		{
			//Discarded unreachable code: IL_008d, IL_009c
			int num = 5;
			DateTime? endAt = default(DateTime?);
			DateTime dateTime3 = default(DateTime);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 1:
						endAt = CS_0024_003C_003E8__locals0._003C_003E4__this.nthIncludedDaySettings.EndAt;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
						{
							num2 = 0;
						}
						break;
					case 5:
						if (!CS_0024_003C_003E8__locals0._003C_003E4__this.nthIncludedDaySettings.EndAt.HasValue)
						{
							goto end_IL_0012;
						}
						goto case 2;
					case 2:
						dateTime3 = v;
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
						{
							num2 = 1;
						}
						break;
					case 3:
						return false;
					case 4:
						return true;
					default:
						if (endAt.HasValue)
						{
							return _003C_003Ec__DisplayClass4_0.b8HG2KQuChYpmrpdawWB(dateTime3, endAt.GetValueOrDefault());
						}
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
						{
							num2 = 3;
						}
						break;
					}
					continue;
					end_IL_0012:
					break;
				}
				num = 4;
			}
		}).Cast<DateTime?>()
			.FirstOrDefault((DateTime? d) => d > CS_0024_003C_003E8__locals0.dateTime.Value);
	}

	public IEnumerable<DateTime> GetDailySequenseDays(DateTime from)
	{
		if (nthIncludedDaySettings.DailySettings.EveryDay <= 0)
		{
			return new List<DateTime>();
		}
		return EverydaySequenceGenerator(from).Where(delegate(DateTime d)
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return kNMRtqBX2J4qO1ym3qkB(productionSchedule, d);
				case 1:
					if (!nthIncludedDaySettings.DailySettings.OnlyWorkDays)
					{
						return true;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}).Where((DateTime d, int i) => i % nthIncludedDaySettings.DailySettings.EveryDay == 0);
	}

	[IteratorStateMachine(typeof(_003CEverydaySequenceGenerator_003Ed__18))]
	private IEnumerable<DateTime> EverydaySequenceGenerator(DateTime from)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CEverydaySequenceGenerator_003Ed__18(-2)
		{
			_003C_003E3__from = from
		};
	}

	[IteratorStateMachine(typeof(_003CGetMonthlySequenseDays_003Ed__19))]
	public IEnumerable<DateTime> GetMonthlySequenseDays(DateTime from)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CGetMonthlySequenseDays_003Ed__19(-2)
		{
			_003C_003E4__this = this,
			_003C_003E3__from = from
		};
	}

	[IteratorStateMachine(typeof(_003CGetWeeklySequenseDays_003Ed__20))]
	public IEnumerable<DateTime> GetWeeklySequenseDays(DateTime from)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CGetWeeklySequenseDays_003Ed__20(-2)
		{
			_003C_003E4__this = this,
			_003C_003E3__from = from
		};
	}

	public Pair<DateTime, DateTime> GetWeekRange(DateTime date)
	{
		CultureInfo currentCulture = Thread.CurrentThread.CurrentCulture;
		DayOfWeek firstDayOfWeek = currentCulture.DateTimeFormat.FirstDayOfWeek;
		int num = currentCulture.Calendar.GetDayOfWeek(date) - firstDayOfWeek;
		if (num < 0)
		{
			num += 7;
		}
		DateTime dateTime = date.AddDays(-num);
		DateTime dateTime2 = dateTime.AddDays(6.0);
		return new Pair<DateTime, DateTime>(dateTime, dateTime2);
	}

	private DateTime GetFirstStartTime()
	{
		//Discarded unreachable code: IL_0045, IL_0054, IL_00e4
		int num = 5;
		int num2 = num;
		DateTime result = default(DateTime);
		ScheduleType scheduleType = default(ScheduleType);
		while (true)
		{
			switch (num2)
			{
			default:
				return result;
			case 6:
				if (scheduleType == ScheduleType.Monthly)
				{
					num2 = 7;
					continue;
				}
				goto case 8;
			case 7:
				result = GetMonthlySequenseDays(nthIncludedDaySettings.StartDate).First();
				num2 = 2;
				continue;
			case 4:
				if (scheduleType != ScheduleType.Weekly)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
					{
						num2 = 6;
					}
					continue;
				}
				break;
			case 8:
				result = nthIncludedDaySettings.StartDate;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
				{
					num2 = 0;
				}
				continue;
			case 5:
				scheduleType = nthIncludedDaySettings.ScheduleType;
				num2 = 4;
				continue;
			case 3:
				break;
			}
			result = GetWeeklySequenseDays(nthIncludedDaySettings.StartDate).First();
			num2 = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
			{
				num2 = 1;
			}
		}
	}

	internal static object llAYy0BXkYTDeUCpIa2c(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object GmxUBMBXn9CnMOTyonLX(object P_0)
	{
		return ((IProductionCalendarService)P_0).GetGlobalProductionSchedule();
	}

	internal static bool kgRfQEBXXFh2etWnftDN()
	{
		return lhlLrJBXKE03VMTkGiFs == null;
	}

	internal static NthIncludedDayTrigger cVCVORBXTHLOOMAN2bs6()
	{
		return lhlLrJBXKE03VMTkGiFs;
	}

	internal static void s1vxEoBXOeaIu6OP2MQa()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool kNMRtqBX2J4qO1ym3qkB(object P_0, DateTime runtimeDateTime)
	{
		return ((IProductionSchedule)P_0).IsWorkDay(runtimeDateTime);
	}
}
