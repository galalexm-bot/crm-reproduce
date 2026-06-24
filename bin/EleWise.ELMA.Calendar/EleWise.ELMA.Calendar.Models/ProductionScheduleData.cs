using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Calendar.Extensions;

namespace EleWise.ELMA.Calendar.Models;

public class ProductionScheduleData
{
	private readonly DayOfWeek[] dayOfWeeks = Enum.GetValues(typeof(DayOfWeek)).Cast<DayOfWeek>().ToArray();

	private IEnumerable<TimeInterval> realBaseIntervalCollection;

	private List<TimeInterval> originalBaseIntervalCollection;

	private List<TimeInterval> breakBaseIntervalCollection;

	private List<WeekDay> weekDays;

	private List<ExceptionalDay> exceptionalDays;

	public IEnumerable<TimeInterval> BaseIntervals
	{
		get
		{
			if (realBaseIntervalCollection == null)
			{
				return realBaseIntervalCollection = originalBaseIntervalCollection.PullBreaks(breakBaseIntervalCollection);
			}
			return realBaseIntervalCollection;
		}
	}

	public IEnumerable<WeekDay> WeekDays => weekDays;

	public IEnumerable<ExceptionalDay> ExceptionalDays => exceptionalDays;

	public ProductionScheduleData(IEnumerable<TimeInterval> baseIntervalCollection, IEnumerable<WeekDay> weekDays, IEnumerable<ExceptionalDay> exceptionalDays)
	{
		this.weekDays = ((weekDays == null) ? new List<WeekDay>() : weekDays.Squash().ToList());
		this.exceptionalDays = ((exceptionalDays == null) ? new List<ExceptionalDay>() : exceptionalDays.Squash().ToList());
		if (baseIntervalCollection == null || !baseIntervalCollection.Any())
		{
			throw new ArgumentException(SR.T("Коллекция базовых интервалов пуста"));
		}
		originalBaseIntervalCollection = baseIntervalCollection.Squash().ToList();
		breakBaseIntervalCollection = new List<TimeInterval>();
	}

	public ProductionScheduleData Aggregate(ProductionScheduleData data)
	{
		if (data == null)
		{
			return this;
		}
		originalBaseIntervalCollection.AddRange(data.originalBaseIntervalCollection);
		originalBaseIntervalCollection = originalBaseIntervalCollection.Squash().ToList();
		weekDays.AddRange(data.weekDays);
		weekDays = weekDays.Squash().ToList();
		exceptionalDays.AddRange(data.exceptionalDays);
		exceptionalDays = exceptionalDays.Squash().ToList();
		return this;
	}

	public void OverridingPowerUp()
	{
		breakBaseIntervalCollection = originalBaseIntervalCollection.GetInvertedIntervalCollection().ToList();
		FillWithHoliday();
		weekDays.ForEach(delegate(WeekDay wd)
		{
			wd.OverridingPowerUp();
		});
		exceptionalDays.ForEach(delegate(ExceptionalDay wd)
		{
			wd.OverridingPowerUp();
		});
	}

	public void FillWithHoliday()
	{
		weekDays.Sort(delegate(WeekDay left, WeekDay right)
		{
			if (left.DayOfWeek == right.DayOfWeek)
			{
				return 0;
			}
			return (left.DayOfWeek >= right.DayOfWeek) ? 1 : (-1);
		});
		if (weekDays.Count == dayOfWeeks.Length)
		{
			return;
		}
		DayOfWeek[] array = dayOfWeeks;
		foreach (DayOfWeek dayOfWeek in array)
		{
			int num = (int)dayOfWeek;
			WeekDay weekDay = ((weekDays.Count > num) ? weekDays[num] : null);
			if (weekDay == null || weekDay.DayOfWeek != dayOfWeek)
			{
				weekDays.Insert(num, new WeekDay(dayOfWeek, null, null));
			}
		}
	}
}
