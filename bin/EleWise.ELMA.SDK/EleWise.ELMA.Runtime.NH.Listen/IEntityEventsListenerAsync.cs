using System.Threading;
using System.Threading.Tasks;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using NHibernate.Event;

namespace EleWise.ELMA.Runtime.NH.Listeners;

[ExtensionPoint(ServiceScope.Shell, ComponentType.Server | ComponentType.Test)]
[DeveloperApi(DeveloperApiType.ExtensionPoint)]
public interface IEntityEventsListenerAsync : IEntityEventsListener
{
	Task<bool> OnPreInsertAsync(PreInsertEvent @event, CancellationToken cancellationToken);

	Task OnPostInsertAsync(PostInsertEvent @event, CancellationToken cancellationToken);

	Task<bool> OnPreUpdateAsync(PreUpdateEvent @event, CancellationToken cancellationToken);

	Task OnPostUpdateAsync(PostUpdateEvent @event, CancellationToken cancellationToken);

	Task OnPostDeleteAsync(PostDeleteEvent @event, CancellationToken cancellationToken);

	Task<bool> OnPreDeleteAsync(PreDeleteEvent @event, CancellationToken cancellationToken);

	Task OnFlushAsync(FlushEvent @event, CancellationToken cancellationToken);

	Task OnPostRemoveCollectionAsync(PostCollectionRemoveEvent @event, CancellationToken cancellationToken);

	Task OnPostRecreateCollectionAsync(PostCollectionRecreateEvent @event, CancellationToken cancellationToken);

	Task OnPostUpdateCollectionAsync(PostCollectionUpdateEvent @event, CancellationToken cancellationToken);

	Task OnPreRemoveCollectionAsync(PreCollectionRemoveEvent @event, CancellationToken cancellationToken);

	Task OnPreRecreateCollectionAsync(PreCollectionRecreateEvent @event, CancellationToken cancellationToken);

	Task OnPreUpdateCollectionAsync(PreCollectionUpdateEvent @event, CancellationToken cancellationToken);

	Task OnPreLoadAsync(PreLoadEvent @event, CancellationToken cancellationToken);
}
