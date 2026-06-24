using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.CRM.Models;

[MetadataType(typeof(EnumMetadata))]
[Uid("3bc57bb5-b5f2-493b-ad88-4ff0245ab237")]
[DisplayName(typeof(__Resources_UtmType), "DisplayName")]
public enum UtmType
{
	[Uid("6bd56dfa-12b9-4082-9a7e-bdf1621189ba")]
	[DisplayName(typeof(__Resources_UtmType), "P_Source_DisplayName")]
	Source,
	[Uid("bfe5f081-513b-42b9-92e2-421e57a987d1")]
	[DisplayName(typeof(__Resources_UtmType), "P_Medium_DisplayName")]
	Medium,
	[Uid("3e43dbad-2d1e-4fa0-b190-f74707aecf79")]
	[DisplayName(typeof(__Resources_UtmType), "P_Campaign_DisplayName")]
	Campaign,
	[Uid("8dd7f050-0d6f-48a1-972c-db38b6813ebe")]
	[DisplayName(typeof(__Resources_UtmType), "P_Content_DisplayName")]
	Content,
	[Uid("031bc23a-c5f7-4204-96d8-51a8aea07b43")]
	[DisplayName(typeof(__Resources_UtmType), "P_Term_DisplayName")]
	Term
}
