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

namespace EleWise.ELMA.Model.Views;

[Serializable]
[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources_StaticTextViewItem), "DisplayName")]
[DebuggerTypeProxy(typeof(DebugView))]
public class StaticTextViewItem : ViewItem, IHideEmptyViewItem, ITooltipViewItem
{
	public new sealed class DebugView
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly StaticTextViewItem viewItem;

		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		private readonly ViewItem.DebugView _viewItemDebugView;

		private static DebugView Gfc7oPCQNGxgcgu0ESfJ;

		public string Text
		{
			get
			{
				return (string)jUuCQGCQDBSuxYavb4G7(viewItem);
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
						k4O1uyCQthV3lZPg4ISg(viewItem, value);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
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

		public DebugView(StaticTextViewItem viewItem)
		{
			//Discarded unreachable code: IL_002a, IL_002f
			tM2lRgCQaHWXRsYbC7MV();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					return;
				case 2:
					this.viewItem = viewItem;
					num = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
					{
						num = 1;
					}
					break;
				default:
					_viewItemDebugView = new ViewItem.DebugView(viewItem);
					num = 2;
					break;
				}
			}
		}

		internal static void tM2lRgCQaHWXRsYbC7MV()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool LBUy7eCQ36NpVgCoKcZc()
		{
			return Gfc7oPCQNGxgcgu0ESfJ == null;
		}

		internal static DebugView vos9aBCQpoCskFOKlXDX()
		{
			return Gfc7oPCQNGxgcgu0ESfJ;
		}

		internal static object jUuCQGCQDBSuxYavb4G7(object P_0)
		{
			return ((StaticTextViewItem)P_0).Text;
		}

		internal static void k4O1uyCQthV3lZPg4ISg(object P_0, object P_1)
		{
			((StaticTextViewItem)P_0).Text = (string)P_1;
		}
	}

	[Component(Order = 400)]
	private class ToolboxItem : CommonViewItemToolboxItem<StaticTextViewItem>
	{
		internal static object WnBSh1CQwU22qVdcZ9l4;

		public ToolboxItem()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			TnxZdgCQHJTIyPnYnoRe();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static void TnxZdgCQHJTIyPnYnoRe()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool r13ZkdCQ41LQ0IWl1DpP()
		{
			return WnBSh1CQwU22qVdcZ9l4 == null;
		}

		internal static ToolboxItem sThQBSCQ6ZSWIZuqZ6bD()
		{
			return (ToolboxItem)WnBSh1CQwU22qVdcZ9l4;
		}
	}

	private static StaticTextViewItem O5kraWoeiTPqnVng21so;

	[EleWise.ELMA.Globalization.Localizable]
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[EleWise.ELMA.Model.Transformations.ChangeableProperty]
	[DefaultValue(TextColor.Default)]
	public TextColor TextColor
	{
		[CompilerGenerated]
		get
		{
			return _003CTextColor_003Ek__BackingField;
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
					_003CTextColor_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
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
	[EleWise.ELMA.Model.Transformations.ChangeableProperty]
	[DefaultValue(null)]
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
				case 1:
					_003CTooltip_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
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

	[XmlElement("HideEmpty")]
	[DefaultValue(HideEmptyEnum.Inherit)]
	[EleWise.ELMA.Model.Transformations.ChangeableProperty]
	public HideEmptyEnum HideEmptySettings
	{
		[CompilerGenerated]
		get
		{
			return _003CHideEmptySettings_003Ek__BackingField;
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
					_003CHideEmptySettings_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
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
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return hyWY0NoeKgPZ2hsJ8bKc(parentViewItem, this);
			case 1:
				if (parentViewItem == null)
				{
					return true;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
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

	public bool IsHideEmpty(RootViewItem parent = null)
	{
		//Discarded unreachable code: IL_0077
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				RootViewItem rootViewItem2;
				RootViewItem rootViewItem;
				switch (num2)
				{
				case 5:
					return HideEmptySettings == HideEmptyEnum.HideEmpty;
				default:
					rootViewItem2 = parent;
					if (rootViewItem2 == null)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto IL_00ac;
				case 3:
					rootViewItem = parent;
					if (rootViewItem == null)
					{
						num2 = 4;
						continue;
					}
					break;
				case 1:
					if (HideEmptySettings == HideEmptyEnum.Inherit)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 5;
				case 2:
					rootViewItem2 = base.Parent;
					goto IL_00ac;
				case 4:
					{
						rootViewItem = base.Parent;
						break;
					}
					IL_00ac:
					if (rootViewItem2 == null)
					{
						return false;
					}
					goto end_IL_0012;
				}
				return rootViewItem.IsHideEmpty();
				continue;
				end_IL_0012:
				break;
			}
			num = 3;
		}
	}

	public StaticTextViewItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		D35H0BoeX4MSotsW7mCe();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool mM77PboeRcGLUKo27o3i()
	{
		return O5kraWoeiTPqnVng21so == null;
	}

	internal static StaticTextViewItem tPKxgRoeqQdGIn7XGuTm()
	{
		return O5kraWoeiTPqnVng21so;
	}

	internal static bool hyWY0NoeKgPZ2hsJ8bKc(object P_0, object P_1)
	{
		return ((ViewItem)P_0).IsChildValid((ViewItem)P_1);
	}

	internal static void D35H0BoeX4MSotsW7mCe()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
