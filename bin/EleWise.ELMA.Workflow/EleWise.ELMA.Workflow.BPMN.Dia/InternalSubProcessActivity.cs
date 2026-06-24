using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.SubProcess;
using EleWise.ELMA.Workflow.Diagrams.Activities;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Activities.SubProcess;

public class InternalSubProcessActivity : SubProcessActivity<InternalSubprocessElement>
{
	[Component]
	private class Info : IWorkflowActivityInfo
	{
		internal static object yop8PhvH3NKGesmP7EWJ;

		public Type ActivityType => IB2BALvHpaq8XfZdIDTV(typeof(InternalSubProcessActivity).TypeHandle);

		public Type DiagramElementType => IB2BALvHpaq8XfZdIDTV(typeof(InternalSubprocessElement).TypeHandle);

		public Info()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			F2K6GKvHCaPiEhJIAp8g();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e2e244178c44ea09cd756894b022a62 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static Type IB2BALvHpaq8XfZdIDTV(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static void F2K6GKvHCaPiEhJIAp8g()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}

		internal static bool RiyxAOvHTK5C2Ugu09W3()
		{
			return yop8PhvH3NKGesmP7EWJ == null;
		}

		internal static Info nWn4lMvHQi25SRROOIv3()
		{
			return (Info)yop8PhvH3NKGesmP7EWJ;
		}
	}

	internal static InternalSubProcessActivity R0NQF3ZgH8bxMbwHoq3R;

	protected override IWorkflowProcess GetSubProcess(IWorkflowInstance instance)
	{
		int num = 2;
		int num2 = num;
		IWorkflowProcess workflowProcess = default(IWorkflowProcess);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (workflowProcess == null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0991fd79553c4ecc82e8b5cb79c2bff2 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return workflowProcess;
			case 2:
				workflowProcess = ((IEnumerable<IWorkflowProcess>)((IWorkflowProcess)WOYnoiZg9limjBLkDrsv(instance)).SubProcesses).FirstOrDefault((IWorkflowProcess p) => ((IEntity<long>)s5Lx0YZgjl5GJeml7uaB(p)).Id == xDyucvZgRrTqBYmLZs47(base.Element));
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_71a41ac2fa884d27b721ae0509586eea == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return null;
			}
		}
	}

	public InternalSubProcessActivity()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		XokRFcZgW8HRn3yc5oSq();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_46e05b4e09174e34a9c81741b8b77a2f != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object WOYnoiZg9limjBLkDrsv(object P_0)
	{
		return ((IWorkflowInstance)P_0).Process;
	}

	internal static bool zMtlQPZgLVyLwlFtcy4B()
	{
		return R0NQF3ZgH8bxMbwHoq3R == null;
	}

	internal static InternalSubProcessActivity BwqfdAZgfnXUnvvU2L7f()
	{
		return R0NQF3ZgH8bxMbwHoq3R;
	}

	internal static void XokRFcZgW8HRn3yc5oSq()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static object s5Lx0YZgjl5GJeml7uaB(object P_0)
	{
		return ((IWorkflowProcess)P_0).Header;
	}

	internal static long xDyucvZgRrTqBYmLZs47(object P_0)
	{
		return ((SubProcessElement)P_0).ProcessHeaderId;
	}
}
