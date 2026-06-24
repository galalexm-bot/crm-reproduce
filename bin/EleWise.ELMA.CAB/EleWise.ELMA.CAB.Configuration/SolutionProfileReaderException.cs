using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.CAB.Configuration;

[Serializable]
public class SolutionProfileReaderException : Exception
{
	public SolutionProfileReaderException()
	{
	}

	public SolutionProfileReaderException(string message)
		: base(message)
	{
	}

	public SolutionProfileReaderException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	protected SolutionProfileReaderException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
