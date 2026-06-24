using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using EleWise.ELMA.Calendar.Export.Models;
using EleWise.ELMA.Calendar.Managers;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Text;
using Ical.Net;
using Ical.Net.DataTypes;
using Ical.Net.Interfaces.DataTypes;
using Ical.Net.Serialization.iCalendar.Serializers;

namespace EleWise.ELMA.Calendar.Export.Extensions;

[Service(Scope = ServiceScope.Shell)]
[DeveloperApi(DeveloperApiType.Service)]
public class CalendarItemsExportProvider
{
	public byte[] ConvertToiCal(ISchedule schedule, DateTimeRange dateTimeRange, Func<ICalendarItem, string> urlGetter)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		Calendar val = new Calendar();
		DateTime startDate = dateTimeRange.From ?? DateTime.Today;
		DateTime endDate = dateTimeRange.To ?? DateTime.Today.AddDays(1.0);
		IEnumerable<ICalendarItemProvider> enumerable = from p in ComponentManager.Current.GetExtensionPoints<ICalendarItemProvider>()
			where !p.External
			select p;
		((CalendarComponent)val).AddProperty("X-WR-CALNAME", schedule.Name);
		foreach (ICalendarItemProvider item in enumerable)
		{
			foreach (ICalendarItem item2 in item.GetItems(schedule, startDate, endDate, checkPermission: false))
			{
				CreateEventItem(item2, val, urlGetter);
			}
		}
		CalendarSerializer val2 = new CalendarSerializer();
		using MemoryStream memoryStream = MemoryHelper.GetMemoryStream();
		((SerializerBase)val2).Serialize((object)val, (Stream)memoryStream, (Encoding)EncodingCache.UTF8WithoutEmitIdentifier);
		return memoryStream.ToArray();
	}

	private void CreateEventItem(ICalendarItem i, Calendar iCal, Func<ICalendarItem, string> urlGetter)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		if (i != null)
		{
			Event obj = iCal.Create<Event>();
			((RecurringComponent)obj).set_Start((IDateTime)new CalDateTime(i.StartDate.ToUniversalTime(), TimeZoneInfo.Utc.StandardName));
			obj.set_End((IDateTime)new CalDateTime(((i.EndDate <= i.StartDate) ? i.StartDate.AddMinutes(5.0) : i.EndDate).ToUniversalTime(), TimeZoneInfo.Utc.StandardName));
			((RecurringComponent)obj).set_Summary(i.Theme);
			((RecurringComponent)obj).set_Description(CreateDescription(i, urlGetter));
			obj.set_Location(i.Place);
		}
	}

	private string CreateDescription(ICalendarItem calItem, Func<ICalendarItem, string> urlGetter)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine(SR.T("URL: ") + urlGetter(calItem) + ";");
		EleWise.ELMA.Security.Models.IUser user = Locator.GetServiceNotNull<UserManager>().LoadOrNull(calItem.CreationAuthor);
		if (user != null)
		{
			stringBuilder.AppendLine(SR.T("Автор: ") + user.GetShortName() + ";");
		}
		stringBuilder.Append(SR.T("Участники: "));
		stringBuilder.AppendLine(string.Join(", ", calItem.EventUsers.Values) + ";");
		if (!string.IsNullOrEmpty(calItem.Description))
		{
			stringBuilder.AppendLine(SR.T("----"));
			stringBuilder.AppendLine(calItem.Description);
		}
		if (calItem.Comments.Count > 0)
		{
			stringBuilder.AppendLine(SR.T("----"));
			stringBuilder.AppendLine(SR.T("Комментарии:"));
			foreach (IComment comment in calItem.Comments)
			{
				stringBuilder.AppendFormat("> {0} - {1} \n{2}\n---- \n", comment.CreationAuthor.FullName, comment.CreationDate.ToString(), comment.Text);
			}
		}
		return stringBuilder.ToString();
	}

	public DateTimeRange CreateDateRange(InternetCalendarPeriod? datePeriod, DateTimeRange? nowDateTimeRange = null, bool takePastEvents = false)
	{
		DateTime value = DateTime.Today;
		DateTime value2 = DateTime.Today.AddDays(1.0);
		switch (datePeriod)
		{
		case InternetCalendarPeriod.Day:
			value = DateTime.Today;
			value2 = DateTime.Today.AddDays(1.0);
			break;
		case InternetCalendarPeriod.Week:
			value = (takePastEvents ? DateTime.Today.AddDays(-7.0) : DateTime.Today);
			value2 = DateTime.Today.AddDays(7.0);
			break;
		case InternetCalendarPeriod.Month:
			value = (takePastEvents ? DateTime.Today.AddMonths(-1) : DateTime.Today);
			value2 = DateTime.Today.AddMonths(1);
			break;
		case InternetCalendarPeriod.ThreeMonths:
			value = (takePastEvents ? DateTime.Today.AddMonths(-3) : DateTime.Today);
			value2 = DateTime.Today.AddMonths(3);
			break;
		default:
			if (nowDateTimeRange.HasValue)
			{
				return nowDateTimeRange.Value;
			}
			break;
		}
		return new DateTimeRange(value, value2);
	}

	public ISchedule GetCurrentSchedule(ISecurityService securityService)
	{
		InstanceOf<IScheduleLogFilter> instanceOf = new InstanceOf<IScheduleLogFilter>();
		instanceOf.New.User = AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
		IScheduleLogFilter @new = instanceOf.New;
		List<IScheduleLog> source = (from sl in Locator.GetServiceNotNull<ScheduleLogManager>().Find(@new, new FetchOptions(0, 1, ListSortDirection.Descending, "ViewDate"))
			where sl != null && sl.Schedule != null && securityService.CanCheckPermission(PermissionProvider.ScheduleViewPermission, sl.Schedule) && securityService.HasPermission(PermissionProvider.ScheduleViewPermission, sl.Schedule)
			select sl).ToList();
		if (!source.Any())
		{
			return ScheduleManager.Instance.GetCurrentUserSchedule();
		}
		return source.First().Schedule;
	}
}
