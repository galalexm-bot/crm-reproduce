using System;
using EleWise.ELMA.Calendar.Export.Models;
using EleWise.ELMA.Calendar.Managers;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using NHibernate;
using NHibernate.Criterion;

namespace EleWise.ELMA.Calendar.Export.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class InternetCalendarManager : EntityManager<IInternetCalendar, long>
{
	public new static InternetCalendarManager Instance => Locator.GetServiceNotNull<InternetCalendarManager>();

	public override void SetupFilter(ICriteria criteria, IEntityFilter filter)
	{
		base.SetupFilter(criteria, filter);
		criteria.Add((ICriterion)(object)Restrictions.Eq("CreationAuthor", (object)base.AuthenticationService.GetCurrentUser<IUser>()));
		DetachedCriteria val = ScheduleManager.Instance.CreateDetachedCriteria(FetchOptions.All, InterfaceActivator.TypeOf<ISchedule>());
		val.SetProjection((IProjection)(object)Projections.Property("Id"));
		criteria.Add((ICriterion)(object)Subqueries.PropertyIn("Calendar.Id", val));
	}

	public void DeleteOnId(long id)
	{
		IInternetCalendar internetCalendar = Load(id);
		if (internetCalendar.CreationAuthor == base.AuthenticationService.GetCurrentUser<IUser>())
		{
			internetCalendar.Delete();
		}
	}

	public void Create(long scheduleId, IInternetCalendar cal = null)
	{
		if (cal == null)
		{
			cal = InterfaceActivator.Create<IInternetCalendar>();
		}
		cal.DynamicUrlPart = Guid.NewGuid();
		cal.Calendar = Locator.GetServiceNotNull<ScheduleManager>().Load(scheduleId);
		Save(cal);
	}
}
