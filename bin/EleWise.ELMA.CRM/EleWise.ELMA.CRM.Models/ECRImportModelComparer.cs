using System.Collections.Generic;

namespace EleWise.ELMA.CRM.Models;

public class ECRImportModelComparer : IEqualityComparer<ExchangeCurrencyRateImportModel>
{
	public bool Equals(ExchangeCurrencyRateImportModel x, ExchangeCurrencyRateImportModel y)
	{
		if (x.CurrenctValuation.Equals(y.CurrenctValuation) && x.CurrencyEstimated.Equals(y.CurrencyEstimated))
		{
			return x.ValuationDate.Equals(y.ValuationDate);
		}
		return false;
	}

	public int GetHashCode(ExchangeCurrencyRateImportModel obj)
	{
		return 0;
	}
}
