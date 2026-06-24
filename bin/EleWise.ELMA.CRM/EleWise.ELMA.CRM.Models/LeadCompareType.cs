using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.CRM.Models;

[MetadataType(typeof(EnumMetadata))]
[Uid("e0ef1353-33d0-49d7-85de-3d60f291cca7")]
[DisplayName(typeof(__Resources_LeadCompareType), "DisplayName")]
public enum LeadCompareType
{
	[Uid("fac110cd-d436-496d-892a-498d3e0485c3")]
	[DisplayName(typeof(__Resources_LeadCompareType), "P_Equal_DisplayName")]
	Equal
}
