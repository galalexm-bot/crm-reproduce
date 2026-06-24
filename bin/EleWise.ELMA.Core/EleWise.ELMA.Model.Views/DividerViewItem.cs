using System;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Model.Managers;
using EleWise.ELMA.Core.Model.Views.Toolbox;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Model.Views;

internal sealed class DividerViewItem : ViewItem
{
	[Component(Order = 950)]
	private class ToolboxItem : CommonViewItemToolboxItem<DividerViewItem>
	{
		private readonly ICurrentPageService currentPageService;

		public override Guid Uid => new Guid("{E3E423B7-F9F4-4574-BA9A-EC8C0DE989C1}");

		public override string Name => SR.T("Разделитель");

		public override string Icon => "horizontal-line";

		public override bool Visible => currentPageService.CurrentPageViewModel.RuntimeVersion == RuntimeVersion.Version2;

		public ToolboxItem(ICurrentPageService currentPageService, IViewItemInfoService viewItemInfoService)
			: base(viewItemInfoService)
		{
			this.currentPageService = currentPageService;
		}
	}

	private DirectionType _003CDirectionType_003Ek__BackingField;

	[DynamicProperty(false)]
	public DirectionType DirectionType
	{
		get
		{
			return _003CDirectionType_003Ek__BackingField;
		}
		set
		{
			_003CDirectionType_003Ek__BackingField = value;
		}
	}

	public DividerViewItem()
	{
		DirectionType = DirectionType.Horizontal;
	}
}
