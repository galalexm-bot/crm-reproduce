using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Types.Settings;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.Workflow.Models;

[Filterable]
[EntityMetadataType(EntityMetadataType.Interface)]
[ShowInCatalogList(false)]
[ActionsType(typeof(WorkflowInstanceMigrationPackageActions))]
[FilterType(typeof(IWorkflowInstanceMigrationPackageFilter))]
[ImplementationUid("6a1dc795-c209-40d0-8272-e9f660fdcb49")]
[TitleProperty("f1774883-1d26-4438-81ec-f62cbf578257")]
[Image(typeof(IWorkflowInstanceMigrationPackage), "document_migration", 16, ImageFormatType.IconPack, false)]
[DisplayFormat(null)]
[Uid("d8a0f095-08e5-47bb-ad4d-20f521f1c2d4")]
[DisplayName(typeof(__Resources_IWorkflowInstanceMigrationPackage), "DisplayName")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[Entity("WfInstanceMigrationPackage")]
[MetadataType(typeof(EntityMetadata))]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>8d206d3b-9278-40d3-855a-948ea7280850</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
public interface IWorkflowInstanceMigrationPackage : IEntity<long>, IEntity, IIdentified
{
	[Uid("03ef2c44-9fb1-4061-ab35-773c552beacc")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	[GuidSettings(FieldName = "Uid")]
	[NotNull]
	[DisplayName(typeof(__Resources_IWorkflowInstanceMigrationPackage), "P_Uid_DisplayName")]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	Guid Uid { get; set; }

	[EntityProperty]
	[DisplayName(typeof(__Resources_IWorkflowInstanceMigrationPackage), "P_Name_DisplayName")]
	[RequiredField]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[FastSearch(true)]
	[Filterable]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Uid("f1774883-1d26-4438-81ec-f62cbf578257")]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[StringSettings(FieldName = "Name")]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[Required(true)]
	[Order(1)]
	string Name { get; set; }

	[DisplayName(typeof(__Resources_IWorkflowInstanceMigrationPackage), "P_CreationDate_DisplayName")]
	[Uid("fdfd8360-92d0-439f-b1e8-d4b0deb91877")]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[Order(2)]
	[EntityProperty]
	[Filterable]
	[NotNull]
	[Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[DateTimeSettings(SetCurrentDate = true, FieldName = "CreationDate")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[PropertyHandler("d0c00d8a-e003-427d-9942-f52cfb77b0f0")]
	DateTime CreationDate { get; set; }

	[EntityProperty]
	[Uid("70fded23-0ee1-4b1f-b0d2-d099b0ff7e29")]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[Filterable]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
	[Order(3)]
	[EntityUserSettings(FieldName = "CreationAuthor")]
	[PropertyHandler("b05ac6bd-eb8b-474a-a796-b53831a9967e")]
	[DisplayName(typeof(__Resources_IWorkflowInstanceMigrationPackage), "P_CreationAuthor_DisplayName")]
	IUser CreationAuthor { get; set; }

	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntitySettings(RelationType = RelationType.OneToMany, KeyColumnUidStr = "76b9ce10-7a81-49e0-9796-5cc30cf52e27", CascadeMode = CascadeMode.SaveUpdate)]
	[DisplayName(typeof(__Resources_IWorkflowInstanceMigrationPackage), "P_Items_DisplayName")]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "6af995bc-e654-42d3-b166-754ddec1b419")]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[Uid("4d2a1838-6963-4975-8836-c149c5097bbf")]
	[Order(4)]
	ISet<IWorkflowInstanceMigrationItem> Items { get; set; }

	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Filterable]
	[CanBeNull]
	[Property("849c1ac9-4d46-4194-8cbb-43f84adf9c17", "532fe071-967a-4e43-8bcf-2d8b2471b130")]
	[Uid("4c99e422-b1f0-4b9e-9306-9e3080204e04")]
	[Order(5)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[DisplayName(typeof(__Resources_IWorkflowInstanceMigrationPackage), "P_Status_DisplayName")]
	[EnumSettings(FieldName = "Status")]
	WorkflowInstanceMigrationPackageStatus? Status { get; set; }

	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "WorkflowProcess")]
	[DisplayName(typeof(__Resources_IWorkflowInstanceMigrationPackage), "P_WorkflowProcess_DisplayName")]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "05ee2952-d4f3-4ac7-b9f9-6d4d8abc0079")]
	[Uid("15765a6a-cc0b-41f6-b5a5-bc49fbd9c85d")]
	[Order(6)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	IWorkflowProcess WorkflowProcess { get; set; }

	[EntityProperty]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[Order(7)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Uid("0047944f-3036-494b-94a0-b84147533963")]
	[DisplayName(typeof(__Resources_IWorkflowInstanceMigrationPackage), "P_MigrationReason_DisplayName")]
	[StringSettings(MultiLine = true, FieldName = "MigrationReason")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	string MigrationReason { get; set; }
}
[FilterFor(typeof(IWorkflowInstanceMigrationPackage))]
public interface IWorkflowInstanceMigrationPackageFilter : IEntityFilter
{
	string Name { get; set; }

	DateTimeRange CreationDate { get; set; }

	IUser CreationAuthor { get; set; }

	WorkflowInstanceMigrationPackageStatus? Status { get; set; }

	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(FieldName = "IsActive")]
	[CanBeNull]
	[CustomFilterProperty]
	[Uid("335f116e-1263-46e7-9660-adbe15db2027")]
	[DisplayName(typeof(__Resources_IWorkflowInstanceMigrationPackage), "FP_IsActive_DisplayName")]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	bool? IsActive { get; set; }
}
