using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.Documents.Models.Messages;

[MetadataType(typeof(EntityMetadata))]
[Uid("eac0bf47-2f49-4d7e-8b85-f5ef742e9d54")]
[DisplayName(typeof(__Resources_IChannelMessageDocumentsExtension), "DisplayName")]
[BaseClass("fb88c7e4-586a-40f8-bed6-16b0eeba3a62")]
[DisplayFormat(null)]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>1d1a38db-9d07-4b62-a65e-c156d5b1bd66</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("ChannelMessageDocumentsExtension")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.InterfaceExtension)]
[ActionsType(typeof(ChannelMessageDocumentsExtensionActions))]
public interface IChannelMessageDocumentsExtension : IChannelMessage, IBaseMessage, IEntity<long>, IEntity, IIdentified, IInheritable
{
	[Uid("c26026ac-724d-4de3-8f6d-a338d7eca765")]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "3712c676-4afd-4121-aa1a-4e47ee2e09f8")]
	[EntitySettings(RelationType = RelationType.ManyToMany, RelationTableName = "M_ChannelMsg_DocAttachments", ParentColumnName = "Parent", ChildColumnName = "Child", CascadeMode = CascadeMode.SaveUpdate)]
	[DisplayName(typeof(__Resources_IChannelMessageDocumentsExtension), "P_DocumentAttachments_DisplayName")]
	[PropertyHandler("53df388f-023d-458e-9d1d-2d72945a6226")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	ISet<IDocumentAttachment> DocumentAttachments { get; set; }
}
