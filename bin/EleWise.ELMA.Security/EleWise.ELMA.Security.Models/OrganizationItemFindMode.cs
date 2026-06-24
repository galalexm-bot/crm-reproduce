using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Security.Models;

[Uid("da2d0b29-7b1c-4e2b-b0f0-9675da93e54d")]
[MetadataType(typeof(EnumMetadata))]
[DefaultValueUid("48ff3773-ca34-4476-97a2-3e82b874c891")]
[DisplayName(typeof(__Resources_OrganizationItemFindMode), "DisplayName")]
public enum OrganizationItemFindMode
{
	[Uid("48ff3773-ca34-4476-97a2-3e82b874c891")]
	[Description(typeof(__Resources_OrganizationItemFindMode), "P_ByTree_Description")]
	[DisplayName(typeof(__Resources_OrganizationItemFindMode), "P_ByTree_DisplayName")]
	ByTree,
	[DisplayName(typeof(__Resources_OrganizationItemFindMode), "P_ByItem_DisplayName")]
	[Description(typeof(__Resources_OrganizationItemFindMode), "P_ByItem_Description")]
	[Uid("6698dc6f-86eb-48d9-8fab-c30ba6274acc")]
	ByItem
}
