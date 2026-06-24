using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Components;
using EleWise.ELMA.Tasks.Models;
using NHibernate;
using NHibernate.Criterion;

namespace EleWise.ELMA.Tasks.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class WorkLogManager : EntityManager<IWorkLog, long>
{
	public ITransformationProvider TransformationProvider { get; set; }

	public WorkLogItemManager WorkLogItemManager { get; set; }

	public new static WorkLogManager Instance => Locator.GetServiceNotNull<WorkLogManager>();

	public long GetWorkLogsCount(ITaskBase task)
	{
		if (task == null || task.IsNew() || task.Id == 0L)
		{
			return 0L;
		}
		return Convert.ToInt64(GetWorkLogCriteria(task).SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.Count("Id") }).UniqueResult());
	}

	public IEnumerable<IWorkLog> GetWorkLogs(ITaskBase task)
	{
		return GetWorkLogCriteria(task).List<IWorkLog>();
	}

	protected virtual ICriteria GetWorkLogCriteria(ITaskBase task)
	{
		return CreateCriteria().Add((ICriterion)(object)Restrictions.Eq("TaskBase", (object)task));
	}

	public virtual ICriteria GetWorkLogReportCriteria(List<Guid> objectsUid, long? taskId = null, bool? isNew = false, DateTime? dateStart = null, DateTime? dateEnd = null)
	{
		string text = $"tb.{GetTypeUidPropertyName(typeof(ITaskBase))}";
		ICriteria val = CreateCriteria().Add((ICriterion)(object)Restrictions.Eq("Worker", (object)base.AuthenticationService.GetCurrentUser<IUser>())).CreateAlias("TaskBase", "tb").Add((ICriterion)(object)Restrictions.In(text, (ICollection)objectsUid))
			.Add((ICriterion)(object)Restrictions.Not((ICriterion)(object)Restrictions.Eq("Status", (object)WorkLogStatus.Rejected)));
		if (taskId.HasValue)
		{
			val.Add((ICriterion)(object)Restrictions.Eq("tb.Id", (object)taskId.Value));
		}
		if (dateStart.HasValue)
		{
			val.Add((ICriterion)(object)Restrictions.Ge("StartDate", (object)dateStart.Value));
		}
		if (dateEnd.HasValue)
		{
			val.Add((ICriterion)(object)Restrictions.Lt("StartDate", (object)dateEnd.Value));
		}
		if (isNew.HasValue)
		{
			if (!isNew.Value)
			{
				DetachedCriteria val2 = DetachedCriteria.For(InterfaceActivator.TypeOf<IWorkLogItem>(), "wlli").Add((ICriterion)(object)Restrictions.EqProperty("wlli.ObjectUID", text)).Add((ICriterion)(object)Restrictions.EqProperty("wlli.ObjectId", "tb.Id"))
					.SetProjection((IProjection)(object)Projections.Property("Id"));
				val.Add((ICriterion)(object)Subqueries.NotExists(val2));
			}
			else
			{
				val.Add((ICriterion)(object)Restrictions.IsNull("WorkLogItem"));
			}
		}
		return val;
	}

	public virtual Dictionary<DateTime?, long> GetWorkLogReportMinutes(List<Guid> objectsUid, DateTime dateStart, DateTime dateEnd)
	{
		ICriteria val = CreateCriteria().Add((ICriterion)(object)Restrictions.Eq("Worker", (object)base.AuthenticationService.GetCurrentUser<IUser>())).Add((ICriterion)(object)Restrictions.IsNull("WorkLogItem")).CreateAlias("TaskBase", "tb")
			.Add((ICriterion)(object)Restrictions.In($"tb.{GetTypeUidPropertyName(typeof(ITaskBase))}", (ICollection)objectsUid))
			.Add((ICriterion)(object)Restrictions.Not((ICriterion)(object)Restrictions.Eq("Status", (object)WorkLogStatus.Rejected)))
			.Add((ICriterion)(object)Restrictions.Ge("CreationDate", (object)new DateTime(dateStart.Year, dateStart.Month, dateStart.Day)))
			.Add((ICriterion)(object)Restrictions.Lt("CreationDate", (object)new DateTime(dateEnd.Year, dateEnd.Month, dateEnd.Day).AddDays(1.0)));
		val.SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.ProjectionList().Add((IProjection)(object)Projections.GroupProperty((IProjection)(object)ProjectionFor((IWorkLog b) => b.StartDate))).Add((IProjection)(object)Projections.Sum((IProjection)(object)ProjectionFor((IWorkLog b) => b.WorkMinutes))) });
		return val.List().Cast<object[]>().ToDictionary((object[] k) => (DateTime?)k[0], (object[] v) => ((WorkTime)v[1]).TotalMinutes);
	}

	[Transaction]
	public virtual void FreeHoursForWeekIgnore(List<Guid> objectsUid, DateTime date)
	{
		DateTime value = date.Date.AddDays(-WorkLogHelper.DayOfWeekNumber(date));
		DateTime value2 = value.Date.AddDays(7.0);
		foreach (IWorkLog item in GetWorkLogReportCriteria(objectsUid, null, null, value, value2).List<IWorkLog>().ToList())
		{
			item.Status = WorkLogStatus.Rejected;
			item.WorkLogItem = null;
			item.Save();
		}
	}

	[Transaction]
	public virtual void SetWorkLogLink(List<long> workLogIds, long? workLogItemId, long? objectId)
	{
		if (workLogIds.Count != 0)
		{
			SetWorkLogLink(workLogIds.ToArray(), workLogItemId, objectId);
		}
	}

	[Transaction]
	public virtual void SetWorkLogLink(string workLogIds, long? workLogItemId, long? objectId)
	{
		if (!string.IsNullOrEmpty(workLogIds))
		{
			IEnumerable<long> source = ParseStringToIds(workLogIds);
			SetWorkLogLink(source.ToArray(), workLogItemId, objectId);
		}
	}

	[Transaction]
	public virtual void SetWorkLogLink(long[] workLogIds, long? workLogItemId, long? objectId)
	{
		if (workLogIds.Length != 0)
		{
			IWorkLogItem workLogItem = WorkLogItemManager.LoadOrNull(workLogItemId.GetValueOrDefault());
			SetWorkLogLink(workLogIds, workLogItem, objectId);
		}
	}

	[Transaction]
	public virtual void SetWorkLogLink(long[] workLogIds, IWorkLogItem workLogItem, long? objectId)
	{
		if (workLogIds.Length == 0)
		{
			return;
		}
		foreach (IWorkLog item in FindByIdArray(workLogIds))
		{
			if (!objectId.HasValue || item.TaskBase.Id == objectId.Value)
			{
				item.Status = WorkLogStatus.Accepted;
				item.WorkLogItem = workLogItem;
				item.Save();
			}
		}
	}

	public void SaveAutoSaveWorkLogsUsers(IUser user)
	{
		AutoSaveWorkLogsUsers autoSaveWorkLogsUsers = GetAutoSaveWorkLogsUsers();
		long id = user.Id;
		if (!autoSaveWorkLogsUsers.UserIds.Contains(id))
		{
			autoSaveWorkLogsUsers.UserIds.Add(id);
			DataAccessManager.BLOBManager.SetBLOB(TaskConstants.WorkLogUid, "UserTaskControlSettings", autoSaveWorkLogsUsers);
		}
	}

	public AutoSaveWorkLogsUsers GetAutoSaveWorkLogsUsers()
	{
		return DataAccessManager.BLOBManager.GetBLOB<AutoSaveWorkLogsUsers>(TaskConstants.WorkLogUid, "UserTaskControlSettings") ?? new AutoSaveWorkLogsUsers();
	}

	public void RemoveAutoSaveWorkLogsUsers(IUser user)
	{
		AutoSaveWorkLogsUsers autoSaveWorkLogsUsers = GetAutoSaveWorkLogsUsers();
		autoSaveWorkLogsUsers.UserIds.Remove(user.Id);
		DataAccessManager.BLOBManager.SetBLOB(TaskConstants.WorkLogUid, "UserTaskControlSettings", autoSaveWorkLogsUsers);
	}

	private IEnumerable<long> ParseStringToIds(string workLogIds)
	{
		string[] array = workLogIds.Split(',');
		for (int i = 0; i < array.Length; i++)
		{
			if (long.TryParse(array[i], out var result))
			{
				yield return result;
			}
		}
	}
}
