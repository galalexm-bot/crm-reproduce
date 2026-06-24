using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using EleWise.ELMA.Calendar.Extensions;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.Scheduling;

namespace EleWise.ELMA.Calendar;

[Serializable]
public class ProductionSchedule : IProductionSchedule
{
	private readonly IEnumerable<TimeInterval> baseWorkingTimeIntervals;

	private readonly WeekDay[] weekDays;

	private readonly List<ExceptionalDay> exceptionalDays;

	private readonly TZSettings tzSettings;

	[Obsolete("Использовать CalendarConstants.ProjectAssemblyUid", true)]
	public const string GUID = "{EAFBC02F-4F64-4229-8698-1AA173FBFCBC}";

	public ProductionSchedule(ProductionScheduleData productionScheduleData, TZSettings tzSettings = null)
	{
		if (productionScheduleData.BaseIntervals == null || !productionScheduleData.BaseIntervals.Any())
		{
			throw new ArgumentException(SR.T("Коллекция базовых интервалов пуста"));
		}
		baseWorkingTimeIntervals = productionScheduleData.BaseIntervals;
		productionScheduleData.FillWithHoliday();
		weekDays = productionScheduleData.WeekDays.OrderBy((WeekDay wd) => wd.DayOfWeek).ToArray();
		exceptionalDays = productionScheduleData.ExceptionalDays.OrderBy((ExceptionalDay ed) => ed.Date).ToList();
		this.tzSettings = tzSettings ?? TZ.Server;
	}

	DateTime IProductionSchedule.StartDateOfWeek(DateTime runtimeDateTime)
	{
		DateTime dateTime = GetComputingDateTime(runtimeDateTime);
		while (dateTime.DayOfWeek != CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek)
		{
			dateTime = dateTime.AddDays(-1.0);
		}
		return GetRuntimeDateTime(dateTime.Date);
	}

	int IProductionSchedule.DayOfWeekNumber(DateTime runtimeDateTime)
	{
		DateTime dateTime = GetComputingDateTime(runtimeDateTime);
		int num = 0;
		while (dateTime.DayOfWeek != CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek)
		{
			dateTime = dateTime.AddDays(-1.0);
			num++;
		}
		return num;
	}

	string IProductionSchedule.MonthName(DateTime runtimeDateTime)
	{
		List<string> list = new List<string>
		{
			SR.T("Январь"),
			SR.T("Февраль"),
			SR.T("Март"),
			SR.T("Апрель"),
			SR.T("Май"),
			SR.T("Июнь"),
			SR.T("Июль"),
			SR.T("Август"),
			SR.T("Сентябрь"),
			SR.T("Октябрь"),
			SR.T("Ноябрь"),
			SR.T("Декабрь")
		};
		return list[GetComputingDateTime(runtimeDateTime).Month - 1];
	}

	public bool IsWorkDay(DateTime runtimeDateTime)
	{
		int lastExceptionalIndex = 0;
		return IsWorkDayByComputingDateTime(GetComputingDateTime(runtimeDateTime), ref lastExceptionalIndex);
	}

	public bool IsWorkDay(DateTime runtimeDateTime, bool needTransformToClientTimezone)
	{
		int lastExceptionalIndex = 0;
		if (needTransformToClientTimezone)
		{
			runtimeDateTime = GetComputingDateTime(runtimeDateTime);
		}
		return IsWorkDayByComputingDateTime(runtimeDateTime, ref lastExceptionalIndex);
	}

	public IEnumerable<DayOfWeek> GetWorkingWeekDays()
	{
		return from wd in weekDays
			where !wd.IsHoliday
			orderby wd.DayOfWeek
			select wd.DayOfWeek;
	}

	public int GetWorkDays(DateTime startRuntimeDateTime, DateTime endRuntimeDateTime)
	{
		int lastExceptionalIndex = 0;
		return GetWorkDaysByComputingDateTime(GetComputingDateTime(startRuntimeDateTime), GetComputingDateTime(endRuntimeDateTime), includingEndDate: true, ref lastExceptionalIndex);
	}

	public TimeSpan GetWorkTimeStart(DateTime runtimeDateTime)
	{
		int lastExceptionalIndex = 0;
		return GetWorkTimeStartByComputingDateTime(GetComputingDateTime(runtimeDateTime), ref lastExceptionalIndex);
	}

