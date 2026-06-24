using System.ServiceModel;
using System.ServiceModel.Web;
using EleWise.ELMA.Services.Public;
using EleWise.ELMA.Web.Service.Internal.Model;

namespace EleWise.ELMA.Web.Service.Internal;

[ServiceContract(Namespace = "http://www.elma-bpm.ru/api/")]
[AuthorizeContractBehavior]
[FaultContractBehavior(typeof(PublicServiceException))]
internal interface IScriptExecutionService
{
	[OperationContract]
	[WebInvoke(Method = "POST", UriTemplate = "/ExecuteScript")]
	ScriptExecutionResponse ExecuteScript(ScriptExecutionRequest request);
}
