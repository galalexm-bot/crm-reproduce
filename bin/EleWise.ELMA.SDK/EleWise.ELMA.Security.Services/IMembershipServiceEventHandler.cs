using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;

namespace EleWise.ELMA.Security.Services;

[ExtensionPoint(ServiceScope.Shell, ComponentType.Server)]
public interface IMembershipServiceEventHandler2 : IMembershipServiceEventHandler, IEventHandler
{
	void ValidationError(UserValidationContext context);
}
[ExtensionPoint(ServiceScope.Shell, ComponentType.Server)]
public interface IMembershipServiceEventHandler : IEventHandler
{
	void Validating(UserValidationContext context);

	void Validated(UserValidationContext context);

	void SetPassword(IUser user, string password);
}
