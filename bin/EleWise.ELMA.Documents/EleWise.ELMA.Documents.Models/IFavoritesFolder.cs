using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Types.Settings;

namespace EleWise.ELMA.Documents.Models.Folders;

[MetadataType(typeof(EntityMetadata))]
[Uid("7dab4b57-b458-45ef-a0d7-5695c823c04c")]
[DisplayName(typeof(__Resources_IFavoritesFolder), "DisplayName")]
[BaseClass("b04c011a-27a4-4fab-8bc6-a1a2ab61a1c3")]
[DisplayFormat(null)]
[InterfaceImplementation("EleWise.ELMA.Documents.Models.Folders.IHasOwner, EleWise.ELMA.Documents")]
[Image(typeof(IFavoritesFolder), "star_outline", 16, ImageFormatType.IconPack, false)]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>9a6cde80-1739-40cf-bf46-f8143d616175</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("FavoritesFolder")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[SaveHistory]
[ImplementationUid("a1ea16e1-4ba4-4a82-8e87-84cfd57df72d")]
[ActionsType(typeof(FavoritesFolderActions))]
public interface IFavoritesFolder : IFolder, IDmsObject, IEntity<long>, IEntity, IIdentified, ISoftDeletable, IInheritable, IUserImageSetable, IHasOwner
{
	[Uid("690f5dde-cb3a-43de-b377-0d2dbcd549a1")]
	[Required(true)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
	[EntityUserSettings(FieldName = "Owner")]
	[RequiredField]
	[DisplayName(typeof(__Resources_IFavoritesFolder), "P_Owner_DisplayName")]
	[EntityProperty]
	new IUser Owner { get; set; }
}
