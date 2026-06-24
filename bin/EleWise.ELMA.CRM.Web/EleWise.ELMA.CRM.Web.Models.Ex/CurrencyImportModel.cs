using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Web.Mvc.Html.ChekBoxes;

namespace EleWise.ELMA.CRM.Web.Models.ExchangeRates;

public class CurrencyImportModel
{
	public List<CheckBoxListItem> ItemsList { get; set; }

	public string Currencies { get; set; }

	public CurrencyImportModel(IEnumerable<ICurrency> items)
	{
		Currencies = new JsonSerializer().Serialize(items);
		ItemsList = items.Select((ICurrency currency) => new CheckBoxListItem(currency.CodeISONumerical.ToString(), currency.Name, isChecked: false)).ToList();
	}

	public CurrencyImportModel()
	{
		ItemsList = new List<CheckBoxListItem>();
	}
}
