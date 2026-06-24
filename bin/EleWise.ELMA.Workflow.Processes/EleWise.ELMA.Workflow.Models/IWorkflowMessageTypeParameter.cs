using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Workflow.Models;

[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>5709e0ef-6e11-4157-b342-6ee3f37af694</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("WorkflowMessageTypeParameter")]
[DisplayFormat(null)]
[DisplayName(typeof(__Resources_IWorkflowMessageTypeParameter), "DisplayName")]
[Uid("645d690f-21cb-4bfa-a060-6bbe39431f1f")]
[MetadataType(typeof(EntityMetadata))]
[ShowInCatalogList(false)]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ImplementationUid("d0f1c3c6-9157-4b3b-8701-6530249e9351")]
[EntityMetadataType(EntityMetadataType.Interface)]
public interface IWorkflowMessageTypeParameter : IEntity<long>, IEntity, IIdentified
{
	[NotNull]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[EntityProperty]
	[Uid("dd5d3949-dff2-4b24-8d2b-cf5bf94d9b2d")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[GuidSettings(FieldName = "Uid")]
	[DisplayName(typeof(__Resources_IWorkflowMessageTypeParameter), "P_Uid_DisplayName")]
	Guid Uid { get; set; }

	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName(typeof(__Resources_IWorkflowMessageTypeParameter), "P_Name_DisplayName")]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[EntityProperty]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[StringSettings(FieldName = "Name")]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Uid("9d22160a-c98c-4bf6-9fc5-ea01e0e58656")]
	[Order(1)]
	string Name { get; set; }

	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName(typeof(__Resources_IWorkflowMessageTypeParameter), "P_Description_DisplayName")]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	[StringSettings(MultiLine = true, FieldName = "Description")]
	[Uid("87bbfe00-8c08-477e-9ba2-316b285c13d6")]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[Order(2)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	string Description { get; set; }

	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "WorkflowMessageType")]
	[DisplayName(typeof(__Resources_IWorkflowMessageTypeParameter), "P_WorkflowMessageType_DisplayName")]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "bf1c98d5-a4d9-451a-a015-c3142c03955c")]
	[Uid("dfef2522-8746-4ab3-9027-1515b258baa1")]
	[Order(3)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	IWorkflowMessageType WorkflowMessageType { get; set; }

	[DisplayName(typeof(__Resources_IWorkflowMessageTypeParameter), "P_IsControlValue_DisplayName")]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	[Order(4)]
	[Uid("4d460f6a-0630-461b-9d29-7ef8aa104b71")]
	[NotNull]
	[BoolSettings(FieldName = "IsControlValue")]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	bool IsControlValue { get; set; }
}
