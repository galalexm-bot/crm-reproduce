using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Tasks.Models;

[MetadataType(typeof(EnumMetadata))]
[Uid("5ab21887-fc5f-4d16-8bbf-68184992c483")]
[DisplayName(typeof(__Resources_TaskPriority), "DisplayName")]
[DefaultValueUid("e9dba4e2-409d-4851-9904-5d7fef48f498")]
public enum TaskPriority
{
	[Uid("1d422c11-2f18-4ff5-bd0f-15f0ba89f885")]
	[DisplayName(typeof(__Resources_TaskPriority), "P_High_DisplayName")]
	[Image(typeof(TaskPriority), "EleWise.ELMA.Tasks.Models.TaskPriority.High.x16.Png", 16, ImageFormatType.Png, false)]
	High = 1,
	[Uid("e9dba4e2-409d-4851-9904-5d7fef48f498")]
	[DisplayName(typeof(__Resources_TaskPriority), "P_Medium_DisplayName")]
	[Image(typeof(TaskPriority), "EleWise.ELMA.Tasks.Models.TaskPriority.Medium.x16.Png", 16, ImageFormatType.Png, false)]
	Medium,
	[Uid("375d0374-dc23-410a-910c-4c4e5f8f77e0")]
	[DisplayName(typeof(__Resources_TaskPriority), "P_Low_DisplayName")]
	[Image(typeof(TaskPriority), "EleWise.ELMA.Tasks.Models.TaskPriority.Low.x16.Png", 16, ImageFormatType.Png, false)]
	Low
}
