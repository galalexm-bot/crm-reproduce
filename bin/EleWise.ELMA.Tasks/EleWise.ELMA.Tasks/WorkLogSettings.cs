using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Runtime.Settings;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Tasks.Components;

namespace EleWise.ELMA.Tasks;

public class WorkLogSettings : GlobalSettingsBase
{
	private int emptyLineCount;

	private int limitDayReport;

	private int limitDayHours;

	[DisplayName(typeof(WorkLogSettings_SR), "P_ReportEmptyLineCount")]
	[Description(typeof(WorkLogSettings_SR), "P_ReportEmptyLineCount_description")]
	public int EmptyLineCount
	{
		get
		{
			return emptyLineCount;
		}
		set
		{
			emptyLineCount = ((value <= 0) ? 1 : value);
		}
	}

	[DisplayName(typeof(WorkLogSettings_SR), "P_DisableOvertime")]
	[Description(typeof(WorkLogSettings_SR), "P_DisableOvertime_description")]
	public bool DisableOvertime { get; set; }

	[DisplayName(typeof(WorkLogSettings_SR), "P_ReportNotificationsEnabled")]
	[Description(typeof(WorkLogSettings_SR), "P_ReportNotificationsEnabled_description")]
	public bool ReportNotificationsEnabled { get; set; }

	[DisplayName(typeof(WorkLogSettings_SR), "P_ReportNotificationsApprovalEnabled")]
	[Description(typeof(WorkLogSettings_SR), "P_ReportNotificationsApprovalEnabled_description")]
	public bool ReportNotificationsApprovalEnabled { get; set; }

	[DisplayName(typeof(WorkLogSettings_SR), "P_ReportNotificationsChangeEnabled")]
	[Description(typeof(WorkLogSettings_SR), "P_ReportNotificationsChangeEnabled_description")]
	public bool ReportNotificationsChangeEnabled { get; set; }

	[DisplayName(typeof(WorkLogSettings_SR), "P_ReportUnconfirmComment")]
	public bool ReportUnconfirmComment { get; set; }

	[IgnoreDataMember]
	[DisplayName("SR.M('Периодичность автоматической отправки трудозатрат на согласование')")]
	public NthIncludedDaySettings PeriodicityAutomaticSendingWorkLog
	{
		get
		{
			if (!string.IsNullOrEmpty(PeriodicityAutomaticSendingWorkLogString))
			{
				return ClassSerializationHelper.DeserializeObjectByJson<NthIncludedDaySettings>(PeriodicityAutomaticSendingWorkLogString);
			}
			return new NthIncludedDaySettings();
		}
		set
		{
			PeriodicityAutomaticSendingWorkLogString = ((value != null) ? ClassSerializationHelper.SerializeObjectByJson(value) : null);
		}
	}

	public string PeriodicityAutomaticSendingWorkLogString { get; set; }

	[DisplayName("SR.M('Пользователи, получающие оповещение при ошибке автоматической отправки трудозатрат на согласование')")]
	public IEnumerable<AssignedRoleTypeModel> AssignedRoleTypesNotificationErrorAutoWorkLog => WorkLogHelper.GetAssignedRoleTypeModelsById(UsersNotificationErrorAutoWorkLogIds, GroupNotificationErrorAutoWorkLogIds, OrganizationItemNotificationErrorAutoWorkLogIds);

	public string UsersNotificationErrorAutoWorkLogIds { get; set; }

	public string GroupNotificationErrorAutoWorkLogIds { get; set; }

	public string OrganizationItemNotificationErrorAutoWorkLogIds { get; set; }

	[DisplayName("SR.M('Пользователи, на которых не влияет ограничение срока подачи трудозатрат')")]
	public IEnumerable<AssignedRoleTypeModel> AssignedRoleTypesNotAffectLimitationWorkLog => WorkLogHelper.GetAssignedRoleTypeModelsById(UsersListNotAffectLimitationWorkLogIds, GroupListNotAffectLimitationWorkLogIds, OrganizationItemListNotAffectLimitationWorkLogIds);

	public string UsersListNotAffectLimitationWorkLogIds { get; set; }

	public string GroupListNotAffectLimitationWorkLogIds { get; set; }

	public string OrganizationItemListNotAffectLimitationWorkLogIds { get; set; }

	[DisplayName(typeof(WorkLogSettings_SR), "P_WorkLogEnabled")]
	public bool WorkLogEnabled { get; set; }

	[DisplayName(typeof(WorkLogSettings_SR), "P_AutoApproveMyWorklog")]
	[Obsolete("Эта настройка устарела, используйте вместо неё группу \"Автосогласование собственных трудозатрат\"")]
	public bool AutoApproveMyWorklog { get; set; }

	[DisplayName(typeof(WorkLogSettings_SR), "P_LimitDayReport")]
	public int LimitDayReport
	{
		get
		{
			return limitDayReport;
		}
		set
		{
			limitDayReport = ((value >= 0) ? value : 0);
		}
	}

	[DisplayName(typeof(WorkLogSettings_SR), "P_LimitDayHours")]
	public int LimitDayHours
	{
		get
		{
			return limitDayHours;
		}
		set
		{
			limitDayHours = ((value >= 0) ? value : 0);
		}
	}

	[DisplayName(typeof(WorkLogSettings_SR), "P_GroupTasks")]
	public GroupTasksType GroupTasks { get; set; }

	[DisplayName("SR.M('Запрещать подавать трудозатраты в завершенные задачи')")]
	public bool DisablePutWorkLogToCompletedTasks { get; set; }

	public WorkLogSettings()
	{
		WorkLogEnabled = true;
		EmptyLineCount = 1;
		DisableOvertime = false;
		ReportNotificationsEnabled = true;
		ReportUnconfirmComment = true;
		ReportNotificationsApprovalEnabled = false;
		ReportNotificationsChangeEnabled = false;
		LimitDayReport = 0;
		LimitDayHours = 0;
		GroupTasks = GroupTasksType.Days;
		DisablePutWorkLogToCompletedTasks = false;
	}
}
