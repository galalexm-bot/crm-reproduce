// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Controllers.ExchangeRates.CurrencyDynamicsController
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.CRM.Components;
using EleWise.ELMA.CRM.Enums.ExchangeRates;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.Web.Models.ExchangeRates;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Binders;
using EleWise.ELMA.Web.Mvc.Controllers;
using EleWise.ELMA.Web.Mvc.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Controllers.ExchangeRates
{
  [ActiveMenuItem("crm-admin-menu")]
  [Permission("7B1CC80C-1AD0-404A-8564-06DE4B269469")]
  public class CurrencyDynamicsController : BPMController
  {
    [HttpGet]
    public ActionResult Index() => View((object) new CurrencyDynamicsSettingsModel());

    [HttpPost]
    public ActionResult Index(
      CurrencyDynamicsSettingsModel settings,
      [JsonBinder] List<CurrencyImportGridRowModel> items)
    {
      CurrencyDynamicsSettingsModel model = settings ?? new CurrencyDynamicsSettingsModel();
      if (settings != null && items != null && items.Any<CurrencyImportGridRowModel>())
      {
        model.Items = items.Distinct<CurrencyImportGridRowModel>();
        List<string> list = CurrencyImportHelper.UpdateCurrenciesRates(model.Items, ValueStorageForExchangeRates.WhithoutRemoving, model.StartDate, model.EndDate).ToList<string>();
        if (list.Any<string>())
        {
          foreach (string text in list)
          {
            // ISSUE: explicit non-virtual call
            Notifier.Warning(text);
          }
        }
        else
        {
          // ISSUE: explicit non-virtual call
          Notifier.Information(EleWise.ELMA.SR.T("Успешно импортированы курcы валют: {0}", (object) string.Join(", ", model.Items.Select<CurrencyImportGridRowModel, string>((Func<CurrencyImportGridRowModel, string>) (it => string.Format("{0} -> {1}", (object) it.EstimatedCode, (object) it.ValuationCode))))));
        }
      }
      return View((object) model);
    }
  }
}
