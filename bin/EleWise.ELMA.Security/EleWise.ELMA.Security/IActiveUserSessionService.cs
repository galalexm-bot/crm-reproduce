using System;
using System.Collections.Generic;
using System.Web;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Security;

public interface IActiveUserSessionService
{
	IEnumerable<AuthenticatedSessionInfo> GetSessions(AuthenticatedSessionFilter filter);

	IEnumerable<long> GetPrivilegeUserIds();

	IEnumerable<long> GetPrivilegeUserIds(bool includeAdmin);

	AuthenticatedSessionInfo Get(Guid ticketId);

	AuthenticatedSessionInfo FindBySessionId(string sessionId);

	void Insert(AuthenticatedSessionInfo sessionInfo, EleWise.ELMA.Security.Models.IUser user);

	void SetUpdated(AuthenticatedSessionInfo sessionInfo, HttpContextBase httpContext);

	void RemoveSession(Guid ticketId);

	void RemoveAllUserSessions(object userId);
}
