using EleWise.ELMA.IntegrationModules.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.IntegrationModules.Workflow.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("d869e7e0-ad13-4fd6-95c9-22ac712d86b0")]
[DisplayName("SR.M('Расширение модулей интеграции для работы с процессами')")]
[BaseClass("35fc5381-8e21-48db-a19e-6c64965d9dcf")]
[DisplayFormat(null)]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>83e2b46e-96b8-4a45-8f22-a2a58973b3f9</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("IntegrationModuleWorkflow")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.InterfaceExtension)]
public interface IIntegrationModuleWorkflow : IIntegrationModule, IEntity<long>, IEntity, IIdentified, ISoftDeletable, IInheritable
{
	[Uid("0b8a1fb5-0fe6-4534-998e-7f5031e76fe1")]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "ae8e2269-5077-4bb3-a8dd-62e5d130f009")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "WorkflowInstance")]
	[DisplayName("SR.M('Экземпляр процесса')")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	IWorkflowInstance WorkflowInstance { get; set; }
}
