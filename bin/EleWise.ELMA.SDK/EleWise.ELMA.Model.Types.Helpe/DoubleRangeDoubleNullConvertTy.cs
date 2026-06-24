using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Ranges;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Helpers;

[Component]
public class DoubleRangeDoubleNullConvertTypeWrapper : IConvertTypeWrapper
{
	internal static DoubleRangeDoubleNullConvertTypeWrapper LkWUJibGusCReCMiGWLB;

	public Type OriginalType => zeJb7pbGSRHJSvAWfu2D(typeof(DoubleRange).TypeHandle);

	public Type ConvertType => zeJb7pbGSRHJSvAWfu2D(typeof(double?).TypeHandle);

	public bool RelativeConvertNeeded(Type type)
	{
		return true;
	}

	public object ConvertWrapper(object obj)
	{
		int num = 1;
		int num2 = num;
		DoubleRange doubleRange = default(DoubleRange);
		while (true)
		{
			switch (num2)
			{
			case 1:
				doubleRange = (DoubleRange)obj;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return doubleRange.From;
			}
		}
	}

	public DoubleRangeDoubleNullConvertTypeWrapper()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type zeJb7pbGSRHJSvAWfu2D(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool ciYS09bGIsjRej5nCG3o()
	{
		return LkWUJibGusCReCMiGWLB == null;
	}

	internal static DoubleRangeDoubleNullConvertTypeWrapper zyrZpYbGVZLQxIJFimn9()
	{
		return LkWUJibGusCReCMiGWLB;
	}
}
