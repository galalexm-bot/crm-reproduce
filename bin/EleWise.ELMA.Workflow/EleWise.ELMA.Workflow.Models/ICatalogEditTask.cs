using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Workflow.Models;

[Uid("ba863f73-7633-4869-89fc-51ff159feced")]
[MetadataType(typeof(EntityMetadata))]
[DisplayName(typeof(__Resources_ICatalogEditTask), "DisplayName")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[Entity("CatalogEditTask")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[FilterType(typeof(ICatalogEditTaskFilter))]
[ActionsType(typeof(CatalogEditTaskActions))]
[Filterable]
[ImplementationUid("e894794c-a2b6-406d-827d-50e169016371")]
[DisplayFormat(null)]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>73267dcb-be41-4cf0-977c-5a0d26265b6f</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[BaseClass("0f338330-068c-4135-be4e-95797a209c4e")]
[Image(typeof(ICatalogEditTask), "document_edit", 16, ImageFormatType.IconPack, false)]
public interface ICatalogEditTask : ITaskBase, IEntity<long>, IEntity, IIdentified, IInheritable
{
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	[Property("1f289b26-0607-4bc7-adc0-9ed814c80c90")]
	[ReferenceOnEntitySettings(FieldName = "ObjectType")]
	[DisplayName(typeof(__Resources_ICatalogEditTask), "P_ObjectType_DisplayName")]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[Uid("46ea3234-41b6-4149-ad5c-4d23cc17f321")]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	ReferenceOnEntity ObjectType { get; set; }
}
