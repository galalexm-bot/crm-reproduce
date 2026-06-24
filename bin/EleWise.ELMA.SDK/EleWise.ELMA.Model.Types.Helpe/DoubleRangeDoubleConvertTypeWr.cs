using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Ranges;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Helpers;

[Component]
public class DoubleRangeDoubleConvertTypeWrapper : IConvertTypeWrapper
{
	internal static DoubleRangeDoubleConvertTypeWrapper c3BJdXbGQkCEffLgLhtt;

	public Type OriginalType => gMmiIMbG8qUJGOKvdc90(typeof(DoubleRange).TypeHandle);

	public Type ConvertType => gMmiIMbG8qUJGOKvdc90(typeof(double).TypeHandle);

	public bool RelativeConvertNeeded(Type type)
	{
		return true;
	}

	public object ConvertWrapper(object obj)
	{
		//Discarded unreachable code: IL_003f
		int num = 2;
		int num2 = num;
		double? num3;
		double? from = default(double?);
		DoubleRange doubleRange = default(DoubleRange);
		while (true)
		{
			switch (num2)
			{
			case 3:
				num3 = 0.0;
				break;
			case 1:
				from = doubleRange.From;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				doubleRange = (DoubleRange)obj;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
				{
					num2 = 1;
				}
				continue;
			default:
				if (!from.HasValue)
				{
					num2 = 3;
					continue;
				}
				num3 = doubleRange.From;
				break;
			}
			break;
		}
		return num3;
	}

	public DoubleRangeDoubleConvertTypeWrapper()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		RD0fKNbGZbCxSerFuh4q();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type gMmiIMbG8qUJGOKvdc90(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool jfck3BbGC1eWDx63L6W3()
	{
		return c3BJdXbGQkCEffLgLhtt == null;
	}

	internal static DoubleRangeDoubleConvertTypeWrapper hP1ZFUbGvUq7QQoFcyyg()
	{
		return c3BJdXbGQkCEffLgLhtt;
	}

	internal static void RD0fKNbGZbCxSerFuh4q()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
