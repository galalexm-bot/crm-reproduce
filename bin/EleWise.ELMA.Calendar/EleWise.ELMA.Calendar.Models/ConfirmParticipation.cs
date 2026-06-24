using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Calendar.Models;

[MetadataType(typeof(EnumMetadata))]
[Uid("6c05e2bc-b2b5-4e5b-b50b-18d72d81b0d8")]
[DisplayName(typeof(__Resources_ConfirmParticipation), "DisplayName")]
[DefaultValueUid("d46b6568-9fae-457a-8b77-98df08563405")]
public enum ConfirmParticipation
{
	[Uid("d46b6568-9fae-457a-8b77-98df08563405")]
	[DisplayName(typeof(__Resources_ConfirmParticipation), "P_None_DisplayName")]
	None,
	[Uid("e3e09c1a-9b9a-4f26-b806-f0d3375bb941")]
	[DisplayName(typeof(__Resources_ConfirmParticipation), "P_Confirmed_DisplayName")]
	Confirmed,
	[Uid("1d9586bd-ef6b-4124-bf13-33836ea94314")]
	[DisplayName(typeof(__Resources_ConfirmParticipation), "P_NotConfirmed_DisplayName")]
	NotConfirmed
}
