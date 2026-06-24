using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Scheduling.Models;

namespace EleWise.ELMA.Workflow.Models;

[ShowInCatalogList(false)]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[Entity("TerminateTaskSchedulerJob")]
[ActionsType(typeof(TerminateTaskSchedulerJobActions))]
[EntityMetadataType(EntityMetadataType.Interface)]
[ImplementationUid("445c900f-a039-4c6e-8a3d-2caa5936cfbb")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>728bea6e-ba27-46de-9bc2-c54ead142be6</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Uid("1727e692-3ba0-470a-9db7-49d83c78cb60")]
[MetadataType(typeof(EntityMetadata))]
[DisplayName(typeof(__Resources_ITerminateTaskSchedulerJob), "DisplayName")]
[DisplayFormat(null)]
[BaseClass("215dd155-ef88-4b92-ab32-6c370e50340c")]
public interface ITerminateTaskSchedulerJob : ISchedulerTaskJob, IEntity<long>, IEntity, IIdentified, IInheritable
{
	[Uid("d6e1587d-4dfb-4062-a172-8dd73d49148c")]
	[EntityProperty]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[DisplayName(typeof(__Resources_ITerminateTaskSchedulerJob), "P_WorkflowBookmark_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "1c56d793-9753-4a56-bc01-790cb0417251")]
	[EntitySettings(FieldName = "WorkflowBookmark")]
	IWorkflowBookmark WorkflowBookmark { get; set; }

	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[EntityProperty]
	[DisplayName(typeof(__Resources_ITerminateTaskSchedulerJob), "P_ConnectorUid_DisplayName")]
	[GuidSettings(FieldName = "ConnectorUid")]
	[NotNull]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Order(1)]
	[Uid("b9e3a368-8b81-423c-a969-f3548040c0db")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	Guid ConnectorUid { get; set; }
}
