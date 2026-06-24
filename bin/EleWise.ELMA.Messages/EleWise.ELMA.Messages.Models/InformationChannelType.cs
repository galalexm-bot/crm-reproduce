using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Messages.Models;

[MetadataType(typeof(EnumMetadata))]
[Uid("b2490e53-65ec-464d-8515-dc74e9749fbd")]
[DisplayName(typeof(__Resources_InformationChannelType), "DisplayName")]
public enum InformationChannelType
{
	[Uid("61c847b1-bbef-4c1b-a4d1-dd60fa8ddd24")]
	[DisplayName(typeof(__Resources_InformationChannelType), "P_Open_DisplayName")]
	Open,
	[Uid("da5d0c68-fda0-4802-b4bb-6620fc4d2b39")]
	[DisplayName(typeof(__Resources_InformationChannelType), "P_Close_DisplayName")]
	[Image(typeof(InformationChannelType), "admin", 16, ImageFormatType.IconPack, false)]
	Close
}
