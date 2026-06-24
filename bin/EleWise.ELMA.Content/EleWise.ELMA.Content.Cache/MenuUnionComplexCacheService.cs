using System;
using System.Collections.Generic;
using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Content.Cache;

[Service(EnableInterceptors = false, Type = ComponentType.Server)]
internal class MenuUnionComplexCacheService : UnionComplexCacheService
{
	private struct Timestamp
	{
		internal long Timestamp1;

		internal long Timestamp2;

		internal long Timestamp3;

		public bool Equal(Timestamp other)
		{
			if (Timestamp1 == other.Timestamp1 && Timestamp2 == other.Timestamp2)
			{
				return Timestamp3 == other.Timestamp3;
			}
			return false;
		}
	}

	private struct TimestampKey
	{
		private readonly string timestampKey1;

		private readonly string timestampKey2;

		private readonly string timestampKey3;

		public TimestampKey(string timestampKey1, string timestampKey2, string timestampKey3)
		{
			this.timestampKey1 = timestampKey1;
			this.timestampKey2 = timestampKey2;
			this.timestampKey3 = timestampKey3;
		}

		public Timestamp TryGetValue(IAbstractBoundVariableService cache)
		{
			Timestamp result = default(Timestamp);
			cache.TryGetValue<long>(timestampKey1, out result.Timestamp1);
			cache.TryGetValue<long>(timestampKey2, out result.Timestamp2);
			cache.TryGetValue<long>(timestampKey3, out result.Timestamp3);
			return result;
		}

		public Timestamp TryGetValue(IDictionary<string, long> cache)
		{
			Timestamp result = default(Timestamp);
			cache.TryGetValue(timestampKey1, out result.Timestamp1);
			cache.TryGetValue(timestampKey2, out result.Timestamp2);
			cache.TryGetValue(timestampKey3, out result.Timestamp3);
			return result;
		}
	}

	private new class CacheEntry<T>
	{
		public T Value { get; set; }

		public Timestamp Timestamp { get; set; }
	}

	public MenuUnionComplexCacheService(ICacheService cacheService, IMemoryCacheService memoryCacheService, IContextBoundVariableService contextCacheService)
		: base(cacheService, memoryCacheService, contextCacheService)
	{
	}

	public virtual T GetOrAdd<T>(string key, string timestampKey1, string timestampKey2, string timestampKey3, Func<T> valueAccessor)
	{
		if (string.IsNullOrEmpty(key))
		{
			throw new ArgumentNullException("key");
		}
		if (string.IsNullOrEmpty(timestampKey1))
		{
			throw new ArgumentNullException("timestampKey1");
		}
		if (string.IsNullOrEmpty(timestampKey2))
		{
			throw new ArgumentNullException("timestampKey2");
		}
		if (string.IsNullOrEmpty(timestampKey3))
		{
			throw new ArgumentNullException("timestampKey3");
		}
		if (valueAccessor == null)
		{
			throw new ArgumentNullException("valueAccessor");
		}
		TimestampKey timestampKey4 = new TimestampKey(timestampKey1, timestampKey2, timestampKey3);
		if (TryGetFromContextCache<T>(key, timestampKey4, out var value))
		{
			return value;
		}
		if (!TryGetFromGlobalCache<T>(key, timestampKey4, out value))
		{
			value = valueAccessor();
			SaveToGlobalCache(key, timestampKey4, value);
		}
		SaveToContextCache(key, timestampKey4, value);
		return value;
	}

	private bool TryGetFromContextCache<T>(string key, TimestampKey timestampKey, out T value)
	{
		Timestamp other = timestampKey.TryGetValue(_contextCacheService);
		if (_contextCacheService.TryGetValue<CacheEntry<T>>(key, out var value2) && value2.Timestamp.Equal(other))
		{
			value = value2.Value;
			return true;
		}
		value = default(T);
		return false;
	}

	private void SaveToContextCache<T>(string key, TimestampKey timestampKey, T value)
	{
		Timestamp timestamp = timestampKey.TryGetValue(_contextCacheService);
		_contextCacheService.Set(key, new CacheEntry<T>
		{
			Timestamp = timestamp,
			Value = value
		});
	}

	private bool TryGetFromGlobalCache<T>(string key, TimestampKey timestampKey, out T value)
	{
		SerializableDictionary<string, long> timestamps = getTimestamps();
		Timestamp other = timestampKey.TryGetValue(timestamps);
		if (_memoryCacheService.TryGetValue<CacheEntry<T>>(key, out var result) && result.Timestamp.Equal(other))
		{
			value = result.Value;
			return true;
		}
		value = default(T);
		return false;
	}

	private void SaveToGlobalCache<T>(string key, TimestampKey timestampKey, T value)
	{
		SerializableDictionary<string, long> timestamps = getTimestamps();
		Timestamp timestamp = timestampKey.TryGetValue(timestamps);
		_memoryCacheService.Insert(key, new CacheEntry<T>
		{
			Timestamp = timestamp,
			Value = value
		});
	}
}
