using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Ranges;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Helpers;

[Component]
public class DateTimeRangeDateTimeNullConvertTypeWrapper : IConvertTypeWrapper
{
	internal static DateTimeRangeDateTimeNullConvertTypeWrapper WZvLynbfYDa81O6YhSMX;

	public Type OriginalType => QcfaECbfs3mgCUpu0txN(typeof(DateTimeRange).TypeHandle);

	public Type ConvertType => typeof(DateTime?);

	public bool RelativeConvertNeeded(Type type)
	{
		return true;
	}

	public object ConvertWrapper(object obj)
	{
		int num = 1;
		int num2 = num;
		DateTimeRange dateTimeRange = default(DateTimeRange);
		while (true)
		{
			switch (num2)
			{
			default:
				return dateTimeRange.From;
			case 1:
				dateTimeRange = (DateTimeRange)obj;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public DateTimeRangeDateTimeNullConvertTypeWrapper()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type QcfaECbfs3mgCUpu0txN(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool GHj9lLbfLII7sG8pYcwd()
	{
		return WZvLynbfYDa81O6YhSMX == null;
	}

	internal static DateTimeRangeDateTimeNullConvertTypeWrapper uqnP0AbfUxPQEhGLZaip()
	{
		return WZvLynbfYDa81O6YhSMX;
	}
}
