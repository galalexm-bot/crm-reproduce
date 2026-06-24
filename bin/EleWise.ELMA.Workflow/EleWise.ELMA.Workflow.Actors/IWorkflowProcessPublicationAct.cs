using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ActorModel.Attributes;

namespace EleWise.ELMA.Workflow.Actors;

[FeatureFlagManaged("Publication.Actor.Enabled", true)]
internal interface IWorkflowProcessPublicationActor : IActorWithIntegerKey, IActor
{
	Task Publish(string comment, bool generateDocumentation, bool isEmulation);

	Task PublicationComplete();
}
