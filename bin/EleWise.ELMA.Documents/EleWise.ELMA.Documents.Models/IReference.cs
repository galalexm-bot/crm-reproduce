using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Documents.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("3829078c-939a-4b05-8d44-b047ed848560")]
[DisplayName(typeof(__Resources_IReference), "DisplayName")]
[Description(typeof(__Resources_IReference), "Description")]
[BaseClass("e0cfbfd4-f303-4b9a-acaf-11000f0e7ef4")]
[AllowCreateHeirs(true)]
[DisplayFormat(null)]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>4f0d0e04-196c-4e6d-a0b5-c0129cfdaee2</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("Reference")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[ImplementationUid("5edee8e1-87ae-4e70-be4e-3c10b3c4accd")]
[ActionsType(typeof(ReferenceActions))]
public interface IReference : IDmsObject, IEntity<long>, IEntity, IIdentified, ISoftDeletable, IInheritable
{
	[Uid("0a97290e-481a-4bd6-9e58-fdeaf84f0d82")]
	[NotNull]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(DefaultValueStr = "True", FieldName = "UseSourceName")]
	[DisplayName(typeof(__Resources_IReference), "P_UseSourceName_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	bool UseSourceName { get; set; }
}
