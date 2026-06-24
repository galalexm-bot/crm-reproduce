using System;
using EleWise.ELMA.Common.Enums;
using EleWise.ELMA.Common.Extensions;

namespace EleWise.ELMA.Common.Models.PeriodicalEntitySettings;

public sealed class MonthlyPeriodicalEntitySettings : IPeriodicalEntitySettings
{
	public int RepeatEvery { get; set; } = 1;


	public EventPeriodicityType PeriodicityType { get; set; }

	public int DayOfMonth { get; set; }

	public PeriodicityDayOfWeek DayOfWeek { get; set; }

	public PeriodicityWeekNumber WeekNumber { get; set; }

	public MonthlyPeriodicalEntitySettings()
	{
	}

	public MonthlyPeriodicalEntitySettings(IPeriodicalEntityExtension periodicalEntity)
	{
		if (periodicalEntity != null)
		{
			DayOfMonth = periodicalEntity.StartDate.Day;
			PeriodicityType = EventPeriodicityType.Absolute;
		}
	}

	public DateTime GetNextDate(DateTime fromDate, DateTime currentDate)
	{
		ValidateSettings();
		if (PeriodicityType == EventPeriodicityType.Absolute)
		{
			return GetAbsoluteNextDate(fromDate, currentDate);
		}
		return GetRelativeNextDate(fromDate, currentDate);
	}

	public DateTime MoveDate(DateTime oldDate, DateTime oldStartDate, DateTime startDate)
	{
		ValidateSettings();
		Contract.Check<ArgumentOutOfRangeException>(oldDate >= oldStartDate, "oldDate >= oldStartDate");
		if (PeriodicityType == EventPeriodicityType.Absolute)
		{
			DateTime prevDateWithDay = GetPrevDateWithDay(oldStartDate, DayOfMonth, RepeatEvery);
			int absoluteEventCountForPeriod = GetAbsoluteEventCountForPeriod(prevDateWithDay, oldDate);
			DateTime prevDateWithDay2 = GetPrevDateWithDay(startDate, DayOfMonth, RepeatEvery);
			return GetAbsoluteNextDate(prevDateWithDay2, absoluteEventCountForPeriod);
		}
		DateTime prevRelativeDate = GetPrevRelativeDate(oldStartDate);
		int relativeEventCountForPeriod = GetRelativeEventCountForPeriod(prevRelativeDate, oldDate);
		DateTime prevRelativeDate2 = GetPrevRelativeDate(startDate);
		return GetRelativeNextDate(prevRelativeDate2, relativeEventCountForPeriod);
	}

	private void ValidateSettings()
	{
		Contract.Check<ArgumentOutOfRangeException>(RepeatEvery > 0, "RepeatEvery > 0");
		Contract.Check<ArgumentException>(Enum.IsDefined(typeof(EventPeriodicityType), PeriodicityType), "Enum.IsDefined(PeriodicityType)");
		Contract.Check<ArgumentOutOfRangeException>(PeriodicityType != 0 || (DayOfMonth > 0 && DayOfMonth <= 31), "DayOfMonth > 0 && DayOfMonth <= 31");
	}

	private DateTime GetAbsoluteNextDate(DateTime fromDate, DateTime currentDate)
	{
		return PeriodicalEntityHelper.GetNextDate(GetPrevDateWithDay(fromDate, DayOfMonth, RepeatEvery), currentDate, GetAbsoluteEventCountForPeriod, GetAbsoluteNextDate, moveBeforeHoliday: false);
	}

	private int GetAbsoluteEventCountForPeriod(DateTime from, DateTime current)
	{
		int num = 0;
		DateTime dateTime = from;
		while (dateTime < current)
		{
			dateTime = from.AddMonths(RepeatEvery * num);
			int dayOfMonth = GetDayOfMonth(dateTime, DayOfMonth);
			dateTime = dateTime.AddDays(dayOfMonth - dateTime.Day);
			if (dateTime < current)
			{
				num++;
			}
		}
		return num;
	}

	private DateTime GetAbsoluteNextDate(DateTime date, int count)
	{
		DateTime date2 = date.AddMonths(count * RepeatEvery);
		int num = GetDayOfMonth(date2, DayOfMonth) - date2.Day;
		return date2.AddDays(num);
	}

	private static DateTime GetPrevDateWithDay(DateTime date, int day, int step)
	{
		int dayOfMonth = GetDayOfMonth(date, day);
		if (date.Day >= dayOfMonth)
		{
			return date.AddDays(dayOfMonth - date.Day);
		}
		DateTime date2 = date.AddMonths(-step);
		dayOfMonth = GetDayOfMonth(date2, day);
		return date2.AddDays(dayOfMonth - date2.Day);
	}

	private static int GetDayOfMonth(DateTime date, int day)
	{
		if (DateTime.DaysInMonth(date.Year, date.Month) < day)
		{
			return DateTime.DaysInMonth(date.Year, date.Month);
		}
		return day;
	}

	private DateTime GetPrevRelativeDate(DateTime from)
	{
		int eventDay = GetEventDay(from.Year, from.Month);
		if (from.Day >= eventDay)
		{
			return from.AddDays(eventDay - from.Day);
		}
		DateTime dateTime = from.AddMonths(-RepeatEvery);
		int eventDay2 = GetEventDay(dateTime.Year, dateTime.Month);
		return dateTime.AddDays(eventDay2 - dateTime.Day);
	}

	private DateTime GetRelativeNextDate(DateTime fromDate, DateTime currentDate)
	{
		return PeriodicalEntityHelper.GetNextDate(fromDate, currentDate, GetRelativeEventCountForPeriod, GetRelativeNextDate, moveBeforeHoliday: false);
	}

