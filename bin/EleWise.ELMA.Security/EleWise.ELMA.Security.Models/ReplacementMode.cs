using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Security.Models;

[MetadataType(typeof(EnumMetadata))]
[Uid("86788123-74ac-4149-96a8-0a7aae36d829")]
[DisplayName(typeof(__Resources_ReplacementMode), "DisplayName")]
public enum ReplacementMode
{
	[Uid("a368a2da-1fe0-4d3c-9b58-0845652c790e")]
	[DisplayName(typeof(__Resources_ReplacementMode), "P_None_DisplayName")]
	None,
	[Uid("006a6f8f-01ac-44ea-9ca0-85b7eeac4245")]
	[DisplayName(typeof(__Resources_ReplacementMode), "P_ManualReplacement_DisplayName")]
	ManualReplacement,
	[DisplayName(typeof(__Resources_ReplacementMode), "P_AutoReplacement_DisplayName")]
	[Uid("444d4c03-31c6-4c48-b595-242be806777e")]
	AutoReplacement
}
