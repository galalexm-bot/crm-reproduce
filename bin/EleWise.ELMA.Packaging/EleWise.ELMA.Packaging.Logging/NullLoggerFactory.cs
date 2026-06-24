using System;

namespace EleWise.ELMA.Packaging.Logging;

internal class NullLoggerFactory : ILoggerFactory
{
	public ILogger CreateLogger(Type type)
	{
		return NullLogger.Instance;
	}
}
