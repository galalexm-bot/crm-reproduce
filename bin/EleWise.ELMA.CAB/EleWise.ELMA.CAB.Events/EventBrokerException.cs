using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.CAB.Events;

[Serializable]
public class EventBrokerException : Exception
{
	public EventBrokerException()
	{
	}

	public EventBrokerException(string message)
		: base(message)
	{
	}

	public EventBrokerException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	protected EventBrokerException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
