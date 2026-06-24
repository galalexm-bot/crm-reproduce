using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.FullTextSearch.Model;

[MetadataType(typeof(EnumMetadata))]
[Description(typeof(__Resources_IndexQueueType), "Description")]
[DisplayName(typeof(__Resources_IndexQueueType), "DisplayName")]
[Uid("0169be84-5ba8-45d1-a112-2db1a1ffdc56")]
public enum IndexQueueType
{
	[Uid("1174a2ee-617f-4dad-a511-a84042640d90")]
	[DisplayName(typeof(__Resources_IndexQueueType), "P_IndexAll_DisplayName")]
	IndexAll,
	[Uid("74c8654a-cd2b-4541-bda2-bbe897698f02")]
	[DisplayName(typeof(__Resources_IndexQueueType), "P_IndexByType_DisplayName")]
	IndexByType,
	[DisplayName(typeof(__Resources_IndexQueueType), "P_IndexObject_DisplayName")]
	[Uid("13418dd4-126b-40b6-9894-44558dc4b9e2")]
	IndexObject,
	[Uid("48401d11-e0a5-47e6-a82a-b87ecce86ddd")]
	[DisplayName(typeof(__Resources_IndexQueueType), "P_ReIndexObject_DisplayName")]
	ReIndexObject,
	[Uid("fc68bdd3-f3ac-4d78-8c44-3ff07785d242")]
	[DisplayName(typeof(__Resources_IndexQueueType), "P_ReIndexObjectPart_DisplayName")]
	ReIndexObjectPart
}
