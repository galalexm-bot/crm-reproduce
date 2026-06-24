using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Workflow.Diagrams.Activities;
using EleWise.ELMA.Workflow.Diagrams.Elements;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.ExtensionPoints;

public sealed class GetRecipientsParameters
{
	internal static GetRecipientsParameters jgG37kZKEgrwWV8KHnVZ;

	public IWorkflowInstance Instance { get; }

	public IElementWithNotification ElementWithNotification { get; }

	public IEnumerable<IUser> Executors { get; }

	public WorkflowActivity Activity { get; }

	internal GetRecipientsParameters(IWorkflowInstance instance, IElementWithNotification elementWithNotification)
	{
		//Discarded unreachable code: IL_002d, IL_0032
		yiYqKmZKzq6nIJftJ8l8();
		this._002Ector(null, instance, elementWithNotification);
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b1ab9396b25b43af8f32e24b1948be96 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public GetRecipientsParameters(WorkflowActivity activity, IWorkflowInstance instance, IElementWithNotification elementWithNotification)
	{
		//Discarded unreachable code: IL_0032, IL_0037
		yiYqKmZKzq6nIJftJ8l8();
		this._002Ector(activity, instance, elementWithNotification, Enumerable.Empty<IUser>());
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public GetRecipientsParameters(WorkflowActivity activity, IWorkflowInstance instance, IElementWithNotification elementWithNotification, IEnumerable<IUser> executors)
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		Activity = activity;
		Instance = instance;
		ElementWithNotification = elementWithNotification;
		Executors = executors ?? Enumerable.Empty<IUser>();
	}

	internal static void yiYqKmZKzq6nIJftJ8l8()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool jWia6eZKwhucpcR2ohMl()
	{
		return jgG37kZKEgrwWV8KHnVZ == null;
	}

	internal static GetRecipientsParameters RUTskDZK4ojVdwl2YwmF()
	{
		return jgG37kZKEgrwWV8KHnVZ;
	}
}
