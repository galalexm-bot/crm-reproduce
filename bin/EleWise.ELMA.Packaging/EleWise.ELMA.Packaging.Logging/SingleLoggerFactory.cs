using System;

namespace EleWise.ELMA.Packaging.Logging;

public class SingleLoggerFactory : ILoggerFactory
{
	private ILogger _logger;

	public SingleLoggerFactory(ILogger logger)
	{
		if (logger == null)
		{
			throw new ArgumentNullException("logger");
		}
		_logger = logger;
	}

	public ILogger CreateLogger(Type type)
	{
		return _logger;
	}
}
