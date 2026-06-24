using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using Orchard.Environment.Configuration;

namespace Orchard.Environment;

public class RunningShellTable : IRunningShellTable
{
	private IEnumerable<ShellSettings> _shells = Enumerable.Empty<ShellSettings>();

	private IDictionary<string, IEnumerable<ShellSettings>> _shellsByHost;

	private readonly ConcurrentDictionary<string, ShellSettings> _shellsByHostAndPrefix = new ConcurrentDictionary<string, ShellSettings>(StringComparer.OrdinalIgnoreCase);

	private ShellSettings _fallback;

	private readonly ReaderWriterLockSlim _lock = new ReaderWriterLockSlim();

	public void Add(ShellSettings settings)
	{
		_lock.EnterWriteLock();
		try
		{
			_shells = _shells.Where((ShellSettings s) => s.Name != settings.Name).Concat(new ShellSettings[1] { settings }).ToArray();
			Organize();
		}
		finally
		{
			_lock.ExitWriteLock();
		}
	}

	public void Remove(ShellSettings settings)
	{
		_lock.EnterWriteLock();
		try
		{
			_shells = _shells.Where((ShellSettings s) => s.Name != settings.Name).ToArray();
			Organize();
		}
		finally
		{
			_lock.ExitWriteLock();
		}
	}

	public void Update(ShellSettings settings)
	{
		_lock.EnterWriteLock();
		try
		{
			_shells = _shells.Where((ShellSettings s) => s.Name != settings.Name).ToArray();
			_shells = _shells.Concat(new ShellSettings[1] { settings }).ToArray();
			Organize();
		}
		finally
		{
			_lock.ExitWriteLock();
		}
	}

	private void Organize()
	{
		IEnumerable<ShellSettings> source = _shells.Where((ShellSettings x) => !string.IsNullOrEmpty(x.RequestUrlHost) || !string.IsNullOrEmpty(x.RequestUrlPrefix));
		List<ShellSettings> source2 = _shells.Where((ShellSettings x) => string.IsNullOrEmpty(x.RequestUrlHost) && string.IsNullOrEmpty(x.RequestUrlPrefix)).ToList();
		_shellsByHost = (from s in source.SelectMany((ShellSettings s) => (s.RequestUrlHost != null && s.RequestUrlHost.IndexOf(',') != -1) ? (from h in s.RequestUrlHost.Split(new char[1] { ',' }, StringSplitOptions.RemoveEmptyEntries)
				select new ShellSettings(s)
				{
					RequestUrlHost = h
				}) : new ShellSettings[1] { s })
			group s by s.RequestUrlHost ?? string.Empty into g
			orderby g.Key.Length descending
			select g).ToDictionary((IGrouping<string, ShellSettings> x) => x.Key, (IGrouping<string, ShellSettings> x) => x.AsEnumerable(), StringComparer.OrdinalIgnoreCase);
		if (source2.Count() == 1)
		{
			_fallback = source2.Single();
		}
		else if (source2.Any())
		{
			_fallback = source2.SingleOrDefault((ShellSettings x) => x.Name == "Default");
		}
		else
		{
			_fallback = null;
		}
		_shellsByHostAndPrefix.Clear();
	}

	public ShellSettings Match(HttpContextBase httpContext)
	{
		try
		{
			HttpRequestBase request = httpContext.Request;
			if (request == null)
			{
				return null;
			}
			string text = request.Headers["Host"];
			string appRelativeCurrentExecutionFilePath = request.AppRelativeCurrentExecutionFilePath;
			return Match(text ?? string.Empty, appRelativeCurrentExecutionFilePath);
		}
		catch (HttpException)
		{
			return null;
		}
	}

	public ShellSettings Match(string host, string appRelativePath)
	{
		_lock.EnterReadLock();
		try
		{
			if (_shellsByHost == null)
			{
				return null;
			}
			if (!_shellsByHost.Any() && _fallback != null)
			{
				return _fallback;
			}
			int num = host.IndexOf(':');
			if (num != -1)
			{
				host = host.Substring(0, num);
			}
			string key2 = host + "/" + appRelativePath.Split('/')[1];
			return _shellsByHostAndPrefix.GetOrAdd(key2, delegate(string key)
			{
				if (!_shellsByHost.TryGetValue(host, out var value) && !_shellsByHost.TryGetValue("", out value))
				{
					string text = _shellsByHost.Keys.FirstOrDefault((string x) => x.StartsWith("*.") && host.EndsWith(x.Substring(2)));
					if (text == null)
					{
						return _fallback;
					}
					value = _shellsByHost[text];
				}
				return value.FirstOrDefault(delegate(ShellSettings settings)
				{
					if (settings.State == TenantState.Disabled)
					{
						return false;
					}
					return string.IsNullOrWhiteSpace(settings.RequestUrlPrefix) || key.Equals(host + "/" + settings.RequestUrlPrefix, StringComparison.OrdinalIgnoreCase);
				}) ?? _fallback;
			});
		}
		finally
		{
			_lock.ExitReadLock();
		}
	}
}
