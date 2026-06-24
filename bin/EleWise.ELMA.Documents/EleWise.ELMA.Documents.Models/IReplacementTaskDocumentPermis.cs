using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Documents.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("dc1a83cb-c37d-4f43-b1fd-50458af5e2f1")]
[DisplayName(typeof(__Resources_IReplacementTaskDocumentPermission), "DisplayName")]
[BaseClass("c4fbe20f-1114-4198-a307-31b65cc84635")]
[DisplayFormat(null)]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>885210a5-9e15-49b5-ae01-8b4bc748db77</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("ReplacementTaskDocumentPermission")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.InterfaceExtension)]
public interface IReplacementTaskDocumentPermission : IReplacement, IEntity<long>, IEntity, IIdentified, ISoftDeletable
{
	[Uid("569dc6ba-d729-4fd1-a2c8-ba129741b11c")]
	[NotNull]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(FieldName = "TaskDocumentsPermissions")]
	[DisplayName(typeof(__Resources_IReplacementTaskDocumentPermission), "P_TaskDocumentsPermissions_DisplayName")]
	[Description(typeof(__Resources_IReplacementTaskDocumentPermission), "P_TaskDocumentsPermissions_Description")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	bool TaskDocumentsPermissions { get; set; }

	[Uid("9552d5c4-cc46-4632-9522-9818f560bbd6")]
	[Order(1)]
	[NotNull]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(FieldName = "TaskDocumentsManagePermissio")]
	[DisplayName(typeof(__Resources_IReplacementTaskDocumentPermission), "P_TaskDocumentsManagePermissions_DisplayName")]
	[Description(typeof(__Resources_IReplacementTaskDocumentPermission), "P_TaskDocumentsManagePermissions_Description")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	bool TaskDocumentsManagePermissions { get; set; }
}
