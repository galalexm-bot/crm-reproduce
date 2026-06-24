using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.CAB.BuilderStrategies;

[Serializable]
public class BuilderStrategyException : Exception
{
	public BuilderStrategyException()
	{
	}

	public BuilderStrategyException(string message)
		: base(message)
	{
	}

	public BuilderStrategyException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	protected BuilderStrategyException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
