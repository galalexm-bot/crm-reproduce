using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Ranges;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Helpers;

[Component]
public class DoubleNullDoubleRangeConvertTypeWrapper : IConvertTypeWrapper
{
	private static DoubleNullDoubleRangeConvertTypeWrapper IGqwICbGTZCbnSsLB2iN;

	public Type OriginalType => typeof(double?);

	public Type ConvertType => gGrSqabGOh06oyV89Wg7(typeof(DoubleRange).TypeHandle);

	public bool RelativeConvertNeeded(Type type)
	{
		return true;
	}

	public object ConvertWrapper(object obj)
	{
		int num = 1;
		double? num3 = default(double?);
		DoubleRange doubleRange = default(DoubleRange);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					num3 = (double?)obj;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
					{
						num2 = 0;
					}
					continue;
				default:
					doubleRange = default(DoubleRange);
					num2 = 3;
					continue;
				case 3:
					break;
				case 2:
					return doubleRange;
				case 4:
					doubleRange.To = num3;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
					{
						num2 = 2;
					}
					continue;
				}
				break;
			}
			doubleRange.From = num3;
			num = 4;
		}
	}

	public DoubleNullDoubleRangeConvertTypeWrapper()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		xXQlgwbG2EZhRJNkg3Wa();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type gGrSqabGOh06oyV89Wg7(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool BncYX9bGkdERS7TeGlFc()
	{
		return IGqwICbGTZCbnSsLB2iN == null;
	}

	internal static DoubleNullDoubleRangeConvertTypeWrapper k5coRcbGnIVI4nCgev7a()
	{
		return IGqwICbGTZCbnSsLB2iN;
	}

	internal static void xXQlgwbG2EZhRJNkg3Wa()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
