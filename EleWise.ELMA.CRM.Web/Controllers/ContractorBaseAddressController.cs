// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Controllers.ContractorBaseAddressController
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Components;
using EleWise.ELMA.CRM.Web.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Web.Content.Menu;
using EleWise.ELMA.Web.Mvc.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Controllers
{
  public class ContractorBaseAddressController : BPMController
  {
    public CrmSettingsModule SettingsModule { get; set; }

    [Permission("7B1CC80C-1AD0-404A-8564-06DE4B269469")]
    public ActionResult Settings()
    {
      ((Controller) this).SetCurrentMenuItem("crm-admin-menu");
      return View((object) ComponentManager.Current.GetExtensionPoints<IAddressBaseSettings>().SelectMany<IAddressBaseSettings, NamedValue<string>>((Func<IAddressBaseSettings, IEnumerable<NamedValue<string>>>) (p => p.Settings(((Controller) this).Url))).Where<NamedValue<string>>((Func<NamedValue<string>, bool>) (i => !string.IsNullOrWhiteSpace(i.Name) && !string.IsNullOrWhiteSpace(i.Value))));
    }

    [Permission("7B1CC80C-1AD0-404A-8564-06DE4B269469")]
    public ActionResult DefaultCountry()
    {
      ((Controller) this).SetCurrentMenuItem("crm-admin-menu");
      return View((object) this.SettingsModule.Settings);
    }

    [HttpPost]
    public ActionResult DefaultCountrySave(CrmSettings model)
    {
      this.SettingsModule.Settings.DefaultCountry = model.DefaultCountry;
      this.SettingsModule.SaveSettings();
      return RedirectToAction("Index", "Admin");
    }
  }
}
