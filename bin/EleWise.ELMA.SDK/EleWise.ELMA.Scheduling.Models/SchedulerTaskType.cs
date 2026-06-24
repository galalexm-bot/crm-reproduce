using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Scheduling.Models;

[Uid("d416d85e-62d4-458d-8865-65c13e0bd288")]
[DefaultValueUid("21f9b877-1ec4-4d7b-b88a-e2cb05433faf")]
[DisplayName(typeof(__Resources_SchedulerTaskType), "DisplayName")]
[MetadataType(typeof(EnumMetadata))]
public enum SchedulerTaskType
{
	[DisplayName(typeof(__Resources_SchedulerTaskType), "P_Once_DisplayName")]
	[Uid("21f9b877-1ec4-4d7b-b88a-e2cb05433faf")]
	Once,
	[DisplayName(typeof(__Resources_SchedulerTaskType), "P_Periodic_DisplayName")]
	[Uid("dc26eaf6-e879-4019-ba24-7982259f36bd")]
	Periodic
}
