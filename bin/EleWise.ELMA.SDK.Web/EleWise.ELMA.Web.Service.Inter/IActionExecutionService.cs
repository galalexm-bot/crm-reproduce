using System.ServiceModel;
using System.ServiceModel.Web;
using EleWise.ELMA.Services.Public;
using EleWise.ELMA.Web.Service.Internal.Model;

namespace EleWise.ELMA.Web.Service.Internal;

[AuthorizeContractBehavior]
[FaultContractBehavior(typeof(PublicServiceException))]
[ServiceContract(Namespace = "http://www.elma-bpm.ru/api/")]
internal interface IActionExecutionService
{
	[OperationContract]
	[WebInvoke(Method = "POST", UriTemplate = "/Execute")]
	ActionExecutionResponse Execute(ActionExecutionRequest request);
}
