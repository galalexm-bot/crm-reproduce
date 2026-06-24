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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Controllers.ExchangeRates
{
    [ActiveMenuItem("crm-admin-menu")]
    [Permission("7B1CC80C-1AD0-404A-8564-06DE4B269469")]
    public class AutomaticCurrencyImportController : BPMController<IRegularCurrencyRateImport, long>
    {
        public ActionResult Index([JsonBinder] List<CurrencyImportGridRowModel> items)
        {
            CurrencyExchangeImportSettings settings = Locator.GetServiceNotNull<CurrencyExchangeImportModule>().Settings;
            IEnumerable<Guid> providersGuids = ComponentManager.Current.GetExtensionPoints<IExchangeCurrencyRateImportProvider>().Select<IExchangeCurrencyRateImportProvider, Guid>((Func<IExchangeCurrencyRateImportProvider, Guid>)(p => p.Uid));
            ExchangeRateImportModel model = new ExchangeRateImportModel()
            {
                Settings = settings,
                Items = (ICollection<CurrencyImportGridRowModel>)RegularCurrencyRateImportManager.Instance.GetAllRowsForGrid(providersGuids).Distinct<CurrencyImportGridRowModel>().ToList<CurrencyImportGridRowModel>()
            };
            if (items != null && items.Any<CurrencyImportGridRowModel>())
            {
                model.Items = (ICollection<CurrencyImportGridRowModel>)model.Items.Concat<CurrencyImportGridRowModel>((IEnumerable<CurrencyImportGridRowModel>)items).Distinct<CurrencyImportGridRowModel>().ToList<CurrencyImportGridRowModel>();
                RegularCurrencyRateImportManager.Instance.Update((IEnumerable<CurrencyImportGridRowModel>)model.Items);
            }
            return View((object)model);
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
            return RedirectToAction("Index", "AutomaticCurrencyImport", new
            {
                area = "EleWise.ELMA.CRM.Web"
            });
        }
    }
}
