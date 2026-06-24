using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.CAB.Commands;

[Serializable]
public class AdapterMapServiceException : Exception
{
	public AdapterMapServiceException()
	{
	}

	public AdapterMapServiceException(string message)
		: base(message)
	{
	}

	public AdapterMapServiceException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	protected AdapterMapServiceException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
