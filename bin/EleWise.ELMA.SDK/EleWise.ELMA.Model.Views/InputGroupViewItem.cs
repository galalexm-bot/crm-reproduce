using System;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views;

[Serializable]
public sealed class InputGroupViewItem : RootViewItem, IContainerViewItem
{
	private static InputGroupViewItem G4KTXjoSz9gsWIKEYnUt;

	public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
	{
		return parentViewItem.IsChildValid(this);
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		//Discarded unreachable code: IL_0067, IL_0076, IL_00dc
		int num = 5;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 4:
				if (!(childViewItem is PropertyValueViewItem))
				{
					num2 = 2;
					break;
				}
				goto case 1;
			case 6:
				if (childViewItem is PopoverViewItem)
				{
					num2 = 3;
					break;
				}
				goto default;
			default:
				return childViewItem is BadgeViewItem;
			case 1:
			case 3:
				return true;
			case 2:
				if (childViewItem is TreeSelectViewItem)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 6;
			case 5:
				if (!(childViewItem is ButtonViewItem))
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 1;
			}
		}
	}

	public InputGroupViewItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		WvvLHuoiWCcKFmPQ63gF();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool SEek4eoiFOwsjX9lloRI()
	{
		return G4KTXjoSz9gsWIKEYnUt == null;
	}

	internal static InputGroupViewItem zKcRwfoiByfyGOFlTZCs()
	{
		return G4KTXjoSz9gsWIKEYnUt;
	}

	internal static void WvvLHuoiWCcKFmPQ63gF()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
