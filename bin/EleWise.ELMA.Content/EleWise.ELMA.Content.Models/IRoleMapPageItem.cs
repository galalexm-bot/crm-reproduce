using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Types.Settings;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.Content.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("3ee2f1a3-a8a5-464b-837b-c3edff72164f")]
[DisplayName(typeof(__Resources_IRoleMapPageItem), "DisplayName")]
[DisplayFormat(null)]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>227ccd4f-fd49-465d-9280-3d418edd6bff</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("RoleMapPageItem")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[Filterable]
[ImplementationUid("5fe43dc3-b7cb-4b02-ad56-46530f1c654f")]
[CacheEntity]
[FilterType(typeof(IRoleMapPageItemFilter))]
public interface IRoleMapPageItem : IEntity<long>, IEntity, IIdentified
{
	[Uid("ce455828-768d-49c9-b424-a28b6f015bbe")]
	[NotNull]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "Uid")]
	[DisplayName(typeof(__Resources_IRoleMapPageItem), "P_Uid_DisplayName")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	Guid Uid { get; set; }

	[Uid("00578572-b973-45b5-95d0-3dd5f09f3110")]
	[Order(6)]
	[Required(true)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "07592751-d5d9-40ea-952c-40b773fbbb0e")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "Page")]
	[RequiredField]
	[DisplayName(typeof(__Resources_IRoleMapPageItem), "P_Page_DisplayName")]
	[Description(typeof(__Resources_IRoleMapPageItem), "P_Page_Description")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	IPortletPage Page { get; set; }

	[Uid("17e451d9-07ff-4202-8629-77ec8a1de2d2")]
	[Order(5)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "72c9994a-cd4e-4746-ac50-5f454b450231")]
	[EntitySettings(RelationType = RelationType.ManyToMany, RelationTableName = "M_RoleMapPageItem_UserGroups", ParentColumnName = "Parent", ChildColumnName = "Child", CascadeMode = CascadeMode.SaveUpdate)]
	[DisplayName(typeof(__Resources_IRoleMapPageItem), "P_UserGroups_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	ISet<IUserGroup> UserGroups { get; set; }

	[Uid("b296668a-a1d6-4a1d-bbea-0b97dee237f8")]
	[Order(2)]
	[NotNull]
	[Required(true)]
	[Property("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
	[Int64Settings(DefaultValueStr = "0", FieldName = "Order")]
	[RequiredField]
	[DisplayName(typeof(__Resources_IRoleMapPageItem), "P_Order_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	long Order { get; set; }

	[Uid("80c50169-69ab-486c-b0b5-7685f5d3741f")]
	[Order(4)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "e502f586-afd4-4f55-bedb-f71028ffd302")]
	[OrganizationItemSettings(RelationType = RelationType.ManyToMany, RelationTableName = "M_RMPI_OrganizationItems", ParentColumnName = "Parent", ChildColumnName = "Child", CascadeMode = CascadeMode.SaveUpdate)]
	[DisplayName(typeof(__Resources_IRoleMapPageItem), "P_OrganizationItems_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	ISet<IOrganizationItem> OrganizationItems { get; set; }

	[Uid("5b9ef835-2c82-4845-9a77-0b9f2e5b5415")]
	[Order(3)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
	[EntityUserSettings(RelationType = RelationType.ManyToMany, RelationTableName = "M_RoleMapPageItem_Users", ParentColumnName = "Parent", ChildColumnName = "Child", CascadeMode = CascadeMode.SaveUpdate)]
	[DisplayName(typeof(__Resources_IRoleMapPageItem), "P_Users_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	ISet<IUser> Users { get; set; }

	[Uid("daed6789-a4a3-4a3f-828c-f9f9cdc7957a")]
	[Order(1)]
	[Required(true)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "8d1b6ab1-ca26-4e3f-b38b-4f66442b285c")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "Parent")]
	[RequiredField]
	[DisplayName(typeof(__Resources_IRoleMapPageItem), "P_Parent_DisplayName")]
	[Description(typeof(__Resources_IRoleMapPageItem), "P_Parent_Description")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	IRoleMapPage Parent { get; set; }
}
