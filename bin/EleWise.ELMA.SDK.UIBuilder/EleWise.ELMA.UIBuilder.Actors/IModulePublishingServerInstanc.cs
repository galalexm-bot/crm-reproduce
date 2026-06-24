using System;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;

namespace EleWise.ELMA.UIBuilder.Actors;

internal interface IModulePublishingServerInstanceActor : IServerPlacementActor, IActorWithGuidKey, IActor
{
	Task PublicationSuccess(Guid moduleMetadataUid);

	Task PublicationError(Guid moduleMetadataUid, Exception exception);
}
