using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.CRM.Models;

[FilterFor(typeof(IExchangeCurrencyRate))]
public interface IExchangeCurrencyRateFilter : IEntityFilter
{
	DateTime? ValuationDate { get; set; }

	ICurrency CurrencyEstimated { get; set; }

	ICurrency CurrencyValuation { get; set; }
}
