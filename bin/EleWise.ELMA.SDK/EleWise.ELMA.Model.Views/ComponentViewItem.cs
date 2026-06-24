using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Model.Transformations;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views;

[Serializable]
public class ComponentViewItem : RootViewItem, IThemeContainerViewItem, IViewItemLoading, IFocusable
{
	private static ComponentViewItem J8o9eFoXxdbrN7INBOHn;

	public Guid HeaderUid
	{
		[CompilerGenerated]
		get
		{
			return _003CHeaderUid_003Ek__BackingField;
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
					_003CHeaderUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DefaultValue(ViewItemLoadingType.SyncLoading)]
	public ViewItemLoadingType LoadingType
	{
		[CompilerGenerated]
		get
		{
			return _003CLoadingType_003Ek__BackingField;
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
					_003CLoadingType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
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

	[DefaultValue(ViewItemTheme.Inherit)]
	[EleWise.ELMA.Model.Transformations.ChangeableProperty]
	public ViewItemTheme Theme
	{
		[CompilerGenerated]
		get
		{
			return _003CTheme_003Ek__BackingField;
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
					_003CTheme_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DefaultValue(FocusableType.None)]
	public FocusableType FocusableType
	{
		[CompilerGenerated]
		get
		{
			return _003CFocusableType_003Ek__BackingField;
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
					_003CFocusableType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
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

	[DefaultValue(FormViewType.Default)]
	public FormViewType FormViewType
	{
		[CompilerGenerated]
		get
		{
			return _003CFormViewType_003Ek__BackingField;
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
					_003CFormViewType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
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
		return true;
	}

	public ComponentViewItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Jxg7myoXyo6YLtj8Dy1s();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool eTWBCdoX0AMDn0QTIwgt()
	{
		return J8o9eFoXxdbrN7INBOHn == null;
	}

	internal static ComponentViewItem D1w1XwoXmnhPooeRX1Zd()
	{
		return J8o9eFoXxdbrN7INBOHn;
	}

	internal static void Jxg7myoXyo6YLtj8Dy1s()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