	private int GetRelativeEventCountForPeriod(DateTime from, DateTime current)
	{
		int num = 0;
		DateTime dateTime = from;
		while (dateTime < current)
		{
			num++;
			dateTime = dateTime.AddMonths(RepeatEvery);
			int eventDay = GetEventDay(dateTime.Year, dateTime.Month);
			dateTime = dateTime.AddDays(eventDay - dateTime.Day);
		}
		return num;
	}

	private DateTime GetRelativeNextDate(DateTime currentDate, int step)
	{
		int eventDay = GetEventDay(currentDate.Year, currentDate.Month);
		int num = step;
		if (eventDay > currentDate.Day)
		{
			num--;
		}
		DateTime dateTime = currentDate.AddMonths(num * RepeatEvery);
		eventDay = GetEventDay(dateTime.Year, dateTime.Month);
		return dateTime.AddDays(eventDay - dateTime.Day);
	}

	private int GetEventDay(int year, int month)
	{
		if (DayOfWeek == PeriodicityDayOfWeek.Day)
		{
			return GetDayOfMonthFromWeekNumber(WeekNumber, year, month);
		}
		return GetDayOfMonthFromDayOfWeek(GetDayOfWeekFromPeriodicity(DayOfWeek), WeekNumber, year, month);
	}

	private static int GetDayOfMonthFromDayOfWeek(DayOfWeek dayOfWeek, PeriodicityWeekNumber weekNumber, int year, int month)
	{
		DateTime dateTime = new DateTime(year, month, 1);
		if (dateTime.DayOfWeek != dayOfWeek)
		{
			dateTime = dateTime.AddDays((dayOfWeek - dateTime.DayOfWeek + 7) % 7);
		}
		switch (weekNumber)
		{
		case PeriodicityWeekNumber.First:
			return dateTime.Day;
		case PeriodicityWeekNumber.Second:
			return dateTime.AddDays(7.0).Day;
		case PeriodicityWeekNumber.Third:
			return dateTime.AddDays(14.0).Day;
		case PeriodicityWeekNumber.Fourth:
			return dateTime.AddDays(21.0).Day;
		case PeriodicityWeekNumber.Last:
		{
			DateTime dateTime2 = new DateTime(year, month, DateTime.DaysInMonth(year, month));
			return dateTime2.AddDays((dayOfWeek - dateTime2.DayOfWeek - 7) % 7).Day;
		}
		default:
			throw new ArgumentException(SR.T("Неверное значение номера недели"), "weekNumber");
		}
	}

	private static int GetMonths(DateTime from, DateTime current)
	{
		return (current.Year - from.Year) * 12 + current.Month - from.Month;
	}

	private static int GetDayOfMonthFromWeekNumber(PeriodicityWeekNumber number, int year, int month)
	{
		return number switch
		{
			PeriodicityWeekNumber.First => 1, 
			PeriodicityWeekNumber.Second => 2, 
			PeriodicityWeekNumber.Third => 3, 
			PeriodicityWeekNumber.Fourth => 4, 
			PeriodicityWeekNumber.Last => DateTime.DaysInMonth(year, month), 
			_ => throw new ArgumentException(SR.T("Неизвестный номер недели"), "number"), 
		};
	}

	private static DayOfWeek GetDayOfWeekFromPeriodicity(PeriodicityDayOfWeek periodicity)
	{
		return periodicity switch
		{
			PeriodicityDayOfWeek.Monday => System.DayOfWeek.Monday, 
			PeriodicityDayOfWeek.Tuesday => System.DayOfWeek.Tuesday, 
			PeriodicityDayOfWeek.Wednesday => System.DayOfWeek.Wednesday, 
			PeriodicityDayOfWeek.Thursday => System.DayOfWeek.Thursday, 
			PeriodicityDayOfWeek.Friday => System.DayOfWeek.Friday, 
			PeriodicityDayOfWeek.Saturday => System.DayOfWeek.Saturday, 
			PeriodicityDayOfWeek.Sunday => System.DayOfWeek.Sunday, 
			_ => throw new ArgumentException(SR.T("Неизвестный день недели"), "periodicity"), 
		};
	}

	public override bool Equals(object obj)
	{
		if (obj is MonthlyPeriodicalEntitySettings monthlyPeriodicalEntitySettings && RepeatEvery == monthlyPeriodicalEntitySettings.RepeatEvery)
		{
			if (PeriodicityType != 0 || monthlyPeriodicalEntitySettings.PeriodicityType != 0 || DayOfMonth != monthlyPeriodicalEntitySettings.DayOfMonth)
			{
				if (PeriodicityType == EventPeriodicityType.Relative && monthlyPeriodicalEntitySettings.PeriodicityType == EventPeriodicityType.Relative && DayOfWeek == monthlyPeriodicalEntitySettings.DayOfWeek)
				{
					return WeekNumber == monthlyPeriodicalEntitySettings.WeekNumber;
				}
				return false;
			}
			return true;
		}
		return false;
	}

	public override int GetHashCode()
	{
		int num = -108832133;
		num = num * -1521134295 + RepeatEvery.GetHashCode();
		num = num * -1521134295 + PeriodicityType.GetHashCode();
		if (PeriodicityType == EventPeriodicityType.Absolute)
		{
			return num * -1521134295 + DayOfMonth.GetHashCode();
		}
		num = num * -1521134295 + DayOfWeek.GetHashCode();
		return num * -1521134295 + WeekNumber.GetHashCode();
	}
}
