using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Templates;
using EleWise.TemplateGenerator;
using EleWise.TemplateGenerator.Functions;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Security.Notifications;

[Component]
public class UserTemplateGeneratorFunctions : ITemplateGeneratorFunctionsContainer
{
	private static UserTemplateGeneratorFunctions A4UmNbJjtynK4I4yh8k;

	public static FormatedValue GetUserShortName(FunctionEvaluationContext context)
	{
		int num = 3;
		int num2 = num;
		EleWise.ELMA.Security.Models.IUser user = default(EleWise.ELMA.Security.Models.IUser);
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (context.Parameters.Count >= 1)
				{
					num2 = 2;
					break;
				}
				goto case 1;
			case 4:
				if (user == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a1a646659a464f3fa5c9aedc64725d72 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return new FormatedValue(UtOkQ1Jwa7M64UGGC92(user));
			case 1:
				return null;
			case 2:
				if (context.Parameters[0] != null)
				{
					user = BgcuJZJRsPHTIaDpvg5(context.Parameters[0]) as EleWise.ELMA.Security.Models.IUser;
					num2 = 4;
					break;
				}
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_147eeadb328044dda63bf8b1037653db == 0)
				{
					num2 = 1;
				}
				break;
			default:
				return null;
			}
		}
	}

	public UserTemplateGeneratorFunctions()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		jIi3rEJ21yR36oGASqu();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5ae6a44bd52345c5bcadd62b7063c7d9 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object BgcuJZJRsPHTIaDpvg5(object P_0)
	{
		return ((FormatedValue)P_0).Value;
	}

	internal static object UtOkQ1Jwa7M64UGGC92(object P_0)
	{
		return ((EleWise.ELMA.Security.Models.IUser)P_0).GetShortName();
	}

	internal static bool XT7jTfJHF1E7oNHq8EB()
	{
		return A4UmNbJjtynK4I4yh8k == null;
	}

	internal static UserTemplateGeneratorFunctions P5yQBwJaswVPZyKyCGj()
	{
		return A4UmNbJjtynK4I4yh8k;
	}

	internal static void jIi3rEJ21yR36oGASqu()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}
}
