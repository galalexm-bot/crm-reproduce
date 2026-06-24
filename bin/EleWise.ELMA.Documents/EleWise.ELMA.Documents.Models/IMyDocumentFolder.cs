using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Types.Settings;

namespace EleWise.ELMA.Documents.Models.Folders;

[MetadataType(typeof(EntityMetadata))]
[Uid("999d3bd5-d83f-4d5c-9f00-6d0e5166d0fe")]
[DisplayName(typeof(__Resources_IMyDocumentFolder), "DisplayName")]
[BaseClass("b04c011a-27a4-4fab-8bc6-a1a2ab61a1c3")]
[DisplayFormat("{$Name}")]
[InterfaceImplementation("EleWise.ELMA.Documents.Models.Folders.IHasOwner, EleWise.ELMA.Documents")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>82246bbd-0c28-4a8c-91ec-149d80ae9756</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("MyDocumentFolder")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[ImplementationUid("af117256-0703-4fac-b126-ff823e808d5f")]
[ActionsType(typeof(MyDocumentFolderActions))]
public interface IMyDocumentFolder : IFolder, IDmsObject, IEntity<long>, IEntity, IIdentified, ISoftDeletable, IInheritable, IUserImageSetable, IHasOwner
{
	[Uid("669c96e8-c303-48bc-b840-c59a9eb45f7b")]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
	[EntityUserSettings(FieldName = "Owner")]
	[DisplayName(typeof(__Resources_IMyDocumentFolder), "P_Owner_DisplayName")]
	[EntityProperty]
	new IUser Owner { get; set; }
}
