using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Model.Views.Toolbox;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Views.Toolbar;
using EleWise.ELMA.Scripts.Models;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.Model.Views;

internal sealed class ButtonViewItem : RootViewItem, ITooltipViewItem, IViewItem, IReactive
{
	[Component(Order = 450)]
	private class ToolboxItem : CommonViewItemToolboxItem<ButtonViewItem>
	{
		public override Guid Uid => new Guid("{51d9aaf6-7403-4506-8513-9382f44117f0}");

		public override string Name => SR.T("Кнопка");

		public override string Icon => "button";

		public ToolboxItem(ViewItemInfoService viewItemInfoService)
			: base((IViewItemInfoService)viewItemInfoService)
		{
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<ViewItem, bool> _003C_003E9__75_0;

		internal bool _003CIsChildValid_003Eb__75_0(ViewItem item)
		{
			return item is SlotViewItem;
		}
	}

	public static Guid PageComponentSlotUid = new Guid("{98F5DE54-7064-4F26-AB7D-5612FBFF424D}");

	private string _003CActionId_003Ek__BackingField;

	private string _003CActionTypeProviderId_003Ek__BackingField;

	private bool _003CDisplayAsLink_003Ek__BackingField;

	private string _003CImageUrl_003Ek__BackingField;

	private bool _003CIsDisabled_003Ek__BackingField;

	private int? _003CMinWidth_003Ek__BackingField;

	private string _003CScriptName_003Ek__BackingField;

	private CodeType _003CCodeType_003Ek__BackingField;

	private string _003CText_003Ek__BackingField;

	private string _003CTooltip_003Ek__BackingField;

	private TextType _003CTextType_003Ek__BackingField;

	private ButtonStyle _003CButtonStyle_003Ek__BackingField;

	private ViewItemButtonSize _003CButtonSize_003Ek__BackingField;

	private ViewItemButtonShape _003CButtonShape_003Ek__BackingField;

	private ViewItemButtonType _003CButtonType_003Ek__BackingField;

	private bool _003CValidationRequired_003Ek__BackingField;

	private ButtonInactiveState _003CButtonInactiveState_003Ek__BackingField;

	private string _003CClickCode_003Ek__BackingField;

	public override bool IsHideable => true;

	public string ActionId
	{
		get
		{
			return _003CActionId_003Ek__BackingField;
		}
		set
		{
			_003CActionId_003Ek__BackingField = value;
		}
	}

	public string ActionTypeProviderId
	{
		get
		{
			return _003CActionTypeProviderId_003Ek__BackingField;
		}
		set
		{
			_003CActionTypeProviderId_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public bool DisplayAsLink
	{
		get
		{
			return _003CDisplayAsLink_003Ek__BackingField;
		}
		set
		{
			_003CDisplayAsLink_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public string ImageUrl
	{
		get
		{
			return _003CImageUrl_003Ek__BackingField;
		}
		set
		{
			_003CImageUrl_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public bool IsDisabled
	{
		get
		{
			return _003CIsDisabled_003Ek__BackingField;
		}
		set
		{
			_003CIsDisabled_003Ek__BackingField = value;
		}
	}

	public int? MinWidth
	{
		get
		{
			return _003CMinWidth_003Ek__BackingField;
		}
		set
		{
			_003CMinWidth_003Ek__BackingField = value;
		}
	}

	public string ScriptName
	{
		get
		{
			return _003CScriptName_003Ek__BackingField;
		}
		set
		{
			_003CScriptName_003Ek__BackingField = value;
		}
	}

	public CodeType CodeType
	{
		get
		{
			return _003CCodeType_003Ek__BackingField;
		}
		set
		{
			_003CCodeType_003Ek__BackingField = value;
		}
	}

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
	public ButtonStyle ButtonStyle
	{
		get
		{
			return _003CButtonStyle_003Ek__BackingField;
		}
		set
		{
			_003CButtonStyle_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public ViewItemButtonSize ButtonSize
	{
		get
		{
			return _003CButtonSize_003Ek__BackingField;
		}
		set
		{
			_003CButtonSize_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public ViewItemButtonShape ButtonShape
	{
		get
		{
			return _003CButtonShape_003Ek__BackingField;
		}
		set
		{
			_003CButtonShape_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public ViewItemButtonType ButtonType
	{
		get
		{
			return _003CButtonType_003Ek__BackingField;
		}
		set
		{
			_003CButtonType_003Ek__BackingField = value;
		}
	}

	public bool ValidationRequired
	{
		get
		{
			return _003CValidationRequired_003Ek__BackingField;
		}
		set
		{
			_003CValidationRequired_003Ek__BackingField = value;
		}
	}

	public ButtonInactiveState ButtonInactiveState
	{
		get
		{
			return _003CButtonInactiveState_003Ek__BackingField;
		}
		set
		{
			_003CButtonInactiveState_003Ek__BackingField = value;
		}
	}

	public override bool ReadOnlyEnabled => false;

	internal string ClickCode
	{
		get
		{
			return _003CClickCode_003Ek__BackingField;
		}
		set
		{
			_003CClickCode_003Ek__BackingField = value;
		}
	}

	public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
	{
		return parentViewItem?.IsChildValid(this) ?? true;
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		if (childViewItem is SlotViewItem slotViewItem && slotViewItem.PlaceholderUid == PageComponentSlotUid)
		{
			return !Enumerable.Any<ViewItem>((System.Collections.Generic.IEnumerable<ViewItem>)base.Items, (Func<ViewItem, bool>)((ViewItem item) => item is SlotViewItem));
		}
		if (childViewItem is DynamicListViewItem)
		{
			return true;
		}
		if (!(childViewItem is ButtonViewItem))
		{
			return childViewItem is SeparatorViewItem;
		}
		return true;
	}

	[OnSerialized]
	public void OnSerializedMethod(UnknownObjectWrapper raw)
	{
		if (base.Root is ToolbarViewItem)
		{
			raw.Value.SetAndCreatePlainPropertyValue("$type", "EleWise.ELMA.Model.Views.Toolbar.Button");
			raw.Value.SetAndCreatePlainPropertyValue("Visible", (!Hide).ToString());
		}
	}

	[OnDeserialized]
	public void OnDeserializedMethod(object raw)
	{
		bool flag = default(bool);
		if (base.Root is ToolbarViewItem && bool.TryParse(raw.GetPlainPropertyValue("Visible")?.ToString(), ref flag))
		{
			Hide = !flag;
		}
	}
}
