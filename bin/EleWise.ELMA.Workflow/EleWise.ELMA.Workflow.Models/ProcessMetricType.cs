using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Workflow.Models;

[MetadataType(typeof(EnumMetadata))]
[DisplayName(typeof(__Resources_ProcessMetricType), "DisplayName")]
[Uid("4ab08848-fd6f-4554-a896-c3596baaefb4")]
public enum ProcessMetricType
{
	[Uid("747551f4-2655-4040-853a-3d79d3c964ec")]
	[DisplayName(typeof(__Resources_ProcessMetricType), "P_Metric_DisplayName")]
	Metric,
	[DisplayName(typeof(__Resources_ProcessMetricType), "P_Indicator_DisplayName")]
	[Uid("23acb0f0-8f8d-4696-ab23-27bba836f30b")]
	Indicator
}
