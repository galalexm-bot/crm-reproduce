using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.IntegrationModules.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.IntegrationModules.Workflow.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("c9979e1d-0e5d-4c88-9af5-f44e08c06993")]
[DisplayName("SR.M('Точка останова интеграции')")]
[DisplayFormat(null)]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>1314baa2-a8c8-4a9a-aa0a-64714628130f</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("WorkflowIntegrationBookmark")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[Filterable]
[ImplementationUid("28fc953c-49c4-44f8-932f-33f79fbcbbb7")]
[FilterType(typeof(IWorkflowIntegrationBookmarkFilter))]
public interface IWorkflowIntegrationBookmark : IEntity<long>, IEntity, IIdentified
{
	[Uid("93d57816-23d4-45be-bfe1-485b9a813c23")]
	[NotNull]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "Uid")]
	[DisplayName("SR.M('Уникальный идентификатор')")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	Guid Uid { get; set; }

	[Uid("285d6abc-d24e-436c-9a9b-d44194ed400d")]
	[Order(1)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "1c56d793-9753-4a56-bc01-790cb0417251")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "WorkflowBookmark")]
	[DisplayName("SR.M('Точка останова экземпляра процесса')")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	IWorkflowBookmark WorkflowBookmark { get; set; }

	[Uid("2dc40951-648d-4cfd-a29d-a80c0d3c44e9")]
	[Order(2)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "35fc5381-8e21-48db-a19e-6c64965d9dcf")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "Integration")]
	[DisplayName("SR.M('Экземпляр интеграции')")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	IIntegrationModule Integration { get; set; }

	[Uid("df95e299-dacd-424f-8494-cb257cd0a6f3")]
	[Order(3)]
	[CanBeNull]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "ElementUid")]
	[DisplayName("SR.M('Уникальный идентификатор элемента процесса')")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	Guid? ElementUid { get; set; }

	[Uid("a83049f3-62e5-4520-8fcb-2abca94413ca")]
	[Order(4)]
	[NotNull]
	[Property("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
	[Int64Settings(RangeInFilter = false, FieldName = "WorkflowInstanceId")]
	[DisplayName("SR.M('Идентификатор экземпляра процесса')")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	long WorkflowInstanceId { get; set; }
}
