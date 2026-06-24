using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Actions;
using EleWise.ELMA.Cache.Attributes;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Projects.Models.Resources;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using NHibernate;
using NHibernate.Criterion;

namespace EleWise.ELMA.Calendar.Managers;

[Component(EnableInterceptiors = true)]
public class ResourceCalendarManager : EntityManager<IResourceCalendar, long>
{
	public new static ResourceCalendarManager Instance => Locator.GetServiceNotNull<ResourceCalendarManager>();

	[ContextCache]
	public virtual IResourceCalendar GetGlobal()
	{
		return Load(CalendarConstants.GlobalProductionScheduleEntityUid);
	}

	public IResourceCalendar GetByUser(EleWise.ELMA.Security.IUser user)
	{
		EleWise.ELMA.Security.Models.IUser user2 = (user as EleWise.ELMA.Security.Models.IUser) ?? UserManager.Instance.Load((long)user.GetId());
		IResourceCalendarUserMapFilter resourceCalendarUserMapFilter = InterfaceActivator.Create<IResourceCalendarUserMapFilter>();
		resourceCalendarUserMapFilter.User = user2;
		IResourceCalendarUserMap resourceCalendarUserMap = EntityManager<IResourceCalendarUserMap>.Instance.Find(resourceCalendarUserMapFilter, new FetchOptions(0, 1)).FirstOrDefault();
		return (resourceCalendarUserMap != null && resourceCalendarUserMap.Calendar != null) ? resourceCalendarUserMap.Calendar : GetGlobal();
	}

