using System;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Model.Managers;
using EleWise.ELMA.Core.Model.Views.Toolbox;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Attributes;
using Newtonsoft.Json;

namespace EleWise.ELMA.Model.Views;

internal sealed class DrawerViewItem : RootViewItem, IViewItemLoading, IViewItem, IReactive
{
	[Component(Order = 460)]
	private class ToolboxItem : CommonViewItemToolboxItem<DrawerViewItem>
	{
		private readonly ICurrentPageService currentPageService;

		public override Guid Uid => new Guid("{BA30AF10-5EDB-4D2B-9974-AE4DAAAB25E5}");

		public override string Name => SR.T("Выдвижная панель");

		public override bool Visible => currentPageService.CurrentPageViewModel.RuntimeVersion == RuntimeVersion.Version2;

		public override string Icon => "drawer";

		public ToolboxItem(ICurrentPageService currentPageService, IViewItemInfoService viewItemInfoService)
			: base(viewItemInfoService)
		{
			this.currentPageService = currentPageService;
		}
	}

	private ViewItemComponentSize _003CSize_003Ek__BackingField;

	private string _003CTitle_003Ek__BackingField;

	private bool _003CMaskClosable_003Ek__BackingField;

	private bool _003CMaskTransparent_003Ek__BackingField;

	private ViewItemComponentPlacement _003CPlacement_003Ek__BackingField;

	private bool _003CDestroyOnClose_003Ek__BackingField;

	private DefaultAction _003COnClose_003Ek__BackingField;

	private ViewItemLoadingType _003CLoadingType_003Ek__BackingField;

	[DynamicProperty(false)]
	public ViewItemComponentSize Size
	{
		get
		{
			return _003CSize_003Ek__BackingField;
		}
		set
		{
			_003CSize_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public string Title
	{
		get
		{
			return _003CTitle_003Ek__BackingField;
		}
		set
		{
			_003CTitle_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public bool MaskClosable
	{
		get
		{
			return _003CMaskClosable_003Ek__BackingField;
		}
		set
		{
			_003CMaskClosable_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public bool MaskTransparent
	{
		get
		{
			return _003CMaskTransparent_003Ek__BackingField;
		}
		set
		{
			_003CMaskTransparent_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public ViewItemComponentPlacement Placement
	{
		get
		{
			return _003CPlacement_003Ek__BackingField;
		}
		set
		{
			_003CPlacement_003Ek__BackingField = value;
		}
	}

	public bool DestroyOnClose
	{
		get
		{
			return _003CDestroyOnClose_003Ek__BackingField;
		}
		set
		{
			_003CDestroyOnClose_003Ek__BackingField = value;
		}
	}

	[JsonIgnore]
	[DynamicProperty(false)]
	public DefaultAction OnClose
	{
		get
		{
			return _003COnClose_003Ek__BackingField;
		}
		set
		{
			_003COnClose_003Ek__BackingField = value;
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

	public DrawerViewItem()
	{
		LoadingType = ViewItemLoadingType.AsyncLoading;
		MaskTransparent = true;
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return true;
	}
}
