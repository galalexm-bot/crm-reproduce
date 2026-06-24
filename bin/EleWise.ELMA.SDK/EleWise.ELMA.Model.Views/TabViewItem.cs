using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Globalization;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Transformations;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views;

[Serializable]
[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources_TabViewItem), "DisplayName")]
[DebuggerTypeProxy(typeof(DebugView))]
public class TabViewItem : RootViewItem, ILayoutItemViewItem, IContainerViewItem, IViewItemLoading, IBadgeViewItem
{
	public new sealed class DebugView
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly TabViewItem viewItem;

		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		private readonly RootViewItem.DebugView _rootViewItemDebugView;

		private static DebugView EUMhTWCZfM77BET9bdcm;

		public string Caption
		{
			get
			{
				return (string)J0jAPoCZvWvnsjSNh5le(viewItem);
			}
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
						PDYU51CZ8yMZGPbBRUCs(viewItem, value);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
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

		public string CaptionViewName
		{
			get
			{
				return (string)PjijlACZZjuIja5WPhHB(viewItem);
			}
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
						GLr4L2CZuwNT1B0Wv9ea(viewItem, value);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public bool CaptionUseOriginalModel
		{
			get
			{
				return viewItem.CaptionUseOriginalModel;
			}
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
						eooca9CZIPLqSXgXc6vq(viewItem, value);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public bool AsyncLoading
		{
			get
			{
				return gfSQ1xCZVe6EQdCUwiVg(viewItem);
			}
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
						viewItem.AsyncLoading = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
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

		public DebugView(TabViewItem viewItem)
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 2:
					return;
				case 1:
					this.viewItem = viewItem;
					num = 2;
					continue;
				}
				_rootViewItemDebugView = new RootViewItem.DebugView(viewItem);
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
				{
					num = 1;
				}
			}
		}

		internal static bool WIgSyjCZQG4i2e20IuYy()
		{
			return EUMhTWCZfM77BET9bdcm == null;
		}

		internal static DebugView nmocOnCZCAILm1n19mFx()
		{
			return EUMhTWCZfM77BET9bdcm;
		}

		internal static object J0jAPoCZvWvnsjSNh5le(object P_0)
		{
			return ((TabViewItem)P_0).Caption;
		}

		internal static void PDYU51CZ8yMZGPbBRUCs(object P_0, object P_1)
		{
			((TabViewItem)P_0).Caption = (string)P_1;
		}

		internal static object PjijlACZZjuIja5WPhHB(object P_0)
		{
			return ((TabViewItem)P_0).CaptionViewName;
		}

		internal static void GLr4L2CZuwNT1B0Wv9ea(object P_0, object P_1)
		{
			((TabViewItem)P_0).CaptionViewName = (string)P_1;
		}

		internal static void eooca9CZIPLqSXgXc6vq(object P_0, bool value)
		{
			((TabViewItem)P_0).CaptionUseOriginalModel = value;
		}

		internal static bool gfSQ1xCZVe6EQdCUwiVg(object P_0)
		{
			return ((TabViewItem)P_0).AsyncLoading;
		}
	}

	private static TabViewItem cGthGFop2ShPXAedLoVP;

	[EleWise.ELMA.Model.Transformations.ChangeableProperty]
	[EleWise.ELMA.Globalization.Localizable]
	public virtual string Caption
	{
		[CompilerGenerated]
		get
		{
			return _003CCaption_003Ek__BackingField;
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
					_003CCaption_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[EleWise.ELMA.Model.Transformations.ChangeableProperty]
	[DefaultValue("")]
	public virtual string CaptionViewName
	{
		[CompilerGenerated]
		get
		{
			return _003CCaptionViewName_003Ek__BackingField;
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
					_003CCaptionViewName_003Ek__BackingField = value;
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

	[EleWise.ELMA.Model.Transformations.ChangeableProperty]
	[DefaultValue(false)]
	public virtual bool CaptionUseOriginalModel
	{
		[CompilerGenerated]
		get
		{
			return _003CCaptionUseOriginalModel_003Ek__BackingField;
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
					_003CCaptionUseOriginalModel_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
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

	[EleWise.ELMA.Model.Transformations.ChangeableProperty]
	[DefaultValue(true)]
	public bool AsyncLoading
	{
		[CompilerGenerated]
		get
		{
			return _003CAsyncLoading_003Ek__BackingField;
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
					_003CAsyncLoading_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
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

	[EleWise.ELMA.Model.Transformations.ChangeableProperty]
	[DefaultValue(false)]
	public bool FixedHeight
	{
		[CompilerGenerated]
		get
		{
			return _003CFixedHeight_003Ek__BackingField;
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
					_003CFixedHeight_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DefaultValue(ViewItemLoadingType.AsyncLoading)]
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
				case 0:
					return;
				case 1:
					_003CLoadingType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DefaultValue("")]
	[EleWise.ELMA.Model.Transformations.ChangeableProperty]
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
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
				case 0:
					return;
				case 1:
					_003CBadgeStyle_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public TabViewItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
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
				Icd4qoop1FNYKAO0Tstd(this, "");
				num = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
				{
					num = 1;
				}
				break;
			case 2:
				LoadingType = ViewItemLoadingType.AsyncLoading;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
				{
					num = 0;
				}
				break;
			case 3:
				AsyncLoading = true;
				num = 2;
				break;
			case 0:
				return;
			}
		}
	}

	public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
	{
		//Discarded unreachable code: IL_0039, IL_0048
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return parentViewItem is TabLayoutViewItem;
			case 1:
				return true;
			case 2:
				if (parentViewItem == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			}
		}
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return true;
	}

	internal static void Icd4qoop1FNYKAO0Tstd(object P_0, object P_1)
	{
		((TabViewItem)P_0).CaptionViewName = (string)P_1;
	}

	internal static bool uKduKFope4V0HEZiMqFZ()
	{
		return cGthGFop2ShPXAedLoVP == null;
	}

	internal static TabViewItem oQgM7LopP5T5X17G9kIG()
	{
		return cGthGFop2ShPXAedLoVP;
	}
}
