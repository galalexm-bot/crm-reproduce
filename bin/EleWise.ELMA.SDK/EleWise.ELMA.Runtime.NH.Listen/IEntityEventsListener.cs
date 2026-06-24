using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using NHibernate.Event;

namespace EleWise.ELMA.Runtime.NH.Listeners;

[DeveloperApi(DeveloperApiType.ExtensionPoint)]
[ExtensionPoint(ServiceScope.Shell, ComponentType.Server | ComponentType.Test)]
public interface IEntityEventsListener
{
	bool OnPreInsert(PreInsertEvent @event);

	void OnPostInsert(PostInsertEvent @event);

	bool OnPreUpdate(PreUpdateEvent @event);

	void OnPostUpdate(PostUpdateEvent @event);

	void OnPostDelete(PostDeleteEvent @event);

	bool OnPreDelete(PreDeleteEvent @event);

	void OnFlush(FlushEvent @event);

	void OnPostRemoveCollection(PostCollectionRemoveEvent @event);

	void OnPostRecreateCollection(PostCollectionRecreateEvent @event);

	void OnPostUpdateCollection(PostCollectionUpdateEvent @event);

	void OnPreRemoveCollection(PreCollectionRemoveEvent @event);

	void OnPreRecreateCollection(PreCollectionRecreateEvent @event);

	void OnPreUpdateCollection(PreCollectionUpdateEvent @event);

	void OnPreLoad(PreLoadEvent @event);
}
