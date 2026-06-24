using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Workflow.Models;

[EntityMetadataType(EntityMetadataType.Interface)]
[ShowInCatalogList(false)]
[MetadataType(typeof(EntityMetadata))]
[ImplementationUid("80feba39-f9aa-4ab7-935b-4cde163ec6ea")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>55f849e0-6c10-44ea-bf4d-b55dc3d8a141</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[DisplayFormat(null)]
[DisplayName(typeof(__Resources_IWorkflowMessageItem), "DisplayName")]
[Entity("WorkflowMessageItem")]
[Uid("44eb0e05-eadc-4831-9b55-f57ff6e77a62")]
public interface IWorkflowMessageItem : IEntity<long>, IEntity, IIdentified
{
	[GuidSettings(FieldName = "Uid")]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[DisplayName(typeof(__Resources_IWorkflowMessageItem), "P_Uid_DisplayName")]
	[Uid("d0af0037-87cc-4684-806c-e96c0d48f96b")]
	[EntityProperty]
	[SystemProperty]
	[NotNull]
	Guid Uid { get; set; }

	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "bf1c98d5-a4d9-451a-a015-c3142c03955c")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "MessageType")]
	[DisplayName(typeof(__Resources_IWorkflowMessageItem), "P_MessageType_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Uid("ed67494b-32d5-49d4-a061-006f2084004d")]
	[Order(1)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[EntityProperty]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	IWorkflowMessageType MessageType { get; set; }

	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Order(2)]
	[Uid("8e0e7744-3287-4590-9562-31cbf532d431")]
	[EntityProperty]
	[XmlSerializableObjectSettings(FieldName = "MessageData")]
	[Property("66c7898b-e56b-49e0-bfb8-9f9c4a7a0c52")]
	[DisplayName(typeof(__Resources_IWorkflowMessageItem), "P_MessageData_DisplayName")]
	object MessageData { get; set; }

	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Uid("c9e2a75e-8a17-41bb-aa4c-138dc8b90c77")]
	[EntityProperty]
	[DisplayName(typeof(__Resources_IWorkflowMessageItem), "P_DestinationWorkflowInstance_DisplayName")]
	[Order(3)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "ae8e2269-5077-4bb3-a8dd-62e5d130f009")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "DestinationWorkflowInstance")]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	IWorkflowInstance DestinationWorkflowInstance { get; set; }

	[DisplayName(typeof(__Resources_IWorkflowMessageItem), "P_SentDate_DisplayName")]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[EntityProperty]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[DateTimeSettings(SetCurrentDate = true, FieldName = "SentDate")]
	[Uid("1d3322d0-5611-4491-bd20-6070b7667ea5")]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Order(4)]
	[Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
	[NotNull]
	DateTime SentDate { get; set; }

	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[DisplayName(typeof(__Resources_IWorkflowMessageItem), "P_ReceiverUids_DisplayName")]
	[Uid("873ce02e-c66f-47bb-9f96-eff2dba956a4")]
	[Order(5)]
	[EntityProperty]
	[XmlSerializableObjectSettings(FieldName = "ReceiverUids")]
	[Property("66c7898b-e56b-49e0-bfb8-9f9c4a7a0c52")]
	object ReceiverUids { get; set; }

	[Property("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
	[Int64Settings(FieldName = "Timestamp")]
	[CanBeNull]
	[Uid("f6038fbd-5fa2-4e7a-ad68-6d50f9604107")]
	[Order(6)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[EntityProperty]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Description(typeof(__Resources_IWorkflowMessageItem), "P_Timestamp_Description")]
	[DisplayName(typeof(__Resources_IWorkflowMessageItem), "P_Timestamp_DisplayName")]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	long? Timestamp { get; set; }
}
