using System;
using NuGet;

namespace EleWise.ELMA.Packaging.Logging;

public class NugetLoggerShim : ILogger, IFileConflictResolver
{
	public ILogger BaseLogger { get; set; }

	public NugetLoggerShim(ILogger baseLogger)
	{
		if (baseLogger == null)
		{
			throw new ArgumentNullException("baseLogger");
		}
		BaseLogger = baseLogger;
	}

	public void Log(MessageLevel level, string message, params object[] args)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected I4, but got Unknown
		LogLevel level2 = LogLevel.Trace;
		switch ((int)level)
		{
		case 2:
			level2 = LogLevel.Debug;
			break;
		case 3:
			level2 = LogLevel.Error;
			break;
		case 0:
			level2 = LogLevel.Information;
			break;
		case 1:
			level2 = LogLevel.Warning;
			break;
		}
		BaseLogger.Log(level2, null, message, args);
	}

	public FileConflictResolution ResolveFileConflict(string message)
	{
		throw new NotImplementedException();
	}
}
