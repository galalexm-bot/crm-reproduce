using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.Workflow.Models;

[Entity("CustomActivityFolder")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[EntityMetadataType(EntityMetadataType.Interface)]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>626da774-36b3-4034-a4f4-e25625e30138</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[MetadataType(typeof(EntityMetadata))]
[Uid("7077af3a-c095-4a73-87de-3ba205024c07")]
[ShowInCatalogList(false)]
[ImplementationUid("4b4d5812-86ab-4580-8a58-1a3d54d84c11")]
[DisplayFormat(null)]
[TitleProperty("11156ceb-da18-4696-b849-d3358e6693f6")]
[DisplayName(typeof(__Resources_ICustomActivityFolder), "DisplayName")]
public interface ICustomActivityFolder : IEntity<long>, IEntity, IIdentified
{
	[DisplayName(typeof(__Resources_ICustomActivityFolder), "P_Uid_DisplayName")]
	[GuidSettings(FieldName = "Uid")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[Uid("fce5550a-7ae2-4545-97d5-8bf01e7e7a5f")]
	[NotNull]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[EntityProperty]
	Guid Uid { get; set; }

	[Required(true)]
	[Uid("11156ceb-da18-4696-b849-d3358e6693f6")]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName(typeof(__Resources_ICustomActivityFolder), "P_Name_DisplayName")]
	[RequiredField]
	[StringSettings(FieldName = "Name")]
	[Order(1)]
	[EntityProperty]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	string Name { get; set; }

	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Uid("b7411b73-be67-4e24-9db9-fbdee4f5e129")]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Order(2)]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "Folder")]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "7077af3a-c095-4a73-87de-3ba205024c07")]
	[EntityProperty]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName(typeof(__Resources_ICustomActivityFolder), "P_Folder_DisplayName")]
	ICustomActivityFolder Folder { get; set; }

	[Order(3)]
	[Description(typeof(__Resources_ICustomActivityFolder), "P_SubFolders_Description")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName(typeof(__Resources_ICustomActivityFolder), "P_SubFolders_DisplayName")]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "7077af3a-c095-4a73-87de-3ba205024c07")]
	[EntitySettings(RelationType = RelationType.OneToMany, KeyColumnUidStr = "b7411b73-be67-4e24-9db9-fbdee4f5e129", CascadeMode = CascadeMode.SaveUpdate)]
	[Uid("d0601e32-fa8c-4990-ad08-0364d4cefc68")]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	ISet<ICustomActivityFolder> SubFolders { get; set; }

	[EntitySettings(RelationType = RelationType.OneToMany, KeyColumnUidStr = "499f475f-659c-44dc-b870-7651b02d8093", CascadeMode = CascadeMode.SaveUpdate)]
	[EntityProperty]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Uid("bda9782d-ee40-4a19-acd0-40602e076cec")]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "9b83a85f-81ce-4f66-9f74-683799a4f362")]
	[Order(4)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Description(typeof(__Resources_ICustomActivityFolder), "P_CustomActivitys_Description")]
	[DisplayName(typeof(__Resources_ICustomActivityFolder), "P_CustomActivitys_DisplayName")]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	ISet<ICustomActivityHeader> CustomActivitys { get; set; }

	[CanBeNull]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[BoolSettings(FieldName = "ReadOnly")]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[Required(true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Order(5)]
	[DisplayName(typeof(__Resources_ICustomActivityFolder), "P_ReadOnly_DisplayName")]
	[RequiredField]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	[Uid("87cdfbdc-0750-435f-8365-80b2e668ea6b")]
	bool? ReadOnly { get; set; }
}
