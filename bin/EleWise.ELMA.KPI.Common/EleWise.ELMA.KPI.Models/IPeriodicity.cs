using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.KPI.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("045071a3-02b7-4eb6-bd2b-4e0cc046f154")]
[DisplayName(typeof(__Resources_IPeriodicity), "DisplayName")]
[DisplayFormat(null)]
[TitleProperty("22a39a45-2bc0-41fd-a6d5-9e6208b89c61")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>644fca4b-4a6d-4cad-9599-98705ca79ed6</Uid>\r\n  <ViewType>List</ViewType>\r\n  <SortDescriptors>\r\n    <TableViewSortDescriptor>\r\n      <PropertyUid>245ca26c-af1c-458d-8664-61ed1d431a7e</PropertyUid>\r\n      <Direction>Ascending</Direction>\r\n    </TableViewSortDescriptor>\r\n  </SortDescriptors>\r\n</TableView>")]
[NamespaceForDisplay("EleWise.ELMA.Common.Models")]
[Entity("Periodicity")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(true)]
[EntityMetadataType(EntityMetadataType.Interface)]
[SaveHistory]
[Filterable]
[ImplementationUid("b2f82f8c-8465-42dd-9175-c593a81af994")]
[FilterType(typeof(IPeriodicityFilter))]
public interface IPeriodicity : IEntity<long>, IEntity, IIdentified
{
	[Uid("7bc4d6da-0602-4c35-90c0-4736539f40ba")]
	[NotNull]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "Uid")]
	[DisplayName(typeof(__Resources_IPeriodicity), "P_Uid_DisplayName")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	Guid Uid { get; set; }

	[Uid("5d40e9ec-4ef9-47ce-b969-2cac8a04fee9")]
	[Order(3)]
	[NotNull]
	[Property("849c1ac9-4d46-4194-8cbb-43f84adf9c17", "d4ca8236-5c72-40ba-a656-9ce63523a0d1")]
	[EnumSettings(FieldName = "Type")]
	[DisplayName(typeof(__Resources_IPeriodicity), "P_Type_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	PeriodicityType Type { get; set; }

	[Uid("299c9e22-9a97-421e-b8aa-4ecb5199344a")]
	[Order(4)]
	[CanBeNull]
	[Property("849c1ac9-4d46-4194-8cbb-43f84adf9c17", "dc077887-179f-4f8a-b794-23e1034c4043")]
	[EnumSettings(FieldName = "GroupingType")]
	[DisplayName(typeof(__Resources_IPeriodicity), "P_GroupingType_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	PeriodGroupingType? GroupingType { get; set; }

	[Uid("557fb953-2df0-41af-8184-c99f9b1d7d44")]
	[Order(2)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(FieldName = "Description")]
	[DisplayName(typeof(__Resources_IPeriodicity), "P_Description_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	string Description { get; set; }

	[Uid("47490632-cb49-41a5-9881-2d6b2225cefb")]
	[Order(5)]
	[NotNull]
	[Property("849c1ac9-4d46-4194-8cbb-43f84adf9c17", "29cbb41a-cf89-43c7-8efb-86303092b36d")]
	[EnumSettings(FieldName = "CalendarType")]
	[DisplayName(typeof(__Resources_IPeriodicity), "P_CalendarType_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	PeriodicityCalendarType CalendarType { get; set; }

	[Uid("22a39a45-2bc0-41fd-a6d5-9e6208b89c61")]
	[Order(1)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(FieldName = "Name")]
	[DisplayName(typeof(__Resources_IPeriodicity), "P_Name_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[FastSearch(true)]
	[Filterable]
	[EntityProperty]
	string Name { get; set; }

	[Uid("245ca26c-af1c-458d-8664-61ed1d431a7e")]
	[Order(6)]
	[NotNull]
	[Property("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
	[Int64Settings(RangeInFilter = false, FieldName = "Order")]
	[DisplayName(typeof(__Resources_IPeriodicity), "P_Order_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	long Order { get; set; }

	[Uid("d8627bd5-84ac-4802-9bda-47c634215327")]
	[Order(7)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "e9a589a8-68c8-4d97-9952-49d362082a58")]
	[EntitySettings(RelationType = RelationType.OneToMany, KeyColumnUidStr = "dcaf3090-b4a2-41af-9a16-810ec5daeb47", CascadeMode = CascadeMode.SaveUpdate)]
	[DisplayName(typeof(__Resources_IPeriodicity), "P_Periods_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[EntityProperty]
	ISet<IPersistedCustomPeriod> Periods { get; set; }
}
