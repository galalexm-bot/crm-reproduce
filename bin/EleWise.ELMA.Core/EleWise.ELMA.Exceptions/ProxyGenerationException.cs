using System;
using EleWise.ELMA.Core;

namespace EleWise.ELMA.Exceptions;

public sealed class ProxyGenerationException : System.Exception
{
	private static string GenerateProxyByHashException => SR.T("Ошибка генерации Proxy по TypeUid: \"{0}\"");

	private static string GenerateProxyException => SR.T("Ошибка генерации Proxy");

	public ProxyGenerationException()
		: base(GenerateProxyException)
	{
	}

	public ProxyGenerationException(string typeRef)
		: base(string.Format(GenerateProxyByHashException, (object)typeRef))
	{
	}
}
