using System;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;

namespace EleWise.ELMA.FilePreview.LocalService.Actors;

internal sealed class PreviewWorkDispatcherActor : Actor, IPreviewWorkDispatcherActor, IActorWithGuidKey, IActor
{
	private static readonly Guid workerGuid = Guid.NewGuid();

	private readonly IActorModelRuntime actorModelRuntime;

	public PreviewWorkDispatcherActor(IActorModelRuntime actorModelRuntime)
	{
		this.actorModelRuntime = actorModelRuntime;
	}

	public Task Process(string fileId, string creator, string sourceFilePath, string targetFilePath, string password)
	{
		return actorModelRuntime.GetActor<IPreviewWorkerActor>(workerGuid).Process(fileId, creator, sourceFilePath, targetFilePath, password);
	}
}
