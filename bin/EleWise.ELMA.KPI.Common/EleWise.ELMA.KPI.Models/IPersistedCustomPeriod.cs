using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.KPI.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("e9a589a8-68c8-4d97-9952-49d362082a58")]
[DisplayName(typeof(__Resources_IPersistedCustomPeriod), "DisplayName")]
[DisplayFormat(null)]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>c68cad25-7fba-46b6-9453-06cb5e94a917</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[NamespaceForDisplay("EleWise.ELMA.Common.Models")]
[Entity("PersistedCustomPeriod")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[Filterable]
[ImplementationUid("3e1b3bbd-243c-4dc8-a873-6c3914801f9f")]
[FilterType(typeof(IPersistedCustomPeriodFilter))]
public interface IPersistedCustomPeriod : IEntity<long>, IEntity, IIdentified
{
	[Uid("1c79ba80-ffc5-4812-ac8f-dfdcee61e08f")]
	[NotNull]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "Uid")]
	[DisplayName(typeof(__Resources_IPersistedCustomPeriod), "P_Uid_DisplayName")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	Guid Uid { get; set; }

	[Uid("3e2dacc2-0a90-48a0-9605-372cc5cdc21d")]
	[Order(2)]
	[NotNull]
	[Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
	[DateTimeSettings(FieldName = "PeriodStart")]
	[DisplayName(typeof(__Resources_IPersistedCustomPeriod), "P_PeriodStart_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	DateTime PeriodStart { get; set; }

	[Uid("61872a0b-a8ee-45a7-a024-146fa263befb")]
	[Order(3)]
	[NotNull]
	[Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
	[DateTimeSettings(FieldName = "PeriodEnd")]
	[DisplayName(typeof(__Resources_IPersistedCustomPeriod), "P_PeriodEnd_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	DateTime PeriodEnd { get; set; }

	[Uid("e7f29d6a-7649-4055-8f64-b9710999c8e7")]
	[Order(4)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(FieldName = "TextRepr")]
	[DisplayName(typeof(__Resources_IPersistedCustomPeriod), "P_TextRepr_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	string TextRepr { get; set; }

	[Uid("dcaf3090-b4a2-41af-9a16-810ec5daeb47")]
	[Order(1)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "045071a3-02b7-4eb6-bd2b-4e0cc046f154")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "Periodicity")]
	[DisplayName(typeof(__Resources_IPersistedCustomPeriod), "P_Periodicity_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	IPeriodicity Periodicity { get; set; }
}
