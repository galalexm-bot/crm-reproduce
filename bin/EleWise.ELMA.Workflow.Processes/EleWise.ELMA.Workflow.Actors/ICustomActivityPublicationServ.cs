using System;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;

namespace EleWise.ELMA.Workflow.Actors;

internal interface ICustomActivityPublicationServerInstanceActor : IServerPlacementActor, IActorWithGuidKey, IActor
{
	Task PublicationSuccess(long customActivityId);

	Task PublicationError(long customActivityId, Exception exception);
}
