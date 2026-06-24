using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Content.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("707b01d4-4fad-4ee5-bf4f-a299cd8a143c")]
[DisplayName(typeof(__Resources_IPageFolder), "DisplayName")]
[BaseClass("8b9c66a6-fdf2-4410-a528-9082aa9b0b8e")]
[DisplayFormat(null)]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>3b851ba2-f55e-490d-9535-943d53acf945</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("PageFolder")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[ImplementationUid("dab4db21-89f2-4cfc-89a9-5391f826c713")]
public interface IPageFolder : IPortalObject, IEntity<long>, IEntity, IIdentified, IInheritable
{
}
