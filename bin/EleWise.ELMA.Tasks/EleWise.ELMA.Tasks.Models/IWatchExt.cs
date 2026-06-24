using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Tasks.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("49910266-cd47-4e84-9030-5a2a65bae705")]
[DisplayName(typeof(__Resources_IWatchExt), "DisplayName")]
[BaseClass("e40e61fc-45d4-44d8-b748-d6ccbffe79b2")]
[DisplayFormat(null)]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>3dba7e07-6b71-4d47-89d7-57dfbb40ec1a</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("WatchExt")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.InterfaceExtension)]
[ActionsType(typeof(WatchExtActions))]
public interface IWatchExt : IWatch, IEntity<long>, IEntity, IIdentified
{
}
