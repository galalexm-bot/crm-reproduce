using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Workflow.Models;

[MetadataType(typeof(EnumMetadata))]
[DisplayName(typeof(__Resources_ProcessIndicatorFactFormulaType), "DisplayName")]
[Uid("6e3d4bc1-874c-44d1-aef9-31cf05e507fa")]
public enum ProcessIndicatorFactFormulaType
{
	[Uid("a0efd937-291a-4851-b0a5-a5d32881db24")]
	[DisplayName(typeof(__Resources_ProcessIndicatorFactFormulaType), "P_Sum_DisplayName")]
	Sum,
	[Uid("c41440be-9552-4acd-96d0-76be787c0bbe")]
	[DisplayName(typeof(__Resources_ProcessIndicatorFactFormulaType), "P_Average_DisplayName")]
	Average,
	[Uid("8961af52-2e39-423e-b950-4071cd00652f")]
	[DisplayName(typeof(__Resources_ProcessIndicatorFactFormulaType), "P_Minimun_DisplayName")]
	Minimun,
	[Uid("4701a0ff-218e-483f-9dc7-9011d41832e7")]
	[DisplayName(typeof(__Resources_ProcessIndicatorFactFormulaType), "P_Maximum_DisplayName")]
	Maximum
}
