using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Documents.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("237093cf-17c8-4e9b-bb94-7b07a236fab3")]
[DisplayName(typeof(__Resources_IDocumentMetadataHead), "DisplayName")]
[DisplayFormat(null)]
[InterfaceImplementation("EleWise.ELMA.Model.Entities.ISoftDeletable")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>36329372-2d5c-4268-ab93-8d0095de67a9</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("DocumentMetadataHead")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[Filterable]
[ImplementationUid("a30f5ecc-5a9e-4407-91aa-25da43899f4a")]
[FilterType(typeof(IDocumentMetadataHeadFilter))]
public interface IDocumentMetadataHead : IEntity<long>, IEntity, IIdentified, ISoftDeletable
{
	[Uid("7a8c2833-52c9-4bf1-bdef-c46832b0ca9f")]
	[NotNull]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "Uid")]
	[DisplayName(typeof(__Resources_IDocumentMetadataHead), "P_Uid_DisplayName")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	Guid Uid { get; set; }

	[Uid("27161bfa-e544-456c-9d31-106c6385b7bc")]
	[Order(1)]
	[NotNull]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "DocumentTypeUid")]
	[DisplayName(typeof(__Resources_IDocumentMetadataHead), "P_DocumentTypeUid_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	Guid DocumentTypeUid { get; set; }

	[Uid("6ef53a08-e91a-4e2f-9cfb-8eb30076540d")]
	[Order(2)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "a22c2598-cbd1-40e1-9cea-9a7cd50890b8")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "Group")]
	[DisplayName(typeof(__Resources_IDocumentMetadataHead), "P_Group_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	IDocumentMetadataGroup Group { get; set; }

	[Uid("abe0d857-40e5-4b50-a348-0410d6c031db")]
	[Order(3)]
	[NotNull]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(FieldName = "IsDeleted")]
	[DisplayName(typeof(__Resources_IDocumentMetadataHead), "P_IsDeleted_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	new bool IsDeleted { get; set; }

	[Uid("22926bcb-3a9c-4f52-9725-d236899ba360")]
	[Order(4)]
	[NotNull]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(FieldName = "HardDelete")]
	[DisplayName(typeof(__Resources_IDocumentMetadataHead), "P_HardDelete_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	new bool HardDelete { get; set; }

	[Uid("85313f70-9d14-4ecd-8af9-8322aca28279")]
	[Order(5)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "a22c2598-cbd1-40e1-9cea-9a7cd50890b8")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "BeforeDeleteGroup")]
	[DisplayName(typeof(__Resources_IDocumentMetadataHead), "P_BeforeDeleteGroup_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	IDocumentMetadataGroup BeforeDeleteGroup { get; set; }

	[Uid("ffeebc9e-68f0-4fe7-b3b1-1222b6e7bb8b")]
	[Order(6)]
	[NotNull]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "MetadataType")]
	[DisplayName(typeof(__Resources_IDocumentMetadataHead), "P_MetadataType_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	Guid MetadataType { get; set; }
}
