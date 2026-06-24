using System.ServiceModel;
using System.ServiceModel.Web;
using EleWise.ELMA.Documents.API.Models;
using EleWise.ELMA.Services.Public;
using EleWise.ELMA.Web.Service;

namespace EleWise.ELMA.Documents.API.Service.v1;

[ServiceContract(Namespace = "http://www.elma-bpm.ru/api/")]
[WsdlDocumentation(typeof(__IDocumentServiceResources), "Description")]
[AuthorizeContractBehavior]
[FaultContractBehavior(typeof(PublicServiceException))]
internal interface IDocumentService
{
	[OperationContract]
	[WebInvoke(Method = "POST", UriTemplate = "/Version/{versionId}/Lock")]
	[WsdlDocumentation(typeof(__IDocumentServiceResources), "DocumentVersionLockDescription")]
	bool DocumentVersionLock(string versionId);

	[OperationContract]
	[WebInvoke(Method = "POST", UriTemplate = "/Version/{versionId}/UnLock")]
	[WsdlDocumentation(typeof(__IDocumentServiceResources), "DocumentVersionUnLockDescription")]
	bool DocumentVersionUnLock(string versionId);

	[OperationContract]
	[WebGet(UriTemplate = "/{documentId}/CurrentVersions")]
	[WsdlDocumentation(typeof(__IDocumentServiceResources), "GetCurrentVersionsDescription")]
	[return: WsdlParamOrReturnDocumentation(typeof(__IDocumentServiceResources), "GetCurrentVersionsResultDescription")]
	DocumentVersionModel[] GetCurrentVersions(string documentId);

	[OperationContract]
	[WebGet(UriTemplate = "/{documentId}/CanEditDocument")]
	[WsdlDocumentation(typeof(__IDocumentServiceResources), "CanEditDocumentDescription")]
	bool CanEditDocument(string documentId);
}
