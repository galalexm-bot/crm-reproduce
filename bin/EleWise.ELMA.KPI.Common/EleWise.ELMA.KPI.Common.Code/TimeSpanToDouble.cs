using System;

namespace EleWise.ELMA.KPI.Common.Code;

public static class TimeSpanToDouble
{
	public static double? Convert(TimeSpan value)
	{
		return Convert(value, null);
	}

	public static double? Convert(TimeSpan value, double? minutesInDay)
	{
		return (double)value.Days * (minutesInDay ?? 1440.0) + (double)(value.Hours * 60) + (double)value.Minutes + Math.Round((double)value.Seconds / 60.0, 2);
	}
}
