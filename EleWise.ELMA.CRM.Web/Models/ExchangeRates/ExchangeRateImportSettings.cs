// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Models.ExchangeRates.ExchangeRateImportSettings
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Enums.ExchangeRates;
using EleWise.ELMA.CRM.Extensions;
using EleWise.ELMA.Files;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Types.Validation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.CRM.Web.Models.ExchangeRates
{
  public class ExchangeRateImportSettings
  {
    [DisplayName(typeof (__Resources_ExchangeRatesImportSettingsModel), "P_Provider_DisplayName")]
    public Guid Provider { get; set; }

    [DisplayName(typeof (__Resources_ExchangeRatesImportSettingsModel), "P_File_DisplayName")]
    [Required(true)]
    [RequiredField]
    public BinaryFile File { get; set; }

    [DisplayName(typeof (__Resources_ExchangeRatesImportSettingsModel), "P_ExchangeRatesImportType_DisplayName")]
    public ExchangeRatesImportType ExchangeRatesImportType { get; set; }

    public ExchangeRateImportSettings()
    {
      List<IExchangeCurrencyRateImportProvider> list = ComponentManager.Current.GetExtensionPoints<IExchangeCurrencyRateImportProvider>().ToList<IExchangeCurrencyRateImportProvider>();
      if (!list.Any<IExchangeCurrencyRateImportProvider>())
        return;
      this.Provider = list.FirstOrDefault<IExchangeCurrencyRateImportProvider>().Uid;
    }
  }
}
