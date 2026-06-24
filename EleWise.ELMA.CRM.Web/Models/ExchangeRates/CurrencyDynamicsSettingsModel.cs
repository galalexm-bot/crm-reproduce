// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Models.ExchangeRates.CurrencyDynamicsSettingsModel
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Types.Settings;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.CRM.Web.Models.ExchangeRates
{
  public class CurrencyDynamicsSettingsModel
  {
    [DisplayName(typeof (__Resources_CurrencyDynamicsSettingsModel), "P_StartDate_DisplayName")]
    [DateTimeSettings(ShowDate = true, ShowTime = false)]
    public DateTime StartDate { get; set; }

    [DisplayName(typeof (__Resources_CurrencyDynamicsSettingsModel), "P_EndDate_DisplayName")]
    [DateTimeSettings(ShowDate = true, ShowTime = false)]
    public DateTime EndDate { get; set; }

    public IEnumerable<CurrencyImportGridRowModel> Items { get; set; }

    public CurrencyDynamicsSettingsModel() => this.Items = (IEnumerable<CurrencyImportGridRowModel>) new List<CurrencyImportGridRowModel>();
  }
}
