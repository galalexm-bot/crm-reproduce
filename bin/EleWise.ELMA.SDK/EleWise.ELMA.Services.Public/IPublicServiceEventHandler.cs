using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Services.Public;

[ExtensionPoint(ServiceScope.Shell, ComponentType.Server)]
[DeveloperApi(DeveloperApiType.ExtensionPoint)]
public interface IPublicServiceEventHandler : IEventHandler
{
	void ActionExecuting(PublicServiceMethodEventArgs e);

	void ActionExecuted(PublicServiceMethodEventArgs e);
}
