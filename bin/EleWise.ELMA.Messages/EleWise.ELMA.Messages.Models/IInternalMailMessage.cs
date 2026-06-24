using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Messages.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("19b641c5-7b9e-4600-9052-18c5bccbd263")]
[DisplayName(typeof(__Resources_IInternalMailMessage), "DisplayName")]
[BaseClass("1d04a703-e4c4-45f7-8128-67cae9ee35e7")]
[DisplayFormat(null)]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>ef139020-b755-412b-8312-0ac38384d750</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("InternalMailMessage")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[Filterable]
[ImplementationUid("9803c959-1b9e-40ae-9de1-280cc25b0e00")]
[FilterType(typeof(IInternalMailMessageFilter))]
public interface IInternalMailMessage : IBaseMessage, IEntity<long>, IEntity, IIdentified, IInheritable
{
	[Uid("d000e451-dec6-49a8-8f70-371f1f12ec9c")]
	[CanBeNull]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "ObjectUid")]
	[DisplayName(typeof(__Resources_IInternalMailMessage), "P_ObjectUid_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	Guid? ObjectUid { get; set; }

	[Uid("43308f23-bf77-43b0-b7c6-427c7b8fba71")]
	[Order(1)]
	[CanBeNull]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "ActionUid")]
	[DisplayName(typeof(__Resources_IInternalMailMessage), "P_ActionUid_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	Guid? ActionUid { get; set; }

	[Uid("20632f5a-25af-4b27-b4f0-d760506a0fc3")]
	[Order(2)]
	[NotNull]
	[Property("849c1ac9-4d46-4194-8cbb-43f84adf9c17", "d0bcbd47-eb48-44bf-97fb-8ae2988c6f0d")]
	[EnumSettings(FieldName = "Priority")]
	[DisplayName(typeof(__Resources_IInternalMailMessage), "P_Priority_DisplayName")]
	[Filterable]
	[EntityProperty]
	MessagePriority Priority { get; set; }

	[Uid("012dd532-65e6-4481-bd16-a1ae5b051827")]
	[Order(3)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(FieldName = "URL")]
	[DisplayName(typeof(__Resources_IInternalMailMessage), "P_URL_DisplayName")]
	[FastSearch(true)]
	[EntityProperty]
	string URL { get; set; }

	[Uid("52d6cd79-b9ae-4ef0-9410-df6c028995db")]
	[Order(4)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(MultiLine = true, FieldName = "ShortMessage")]
	[DisplayName(typeof(__Resources_IInternalMailMessage), "P_ShortMessage_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	string ShortMessage { get; set; }

	[Uid("3edf5d54-6b49-4701-86ab-9f2ce5cb9639")]
	[Order(5)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(MultiLine = true, FieldName = "FullMessageText")]
	[DisplayName(typeof(__Resources_IInternalMailMessage), "P_FullMessageText_DisplayName")]
	[FastSearch(true)]
	[EntityProperty]
	string FullMessageText { get; set; }

	[Uid("a187f5b1-9bc1-4d3f-b60c-4d13d36ea132")]
	[Order(6)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(FieldName = "ObjectId")]
	[DisplayName(typeof(__Resources_IInternalMailMessage), "P_ObjectId_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	string ObjectId { get; set; }

	[Uid("427ac2fb-6acc-43a7-bdd0-e730722e4b7f")]
	[Order(7)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(MultiLine = true, FieldName = "ShortMessageText")]
	[DisplayName(typeof(__Resources_IInternalMailMessage), "P_ShortMessageText_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[FastSearch(true)]
	[EntityProperty]
	string ShortMessageText { get; set; }

	[Uid("62630f84-fe64-4e67-9331-429169be202f")]
	[Order(8)]
	[CanBeNull]
	[Property("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
	[Int64Settings(FieldName = "RecipientId")]
	[DisplayName(typeof(__Resources_IInternalMailMessage), "P_RecipientId_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	long? RecipientId { get; set; }

	[Uid("95c0b8d4-6ade-4d5a-86a3-ac7eff761cca")]
	[Order(9)]
	[CanBeNull]
	[Property("849c1ac9-4d46-4194-8cbb-43f84adf9c17", "580d66ad-88b5-4f84-840b-f4d765c336eb")]
	[EnumSettings(FieldName = "Status")]
	[DisplayName(typeof(__Resources_IInternalMailMessage), "P_Status_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	MessageStatus? Status { get; set; }
}
