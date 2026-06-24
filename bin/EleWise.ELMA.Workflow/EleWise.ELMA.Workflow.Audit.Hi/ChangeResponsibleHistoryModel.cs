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

public class ChangeResponsibleHistoryModel : HistoryBaseModel, IEditedHistoryModel<IWorkflowInstance>, IHistoryBaseModel
{
	private static ChangeResponsibleHistoryModel saEIqUZn9Cc9yuLa2VMZ;

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
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae2bde9e5844c638021cdb56fc01122 != 0)
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
				case 1:
					_003CNewEntity_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e8980a9fd9d44c20920ffa276900c96f == 0)
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

	public ChangeResponsibleHistoryModel([NotNull] EntityActionEventArgs originalEvent, string actionTheme)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		Q0E3weZnRPAhwSecZM4o();
		base._002Ector(originalEvent, actionTheme);
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e4c570270f54493d8f3f4763a72f63f7 == 0)
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
			num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3b4403f77a00495e957e5e4a6840e5d3 == 0)
			{
				num = 1;
			}
		}
	}

	internal static void Q0E3weZnRPAhwSecZM4o()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool dkGSFuZnWM5sg97lgvXY()
	{
		return saEIqUZn9Cc9yuLa2VMZ == null;
	}

	internal static ChangeResponsibleHistoryModel pNmCwCZnjptWY1TZqBKs()
	{
		return saEIqUZn9Cc9yuLa2VMZ;
	}
}
