using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Workflow.Models;

[EntityMetadataType(EntityMetadataType.InterfaceExtension)]
[MetadataType(typeof(EntityMetadata))]
[Uid("0eeff57a-c8e6-4749-a2f5-df3d800bebb6")]
[Filterable]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ActionsType(typeof(ProcessesWorkflowInstanceActions))]
[FilterType(typeof(IProcessesWorkflowInstanceFilter))]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>0fae0258-0506-438b-af12-31ee538f9c00</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[ShowInCatalogList(false)]
[Entity("ProcessesWorkflowInstance")]
[ClassFormsScheme(ClassFormsScheme.FormConstructor)]
[DisplayName(typeof(__Resources_IProcessesWorkflowInstance), "DisplayName")]
[BaseClass("ae8e2269-5077-4bb3-a8dd-62e5d130f009")]
[DisplayFormat(null)]
public interface IProcessesWorkflowInstance : IWorkflowInstance, IEntity<long>, IEntity, IIdentified
{
}
