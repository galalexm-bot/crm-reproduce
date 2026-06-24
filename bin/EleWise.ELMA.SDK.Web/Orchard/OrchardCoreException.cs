using System;
using System.Runtime.Serialization;
using Orchard.Localization;

namespace Orchard;

[Serializable]
public class OrchardCoreException : Exception
{
	private readonly LocalizedString _localizedMessage;

	public LocalizedString LocalizedMessage => _localizedMessage;

	public OrchardCoreException()
	{
	}

	public OrchardCoreException(LocalizedString message)
		: base(message.Text)
	{
		_localizedMessage = message;
	}

	public OrchardCoreException(LocalizedString message, Exception innerException)
		: base(message.Text, innerException)
	{
		_localizedMessage = message;
	}

	protected OrchardCoreException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
