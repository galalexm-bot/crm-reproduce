using System;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;

namespace EleWise.ELMA.Model.Metadata.Actors;

internal interface IDataClassMetadataPublishingServerInstanceActor : IServerPlacementActor, IActorWithGuidKey, IActor
{
	Task Complete(Guid publicationToken, UIMetadataPublishResult result);

	Task Error(Guid publicationToken, Exception exception);
}
