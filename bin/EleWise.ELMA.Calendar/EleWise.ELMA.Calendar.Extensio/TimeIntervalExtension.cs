using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Calendar.Models;

namespace EleWise.ELMA.Calendar.Extensions;

public static class TimeIntervalExtension
{
	public static IEnumerable<TimeInterval> Squash(this IEnumerable<TimeInterval> intervals, bool ignoreAggregationPriority = false)
	{
		if (intervals == null)
		{
			throw new NullReferenceException("Коллекция интервалов - \"null\"");
		}
		if (!intervals.Any())
		{
			return intervals;
		}
		if (ignoreAggregationPriority)
		{
			List<TimeInterval> list = intervals.ToList();
			list.Sort(delegate(TimeInterval left, TimeInterval right)
			{
				if (left.Start == right.Start)
				{
					return 0;
				}
				return (!(left.Start < right.Start)) ? 1 : (-1);
			});
			int minAggregationPriority = list.Min((TimeInterval i) => i.AggregationPriority);
			Stack<TimeInterval> stack = new Stack<TimeInterval>();
			stack.Push(list.First());
			return (from wt in list.Aggregate(stack, delegate(Stack<TimeInterval> aggregatedCollection, TimeInterval workingTime)
				{
					TimeInterval timeInterval = aggregatedCollection.Peek();
					if (workingTime.Start <= timeInterval.End)
					{
						TimeInterval item = new TimeInterval(timeInterval.Start, (workingTime.End > timeInterval.End) ? workingTime.End : timeInterval.End, minAggregationPriority);
						aggregatedCollection.Pop();
						aggregatedCollection.Push(item);
						return aggregatedCollection;
					}
					aggregatedCollection.Push(workingTime);
					return aggregatedCollection;
				})
				orderby wt.Start
				select wt).ToList();
		}
		List<TimeInterval> list2 = new List<TimeInterval>();
		List<IEnumerable<TimeInterval>> list3 = (from i in intervals
			group i by i.AggregationPriority into g
			orderby g.Key descending
			select g.Squash(ignoreAggregationPriority: true)).ToList();
		list2.AddRange(list3.First());
		list3.RemoveAt(0);
		return list3.Aggregate(list2, delegate(List<TimeInterval> aggregatedIntervals, IEnumerable<TimeInterval> lowPriorityIntervals)
		{
			IEnumerable<TimeInterval> highPrioriryIntervals = aggregatedIntervals.Squash(ignoreAggregationPriority: true);
			aggregatedIntervals.AddRange(GetCuttedIntervals(lowPriorityIntervals, highPrioriryIntervals));
			return aggregatedIntervals.OrderBy((TimeInterval i) => i.Start).ToList();
		});
	}

	public static IEnumerable<TimeInterval> PullBreaks(this IEnumerable<TimeInterval> workingTimeIntervals, IEnumerable<TimeInterval> breakIntervals)
	{
		if (workingTimeIntervals == null)
		{
			throw new NullReferenceException("Коллекция рабочих интервалов - \"null\"");
		}
		if (!workingTimeIntervals.Any() || breakIntervals == null || !breakIntervals.Any())
		{
			return workingTimeIntervals.OrderBy((TimeInterval wi) => wi.Start);
		}
		IEnumerable<IGrouping<int, TimeInterval>> source = from wi in workingTimeIntervals.Squash()
			group wi by wi.AggregationPriority;
		IOrderedEnumerable<IGrouping<int, TimeInterval>> orderedEnumerable = from bi in breakIntervals.Squash()
			group bi by bi.AggregationPriority into g
			orderby g.Key descending
			select g;
		int breakIntervalGroupsFirstKey = orderedEnumerable.First().Key;
		List<TimeInterval> list = source.Where((IGrouping<int, TimeInterval> g) => g.Key > breakIntervalGroupsFirstKey).SelectMany((IGrouping<int, TimeInterval> g) => g).ToList();
		List<TimeInterval> list2 = (from wi in source.Where((IGrouping<int, TimeInterval> g) => g.Key <= breakIntervalGroupsFirstKey).SelectMany((IGrouping<int, TimeInterval> g) => g)
			orderby wi.Start
			select wi).ToList();
		foreach (IGrouping<int, TimeInterval> item in orderedEnumerable)
		{
			IGrouping<int, TimeInterval> targetBreakIntervalGroup = item;
			list.AddRange((from wi in list2
				group wi by wi.AggregationPriority into g
				where g.Key > targetBreakIntervalGroup.Key
				select g).SelectMany((IGrouping<int, TimeInterval> g) => g));
			list2 = (from wi in (from wi in list2
					group wi by wi.AggregationPriority into g
					where g.Key <= targetBreakIntervalGroup.Key
					select g).SelectMany((IGrouping<int, TimeInterval> g) => g)
				orderby wi.Start
				select wi).ToList();
			if (!list2.Any())
			{
				break;
			}
			IEnumerable<TimeInterval> highPrioriryIntervals = targetBreakIntervalGroup;
			list2 = GetCuttedIntervals(list2, highPrioriryIntervals).ToList();
		}
		list.AddRange(list2);
		list.Sort(delegate(TimeInterval left, TimeInterval right)
		{
			if (left.Start == right.Start)
			{
				return 0;
			}
			return (!(left.Start < right.Start)) ? 1 : (-1);
		});
		return list;
	}

