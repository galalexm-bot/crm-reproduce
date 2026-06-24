using System;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Model.Views.Charts;

[DynamicPropertyContainer]
public interface IChartViewItem : IDynamicViewItem, IViewItemWithPropertyParents, IViewItem, IReactive
{
	[DynamicProperty(false)]
	string Title { get; set; }

	[DynamicProperty(false)]
	Guid ValueUid { get; set; }

	[DynamicProperty(false)]
	Guid NameUid { get; set; }

	ViewItemChartLegendViewType LegendViewType { get; set; }

	[DynamicProperty(false)]
	ActionWithParam<object> OnMouseEnterElement { get; set; }

	[DynamicProperty(false)]
	ActionWithParam<object> OnMouseLeaveElement { get; set; }

	[DynamicProperty(false)]
	ActionWithParam<object> OnClickElement { get; set; }
}
