using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services.Public;

namespace EleWise.ELMA.Web.Service.v1;

[ServiceContract(Namespace = "http://www.elma-bpm.ru/api/")]
[WsdlDocumentation(typeof(__IEntityServiceResources), "Description")]
[AuthorizeContractBehavior]
[FaultContractBehavior(typeof(PublicServiceException))]
public interface IEntityService
{
	[OperationContract]
	[WebGet(UriTemplate = "/Load?type={typeuid}&id={entityid}")]
	[WsdlDocumentation(typeof(__IEntityServiceResources), "LoadDescription")]
	[return: WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "LoadResultDescription")]
	WebData Load([WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "typeuidDescription")] string typeuid, [WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "entityidDescription")] string entityid);

	[OperationContract]
	[WebGet(UriTemplate = "/LoadTree?type={typeuid}&id={entityid}&select={select}")]
	[WsdlDocumentation(typeof(__IEntityServiceResources), "LoadDescription")]
	[return: WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "LoadResultDescription")]
	WebData LoadTree([WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "typeuidDescription")] string typeuid, [WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "entityidDescription")] string entityid, [WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "selectDescription")] string select);

	[OperationContract]
	[WebInvoke(Method = "POST", UriTemplate = "/LoadTree?type={typeuid}&id={entityid}&select={select}")]
	[WsdlDocumentation(typeof(__IEntityServiceResources), "LoadDescription")]
	[return: WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "LoadResultDescription")]
	WebData LoadTreeWithDependencies([WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "typeuidDescription")] string typeuid, [WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "entityidDescription")] string entityid, [WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "selectDescription")] string select, [WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "entityTypeSerializationSettings")] EntityTypeSerializationSettings[] entityTypeSerializationSettings);

	[OperationContract]
	[WebGet(UriTemplate = "/Count?type={typeuid}&q={eqlQuery}&filterProviderUid={filterProviderUid}&filterProviderData={filterProviderData}&filter={filter}")]
	[WsdlDocumentation(typeof(__IEntityServiceResources), "CountDescription")]
	[return: WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "CountResultDescription")]
	long Count([WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "typeuidDescription")] string typeuid, [WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "eqlQueryDescription")] string eqlQuery, [WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "filterProviderUidDescription")] string filterProviderUid = null, [WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "filterProviderDataDescription")] string filterProviderData = null, [WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "filterDescription")] string filter = null);

	[OperationContract]
	[WebGet(UriTemplate = "/Query?type={typeuid}&q={eqlQuery}&limit={limit}&offset={offset}&sort={sort}&filterProviderUid={filterProviderUid}&filterProviderData={filterProviderData}&filter={filter}&loadDisplayName={loadDisplayName}")]
	[WsdlDocumentation(typeof(__IEntityServiceResources), "FindAllQueryDescription")]
	[return: WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "FindAllQueryResultDescription")]
	IEnumerable<WebData> Query([WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "typeuidDescription")] string typeuid, [WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "eqlQueryDescription")] string eqlQuery, [WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "sortDescription")] string sort, [WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "limitDescription")] int limit = 0, [WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "offsetDescription")] int offset = 0, [WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "filterProviderUidDescription")] string filterProviderUid = null, [WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "filterProviderDataDescription")] string filterProviderData = null, [WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "filterDescription")] string filter = null, [WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "loadDisplayNameDescription")] bool loadDisplayName = false);

	[OperationContract]
	[WebGet(UriTemplate = "/QueryTree?type={typeuid}&q={eqlQuery}&select={select}&limit={limit}&offset={offset}&sort={sort}&filterProviderUid={filterProviderUid}&filterProviderData={filterProviderData}&filter={filter}")]
	[WsdlDocumentation(typeof(__IEntityServiceResources), "FindAllQueryDescription")]
	[return: WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "FindAllQueryResultDescription")]
	IEnumerable<WebData> QueryTree([WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "typeuidDescription")] string typeuid, [WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "eqlQueryDescription")] string eqlQuery, [WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "selectDescription")] string select, [WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "sortDescription")] string sort, [WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "limitDescription")] int limit = 0, [WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "offsetDescription")] int offset = 0, [WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "filterProviderUidDescription")] string filterProviderUid = null, [WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "filterProviderDataDescription")] string filterProviderData = null, [WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "filterDescription")] string filter = null);

	[OperationContract]
	[WebInvoke(Method = "POST", UriTemplate = "/QueryTree?type={typeuid}&q={eqlQuery}&select={select}&limit={limit}&offset={offset}&sort={sort}&filterProviderUid={filterProviderUid}&filterProviderData={filterProviderData}&filter={filter}")]
	[WsdlDocumentation(typeof(__IEntityServiceResources), "FindAllQueryDescription")]
	[return: WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "FindAllQueryResultDescription")]
	IEnumerable<WebData> QueryTreeWithDependencies([WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "typeuidDescription")] string typeuid, [WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "eqlQueryDescription")] string eqlQuery, [WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "selectDescription")] string select, [WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "entityTypeSerializationSettings")] EntityTypeSerializationSettings[] entityTypeSerializationSettings, [WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "sortDescription")] string sort, [WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "limitDescription")] int limit = 0, [WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "offsetDescription")] int offset = 0, [WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "filterProviderUidDescription")] string filterProviderUid = null, [WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "filterProviderDataDescription")] string filterProviderData = null, [WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "filterDescription")] string filter = null);

	[OperationContract]
	[WebGet(UriTemplate = "/UserDefinedList?userdefinedlist={userdefinedlistuid}&modelsubtype={modelsubtypeuid}")]
	[WsdlDocumentation(typeof(__IEntityServiceResources), "FindAllQueryDescription")]
	[return: WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "FindAllQueryResultDescription")]
	IEnumerable<WebData> UserDefinedListQuery([WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "userdefinedlistuidDescription")] Guid userdefinedlistuid, [WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "modelsubtypeuidDescription")] Guid modelsubtypeuid);

	[OperationContract]
	[WebInvoke(Method = "POST", UriTemplate = "/Insert/{typeuid}")]
	[WsdlDocumentation(typeof(__IEntityServiceResources), "EntitySaveDescription")]
	[return: WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "EntitySaveResultDescription")]
	string Insert([WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "typeuidDescription")] string typeuid, [WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "entityDataDescription")] WebData entityData);

	[OperationContract]
	[WebInvoke(Method = "POST", UriTemplate = "/Update/{typeuid}/{entityid}")]
	[WsdlDocumentation(typeof(__IEntityServiceResources), "EntityUpdateDescription")]
	[return: WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "EntityUpdateResultDescription")]
	string Update([WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "typeuidDescription")] string typeuid, [WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "entityidDescription")] string entityid, [WsdlParamOrReturnDocumentation(typeof(__IEntityServiceResources), "entityDataDescription")] WebData entityData);

	[OperationContract]
	[WebInvoke(Method = "GET", UriTemplate = "/{typeUid}/IsBaseOrChild/{baseTypeUid}")]
	[WsdlDocumentation("SR.M('Проверка принадлежности Uid-а типа сущности к заданному типу сущности или наследнику от неё')")]
	[return: WsdlParamOrReturnDocumentation("SR.M('Да / нет')")]
	bool IsBaseOrChildEntityType([WsdlParamOrReturnDocumentation("SR.M('Uid проверяемого типа сущности')")] string typeUid, [WsdlParamOrReturnDocumentation("SR.M('Uid типа сущности, на принадлежность к которому происходит проверка')")] string baseTypeUid);
}
