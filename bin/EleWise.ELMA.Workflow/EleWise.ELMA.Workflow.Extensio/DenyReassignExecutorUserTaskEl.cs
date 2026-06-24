using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Tasks;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.ExtensionPoints;

[Component]
public class DenyReassignExecutorUserTaskElementExtentions : IDenyReassignExecutorInElementExtentions
{
	internal static DenyReassignExecutorUserTaskElementExtentions InIIUGIkDko31gytxtH;

	public bool DenyReassign(BPMNFlowElement element)
	{
		//Discarded unreachable code: IL_0050, IL_005f
		int num = 2;
		UserTaskElement userTaskElement = default(UserTaskElement);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (userTaskElement == null)
					{
						goto end_IL_0012;
					}
					goto default;
				default:
					return AjqwFsIA3hdFeWd0wpS(userTaskElement);
				case 3:
					return false;
				case 2:
					userTaskElement = element as UserTaskElement;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6b089b0d02ae4d3186c8d2cb8a24d4d3 == 0)
					{
						num2 = 1;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 3;
		}
	}

	public DenyReassignExecutorUserTaskElementExtentions()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		tMlR5VIGmNlG5jJt0fk();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_978f838cc41a4debb9700ede4b63f820 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool AjqwFsIA3hdFeWd0wpS(object P_0)
	{
		return ((UserTaskElement)P_0).DenyReassign;
	}

	internal static bool h8jOm8IUgZ7YnGPD2qk()
	{
		return InIIUGIkDko31gytxtH == null;
	}

	internal static DenyReassignExecutorUserTaskElementExtentions ON12lAIV48gT0Xa1E2c()
	{
		return InIIUGIkDko31gytxtH;
	}

	internal static void tMlR5VIGmNlG5jJt0fk()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
