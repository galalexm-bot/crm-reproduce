using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Calendar.Extensions;

namespace EleWise.ELMA.Calendar.Models;

public class WeekDay
{
	private IEnumerable<TimeInterval> realWorkingTimeIntervals;

	private List<TimeInterval> originalWorkingTimeIntervals;

	private List<TimeInterval> breakIntervals;

	public DayOfWeek DayOfWeek { get; private set; }

	public IEnumerable<TimeInterval> WorkingTimeIntervals
	{
		get
		{
			if (realWorkingTimeIntervals == null)
			{
				return realWorkingTimeIntervals = originalWorkingTimeIntervals.PullBreaks(breakIntervals);
			}
			return realWorkingTimeIntervals;
		}
	}

	public bool IsHoliday => !WorkingTimeIntervals.Any();

	public TimeSpan Duration => TimeSpan.FromTicks(WorkingTimeIntervals.Sum((TimeInterval wt) => wt.Duration.Ticks));

	public WeekDay(DayOfWeek dayOfWeek, IEnumerable<TimeInterval> workingTimeIntervals, IEnumerable<TimeInterval> breakIntervals)
	{
		DayOfWeek = dayOfWeek;
		originalWorkingTimeIntervals = ((workingTimeIntervals != null) ? workingTimeIntervals.Squash().ToList() : new List<TimeInterval>());
		this.breakIntervals = ((breakIntervals != null) ? breakIntervals.Squash().ToList() : new List<TimeInterval>());
	}

	public WeekDay Merge(WeekDay weekDay)
	{
		if (weekDay != null && weekDay.DayOfWeek == DayOfWeek)
		{
			originalWorkingTimeIntervals.AddRange(weekDay.originalWorkingTimeIntervals);
			originalWorkingTimeIntervals = originalWorkingTimeIntervals.Squash().ToList();
			breakIntervals.AddRange(weekDay.breakIntervals);
			breakIntervals = breakIntervals.Squash().ToList();
			realWorkingTimeIntervals = null;
		}
		return this;
	}

	public void OverridingPowerUp()
	{
		breakIntervals.AddRange(WorkingTimeIntervals.GetInvertedIntervalCollection());
		breakIntervals = breakIntervals.Squash().ToList();
	}
}
