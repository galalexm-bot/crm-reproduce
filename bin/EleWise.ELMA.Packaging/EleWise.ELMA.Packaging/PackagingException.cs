using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Packaging;

[Serializable]
public class PackagingException : Exception
{
	public PackagingException(string message)
		: base(message)
	{
	}

	public PackagingException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	protected PackagingException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
