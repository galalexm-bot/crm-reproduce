using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Workflow.Models.ConditionTable.Operations;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Models.ConditionTable;

[Component]
internal sealed class StringOperations : ITypeOperations
{
	private static StringOperations vYP0EqOTI0eHBAvxp0A2;

	public Type Type => daGeH0OTea6P1M5PlUIf(typeof(string).TypeHandle);

	public Guid[] Operations => new Guid[3]
	{
		EqualsOperation.UID,
		ContainsOperation.UID,
		NotEqualsOperation.UID
	};

	public StringOperations()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_71a41ac2fa884d27b721ae0509586eea == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type daGeH0OTea6P1M5PlUIf(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool ybfvWvOTajuv3WIddvTF()
	{
		return vYP0EqOTI0eHBAvxp0A2 == null;
	}

	internal static StringOperations gMuk8kOTrJR4wf0VVpTp()
	{
		return vYP0EqOTI0eHBAvxp0A2;
	}
}
