using System;
using EleWise.ELMA.IntegrationModules.Models;

namespace EleWise.ELMA.IntegrationModules.Exceptions;

public class AuthenticationException : Exception
{
	public AuthenticationException()
	{
	}

	public AuthenticationException(string message)
		: base(message)
	{
	}

	public AuthenticationException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	public AuthenticationException(IIntegrationModule module, Exception innerException)
		: base(SR.T("Ошибка аутентификации модуля интеграции \"{0}\"", module.Name), innerException)
	{
	}
}