	public TimeSpan GetWorkTimeEnd(DateTime runtimeDateTime)
	{
		int lastExceptionalIndex = 0;
		return GetWorkTimeEndByComputingDateTime(GetComputingDateTime(runtimeDateTime), ref lastExceptionalIndex);
	}

	public DateTime CheckWorkDay(DateTime runtimeDateTime)
	{
		int lastExceptionalIndex = 0;
		return GetRuntimeDateTime(CheckWorkDayByComputingDateTime(GetComputingDateTime(runtimeDateTime), ref lastExceptionalIndex));
	}

	public DateTime GetNextWorkTime(DateTime runtimeDateTime)
	{
		DateTime dateTime = CheckWorkDay(runtimeDateTime);
		TimeSpan workTimeStart = GetWorkTimeStart(dateTime);
		TimeSpan workTimeEnd = GetWorkTimeEnd(dateTime);
		if (dateTime.Date != runtimeDateTime.Date)
		{
			dateTime = dateTime.Date + workTimeStart;
		}
		else if (dateTime.TimeOfDay < workTimeStart)
		{
			dateTime = dateTime.Date + workTimeStart;
		}
		else if (dateTime.TimeOfDay > workTimeEnd)
		{
			dateTime = CheckWorkDay(dateTime.AddDays(1.0));
			workTimeStart = GetWorkTimeStart(dateTime);
			dateTime = dateTime.Date + workTimeStart;
		}
		return dateTime;
	}

	public TimeSpan GetMinWorkTimeStartByWeek()
	{
		return (from wti in weekDays.SelectMany((WeekDay wd) => wd.WorkingTimeIntervals)
			select wti.Start).Min();
	}

	public TimeSpan GetMaxWorkTimeEndByWeek()
	{
		return (from wti in weekDays.SelectMany((WeekDay wd) => wd.WorkingTimeIntervals)
			select wti.End).Max();
	}

	public TimeSpan GetWorkTimeInDay()
	{
		return TimeSpan.FromTicks(baseWorkingTimeIntervals.Sum((TimeInterval wt) => wt.Duration.Ticks));
	}

	public TimeSpan GetWorkTimeInDay(DateTime runtimeDateTime)
	{
		int lastExceptionalIndex = 0;
		return GetWorkTimeInDayByComputingDateTime(GetComputingDateTime(runtimeDateTime), ref lastExceptionalIndex);
	}

	public TimeSpan EvalWorkTimeSpanDifference(DateTime startRuntimeDateTime, DateTime endRuntimeDateTime)
	{
		DateTime computingDateTime = GetComputingDateTime(startRuntimeDateTime);
		DateTime computingDateTime2 = GetComputingDateTime(endRuntimeDateTime);
		if (computingDateTime >= computingDateTime2)
		{
			return TimeSpan.Zero;
		}
		TimeSpan timeOfDay = computingDateTime.TimeOfDay;
		TimeSpan timeOfDay2 = computingDateTime2.TimeOfDay;
		int lastExceptionalIndex = 0;
		if (computingDateTime.Date == computingDateTime2.Date)
		{
			return GetWorkingTimeIntervals(startRuntimeDateTime, ref lastExceptionalIndex).GetDurationByPeriod(timeOfDay, timeOfDay2);
		}
		TimeSpan zero = TimeSpan.Zero;
		zero += GetWorkingTimeIntervals(computingDateTime, ref lastExceptionalIndex).GetDurationByPeriod(timeOfDay, TimeSpan.FromDays(1.0));
		DateTime dateTime = computingDateTime.Date.AddDays(1.0);
		DateTime date = computingDateTime2.Date;
		int num = (int)((date - dateTime).TotalDays / 7.0);
		if (num > 0)
		{
			zero += TimeSpan.FromDays(weekDays.Count((WeekDay wd) => !wd.IsHoliday) * num);
		}
		int dayOfWeek = (int)dateTime.DayOfWeek;
		int num2 = (int)date.DayOfWeek;
		TimeSpan timeSpan = TimeSpan.FromDays(1.0);
		if (num2 < dayOfWeek)
		{
			num2 += 7;
		}
		for (int i = dayOfWeek; i < num2; i++)
		{
			if (!weekDays.ElementAt(i % 7).IsHoliday)
			{
				zero += timeSpan;
			}
		}
		return zero + GetWorkingTimeIntervals(computingDateTime2, ref lastExceptionalIndex).GetDurationByPeriod(TimeSpan.Zero, timeOfDay2);
	}

