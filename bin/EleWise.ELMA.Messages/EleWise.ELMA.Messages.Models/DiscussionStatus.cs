using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Messages.Models;

[MetadataType(typeof(EnumMetadata))]
[Uid("6f1c79a9-e7b6-4d60-b244-72b23f04f67c")]
[DisplayName(typeof(__Resources_DiscussionStatus), "DisplayName")]
public enum DiscussionStatus
{
	[Uid("3add6b38-504c-429b-ae81-891881a6eeac")]
	[DisplayName(typeof(__Resources_DiscussionStatus), "P_Open_DisplayName")]
	Open,
	[Uid("b2aac125-e684-40c5-acbe-22cbb653efc8")]
	[DisplayName(typeof(__Resources_DiscussionStatus), "P_Closed_DisplayName")]
	Closed
}
