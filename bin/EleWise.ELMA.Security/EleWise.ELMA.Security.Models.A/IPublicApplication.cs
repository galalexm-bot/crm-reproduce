using System;
using EleWise.ELMA.API.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.Security.Models.API;

[EntityMetadataType(EntityMetadataType.Interface)]
[Filterable]
[Entity("PublicApplication")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[FilterType(typeof(IPublicApplicationFilter))]
[ShowInCatalogList(false)]
[ImplementationUid("fa3fc7fc-6535-4f4f-a5b9-996a7e95166b")]
[CacheEntity]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>c10ecc37-a1a3-4136-9ea0-e024185d199e</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[DisplayName(typeof(__Resources_IPublicApplication), "DisplayName")]
[DisplayFormat(null)]
[MetadataType(typeof(EntityMetadata))]
[Uid("1817c965-17ce-4463-86b5-08deb0f4b04e")]
[ShowInDesigner(false)]
[InterfaceImplementation("EleWise.ELMA.API.Models.IPublicApplication")]
[TitleProperty("889bac17-f1d5-47c7-b687-436d4884cd0d")]
[ShowInTypeTree(false)]
public interface IPublicApplication : IEntity<long>, IEntity, IIdentified, EleWise.ELMA.API.Models.IPublicApplication
{
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[Uid("2b7545eb-1a14-4463-b2e4-db75f4ea1621")]
	[NotNull]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	[GuidSettings(FieldName = "Uid")]
	[DisplayName(typeof(__Resources_IPublicApplication), "P_Uid_DisplayName")]
	new Guid Uid { get; set; }

	[RequiredField]
	[DisplayName(typeof(__Resources_IPublicApplication), "P_Name_DisplayName")]
	[StringSettings(FieldName = "Name")]
	[Required(true)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	[FastSearch(true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[Order(1)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Uid("889bac17-f1d5-47c7-b687-436d4884cd0d")]
	new string Name { get; set; }

	[Uid("238ae522-8845-43d3-8dfa-e67a0a9ba149")]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[StringSettings(MultiLine = true, FieldName = "Description")]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[DisplayName(typeof(__Resources_IPublicApplication), "P_Description_DisplayName")]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Sortable(false)]
	[Order(2)]
	new string Description { get; set; }

	[Order(3)]
	[Uid("c83026a2-0ef4-4e26-a72f-b881352c8195")]
	[RequiredField]
	[StringSettings(FieldName = "Author")]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[Required(true)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName(typeof(__Resources_IPublicApplication), "P_Author_DisplayName")]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	new string Author { get; set; }

	[Order(4)]
	[Required(true)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[Uid("87ad3542-e4b5-4df2-af03-79c2d2e295a5")]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[StringSettings(FieldName = "Site")]
	[DisplayName(typeof(__Resources_IPublicApplication), "P_Site_DisplayName")]
	[RequiredField]
	[EntityProperty]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	new string Site { get; set; }

	[Required(true)]
	[NotNull]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	[Filterable]
	[BoolSettings(FieldName = "IsActive")]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[RequiredField]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName(typeof(__Resources_IPublicApplication), "P_IsActive_DisplayName")]
	[Uid("d74c80f3-b17e-4d33-bba4-f44df4d57b8f")]
	[Order(5)]
	bool IsActive { get; set; }

	[DisplayName(typeof(__Resources_IPublicApplication), "P_Tokens_DisplayName")]
	[Sortable(false)]
	[EntitySettings(RelationType = RelationType.OneToMany, KeyColumnUidStr = "bfec7811-b7c0-47c8-9f0b-8e085c9a2f00", CascadeMode = CascadeMode.AllDeleteOrphan)]
	[Order(6)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "69334e6e-2d55-4665-94e1-1de241bfa9ce")]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Uid("b8ff9e3c-d694-4028-988e-a1fdb8880346")]
	ISet<IPublicApplicationToken> Tokens { get; set; }

	[Filterable]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[NotNull]
	[Required(true)]
	[EntityProperty]
	[RequiredField]
	[BoolSettings(FieldName = "IsSystem")]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[DisplayName(typeof(__Resources_IPublicApplication), "P_IsSystem_DisplayName")]
	[Uid("0d651796-34dc-4f60-8c0b-ac825bc23960")]
	[Order(7)]
	bool IsSystem { get; set; }
}
