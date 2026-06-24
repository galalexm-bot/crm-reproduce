using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Scheduling;

[MetadataType(typeof(EnumMetadata))]
[DisplayName(typeof(__Resources_JobStatus), "DisplayName")]
[Uid("cfaea77f-1cdc-40fa-954b-d43da508b05a")]
public enum JobStatus
{
	[Uid("d23bae26-8639-4e3f-b18f-bfaa733d467b")]
	[DisplayName(typeof(__Resources_JobStatus), "P_Pending_DisplayName")]
	Pending,
	[DisplayName(typeof(__Resources_JobStatus), "P_Working_DisplayName")]
	[Uid("c5c99a17-f4fe-46d5-87f0-ae565c5e0656")]
	Working,
	[Uid("298be857-2414-414e-9c8b-66491d359ea8")]
	[DisplayName(typeof(__Resources_JobStatus), "P_Success_DisplayName")]
	Success,
	[Uid("41ce53c2-8838-422b-a277-f89c60421e43")]
	[DisplayName(typeof(__Resources_JobStatus), "P_Errors_DisplayName")]
	Errors,
	[DisplayName(typeof(__Resources_JobStatus), "P_Fail_DisplayName")]
	[Uid("f570723b-048b-4c92-b1d2-f24ec50a8fcf")]
	Fail
}
