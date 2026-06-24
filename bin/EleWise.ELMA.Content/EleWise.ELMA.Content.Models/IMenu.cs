using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.Content.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("fd7b1de8-71be-4eb5-97a5-cf759a4576f9")]
[DisplayName(typeof(__Resources_IMenu), "DisplayName")]
[Description(typeof(__Resources_IMenu), "Description")]
[AllowCreateHeirs(true)]
[DisplayFormat("{$Name}")]
[TitleProperty("78e955e4-b6ce-4783-a3f8-c9a6f637eb3e")]
[CustomCode(typeof(IMenu), "EleWise.ELMA.Content.Models.Menu.CustomCodeTemplate.cs")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>76213ead-63c1-409f-92a4-922247e66f42</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("Menu")]
[IdType("d6b44bce-b236-424d-aa74-d80da3c8db75")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[ImplementationUid("09fc95a8-2f07-4a42-97b8-37272ba07700")]
[CacheEntity]
public interface IMenu : IEntity<int>, IEntity, IIdentified, IInheritable
{
	[Obsolete("Свойство не используется", true)]
	string MenuUid { get; set; }

	[Uid("ab8df6fe-88ab-49c5-8515-870870b70294")]
	[NotNull]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "Uid")]
	[DisplayName(typeof(__Resources_IMenu), "P_Uid_DisplayName")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[EntityProperty]
	Guid Uid { get; set; }

	[Uid("78e955e4-b6ce-4783-a3f8-c9a6f637eb3e")]
	[Order(1)]
	[Required(true)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(FieldName = "Name")]
	[RequiredField]
	[DisplayName(typeof(__Resources_IMenu), "P_Name_DisplayName")]
	[Description(typeof(__Resources_IMenu), "P_Name_Description")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[FastSearch(true)]
	[ShowInTable(true)]
	[EntityProperty]
	string Name { get; set; }

	[Uid("ca62d428-0554-4916-8724-293852b1b3ab")]
	[Order(2)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(MultiLine = true, FieldName = "Description")]
	[DisplayName(typeof(__Resources_IMenu), "P_Description_DisplayName")]
	[Description(typeof(__Resources_IMenu), "P_Description_Description")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[ShowInTable(true)]
	[EntityProperty]
	string Description { get; set; }

	[Uid("8d336e54-a22b-4b8e-b84e-74f243876fd6")]
	[Order(3)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "9cca472a-f1fe-4173-91d8-aab6ec01eeb8")]
	[EntitySettings(RelationType = RelationType.OneToMany, KeyColumnUidStr = "1d1fc883-53a6-4f0a-b88a-f6f543a4abdd", CascadeMode = CascadeMode.All)]
	[DisplayName(typeof(__Resources_IMenu), "P_Items_DisplayName")]
	[Description(typeof(__Resources_IMenu), "P_Items_Description")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	ISet<IMenuItem> Items { get; set; }

	[Uid("7651689e-3049-404f-97a5-ff9e63df2bab")]
	[Order(4)]
	[NotNull]
	[Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
	[DateTimeSettings(FieldName = "ItemsChangeDate")]
	[DisplayName(typeof(__Resources_IMenu), "P_ItemsChangeDate_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	DateTime ItemsChangeDate { get; set; }
}
