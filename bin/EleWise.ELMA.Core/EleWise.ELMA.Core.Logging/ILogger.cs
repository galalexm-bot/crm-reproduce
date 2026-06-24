using System;

namespace EleWise.ELMA.Core.Logging;

public interface ILogger
{
	void Log(LogLevel level, System.Exception exception, string format, params object[] args);
}
