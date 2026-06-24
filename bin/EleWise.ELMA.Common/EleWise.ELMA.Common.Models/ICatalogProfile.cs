using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security.Models;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.Common.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("fc1db3fb-139b-4bb4-9f7b-d0adead0409c")]
[DisplayName(typeof(__Resources_ICatalogProfile), "DisplayName")]
[DisplayFormat(null)]
[TitleProperty("b13b793e-4511-4745-98ee-5620e0168c83")]
[ShowInTypeTree(false)]
[ShowInDesigner(false)]
[InterfaceImplementation("EleWise.ELMA.Security.Models.IPropertyOwnerProfile, EleWise.ELMA.Security")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>0f886c0e-ddbc-42b7-9e1e-1a28ec4d58ea</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("CatalogProfile")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[ImplementationUid("b6649c9f-e0ef-4fd9-8bf7-f9383389f7b6")]
public interface ICatalogProfile : IEntity<long>, IEntity, IIdentified, IPropertyOwnerProfile
{
	[Uid("ca6ad905-b15f-4579-bb6a-8b669c1e3642")]
	[NotNull]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "Uid")]
	[DisplayName(typeof(__Resources_ICatalogProfile), "P_Uid_DisplayName")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	Guid Uid { get; set; }

	[Uid("42492fa9-2339-4c31-8608-7813eb3f3553")]
	[Order(1)]
	[Property("2df8e9ca-3ac4-4ba5-832f-18f6374397e7")]
	[ReferenceOnEntityTypeSettings(FieldName = "CatalogType")]
	[DisplayName(typeof(__Resources_ICatalogProfile), "P_CatalogType_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	ReferenceOnEntityType CatalogType { get; set; }

	[Uid("3680981f-4a20-44c0-93ea-96a4264abbbb")]
	[Order(2)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "b97c9b9d-7a9b-49c4-a266-3565b5397a15")]
	[EntitySettings(RelationType = RelationType.OneToMany, KeyColumnUidStr = "d62b47cb-1a1a-445d-919c-7733c7a1c7a3", CascadeMode = CascadeMode.All)]
	[DisplayName(typeof(__Resources_ICatalogProfile), "P_Permission_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	ISet<ICatalogAccess> Permission { get; set; }

	[Uid("b13b793e-4511-4745-98ee-5620e0168c83")]
	[Order(3)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(FieldName = "Name")]
	[DisplayName(typeof(__Resources_ICatalogProfile), "P_Name_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	string Name { get; set; }
}
