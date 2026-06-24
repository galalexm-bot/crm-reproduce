// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Components.CrmModuleSettingsCurrencyItemProvider
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Extensions;
using EleWise.ELMA.CRM.Web.Extensions;
using EleWise.ELMA.CRM.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Components
{
  [Component(Order = 500)]
  public class CrmModuleSettingsCurrencyItemProvider : ICrmModuleSettingsItemProvider
  {
    public IEnumerable<CrmModuleSettingsItem> GetItems(UrlHelper urlHelper)
    {
      string str = EleWise.ELMA.SR.T("Импорт курсов валют");
      List<IExchangeCurrencyRateImportProvider> list = ComponentManager.Current.GetExtensionPoints<IExchangeCurrencyRateImportProvider>().ToList<IExchangeCurrencyRateImportProvider>();
      List<CrmModuleSettingsItem> items = new List<CrmModuleSettingsItem>();
      if (list.Any<IExchangeCurrencyRateImportProvider>())
      {
        items.AddRange((IEnumerable<CrmModuleSettingsItem>) new List<CrmModuleSettingsItem>()
        {
          new CrmModuleSettingsItem()
          {
            Order = 43,
            Category = str,
            Text = EleWise.ELMA.SR.T("Импортировать динамику курса валюты"),
            Description = EleWise.ELMA.SR.T("Получение динамики (за период) ежедневных курсов валюты"),
            Url = urlHelper.Action("Index", "CurrencyDynamics", (object) new
            {
              area = "EleWise.ELMA.CRM.Web"
            })
          },
          new CrmModuleSettingsItem()
          {
            Order = 44,
            Category = str,
            Text = EleWise.ELMA.SR.T("Автоматическое регулярное получение курсов валют"),
            Description = EleWise.ELMA.SR.T("Автоматическое регулярное получение курсов валют"),
            Url = urlHelper.Action("Index", "AutomaticCurrencyImport", (object) new
            {
              area = "EleWise.ELMA.CRM.Web"
            })
          }
        });
        if (list.Any<IExchangeCurrencyRateImportProvider>((Func<IExchangeCurrencyRateImportProvider, bool>) (p => p.CanFillingCurrencies)))
          items.Add(new CrmModuleSettingsItem()
          {
            Order = 42,
            Category = str,
            Text = EleWise.ELMA.SR.T("Импортировать классификатор валют"),
            Description = EleWise.ELMA.SR.T("Заполнение/дополнение справочника валют"),
            Url = urlHelper.Action("Index", "CurrencyQualifier", (object) new
            {
              area = "EleWise.ELMA.CRM.Web"
            })
          });
      }
      return (IEnumerable<CrmModuleSettingsItem>) items;
    }

    public IEnumerable<CrmModuleSettingsItem> GetObjects(UrlHelper urlHelper) => (IEnumerable<CrmModuleSettingsItem>) new List<CrmModuleSettingsItem>();
  }
}
