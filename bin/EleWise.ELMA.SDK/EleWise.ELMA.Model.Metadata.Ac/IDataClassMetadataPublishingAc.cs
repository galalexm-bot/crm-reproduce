using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ActorModel.Attributes;

namespace EleWise.ELMA.Model.Metadata.Actors;

[FeatureFlagManaged("Publication.Actor.Enabled", true)]
internal interface IDataClassMetadataPublishingActor : IActorWithGuidKey, IActor
{
	Task Publish(string comment);

	Task PublishComplete();
}
