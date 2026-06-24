using System;
using EleWise.ELMA.API.Models;

namespace EleWise.ELMA.API;

public interface IPublicCacheService
{
	bool IsCacheValid(Guid authToken, string tokenValue, out IPublicClientCacheToken cacheToken);

	long RemoveExpired(TimeSpan expireInterval);

	IPublicClientCacheToken CreateCacheToken(Guid authToken, string tokenValue);

	Guid GetTokenKey(Guid authToken, string tokenValue);

	bool PromoteCacheToken(Guid authToken, string tokenValue);

	string GetTokenValue(Guid typeUid, string eqlQuery);

	bool SyncCache(Guid authToken, Guid typeUid, DateTime? fromDate, long[] data, string eqlQuery);

	bool UpdateCache(Guid authToken, Guid typeUid, DateTime? fromDate, long[] updated, long[] deleted, string eqlQuery);
}