	public TimeSpan EvalWorkTimeDifference(DateTime startRuntimeDateTime, DateTime endRuntimeDateTime)
	{
		return TimeSpan.FromHours(EvalWorkTimeHoursDifference(startRuntimeDateTime, endRuntimeDateTime));
	}

	public double EvalWorkTimeHoursDifference(DateTime startRuntimeDateTime, DateTime endRuntimeDateTime)
	{
		DateTime computingDateTime = GetComputingDateTime(startRuntimeDateTime);
		DateTime computingDateTime2 = GetComputingDateTime(endRuntimeDateTime);
		if (computingDateTime >= computingDateTime2)
		{
			return 0.0;
		}
		TimeSpan timeOfDay = computingDateTime.TimeOfDay;
		TimeSpan timeOfDay2 = computingDateTime2.TimeOfDay;
		int lastExceptionalIndex = 0;
		if (computingDateTime.Date == computingDateTime2.Date)
		{
			return GetWorkingTimeIntervals(startRuntimeDateTime, ref lastExceptionalIndex).GetDurationByPeriod(timeOfDay, timeOfDay2).TotalHours;
		}
		double num = 0.0;
		num += GetWorkingTimeIntervals(computingDateTime, ref lastExceptionalIndex).GetDurationByPeriod(timeOfDay, TimeSpan.FromDays(1.0)).TotalHours;
		DateTime dateTime = computingDateTime.Date.AddDays(1.0);
		DateTime date = computingDateTime2.Date;
		double totalHours = TimeSpan.FromTicks(weekDays.Sum((WeekDay wd) => wd.Duration.Ticks)).TotalHours;
		int num2 = (int)((date - dateTime).TotalDays / 7.0);
		if (num2 > 0)
		{
			num += totalHours * (double)num2;
		}
		int dayOfWeek = (int)dateTime.DayOfWeek;
		int num3 = (int)date.DayOfWeek;
		if (num3 < dayOfWeek)
		{
			num3 += 7;
		}
		for (int i = dayOfWeek; i < num3; i++)
		{
			num += weekDays.ElementAt(i % 7).Duration.TotalHours;
		}
		return num + GetWorkingTimeIntervals(computingDateTime2, ref lastExceptionalIndex).GetDurationByPeriod(TimeSpan.Zero, timeOfDay2).TotalHours;
	}

	public double GetBaseWorkTimeStartDifference(TimeSpan timeOfDay)
	{
		return baseWorkingTimeIntervals.Where((TimeInterval x) => x.Start < timeOfDay).Sum((TimeInterval x) => Math.Min(x.Duration.TotalHours, (timeOfDay - x.Start).TotalHours));
	}

	public double GetBaseWorkTimeEndDifference(TimeSpan timeOfDay)
	{
		return baseWorkingTimeIntervals.Where((TimeInterval x) => x.End > timeOfDay).Sum((TimeInterval x) => Math.Min(x.Duration.TotalHours, (x.End - timeOfDay).TotalHours));
	}

