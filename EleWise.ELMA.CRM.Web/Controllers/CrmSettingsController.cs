// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Controllers.CrmSettingsController
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.CRM.Components;
using EleWise.ELMA.Web.Mvc.Security;
using System.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Controllers
{
  [AnyPermission(new string[] {"7B1CC80C-1AD0-404A-8564-06DE4B269469"})]
  public class CrmSettingsController : BPMController
  {
    public CrmSettingsModule SettingsModule { get; set; }

    public CrmSettings Settings => this.SettingsModule.Settings;

    [HttpGet]
    public ActionResult View() => PartialView((object) this.Settings);

    [HttpGet]
    public ActionResult Edit() => PartialView((object) this.Settings);
  }
}
