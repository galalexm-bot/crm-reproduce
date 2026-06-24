// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Models.ExchangeRates.CurrencyImportModel
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Web.Mvc.Html.ChekBoxes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.CRM.Web.Models.ExchangeRates
{
  public class CurrencyImportModel
  {
    public List<CheckBoxListItem> ItemsList { get; set; }

    public string Currencies { get; set; }

    public CurrencyImportModel(IEnumerable<ICurrency> items)
    {
      this.Currencies = new JsonSerializer().Serialize((object) items);
      this.ItemsList = items.Select<ICurrency, CheckBoxListItem>((Func<ICurrency, CheckBoxListItem>) (currency => new CheckBoxListItem(currency.CodeISONumerical.ToString(), currency.Name, false))).ToList<CheckBoxListItem>();
    }

    public CurrencyImportModel() => this.ItemsList = new List<CheckBoxListItem>();
  }
}
