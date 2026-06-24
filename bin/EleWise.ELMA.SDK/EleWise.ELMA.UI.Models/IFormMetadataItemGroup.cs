using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.UI.Models;

[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[Entity("FormMetadataItemGroup")]
[ShowInCatalogList(false)]
[ImplementationUid("7239c845-9b14-4858-b39c-d98cc89e7d2b")]
[EntityMetadataType(EntityMetadataType.Interface)]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>de023afa-06a9-4818-9bb7-32346ce904f8</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Uid("0fb824f0-01de-439e-9d42-320cc59e10b6")]
[MetadataType(typeof(EntityMetadata))]
[DisplayFormat(null)]
[DisplayName(typeof(__Resources_IFormMetadataItemGroup), "DisplayName")]
public interface IFormMetadataItemGroup : IEntity<long>, IEntity, IIdentified
{
	[NotNull]
	[Uid("d0d93fa2-e3bf-459a-b41e-377866b10fa4")]
	[GuidSettings(FieldName = "Uid")]
	[DisplayName(typeof(__Resources_IFormMetadataItemGroup), "P_Uid_DisplayName")]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	Guid Uid { get; set; }

	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[ShowInTable(true)]
	[EntityProperty]
	[FastSearch(true)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(MaxValueString = "2000", FieldName = "Name")]
	[Required(true)]
	[Uid("9cb2404d-688f-4a4b-a696-3db954c38206")]
	[Order(1)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName(typeof(__Resources_IFormMetadataItemGroup), "P_Name_DisplayName")]
	[RequiredField]
	[StringRangeLength(0, "2000")]
	string Name { get; set; }

	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[NotNull]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[Uid("63acd8ab-8b2e-4c4f-bd83-0ab80185a203")]
	[Order(2)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[GuidSettings(FieldName = "MetadataType")]
	[DisplayName(typeof(__Resources_IFormMetadataItemGroup), "P_MetadataType_DisplayName")]
	Guid MetadataType { get; set; }

	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "7193b3a8-1310-4ea7-90ba-4d4632f1159f")]
	[EntitySettings(RelationType = RelationType.OneToMany, KeyColumnUidStr = "c9f61c8e-2e6e-497d-afe2-a7759b6c135d", CascadeMode = CascadeMode.SaveUpdate)]
	[Uid("c8b48748-5bac-4630-8978-037b366e82c5")]
	[Order(5)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[DisplayName(typeof(__Resources_IFormMetadataItemGroup), "P_Headers_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	ISet<IFormMetadataItemHeader> Headers { get; set; }

	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "Parent")]
	[Uid("1074c92e-02c4-432b-b5b6-bfe94f6a8a95")]
	[Order(3)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "0fb824f0-01de-439e-9d42-320cc59e10b6")]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName(typeof(__Resources_IFormMetadataItemGroup), "P_Parent_DisplayName")]
	IFormMetadataItemGroup Parent { get; set; }

	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[EntityProperty]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Order(4)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Uid("e220f284-f451-4745-b694-a66fa2fd6577")]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "0fb824f0-01de-439e-9d42-320cc59e10b6")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName(typeof(__Resources_IFormMetadataItemGroup), "P_Groups_DisplayName")]
	[EntitySettings(RelationType = RelationType.OneToMany, KeyColumnUidStr = "1074c92e-02c4-432b-b5b6-bfe94f6a8a95", CascadeMode = CascadeMode.SaveUpdate)]
	ISet<IFormMetadataItemGroup> Groups { get; set; }
}
