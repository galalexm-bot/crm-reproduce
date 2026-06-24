using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.CRM.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("a30de29b-d686-4998-b419-e8b8724425fb")]
[DisplayName("SR.M('Письмо')")]
[BaseClass("ef96d819-d015-4516-b39e-0a8a3c4e337d")]
[DisplayFormat(null)]
[Image(typeof(IRelationshipMail), "message_outline", 24, ImageFormatType.IconPack, false)]
[CustomCode(typeof(IRelationshipMail), "EleWise.ELMA.CRM.Models.RelationshipMail.CustomCodeTemplate.cs")]
[ClassFormsScheme(ClassFormsScheme.FormConstructor)]
[Form(typeof(IRelationshipMail), "EleWise.ELMA.CRM.Models.RelationshipMail.Form.LeadConverterForm.xml")]
[FormTransformation(typeof(IRelationshipMail), "EleWise.ELMA.CRM.Models.RelationshipMail.Form.BaseView.xml")]
[FormTransformation(typeof(IRelationshipMail), "EleWise.ELMA.CRM.Models.RelationshipMail.Form.BaseEdit.xml")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>8b4ea79f-4445-48ff-b736-b3f2c0570553</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("RelationshipMail")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[SaveHistory]
[ImplementationUid("bed7fd63-a906-44ea-929a-2b085c8edfc9")]
[ActionsType(typeof(RelationshipMailActions))]
public interface IRelationshipMail : IRelationship, IEntity<long>, IEntity, IIdentified, ISoftDeletable, IInheritable
{
}
