using System;
using System.Linq.Expressions;
using System.Net;
using System.ServiceModel;
using System.ServiceModel.Activation;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Services;
using EleWise.ELMA.Services.Public;
using EleWise.ELMA.UI.Models;
using EleWise.ELMA.UI.Services.FindComponent;

namespace EleWise.ELMA.Web.Service.Internal;

[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, MaxItemsInObjectGraph = int.MaxValue)]
[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
[ServiceKnownType("GetGlobalKnownTypes", typeof(ServiceKnownTypeHelper))]
[Component]
[Uid("{A0537CF5-88F4-4E08-82EB-022169E38B69}")]
internal sealed class ComponentMetadataService : IComponentMetadataService, IInternalAPIWebService
{
	public const string GuidS = "{A0537CF5-88F4-4E08-82EB-022169E38B69}";

	public static Guid Guid = new Guid("{A0537CF5-88F4-4E08-82EB-022169E38B69}");

	private static IFindComponentService FindComponentService => Locator.GetServiceNotNull<IFindComponentService>();

	private static Exception WebFaultException(Expression<Action<ComponentMetadataService>> method, string message, HttpStatusCode statusCode)
	{
		Logger.Log.Error(SR.T("В сервисе \"{0}\" в методе \"{1}\" произошла ошибка: {2}", typeof(ComponentMetadataService), method, message));
		return PublicServiceException.CreateWebFault(message, (int)statusCode);
	}

	public RecursiveComponentModel FindComponent(Guid headerUid, InterfaceBuilderViewMode viewMode)
	{
		try
		{
			return FindComponentService.FindComponent(headerUid, new FindComponentOptions
			{
				ViewMode = viewMode
			});
		}
		catch (Exception ex)
		{
			Logger.Log.Error(ex, SR.T("Ошибка при построении модели компонента с зависимостями"));
			throw WebFaultException((ComponentMetadataService s) => s.FindComponent(headerUid, viewMode), ex.ToString(), HttpStatusCode.InternalServerError);
		}
	}
}
