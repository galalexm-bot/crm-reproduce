using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Globalization;
using EleWise.ELMA.Model.Transformations;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views;

[Serializable]
public class BadgeViewItem : RootViewItem, IBadgeViewItem
{
	private static BadgeViewItem jOo8pyoiknpVs8yoJYa7;

	[EleWise.ELMA.Globalization.Localizable]
	[EleWise.ELMA.Model.Transformations.ChangeableProperty]
	[DefaultValue("")]
	public string BadgeText
	{
		[CompilerGenerated]
		get
		{
			return _003CBadgeText_003Ek__BackingField;
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
					_003CBadgeText_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[EleWise.ELMA.Model.Transformations.ChangeableProperty]
	[DefaultValue(false)]
	public bool Dot
	{
		[CompilerGenerated]
		get
		{
			return _003CDot_003Ek__BackingField;
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
					_003CDot_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
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

	[DefaultValue(ButtonStyle.Default)]
	[EleWise.ELMA.Model.Transformations.ChangeableProperty]
	public ButtonStyle BadgeStyle
	{
		[CompilerGenerated]
		get
		{
			return _003CBadgeStyle_003Ek__BackingField;
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
					_003CBadgeStyle_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
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

	public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
	{
		return true;
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		//Discarded unreachable code: IL_003d, IL_00eb, IL_00fa
		int num = 4;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					if (!(childViewItem is PanelViewItem))
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 1;
				case 4:
					if (base.Items != null)
					{
						goto end_IL_0012;
					}
					goto case 5;
				case 2:
					return !(childViewItem is TabLayoutViewItem);
				case 1:
					return false;
				default:
					return false;
				case 5:
					if (childViewItem is ContentNavigationViewItem)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 6;
				case 3:
					if (M8lt0koi25x5VVB9gqye(base.Items) >= 1)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 5;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 3;
		}
	}

	public BadgeViewItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		a9WFg7oiedyrg5EBMuM7();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool yy5L25oinevLSfLMBeik()
	{
		return jOo8pyoiknpVs8yoJYa7 == null;
	}

	internal static BadgeViewItem TMI5IjoiOXnadMRt8xQk()
	{
		return jOo8pyoiknpVs8yoJYa7;
	}

	internal static int M8lt0koi25x5VVB9gqye(object P_0)
	{
		return ((EventedList<ViewItem>)P_0).Count;
	}

	internal static void a9WFg7oiedyrg5EBMuM7()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
