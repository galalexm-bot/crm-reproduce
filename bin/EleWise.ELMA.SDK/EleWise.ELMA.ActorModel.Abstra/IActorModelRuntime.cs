using System;
using System.Threading.Tasks;

namespace EleWise.ELMA.ActorModel.Abstractions;

public interface IActorModelRuntime
{
	TActorInterface GetActor<TActorInterface>(long primaryKey) where TActorInterface : IActorWithIntegerKey;

	TActorInterface GetActor<TActorInterface>(string primaryKey) where TActorInterface : IActorWithStringKey;

	TActorInterface GetActor<TActorInterface>(Guid primaryKey) where TActorInterface : IActorWithGuidKey;

	TActorInterface GetActor<TActorInterface>(Guid primaryKey, string keyExtension) where TActorInterface : IActorWithGuidCompoundKey;

	Task<ISubscription> Subscribe<T>(Guid eventId, string eventNamespace, Func<T, Task> onPublish);

	Task Publish<T>(Guid eventId, string eventNamespace, T data);
}
