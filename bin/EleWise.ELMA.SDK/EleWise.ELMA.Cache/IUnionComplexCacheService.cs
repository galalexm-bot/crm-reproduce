using System;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Cache;

[DeveloperApi(DeveloperApiType.Service)]
public interface IUnionComplexCacheService
{
	T GetOrAdd<T>(string key, string timestampKey, Func<T> valueAccessor);

	T GetOrAdd<T>(string key, string timestampKey, Func<T> valueAccessor, TimeSpan timeout);

	void RefreshTimestamp(string timestampKey);
}
