using System;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.Files.Previews;

namespace EleWise.ELMA.FilePreview.LocalService.Actors;

internal sealed class PreviewsServerInstanceActor : Actor, IPreviewsServerInstanceActor, IServerPlacementActor, IActorWithGuidKey, IActor
{
	private readonly IFilePreviewEventHandler filePreviewEventHandler;

	public PreviewsServerInstanceActor(IFilePreviewEventHandler filePreviewEventHandler)
	{
		this.filePreviewEventHandler = filePreviewEventHandler;
	}

	public Task Complete(string fileId, Exception exception = null)
	{
		return filePreviewEventHandler.Complete(fileId, exception);
	}
}
