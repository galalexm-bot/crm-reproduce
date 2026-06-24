using System;
using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.ExtensionPoints;

[Component]
public class CreateTaskReminder : ICreateReminderExtended
{
	public bool Check(IReminder reminder)
	{
		if (reminder.RefObject == null || reminder.RefObject.Object == null)
		{
			return false;
		}
		if (reminder.RefObject.Object.CastAsRealType() is ITask task)
		{
			if (!task.IsTemplate)
			{
				return task.PeriodTemplate != null;
			}
			return true;
		}
		return false;
	}

	public IReminder Create(IReminder reminder)
	{
		if (reminder.RefObject == null || reminder.RefObject.Object == null)
		{
			return reminder;
		}
		if (!(reminder.RefObject.Object.CastAsRealType() is ITask task))
		{
			return reminder;
		}
		ITask task2 = null;
		IReminder reminder2 = null;
		if (task.IsTemplate)
		{
			task2 = task;
			reminder2 = reminder;
			reminder2.RemindDate = null;
		}
		else if (task.PeriodTemplate != null)
		{
			task2 = task.PeriodTemplate;
			reminder2 = InterfaceActivator.Create<IReminder>();
			reminder2.PropertyName = reminder.PropertyName;
			reminder2.RemindTo = reminder.RemindTo;
			reminder2.RefObject = ReferenceOnEntity.Create(task2);
			reminder.Template = reminder2;
		}
		if (task2 == null)
		{
			return reminder;
		}
		reminder2.Save();
		ITaskFilter taskFilter = InterfaceActivator.Create<ITaskFilter>();
		taskFilter.PeriodTemplate = task2;
		if (reminder2.PropertyName == "StartDate")
		{
			taskFilter.StartDate = new DateTimeRange
			{
				From = DateTime.Now
			};
		}
		else
		{
			taskFilter.EndDate = new RelativeDateTime(DateTime.Now, null);
		}
		foreach (ITask item in TaskManager.Instance.Find(taskFilter, FetchOptions.All))
		{
			if (item.Id != task.Id)
			{
				ReminderManager.Instance.CreateByTemplate(reminder2, item)?.Save();
			}
		}
		return reminder;
	}
}
