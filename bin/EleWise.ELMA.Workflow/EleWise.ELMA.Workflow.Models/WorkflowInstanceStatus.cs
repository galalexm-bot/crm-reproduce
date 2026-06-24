using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Workflow.Models;

[Uid("a800a08c-cc3b-4802-aabb-358e399323fd")]
[MetadataType(typeof(EnumMetadata))]
[Description(typeof(__Resources_WorkflowInstanceStatus), "Description")]
[DisplayName(typeof(__Resources_WorkflowInstanceStatus), "DisplayName")]
public enum WorkflowInstanceStatus
{
	[DisplayName(typeof(__Resources_WorkflowInstanceStatus), "P_None_DisplayName")]
	[Uid("d2344a04-24cb-4154-8dd8-0907fd0b5bf7")]
	None,
	[DisplayName(typeof(__Resources_WorkflowInstanceStatus), "P_Running_DisplayName")]
	[Uid("8807ebbd-d95d-4645-b6ec-7f113734817a")]
	Running,
	[Uid("308653a2-db50-4336-9dc3-bef65d3a457e")]
	[DisplayName(typeof(__Resources_WorkflowInstanceStatus), "P_Completed_DisplayName")]
	Completed,
	[Uid("f7a3a64f-efc4-4c9f-86f0-33a5cb7a28fa")]
	[DisplayName(typeof(__Resources_WorkflowInstanceStatus), "P_Aborted_DisplayName")]
	Aborted,
	[Uid("7c6e7109-48ab-4ede-a070-223708226472")]
	[DisplayName(typeof(__Resources_WorkflowInstanceStatus), "P_Terminated_DisplayName")]
	Terminated
}
