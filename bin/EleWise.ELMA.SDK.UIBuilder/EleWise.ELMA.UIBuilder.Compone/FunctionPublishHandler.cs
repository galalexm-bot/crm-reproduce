using System;
using System.Threading.Tasks;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Events.Publication;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.UI.Services.FindComponent;

namespace EleWise.ELMA.UIBuilder.Components;

[Component]
internal sealed class FunctionPublishHandler : IFunctionMetadataPublishingEventHandler, IEventHandler
{
	private readonly ISearchMetadataServiceInternal searchMetadataService;

	private readonly IFindComponentServiceInternal findComponentService;

	public FunctionPublishHandler(ISearchMetadataServiceInternal searchMetadataService, IFindComponentServiceInternal findComponentService)
	{
		this.searchMetadataService = searchMetadataService;
		this.findComponentService = findComponentService;
	}

	public Task Complete(Guid functionMetadataUid, UIMetadataPublishResult result)
	{
		searchMetadataService.ClearCache();
		findComponentService.ClearCache();
		return Task.CompletedTask;
	}

	public Task Error(Guid functionMetadataUid, Exception exception)
	{
		return Task.CompletedTask;
	}
}
