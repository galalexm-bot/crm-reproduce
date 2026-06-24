using System;

namespace EleWise.ELMA.Exceptions;

public class ScriptExecuteException : System.Exception
{
	public ScriptExecuteException(string message)
		: base(message)
	{
	}

	public ScriptExecuteException(string message, System.Exception innerException)
		: base(message, innerException)
	{
	}
}
