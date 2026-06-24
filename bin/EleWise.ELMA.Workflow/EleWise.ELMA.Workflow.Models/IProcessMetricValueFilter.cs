using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Workflow.Models;

[FilterFor(typeof(IProcessMetricValue))]
public interface IProcessMetricValueFilter : IEntityFilter
{
	DateTime? PeriodStart { get; set; }

	DateTime? PeriodEnd { get; set; }

	IUser Responsible { get; set; }

	Guid? ProcessMetricUid { get; set; }

	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[DateTimeSettings(FieldName = "Period")]
	[Property("6fbbca7c-a693-4791-902c-30b5984671a2")]
	[CustomFilterProperty]
	[Uid("803b658a-e44d-4f94-badd-a477e2a77968")]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[DisplayName(typeof(__Resources_IProcessMetricValue), "FP_Period_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	DateTimeRange Period { get; set; }
}
