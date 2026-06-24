using System;
using System.Threading.Tasks;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.Model.AutoMaps.DTOMapper.Internal;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.UI.Services.FindComponent;
using EleWise.ELMA.UIBuilder.Handler;

namespace EleWise.ELMA.UIBuilder.Components;

[Component]
internal sealed class ModulePublishHandler : IModulePublishingEventHandler, IEventHandler
{
	private readonly IModuleMapperService mapperService;

	private readonly IFindComponentServiceInternal findComponentService;

	private readonly ISearchMetadataServiceInternal searchMetadataService;

	public ModulePublishHandler(IModuleMapperService mapperService, IFindComponentServiceInternal findComponentService, ISearchMetadataServiceInternal searchMetadataService)
	{
		this.mapperService = mapperService;
		this.findComponentService = findComponentService;
		this.searchMetadataService = searchMetadataService;
	}

	public Task PublicationSuccess(Guid moduleMetadataItemHeaderUid)
	{
		mapperService.ModuleMappers = null;
		findComponentService.ClearCache();
		searchMetadataService.ClearCache();
		return Task.CompletedTask;
	}

	public Task PublicationError(Guid moduleMetadataItemHeaderUid, Exception exception)
	{
		return Task.CompletedTask;
	}
}
