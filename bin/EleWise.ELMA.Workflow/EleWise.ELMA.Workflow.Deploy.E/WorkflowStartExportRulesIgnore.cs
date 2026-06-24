using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export.ExtensionPoints;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Deploy.Export;

[Component]
public class WorkflowStartExportRulesIgnore : IStartExportRulesIgnore
{
	internal static WorkflowStartExportRulesIgnore KEOabjOOWOG3tLm9sl1N;

	public bool IgnoreThisEntity(EntityMetadata entityMetadata)
	{
		//Discarded unreachable code: IL_0031, IL_0040
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				if (entityMetadata is ProcessContext)
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 3:
				if (entityMetadata == null)
				{
					num2 = 2;
					continue;
				}
				goto default;
			case 1:
				return true;
			case 2:
				break;
			}
			break;
		}
		return false;
	}

	public WorkflowStartExportRulesIgnore()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool Hf2qg2OOjt6XH9ylrfZD()
	{
		return KEOabjOOWOG3tLm9sl1N == null;
	}

	internal static WorkflowStartExportRulesIgnore Tp00gAOOR19FuESub2py()
	{
		return KEOabjOOWOG3tLm9sl1N;
	}
}
