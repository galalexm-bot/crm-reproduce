using System;

namespace EleWise.ELMA.KPI.Common.Code;

public static class DoubleToTimeSpan
{
	private static readonly double MinutesInDay = 1440.0;

	public static TimeSpan Convert(double? value)
	{
		return Convert(value, MinutesInDay);
	}

	public static TimeSpan Convert(double? value, double? minutesInDay)
	{
		if (!value.HasValue)
		{
			return default(TimeSpan);
		}
		minutesInDay = minutesInDay ?? MinutesInDay;
		int num = (int)(value / minutesInDay.Value).Value;
		value -= (double)num * minutesInDay.Value;
		int num2 = (int)(value / 60.0).Value;
		value -= (double)(num2 * 60);
		int num3 = (int)value.Value;
		value -= (double)num3;
		int seconds = (int)((double)(int)(value * 100.0).Value / 100.0 * 60.0);
		return new TimeSpan(num, num2, num3, seconds);
	}
}
