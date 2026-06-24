using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Security.Models;

[DisplayName(typeof(__Resources_WorkerDisplayType), "DisplayName")]
[MetadataType(typeof(EnumMetadata))]
[Uid("{3801A448-48D8-41D4-926F-38DC5AC6B80A}")]
[MetadataAccessLevel(MetadataAccessLevel.EleWise)]
public enum WorkerDisplayType
{
	[Uid("{A9B02885-1F64-4595-BA0E-81285AF2F416}")]
	[MetadataAccessLevel(MetadataAccessLevel.EleWise)]
	[DisplayName(typeof(__Resources_WorkerDisplayType), "P_Job_DisplayName")]
	Job,
	[Uid("{A754A5D4-B629-4794-9CB0-FB6A213D907E}")]
	[DisplayName(typeof(__Resources_WorkerDisplayType), "P_UserName_DisplayName")]
	[MetadataAccessLevel(MetadataAccessLevel.EleWise)]
	UserName,
	[MetadataAccessLevel(MetadataAccessLevel.EleWise)]
	[Uid("{8A5BEBB9-5B17-4540-867F-A0ADB2CE5E67}")]
	[DisplayName(typeof(__Resources_WorkerDisplayType), "P_Custom_DisplayName")]
	Custom
}
