using System.Collections.Generic;
using EleWise.ELMA.CRM.Components;
using EleWise.ELMA.CRM.Models;

namespace EleWise.ELMA.CRM.Web.Models.ExchangeRates;

public class ExchangeRateImportModel
{
	public CurrencyExchangeImportSettings Settings { get; set; }

	public ICollection<CurrencyImportGridRowModel> Items { get; set; }
}
