using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.Managers;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Models;

[DefaultManager(typeof(WorkflowInstanceContextManagerMaker))]
public abstract class WorkflowInstanceContext : WorkflowEntity
{
	internal static WorkflowInstanceContext sftUDYORRbXIBWVmxf0H;

	public static WorkflowInstanceContext Load(object workflowInstance)
	{
		return (WorkflowInstanceContext)K2fmmmOR3SbHqTOTAJKD(Locator.GetServiceNotNull<WorkflowInstanceContextService>(), (IWorkflowInstance)workflowInstance);
	}

	public static WorkflowInstanceContext Check(object workflowInstance, WorkflowInstanceContext context)
	{
		return (WorkflowInstanceContext)nXJ6DtORTBtLYRq0e7mh(Locator.GetServiceNotNull<WorkflowInstanceContextService>(), (IWorkflowInstance)workflowInstance, context);
	}

	protected WorkflowInstanceContext(long id, Type mainType)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		dBOSH3ORQAIWhcUnGvpA();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			Initialize(id, mainType);
			num = 1;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe4a54387d744988feba4889229faf1 == 0)
			{
				num = 1;
			}
		}
	}

	protected override ICompositeEntityManager CreateCompositeManager()
	{
		return (ICompositeEntityManager)qsCaRGORMVtN2Ybq42vS(YU8AObORpvmMl24tsK2S(typeof(WorkflowInstanceContextManager<>).TypeHandle).MakeGenericType(rMXMn1ORCfSkrTIPKxfV(this)));
	}

	internal static object K2fmmmOR3SbHqTOTAJKD(object P_0, object P_1)
	{
		return ((WorkflowInstanceContextService)P_0).LoadWorkflowInstanceContext((IWorkflowInstance)P_1);
	}

	internal static bool qsBVyAOR6m2dExKcpmpm()
	{
		return sftUDYORRbXIBWVmxf0H == null;
	}

	internal static WorkflowInstanceContext MWBsNgORqeQqXvCqP8pU()
	{
		return sftUDYORRbXIBWVmxf0H;
	}

	internal static object nXJ6DtORTBtLYRq0e7mh(object P_0, object P_1, object P_2)
	{
		return ((WorkflowInstanceContextService)P_0).CheckWorkflowInstanceContext((IWorkflowInstance)P_1, (WorkflowInstanceContext)P_2);
	}

	internal static void dBOSH3ORQAIWhcUnGvpA()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static Type YU8AObORpvmMl24tsK2S(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static Type rMXMn1ORCfSkrTIPKxfV(object P_0)
	{
		return P_0.GetType();
	}

	internal static object qsCaRGORMVtN2Ybq42vS(Type P_0)
	{
		return Locator.GetServiceNotNull(P_0);
	}
}
