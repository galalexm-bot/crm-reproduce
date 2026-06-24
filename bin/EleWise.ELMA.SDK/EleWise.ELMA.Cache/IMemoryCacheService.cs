using System;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Cache;

[DeveloperApi(DeveloperApiType.Service)]
public interface IMemoryCacheService
{
	bool TryGetValue<T>(string key, out T result);

	bool Contains(string key);

	void Insert<T>(string key, T value);

	void Insert<T>(string key, T value, TimeSpan timeout);

	void Remove(string key);

	void RemoveBySubkey(string subkey);
}
