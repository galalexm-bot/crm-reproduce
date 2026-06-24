using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Runtime.NH.Listeners;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.ExtensionPoints;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;
using Iesi.Collections.Generic;
using NHibernate;
using NHibernate.Engine;
using NHibernate.Event;

namespace EleWise.ELMA.Tasks.Listeners;

[Component]
internal class TaskCacheListener : EntityEventsListener, IUnitOfWorkEventListener
{
	public TaskBaseManager TaskBaseManager { get; set; }

	public IEnumerable<ITaskAttachmetSpecifiedExtension> TaskAttachmetSpecifiedExtension { get; set; }

	public override bool OnPreInsert(PreInsertEvent @event)
	{
		ResetCurrentCountCache4TaskBase((IPreDatabaseOperationEventArgs)(object)@event);
		if (((AbstractPreDatabaseOperationEvent)@event).get_Entity() is ITaskBase taskBase)
		{
			if (taskBase.IsComplete())
			{
				if (!DisableSetTaskEndWorkDate())
				{
					taskBase.EndWorkDate = DateTime.Now;
					if (!taskBase.StartWorkDate.HasValue)
					{
						taskBase.StartWorkDate = taskBase.EndWorkDate;
					}
				}
			}
			else if (taskBase.Status == TaskBaseStatus.InProgress)
			{
				taskBase.StartWorkDate = DateTime.Now;
			}
			if (taskBase.InformTo != null)
			{
				foreach (IUser item in (IEnumerable<IUser>)taskBase.InformTo)
				{
					TaskBaseManager.ResetCurrentCountCache(item.Id);
				}
			}
		}
		return false;
	}

	public override bool OnPreUpdate(PreUpdateEvent @event)
	{
		if (((AbstractPreDatabaseOperationEvent)@event).get_Entity() is ITask && ((ITask)((AbstractPreDatabaseOperationEvent)@event).get_Entity()).IsTemplate && !ContextVars.GetOrAdd("PeriodTaskTemplate_ChangedTemplates", () => new List<long>()).Contains(((ITask)((AbstractPreDatabaseOperationEvent)@event).get_Entity()).Id))
		{
			int num = Array.IndexOf(((AbstractPreDatabaseOperationEvent)@event).get_Persister().get_PropertyNames(), "Period");
			int num2 = Array.IndexOf(((AbstractPreDatabaseOperationEvent)@event).get_Persister().get_PropertyNames(), "StartDate");
			int num3 = Array.IndexOf(((AbstractPreDatabaseOperationEvent)@event).get_Persister().get_PropertyNames(), "EndDate");
			if ((num >= 0 && (CalendarEventPeriod)@event.get_State()[num] != (CalendarEventPeriod)@event.get_OldState()[num]) || (num2 >= 0 && (DateTime?)@event.get_State()[num2] != (DateTime?)@event.get_OldState()[num2]) || (num3 >= 0 && (DateTime?)@event.get_State()[num3] != (DateTime?)@event.get_OldState()[num3]))
			{
				throw new Exception(SR.T("После изменения периодичности задачи или сроков выполнения шаблона необходимо вызывать метод TaskManager.TemplateChangeDateOrPeriod"));
			}
		}
		if (((AbstractPreDatabaseOperationEvent)@event).get_Entity() is ITaskBase taskBase)
		{
			int num4 = Array.IndexOf(((AbstractPreDatabaseOperationEvent)@event).get_Persister().get_PropertyNames(), "EndDate");
			if (num4 >= 0 && (DateTime?)@event.get_State()[num4] != (DateTime?)@event.get_OldState()[num4])
			{
				int num5 = Array.IndexOf(((AbstractPreDatabaseOperationEvent)@event).get_Persister().get_PropertyNames(), "ExpiredNotificationSent");
				if (num5 >= 0)
				{
					@event.get_State()[num5] = false;
				}
				taskBase.ExpiredNotificationSent = false;
			}
			int num6 = Array.IndexOf(((AbstractPreDatabaseOperationEvent)@event).get_Persister().get_PropertyNames(), "Status");
			if (num6 >= 0)
			{
				TaskBaseStatus taskBaseStatus = (TaskBaseStatus)@event.get_OldState()[num6];
				if (taskBase.IsComplete())
				{
					if (TaskBaseExtensions.ActiveTaskStatuses.Contains(taskBaseStatus) && !DisableSetTaskEndWorkDate())
					{
						taskBase.EndWorkDate = DateTime.Now;
						if (!taskBase.StartWorkDate.HasValue)
						{
							taskBase.StartWorkDate = taskBase.EndWorkDate;
						}
					}
				}
				else if (TaskBaseExtensions.CloseStatuses.Contains(taskBaseStatus))
				{
					taskBase.StartWorkDate = ((taskBase.Status == TaskBaseStatus.InProgress) ? new DateTime?(DateTime.Now) : null);
					taskBase.EndWorkDate = null;
				}
				else if (taskBase.Status != taskBaseStatus && taskBase.Status == TaskBaseStatus.InProgress)
				{
					taskBase.StartWorkDate = DateTime.Now;
				}
			}
		}
		ResetCurrentCountCache4TaskBase((IPreDatabaseOperationEventArgs)(object)@event);
		return false;
	}

