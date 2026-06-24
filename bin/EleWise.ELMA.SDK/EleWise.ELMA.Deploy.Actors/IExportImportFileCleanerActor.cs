using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;

namespace EleWise.ELMA.Deploy.Actors;

internal interface IExportImportFileCleanerActor : IActorWithGuidKey, IActor
{
	Task Start();
}
