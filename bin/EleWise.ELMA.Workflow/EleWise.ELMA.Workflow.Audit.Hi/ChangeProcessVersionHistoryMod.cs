using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Audit.HistoryModels;

public class ChangeProcessVersionHistoryModel : HistoryBaseModel, ICommentedHistoryModel, IHistoryBaseModel, IWorkflowInstanceEvent
{
	internal static ChangeProcessVersionHistoryModel GrdGT9Znno9lTvXXo2sR;

	public IList<PropertyMetadata> ChangedProperties { get; set; }

	public IWorkflowInstance OldEntity
	{
		[CompilerGenerated]
		get
		{
			return _003COldEntity_003Ek__BackingField;
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
					_003COldEntity_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public IWorkflowInstance NewEntity
	{
		[CompilerGenerated]
		get
		{
			return _003CNewEntity_003Ek__BackingField;
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
					_003CNewEntity_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_61395ebf330446ac8ce99b55ee3acfa9 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

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
				case 0:
					return;
				case 1:
					_003CComment_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ChangeProcessVersionHistoryModel([NotNull] EntityActionEventArgs originalEvent, string actionTheme)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		djiAmoZnfiPh5lHJRMUc();
		base._002Ector(originalEvent, actionTheme);
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_43af423d081c48e3bc6cea30ce47523d == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			ChangedProperties = new List<PropertyMetadata>();
			num = 1;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_71a41ac2fa884d27b721ae0509586eea == 0)
			{
				num = 0;
			}
		}
	}

	internal static void djiAmoZnfiPh5lHJRMUc()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool VxrGyhZnHBfm8oKAX8Bi()
	{
		return GrdGT9Znno9lTvXXo2sR == null;
	}

	internal static ChangeProcessVersionHistoryModel v1d5ZgZnLomsvqyAtlKX()
	{
		return GrdGT9Znno9lTvXXo2sR;
	}
}
