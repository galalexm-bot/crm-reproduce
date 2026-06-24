using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Activation;
using EleWise.ELMA.API;
using EleWise.ELMA.API.Models;
using EleWise.ELMA.Calendar.API.Models;
using EleWise.ELMA.Calendar.Managers;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.Calendar.Services;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Services.Public;
using EleWise.ELMA.Web.Service;
using EleWise.ELMA.Web.Service.v1;

namespace EleWise.ELMA.Calendar.API.Service.v1;

[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, MaxItemsInObjectGraph = int.MaxValue)]
[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
[ServiceKnownType("GetGlobalKnownTypes", typeof(ServiceKnownTypeHelper))]
[Component]
[Uid("{EE107E02-E151-43B6-8951-4BA0FD8CAD1E}")]
public class CalendarService : ICalendarService, IPublicAPIWebService
{
	public const string GuidS = "{EE107E02-E151-43B6-8951-4BA0FD8CAD1E}";

	public static Guid Guid = new Guid("{EE107E02-E151-43B6-8951-4BA0FD8CAD1E}");

	private static IAvailableTimeSlotsService AvailableTimeSlotsService => Locator.GetServiceNotNull<IAvailableTimeSlotsService>();

	public bool SetPackagesPeriod(int months)
	{
		IPublicClientSession session = Locator.GetServiceNotNull<IPublicClientService>().GetSession(PackageChangesService.AuthToken);
		if (session == null)
		{
			throw PublicServiceException.CreateWebFault(SR.T("Ошибка авторизации"), 401);
		}
		DataAccessManager.BLOBManager.SetBLOB(Guid, session.SessionToken, months);
		return true;
	}

	public CalendarItemWCF[] CalendarItems(DateTime startDate, DateTime endDate)
	{
		IEnumerable<IUpdatePackageCalendarItemProvider> extensionPoints = ComponentManager.Current.GetExtensionPoints<IUpdatePackageCalendarItemProvider>();
		ISchedule[] schedules = new ISchedule[1] { ScheduleManager.Instance.GetUserSchedule(AuthenticationService.GetCurrentUser<IUser>()) };
		return extensionPoints.SelectMany((IUpdatePackageCalendarItemProvider p) => from i in p.GetItems(schedules, startDate, endDate)
			select new CalendarItemWCF(i)).ToArray();
	}

	public ProductionScheduleWCF GetProductionSchedule()
	{
		return new ProductionScheduleWCF(ResourceCalendarManager.Instance.GetByUser(UserManager.Instance.GetCurrentUser()));
	}

	public TimeSlot[] GetAvailableTimeSlots(TimeSlotsData data)
	{
		ICollection<IUser> users = UserManager.Instance.FindByIdArray(data.Users.Ids);
		return AvailableTimeSlotsService.GetIntervals(users, data.TimeSlots).ToArray();
	}
}