	public DateTime EvalTargetTime(DateTime startRuntimeDateTime, TimeSpan interval)
	{
		DateTime computingDateTime = GetComputingDateTime(startRuntimeDateTime);
		int num = ((interval >= TimeSpan.Zero) ? 1 : (-1));
		if (num < 0)
		{
			interval = -interval;
		}
		int i;
		for (i = 0; i >= 0 && i < exceptionalDays.Count && exceptionalDays[i].Date < computingDateTime.Date; i++)
		{
		}
		TimeSpan workTimeStartByComputingDateTime;
		TimeSpan workTimeEndByComputingDateTime;
		IEnumerable<TimeInterval> workingTimeIntervals;
		if (IsWorkDayByComputingDateTime(computingDateTime, ref i, findExceptionalDay: true, num))
		{
			workTimeStartByComputingDateTime = GetWorkTimeStartByComputingDateTime(computingDateTime, ref i);
			workTimeEndByComputingDateTime = GetWorkTimeEndByComputingDateTime(computingDateTime, ref i);
			if (computingDateTime.TimeOfDay <= workTimeStartByComputingDateTime)
			{
				computingDateTime = ((num <= 0) ? computingDateTime.Date.AddSeconds(-1.0) : computingDateTime.Date.Add(workTimeStartByComputingDateTime));
			}
			else if (computingDateTime.TimeOfDay >= workTimeEndByComputingDateTime)
			{
				computingDateTime = ((num <= 0) ? computingDateTime.Date.AddDays(1.0).AddSeconds(-1.0) : computingDateTime.Date.AddDays(1.0));
			}
			else
			{
				workingTimeIntervals = GetWorkingTimeIntervals(computingDateTime, ref i);
				computingDateTime = GetNearestWorkingTimeByDelta(workingTimeIntervals, computingDateTime, num);
			}
		}
		else
		{
			computingDateTime = computingDateTime.Date;
			if (num < 0)
			{
				computingDateTime = computingDateTime.AddDays(1.0).AddSeconds(-1.0);
			}
		}
		TimeSpan timeSpan = TimeSpan.FromDays(1.0);
		while (true)
		{
			if (!IsWorkDayByComputingDateTime(computingDateTime, ref i, findExceptionalDay: false, num))
			{
				computingDateTime = computingDateTime.AddDays(num);
				continue;
			}
			if (interval < timeSpan)
			{
				break;
			}
			DateTime dateTime = computingDateTime.AddDays((int)interval.TotalDays * num);
			int num2 = ((num > 0) ? GetWorkDaysByComputingDateTime(computingDateTime, dateTime, includingEndDate: false, ref i, useExceptionalDays: false) : GetWorkDaysByComputingDateTime(dateTime.AddDays(1.0), computingDateTime.AddDays(1.0), includingEndDate: false, ref i, useExceptionalDays: false));
			interval -= TimeSpan.FromDays(num2);
			computingDateTime = dateTime;
		}
		if (interval > TimeSpan.Zero)
		{
			return GetRuntimeDateTime(EvalTargetTimeByComputingDateTime(computingDateTime, (double)num * interval.TotalHours));
		}
		workTimeStartByComputingDateTime = GetWorkTimeStartByComputingDateTime(computingDateTime, ref i, findExceptionalDay: false);
		workTimeEndByComputingDateTime = GetWorkTimeEndByComputingDateTime(computingDateTime, ref i, findExceptionalDay: false);
		if (computingDateTime.TimeOfDay <= workTimeStartByComputingDateTime || computingDateTime.TimeOfDay >= workTimeEndByComputingDateTime)
		{
			if ((num > 0) ? (computingDateTime.TimeOfDay <= workTimeStartByComputingDateTime) : (computingDateTime.TimeOfDay >= workTimeEndByComputingDateTime))
			{
				i -= num;
				computingDateTime = computingDateTime.Date.AddDays(-num);
				while (!IsWorkDayByComputingDateTime(computingDateTime, ref i, findExceptionalDay: false, num))
				{
					computingDateTime = computingDateTime.AddDays(-num);
				}
				workTimeStartByComputingDateTime = GetWorkTimeStartByComputingDateTime(computingDateTime, ref i, findExceptionalDay: false);
				workTimeEndByComputingDateTime = GetWorkTimeEndByComputingDateTime(computingDateTime, ref i, findExceptionalDay: false);
			}
			computingDateTime = computingDateTime.Date.Add((num > 0) ? workTimeEndByComputingDateTime : workTimeStartByComputingDateTime);
		}
		workingTimeIntervals = GetWorkingTimeIntervals(computingDateTime, ref i);
		computingDateTime = GetNearestWorkingTimeByDelta(workingTimeIntervals, computingDateTime, num);
		return GetRuntimeDateTime(computingDateTime);
	}

	public DateTime EvalTargetTime(DateTime startRuntimeDateTime, double intervalHours)
	{
		return GetRuntimeDateTime(EvalTargetTimeByComputingDateTime(GetComputingDateTime(startRuntimeDateTime), intervalHours));
	}

