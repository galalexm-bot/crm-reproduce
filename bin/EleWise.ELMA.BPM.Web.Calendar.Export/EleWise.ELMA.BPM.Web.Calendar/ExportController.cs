using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Calendar.Extensions;
using EleWise.ELMA.BPM.Web.Calendar.Models;
using EleWise.ELMA.BPM.Web.Common.Extensions;
using EleWise.ELMA.Calendar;
using EleWise.ELMA.Calendar.Export.Extensions;
using EleWise.ELMA.Calendar.Export.Models;
using EleWise.ELMA.Calendar.Managers;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Runtime.Settings;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Extensions;

namespace EleWise.ELMA.BPM.Web.Calendar.Export.Controllers;

public class ExportController : BPMController<ISchedule, long>
{
	public ActionResult Export(InternetCalendarPeriod? timeInterval)
	{
		ScheduleState scheduleState = StateExtensions.LoadState<ScheduleState>("/calendar/FullCalendar");
		DateTime start = default(DateTime);
		DateTime end = default(DateTime);
		CalendarExtensions.CalendarDateRange(scheduleState.ViewDate, 0, scheduleState.Mode, out start, out end);
		CalendarItemsExportProvider serviceNotNull = Locator.GetServiceNotNull<CalendarItemsExportProvider>();
		DateTimeRange dateTimeRange = serviceNotNull.CreateDateRange(timeInterval, new DateTimeRange(start, end));
		ISchedule currentSchedule = serviceNotNull.GetCurrentSchedule(base.SecurityService);
		string applicationBaseUrl = Locator.GetServiceNotNull<CommonSettingsModule>().Settings.ApplicationBaseUrl;
		byte[] fileContents = serviceNotNull.ConvertToiCal(currentSchedule, dateTimeRange, (ICalendarItem it) => applicationBaseUrl + ((Controller)this).get_Url().ObjectLink(it));
		Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser();
		return (ActionResult)(object)File(fileContents, "text/calendar; charset=utf-8", currentSchedule.Name.ToTranslitIdent() + ".ics");
	}

	public ISchedule GetCurrentSchedule()
	{
		InstanceOf<IScheduleLogFilter> instanceOf = new InstanceOf<IScheduleLogFilter>();
		instanceOf.New.User = base.AuthenticationService.GetCurrentUser<IUser>();
		IScheduleLogFilter @new = instanceOf.New;
		List<IScheduleLog> source = (from sl in Locator.GetServiceNotNull<ScheduleLogManager>().Find(@new, new FetchOptions(0, 1, ListSortDirection.Descending, "ViewDate"))
			where sl != null && sl.Schedule != null && base.SecurityService.CanCheckPermission(PermissionProvider.ScheduleViewPermission, sl.Schedule) && base.SecurityService.HasPermission(PermissionProvider.ScheduleViewPermission, sl.Schedule)
			select sl).ToList();
		if (!source.Any())
		{
			return ScheduleManager.Instance.GetCurrentUserSchedule();
		}
		return source.First().Schedule;
	}
}
