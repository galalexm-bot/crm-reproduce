using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ActorModel.Attributes;

namespace EleWise.ELMA.Messages.Impl.Actors;

[FeatureFlagManaged("MessageManager.Enabled", true)]
internal interface IMessagesHandlerActor : IActorWithGuidKey, IActor
{
	Task Start();
}
