using System;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Model.Managers;
using EleWise.ELMA.Core.Model.Views.Toolbox;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Model.Views.Charts;

internal sealed class PieChartViewItem : ChartViewItem
{
	[Component]
	private class ToolboxItem : ChartViewItemToolboxItem<PieChartViewItem>
	{
		private readonly ICurrentPageService currentPageService;

		public override Guid Uid => new Guid("{C9C1BFBB-750B-446A-B635-EFCA99151255}");

		public override string Name => SR.T("Круговая диаграмма");

		public override bool Visible => currentPageService.CurrentPageViewModel.RuntimeVersion == RuntimeVersion.Version2;

		public override string Icon => "statistic";

		public ToolboxItem(ICurrentPageService currentPageService, IViewItemInfoService viewItemInfoService)
			: base(viewItemInfoService)
		{
			this.currentPageService = currentPageService;
		}
	}

	private ViewItemPieChartViewType _003CViewType_003Ek__BackingField;

	[DynamicProperty(false)]
	public ViewItemPieChartViewType ViewType
	{
		get
		{
			return _003CViewType_003Ek__BackingField;
		}
		set
		{
			_003CViewType_003Ek__BackingField = value;
		}
	}
}
