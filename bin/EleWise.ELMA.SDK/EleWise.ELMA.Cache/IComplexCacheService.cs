using System;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Cache;

[DeveloperApi(DeveloperApiType.Service)]
public interface IComplexCacheService
{
	T GetOrAdd<T>(string key, string timestampKey, Func<T> valueAccessor);

	T GetOrAdd<T>(string key, string timestampKey, Func<T> valueAccessor, TimeSpan timeout);

	T GetOrAdd<T>(string key, string timestampKey, string timestampRegionKey, Func<T> valueAccessor);

	T GetOrAdd<T>(string key, string timestampKey, string timestampRegionKey, Func<T> valueAccessor, TimeSpan timeout);

	void RefreshTimestamp(string timestampKey);

	void RefreshTimestamp(string timestampKey, string timestampRegionKey);

	void RefreshTimestampRegion(string timestampRegionKey);
}
