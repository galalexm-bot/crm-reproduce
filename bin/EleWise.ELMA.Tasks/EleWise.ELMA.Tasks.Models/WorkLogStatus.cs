using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Tasks.Models;

[MetadataType(typeof(EnumMetadata))]
[Uid("cc641cef-d2ef-428c-8fd1-2bded558b6bb")]
[DisplayName(typeof(__Resources_WorkLogStatus), "DisplayName")]
public enum WorkLogStatus
{
	[Uid("8a332d5a-0e61-4705-926f-c561acef062a")]
	[DisplayName(typeof(__Resources_WorkLogStatus), "P_New_DisplayName")]
	[Image(typeof(WorkLogStatus), "help", 16, ImageFormatType.IconPack, false)]
	New,
	[Uid("1765402a-7be7-4da9-af27-f4803e169dc2")]
	[DisplayName(typeof(__Resources_WorkLogStatus), "P_Accepted_DisplayName")]
	[Image(typeof(WorkLogStatus), "complete", 16, ImageFormatType.IconPack, false)]
	Accepted,
	[Uid("51fea405-c9be-46bb-afa3-81b87f3c1454")]
	[DisplayName(typeof(__Resources_WorkLogStatus), "P_Rejected_DisplayName")]
	[Image(typeof(WorkLogStatus), "error", 16, ImageFormatType.IconPack, false)]
	Rejected
}
