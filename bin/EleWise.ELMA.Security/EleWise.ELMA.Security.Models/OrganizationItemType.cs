using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Security.Models;

[DisplayName(typeof(__Resources_OrganizationItemType), "DisplayName")]
[MetadataType(typeof(EnumMetadata))]
[Uid("6557e077-71cd-4f73-b23a-eed2447ef0b0")]
public enum OrganizationItemType
{
	[DisplayName(typeof(__Resources_OrganizationItemType), "P_Department_DisplayName")]
	[Uid("f4e4d32f-b8c2-43db-b385-293c60f180d9")]
	Department,
	[Uid("327b0966-8f7c-4a0d-b59e-4a60cf165271")]
	[DisplayName(typeof(__Resources_OrganizationItemType), "P_Position_DisplayName")]
	Position,
	[DisplayName(typeof(__Resources_OrganizationItemType), "P_EmployeeGroup_DisplayName")]
	[Uid("b98d9657-f0b0-4dae-b0f9-a6bfd0074e9a")]
	EmployeeGroup,
	[Description(typeof(__Resources_OrganizationItemType), "P_NestedStructure_Description")]
	[DisplayName(typeof(__Resources_OrganizationItemType), "P_NestedStructure_DisplayName")]
	[Uid("d66ebd4f-f30b-4cb9-a9ce-9c6ac231dddd")]
	NestedStructure
}
