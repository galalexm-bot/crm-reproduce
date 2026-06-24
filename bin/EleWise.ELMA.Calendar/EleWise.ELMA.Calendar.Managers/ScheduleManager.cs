using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Cache.Attributes;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using NHibernate;
using NHibernate.Criterion;

namespace EleWise.ELMA.Calendar.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class ScheduleManager : EntityManager<ISchedule, long>
{
	public new static ScheduleManager Instance => Locator.GetServiceNotNull<ScheduleManager>();

	public override void SetupFilter(ICriteria criteria, IEntityFilter filter)
	{
		base.SetupFilter(criteria, filter);
		if (filter is IScheduleFilter scheduleFilter)
		{
			if (scheduleFilter.Shared.HasValue)
			{
				criteria.Add((ICriterion)(object)(scheduleFilter.Shared.Value ? Restrictions.IsNull("Owner") : Restrictions.IsNotNull("Owner")));
			}
			if (scheduleFilter.Owners != null && ((IEnumerable<IUser>)scheduleFilter.Owners).Any())
			{
				object[] array = ((IEnumerable<IUser>)scheduleFilter.Owners).ToArray();
				criteria.Add((ICriterion)(object)Restrictions.In("Owner", array));
			}
		}
	}

	public virtual ISchedule GetUserSchedule(IUser user)
	{
		Contract.ArgumentNotNull(user, "user");
		IEnumerable<ISchedule> userSchedules = GetUserSchedules(new IUser[1] { user });
		return userSchedules.First();
	}

	[ContextCache]
	[Transaction]
	public virtual IEnumerable<ISchedule> GetUserSchedules(IList<IUser> users)
	{
		Contract.CheckArgument(users.Count > 0, "users.Count > 0");
		IList<ISchedule> list = CreateCriteria(new Filter
		{
			DisableSecurity = true
		}).Add((ICriterion)(object)Restrictions.In("Owner.Id", users.Select((IUser user) => user.GetId()).ToArray())).List<ISchedule>();
		if (users.Count != list.Count)
		{
			IEnumerable<IUser> enumerable = users.Except(list.Select((ISchedule schedule) => schedule.Owner));
			foreach (IUser item in enumerable)
			{
				InstanceOf<ISchedule> instanceOf = new InstanceOf<ISchedule>();
				instanceOf.New.Name = item.FullName;
				instanceOf.New.Owner = item;
				ISchedule @new = instanceOf.New;
				@new.Save();
				list.Add(@new);
			}
		}
		return list;
	}

	public virtual ISchedule GetCurrentUserSchedule()
	{
		return GetUserSchedule(base.AuthenticationService.GetCurrentUser<IUser>());
	}
}
