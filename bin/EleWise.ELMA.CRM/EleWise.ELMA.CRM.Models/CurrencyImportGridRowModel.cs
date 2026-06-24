using System;

namespace EleWise.ELMA.CRM.Models;

public class CurrencyImportGridRowModel
{
	public Guid? Uid { get; set; }

	public long Id { get; set; }

	public Guid? Provider { get; set; }

	public string EstimatedCode { get; set; }

	public string ValuationCode { get; set; }

	public override bool Equals(object obj)
	{
		if (!(obj is CurrencyImportGridRowModel currencyImportGridRowModel))
		{
			return false;
		}
		if ((!currencyImportGridRowModel.Provider.HasValue || currencyImportGridRowModel.Provider.Equals(Provider)) && currencyImportGridRowModel.EstimatedCode.Equals(EstimatedCode))
		{
			return currencyImportGridRowModel.ValuationCode.Equals(ValuationCode);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return EstimatedCode.GetHashCode() ^ ValuationCode.GetHashCode() ^ Provider.GetHashCode();
	}
}
