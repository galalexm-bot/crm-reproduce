using System;

namespace Orchard.Caching;

public static class CacheManagerExtensions
{
	public static TResult Get<TKey, TResult>(this ICacheManager cacheManager, TKey key, bool preventConcurrentCalls, Func<AcquireContext<TKey>, TResult> acquire)
	{
		if (preventConcurrentCalls)
		{
			lock ((object)key)
			{
				return cacheManager.Get(key, acquire);
			}
		}
		return cacheManager.Get(key, acquire);
	}
}
