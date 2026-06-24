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

namespace EleWise.ELMA.Tasks.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("173df0f6-d713-4f67-94c9-29c9758e410a")]
[DisplayName(typeof(__Resources_ITaskBasePermission), "DisplayName")]
[Description(typeof(__Resources_ITaskBasePermission), "Description")]
[DisplayFormat(null)]
[InterfaceImplementation("EleWise.ELMA.Security.Services.IInstanceExpressionPermissionHolder")]
[InterfaceImplementation("EleWise.ELMA.Security.Services.ISecurityExpressionSetIdHolder")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>344cb548-ff92-44cd-a837-f314b766d200</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("TaskBasePermission")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[ImplementationUid("52f9c43f-8748-4967-b4ef-9326c2e853c1")]
public interface ITaskBasePermission : IEntity<long>, IEntity, IIdentified, IInstanceExpressionPermissionHolder, ISecurityExpressionSetIdHolder
{
	[Uid("63f181a1-99ca-4795-9011-cad98d393d8b")]
	[NotNull]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "Uid")]
	[DisplayName(typeof(__Resources_ITaskBasePermission), "P_Uid_DisplayName")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	Guid Uid { get; set; }

	[Uid("a36fab61-3479-4c03-abb1-602cebbdee7c")]
	[Order(1)]
	[Required(true)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "0f338330-068c-4135-be4e-95797a209c4e")]
	[EntitySettings(FieldName = "Target")]
	[RequiredField]
	[DisplayName(typeof(__Resources_ITaskBasePermission), "P_Target_DisplayName")]
	[Description(typeof(__Resources_ITaskBasePermission), "P_Target_Description")]
	[EntityProperty]
	new ITaskBase Target { get; set; }

	[Uid("85dfd146-91f2-4857-8c7d-d47d36c6b879")]
	[Order(2)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
	[EntityUserSettings(FieldName = "UserId")]
	[DisplayName(typeof(__Resources_ITaskBasePermission), "P_User_DisplayName")]
	[EntityProperty]
	new IUser User { get; set; }

	[Uid("996362ca-0c5a-43d5-b131-bc2e408e68da")]
	[Order(3)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(MaxValueString = "255", FieldName = "TypeRole")]
	[StringRangeLength(0, "255")]
	[DisplayName(typeof(__Resources_ITaskBasePermission), "P_TypeRole_DisplayName")]
	[Description(typeof(__Resources_ITaskBasePermission), "P_TypeRole_Description")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	new string TypeRole { get; set; }

	[Uid("ea2d0cad-76d1-4122-a9da-9bab7282f866")]
	[Order(4)]
	[NotNull]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(FieldName = "AllowChief")]
	[DisplayName(typeof(__Resources_ITaskBasePermission), "P_AllowChief_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	new bool AllowChief { get; set; }

	[Uid("bc5055f1-1214-4222-8d81-e3bdd6079a31")]
	[Order(5)]
	[CanBeNull]
	[Property("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
	[Int64Settings(FieldName = "UserSecuritySetCacheId")]
	[DisplayName(typeof(__Resources_ITaskBasePermission), "P_UserSecuritySetCacheId_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	new long? UserSecuritySetCacheId { get; set; }
}
