using System;

namespace EleWise.ELMA.API.Models;

public interface IPublicClientCacheToken
{
	long Id { get; }

	IPublicClientSession Session { get; }

	Guid TokenKey { get; }

	string TokenValue { get; }

	DateTime LastAccess { get; }
}
