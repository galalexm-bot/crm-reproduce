using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.CAB.Services;

[Serializable]
public class ModuleEnumeratorException : Exception
{
	public ModuleEnumeratorException()
	{
	}

	public ModuleEnumeratorException(string message)
		: base(message)
	{
	}

	public ModuleEnumeratorException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	protected ModuleEnumeratorException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
