using System;

namespace Orchard.Core.Shapes;

public static class TimespanExtensions
{
	public static int TotalWeeks(this TimeSpan time)
	{
		return (int)time.TotalDays / 7;
	}

	public static int TotalMonths(this TimeSpan time)
	{
		return (int)time.TotalDays / 31;
	}

	public static int TotalYears(this TimeSpan time)
	{
		return (int)time.TotalDays / 365;
	}
}
