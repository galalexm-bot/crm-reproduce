using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Globalization;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Transformations;
using EleWise.ELMA.Model.Views.Toolbox;
using EleWise.ELMA.Scripts.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Views;

[Serializable]
[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources_ButtonViewItem), "DisplayName")]
public class ButtonViewItem : RootViewItem, ITooltipViewItem
{
	[Component(Order = 450)]
	private class ToolboxItem : CommonViewItemToolboxItem<ButtonViewItem>
	{
		private static object b965STCEv3HLpTpQeHF5;

		public ToolboxItem()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool TTL99YCE8INpK7j7W2BV()
		{
			return b965STCEv3HLpTpQeHF5 == null;
		}

		internal static ToolboxItem oSpuEqCEZthrJuDASXf9()
		{
			return (ToolboxItem)b965STCEv3HLpTpQeHF5;
		}
	}

	public static Guid PageComponentSlotUid;

	internal static ButtonViewItem wo3hcaoTHlygQSADUcph;

	[EleWise.ELMA.Model.Transformations.ChangeableProperty]
	[DefaultValue(null)]
	public string ActionId
	{
		[CompilerGenerated]
		get
		{
			return _003CActionId_003Ek__BackingField;
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
					_003CActionId_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
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

	[DefaultValue(null)]
	public string ActionTypeProviderId
	{
		[CompilerGenerated]
		get
		{
			return _003CActionTypeProviderId_003Ek__BackingField;
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
					_003CActionTypeProviderId_003Ek__BackingField = value;
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
	public ButtonStyle ButtonStyle
	{
		[CompilerGenerated]
		get
		{
			return _003CButtonStyle_003Ek__BackingField;
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
					_003CButtonStyle_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DefaultValue(ViewItemButtonSize.Default)]
	[EleWise.ELMA.Model.Transformations.ChangeableProperty]
	public ViewItemButtonSize ButtonSize
	{
		[CompilerGenerated]
		get
		{
			return _003CButtonSize_003Ek__BackingField;
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
					_003CButtonSize_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
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

	[DefaultValue(ViewItemButtonShape.Default)]
	[EleWise.ELMA.Model.Transformations.ChangeableProperty]
	public ViewItemButtonShape ButtonShape
	{
		[CompilerGenerated]
		get
		{
			return _003CButtonShape_003Ek__BackingField;
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
					_003CButtonShape_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DefaultValue(ButtonInactiveState.Active)]
	public ButtonInactiveState ButtonInactiveState
	{
		[CompilerGenerated]
		get
		{
			return _003CButtonInactiveState_003Ek__BackingField;
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
					_003CButtonInactiveState_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DefaultValue(ViewItemButtonType.Fill)]
	public ViewItemButtonType ButtonType
	{
		[CompilerGenerated]
		get
		{
			return _003CButtonType_003Ek__BackingField;
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
					_003CButtonType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
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

	[DefaultValue(false)]
	[EleWise.ELMA.Model.Transformations.ChangeableProperty]
	public bool DisplayAsLink
	{
		[CompilerGenerated]
		get
		{
			return _003CDisplayAsLink_003Ek__BackingField;
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
					_003CDisplayAsLink_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DefaultValue(null)]
	[EleWise.ELMA.Model.Transformations.ChangeableProperty]
	public MetadataImage Image
	{
		[CompilerGenerated]
		get
		{
			return _003CImage_003Ek__BackingField;
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
					_003CImage_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
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

	[DefaultValue(null)]
	[EleWise.ELMA.Model.Transformations.ChangeableProperty]
	public string ImageUrl
	{
		[CompilerGenerated]
		get
		{
			return _003CImageUrl_003Ek__BackingField;
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
					_003CImageUrl_003Ek__BackingField = value;
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

	[DefaultValue(false)]
	public bool IsDisabled
	{
		[CompilerGenerated]
		get
		{
			return _003CIsDisabled_003Ek__BackingField;
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
					_003CIsDisabled_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
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
	[DefaultValue(null)]
	public int? MinWidth { get; set; }

	[DefaultValue(null)]
	[EleWise.ELMA.Model.Transformations.ChangeableProperty]
	public string ScriptName
	{
		[CompilerGenerated]
		get
		{
			return _003CScriptName_003Ek__BackingField;
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
					_003CScriptName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
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
	[DefaultValue(CodeType.Server)]
	public CodeType CodeType
	{
		[CompilerGenerated]
		get
		{
			return _003CCodeType_003Ek__BackingField;
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
					_003CCodeType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
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

	[EleWise.ELMA.Globalization.Localizable]
	[DefaultValue(null)]
	[EleWise.ELMA.Model.Transformations.ChangeableProperty]
	public string Text
	{
		[CompilerGenerated]
		get
		{
			return _003CText_003Ek__BackingField;
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
					_003CText_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
					{
						num2 = 0;
					}
					break;
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
				case 0:
					return;
				case 1:
					_003CTextType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[EleWise.ELMA.Globalization.Localizable]
	[DefaultValue(null)]
	[EleWise.ELMA.Model.Transformations.ChangeableProperty]
	public string Tooltip
	{
		[CompilerGenerated]
		get
		{
			return _003CTooltip_003Ek__BackingField;
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
					_003CTooltip_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DefaultValue(false)]
	public bool ValidationRequired
	{
		[CompilerGenerated]
		get
		{
			return _003CValidationRequired_003Ek__BackingField;
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
					_003CValidationRequired_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string ImageSrc
	{
		get
		{
			int num = 1;
			int num2 = num;
			string text2 = default(string);
			string text = default(string);
			while (true)
			{
				switch (num2)
				{
				case 3:
					text2 = Convert.ToBase64String((byte[])cP9j1FoTM4qa1EhjcX9n(Image));
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
					{
						num2 = 0;
					}
					break;
				case 1:
					if (Image == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
						{
							num2 = 0;
						}
					}
					else
					{
						text = (string)tNiI5EoTymFi077IfFyj(BNpcCqoTxxVnS3rk0nPh(-867826612 ^ -867935892), RPWPnooTmUo8abQBQF7a(XYcpRhoT0HjcAR46nZ2Q(Image).ToString()));
						num2 = 3;
					}
					break;
				default:
					return null;
				case 2:
					return (string)uUSnf1oTJYm0Dr1Vhmgl(BNpcCqoTxxVnS3rk0nPh(0x638095EB ^ 0x6382C8DB), text, text2);
				}
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
			case 1:
				if (parentViewItem != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
					{
						num2 = 0;
					}
					break;
				}
				return true;
			default:
				return parentViewItem.IsChildValid(this);
			}
		}
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		//Discarded unreachable code: IL_0039, IL_0048, IL_0070, IL_007f
		int num = 3;
		int num2 = num;
		SlotViewItem slotViewItem = default(SlotViewItem);
		while (true)
		{
			switch (num2)
			{
			case 3:
				if ((slotViewItem = childViewItem as SlotViewItem) != null)
				{
					num2 = 2;
					break;
				}
				goto default;
			case 2:
				if (!(TDjSIooT9rpEi34Ii2jd(slotViewItem) == PageComponentSlotUid))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 5;
			case 4:
				return true;
			case 1:
				return childViewItem is ButtonViewItem;
			case 5:
				return !base.Items.Any((ViewItem item) => item is SlotViewItem);
			default:
				if (!(childViewItem is DynamicListViewItem))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 4;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeMinWidth()
	{
		int num = 1;
		int num2 = num;
		int? minWidth = default(int?);
		while (true)
		{
			switch (num2)
			{
			default:
				return minWidth.HasValue;
			case 1:
				minWidth = MinWidth;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public ButtonViewItem()
	{
		//Discarded unreachable code: IL_0036, IL_003b
		TcIu7goTdMcbcMQtPmxp();
		CodeType = CodeType.Server;
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static ButtonViewItem()
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
				PageComponentSlotUid = new Guid((string)BNpcCqoTxxVnS3rk0nPh(-629844702 ^ -629733256));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				SingletonReader.JJCZtPuTvSt();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static bool b4G0vDoTA5coZr7j87bk()
	{
		return wo3hcaoTHlygQSADUcph == null;
	}

	internal static ButtonViewItem JkOXwFoT7edeDqQ0tggo()
	{
		return wo3hcaoTHlygQSADUcph;
	}

	internal static object BNpcCqoTxxVnS3rk0nPh(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static ImageFormatType XYcpRhoT0HjcAR46nZ2Q(object P_0)
	{
		return ((MetadataImage)P_0).Format;
	}

	internal static object RPWPnooTmUo8abQBQF7a(object P_0)
	{
		return ((string)P_0).ToLower();
	}

	internal static object tNiI5EoTymFi077IfFyj(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object cP9j1FoTM4qa1EhjcX9n(object P_0)
	{
		return ((MetadataImage)P_0).Data;
	}

	internal static object uUSnf1oTJYm0Dr1Vhmgl(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static Guid TDjSIooT9rpEi34Ii2jd(object P_0)
	{
		return ((SlotViewItem)P_0).PlaceholderUid;
	}

	internal static void TcIu7goTdMcbcMQtPmxp()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
