using System;

namespace Orchard.Caching;

public interface ICacheHolder : ISingletonDependency, IDependency
{
	ICache<TKey, TResult> GetCache<TKey, TResult>(Type component);
}
