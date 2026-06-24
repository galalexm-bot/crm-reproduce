using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Ranges;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Helpers;

[Component]
public class DateTimeRangeDateTimeConvertTypeWrapper : IConvertTypeWrapper
{
	internal static DateTimeRangeDateTimeConvertTypeWrapper bbbbsabfldnYj14bHAvN;

	public Type OriginalType => CRl9qMbf5lh0XNb4KnDy(typeof(DateTimeRange).TypeHandle);

	public Type ConvertType => CRl9qMbf5lh0XNb4KnDy(typeof(DateTime).TypeHandle);

	public bool RelativeConvertNeeded(Type type)
	{
		return true;
	}

	public object ConvertWrapper(object obj)
	{
		//Discarded unreachable code: IL_003b
		int num = 1;
		int num2 = num;
		DateTime? dateTime;
		DateTimeRange dateTimeRange = default(DateTimeRange);
		DateTime? from = default(DateTime?);
		while (true)
		{
			switch (num2)
			{
			case 3:
				dateTime = DateTime.MinValue;
				break;
			case 1:
				dateTimeRange = (DateTimeRange)obj;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				if (!from.HasValue)
				{
					num2 = 3;
					continue;
				}
				dateTime = dateTimeRange.From;
				break;
			default:
				from = dateTimeRange.From;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
				{
					num2 = 2;
				}
				continue;
			}
			break;
		}
		return dateTime;
	}

	public DateTimeRangeDateTimeConvertTypeWrapper()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		BCDTEvbfjHbNIvsY4rhr();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type CRl9qMbf5lh0XNb4KnDy(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool iKNxSlbfr5jlwIRhJkCH()
	{
		return bbbbsabfldnYj14bHAvN == null;
	}

	internal static DateTimeRangeDateTimeConvertTypeWrapper RYtEq0bfgDLxH8ZqmUc9()
	{
		return bbbbsabfldnYj14bHAvN;
	}

	internal static void BCDTEvbfjHbNIvsY4rhr()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
