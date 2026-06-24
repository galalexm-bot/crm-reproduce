using EleWise.ELMA.Content.Transformation;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.Content.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("8d1b6ab1-ca26-4e3f-b38b-4f66442b285c")]
[DisplayName(typeof(__Resources_IRoleMapPage), "DisplayName")]
[BaseClass("5ce3c5d3-24b4-4d79-9be5-91bf0bb80a22")]
[DisplayFormat(null)]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>4ae70637-a815-4d8a-a3aa-f5b39a28fc8f</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("RoleMapPage")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[Filterable]
[ImplementationUid("63b27e07-f2ff-4709-9784-f711945c61aa")]
[CacheEntity]
[FilterType(typeof(IRoleMapPageFilter))]
public interface IRoleMapPage : IPageBase, IPortalObject, IEntity<long>, IEntity, IIdentified, IInheritable, IPageTransformationContainer
{
	[Uid("be0d57b1-b8b4-48a8-aa50-c2e0e0d6653d")]
	[Order(1)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "3ee2f1a3-a8a5-464b-837b-c3edff72164f")]
	[EntitySettings(RelationType = RelationType.OneToMany, KeyColumnUidStr = "daed6789-a4a3-4a3f-828c-f9f9cdc7957a", CascadeMode = CascadeMode.AllDeleteOrphan, CopyAction = CopyAction.Clone)]
	[DisplayName(typeof(__Resources_IRoleMapPage), "P_MapItems_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[EntityProperty]
	ISet<IRoleMapPageItem> MapItems { get; set; }

	[Uid("afff9f81-7003-483e-95e3-054e254252c9")]
	[Required(true)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "07592751-d5d9-40ea-952c-40b773fbbb0e")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "DefaultMapPage")]
	[RequiredField]
	[DisplayName(typeof(__Resources_IRoleMapPage), "P_DefaultMapPage_DisplayName")]
	[Description(typeof(__Resources_IRoleMapPage), "P_DefaultMapPage_Description")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	IPortletPage DefaultMapPage { get; set; }
}
