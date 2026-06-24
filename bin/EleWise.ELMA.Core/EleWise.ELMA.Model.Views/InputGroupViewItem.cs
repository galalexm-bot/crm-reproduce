using System;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Model.Managers;
using EleWise.ELMA.Core.Model.Views.Toolbox;

namespace EleWise.ELMA.Model.Views;

public sealed class InputGroupViewItem : RootViewItem, IContainerViewItem
{
	[Component(Order = 480)]
	private class ToolboxItem : CommonViewItemToolboxItem<InputGroupViewItem>
	{
		private readonly ICurrentPageService currentPageService;

		public override Guid Uid => new Guid("{96521261-6067-4691-B629-9052124DED69}");

		public override string Name => SR.T("Группа ввода");

		public override bool Visible => currentPageService.CurrentPageViewModel.RuntimeVersion == RuntimeVersion.Version2;

		public override string Icon => "input-group";

		public ToolboxItem(ICurrentPageService currentPageService, IViewItemInfoService viewItemInfoService)
			: base(viewItemInfoService)
		{
			this.currentPageService = currentPageService;
		}
	}

	public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
	{
		return parentViewItem.IsChildValid(this);
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		if (!(childViewItem is ButtonViewItem) && !(childViewItem is PropertyValueViewItem) && !(childViewItem is TreeSelectViewItem) && !(childViewItem is PopoverViewItem))
		{
			return childViewItem is BadgeViewItem;
		}
		return true;
	}
}
