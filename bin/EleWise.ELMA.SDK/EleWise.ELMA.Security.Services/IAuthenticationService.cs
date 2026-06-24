using System;
using System.Collections.Generic;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Security.Services;

[PublicApiMember("AuthenticationServicesApi", "SR.M('Служба аутентификации системы')", "SR.M('\r\n    /// <code>\r\n    /// //С помощью данного сервиса мы можем получить текущего пользователя,\r\n    /// //получить информацию о авторизованных сессиях. Так же предоставляется возможность\r\n    /// //удалять сессии.\r\n    /// //запишем сервис в переменную, чтобы с ним легче было работать\r\n    /// var service = PublicAPI.Services.Authentication;\r\n    /// \r\n    /// //для получения текущего пользователя используйте функцию GetCurrentUser()\r\n    /// var currentUser = service.GetCurrentUser();\r\n    /// \r\n    /// //для получения информации о активных авторизированных сессиях используйте функцию GetActiveSessions()\r\n    /// var activeSessions = service.GetActiveSessions();\r\n    /// \r\n    /// //для получения информации о авторизированных сессиях используйте функцию GetSession(filter),\r\n    /// //где filter - экземпляр класса AuthenticatedSessionFilter. Данный фильтр предоставляет возможность\r\n    /// //фильтровать по двум полям:\r\n    /// //1.bool OnlyActive - выбирать только активные сессии;\r\n    /// //2.bool OnlyConcurrentUsers - выбирать только сессии пользователей с конкурентными лицензиями.\r\n    /// //Так же вместо filter можно передать null\r\n    /// var sessions = service.GetSessions(null); \r\n    /// \r\n    /// //чтобы удалить сессию по её тикету, используйте функцию RemoveSession(ticketId)\r\n    /// service.RemoveSession(activeSession.First().TicketUid);\r\n    /// \r\n    /// //чтобы удалить все авторизованные сессии пользователя, используйте функцию RemoveAllUserSessions(userId)\r\n    /// service.RemoveAllUserSessions(user.Id);\r\n    /// </code>')")]
[DeveloperApi(DeveloperApiType.Service)]
public interface IAuthenticationService
{
	[PublicApiNodeId("AuthenticationServicesApi")]
	IUser GetCurrentUser();

	object GetCurrentUserId();

	T GetCurrentUser<T>() where T : IUser;

	void SignIn(IUser user, bool rememberMeSet = false);

	void SignIn(IUser user, bool rememberMeSet, bool checkRequireChangePassword);

	void SignOut();

	void SetAuthenticatedUserForRequest(IUser user);

	void SetAuthenticatedUserIdForRequest(object userId);

	[PublicApiNodeId("AuthenticationServicesApi")]
	AuthenticatedSessionInfo GetCurrentSession();

	[PublicApiNodeId("AuthenticationServicesApi")]
	IEnumerable<AuthenticatedSessionInfo> GetActiveSessions();

	[PublicApiNodeId("AuthenticationServicesApi")]
	IEnumerable<AuthenticatedSessionInfo> GetSessions(AuthenticatedSessionFilter filter);

	[PublicApiNodeId("AuthenticationServicesApi")]
	void RemoveSession(Guid ticketId);

	[PublicApiNodeId("AuthenticationServicesApi")]
	void RemoveAllUserSessions(object userId);
}
