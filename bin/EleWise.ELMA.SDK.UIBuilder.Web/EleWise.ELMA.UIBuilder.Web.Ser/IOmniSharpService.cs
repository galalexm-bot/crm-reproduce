using System.ServiceModel;
using System.ServiceModel.Web;
using System.Threading.Tasks;
using EleWise.ELMA.Scripts.Models;
using EleWise.ELMA.Services.Public;
using EleWise.ELMA.Web.Service;

namespace EleWise.ELMA.UIBuilder.Web.Service;

[FaultContractBehavior(typeof(PublicServiceException))]
[ServiceContract(Namespace = "http://www.elma-bpm.ru/api/")]
[WsdlDocumentation(typeof(__IOmniSharpServiceResources), "Description")]
internal interface IOmniSharpService
{
	[OperationContract]
	[WebGet(UriTemplate = "/Start?needRestart={needRestart}")]
	[WsdlDocumentation(typeof(__IOmniSharpServiceResources), "StartDescription")]
	void Start([WsdlParamOrReturnDocumentation(typeof(__IOmniSharpServiceResources), "NeedRestartDescription")] bool needRestart);

	[OperationContract]
	[WebInvoke(Method = "POST", UriTemplate = "/GetResult")]
	[WsdlDocumentation(typeof(__IOmniSharpServiceResources), "GetResultDescription")]
	[return: WsdlParamOrReturnDocumentation(typeof(__IOmniSharpServiceResources), "GetResultResultDescription")]
	Task<string> GetResult([WsdlParamOrReturnDocumentation(typeof(__IOmniSharpServiceResources), "RequestDescription")] OmniSharpRequest request);

	[OperationContract]
	[WebInvoke(Method = "POST", UriTemplate = "/AddReferences")]
	[WsdlDocumentation(typeof(__IOmniSharpServiceResources), "AddReferencesDescription")]
	void AddReferences([WsdlParamOrReturnDocumentation(typeof(__IOmniSharpServiceResources), "RequestDescription")] AddReferencesRequest request);

	[OperationContract]
	[WebInvoke(Method = "POST", UriTemplate = "/RemoveReferences")]
	[WsdlDocumentation(typeof(__IOmniSharpServiceResources), "RemoveReferencesDescription")]
	void RemoveReferences([WsdlParamOrReturnDocumentation(typeof(__IOmniSharpServiceResources), "RequestDescription")] RemoveReferencesRequest request);
}
