using System;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ActorModel.Attributes;
using EleWise.ELMA.Events;

namespace EleWise.ELMA.ActorModel.Publication;

[FeatureFlagManaged("Publication.Actor.Enabled", true)]
internal interface IGlobalScriptModulePublicationActor : IActorWithIntegerKey, IActor
{
	Task Publish();

	Task PublicationComplete();
}
internal interface IGlobalScriptModulePublicationEventHandler : IEventHandler
{
	Task Complete(long globalScriptModuleId);

	Task Error(long globalScriptModuleId, Exception exception);
}
internal interface IGlobalScriptModulePublicationServerInstanceActor : IServerPlacementActor, IActorWithGuidKey, IActor
{
	Task PublicationSuccess(long globalScriptModuleId);

	Task PublicationError(long globalScriptModuleId, Exception exception);
}
