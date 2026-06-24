using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Messages.Models;

[MetadataType(typeof(EnumMetadata))]
[Uid("580d66ad-88b5-4f84-840b-f4d765c336eb")]
[Obsolete("Статусы сообщений больше не используются и будут удалены в будущих версиях.")]
public enum MessageStatus
{
	[Uid("e4e0430e-a3a4-42da-8b24-a51c00189a1f")]
	New,
	[Uid("1406de74-f26c-41fc-ba37-35b9c5a54676")]
	Read
}
