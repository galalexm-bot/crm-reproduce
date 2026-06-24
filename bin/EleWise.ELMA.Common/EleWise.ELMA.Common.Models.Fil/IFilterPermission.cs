using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Security.Types.Settings;

namespace EleWise.ELMA.Common.Models.Filters;

[MetadataType(typeof(EntityMetadata))]
[Uid("ff7da5f9-8007-41ed-80b1-a58d2426a375")]
[DisplayName(typeof(__Resources_IFilterPermission), "DisplayName")]
[DisplayFormat(null)]
[InterfaceImplementation("EleWise.ELMA.Security.Services.ISecuritySetIdHolder")]
[CustomCode(typeof(IFilterPermission), "EleWise.ELMA.Common.Models.Filters.FilterPermission.CustomCodeTemplate.cs")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>1405baba-6209-4148-839d-766ee5ace829</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("FilterPermission")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[ImplementationUid("0baa73c8-4849-4d21-9357-b31e951a8b5d")]
public interface IFilterPermission : IEntity<long>, IEntity, IIdentified, ISecuritySetIdHolder, IInstanceSettingsPermissionHolder
{
	[Uid("8aa0d329-2aef-4e13-a096-51eccdd4f1f3")]
	[NotNull]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "Uid")]
	[DisplayName(typeof(__Resources_IFilterPermission), "P_Uid_DisplayName")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	Guid Uid { get; set; }

	[Uid("1bbe0d87-7971-4bd1-b778-41be530a16c5")]
	[Order(1)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "4bf10c6c-4fae-4741-b32b-04fa4879a4d6")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "FilterObj")]
	[DisplayName(typeof(__Resources_IFilterPermission), "P_Filter_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	IFilter Filter { get; set; }

	[Uid("19d3357d-100e-4e8b-b959-337dd6bb2982")]
	[Order(2)]
	[NotNull]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "PermissionId")]
	[DisplayName(typeof(__Resources_IFilterPermission), "P_PermissionId_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	new Guid PermissionId { get; set; }

	[Uid("90f0dd02-2218-4e04-8d04-5ccab3b69170")]
	[Order(3)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
	[EntityUserSettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "UserId")]
	[DisplayName(typeof(__Resources_IFilterPermission), "P_User_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	IUser User { get; set; }

	[Uid("3424e4a8-16ca-4b3c-a1ff-15c7a76e809a")]
	[Order(4)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "72c9994a-cd4e-4746-ac50-5f454b450231")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "Group")]
	[DisplayName(typeof(__Resources_IFilterPermission), "P_Group_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	IUserGroup Group { get; set; }

	[Uid("826b74f0-286f-4729-9e62-6d8eee169487")]
	[Order(5)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "e502f586-afd4-4f55-bedb-f71028ffd302")]
	[OrganizationItemSettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "OrganizationItemPosition")]
	[DisplayName(typeof(__Resources_IFilterPermission), "P_OrganizationItemPosition_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	IOrganizationItem OrganizationItemPosition { get; set; }

	[Uid("ea5a36f5-e6cb-4463-a971-522f48491516")]
	[Order(6)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "e502f586-afd4-4f55-bedb-f71028ffd302")]
	[OrganizationItemSettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "OrganizationItemEmployee")]
	[DisplayName(typeof(__Resources_IFilterPermission), "P_OrganizationItemEmployee_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	IOrganizationItem OrganizationItemEmployee { get; set; }

	[Uid("4e20975d-d6d3-4453-b30e-5006da3040d4")]
	[Order(7)]
	[CanBeNull]
	[Property("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
	[Int64Settings(FieldName = "UserSecuritySetCacheId")]
	[DisplayName(typeof(__Resources_IFilterPermission), "P_UserSecuritySetCacheId_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	new long? UserSecuritySetCacheId { get; set; }

	[Uid("3dd19f93-adf3-4d81-ad6e-147859430eda")]
	[Order(8)]
	[CanBeNull]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "PermissionRole")]
	[DisplayName(typeof(__Resources_IFilterPermission), "P_PermissionRole_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	Guid? PermissionRole { get; set; }
}
