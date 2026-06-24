using System;
using System.Collections.Generic;
using EleWise.ELMA.API.Models;

namespace EleWise.ELMA.API;

public interface IPublicClientService
{
	IEnumerable<IPublicClientSession> Sessions { get; }

	IPublicClientSession CreateSession(Guid authToken, string applicationToken);

	bool UpdateAuthToken(string sessionToken, Guid newToken);

	bool IsSessionValid(string sessionToken, out IPublicClientSession session);

	bool PromoteSession(string sessionToken);

	bool RemoveSession(string sessionToken);

	IPublicClientSession GetSession(Guid authToken);

	bool UpdateLastChangesPackage(Guid authToken, string changesPackage);

	long RemoveExpired(TimeSpan expireInterval);
}
