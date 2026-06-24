using System.ServiceModel;
using System.ServiceModel.Web;
using EleWise.ELMA.Services.Public;
using EleWise.ELMA.UI.Models;

namespace EleWise.ELMA.Web.Service.Internal;

[ServiceContract(Namespace = "http://www.elma-bpm.ru/api/")]
[AuthorizeContractBehavior]
[FaultContractBehavior(typeof(PublicServiceException))]
internal interface IModuleMetadataService
{
	[OperationContract]
	[WebInvoke(Method = "POST", UriTemplate = "/CheckDesignerModules")]
	CheckDesignerModuleResult[] CheckDesignerModules();
}
