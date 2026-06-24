using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Workflow.Models;

[MetadataType(typeof(EnumMetadata))]
[DisplayName(typeof(__Resources_WorkflowInstanceGeneralStatus), "DisplayName")]
[Uid("a6f70f2a-4685-4b4e-adce-d7aa16f245b2")]
public enum WorkflowInstanceGeneralStatus
{
	[DisplayName(typeof(__Resources_WorkflowInstanceGeneralStatus), "P_Current_DisplayName")]
	[Uid("3d8604bd-6fb7-40c1-b3d2-a999c94c9d59")]
	Current,
	[Uid("7214bdf4-d771-42d9-9e6b-4dc6f60aa539")]
	[DisplayName(typeof(__Resources_WorkflowInstanceGeneralStatus), "P_Completed_DisplayName")]
	Completed,
	[Uid("dbab3de0-d603-41e9-b0e3-ab58d6d913d3")]
	[DisplayName(typeof(__Resources_WorkflowInstanceGeneralStatus), "P_Terminated_DisplayName")]
	Terminated
}
