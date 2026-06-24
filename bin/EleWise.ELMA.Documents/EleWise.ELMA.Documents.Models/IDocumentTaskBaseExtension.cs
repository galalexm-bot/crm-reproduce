using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Documents.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("e41b21fb-a5fb-4d42-a703-8db33c8db6e0")]
[DisplayName(typeof(__Resources_IDocumentTaskBaseExtension), "DisplayName")]
[BaseClass("0f338330-068c-4135-be4e-95797a209c4e")]
[DisplayFormat(null)]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>e2c02da6-fcf4-4ff8-8f0f-37be6b420858</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("DocumentTaskBaseExtension")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.InterfaceExtension)]
[Filterable]
[FilterType(typeof(IDocumentTaskBaseExtensionFilter))]
[ActionsType(typeof(DocumentTaskBaseExtensionActions))]
public interface IDocumentTaskBaseExtension : ITaskBase, IEntity<long>, IEntity, IIdentified, IInheritable
{
}