	public DateTime AddDays(DateTime startRuntimeDateTime, int addDays)
	{
		DateTime dateTime = GetComputingDateTime(startRuntimeDateTime).Date;
		int num = ((addDays >= 0) ? 1 : (-1));
		addDays = Math.Abs(addDays);
		int lastExceptionalIndex = 0;
		IsWorkDayByComputingDateTime(dateTime, ref lastExceptionalIndex);
		if (num < 0)
		{
			lastExceptionalIndex += num;
		}
		while (addDays > 0)
		{
			if (!IsWorkDayByComputingDateTime(dateTime, ref lastExceptionalIndex, findExceptionalDay: false))
			{
				dateTime = dateTime.AddDays(num);
				continue;
			}
			DateTime dateTime2 = dateTime.AddDays(addDays * num);
			int num2 = ((num > 0) ? GetWorkDaysByComputingDateTime(dateTime, dateTime2, includingEndDate: false, ref lastExceptionalIndex, useExceptionalDays: false) : GetWorkDaysByComputingDateTime(dateTime2.AddDays(1.0), dateTime.AddDays(1.0), includingEndDate: false, ref lastExceptionalIndex, useExceptionalDays: false));
			addDays -= num2;
			dateTime = dateTime2;
		}
		while (!IsWorkDayByComputingDateTime(dateTime, ref lastExceptionalIndex, findExceptionalDay: false))
		{
			dateTime = dateTime.AddDays(num);
		}
		return dateTime.ToRuntimeDateTimeFromServer();
	}

	private DateTime GetComputingDateTime(DateTime runtimeDateTime)
	{
		DateTime dateTime = runtimeDateTime.ToClientDateTime(tzSettings);
		return dateTime.Date + TimeSpan.FromSeconds((int)dateTime.TimeOfDay.TotalSeconds);
	}

	private DateTime GetRuntimeDateTime(DateTime dateTimeForComputation)
	{
		return dateTimeForComputation.ToRuntimeDateTimeFromClient(tzSettings);
	}

	private bool IsWorkDayByComputingDateTime(DateTime computingDateTime, ref int lastExceptionalIndex, bool findExceptionalDay = true, int delta = 1)
	{
		WeekDay weekDay = weekDays.First((WeekDay wd) => wd.DayOfWeek == computingDateTime.DayOfWeek);
		return !weekDay.IsHoliday;
	}

	private ExceptionalDay FindExceptionalDayByComputingDateTime(DateTime computingDateTime, ref int lastExceptionalIndex, bool findExceptionalDay = true, int delta = 1)
	{
		while (findExceptionalDay && lastExceptionalIndex >= 0 && lastExceptionalIndex < exceptionalDays.Count() && ((delta > 0) ? (exceptionalDays[lastExceptionalIndex].Date < computingDateTime.Date) : (exceptionalDays[lastExceptionalIndex].Date > computingDateTime.Date)))
		{
			lastExceptionalIndex += delta;
		}
		return (lastExceptionalIndex >= 0 && lastExceptionalIndex < exceptionalDays.Count) ? exceptionalDays[lastExceptionalIndex] : null;
	}

	private int GetWorkDaysByComputingDateTime(DateTime startComputingDateTime, DateTime endComputingDateTime, bool includingEndDate, ref int lastExceptionalIndex, bool useExceptionalDays = true)
	{
		if (startComputingDateTime > endComputingDateTime)
		{
			return 0;
		}
		startComputingDateTime = startComputingDateTime.Date;
		endComputingDateTime = (includingEndDate ? endComputingDateTime.Date.AddDays(1.0) : endComputingDateTime.Date);
		int num = 0;
		int num2 = (int)((endComputingDateTime - startComputingDateTime).TotalDays / 7.0);
		if (num2 > 0)
		{
			num += weekDays.Count((WeekDay d) => !d.IsHoliday) * num2;
		}
		int dayOfWeek = (int)startComputingDateTime.DayOfWeek;
		int num3 = (int)endComputingDateTime.DayOfWeek;
		if (num3 < dayOfWeek)
		{
			num3 += 7;
		}
		for (int i = dayOfWeek; i < num3; i++)
		{
			if (!weekDays[i % 7].IsHoliday)
			{
				num++;
			}
		}
		return num;
	}

	private TimeSpan GetWorkTimeStartByComputingDateTime(DateTime computingDateTime, ref int lastExceptionalIndex, bool findExceptionalDay = true)
	{
		WeekDay weekDay = weekDays.First((WeekDay wd) => wd.DayOfWeek == computingDateTime.DayOfWeek);
		return weekDay.IsHoliday ? TimeSpan.Zero : weekDay.WorkingTimeIntervals.First().Start;
	}

