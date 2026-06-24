using System;
using System.Collections.Generic;
using System.Linq;

namespace Orchard.Caching;

public class DefaultParallelCacheContext : IParallelCacheContext
{
	public class TaskWithAcquireContext<T> : ITask<T>, IDisposable
	{
		private readonly ICacheContextAccessor _cacheContextAccessor;

		private readonly Func<T> _function;

		private IList<IVolatileToken> _tokens;

		public IEnumerable<IVolatileToken> Tokens
		{
			get
			{
				if (_tokens == null)
				{
					return Enumerable.Empty<IVolatileToken>();
				}
				return _tokens;
			}
		}

		public TaskWithAcquireContext(ICacheContextAccessor cacheContextAccessor, Func<T> function)
		{
			_cacheContextAccessor = cacheContextAccessor;
			_function = function;
		}

		public T Execute()
		{
			IAcquireContext current = _cacheContextAccessor.Current;
			try
			{
				if (current == null)
				{
					_cacheContextAccessor.Current = new SimpleAcquireContext(AddToken);
				}
				return _function();
			}
			finally
			{
				if (current == null)
				{
					_cacheContextAccessor.Current = current;
				}
			}
		}

		public void Dispose()
		{
			Finish();
		}

		public void Finish()
		{
			IList<IVolatileToken> tokens = _tokens;
			_tokens = null;
			if (_cacheContextAccessor.Current == null || tokens == null)
			{
				return;
			}
			foreach (IVolatileToken item in tokens)
			{
				_cacheContextAccessor.Current.Monitor(item);
			}
		}

		private void AddToken(IVolatileToken token)
		{
			if (_tokens == null)
			{
				_tokens = new List<IVolatileToken>();
			}
			_tokens.Add(token);
		}
	}

	private readonly ICacheContextAccessor _cacheContextAccessor;

	public bool Disabled { get; set; }

	public DefaultParallelCacheContext(ICacheContextAccessor cacheContextAccessor)
	{
		_cacheContextAccessor = cacheContextAccessor;
	}

	public IEnumerable<TResult> RunInParallel<T, TResult>(IEnumerable<T> source, Func<T, TResult> selector)
	{
		if (Disabled)
		{
			return source.Select(selector);
		}
		List<ITask<TResult>> list = source.Select((T item) => CreateContextAwareTask(() => selector(item))).ToList();
		TResult[] result = list.Select((ITask<TResult> task) => task.Execute()).ToArray();
		foreach (ITask<TResult> item in list)
		{
			item.Finish();
		}
		return result;
	}

	public ITask<T> CreateContextAwareTask<T>(Func<T> function)
	{
		return new TaskWithAcquireContext<T>(_cacheContextAccessor, function);
	}
}
