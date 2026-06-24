using System;
using System.Collections.Generic;
using System.IO;
using System.ServiceModel;
using System.ServiceModel.Web;
using EleWise.ELMA.Services.Public;

namespace EleWise.ELMA.Web.Service.v1;

[ServiceContract(Namespace = "http://www.elma-bpm.ru/api/")]
[WsdlDocumentation(typeof(__IFilesServiceResources), "Description")]
[AuthorizeContractBehavior]
[FaultContractBehavior(typeof(PublicServiceException))]
public interface IFilesService
{
	[OperationContract]
	[WebGet(UriTemplate = "/FileSize?uid={uid}")]
	[AuthorizeOperationBehavior]
	[FaultContract(typeof(PublicServiceException))]
	[WsdlDocumentation(typeof(__IFilesServiceResources), "FileSizeDescription")]
	[return: WsdlParamOrReturnDocumentation(typeof(__IFilesServiceResources), "FileSizeResultDescription")]
	long FileSize([WsdlParamOrReturnDocumentation(typeof(__IFilesServiceResources), "FileSizeUidParamDescription")] Guid uid);

	[OperationContract]
	[WebGet(UriTemplate = "/Download?uid={uid}")]
	[WsdlDocumentation(typeof(__IFilesServiceResources), "DownloadDescription")]
	[return: WsdlParamOrReturnDocumentation(typeof(__IFilesServiceResources), "DownloadResultDescription")]
	Stream Download([WsdlParamOrReturnDocumentation(typeof(__IFilesServiceResources), "DownloadUidParamDescription")] Guid uid);

	[OperationContract]
	[WebInvoke(Method = "POST", UriTemplate = "/Upload")]
	[WsdlDocumentation(typeof(__IFilesServiceResources), "UploadDescription")]
	[return: WsdlParamOrReturnDocumentation(typeof(__IFilesServiceResources), "UploadResultDescription")]
	Guid Upload([WsdlParamOrReturnDocumentation(typeof(__IFilesServiceResources), "UploadBodyParamDescription")] Stream body);

	[OperationContract]
	[WebGet(UriTemplate = "/PreviewFileTypes")]
	[WsdlDocumentation(typeof(__IFilesServiceResources), "PreviewFileTypesDescription")]
	[return: WsdlParamOrReturnDocumentation(typeof(__IFilesServiceResources), "PreviewFileTypesResultDescription")]
	IEnumerable<string> PreviewFileTypes();

	[OperationContract]
	[WebGet(UriTemplate = "/DownloadPreview?uid={uid}")]
	[WsdlDocumentation(typeof(__IFilesServiceResources), "DownloadPreviewDescription")]
	[return: WsdlParamOrReturnDocumentation(typeof(__IFilesServiceResources), "DownloadPreviewResultDescription")]
	Stream DownloadPreview([WsdlParamOrReturnDocumentation(typeof(__IFilesServiceResources), "DownloadPreviewUidParamDescription")] Guid uid);
}
