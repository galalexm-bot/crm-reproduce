using System;

namespace EleWise.ELMA.Packaging.Logging;

public static class LoggingExtensions
{
	public static bool IsVerboseEnabled(this ILogger log)
	{
		return log.IsEnabled(LogLevel.Verbose);
	}

	public static bool IsTraceEnabled(this ILogger log)
	{
		return log.IsEnabled(LogLevel.Trace);
	}

	public static bool IsDebugEnabled(this ILogger log)
	{
		return log.IsEnabled(LogLevel.Debug);
	}

	public static bool IsInfoEnabled(this ILogger log)
	{
		return log.IsEnabled(LogLevel.Information);
	}

	public static bool IsWarnEnabled(this ILogger log)
	{
		return log.IsEnabled(LogLevel.Warning);
	}

	public static bool IsErrorEnabled(this ILogger log)
	{
		return log.IsEnabled(LogLevel.Error);
	}

	public static bool IsFatalEnabled(this ILogger log)
	{
		return log.IsEnabled(LogLevel.Fatal);
	}

	public static void Verbose(this ILogger logger, object message)
	{
		FilteredLog(logger, LogLevel.Verbose, null, message, null);
	}

	public static void Trace(this ILogger logger, object message)
	{
		FilteredLog(logger, LogLevel.Trace, null, message, null);
	}

	public static void Debug(this ILogger logger, object message)
	{
		FilteredLog(logger, LogLevel.Debug, null, message, null);
	}

	public static void Info(this ILogger logger, object message)
	{
		FilteredLog(logger, LogLevel.Information, null, message, null);
	}

	public static void Warn(this ILogger logger, object message)
	{
		FilteredLog(logger, LogLevel.Warning, null, message, null);
	}

	public static void Error(this ILogger logger, object message)
	{
		FilteredLog(logger, LogLevel.Error, null, message, null);
	}

	public static void Fatal(this ILogger logger, object message)
	{
		FilteredLog(logger, LogLevel.Fatal, null, message, null);
	}

	public static void Verbose(this ILogger logger, object message, Exception exception)
	{
		FilteredLog(logger, LogLevel.Verbose, exception, message, null);
	}

	public static void Trace(this ILogger logger, object message, Exception exception)
	{
		FilteredLog(logger, LogLevel.Trace, exception, message, null);
	}

	public static void Debug(this ILogger logger, object message, Exception exception)
	{
		FilteredLog(logger, LogLevel.Debug, exception, message, null);
	}

	public static void Info(this ILogger logger, object message, Exception exception)
	{
		FilteredLog(logger, LogLevel.Information, exception, message, null);
	}

	public static void Warn(this ILogger logger, object message, Exception exception)
	{
		FilteredLog(logger, LogLevel.Warning, exception, message, null);
	}

	public static void Error(this ILogger logger, object message, Exception exception)
	{
		FilteredLog(logger, LogLevel.Error, exception, message, null);
	}

	public static void Fatal(this ILogger logger, object message, Exception exception)
	{
		FilteredLog(logger, LogLevel.Fatal, exception, message, null);
	}

	public static void VerboseFormat(this ILogger logger, string format, params object[] args)
	{
		FilteredLog(logger, LogLevel.Verbose, null, format, args);
	}

	public static void TraceFormat(this ILogger logger, string format, params object[] args)
	{
		FilteredLog(logger, LogLevel.Trace, null, format, args);
	}

	public static void DebugFormat(this ILogger logger, string format, params object[] args)
	{
		FilteredLog(logger, LogLevel.Debug, null, format, args);
	}

	public static void InfoFormat(this ILogger logger, string format, params object[] args)
	{
		FilteredLog(logger, LogLevel.Information, null, format, args);
	}

	public static void WarnFormat(this ILogger logger, string format, params object[] args)
	{
		FilteredLog(logger, LogLevel.Warning, null, format, args);
	}

	public static void ErrorFormat(this ILogger logger, string format, params object[] args)
	{
		FilteredLog(logger, LogLevel.Error, null, format, args);
	}

	public static void FatalFormat(this ILogger logger, string format, params object[] args)
	{
		FilteredLog(logger, LogLevel.Fatal, null, format, args);
	}

	public static void Verbose(this ILogger logger, Exception exception, string format, params object[] args)
	{
		FilteredLog(logger, LogLevel.Verbose, exception, format, args);
	}

	public static void Trace(this ILogger logger, Exception exception, string format, params object[] args)
	{
		FilteredLog(logger, LogLevel.Trace, exception, format, args);
	}

	public static void Debug(this ILogger logger, Exception exception, string format, params object[] args)
	{
		FilteredLog(logger, LogLevel.Debug, exception, format, args);
	}

	public static void Info(this ILogger logger, Exception exception, string format, params object[] args)
	{
		FilteredLog(logger, LogLevel.Information, exception, format, args);
	}

	public static void Warn(this ILogger logger, Exception exception, string format, params object[] args)
	{
		FilteredLog(logger, LogLevel.Warning, exception, format, args);
	}

	public static void Error(this ILogger logger, Exception exception, string format, params object[] args)
	{
		FilteredLog(logger, LogLevel.Error, exception, format, args);
	}

	public static void Fatal(this ILogger logger, Exception exception, string format, params object[] args)
	{
		FilteredLog(logger, LogLevel.Fatal, exception, format, args);
	}

	private static void FilteredLog(ILogger logger, LogLevel level, Exception exception, object format, object[] objects)
	{
		if (logger != null && logger.IsEnabled(level))
		{
			string format2 = ((format != null) ? format.ToString() : "");
			logger.Log(level, exception, format2, objects);
		}
	}
}
