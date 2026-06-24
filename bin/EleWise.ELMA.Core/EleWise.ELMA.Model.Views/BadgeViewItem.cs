using System;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Model.Managers;
using EleWise.ELMA.Core.Model.Views.Toolbox;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Model.Views;

internal sealed class BadgeViewItem : RootViewItem, IBadgeViewItem, IViewItem, IReactive
{
	[Component(Order = 500)]
	private class ToolboxItem : CommonViewItemToolboxItem<BadgeViewItem>
	{
		private readonly ICurrentPageService currentPageService;

		public override Guid Uid => new Guid("{113F1B3C-13B2-474D-BD80-3064F0DB3059}");

		public override string Name => SR.T("Счетчик");

		public override string Icon => "badge";

		public override bool Visible => currentPageService.CurrentPageViewModel.RuntimeVersion == RuntimeVersion.Version2;

		public ToolboxItem(ICurrentPageService currentPageService, IViewItemInfoService viewItemInfoService)
			: base(viewItemInfoService)
		{
			this.currentPageService = currentPageService;
		}
	}

	private string _003CBadgeText_003Ek__BackingField;

	private bool _003CDot_003Ek__BackingField;

	private ButtonStyle _003CBadgeStyle_003Ek__BackingField;

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

	public override bool IsChildValid(ViewItem childViewItem)
	{
		if (base.Items == null || base.Items.Count < 1)
		{
			if (!(childViewItem is ContentNavigationViewItem) && !(childViewItem is PanelViewItem))
			{
				return !(childViewItem is TabLayoutViewItem);
			}
			return false;
		}
		return false;
	}
}
