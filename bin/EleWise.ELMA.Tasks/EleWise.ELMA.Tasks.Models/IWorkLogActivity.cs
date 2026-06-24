using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.Tasks.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("ceb2cfdd-65a1-41f1-bfd5-e2a610334bec")]
[DisplayName(typeof(__Resources_IWorkLogActivity), "DisplayName")]
[DisplayFormat(null)]
[TitleProperty("77d486b5-85f1-46f8-872d-5837cde348c4")]
[InterfaceImplementation("EleWise.ELMA.Model.Entities.ISoftDeletable")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>fd4ab8fb-b79b-47aa-96d9-ea055d7516fe</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("WorkLogActivity")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(true)]
[EntityMetadataType(EntityMetadataType.Interface)]
[Filterable]
[ImplementationUid("a224727a-7462-421d-b12a-77ebed082822")]
[InstancePermission(true, "WorkLogActivityPermission", "Permissions")]
[FilterType(typeof(IWorkLogActivityFilter))]
[TablePart(typeof(IWorkLogActivityPermission))]
public interface IWorkLogActivity : IEntity<long>, IEntity, IIdentified, ISoftDeletable
{
	[Uid("61bed622-16da-4f3d-a1b6-736cccc6b050")]
	[NotNull]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "Uid")]
	[DisplayName(typeof(__Resources_IWorkLogActivity), "P_Uid_DisplayName")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	Guid Uid { get; set; }

	[Uid("77d486b5-85f1-46f8-872d-5837cde348c4")]
	[Order(1)]
	[Required(true)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(MaxValueString = "1024", FieldName = "Name")]
	[RequiredField]
	[StringRangeLength(0, "1024")]
	[DisplayName(typeof(__Resources_IWorkLogActivity), "P_Name_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[FastSearch(true)]
	[Filterable]
	[EntityProperty]
	string Name { get; set; }

	[Uid("9c7f7fd9-3036-4aaf-b6df-028aab19c840")]
	[Order(4)]
	[NotNull]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(FieldName = "IsDeleted")]
	[DisplayName(typeof(__Resources_IWorkLogActivity), "P_IsDeleted_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[EntityProperty]
	new bool IsDeleted { get; set; }

	[Uid("8ce4052c-fe5d-4d56-aaf9-f8a44a5044be")]
	[Order(5)]
	[NotNull]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(FieldName = "HardDelete")]
	[DisplayName(typeof(__Resources_IWorkLogActivity), "P_HardDelete_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[EntityProperty]
	new bool HardDelete { get; set; }

	[Uid("bc3ca93f-67d0-4bc1-a24e-497bc5c11db4")]
	[Order(3)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "3ead92ee-2dcd-4791-bc71-2c184ef9c2ec")]
	[EntitySettings(RelationType = RelationType.OneToMany, KeyColumnUidStr = "a83c6b62-78e6-41b7-b8c1-3c122fadd557", CascadeMode = CascadeMode.All)]
	[DisplayName(typeof(__Resources_IWorkLogActivity), "P_ObjectsUIDs_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	ISet<IWorkLogActivityObjectType> ObjectsUIDs { get; set; }

	[Uid("c5bbc491-4d64-4039-9c63-466572cd3665")]
	[Order(2)]
	[NotNull]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(DefaultValueStr = "True", FieldName = "AllObjectTypes")]
	[DisplayName(typeof(__Resources_IWorkLogActivity), "P_AllObjectTypes_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	bool AllObjectTypes { get; set; }

	[Uid("e4c1da2a-6bf4-471f-a8dc-abc9a96e3555")]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "9f59b79b-fd52-4774-adc4-3aa3808f4f8f")]
	[EntitySettings(RelationType = RelationType.OneToMany, KeyColumnUidStr = "b9f4f942-145c-46bc-9866-924785c18600", CascadeMode = CascadeMode.All)]
	[DisplayName(typeof(__Resources_IWorkLogActivity), "P_Permissions_DisplayName")]
	[Description(typeof(__Resources_IWorkLogActivity), "P_Permissions_Description")]
	[EntityProperty]
	[TablePartProperty]
	ISet<IWorkLogActivityPermission> Permissions { get; set; }
}
