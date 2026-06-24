using System;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Tasks;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.ExtensionPoints;

[Obsolete("Используйте IDenyReplaceExecutorExtention")]
public class DenyReplaceExecutorUserTaskElementExtentions : IDenyReplaceExecutorInElementExtentions
{
	internal static DenyReplaceExecutorUserTaskElementExtentions nMZfLVaMYqLgXHu5uY7;

	[Obsolete("Используйте IDenyReplaceExecutorExtention.DenyReplace")]
	public bool DenyReplace(BPMNFlowElement element)
	{
		//Discarded unreachable code: IL_005d
		int num = 1;
		int num2 = num;
		UserTaskElement userTaskElement = default(UserTaskElement);
		while (true)
		{
			switch (num2)
			{
			case 1:
				userTaskElement = element as UserTaskElement;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_448e6815cb30438893079dcbb906fd65 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return userTaskElement.DenyReplace;
			case 2:
				return false;
			default:
				if (userTaskElement == null)
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f8a84e2cb374827a50ba2cbcf11cf48 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 3;
			}
		}
	}

	public DenyReplaceExecutorUserTaskElementExtentions()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_71a41ac2fa884d27b721ae0509586eea != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool pIDT2yakvCiyxYdLSFx()
	{
		return nMZfLVaMYqLgXHu5uY7 == null;
	}

	internal static DenyReplaceExecutorUserTaskElementExtentions jxx3MraUps6rXsxjctl()
	{
		return nMZfLVaMYqLgXHu5uY7;
	}
}
