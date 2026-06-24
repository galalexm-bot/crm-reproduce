using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using EleWise.ELMA.Common.Extensions;
using EleWise.ELMA.Extensions;

namespace EleWise.ELMA.Common.Models.PeriodicalEntitySettings;

public sealed class WeeklyPeriodicalEntitySettings : IPeriodicalEntitySettings
{
	private DayOfWeek StartDayOfWeek => CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek;

	public int RepeatEvery { get; set; } = 1;


	public List<DayOfWeek> DaysOfWeek { get; set; }

	public WeeklyPeriodicalEntitySettings()
	{
	}

	public WeeklyPeriodicalEntitySettings(IPeriodicalEntityExtension periodicalEntity)
	{
		if (periodicalEntity != null)
		{
			DaysOfWeek = new List<DayOfWeek> { periodicalEntity.StartDate.DayOfWeek };
		}
	}

	public DateTime GetNextDate(DateTime fromDate, DateTime currentDate)
	{
		ValidateSettings();
		List<int> daysOfWeek = GetOrderedDaysOfWeek();
		return PeriodicalEntityHelper.GetNextDate(GetPrevDateWeekStartDate(fromDate, daysOfWeek), currentDate, (DateTime f, DateTime c) => GetCountForPeriod(f, c, daysOfWeek), (DateTime d, int c) => GetNextDate(d, c, daysOfWeek), moveBeforeHoliday: false);
	}

	public DateTime MoveDate(DateTime oldDate, DateTime oldStartDate, DateTime startDate)
	{
		ValidateSettings();
		Contract.Check<ArgumentOutOfRangeException>(oldDate >= oldStartDate, "oldDate >= oldStartDate");
		List<int> orderedDaysOfWeek = GetOrderedDaysOfWeek();
		DateTime prevDateWeekStartDate = GetPrevDateWeekStartDate(oldStartDate, orderedDaysOfWeek);
		int countForPeriod = GetCountForPeriod(prevDateWeekStartDate, oldDate, orderedDaysOfWeek);
		DateTime prevDateWeekStartDate2 = GetPrevDateWeekStartDate(startDate, orderedDaysOfWeek);
		int weekBias = GetWeekBias(oldStartDate.DayOfWeek.GetDayOfWeekNumber(StartDayOfWeek), orderedDaysOfWeek);
		int weekBias2 = GetWeekBias(startDate.DayOfWeek.GetDayOfWeekNumber(StartDayOfWeek), orderedDaysOfWeek);
		return GetNextDate(prevDateWeekStartDate2, countForPeriod + (weekBias2 - weekBias), orderedDaysOfWeek);
	}

	private void ValidateSettings()
	{
		Contract.Check<ArgumentOutOfRangeException>(RepeatEvery > 0, "RepeatEvery > 0");
		Contract.NotNull(DaysOfWeek, "DaysOfWeek");
		Contract.Check<ArgumentException>(DaysOfWeek.Count > 0, "DaysOfWeek.Count > 0");
	}

	private DateTime GetNextDate(DateTime from, int step, List<int> daysOfWeek)
	{
		int num = step / daysOfWeek.Count;
		int index = step % daysOfWeek.Count;
		int num2 = daysOfWeek[index];
		int dayOfWeekNumber = from.DayOfWeek.GetDayOfWeekNumber(StartDayOfWeek);
		int num3 = (num2 - dayOfWeekNumber + 7) % 7;
		return from.AddDays(num * RepeatEvery * 7 + num3);
	}

	private int GetCountForPeriod(DateTime from, DateTime current, List<int> daysOfWeek)
	{
		int num = (int)(current - from).TotalDays / (7 * RepeatEvery) * daysOfWeek.Count;
		int dayOfWeekNumber = from.DayOfWeek.GetDayOfWeekNumber(StartDayOfWeek);
		int dayOfWeekNumber2 = current.DayOfWeek.GetDayOfWeekNumber(StartDayOfWeek);
		int weekBias = GetWeekBias(dayOfWeekNumber, daysOfWeek);
		int weekBias2 = GetWeekBias(dayOfWeekNumber2, daysOfWeek);
		return num + Math.Abs(weekBias - weekBias2);
	}

	private DateTime GetPrevDateWeekStartDate(DateTime fromDate, List<int> daysOfWeek)
	{
		int dayOfWeekNumber = fromDate.DayOfWeek.GetDayOfWeekNumber(StartDayOfWeek);
		int weekBias = GetWeekBias(dayOfWeekNumber, daysOfWeek);
		int num = (dayOfWeekNumber - daysOfWeek[weekBias] + 7) % 7;
		DateTime prevDate = fromDate.AddDays(-num);
		bool flag = IsSameWeek(fromDate, prevDate, StartDayOfWeek);
		if ((weekBias + 1) % daysOfWeek.Count == 0 && !flag)
		{
			prevDate = prevDate.AddDays(-((RepeatEvery - 1) * 7));
		}
		return prevDate.AddDays(-daysOfWeek[weekBias] + daysOfWeek[0]);
	}

	private List<int> GetOrderedDaysOfWeek()
	{
		return (from i in DaysOfWeek.Select((DayOfWeek i) => i.GetDayOfWeekNumber(StartDayOfWeek)).Distinct()
			orderby i
			select i).ToList();
	}

	private static bool IsSameWeek(DateTime currentDate, DateTime prevDate, DayOfWeek startDayOfWeek)
	{
		int dayOfWeekNumber = currentDate.DayOfWeek.GetDayOfWeekNumber(startDayOfWeek);
		int dayOfWeekNumber2 = prevDate.DayOfWeek.GetDayOfWeekNumber(startDayOfWeek);
		return currentDate.Date.AddDays(-dayOfWeekNumber) == prevDate.Date.AddDays(-dayOfWeekNumber2);
	}

	private static int GetWeekBias(int current, List<int> days)
	{
		int num = days.IndexOf(current);
		if (num != -1)
		{
			return num;
		}
		for (int i = 0; i < days.Count; i++)
		{
			if (days[i] > current)
			{
				return (i - 1 + days.Count) % days.Count;
			}
		}
		return days.Count - 1;
	}

	public override bool Equals(object obj)
	{
		if (obj is WeeklyPeriodicalEntitySettings weeklyPeriodicalEntitySettings && RepeatEvery == weeklyPeriodicalEntitySettings.RepeatEvery)
		{
			return DaysOfWeek.SequenceEqual(weeklyPeriodicalEntitySettings.DaysOfWeek);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return (1673267196 * -1521134295 + RepeatEvery.GetHashCode()) * -1521134295 + EqualityComparer<List<DayOfWeek>>.Default.GetHashCode(DaysOfWeek);
	}
}
