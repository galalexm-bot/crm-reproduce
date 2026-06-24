using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ActorModel.Attributes;

namespace EleWise.ELMA.Workflow.Actors;

[FeatureFlagManaged("Publication.Actor.Enabled", true)]
internal interface ICustomActivityPublicationActor : IActorWithIntegerKey, IActor
{
	Task Publish();

	Task PublicationComplete();
}
