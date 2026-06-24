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

namespace EleWise.ELMA.Tasks.Models;

[MetadataType(typeof(TablePartMetadata))]
[Uid("9f59b79b-fd52-4774-adc4-3aa3808f4f8f")]
[DisplayName(typeof(__Resources_IWorkLogActivityPermission), "DisplayName")]
[Description(typeof(__Resources_IWorkLogActivityPermission), "Description")]
[DisplayFormat(null)]
[ShowInTypeTree(false)]
[ShowInDesigner(false)]
[CustomCode(typeof(IWorkLogActivityPermission), "EleWise.ELMA.Tasks.Models.WorkLogActivity.CustomCodeTemplate.cs")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>095f5f29-a206-4746-8f83-17757849dcd2</Uid>\r\n  <ViewType>List</ViewType>\r\n  <Resizeable>true</Resizeable>\r\n  <Groupable>true</Groupable>\r\n  <CanAdd>true</CanAdd>\r\n  <CanEdit>true</CanEdit>\r\n  <CanDelete>true</CanDelete>\r\n</TableView>")]
[Entity("WorkLogActivityPermission")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[CopyAction(CopyAction.Clone)]
[ImplementationUid("8417ec3d-60c0-4ec8-bd52-808167d537fb")]
[Order(6)]
[TablePartInfo(ParentPropertyUidStr = "b9f4f942-145c-46bc-9866-924785c18600", TablePartPropertyUidStr = "e4c1da2a-6bf4-471f-a8dc-abc9a96e3555", TablePartPropertyName = "Permissions")]
public interface IWorkLogActivityPermission : IEntity<long>, IEntity, IIdentified, ITablePartItem
{
	[Uid("b9f4f942-145c-46bc-9866-924785c18600")]
	[SystemProperty]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "ceb2cfdd-65a1-41f1-bfd5-e2a610334bec")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "Parent")]
	[DisplayName(typeof(__Resources_IWorkLogActivityPermission), "P_Parent_DisplayName")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = true)]
	[EntityProperty]
	new IWorkLogActivity Parent { get; set; }

	[Uid("ea8a9125-bfe1-4696-bf30-c66b243eb087")]
	[NotNull]
	[Required(true)]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "PermissionId")]
	[RequiredField]
	[DisplayName(typeof(__Resources_IWorkLogActivityPermission), "P_PermissionId_DisplayName")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = true)]
	[EntityProperty]
	Guid PermissionId { get; set; }

	[Uid("5c2218c8-88b3-479b-8085-3b76a3b86fbe")]
	[CanBeNull]
	[SystemProperty]
	[Property("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
	[Int64Settings(FieldName = "UserSecuritySetCacheId")]
	[DisplayName(typeof(__Resources_IWorkLogActivityPermission), "P_UserSecuritySetCacheId_DisplayName")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = true)]
	[EntityProperty]
	long? UserSecuritySetCacheId { get; set; }

	[Uid("14aded42-2e6f-4919-a7e3-5b0af3806b37")]
	[CanBeNull]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "PermissionRole")]
	[DisplayName(typeof(__Resources_IWorkLogActivityPermission), "P_PermissionRole_DisplayName")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = true)]
	[EntityProperty]
	Guid? PermissionRole { get; set; }

	[Uid("085bdb48-5514-4566-9d6b-667f65fdfcc9")]
	[SystemProperty]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
	[EntityUserSettings(FieldName = "User")]
	[DisplayName(typeof(__Resources_IWorkLogActivityPermission), "P_User_DisplayName")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = true)]
	[EntityProperty]
	IUser User { get; set; }

	[Uid("74f350ec-1d38-4307-a623-176fa57a700e")]
	[SystemProperty]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "e502f586-afd4-4f55-bedb-f71028ffd302")]
	[OrganizationItemSettings(FieldName = "OrganizationItemPosition")]
	[DisplayName(typeof(__Resources_IWorkLogActivityPermission), "P_OrganizationItemPosition_DisplayName")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = true)]
	[EntityProperty]
	IOrganizationItem OrganizationItemPosition { get; set; }

	[Uid("059c4f21-ccc0-4988-804e-9197616f2b94")]
	[SystemProperty]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "72c9994a-cd4e-4746-ac50-5f454b450231")]
	[EntitySettings(FieldName = "Group")]
	[DisplayName(typeof(__Resources_IWorkLogActivityPermission), "P_Group_DisplayName")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = true)]
	[EntityProperty]
	IUserGroup Group { get; set; }

	[Uid("aeceedf7-3f3b-42a4-b942-633d5d2fe60a")]
	[SystemProperty]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "e502f586-afd4-4f55-bedb-f71028ffd302")]
	[OrganizationItemSettings(FieldName = "OrganizationItem")]
	[DisplayName(typeof(__Resources_IWorkLogActivityPermission), "P_OrganizationItem_DisplayName")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = true)]
	[EntityProperty]
	IOrganizationItem OrganizationItem { get; set; }

	[Uid("5a8a7452-a829-4663-b967-8113ac76d7f1")]
	[NotNull]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "Uid")]
	[DisplayName(typeof(__Resources_IWorkLogActivityPermission), "P_Uid_DisplayName")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	Guid Uid { get; set; }
}
