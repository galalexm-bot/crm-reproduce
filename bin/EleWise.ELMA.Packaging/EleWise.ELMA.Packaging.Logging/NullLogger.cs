using System;

namespace EleWise.ELMA.Packaging.Logging;

public class NullLogger : ILogger
{
	private static volatile ILogger _instance = new NullLogger();

	public static ILogger Instance => _instance;

	public static void SetupImpl(ILogger impl)
	{
		if (impl == null)
		{
			throw new ArgumentNullException("impl");
		}
		_instance = impl;
	}

	public bool IsEnabled(LogLevel level)
	{
		return false;
	}

	public void Log(LogLevel level, Exception exception, string format, params object[] args)
	{
	}
}
