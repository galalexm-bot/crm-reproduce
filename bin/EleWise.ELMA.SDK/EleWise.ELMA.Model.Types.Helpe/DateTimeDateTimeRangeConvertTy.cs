using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Ranges;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Helpers;

[Component]
public class DateTimeDateTimeRangeConvertTypeWrapper : IConvertTypeWrapper
{
	internal static DateTimeDateTimeRangeConvertTypeWrapper y5FibjbfcyQ9r41Qg6fI;

	public Type OriginalType => rZjZN7bQBFN4FJ5at3m9(typeof(DateTime).TypeHandle);

	public Type ConvertType => rZjZN7bQBFN4FJ5at3m9(typeof(DateTimeRange).TypeHandle);

	public bool RelativeConvertNeeded(Type type)
	{
		return true;
	}

	public object ConvertWrapper(object obj)
	{
		int num = 3;
		DateTimeRange dateTimeRange = default(DateTimeRange);
		DateTime value = default(DateTime);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					dateTimeRange.From = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					value = (DateTime)obj;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					dateTimeRange = default(DateTimeRange);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					return dateTimeRange;
				}
				break;
			}
			dateTimeRange.To = value;
			num = 4;
		}
	}

	public DateTimeDateTimeRangeConvertTypeWrapper()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		jNB0h2bQWRchoRG8eqp1();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type rZjZN7bQBFN4FJ5at3m9(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool Ddxrp5bfzIwsnsPVV1Sv()
	{
		return y5FibjbfcyQ9r41Qg6fI == null;
	}

	internal static DateTimeDateTimeRangeConvertTypeWrapper GPIbJJbQFUo6k4mOUilp()
	{
		return y5FibjbfcyQ9r41Qg6fI;
	}

	internal static void jNB0h2bQWRchoRG8eqp1()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
