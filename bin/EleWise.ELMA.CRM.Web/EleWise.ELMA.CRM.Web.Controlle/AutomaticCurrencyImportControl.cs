using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Components;
using EleWise.ELMA.CRM.Extensions;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.Web.Models.ExchangeRates;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Binders;
using EleWise.ELMA.Web.Mvc.Security;

namespace EleWise.ELMA.CRM.Web.Controllers.ExchangeRates;

[ActiveMenuItem("crm-admin-menu")]
[Permission("7B1CC80C-1AD0-404A-8564-06DE4B269469")]
public class AutomaticCurrencyImportController : BPMController<IRegularCurrencyRateImport, long>
{
	public ActionResult Index([JsonBinder] List<CurrencyImportGridRowModel> items)
	{
		CurrencyExchangeImportSettings settings = Locator.GetServiceNotNull<CurrencyExchangeImportModule>().Settings;
		IEnumerable<Guid> providersGuids = from p in ComponentManager.Current.GetExtensionPoints<IExchangeCurrencyRateImportProvider>()
			select p.Uid;
		ExchangeRateImportModel exchangeRateImportModel = new ExchangeRateImportModel
		{
			Settings = settings,
			Items = RegularCurrencyRateImportManager.Instance.GetAllRowsForGrid(providersGuids).Distinct().ToList()
		};
		if (items != null && items.Any())
		{
			exchangeRateImportModel.Items = exchangeRateImportModel.Items.Concat(items).Distinct().ToList();
			RegularCurrencyRateImportManager.Instance.Update(exchangeRateImportModel.Items);
		}
		return (ActionResult)(object)((Controller)this).View((object)exchangeRateImportModel);
	}

	public RedirectToRouteResult Save([JsonBinder] List<CurrencyImportGridRowModel> items, [JsonBinder] List<long> removedItems, ExchangeRateImportModel model)
	{
		if (model != null)
		{
			if (removedItems != null)
			{
				RegularCurrencyRateImportManager.Instance.RemoveByIdsArray(removedItems.ToArray());
			}
			if (items != null)
			{
				RegularCurrencyRateImportManager.Instance.Update(items);
			}
			if (model.Settings != null)
			{
				CurrencyExchangeImportModule serviceNotNull = Locator.GetServiceNotNull<CurrencyExchangeImportModule>();
				serviceNotNull.Settings = model.Settings;
				serviceNotNull.SaveSettings();
			}
		}
		return ((Controller)this).RedirectToAction("Index", "AutomaticCurrencyImport", (object)new
		{
			area = "EleWise.ELMA.CRM.Web"
		});
	}
}
