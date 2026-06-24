using System;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.UI.Metadata;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Model.Managers;
using EleWise.ELMA.Core.Model.Views.Toolbox;

namespace EleWise.ELMA.Model.Views;

internal sealed class PlaceholderViewItem : ViewItem
{
	[Component(Order = 151)]
	private class ToolboxItem : CommonViewItemToolboxItem<PlaceholderViewItem>
	{
		private readonly ICurrentPageService currentPageService;

		public override Guid Uid => new Guid("{CAF93928-28A8-4592-B055-1D67B57D9355}");

		public override string Name => SR.T("Область для вставки компонента");

		public override string Icon => "placeholder";

		public override bool Visible
		{
			get
			{
				if (currentPageService.CurrentPageViewModel.RuntimeVersion == RuntimeVersion.Version2)
				{
					return ((object)currentPageService.CurrentPageViewModel.Metadata).GetType() == typeof(ComponentMetadata);
				}
				return false;
			}
		}

		public ToolboxItem(ICurrentPageService currentPageService, IViewItemInfoService viewItemInfoService)
			: base(viewItemInfoService)
		{
			this.currentPageService = currentPageService;
		}
	}

	public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
	{
		return parentViewItem?.IsChildValid(this) ?? true;
	}
}
