using System;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Cache;

[DeveloperApi(DeveloperApiType.Service)]
public interface ICacheService
{
	bool IsDistributed { get; }

	[Obsolete("Этот метод поддерживается полностью только на локальном кэше AspNet")]
	void Insert<T>(string key, T value, string region, TimeSpan cacheDuration, CacheItemRemovedCallback<T> onRemoveItemCallback);

	void Insert<T>(string key, T value, string region, TimeSpan cacheDuration);

	void Insert<T>(string key, T value, TimeSpan cacheDuration);

	void Insert<T>(string key, T value, string region);

	void Insert<T>(string key, T value);

	bool Contains(string key);

	bool Contains(string key, string region);

	T Get<T>(string key);

	T Get<T>(string key, string region);

	bool TryGetValue<T>(string key, out T value);

	bool TryGetValue<T>(string key, string region, out T value);

	void Remove(string key);

	void Remove(string key, string region);

	void ClearRegion(string region);
}
