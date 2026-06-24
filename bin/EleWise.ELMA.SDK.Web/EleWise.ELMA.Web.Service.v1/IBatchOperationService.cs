using System.ServiceModel;
using System.ServiceModel.Web;
using EleWise.ELMA.API.Models;
using EleWise.ELMA.Services.Public;

namespace EleWise.ELMA.Web.Service.v1;

[ServiceContract(Namespace = "http://www.elma-bpm.ru/api/")]
[WsdlDocumentation(typeof(__IEntityServiceResources), "Description")]
[AuthorizeContractBehavior]
[FaultContractBehavior(typeof(PublicServiceException))]
public interface IBatchOperationService
{
	[OperationContract]
	[WebInvoke(UriTemplate = "/Query")]
	[WsdlDocumentation(typeof(__IBatchOperationServiceResources), "QueryDescription")]
	[return: WsdlParamOrReturnDocumentation(typeof(__IBatchOperationServiceResources), "QueryResultDescription")]
	EntityQueryResponse[] Query([WsdlParamOrReturnDocumentation(typeof(__IBatchOperationServiceResources), "QueryRequestsParamDescription")] EntityQueryRequest[] requests);
}
