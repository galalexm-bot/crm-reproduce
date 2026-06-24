using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Messages.Enums;

[MetadataType(typeof(EnumMetadata))]
[Uid("d316ddb9-3a2e-4e00-a32f-4428b734116a")]
[DisplayName(typeof(__Resources_FeedPriority), "DisplayName")]
public enum FeedPriority
{
	[Uid("2932a0db-45b9-4c3d-8daa-9938d36d50c9")]
	[DisplayName(typeof(__Resources_FeedPriority), "P_Urgent_DisplayName")]
	Urgent = 100,
	[Uid("38c9b455-565c-46a3-8d5e-acbf661f7509")]
	[DisplayName(typeof(__Resources_FeedPriority), "P_High_DisplayName")]
	High = 10,
	[Uid("e6784d42-a026-408a-8db2-025f39bdbc07")]
	[DisplayName(typeof(__Resources_FeedPriority), "P_Normal_DisplayName")]
	Normal = 0,
	[Uid("d0f1c414-eb3f-4b81-b7f5-a3fc469d49e8")]
	[DisplayName(typeof(__Resources_FeedPriority), "P_Low_DisplayName")]
	Low = -10,
	[Uid("608e9186-57a2-4f1e-8bfa-dc5e8d4a6cf8")]
	[DisplayName(typeof(__Resources_FeedPriority), "P_Lowest_DisplayName")]
	Lowest = -100
}
