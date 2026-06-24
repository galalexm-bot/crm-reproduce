using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Enums.ExchangeRates;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.CRM.Extensions;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
[DeveloperApi(DeveloperApiType.ExtensionPoint)]
public interface IExchangeCurrencyRateImportProvider
{
	string Name { get; }

	Guid Uid { get; }

	bool CanFillingCurrencies { get; }

	bool CanAutomaticFilling { get; }

	bool CanFillingWithFile { get; }

	IEnumerable<string> CurrenciesEstimated { get; }

	IEnumerable<string> CurrenciesValuation { get; }

	IEnumerable<ICurrency> GetNewCurrencies(ExchangeRatesImportType type, string filePath = "");

	IEnumerable<string> FillСurrencyDynamics(IEnumerable<string> currenciesValuationCodes, string currencyEstimatedCode, DateTime fromDate, DateTime toDate);
}
