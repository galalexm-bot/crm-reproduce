using System;
using EleWise.ELMA.Common.Enums;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Common.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("97fd06ae-4a0c-4f45-9aa7-845664989ccd")]
[DisplayName(typeof(__Resources_IUnitMeasureProperties), "DisplayName")]
[DisplayFormat(null)]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>ca983835-0674-4b8d-9de8-23e63f3c0105</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("UnitMeasureProperties")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[ImplementationUid("92f6e5db-a35e-473e-9760-db66d88c67c5")]
public interface IUnitMeasureProperties : IEntity<long>, IEntity, IIdentified
{
	[Uid("e9532b20-93c5-407c-845e-6f8225ec567d")]
	[NotNull]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "Uid")]
	[DisplayName(typeof(__Resources_IUnitMeasureProperties), "P_Uid_DisplayName")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	Guid Uid { get; set; }

	[Uid("5112ef49-6033-4270-a4ed-12eef3f2d956")]
	[Order(1)]
	[NotNull]
	[Property("d6b44bce-b236-424d-aa74-d80da3c8db75")]
	[Int32Settings(FieldName = "DoublePrecision")]
	[DisplayName(typeof(__Resources_IUnitMeasureProperties), "P_DoublePrecision_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	int DoublePrecision { get; set; }

	[Uid("1c4c72ff-fa1b-464c-a0eb-6ea3ee4326a6")]
	[Order(2)]
	[NotNull]
	[Property("849c1ac9-4d46-4194-8cbb-43f84adf9c17", "f971a135-a8d1-46d4-8193-b3860eac6d8e")]
	[EnumSettings(FieldName = "Position")]
	[DisplayName(typeof(__Resources_IUnitMeasureProperties), "P_Position_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	UnitMeasurePosition Position { get; set; }

	[Uid("71479b26-b21d-4bd9-94cb-7e34f7d6c151")]
	[Order(3)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(FieldName = "DoubleSeparator")]
	[DisplayName(typeof(__Resources_IUnitMeasureProperties), "P_DoubleSeparator_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	string DoubleSeparator { get; set; }

	[Uid("dac7159a-4762-49c8-b00f-8efbc7b37640")]
	[Order(4)]
	[NotNull]
	[Property("d6b44bce-b236-424d-aa74-d80da3c8db75")]
	[Int32Settings(FieldName = "GroupMemberLenght")]
	[DisplayName(typeof(__Resources_IUnitMeasureProperties), "P_GroupMemberLenght_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	int GroupMemberLenght { get; set; }

	[Uid("1db23175-d201-4805-82c9-dd6a75a7fd85")]
	[Order(5)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(FieldName = "GroupSeparator")]
	[DisplayName(typeof(__Resources_IUnitMeasureProperties), "P_GroupSeparator_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	string GroupSeparator { get; set; }

	[Uid("2376a2a7-da28-4a6f-b683-386115f45913")]
	[Order(6)]
	[NotNull]
	[Property("849c1ac9-4d46-4194-8cbb-43f84adf9c17", "58e4e46a-2219-49eb-adaf-ec85e1fd5d4b")]
	[EnumSettings(FieldName = "NegativeFormat")]
	[DisplayName(typeof(__Resources_IUnitMeasureProperties), "P_NegativeFormat_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	NegativeFormat NegativeFormat { get; set; }
}
