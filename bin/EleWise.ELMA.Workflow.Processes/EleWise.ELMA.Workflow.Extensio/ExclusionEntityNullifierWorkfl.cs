using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Nullifier;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Extensions;

[Component]
internal class ExclusionEntityNullifierWorkflowProcess : IExclusionEntityNullifier
{
	internal static ExclusionEntityNullifierWorkflowProcess lAdfFsYvqspVnH7IdmO;

	public List<Guid> SetExclusion()
	{
		return new List<Guid>
		{
			InterfaceActivator.UID<IWorkflowMessageTypeParameter>(),
			InterfaceActivator.UID<IWorkflowMessageType>(),
			InterfaceActivator.UID<ICustomActivityFolder>(),
			InterfaceActivator.UID<ITerminateMessageReceiveSchedulerJob>(),
			InterfaceActivator.UID<IWorkflowMessageBookmark>(),
			InterfaceActivator.UID<IImprovementProcessSettings>(),
			InterfaceActivator.UID<ICustomActivityHeader>(),
			InterfaceActivator.UID<ICustomActivity>()
		};
	}

	public ExclusionEntityNullifierWorkflowProcess()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		W4xN7VY97L3v5b20TGh();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_140e6a1eacec422f932ef627eb6c4c16 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void W4xN7VY97L3v5b20TGh()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}

	internal static bool F5KxfYYPrS2CFhsLCaM()
	{
		return lAdfFsYvqspVnH7IdmO == null;
	}

	internal static ExclusionEntityNullifierWorkflowProcess Ur8BpXY4c1xYAot07lx()
	{
		return lAdfFsYvqspVnH7IdmO;
	}
}
