using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.Workflow.Models;

[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>c74e9217-1442-43e2-aa54-e87687d2e1e2</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[InterfaceImplementation("EleWise.ELMA.Model.Entities.ISoftDeletable")]
[EntityMetadataType(EntityMetadataType.Interface)]
[ShowInCatalogList(false)]
[Entity("WorkflowMessageType")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[DisplayName(typeof(__Resources_IWorkflowMessageType), "DisplayName")]
[DisplayFormat(null)]
[ImplementationUid("dcd9a816-c738-4b33-a49b-53d9f147a794")]
[Uid("bf1c98d5-a4d9-451a-a015-c3142c03955c")]
[MetadataType(typeof(EntityMetadata))]
public interface IWorkflowMessageType : IEntity<long>, IEntity, IIdentified, ISoftDeletable
{
	[GuidSettings(FieldName = "Uid")]
	[SystemProperty]
	[DisplayName(typeof(__Resources_IWorkflowMessageType), "P_Uid_DisplayName")]
	[EntityProperty]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[NotNull]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[Uid("3c518a36-581f-4afc-b709-2c15c84275b2")]
	Guid Uid { get; set; }

	[Order(1)]
	[Uid("5c903f0f-5c80-4e89-9e7b-c6dcf7e4e617")]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[StringSettings(MaxValueString = "2000", FieldName = "Name")]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[DisplayName(typeof(__Resources_IWorkflowMessageType), "P_Name_DisplayName")]
	[StringRangeLength(0, "2000")]
	string Name { get; set; }

	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[EntityProperty]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName(typeof(__Resources_IWorkflowMessageType), "P_Description_DisplayName")]
	[StringSettings(MultiLine = true, FieldName = "Description")]
	[Order(2)]
	[Uid("e2c28bb2-cf8f-4553-b0a6-46401c18e102")]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	string Description { get; set; }

	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntitySettings(RelationType = RelationType.OneToMany, KeyColumnUidStr = "dfef2522-8746-4ab3-9027-1515b258baa1", CascadeMode = CascadeMode.SaveUpdate)]
	[DisplayName(typeof(__Resources_IWorkflowMessageType), "P_Parameters_DisplayName")]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[EntityProperty]
	[Uid("bf284416-9eee-4ab4-b545-d83aab570425")]
	[Order(3)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "645d690f-21cb-4bfa-a060-6bbe39431f1f")]
	ISet<IWorkflowMessageTypeParameter> Parameters { get; set; }

	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName(typeof(__Resources_IWorkflowMessageType), "P_ReliableDelivery_DisplayName")]
	[BoolSettings(FieldName = "ReliableDelivery")]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[Order(4)]
	[Uid("7465c187-8d2f-427f-a9b0-648491803bbb")]
	[NotNull]
	[EntityProperty]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	bool ReliableDelivery { get; set; }

	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName(typeof(__Resources_IWorkflowMessageType), "P_IsDeleted_DisplayName")]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[EntityProperty]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Uid("752b63d9-7154-420d-878d-527bdf1d3488")]
	[NotNull]
	[Order(5)]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(FieldName = "IsDeleted")]
	new bool IsDeleted { get; set; }

	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName(typeof(__Resources_IWorkflowMessageType), "P_HardDelete_DisplayName")]
	[Uid("3ebc7f89-be4d-4629-8583-564f591556e1")]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[NotNull]
	[Order(6)]
	[BoolSettings(FieldName = "HardDelete")]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	new bool HardDelete { get; set; }
}
