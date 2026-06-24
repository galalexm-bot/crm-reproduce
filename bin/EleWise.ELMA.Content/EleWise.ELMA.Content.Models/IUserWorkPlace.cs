using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Content.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("cd889588-1e2a-44f2-8355-139250161405")]
[DisplayName("SR.M('UserWorkPlace')")]
[BaseClass("cfdeb03c-35e9-45e7-aad8-037d83888f73")]
[DisplayFormat(null)]
[TableView("\ufeff<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>c0c5626e-b376-41ab-af1f-463e11610733</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("UserWorkPlace")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.InterfaceExtension)]
[SaveHistory]
[ActionsType(typeof(UserWorkPlaceActions))]
public interface IUserWorkPlace : EleWise.ELMA.Security.Models.IUser, IEntity<long>, IEntity, IIdentified, EleWise.ELMA.Security.IUser
{
	[Uid("491779d0-4bbc-4361-ba97-1ad966019f33")]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "ead23410-298c-4814-8069-076f8d5a3153")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "WorkPlace")]
	[DisplayName("SR.M('Интерфейс')")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	IWorkPlace WorkPlace { get; set; }

	[Uid("2faa6d95-cb7b-4391-9fc2-a187ccd8c997")]
	[Order(1)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "15fcdf05-bcf6-4d38-97cb-51c8086f7bc0")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "ColorScheme")]
	[DisplayName("SR.M('Цветовая схема')")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	IColorScheme ColorScheme { get; set; }
}
