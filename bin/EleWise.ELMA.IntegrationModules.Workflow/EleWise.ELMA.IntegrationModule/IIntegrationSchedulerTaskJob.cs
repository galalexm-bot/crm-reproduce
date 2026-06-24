using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Scheduling.Models;

namespace EleWise.ELMA.IntegrationModules.Workflow.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("b7f17d95-8259-43e0-a92a-9a2faf920c6d")]
[DisplayName("SR.M('Работа планировщика для активити интеграции')")]
[BaseClass("215dd155-ef88-4b92-ab32-6c370e50340c")]
[DisplayFormat(null)]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>3714ee78-e3a8-470e-80b2-3f2117c31f13</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("IntegrationSchedulerTaskJob")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.InterfaceExtension)]
public interface IIntegrationSchedulerTaskJob : ISchedulerTaskJob, IEntity<long>, IEntity, IIdentified, IInheritable
{
	[Uid("ade45131-f4bb-4f01-bd1e-9d50800424e6")]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "c9979e1d-0e5d-4c88-9af5-f44e08c06993")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "IntegrationBookmark")]
	[DisplayName("SR.M('Точка останова')")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	IWorkflowIntegrationBookmark IntegrationBookmark { get; set; }

	[Uid("e9638125-7af5-4c6f-957d-2a02cede4002")]
	[Order(1)]
	[CanBeNull]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "ConnectorUid")]
	[DisplayName("SR.M('Идентификатор перехода')")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	Guid? ConnectorUid { get; set; }
}
