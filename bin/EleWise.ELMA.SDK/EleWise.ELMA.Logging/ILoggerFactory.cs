using System;

namespace EleWise.ELMA.Logging;

public interface ILoggerFactory
{
	ILogger CreateLogger(Type type);

	ILogger CreateLogger(string name);
}
