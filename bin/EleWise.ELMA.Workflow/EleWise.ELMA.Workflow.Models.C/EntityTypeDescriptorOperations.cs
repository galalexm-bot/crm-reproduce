using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Models.ConditionTable;

[Component]
public abstract class EntityTypeDescriptorOperationsBase<TEntity> : ITypeOperations where TEntity : IEntity
{
	private static object E7Dw4YOTWiVkJsRHk9HR;

	public Type Type => InterfaceActivator.TypeOf<TEntity>();

	public abstract Guid[] Operations { get; }

	protected EntityTypeDescriptorOperationsBase()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ac5d16a577a84bb0b8ee3654769d2d33 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool ypxP3MOTj9mnRIQfWDeD()
	{
		return E7Dw4YOTWiVkJsRHk9HR == null;
	}

	internal static object eHKvLMOTR1D0momC90My()
	{
		return E7Dw4YOTWiVkJsRHk9HR;
	}
}
