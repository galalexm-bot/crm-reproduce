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
[Uid("faa1edca-b15c-4307-9b6e-45f6aa3cb533")]
[DisplayName("SR.M('Работа планировщика для активити модулей интеграции')")]
[Description("SR.M('Расширение работы задачи планировщика для хранения информации об активити модуля интеграции')")]
[BaseClass("215dd155-ef88-4b92-ab32-6c370e50340c")]
[DisplayFormat(null)]
[TableView("\ufeff<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>27889ed9-3713-4c4c-990b-c7cffb916660</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("IMSchedulerTaskJob")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[ImplementationUid("3703f1a1-ed79-4755-85ba-e83904dd9aea")]
public interface IIntegrationModuleSchedulerTaskJob : ISchedulerTaskJob, IEntity<long>, IEntity, IIdentified, IInheritable
{
	[Uid("3d76e264-3702-4334-a490-e3ccc7a99d0a")]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "c9979e1d-0e5d-4c88-9af5-f44e08c06993")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "IntegrationModuleBookmark")]
	[DisplayName("SR.M('Точка останова модуля интеграции')")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	IWorkflowIntegrationBookmark IntegrationModuleBookmark { get; set; }

	[Uid("6e6b95cd-a07d-423a-80b5-7924c42b401b")]
	[Order(1)]
	[CanBeNull]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "IntegrationConnectorUid")]
	[DisplayName("SR.M('Идентификатор перехода')")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	Guid? IntegrationConnectorUid { get; set; }
}
