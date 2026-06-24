using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Files;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Types.Settings;

namespace EleWise.ELMA.Documents.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("d1bfe6d8-fa26-469a-af73-13b9dab3f4af")]
[DisplayName(typeof(__Resources_IDocumentTemplate), "DisplayName")]
[DisplayFormat(null)]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>fd66b199-e61d-4fc0-8164-fc8018b14b90</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("DocumentTemplate")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[ImplementationUid("693f3eaf-a511-4669-8f34-b8619bd64478")]
public interface IDocumentTemplate : IEntity<long>, IEntity, IIdentified
{
	[Uid("acf9ae73-b636-4f12-95ec-2c1894652eee")]
	[NotNull]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "Uid")]
	[DisplayName(typeof(__Resources_IDocumentTemplate), "P_Uid_DisplayName")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	Guid Uid { get; set; }

	[Uid("2dd5b223-eef6-4301-8129-03e258ca65d5")]
	[Order(1)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "c3fe0ba3-2b4e-4de7-b60b-45a6fa196cb8")]
	[EntitySettings(FieldName = "Profile")]
	[DisplayName(typeof(__Resources_IDocumentTemplate), "P_Profile_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	IDocumentMetadataProfile Profile { get; set; }

	[Uid("1016793f-3111-4490-bfd4-68c6ba89603f")]
	[Order(2)]
	[Property("289f266b-2805-457e-bce0-b0bcd4d38143")]
	[BinaryFileSettings(FieldName = "File")]
	[DisplayName(typeof(__Resources_IDocumentTemplate), "P_File_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	BinaryFile File { get; set; }

	[Uid("7bac017f-cdbb-42c4-93f6-dfe4f8a13c14")]
	[Order(3)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "2b660715-d111-4cc6-acfd-965661719fba")]
	[EntitySettings(FieldName = "Document")]
	[DisplayName(typeof(__Resources_IDocumentTemplate), "P_Document_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	IDocument Document { get; set; }

	[Uid("811a7c33-02d9-427a-99ce-a7459612ab57")]
	[Order(4)]
	[CanBeNull]
	[Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
	[DateTimeSettings(FieldName = "CreationDate")]
	[DisplayName(typeof(__Resources_IDocumentTemplate), "P_CreationDate_DisplayName")]
	[PropertyHandler("d0c00d8a-e003-427d-9942-f52cfb77b0f0")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	DateTime? CreationDate { get; set; }

	[Uid("02e1641d-4cea-4f1e-9c7f-80ac4aa99ea5")]
	[Order(5)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
	[EntityUserSettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "CreationAuthor")]
	[DisplayName(typeof(__Resources_IDocumentTemplate), "P_CreationAuthor_DisplayName")]
	[PropertyHandler("b05ac6bd-eb8b-474a-a796-b53831a9967e")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	IUser CreationAuthor { get; set; }

	[Uid("5c80d7e0-68b1-40b0-b800-cbabad65a174")]
	[Order(6)]
	[NotNull]
	[Property("849c1ac9-4d46-4194-8cbb-43f84adf9c17", "063cf20d-b631-4b8e-b226-2e37408a137b")]
	[EnumSettings(FieldName = "TemplateType")]
	[DisplayName(typeof(__Resources_IDocumentTemplate), "P_TemplateType_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	DocumentTemplateType TemplateType { get; set; }
}
