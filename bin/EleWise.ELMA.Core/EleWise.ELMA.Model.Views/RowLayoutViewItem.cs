using System;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Model.Managers;
using EleWise.ELMA.Core.Model.Views.Toolbox;

namespace EleWise.ELMA.Model.Views;

internal class RowLayoutViewItem : RootViewItem
{
	[Component(Order = 160)]
	private class ToolboxItem : CommonViewItemToolboxItem<RowLayoutViewItem>
	{
		private readonly ICurrentPageService currentPageService;

		public override Guid Uid => new Guid("{EFE6426D-7846-4449-AB87-97B2565FEFB9}");

		public override string Name => SR.T("Размещение в строку");

		public override string Icon => "row-layout";

		public override bool Visible => currentPageService.CurrentPageViewModel.RuntimeVersion == RuntimeVersion.Version2;

		public ToolboxItem(ICurrentPageService currentPageService, IViewItemInfoService viewItemInfoService)
			: base(viewItemInfoService)
		{
			this.currentPageService = currentPageService;
		}
	}

	private HorizontalAlign _003CAlign_003Ek__BackingField;

	private VerticalAlign _003CVerticalAlign_003Ek__BackingField;

	public HorizontalAlign Align
	{
		get
		{
			return _003CAlign_003Ek__BackingField;
		}
		set
		{
			_003CAlign_003Ek__BackingField = value;
		}
	}

	public VerticalAlign VerticalAlign
	{
		get
		{
			return _003CVerticalAlign_003Ek__BackingField;
		}
		set
		{
			_003CVerticalAlign_003Ek__BackingField = value;
		}
	}

	public RowLayoutViewItem()
	{
		Align = HorizontalAlign.Left;
	}

	public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
	{
		return parentViewItem.IsChildValid(this);
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return true;
	}
}
