using EleWise.ELMA.Events;

namespace Orchard.Security;

public interface IAuthorizationServiceEventHandler : IEventHandler
{
	void Checking(CheckAccessContext context);

	void Adjust(CheckAccessContext context);

	void Complete(CheckAccessContext context);
}
