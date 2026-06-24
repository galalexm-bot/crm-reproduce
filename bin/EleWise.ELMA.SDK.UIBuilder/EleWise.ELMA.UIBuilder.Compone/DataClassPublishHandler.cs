using System;
using System.Threading.Tasks;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.AutoMaps.DTOMapper.Internal;
using EleWise.ELMA.Model.Events.Publication;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.UI.Services.FindComponent;

namespace EleWise.ELMA.UIBuilder.Components;

[Component]
internal sealed class DataClassPublishHandler : IDataClassMetadataPublishingEventHandler, IEventHandler
{
	private readonly IModuleMapperService mapperService;

	private readonly ISearchMetadataServiceInternal searchMetadataService;

	private readonly IFindComponentServiceInternal findComponentService;

	public DataClassPublishHandler(IModuleMapperService mapperService, ISearchMetadataServiceInternal searchMetadataService, IFindComponentServiceInternal findComponentService)
	{
		this.mapperService = mapperService;
		this.searchMetadataService = searchMetadataService;
		this.findComponentService = findComponentService;
	}

	public Task Complete(Guid publicationToken, UIMetadataPublishResult result)
	{
		mapperService.ModuleMappers = null;
		searchMetadataService.ClearCache();
		findComponentService.ClearCache();
		return Task.CompletedTask;
	}

	public Task Error(Guid publicationToken, Exception exception)
	{
		return Task.CompletedTask;
	}
}
