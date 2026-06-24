using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Types.Settings;

namespace EleWise.ELMA.Workflow.Models;

[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[Entity("WorkflowInstancePermission")]
[ShowInCatalogList(false)]
[ImplementationUid("2793d785-47d3-411e-8f49-33b3f61e3786")]
[EntityMetadataType(EntityMetadataType.Interface)]
[Uid("a76aaa94-fda5-43b1-9705-3fea20520c46")]
[MetadataType(typeof(EntityMetadata))]
[DisplayName(typeof(__Resources_IWorkflowInstancePermission), "DisplayName")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>18ed781f-54f1-4092-9d0c-5cb715545d36</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[DisplayFormat(null)]
public interface IWorkflowInstancePermission : IEntity<long>, IEntity, IIdentified
{
	[NotNull]
	[DisplayName(typeof(__Resources_IWorkflowInstancePermission), "P_Uid_DisplayName")]
	[Uid("9fb87b40-0852-435f-a341-261e48257c16")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[GuidSettings(FieldName = "Uid")]
	[EntityProperty]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	Guid Uid { get; set; }

	[GuidSettings(FieldName = "PermissionRole")]
	[DisplayName(typeof(__Resources_IWorkflowInstancePermission), "P_PermissionRole_DisplayName")]
	[EntityProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[Uid("5428af97-4df7-4ddb-acff-92ad02f6866b")]
	[CanBeNull]
	Guid? PermissionRole { get; set; }

	[EntityProperty]
	[DisplayName(typeof(__Resources_IWorkflowInstancePermission), "P_WorkflowInstance_DisplayName")]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "ae8e2269-5077-4bb3-a8dd-62e5d130f009")]
	[EntitySettings(FieldName = "WorkflowInstance")]
	[Uid("11f993b0-1ae8-4726-ac0f-77b586e7b535")]
	[Order(1)]
	IWorkflowInstance WorkflowInstance { get; set; }

	[EntityUserSettings(FieldName = "User")]
	[DisplayName(typeof(__Resources_IWorkflowInstancePermission), "P_User_DisplayName")]
	[EntityProperty]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
	[Order(2)]
	[Uid("f7440358-7cd7-4aa5-996c-46ba2395c3e3")]
	IUser User { get; set; }

	[Order(3)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "72c9994a-cd4e-4746-ac50-5f454b450231")]
	[EntityProperty]
	[DisplayName(typeof(__Resources_IWorkflowInstancePermission), "P_Group_DisplayName")]
	[EntitySettings(FieldName = "Group")]
	[Uid("36686de9-f40c-451a-8c1d-0f1ab61d614b")]
	IUserGroup Group { get; set; }

	[Order(4)]
	[Uid("e2b9f87d-dce1-4d82-835e-23c0bec98d04")]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "e502f586-afd4-4f55-bedb-f71028ffd302")]
	[OrganizationItemSettings(FieldName = "OrganizationItemPosition")]
	[EntityProperty]
	[DisplayName(typeof(__Resources_IWorkflowInstancePermission), "P_OrganizationItemPosition_DisplayName")]
	IOrganizationItem OrganizationItemPosition { get; set; }

	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Int64Settings(FieldName = "UserSecuritySetCacheId")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[Order(5)]
	[Uid("0901ad27-f2f4-4ae9-bf94-2a3f5561b44d")]
	[DisplayName(typeof(__Resources_IWorkflowInstancePermission), "P_UserSecuritySetCacheId_DisplayName")]
	[Property("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
	[CanBeNull]
	long? UserSecuritySetCacheId { get; set; }

	[CanBeNull]
	[Order(6)]
	[DisplayName(typeof(__Resources_IWorkflowInstancePermission), "P_PermissionId_DisplayName")]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[EntityProperty]
	[GuidSettings(FieldName = "PermissionId")]
	[Uid("79e6c73e-5e95-4824-a5f9-fbfaf106eb7d")]
	Guid? PermissionId { get; set; }
}
