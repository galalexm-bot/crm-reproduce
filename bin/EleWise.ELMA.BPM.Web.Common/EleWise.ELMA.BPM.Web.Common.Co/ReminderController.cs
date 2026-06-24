using System;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.Common.Extensions;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.BPM.Web.Common.Controllers;

[RouteArea("EleWise.ELMA.BPM.Web.Common")]
public class ReminderController : BPMController<IReminder, long>
{
	public ActionResult Popup(Guid objectType, long objectId, string propertyName, DateTime? originalDate, bool? periodical)
	{
		ReminderModel reminderModel = new ReminderModel
		{
			PropertyName = propertyName,
			OriginalDate = originalDate,
			RemindDate = originalDate,
			RefObject = ReferenceOnEntity.Create(objectType, objectId),
			Periodical = (periodical ?? false)
		};
		if (reminderModel.Entity == null)
		{
			throw new ArgumentException("Entity is null");
		}
		if (string.IsNullOrEmpty(reminderModel.PropertyName))
		{
			throw new ArgumentException("PropertyName is null or empty");
		}
		IReminderFilter reminderFilter = InterfaceActivator.Create<IReminderFilter>();
		reminderFilter.RefObject = reminderModel.RefObject;
		reminderFilter.PropertyName = reminderModel.PropertyName;
		reminderFilter.CreationAuthor = GetCurrentUser();
		reminderModel.Reminders = base.Manager.Find(reminderFilter, FetchOptions.All);
		return (ActionResult)(object)((Controller)this).PartialView((object)reminderModel);
	}

	public ActionResult Reminders(Guid objectType, long objectId, string propertyName, DateTime? originalDate, bool? periodical)
	{
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		ReferenceOnEntity referenceOnEntity = ReferenceOnEntity.Create(objectType, objectId);
		if (referenceOnEntity.Object == null)
		{
			throw new ArgumentException("Entity is null");
		}
		if (string.IsNullOrEmpty(propertyName))
		{
			throw new ArgumentException("PropertyName is null or empty");
		}
		IReminderFilter reminderFilter = InterfaceActivator.Create<IReminderFilter>();
		reminderFilter.RefObject = referenceOnEntity;
		reminderFilter.PropertyName = propertyName;
		reminderFilter.CreationAuthor = GetCurrentUser();
		IOrderedEnumerable<IReminder> source = from r in base.Manager.Find(reminderFilter, FetchOptions.All)
			where !r.RemindDate.HasValue || r.RemindDate.Value >= DateTime.Now
			orderby r.RemindTo descending
			select r;
		ContentResult val = new ContentResult();
		val.set_Content(string.Join(", ", from r in source.Take(2)
			select SR.T("За") + " " + r.GetRemindString()) + ((source.Count() > 2) ? " ..." : ""));
		return (ActionResult)val;
	}

	public ActionResult Delete(IReminder reminder)
	{
		if (reminder.CreationAuthor == base.AuthenticationService.GetCurrentUser())
		{
			IReminder template = null;
			if (!reminder.RemindDate.HasValue)
			{
				template = reminder;
			}
			else if (reminder.Template != null)
			{
				template = reminder.Template;
			}
			if (template != null)
			{
				foreach (IReminder item in base.Manager.Find((IReminder f) => f.Template == template))
				{
					item.Delete();
				}
				template.Delete();
			}
			else
			{
				reminder.Delete();
			}
			return SuccessJson();
		}
		return ErrorJson(SR.T("Нет доступа к напоминанию"));
	}

	[HttpPost]
	public ActionResult Save(Guid objectType, long objectId, string propertyName, DateTime? originalDate, int reminderTime, ReminderTimeTypes reminderTimeType, bool? reminderPeriodical, bool? relativeDate, DateTime? remindDate)
	{
		ReferenceOnEntity referenceOnEntity = ReferenceOnEntity.Create(objectType, objectId);
		if (referenceOnEntity.Object == null)
		{
			throw new ArgumentException("Entity is null");
		}
		if (string.IsNullOrEmpty(propertyName))
		{
			throw new ArgumentException("PropertyName is null or empty");
		}
		if (reminderTime <= 0)
		{
			throw new ArgumentException("time");
		}
		if ((!relativeDate.HasValue && !remindDate.HasValue) || !originalDate.HasValue)
		{
			return SuccessJson();
		}
		IReminder reminder = InterfaceActivator.Create<IReminder>();
		reminder.RefObject = referenceOnEntity;
		reminder.PropertyName = propertyName;
		if (relativeDate.Value)
		{
			switch (reminderTimeType)
			{
			case ReminderTimeTypes.Hours:
				reminder.RemindTo = TimeSpan.FromHours(reminderTime);
				break;
			case ReminderTimeTypes.Days:
				reminder.RemindTo = TimeSpan.FromDays(reminderTime);
				break;
			case ReminderTimeTypes.Weekly:
				reminder.RemindTo = TimeSpan.FromDays(reminderTime * 7);
				break;
			default:
				reminder.RemindTo = TimeSpan.FromMinutes(reminderTime);
				break;
			}
		}
		else
		{
			reminder.RemindTo = originalDate.Value - remindDate.Value;
		}
		reminder.RemindDate = originalDate.Value.Add(-reminder.RemindTo);
		if (reminderPeriodical.HasValue && reminderPeriodical.Value)
		{
			ComponentManager.Current.GetExtensionPoints<ICreateReminderExtended>().FirstOrDefault((ICreateReminderExtended p) => p.Check(reminder))?.Create(reminder);
		}
		reminder.Save();
		return SuccessJson();
	}
}
