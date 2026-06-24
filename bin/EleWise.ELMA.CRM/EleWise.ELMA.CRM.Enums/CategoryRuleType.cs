using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.CRM.Enums;

[MetadataType(typeof(EnumMetadata))]
[Uid("e2fb6b91-1afb-4d87-a499-608624815b56")]
[DisplayName(typeof(__Resources_CategoryRuleType), "DisplayName")]
[DefaultValueUid("a8ad20b7-7971-4e77-851e-39d18ccb54a8")]
public enum CategoryRuleType
{
	[Uid("a8ad20b7-7971-4e77-851e-39d18ccb54a8")]
	[DisplayName(typeof(__Resources_CategoryRuleType), "P_RuleForLeads_DisplayName")]
	RuleForLeads,
	[Uid("6e419731-fb2d-4266-8fa1-bfeaf4d0af47")]
	[DisplayName(typeof(__Resources_CategoryRuleType), "P_RuleForContractor_DisplayName")]
	RuleForContractor
}
