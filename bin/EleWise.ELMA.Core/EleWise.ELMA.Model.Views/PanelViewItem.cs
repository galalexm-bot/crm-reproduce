using System;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Model.Views.Toolbox;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Attributes;
using Newtonsoft.Json;

namespace EleWise.ELMA.Model.Views;

internal sealed class PanelViewItem : RootViewItem, ICustomViewItem, ICustomViewNameViewItem, IViewItem, IReactive, IViewItemLoading, IBadgeViewItem
{
	[Component(Order = 200)]
	private class ToolboxItem : CommonViewItemToolboxItem<PanelViewItem>
	{
		public override Guid Uid => new Guid("{28dfe854-f570-4838-ad44-c3d95666f014}");

		public override string Name => SR.T("Панель");

		public override string Icon => "panel";

		public ToolboxItem(ViewItemInfoService viewItemInfoService)
			: base((IViewItemInfoService)viewItemInfoService)
		{
		}

		public override string GetSlotName(Guid uid)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			string result = base.GetSlotName(uid);
			if (uid == HeaderSlotUid)
			{
				result = SR.T("Заголовок панели");
			}
			return result;
		}
	}

	public static Guid HeaderSlotUid = new Guid("385EC32C-3637-43C5-A6DB-485BDF5A58B5");

	private string _003CCaption_003Ek__BackingField;

	private bool _003CCollapsible_003Ek__BackingField;

	private TextType _003CTextType_003Ek__BackingField;

	private PanelViewItemCollapseType _003CCollapsed_003Ek__BackingField;

	private bool _003CIsExpanded_003Ek__BackingField;

	private ActionWithParam<bool> _003COnChange_003Ek__BackingField;

	private bool _003CSaveState_003Ek__BackingField;

	private PanelViewItemStyle _003CStyle_003Ek__BackingField;

	private string _003CCssClass_003Ek__BackingField;

	private PanelAsyncLoading _003CAsyncLoading_003Ek__BackingField;

	private string _003CCustomViewName_003Ek__BackingField;

	private bool _003CUseOriginalModel_003Ek__BackingField;

	private string _003CBadgeText_003Ek__BackingField;

	private bool _003CDot_003Ek__BackingField;

	private ButtonStyle _003CBadgeStyle_003Ek__BackingField;

	[DynamicProperty(false)]
	public string Caption
	{
		get
		{
			return _003CCaption_003Ek__BackingField;
		}
		set
		{
			_003CCaption_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public bool Collapsible
	{
		get
		{
			return _003CCollapsible_003Ek__BackingField;
		}
		set
		{
			_003CCollapsible_003Ek__BackingField = value;
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

	public PanelViewItemCollapseType Collapsed
	{
		get
		{
			return _003CCollapsed_003Ek__BackingField;
		}
		set
		{
			_003CCollapsed_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	[JsonIgnore]
	public bool IsExpanded
	{
		get
		{
			return _003CIsExpanded_003Ek__BackingField;
		}
		set
		{
			_003CIsExpanded_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	[JsonIgnore]
	public ActionWithParam<bool> OnChange
	{
		get
		{
			return _003COnChange_003Ek__BackingField;
		}
		set
		{
			_003COnChange_003Ek__BackingField = value;
		}
	}

	public bool SaveState
	{
		get
		{
			return _003CSaveState_003Ek__BackingField;
		}
		set
		{
			_003CSaveState_003Ek__BackingField = value;
		}
	}

	[JsonProperty(/*Could not decode attribute arguments.*/)]
	[DynamicProperty(false)]
	public PanelViewItemStyle Style
	{
		get
		{
			return _003CStyle_003Ek__BackingField;
		}
		set
		{
			_003CStyle_003Ek__BackingField = value;
		}
	}

	public string CssClass
	{
		get
		{
			return _003CCssClass_003Ek__BackingField;
		}
		set
		{
			_003CCssClass_003Ek__BackingField = value;
		}
	}

	public PanelAsyncLoading AsyncLoading
	{
		get
		{
			return _003CAsyncLoading_003Ek__BackingField;
		}
		set
		{
			_003CAsyncLoading_003Ek__BackingField = value;
		}
	}

	public string CustomViewName
	{
		get
		{
			return _003CCustomViewName_003Ek__BackingField;
		}
		set
		{
			_003CCustomViewName_003Ek__BackingField = value;
		}
	}

	public bool UseOriginalModel
	{
		get
		{
			return _003CUseOriginalModel_003Ek__BackingField;
		}
		set
		{
			_003CUseOriginalModel_003Ek__BackingField = value;
		}
	}

	ViewItemLoadingType IViewItemLoading.LoadingType
	{
		get
		{
			if (AsyncLoading != 0)
			{
				if (AsyncLoading != PanelAsyncLoading.ExpandAsyncLoading)
				{
					return ViewItemLoadingType.AsyncLoading;
				}
				return ViewItemLoadingType.LazyLoading;
			}
			return ViewItemLoadingType.SyncLoading;
		}
		set
		{
			AsyncLoading = value switch
			{
				ViewItemLoadingType.LazyLoading => PanelAsyncLoading.ExpandAsyncLoading, 
				ViewItemLoadingType.SyncLoading => PanelAsyncLoading.None, 
				_ => PanelAsyncLoading.AlwaysAsyncLoading, 
			};
		}
	}

	[DynamicProperty(false)]
	public string BadgeText
	{
		get
		{
			return _003CBadgeText_003Ek__BackingField;
		}
		set
		{
			_003CBadgeText_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public bool Dot
	{
		get
		{
			return _003CDot_003Ek__BackingField;
		}
		set
		{
			_003CDot_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public ButtonStyle BadgeStyle
	{
		get
		{
			return _003CBadgeStyle_003Ek__BackingField;
		}
		set
		{
			_003CBadgeStyle_003Ek__BackingField = value;
		}
	}

	public PanelViewItem()
	{
		Style = PanelViewItemStyle.Separator;
		CustomViewName = "";
		CssClass = "";
		AsyncLoading = PanelAsyncLoading.None;
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return true;
	}
}
