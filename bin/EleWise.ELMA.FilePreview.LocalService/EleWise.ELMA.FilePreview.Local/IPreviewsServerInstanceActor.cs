using System;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;

namespace EleWise.ELMA.FilePreview.LocalService.Actors;

internal interface IPreviewsServerInstanceActor : IServerPlacementActor, IActorWithGuidKey, IActor
{
	Task Complete(string fileId, Exception exception = null);
}
