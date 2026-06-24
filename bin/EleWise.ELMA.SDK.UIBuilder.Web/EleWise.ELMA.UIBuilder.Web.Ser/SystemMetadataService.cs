using System;
using System.ServiceModel;
using System.ServiceModel.Activation;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Services;
using EleWise.ELMA.UIBuilder.MetadataEdit.DTO;
using EleWise.ELMA.UIBuilder.MetadataEdit.Services.Abstraction;
using EleWise.ELMA.Web.Service;

namespace EleWise.ELMA.UIBuilder.Web.Service;

[Component]
[Uid("BE1BADF0-0D09-4B74-B731-B5E466C18DF9")]
[ServiceKnownType("GetGlobalKnownTypes", typeof(ServiceKnownTypeHelper))]
[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, MaxItemsInObjectGraph = int.MaxValue)]
internal sealed class SystemMetadataService : ISystemMetadataService, IInternalAPIWebService
{
	public const string UidS = "BE1BADF0-0D09-4B74-B731-B5E466C18DF9";

	public static Guid Uid = new Guid("BE1BADF0-0D09-4B74-B731-B5E466C18DF9");

	private static IModuleMetadataService ModuleMetadataService => Locator.GetServiceNotNull<IModuleMetadataService>();

	public SystemInitData GetSystemInitData(InitDataModel initDataModel)
	{
		return ModuleMetadataService.GetSystemInitData(initDataModel).Result;
	}
}
