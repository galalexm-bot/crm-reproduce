using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Extensions;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.Web.Models.ExchangeRates;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Controllers;
using EleWise.ELMA.Web.Mvc.Html.ChekBoxes;
using EleWise.ELMA.Web.Mvc.Security;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Controllers.ExchangeRates
{
    [ActiveMenuItem("crm-admin-menu")]
    [Permission("7B1CC80C-1AD0-404A-8564-06DE4B269469")]
    public class CurrencyQualifierController : BPMController
    {
        public ActionResult Index() => View((object)new ExchangeRateImportSettings());

        [HttpPost]
        public RedirectToRouteResult Import(string currencies = null, string[] itemsList = null)
        {
            if (!string.IsNullOrEmpty(currencies) && itemsList != null)
            {
                try
                {
                    IEnumerable<ICurrency> enumerable = from a in Deserialize(currencies)
                                                        where itemsList.Contains(a.CodeISONumerical.ToString())
                                                        select a;
                    enumerable.Each(delegate (ICurrency s)
                    {
                        s.Save();
                    });
                    base.Notifier.Information(SR.T("Импортированы валюты : {0}", string.Join(", ", enumerable.Select((ICurrency it) => it.Name))));
                }
                catch (Exception ex)
                {
                    EleWise.ELMA.Logging.Logger.Log.Error(ex);
                    base.Notifier.Error(SR.T("Импорт валют не удался. Ошибка: {0}", ex.Message));
                }
            }
            return RedirectToAction("Index", "CurrencyQualifier", new
            {
                area = "EleWise.ELMA.CRM.Web"
            });
        }

        public static List<ICurrency> Deserialize(string items)
        {
            ExpandoObject[] source = new JsonSerializer().Deserialize<ExpandoObject[]>(items);
            EntityJsonSerializer serializer = new EntityJsonSerializer();
            Func<ExpandoObject, ICurrency> selector = (Func<ExpandoObject, ICurrency>)(s => (ICurrency)serializer.ConvertFromSerializable((IDictionary<string, object>)s, InterfaceActivator.TypeOf<ICurrency>()));
            return ((IEnumerable<ExpandoObject>)source).Select<ExpandoObject, ICurrency>(selector).ToList<ICurrency>();
        }

        public ActionResult CurrencyList(ExchangeRateImportSettings settings)
        {
            if (settings == null)
            {
                base.Notifier.Error(SR.T("Не были найдены настройки импорта классификаторов валют"));
                return RedirectToIndexAjax();
            }
            bool flag = settings.File != null && settings.File.ContentLocation != null;
            string text = "";
            IExchangeCurrencyRateImportProvider exchangeCurrencyRateImportProvider = ComponentManager.Current.GetExtensionPoints<IExchangeCurrencyRateImportProvider>().FirstOrDefault((IExchangeCurrencyRateImportProvider a) => a.Uid == settings.Provider);
            if (exchangeCurrencyRateImportProvider == null)
            {
                base.Notifier.Error(SR.T("Не удалось найти подходящий компонент для реализации {0}", "IExchangeCurrencyRateImportProvider"));
                return RedirectToIndexAjax();
            }
            if (flag)
            {
                text = IOExtensions.GetTempFileName(settings.File.Extension);
                settings.File.SaveToLocalPath(text);
            }
            IEnumerable<ICurrency> newCurrencies = exchangeCurrencyRateImportProvider.GetNewCurrencies(settings.ExchangeRatesImportType, text);
            if (flag)
            {
                try
                {
                    System.IO.File.Delete(text);
                }
                catch (Exception ex)
                {
                    base.Logger.Warn(SR.T("Не удалось удалить временный файл ({0}) после импорта новых валют: {1}", text, ex));
                }
            }
            IEnumerable<string> availableCodes = CurrencyManager.Instance.GetAvalailableCodes();
            CurrencyImportModel currencyImportModel = new CurrencyImportModel(newCurrencies.Where((ICurrency n) => string.IsNullOrEmpty(n.CodeISOAlphabetic) || !availableCodes.Contains(n.CodeISOAlphabetic)));
            if (!currencyImportModel.ItemsList.Any())
            {
                if (newCurrencies.Any())
                {
                    base.Notifier.Information(SR.T("Не найдено новых классификаторов для импорта. Они уже были добавлены в справочник валют"));
                    return RedirectToIndexAjax();
                }
                base.Notifier.Error(SR.T("Не найдено новых классификаторов для импорта. Возможно, не указана ссылка к файлу импорта курса валют"));
                return RedirectToIndexAjax();
            }
            return PartialView(currencyImportModel);
        }
        public ActionResult CurrencyImportSettings(Guid guid) => PartialView((object)new ExchangeRateImportSettings()
        {
            Provider = guid
        });

        private ActionResult RedirectToIndexAjax() => Json((object)new
        {
            RedirectUrl = ((Controller)this).Url.Action("Index", (object)new
            {
                area = "EleWise.ELMA.CRM.Web"
            })
        });
    }
}
