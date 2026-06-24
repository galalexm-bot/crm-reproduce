using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Tasks;

[DefaultValueUid("6C742F10-5406-4335-B9B9-BE4914EB1B11")]
[ShowInTypeTree(false)]
[ShowInDesigner(false)]
[DisplayName(typeof(__Resources_NotificationElementRecipientType), "DisplayName")]
[MetadataAccessLevel(MetadataAccessLevel.EleWise)]
[MetadataType(typeof(EnumMetadata))]
[Uid("1fbebd8c-9c9d-480c-9b27-6f5763e21c92")]
public enum NotificationElementRecipientType
{
	[Uid("6C742F10-5406-4335-B9B9-BE4914EB1B11")]
	NotSet = 0,
	[DisplayName(typeof(__Resources_NotificationElementRecipientType), "P_CurrentExecutor_DisplayName")]
	[MetadataAccessLevel(MetadataAccessLevel.EleWise)]
	[Uid("58c7dfe9-fa7a-46d0-b346-cc7f4b4092d2")]
	CurrentExecutor = 2,
	[Uid("d15c7736-529c-46ce-8b2a-981191d28de6")]
	[DisplayName(typeof(__Resources_NotificationElementRecipientType), "P_ContextVariable_DisplayName")]
	[MetadataAccessLevel(MetadataAccessLevel.EleWise)]
	ContextVariable = 1
}
