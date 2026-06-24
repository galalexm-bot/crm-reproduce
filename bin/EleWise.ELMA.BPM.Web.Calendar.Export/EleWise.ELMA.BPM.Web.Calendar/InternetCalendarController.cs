using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Calendar.Export.Models;
using EleWise.ELMA.Calendar;
using EleWise.ELMA.Calendar.Export.Extensions;
using EleWise.ELMA.Calendar.Export.Managers;
using EleWise.ELMA.Calendar.Export.Models;
using EleWise.ELMA.Calendar.Managers;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Settings;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.BPM.Web.Calendar.Export.Controllers;

public class InternetCalendarController : BPMController<IInternetCalendar, long>
{
	public ActionResult List()
	{
		base.ActiveMenuItem = "SchedulerController.CalendarItems";
		return (ActionResult)(object)((Controller)this).View();
	}

	[CustomGridAction]
	public ActionResult Grid(GridCommand command, [Bind(Prefix = "DataFilter")] IInternetCalendarFilter filter)
	{
		GridData<IInternetCalendar, IInternetCalendarFilter> gridData = CreateGridData(command, filter);
		return (ActionResult)(object)((Controller)this).PartialView((object)gridData);
	}

	[HttpGet]
	public ActionResult Create()
	{
		InternetCalendarModel internetCalendarModel = new InternetCalendarModel
		{
			Schedules = (from s in ScheduleManager.Instance.FindAll()
				orderby s.Owner != null
				select s).ToList()
		};
		foreach (InternetCalendarPeriod value in Enum.GetValues(typeof(InternetCalendarPeriod)))
		{
			if (value != InternetCalendarPeriod.CurrentList)
			{
				internetCalendarModel.Periods.Add(new InternetCalPeriodModel
				{
					Name = value.GetDisplayName(),
					Value = value
				});
			}
		}
		return (ActionResult)(object)((Controller)this).PartialView("CreateInternetCalPopup", (object)internetCalendarModel);
	}

	[HttpPost]
	public ActionResult Create(InternetCalendarModel cal)
	{
		string text = null;
		try
		{
			InternetCalendarManager.Instance.Create(cal.ScheduleId, cal.Entity);
		}
		catch (Exception ex)
		{
			text = ex.Message;
		}
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			success = string.IsNullOrEmpty(text),
			error = text
		}, "text/html");
	}

	public ActionResult QuickCreate()
	{
		IInternetCalendar internetCalendar = null;
		ISchedule currentSchedule = Locator.GetServiceNotNull<CalendarItemsExportProvider>().GetCurrentSchedule(base.SecurityService);
		InternetCalendarManager instance = InternetCalendarManager.Instance;
		InstanceOf<IInternetCalendarFilter> instanceOf = new InstanceOf<IInternetCalendarFilter>();
		instanceOf.New.Calendar = currentSchedule;
		instanceOf.New.CreationAuthor = base.AuthenticationService.GetCurrentUser<IUser>();
		instanceOf.New.QuickConnection = true;
		ICollection<IInternetCalendar> collection = instance.Find(instanceOf.New, FetchOptions.All);
		if (collection.Count == 0)
		{
			internetCalendar = InterfaceActivator.Create<IInternetCalendar>();
			internetCalendar.Name = SR.T("Календарь быстрого подключения");
			internetCalendar.QuickConnection = true;
			InternetCalendarManager.Instance.Create(currentSchedule.Id, internetCalendar);
		}
		else
		{
			internetCalendar = collection.First();
		}
		string text = CreateUrl(internetCalendar);
		return (ActionResult)(object)((Controller)this).Json((object)text, (JsonRequestBehavior)0);
	}

	[AuthenticationFilter(NotRequired = true)]
	public ActionResult Private(string id, string fileName)
	{
		Guid guid = Guid.Empty;
		if (!Guid.TryParse(id, out guid))
		{
			return (ActionResult)(object)((Controller)this).HttpNotFound("Неправильная ссылка на интернет календарь");
		}
		ICollection<IInternetCalendar> collection = base.Manager.Find((IInternetCalendar m) => m.DynamicUrlPart == guid);
		if (collection.Count == 0)
		{
			return (ActionResult)(object)((Controller)this).HttpNotFound("Неправильная ссылка на интернет календарь");
		}
		IInternetCalendar internetCalendar = collection.ToArray()[0];
		CalendarItemsExportProvider serviceNotNull = Locator.GetServiceNotNull<CalendarItemsExportProvider>();
		DateTimeRange dateTimeRange = serviceNotNull.CreateDateRange(internetCalendar.Period, null, takePastEvents: true);
		string applicationBaseUrl = Locator.GetServiceNotNull<CommonSettingsModule>().Settings.ApplicationBaseUrl;
		byte[] fileContents = serviceNotNull.ConvertToiCal(internetCalendar.Calendar, dateTimeRange, (ICalendarItem it) => applicationBaseUrl + ((Controller)this).get_Url().ObjectLink(it));
		fileName = fileName ?? ("Calendar - " + internetCalendar.CreationAuthor.UserName + ".ics");
		return (ActionResult)(object)File(fileContents, "text/calendar; charset=utf-8", fileName);
	}

	public ActionResult Delete(long id)
	{
		((InternetCalendarManager)base.Manager).DeleteOnId(id);
		return (ActionResult)(object)((Controller)this).Json((object)true, (JsonRequestBehavior)0);
	}

	public ActionResult InternetCalPopup(long id)
	{
		IInternetCalendar internetCal = base.Manager.Load(id);
		string url = CreateUrl(internetCal);
		InternetCalLinkModel internetCalLinkModel = new InternetCalLinkModel
		{
			Id = id,
			Url = url
		};
		return (ActionResult)(object)((Controller)this).PartialView((object)internetCalLinkModel);
	}

	private string CreateUrl(IInternetCalendar internetCal)
	{
		CommonSettingsModule serviceNotNull = Locator.GetServiceNotNull<CommonSettingsModule>();
		return string.Format("{0}{1}", serviceNotNull.Settings.ApplicationBaseUrl, ((Controller)this).get_Url().Action("Private", "InternetCalendar", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Calendar.Export",
			id = internetCal.DynamicUrlPart,
			fileName = internetCal.Calendar.Name.ToTranslitIdent() + ".ics"
		}));
	}

	public ActionResult UrlGeneration(long iCalId)
	{
		IInternetCalendar internetCalendar = base.Manager.Load(iCalId);
		internetCalendar.DynamicUrlPart = Guid.NewGuid();
		internetCalendar.Save();
		string text = CreateUrl(internetCalendar);
		return (ActionResult)(object)((Controller)this).Json((object)text, (JsonRequestBehavior)0);
	}
}