	private TimeSpan GetWorkTimeEndByComputingDateTime(DateTime computingDateTime, ref int lastExceptionalIndex, bool findExceptionalDay = true)
	{
		WeekDay weekDay = weekDays.First((WeekDay wd) => wd.DayOfWeek == computingDateTime.DayOfWeek);
		return weekDay.IsHoliday ? TimeSpan.Zero : weekDay.WorkingTimeIntervals.Last().End;
	}

	private DateTime CheckWorkDayByComputingDateTime(DateTime computingDateTime, ref int lastExceptionalIndex)
	{
		bool flag = false;
		while (!flag)
		{
			flag = IsWorkDayByComputingDateTime(computingDateTime, ref lastExceptionalIndex);
			if (!flag)
			{
				computingDateTime = computingDateTime.AddDays(1.0);
			}
		}
		return computingDateTime;
	}

	private TimeSpan GetWorkTimeInDayByComputingDateTime(DateTime computingDateTime, ref int lastExceptionalIndex)
	{
		WeekDay weekDay = weekDays.First((WeekDay wd) => wd.DayOfWeek == computingDateTime.DayOfWeek);
		return weekDay.Duration;
	}

	private IEnumerable<TimeInterval> GetWorkingTimeIntervals(DateTime computingDateTime, ref int lastExceptionalIndex)
	{
		WeekDay weekDay = weekDays.First((WeekDay wd) => wd.DayOfWeek == computingDateTime.DayOfWeek);
		return weekDay.WorkingTimeIntervals;
	}

	private DateTime GetNearestWorkingTimeByDelta(IEnumerable<TimeInterval> workingTimeIntervals, DateTime computingTime, int delta)
	{
		TimeInterval[] array = (workingTimeIntervals as TimeInterval[]) ?? workingTimeIntervals.ToArray();
		if (array.Length <= 1)
		{
			return computingTime;
		}
		for (int i = 0; i < array.Length; i++)
		{
			if (i + 1 < array.Length)
			{
				TimeSpan end = array[i].End;
				TimeSpan start = array[i + 1].Start;
				TimeSpan timeOfDay = computingTime.TimeOfDay;
				if (timeOfDay >= end && timeOfDay <= start)
				{
					computingTime = ((delta > 0) ? computingTime.Date.Add(start) : computingTime.Date.Add(end));
					break;
				}
			}
		}
		return computingTime;
	}

