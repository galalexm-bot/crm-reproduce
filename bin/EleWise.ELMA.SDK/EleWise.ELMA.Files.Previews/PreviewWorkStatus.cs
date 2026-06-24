using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Files.Previews;

[MetadataType(typeof(EnumMetadata))]
[DisplayName(typeof(__Resources_PreviewWorkStatus), "DisplayName")]
[Uid("09b07ae0-7c5a-4124-bbd7-df6e15766a15")]
public enum PreviewWorkStatus
{
	[DisplayName(typeof(__Resources_PreviewWorkStatus), "P_InProgress_DisplayName")]
	[Uid("9ff5eb89-e5fa-467d-8234-904333008476")]
	InProgress,
	[DisplayName(typeof(__Resources_PreviewWorkStatus), "P_Completed_DisplayName")]
	[Uid("7a541cf8-69ad-493f-a8ac-f7d1859a62b6")]
	Completed,
	[Uid("1d021981-c999-41e6-8682-a0322b9a649b")]
	[DisplayName(typeof(__Resources_PreviewWorkStatus), "P_Fail_DisplayName")]
	Fail,
	[DisplayName(typeof(__Resources_PreviewWorkStatus), "P_None_DisplayName")]
	[Uid("42d731bc-aa60-45bb-bde3-34fa96948ba2")]
	None
}
