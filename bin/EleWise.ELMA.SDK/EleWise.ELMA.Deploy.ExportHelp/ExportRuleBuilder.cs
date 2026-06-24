using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Deploy.ExportHelper;

public class ExportRuleBuilder<T>
{
	public readonly ExportRuleList ExportRules;

	private static object BivwyOEDONEYkbS4Fqyt;

	public ExportRuleBuilder(ExportRuleList exportRuleList)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				ExportRules = exportRuleList;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public ExportRuleBuilderSelectType<T> Rule()
	{
		ExportRule exportRule = new ExportRule();
		ExportRules.Add(exportRule);
		return new ExportRuleBuilderSelectType<T>(exportRule, this);
	}

	internal static bool bbt1frED2vR61ThkuBZ2()
	{
		return BivwyOEDONEYkbS4Fqyt == null;
	}

	internal static object d080gDEDeZSg9cQs0xhJ()
	{
		return BivwyOEDONEYkbS4Fqyt;
	}
}
