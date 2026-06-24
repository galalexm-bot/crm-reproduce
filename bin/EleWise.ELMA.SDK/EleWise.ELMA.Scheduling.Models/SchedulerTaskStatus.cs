using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Scheduling.Models;

[DefaultValueUid("fdd26016-cca3-442a-b2f7-b0b091e34e94")]
[DisplayName(typeof(__Resources_SchedulerTaskStatus), "DisplayName")]
[MetadataType(typeof(EnumMetadata))]
[Uid("742e4058-85b4-4412-98d2-b80cc8f0aa3e")]
public enum SchedulerTaskStatus
{
	[Uid("fdd26016-cca3-442a-b2f7-b0b091e34e94")]
	[DisplayName(typeof(__Resources_SchedulerTaskStatus), "P_Enabled_DisplayName")]
	Enabled,
	[DisplayName(typeof(__Resources_SchedulerTaskStatus), "P_Disabled_DisplayName")]
	[Uid("ff6fb316-cc09-47e2-aa1c-ee8b36f66a94")]
	Disabled,
	[Uid("1616e67a-1d33-463e-b55b-b3b8499a65c5")]
	[DisplayName(typeof(__Resources_SchedulerTaskStatus), "P_Closed_DisplayName")]
	Closed
}
