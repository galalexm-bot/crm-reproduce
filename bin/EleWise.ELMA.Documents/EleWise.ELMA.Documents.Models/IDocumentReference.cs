using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Documents.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("07530c60-5991-43fc-9827-3d0904200080")]
[DisplayName(typeof(__Resources_IDocumentReference), "DisplayName")]
[BaseClass("3829078c-939a-4b05-8d44-b047ed848560")]
[AllowCreateHeirs(true)]
[DisplayFormat(null)]
[Image(typeof(IDocumentReference), "document_link", 16, ImageFormatType.IconPack, false)]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>32fc8653-9f58-41be-a95d-28804fa0d001</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("DocumentReference")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[ImplementationUid("c4b941bc-e887-401e-b977-bbcfe3bbfb1d")]
[ActionsType(typeof(DocumentReferenceActions))]
public interface IDocumentReference : IReference, IDmsObject, IEntity<long>, IEntity, IIdentified, ISoftDeletable, IInheritable
{
	[Uid("af122d86-7103-4eff-b76d-c79367267e2c")]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "2b660715-d111-4cc6-acfd-965661719fba")]
	[EntitySettings(FieldName = "Reference")]
	[DisplayName(typeof(__Resources_IDocumentReference), "P_Reference_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	IDocument Reference { get; set; }
}
