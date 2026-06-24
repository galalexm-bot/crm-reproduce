using System;

namespace EleWise.ELMA.DTO;

internal sealed class ExtendEntityServiceContext : System.IDisposable
{
	private static bool inited;

	private static IExtendEntityService currentService;

	private readonly IExtendEntityService previousService;

	public static IExtendEntityService ExtendEntityService => currentService;

	public ExtendEntityServiceContext(IExtendEntityService service)
	{
		previousService = currentService;
		currentService = service;
	}

	public void Dispose()
	{
		currentService = previousService;
	}

	internal static void Init(IExtendEntityService rootService)
	{
		if (!inited)
		{
			currentService = rootService;
			inited = true;
		}
	}
}
