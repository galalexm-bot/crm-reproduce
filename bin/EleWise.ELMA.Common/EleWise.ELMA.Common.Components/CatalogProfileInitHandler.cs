using EleWise.ELMA.Common.Services;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Common.Components;

[Component(Type = ComponentType.Server)]
internal class CatalogProfileInitHandler : IInitHandler
{
	public void Init()
	{
	}

	public void InitComplete()
	{
		Locator.GetServiceNotNull<CatalogProfileUpdaterService>().UpdateProfiles();
	}
}
