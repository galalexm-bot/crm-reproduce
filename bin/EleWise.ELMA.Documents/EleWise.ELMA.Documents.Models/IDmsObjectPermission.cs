using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Types;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Security.Types.Settings;

namespace EleWise.ELMA.Documents.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("84dce77f-08d3-49ff-a5b7-102b171dc054")]
[DisplayName(typeof(__Resources_IDmsObjectPermission), "DisplayName")]
[DisplayFormat(null)]
[InterfaceImplementation("EleWise.ELMA.Security.Services.ISecuritySetIdHolder")]
[CustomCode(typeof(IDmsObjectPermission), "EleWise.ELMA.Documents.Models.DmsObjectPermissions.CustomCodeTemplate.cs")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>fa119423-b557-40c8-b8d6-325fe62727e9</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("DmsObjectPermission")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[ImplementationUid("96852bd2-3bb0-4c78-ac77-91b571ed9fa1")]
public interface IDmsObjectPermission : IEntity<long>, IEntity, IIdentified, ISecuritySetIdHolder, IInstanceSettingsPermissionHolder
{
	[Uid("07a60982-39cb-4223-ac37-37ff38e7ce00")]
	[NotNull]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "Uid")]
	[DisplayName(typeof(__Resources_IDmsObjectPermission), "P_Uid_DisplayName")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	Guid Uid { get; set; }

	[Uid("dab9f01e-a8be-4c1c-a99a-a43406e1f2b5")]
	[Order(1)]
	[Required(true)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "e0cfbfd4-f303-4b9a-acaf-11000f0e7ef4")]
	[EntitySettings(FieldName = "DmsObject")]
	[RequiredField]
	[DisplayName(typeof(__Resources_IDmsObjectPermission), "P_DmsObject_DisplayName")]
	[EntityProperty]
	IDmsObject DmsObject { get; set; }

	[Uid("1b2b0ca6-96aa-47d6-b588-97c32f3a3400")]
	[Order(2)]
	[NotNull]
	[Required(true)]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "PermissionId")]
	[RequiredField]
	[DisplayName(typeof(__Resources_IDmsObjectPermission), "P_PermissionId_DisplayName")]
	[EntityProperty]
	new Guid PermissionId { get; set; }

	[Uid("4580a852-28a5-434b-9b07-fa5d00bb5827")]
	[Order(3)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
	[EntityUserSettings(FieldName = "User")]
	[DisplayName(typeof(__Resources_IDmsObjectPermission), "P_User_DisplayName")]
	[EntityProperty]
	IUser User { get; set; }

	[Uid("88d315a7-ce52-4a5b-a52d-ee9cbb844040")]
	[Order(4)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "72c9994a-cd4e-4746-ac50-5f454b450231")]
	[EntitySettings(FieldName = "Group")]
	[DisplayName(typeof(__Resources_IDmsObjectPermission), "P_Group_DisplayName")]
	[EntityProperty]
	IUserGroup Group { get; set; }

	[Uid("be0ac153-ce1b-4c66-a625-2eeee9f0fe1e")]
	[Order(5)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "e502f586-afd4-4f55-bedb-f71028ffd302")]
	[OrganizationItemSettings(FieldName = "OrganizationItemPosition")]
	[DisplayName(typeof(__Resources_IDmsObjectPermission), "P_OrganizationItemPosition_DisplayName")]
	[EntityProperty]
	IOrganizationItem OrganizationItemPosition { get; set; }

	[Uid("53876ad2-34d8-4749-98da-13d1e34edcb2")]
	[Order(6)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "e502f586-afd4-4f55-bedb-f71028ffd302")]
	[OrganizationItemSettings(FieldName = "OrganizationItemEmployee")]
	[DisplayName(typeof(__Resources_IDmsObjectPermission), "P_OrganizationItemEmployee_DisplayName")]
	[EntityProperty]
	IOrganizationItem OrganizationItemEmployee { get; set; }

	[Uid("22070c4e-60ca-41b8-bace-99790d290915")]
	[Order(7)]
	[CanBeNull]
	[Property("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
	[Int64Settings(DefaultValueStr = "0", FieldName = "UserSecuritySetCacheId")]
	[DisplayName(typeof(__Resources_IDmsObjectPermission), "P_UserSecuritySetCacheId_DisplayName")]
	[EntityProperty]
	new long? UserSecuritySetCacheId { get; set; }

	[Uid("34480f69-6a32-4186-a999-bc454a9ae059")]
	[Order(8)]
	[CanBeNull]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "PermissionRole")]
	[DisplayName(typeof(__Resources_IDmsObjectPermission), "P_PermissionRole_DisplayName")]
	[EntityProperty]
	Guid? PermissionRole { get; set; }

	[Uid("ccf92e5c-c4d9-486f-a1db-8d1ed1af9d11")]
	[Order(9)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "b04c011a-27a4-4fab-8bc6-a1a2ab61a1c3")]
	[DocumentFolderSettings(SerializedInfos = "", FieldName = "InheritedFromFolder")]
	[DisplayName(typeof(__Resources_IDmsObjectPermission), "P_InheritedFromFolder_DisplayName")]
	[Description(typeof(__Resources_IDmsObjectPermission), "P_InheritedFromFolder_Description")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	IFolder InheritedFromFolder { get; set; }
}
