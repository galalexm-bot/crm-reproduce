using System;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views;

[Serializable]
public class DndPreviewViewItem : RootViewItem
{
	internal static DndPreviewViewItem GJouPVoSSHo45L1r1dtY;

	private int Type
	{
		[CompilerGenerated]
		get
		{
			return _003CType_003Ek__BackingField;
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
					_003CType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	private int Width
	{
		[CompilerGenerated]
		get
		{
			return _003CWidth_003Ek__BackingField;
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
					_003CWidth_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	private int Height
	{
		[CompilerGenerated]
		get
		{
			return _003CHeight_003Ek__BackingField;
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
					_003CHeight_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
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

	private string BackgroundColor
	{
		[CompilerGenerated]
		get
		{
			return _003CBackgroundColor_003Ek__BackingField;
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
					_003CBackgroundColor_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	private string StrokeColor
	{
		[CompilerGenerated]
		get
		{
			return _003CStrokeColor_003Ek__BackingField;
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
					_003CStrokeColor_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
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

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return false;
	}

	public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
	{
		//Discarded unreachable code: IL_0056, IL_0065
		int num = 3;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (paLwPloSqwqvx8N7WimZ(parentViewItem) == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto default;
				case 3:
					if (!(parentViewItem is SlotViewItem))
					{
						break;
					}
					goto end_IL_0012;
				default:
					return parentViewItem.Parent is DndViewItem;
				case 1:
					break;
				}
				return false;
				continue;
				end_IL_0012:
				break;
			}
			num = 2;
		}
	}

	public DndPreviewViewItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		fdQGuVoSKnnq1qPyIkfI();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool NKOdd4oSiWxrFCE05Kme()
	{
		return GJouPVoSSHo45L1r1dtY == null;
	}

	internal static DndPreviewViewItem HPpAHPoSRlrUXrXkBh29()
	{
		return GJouPVoSSHo45L1r1dtY;
	}

	internal static object paLwPloSqwqvx8N7WimZ(object P_0)
	{
		return ((ViewItem)P_0).Parent;
	}

	internal static void fdQGuVoSKnnq1qPyIkfI()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
