using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;

namespace EleWise.ELMA.Services.Public;

[ExtensionPoint(ServiceScope.Shell, ComponentType.Server)]
public interface IAuthorizationServiceEventHandler : IEventHandler
{
	void OnAuthorizeUser(AuthorizeUserEventArgs e);
}
