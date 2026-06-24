using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.CRM.Enums.ExchangeRates;

public enum ExchangeRatesImportType
{
	[DisplayName(typeof(__Resources_ExchangeRatesImportType), "P_Automatically_DisplayName")]
	Automatically,
	[DisplayName(typeof(__Resources_ExchangeRatesImportType), "P_Manually_DisplayName")]
	Manually
}
