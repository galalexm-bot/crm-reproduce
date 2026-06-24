using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.CRM.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("c32a1543-9f2b-413d-b247-06e0034d8b0e")]
[DisplayName(typeof(__Resources_ICientType), "DisplayName")]
[DisplayFormat(null)]
[TitleProperty("d83e56df-22b4-4c85-9441-eefa099587e7")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>a05decb6-9658-4f70-bd67-2e3a0274d12e</Uid>\r\n  <ViewType>List</ViewType>\r\n  <Sortable>false</Sortable>\r\n</TableView>")]
[Entity("CientType")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(true)]
[EntityMetadataType(EntityMetadataType.Interface)]
[ImplementationUid("40dbba15-96d2-4e8c-a89c-4a6959c24681")]
[Hierarchical(HierarchyType.GroupAndElements, "1638f581-f723-464e-abe3-9de26233b2fd", "3005d7df-c45d-453a-81e9-dd6cfe3732ab")]
public interface ICientType : IEntity<long>, IEntity, IIdentified
{
	[Uid("37191abc-3a83-45ed-a947-1d35b5138e3a")]
	[NotNull]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "Uid")]
	[DisplayName(typeof(__Resources_ICientType), "P_Uid_DisplayName")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	Guid Uid { get; set; }

	[Uid("1638f581-f723-464e-abe3-9de26233b2fd")]
	[Order(1)]
	[SystemProperty]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "c32a1543-9f2b-413d-b247-06e0034d8b0e")]
	[EntitySettings(FieldName = "Parent")]
	[DisplayName(typeof(__Resources_ICientType), "P_Parent_DisplayName")]
	[EntityProperty]
	ICientType Parent { get; set; }

	[Uid("3005d7df-c45d-453a-81e9-dd6cfe3732ab")]
	[Order(2)]
	[NotNull]
	[SystemProperty]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(FieldName = "IsGroup")]
	[DisplayName(typeof(__Resources_ICientType), "P_IsGroup_DisplayName")]
	[EntityProperty]
	bool IsGroup { get; set; }

	[Uid("d83e56df-22b4-4c85-9441-eefa099587e7")]
	[Order(3)]
	[Required(true)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(FieldName = "Name")]
	[RequiredField]
	[DisplayName(typeof(__Resources_ICientType), "P_Name_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[FastSearch(true)]
	[Filterable]
	[EntityProperty]
	string Name { get; set; }
}
