using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Workflow.Models.ConditionTable.Operations;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Models.ConditionTable;

[Component]
internal sealed class DoubleOperations : ITypeOperations
{
	internal static DoubleOperations s7EyGIOTnjuc1hK5vNwt;

	public Type Type => MQJqDSOTfoMX3TYc29pm(typeof(double).TypeHandle);

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

	public DoubleOperations()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		UMddZ4OT9a169W7G6T94();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type MQJqDSOTfoMX3TYc29pm(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool sG3pRdOTHM8P0FjPE8K0()
	{
		return s7EyGIOTnjuc1hK5vNwt == null;
	}

	internal static DoubleOperations vlwwfiOTLOtk9GM4rQLZ()
	{
		return s7EyGIOTnjuc1hK5vNwt;
	}

	internal static void UMddZ4OT9a169W7G6T94()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
