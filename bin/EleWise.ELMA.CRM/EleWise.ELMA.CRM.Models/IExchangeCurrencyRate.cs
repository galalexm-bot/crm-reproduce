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
[Uid("fa9ecda0-1152-41ab-8670-70f35cdb83bc")]
[DisplayName(typeof(__Resources_IExchangeCurrencyRate), "DisplayName")]
[DisplayFormat(null)]
[TitleProperty("7fc69419-1a11-47a6-ab88-296d03ef15fc")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>a3f37115-ff01-44f7-bbcc-d4d6d4e65460</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("ExchangeCurrencyRate")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(true)]
[EntityMetadataType(EntityMetadataType.Interface)]
[Filterable]
[ImplementationUid("05efc026-9cf9-409a-936c-e0a152c82c11")]
[FilterType(typeof(IExchangeCurrencyRateFilter))]
public interface IExchangeCurrencyRate : IEntity<long>, IEntity, IIdentified
{
	[Uid("99ef89bf-c1c4-4615-bc20-3fe4b217177b")]
	[NotNull]
	[SystemProperty]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "Uid")]
	[DisplayName(typeof(__Resources_IExchangeCurrencyRate), "P_Uid_DisplayName")]
	[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[EntityProperty]
	Guid Uid { get; set; }

	[Uid("399ddde6-eaac-4d1d-921a-c9d6cc0c9d19")]
	[Order(2)]
	[NotNull]
	[Required(true)]
	[Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
	[DateTimeSettings(ShowTime = false, RangeInFilter = false, FieldName = "ValuationDate")]
	[RequiredField]
	[DisplayName(typeof(__Resources_IExchangeCurrencyRate), "P_ValuationDate_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[FastSearch(true)]
	[Filterable]
	[EntityProperty]
	DateTime ValuationDate { get; set; }

	[Uid("cd6aa25e-1d2e-4be2-b3f4-7c5f9c507409")]
	[Order(3)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "a69fb8a1-e116-4f4f-909a-fd5bbd2beb9b")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "CurrencyEstimated")]
	[DisplayName(typeof(__Resources_IExchangeCurrencyRate), "P_CurrencyEstimated_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	ICurrency CurrencyEstimated { get; set; }

	[Uid("779f9dec-758c-4e12-8284-d4f5bf5c54d7")]
	[Order(4)]
	[NotNull]
	[Required(true)]
	[Property("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
	[Int64Settings(DefaultValueStr = "1", FieldName = "Nominal")]
	[RequiredField]
	[DisplayName(typeof(__Resources_IExchangeCurrencyRate), "P_Nominal_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	long Nominal { get; set; }

	[Uid("235bbcf6-fd46-465f-b589-963e3c244248")]
	[Order(5)]
	[NotNull]
	[Required(true)]
	[Property("d3df6e6e-1ff1-46aa-ad60-d51ffa91ccc7")]
	[DoubleSettings(PrecisionString = "6", FieldName = "ExchangeRate")]
	[RequiredField]
	[DisplayName(typeof(__Resources_IExchangeCurrencyRate), "P_ExchangeRate_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	double ExchangeRate { get; set; }

	[Uid("a195d03e-fdd1-4b3d-b09a-bb4f6d0b9d60")]
	[Order(6)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "a69fb8a1-e116-4f4f-909a-fd5bbd2beb9b")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "CurrencyValuation")]
	[DisplayName(typeof(__Resources_IExchangeCurrencyRate), "P_CurrencyValuation_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	ICurrency CurrencyValuation { get; set; }

	[Uid("23198d81-3fbe-4765-95f2-7d18778100d5")]
	[Order(7)]
	[CanBeNull]
	[Property("d3df6e6e-1ff1-46aa-ad60-d51ffa91ccc7")]
	[CalculateType(PropertyCalculateType.CSScript)]
	[CalculateScript("ExchangeRate != null && Nominal != null ? ExchangeRate/Nominal : 0")]
	[DoubleSettings(PrecisionString = "6", FieldName = "RateToNominal")]
	[DisplayName(typeof(__Resources_IExchangeCurrencyRate), "P_RateToNominal_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	double? RateToNominal { get; set; }

	[Uid("7fc69419-1a11-47a6-ab88-296d03ef15fc")]
	[Order(1)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[CalculateType(PropertyCalculateType.CSScript)]
	[CalculateScript("SR.T(\"{0} -> {1} на {2}\", CurrencyEstimated != null ? CurrencyEstimated.Name : \"\", CurrencyValuation != null ? CurrencyValuation.Name : \"\", ValuationDate.ToString(\"dd.MM.yyyy\"))")]
	[StringSettings(FieldName = "Name")]
	[DisplayName(typeof(__Resources_IExchangeCurrencyRate), "P_Name_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[FastSearch(true)]
	[EntityProperty]
	string Name { get; set; }
}
