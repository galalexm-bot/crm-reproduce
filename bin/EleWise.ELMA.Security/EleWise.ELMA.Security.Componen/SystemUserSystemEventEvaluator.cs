using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Security.Components;

[Component]
internal class SystemUserSystemEventEvaluator : IHistoryModelEvaluator
{
	internal static SystemUserSystemEventEvaluator mtZRyvzdHJtAMaEu8T5;

	public void Evaluate(IHistoryBaseModel historyModel)
	{
		//Discarded unreachable code: IL_0096, IL_00a5
		int num = 4;
		int num2 = num;
		EleWise.ELMA.Security.Models.IUser user = default(EleWise.ELMA.Security.Models.IUser);
		while (true)
		{
			switch (num2)
			{
			default:
				qpUCdKz8g6Rlxx5y3x8(historyModel, user);
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e2be4970ad4d405ab7ed74c6b68c9f7d != 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				if (historyModel.ActionAuthor != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f4f2657bf7454f44b4829aa89c711f0d != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			case 4:
				if (!(historyModel is SystemHistoryModel))
				{
					num2 = 3;
					break;
				}
				user = UserManager.Instance.Load(SecurityConstants.SystemUserUid);
				num2 = 5;
				break;
			case 1:
				return;
			case 2:
				return;
			case 3:
				return;
			}
		}
	}

	public SystemUserSystemEventEvaluator()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		zB9YnTzrky8TGaWxWfY();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b496c4412b534db6beb066c8296e663d != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void qpUCdKz8g6Rlxx5y3x8(object P_0, object P_1)
	{
		((IHistoryBaseModel)P_0).ActionAuthor = (IUser)P_1;
	}

	internal static bool MW1bQ2zTtlDKf0XTYiw()
	{
		return mtZRyvzdHJtAMaEu8T5 == null;
	}

	internal static SystemUserSystemEventEvaluator yMGCRMzg0BoY9K5C4RC()
	{
		return mtZRyvzdHJtAMaEu8T5;
	}

	internal static void zB9YnTzrky8TGaWxWfY()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}
}
