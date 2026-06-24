using System.Threading;
using System.Threading.Tasks;
using EleWise.ELMA.Model.Attributes;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Event;

namespace EleWise.ELMA.Runtime.NH.Listeners;

[DeveloperApi(DeveloperApiType.ExtensionPoint)]
public abstract class EntityEventsListenerAsync : EntityEventsListener, IEntityEventsListenerAsync, IEntityEventsListener
{
	internal static EntityEventsListenerAsync beS0FvWA2BNnj7GR6kII;

	public virtual Task<bool> OnPreInsertAsync(PreInsertEvent @event, CancellationToken cancellationToken)
	{
		return Task.FromResult(result: false);
	}

	public virtual Task OnPostInsertAsync(PostInsertEvent @event, CancellationToken cancellationToken)
	{
		return Task.CompletedTask;
	}

	public virtual Task<bool> OnPreUpdateAsync(PreUpdateEvent @event, CancellationToken cancellationToken)
	{
		return Task.FromResult(result: false);
	}

	public virtual Task OnPostUpdateAsync(PostUpdateEvent @event, CancellationToken cancellationToken)
	{
		return (Task)ow4vV2WA1lEmlvZpYl6X();
	}

	public virtual Task OnPostDeleteAsync(PostDeleteEvent @event, CancellationToken cancellationToken)
	{
		return Task.CompletedTask;
	}

	public virtual Task<bool> OnPreDeleteAsync(PreDeleteEvent @event, CancellationToken cancellationToken)
	{
		return Task.FromResult(result: false);
	}

	public virtual Task OnFlushAsync(FlushEvent @event, CancellationToken cancellationToken)
	{
		return (Task)ow4vV2WA1lEmlvZpYl6X();
	}

	public virtual Task OnPostRemoveCollectionAsync(PostCollectionRemoveEvent @event, CancellationToken cancellationToken)
	{
		return (Task)ow4vV2WA1lEmlvZpYl6X();
	}

	public virtual Task OnPostRecreateCollectionAsync(PostCollectionRecreateEvent @event, CancellationToken cancellationToken)
	{
		return (Task)ow4vV2WA1lEmlvZpYl6X();
	}

	public virtual Task OnPostUpdateCollectionAsync(PostCollectionUpdateEvent @event, CancellationToken cancellationToken)
	{
		return Task.CompletedTask;
	}

	public virtual Task OnPreRemoveCollectionAsync(PreCollectionRemoveEvent @event, CancellationToken cancellationToken)
	{
		return (Task)ow4vV2WA1lEmlvZpYl6X();
	}

	public virtual Task OnPreRecreateCollectionAsync(PreCollectionRecreateEvent @event, CancellationToken cancellationToken)
	{
		return Task.CompletedTask;
	}

	public virtual Task OnPreUpdateCollectionAsync(PreCollectionUpdateEvent @event, CancellationToken cancellationToken)
	{
		return (Task)ow4vV2WA1lEmlvZpYl6X();
	}

	public virtual Task OnPreLoadAsync(PreLoadEvent @event, CancellationToken cancellationToken)
	{
		return (Task)ow4vV2WA1lEmlvZpYl6X();
	}

	protected EntityEventsListenerAsync()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		bjRhfWWAN5r4DvJLw0IB();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object ow4vV2WA1lEmlvZpYl6X()
	{
		return Task.CompletedTask;
	}

	internal static void bjRhfWWAN5r4DvJLw0IB()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool Pwt65UWAeSlk28JwwTMG()
	{
		return beS0FvWA2BNnj7GR6kII == null;
	}

	internal static EntityEventsListenerAsync lo5wvOWAPY9jPi79xdBm()
	{
		return beS0FvWA2BNnj7GR6kII;
	}
}
