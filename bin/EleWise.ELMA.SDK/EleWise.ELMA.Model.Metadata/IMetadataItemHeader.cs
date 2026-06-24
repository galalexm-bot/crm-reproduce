using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Model.Metadata;

[DisplayName(typeof(__Resources_IMetadataItemHeader), "DisplayName")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>58640c84-8d9b-4eba-b737-80a0ea3b231c</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("MetadataItemHeader")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[DisplayFormat(null)]
[Uid("8ead9b92-c173-45cf-97bc-91cce45df1ea")]
[MetadataType(typeof(EntityMetadata))]
[Description(typeof(__Resources_IMetadataItemHeader), "Description")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[ImplementationUid("0b955dd3-40b1-424a-a864-6f365427a3fd")]
[ShowInDesigner(false)]
[TitleProperty("3376e00b-17e6-4fd4-a60b-b97182d96d85")]
[ShowInTypeTree(false)]
public interface IMetadataItemHeader : IEntity<long>, IEntity, IIdentified
{
	[Uid("bb6b631f-c4bf-432e-a4b1-96621b4a8ef5")]
	[GuidSettings(FieldName = "Uid")]
	[DisplayName(typeof(__Resources_IMetadataItemHeader), "P_Uid_DisplayName")]
	[EntityProperty]
	[SystemProperty]
	[NotNull]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	Guid Uid { get; set; }

	[FastSearch(true)]
	[Order(1)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[EntityProperty]
	[Filterable]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[Uid("3376e00b-17e6-4fd4-a60b-b97182d96d85")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[StringSettings(MaxValueString = "512", FieldName = "Name")]
	[DisplayName(typeof(__Resources_IMetadataItemHeader), "P_Name_DisplayName")]
	[StringRangeLength(0, "512")]
	string Name { get; set; }

	[DisplayName(typeof(__Resources_IMetadataItemHeader), "P_CreationDate_DisplayName")]
	[NotNull]
	[RequiredField]
	[Order(4)]
	[Uid("a74b039e-46f5-4360-b400-ad4678e7dfa0")]
	[Required(true)]
	[DateTimeSettings(SetCurrentDate = true, FieldName = "CreationDate")]
	[EntityProperty]
	[Filterable]
	[Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
	[PropertyHandler("d0c00d8a-e003-427d-9942-f52cfb77b0f0")]
	DateTime CreationDate { get; set; }

	[Uid("e2b59de9-ec44-4c31-8258-8a5b746a4577")]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "f351b2f8-586c-4ad2-a9d4-8996caab21fd")]
	[EntitySettings(FieldName = "Current")]
	[Order(6)]
	[EntityProperty]
	[DisplayName(typeof(__Resources_IMetadataItemHeader), "P_Current_DisplayName")]
	IMetadataItem Current { get; set; }

	[Order(7)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "f351b2f8-586c-4ad2-a9d4-8996caab21fd")]
	[EntityProperty]
	[DisplayName(typeof(__Resources_IMetadataItemHeader), "P_Published_DisplayName")]
	[EntitySettings(FieldName = "Published")]
	[Uid("a9dfcbb0-c962-43f8-a008-9c9e40e851eb")]
	IMetadataItem Published { get; set; }

	[Required(true)]
	[DisplayName(typeof(__Resources_IMetadataItemHeader), "P_IsDirtyItem_DisplayName")]
	[Order(8)]
	[NotNull]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[EntityProperty]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[Uid("ed3a6e73-515b-46e2-89f8-0111655e59a2")]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[BoolSettings(DefaultValueStr = "True", FieldName = "IsDirtyItem")]
	[RequiredField]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	bool IsDirtyItem { get; set; }

	[DisplayName(typeof(__Resources_IMetadataItemHeader), "P_CreationAuthorId_DisplayName")]
	[EntityProperty]
	[Int64Settings(FieldName = "CreationAuthorId")]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[CanBeNull]
	[Order(5)]
	[Property("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
	[Uid("d715ead6-8b7c-4a51-8900-7358770d4889")]
	long? CreationAuthorId { get; set; }

	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName(typeof(__Resources_IMetadataItemHeader), "P_DisplayName_DisplayName")]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[StringSettings(FieldName = "DisplayName")]
	[Order(2)]
	[Uid("6e71acaf-7e49-401a-bd7c-2be51d47dd70")]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	string DisplayName { get; set; }

	[EntitySettings(FieldName = "Group")]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "70825a99-37a6-4ac5-85ec-3eef06262f55")]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[DisplayName(typeof(__Resources_IMetadataItemHeader), "P_Group_DisplayName")]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Uid("e6ab6990-f15f-4893-967f-a20d663df0b4")]
	[Order(3)]
	[EntityProperty]
	IMetadataItemGroup Group { get; set; }

	[Uid("d19c10b8-4dda-4f6a-89d3-79815c219b8a")]
	[StringRangeLength(0, "512")]
	[DisplayName(typeof(__Resources_IMetadataItemHeader), "P_Tag_DisplayName")]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Order(9)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[EntityProperty]
	[StringSettings(MaxValueString = "512", FieldName = "Tag")]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	string Tag { get; set; }

	[GuidSettings(FieldName = "ModuleUid")]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[NotNull]
	[Uid("c55a17ab-44d1-4823-8bb6-ccd3c60f3438")]
	[Order(10)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	[DisplayName(typeof(__Resources_IMetadataItemHeader), "P_ModuleUid_DisplayName")]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	Guid ModuleUid { get; set; }
}
