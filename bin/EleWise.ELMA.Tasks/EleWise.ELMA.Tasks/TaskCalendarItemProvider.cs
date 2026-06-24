using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using EleWise.ELMA.Cache.Attributes;
using EleWise.ELMA.Calendar;
using EleWise.ELMA.Calendar.Managers;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.Tasks;

[Component]
public class TaskCalendarItemProvider : ICalendarItemSearchProvider, ICalendarItemProvider, IUpdatePackageCalendarItemProvider, IModifyTimeCalendarItemProvider
{
	public static readonly Guid _uid = new Guid("{F58278DE-ABE6-447B-96F0-8816FA63E325}");

	public TaskBaseManager TaskBaseManager { get; set; }

	public ISecurityService SecurityService { get; set; }

	public ScheduleManager ScheduleManager { get; set; }

	public Guid Uid => _uid;

	public IEntityManager<ITaskTimePlan, long> TaskTimePlanManager { get; set; }

	[NotNull]
	public IAuthenticationService AuthenticationService { get; set; }

	private EleWise.ELMA.Security.Models.IUser CurrentUser => AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();

	public bool External => false;

	public Guid GetPackageTypeUid(Guid typeUid)
	{
		if (!(typeUid == InterfaceActivator.UID<ITaskTimePlan>()))
		{
			return Guid.Empty;
		}
		return new Guid("63514ECB-F185-4D01-B8B6-8ABFF58A264C");
	}

	public IEnumerable<Guid> GetTypeUids()
	{
		yield return InterfaceActivator.UID<ITaskTimePlan>();
	}

	public IEntityFilter GetFilter(ICollection<ISchedule> schedules, DateTime startDate, DateTime endDate)
	{
		return GetFilterPrivate(schedules, startDate, endDate);
	}

	public ICalendarItem[] GetItems(Guid typeUid, long[] ids, ICollection<ISchedule> schedules)
	{
		return ((IEnumerable<ITaskTimePlan>)TaskTimePlanManager.FindByIdArray(ids)).Select((Func<ITaskTimePlan, ICalendarItem>)((ITaskTimePlan t) => new TaskCalendarItem(t, CurrentUser))).ToArray();
	}

	ICalendarItem[] IUpdatePackageCalendarItemProvider.GetItems(ICollection<ISchedule> schedules, DateTime startDate, DateTime endDate)
	{
		return GetItems(schedules, startDate, endDate).ToArray();
	}

	private ITaskTimePlanFilter GetFilterPrivate(ICollection<ISchedule> schedules, DateTime startDate, DateTime endDate, bool checkPermission = true)
	{
		InstanceOf<ITaskTimePlanFilter> instanceOf = new InstanceOf<ITaskTimePlanFilter>();
		instanceOf.New.Period = new DateTimeRange
		{
			From = startDate,
			To = endDate
		};
		instanceOf.New.Executors = (ISet<EleWise.ELMA.Security.Models.IUser>)(object)new HashedSet<EleWise.ELMA.Security.Models.IUser>((ICollection<EleWise.ELMA.Security.Models.IUser>)(from s in schedules
			select s.Owner into o
			where o != null
			select o).ToList());
		instanceOf.New.DisableSecurity = !checkPermission;
		return instanceOf.New;
	}

	[ContextCache]
	public virtual ICollection<ICalendarItem> GetItems(EleWise.ELMA.Security.Models.IUser user, DateTime startDate, DateTime endDate, bool checkPermission = true, bool showExpired = false)
	{
		return GetItems(ScheduleManager.GetUserSchedule(user), startDate, endDate, checkPermission, showExpired);
	}

	[ContextCache]
	public virtual ICollection<ICalendarItem> GetItems(ISchedule schedule, DateTime startDate, DateTime endDate, bool checkPermission = true, bool showExpired = false)
	{
		if (schedule.Owner == null)
		{
			return new List<ICalendarItem>();
		}
		return GetItems(new List<ISchedule> { schedule }, startDate, endDate, checkPermission, showExpired);
	}

