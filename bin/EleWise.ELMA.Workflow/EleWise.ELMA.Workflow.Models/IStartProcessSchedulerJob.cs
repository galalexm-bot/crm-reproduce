using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Scheduling.Models;

namespace EleWise.ELMA.Workflow.Models;

[DisplayName(typeof(__Resources_IStartProcessSchedulerJob), "DisplayName")]
[Uid("edb7b6ee-b938-44ef-84fd-28073f17110d")]
[MetadataType(typeof(EntityMetadata))]
[ShowInCatalogList(false)]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ImplementationUid("6b99fc52-8d1a-49f8-ab40-d8ef081f181e")]
[EntityMetadataType(EntityMetadataType.Interface)]
[DisplayFormat(null)]
[BaseClass("215dd155-ef88-4b92-ab32-6c370e50340c")]
[Entity("StartProcessSchedulerJob")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>6c36a446-4081-4578-a210-86045926675d</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
public interface IStartProcessSchedulerJob : ISchedulerTaskJob, IEntity<long>, IEntity, IIdentified, IInheritable
{
	[EntitySettings(FieldName = "ProcessHeader")]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "da55965d-02a3-4dfd-8b71-d0c45d82c6a5")]
	[Uid("52a9cf6c-4202-4f44-91e0-a2c5b8168bd6")]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[DisplayName(typeof(__Resources_IStartProcessSchedulerJob), "P_ProcessHeader_DisplayName")]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	IProcessHeader ProcessHeader { get; set; }
}
