using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.CRM.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("75c19cdd-8a04-4a94-bf1f-cbb01da6d5a2")]
[DisplayName(typeof(__Resources_IRegularCurrencyRateImport), "DisplayName")]
[DisplayFormat(null)]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>88476859-81df-49db-b58c-6f2beb1259ec</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("RegularCurrencyRateImport")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[Filterable]
[ImplementationUid("759a9083-9106-4dee-acb1-b2e165517978")]
[FilterType(typeof(IRegularCurrencyRateImportFilter))]
public interface IRegularCurrencyRateImport : IEntity<long>, IEntity, IIdentified
{
	[Uid("0ed96c7a-204b-40a1-acc8-92c4b1309fe9")]
	[NotNull]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "Uid")]
	[DisplayName(typeof(__Resources_IRegularCurrencyRateImport), "P_Uid_DisplayName")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	Guid Uid { get; set; }

	[Uid("ea36a2b7-56c2-45ab-b94d-1928153ca81c")]
	[Order(1)]
	[CanBeNull]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "Provider")]
	[DisplayName(typeof(__Resources_IRegularCurrencyRateImport), "P_Provider_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	Guid? Provider { get; set; }

	[Uid("d046a68d-3552-4a62-838a-4fade96c8e71")]
	[Order(2)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "a69fb8a1-e116-4f4f-909a-fd5bbd2beb9b")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "CurrencyEstimated")]
	[DisplayName(typeof(__Resources_IRegularCurrencyRateImport), "P_CurrencyEstimated_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	ICurrency CurrencyEstimated { get; set; }

	[Uid("a419df85-fcb1-4f9e-820a-e9ebdf7115f3")]
	[Order(3)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "a69fb8a1-e116-4f4f-909a-fd5bbd2beb9b")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "CurrencyValuation")]
	[DisplayName(typeof(__Resources_IRegularCurrencyRateImport), "P_CurrencyValuation_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	ICurrency CurrencyValuation { get; set; }
}
