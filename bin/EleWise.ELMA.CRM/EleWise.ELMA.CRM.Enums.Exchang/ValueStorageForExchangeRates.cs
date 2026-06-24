using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.CRM.Enums.ExchangeRates;

public enum ValueStorageForExchangeRates
{
	[DisplayName(typeof(__Resources_ValueStorageForExchangeRates), "P_WhithoutRemoving_DisplayName")]
	WhithoutRemoving,
	[DisplayName(typeof(__Resources_ValueStorageForExchangeRates), "P_Current_DisplayName")]
	Current
}
