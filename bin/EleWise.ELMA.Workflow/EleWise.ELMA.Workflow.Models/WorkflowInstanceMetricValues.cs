using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.Managers;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Models;

[DefaultManager(typeof(WorkflowInstanceMetricValuesManagerMaker))]
public abstract class WorkflowInstanceMetricValues : WorkflowEntity
{
	internal static WorkflowInstanceMetricValues RcWp48Oj0wLi6Zqsv8wI;

	public static WorkflowInstanceMetricValues Load(object workflowInstance)
	{
		return Locator.GetServiceNotNull<WorkflowInstanceContextService>().LoadWorkflowInstanceMetricValues((IWorkflowInstance)workflowInstance);
	}

	protected WorkflowInstanceMetricValues(long id, Type mainType)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		oSjCBwOjte1EfEik661A();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 != 0)
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
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4459fbe344a947429d197733d274ef68 == 0)
			{
				num = 1;
			}
		}
	}

	protected override ICompositeEntityManager CreateCompositeManager()
	{
		return (ICompositeEntityManager)Y4n5MiOjg8qTT7HH7CfL(JBUTy3OjbWj7MarqVbf5(typeof(WorkflowInstanceMetricValuesManager<>).TypeHandle).MakeGenericType(xhUxU2Oj5MjMW2B4VQo5(this)));
	}

	internal static bool Cjevj4Ojy8UfEh0xVWw5()
	{
		return RcWp48Oj0wLi6Zqsv8wI == null;
	}

	internal static WorkflowInstanceMetricValues qciUHUOjmgUwxUgIrw67()
	{
		return RcWp48Oj0wLi6Zqsv8wI;
	}

	internal static void oSjCBwOjte1EfEik661A()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static Type JBUTy3OjbWj7MarqVbf5(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static Type xhUxU2Oj5MjMW2B4VQo5(object P_0)
	{
		return P_0.GetType();
	}

	internal static object Y4n5MiOjg8qTT7HH7CfL(Type P_0)
	{
		return Locator.GetServiceNotNull(P_0);
	}
}
