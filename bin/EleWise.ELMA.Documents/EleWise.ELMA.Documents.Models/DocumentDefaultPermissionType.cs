using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Documents.Models;

[MetadataType(typeof(EnumMetadata))]
[Uid("dc9bee3d-46b9-40a4-a194-d0f2ad7f60cd")]
[DisplayName(typeof(__Resources_DocumentDefaultPermissionType), "DisplayName")]
[DefaultValueUid("b126604a-2e48-4190-9741-2aefecfa5f76")]
public enum DocumentDefaultPermissionType
{
	[Uid("b126604a-2e48-4190-9741-2aefecfa5f76")]
	[DisplayName(typeof(__Resources_DocumentDefaultPermissionType), "P_FromFolder_DisplayName")]
	FromFolder,
	[Uid("6fa543ca-5b27-4b27-8bf0-34ee3069f141")]
	[DisplayName(typeof(__Resources_DocumentDefaultPermissionType), "P_FromFolderPlusCustom_DisplayName")]
	FromFolderPlusCustom,
	[Uid("b49e566e-7b9b-4ea4-a8ac-13cb243d150e")]
	[DisplayName(typeof(__Resources_DocumentDefaultPermissionType), "P_Custom_DisplayName")]
	Custom
}
