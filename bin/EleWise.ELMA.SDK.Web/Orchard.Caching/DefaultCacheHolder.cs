using System;
using System.Collections.Concurrent;

namespace Orchard.Caching;

public class DefaultCacheHolder : ICacheHolder, ISingletonDependency, IDependency
{
	private class CacheKey : Tuple<Type, Type, Type>
	{
		public CacheKey(Type component, Type key, Type result)
			: base(component, key, result)
		{
		}
	}

	private readonly ICacheContextAccessor _cacheContextAccessor;

	private readonly ConcurrentDictionary<CacheKey, object> _caches = new ConcurrentDictionary<CacheKey, object>();

	public DefaultCacheHolder(ICacheContextAccessor cacheContextAccessor)
	{
		_cacheContextAccessor = cacheContextAccessor;
	}

	public ICache<TKey, TResult> GetCache<TKey, TResult>(Type component)
	{
		CacheKey key = new CacheKey(component, typeof(TKey), typeof(TResult));
		return (Cache<TKey, TResult>)_caches.GetOrAdd(key, (CacheKey k) => new Cache<TKey, TResult>(_cacheContextAccessor));
	}
}
