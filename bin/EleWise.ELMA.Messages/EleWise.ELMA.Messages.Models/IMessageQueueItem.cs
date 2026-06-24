using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.Messages.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("ed3483bd-d30b-4cea-90a7-f1957024ff4e")]
[DisplayName(typeof(__Resources_IMessageQueueItem), "DisplayName")]
[DisplayFormat(null)]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>9918b3a6-4f10-4a61-b696-0065150a4742</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("MessageQueueItem")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[ImplementationUid("889c8920-e1a0-4775-800f-c694177af1fb")]
public interface IMessageQueueItem : IEntity<long>, IEntity, IIdentified
{
	[Uid("54973ed2-b9c9-4384-a896-3113b2d618bb")]
	[NotNull]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "Uid")]
	[DisplayName(typeof(__Resources_IMessageQueueItem), "P_Uid_DisplayName")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	Guid Uid { get; set; }

	[Uid("87cb25e0-bd1c-4e58-8c2a-9391e950ca7f")]
	[Order(1)]
	[Property("66c7898b-e56b-49e0-bfb8-9f9c4a7a0c52")]
	[XmlSerializableObjectSettings(FieldName = "Data")]
	[DisplayName(typeof(__Resources_IMessageQueueItem), "P_Data_DisplayName")]
	[EntityProperty]
	object Data { get; set; }

	[Uid("7a5c3f65-7b94-49f2-b312-0ff43fe761b5")]
	[Order(2)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "40deec41-5afa-4394-b880-9eec3bf1d9e1")]
	[EntitySettings(RelationType = RelationType.OneToMany, KeyColumnUidStr = "c97c2bf7-2c58-4994-9de0-74e382d699e2", CascadeMode = CascadeMode.All)]
	[DisplayName(typeof(__Resources_IMessageQueueItem), "P_Channels_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	ISet<IMessageQueueChannelItem> Channels { get; set; }
}
