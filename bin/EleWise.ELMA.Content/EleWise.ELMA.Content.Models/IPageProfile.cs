using EleWise.ELMA.Content.Transformation;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Content.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("5b3a5e5c-89b2-4626-a58c-c7f884852109")]
[DisplayName(typeof(__Resources_IPageProfile), "DisplayName")]
[BaseClass("8b9c66a6-fdf2-4410-a528-9082aa9b0b8e")]
[DisplayFormat(null)]
[ShowInTypeTree(false)]
[ShowInDesigner(false)]
[InterfaceImplementation("EleWise.ELMA.Content.Transformation.IPageTransformationContainer, EleWise.ELMA.Content")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>b46bcfbf-f2c5-4433-8a46-6d556f7eb7ed</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("PageProfile")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[ImplementationUid("65b3fd77-9a21-4454-a8a1-b7a7fe7a015f")]
public interface IPageProfile : IPortalObject, IEntity<long>, IEntity, IIdentified, IInheritable, IPageTransformationContainer
{
}
