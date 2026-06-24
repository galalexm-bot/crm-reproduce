using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ActorModel.Attributes;

namespace EleWise.ELMA.UI.Actors;

[FeatureFlagManaged("Publication.Actor.Enabled", true)]
internal interface IComponentMetadataPublishingActor : IActorWithGuidKey, IActor
{
	Task Publish(string comment, bool forEmulation);

	Task PublishComplete();
}
