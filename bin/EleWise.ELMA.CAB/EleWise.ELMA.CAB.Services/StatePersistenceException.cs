using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.CAB.Services;

[Serializable]
public class StatePersistenceException : Exception
{
	public StatePersistenceException()
	{
	}

	public StatePersistenceException(string message)
		: base(message)
	{
	}

	public StatePersistenceException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	protected StatePersistenceException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
