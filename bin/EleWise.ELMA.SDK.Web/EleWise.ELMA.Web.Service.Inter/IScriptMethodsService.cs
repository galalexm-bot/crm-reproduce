using System.ServiceModel;
using System.ServiceModel.Web;
using EleWise.ELMA.Services.Public;
using EleWise.ELMA.Web.Service.Internal.Model;

namespace EleWise.ELMA.Web.Service.Internal;

[ServiceContract(Namespace = "http://www.elma-bpm.ru/api/")]
[AuthorizeContractBehavior]
[FaultContractBehavior(typeof(PublicServiceException))]
internal interface IScriptMethodsService
{
	[OperationContract]
	[WebInvoke(Method = "POST", UriTemplate = "/GenerateMethodCode")]
	GenerateMethodCodeResponse GenerateMethodCode(GenerateMethodCodeRequest request);

	[OperationContract]
	[WebInvoke(Method = "POST", UriTemplate = "/ParseMethods")]
	ScriptMethodDeclaration[] ParseMethods(ParseMethodsRequest request);

	[OperationContract]
	[WebInvoke(Method = "POST", UriTemplate = "/AddInterface")]
	AddInterfaceResponse AddInterface(AddInterfaceRequest request);

	[OperationContract]
	[WebInvoke(Method = "POST", UriTemplate = "/InterfaceExists")]
	bool InterfaceExists(InterfaceExistsRequest request);
}
