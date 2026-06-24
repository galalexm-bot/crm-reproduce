using System;
using System.Collections.Generic;
using EleWise.ELMA.Components;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Workflow.Diagrams;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Components;

public abstract class WorkflowLinkedFinderBase : LinkedFinderBase
{
	private readonly Guid processHeaderUID;

	protected readonly ProcessHeaderManager ProcessHeaderManager;

	private static WorkflowLinkedFinderBase T4MSOrOmWp4fI8JxJse9;

	public WorkflowLinkedFinderBase(ProcessHeaderManager processHeaderManager)
	{
		//Discarded unreachable code: IL_003b, IL_0040
		sqYr8iOm6eB30VqOE6DX();
		processHeaderUID = InterfaceActivator.UID<IProcessHeader>(loadImplementation: false);
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				ProcessHeaderManager = processHeaderManager;
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cb262bcfe4074a1ab16e653815d57f28 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	protected void AddDiagram(List<WorkflowDiagram> diagrams, IProcessHeader header)
	{
		if (header.Current?.Diagram != null)
		{
			diagrams.Add(header.Current.Diagram);
		}
	}

	protected ICollection<WorkflowDiagram> GetProcessDiagrams(ICollection<ILinkedObject> objectsToSearch, LinkedObjectsContext context)
	{
		List<WorkflowDiagram> list = new List<WorkflowDiagram>();
		foreach (IProcessHeader processHeader in GetProcessHeaders(objectsToSearch, context))
		{
			AddDiagram(list, processHeader);
		}
		return list;
	}

	protected ICollection<IProcessHeader> GetProcessHeaders(ICollection<ILinkedObject> objectsToSearch, LinkedObjectsContext context)
	{
		List<IProcessHeader> list = new List<IProcessHeader>();
		foreach (ILinkedObject item in objectsToSearch)
		{
			if (IsProcessHeader(item))
			{
				IProcessHeader header = GetHeader(item.Uid, context);
				if (header != null)
				{
					list.Add(header);
				}
			}
		}
		return list;
	}

	protected IProcessHeader GetHeader(Guid headerUid, LinkedObjectsContext context)
	{
		return GetObjectFromContextLoadedDataOrLoad(headerUid, context, (Guid uid) => ProcessHeaderManager.LoadOrNull(uid));
	}

	private bool IsProcessHeader(ILinkedObject objectInfo)
	{
		return DBiCyTOmqyHYyK7Sgcnp(objectInfo) == processHeaderUID;
	}

	internal static void sqYr8iOm6eB30VqOE6DX()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool GU4etIOmj1BLAfGjBsC9()
	{
		return T4MSOrOmWp4fI8JxJse9 == null;
	}

	internal static WorkflowLinkedFinderBase s1dJaZOmRYYyeJxbUVdX()
	{
		return T4MSOrOmWp4fI8JxJse9;
	}

	internal static Guid DBiCyTOmqyHYyK7Sgcnp(object P_0)
	{
		return ((ILinkedObject)P_0).TypeUid;
	}
}
