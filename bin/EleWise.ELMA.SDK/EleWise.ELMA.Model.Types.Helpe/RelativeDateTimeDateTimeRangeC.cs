using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Ranges;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Helpers;

[Component(Order = 3000)]
public class RelativeDateTimeDateTimeRangeConverter : IConvertTypeWrapper
{
	internal static RelativeDateTimeDateTimeRangeConverter X5IwPbbhNh0OnEATqgNC;

	public Type OriginalType => bt0O7wbhaKZEia2ytLcC(typeof(RelativeDateTime).TypeHandle);

	public Type ConvertType => bt0O7wbhaKZEia2ytLcC(typeof(DateTimeRange).TypeHandle);

	public bool RelativeConvertNeeded(Type type)
	{
		return true;
	}

	public object ConvertWrapper(object obj)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return kiMOwNbhDvKLlfAIrRos((RelativeDateTime)obj);
			case 1:
				if (!RelativeConvertNeeded(obj.GetType()))
				{
					return obj;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public RelativeDateTimeDateTimeRangeConverter()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		uZm0CUbhtLhbXjZ506Bj();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type bt0O7wbhaKZEia2ytLcC(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static DateTimeRange kiMOwNbhDvKLlfAIrRos(object P_0)
	{
		return ((RelativeDateTime)P_0).DateTimeRange;
	}

	internal static bool iLQ6Dhbh38kYsKKdowT3()
	{
		return X5IwPbbhNh0OnEATqgNC == null;
	}

	internal static RelativeDateTimeDateTimeRangeConverter jCsSEebhpudrfd2bPSX9()
	{
		return X5IwPbbhNh0OnEATqgNC;
	}

	internal static void uZm0CUbhtLhbXjZ506Bj()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
