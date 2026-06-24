using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Tasks.Components;

namespace EleWise.ELMA.Tasks.ExtensionPoints;

[AutoImplementClassBase(typeof(Filter))]
public interface IWorkLogObjectSearchFilter : IAutoImplement, IEntityFilter
{
	[DisplayName(typeof(WorkLogObjectSearchFilter_SR), "P_Name")]
	[Order(-100)]
	string Name { get; set; }

	[DisplayName(typeof(WorkLogObjectSearchFilter_SR), "P_EntityType")]
	[WorkLogItemSearchField]
	Guid? EntityType { get; set; }

	[DisplayName(typeof(WorkLogObjectSearchFilter_SR), "P_CreationAuthor")]
	[WorkLogItemSearchHide]
	IUser CreationAuthor { get; set; }

	[DateTimeSettings(ShowTime = false, RelativeInFilter = true, FieldName = "Date")]
	[DisplayName(typeof(WorkLogObjectSearchFilter_SR), "P_CreationDate")]
	[WorkLogItemSearchHide]
	RelativeDateTime CreationDate { get; set; }

	[DisplayName(typeof(WorkLogObjectSearchFilter_SR), "P_EndDate")]
	[DateTimeSettings(ShowTime = false, FieldName = "Date")]
	[WorkLogItemSearchHide]
	DateTimeRange EndDate { get; set; }
}
