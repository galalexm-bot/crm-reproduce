using System;

namespace EleWise.ELMA.Core.Exceptions;

public class ServiceNotFoundException : System.Exception
{
	protected static string NamedServiceNotFound => SR.T("Служба \"{0}\" не найдена");

	protected static string ServiceNotFound => SR.T("Служба не найдена");

	public ServiceNotFoundException()
		: base(ServiceNotFound)
	{
	}

	public ServiceNotFoundException(string serviceName)
		: this(serviceName, string.Format(NamedServiceNotFound, (object)serviceName))
	{
	}

	public ServiceNotFoundException(System.Type serviceType)
		: this(serviceType.get_FullName(), string.Format(NamedServiceNotFound, (object)serviceType.get_FullName()))
	{
	}

	public ServiceNotFoundException(string serviceName, string message)
		: base(message)
	{
	}
}
