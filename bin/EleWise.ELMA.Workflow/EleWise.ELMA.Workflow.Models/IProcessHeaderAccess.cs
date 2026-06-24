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

namespace EleWise.ELMA.Workflow.Models;

[ImplementationUid("82eb48bc-013a-4f08-ab68-a3674091253f")]
[InterfaceImplementation("EleWise.ELMA.Security.Services.IInstanceSettingsPermissionHolder")]
[MetadataType(typeof(EntityMetadata))]
[CustomCode(typeof(IProcessHeaderAccess), "EleWise.ELMA.Workflow.Models.ProcessHeaderAccess.CustomCodeTemplate.cs")]
[Uid("0cb7b882-76c8-4510-8440-61ddd895f048")]
[DisplayFormat(null)]
[DisplayName(typeof(__Resources_IProcessHeaderAccess), "DisplayName")]
[EntityMetadataType(EntityMetadataType.Interface)]
[ShowInCatalogList(false)]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>d8da6fef-2b2f-42ca-8359-2a07a066dcca</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("ProcessHeaderAccess")]
public interface IProcessHeaderAccess : IEntity<long>, IEntity, IIdentified, IInstanceSettingsPermissionHolder
{
	[NotNull]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	[DisplayName(typeof(__Resources_IProcessHeaderAccess), "P_Uid_DisplayName")]
	[Uid("73e6e9ce-bdb8-4187-857b-7ac40d318740")]
	[GuidSettings(FieldName = "Uid")]
	Guid Uid { get; set; }

	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[GuidSettings(FieldName = "PermissionRole")]
	[EntityProperty]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[CanBeNull]
	[Order(1)]
	[Uid("658fbf5e-4b5c-49cd-9321-4269277658a1")]
	[DisplayName(typeof(__Resources_IProcessHeaderAccess), "P_PermissionRole_DisplayName")]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	Guid? PermissionRole { get; set; }

	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "ProcessHeader")]
	[DisplayName(typeof(__Resources_IProcessHeaderAccess), "P_ProcessHeader_DisplayName")]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "da55965d-02a3-4dfd-8b71-d0c45d82c6a5")]
	[EntityProperty]
	[Order(2)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Uid("382880a6-7e86-401e-93e3-689411c85876")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	IProcessHeader ProcessHeader { get; set; }

	[Order(3)]
	[Uid("894ec7d2-f35f-4426-bb9a-8c42623d8808")]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
	[EntityUserSettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "User")]
	[DisplayName(typeof(__Resources_IProcessHeaderAccess), "P_User_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	IUser User { get; set; }

	[EntityProperty]
	[Order(4)]
	[Uid("b0525787-189b-4f0c-879b-e42e1b06f255")]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "72c9994a-cd4e-4746-ac50-5f454b450231")]
	[DisplayName(typeof(__Resources_IProcessHeaderAccess), "P_Group_DisplayName")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "Group")]
	IUserGroup Group { get; set; }

	[OrganizationItemSettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "OrganizationItemPosition")]
	[DisplayName(typeof(__Resources_IProcessHeaderAccess), "P_OrganizationItemPosition_DisplayName")]
	[EntityProperty]
	[Order(5)]
	[Uid("b82e71cc-b0c5-40f3-9177-9da8aa1052e1")]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "e502f586-afd4-4f55-bedb-f71028ffd302")]
	IOrganizationItem OrganizationItemPosition { get; set; }

	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "PermissionId")]
	[RequiredField]
	[Order(6)]
	[NotNull]
	[Required(true)]
	[DisplayName(typeof(__Resources_IProcessHeaderAccess), "P_PermissionId_DisplayName")]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	[Uid("d8d9cf5b-c5d5-4533-8539-01b9176f5c0a")]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[Description(typeof(__Resources_IProcessHeaderAccess), "P_PermissionId_Description")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	new Guid PermissionId { get; set; }

	[DisplayName(typeof(__Resources_IProcessHeaderAccess), "P_OrganizationItem_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "e502f586-afd4-4f55-bedb-f71028ffd302")]
	[OrganizationItemSettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "OrganizationItem")]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	[Uid("151e1804-430d-40aa-b8c0-e0bdaabc872a")]
	[Order(7)]
	IOrganizationItem OrganizationItem { get; set; }
}
