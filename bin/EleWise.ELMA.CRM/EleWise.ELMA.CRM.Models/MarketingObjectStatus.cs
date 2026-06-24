using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.CRM.Models;

[MetadataType(typeof(EnumMetadata))]
[Uid("04cdb6f4-972a-451c-a4d4-2b7d04702602")]
[DisplayName(typeof(__Resources_MarketingObjectStatus), "DisplayName")]
[DefaultValueUid("a4468ca7-efe4-493f-a6f1-0fcad62731ae")]
public enum MarketingObjectStatus
{
	[Uid("a4468ca7-efe4-493f-a6f1-0fcad62731ae")]
	[DisplayName(typeof(__Resources_MarketingObjectStatus), "P_Active_DisplayName")]
	Active,
	[Uid("d98164a9-19f7-4864-97ca-8cf299b34824")]
	[DisplayName(typeof(__Resources_MarketingObjectStatus), "P_Archived_DisplayName")]
	Archived
}
