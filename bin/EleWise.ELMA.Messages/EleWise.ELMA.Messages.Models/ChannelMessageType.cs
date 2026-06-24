using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Messages.Models;

[MetadataType(typeof(EnumMetadata))]
[Uid("c6f920ce-eee5-4827-9cf1-c15df2a2b0b7")]
[DisplayName(typeof(__Resources_ChannelMessageType), "DisplayName")]
public enum ChannelMessageType
{
	[Uid("f463eb11-f87d-4979-aa8a-e90f590e82fe")]
	[DisplayName(typeof(__Resources_ChannelMessageType), "P_Post_DisplayName")]
	Post,
	[Uid("69660fd6-4563-40e5-b833-81476dd31227")]
	[DisplayName(typeof(__Resources_ChannelMessageType), "P_Comment_DisplayName")]
	Comment
}
