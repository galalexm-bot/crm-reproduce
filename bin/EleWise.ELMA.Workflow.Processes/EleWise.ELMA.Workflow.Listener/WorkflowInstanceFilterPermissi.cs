using System;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Filters;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Helpers;
using EleWise.ELMA.Runtime.NH.Listeners;
using EleWise.ELMA.Security;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Security;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Event;

namespace EleWise.ELMA.Workflow.Listeners;

[Component]
public class WorkflowInstanceFilterPermissionIdListener : PostFlushEventListener
{
	internal static WorkflowInstanceFilterPermissionIdListener qPCqDjaJidcqe8ZjObY;

	public override void OnPostInsert(PostInsertEvent @event)
	{
		//Discarded unreachable code: IL_008e
		int num = 8;
		int num2 = num;
		IFilter filter = default(IFilter);
		IEntityFilter entityFilter = default(IEntityFilter);
		Guid? code = default(Guid?);
		while (true)
		{
			switch (num2)
			{
			case 7:
				if (filter != null)
				{
					num2 = 2;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_c5274b5f82c74d1e8e92ea099532df1e == 0)
					{
						num2 = 1;
					}
					break;
				}
				return;
			case 4:
				return;
			case 11:
				return;
			default:
				entityFilter = UniversalFilterSaver.UnPack(bX9ge1agnsD1VoJNy4L(filter));
				num2 = 6;
				break;
			case 8:
				filter = yLMRx4a5PmD7FCCSt7a(@event) as IFilter;
				num2 = 7;
				break;
			case 3:
				if (bX9ge1agnsD1VoJNy4L(filter) == null)
				{
					return;
				}
				num2 = 9;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_9da417d3072c4857ad8a08ca0cf38980 == 0)
				{
					num2 = 10;
				}
				break;
			case 10:
				code = filter.Code;
				num2 = 5;
				break;
			case 5:
				if (!code.HasValue)
				{
					num2 = 4;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_de54abced8a94396b6a2752618533f57 == 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 9;
			case 9:
				if (!iVeyDfaZxAdsUNTv2mF(G4v15TaIIgmafIVgeKp(rCSBE2a1QOBoUOq45SK(filter)), InterfaceActivator.UID<IWorkflowInstance>()))
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_9da417d3072c4857ad8a08ca0cf38980 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				pSej4XYCs5W6LtOmXxg(filter, HNqnn0YEOOwWYY5bfWh(entityFilter, null));
				num2 = 11;
				break;
			case 2:
				if (filter.ObjectsType == null)
				{
					return;
				}
				num2 = 3;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_820de5fd03a94336b27530b7b54bc5b6 != 0)
				{
					num2 = 0;
				}
				break;
			case 6:
			{
				IEntityFilter entityFilter2 = entityFilter;
				code = filter.Code;
				Guid value;
				if (!(code.Value == WorkflowConstants.MyProcessesFilterCode))
				{
					code = filter.Code;
					value = (iVeyDfaZxAdsUNTv2mF(code.Value, WorkflowConstants.MonitorFilterCode) ? lqIlx6az9vdkbFoSxtS(WorkflowPermissionProvider.ProcessMonitor) : lqIlx6az9vdkbFoSxtS(WorkflowProcessesPermissionProvider.ImprovementAccessPermission));
				}
				else
				{
					value = lqIlx6az9vdkbFoSxtS(WorkflowPermissionProvider.MyProcessesPermission);
				}
				entityFilter2.PermissionId = value;
				num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_5e3789bc3f974f489e0b5a0c8243b85d != 0)
				{
					num2 = 0;
				}
				break;
			}
			}
		}
	}

	public WorkflowInstanceFilterPermissionIdListener()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		pT0m0kYX1mlLlPvNpO2();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_4d66b27a693d4e1f9d801c17731a3049 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object yLMRx4a5PmD7FCCSt7a(object P_0)
	{
		return ((AbstractPostDatabaseOperationEvent)P_0).get_Entity();
	}

	internal static object bX9ge1agnsD1VoJNy4L(object P_0)
	{
		return ((IFilter)P_0).FilterFields;
	}

	internal static object rCSBE2a1QOBoUOq45SK(object P_0)
	{
		return ((IFilter)P_0).ObjectsType;
	}

	internal static Guid G4v15TaIIgmafIVgeKp(object P_0)
	{
		return ((ReferenceOnEntityType)P_0).TypeUid;
	}

	internal static bool iVeyDfaZxAdsUNTv2mF(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static Guid lqIlx6az9vdkbFoSxtS(object P_0)
	{
		return ((Permission)P_0).Id;
	}

	internal static object HNqnn0YEOOwWYY5bfWh(object P_0, object P_1)
	{
		return UniversalFilterSaver.Pack((IEntityFilter)P_0, (ITypeWrapperResolver)P_1);
	}

	internal static void pSej4XYCs5W6LtOmXxg(object P_0, object P_1)
	{
		((IFilter)P_0).FilterFields = P_1;
	}

	internal static bool BDhQSmarQ3q9rPqoS7W()
	{
		return qPCqDjaJidcqe8ZjObY == null;
	}

	internal static WorkflowInstanceFilterPermissionIdListener qN6qV4a7J9dYYuZo29E()
	{
		return qPCqDjaJidcqe8ZjObY;
	}

	internal static void pT0m0kYX1mlLlPvNpO2()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}
}
