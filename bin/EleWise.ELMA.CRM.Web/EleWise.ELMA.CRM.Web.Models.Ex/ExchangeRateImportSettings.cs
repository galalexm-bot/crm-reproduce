using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Enums.ExchangeRates;
using EleWise.ELMA.CRM.Extensions;
using EleWise.ELMA.Files;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Types.Validation;

namespace EleWise.ELMA.CRM.Web.Models.ExchangeRates;

public class ExchangeRateImportSettings
{
	[DisplayName(typeof(__Resources_ExchangeRatesImportSettingsModel), "P_Provider_DisplayName")]
	public Guid Provider { get; set; }

	[DisplayName(typeof(__Resources_ExchangeRatesImportSettingsModel), "P_File_DisplayName")]
	[Required(true)]
	[RequiredField]
	public BinaryFile File { get; set; }

	[DisplayName(typeof(__Resources_ExchangeRatesImportSettingsModel), "P_ExchangeRatesImportType_DisplayName")]
	public ExchangeRatesImportType ExchangeRatesImportType { get; set; }

	public ExchangeRateImportSettings()
	{
		List<IExchangeCurrencyRateImportProvider> source = ComponentManager.Current.GetExtensionPoints<IExchangeCurrencyRateImportProvider>().ToList();
		if (source.Any())
		{
			Provider = source.FirstOrDefault().Uid;
		}
	}
}