	public IDictionary<EleWise.ELMA.Security.Models.IUser, IResourceCalendar> GetByManyUserIds(IList<EleWise.ELMA.Security.Models.IUser> users)
	{
		IResourceCalendar global = GetGlobal();
		Dictionary<long, IResourceCalendar> result = new Dictionary<long, IResourceCalendar>();
		CreateCriteria(FetchOptions.All, InterfaceActivator.TypeOf<IResourceCalendarUserMap>()).SetFetchMode("Calendar", (FetchMode)2).Add((ICriterion)(object)Restrictions.In("User", (ICollection)users)).SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.ProjectionList().Add((IProjection)(object)Projections.GroupProperty("User")).Add((IProjection)(object)Projections.GroupProperty("Calendar")) })
			.List<object[]>()
			.ForEach(delegate(object[] o)
			{
				if (o[0] is EleWise.ELMA.Security.Models.IUser user && !result.ContainsKey(user.Id))
				{
					result.Add(user.Id, (o[1] as IResourceCalendar) ?? global);
				}
			});
		return users.ToDictionary((EleWise.ELMA.Security.Models.IUser k) => k, (EleWise.ELMA.Security.Models.IUser v) => result.ContainsKey(v.Id) ? result[v.Id] : global);
	}

	public override void SetupFilter(ICriteria criteria, IEntityFilter filter)
	{
		base.SetupFilter(criteria, filter);
		if (filter is IResourceCalendarFilter resourceCalendarFilter && (!resourceCalendarFilter.AllCalendars.HasValue || !resourceCalendarFilter.AllCalendars.Value))
		{
			criteria.Add((ICriterion)(object)Restrictions.Eq("IsCatalog", (object)true));
		}
	}

	public override ActionCheckResult CanSave(IResourceCalendar obj)
	{
		if (!((IEnumerable<IBaseTimeInterval>)obj.BaseIntervals).Any())
		{
			EleWise.ELMA.Logging.Logger.Log.Error(SR.T("Невозможно сохранить производственный календарь - коллекция базовых интервалов пуста"));
			return ActionCheckResult.False(SR.T("Невозможно сохранить производственный календарь - коллекция базовых интервалов пуста"));
		}
		if (((IEnumerable<IBaseTimeInterval>)obj.BaseIntervals).Any((IBaseTimeInterval bi) => bi.Start >= bi.Finish))
		{
			EleWise.ELMA.Logging.Logger.Log.Error(SR.T("Невозможно сохранить производственный календарь - базовые интервалы заданы некорректно"));
			foreach (IBaseTimeInterval item in ((IEnumerable<IBaseTimeInterval>)obj.BaseIntervals).Where((IBaseTimeInterval bi) => bi.Start >= bi.Finish))
			{
				EleWise.ELMA.Logging.Logger.Log.Error(SR.T("Некорректный базовый интервал ({0}-{1})", item.Start, item.Finish));
			}
			return ActionCheckResult.False(SR.T("Невозможно сохранить производственный календарь - базовые интервалы заданы некорректно"));
		}
		if (!((IEnumerable<IWorkTimeInterval>)obj.WorkIntervals).Any((IWorkTimeInterval wi) => wi.DayOfWeek.HasValue))
		{
			EleWise.ELMA.Logging.Logger.Log.Error(SR.T("Невозможно сохранить производственный календарь - коллекция интервалов дней недели пуста"));
			return ActionCheckResult.False(SR.T("Невозможно сохранить производственный календарь - коллекция интервалов дней недели пуста"));
		}
		if (((IEnumerable<IWorkTimeInterval>)obj.WorkIntervals).Any((IWorkTimeInterval wi) => wi.Start >= wi.Finish))
		{
			EleWise.ELMA.Logging.Logger.Log.Error(SR.T("Невозможно сохранить производственный календарь - рабочие интервалы заданы некорректно"));
			foreach (IWorkTimeInterval item2 in ((IEnumerable<IWorkTimeInterval>)obj.WorkIntervals).Where((IWorkTimeInterval wi) => wi.Start >= wi.Finish))
			{
				EleWise.ELMA.Logging.Logger.Log.Error(SR.T("Некорректный рабочий интервал ({0}: {1}-{2})", item2.DayOfWeek.HasValue ? item2.DayOfWeek.ToString() : $"{item2.DateExceptionStart} - {item2.DateExceptionFinish}", item2.Start, item2.Finish));
			}
			return ActionCheckResult.False(SR.T("Невозможно сохранить производственный календарь - рабочие интервалы заданы некорректно"));
		}
		foreach (IWorkTimeInterval item3 in ((IEnumerable<IWorkTimeInterval>)obj.WorkIntervals).Where((IWorkTimeInterval wi) => !wi.DayOfWeek.HasValue && wi.DateExceptionStart.HasValue && wi.DateExceptionFinish.HasValue))
		{
			if (item3.DateExceptionStart.Value.ToClientDateTime(TZ.Server).TimeOfDay != TimeSpan.Zero)
			{
				EleWise.ELMA.Logging.Logger.Log.Error(SR.T("Дата начала периода рабочего интервала исключительного дня некорректна"));
				return ActionCheckResult.False(SR.T("Дата начала периода рабочего интервала исключительного дня некорректна"));
			}
			if (item3.DateExceptionFinish.Value.ToClientDateTime(TZ.Server).TimeOfDay != TimeSpan.Zero)
			{
				EleWise.ELMA.Logging.Logger.Log.Error(SR.T("Дата завершения периода рабочего интервала исключительного дня некорректна"));
				return ActionCheckResult.False(SR.T("Дата завершения периода рабочего интервала исключительного дня некорректна"));
			}
		}
		return ActionCheckResult.True;
	}

	[Transaction]
	public virtual void DeleteBaseTimeIntervalCollectionImmediately(IResourceCalendar productionSchedule, IEnumerable<IBaseTimeInterval> baseTimeIntervalCollection)
	{
		foreach (IBaseTimeInterval item in baseTimeIntervalCollection.ToList())
		{
			((ICollection<IBaseTimeInterval>)productionSchedule.BaseIntervals).Remove(item);
			item.Delete();
		}
	}

	[Transaction]
	public virtual void DeleteWorkingTimeIntervalCollectionImmediately(IResourceCalendar productionSchedule, IEnumerable<IWorkTimeInterval> workingTimeIntervalCollection)
	{
		foreach (IWorkTimeInterval item in workingTimeIntervalCollection.ToList())
		{
			((ICollection<IWorkTimeInterval>)productionSchedule.WorkIntervals).Remove(item);
			item.Delete();
		}
	}

	[Transaction]
	public virtual void DeleteHolidayIntervalCollectionImmediately(IResourceCalendar productionSchedule, IEnumerable<IHolidayInterval> holidayIntervalCollection)
	{
		foreach (IHolidayInterval item in holidayIntervalCollection.ToList())
		{
			((ICollection<IHolidayInterval>)productionSchedule.HolidayIntervals).Remove(item);
			item.Delete();
		}
	}

	public void FillWithDefaultBaseIntervalCollection(IResourceCalendar productionSchedule)
	{
		IResourceCalendar global = GetGlobal();
		foreach (IBaseTimeInterval item in (IEnumerable<IBaseTimeInterval>)global.BaseIntervals)
		{
			IBaseTimeInterval baseTimeInterval = EntityManager<IBaseTimeInterval>.Instance.Create();
			baseTimeInterval.Calendar = productionSchedule;
			baseTimeInterval.Start = item.Start;
			baseTimeInterval.Finish = item.Finish;
			productionSchedule.BaseIntervals.Add(baseTimeInterval);
		}
	}

	public void AddFiveDayWorkingWeekByBaseIntervals(IResourceCalendar productionSchedule)
	{
		if (((IEnumerable<IWorkTimeInterval>)productionSchedule.WorkIntervals).Any((IWorkTimeInterval wi) => wi.DayOfWeek.HasValue))
		{
			return;
		}
		List<IWorkTimeInterval> list = new List<IWorkTimeInterval>();
		for (int i = 1; i <= 5; i++)
		{
			foreach (IBaseTimeInterval item in (IEnumerable<IBaseTimeInterval>)productionSchedule.BaseIntervals)
			{
				IWorkTimeInterval workTimeInterval = EntityManager<IWorkTimeInterval>.Instance.Create();
				workTimeInterval.Calendar = productionSchedule;
				workTimeInterval.DayOfWeek = i;
				workTimeInterval.DateExceptionStart = null;
				workTimeInterval.DateExceptionFinish = null;
				workTimeInterval.Start = item.Start;
				workTimeInterval.Finish = item.Finish;
				list.Add(workTimeInterval);
			}
		}
		productionSchedule.WorkIntervals.AddAll((ICollection<IWorkTimeInterval>)list);
	}

	internal void FillWithBaseIntervalsByGlobalProductionSchedule()
	{
		IResourceCalendarFilter resourceCalendarFilter = InterfaceActivator.Create<IResourceCalendarFilter>();
		resourceCalendarFilter.Query = $"BaseIntervals IS EMPTY AND Uid <> Guid('{CalendarConstants.GlobalProductionScheduleEntityUid}')";
		resourceCalendarFilter.AllCalendars = true;
		ICriteria val = CreateCriteria(resourceCalendarFilter);
		SetupFilter(val, resourceCalendarFilter);
		IList<IResourceCalendar> list = val.List<IResourceCalendar>();
		foreach (IResourceCalendar item in list)
		{
			FillWithDefaultBaseIntervalCollection(item);
			AddFiveDayWorkingWeekByBaseIntervals(item);
			item.Save();
		}
	}
}
