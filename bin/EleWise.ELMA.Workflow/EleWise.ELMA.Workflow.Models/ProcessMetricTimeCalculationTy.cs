using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Workflow.Models;

[Uid("52e4bb16-2190-4600-9039-729cb98161d8")]
[MetadataType(typeof(EnumMetadata))]
[DisplayName(typeof(__Resources_ProcessMetricTimeCalculationType), "DisplayName")]
public enum ProcessMetricTimeCalculationType
{
	[DisplayName(typeof(__Resources_ProcessMetricTimeCalculationType), "P_BuisnessProcessExecutionTime_DisplayName")]
	[Uid("6f56a23a-d309-4e82-bf0f-0c9d7145d988")]
	BuisnessProcessExecutionTime,
	[DisplayName(typeof(__Resources_ProcessMetricTimeCalculationType), "P_StageExecutionTime_DisplayName")]
	[Uid("93c62f21-e680-419a-bb32-2eb82ff5b63e")]
	StageExecutionTime,
	[Uid("191524f3-82a3-4fee-ab4f-b877dcf7911e")]
	[DisplayName(typeof(__Resources_ProcessMetricTimeCalculationType), "P_TaskExecutionTime_DisplayName")]
	TaskExecutionTime
}
