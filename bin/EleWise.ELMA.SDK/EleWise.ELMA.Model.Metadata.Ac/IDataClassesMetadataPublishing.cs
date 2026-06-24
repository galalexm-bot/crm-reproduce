using System;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ActorModel.Attributes;

namespace EleWise.ELMA.Model.Metadata.Actors;

[FeatureFlagManaged("Publication.Actor.Enabled", true)]
internal interface IDataClassesMetadataPublishingActor : IActorWithGuidKey, IActor
{
	Task<Guid> Publish(Guid[] dataClassMetadataHeadersUid, string comment);

	Task PublishComplete();
}