	private DateTime EvalTargetTimeByComputingDateTime(DateTime computingDateTime, double intervalHours)
	{
		int num = ((intervalHours >= 0.0) ? 1 : (-1));
		intervalHours = Math.Abs(intervalHours);
		DateTime targetTime = computingDateTime;
		int i;
		for (i = 0; i >= 0 && i < exceptionalDays.Count && exceptionalDays[i].Date < targetTime.Date; i++)
		{
		}
		TimeInterval[] array;
		if (IsWorkDayByComputingDateTime(targetTime, ref i, findExceptionalDay: true, num))
		{
			TimeSpan workTimeStartByComputingDateTime = GetWorkTimeStartByComputingDateTime(targetTime, ref i);
			TimeSpan workTimeEndByComputingDateTime = GetWorkTimeEndByComputingDateTime(targetTime, ref i);
			if ((num > 0) ? (targetTime.TimeOfDay < workTimeEndByComputingDateTime) : (targetTime.TimeOfDay > workTimeStartByComputingDateTime))
			{
				if (num > 0 && targetTime.TimeOfDay < workTimeStartByComputingDateTime)
				{
					targetTime = targetTime.Date.Add(workTimeStartByComputingDateTime);
				}
				if (num < 0 && targetTime.TimeOfDay > workTimeEndByComputingDateTime)
				{
					targetTime = targetTime.Date.Add(workTimeEndByComputingDateTime);
				}
				array = GetWorkingTimeIntervals(targetTime, ref i).ToArray();
				targetTime = GetNearestWorkingTimeByDelta(array, targetTime, num);
				TimeInterval targetWorkingTime = array.First((TimeInterval wt) => targetTime.TimeOfDay >= wt.Start && targetTime.TimeOfDay <= wt.End);
				TimeInterval[] array2 = ((num > 0) ? array.SkipWhile((TimeInterval wt) => wt.End < targetWorkingTime.Start).ToArray() : array.TakeWhile((TimeInterval wt) => wt.Start < targetWorkingTime.End).Reverse().ToArray());
				for (int j = 0; j < array2.Length; j++)
				{
					TimeInterval timeInterval = array2[j];
					double totalHours;
					if ((totalHours = ((num > 0) ? (timeInterval.End - targetTime.TimeOfDay) : (targetTime.TimeOfDay - timeInterval.Start)).TotalHours) < intervalHours)
					{
						intervalHours -= totalHours;
						targetTime = ((j + 1 < array2.Length) ? targetTime.Date.Add((num > 0) ? array2[j + 1].Start : array2[j + 1].End) : targetTime.Date.Add((num > 0) ? timeInterval.End : timeInterval.Start));
						continue;
					}
					targetTime = targetTime.Add(TimeSpan.FromHours(intervalHours * (double)num));
					return targetTime;
				}
			}
		}
		targetTime = targetTime.Date.AddDays(num);
		double num2 = weekDays.Sum((WeekDay wd) => wd.Duration.TotalHours);
		while (true)
		{
			if (!IsWorkDayByComputingDateTime(targetTime, ref i, findExceptionalDay: false, num))
			{
				targetTime = targetTime.AddDays(num);
				continue;
			}
			int lastExceptionalIndex = 0;
			double totalHours2 = GetWorkTimeInDayByComputingDateTime(targetTime, ref lastExceptionalIndex).TotalHours;
			if (intervalHours <= totalHours2)
			{
				break;
			}
			DateTime dateTime = targetTime.AddDays((int)(intervalHours / num2) * num * 7);
			if (intervalHours >= num2)
			{
				int num3 = 0;
				DateTime dateTime2 = ((num > 0) ? targetTime.Date : dateTime.Date.AddDays(1.0));
				DateTime dateTime3 = ((num > 0) ? dateTime.Date : targetTime.Date.AddDays(1.0));
				if (dateTime2 <= dateTime3)
				{
					num3 = (int)((dateTime3 - dateTime2).TotalDays / 7.0);
				}
				intervalHours -= (double)num3 * num2;
				targetTime = targetTime.AddDays(num3 * 7 * num);
			}
			while ((num > 0) ? (targetTime.Date < dateTime) : (targetTime.Date > dateTime))
			{
				lastExceptionalIndex = 0;
				totalHours2 = GetWorkTimeInDayByComputingDateTime(targetTime, ref lastExceptionalIndex).TotalHours;
				intervalHours -= totalHours2;
				targetTime = targetTime.AddDays(num);
			}
			if (intervalHours < num2)
			{
				dateTime = targetTime.AddDays(num);
				lastExceptionalIndex = 0;
				totalHours2 = GetWorkTimeInDayByComputingDateTime(targetTime, ref lastExceptionalIndex).TotalHours;
				while (intervalHours >= totalHours2 && ((num > 0) ? (targetTime.Date < dateTime) : (targetTime.Date > dateTime)))
				{
					intervalHours -= totalHours2;
					targetTime = targetTime.AddDays(num);
					dateTime = targetTime.AddDays(num);
					lastExceptionalIndex = 0;
					totalHours2 = GetWorkTimeInDayByComputingDateTime(targetTime, ref lastExceptionalIndex).TotalHours;
				}
			}
		}
		targetTime += ((num > 0) ? GetWorkTimeStartByComputingDateTime(targetTime, ref i) : GetWorkTimeEndByComputingDateTime(targetTime, ref i));
		array = GetWorkingTimeIntervals(targetTime, ref i).ToArray();
		if (num < 0)
		{
			array = array.Reverse().ToArray();
		}
		for (int k = 0; k < array.Length; k++)
		{
			TimeInterval timeInterval2 = array[k];
			double totalHours3;
			if ((num > 0) ? ((totalHours3 = (timeInterval2.End - targetTime.TimeOfDay).TotalHours) <= intervalHours) : ((totalHours3 = (targetTime.TimeOfDay - timeInterval2.Start).TotalHours) <= intervalHours))
			{
				intervalHours -= totalHours3;
				targetTime = ((k + 1 < array.Length) ? targetTime.Date.Add((num > 0) ? array[k + 1].Start : array[k + 1].End) : targetTime.Date.Add((num > 0) ? timeInterval2.End : timeInterval2.Start));
				continue;
			}
			targetTime = targetTime.Add(TimeSpan.FromHours(intervalHours * (double)num));
			break;
		}
		return targetTime;
	}
}
