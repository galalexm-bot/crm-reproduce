using System.ServiceModel;
using System.ServiceModel.Activation;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Models;
using EleWise.ELMA.UI.Services;

namespace EleWise.ELMA.Web.Service.Internal;

[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, MaxItemsInObjectGraph = int.MaxValue)]
[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
[ServiceKnownType("GetGlobalKnownTypes", typeof(ServiceKnownTypeHelper))]
[Component]
[Uid("{76DA5D55-C783-45D8-8245-7CE66AE0DA5F}")]
internal sealed class ModuleMetadataService : IModuleMetadataService, IInternalAPIWebService
{
	private static IWebDesignerCheckModulesService webDesignerCheckModulesService;

	public const string GuidS = "{76DA5D55-C783-45D8-8245-7CE66AE0DA5F}";

	private static IWebDesignerCheckModulesService WebDesignerCheckModulesService => webDesignerCheckModulesService ?? (webDesignerCheckModulesService = Locator.GetServiceNotNull<IWebDesignerCheckModulesService>());

	public CheckDesignerModuleResult[] CheckDesignerModules()
	{
		return WebDesignerCheckModulesService.CheckWebDesigner();
	}
}
