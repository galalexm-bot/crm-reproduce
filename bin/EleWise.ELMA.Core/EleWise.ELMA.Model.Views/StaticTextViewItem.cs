using System;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Model.Views.Toolbox;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Model.Views;

internal sealed class StaticTextViewItem : ViewItem, ITooltipViewItem, IViewItem, IReactive, IHideEmptyViewItem
{
	[Component(Order = 400)]
	private class ToolboxItem : CommonViewItemToolboxItem<StaticTextViewItem>
	{
		public override Guid Uid => new Guid("{22E07CA7-7182-41D4-9C1E-1E7FB2D85C76}");

		public override string Name => SR.T("Текст");

		public override string Icon => "text";

		public ToolboxItem(ViewItemInfoService viewItemInfoService)
			: base((IViewItemInfoService)viewItemInfoService)
		{
		}
	}

	private string _003CText_003Ek__BackingField;

	private TextType _003CTextType_003Ek__BackingField;

	private TextColor _003CTextColor_003Ek__BackingField;

	private HideEmptyEnum _003CHideEmptySettings_003Ek__BackingField;

	private HideEmptyEnum _003CHideEmpty_003Ek__BackingField;

	private string _003CTooltip_003Ek__BackingField;

	[DynamicProperty(false)]
	public string Text
	{
		get
		{
			return _003CText_003Ek__BackingField;
		}
		set
		{
			_003CText_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public TextType TextType
	{
		get
		{
			return _003CTextType_003Ek__BackingField;
		}
		set
		{
			_003CTextType_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public TextColor TextColor
	{
		get
		{
			return _003CTextColor_003Ek__BackingField;
		}
		set
		{
			_003CTextColor_003Ek__BackingField = value;
		}
	}

	public HideEmptyEnum HideEmptySettings
	{
		get
		{
			return _003CHideEmptySettings_003Ek__BackingField;
		}
		set
		{
			_003CHideEmptySettings_003Ek__BackingField = value;
		}
	}

	public HideEmptyEnum HideEmpty
	{
		get
		{
			return _003CHideEmpty_003Ek__BackingField;
		}
		set
		{
			_003CHideEmpty_003Ek__BackingField = value;
		}
	}

	public bool IsHideable => true;

	[DynamicProperty(false)]
	public string Tooltip
	{
		get
		{
			return _003CTooltip_003Ek__BackingField;
		}
		set
		{
			_003CTooltip_003Ek__BackingField = value;
		}
	}
}
