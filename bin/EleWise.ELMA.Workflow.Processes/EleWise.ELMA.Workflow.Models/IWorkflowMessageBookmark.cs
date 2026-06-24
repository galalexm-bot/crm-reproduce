using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Workflow.Models;

[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[Entity("WorkflowMessageBookmark")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>7bb76a15-dee7-45f5-a5fe-ffdd654836d2</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[ShowInCatalogList(false)]
[ActionsType(typeof(WorkflowMessageBookmarkActions))]
[ImplementationUid("4c210446-237e-4b7a-a2db-32077b2bf617")]
[EntityMetadataType(EntityMetadataType.Interface)]
[DisplayName(typeof(__Resources_IWorkflowMessageBookmark), "DisplayName")]
[Uid("38bc42c0-84bf-44e8-a9d2-c7a7ad7a6b43")]
[MetadataType(typeof(EntityMetadata))]
[DisplayFormat(null)]
[Image(typeof(IWorkflowMessageBookmark), "escalation", 16, ImageFormatType.IconPack, false)]
public interface IWorkflowMessageBookmark : IEntity<long>, IEntity, IIdentified
{
	[GuidSettings(FieldName = "Uid")]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[DisplayName(typeof(__Resources_IWorkflowMessageBookmark), "P_Uid_DisplayName")]
	[EntityProperty]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[SystemProperty]
	[Uid("b591a592-1c4a-4082-8891-2e79624f46c2")]
	[NotNull]
	Guid Uid { get; set; }

	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "Bookmark")]
	[DisplayName(typeof(__Resources_IWorkflowMessageBookmark), "P_Bookmark_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[EntityProperty]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Uid("2b4ef57c-e653-4b25-85f8-1214b8fa71ec")]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "1c56d793-9753-4a56-bc01-790cb0417251")]
	[Order(2)]
	IWorkflowBookmark Bookmark { get; set; }

	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "bf1c98d5-a4d9-451a-a015-c3142c03955c")]
	[Uid("d1a148e8-a55e-4950-9175-2c57e9bf2308")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "MessageType")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName(typeof(__Resources_IWorkflowMessageBookmark), "P_MessageType_DisplayName")]
	[Order(3)]
	IWorkflowMessageType MessageType { get; set; }

	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[DisplayName(typeof(__Resources_IWorkflowMessageBookmark), "P_ControlParameterValue_DisplayName")]
	[EntityProperty]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(MaxValueString = "2000", FieldName = "ControlParameterValue")]
	[StringRangeLength(0, "2000")]
	[Uid("66d45ad2-49e6-482c-86c2-9fa98f0e9fc0")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Order(4)]
	string ControlParameterValue { get; set; }

	[Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
	[NotNull]
	[Uid("0c71344a-2b8f-46a6-b481-fc5643b53d8e")]
	[DateTimeSettings(SetCurrentDate = true, FieldName = "CreationDate")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[PropertyHandler("d0c00d8a-e003-427d-9942-f52cfb77b0f0")]
	[DisplayName(typeof(__Resources_IWorkflowMessageBookmark), "P_CreationDate_DisplayName")]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[EntityProperty]
	[Filterable]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[Order(1)]
	DateTime CreationDate { get; set; }

	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	[DisplayName(typeof(__Resources_IWorkflowMessageBookmark), "P_Status_DisplayName")]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EnumSettings(DefaultValueStr = "f26b712e-d420-4b07-b708-bdbe2bd2fa6c", FieldName = "Status")]
	[NotNull]
	[Order(5)]
	[Uid("91121c00-f1da-411e-bf31-85a8cfc78473")]
	[Property("849c1ac9-4d46-4194-8cbb-43f84adf9c17", "b57bf1cd-c8d4-4e32-9f9e-1430206b8530")]
	WorkflowMessageBookmarkStatus Status { get; set; }
}
