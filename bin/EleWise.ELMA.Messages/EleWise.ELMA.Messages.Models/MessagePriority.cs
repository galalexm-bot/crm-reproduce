using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Messages.Models;

[MetadataType(typeof(EnumMetadata))]
[Uid("d0bcbd47-eb48-44bf-97fb-8ae2988c6f0d")]
[DisplayName(typeof(__Resources_MessagePriority), "DisplayName")]
public enum MessagePriority
{
	[Uid("a7470436-2009-4d1d-b4b3-f55e4b289e36")]
	[DisplayName(typeof(__Resources_MessagePriority), "P_Low_DisplayName")]
	Low = -100,
	[Uid("fdca73c8-c5ae-4569-b4da-d79d599eefef")]
	[DisplayName(typeof(__Resources_MessagePriority), "P_Default_DisplayName")]
	Default = 0,
	[Uid("e38bb86e-4484-47a9-91dc-34560411800d")]
	[DisplayName(typeof(__Resources_MessagePriority), "P_High_DisplayName")]
	High = 100
}
