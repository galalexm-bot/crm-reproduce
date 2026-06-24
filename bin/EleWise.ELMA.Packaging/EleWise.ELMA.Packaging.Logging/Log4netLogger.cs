using System;
using System.Globalization;
using log4net;
using log4net.Core;
using log4net.Util;

namespace EleWise.ELMA.Packaging.Logging;

[Serializable]
public class Log4netLogger : MarshalByRefObject, ILogger
{
	private static readonly Type declaringType;

	private static readonly Type defaultCallerType;

	private ILogger logger;

	private static ILogger _defaultInstance;

	private static readonly object _lockObject;

	public static ILogger DefaultInstance
	{
		get
		{
			try
			{
				if (_defaultInstance != null)
				{
					return _defaultInstance;
				}
				lock (_lockObject)
				{
					if (_defaultInstance != null)
					{
						return _defaultInstance;
					}
					_defaultInstance = new Log4netFactory().CreateLogger(typeof(Logger));
				}
				return _defaultInstance;
			}
			catch
			{
				return new NullLogger();
			}
		}
	}

	static Log4netLogger()
	{
		_defaultInstance = null;
		_lockObject = new object();
		declaringType = typeof(Log4netLogger);
		defaultCallerType = typeof(LoggingExtensions);
	}

	internal Log4netLogger()
	{
	}

	public Log4netLogger(ILogger logger)
	{
		this.logger = logger;
	}

	internal Log4netLogger(ILog log)
		: this(((ILoggerWrapper)log).get_Logger())
	{
	}

	private Level GetLevel(LogLevel level)
	{
		return (Level)(level switch
		{
			LogLevel.Verbose => Level.Verbose, 
			LogLevel.Trace => Level.Trace, 
			LogLevel.Debug => Level.Debug, 
			LogLevel.Information => Level.Info, 
			LogLevel.Warning => Level.Warn, 
			LogLevel.Error => Level.Error, 
			LogLevel.Fatal => Level.Fatal, 
			_ => Level.All, 
		});
	}

	public bool IsEnabled(LogLevel level)
	{
		return logger.IsEnabledFor(GetLevel(level));
	}

	public void Log(LogLevel level, Exception exception, string format, params object[] args)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		if (IsEnabled(level))
		{
			Type type = declaringType;
			logger.Log(type, GetLevel(level), (object)new SystemStringFormat((IFormatProvider)CultureInfo.InvariantCulture, format, args), exception);
		}
	}
}
