using System;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Calendar.Export.Models;
using EleWise.ELMA.Calendar.Export.Managers;
using EleWise.ELMA.Calendar.Export.Models;
using EleWise.ELMA.Calendar.Managers;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Binders;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.BPM.Web.Calendar.Export.Controllers;

public class ExternalCalendarController : BPMController<IExternalCalendar, long>
{
	[CustomGridAction]
	public ActionResult Grid(GridCommand command, [Bind(Prefix = "DataFilter")] IExternalCalendarFilter filter, bool shared)
	{
		if (filter == null)
		{
			filter = InterfaceActivator.Create<IExternalCalendarFilter>();
		}
		if (!shared)
		{
			filter.ScheduleOwner = base.AuthenticationService.GetCurrentUser<IUser>();
		}
		else
		{
			filter.SharedOnly = true;
		}
		GridData<IExternalCalendar, IExternalCalendarFilter> gridData = CreateGridData(command, filter);
		return (ActionResult)(object)((Controller)this).PartialView((object)gridData);
	}

	[HttpPost]
	public ActionResult Delete(long id)
	{
		try
		{
			ExternalCalendarManager.Instance.Load(id).Delete();
		}
		catch (Exception ex)
		{
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				success = false,
				error = ex.Message
			});
		}
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			success = true
		});
	}

	[HttpGet]
	public ActionResult Edit(long? id, long? scheduleId)
	{
		IExternalCalendar externalCalendar;
		if (!id.HasValue)
		{
			InstanceOf<IExternalCalendar> instanceOf = new InstanceOf<IExternalCalendar>();
			instanceOf.New.Schedule = (scheduleId.HasValue ? ScheduleManager.Instance.Load(scheduleId.Value) : null);
			externalCalendar = instanceOf.New;
		}
		else
		{
			externalCalendar = ExternalCalendarManager.Instance.LoadOrNull(id.Value);
		}
		IExternalCalendar externalCalendar2 = externalCalendar;
		return (ActionResult)(object)((Controller)this).PartialView((object)externalCalendar2);
	}

	[HttpPost]
	public ActionResult Edit(IExternalCalendar model)
	{
		string text = null;
		try
		{
			if (!((Controller)this).get_ModelState().get_IsValid())
			{
				throw new Exception(SR.T("Не заполнены обязательные поля"));
			}
			model.Save();
		}
		catch (Exception ex)
		{
			EleWise.ELMA.Logging.Logger.Log.Error(SR.T("Ошибка добавления внешнего календаря"), ex);
			text = SR.T("Ошибка добавления внешнего календаря: {0}", ex.Message);
		}
		ExternalCalendarManager.Instance.GetCalendarEvents(model, DateTime.Now, DateTime.Now);
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			success = string.IsNullOrEmpty(text),
			error = text
		}, "text/html");
	}

	public ActionResult ViewItem(long id, string itemId, [ModelBinder(typeof(DateTimeNoOffsetBinder))] DateTime startDate, [ModelBinder(typeof(DateTimeNoOffsetBinder))] DateTime endDate)
	{
		try
		{
			IExternalCalendar calendar = ExternalCalendarManager.Instance.Load(id);
			ExternalCalendarItem externalCalendarItem = ExternalCalendarManager.Instance.GetCalendarEvents(calendar, startDate, endDate).FirstOrDefault((ExternalCalendarItem e) => e.Id == itemId);
			if (externalCalendarItem == null)
			{
				throw new Exception(SR.T("Событие не найдено ({0})", itemId));
			}
			return (ActionResult)(object)((Controller)this).View((object)new ExternalCalendarEventModel
			{
				Calendar = calendar,
				Item = externalCalendarItem
			});
		}
		catch (Exception exception)
		{
			FormNotifierExtensions.Error(base.Notifier, exception);
			return (ActionResult)(object)((Controller)this).Redirect(((Controller)this).get_Url().ReturnUrl(redirectHomeIfNull: true));
		}
	}

	public ActionResult ExternalCalendarTab(long? scheduleId)
	{
		ISchedule schedule = (scheduleId.HasValue ? ScheduleManager.Instance.Load(scheduleId.Value) : ScheduleManager.Instance.GetCurrentUserSchedule());
		return (ActionResult)(object)((Controller)this).PartialView((object)schedule);
	}
}