	private bool DisableSetTaskEndWorkDate()
	{
		ContextVars.TryGetValue<bool>("DisableSetTaskWorkDate", out var value);
		return value;
	}

	public override void OnPreUpdateCollection(PreCollectionUpdateEvent @event)
	{
		if (@event == null || !(((AbstractCollectionEvent)@event).get_AffectedOwnerOrNull() is ITaskBase) || !(((ISessionImplementor)((AbstractEvent)@event).get_Session()).get_PersistenceContext().GetCollectionEntry(((AbstractCollectionEvent)@event).get_Collection()).get_Snapshot() is IEnumerable<IUser> enumerable))
		{
			return;
		}
		foreach (IUser item in enumerable)
		{
			TaskBaseManager.ResetCurrentCountCache(item.Id);
		}
	}

	private void ResetCurrentCountCache4TaskBase(IPreDatabaseOperationEventArgs @event)
	{
		if (!(@event.get_Entity() is ITaskBase taskBase) || TaskBaseManager == null)
		{
			return;
		}
		IUser executor = taskBase.Executor;
		List<long> list = new List<long>();
		if (executor != null)
		{
			list.Add(executor.Id);
		}
		PreUpdateEvent val = (PreUpdateEvent)(object)((@event is PreUpdateEvent) ? @event : null);
		if (val != null)
		{
			int num = Array.IndexOf(((AbstractPreDatabaseOperationEvent)val).get_Persister().get_PropertyNames(), "Executor");
			if (num >= 0 && val.get_OldState()[num] is IUser user && !list.Contains(user.Id))
			{
				list.Add(user.Id);
			}
		}
		foreach (long item in list)
		{
			TaskBaseManager.ResetCurrentCountCache(item);
		}
		foreach (IUser item2 in (IEnumerable<IUser>)taskBase.InformTo)
		{
			TaskBaseManager.ResetCurrentCountCache(item2.Id);
		}
	}

	public void OnStartUnitofWork(IUnitOfWork unitOfWork)
	{
	}

	public void OnPreFlushUnitofWork(IUnitOfWork unitOfWork, IEnumerable<object> entities)
	{
		ProcessEntities(entities);
	}

	public void OnPreCommitUnitofWork(IUnitOfWork unitOfWork)
	{
	}

	public void OnPostCommitUnitofWork(IUnitOfWork unitOfWork)
	{
	}

	public void OnPostRollbackUnitofWork(IUnitOfWork unitOfWork)
	{
	}

	public void OnDisposeUnitofWork(IUnitOfWork unitOfWork)
	{
	}

	public void OnPostFlushUnitofWork(IUnitOfWork unitOfWork)
	{
	}

	protected void ProcessEntities(IEnumerable<object> entitites)
	{
		foreach (object entitite in entitites)
		{
			if (entitite is ITaskBase taskBase)
			{
				Process(taskBase);
				ProcessAttachments(taskBase);
			}
		}
	}

	private void Process(ITaskBase taskBase)
	{
		Process(taskBase, (ITaskBase u) => u.InformTo, delegate(ITaskBase u, string v)
		{
			u.InformToHash = v;
		});
	}

	private void Process<EntityT, CollectionEntryT>(EntityT entity, Func<EntityT, ISet<CollectionEntryT>> collectionAccessor, Action<EntityT, string> hashSetter) where EntityT : IEntity where CollectionEntryT : IEntity
	{
		if (!NHibernateUtil.IsInitialized((object)entity))
		{
			return;
		}
		ISet<CollectionEntryT> val = collectionAccessor(entity);
		if (val.IsInitialized<CollectionEntryT>())
		{
			hashSetter(entity, string.Join(", ", (from i in (IEnumerable<CollectionEntryT>)val
				select i.GetId() into id
				orderby id
				select id).ToArray()));
		}
	}

	private void ProcessAttachments(ITaskBase taskBase)
	{
		TaskBaseManager.UpdateAttachmentsSpecifiedHash(taskBase);
	}
}
