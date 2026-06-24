using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Tasks.Components;

namespace EleWise.ELMA.Tasks.Models;

public interface ICreateSubtaskActionModel : IAutoImplement
{
	[View(ViewType = ViewType.Display, Visibility = Visibility.Hidden, ReadOnly = false)]
	[SubtaskFieldType(CreateSubtaskSettingTypes.HiddenSetting)]
	Guid SubTaskTypeUid { get; set; }

	[View(ViewType = ViewType.Display, Visibility = Visibility.Hidden, ReadOnly = false)]
	[SubtaskFieldType(CreateSubtaskSettingTypes.HiddenSetting)]
	string CreateSubTaskAction { get; set; }

	[View(ViewType = ViewType.Display, Visibility = Visibility.Hidden, ReadOnly = false)]
	[SubtaskFieldType(CreateSubtaskSettingTypes.HiddenSetting)]
	string CreateSubTaskController { get; set; }

	[View(ViewType = ViewType.Display, Visibility = Visibility.Hidden, ReadOnly = false)]
	[SubtaskFieldType(CreateSubtaskSettingTypes.HiddenSetting)]
	string CreateSubTaskArea { get; set; }

	[View(ViewType = ViewType.All, Visibility = Visibility.Hidden, ReadOnly = false)]
	[SubtaskFieldType(CreateSubtaskSettingTypes.HiddenSetting)]
	long ParentId { get; set; }

	[DisplayName(typeof(__Resources_ICreateSubtaskActionModel), "P_CopySubject_DisplayName")]
	[View(ViewType = ViewType.Display, Visibility = Visibility.Hidden, ReadOnly = false)]
	[SubtaskDefaultFieldCheck(typeof(CreateSubtaskActionHandler), "IsDefaultValueSubject")]
	[SubtaskFieldType(CreateSubtaskSettingTypes.CopySetting)]
	bool CopySubject { get; set; }

	[DisplayName(typeof(__Resources_ICreateSubtaskActionModel), "P_CopyPriority_DisplayName")]
	[View(ViewType = ViewType.Display, Visibility = Visibility.Hidden, ReadOnly = false)]
	[SubtaskDefaultFieldCheck(typeof(CreateSubtaskActionHandler), "IsDefaultValuePriority")]
	[SubtaskFieldType(CreateSubtaskSettingTypes.CopySetting)]
	bool CopyPriority { get; set; }

	[DisplayName(typeof(__Resources_ICreateSubtaskActionModel), "P_CopyDates_DisplayName")]
	[View(ViewType = ViewType.Display, Visibility = Visibility.Hidden, ReadOnly = false)]
	[SubtaskDefaultFieldCheck(typeof(CreateSubtaskActionHandler), "IsDefaultValueDates")]
	[SubtaskFieldType(CreateSubtaskSettingTypes.CopySetting)]
	bool CopyDates { get; set; }

	[DisplayName(typeof(__Resources_ICreateSubtaskActionModel), "P_CopyDescription_DisplayName")]
	[View(ViewType = ViewType.Display, Visibility = Visibility.Hidden, ReadOnly = false)]
	[SubtaskDefaultFieldCheck(typeof(CreateSubtaskActionHandler), "IsDefaultValueDescription")]
	[SubtaskFieldType(CreateSubtaskSettingTypes.CopySetting)]
	bool CopyDescription { get; set; }

	[DisplayName(typeof(__Resources_ICreateSubtaskActionModel), "P_AppendCommentsToDescription_DisplayName")]
	[View(ViewType = ViewType.Display, Visibility = Visibility.Hidden, ReadOnly = false)]
	[SubtaskFieldType(CreateSubtaskSettingTypes.CopySetting)]
	bool AppendCommentsToDescription { get; set; }

	[DisplayName(typeof(__Resources_ICreateSubtaskActionModel), "P_CopyAttachments_DisplayName")]
	[View(ViewType = ViewType.Display, Visibility = Visibility.Hidden, ReadOnly = false)]
	[SubtaskDefaultFieldCheck(typeof(CreateSubtaskActionHandler), "IsDefaultValueAttachments")]
	[SubtaskFieldType(CreateSubtaskSettingTypes.CopySetting)]
	bool CopyAttachments { get; set; }

	[View(ViewType = ViewType.All, Visibility = Visibility.Hidden, ReadOnly = false)]
	[SubtaskFieldType(CreateSubtaskSettingTypes.HiddenSetting)]
	string RedirectUrl { get; set; }

	[View(ViewType = ViewType.All, Visibility = Visibility.Hidden, ReadOnly = false)]
	[SubtaskFieldType(CreateSubtaskSettingTypes.HiddenSetting)]
	string PopupId { get; set; }
}
