using System;
using System.Threading.Tasks;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.UI.Events;
using EleWise.ELMA.UI.Services.FindComponent;

namespace EleWise.ELMA.UIBuilder.Components;

[Component]
internal sealed class ComponentPublishingHandler : IComponentMetadataPublishingEventHandler, IEventHandler
{
	private readonly ISearchMetadataServiceInternal searchMetadataService;

	private readonly IFindComponentServiceInternal findComponentService;

	public ComponentPublishingHandler(ISearchMetadataServiceInternal searchMetadataService, IFindComponentServiceInternal findComponentService)
	{
		this.searchMetadataService = searchMetadataService;
		this.findComponentService = findComponentService;
	}

	public Task PublicationSuccess(Guid componentMetadataUid, UIMetadataPublishResult result)
	{
		searchMetadataService.ClearCache();
		findComponentService.ClearCache();
		return Task.CompletedTask;
	}

	public Task PublicationError(Guid componentMetadataUid, Exception exception)
	{
		return Task.CompletedTask;
	}
}
