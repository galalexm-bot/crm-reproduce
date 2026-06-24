using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Documents.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("b04c011a-27a4-4fab-8bc6-a1a2ab61a1c3")]
[DisplayName(typeof(__Resources_IFolder), "DisplayName")]
[BaseClass("e0cfbfd4-f303-4b9a-acaf-11000f0e7ef4")]
[AllowCreateHeirs(true)]
[DisplayFormat("{$Name}")]
[InterfaceImplementation("EleWise.ELMA.Model.Entities.IUserImageSetable")]
[Image(typeof(IFolder), "folder", 16, ImageFormatType.IconPack, false)]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>3868dd49-232e-41ad-b1ba-00a57f57f28b</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("Folder")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[CopyAction(CopyAction.ByRef)]
[ImplementationUid("4b6678a3-4f9a-4d7c-88f3-316ec58a1e4e")]
[ActionsType(typeof(FolderActions))]
public interface IFolder : IDmsObject, IEntity<long>, IEntity, IIdentified, ISoftDeletable, IInheritable, IUserImageSetable
{
	[Uid("854e29a1-a2d6-428c-b8c8-9fee70b98d7f")]
	[NotNull]
	[Property("849c1ac9-4d46-4194-8cbb-43f84adf9c17", "8379a78e-5589-47d4-8746-abf8727e6157")]
	[EnumSettings(FieldName = "FolderType")]
	[DisplayName(typeof(__Resources_IFolder), "P_FolderType_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[EntityProperty]
	FolderType FolderType { get; set; }

	[Uid("03982603-ceb8-4c05-aa00-b6f64dbf60d1")]
	[Order(1)]
	[Property("a3a41ae4-30e2-4c46-bba2-ee55efdc7b90", "07c1ed28-cf39-4c5e-a303-99a045c96558")]
	[EntitySettings(FieldName = "WebDocument")]
	[DisplayName(typeof(__Resources_IFolder), "P_WebDocument_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	IWebDocument WebDocument { get; set; }

	[Uid("68b611cf-a363-42c9-8a86-2994031a433e")]
	[Order(2)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(MaxValueString = "2000", FieldName = "ImageUrl")]
	[StringRangeLength(0, "2000")]
	[DisplayName(typeof(__Resources_IFolder), "P_ImageUrl_DisplayName")]
	[Description(typeof(__Resources_IFolder), "P_ImageUrl_Description")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	new string ImageUrl { get; set; }

	[Uid("5cadf474-d594-4b7b-a0bd-8159f32d111d")]
	[Order(3)]
	[NotNull]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(FieldName = "HasChildFolders")]
	[DisplayName(typeof(__Resources_IFolder), "P_HasChildFolders_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	bool HasChildFolders { get; set; }
}
