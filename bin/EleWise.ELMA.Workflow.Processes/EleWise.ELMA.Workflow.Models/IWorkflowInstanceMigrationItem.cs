using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Workflow.Models;

[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>db27776b-083e-4a20-b533-9eca44330844</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("WfInstanceMigrationItem")]
[ShowInCatalogList(false)]
[DisplayFormat(null)]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[FilterType(typeof(IWorkflowInstanceMigrationItemFilter))]
[ImplementationUid("eb754df0-72fe-4b12-9c86-fcda11bcd2fa")]
[Filterable]
[EntityMetadataType(EntityMetadataType.Interface)]
[Uid("6af995bc-e654-42d3-b166-754ddec1b419")]
[MetadataType(typeof(EntityMetadata))]
[DisplayName(typeof(__Resources_IWorkflowInstanceMigrationItem), "DisplayName")]
public interface IWorkflowInstanceMigrationItem : IEntity<long>, IEntity, IIdentified
{
	[EntityProperty]
	[GuidSettings(FieldName = "Uid")]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[DisplayName(typeof(__Resources_IWorkflowInstanceMigrationItem), "P_Uid_DisplayName")]
	[NotNull]
	[SystemProperty]
	[Uid("45a5bd44-e029-4e0c-a951-a26d5ffd4d1e")]
	Guid Uid { get; set; }

	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "ae8e2269-5077-4bb3-a8dd-62e5d130f009")]
	[Order(1)]
	[DisplayName(typeof(__Resources_IWorkflowInstanceMigrationItem), "P_WorkflowInstance_DisplayName")]
	[EntitySettings(FieldName = "WorkflowInstance")]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	[Uid("4ad04561-91d9-4e4d-bc63-2c2d343fd0aa")]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	IWorkflowInstance WorkflowInstance { get; set; }

	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "Package")]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Order(2)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[DisplayName(typeof(__Resources_IWorkflowInstanceMigrationItem), "P_Package_DisplayName")]
	[Filterable]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "d8a0f095-08e5-47bb-ad4d-20f521f1c2d4")]
	[Uid("76b9ce10-7a81-49e0-9796-5cc30cf52e27")]
	[EntityProperty]
	IWorkflowInstanceMigrationPackage Package { get; set; }

	[EnumSettings(FieldName = "Status")]
	[Order(3)]
	[Property("849c1ac9-4d46-4194-8cbb-43f84adf9c17", "a26bbf50-feb9-4416-84bb-0813dfb4acb3")]
	[Uid("addf9e62-3445-49c7-9193-4d73821e99ef")]
	[CanBeNull]
	[EntityProperty]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Filterable]
	[DisplayName(typeof(__Resources_IWorkflowInstanceMigrationItem), "P_Status_DisplayName")]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	WorkflowInstanceMigrationItemStatus? Status { get; set; }

	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[StringSettings(FieldName = "Comment")]
	[DisplayName(typeof(__Resources_IWorkflowInstanceMigrationItem), "P_Comment_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Uid("ed442f59-5d77-421e-8926-35983787d056")]
	[Order(4)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[EntityProperty]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	string Comment { get; set; }

	[EntityProperty]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[CanBeNull]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[Uid("f636a0cd-31a6-49d2-8b6c-1575d7fb688f")]
	[Order(5)]
	[DisplayName(typeof(__Resources_IWorkflowInstanceMigrationItem), "P_IsManualUpdateAvailable_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[BoolSettings(DefaultValueStr = "True", FieldName = "IsManualUpdateAvailable")]
	bool? IsManualUpdateAvailable { get; set; }

	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[EntityProperty]
	[Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
	[DateTimeSettings(FieldName = "StartDate")]
	[CanBeNull]
	[Uid("fab209cb-9621-4581-82ba-7e515640fd0a")]
	[Order(6)]
	[DisplayName(typeof(__Resources_IWorkflowInstanceMigrationItem), "P_StartDate_DisplayName")]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	DateTime? StartDate { get; set; }
}
[FilterFor(typeof(IWorkflowInstanceMigrationItem))]
public interface IWorkflowInstanceMigrationItemFilter : IEntityFilter
{
	IWorkflowInstanceMigrationPackage Package { get; set; }

	WorkflowInstanceMigrationItemStatus? Status { get; set; }
}
