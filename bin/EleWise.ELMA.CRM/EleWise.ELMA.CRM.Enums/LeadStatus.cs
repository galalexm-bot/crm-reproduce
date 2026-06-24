using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.CRM.Enums;

[MetadataType(typeof(EnumMetadata))]
[Uid("2f11614b-fbb9-4326-ab15-431de50713d6")]
[DisplayName(typeof(__Resources_LeadStatus), "DisplayName")]
public enum LeadStatus
{
	[Uid("e1b00663-b9a5-4d29-a64c-23215bac735e")]
	[DisplayName(typeof(__Resources_LeadStatus), "P_New_DisplayName")]
	New,
	[Uid("403e740d-2ce8-4079-935c-c0dc8da82f93")]
	[DisplayName(typeof(__Resources_LeadStatus), "P_InHand_DisplayName")]
	InHand,
	[Uid("fb4b5a3e-3e75-4e62-9f6d-082b239a44eb")]
	[DisplayName(typeof(__Resources_LeadStatus), "P_Qualified_DisplayName")]
	Qualified,
	[Uid("3268726c-92b5-470e-ad79-de60b7fbd361")]
	[DisplayName(typeof(__Resources_LeadStatus), "P_Unqualified_DisplayName")]
	Unqualified,
	[Uid("2f12c683-463c-4ec9-9a07-36daa1502d32")]
	[DisplayName(typeof(__Resources_LeadStatus), "P_Dublicate_DisplayName")]
	[View(Visibility.Hidden)]
	Dublicate,
	[Uid("c91f8c62-ac9d-47e8-8216-abc59172809e")]
	[DisplayName(typeof(__Resources_LeadStatus), "P_ConversationNotStart_DisplayName")]
	ConversationNotStart
}
