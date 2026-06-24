using System;

namespace EleWise.ELMA.Packaging.Logging;

public interface ILoggerFactory
{
	ILogger CreateLogger(Type type);
}
