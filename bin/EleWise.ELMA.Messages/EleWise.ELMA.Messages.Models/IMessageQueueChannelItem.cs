using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Messages.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("40deec41-5afa-4394-b880-9eec3bf1d9e1")]
[DisplayName(typeof(__Resources_IMessageQueueChannelItem), "DisplayName")]
[DisplayFormat(null)]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>747714dc-35de-4153-8fd0-bad87cdf0922</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("MessageQueueChannelItem")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[ImplementationUid("14363994-2678-4d02-8acc-6ad98c1f79b2")]
[NonUnique]
public interface IMessageQueueChannelItem : IEntity<long>, IEntity, IIdentified
{
	[Uid("c97c2bf7-2c58-4994-9de0-74e382d699e2")]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "ed3483bd-d30b-4cea-90a7-f1957024ff4e")]
	[EntitySettings(FieldName = "Item")]
	[DisplayName(typeof(__Resources_IMessageQueueChannelItem), "P_Item_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	IMessageQueueItem Item { get; set; }

	[Uid("75093453-9c7e-4c7a-876b-9e589009afb4")]
	[Order(1)]
	[CanBeNull]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "ChannelUid")]
	[DisplayName(typeof(__Resources_IMessageQueueChannelItem), "P_ChannelUid_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	Guid? ChannelUid { get; set; }

	[Uid("00085077-dd50-4d54-a63d-4d931e18ddf3")]
	[Order(2)]
	[NotNull]
	[Property("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
	[Int64Settings(FieldName = "Attempt")]
	[DisplayName(typeof(__Resources_IMessageQueueChannelItem), "P_Attempt_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	long Attempt { get; set; }

	[Uid("d9bf72b4-f98d-43f8-b797-5199eac2d3eb")]
	[Order(3)]
	[CanBeNull]
	[Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
	[DateTimeSettings(SetCurrentDate = true, FieldName = "CreationDate")]
	[DisplayName(typeof(__Resources_IMessageQueueChannelItem), "P_CreationDate_DisplayName")]
	[PropertyHandler("d0c00d8a-e003-427d-9942-f52cfb77b0f0")]
	[Filterable]
	[EntityProperty]
	DateTime? CreationDate { get; set; }

	[Uid("ed82dc7b-9714-4b10-bdd2-7b2313aa5e24")]
	[Order(4)]
	[CanBeNull]
	[Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
	[DateTimeSettings(FieldName = "LastSendDate")]
	[DisplayName(typeof(__Resources_IMessageQueueChannelItem), "P_LastSendDate_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	DateTime? LastSendDate { get; set; }

	[Uid("c304ef4b-e775-4367-a5c6-00efd7b287d3")]
	[Order(5)]
	[CanBeNull]
	[Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
	[DateTimeSettings(FieldName = "NextSendDate")]
	[DisplayName(typeof(__Resources_IMessageQueueChannelItem), "P_NextSendDate_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	DateTime? NextSendDate { get; set; }
}
