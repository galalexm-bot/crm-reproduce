using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.Messages.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("fb88c7e4-586a-40f8-bed6-16b0eeba3a62")]
[DisplayName(typeof(__Resources_IChannelMessage), "DisplayName")]
[BaseClass("1d04a703-e4c4-45f7-8128-67cae9ee35e7")]
[DisplayFormat(null)]
[ShowInDesigner(false)]
[Image(typeof(IChannelMessage), "message_outline", 16, ImageFormatType.IconPack, false)]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>55401f68-b4a0-46c0-8a74-4df116fef2b6</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("ChannelMessage")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[Filterable]
[ImplementationUid("3c676fc0-23ae-47af-99b0-3c310efd1d5b")]
[FilterType(typeof(IChannelMessageFilter))]
[ActionsType(typeof(ChannelMessageActions))]
public interface IChannelMessage : IBaseMessage, IEntity<long>, IEntity, IIdentified, IInheritable
{
	[Uid("e49bfb6e-5210-4877-8dc1-e095efeeb1f9")]
	[NotNull]
	[Required(true)]
	[Property("849c1ac9-4d46-4194-8cbb-43f84adf9c17", "c6f920ce-eee5-4827-9cf1-c15df2a2b0b7")]
	[EnumSettings(FieldName = "MessageType")]
	[RequiredField]
	[DisplayName(typeof(__Resources_IChannelMessage), "P_MessageType_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	ChannelMessageType MessageType { get; set; }

	[Uid("042e04c8-f884-40b4-8209-68995e035b33")]
	[Order(1)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "fb88c7e4-586a-40f8-bed6-16b0eeba3a62")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "Parent")]
	[DisplayName(typeof(__Resources_IChannelMessage), "P_Parent_DisplayName")]
	[Filterable]
	[EntityProperty]
	IChannelMessage Parent { get; set; }

	[Uid("c72c8456-1177-417b-9660-ac48531e0e36")]
	[Order(2)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "d5252826-304f-482c-a767-2b2475adc587")]
	[EntitySettings(RelationType = RelationType.ManyToMany, RelationTableName = "M_ChannelMessage_Channels", ParentColumnName = "MessageId", ChildColumnName = "ChannelId", CascadeMode = CascadeMode.SaveUpdate)]
	[DisplayName(typeof(__Resources_IChannelMessage), "P_Channels_DisplayName")]
	[EntityProperty]
	ISet<IInformationChannel> Channels { get; set; }

	[Uid("3a163011-2bbb-4b93-bcf0-8234f1803d65")]
	[Order(3)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "fb88c7e4-586a-40f8-bed6-16b0eeba3a62")]
	[EntitySettings(RelationType = RelationType.OneToMany, KeyColumnUidStr = "042e04c8-f884-40b4-8209-68995e035b33", CascadeMode = CascadeMode.SaveUpdate)]
	[DisplayName(typeof(__Resources_IChannelMessage), "P_Messages_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	ISet<IChannelMessage> Messages { get; set; }

	[Uid("8563d566-94f5-4dda-b6ab-8c8689df4d26")]
	[Order(4)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "3536c931-154c-4618-93b8-4e35bd8db226")]
	[EntitySettings(RelationType = RelationType.ManyToMany, RelationTableName = "M_ChannelMessage_Attachments", ParentColumnName = "MessageId", ChildColumnName = "AttachmentId", CascadeMode = CascadeMode.SaveUpdate)]
	[DisplayName(typeof(__Resources_IChannelMessage), "P_Attachments_DisplayName")]
	[Sortable(false)]
	[Groupable(false)]
	[PropertyHandler("81c57a64-25c0-4a7d-84a1-d018e2727460")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	ISet<IAttachment> Attachments { get; set; }

	[Uid("a576af86-dbe1-4ffc-81b8-4c4614348684")]
	[Order(5)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "a260a14f-9bf3-4d18-bb90-2111720236db")]
	[EntitySettings(RelationType = RelationType.OneToMany, KeyColumnUidStr = "464330e0-8b53-4f5f-bd13-e537765b7ee5", CascadeMode = CascadeMode.SaveUpdate)]
	[DisplayName(typeof(__Resources_IChannelMessage), "P_DiscussionObjects_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	ISet<IDiscussionObject> DiscussionObjects { get; set; }
}
