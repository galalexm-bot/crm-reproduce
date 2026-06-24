using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Events;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Audit.HistoryModels;

public class AddCommentWorkflowInstanceHistoryModel : HistoryBaseModel, ICommentedHistoryModel, IHistoryBaseModel, IAttachedHistoryModel, IWorkflowInstanceEvent, IMultiCommentHistoryModel
{
	internal static AddCommentWorkflowInstanceHistoryModel amMxbuZnXLDQp25A59ZK;

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
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 == 0)
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

	public ICollection<IAttachment> Attachments { get; set; }

	public ICollection<IComment> Comments { get; set; }

	public AddCommentWorkflowInstanceHistoryModel([NotNull] EntityActionEventArgs originalEvent, string actionTheme)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		KCC5qKZnD8K31gE7bDGb();
		base._002Ector(originalEvent, actionTheme);
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void KCC5qKZnD8K31gE7bDGb()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool n3lPsPZndjXdwCt6KMCb()
	{
		return amMxbuZnXLDQp25A59ZK == null;
	}

	internal static AddCommentWorkflowInstanceHistoryModel AOEbMMZnuAdoGqOFoibT()
	{
		return amMxbuZnXLDQp25A59ZK;
	}
}
