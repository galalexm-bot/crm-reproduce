using System.ServiceModel;
using System.ServiceModel.Web;
using EleWise.ELMA.Documents.Services;
using EleWise.ELMA.Services.Public;
using EleWise.ELMA.Web.Service;

namespace EleWise.ELMA.Documents.API.Service.v1;

[ServiceContract(Namespace = "http://www.elma-bpm.ru/api/")]
[AuthorizeContractBehavior]
[FaultContractBehavior(typeof(PublicServiceException))]
public interface IScanningService
{
	[OperationContract]
	[WebInvoke(Method = "POST", UriTemplate = "/{vValue}/Status")]
	[WsdlDocumentation(typeof(__IScanningServiceResources), "SetStatusScanedFileDescription")]
	void SetStatusScanedFile(string vValue, StatusScanedFileEnum status);

	[OperationContract]
	[WebGet(UriTemplate = "/{vValue}/Status")]
	[WsdlDocumentation(typeof(__IScanningServiceResources), "GetStatusScanedFileDescription")]
	StatusScanedFileEnum GetStatusScanedFile(string vValue);

	[OperationContract]
	[WebInvoke(Method = "POST", UriTemplate = "/{vValue}/StartFile")]
	[WsdlDocumentation(typeof(__IScanningServiceResources), "ScanedFileSendStartDescription")]
	void ScanedFileSendStart(string vValue, string fileName);

	[OperationContract]
	[WebInvoke(Method = "POST", UriTemplate = "/{vValue}/EndFile")]
	[WsdlDocumentation(typeof(__IScanningServiceResources), "ScanedFileSendEndDescription")]
	void ScanedFileSendEnd(string vValue);
}