	[ContextCache]
	public virtual ICollection<ICalendarItem> GetItems(ICollection<ISchedule> schedules, DateTime startDate, DateTime endDate, bool checkPermission = true, bool showExpired = false)
	{
		if (schedules.All((ISchedule s) => s.Owner == null))
		{
			return new List<ICalendarItem>();
		}
		return ((IEnumerable<ITaskTimePlan>)TaskTimePlanManager.Find(GetFilterPrivate(schedules, startDate, endDate, checkPermission), FetchOptions.All)).Select((Func<ITaskTimePlan, ICalendarItem>)((ITaskTimePlan t) => new TaskCalendarItem(t, CurrentUser))).ToArray();
	}

	public IDictionary<ISchedule, ICollection<ICalendarItem>> CrossingItems(ICollection<ISchedule> schedules, DateTime startDate, DateTime endDate)
	{
		List<ISchedule> source = schedules.Where((ISchedule s) => s.Owner != null).ToList();
		if (!source.Any())
		{
			return new Dictionary<ISchedule, ICollection<ICalendarItem>>();
		}
		startDate = startDate.AddSeconds(1.0);
		endDate = endDate.AddSeconds(-1.0);
		InstanceOf<ITaskTimePlanFilter> instanceOf = new InstanceOf<ITaskTimePlanFilter>();
		instanceOf.New.Period = new DateTimeRange
		{
			From = startDate,
			To = endDate
		};
		instanceOf.New.Executors = (ISet<EleWise.ELMA.Security.Models.IUser>)(object)new HashedSet<EleWise.ELMA.Security.Models.IUser>((ICollection<EleWise.ELMA.Security.Models.IUser>)source.Select((ISchedule s) => s.Owner).ToList());
		ITaskTimePlanFilter filter = instanceOf.New;
		List<ITaskTimePlan> list = new List<ITaskTimePlan>();
		SecurityService.RunWithElevatedPrivilegies(delegate
		{
			list = TaskTimePlanManager.Find(filter, FetchOptions.All).ToList();
		});
		return (from s in ((IEnumerable<ISchedule>)schedules).ToDictionary((Func<ISchedule, ISchedule>)((ISchedule schedule) => schedule), (Func<ISchedule, ICollection<ICalendarItem>>)((ISchedule schedule) => (from e in list
				where e.Task.Executor == schedule.Owner
				select new TaskCalendarItem(e, CurrentUser)
				{
					OnlyInfo = (!SecurityService.CanCheckPermission(PermissionProvider.ViewTaskPermission, e.Task) || (SecurityService.CanCheckPermission(PermissionProvider.ViewTaskPermission, e.Task) && !SecurityService.HasPermission(PermissionProvider.ViewTaskPermission, e.Task)))
				}).Cast<ICalendarItem>().ToList()))
			where s.Value.Any()
			select s).ToDictionary((KeyValuePair<ISchedule, ICollection<ICalendarItem>> s) => s.Key, (KeyValuePair<ISchedule, ICollection<ICalendarItem>> s) => s.Value);
	}

	public ICollection<ICalendarPlannedItem> GetRePlannedItems(EleWise.ELMA.Security.Models.IUser user)
	{
		return GetRePlannedItems(user, "");
	}

	public ICollection<ICalendarPlannedItem> GetRePlannedItems(EleWise.ELMA.Security.Models.IUser user, string searchString)
	{
		ITaskBaseFilter filter = GetFilter(user, isPlanned: true, searchString);
		return (from t in TaskBaseManager.Find(filter, new FetchOptions(0, 0, ListSortDirection.Descending, "StartDate"))
			select new TaskCalendarPlannedItem(t)).Cast<ICalendarPlannedItem>().ToList();
	}

	public ICollection<ICalendarPlannedItem> GetUnPlannedItems(EleWise.ELMA.Security.Models.IUser user)
	{
		return GetUnPlannedItems(user, "");
	}

