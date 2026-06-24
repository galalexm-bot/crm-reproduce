using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security.Types.Settings;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.Security.Models;

[ShowInCatalogList(false)]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[Entity("OrganizationItem")]
[EntityMetadataType(EntityMetadataType.Interface)]
[CacheEntity]
[ImplementationUid("dfb7b232-140c-4aba-bff2-c5ccee293088")]
[CopyAction(CopyAction.ByRef)]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>6a3df994-7968-415d-892a-31f9278a1594</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Uid("e502f586-afd4-4f55-bedb-f71028ffd302")]
[MetadataType(typeof(EntityMetadata))]
[DisplayName(typeof(__Resources_IOrganizationItem), "DisplayName")]
[InterfaceImplementation("EleWise.ELMA.Model.Entities.ISoftDeletable, EleWise.ELMA.SDK")]
[DisplayFormat("{$Name}")]
public interface IOrganizationItem : IEntity<long>, IEntity, IIdentified, ISoftDeletable
{
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "Uid")]
	[Uid("e9091819-d95f-4e37-af9c-a4a0efa7402b")]
	[NotNull]
	[Required(true)]
	[View(ViewType = ViewType.All, ItemType = EleWise.ELMA.Model.Views.ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	[RequiredField]
	[DisplayName(typeof(__Resources_IOrganizationItem), "P_Uid_DisplayName")]
	Guid Uid { get; set; }

	[EnumSettings(FieldName = "ItemType")]
	[EntityProperty]
	[Uid("e6eb286a-dbf0-4e8e-b606-d422940cc3a4")]
	[Order(1)]
	[NotNull]
	[Property("849c1ac9-4d46-4194-8cbb-43f84adf9c17", "6557e077-71cd-4f73-b23a-eed2447ef0b0")]
	[DisplayName(typeof(__Resources_IOrganizationItem), "P_ItemType_DisplayName")]
	OrganizationItemType ItemType { get; set; }

	[View(ViewType = ViewType.Create, ItemType = EleWise.ELMA.Model.Views.ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = EleWise.ELMA.Model.Views.ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[Uid("cae9e784-5d4e-4f17-94f5-abfa9023feb3")]
	[View(ViewType = ViewType.Edit, ItemType = EleWise.ELMA.Model.Views.ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[StringRangeLength(0, "2000")]
	[Order(2)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(MaxValueString = "2000", FieldName = "Name")]
	[View(ViewType = ViewType.List, ItemType = EleWise.ELMA.Model.Views.ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName(typeof(__Resources_IOrganizationItem), "P_Name_DisplayName")]
	[FastSearch(true)]
	[EntityProperty]
	string Name { get; set; }

	[DisplayName(typeof(__Resources_IOrganizationItem), "P_ParentItem_DisplayName")]
	[EntityProperty]
	[OrganizationItemSettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "ParentItem")]
	[Uid("f8983979-45d6-411f-a505-770f381030a8")]
	[Order(3)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "e502f586-afd4-4f55-bedb-f71028ffd302")]
	IOrganizationItem ParentItem { get; set; }

	[Description(typeof(__Resources_IOrganizationItem), "P_User_Description")]
	[DisplayName(typeof(__Resources_IOrganizationItem), "P_User_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = EleWise.ELMA.Model.Views.ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Order(4)]
	[Uid("be1f5c48-fa8f-4bf0-ae4c-0ecdfd88052e")]
	[EntityUserSettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "UserId")]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
	[View(ViewType = ViewType.List, ItemType = EleWise.ELMA.Model.Views.ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.Edit, ItemType = EleWise.ELMA.Model.Views.ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = EleWise.ELMA.Model.Views.ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	IUser User { get; set; }

	[EntityProperty]
	[View(ViewType = ViewType.Create, ItemType = EleWise.ELMA.Model.Views.ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = EleWise.ELMA.Model.Views.ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = EleWise.ELMA.Model.Views.ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = EleWise.ELMA.Model.Views.ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityUserSettings(RelationType = RelationType.ManyToMany, RelationTableName = "OrganizationItemUsers", ParentColumnName = "OrganizationItemId", ChildColumnName = "UserId", CascadeMode = CascadeMode.SaveUpdate)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
	[Order(5)]
	[Description(typeof(__Resources_IOrganizationItem), "P_Users_Description")]
	[DisplayName(typeof(__Resources_IOrganizationItem), "P_Users_DisplayName")]
	[Uid("08f27ddc-aed6-4a7e-9745-befd0b354b1b")]
	ISet<IUser> Users { get; set; }

	[View(ViewType = ViewType.Edit, ItemType = EleWise.ELMA.Model.Views.ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = EleWise.ELMA.Model.Views.ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Groupable(false)]
	[EntityProperty]
	[View(ViewType = ViewType.List, ItemType = EleWise.ELMA.Model.Views.ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = EleWise.ELMA.Model.Views.ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[Order(6)]
	[Uid("28d68012-b2c4-4366-ba7b-73b317d49b8c")]
	[Sortable(false)]
	[DisplayName(typeof(__Resources_IOrganizationItem), "P_UsersHash_DisplayName")]
	[StringSettings(FieldName = "UsersHash")]
	string UsersHash { get; set; }

	[View(ViewType = ViewType.Edit, ItemType = EleWise.ELMA.Model.Views.ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = EleWise.ELMA.Model.Views.ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = EleWise.ELMA.Model.Views.ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	[View(ViewType = ViewType.List, ItemType = EleWise.ELMA.Model.Views.ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[Order(7)]
	[Uid("4d68a5ae-1c1a-4b84-bfd1-e34e0d73240f")]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "e502f586-afd4-4f55-bedb-f71028ffd302")]
	[DisplayName(typeof(__Resources_IOrganizationItem), "P_SubItems_DisplayName")]
	[OrganizationItemSettings(RelationType = RelationType.OneToMany, KeyColumnUidStr = "f8983979-45d6-411f-a505-770f381030a8", CascadeMode = CascadeMode.SaveUpdate)]
	ISet<IOrganizationItem> SubItems { get; set; }

	[View(ViewType = ViewType.Create, ItemType = EleWise.ELMA.Model.Views.ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = EleWise.ELMA.Model.Views.ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.List, ItemType = EleWise.ELMA.Model.Views.ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = EleWise.ELMA.Model.Views.ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[NotNull]
	[Order(8)]
	[Uid("18e81d76-bfd2-460d-bdaf-aa5a0da66657")]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(FieldName = "IsDeleted")]
	[DisplayName(typeof(__Resources_IOrganizationItem), "P_IsDeleted_DisplayName")]
	new bool IsDeleted { get; set; }

	[View(ViewType = ViewType.Edit, ItemType = EleWise.ELMA.Model.Views.ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = EleWise.ELMA.Model.Views.ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = EleWise.ELMA.Model.Views.ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = EleWise.ELMA.Model.Views.ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[EntityProperty]
	[DisplayName(typeof(__Resources_IOrganizationItem), "P_HardDelete_DisplayName")]
	[Order(9)]
	[Uid("9d3972d9-8a2e-4326-a27c-4f16d81d3a1a")]
	[NotNull]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(FieldName = "HardDelete")]
	new bool HardDelete { get; set; }
}
