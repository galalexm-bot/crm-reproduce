using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using EleWise.ELMA.Cache.Attributes;
using EleWise.ELMA.Calendar;
using EleWise.ELMA.Calendar.Managers;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Enums;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.CRM;

[Component]
public class RelationshipCalendarItemProvider : ICalendarItemProvider, ICrossingCalendarProvider, IUpdatePackageCalendarItemProvider, IModifyTimeCalendarItemProvider
{
	public static readonly Guid uid = new Guid("{6c87f9df-53e2-479b-b29f-61317b89d4f5}");

	public RelationshipManager RelationshipManager { get; set; }

	public ScheduleManager ScheduleManager { get; set; }

	public ISecurityService SecurityService { get; set; }

	[NotNull]
	public IAuthenticationService AuthenticationService { get; set; }

	private EleWise.ELMA.Security.Models.IUser CurrentUser => AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();

	public Guid Uid => uid;

	public bool External => false;

	public IEnumerable<Guid> TypeUids => from ClassMetadata md in from m in Locator.GetServiceNotNull<IMetadataRuntimeService>().GetMetadataList()
			where m is ClassMetadata && ((ClassMetadata)m).BaseClassUid == InterfaceActivator.UID<IRelationship>()
			select m
		select md.Uid;

	public Guid GetPackageTypeUid(Guid typeUid)
	{
		if (!(typeUid == InterfaceActivator.UID<IRelationship>()))
		{
			return Guid.Empty;
		}
		return new Guid("233BD34B-FB24-44A0-8A1A-8601ADE628B5");
	}

	public IEnumerable<Guid> GetTypeUids()
	{
		yield return InterfaceActivator.UID<IRelationship>();
	}

	public IEntityFilter GetFilter(ICollection<ISchedule> schedules, DateTime startDate, DateTime endDate)
	{
		return GetFilterPrivate(schedules, startDate, endDate);
	}

	public ICalendarItem[] GetItems(Guid typeUid, long[] ids, ICollection<ISchedule> schedules)
	{
		EleWise.ELMA.Security.Models.IUser[] owners = (from s in schedules
			where s.Owner != null
			select s.Owner).ToArray();
		return ((IEnumerable<IRelationship>)RelationshipManager.FindByIdArray(ids)).Select((Func<IRelationship, ICalendarItem>)((IRelationship t) => new RelationshipCalendarItem(t, owners))).ToArray();
	}

	ICalendarItem[] IUpdatePackageCalendarItemProvider.GetItems(ICollection<ISchedule> schedules, DateTime startDate, DateTime endDate)
	{
		return GetItems(schedules, startDate, endDate).ToArray();
	}

	private IRelationshipFilter GetFilterPrivate(ICollection<ISchedule> schedules, DateTime startDate, DateTime endDate, bool checkPermission = true, bool showExpired = true)
	{
		InstanceOf<IRelationshipFilter> instanceOf = new InstanceOf<IRelationshipFilter>();
		instanceOf.New.Period = new DateTimeRange
		{
			From = startDate,
			To = endDate
		};
		instanceOf.New.LoadExpired = showExpired;
		instanceOf.New.Schedules = (ISet<ISchedule>)(object)new HashedSet<ISchedule>(schedules);
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
		return GetItems(new List<ISchedule> { schedule }, startDate, endDate, checkPermission, showExpired);
	}

	[ContextCache]
	public virtual ICollection<ICalendarItem> GetItems(ICollection<ISchedule> schedules, DateTime startDate, DateTime endDate, bool checkPermission = true, bool showExpired = false)
	{
		EleWise.ELMA.Security.Models.IUser[] owners = (from s in schedules
			where s.Owner != null
			select s.Owner).ToArray();
		return ((IEnumerable<IRelationship>)RelationshipManager.Find(GetFilterPrivate(schedules, startDate, endDate, checkPermission, showExpired), FetchOptions.All)).Select((Func<IRelationship, ICalendarItem>)((IRelationship t) => new RelationshipCalendarItem(t, owners))).ToArray();
	}

	public IDictionary<ISchedule, ICollection<ICalendarItem>> CrossingItems(ICollection<ISchedule> schedules, DateTime startDate, DateTime endDate)
	{
		startDate = startDate.AddSeconds(1.0);
		endDate = endDate.AddSeconds(-1.0);
		InstanceOf<IRelationshipFilter> instanceOf = new InstanceOf<IRelationshipFilter>();
		instanceOf.New.Period = new DateTimeRange
		{
			From = startDate,
			To = endDate
		};
		instanceOf.New.Schedules = (ISet<ISchedule>)(object)new HashedSet<ISchedule>(schedules);
		IRelationshipFilter filter = instanceOf.New;
		EleWise.ELMA.Security.Models.IUser[] owners = (from s in schedules
			where s.Owner != null
			select s.Owner).ToArray();
		List<IRelationship> list = new List<IRelationship>();
		SecurityService.RunWithElevatedPrivilegies(delegate
		{
			list = RelationshipManager.Find(filter, FetchOptions.All).ToList();
		});
		return (from s in ((IEnumerable<ISchedule>)schedules).ToDictionary((Func<ISchedule, ISchedule>)((ISchedule schedule) => schedule), (Func<ISchedule, ICollection<ICalendarItem>>)delegate(ISchedule schedule)
			{
				bool hasPermission = SecurityService.HasPermission(EleWise.ELMA.Calendar.PermissionProvider.ScheduleViewPermission, schedule);
				return (from e in list
					where (from eu in (IEnumerable<IRelationshipUser>)e.RelationshipUsers
						where eu.Status == RelationshipUserStatus.Participant
						select eu.User).Contains(schedule.Owner) || ((ICollection<ISchedule>)e.Schedules).Contains(schedule)
					select e into r
					select new RelationshipCalendarItem(r, owners)
					{
						OnlyInfo = (!hasPermission && !SecurityService.HasPermission(CRMPermissionProvider.CRMAccessPermission))
					}).Cast<ICalendarItem>().ToList();
			})
			where s.Value.Any()
			select s).ToDictionary((KeyValuePair<ISchedule, ICollection<ICalendarItem>> s) => s.Key, (KeyValuePair<ISchedule, ICollection<ICalendarItem>> s) => s.Value);
	}

