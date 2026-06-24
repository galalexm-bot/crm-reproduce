using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Components;

[Component]
internal sealed class WorkflowTaskObjectFormProvider : IObjectFormProvider
{
	private static WorkflowTaskObjectFormProvider dMMgcsObSbsD2tQfyexx;

	public bool Check(Guid typeUid, Guid subTypeUid)
	{
		return y7luQqObE2HNKHiUc8hN(subTypeUid, InterfaceActivator.UID<IWorkflowTask>());
	}

	public (object, ClassMetadata) GetObjectInfo(Guid typeUid, Guid subTypeUid, string model)
	{
		throw new NotImplementedException();
	}

	public FormViewItem GetFormByType(object entity, ViewType viewType)
	{
		throw new NotImplementedException();
	}

	public FormViewItem GetFormByUid(object entity, Guid formUid)
	{
		//Discarded unreachable code: IL_0035, IL_0044
		int num = 2;
		int num2 = num;
		IWorkflowTaskBase workflowTaskBase = default(IWorkflowTaskBase);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (workflowTaskBase == null)
				{
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f508947b0d94af1961e5aa17a8a2044 == 0)
					{
						num2 = 4;
					}
					break;
				}
				if (dycah3ObwAetf0VC1Ls4(formUid, Guid.Empty))
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			case 2:
				workflowTaskBase = entity as IWorkflowTaskBase;
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b != 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				return null;
			case 3:
				return WorkflowTaskFormViewTransformate.GetViewItem(workflowTaskBase) as FormViewItem;
			default:
				return vrFiCZOb4L5uJ047I4AC(workflowTaskBase, formUid) as FormViewItem;
			}
		}
	}

	public void InitObject(object obj, ViewType viewType, IDictionary<string, object> arguments)
	{
	}

	public WorkflowTaskObjectFormProvider()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		sn2hD4Obzjv7AgcEndFc();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0991fd79553c4ecc82e8b5cb79c2bff2 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool y7luQqObE2HNKHiUc8hN(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static bool nE8fFlOb1QqRGtdPaXjg()
	{
		return dMMgcsObSbsD2tQfyexx == null;
	}

	internal static WorkflowTaskObjectFormProvider Fb5dvPObhNhmst1tShoQ()
	{
		return dMMgcsObSbsD2tQfyexx;
	}

	internal static bool dycah3ObwAetf0VC1Ls4(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static object vrFiCZOb4L5uJ047I4AC(object P_0, Guid formUid)
	{
		return WorkflowTaskFormViewTransformate.GetViewItem((IWorkflowTaskBase)P_0, formUid);
	}

	internal static void sn2hD4Obzjv7AgcEndFc()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
