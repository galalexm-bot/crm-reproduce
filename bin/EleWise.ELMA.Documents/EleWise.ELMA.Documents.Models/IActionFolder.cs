using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Documents.Models.Folders;

[MetadataType(typeof(EntityMetadata))]
[Uid("7e649aad-fb62-44bf-8c01-0d28303b922a")]
[DisplayName(typeof(__Resources_IActionFolder), "DisplayName")]
[BaseClass("b04c011a-27a4-4fab-8bc6-a1a2ab61a1c3")]
[DisplayFormat(null)]
[Image(typeof(IActionFolder), "folder_action", 16, ImageFormatType.IconPack, false)]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>f03093a6-21f5-42f4-a14a-671e337aeaae</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("ActionFolder")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[Filterable]
[ImplementationUid("9435b62f-6738-49fd-b5cd-a1c178ae21f8")]
[FilterType(typeof(IActionFolderFilter))]
[ActionsType(typeof(ActionFolderActions))]
public interface IActionFolder : IFolder, IDmsObject, IEntity<long>, IEntity, IIdentified, ISoftDeletable, IInheritable, IUserImageSetable
{
	[Uid("524d8132-476a-43f3-9a11-bcd58974928b")]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(MultiLine = true, FieldName = "Description")]
	[DisplayName(typeof(__Resources_IActionFolder), "P_Description_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	string Description { get; set; }

	[Uid("44b5351e-3b96-42a6-8580-d02064dfb6da")]
	[Order(1)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(FieldName = "ActionTypeProviderId")]
	[DisplayName(typeof(__Resources_IActionFolder), "P_ActionTypeProviderId_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	string ActionTypeProviderId { get; set; }

	[Uid("353ad68d-0d4a-49d7-bdff-5eff2e702f29")]
	[Order(2)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(FieldName = "ActionId")]
	[DisplayName(typeof(__Resources_IActionFolder), "P_ActionId_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	string ActionId { get; set; }
}
