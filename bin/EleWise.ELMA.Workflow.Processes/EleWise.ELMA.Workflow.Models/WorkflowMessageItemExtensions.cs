using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Workflow.Models;

public static class WorkflowMessageItemExtensions
{
	internal static WorkflowMessageItemExtensions AMrFdWsi1dCSSjgkv00;

	public static void AddReceiver(this IWorkflowMessageItem item, Guid elementUid)
	{
		int num = 2;
		int num2 = num;
		List<Guid> list = default(List<Guid>);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				list.Add(elementUid);
				num2 = 3;
				break;
			case 2:
				list = new List<Guid>((List<Guid>)item.ReceiverUids);
				num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_ff730ec99c9d438e9ab033b91102c6e4 == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 3:
				oZG8TZsfM5UVYxLwWxM(item, list);
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_6ee07aa726964a2281f0ce81cd001aec == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void oZG8TZsfM5UVYxLwWxM(object P_0, object P_1)
	{
		((IWorkflowMessageItem)P_0).ReceiverUids = P_1;
	}

	internal static bool UJ4Wuusuf8yld0Vy7Up()
	{
		return AMrFdWsi1dCSSjgkv00 == null;
	}

	internal static WorkflowMessageItemExtensions ze6UlpslvIM35J2cLTh()
	{
		return AMrFdWsi1dCSSjgkv00;
	}
}
