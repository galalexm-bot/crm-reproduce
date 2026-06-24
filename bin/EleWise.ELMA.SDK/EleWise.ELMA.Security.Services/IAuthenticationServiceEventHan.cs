using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;

namespace EleWise.ELMA.Security.Services;

[ExtensionPoint(ServiceScope.Shell, ComponentType.Server)]
public interface IAuthenticationServiceEventHandler2 : IAuthenticationServiceEventHandler, IEventHandler
{
	void SignInError(IUser user, Exception error);
}
[ExtensionPoint(ServiceScope.Shell, ComponentType.Server)]
public interface IAuthenticationServiceEventHandler : IEventHandler
{
	void SignedIn(IUser user);

	void SignedOut(IUser user);

	[Obsolete("Устаревший метод. Используйте интерфейс IAuthenticatedSessionEventHandler вместо этого. Будет удалена в будущих версиях")]
	void SessionRegistered(IUser user);

	[Obsolete("Устаревший метод. Используйте интерфейс IAuthenticatedSessionEventHandler вместо этого. Будет удалена в будущих версиях")]
	void SessionClosed(IUser user);
}
