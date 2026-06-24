using System;
using EleWise.ELMA.ActorModel.Publication;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.UIBuilder.Components;

[Component]
internal class ObjectPublicationHandler : IPublicationEventHandler, IEventHandler
{
	private readonly ISearchFormServiceInternal searchFormService;

	public ObjectPublicationHandler(ISearchFormServiceInternal searchFormService)
	{
		this.searchFormService = searchFormService;
	}

	public void Complete(Guid publicationToken)
	{
		searchFormService.ClearCache();
	}

	public void Error(Guid publicationToken, Exception exception)
	{
	}
}
