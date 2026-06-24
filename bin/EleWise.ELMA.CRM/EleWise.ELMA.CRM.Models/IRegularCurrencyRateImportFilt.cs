using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.CRM.Models;

[FilterFor(typeof(IRegularCurrencyRateImport))]
public interface IRegularCurrencyRateImportFilter : IEntityFilter
{
	Guid? Provider { get; set; }

	ICurrency CurrencyEstimated { get; set; }

	ICurrency CurrencyValuation { get; set; }
}
