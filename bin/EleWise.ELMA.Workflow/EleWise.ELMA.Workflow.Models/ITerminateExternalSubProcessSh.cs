using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Scheduling.Models;

namespace EleWise.ELMA.Workflow.Models;

[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>ec2f8267-1688-404f-8efc-11b7f641fbf1</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[DisplayFormat(null)]
[Uid("79229e1d-954d-4644-8709-05aac196edc2")]
[MetadataType(typeof(EntityMetadata))]
[BaseClass("215dd155-ef88-4b92-ab32-6c370e50340c")]
[DisplayName(typeof(__Resources_ITerminateExternalSubProcessShelulerJob), "DisplayName")]
[EntityMetadataType(EntityMetadataType.Interface)]
[ImplementationUid("de0613ca-93fa-4140-b1d7-e315d8d9d225")]
[ShowInCatalogList(false)]
[Entity("TermExtSubProcShelulerJob")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
public interface ITerminateExternalSubProcessShelulerJob : ISchedulerTaskJob, IEntity<long>, IEntity, IIdentified, IInheritable
{
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[Uid("9f494d05-b13d-4a4b-904d-fac09c9d39f2")]
	[CanBeNull]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	[GuidSettings(FieldName = "ConnectorUid")]
	[DisplayName(typeof(__Resources_ITerminateExternalSubProcessShelulerJob), "P_ConnectorUid_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	Guid? ConnectorUid { get; set; }

	[EntityProperty]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "ae8e2269-5077-4bb3-a8dd-62e5d130f009")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "subInstance")]
	[Uid("e05d24cb-bc5a-4517-8ada-83526fe091a7")]
	[Order(1)]
	[DisplayName(typeof(__Resources_ITerminateExternalSubProcessShelulerJob), "P_subInstance_DisplayName")]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	IWorkflowInstance subInstance { get; set; }

	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName(typeof(__Resources_ITerminateExternalSubProcessShelulerJob), "P_WorkflowBookmark_DisplayName")]
	[EntityProperty]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "WorkflowBookmark")]
	[Uid("22b2e572-0b39-4e63-a871-a12d746636e5")]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "1c56d793-9753-4a56-bc01-790cb0417251")]
	[Order(2)]
	IWorkflowBookmark WorkflowBookmark { get; set; }
}
