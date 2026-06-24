using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Tasks.Models;

[MetadataType(typeof(EnumMetadata))]
[Uid("2a9d14fe-1bcb-499f-bfd9-4a4767315adc")]
[DisplayName(typeof(__Resources_WorkLogItemStatus), "DisplayName")]
public enum WorkLogItemStatus
{
	[Uid("f24ca947-a5be-4ffb-ae0d-f439b393af13")]
	[DisplayName(typeof(__Resources_WorkLogItemStatus), "P_Draft_DisplayName")]
	[View(Visibility.Hidden)]
	Draft = 3,
	[Uid("9f9089ad-fa1c-4ed5-a483-b760e385569c")]
	[DisplayName(typeof(__Resources_WorkLogItemStatus), "P_New_DisplayName")]
	[Image(typeof(WorkLogItemStatus), "help", 16, ImageFormatType.IconPack, false)]
	New = 0,
	[Uid("cf238483-878b-405d-8766-6e4ecbcebe6e")]
	[DisplayName(typeof(__Resources_WorkLogItemStatus), "P_Confirm_DisplayName")]
	[Image(typeof(WorkLogItemStatus), "complete", 16, ImageFormatType.IconPack, false)]
	Confirm = 1,
	[Uid("8c1e573b-89f4-43a3-9923-0bd89981930e")]
	[DisplayName(typeof(__Resources_WorkLogItemStatus), "P_Unconfirm_DisplayName")]
	[Image(typeof(WorkLogItemStatus), "error", 16, ImageFormatType.IconPack, false)]
	Unconfirm = 2
}
