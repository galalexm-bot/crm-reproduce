using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Workflow.Models.ConditionTable.Operations;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Models.ConditionTable;

[Component]
internal sealed class EntityOperations : ITypeOperations
{
	internal static EntityOperations ypFYqTOT2iabsA49oMk2;

	public Type Type => oObZyPOTiXNNIePZ0OvG(typeof(IEntity).TypeHandle);

	public Guid[] Operations => new Guid[4]
	{
		SelectOperation.UID,
		EQLOperation.UID,
		GlobalVariableOperation.UID,
		FunctionOperation.UID
	};

	public EntityOperations()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1b8b735647da470aa2d45d64d6f538d1 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type oObZyPOTiXNNIePZ0OvG(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool cIlHkJOTovojT8Y6QkHE()
	{
		return ypFYqTOT2iabsA49oMk2 == null;
	}

	internal static EntityOperations rslGvLOTF1OfSVvV07g8()
	{
		return ypFYqTOT2iabsA49oMk2;
	}
}
