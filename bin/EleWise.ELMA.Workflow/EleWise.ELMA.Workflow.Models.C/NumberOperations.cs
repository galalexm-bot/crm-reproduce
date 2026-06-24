using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Workflow.Models.ConditionTable.Operations;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Models.ConditionTable;

[Component]
internal class NumberOperations : ITypeOperations
{
	internal static NumberOperations sHxOpBOTUD4Y4ZubJkOa;

	public Type Type => cORiDcOTGCbdn75rTg2F(typeof(long).TypeHandle);

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

	public NumberOperations()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		siY7bjOT7jl4h793YZit();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bb19f93c0a774f6cbdada859bba83212 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type cORiDcOTGCbdn75rTg2F(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool LCnJlaOTVS1s2SQOPwPD()
	{
		return sHxOpBOTUD4Y4ZubJkOa == null;
	}

	internal static NumberOperations AY9oshOTAlNuVAqNYDtf()
	{
		return sHxOpBOTUD4Y4ZubJkOa;
	}

	internal static void siY7bjOT7jl4h793YZit()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
