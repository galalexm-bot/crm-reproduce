using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;

namespace EleWise.ELMA.FilePreview.LocalService.Actors;

internal interface IPreviewsActor : IActorWithGuidKey, IActor
{
	Task QueueWorkItem(string fileId, long priority);

	Task<bool> RunWork(string fileId, string fileEncryptPassword, string password);

	Task RemoveWorkItem(string fileId);
}
