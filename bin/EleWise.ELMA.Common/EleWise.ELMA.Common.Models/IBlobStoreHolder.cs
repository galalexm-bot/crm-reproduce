using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Common.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("512da0a8-3e14-4113-ad0d-54befe96d09f")]
[DisplayName(typeof(__Resources_IBlobStoreHolder), "DisplayName")]
[Description(typeof(__Resources_IBlobStoreHolder), "Description")]
[DisplayFormat(null)]
[ShowInDesigner(false)]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>97b46a9f-3f88-4f9f-8924-72562f80916e</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("BlobStoreHolder")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[ImplementationUid("bd1f40e0-840b-4455-8b65-b99711ebde75")]
public interface IBlobStoreHolder : IEntity<long>, IEntity, IIdentified
{
	[Uid("0d6f8202-b4a9-4b0e-a603-dc6b1a1e6726")]
	[NotNull]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "Uid")]
	[DisplayName(typeof(__Resources_IBlobStoreHolder), "P_Uid_DisplayName")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	Guid Uid { get; set; }

	[Uid("bb95a7b3-e11b-466b-8515-03502203268c")]
	[Order(1)]
	[Required(true)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(MaxValueString = "400", FieldName = "Key")]
	[RequiredField]
	[StringRangeLength(0, "400")]
	[DisplayName(typeof(__Resources_IBlobStoreHolder), "P_Key_DisplayName")]
	[Description(typeof(__Resources_IBlobStoreHolder), "P_Key_Description")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	string Key { get; set; }

	[Uid("f3914a60-3168-4806-9c87-232606781fb8")]
	[Order(2)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(MaxValueString = "1024", FieldName = "SmallData")]
	[StringRangeLength(0, "1024")]
	[DisplayName(typeof(__Resources_IBlobStoreHolder), "P_SmallData_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	string SmallData { get; set; }

	[Uid("448e1fd6-41b5-45d7-8c04-5e3fbbead33a")]
	[Order(3)]
	[Property("1911b22d-0ce2-4743-832f-6a44cb0357fe")]
	[BlobSettings(FieldName = "BigData")]
	[DisplayName(typeof(__Resources_IBlobStoreHolder), "P_BigData_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	byte[] BigData { get; set; }
}
