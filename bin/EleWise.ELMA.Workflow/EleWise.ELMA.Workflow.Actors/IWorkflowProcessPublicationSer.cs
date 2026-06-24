using System;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;

namespace EleWise.ELMA.Workflow.Actors;

internal interface IWorkflowProcessPublicationServerInstanceActor : IServerPlacementActor, IActorWithGuidKey, IActor
{
	Task PublicationSuccess(long processHeaderId);

	Task PublicationError(long processHeaderId, Exception exception);
}
