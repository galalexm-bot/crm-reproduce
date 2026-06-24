using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Services.Public;

namespace EleWise.ELMA.Web.Service.v1;

[ServiceContract(Namespace = "http://www.elma-bpm.ru/api/")]
[WsdlDocumentation(typeof(__IEntityServiceResources), "HeadDescription")]
[AuthorizeContractBehavior]
[FaultContractBehavior(typeof(PublicServiceException))]
public interface IEntityHeadService
{
	[OperationContract]
	[WebGet(UriTemplate = "/Load?type={typeuid}&id={entityid}")]
	[WsdlDocumentation(typeof(__IEntityServiceResources), "LoadHeadDescription")]
	[return: WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "LoadHeadResultDescription")]
	WebData Load([WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "typeuidDescription")] string typeuid, [WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "entityidDescription")] string entityid);

	[OperationContract]
	[WebGet(UriTemplate = "/Query?type={typeuid}&q={eqlQuery}&limit={limit}&offset={offset}&sort={sort}&filterProviderUid={filterProviderUid}&filterProviderData={filterProviderData}&filter={filter}")]
	[WsdlDocumentation(typeof(__IEntityServiceResources), "FindAllQueryHeadDescription")]
	[return: WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "FindAllQueryHeadResultDescription")]
	IEnumerable<WebData> Query([WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "typeuidDescription")] string typeuid, [WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "eqlQueryDescription")] string eqlQuery, [WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "sortDescription")] string sort, [WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "limitDescription")] int limit = 0, [WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "offsetDescription")] int offset = 0, [WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "filterProviderUidDescription")] string filterProviderUid = null, [WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "filterProviderDataDescription")] string filterProviderData = null, [WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "filterDescription")] string filter = null);

	[OperationContract]
	[WebGet(UriTemplate = "/QuerySimple?type={typeuid}&search={search}&q={eqlQuery}&limit={limit}&sort={sort}&filterProviderUid={filterProviderUid}&filterProviderData={filterProviderData}&filter={filter}")]
	[AuthorizeOperationBehavior]
	[FaultContract(typeof(PublicServiceException))]
	[WsdlDocumentation(typeof(__IEntityServiceResources), "QuerySimpleDescription")]
	[return: WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "QuerySimpleResultDescription")]
	IEnumerable<WebData> QuerySimple([WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "typeuidDescription")] string typeuid, [WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "searchStringDescription")] string search, [WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "eqlQueryDescription")] string eqlQuery, [WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "sortDescription")] string sort = null, [WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "limitDescription")] int limit = 100, [WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "filterProviderUidDescription")] string filterProviderUid = null, [WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "filterProviderDataDescription")] string filterProviderData = null, [WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "filterDescription")] string filter = null);

	[OperationContract]
	[WebGet(UriTemplate = "/Link?type={typeuid}&id={entityid}")]
	[WsdlDocumentation(typeof(__IEntityServiceResources), "EntityLinkDescription")]
	[return: WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "EntityLinkResultDescription")]
	string Link([WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "typeuidDescription")] string typeuid, [WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "entityidDescription")] string entityid);
}
