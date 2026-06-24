using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Calendar.Services;

[Service(InjectProperties = false, EnableInterceptors = false)]
internal sealed class TimeSlotsCalculationService : ITimeSlotsCalculationService
{
	private enum IntervalEntrance
	{
		Left,
		Right,
		Center,
		Full,
		None,
		NotSet
	}

	public IList<TimeSlot> NormalizeIntervals(IList<TimeSlot> timeSlots)
	{
		if (!timeSlots.Any())
		{
			return timeSlots.ToList();
		}
		List<TimeSlot> list = (from m in timeSlots
			orderby m.StartDate, m.EndDate
			select m).ToList();
		for (int i = 0; i + 1 < list.Count; i++)
		{
			if (list[i + 1].StartDate <= list[i].EndDate)
			{
				list[i] = new TimeSlot(list[i].StartDate, list[i + 1].EndDate);
				list.RemoveAt(i + 1);
			}
		}
		return list;
	}

	public IEnumerable<TimeSlot> Subtraction(IEnumerable<TimeSlot> timeSlots, IEnumerable<TimeSlot> timesSearched)
	{
		List<TimeSlot> list = new List<TimeSlot>(timeSlots);
		List<TimeSlot> list2 = new List<TimeSlot>();
		foreach (TimeSlot item in timesSearched)
		{
			(IntervalEntrance, int) tuple = (IntervalEntrance.NotSet, -1);
			while (tuple.Item1 != IntervalEntrance.None)
			{
				tuple = BinarySearch(list, item);
				if (tuple.Item1 == IntervalEntrance.None)
				{
					break;
				}
				TimeSlot timeSlot = list[tuple.Item2];
				TimeSlot resultSlot;
				if (tuple.Item1 == IntervalEntrance.Center)
				{
					if (item.EndDate != timeSlot.EndDate && TryCreateRightInterval(item, timeSlot, out resultSlot))
					{
						list2.Add(resultSlot);
					}
					if (item.StartDate != timeSlot.StartDate && TryCreateLeftInterval(item, timeSlot, out resultSlot))
					{
						list2.Add(resultSlot);
					}
				}
				else if (tuple.Item1 == IntervalEntrance.Right)
				{
					if (TryCreateRightInterval(item, timeSlot, out resultSlot))
					{
						list2.Add(resultSlot);
					}
				}
				else if (tuple.Item1 == IntervalEntrance.Left && TryCreateLeftInterval(item, timeSlot, out resultSlot))
				{
					list2.Add(resultSlot);
				}
				list.RemoveAt(tuple.Item2);
				foreach (TimeSlot item2 in list2)
				{
					list.Insert(tuple.Item2, item2);
				}
				list2.Clear();
			}
		}
		return list;
	}

	public IList<TimeSlot> Intersection(IList<TimeSlot> timeSlots, TimeSlot timeSearched)
	{
		(IntervalEntrance, int) tuple = (IntervalEntrance.NotSet, -1);
		List<TimeSlot> list = new List<TimeSlot>(timeSlots);
		HashSet<TimeSlot> hashSet = new HashSet<TimeSlot>();
		while (tuple.Item1 != IntervalEntrance.None)
		{
			tuple = BinarySearch(list, timeSearched);
			if (tuple.Item1 == IntervalEntrance.Center)
			{
				return new List<TimeSlot> { timeSearched };
			}
			if (tuple.Item1 == IntervalEntrance.Left)
			{
				if (TryCreateCenterInterval(timeSearched, list[tuple.Item2], out var resultSlot))
				{
					hashSet.Add(resultSlot);
				}
				list.RemoveAt(tuple.Item2);
			}
			else if (tuple.Item1 == IntervalEntrance.Full)
			{
				hashSet.Add(list[tuple.Item2]);
				list.RemoveAt(tuple.Item2);
			}
			else if (tuple.Item1 == IntervalEntrance.Right)
			{
				if (TryCreateCenterInterval(list[tuple.Item2], timeSearched, out var resultSlot2))
				{
					hashSet.Add(resultSlot2);
				}
				list.RemoveAt(tuple.Item2);
			}
		}
		return hashSet.OrderBy((TimeSlot interval) => interval.StartDate).ToList();
	}

	private (IntervalEntrance entrance, int index) BinarySearch(IList<TimeSlot> timeSlots, TimeSlot timeSearched)
	{
		TimeSlot[] array = timeSlots.OrderBy((TimeSlot x) => x.StartDate).ToArray();
		int num = 0;
		int num2 = array.Length - 1;
		while (num <= num2)
		{
			int num3 = num2 + num >> 1;
			IntervalEntrance intervalEntrance = CheckEntrance(array[num3], timeSearched);
			if (intervalEntrance != IntervalEntrance.None)
			{
				return (intervalEntrance, num3);
			}
			if (array[num3].StartDate < timeSearched.StartDate)
			{
				num = num3 + 1;
			}
			else
			{
				num2 = num3 - 1;
			}
		}
		return (IntervalEntrance.None, -1);
	}

	private IntervalEntrance CheckEntrance(TimeSlot timeSlot, TimeSlot timeSearched)
	{
		if (IsTimeSlotCoveredByTimeSlot(timeSearched, timeSlot))
		{
			return IntervalEntrance.Full;
		}
		if (IsTimeSlotCoveredByTimeSlot(timeSlot, timeSearched))
		{
			return IntervalEntrance.Center;
		}
		if (IsDateInTimeSlot(timeSearched.StartDate, timeSlot))
		{
			return IntervalEntrance.Left;
		}
		if (IsDateInTimeSlot(timeSearched.EndDate, timeSlot))
		{
			return IntervalEntrance.Right;
		}
		return IntervalEntrance.None;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private bool IsTimeSlotCoveredByTimeSlot(TimeSlot interval, TimeSlot coveredTimeSlot)
	{
		return interval.StartDate <= coveredTimeSlot.StartDate && interval.EndDate >= coveredTimeSlot.EndDate;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private bool IsDateInTimeSlot(DateTime date, TimeSlot timeSlot)
	{
		return date > timeSlot.StartDate && date < timeSlot.EndDate;
	}

	private bool TryCreateLeftInterval(TimeSlot timeSlot, TimeSlot availableTime, out TimeSlot resultSlot)
	{
		resultSlot = null;
		if (availableTime.StartDate >= timeSlot.StartDate)
		{
			return false;
		}
		resultSlot = new TimeSlot(availableTime.StartDate, timeSlot.StartDate);
		return true;
	}

	private bool TryCreateRightInterval(TimeSlot timeSlot, TimeSlot availableTime, out TimeSlot resultSlot)
	{
		resultSlot = null;
		if (timeSlot.EndDate >= availableTime.EndDate)
		{
			return false;
		}
		resultSlot = new TimeSlot(timeSlot.EndDate, availableTime.EndDate);
		return true;
	}

	private bool TryCreateCenterInterval(TimeSlot timeSlotWithStart, TimeSlot timeSlotWithEnd, out TimeSlot resultSlot)
	{
		resultSlot = null;
		if (timeSlotWithStart.StartDate >= timeSlotWithEnd.EndDate)
		{
			return false;
		}
		resultSlot = new TimeSlot(timeSlotWithStart.StartDate, timeSlotWithEnd.EndDate);
		return true;
	}
}
