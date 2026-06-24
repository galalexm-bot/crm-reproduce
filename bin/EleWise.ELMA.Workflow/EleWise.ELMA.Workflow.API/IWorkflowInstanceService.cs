using System.ServiceModel;
using System.ServiceModel.Web;
using EleWise.ELMA.Services.Public;
using EleWise.ELMA.Web.Service;

namespace EleWise.ELMA.Workflow.API;

[WsdlDocumentation(typeof(__IWorkflowInstanceService), "ServiceDescription")]
[AuthorizeContractBehavior]
[FaultContractBehavior(typeof(PublicServiceException))]
[ServiceContract(Namespace = "http://www.elma-bpm.ru/api/")]
public interface IWorkflowInstanceService
{
	[OperationContract]
	[WebGet(UriTemplate = "/Map?id={processId}")]
	[WsdlDocumentation(typeof(__IWorkflowInstanceService), "GetMapLinkDescription")]
	[return: WsdlParamOrReturnDocumentation(typeof(__IWorkflowInstanceService), "GetMapLinkResultDescription")]
	string GetMapLink([WsdlParamOrReturnDocumentation(typeof(__IWorkflowInstanceService), "GetMapLinkParamDescription")] long processId);
}
