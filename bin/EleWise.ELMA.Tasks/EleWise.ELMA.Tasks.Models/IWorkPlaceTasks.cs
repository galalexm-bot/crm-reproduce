using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Tasks.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("8a4185fb-a82e-46c0-9893-8c8b72af0f01")]
[DisplayName(typeof(__Resources_IWorkPlaceTasks), "DisplayName")]
[BaseClass("ead23410-298c-4814-8069-076f8d5a3153")]
[DisplayFormat(null)]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>12cbbf2c-167e-4632-898f-213c9b333a5a</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("WorkPlaceTasks")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.InterfaceExtension)]
public interface IWorkPlaceTasks : IWorkPlace, IEntity<long>, IEntity, IIdentified
{
	[Uid("d0af48e4-18b8-4a53-b3b0-abaa6cdfa18c")]
	[CanBeNull]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(DefaultValueStr = "True", FieldName = "UserPanelTasks")]
	[DisplayName(typeof(__Resources_IWorkPlaceTasks), "P_UserPanelTasks_DisplayName")]
	[Description(typeof(__Resources_IWorkPlaceTasks), "P_UserPanelTasks_Description")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	bool? UserPanelTasks { get; set; }

	[Uid("4fc7db98-6af6-450a-a40a-931345cbd084")]
	[Order(1)]
	[CanBeNull]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(DefaultValueStr = "True", FieldName = "UserPanelCoExecution")]
	[DisplayName(typeof(__Resources_IWorkPlaceTasks), "P_UserPanelCoExecution_DisplayName")]
	[Description(typeof(__Resources_IWorkPlaceTasks), "P_UserPanelCoExecution_Description")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	bool? UserPanelCoExecution { get; set; }
}
