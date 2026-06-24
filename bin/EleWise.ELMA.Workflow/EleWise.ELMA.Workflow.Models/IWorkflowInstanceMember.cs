using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Types.Settings;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Workflow.Models;

[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[Entity("WorkflowInstanceMember")]
[ShowInCatalogList(false)]
[ImplementationUid("faf42e8b-3627-416f-9678-d7363d2cfec1")]
[EntityMetadataType(EntityMetadataType.Interface)]
[Uid("1310802b-9c9e-44ff-b239-510c874bc9ca")]
[MetadataType(typeof(EntityMetadata))]
[DisplayName(typeof(__Resources_IWorkflowInstanceMember), "DisplayName")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>7a3b9084-a033-404a-829a-c7aa24997d8c</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[DisplayFormat("{$User}")]
public interface IWorkflowInstanceMember : IEntity<long>, IEntity, IIdentified
{
	[GuidSettings(FieldName = "Uid")]
	[Uid("beeab842-0ff5-46f0-b00e-7606355e8417")]
	[DisplayName(typeof(__Resources_IWorkflowInstanceMember), "P_Uid_DisplayName")]
	[SystemProperty]
	[NotNull]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[EntityProperty]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	Guid Uid { get; set; }

	[Uid("fec8ede3-4a10-4f36-855f-feab23c24e31")]
	[DisplayName(typeof(__Resources_IWorkflowInstanceMember), "P_Instance_DisplayName")]
	[Order(1)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "ae8e2269-5077-4bb3-a8dd-62e5d130f009")]
	[EntitySettings(RelationTableName = "M_WorkflowInstanceMember_", ParentColumnName = "Parent", ChildColumnName = "Child", CascadeMode = CascadeMode.SaveUpdate, FieldName = "Instance")]
	[EntityProperty]
	IWorkflowInstance Instance { get; set; }

	[EntityUserSettings(RelationTableName = "M_WorkflowInstanceMember_", ParentColumnName = "Parent", ChildColumnName = "Child", CascadeMode = CascadeMode.SaveUpdate, FieldName = "User")]
	[DisplayName(typeof(__Resources_IWorkflowInstanceMember), "P_User_DisplayName")]
	[EntityProperty]
	[Uid("0467d943-71a4-46db-bd8a-e5d0976f80ec")]
	[Order(3)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
	IUser User { get; set; }

	[EntityProperty]
	[GuidSettings(FieldName = "PermissionRole")]
	[DisplayName(typeof(__Resources_IWorkflowInstanceMember), "P_PermissionRole_DisplayName")]
	[CanBeNull]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[Uid("3a20103b-452f-47e4-b11c-6ade0d332d92")]
	[Order(4)]
	Guid? PermissionRole { get; set; }

	[EntitySettings(FieldName = "Task")]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "0f338330-068c-4135-be4e-95797a209c4e")]
	[Uid("c362e165-6e9c-4819-b4b8-12ebadc2987e")]
	[Order(2)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName(typeof(__Resources_IWorkflowInstanceMember), "P_Task_DisplayName")]
	[EntityProperty]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	ITaskBase Task { get; set; }
}
