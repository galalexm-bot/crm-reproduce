using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Messages.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("a260a14f-9bf3-4d18-bb90-2111720236db")]
[DisplayName(typeof(__Resources_IDiscussionObject), "DisplayName")]
[DisplayFormat(null)]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>c6a41092-6a97-41e5-a1d0-a3499eb79a06</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("DiscussionObject")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[SaveHistory]
[ImplementationUid("72b3017d-0526-400d-a4bd-60beff601cb7")]
public interface IDiscussionObject : IEntity<long>, IEntity, IIdentified
{
	[Uid("9a3c61ae-9c04-4cc8-8ac8-0d34aef0d161")]
	[NotNull]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "Uid")]
	[DisplayName(typeof(__Resources_IDiscussionObject), "P_Uid_DisplayName")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	Guid Uid { get; set; }

	[Uid("464330e0-8b53-4f5f-bd13-e537765b7ee5")]
	[Order(1)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "fb88c7e4-586a-40f8-bed6-16b0eeba3a62")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "Message")]
	[DisplayName(typeof(__Resources_IDiscussionObject), "P_Message_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	IChannelMessage Message { get; set; }

	[Uid("0f742861-cda5-4dcd-b7e7-0d4ba7e3a9a3")]
	[Order(2)]
	[NotNull]
	[Property("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
	[Int64Settings(FieldName = "ObjectId")]
	[DisplayName(typeof(__Resources_IDiscussionObject), "P_ObjectId_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	long ObjectId { get; set; }

	[Uid("d3e0431c-cf1d-4802-99b8-e2efbb72b117")]
	[Order(3)]
	[NotNull]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "ObjectType")]
	[DisplayName(typeof(__Resources_IDiscussionObject), "P_ObjectType_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	Guid ObjectType { get; set; }
}
