using System.Runtime.CompilerServices;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Events;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Audit.HistoryModels;

public class TerminateWorkflowInstanceHistoryModel : HistoryBaseModel, ICommentedHistoryModel, IHistoryBaseModel, IWorkflowInstanceEvent
{
	internal static TerminateWorkflowInstanceHistoryModel ByxCO8ZnTFpoEBcZTUm4;

	public IComment Comment
	{
		[CompilerGenerated]
		get
		{
			return _003CComment_003Ek__BackingField;
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
				case 1:
					_003CComment_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe4a54387d744988feba4889229faf1 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public TerminateWorkflowInstanceHistoryModel([NotNull] EntityActionEventArgs originalEvent, string actionTheme)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		BLIa1cZnC7E0SAIWj0A1();
		base._002Ector(originalEvent, actionTheme);
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ffb1346d351f436b84bb1e9954c3bfa8 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void BLIa1cZnC7E0SAIWj0A1()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool Pt8XenZnQIAowBFDw6cb()
	{
		return ByxCO8ZnTFpoEBcZTUm4 == null;
	}

	internal static TerminateWorkflowInstanceHistoryModel MU5mPwZnpuNY4SXtwaeP()
	{
		return ByxCO8ZnTFpoEBcZTUm4;
	}
}
