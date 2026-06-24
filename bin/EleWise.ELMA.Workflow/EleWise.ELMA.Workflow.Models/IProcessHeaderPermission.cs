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

namespace EleWise.ELMA.Workflow.Models;

[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>f602c47c-7b88-4f6e-a5a8-cd52accaf5c1</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("ProcessHeaderPermission")]
[ImplementationUid("20ae1004-68fb-4522-ac9c-561a4c510f51")]
[EntityMetadataType(EntityMetadataType.Interface)]
[ShowInCatalogList(false)]
[DisplayFormat(null)]
[MetadataType(typeof(EntityMetadata))]
[Uid("b8facc2f-e3f3-46d2-b9e1-e9fdb69cc5f6")]
[DisplayName(typeof(__Resources_IProcessHeaderPermission), "DisplayName")]
public interface IProcessHeaderPermission : IEntity<long>, IEntity, IIdentified
{
	[EntityProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[GuidSettings(FieldName = "Uid")]
	[Uid("a09e033b-4d5c-4420-9291-1137a951c9ed")]
	[DisplayName(typeof(__Resources_IProcessHeaderPermission), "P_Uid_DisplayName")]
	[NotNull]
	[SystemProperty]
	Guid Uid { get; set; }

	[GuidSettings(FieldName = "PermissionRole")]
	[Uid("25dbc6db-ce78-40d0-9dc8-392c606beb11")]
	[DisplayName(typeof(__Resources_IProcessHeaderPermission), "P_PermissionRole_DisplayName")]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[CanBeNull]
	[EntityProperty]
	Guid? PermissionRole { get; set; }

	[Order(1)]
	[DisplayName(typeof(__Resources_IProcessHeaderPermission), "P_ProcessHeader_DisplayName")]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "da55965d-02a3-4dfd-8b71-d0c45d82c6a5")]
	[EntityProperty]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "ProcessHeader")]
	[Uid("95444346-7a7d-4c8c-89d7-537cc7623075")]
	IProcessHeader ProcessHeader { get; set; }

	[EntityUserSettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "User")]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
	[Order(2)]
	[DisplayName(typeof(__Resources_IProcessHeaderPermission), "P_User_DisplayName")]
	[Uid("64339077-ff8d-44bc-be45-65bb76fda25d")]
	[EntityProperty]
	IUser User { get; set; }

	[EntityProperty]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "72c9994a-cd4e-4746-ac50-5f454b450231")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "Group")]
	[Order(3)]
	[DisplayName(typeof(__Resources_IProcessHeaderPermission), "P_Group_DisplayName")]
	[Uid("395061b9-ec52-46f8-af1f-7d39086b3070")]
	IUserGroup Group { get; set; }

	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "e502f586-afd4-4f55-bedb-f71028ffd302")]
	[Order(4)]
	[OrganizationItemSettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "OrganizationItemPosition")]
	[Uid("70c7e951-93be-4e30-b2e9-6890c71f0284")]
	[DisplayName(typeof(__Resources_IProcessHeaderPermission), "P_OrganizationItemPosition_DisplayName")]
	[EntityProperty]
	IOrganizationItem OrganizationItemPosition { get; set; }

	[Uid("351c1622-6197-4e6b-832b-3f7d70681af8")]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[DisplayName(typeof(__Resources_IProcessHeaderPermission), "P_UserSecuritySetCacheId_DisplayName")]
	[CanBeNull]
	[Order(5)]
	[Int64Settings(FieldName = "UserSecuritySetCacheId")]
	[Property("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
	long? UserSecuritySetCacheId { get; set; }

	[GuidSettings(FieldName = "PermissionId")]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[RequiredField]
	[NotNull]
	[Order(6)]
	[Uid("0bfffe67-c98d-4c02-ab58-af3682051800")]
	[Required(true)]
	[EntityProperty]
	[DisplayName(typeof(__Resources_IProcessHeaderPermission), "P_PermissionId_DisplayName")]
	Guid PermissionId { get; set; }

	[EntityProperty]
	[OrganizationItemSettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "OrganizationItem")]
	[DisplayName(typeof(__Resources_IProcessHeaderPermission), "P_OrganizationItem_DisplayName")]
	[Order(7)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "e502f586-afd4-4f55-bedb-f71028ffd302")]
	[Uid("110dcdfe-06a8-46b2-bdc0-f878958363c3")]
	IOrganizationItem OrganizationItem { get; set; }
}
