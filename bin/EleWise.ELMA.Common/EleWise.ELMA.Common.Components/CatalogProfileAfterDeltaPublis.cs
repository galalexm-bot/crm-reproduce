using System.Linq;
using EleWise.ELMA.Common.Services;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.ExtensionPoints;

namespace EleWise.ELMA.Common.Components;

[Component(Type = ComponentType.Server)]
internal class CatalogProfileAfterDeltaPublishEventHandler : IAfterDeltaPublishEventHandler, IEventHandler
{
	private readonly CatalogProfileUpdaterService catalogProfileUpdaterService;

	public CatalogProfileAfterDeltaPublishEventHandler(CatalogProfileUpdaterService catalogProfileUpdaterService)
	{
		this.catalogProfileUpdaterService = catalogProfileUpdaterService;
	}

	public void Processing(MetadataPublishedEventArgs eventArgs)
	{
		catalogProfileUpdaterService.CreateProfiles(eventArgs.DeltaPublishedMetadata.OfType<ClassMetadata>());
	}
}
