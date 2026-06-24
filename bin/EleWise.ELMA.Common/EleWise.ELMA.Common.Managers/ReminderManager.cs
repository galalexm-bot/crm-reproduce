using System;
using System.Collections.Generic;
using System.Reflection;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Notifications;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Common.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class ReminderManager : EntityManager<IReminder, long>
{
	[NotNull]
	public new IAuthenticationService AuthenticationService { get; set; }

	public new static ReminderManager Instance => Locator.GetServiceNotNull<ReminderManager>();

	public IReminder CreateByTemplate(IReminder template, IEntity entity)
	{
		if (string.IsNullOrEmpty(template.PropertyName))
		{
			return null;
		}
		PropertyInfo reflectionProperty = entity.GetType().GetReflectionProperty(template.PropertyName);
		if (reflectionProperty == null)
		{
			return null;
		}
		object value = reflectionProperty.GetValue(entity, null);
		if (value == null)
		{
			return null;
		}
		IReminder reminder = InterfaceActivator.Create<IReminder>();
		reminder.CreationAuthor = template.CreationAuthor;
		reminder.PropertyName = template.PropertyName;
		reminder.RemindTo = template.RemindTo;
		reminder.RefObject = ReferenceOnEntity.Create(entity);
		reminder.RemindDate = DateTime.Parse(value.ToString()).Add(-template.RemindTo);
		reminder.Template = template;
		return reminder;
	}

	[Transaction]
	public virtual ICollection<IReminder> SendReminders(DateTime date)
	{
		INotificationManager serviceNotNull = Locator.GetServiceNotNull<INotificationManager>();
		IUser currentUser = AuthenticationService.GetCurrentUser();
		IReminderFilter reminderFilter = InterfaceActivator.Create<IReminderFilter>();
		reminderFilter.Posted = false;
		reminderFilter.RemindDate = new DateTimeRange
		{
			To = date
		};
		ICollection<IReminder> collection = Find(reminderFilter, FetchOptions.All);
		foreach (IReminder item in collection)
		{
			try
			{
				AuthenticationService.SetAuthenticatedUserForRequest(item.CreationAuthor);
				serviceNotNull.AddUserToForceSendList(item.CreationAuthor);
				EntityActionEventArgs entityActionEventArgs = EntityActionEventArgs.TryCreate(null, item.RefObject.Object, "5761c647-866e-4a19-9ebd-1b9ac73eb86d");
				entityActionEventArgs.ExtendedProperties.Add("Reminder", item);
				base.ActionHandler.ActionExecuted(entityActionEventArgs);
				item.Posted = true;
				item.Save();
			}
			catch (Exception exception)
			{
				base.Logger.Error(exception, "Ошибка отправки напоминания (Id={0}", item.Id);
			}
		}
		if (currentUser != null)
		{
			((IEntity)currentUser).Refresh();
			AuthenticationService.SetAuthenticatedUserForRequest(currentUser);
		}
		else
		{
			AuthenticationService.SignOut();
		}
		return collection;
	}
}
