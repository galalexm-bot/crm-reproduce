using EleWise.ELMA.Documents.Types;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Documents.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("a969bb26-47e5-4b53-8d83-5a2b50919108")]
[DisplayName(typeof(__Resources_IFolderReference), "DisplayName")]
[BaseClass("3829078c-939a-4b05-8d44-b047ed848560")]
[DisplayFormat(null)]
[Image(typeof(IFolderReference), "folder_link", 16, ImageFormatType.IconPack, false)]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>025c9fcb-bf36-49cb-93b7-2dc7f500dc70</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("FolderReference")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[ImplementationUid("f6dfaf3f-875f-4d12-9bd0-acad40f4cbaa")]
[ActionsType(typeof(FolderReferenceActions))]
public interface IFolderReference : IReference, IDmsObject, IEntity<long>, IEntity, IIdentified, ISoftDeletable, IInheritable
{
	[Uid("cc7d2488-4704-482a-8b79-6b2fb1a8ead1")]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "b04c011a-27a4-4fab-8bc6-a1a2ab61a1c3")]
	[DocumentFolderSettings(SerializedInfos = "", FieldName = "Reference")]
	[DisplayName(typeof(__Resources_IFolderReference), "P_Reference_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	IFolder Reference { get; set; }
}
