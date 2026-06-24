using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Workflow.Models;

[Uid("8c8f9b62-bf88-43a1-8e36-f77c98b04d53")]
[MetadataType(typeof(EnumMetadata))]
[DisplayName(typeof(__Resources_ProcessMetricDataType), "DisplayName")]
public enum ProcessMetricDataType
{
	[Uid("b7ae9f7c-28b1-4284-a5b7-741050c7dd4b")]
	[DisplayName(typeof(__Resources_ProcessMetricDataType), "P_Integer_DisplayName")]
	Integer,
	[Uid("c0451cf0-c710-4a41-8be0-6e48827f084c")]
	[DisplayName(typeof(__Resources_ProcessMetricDataType), "P_Float_DisplayName")]
	Float,
	[View(Visibility.Hidden)]
	[DisplayName(typeof(__Resources_ProcessMetricDataType), "P_DateTime_DisplayName")]
	[Uid("c6c033f1-af77-44b7-8afd-bd8c44f14f86")]
	DateTime,
	[Uid("cee40b91-3a53-4ac4-a820-71f108912e63")]
	[DisplayName(typeof(__Resources_ProcessMetricDataType), "P_TimeSpan_DisplayName")]
	TimeSpan
}
