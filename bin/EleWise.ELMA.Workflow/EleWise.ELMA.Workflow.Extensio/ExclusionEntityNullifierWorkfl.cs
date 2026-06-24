using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Nullifier;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.ExtensionPoints;

[Component]
internal class ExclusionEntityNullifierWorkflow : IExclusionEntityNullifier
{
	private static ExclusionEntityNullifierWorkflow UbXPlvI7tPnoOdgZ1gx;

	public List<Guid> SetExclusion()
	{
		return new List<Guid>
		{
			InterfaceActivator.UID<IWorkflowTrackingItem>(),
			InterfaceActivator.UID<IProcessHeader>(),
			InterfaceActivator.UID<IWorkflowInstance>(),
			InterfaceActivator.UID<ITerminateExternalSubProcessShelulerJob>(),
			InterfaceActivator.UID<IResumeProcessSchedulerJob>(),
			InterfaceActivator.UID<IProcessGroup>(),
			InterfaceActivator.UID<IStartProcessSchedulerJob>(),
			InterfaceActivator.UID<IRegulationResourceType>(),
			InterfaceActivator.UID<IProcessHeaderAccess>(),
			InterfaceActivator.UID<IMonitorUpdateActionQueueItem>(),
			InterfaceActivator.UID<IWorkflowInstanceState>(),
			InterfaceActivator.UID<IWorkflowBookmark>(),
			InterfaceActivator.UID<IWorkflowInstanceMember>(),
			InterfaceActivator.UID<IRegulationTemplate>(),
			InterfaceActivator.UID<IWorkflowInstancePermission>(),
			InterfaceActivator.UID<ITerminateTaskSchedulerJob>(),
			InterfaceActivator.UID<IMonitorCacheItem>(),
			InterfaceActivator.UID<IWorkflowSwimlaneExecutor>(),
			InterfaceActivator.UID<IWorkflowProcessListRunning>(),
			InterfaceActivator.UID<IWorkflowTask>(),
			InterfaceActivator.UID<IProcessHeaderPermission>(),
			InterfaceActivator.UID<IWorkflowQueueItem>(),
			InterfaceActivator.UID<IEmulationContextTemplates>(),
			InterfaceActivator.UID<IProcessMetricValue>(),
			InterfaceActivator.UID<IWorkflowProcess>()
		};
	}

	public ExclusionEntityNullifierWorkflow()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		FSG780IFWcgOpT8JSjO();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void FSG780IFWcgOpT8JSjO()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool pLO4KJI2RsjOg8AuKBU()
	{
		return UbXPlvI7tPnoOdgZ1gx == null;
	}

	internal static ExclusionEntityNullifierWorkflow mHaZn0Iomg06Xq9fIBY()
	{
		return UbXPlvI7tPnoOdgZ1gx;
	}
}
