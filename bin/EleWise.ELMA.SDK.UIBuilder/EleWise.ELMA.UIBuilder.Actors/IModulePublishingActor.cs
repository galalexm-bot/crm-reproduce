using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;

namespace EleWise.ELMA.UIBuilder.Actors;

internal interface IModulePublishingActor : IActorWithGuidKey, IActor
{
	Task Publish(string comment);

	Task PublishComplete();
}
