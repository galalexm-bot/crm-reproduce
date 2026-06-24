using System;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Workflow.Models.ConditionTable.Operations;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Models.ConditionTable;

[Component]
internal sealed class MoneyOperations : ITypeOperations
{
	private static MoneyOperations GsU0aIOTPgroWAie9LCO;

	public Type Type => F406wwOTuQbLcWqFgZCG(typeof(Money).TypeHandle);

	public Guid[] Operations => new Guid[7]
	{
		LessOperation.UID,
		MoreOperation.UID,
		RangeOperation.UID,
		EqualsOperation.UID,
		NotEqualsOperation.UID,
		MoreOrEqualsOperation.UID,
		LessOrEqualsOperation.UID
	};

	public MoneyOperations()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		QNB2HcOTDlVMdDevwdg0();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_46e05b4e09174e34a9c81741b8b77a2f == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type F406wwOTuQbLcWqFgZCG(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool HLHSHwOTXxLq8c2j9ysH()
	{
		return GsU0aIOTPgroWAie9LCO == null;
	}

	internal static MoneyOperations SaVrt1OTdrVrahND1CEg()
	{
		return GsU0aIOTPgroWAie9LCO;
	}

	internal static void QNB2HcOTDlVMdDevwdg0()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
