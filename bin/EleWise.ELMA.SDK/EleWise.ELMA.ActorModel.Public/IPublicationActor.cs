using System;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ActorModel.Attributes;

namespace EleWise.ELMA.ActorModel.Publication;

[FeatureFlagManaged("Publication.Actor.Enabled", true)]
internal interface IPublicationActor : IActorWithGuidKey, IActor
{
	Task<Guid> Start(string comment, string tag, params long[] headerIds);

	Task<bool> PublicationStarted();

	Task Wait(Guid сonnectionUid);

	Task Complete(Guid сonnectionUid);

	Task RuntimeUpdated(Guid connectionUid);

	Task Error(Exception exception);
}
