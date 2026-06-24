using System;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Attributes;
using Newtonsoft.Json;

namespace EleWise.ELMA.Model.Views;

public sealed class ComponentViewItem : RootViewItem, IThemeContainerViewItem, IViewItemLoading, IViewItem, IReactive, IFocusable
{
	private Guid _003CHeaderUid_003Ek__BackingField;

	private ViewItemLoadingType _003CLoadingType_003Ek__BackingField;

	private InterfaceBuilderViewMode _003CViewMode_003Ek__BackingField;

	private ViewItemTheme _003CTheme_003Ek__BackingField;

	private FocusableType _003CFocusableType_003Ek__BackingField;

	private FormViewType _003CFormViewType_003Ek__BackingField;

	private DefaultAction _003CCloseCurrentDrawer_003Ek__BackingField;

	[NotResettable]
	public Guid HeaderUid
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _003CHeaderUid_003Ek__BackingField;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_003CHeaderUid_003Ek__BackingField = value;
		}
	}

	public ViewItemLoadingType LoadingType
	{
		get
		{
			return _003CLoadingType_003Ek__BackingField;
		}
		set
		{
			_003CLoadingType_003Ek__BackingField = value;
		}
	}

	[NotResettable]
	[JsonIgnore]
	public InterfaceBuilderViewMode ViewMode
	{
		get
		{
			return _003CViewMode_003Ek__BackingField;
		}
		set
		{
			_003CViewMode_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public ViewItemTheme Theme
	{
		get
		{
			return _003CTheme_003Ek__BackingField;
		}
		set
		{
			_003CTheme_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public FocusableType FocusableType
	{
		get
		{
			return _003CFocusableType_003Ek__BackingField;
		}
		set
		{
			_003CFocusableType_003Ek__BackingField = value;
		}
	}

	public bool FocusableEnabled => true;

	public FormViewType FormViewType
	{
		get
		{
			return _003CFormViewType_003Ek__BackingField;
		}
		set
		{
			_003CFormViewType_003Ek__BackingField = value;
		}
	}

	[JsonIgnore]
	public DefaultAction CloseCurrentDrawer
	{
		get
		{
			return _003CCloseCurrentDrawer_003Ek__BackingField;
		}
		set
		{
			_003CCloseCurrentDrawer_003Ek__BackingField = value;
		}
	}

	public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
	{
		return parentViewItem?.IsChildValid(this) ?? true;
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return true;
	}
}
