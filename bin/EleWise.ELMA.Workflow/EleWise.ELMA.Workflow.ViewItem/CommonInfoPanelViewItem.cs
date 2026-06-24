using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.ViewItems;

[Serializable]
[ViewItemMetadata(Type = typeof(IWorkflowTask))]
[DisplayName(typeof(__Resources_CommonInfoPanelViewItem), "DisplayName")]
public class CommonInfoPanelViewItem : ViewItem
{
	[Component(Order = 100)]
	private class ToolboxItem : WorkflowViewItemToolboxItem<CommonInfoPanelViewItem>
	{
		internal static object CuOQA9ZRbF26ghcwsOeF;

		public ToolboxItem()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			NwPDj0ZRBlkv4hS3l7Er();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_32f3e755437f4eacb85c8a0d536f83ea == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static void NwPDj0ZRBlkv4hS3l7Er()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}

		internal static bool LHLMuUZR5JHbReefCf53()
		{
			return CuOQA9ZRbF26ghcwsOeF == null;
		}

		internal static ToolboxItem rbW0eXZRgb1F6FGk8u17()
		{
			return (ToolboxItem)CuOQA9ZRbF26ghcwsOeF;
		}
	}

	private static CommonInfoPanelViewItem yXQUwq5hpj4twXTB1i2;

	public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (parentViewItem != null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a2041b18ca1f4a5cb8e5060163bfdb57 != 0)
					{
						num2 = 0;
					}
					break;
				}
				return true;
			default:
				return aawa2154B7sLvYiI5vm(parentViewItem, this);
			}
		}
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return false;
	}

	public CommonInfoPanelViewItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9570b4a70465495fba22c942f586465a == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool aawa2154B7sLvYiI5vm(object P_0, object P_1)
	{
		return ((ViewItem)P_0).IsChildValid((ViewItem)P_1);
	}

	internal static bool tamenQ5EZr5G8Gg54pi()
	{
		return yXQUwq5hpj4twXTB1i2 == null;
	}

	internal static CommonInfoPanelViewItem dwwjaQ5wHA54CGYpUoC()
	{
		return yXQUwq5hpj4twXTB1i2;
	}
}
