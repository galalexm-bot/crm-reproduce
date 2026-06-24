using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Scheduling.Models;

namespace EleWise.ELMA.Workflow.Models;

[BaseClass("215dd155-ef88-4b92-ab32-6c370e50340c")]
[DisplayName(typeof(__Resources_ITerminateMessageReceiveSchedulerJob), "DisplayName")]
[MetadataType(typeof(EntityMetadata))]
[Uid("85516bb3-c239-4e3c-b1e9-b7f1cb746034")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[ImplementationUid("ad25f98c-844d-4d9a-ba52-d1378855d518")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[DisplayFormat(null)]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>0c6fc9b7-84e5-4b94-8163-e9247e968240</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("TerminateMessageReceSchedJob")]
public interface ITerminateMessageReceiveSchedulerJob : ISchedulerTaskJob, IEntity<long>, IEntity, IIdentified, IInheritable
{
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[EntityProperty]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "MessageBookmark")]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "38bc42c0-84bf-44e8-a9d2-c7a7ad7a6b43")]
	[Uid("56dbafd3-a153-4e19-aa58-2f4be933931c")]
	[DisplayName(typeof(__Resources_ITerminateMessageReceiveSchedulerJob), "P_MessageBookmark_DisplayName")]
	IWorkflowMessageBookmark MessageBookmark { get; set; }

	[DisplayName(typeof(__Resources_ITerminateMessageReceiveSchedulerJob), "P_ConnectorUid_DisplayName")]
	[GuidSettings(FieldName = "ConnectorUid")]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Uid("c0f04de1-2045-4858-a602-059c73e0c8b3")]
	[Order(1)]
	[CanBeNull]
	[EntityProperty]
	Guid? ConnectorUid { get; set; }
}
