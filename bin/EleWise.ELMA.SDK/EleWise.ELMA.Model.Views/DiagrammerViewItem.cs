using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views;

[Serializable]
public class DiagrammerViewItem : RootViewItem
{
	internal static DiagrammerViewItem suHR2Soi3b5bRW4EhmDW;

	[DefaultValue(false)]
	public bool ReadOnlyDiagram
	{
		[CompilerGenerated]
		get
		{
			return _003CReadOnlyDiagram_003Ek__BackingField;
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
					_003CReadOnlyDiagram_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DefaultValue(false)]
	public bool DisplayFullscreen
	{
		[CompilerGenerated]
		get
		{
			return _003CDisplayFullscreen_003Ek__BackingField;
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
					_003CDisplayFullscreen_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DefaultValue(false)]
	public bool Fullscreen
	{
		[CompilerGenerated]
		get
		{
			return _003CFullscreen_003Ek__BackingField;
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
					_003CFullscreen_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DefaultValue(false)]
	public bool DisplayGrid
	{
		[CompilerGenerated]
		get
		{
			return _003CDisplayGrid_003Ek__BackingField;
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
					_003CDisplayGrid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return childViewItem is DynamicListViewItem;
	}

	public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
	{
		return MU1Mq4oiDmouNdp69el4(parentViewItem, this);
	}

	public DiagrammerViewItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		tkqjyNoit2ROfiroRMRr();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool qYGa2uoipR1TReJW07C2()
	{
		return suHR2Soi3b5bRW4EhmDW == null;
	}

	internal static DiagrammerViewItem IaojThoiaqAXRk5xSXPo()
	{
		return suHR2Soi3b5bRW4EhmDW;
	}

	internal static bool MU1Mq4oiDmouNdp69el4(object P_0, object P_1)
	{
		return ((ViewItem)P_0).IsChildValid((ViewItem)P_1);
	}

	internal static void tkqjyNoit2ROfiroRMRr()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
