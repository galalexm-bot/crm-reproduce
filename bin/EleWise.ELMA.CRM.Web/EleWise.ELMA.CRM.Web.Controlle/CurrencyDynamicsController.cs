using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.CRM.Components;
using EleWise.ELMA.CRM.Enums.ExchangeRates;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.Web.Models.ExchangeRates;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Binders;
using EleWise.ELMA.Web.Mvc.Security;

namespace EleWise.ELMA.CRM.Web.Controllers.ExchangeRates;

[ActiveMenuItem("crm-admin-menu")]
[Permission("7B1CC80C-1AD0-404A-8564-06DE4B269469")]
public class CurrencyDynamicsController : BPMController
{
	[HttpGet]
	public ActionResult Index()
	{
		CurrencyDynamicsSettingsModel currencyDynamicsSettingsModel = new CurrencyDynamicsSettingsModel();
		return (ActionResult)(object)((Controller)this).View((object)currencyDynamicsSettingsModel);
	}

	[HttpPost]
	public ActionResult Index(CurrencyDynamicsSettingsModel settings, [JsonBinder] List<CurrencyImportGridRowModel> items)
	{
		CurrencyDynamicsSettingsModel currencyDynamicsSettingsModel = settings ?? new CurrencyDynamicsSettingsModel();
		if (settings != null && items != null && items.Any())
		{
			currencyDynamicsSettingsModel.Items = items.Distinct();
			List<string> list = CurrencyImportHelper.UpdateCurrenciesRates(currencyDynamicsSettingsModel.Items, ValueStorageForExchangeRates.WhithoutRemoving, currencyDynamicsSettingsModel.StartDate, currencyDynamicsSettingsModel.EndDate).ToList();
			if (list.Any())
			{
				foreach (string item in list)
				{
					base.Notifier.Warning(item);
				}
			}
			else
			{
				base.Notifier.Information(SR.T("Успешно импортированы курcы валют: {0}", string.Join(", ", currencyDynamicsSettingsModel.Items.Select((CurrencyImportGridRowModel it) => $"{it.EstimatedCode} -> {it.ValuationCode}"))));
			}
		}
		return (ActionResult)(object)((Controller)this).View((object)currencyDynamicsSettingsModel);
	}
}
