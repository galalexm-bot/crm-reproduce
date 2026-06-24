using System;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using NHibernate.Criterion;

namespace EleWise.ELMA.Calendar.Managers;

public class ScheduleLogManager : EntityManager<IScheduleLog, long>
{
	private ITransformationProvider transformationProvider;

	[NotNull]
	public new static ScheduleLogManager Instance => Locator.GetServiceNotNull<ScheduleLogManager>();

	public ScheduleLogManager(ITransformationProvider transformationProvider)
	{
		this.transformationProvider = transformationProvider;
	}

	[Transaction]
	public virtual void Visit(ISchedule schedule, IUser user)
	{
		if (schedule != null && user != null)
		{
			IScheduleLog scheduleLog = CreateCriteria().Add((ICriterion)(object)Restrictions.Eq("User.Id", (object)user.Id)).Add((ICriterion)(object)Restrictions.Eq("Schedule.Id", (object)schedule.Id)).UniqueResult<IScheduleLog>();
			if (scheduleLog == null)
			{
				InstanceOf<IScheduleLog> instanceOf = new InstanceOf<IScheduleLog>();
				instanceOf.New.Schedule = schedule;
				instanceOf.New.User = user;
				instanceOf.New.Favorite = false;
				scheduleLog = instanceOf.New;
			}
			IScheduleLog scheduleLog2 = scheduleLog;
			scheduleLog2.ViewDate = DateTime.Now;
			scheduleLog2.Save();
		}
	}

	[Transaction]
	public virtual void SetFavorite(ISchedule schedule, IUser user, bool favorite)
	{
		if (schedule == null || user == null)
		{
			return;
		}
		IScheduleLog scheduleLog = CreateCriteria().Add((ICriterion)(object)Restrictions.Eq("User.Id", (object)user.Id)).Add((ICriterion)(object)Restrictions.Eq("Schedule.Id", (object)schedule.Id)).UniqueResult<IScheduleLog>();
		if (scheduleLog != null)
		{
			if (favorite)
			{
				scheduleLog.Favorite = favorite;
				scheduleLog.Save();
			}
			else
			{
				scheduleLog.Delete();
			}
		}
	}
}
