using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;

namespace EleWise.ELMA.Deploy.Actors;

internal interface IModuleAutoDeployActor : IActorWithGuidKey, IActor
{
	Task StartWatching();
}