	public ICollection<ICalendarPlannedItem> GetUnPlannedItems(EleWise.ELMA.Security.Models.IUser user, string searchString)
	{
		ITaskBaseFilter filter = GetFilter(user, isPlanned: false, searchString);
		return (from t in TaskBaseManager.Find(filter, new FetchOptions(0, 0, ListSortDirection.Descending, "StartDate"))
			select new TaskCalendarPlannedItem(t)).Cast<ICalendarPlannedItem>().ToList();
	}

	private ITaskBaseFilter GetFilter(EleWise.ELMA.Security.Models.IUser user, bool isPlanned, string searchString = null)
	{
		ITaskBaseFilter taskBaseFilter = InterfaceActivator.Create<ITaskBaseFilter>();
		taskBaseFilter.Executor = user;
		taskBaseFilter.IsPlanned = isPlanned;
		taskBaseFilter.CompleteStatus = TaskCompleteStatus.Active;
		taskBaseFilter.NotShowInLists = false;
		taskBaseFilter.IsEmulation = false;
		taskBaseFilter.SearchString = searchString;
		return taskBaseFilter;
	}

	public ICalendarItem AddItem(EleWise.ELMA.Security.Models.IUser user, string id, DateTime startDate, DateTime endDate, bool removeOther)
	{
		if (string.IsNullOrEmpty(id) || startDate >= endDate)
		{
			throw new Exception(SR.T("Неверные параметры"));
		}
		ITaskBase taskBase = TaskBaseManager.LoadOrNull(long.Parse(id));
		if (taskBase == null)
		{
			throw new Exception(SR.T("Не найдена задача"));
		}
		if (TaskBaseManager.Instance.CanSchedule(taskBase.Id, startDate, endDate, removeOther))
		{
			return new TaskCalendarItem(TaskBaseManager.Instance.Schedule(taskBase.Id, startDate, endDate, removeOther), CurrentUser);
		}
		return null;
	}

	[Transaction]
	public virtual ICalendarItem ModifyTime(string id, int dayDelta, int minuteDelta, bool moved)
	{
		ITaskTimePlan taskTimePlan = CheckTaskTimePlan(id);
		if (moved)
		{
			taskTimePlan.StartTime = taskTimePlan.StartTime.AddDays(dayDelta).AddMinutes(minuteDelta);
		}
		taskTimePlan.EndTime = taskTimePlan.EndTime.AddDays(dayDelta).AddMinutes(minuteDelta);
		taskTimePlan.Save();
		return new TaskCalendarItem(taskTimePlan, CurrentUser);
	}

	[Transaction]
	public virtual ICalendarItem ModifyTime(string id, DateTime startDate, DateTime endDate)
	{
		ITaskTimePlan taskTimePlan = CheckTaskTimePlan(id);
		taskTimePlan.StartTime = startDate;
		taskTimePlan.EndTime = endDate;
		taskTimePlan.Save();
		return new TaskCalendarItem(taskTimePlan, CurrentUser);
	}

	private ITaskTimePlan CheckTaskTimePlan(string id)
	{
		ITaskTimePlan taskTimePlan = TaskTimePlanManager.LoadOrNull(long.Parse(id));
		if (taskTimePlan == null)
		{
			throw new Exception(SR.T("Не найдено событие"));
		}
		if (taskTimePlan.Task.Status == TaskBaseStatus.IncompleteControlled || taskTimePlan.Task.Status == TaskBaseStatus.CompleteControlled || taskTimePlan.Task.Status == TaskBaseStatus.WasClosed)
		{
			throw new Exception(SR.T("Задача закрыта и не может изменятся"));
		}
		return taskTimePlan;
	}

	public void Remove(string id)
	{
		ITaskTimePlan taskTimePlan = TaskTimePlanManager.LoadOrNull(long.Parse(id));
		if (taskTimePlan == null)
		{
			throw new Exception(SR.T("Не найдено событие"));
		}
		if (taskTimePlan.Task.Status == TaskBaseStatus.IncompleteControlled || taskTimePlan.Task.Status == TaskBaseStatus.CompleteControlled || taskTimePlan.Task.Status == TaskBaseStatus.WasClosed)
		{
			throw new Exception(SR.T("Задача закрыта и не может удаляться"));
		}
		taskTimePlan.Delete();
	}
}
