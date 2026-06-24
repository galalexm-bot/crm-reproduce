using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Globalization;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Transformations;
using EleWise.ELMA.Model.Views.Toolbox;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Views;

[Serializable]
[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources_PanelViewItem), "DisplayName")]
[DebuggerTypeProxy(typeof(DebugView))]
public class PanelViewItem : RootViewItem, ICustomViewItem, ICustomViewNameViewItem, IViewItemLoading, IBadgeViewItem
{
	public new sealed class DebugView
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly PanelViewItem viewItem;

		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		private readonly RootViewItem.DebugView _rootViewItemDebugView;

		private static DebugView SkkPndCQlvCYZmpAK7n4;

		public string Caption
		{
			get
			{
				return (string)FBNWKPCQjlyTBDlbl6Ow(viewItem);
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
						ToogEPCQYgecQ4pfokZ4(viewItem, value);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public bool Collapsible
		{
			get
			{
				return viewItem.Collapsible;
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
						i2R0XvCQL1D5qYTLmksT(viewItem, value);
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

		public PanelViewItemCollapseType DefaultCollapseState
		{
			get
			{
				return f3QGuqCQUpvWfPo9DajQ(viewItem);
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
						Y2XuScCQs4AEmBN8f2mq(viewItem, value);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public PanelAsyncLoading AsyncLoading
		{
			get
			{
				return viewItem.AsyncLoading;
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
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
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

		public string CustomViewName
		{
			get
			{
				return (string)tcUto5CQcLmEy0mmU3p5(viewItem);
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
						GngtWLCQz9ni5oPPEeig(viewItem, value);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public bool UseOriginalModel
		{
			get
			{
				return viewItem.UseOriginalModel;
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
						dsY6ErCCFHiBKFKWsCc1(viewItem, value);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
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

		public DebugView(PanelViewItem viewItem)
		{
			//Discarded unreachable code: IL_002a, IL_002f
			AuCZdvCQ5MjqINYONuM4();
			base._002Ector();
			int num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
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
					_rootViewItemDebugView = new RootViewItem.DebugView(viewItem);
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
					{
						num = 0;
					}
					break;
				default:
					this.viewItem = viewItem;
					num = 2;
					break;
				}
			}
		}

		internal static void AuCZdvCQ5MjqINYONuM4()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool CTTHguCQrjilOqH6ASDw()
		{
			return SkkPndCQlvCYZmpAK7n4 == null;
		}

		internal static DebugView lFv8PECQgbNwXu1ubsKo()
		{
			return SkkPndCQlvCYZmpAK7n4;
		}

		internal static object FBNWKPCQjlyTBDlbl6Ow(object P_0)
		{
			return ((PanelViewItem)P_0).Caption;
		}

		internal static void ToogEPCQYgecQ4pfokZ4(object P_0, object P_1)
		{
			((PanelViewItem)P_0).Caption = (string)P_1;
		}

		internal static void i2R0XvCQL1D5qYTLmksT(object P_0, bool value)
		{
			((PanelViewItem)P_0).Collapsible = value;
		}

		internal static PanelViewItemCollapseType f3QGuqCQUpvWfPo9DajQ(object P_0)
		{
			return ((PanelViewItem)P_0).DefaultCollapseState;
		}

		internal static void Y2XuScCQs4AEmBN8f2mq(object P_0, PanelViewItemCollapseType value)
		{
			((PanelViewItem)P_0).DefaultCollapseState = value;
		}

		internal static object tcUto5CQcLmEy0mmU3p5(object P_0)
		{
			return ((PanelViewItem)P_0).CustomViewName;
		}

		internal static void GngtWLCQz9ni5oPPEeig(object P_0, object P_1)
		{
			((PanelViewItem)P_0).CustomViewName = (string)P_1;
		}

		internal static void dsY6ErCCFHiBKFKWsCc1(object P_0, bool value)
		{
			((PanelViewItem)P_0).UseOriginalModel = value;
		}
	}

	[Component(Order = 200)]
	private class ToolboxItem : CommonViewItemToolboxItem<PanelViewItem>
	{
		internal static object FenC0RCCBiAn0c2epL48;

		public override string Name => (string)WVA3J4CChk5jeOUry2bn(d5FjmrCCbfW7yu14IDZj(-210725949 ^ -210571263));

		public ToolboxItem()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			oMn2xFCCGhtt6FnDOU1x();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static object d5FjmrCCbfW7yu14IDZj(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object WVA3J4CChk5jeOUry2bn(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static bool OUx5JyCCWOQxGdik5GDt()
		{
			return FenC0RCCBiAn0c2epL48 == null;
		}

		internal static ToolboxItem rrGVTMCCocVDSh10se8j()
		{
			return (ToolboxItem)FenC0RCCBiAn0c2epL48;
		}

		internal static void oMn2xFCCGhtt6FnDOU1x()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	internal static PanelViewItem GwkuG8oPOdZINpgkPj1u;

	[EleWise.ELMA.Globalization.Localizable]
	[EleWise.ELMA.Model.Transformations.ChangeableProperty]
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
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
	public virtual bool Collapsible
	{
		[CompilerGenerated]
		get
		{
			return _003CCollapsible_003Ek__BackingField;
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
					_003CCollapsible_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DefaultValue(PanelViewItemCollapseType.DefaultExpanded)]
	[XmlElement("Collapsed")]
	[EleWise.ELMA.Model.Transformations.ChangeableProperty]
	public virtual PanelViewItemCollapseType DefaultCollapseState
	{
		[CompilerGenerated]
		get
		{
			return _003CDefaultCollapseState_003Ek__BackingField;
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
					_003CDefaultCollapseState_003Ek__BackingField = value;
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

	[EleWise.ELMA.Model.Transformations.ChangeableProperty]
	[DefaultValue(false)]
	public virtual bool SaveState
	{
		[CompilerGenerated]
		get
		{
			return _003CSaveState_003Ek__BackingField;
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
					_003CSaveState_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	private bool IsExpanded
	{
		[CompilerGenerated]
		get
		{
			return _003CIsExpanded_003Ek__BackingField;
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
					_003CIsExpanded_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
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
	[DefaultValue(PanelViewItemStyle.GrayHeaderNoBorder)]
	public virtual PanelViewItemStyle Style
	{
		[CompilerGenerated]
		get
		{
			return _003CStyle_003Ek__BackingField;
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
					_003CStyle_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
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
	[DefaultValue(TextType.Default)]
	public TextType TextType
	{
		[CompilerGenerated]
		get
		{
			return _003CTextType_003Ek__BackingField;
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
					_003CTextType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
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
	[DefaultValue("")]
	public virtual string CssClass
	{
		[CompilerGenerated]
		get
		{
			return _003CCssClass_003Ek__BackingField;
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
					_003CCssClass_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
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

	[DefaultValue(PanelAsyncLoading.None)]
	[EleWise.ELMA.Model.Transformations.ChangeableProperty]
	public PanelAsyncLoading AsyncLoading
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
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
	[DefaultValue("")]
	public virtual string CustomViewName
	{
		[CompilerGenerated]
		get
		{
			return _003CCustomViewName_003Ek__BackingField;
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
					_003CCustomViewName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DefaultValue(false)]
	[EleWise.ELMA.Model.Transformations.ChangeableProperty]
	public virtual bool UseOriginalModel
	{
		[CompilerGenerated]
		get
		{
			return _003CUseOriginalModel_003Ek__BackingField;
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
					_003CUseOriginalModel_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	ViewItemLoadingType IViewItemLoading.LoadingType
	{
		get
		{
			//Discarded unreachable code: IL_0057, IL_0066
			int num = 3;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (AsyncLoading != PanelAsyncLoading.ExpandAsyncLoading)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
						{
							num2 = 0;
						}
						break;
					}
					return ViewItemLoadingType.LazyLoading;
				case 3:
					if (AsyncLoading == PanelAsyncLoading.None)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto default;
				case 1:
					return ViewItemLoadingType.AsyncLoading;
				case 2:
					return ViewItemLoadingType.SyncLoading;
				}
			}
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
					AsyncLoading = value switch
					{
						ViewItemLoadingType.LazyLoading => PanelAsyncLoading.ExpandAsyncLoading, 
						ViewItemLoadingType.SyncLoading => PanelAsyncLoading.None, 
						_ => PanelAsyncLoading.AlwaysAsyncLoading, 
					};
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
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
				case 1:
					_003CBadgeText_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
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
				case 0:
					return;
				case 1:
					_003CDot_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
					{
						num2 = 0;
					}
					break;
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public PanelViewItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 2:
				CssClass = "";
				num = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
				{
					num = 2;
				}
				break;
			case 4:
				AsyncLoading = PanelAsyncLoading.None;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			case 1:
				IByySXoPPYlGOWxiMBOh(this, PanelViewItemStyle.GrayHeaderNoBorder);
				num = 3;
				break;
			case 3:
				v1ojpdoP1qfULY7GFikK(this, "");
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
				{
					num = 2;
				}
				break;
			}
		}
	}

	public override void InitNew(ViewItem parent)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				Style = PanelViewItemStyle.Separator;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 2:
				base.InitNew(parent);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
	{
		//Discarded unreachable code: IL_0037, IL_0046
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return NPFGEPoPNwNxn11rFY6a(parentViewItem, this);
			default:
				return true;
			case 1:
				if (parentViewItem == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return true;
	}

	internal static void IByySXoPPYlGOWxiMBOh(object P_0, PanelViewItemStyle value)
	{
		((PanelViewItem)P_0).Style = value;
	}

	internal static void v1ojpdoP1qfULY7GFikK(object P_0, object P_1)
	{
		((PanelViewItem)P_0).CustomViewName = (string)P_1;
	}

	internal static bool SVkbIooP2MQBJiIsOv34()
	{
		return GwkuG8oPOdZINpgkPj1u == null;
	}

	internal static PanelViewItem IZdUEboPeCP6tttvF5NF()
	{
		return GwkuG8oPOdZINpgkPj1u;
	}

	internal static bool NPFGEPoPNwNxn11rFY6a(object P_0, object P_1)
	{
		return ((ViewItem)P_0).IsChildValid((ViewItem)P_1);
	}
}
