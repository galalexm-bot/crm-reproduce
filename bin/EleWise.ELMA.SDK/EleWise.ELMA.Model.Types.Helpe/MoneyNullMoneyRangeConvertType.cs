using System;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Ranges;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Helpers;

[Component]
public class MoneyNullMoneyRangeConvertTypeWrapper : IConvertTypeWrapper
{
	private static MoneyNullMoneyRangeConvertTypeWrapper Lhc1T9bf12qfcn71vc1U;

	public Type OriginalType => typeof(Money?);

	public Type ConvertType => CneHIJbfpCq6bbeGjlNo(typeof(MoneyRange).TypeHandle);

	public bool RelativeConvertNeeded(Type type)
	{
		return true;
	}

	public object ConvertWrapper(object obj)
	{
		//Discarded unreachable code: IL_00a9
		int num = 4;
		int num2 = num;
		MoneyRange moneyRange = default(MoneyRange);
		Money money4 = default(Money);
		Money? money2 = default(Money?);
		Money money = default(Money);
		while (true)
		{
			Money money3;
			switch (num2)
			{
			case 2:
				return moneyRange;
			default:
				moneyRange.From = money4;
				num2 = 6;
				continue;
			case 6:
				moneyRange.To = money4;
				num2 = 2;
				continue;
			case 4:
				money2 = (Money?)obj;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
				{
					num2 = 2;
				}
				continue;
			case 3:
				if (!money2.HasValue)
				{
					num2 = 5;
					continue;
				}
				money3 = money2.Value;
				break;
			case 7:
				money3 = money;
				break;
			case 1:
				moneyRange = default(MoneyRange);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
				{
					num2 = 0;
				}
				continue;
			case 5:
				money = default(Money);
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			money4 = money3;
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
			{
				num2 = 1;
			}
		}
	}

	public MoneyNullMoneyRangeConvertTypeWrapper()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type CneHIJbfpCq6bbeGjlNo(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool SLUSvJbfNyyCQYH2nBrj()
	{
		return Lhc1T9bf12qfcn71vc1U == null;
	}

	internal static MoneyNullMoneyRangeConvertTypeWrapper NAkJvPbf3OYPQwOV8rcV()
	{
		return Lhc1T9bf12qfcn71vc1U;
	}
}
