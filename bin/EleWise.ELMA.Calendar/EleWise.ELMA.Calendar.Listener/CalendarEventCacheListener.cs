using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Runtime.NH.Listeners;
using Iesi.Collections.Generic;
using NHibernate;

namespace EleWise.ELMA.Calendar.Listeners;

[Component]
internal class CalendarEventCacheListener : EntityEventsListener, IUnitOfWorkEventListener
{
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
			if (entitite is ICalendarEvent calendarEvent)
			{
				Process(calendarEvent);
			}
		}
	}

	private void Process(ICalendarEvent calendarEvent)
	{
		Process(calendarEvent, (ICalendarEvent u) => u.EventUsers, delegate(ICalendarEvent u, string v)
		{
			u.EventUsersHash = v;
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
}
