#define TRACE
using System;
using System.Diagnostics;
using System.IO;

namespace EleWise.ELMA.Packaging.Logging;

public static class Logger
{
	public class DebugLogger : ILogger
	{
		public static DebugLogger Instance = new DebugLogger();

		public bool IsEnabled(LogLevel level)
		{
			return true;
		}

		public void Log(LogLevel level, Exception exception, string format, params object[] args)
		{
			if (args != null)
			{
				string.Format(format, args);
			}
		}
	}

	public class TraceLogger : ILogger
	{
		public static TraceLogger Instance = new TraceLogger();

		public bool IsEnabled(LogLevel level)
		{
			return true;
		}

		public void Log(LogLevel level, Exception exception, string format, params object[] args)
		{
			string text = ((args != null) ? string.Format(format, args) : format);
			Trace.WriteLine(string.Concat("TR --- ", level, " ", text, " ", exception));
			Trace.Flush();
		}
	}

	public class ConsoleLogger : ILogger
	{
		public static ConsoleLogger Instance = new ConsoleLogger();

		public bool IsEnabled(LogLevel level)
		{
			return true;
		}

		public void Log(LogLevel level, Exception exception, string format, params object[] args)
		{
			string text = ((args != null) ? string.Format(format, args) : format);
			Console.WriteLine(string.Concat(DateTime.Now, " - ", level, " ", text, " ", exception));
		}
	}

	private static ILogger _log;

	public static ILogger Log
	{
		get
		{
			if (_log == null)
			{
				_log = Log4netLogger.DefaultInstance;
			}
			return _log;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			_log = value;
		}
	}

	static Logger()
	{
		NullLogger.SetupImpl(Log4netLogger.DefaultInstance);
	}

	internal static string GetConfigFile(string fileName)
	{
		if (Path.IsPathRooted(fileName))
		{
			return fileName;
		}
		return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
	}
}
