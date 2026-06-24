using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Security.Models;

[Uid("c9c37f37-f3f9-4e4d-b222-686bac63f049")]
[MetadataType(typeof(EnumMetadata))]
[DisplayName(typeof(__Resources_UserStatus), "DisplayName")]
public enum UserStatus
{
	[Uid("16ca2fed-8273-4f19-82b3-ebc4fff7e118")]
	[DisplayName(typeof(__Resources_UserStatus), "P_Active_DisplayName")]
	[Image(typeof(UserStatus), "user", 16, ImageFormatType.IconPack, false)]
	Active = 0,
	[Image(typeof(UserStatus), "user_blocked", 16, ImageFormatType.IconPack, false)]
	[Uid("50a2a1de-fc9b-4d6d-b779-bb52fcd7b480")]
	[DisplayName(typeof(__Resources_UserStatus), "P_Blocked_DisplayName")]
	Blocked = 1,
	[Uid("1c186d5f-9ab7-4251-ab86-b57a914f91c1")]
	[DisplayName(typeof(__Resources_UserStatus), "P_NotConfirmed_DisplayName")]
	[Image(typeof(UserStatus), "user_warning", 16, ImageFormatType.IconPack, false)]
	NotConfirmed = 10,
	[DisplayName(typeof(__Resources_UserStatus), "P_System_DisplayName")]
	[Image(typeof(UserStatus), "user_settings", 16, ImageFormatType.IconPack, false)]
	[Uid("6ee3218c-18de-4743-86d4-97e9bf806aba")]
	System = 100
}
