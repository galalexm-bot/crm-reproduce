using System;

namespace EleWise.ELMA.Packaging.Logging;

public class OperationStatusLoggerFactory : ILoggerFactory
{
	private ILoggerFactory _baseLoggerFactory;

	private PackagingHelper _helper;

	public OperationStatusLoggerFactory(ILoggerFactory baseLoggerFactory, PackagingHelper helper)
	{
		if (baseLoggerFactory == null)
		{
			throw new ArgumentNullException("baseLoggerFactory");
		}
		_baseLoggerFactory = baseLoggerFactory;
		_helper = helper;
	}

	public ILogger CreateLogger(Type type)
	{
		return new OperationStatusLogger(_baseLoggerFactory.CreateLogger(type), _helper);
	}
}
