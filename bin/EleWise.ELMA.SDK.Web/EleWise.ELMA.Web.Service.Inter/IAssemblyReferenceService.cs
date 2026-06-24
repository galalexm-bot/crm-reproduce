using System.ServiceModel;
using System.ServiceModel.Web;
using EleWise.ELMA.Services.Public;
using EleWise.ELMA.Web.Service.Internal.Model;

namespace EleWise.ELMA.Web.Service.Internal;

[ServiceContract(Namespace = "http://www.elma-bpm.ru/api/")]
[AuthorizeContractBehavior]
[FaultContractBehavior(typeof(PublicServiceException))]
internal interface IAssemblyReferenceService
{
	[OperationContract]
	[WebInvoke(Method = "POST", UriTemplate = "/DiscoverServiceReference")]
	DiscoverServiceReferenceResponse DiscoverServiceReference(DiscoverServiceReferenceRequest request);

	[OperationContract]
	[WebInvoke(Method = "POST", UriTemplate = "/DiscoverWebReference")]
	DiscoverServiceReferenceResponse DiscoverWebReference(DiscoverServiceReferenceRequest request);
}
