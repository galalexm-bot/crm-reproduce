using System;

namespace EleWise.ELMA.Extensions;

public static class DayOfWeekExtensions
{
	internal static DayOfWeekExtensions h45kKKGauyeD8dR9mvSD;

	public static int GetWorkTimeIntervalDayOfWeek(this DayOfWeek dayOfWeek)
	{
		return aiv5YZGaSIn7B7vT35yc((int)dayOfWeek);
	}

	public static int GetWorkTimeIntervalDayOfWeek(this int dayOfWeek)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return dayOfWeek;
			case 1:
				if (dayOfWeek == 0)
				{
					return 7;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static int GetDayOfWeekNumber(this DayOfWeek current, DayOfWeek startDayOfWeek)
	{
		return (current + 7 - startDayOfWeek) % 7;
	}

	internal static int aiv5YZGaSIn7B7vT35yc(int dayOfWeek)
	{
		return dayOfWeek.GetWorkTimeIntervalDayOfWeek();
	}

	internal static bool cyfNlJGaIpc7KFxQNQy2()
	{
		return h45kKKGauyeD8dR9mvSD == null;
	}

	internal static DayOfWeekExtensions aclf2pGaVDJQDu13QAh9()
	{
		return h45kKKGauyeD8dR9mvSD;
	}
}
