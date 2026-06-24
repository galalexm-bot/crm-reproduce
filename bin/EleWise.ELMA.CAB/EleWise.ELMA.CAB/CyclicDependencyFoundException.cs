using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.CAB;

[Serializable]
public class CyclicDependencyFoundException : Exception
{
	public CyclicDependencyFoundException()
	{
	}

	public CyclicDependencyFoundException(string message)
		: base(message)
	{
	}

	public CyclicDependencyFoundException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	protected CyclicDependencyFoundException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
