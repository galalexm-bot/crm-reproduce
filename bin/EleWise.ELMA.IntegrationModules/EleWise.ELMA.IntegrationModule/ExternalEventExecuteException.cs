using System;

namespace EleWise.ELMA.IntegrationModules.Exceptions;

internal class ExternalEventExecuteException : Exception
{
	public ExternalEventExecuteException()
	{
	}

	public ExternalEventExecuteException(string message)
		: base(message)
	{
	}

	public ExternalEventExecuteException(string message, Exception innerException)
		: base(message, innerException)
	{
	}
}
