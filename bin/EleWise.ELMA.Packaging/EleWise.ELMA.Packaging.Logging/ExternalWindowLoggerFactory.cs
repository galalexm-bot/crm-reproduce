using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Packaging.Logging;

public class ExternalWindowLoggerFactory : ILoggerFactory, IDisposable
{
	private ILoggerFactory _baseLoggerFactory;

	private IntPtr _hwnd;

	private List<ExternalWindowLogger> _createdLoggers = new List<ExternalWindowLogger>();

	public ExternalWindowLoggerFactory(ILoggerFactory baseLoggerFactory, IntPtr hwnd)
	{
		if (baseLoggerFactory == null)
		{
			throw new ArgumentNullException("baseLoggerFactory");
		}
		_baseLoggerFactory = baseLoggerFactory;
		_hwnd = hwnd;
	}

	public ILogger CreateLogger(Type type)
	{
		lock (this)
		{
			ExternalWindowLogger externalWindowLogger = new ExternalWindowLogger(_baseLoggerFactory.CreateLogger(type), _hwnd);
			_createdLoggers.Add(externalWindowLogger);
			return externalWindowLogger;
		}
	}

	public void Dispose()
	{
		lock (this)
		{
			try
			{
				foreach (ExternalWindowLogger createdLogger in _createdLoggers)
				{
					createdLogger.Dispose();
				}
			}
			finally
			{
				_createdLoggers.Clear();
			}
		}
	}
}
