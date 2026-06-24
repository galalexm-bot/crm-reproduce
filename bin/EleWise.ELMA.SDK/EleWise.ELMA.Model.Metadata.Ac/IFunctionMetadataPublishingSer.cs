using System;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;

namespace EleWise.ELMA.Model.Metadata.Actors;

internal interface IFunctionMetadataPublishingServerInstanceActor : IServerPlacementActor, IActorWithGuidKey, IActor
{
	Task PublicationSuccess(Guid functionMetadataUid, UIMetadataPublishResult result);

	Task PublicationError(Guid functionMetadataUid, Exception exception);
}
