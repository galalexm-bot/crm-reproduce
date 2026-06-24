using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Workflow.Models;

[Description(typeof(__Resources_WorkflowProcessRunAvailability), "Description")]
[Uid("88d24cd2-8e03-47b6-9f5b-6c11bf84a603")]
[DisplayName(typeof(__Resources_WorkflowProcessRunAvailability), "DisplayName")]
[MetadataType(typeof(EnumMetadata))]
public enum WorkflowProcessRunAvailability
{
	[Description(typeof(__Resources_WorkflowProcessRunAvailability), "P_Allowed_Description")]
	[DisplayName(typeof(__Resources_WorkflowProcessRunAvailability), "P_Allowed_DisplayName")]
	[Uid("52364df8-918d-4d98-8551-23cf7fa7865f")]
	Allowed,
	[Description(typeof(__Resources_WorkflowProcessRunAvailability), "P_DeniedForUsers_Description")]
	[DisplayName(typeof(__Resources_WorkflowProcessRunAvailability), "P_DeniedForUsers_DisplayName")]
	[Uid("22dc7f3c-6a14-43d6-bfa3-34e88e7c350e")]
	DeniedForUsers,
	[Uid("9788cf02-3a87-47af-8e2d-1d1e9e52f430")]
	[Description(typeof(__Resources_WorkflowProcessRunAvailability), "P_Denied_Description")]
	[DisplayName(typeof(__Resources_WorkflowProcessRunAvailability), "P_Denied_DisplayName")]
	Denied
}
