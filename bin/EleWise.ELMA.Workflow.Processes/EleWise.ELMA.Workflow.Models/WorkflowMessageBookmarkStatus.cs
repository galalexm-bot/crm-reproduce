using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Workflow.Models;

[Uid("b57bf1cd-c8d4-4e32-9f9e-1430206b8530")]
[MetadataType(typeof(EnumMetadata))]
[DefaultValueUid("f26b712e-d420-4b07-b708-bdbe2bd2fa6c")]
[DisplayName(typeof(__Resources_WorkflowMessageBookmarkStatus), "DisplayName")]
public enum WorkflowMessageBookmarkStatus
{
	[Uid("f26b712e-d420-4b07-b708-bdbe2bd2fa6c")]
	[DisplayName(typeof(__Resources_WorkflowMessageBookmarkStatus), "P_Awaiting_DisplayName")]
	Awaiting,
	[Uid("e1b50c2a-ecd9-4242-87e2-5271fed1785d")]
	[DisplayName(typeof(__Resources_WorkflowMessageBookmarkStatus), "P_Received_DisplayName")]
	Received,
	[DisplayName(typeof(__Resources_WorkflowMessageBookmarkStatus), "P_Terminated_DisplayName")]
	[Uid("e8542ea8-c2ba-4a20-a98a-cde7b98f58e7")]
	Terminated
}
