using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.Context;
using EleWise.ELMA.Services;

namespace Orchard.Logging;

internal static class ELMALoggingExtensions
{
	public static void Verbose(this ILogger logger, string format, params object[] args)
	{
		logger.LogFormat(LogLevel.Verbose, format, args);
	}

	public static void Trace(this ILogger logger, string format, params object[] args)
	{
		logger.LogFormat(LogLevel.Trace, format, args);
	}

	public static void Debug(this ILogger logger, string format, params object[] args)
	{
		logger.LogFormat(LogLevel.Debug, format, args);
	}

	public static void Information(this ILogger logger, string format, params object[] args)
	{
		logger.LogFormat(LogLevel.Information, format, args);
	}

	public static void Warning(this ILogger logger, string format, params object[] args)
	{
		logger.LogFormat(LogLevel.Warning, format, args);
	}

	public static void Error(this ILogger logger, string format, params object[] args)
	{
		logger.LogFormat(LogLevel.Error, format, args);
	}

	public static void Fatal(this ILogger logger, string format, params object[] args)
	{
		logger.LogFormat(LogLevel.Fatal, format, args);
	}

	private static void LogFormat(this ILogger logger, LogLevel level, string format, params object[] args)
	{
		FilteredLog(logger, level, null, format, args);
	}

	public static void Information(this ILogger logger, Exception exception, string format, params object[] args)
	{
		Log(logger, LogLevel.Information, exception, format, args);
	}

	public static void Warning(this ILogger logger, Exception exception, string format, params object[] args)
	{
		Log(logger, LogLevel.Warning, exception, format, args);
	}

	private static void Log(this ILogger logger, LogLevel level, Exception exception, string format, params object[] args)
	{
		FilteredLog(logger, level, exception, format, args);
	}

	private static void FilteredLog(ILogger logger, LogLevel level, Exception exception, object format, object[] objects)
	{
		if (logger == null || !logger.IsEnabled(level))
		{
			return;
		}
		using (ELMAContext.Create())
		{
			int num;
			if (ComponentManager.Initialized && ComponentManager.Current.Stage != ComponentManager.LifetimeStage.Disposed)
			{
				num = ((ComponentManager.Current.Stage != ComponentManager.LifetimeStage.BeforeInit) ? 1 : 0);
				if (num != 0 && !ContextVars.Contains("EleWise.ELMA.Logging.LoggingExtensions.ContextCallType"))
				{
					ContextVars.Set("EleWise.ELMA.Logging.LoggingExtensions.ContextCallType", typeof(ELMALoggingExtensions));
				}
			}
			else
			{
				num = 0;
			}
			string format2 = ((format != null) ? format.ToString() : "");
			logger.Log(level, exception, format2, objects);
			if (num != 0)
			{
				ContextVars.Set<Type>("EleWise.ELMA.Logging.LoggingExtensions.ContextCallType", null);
			}
		}
	}
}