	public ICollection<ICalendarPlannedItem> GetRePlannedItems(EleWise.ELMA.Security.Models.IUser user)
	{
		return new Collection<ICalendarPlannedItem>();
	}

	public ICollection<ICalendarPlannedItem> GetUnPlannedItems(EleWise.ELMA.Security.Models.IUser user)
	{
		return new Collection<ICalendarPlannedItem>();
	}

	public ICalendarItem AddItem(EleWise.ELMA.Security.Models.IUser user, string id, DateTime startDate, DateTime endDate, bool removeOther)
	{
		return null;
	}

	public ICalendarItem ModifyTime(string id, int dayDelta, int minuteDelta, bool moved)
	{
		IRelationship relationship = CheckRelationship(id);
		DateTime dateTime = (moved ? relationship.StartDate.AddDays(dayDelta).AddMinutes(minuteDelta) : relationship.StartDate);
		DateTime dateTime2 = relationship.EndDate.AddDays(dayDelta).AddMinutes(minuteDelta);
		if (dateTime == dateTime2)
		{
			dateTime2 = dateTime2.AddMinutes(RelationshipManager.GetDefaultDurationByEntityTypeUid(relationship.TypeUid));
		}
		RelationshipManager.ChangeTime(relationship.Id, dateTime, dateTime2, null);
		return new RelationshipCalendarItem(relationship, new List<EleWise.ELMA.Security.Models.IUser>());
	}

	public ICalendarItem ModifyTime(string id, DateTime startDate, DateTime endDate)
	{
		IRelationship relationship = CheckRelationship(id);
		if (startDate == endDate)
		{
			endDate = endDate.AddMinutes(RelationshipManager.GetDefaultDurationByEntityTypeUid(relationship.TypeUid));
		}
		RelationshipManager.ChangeTime(relationship.Id, startDate, endDate, null);
		return new RelationshipCalendarItem(relationship, new List<EleWise.ELMA.Security.Models.IUser>());
	}

	private IRelationship CheckRelationship(string id)
	{
		IRelationship relationship = null;
		SecurityService.RunWithElevatedPrivilegies(delegate
		{
			relationship = RelationshipManager.LoadOrNull(long.Parse(id));
		});
		if (relationship == null)
		{
			throw new Exception(SR.T("Не найдено взаимоотношение"));
		}
		if (((!relationship.Completed.HasValue || !relationship.Completed.Value) && relationship.CreationAuthor == CurrentUser) || UserManager.Instance.IsSubordinateUser(CurrentUser, relationship.CreationAuthor))
		{
			return relationship;
		}
		throw new Exception(SR.T("Взаимоотношение закрыто или нет доступа на изменение"));
	}

	public void Remove(string id)
	{
		IRelationship relationship = null;
		SecurityService.RunWithElevatedPrivilegies(delegate
		{
			relationship = RelationshipManager.LoadOrNull(long.Parse(id));
		});
		if (relationship == null)
		{
			throw new Exception(SR.T("Не найдено взаимоотношение"));
		}
		if (((!relationship.Completed.HasValue || !relationship.Completed.Value) && relationship.CreationAuthor == CurrentUser) || UserManager.Instance.IsSubordinateUser(CurrentUser, relationship.CreationAuthor))
		{
			long currentParentEntityId = 0L;
			Guid currentParentEntityUid = Guid.Empty;
			RelationshipManager.Instance.DeleteRelationship(relationship, out currentParentEntityUid, out currentParentEntityId);
			return;
		}
		throw new Exception(SR.T("Взаимоотношение закрыто или нет доступа на изменение"));
	}

	public void FillData(Guid typeUid, long id, ICollection<EleWise.ELMA.Security.Models.IUser> owners, ICollection<ISchedule> schedules)
	{
		IRelationship relationship = RelationshipManager.Instance.Load(id);
		foreach (IRelationshipUser item in ((IEnumerable<IRelationshipUser>)relationship.RelationshipUsers).Where((IRelationshipUser relUser) => relUser.Status == RelationshipUserStatus.Participant))
		{
			owners.Add(item.User);
		}
		foreach (ISchedule item2 in (IEnumerable<ISchedule>)relationship.Schedules)
		{
			schedules.Add(item2);
		}
	}
}
