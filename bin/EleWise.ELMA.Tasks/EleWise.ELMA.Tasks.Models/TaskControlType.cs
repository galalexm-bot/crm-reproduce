using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Tasks.Models;

[MetadataType(typeof(EnumMetadata))]
[Uid("5b489918-cb58-437d-a876-c6b55124d08f")]
[DisplayName(typeof(__Resources_TaskControlType), "DisplayName")]
public enum TaskControlType
{
	[Uid("cc5b80a5-f2cc-4adb-99d1-64001862d775")]
	[DisplayName(typeof(__Resources_TaskControlType), "P_Notification_DisplayName")]
	Notification,
	[Uid("658fd85b-676c-4c62-9754-5affd2f37793")]
	[DisplayName(typeof(__Resources_TaskControlType), "P_Execution_DisplayName")]
	Execution,
	[Uid("d8615b2c-b5c1-4309-9b3c-0cbca5897064")]
	[DisplayName(typeof(__Resources_TaskControlType), "P_Current_DisplayName")]
	Current
}
