using System;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Actors;

internal sealed class WorkflowProcessPublicationServerInstanceActor : Actor, IWorkflowProcessPublicationServerInstanceActor, IServerPlacementActor, IActorWithGuidKey, IActor
{
	private readonly IWorkflowProcessPublicationEventHandler workflowProcessPublicationEventHandler;

	internal static WorkflowProcessPublicationServerInstanceActor qwPNV4ZHjuu06G449Vu6;

	public WorkflowProcessPublicationServerInstanceActor(IWorkflowProcessPublicationEventHandler workflowProcessPublicationEventHandler)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		v3WF4eZHq57MpbgFr4Os();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c559093b7320494babd70d164a6df42d != 0)
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
			this.workflowProcessPublicationEventHandler = workflowProcessPublicationEventHandler;
			num = 1;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 == 0)
			{
				num = 0;
			}
		}
	}

	public Task PublicationSuccess(long processHeaderId)
	{
		return (Task)pf3XspZH3xDw9xePjVZy(workflowProcessPublicationEventHandler, processHeaderId);
	}

	public Task PublicationError(long processHeaderId, Exception exception)
	{
		return (Task)tLyDKrZHT3dohceUj4bi(workflowProcessPublicationEventHandler, processHeaderId, exception);
	}

	internal static void v3WF4eZHq57MpbgFr4Os()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool yltetmZHR7hhw5UriFTL()
	{
		return qwPNV4ZHjuu06G449Vu6 == null;
	}

	internal static WorkflowProcessPublicationServerInstanceActor y2m8vwZH6HNJpq5g7Aek()
	{
		return qwPNV4ZHjuu06G449Vu6;
	}

	internal static object pf3XspZH3xDw9xePjVZy(object P_0, long processHeaderId)
	{
		return ((IWorkflowProcessPublicationEventHandler)P_0).Complete(processHeaderId);
	}

	internal static object tLyDKrZHT3dohceUj4bi(object P_0, long processHeaderId, object P_2)
	{
		return ((IWorkflowProcessPublicationEventHandler)P_0).Error(processHeaderId, (Exception)P_2);
	}
}
