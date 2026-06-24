using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Types.Settings;

namespace EleWise.ELMA.Content.Models.Media;

[MetadataType(typeof(EntityMetadata))]
[Uid("18ac4fd5-5a0f-466d-9df7-7d7d0e952bfc")]
[DisplayName(typeof(__Resources_IMediaFile), "DisplayName")]
[DisplayFormat(null)]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>bf349eec-dd52-422c-b924-9a1fc22da61a</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("MediaFile")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[ImplementationUid("b2f0b569-9c75-4d79-b3e1-03e7b6732939")]
public interface IMediaFile : IEntity<long>, IEntity, IIdentified
{
	[Uid("9eb90554-c400-4d89-aab3-c1f458d7c59f")]
	[NotNull]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "Uid")]
	[DisplayName(typeof(__Resources_IMediaFile), "P_Uid_DisplayName")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	Guid Uid { get; set; }

	[Uid("1e64e6a9-e95d-4537-8559-5981ac99b8ed")]
	[Order(5)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(MaxValueString = "2000", FieldName = "Name")]
	[StringRangeLength(0, "2000")]
	[DisplayName(typeof(__Resources_IMediaFile), "P_Name_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	string Name { get; set; }

	[Uid("93b442d9-5d99-422b-a633-dc3e3a8de149")]
	[Order(6)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(FieldName = "ContentType")]
	[DisplayName(typeof(__Resources_IMediaFile), "P_ContentType_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	string ContentType { get; set; }

	[Uid("3f168550-3037-44a6-9a81-2b94f2630588")]
	[Order(7)]
	[NotNull]
	[Required(true)]
	[Property("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
	[Int64Settings(DefaultValueStr = "0", FieldName = "Size")]
	[RequiredField]
	[DisplayName(typeof(__Resources_IMediaFile), "P_Size_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	long Size { get; set; }

	[Uid("7fd92070-ed34-404b-898e-1c1bf70d1291")]
	[Order(1)]
	[CanBeNull]
	[Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
	[DateTimeSettings(SetCurrentDate = true, FieldName = "CreationDate")]
	[DisplayName(typeof(__Resources_IMediaFile), "P_CreationDate_DisplayName")]
	[PropertyHandler("d0c00d8a-e003-427d-9942-f52cfb77b0f0")]
	[Filterable]
	[EntityProperty]
	DateTime? CreationDate { get; set; }

	[Uid("21adbc4f-f5b9-4cf4-a388-6e34c233b1ed")]
	[Order(2)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
	[EntityUserSettings(FieldName = "CreationAuthor")]
	[DisplayName(typeof(__Resources_IMediaFile), "P_CreationAuthor_DisplayName")]
	[PropertyHandler("b05ac6bd-eb8b-474a-a796-b53831a9967e")]
	[Filterable]
	[EntityProperty]
	IUser CreationAuthor { get; set; }

	[Uid("2e10fba1-a849-44ff-8ace-c843f34046c3")]
	[Order(3)]
	[CanBeNull]
	[Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
	[DateTimeSettings(FieldName = "ChangeDate")]
	[DisplayName(typeof(__Resources_IMediaFile), "P_ChangeDate_DisplayName")]
	[PropertyHandler("12a6c5c4-12f8-4b2e-b7ea-5438974a2d25")]
	[Filterable]
	[EntityProperty]
	DateTime? ChangeDate { get; set; }

	[Uid("9b35806c-eb9d-4e9b-8fb9-f021d38d271a")]
	[Order(4)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
	[EntityUserSettings(FieldName = "ChangeAuthor")]
	[DisplayName(typeof(__Resources_IMediaFile), "P_ChangeAuthor_DisplayName")]
	[PropertyHandler("d152e660-1ee9-4b5f-a614-df280e5b3f98")]
	[Filterable]
	[EntityProperty]
	IUser ChangeAuthor { get; set; }

	[Uid("a9b9d32a-a23b-44d6-997e-d7886938181a")]
	[Order(8)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "976abff1-041c-40b4-ad3d-ff1e32e4f970")]
	[EntitySettings(FieldName = "Parent")]
	[DisplayName(typeof(__Resources_IMediaFile), "P_Parent_DisplayName")]
	[Description(typeof(__Resources_IMediaFile), "P_Parent_Description")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	IMediaFolder Parent { get; set; }

	[Uid("3b44f809-ac64-4f05-87fd-d1a00b9de82e")]
	[Order(9)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(MaxValueString = "2000", FieldName = "StoreId")]
	[StringRangeLength(0, "2000")]
	[DisplayName(typeof(__Resources_IMediaFile), "P_StoreId_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	string StoreId { get; set; }
}
