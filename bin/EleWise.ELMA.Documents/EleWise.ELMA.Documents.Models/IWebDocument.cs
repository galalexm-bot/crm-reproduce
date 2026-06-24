using EleWise.ELMA.Documents.CodeGeneration;
using EleWise.ELMA.Documents.Metadata;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Documents.Models;

[MetadataType(typeof(DocumentMetadata))]
[Uid("07c1ed28-cf39-4c5e-a303-99a045c96558")]
[DisplayName(typeof(__Resources_IWebDocument), "DisplayName")]
[BaseClass("2b660715-d111-4cc6-acfd-965661719fba")]
[AllowCreateHeirs(true)]
[DisplayFormat(null)]
[Image(typeof(IWebDocument), "webdoc", 16, ImageFormatType.IconPack, false)]
[ClassFormsScheme(ClassFormsScheme.FormConstructor)]
[FormTransformation(typeof(IWebDocument), "EleWise.ELMA.Documents.Models.WebDocument.Form.Edit.xml")]
[FormTransformation(typeof(IWebDocument), "EleWise.ELMA.Documents.Models.WebDocument.Form.Display.xml")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>0383f436-0b90-42e1-8b8c-f9fd0f45c061</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("WebDocument")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[Filterable]
[ImplementationUid("f6ce14b6-0158-459a-9530-ff8423e42b9e")]
[FilterType(typeof(IWebDocumentFilter))]
[ActionsType(typeof(WebDocumentActions))]
[DisableCreate(false)]
[ControlOnSendingValue(false)]
[IsAllowRename(true)]
[TemplateName("Новый веб-документ {$Document.CreationDate}")]
[MultipleRegistration(false)]
[UploadButton(true)]
[ScanButton(true)]
[TemplateButton(true)]
[NeedAnswer(false)]
[AnswerDocumentProperty("00000000-0000-0000-0000-000000000000")]
[DefaultManager(typeof(DocumentManagerMaker))]
[EnableCrypto(false)]
[UseLifeCycle(false)]
[CryptoSettings(CryptoEntityTypeUidStr = "712c3047-68d0-4d57-9122-1bf10a586e24", CryptoAttributesStr = "", CryptoTableName = null)]
public interface IWebDocument : IDocument, IDmsObject, IEntity<long>, IEntity, IIdentified, ISoftDeletable, IInheritable
{
}
