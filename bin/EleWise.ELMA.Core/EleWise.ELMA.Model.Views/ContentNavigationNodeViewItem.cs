using System;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Model.Views.Toolbox;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Model.Views;

internal class ContentNavigationNodeViewItem : RootViewItem, IContainerViewItem, IViewItemLoading, IViewItem, IReactive, IBadgeViewItem
{
	[Component]
	private class ToolboxItem : CommonViewItemToolboxItem<ContentNavigationNodeViewItem>
	{
		public override Guid Uid => new Guid("{E931E72F-6C95-4FFA-A1B0-A30B87BCAD51}");

		public override string Name => SR.T("Вкладка меню с формой");

		public override bool Visible => false;

		public ToolboxItem(IViewItemInfoService viewItemInfoService)
			: base(viewItemInfoService)
		{
		}
	}

	private string _003CCaption_003Ek__BackingField;

	private bool _003CMultiLineCaption_003Ek__BackingField;

	private ViewItemLoadingType _003CLoadingType_003Ek__BackingField;

	private bool _003CFixedHeight_003Ek__BackingField;

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
	public bool MultiLineCaption
	{
		get
		{
			return _003CMultiLineCaption_003Ek__BackingField;
		}
		set
		{
			_003CMultiLineCaption_003Ek__BackingField = value;
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

	public bool FixedHeight
	{
		get
		{
			return _003CFixedHeight_003Ek__BackingField;
		}
		set
		{
			_003CFixedHeight_003Ek__BackingField = value;
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

	public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
	{
		if (parentViewItem != null)
		{
			return parentViewItem is ContentNavigationViewItem;
		}
		return true;
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return true;
	}
}
