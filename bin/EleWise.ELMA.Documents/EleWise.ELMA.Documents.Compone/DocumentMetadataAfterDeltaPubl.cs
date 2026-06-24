using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Metadata;
using EleWise.ELMA.Documents.Services;
using EleWise.ELMA.Events;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.ExtensionPoints;

namespace EleWise.ELMA.Documents.Components;

[Component(Type = ComponentType.Server)]
internal class DocumentMetadataAfterDeltaPublishEventHandler : IAfterDeltaPublishEventHandler, IEventHandler
{
	private readonly IDocumentMetadataProfileUpdaterService documentMetadataProfileUpdaterService;

	public DocumentMetadataAfterDeltaPublishEventHandler(IDocumentMetadataProfileUpdaterService documentMetadataProfileUpdaterService)
	{
		this.documentMetadataProfileUpdaterService = documentMetadataProfileUpdaterService;
	}

	public void Processing(MetadataPublishedEventArgs eventArgs)
	{
		documentMetadataProfileUpdaterService.CreateProfiles(eventArgs.DeltaPublishedMetadata.OfType<DocumentMetadata>());
	}
}
