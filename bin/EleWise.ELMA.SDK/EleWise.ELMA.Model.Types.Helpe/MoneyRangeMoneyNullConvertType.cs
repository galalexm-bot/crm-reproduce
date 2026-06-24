using System;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Ranges;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Helpers;

[Component]
public class MoneyRangeMoneyNullConvertTypeWrapper : IConvertTypeWrapper
{
	internal static MoneyRangeMoneyNullConvertTypeWrapper W3LfkJbfqIJlRZBPqaZu;

	public Type OriginalType => kAJ9xRbfTfH8MfnHtGvh(typeof(MoneyRange).TypeHandle);

	public Type ConvertType => kAJ9xRbfTfH8MfnHtGvh(typeof(Money?).TypeHandle);

	public bool RelativeConvertNeeded(Type type)
	{
		return true;
	}

	public object ConvertWrapper(object obj)
	{
		int num = 1;
		int num2 = num;
		MoneyRange moneyRange = default(MoneyRange);
		while (true)
		{
			switch (num2)
			{
			case 1:
				moneyRange = (MoneyRange)obj;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return moneyRange.From;
			}
		}
	}

	public MoneyRangeMoneyNullConvertTypeWrapper()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		pUafitbfk6lvPI1ESS1X();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type kAJ9xRbfTfH8MfnHtGvh(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool vSCc0sbfKBG3HVePbkXF()
	{
		return W3LfkJbfqIJlRZBPqaZu == null;
	}

	internal static MoneyRangeMoneyNullConvertTypeWrapper BmMllgbfX8jILaAtUt0R()
	{
		return W3LfkJbfqIJlRZBPqaZu;
	}

	internal static void pUafitbfk6lvPI1ESS1X()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
