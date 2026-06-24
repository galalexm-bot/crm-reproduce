using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Ranges;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Helpers;

[Component]
public class LongRangeDoubleRangeConvertTypeWrapper : IConvertTypeWrapper
{
	private static LongRangeDoubleRangeConvertTypeWrapper M8uLNybGsgrRJTPtNBmF;

	public Type OriginalType => k8sZSybEFeaMu0JRMUYq(typeof(Int64Range).TypeHandle);

	public Type ConvertType => k8sZSybEFeaMu0JRMUYq(typeof(DoubleRange).TypeHandle);

	public bool RelativeConvertNeeded(Type type)
	{
		return true;
	}

	public object ConvertWrapper(object obj)
	{
		int num = 3;
		int num2 = num;
		DoubleRange doubleRange = default(DoubleRange);
		Int64Range int64Range = default(Int64Range);
		while (true)
		{
			switch (num2)
			{
			case 2:
				doubleRange = default(DoubleRange);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				int64Range = (Int64Range)obj;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				return doubleRange;
			default:
				doubleRange.From = int64Range.From;
				num2 = 4;
				break;
			case 4:
				doubleRange.To = int64Range.To;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public LongRangeDoubleRangeConvertTypeWrapper()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		bAWYqYbEBdawBm9MaFIh();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type k8sZSybEFeaMu0JRMUYq(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool q5STThbGctCiZgliPfnr()
	{
		return M8uLNybGsgrRJTPtNBmF == null;
	}

	internal static LongRangeDoubleRangeConvertTypeWrapper P4RMNgbGzPdfo83OWPPQ()
	{
		return M8uLNybGsgrRJTPtNBmF;
	}

	internal static void bAWYqYbEBdawBm9MaFIh()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
