using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Security.Types.Settings;

namespace EleWise.ELMA.Content.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("426e67d5-5b15-4770-b4e4-11c610973e11")]
[DisplayName(typeof(__Resources_IPortalObjectPermission), "DisplayName")]
[DisplayFormat(null)]
[InterfaceImplementation("EleWise.ELMA.Security.Services.ISecuritySetIdHolder")]
[CustomCode(typeof(IPortalObjectPermission), "EleWise.ELMA.Content.Models.PortalObjectPermissions.CustomCodeTemplate.cs")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>e2bab497-20c4-445c-8992-f9f1417d8e5c</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("PortalObjectPermission")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[ImplementationUid("4e6e03d5-3d47-4bdb-8774-4761bd23e801")]
public interface IPortalObjectPermission : IEntity<long>, IEntity, IIdentified, ISecuritySetIdHolder, IInstanceSettingsPermissionHolder
{
	[Uid("ef717195-db6c-4caa-836a-21903450139c")]
	[NotNull]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "Uid")]
	[DisplayName(typeof(__Resources_IPortalObjectPermission), "P_Uid_DisplayName")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	Guid Uid { get; set; }

	[Uid("2119f360-7ba2-469d-920a-569b7a05d93c")]
	[Order(1)]
	[Required(true)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "8b9c66a6-fdf2-4410-a528-9082aa9b0b8e")]
	[EntitySettings(FieldName = "PortalObject")]
	[RequiredField]
	[DisplayName(typeof(__Resources_IPortalObjectPermission), "P_PortalObject_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	IPortalObject PortalObject { get; set; }

	[Uid("5b044158-da3b-4210-bfd9-6aa58ac150f8")]
	[Order(2)]
	[NotNull]
	[Required(true)]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "PermissionId")]
	[RequiredField]
	[DisplayName(typeof(__Resources_IPortalObjectPermission), "P_PermissionId_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	new Guid PermissionId { get; set; }

	[Uid("0ba9bbad-fb4f-4d0b-89ef-45b746da532e")]
	[Order(3)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
	[EntityUserSettings(FieldName = "User")]
	[DisplayName(typeof(__Resources_IPortalObjectPermission), "P_User_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	IUser User { get; set; }

	[Uid("1743f51b-a3c6-4862-a43f-3dc96a2cc03a")]
	[Order(4)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "72c9994a-cd4e-4746-ac50-5f454b450231")]
	[EntitySettings(FieldName = "Group")]
	[DisplayName(typeof(__Resources_IPortalObjectPermission), "P_Group_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	IUserGroup Group { get; set; }

	[Uid("fffd78eb-fb08-400b-93de-c2601f0a8a6a")]
	[Order(5)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "e502f586-afd4-4f55-bedb-f71028ffd302")]
	[OrganizationItemSettings(FieldName = "OrganizationItemPosition")]
	[DisplayName(typeof(__Resources_IPortalObjectPermission), "P_OrganizationItemPosition_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	IOrganizationItem OrganizationItemPosition { get; set; }

	[Uid("3d961b8e-74a2-4a8d-9766-0c466d5b1de9")]
	[Order(6)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "e502f586-afd4-4f55-bedb-f71028ffd302")]
	[OrganizationItemSettings(FieldName = "OrganizationItemEmployee")]
	[DisplayName(typeof(__Resources_IPortalObjectPermission), "P_OrganizationItemEmployee_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	IOrganizationItem OrganizationItemEmployee { get; set; }

	[Uid("4ffc2531-6cd7-47b4-ac2e-900c3bdc5abf")]
	[Order(7)]
	[CanBeNull]
	[Property("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
	[Int64Settings(FieldName = "UserSecuritySetCacheId")]
	[DisplayName(typeof(__Resources_IPortalObjectPermission), "P_UserSecuritySetCacheId_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	new long? UserSecuritySetCacheId { get; set; }

	[Uid("3d83d8f4-e3db-49ce-94ba-f0b39524358c")]
	[Order(8)]
	[CanBeNull]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "PermissionRole")]
	[DisplayName(typeof(__Resources_IPortalObjectPermission), "P_PermissionRole_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	Guid? PermissionRole { get; set; }

	[Uid("bbf53f18-a825-46b1-a909-48ee28677d91")]
	[Order(9)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "707b01d4-4fad-4ee5-bf4f-a299cd8a143c")]
	[EntitySettings(FieldName = "InheritedFromFolder")]
	[DisplayName(typeof(__Resources_IPortalObjectPermission), "P_InheritedFromFolder_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	IPageFolder InheritedFromFolder { get; set; }
}
