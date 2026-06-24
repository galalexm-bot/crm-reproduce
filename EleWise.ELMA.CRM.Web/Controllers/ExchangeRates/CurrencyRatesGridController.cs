// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Controllers.ExchangeRates.CurrencyRatesGridController
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Components;
using EleWise.ELMA.CRM.Extensions;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Controllers.ExchangeRates
{
  [ActiveMenuItem("crm-admin-menu")]
  [Permission("7B1CC80C-1AD0-404A-8564-06DE4B269469")]
  public class CurrencyRatesGridController : BPMController<IRegularCurrencyRateImport, long>
  {
    public ActionResult ProviderCell(Guid? providerGuid, string value = "")
    {
      IEnumerable<IExchangeCurrencyRateImportProvider> extensionPoints = ComponentManager.Current.GetExtensionPoints<IExchangeCurrencyRateImportProvider>();
      List<SelectListItem> model = new List<SelectListItem>();
      string[] source = value.Split(',');
      if (((IEnumerable<string>) source).Count<string>() > 1)
      {
        string estimated = source[0];
        string valuation = source[1];
        foreach (IExchangeCurrencyRateImportProvider provider in extensionPoints)
        {
          IEnumerable<string> currencyEstimatedCodes = provider.GetCurrencyEstimatedCodes();
          IEnumerable<string> currencyValuationCodes = provider.GetCurrencyValuationCodes();
          Func<string, bool> predicate = (Func<string, bool>) (a => a == estimated);
          if (currencyEstimatedCodes.Any<string>(predicate) && currencyValuationCodes.Any<string>((Func<string, bool>) (a => a == valuation)))
          {
            SelectListItem selectListItem = new SelectListItem()
            {
              Text = provider.Name,
              Value = provider.Uid.ToString()
            };
            Guid? nullable = providerGuid;
            Guid uid = provider.Uid;
            if ((nullable.HasValue ? (nullable.HasValue ? (nullable.GetValueOrDefault() == uid ? 1 : 0) : 1) : 0) != 0)
              selectListItem.Selected = true;
            model.Add(selectListItem);
          }
        }
      }
      return PartialView((object) model);
    }

    public JsonResult GetCurrencies(string selectedPairs, string text = "")
    {
      List<string> stringList = !string.IsNullOrEmpty(selectedPairs) ? new JsonSerializer().Deserialize<List<string>>(selectedPairs) : new List<string>();
      IEnumerable<IExchangeCurrencyRateImportProvider> extensionPoints = ComponentManager.Current.GetExtensionPoints<IExchangeCurrencyRateImportProvider>();
      List<SelectListItem> selectListItemList = new List<SelectListItem>();
      foreach (IExchangeCurrencyRateImportProvider provider in extensionPoints)
      {
        List<string> list1 = provider.GetCurrencyEstimatedCodes().Distinct<string>().ToList<string>();
        List<string> list2 = provider.GetCurrencyValuationCodes().Distinct<string>().ToList<string>();
        foreach (string str1 in list1)
        {
          foreach (string str2 in list2)
          {
            if (str1 != str2)
            {
              string str3 = string.Format("{0},{1}", (object) str1, (object) str2);
              string str4 = string.Format("{0} -> {1}", (object) str1, (object) str2);
              if ((string.IsNullOrEmpty(text) || str4.ToLower().Contains(text.ToLower())) && !stringList.Contains(str3))
                selectListItemList.Add(new SelectListItem()
                {
                  Value = str3,
                  Text = str4
                });
            }
          }
        }
      }
      return new JsonResult()
      {
        Data = (object) selectListItemList
      };
    }

    public ActionResult LoadRow(CurrencyImportGridRowModel item, bool edit = false)
    {
      CurrencyImportGridRowModel model = item ?? new CurrencyImportGridRowModel();
      return PartialView(edit ? "GridRow" : "DisplayGridRow", (object) model);
    }
  }
}
