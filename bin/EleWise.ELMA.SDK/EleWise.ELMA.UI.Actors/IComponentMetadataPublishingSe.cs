using System;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.Model;

namespace EleWise.ELMA.UI.Actors;

internal interface IComponentMetadataPublishingServerInstanceActor : IServerPlacementActor, IActorWithGuidKey, IActor
{
	Task PublicationSuccess(Guid componentMetadataUid, UIMetadataPublishResult result);

	Task PublicationError(Guid componentMetadataUid, Exception exception);
}
