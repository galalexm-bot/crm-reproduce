using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.ViewItems;

[Serializable]
[ViewItemMetadata(Type = typeof(IWorkflowTask))]
[DisplayName(typeof(__Resources_ButtonsPanelViewItem), "DisplayName")]
public class ButtonsPanelViewItem : ViewItem
{
	[Component(Order = 300)]
	private class ToolboxItem : WorkflowViewItemToolboxItem<ButtonsPanelViewItem>
	{
		private static object p3TJEBZR0rNLmdjcCecT;

		public ToolboxItem()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			U8emP4ZRt9CTUxmsiswT();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static void U8emP4ZRt9CTUxmsiswT()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}

		internal static bool elXd3LZRyiQLB9WVGgVF()
		{
			return p3TJEBZR0rNLmdjcCecT == null;
		}

		internal static ToolboxItem m8TCsVZRm36bwwZv9L97()
		{
			return (ToolboxItem)p3TJEBZR0rNLmdjcCecT;
		}
	}

	internal static ButtonsPanelViewItem j92cK05Fk8r4il1VsvS;

	public ButtonsPanelViewItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58f735bab6d046fe96f749ec2e269a96 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				Tnp8Yv5aEh8qf1o3wcJ(this, ViewItemHideMode.Modal);
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return eBNQjQ5rnoy9y10QV42(parentViewItem, this);
			case 1:
				if (parentViewItem == null)
				{
					return true;
				}
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3ab79470996d472f815915b21f45aac1 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return false;
	}

	internal static void Tnp8Yv5aEh8qf1o3wcJ(object P_0, ViewItemHideMode P_1)
	{
		((ViewItem)P_0).HideMode = P_1;
	}

	internal static bool PoGEHS5ild8RCaRKOiD()
	{
		return j92cK05Fk8r4il1VsvS == null;
	}

	internal static ButtonsPanelViewItem ltGsbf5IuUGXuN6e24O()
	{
		return j92cK05Fk8r4il1VsvS;
	}

	internal static bool eBNQjQ5rnoy9y10QV42(object P_0, object P_1)
	{
		return ((ViewItem)P_0).IsChildValid((ViewItem)P_1);
	}
}
