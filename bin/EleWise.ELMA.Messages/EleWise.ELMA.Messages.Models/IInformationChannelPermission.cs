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

namespace EleWise.ELMA.Messages.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("63187d69-5c67-4141-aeee-7be9fa6f8290")]
[DisplayName(typeof(__Resources_IInformationChannelPermission), "DisplayName")]
[DisplayFormat(null)]
[InterfaceImplementation("EleWise.ELMA.Security.Services.ISecuritySetIdHolder")]
[CustomCode(typeof(IInformationChannelPermission), "EleWise.ELMA.Messages.Models.InformationChannelPermission.CustomCodeTemplate.cs")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>ba6d4603-480e-482c-9ed3-1ba188a10c0b</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("InformationChannelPermission")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[ImplementationUid("9b9203d0-3e66-4977-bf77-badf9183bb7b")]
public interface IInformationChannelPermission : IEntity<long>, IEntity, IIdentified, ISecuritySetIdHolder, IInstanceSettingsPermissionHolder
{
	[Uid("11a80319-3873-489b-a6cf-02e4f6a4c721")]
	[NotNull]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "Uid")]
	[DisplayName(typeof(__Resources_IInformationChannelPermission), "P_Uid_DisplayName")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	Guid Uid { get; set; }

	[Uid("46b330e0-db5b-4f8e-978d-3061838762cc")]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "d5252826-304f-482c-a767-2b2475adc587")]
	[EntitySettings(FieldName = "Channel")]
	[DisplayName(typeof(__Resources_IInformationChannelPermission), "P_Channel_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	IInformationChannel Channel { get; set; }

	[Uid("d203a298-5a46-47d6-ac53-812ea88cc073")]
	[Order(1)]
	[NotNull]
	[Required(true)]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "PermissionId")]
	[RequiredField]
	[DisplayName(typeof(__Resources_IInformationChannelPermission), "P_PermissionId_DisplayName")]
	[EntityProperty]
	new Guid PermissionId { get; set; }

	[Uid("691c027e-ea1b-40e4-9026-a9366f4a2fcc")]
	[Order(2)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
	[EntityUserSettings(FieldName = "User")]
	[DisplayName(typeof(__Resources_IInformationChannelPermission), "P_User_DisplayName")]
	[EntityProperty]
	IUser User { get; set; }

	[Uid("426a9779-32b6-4e2d-bc6c-77f91f7889f6")]
	[Order(3)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "72c9994a-cd4e-4746-ac50-5f454b450231")]
	[EntitySettings(FieldName = "Group")]
	[DisplayName(typeof(__Resources_IInformationChannelPermission), "P_Group_DisplayName")]
	[EntityProperty]
	IUserGroup Group { get; set; }

	[Uid("7f8b18ed-ec69-477d-8b8f-c9b5c03669f0")]
	[Order(4)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "e502f586-afd4-4f55-bedb-f71028ffd302")]
	[OrganizationItemSettings(FieldName = "OrganizationItemPosition")]
	[DisplayName(typeof(__Resources_IInformationChannelPermission), "P_OrganizationItemPosition_DisplayName")]
	[EntityProperty]
	IOrganizationItem OrganizationItemPosition { get; set; }

	[Uid("c5655697-ff30-4048-b8b6-39487f4baf2b")]
	[Order(5)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "e502f586-afd4-4f55-bedb-f71028ffd302")]
	[OrganizationItemSettings(FieldName = "OrganizationItem")]
	[DisplayName(typeof(__Resources_IInformationChannelPermission), "P_OrganizationItem_DisplayName")]
	[EntityProperty]
	IOrganizationItem OrganizationItem { get; set; }

	[Uid("d916c2da-5622-4d79-948d-633cffe809b8")]
	[Order(6)]
	[CanBeNull]
	[Property("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
	[Int64Settings(DefaultValueStr = "0", FieldName = "UserSecuritySetCacheId")]
	[DisplayName(typeof(__Resources_IInformationChannelPermission), "P_UserSecuritySetCacheId_DisplayName")]
	[EntityProperty]
	new long? UserSecuritySetCacheId { get; set; }

	[Uid("4aa2fe6e-8279-48eb-aca9-2df4614308eb")]
	[Order(7)]
	[CanBeNull]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "PermissionRole")]
	[DisplayName(typeof(__Resources_IInformationChannelPermission), "P_PermissionRole_DisplayName")]
	[EntityProperty]
	Guid? PermissionRole { get; set; }
}
