using System.ServiceModel;
using System.ServiceModel.Activation;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.IntegrationModules.Exceptions;
using EleWise.ELMA.IntegrationModules.Services;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Services;
using EleWise.ELMA.Services.Public;
using EleWise.ELMA.Web.Service;

namespace EleWise.ELMA.IntegrationModules.API;

[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, MaxItemsInObjectGraph = int.MaxValue)]
[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
[Component]
[Uid("EE2873EA-94A7-424C-A37B-73736B184DA5")]
internal class IntegrationPublicAPIWebService : IPublicAPIWebService, IIntegrationPublicApiWebService
{
	private const string GuidS = "EE2873EA-94A7-424C-A37B-73736B184DA5";

	private IExternalEventService externalEventService;

	public IExternalEventService ExternalEventService => externalEventService ?? (externalEventService = Locator.GetServiceNotNull<IExternalEventService>());

	public bool ExecuteExternalEvent(string eventUrl)
	{
		try
		{
			return ExternalEventService.ExecuteExternalEvent(eventUrl);
		}
		catch (ExternalEventExecuteException innerException)
		{
			throw PublicServiceException.CreateWebFault(SR.T("Ошибка при выполнении внешнего события по ключу \"{0}\"", eventUrl), innerException, 400);
		}
	}

	public bool ExecuteExternalEventPOST(string eventUrl, WebData data)
	{
		try
		{
			return ExternalEventService.ExecuteExternalEventPOST(eventUrl, data);
		}
		catch (ExternalEventExecuteException innerException)
		{
			throw PublicServiceException.CreateWebFault(SR.T("Ошибка при выполнении внешнего события по ключу \"{0}\"", eventUrl), innerException, 400);
		}
	}
}
