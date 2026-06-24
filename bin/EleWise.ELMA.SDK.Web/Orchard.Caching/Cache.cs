using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace Orchard.Caching;

public class Cache<TKey, TResult> : ICache<TKey, TResult>
{
	private class CacheEntry
	{
		private IList<IVolatileToken> _tokens;

		public TResult Result { get; set; }

		public IEnumerable<IVolatileToken> Tokens
		{
			get
			{
				IEnumerable<IVolatileToken> tokens = _tokens;
				return tokens ?? Enumerable.Empty<IVolatileToken>();
			}
		}

		public void AddToken(IVolatileToken volatileToken)
		{
			if (_tokens == null)
			{
				_tokens = new List<IVolatileToken>();
			}
			_tokens.Add(volatileToken);
		}

		public void CompactTokens()
		{
			if (_tokens != null)
			{
				_tokens = _tokens.Distinct().ToArray();
			}
		}
	}

	private readonly ICacheContextAccessor _cacheContextAccessor;

	private readonly ConcurrentDictionary<TKey, CacheEntry> _entries;

	public Cache(ICacheContextAccessor cacheContextAccessor)
	{
		_cacheContextAccessor = cacheContextAccessor;
		_entries = new ConcurrentDictionary<TKey, CacheEntry>();
	}

	public TResult Get(TKey key, Func<AcquireContext<TKey>, TResult> acquire)
	{
		return _entries.AddOrUpdate(key, (TKey k) => AddEntry(k, acquire), (TKey k, CacheEntry currentEntry) => UpdateEntry(currentEntry, k, acquire)).Result;
	}

	private CacheEntry AddEntry(TKey k, Func<AcquireContext<TKey>, TResult> acquire)
	{
		CacheEntry cacheEntry = CreateEntry(k, acquire);
		PropagateTokens(cacheEntry);
		return cacheEntry;
	}

	private CacheEntry UpdateEntry(CacheEntry currentEntry, TKey k, Func<AcquireContext<TKey>, TResult> acquire)
	{
		CacheEntry cacheEntry = (currentEntry.Tokens.Any((IVolatileToken t) => t != null && !t.IsCurrent) ? CreateEntry(k, acquire) : currentEntry);
		PropagateTokens(cacheEntry);
		return cacheEntry;
	}

	private void PropagateTokens(CacheEntry entry)
	{
		if (_cacheContextAccessor.Current == null)
		{
			return;
		}
		foreach (IVolatileToken token in entry.Tokens)
		{
			_cacheContextAccessor.Current.Monitor(token);
		}
	}

	private CacheEntry CreateEntry(TKey k, Func<AcquireContext<TKey>, TResult> acquire)
	{
		CacheEntry cacheEntry = new CacheEntry();
		AcquireContext<TKey> acquireContext = new AcquireContext<TKey>(k, cacheEntry.AddToken);
		IAcquireContext current = null;
		try
		{
			current = _cacheContextAccessor.Current;
			_cacheContextAccessor.Current = acquireContext;
			cacheEntry.Result = acquire(acquireContext);
		}
		finally
		{
			_cacheContextAccessor.Current = current;
		}
		cacheEntry.CompactTokens();
		return cacheEntry;
	}
}
