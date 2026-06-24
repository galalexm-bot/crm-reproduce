using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Workflow.Models;

[DisplayName(typeof(__Resources_ProcessStatusesSelection), "DisplayName")]
[Uid("67111e40-832c-4522-a092-61d2608d2dc3")]
[MetadataType(typeof(EnumMetadata))]
public enum ProcessStatusesSelection
{
	[DisplayName(typeof(__Resources_ProcessStatusesSelection), "P_Active_DisplayName")]
	[Uid("ea3c3573-58ac-481e-a2a8-43b828c75476")]
	Active,
	[Uid("c02d2ff1-e96f-4160-9309-c1748feb3e66")]
	[DisplayName(typeof(__Resources_ProcessStatusesSelection), "P_Completed_DisplayName")]
	Completed,
	[Uid("9c9b4db8-9c22-4e6a-b9b6-8f7faed5ae8c")]
	[DisplayName(typeof(__Resources_ProcessStatusesSelection), "P_Canceled_DisplayName")]
	Canceled
}
