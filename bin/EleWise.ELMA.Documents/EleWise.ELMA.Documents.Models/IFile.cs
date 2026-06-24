using EleWise.ELMA.Documents.CodeGeneration;
using EleWise.ELMA.Documents.Metadata;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Documents.Models;

[MetadataType(typeof(DocumentMetadata))]
[Uid("7f8a792f-1123-48b9-985f-8cad74803a35")]
[DisplayName(typeof(__Resources_IFile), "DisplayName")]
[BaseClass("2b660715-d111-4cc6-acfd-965661719fba")]
[AllowCreateHeirs(true)]
[DisplayFormat("{$Name}")]
[Image(typeof(IFile), "file", 16, ImageFormatType.IconPack, false)]
[ClassFormsScheme(ClassFormsScheme.FormConstructor)]
[FormTransformation(typeof(IFile), "EleWise.ELMA.Documents.Models.File.Form.Display.xml")]
[FormView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<FormView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>00000000-0000-0000-0000-000000000000</Uid>\r\n  <ViewType>Display</ViewType>\r\n  <CanUseCommonView>true</CanUseCommonView>\r\n  <CanUseCommonRazorView>true</CanUseCommonRazorView>\r\n  <CanUseTabView>true</CanUseTabView>\r\n  <CanUseTabRazorView>true</CanUseTabRazorView>\r\n  <ViewInCommon>true</ViewInCommon>\r\n</FormView>")]
[FormView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<FormView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>00000000-0000-0000-0000-000000000000</Uid>\r\n  <ViewType>Create</ViewType>\r\n  <CanUseCommonView>true</CanUseCommonView>\r\n  <CanUseCommonRazorView>true</CanUseCommonRazorView>\r\n  <ViewInCommon>true</ViewInCommon>\r\n</FormView>")]
[FormView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<FormView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>00000000-0000-0000-0000-000000000000</Uid>\r\n  <ViewType>Edit</ViewType>\r\n  <CanUseCommonView>true</CanUseCommonView>\r\n  <CanUseCommonRazorView>true</CanUseCommonRazorView>\r\n  <ViewInCommon>true</ViewInCommon>\r\n</FormView>")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>0ccbb55e-3034-4381-9c5d-1d19c86d4d8f</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("File")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[Filterable]
[ImplementationUid("ff9b2cc5-861b-4991-abaa-2aa1141a7566")]
[FilterType(typeof(IFileFilter))]
[ActionsType(typeof(FileActions))]
[DisableCreate(false)]
[ControlOnSendingValue(false)]
[IsAllowRename(true)]
[TemplateName("{$FileName}")]
[MultipleRegistration(false)]
[UploadButton(true)]
[ScanButton(true)]
[TemplateButton(true)]
[NeedAnswer(false)]
[AnswerDocumentProperty("00000000-0000-0000-0000-000000000000")]
[DefaultManager(typeof(DocumentManagerMaker))]
[EnableCrypto(false)]
[UseLifeCycle(false)]
[CryptoSettings(CryptoEntityTypeUidStr = "3b5eec9c-4226-455f-8dd5-b8d0c4ea1985", CryptoAttributesStr = "", CryptoTableName = null)]
public interface IFile : IDocument, IDmsObject, IEntity<long>, IEntity, IIdentified, ISoftDeletable, IInheritable
{
}
