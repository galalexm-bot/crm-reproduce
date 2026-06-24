using System;
using System.Collections.Generic;
using EleWise.ELMA.DevServer.TypeDescriptors;
using EleWise.ELMA.Workflow.Types;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.DevServer;

internal sealed class WorkflowTypeDescriptorProvider : ITypeDescriptorProvider
{
	private static WorkflowTypeDescriptorProvider T4wX3N4bDEUg2SAh7OY;

	public IEnumerable<Type> GetTypeDescriptors()
	{
		return new Type[12]
		{
			typeof(InstanceMetricValuesTypeDescriptor),
			typeof(InstanceNamingSchemeTypeDescriptor),
			typeof(ProcessMetricValuesTypeDescriptor),
			typeof(WorkflowInstanceContextTypeDescriptor),
			typeof(ProcessParametersTypeDescriptor),
			typeof(ProcessContextViewSchemeTypeDescriptor),
			typeof(ProcessInstanceMetricsContainerTypeDescriptor),
			typeof(ProcessMetricsContainerTypeDescriptor),
			typeof(ProcessRegulationTypeDescriptor),
			typeof(WorkflowBookmarkTypeDescriptor),
			typeof(WorkflowDiagramTypeDescriptor),
			typeof(WorkflowFormsContainerTypeDescriptor)
		};
	}

	public WorkflowTypeDescriptorProvider()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1de08766357542bdb81146373079f817 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool qGTaEx45FLXPvs14bRN()
	{
		return T4wX3N4bDEUg2SAh7OY == null;
	}

	internal static WorkflowTypeDescriptorProvider qb7qMQ4gxYVcvUmhOlb()
	{
		return T4wX3N4bDEUg2SAh7OY;
	}
}
