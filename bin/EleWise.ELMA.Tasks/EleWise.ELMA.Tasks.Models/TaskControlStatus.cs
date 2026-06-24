using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Tasks.Models;

[MetadataType(typeof(EnumMetadata))]
[Uid("10d92b32-84c9-4278-8d2b-5e8eb7625543")]
[DisplayName(typeof(__Resources_TaskControlStatus), "DisplayName")]
[ShowInDesigner(false)]
[DefaultValueUid("40fdf331-4b37-4691-8ca5-ad1d1ea272cf")]
public enum TaskControlStatus
{
	[Uid("40fdf331-4b37-4691-8ca5-ad1d1ea272cf")]
	[DisplayName(typeof(__Resources_TaskControlStatus), "P_ExecutionAll_DisplayName")]
	ExecutionAll,
	[Uid("e09e4c25-e650-43f7-84dd-f2c1e534b112")]
	[DisplayName(typeof(__Resources_TaskControlStatus), "P_ExecutionActive_DisplayName")]
	ExecutionActive,
	[Uid("d7add8dc-73de-48a1-af4b-65d68f38c24f")]
	[DisplayName(typeof(__Resources_TaskControlStatus), "P_Current_DisplayName")]
	Current
}
