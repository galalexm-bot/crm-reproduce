using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Calendar.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("f250bf68-9f73-449e-8bbd-e3fbad29fe3c")]
[DisplayName(typeof(__Resources_IWorkPlaceCalendar), "DisplayName")]
[BaseClass("ead23410-298c-4814-8069-076f8d5a3153")]
[DisplayFormat(null)]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>229ca507-00ec-4bdd-98a3-3a4f0300aefc</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("WorkPlaceCalendar")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.InterfaceExtension)]
public interface IWorkPlaceCalendar : IWorkPlace, IEntity<long>, IEntity, IIdentified
{
	[Uid("08c126e1-3f55-4369-a0ca-ed205188d60e")]
	[CanBeNull]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(DefaultValueStr = "True", FieldName = "UserPanelCalendar")]
	[DisplayName(typeof(__Resources_IWorkPlaceCalendar), "P_UserPanelCalendar_DisplayName")]
	[Description(typeof(__Resources_IWorkPlaceCalendar), "P_UserPanelCalendar_Description")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	bool? UserPanelCalendar { get; set; }
}
