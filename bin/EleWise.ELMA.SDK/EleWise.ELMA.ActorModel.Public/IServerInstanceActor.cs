using System;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.ActorModel.Publication;

internal interface IServerInstanceActor : IServerPlacementActor, IActorWithGuidKey, IActor
{
	Task DeltaPublicationStart(MetadataAssemblyPublishResult result, Guid[] softPublished, Guid[] deltaPublished, AssemblyModelsMetadata restartNeeded);

	Task DeltaPublicationComplete();

	Task PublicationComplete(Guid publicationToken);

	Task PublicationError(Guid publicationToken, Exception exception);

	Task Deactivate();
}
