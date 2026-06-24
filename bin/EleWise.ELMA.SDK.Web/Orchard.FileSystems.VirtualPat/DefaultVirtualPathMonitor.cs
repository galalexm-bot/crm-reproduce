using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Caching;
using System.Web.Hosting;
using EleWise.ELMA.Logging;
using Orchard.Caching;
using Orchard.Logging;
using Orchard.Services;

namespace Orchard.FileSystems.VirtualPath;

public class DefaultVirtualPathMonitor : IVirtualPathMonitor, IVolatileProvider, ISingletonDependency, IDependency
{
	public class Token : IVolatileToken
	{
		public bool IsCurrent { get; set; }

		public string VirtualPath { get; private set; }

		public Token(string virtualPath)
		{
			IsCurrent = true;
			VirtualPath = virtualPath;
		}

		public override string ToString()
		{
			return $"IsCurrent: {IsCurrent}, VirtualPath: \"{VirtualPath}\"";
		}
	}

	private class Thunk
	{
		private readonly Weak<DefaultVirtualPathMonitor> _weak;

		public Thunk(DefaultVirtualPathMonitor provider)
		{
			_weak = new Weak<DefaultVirtualPathMonitor>(provider);
		}

		public void Signal(string key, object value, CacheItemRemovedReason reason)
		{
			_weak.Target?.Signal(key, value, reason);
		}
	}

	private readonly Thunk _thunk;

	private readonly string _prefix = Guid.NewGuid().ToString("n");

	private readonly IDictionary<string, Weak<Token>> _tokens = new Dictionary<string, Weak<Token>>();

	private readonly IClock _clock;

	public ILogger Logger { get; set; }

	public DefaultVirtualPathMonitor(IClock clock)
	{
		_clock = clock;
		_thunk = new Thunk(this);
		Logger = NullLogger.Instance;
	}

	public IVolatileToken WhenPathChanges(string virtualPath)
	{
		Token result = BindToken(virtualPath);
		try
		{
			BindSignal(virtualPath);
			return result;
		}
		catch (HttpException exception)
		{
			Logger.Information(exception, "Error monitoring file changes on virtual path '{0}'", virtualPath);
			return result;
		}
	}

	private Token BindToken(string virtualPath)
	{
		lock (_tokens)
		{
			if (!_tokens.TryGetValue(virtualPath, out var value))
			{
				value = new Weak<Token>(new Token(virtualPath));
				_tokens[virtualPath] = value;
			}
			Token token = value.Target;
			if (token == null)
			{
				token = (value.Target = new Token(virtualPath));
			}
			return token;
		}
	}

	private Token DetachToken(string virtualPath)
	{
		lock (_tokens)
		{
			if (!_tokens.TryGetValue(virtualPath, out var value))
			{
				return null;
			}
			Token target = value.Target;
			value.Target = null;
			return target;
		}
	}

	private void BindSignal(string virtualPath)
	{
		BindSignal(virtualPath, _thunk.Signal);
	}

	private void BindSignal(string virtualPath, CacheItemRemovedCallback callback)
	{
		string key = _prefix + virtualPath;
		if (HostingEnvironment.Cache.Get(key) == null)
		{
			CacheDependency cacheDependency = HostingEnvironment.VirtualPathProvider.GetCacheDependency(virtualPath, new string[1] { virtualPath }, _clock.UtcNow);
			Logger.Debug("Monitoring virtual path \"{0}\"", virtualPath);
			HostingEnvironment.Cache.Add(key, virtualPath, cacheDependency, Cache.NoAbsoluteExpiration, Cache.NoSlidingExpiration, CacheItemPriority.NotRemovable, callback);
		}
	}

	public void Signal(string key, object value, CacheItemRemovedReason reason)
	{
		string text = Convert.ToString(value);
		Logger.Debug("Virtual path changed ({1}) '{0}'", text, reason.ToString());
		Token token = DetachToken(text);
		if (token != null)
		{
			token.IsCurrent = false;
		}
	}
}
