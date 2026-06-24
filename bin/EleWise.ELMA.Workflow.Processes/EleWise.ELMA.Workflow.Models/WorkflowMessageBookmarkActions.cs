using System;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Attributes;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Models;

public class WorkflowMessageBookmarkActions : DefaultEntityActions
{
	[DisplayName(typeof(__Resources_WorkflowMessageBookmarkActions), "P_Escalation_DisplayName")]
	[Uid("ee86d65d-8631-4b27-92c0-fc4feb9b4765")]
	public const string Escalation = "ee86d65d-8631-4b27-92c0-fc4feb9b4765";

	private static Guid _escalationGuid;

	internal static WorkflowMessageBookmarkActions T0BLFRqafHIcx15Tl6b;

	public static Guid EscalationGuid => _escalationGuid;

	protected WorkflowMessageBookmarkActions()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_9747bbf97f854087a2d2f13ea94f4085 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static WorkflowMessageBookmarkActions()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				gI0uTGqPZ5o5RHXe7c9();
				num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_7f79a06dec5f490c93fd11725200b9b3 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 1:
				_escalationGuid = new Guid((string)B569kSq4Re8233gnIoN(0x48B7D69C ^ 0x48B7999E));
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_6ee07aa726964a2281f0ce81cd001aec == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool FgTk5YqYhspSvsMB5Qw()
	{
		return T0BLFRqafHIcx15Tl6b == null;
	}

	internal static WorkflowMessageBookmarkActions nnOxacqv3e9YjTT7N3k()
	{
		return T0BLFRqafHIcx15Tl6b;
	}

	internal static void gI0uTGqPZ5o5RHXe7c9()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}

	internal static object B569kSq4Re8233gnIoN(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
