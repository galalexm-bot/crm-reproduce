using System.Runtime.CompilerServices;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Audit.HistoryModels;

public class CreateWorkflowInstanceHistoryModel : HistoryBaseModel, ICreatedHistoryModel<IWorkflowInstance>, IHistoryBaseModel, IWorkflowInstanceEvent
{
	internal static CreateWorkflowInstanceHistoryModel WouJBCZn6KSdMDRxvV2a;

	public IWorkflowInstance Entity
	{
		[CompilerGenerated]
		get
		{
			return _003CEntity_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					_003CEntity_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae2bde9e5844c638021cdb56fc01122 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public CreateWorkflowInstanceHistoryModel([NotNull] EntityActionEventArgs originalEvent, string actionTheme)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector(originalEvent, actionTheme);
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_545887e65739480a965b7ddfab7d0632 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool urOB6nZnqbrkmy38G1Dp()
	{
		return WouJBCZn6KSdMDRxvV2a == null;
	}

	internal static CreateWorkflowInstanceHistoryModel xMXMVIZn3tmgiCPClS65()
	{
		return WouJBCZn6KSdMDRxvV2a;
	}
}
