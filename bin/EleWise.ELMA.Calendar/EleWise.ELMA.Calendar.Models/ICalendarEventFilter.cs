using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security.Models;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.Calendar.Models;

[FilterFor(typeof(ICalendarEvent))]
public interface ICalendarEventFilter : IEntityFilter
{
	string Subject { get; set; }

	DateTimeRange CreationDate { get; set; }

	bool? Completed { get; set; }

	IUser CreationAuthor { get; set; }

	bool? ConfirmParticipation { get; set; }

	ICalendarEventPeriodical TemplateEvent { get; set; }

	[CustomFilterProperty]
	[Uid("c5d14259-0d8e-4b64-9527-0d9a113b5ca8")]
	[Property("6fbbca7c-a693-4791-902c-30b5984671a2")]
	[DateTimeSettings(FieldName = "Period")]
	[DisplayName(typeof(__Resources_ICalendarEvent), "FP_DateRange_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	DateTimeRange DateRange { get; set; }

	[CustomFilterProperty]
	[Uid("1607d454-fff1-4fe5-a6d6-0df5b9c49e3a")]
	[Order(1)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "2919287f-1f84-42d0-b937-7da6025b95e4")]
	[EntitySettings(RelationType = RelationType.ManyToMany, ParentColumnName = "Parent", ChildColumnName = "Child")]
	[DisplayName(typeof(__Resources_ICalendarEvent), "FP_Schedules_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	ISet<ISchedule> Schedules { get; set; }

	[CustomFilterProperty]
	[Uid("744ab87f-9128-402e-87c5-3166b1aa2ce6")]
	[Order(2)]
	[NotNull]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(FieldName = "AllTypes")]
	[DisplayName(typeof(__Resources_ICalendarEvent), "FP_AllTypes_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	bool AllTypes { get; set; }
}
