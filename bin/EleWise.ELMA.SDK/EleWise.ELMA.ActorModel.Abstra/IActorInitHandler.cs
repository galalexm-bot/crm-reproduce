using System.Threading.Tasks;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.ActorModel.Abstractions;

[ExtensionPoint(ComponentType.All)]
public interface IActorInitHandler
{
	Task Init(IActorModelRuntime actorModelRuntime);
}
