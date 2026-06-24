using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Security.Models;

[MetadataType(typeof(EntityMetadata))]
[DisplayName(typeof(__Resources_IAssignedRoleStereotype), "DisplayName")]
[Uid("3778a904-313b-4b87-b655-8e45b715e137")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>083cb3d4-c385-49d7-b0b6-22ddbe4b4c3e</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[DisplayFormat(null)]
[EntityMetadataType(EntityMetadataType.Interface)]
[ImplementationUid("f071a2bc-aaf0-4d8f-a97d-4bf0855198ca")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[Entity("AssignedRoleStereotype")]
public interface IAssignedRoleStereotype : IEntity<long>, IEntity, IIdentified
{
	[EntityProperty]
	[SystemProperty]
	[NotNull]
	[Uid("9b2b0d29-5731-419a-9271-0ac64bdcc69c")]
	[DisplayName(typeof(__Resources_IAssignedRoleStereotype), "P_Uid_DisplayName")]
	[GuidSettings(FieldName = "Uid")]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	Guid Uid { get; set; }

	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Uid("6b56bc06-9461-457d-b687-96aa2ba81102")]
	[RequiredField]
	[GuidSettings(FieldName = "GroupUid")]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[DisplayName(typeof(__Resources_IAssignedRoleStereotype), "P_GroupUid_DisplayName")]
	[CanBeNull]
	[Description(typeof(__Resources_IAssignedRoleStereotype), "P_GroupUid_Description")]
	[Required(true)]
	Guid? GroupUid { get; set; }

	[Uid("06323394-6a9f-4154-bc8a-5c4412bce886")]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[Required(true)]
	[RequiredField]
	[GuidSettings(FieldName = "PermissionUid")]
	[Description(typeof(__Resources_IAssignedRoleStereotype), "P_PermissionUid_Description")]
	[DisplayName(typeof(__Resources_IAssignedRoleStereotype), "P_PermissionUid_DisplayName")]
	[EntityProperty]
	[Order(1)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[CanBeNull]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	Guid? PermissionUid { get; set; }
}
