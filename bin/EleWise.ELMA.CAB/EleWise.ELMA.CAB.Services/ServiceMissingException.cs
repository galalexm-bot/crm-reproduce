using System;
using System.Globalization;
using System.Runtime.Serialization;
using EleWise.ELMA.CAB.Properties;

namespace EleWise.ELMA.CAB.Services;

[Serializable]
public class ServiceMissingException : Exception
{
	public ServiceMissingException()
	{
	}

	public ServiceMissingException(string message)
		: base(message)
	{
	}

	public ServiceMissingException(string message, Exception exception)
		: base(message, exception)
	{
	}

	public ServiceMissingException(Type serviceType)
		: base(string.Format(CultureInfo.CurrentCulture, Resources.ServiceMissingExceptionSimpleMessage, new object[1] { serviceType }))
	{
	}

	public ServiceMissingException(Type serviceType, object component)
		: base(string.Format(CultureInfo.CurrentCulture, Resources.ServiceMissingExceptionMessage, new object[2] { serviceType, component }))
	{
	}

	public ServiceMissingException(Type serviceType, object component, Exception innerException)
		: base(string.Format(CultureInfo.CurrentCulture, Resources.ServiceMissingExceptionMessage, new object[2] { serviceType, component }), innerException)
	{
	}

	protected ServiceMissingException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
