using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Content.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("e487244a-e2ec-4af2-acb2-8999a5438cd3")]
[DisplayName(typeof(__Resources_IStartMenu), "DisplayName")]
[BaseClass("fd7b1de8-71be-4eb5-97a5-cf759a4576f9")]
[DisplayFormat(null)]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>b6251aae-812d-43fa-8619-6ad9acc5204c</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("StartMenu")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[ImplementationUid("12af54f6-29ca-48bf-9877-245a2b9b8758")]
public interface IStartMenu : IMenu, IEntity<int>, IEntity, IIdentified, IInheritable
{
}
