using System;
using System.Linq.Expressions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Runtime.NH.Listeners;
using NHibernate.Event;
using NHibernate.Persister.Entity;

namespace EleWise.ELMA.Documents.Listeners;

[Component(Order = 100000)]
internal class FolderReferenceListener : EntityEventsListener
{
	private readonly string nameOfCreationDate = LinqUtils.NameOf((Expression<Func<IFolderReference, object>>)((IFolderReference r) => r.CreationDate));

	private readonly string nameOfChangeDate = LinqUtils.NameOf((Expression<Func<IFolderReference, object>>)((IFolderReference r) => r.ChangeDate));

	private readonly string nameOfCreationAuthor = LinqUtils.NameOf((Expression<Func<IFolderReference, object>>)((IFolderReference r) => r.CreationAuthor));

	private readonly string nameOfChangeAuthor = LinqUtils.NameOf((Expression<Func<IFolderReference, object>>)((IFolderReference r) => r.ChangeAuthor));

	public override bool OnPreInsert(PreInsertEvent @event)
	{
		if (((AbstractPreDatabaseOperationEvent)@event).get_Entity() is IFolderReference folderReference && folderReference.Reference != null)
		{
			UpdateReference(((AbstractPreDatabaseOperationEvent)@event).get_Persister(), @event.get_State(), folderReference);
		}
		return false;
	}

	public override bool OnPreUpdate(PreUpdateEvent @event)
	{
		if (((AbstractPreDatabaseOperationEvent)@event).get_Entity() is IFolderReference folderReference && folderReference.Reference != null)
		{
			UpdateReference(((AbstractPreDatabaseOperationEvent)@event).get_Persister(), @event.get_State(), folderReference);
		}
		return false;
	}

	private void UpdateReference(IEntityPersister persister, object[] state, IFolderReference reference)
	{
		reference.CreationDate = reference.Reference.CreationDate;
		reference.ChangeDate = reference.Reference.ChangeDate;
		reference.CreationAuthor = reference.Reference.CreationAuthor;
		reference.ChangeAuthor = reference.Reference.ChangeAuthor;
		persister.Set(state, nameOfCreationDate, reference.CreationDate);
		persister.Set(state, nameOfChangeDate, reference.ChangeDate);
		persister.Set(state, nameOfCreationAuthor, reference.CreationAuthor);
		persister.Set(state, nameOfChangeAuthor, reference.ChangeAuthor);
	}
}
