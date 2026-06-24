using System.ServiceModel;
using System.ServiceModel.Web;
using EleWise.ELMA.Services.Public;
using EleWise.ELMA.Web.Service.v1.AdministrationService.Models;

namespace EleWise.ELMA.Web.Service.v1.AdministrationService;

[ServiceContract(Namespace = "http://www.elma-bpm.ru/api/")]
[AuthorizeContractBehavior]
[FaultContractBehavior(typeof(PublicServiceException))]
internal interface IAdministrationService
{
	[OperationContract]
	[WebGet(UriTemplate = "/GetGlobalSettingsModuleInfo")]
	IGlobalSettingsModuleInfo[] GetGlobalSettingsModuleInfo();

	[OperationContract]
	[WebInvoke(Method = "POST", UriTemplate = "/GetModuleGlobalSettings")]
	IModuleGlobalSettings GetModuleGlobalSettings(ModuleSettingsParameters moduleSettingsParameters);
}
