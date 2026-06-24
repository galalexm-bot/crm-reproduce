using System;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.UIBuilder.Handler;

namespace EleWise.ELMA.UIBuilder.Actors;

internal sealed class ModulePublishingServerInstanceActor : Actor, IModulePublishingServerInstanceActor, IServerPlacementActor, IActorWithGuidKey, IActor
{
	private readonly IModulePublishingEventHandler modulePublishingEventHandler;

	public ModulePublishingServerInstanceActor(IModulePublishingEventHandler modulePublishingEventHandler)
	{
		this.modulePublishingEventHandler = modulePublishingEventHandler;
	}

	public Task PublicationSuccess(Guid moduleMetadataUid)
	{
		return modulePublishingEventHandler.PublicationSuccess(moduleMetadataUid);
	}

	public Task PublicationError(Guid moduleMetadataUid, Exception exception)
	{
		return modulePublishingEventHandler.PublicationError(moduleMetadataUid, exception);
	}
}
