using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ActorModel.Attributes;

namespace EleWise.ELMA.Messages.Impl.Actors;

[FeatureFlagManaged("MessageManager.Enabled", true)]
internal interface IMessageSenderActor : IActorWithIntegerKey, IActor
{
	Task Send(IReadOnlyCollection<(long messageQueueChannelItemId, Guid messageChannelUid)> channels);
}
