using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Messages.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("0ed1ea8d-b62a-4953-b5c0-dfcbb4c93cda")]
[DisplayName(typeof(__Resources_IWorkPlaceMessages), "DisplayName")]
[BaseClass("ead23410-298c-4814-8069-076f8d5a3153")]
[DisplayFormat(null)]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>0798f6d4-d0f5-475b-8324-21780d5be835</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("WorkPlaceMessages")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.InterfaceExtension)]
public interface IWorkPlaceMessages : IWorkPlace, IEntity<long>, IEntity, IIdentified
{
	[Uid("64c6df57-f077-4fad-a715-ae5cffa2c3c9")]
	[CanBeNull]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(DefaultValueStr = "True", FieldName = "UserPanelMessages")]
	[DisplayName(typeof(__Resources_IWorkPlaceMessages), "P_UserPanelMessages_DisplayName")]
	[Description(typeof(__Resources_IWorkPlaceMessages), "P_UserPanelMessages_Description")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	bool? UserPanelMessages { get; set; }
}
