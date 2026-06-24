using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Scheduling.Models;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.RPA.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("af246c33-c468-4371-97d6-ab77dde5ace4")]
[DisplayName(typeof(__Resources_IExecutingRPAProcessSchedulerJob), "DisplayName")]
[BaseClass("215dd155-ef88-4b92-ab32-6c370e50340c")]
[AllowCreateHeirs(true)]
[DisplayFormat(null)]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>683fd60d-dcae-47ad-813c-b3a3d25820d8</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("ExecRPAProcSchedulerJob")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[ImplementationUid("d3cedb40-d5ba-4258-8373-110c0103dee1")]
[InstancePermission(false, "ExecutingRPAProcesPermission", "Permissions")]
public interface IExecutingRPAProcessSchedulerJob : ISchedulerTaskJob, IEntity<long>, IEntity, IIdentified, IInheritable
{
	[Uid("fffb3456-3520-4e6a-b112-299c2473c13c")]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "1c56d793-9753-4a56-bc01-790cb0417251")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "WorkflowBookmark")]
	[DisplayName(typeof(__Resources_IExecutingRPAProcessSchedulerJob), "P_WorkflowBookmark_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	IWorkflowBookmark WorkflowBookmark { get; set; }

	[Uid("2cb30c5f-5b42-431c-bdc4-eb79a6e67537")]
	[Order(1)]
	[NotNull]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "SchedulerTaskUid")]
	[DisplayName(typeof(__Resources_IExecutingRPAProcessSchedulerJob), "P_SchedulerTaskUid_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	Guid SchedulerTaskUid { get; set; }

	[Uid("720260fc-750a-45e0-94dc-22f0c635298a")]
	[Order(2)]
	[NotNull]
	[Property("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
	[Int64Settings(FieldName = "RPATaskId")]
	[DisplayName(typeof(__Resources_IExecutingRPAProcessSchedulerJob), "P_RPATaskId_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	long RPATaskId { get; set; }
}
