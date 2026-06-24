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
using Iesi.Collections.Generic;

namespace EleWise.ELMA.Documents.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("a22c2598-cbd1-40e1-9cea-9a7cd50890b8")]
[DisplayName(typeof(__Resources_IDocumentMetadataGroup), "DisplayName")]
[AllowCreateHeirs(true)]
[DisplayFormat(null)]
[InterfaceImplementation("EleWise.ELMA.Model.Entities.ISoftDeletable")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>4fde8e06-0bb0-474e-bda4-b3a8ecfebe58</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("DocumentMetadataGroup")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[Filterable]
[ImplementationUid("59daae27-1140-4e99-8a71-67af5882fd73")]
[FilterType(typeof(IDocumentMetadataGroupFilter))]
public interface IDocumentMetadataGroup : IEntity<long>, IEntity, IIdentified, ISoftDeletable, IInheritable
{
	[Uid("934a5892-7480-4df8-a360-69991afb03e7")]
	[NotNull]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "Uid")]
	[DisplayName(typeof(__Resources_IDocumentMetadataGroup), "P_Uid_DisplayName")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	Guid Uid { get; set; }

	[Uid("cb415ff2-1c5d-41a4-94e1-3be1f1128320")]
	[Order(1)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(MaxValueString = "2000", FieldName = "Name")]
	[StringRangeLength(0, "2000")]
	[DisplayName(typeof(__Resources_IDocumentMetadataGroup), "P_Name_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	string Name { get; set; }

	[Uid("60227fa6-53f1-4a28-bb23-af1d720f9979")]
	[Order(2)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "a22c2598-cbd1-40e1-9cea-9a7cd50890b8")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "ParentGroup")]
	[DisplayName(typeof(__Resources_IDocumentMetadataGroup), "P_ParentGroup_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	IDocumentMetadataGroup ParentGroup { get; set; }

	[Uid("accbadbc-cc30-42a2-82d4-15b434dcab8f")]
	[Order(3)]
	[CanBeNull]
	[Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
	[DateTimeSettings(FieldName = "CreationDate")]
	[DisplayName(typeof(__Resources_IDocumentMetadataGroup), "P_CreationDate_DisplayName")]
	[PropertyHandler("d0c00d8a-e003-427d-9942-f52cfb77b0f0")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	DateTime? CreationDate { get; set; }

	[Uid("5d8c69b7-055e-4045-8f61-5cb5ad83d2b7")]
	[Order(4)]
	[CanBeNull]
	[Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
	[DateTimeSettings(FieldName = "ChangeDate")]
	[DisplayName(typeof(__Resources_IDocumentMetadataGroup), "P_ChangeDate_DisplayName")]
	[PropertyHandler("12a6c5c4-12f8-4b2e-b7ea-5438974a2d25")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	DateTime? ChangeDate { get; set; }

	[Uid("b3609ea4-cd58-4018-9dc1-79afe8db795a")]
	[Order(6)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
	[EntityUserSettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "ChangeAuthor")]
	[DisplayName(typeof(__Resources_IDocumentMetadataGroup), "P_ChangeAuthor_DisplayName")]
	[TableCellAlignment(LineAlignment.Right)]
	[PropertyHandler("d152e660-1ee9-4b5f-a614-df280e5b3f98")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	IUser ChangeAuthor { get; set; }

	[Uid("00406cb7-91d5-4f0e-9b10-f794876fb9ec")]
	[Order(5)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
	[EntityUserSettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "CreationAuthor")]
	[DisplayName(typeof(__Resources_IDocumentMetadataGroup), "P_CreationAuthor_DisplayName")]
	[PropertyHandler("b05ac6bd-eb8b-474a-a796-b53831a9967e")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	IUser CreationAuthor { get; set; }

	[Uid("14ee8d5e-9229-4ec0-ae6f-af485fff39df")]
	[Order(7)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "237093cf-17c8-4e9b-bb94-7b07a236fab3")]
	[EntitySettings(RelationType = RelationType.OneToMany, KeyColumnUidStr = "6ef53a08-e91a-4e2f-9cfb-8eb30076540d", CascadeMode = CascadeMode.SaveUpdate)]
	[DisplayName(typeof(__Resources_IDocumentMetadataGroup), "P_DocumentTypes_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	ISet<IDocumentMetadataHead> DocumentTypes { get; set; }

	[Uid("912d4de7-7edd-4be9-9036-fb586f83e738")]
	[Order(8)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "a22c2598-cbd1-40e1-9cea-9a7cd50890b8")]
	[EntitySettings(RelationType = RelationType.OneToMany, KeyColumnUidStr = "60227fa6-53f1-4a28-bb23-af1d720f9979", CascadeMode = CascadeMode.SaveUpdate)]
	[DisplayName(typeof(__Resources_IDocumentMetadataGroup), "P_Groups_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	ISet<IDocumentMetadataGroup> Groups { get; set; }

	[Uid("6634ed07-860e-4755-9d74-26514c76b05a")]
	[Order(9)]
	[NotNull]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(FieldName = "IsDeleted")]
	[DisplayName(typeof(__Resources_IDocumentMetadataGroup), "P_IsDeleted_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	new bool IsDeleted { get; set; }

	[Uid("119f3647-9846-4536-9725-785404a6a3bd")]
	[Order(10)]
	[NotNull]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(FieldName = "HardDelete")]
	[DisplayName(typeof(__Resources_IDocumentMetadataGroup), "P_HardDelete_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	new bool HardDelete { get; set; }

	[Uid("348b5405-69d6-4d2e-a38a-40d18a42527f")]
	[Order(11)]
	[NotNull]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "MetadataType")]
	[DisplayName(typeof(__Resources_IDocumentMetadataGroup), "P_MetadataType_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	Guid MetadataType { get; set; }

	[Uid("6dc63a2e-f6ee-42ec-8440-10994be2a1bc")]
	[Order(12)]
	[NotNull]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "GroupType")]
	[DisplayName(typeof(__Resources_IDocumentMetadataGroup), "P_GroupType_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	Guid GroupType { get; set; }
}
