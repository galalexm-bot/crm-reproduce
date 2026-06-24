using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;

namespace EleWise.ELMA.Security.Services;

[ExtensionPoint(ServiceScope.Shell, ComponentType.Server)]
public interface IAuthenticatedSessionEventHandler : IEventHandler
{
	void SessionRegistered(IUser user, AuthenticatedSessionInfo sessionInfo);

	void SessionClosed(IUser user, AuthenticatedSessionInfo sessionInfo);
}
