using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.Documents.Models.Calendar;

[MetadataType(typeof(EntityMetadata))]
[Uid("36a2ca5c-8304-4614-a3ef-6a74834aa6cb")]
[DisplayName(typeof(__Resources_IDocumentCalendarEvent), "DisplayName")]
[BaseClass("6fb5a4a7-8b40-4b17-a2ae-3fdd0b04945c")]
[DisplayFormat(null)]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>4ac4ce25-bcd5-4748-b772-b9379d893dc9</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("DocumentCalendarEvent")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.InterfaceExtension)]
[ActionsType(typeof(DocumentCalendarEventActions))]
public interface IDocumentCalendarEvent : ICalendarEvent, IEntity<long>, IEntity, IIdentified, IInheritable
{
	[Uid("dcea12e2-5eca-4ba4-9185-f267cdfa456f")]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "3712c676-4afd-4121-aa1a-4e47ee2e09f8")]
	[EntitySettings(RelationType = RelationType.ManyToMany, RelationTableName = "M_Event_DocumentAttachments", ParentColumnName = "EventId", ChildColumnName = "DocumentAttachmentId", CascadeMode = CascadeMode.All)]
	[DisplayName(typeof(__Resources_IDocumentCalendarEvent), "P_DocumentAttachments_DisplayName")]
	[PropertyHandler("53df388f-023d-458e-9d1d-2d72945a6226")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	ISet<IDocumentAttachment> DocumentAttachments { get; set; }
}
