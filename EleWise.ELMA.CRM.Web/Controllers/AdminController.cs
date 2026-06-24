// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Controllers.AdminController
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.CRM.Web.Portlets;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.Security;
using System.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Controllers
{
  [Permission("7B1CC80C-1AD0-404A-8564-06DE4B269469")]
  public class AdminController : BPMController<ISchedule, long>
  {
    [ContentItem(Name = "SR.M('Клиенты')", Image24 = "#crm.svg")]
    [Permission("0B298062-9DE5-46E5-8D1D-C46B3680809A")]
    public ActionResult Index() => (ActionResult) View("ModuleSettingsPage");

    public PartialViewResult HomePortlet(CRMHomePortletPersonalization settings) => PartialView(nameof (HomePortlet), (object) settings);
  }
}
