using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using NHibernate.Event;

namespace EleWise.ELMA.Runtime.NH.Listeners;

[ExtensionPoint(ServiceScope.Shell, ComponentType.Server)]
[DeveloperApi(DeveloperApiType.ExtensionPoint)]
public interface IPostFlushEventListener
{
	void OnPostInsert(PostInsertEvent @event);

	void OnPostUpdate(PostUpdateEvent @event);

	void OnPostDelete(PostDeleteEvent @event);

	void OnPostUpdateCollection(PostCollectionUpdateEvent @event);
}
