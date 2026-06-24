using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Model.Events;

[ExtensionPoint(ServiceScope.Shell, ComponentType.Server)]
[DeveloperApi(DeveloperApiType.ExtensionPoint)]
public interface IEntityActionHandler : IEventHandler
{
	void ActionExecuted(EntityActionEventArgs e);
}
