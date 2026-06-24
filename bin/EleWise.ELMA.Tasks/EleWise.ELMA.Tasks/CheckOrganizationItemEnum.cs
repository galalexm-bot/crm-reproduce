using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Tasks;

public enum CheckOrganizationItemEnum
{
	[DisplayName(typeof(__Resources_CheckOrganizationItemEnum), "P_No_DisplayName")]
	No,
	[DisplayName(typeof(__Resources_CheckOrganizationItemEnum), "P_Confirm_DisplayName")]
	Confirm,
	[DisplayName(typeof(__Resources_CheckOrganizationItemEnum), "P_Deny_DisplayName")]
	Deny
}
