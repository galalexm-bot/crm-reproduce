using System;
using System.Reflection;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Runtime.NH.Listeners;
using NHibernate.Event;

namespace EleWise.ELMA.Common.Listeners;

[Component]
internal class ReminderEventListener : PostFlushEventListener
{
	public override void OnPostUpdate(PostUpdateEvent @event)
	{
		if (!(((AbstractPostDatabaseOperationEvent)@event).get_Entity() is IEntity entity))
		{
			return;
		}
		ReferenceOnEntity referenceOnEntity = ReferenceOnEntity.Create(entity);
		foreach (IReminder item in ReminderManager.Instance.Find($"RefObject = Reference('{referenceOnEntity.ObjectTypeUId}', {referenceOnEntity.ObjectId}) and not RemindDate is null"))
		{
			PropertyInfo reflectionProperty = entity.GetType().GetReflectionProperty(item.PropertyName);
			if (reflectionProperty == null)
			{
				continue;
			}
			object value = reflectionProperty.GetValue(entity, null);
			if (value == null)
			{
				continue;
			}
			DateTime dateTime = DateTime.Parse(value.ToString()).Add(-item.RemindTo);
			if (dateTime >= DateTime.Now)
			{
				DateTime value2 = dateTime;
				DateTime? remindDate = item.RemindDate;
				if (value2 != remindDate)
				{
					item.RemindDate = dateTime;
					item.Posted = false;
					item.Save();
				}
			}
		}
	}

	public override void OnPostDelete(PostDeleteEvent @event)
	{
		IEntity entity = ((AbstractPostDatabaseOperationEvent)@event).get_Entity() as IEntity;
		if (entity == null)
		{
			return;
		}
		Type entityIdType = ModelHelper.GetEntityIdType(entity.GetType());
		if (!(entityIdType == typeof(long)) && !(entityIdType == typeof(int)))
		{
			return;
		}
		foreach (IReminder item in ReminderManager.Instance.Find((IReminder f) => f.RefObject == ReferenceOnEntity.Create(entity)))
		{
			item.Delete();
		}
	}
}
