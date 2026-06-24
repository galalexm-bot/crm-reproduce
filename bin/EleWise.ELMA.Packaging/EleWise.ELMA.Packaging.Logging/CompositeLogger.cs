using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Packaging.Logging;

public class CompositeLogger : ILogger
{
	public IEnumerable<ILogger> Loggers { get; set; }

	public CompositeLogger(IEnumerable<ILogger> loggers)
	{
		if (loggers == null)
		{
			throw new ArgumentNullException("loggers");
		}
		Loggers = loggers;
	}

	public bool IsEnabled(LogLevel level)
	{
		if (Loggers == null)
		{
			return false;
		}
		return Loggers.Any((ILogger l) => l.IsEnabled(level));
	}

	public void Log(LogLevel level, Exception exception, string format, params object[] args)
	{
		if (Loggers == null)
		{
			return;
		}
		foreach (ILogger logger in Loggers)
		{
			logger.Log(level, exception, format, args);
		}
	}
}
