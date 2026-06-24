using System;

namespace EleWise.ELMA.CRM.Models;

public class ExchangeCurrencyRateImportModel
{
	public DateTime? ValuationDate { get; set; }

	public string CurrencyEstimated { get; set; }

	public int Nominal { get; set; }

	public double ExchangeRate { get; set; }

	public string CurrenctValuation { get; set; }
}
