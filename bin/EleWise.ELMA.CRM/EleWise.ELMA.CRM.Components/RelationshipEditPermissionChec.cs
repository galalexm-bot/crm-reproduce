using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.CRM.Components;

public enum RelationshipEditPermissionCheckEnum
{
	[DisplayName(typeof(__Resources_RelationshipEditPermissionCheckEnum), "EditPermission")]
	EditPermission,
	[DisplayName(typeof(__Resources_RelationshipEditPermissionCheckEnum), "ViewPermission")]
	ViewPermission
}
