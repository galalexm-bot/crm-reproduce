using System;
using System.ServiceModel;
using System.ServiceModel.Web;
using EleWise.ELMA.API.Models;
using EleWise.ELMA.Services.Public;

namespace EleWise.ELMA.Web.Service.v1;

[ServiceContract(Namespace = "http://www.elma-bpm.ru/api/")]
[WsdlDocumentation(typeof(__IEntityServiceResources), "ChangesDescription")]
[AuthorizeContractBehavior]
[FaultContractBehavior(typeof(PublicServiceException))]
public interface IEntityChangesService
{
	[OperationContract]
	[WebGet(UriTemplate = "/IsSupported?type={typeuid}")]
	[WsdlDocumentation(typeof(__IEntityServiceResources), "IsSupportedDescription")]
	[return: WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "IsSupportedResultDescription")]
	bool IsSupported([WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "typeuidDescription")] string typeuid);

	[OperationContract]
	[WebGet(UriTemplate = "/Changes?type={typeuid}&from={fromServerTime}&q={eqlQuery}")]
	[WsdlDocumentation(typeof(__IEntityServiceResources), "GetChangedHeadDescription")]
	[return: WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "GetChangedHeadResultDescription")]
	EntityChangesResponse Changes([WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "typeuidDescription")] string typeuid, [WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "fromServerTimeDescription")] DateTime fromServerTime, [WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "eqlQueryDescription")] string eqlQuery);

	[OperationContract]
	[WebInvoke(Method = "POST", UriTemplate = "/ChangesCommit")]
	[WsdlDocumentation(typeof(__IEntityServiceResources), "ChangesCommitDescription")]
	[return: WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "ChangesCommitResultDescription")]
	bool ChangesCommit([WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "changesCommitIdDescription")] Guid id);

	[OperationContract]
	[WebInvoke(Method = "POST", UriTemplate = "/Sync")]
	[WsdlDocumentation(typeof(__IEntityServiceResources), "SyncChangedHeadDescription")]
	[return: WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "SyncChangedHeadResultDescription")]
	bool Sync([WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "syncChangesDescription")] EntityChangesSyncRequest changes);
}
