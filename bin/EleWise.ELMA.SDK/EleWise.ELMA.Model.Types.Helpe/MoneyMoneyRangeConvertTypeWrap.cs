using System;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Ranges;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Helpers;

[Component]
public class MoneyMoneyRangeConvertTypeWrapper : IConvertTypeWrapper
{
	internal static MoneyMoneyRangeConvertTypeWrapper Ar6wtNbfnlZViEmdFX4D;

	public Type OriginalType => typeof(Money);

	public Type ConvertType => GVUo3ibfe9rpurF06PTX(typeof(MoneyRange).TypeHandle);

	public bool RelativeConvertNeeded(Type type)
	{
		return true;
	}

	public object ConvertWrapper(object obj)
	{
		int num = 3;
		int num2 = num;
		Money money = default(Money);
		MoneyRange moneyRange = default(MoneyRange);
		while (true)
		{
			switch (num2)
			{
			case 3:
				money = (Money)obj;
				num2 = 2;
				break;
			case 4:
				moneyRange.From = money;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				moneyRange = default(MoneyRange);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
				{
					num2 = 3;
				}
				break;
			case 1:
				return moneyRange;
			default:
				moneyRange.To = money;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public MoneyMoneyRangeConvertTypeWrapper()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		xgI61xbfPGwtRUeutR3v();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type GVUo3ibfe9rpurF06PTX(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool dGhnCLbfO6P9c3mJGhPl()
	{
		return Ar6wtNbfnlZViEmdFX4D == null;
	}

	internal static MoneyMoneyRangeConvertTypeWrapper uHHMTRbf2lHg5M5EqpsJ()
	{
		return Ar6wtNbfnlZViEmdFX4D;
	}

	internal static void xgI61xbfPGwtRUeutR3v()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
