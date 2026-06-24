using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.Managers;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Models;

[DefaultManager(typeof(WorkflowProcessMetricValuesManagerMaker))]
public abstract class WorkflowProcessMetricValues : WorkflowEntity
{
	internal static WorkflowProcessMetricValues TBYwheOjL6yfkqcu22pL;

	public static WorkflowProcessMetricValues Load(object process)
	{
		return (WorkflowProcessMetricValues)PiSlv9OjWlXAkVs4OF17(Locator.GetServiceNotNull<WorkflowInstanceContextService>(), (IWorkflowProcess)process);
	}

	protected WorkflowProcessMetricValues(long id, Type mainType)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				Initialize(id, mainType);
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2f119e188994b55be2499c193b880fb != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	protected override ICompositeEntityManager CreateCompositeManager()
	{
		return (ICompositeEntityManager)CxndtkOj69aHYb9VaJnr(asxS2rOjjwXri9y0wW8U(typeof(WorkflowProcessMetricValuesManager<>).TypeHandle).MakeGenericType(JLT8IKOjR6CNZRAZCsmJ(this)));
	}

	internal static object PiSlv9OjWlXAkVs4OF17(object P_0, object P_1)
	{
		return ((WorkflowInstanceContextService)P_0).LoadWorkflowProcessMetricValues((IWorkflowProcess)P_1);
	}

	internal static bool qxMVslOjfEBPSnrAyx58()
	{
		return TBYwheOjL6yfkqcu22pL == null;
	}

	internal static WorkflowProcessMetricValues j68uArOj93cgPhv3p5gS()
	{
		return TBYwheOjL6yfkqcu22pL;
	}

	internal static Type asxS2rOjjwXri9y0wW8U(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static Type JLT8IKOjR6CNZRAZCsmJ(object P_0)
	{
		return P_0.GetType();
	}

	internal static object CxndtkOj69aHYb9VaJnr(Type P_0)
	{
		return Locator.GetServiceNotNull(P_0);
	}
}
