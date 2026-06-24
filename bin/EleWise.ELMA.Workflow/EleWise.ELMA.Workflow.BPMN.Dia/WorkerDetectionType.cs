using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Swimlanes;

[DisplayName(typeof(__Resources_WorkerDetectionType), "DisplayName")]
public enum WorkerDetectionType
{
	[MetadataAccessLevel(MetadataAccessLevel.EleWise)]
	[DisplayName(typeof(__Resources_WorkerDetectionType), "P_UseSelector_DisplayName")]
	[Uid("FAA4E2CE-B447-495F-9A1B-11D215016962")]
	UseSelector,
	[DisplayName(typeof(__Resources_WorkerDetectionType), "P_WhoFirst_DisplayName")]
	[MetadataAccessLevel(MetadataAccessLevel.EleWise)]
	[Uid("1789D5D4-62B5-4700-88AA-2CC3B08577B9")]
	WhoFirst
}
