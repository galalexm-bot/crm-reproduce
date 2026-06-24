using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Components;
using EleWise.ELMA.CRM.Extensions;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Security;

namespace EleWise.ELMA.CRM.Web.Controllers.ExchangeRates;

[ActiveMenuItem("crm-admin-menu")]
[Permission("7B1CC80C-1AD0-404A-8564-06DE4B269469")]
public class CurrencyRatesGridController : BPMController<IRegularCurrencyRateImport, long>
{
	public ActionResult ProviderCell(Guid? providerGuid, string value = "")
	{
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		IEnumerable<IExchangeCurrencyRateImportProvider> extensionPoints = ComponentManager.Current.GetExtensionPoints<IExchangeCurrencyRateImportProvider>();
		List<SelectListItem> list = new List<SelectListItem>();
		string[] array = value.Split(',');
		if (array.Count() > 1)
		{
			string estimated = array[0];
			string valuation = array[1];
			foreach (IExchangeCurrencyRateImportProvider item in extensionPoints)
			{
				IEnumerable<string> currencyEstimatedCodes = item.GetCurrencyEstimatedCodes();
				IEnumerable<string> currencyValuationCodes = item.GetCurrencyValuationCodes();
				if (currencyEstimatedCodes.Any((string a) => a == estimated) && currencyValuationCodes.Any((string a) => a == valuation))
				{
					SelectListItem val = new SelectListItem();
					val.set_Text(item.Name);
					val.set_Value(item.Uid.ToString());
					SelectListItem val2 = val;
					if (providerGuid == item.Uid)
					{
						val2.set_Selected(true);
					}
					list.Add(val2);
				}
			}
		}
		return (ActionResult)(object)((Controller)this).PartialView((object)list);
	}

	public JsonResult GetCurrencies(string selectedPairs, string text = "")
	{
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected O, but got Unknown
		List<string> list = ((!string.IsNullOrEmpty(selectedPairs)) ? new JsonSerializer().Deserialize<List<string>>(selectedPairs) : new List<string>());
		IEnumerable<IExchangeCurrencyRateImportProvider> extensionPoints = ComponentManager.Current.GetExtensionPoints<IExchangeCurrencyRateImportProvider>();
		List<SelectListItem> list2 = new List<SelectListItem>();
		foreach (IExchangeCurrencyRateImportProvider item in extensionPoints)
		{
			List<string> list3 = item.GetCurrencyEstimatedCodes().Distinct().ToList();
			List<string> list4 = item.GetCurrencyValuationCodes().Distinct().ToList();
			foreach (string item2 in list3)
			{
				foreach (string item3 in list4)
				{
					if (item2 != item3)
					{
						string text2 = $"{item2},{item3}";
						string text3 = $"{item2} -> {item3}";
						if ((string.IsNullOrEmpty(text) || text3.ToLower().Contains(text.ToLower())) && !list.Contains(text2))
						{
							SelectListItem val = new SelectListItem();
							val.set_Value(text2);
							val.set_Text(text3);
							list2.Add(val);
						}
					}
				}
			}
		}
		JsonResult val2 = new JsonResult();
		val2.set_Data((object)list2);
		return val2;
	}

	public ActionResult LoadRow(CurrencyImportGridRowModel item, bool edit = false)
	{
		CurrencyImportGridRowModel currencyImportGridRowModel = item ?? new CurrencyImportGridRowModel();
		return (ActionResult)(object)((Controller)this).PartialView(edit ? "GridRow" : "DisplayGridRow", (object)currencyImportGridRowModel);
	}
}
