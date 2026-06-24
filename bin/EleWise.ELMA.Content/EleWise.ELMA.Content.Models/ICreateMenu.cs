using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Content.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("94745532-cdc7-4d8b-8f5e-8ba06d6695ce")]
[DisplayName(typeof(__Resources_ICreateMenu), "DisplayName")]
[BaseClass("fd7b1de8-71be-4eb5-97a5-cf759a4576f9")]
[DisplayFormat(null)]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>da80b572-93de-4f4e-84c7-8d1616f5b378</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("CreateMenu")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[ImplementationUid("e6523981-4c07-4fbc-bbe9-9d528a008587")]
public interface ICreateMenu : IMenu, IEntity<int>, IEntity, IIdentified, IInheritable
{
}
