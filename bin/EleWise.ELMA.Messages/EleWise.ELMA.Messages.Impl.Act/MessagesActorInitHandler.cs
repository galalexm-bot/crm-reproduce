using System;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Messages.Impl.Actors;

[Component(Type = ComponentType.Server)]
internal sealed class MessagesActorInitHandler : IActorInitHandler
{
	public Task Init(IActorModelRuntime actorModelRuntime)
	{
		return actorModelRuntime.GetActor<IMessagesHandlerActor>(Guid.Empty).Start();
	}
}
