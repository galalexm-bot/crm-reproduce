using System;
using System.Collections.Generic;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Tasks.Components;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.ExtensionPoints;

[InterfaceExtension(typeof(IWorkLogObjectSearchFilter))]
public interface IWorkLogItemSearchFilter : IWorkLogObjectSearchFilter, IAutoImplement, IEntityFilter
{
	[DisplayName(typeof(WorkLogItemSearchFilter_SR), "P_WorkLogItemStatus")]
	[WorkLogItemSearchField]
	[Order(-50)]
	WorkLogItemStatus? WorkLogItemStatus { get; set; }

	[WorkLogItemSearchField]
	[WorkLogItemSearchHide]
	[View(Visibility = Visibility.Hidden)]
	List<WorkLogItemStatus> WorkLogItemStatuses { get; set; }

	[DisplayName(typeof(WorkLogItemSearchFilter_SR), "P_WorkLogItemDate")]
	[DateTimeSettings(ShowTime = false, RelativeInFilter = true, FieldName = "Date")]
	[WorkLogItemSearchField]
	[Order(-49)]
	RelativeDateTime WorkLogItemDate { get; set; }

	[DisplayName(typeof(WorkLogItemSearchFilter_SR), "P_WorkLogItemActivity")]
	[WorkLogItemSearchField]
	[Order(-48)]
	List<IWorkLogActivity> WorkLogItemActivities { get; set; }

	[DisplayName(typeof(WorkLogItemSearchFilter_SR), "P_WorkLogItemAuthors")]
	[WorkLogItemSearchField]
	[Order(-47)]
	List<IUser> WorkLogItemAuthors { get; set; }

	[DisplayName(typeof(WorkLogItemSearchFilter_SR), "P_WorkLogItemHarmonizators")]
	[WorkLogItemSearchField]
	[Order(-46)]
	List<IUser> WorkLogItemHarmonizators { get; set; }

	[DisplayName(typeof(WorkLogItemSearchFilter_SR), "P_MyDepartment")]
	[WorkLogItemSearchField]
	[WorkLogItemSearchHide]
	bool? MyDepartment { get; set; }

	[DisplayName(typeof(WorkLogItemSearchFilter_SR), "P_OnlyMy")]
	[WorkLogItemSearchField]
	[WorkLogItemSearchHide]
	bool? OnlyMy { get; set; }

	[DisplayName(typeof(WorkLogItemSearchFilter_SR), "P_WorkLogItemObjectId")]
	[WorkLogItemSearchField]
	[WorkLogItemSearchHide]
	[View(Visibility = Visibility.Hidden)]
	long? WorkLogItemObjectId { get; set; }

	[DisplayName(typeof(WorkLogItemSearchFilter_SR), "P_WorkLogItemObjectTypeUid")]
	[WorkLogItemSearchField]
	[WorkLogItemSearchHide]
	[View(Visibility = Visibility.Hidden)]
	Guid? WorkLogItemObjectTypeUid { get; set; }

	[DisplayName(typeof(WorkLogItemSearchFilter_SR), "P_ShowDraft")]
	[WorkLogItemSearchHide]
	[WorkLogItemSearchField]
	[View(Visibility = Visibility.Hidden)]
	bool? ShowDraft { get; set; }

	[WorkLogItemSearchField]
	[WorkLogItemSearchHide]
	[View(Visibility = Visibility.Hidden)]
	List<long> Ids { get; set; }

	[WorkLogItemSearchField]
	[WorkLogItemSearchHide]
	[View(Visibility = Visibility.Hidden)]
	List<long> ExcludeIds { get; set; }

	[WorkLogItemSearchField]
	[WorkLogItemSearchHide]
	[View(Visibility = Visibility.Hidden)]
	List<Guid> ObjectUids { get; set; }

	[WorkLogItemSearchField]
	[WorkLogItemSearchHide]
	[View(Visibility = Visibility.Hidden)]
	List<IWorkLogItemSearchFilter> FilterList { get; set; }
}
