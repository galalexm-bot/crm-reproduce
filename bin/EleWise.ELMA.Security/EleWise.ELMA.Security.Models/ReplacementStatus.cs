using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Security.Models;

[Uid("0ae225a8-01a2-464e-ad37-35972aaf467d")]
[DefaultValueUid("aaf05103-52a6-4724-a340-76cd2de74b1f")]
[DisplayName(typeof(__Resources_ReplacementStatus), "DisplayName")]
[MetadataType(typeof(EnumMetadata))]
public enum ReplacementStatus
{
	[DisplayName(typeof(__Resources_ReplacementStatus), "P_Active_DisplayName")]
	[Uid("aaf05103-52a6-4724-a340-76cd2de74b1f")]
	Active,
	[DisplayName(typeof(__Resources_ReplacementStatus), "P_Delete_DisplayName")]
	[Uid("1631194f-8fa9-457f-9e88-dc9054381c14")]
	Delete
}