	public static TimeSpan GetDurationByPeriod(this IEnumerable<TimeInterval> workingTimeIntervals, TimeSpan startDateTime, TimeSpan endDateTime)
	{
		if (workingTimeIntervals == null)
		{
			throw new NullReferenceException(SR.T("Коллекция рабочих интервалов - \"null\""));
		}
		startDateTime = TimeSpan.FromSeconds((int)startDateTime.TotalSeconds);
		endDateTime = TimeSpan.FromSeconds((int)endDateTime.TotalSeconds);
		if (!workingTimeIntervals.Any() || startDateTime >= endDateTime)
		{
			return TimeSpan.Zero;
		}
		return (from wt in workingTimeIntervals.Squash()
			where startDateTime < wt.End && endDateTime > wt.Start
			select wt).Aggregate(TimeSpan.Zero, delegate(TimeSpan duration, TimeInterval workingTime)
		{
			TimeSpan timeSpan = ((startDateTime <= workingTime.Start) ? workingTime.Start : startDateTime);
			TimeSpan timeSpan2 = ((endDateTime >= workingTime.End) ? workingTime.End : endDateTime);
			duration += timeSpan2 - timeSpan;
			return duration;
		});
	}

	public static IEnumerable<TimeInterval> GetInvertedIntervalCollection(this IEnumerable<TimeInterval> intervals)
	{
		if (intervals == null)
		{
			throw new NullReferenceException("Коллекция интервалов - \"null\"");
		}
		if (!intervals.Any())
		{
			return new List<TimeInterval>
			{
				new TimeInterval(TimeSpan.Zero, TimeSpan.FromDays(1.0))
			};
		}
		intervals = intervals.Squash(ignoreAggregationPriority: true);
		int aggregationPriority = (intervals.Any() ? intervals.First().AggregationPriority : 0);
		List<TimeInterval> list = new List<TimeInterval>();
		TimeSpan timeSpan = TimeSpan.Zero;
		foreach (TimeInterval interval in intervals)
		{
			if (interval.Start > timeSpan)
			{
				list.Add(new TimeInterval(timeSpan, interval.Start, aggregationPriority));
			}
			timeSpan = interval.End;
		}
		if (timeSpan < TimeSpan.FromDays(1.0))
		{
			list.Add(new TimeInterval(timeSpan, TimeSpan.FromDays(1.0), aggregationPriority));
		}
		return list;
	}

	private static IEnumerable<TimeInterval> GetCuttedIntervals(IEnumerable<TimeInterval> lowPriorityIntervals, IEnumerable<TimeInterval> highPrioriryIntervals)
	{
		if (lowPriorityIntervals == null)
		{
			throw new NullReferenceException("Коллекция интервалов с низким приоритетом - \"null\"");
		}
		if (!lowPriorityIntervals.Any() || highPrioriryIntervals == null || !highPrioriryIntervals.Any())
		{
			return lowPriorityIntervals.OrderBy((TimeInterval lpi) => lpi.Start);
		}
		List<TimeInterval> list = new List<TimeInterval>();
		Stack<TimeInterval> stack = new Stack<TimeInterval>(lowPriorityIntervals.OrderByDescending((TimeInterval i) => i.Start));
		foreach (TimeInterval highPriorityInterval in highPrioriryIntervals.OrderBy((TimeInterval hpi) => hpi.Start))
		{
			while (stack.Any((TimeInterval i) => i.Start < highPriorityInterval.End))
			{
				TimeInterval item = stack.Pop();
				if (item.End <= highPriorityInterval.Start)
				{
					list.Add(item);
					continue;
				}
				if (item.Start < highPriorityInterval.Start)
				{
					list.Add(new TimeInterval(item.Start, highPriorityInterval.Start, item.AggregationPriority));
				}
				if (item.End > highPriorityInterval.End)
				{
					stack.Push(new TimeInterval(highPriorityInterval.End, item.End, item.AggregationPriority));
				}
			}
		}
		list.AddRange(stack);
		list.Sort(delegate(TimeInterval left, TimeInterval right)
		{
			if (left.Start == right.Start)
			{
				return 0;
			}
			return (!(left.Start < right.Start)) ? 1 : (-1);
		});
		return list;
	}
}
