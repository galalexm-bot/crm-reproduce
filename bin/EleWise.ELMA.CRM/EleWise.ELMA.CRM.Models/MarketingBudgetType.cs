using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.CRM.Models;

[MetadataType(typeof(EnumMetadata))]
[Uid("fa2b32d5-45c8-4e86-a88e-8f1357b8344c")]
[DisplayName(typeof(__Resources_MarketingBudgetType), "DisplayName")]
[DefaultValueUid("b06843f9-5862-4d4e-8119-a22392cb8070")]
public enum MarketingBudgetType
{
	[Uid("167b5b2f-fddf-457c-be2a-5b1510c01e3a")]
	[DisplayName(typeof(__Resources_MarketingBudgetType), "P_Manual_DisplayName")]
	Manual,
	[Uid("b06843f9-5862-4d4e-8119-a22392cb8070")]
	[DisplayName(typeof(__Resources_MarketingBudgetType), "P_SumOfChild_DisplayName")]
	SumOfChild
}
