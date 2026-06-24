using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Notifications;
using EleWise.ELMA.Tasks.Components;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Components;

[Component]
public class WorkflowTaskNotificationFlowObjects : INotificationFlowObject
{
	private static WorkflowTaskNotificationFlowObjects grYTpZOBfvaDlUirTJcl;

	public bool Can(Guid flowUid)
	{
		int num = 1;
		int num2 = num;
		Guid uID = default(Guid);
		while (true)
		{
			switch (num2)
			{
			default:
				return uID.Equals(flowUid);
			case 1:
				uID = TaskNotificationFlow.UID;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_85ba8d91af394836ac86666c40b1e150 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public IDictionary<Guid, Guid[]> Get()
	{
		Dictionary<Guid, Guid[]> dictionary = new Dictionary<Guid, Guid[]>();
		dictionary.Add(InterfaceActivator.UID<IWorkflowTask>(), new Guid[3]
		{
			DefaultEntityActions.CreateGuid,
			TaskBaseActions.RedirectGuid,
			TaskBaseActions.ActivateGuid
		});
		return dictionary;
	}

	public WorkflowTaskNotificationFlowObjects()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6d48f3b4557a49578bf7f5ef0517e0be == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool LmYpguOB97UGrocxQkJs()
	{
		return grYTpZOBfvaDlUirTJcl == null;
	}

	internal static WorkflowTaskNotificationFlowObjects Ljc66TOBWo7VfnnCmDfb()
	{
		return grYTpZOBfvaDlUirTJcl;
	}
}
