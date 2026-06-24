using System;

namespace EleWise.ELMA.Logging;

public interface ILogger
{
	event EventHandler ConfigurationChanged;

	bool IsEnabled(LogLevel level);

	void Log(LogLevel level, Exception exception, string format, params object[] args);
}
