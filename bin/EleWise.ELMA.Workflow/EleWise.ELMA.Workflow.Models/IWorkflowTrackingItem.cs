using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Workflow.Models;

[Entity("WorkflowTrackingItem")]
[EntityMetadataType(EntityMetadataType.Interface)]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>00456576-1011-4dca-901d-588defa3d0da</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[DisplayName(typeof(__Resources_IWorkflowTrackingItem), "DisplayName")]
[Uid("417f0022-130c-43ee-b91f-3890f5de2307")]
[ImplementationUid("bb54f905-dffa-4ae7-a893-3d7f5e358d39")]
[MetadataType(typeof(EntityMetadata))]
[DisplayFormat(null)]
[Description(typeof(__Resources_IWorkflowTrackingItem), "Description")]
public interface IWorkflowTrackingItem : IEntity<long>, IEntity, IIdentified
{
	[Uid("c7e03210-cff7-4beb-ae5a-b07146d112a2")]
	[GuidSettings(FieldName = "Uid")]
	[DisplayName(typeof(__Resources_IWorkflowTrackingItem), "P_Uid_DisplayName")]
	[NotNull]
	[SystemProperty]
	[EntityProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	Guid Uid { get; set; }

	[EntityProperty]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "ae8e2269-5077-4bb3-a8dd-62e5d130f009")]
	[EntitySettings(FieldName = "Instance")]
	[Uid("e7fd06e7-f030-495d-a003-c5a1812f80e3")]
	[DisplayName(typeof(__Resources_IWorkflowTrackingItem), "P_Instance_DisplayName")]
	IWorkflowInstance Instance { get; set; }

	[RequiredField]
	[DisplayName(typeof(__Resources_IWorkflowTrackingItem), "P_ElementUid_DisplayName")]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "ElementUid")]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[Required(true)]
	[Uid("1e19b310-718e-4edf-9bbb-b112b1bb081f")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[NotNull]
	[Order(1)]
	Guid ElementUid { get; set; }

	[CanBeNull]
	[Order(2)]
	[Uid("2e39e1aa-a6f9-40fa-b14a-299ad60b79bc")]
	[Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
	[DateTimeSettings(FieldName = "StartDate")]
	[EntityProperty]
	[DisplayName(typeof(__Resources_IWorkflowTrackingItem), "P_StartDate_DisplayName")]
	DateTime? StartDate { get; set; }

	[CanBeNull]
	[Order(3)]
	[Uid("602ea27e-4e21-42f6-8e58-9da390d289e5")]
	[Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
	[DateTimeSettings(FieldName = "EndDate")]
	[EntityProperty]
	[DisplayName(typeof(__Resources_IWorkflowTrackingItem), "P_EndDate_DisplayName")]
	DateTime? EndDate { get; set; }
}
