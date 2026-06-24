using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Runtime.NH.Listeners;
using NHibernate;

namespace EleWise.ELMA.CRM.Listeners;

[Component]
internal class RelationshipUsersListener : EntityEventsListener, IUnitOfWorkEventListener
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
			if (entitite is IRelationship relationship)
			{
				Process(relationship);
			}
		}
	}

	private void Process(IRelationship relationship)
	{
		if (NHibernateUtil.IsInitialized((object)relationship) && relationship.RelationshipUsers.IsInitialized<IRelationshipUser>())
		{
			relationship.RelationshipUsersHash = string.Join(", ", from r in (IEnumerable<IRelationshipUser>)relationship.RelationshipUsers
				select r.User.Id into i
				orderby i
				select i);
		}
	}
}
