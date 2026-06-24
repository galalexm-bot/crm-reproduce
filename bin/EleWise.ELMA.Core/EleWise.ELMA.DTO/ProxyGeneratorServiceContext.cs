using System;

namespace EleWise.ELMA.DTO;

internal sealed class ProxyGeneratorServiceContext : System.IDisposable
{
	private static bool inited;

	private static IProxyGeneratorService currentService;

	private readonly IProxyGeneratorService previousService;

	public static IProxyGeneratorService ProxyGenerator => currentService;

	public ProxyGeneratorServiceContext(IProxyGeneratorService service)
	{
		previousService = currentService;
		currentService = service;
	}

	public void Dispose()
	{
		currentService = previousService;
	}

	internal static void Init(IProxyGeneratorService rootService)
	{
		if (!inited)
		{
			currentService = rootService;
			inited = true;
		}
	}
}
