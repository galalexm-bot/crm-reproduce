using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;
using EleWise.ELMA.Services.Public;
using EleWise.ELMA.UIBuilder.Web.Models;
using EleWise.ELMA.Web.Service;

namespace EleWise.ELMA.UIBuilder.Web.Service;

[ServiceContract(Namespace = "http://www.elma-bpm.ru/api/")]
[AuthorizeContractBehavior]
[FaultContractBehavior(typeof(PublicServiceException))]
internal interface IFormViewItemService
{
	[OperationContract]
	[WebGet(UriTemplate = "/GetMetadataForms?metadataUid={metadataUid}")]
	IEnumerable<FormViewItemHeader> GetMetadataForms(Guid metadataUid);
}
