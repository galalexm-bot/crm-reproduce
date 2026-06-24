using System;

namespace EleWise.ELMA.Model.Views.Charts;

internal interface IChartViewItem : IDynamicViewItem, IViewItemWithPropertyParents
{
	string Title { get; set; }

	Guid ValueUid { get; set; }

	Guid NameUid { get; set; }

	ViewItemChartLegendViewType LegendViewType { get; set; }
}
