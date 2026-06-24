using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;

namespace EleWise.ELMA.FilePreview.LocalService.Actors;

internal interface IPreviewWorkerActor : IActorWithGuidKey, IActor
{
	Task Process(string fileId, string creator, string sourceFilePath, string targetFilePath, string password);
}
