using System;
using System.ServiceModel;
using System.ServiceModel.Web;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Services.Public;

namespace EleWise.ELMA.Web.Service.v1;

[ServiceContract(Namespace = "http://www.elma-bpm.ru/api/")]
[WsdlDocumentation(typeof(__IMetadataServiceResources), "Description")]
[ServiceKnownType("GetMetadataKnownTypes", typeof(ServiceKnownTypeHelper))]
[XmlSerializerFormat]
[AuthorizeContractBehavior]
[FaultContractBehavior(typeof(PublicServiceException))]
public interface IMetadataService
{
	[OperationContract]
	[WebGet(UriTemplate = "/Metadata")]
	AbstractMetadata[] LoadAllMetadata();

	[OperationContract]
	[WebGet(UriTemplate = "/Metadata/{typeUid}")]
	AbstractMetadata LoadMetadata(string typeUid);

	[OperationContract]
	[WebGet(UriTemplate = "/Metadata/{typeUid}/Class")]
	ClassMetadata LoadClassMetadata(string typeUid);

	[OperationContract]
	[WebGet(UriTemplate = "/Metadata/{typeUid}/Enum")]
	EnumMetadata LoadEnumMetadata(string typeUid);

	[OperationContract]
	[WebGet(UriTemplate = "/Metadata/{typeUid}/Class/Childs")]
	ClassMetadata[] LoadAllChildClassMetadata(string typeUid);

	[OperationContract]
	[WebGet(UriTemplate = "/Metadata/{typeUid}/Enum/Childs")]
	EnumMetadata[] LoadAllChildEnumMetadata(string typeUid);

	[OperationContract]
	[WebGet(UriTemplate = "/Metadata/{typeUid}/Property/ByUid?uid={propertyUid}")]
	PropertyMetadata LoadPropertyMetadataByGuid(string typeUid, Guid propertyUid);

	[OperationContract]
	[WebGet(UriTemplate = "/Property/{typeUid}/Property/ByName?name={propertyName}")]
	PropertyMetadata LoadPropertyMetadataByName(string typeUid, string propertyName);

	[OperationContract]
	[WebGet(UriTemplate = "/Metadata/Hash")]
	string GetMetadataHash();
}
