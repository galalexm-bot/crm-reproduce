using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Content.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("18cdf140-3108-4768-8d8a-a94d405aa092")]
[DisplayName(typeof(__Resources_ILeftMenu), "DisplayName")]
[BaseClass("fd7b1de8-71be-4eb5-97a5-cf759a4576f9")]
[DisplayFormat(null)]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>f77c46a3-8197-4d15-ac03-a09a78dbcbab</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("LeftMenu")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[ImplementationUid("247e6ac7-5230-4ca7-94b4-72c4b69dd2c1")]
public interface ILeftMenu : IMenu, IEntity<int>, IEntity, IIdentified, IInheritable
{
}
