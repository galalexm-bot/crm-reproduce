using System;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Model.Views.Toolbox;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Model.Views;

internal class TabViewItem : RootViewItem, IContainerViewItem, IViewItemLoading, IViewItem, IReactive, IBadgeViewItem
{
	[Component]
	private class ToolboxItem : CommonViewItemToolboxItem<TabViewItem>
	{
		public override Guid Uid => new Guid("{2789A31E-94DB-4EC2-BD55-B76EEEBEF89D}");

		public override string Name => SR.T("Вкладка");

		public override bool Visible => false;

		public ToolboxItem(ViewItemInfoService viewItemInfoService)
			: base((IViewItemInfoService)viewItemInfoService)
		{
		}
	}

	private string _003CCaption_003Ek__BackingField;

	private string _003CCaptionViewName_003Ek__BackingField;

	private bool _003CCaptionUseOriginalModel_003Ek__BackingField;

	private bool _003CAsyncLoading_003Ek__BackingField;

	private ViewItemLoadingType _003CLoadingType_003Ek__BackingField;

	private bool _003CFixedHeight_003Ek__BackingField;

	private string _003CBadgeText_003Ek__BackingField;

	private bool _003CDot_003Ek__BackingField;

	private ButtonStyle _003CBadgeStyle_003Ek__BackingField;

	[DynamicProperty(false)]
	public virtual string Caption
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

	public virtual string CaptionViewName
	{
		get
		{
			return _003CCaptionViewName_003Ek__BackingField;
		}
		set
		{
			_003CCaptionViewName_003Ek__BackingField = value;
		}
	}

	public virtual bool CaptionUseOriginalModel
	{
		get
		{
			return _003CCaptionUseOriginalModel_003Ek__BackingField;
		}
		set
		{
			_003CCaptionUseOriginalModel_003Ek__BackingField = value;
		}
	}

	public bool AsyncLoading
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

	public TabViewItem()
	{
		CaptionViewName = "";
		AsyncLoading = true;
		LoadingType = ViewItemLoadingType.AsyncLoading;
	}

	public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
	{
		if (parentViewItem != null)
		{
			return parentViewItem is TabLayoutViewItem;
		}
		return true;
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return true;
	}
}
