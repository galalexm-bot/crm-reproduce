using System;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Managers;

public class WorkflowInstanceMetricValuesManager<T> : WorkflowBaseManager<T> where T : WorkflowInstanceMetricValues
{
	private static object S4DECI9lnTCroDi0hH3;

	public WorkflowInstanceContextService WorkflowInstanceContextService
	{
		[CompilerGenerated]
		get
		{
			return _003CWorkflowInstanceContextService_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					_003CWorkflowInstanceContextService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cb262bcfe4074a1ab16e653815d57f28 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public override void Save(T obj)
	{
		Entity<long> entity = null;
		foreach (Entity<long> compositeEntity in obj.GetCompositeEntities())
		{
			if (entity == null)
			{
				entity = compositeEntity;
			}
			else if (compositeEntity.Id <= 0 && entity != null)
			{
				compositeEntity.Id = entity.Id;
			}
			GetPartialManager(compositeEntity).Save(compositeEntity);
		}
	}

	public override T LoadOrNull(long id)
	{
		Contract.ServiceNotNull(WorkflowInstanceContextService, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1895853023 ^ -1895827303));
		return (T)WorkflowInstanceContextService.LoadWorkflowInstanceMetricValues(typeof(T), id);
	}

	public WorkflowInstanceMetricValuesManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool WuK93q90wUD3dYpNtrF()
	{
		return S4DECI9lnTCroDi0hH3 == null;
	}

	internal static object xCsuWP9y0U7wwVE0leB()
	{
		return S4DECI9lnTCroDi0hH3;
	}
}
public class WorkflowInstanceMetricValuesManagerMaker : IManagerMaker
{
	internal static WorkflowInstanceMetricValuesManagerMaker oredsX9mZjDefuErjWd;

	public Type MakeManager(Type objectType)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return typeof(WorkflowInstanceMetricValuesManager<>).MakeGenericType(objectType);
			case 1:
				N8UQNo95T4LwIXX54sX(objectType, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4FD00585 ^ 0x4FD0A647));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_46e05b4e09174e34a9c81741b8b77a2f == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public WorkflowInstanceMetricValuesManagerMaker()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		DO7ORp9gHlvuvNpEtlC();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a9be7e056b4e4b6e863b634c418144f1 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void N8UQNo95T4LwIXX54sX(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static bool WZUiKO9tZNxKDIr52fu()
	{
		return oredsX9mZjDefuErjWd == null;
	}

	internal static WorkflowInstanceMetricValuesManagerMaker Cypbeq9bKO44xYBM5xo()
	{
		return oredsX9mZjDefuErjWd;
	}

	internal static void DO7ORp9gHlvuvNpEtlC()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
