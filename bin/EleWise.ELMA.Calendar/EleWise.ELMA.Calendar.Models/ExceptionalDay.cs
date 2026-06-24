using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Calendar.Extensions;

namespace EleWise.ELMA.Calendar.Models;

public class ExceptionalDay
{
	private IEnumerable<TimeInterval> realWorkingTimeIntervals;

	internal List<TimeInterval> originalWorkingTimeIntervals;

	internal List<TimeInterval> breakIntervals;

	public DateTime Date { get; private set; }

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

	public TimeSpan Duration => new TimeSpan(WorkingTimeIntervals.Sum((TimeInterval wt) => wt.Duration.Ticks));

	public ExceptionalDay(DateTime date, IEnumerable<TimeInterval> workingTimeIntervals, IEnumerable<TimeInterval> breakIntervals)
	{
		if (date.TimeOfDay != TimeSpan.Zero)
		{
			throw new ArgumentException(SR.T("Некорректно задана дата исключительного дня при создании данных производственного календаря"));
		}
		Date = date;
		originalWorkingTimeIntervals = ((workingTimeIntervals != null) ? workingTimeIntervals.Squash().ToList() : new List<TimeInterval>());
		this.breakIntervals = ((breakIntervals != null) ? breakIntervals.Squash().ToList() : new List<TimeInterval>());
	}

	public ExceptionalDay Merge(ExceptionalDay exceptionalDay)
	{
		if (exceptionalDay != null && exceptionalDay.Date == Date)
		{
			originalWorkingTimeIntervals.AddRange(exceptionalDay.originalWorkingTimeIntervals);
			originalWorkingTimeIntervals = originalWorkingTimeIntervals.Squash().ToList();
			breakIntervals.AddRange(exceptionalDay.breakIntervals);
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
