using System;

namespace EleWise.ELMA.Calendar.Models;

public struct TimeInterval
{
	private readonly TimeSpan start;

	private readonly TimeSpan end;

	private readonly int aggregationPriority;

	public TimeSpan Start => start;

	public TimeSpan End => end;

	public int AggregationPriority => aggregationPriority;

	public TimeSpan Duration => End - Start;

	public TimeInterval(TimeSpan start, TimeSpan end, int aggregationPriority = 0)
		: this(start, end, checkTimeStartEnd: true, aggregationPriority)
	{
	}

	public TimeInterval(TimeSpan start, TimeSpan end, bool checkTimeStartEnd, int aggregationPriority = 0)
	{
		start = TimeSpan.FromSeconds((int)start.TotalSeconds);
		end = TimeSpan.FromSeconds((int)end.TotalSeconds);
		if (checkTimeStartEnd && (start >= end || start < TimeSpan.Zero || start >= TimeSpan.FromDays(1.0) || end <= TimeSpan.Zero || end > TimeSpan.FromDays(1.0)))
		{
			throw new ArgumentException(SR.T("Некорректно заданы параметры интервала: начальная точка интервала - {0}, конечная точка интервала - {1})", start, end));
		}
		if (aggregationPriority < 0)
		{
			throw new ArgumentOutOfRangeException(SR.T("Приоритет агрегации должен имееть значение большое либо равным 0"));
		}
		this.start = start;
		this.end = end;
		this.aggregationPriority = aggregationPriority;
	}

	public override string ToString()
	{
		return SR.T("C {0} до {1}", Start.ToString("hh\\:mm\\:ss"), End.ToString("hh\\:mm\\:ss"));
	}

	public bool Equals(TimeInterval other)
	{
		return start.Equals(other.start) && end.Equals(other.end);
	}

	public override bool Equals(object obj)
	{
		if (obj == null)
		{
			return false;
		}
		return obj is TimeInterval && Equals((TimeInterval)obj);
	}

	public override int GetHashCode()
	{
		TimeSpan timeSpan = start;
		int num = timeSpan.GetHashCode() * 397;
		timeSpan = end;
		return num ^ timeSpan.GetHashCode();
	}
}
