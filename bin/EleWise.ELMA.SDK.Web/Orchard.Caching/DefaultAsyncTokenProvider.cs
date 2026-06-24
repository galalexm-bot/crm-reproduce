using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using EleWise.ELMA.Logging;
using Orchard.Exceptions;

namespace Orchard.Caching;

public class DefaultAsyncTokenProvider : IAsyncTokenProvider
{
	public class AsyncVolativeToken : IVolatileToken
	{
		private readonly Action<Action<IVolatileToken>> _task;

		private readonly List<IVolatileToken> _taskTokens = new List<IVolatileToken>();

		private volatile Exception _taskException;

		private volatile bool _isTaskFinished;

		public ILogger Logger { get; set; }

		public bool IsCurrent
		{
			get
			{
				if (_taskException != null)
				{
					return false;
				}
				if (_isTaskFinished)
				{
					return _taskTokens.All((IVolatileToken t) => t.IsCurrent);
				}
				return true;
			}
		}

		public AsyncVolativeToken(Action<Action<IVolatileToken>> task, ILogger logger)
		{
			_task = task;
			Logger = logger;
		}

		public void QueueWorkItem()
		{
			ThreadPool.QueueUserWorkItem(delegate
			{
				try
				{
					_task(delegate(IVolatileToken token)
					{
						_taskTokens.Add(token);
					});
				}
				catch (Exception ex)
				{
					if (ex.IsFatal())
					{
						throw;
					}
					Logger.Error(ex, "Error while monitoring extension files. Assuming extensions are not current.");
					_taskException = ex;
				}
				finally
				{
					_isTaskFinished = true;
				}
			});
		}
	}

	public ILogger Logger { get; set; }

	public DefaultAsyncTokenProvider()
	{
		Logger = NullLogger.Instance;
	}

	public IVolatileToken GetToken(Action<Action<IVolatileToken>> task)
	{
		AsyncVolativeToken asyncVolativeToken = new AsyncVolativeToken(task, Logger);
		asyncVolativeToken.QueueWorkItem();
		return asyncVolativeToken;
	}
}
