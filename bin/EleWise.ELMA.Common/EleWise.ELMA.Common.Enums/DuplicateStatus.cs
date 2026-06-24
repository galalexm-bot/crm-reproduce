using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Common.Enums;

[MetadataType(typeof(EnumMetadata))]
[Uid("940cca99-2076-490c-b6e2-a58c3996d936")]
[DisplayName(typeof(__Resources_DuplicateStatus), "DisplayName")]
[DefaultValueUid("a65f24ab-f52e-473b-8d0a-103a26a782c6")]
public enum DuplicateStatus
{
	[Uid("a65f24ab-f52e-473b-8d0a-103a26a782c6")]
	[DisplayName(typeof(__Resources_DuplicateStatus), "P_NotProcessed_DisplayName")]
	NotProcessed,
	[Uid("621f3181-98fc-4add-8a42-f98eaa5064b3")]
	[DisplayName(typeof(__Resources_DuplicateStatus), "P_PossibleDuplicate_DisplayName")]
	PossibleDuplicate,
	[Uid("5ae94272-d194-4101-adfa-3797d39b4c42")]
	[DisplayName(typeof(__Resources_DuplicateStatus), "P_NotDuplicate_DisplayName")]
	NotDuplicate,
	[Uid("d9194894-41c2-4527-b52c-9e2f75e5bfc8")]
	[DisplayName(typeof(__Resources_DuplicateStatus), "P_Duplicate_DisplayName")]
	Duplicate
}
