using System;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.UIBuilder.Actors;
using EleWise.ELMA.UIBuilder.Handler;

namespace EleWise.ELMA.UIBuilder.Services;

[Service(EnableInterceptors = false, InjectProperties = false)]
internal sealed class ModulePublishService : IModulePublishService
{
	private sealed class ModulePublishingEventHandler : IModulePublishingEventHandler, IEventHandler
	{
		private readonly IModulePublishingActor modulePublishingActor;

		private readonly Guid moduleHeaderUid;

		private readonly TaskCompletionSource<bool> taskCompletionSource = new TaskCompletionSource<bool>(TaskCreationOptions.RunContinuationsAsynchronously);

		public Task<bool> Wait => taskCompletionSource.Task;

		public ModulePublishingEventHandler(IModulePublishingActor modulePublishingActor, Guid moduleHeaderUid)
		{
			this.modulePublishingActor = modulePublishingActor;
			this.moduleHeaderUid = moduleHeaderUid;
		}

		public Task PublicationSuccess(Guid moduleMetadataItemHeaderUid)
		{
			if (moduleHeaderUid != moduleMetadataItemHeaderUid)
			{
				return Task.CompletedTask;
			}
			taskCompletionSource.TrySetResult(result: true);
			return modulePublishingActor.PublishComplete();
		}

		public Task PublicationError(Guid moduleMetadataItemHeaderUid, Exception exception)
		{
			if (moduleHeaderUid != moduleMetadataItemHeaderUid)
			{
				return Task.CompletedTask;
			}
			taskCompletionSource.TrySetException(exception);
			return modulePublishingActor.PublishComplete();
		}
	}

	private readonly IActorModelRuntime actorModelRuntime;

	private readonly IEventHandlerSubscribeService eventHandlerSubscribeService;

	public ModulePublishService(IActorModelRuntime actorModelRuntime, IEventHandlerSubscribeService eventHandlerSubscribeService)
	{
		this.actorModelRuntime = actorModelRuntime;
		this.eventHandlerSubscribeService = eventHandlerSubscribeService;
	}

	public void Publish(Guid headerUid, string comment)
	{
		PublishAsync(headerUid, comment).GetAwaiter().GetResult();
	}

	private async Task PublishAsync(Guid headerUid, string comment)
	{
		IModulePublishingActor actor = actorModelRuntime.GetActor<IModulePublishingActor>(headerUid);
		ModulePublishingEventHandler handler = new ModulePublishingEventHandler(actor, headerUid);
		using (eventHandlerSubscribeService.Subscribe(handler))
		{
			_ = 1;
			try
			{
				await actor.Publish(comment);
				await handler.Wait;
			}
			catch (NoServerCompatibleWithActorException innerException)
			{
				throw new NoServerCompatibleWithActorException(SR.T("Отключена возможность публикации"), innerException);
			}
		}
	}
}
