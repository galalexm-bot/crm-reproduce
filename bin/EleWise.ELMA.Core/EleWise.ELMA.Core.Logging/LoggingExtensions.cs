using System;

namespace EleWise.ELMA.Core.Logging;

public static class LoggingExtensions
{
	public static void Verbose(this ILogger logger, object message)
	{
		logger.Log(LogLevel.Verbose, message);
	}

	public static void Trace(this ILogger logger, object message)
	{
		logger.Log(LogLevel.Trace, message);
	}

	public static void Debug(this ILogger logger, object message)
	{
		logger.Log(LogLevel.Debug, message);
	}

	public static void Info(this ILogger logger, object message)
	{
		logger.Log(LogLevel.Information, message);
	}

	public static void Info(this ILogger logger, object message, object[] objects)
	{
		logger.Log(LogLevel.Error, message, objects);
	}

	public static void Warn(this ILogger logger, object message)
	{
		logger.Log(LogLevel.Warning, message);
	}

	public static void Warn(this ILogger logger, object message, object[] objects)
	{
		logger.Log(LogLevel.Error, message, objects);
	}

	public static void Error(this ILogger logger, object message)
	{
		logger.Log(LogLevel.Error, message);
	}

	public static void Error(this ILogger logger, object message, object[] objects)
	{
		logger.Log(LogLevel.Error, message, objects);
	}

	public static void Fatal(this ILogger logger, object message)
	{
		logger.Log(LogLevel.Fatal, message);
	}

	public static void Log(this ILogger logger, LogLevel level, object message)
	{
		FilteredLog(logger, level, null, message, null);
	}

	public static void Log(this ILogger logger, LogLevel level, object message, object[] objects)
	{
		FilteredLog(logger, level, null, message, objects);
	}

	public static void Verbose(this ILogger logger, object message, System.Exception exception)
	{
		logger.Log(LogLevel.Verbose, message, exception);
	}

	public static void Trace(this ILogger logger, object message, System.Exception exception)
	{
		logger.Log(LogLevel.Trace, message, exception);
	}

	public static void Debug(this ILogger logger, object message, System.Exception exception)
	{
		logger.Log(LogLevel.Debug, message, exception);
	}

	public static void Info(this ILogger logger, object message, System.Exception exception)
	{
		logger.Log(LogLevel.Information, message, exception);
	}

	public static void Warn(this ILogger logger, object message, System.Exception exception)
	{
		logger.Log(LogLevel.Warning, message, exception);
	}

	public static void Error(this ILogger logger, object message, System.Exception exception)
	{
		logger.Log(LogLevel.Error, message, exception);
	}

	public static void Fatal(this ILogger logger, object message, System.Exception exception)
	{
		logger.Log(LogLevel.Fatal, message, exception);
	}

	public static void Log(this ILogger logger, LogLevel level, object message, System.Exception exception)
	{
		FilteredLog(logger, level, exception, message, null);
	}

	private static void FilteredLog(ILogger logger, LogLevel level, System.Exception exception, object format, object[] objects)
	{
		string format2 = ((format != null) ? format.ToString() : "");
		logger.Log(level, exception, format2, objects);
	}
}
