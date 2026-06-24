using EleWise.ELMA.Content.Transformation;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Content.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("5ce3c5d3-24b4-4d79-9be5-91bf0bb80a22")]
[DisplayName("SR.M('Базовая страница портала')")]
[BaseClass("8b9c66a6-fdf2-4410-a528-9082aa9b0b8e")]
[DisplayFormat(null)]
[InterfaceImplementation("EleWise.ELMA.Content.Transformation.IPageTransformationContainer, EleWise.ELMA.Content")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>ec1ae8bd-c7c7-4bd3-8194-b3aa466e0fd6</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("PageBase")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[ImplementationUid("37c8cc2b-f426-44f1-bce8-9ef72b556a63")]
public interface IPageBase : IPortalObject, IEntity<long>, IEntity, IIdentified, IInheritable, IPageTransformationContainer
{
	[Uid("622df407-33ad-4440-81fb-0c590795b31b")]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(FieldName = "HomePageUsers")]
	[DisplayName("SR.M('HomePageUsers')")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	string HomePageUsers { get; set; }
}
