using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;

namespace EleWise.ELMA.Security.Events;

[ExtensionPoint(ServiceScope.Shell, ComponentType.Server)]
public interface IGroupPermissionEventHandler : IEventHandler
{
	void PostChange(GroupPermissionEventArgs args);
}
