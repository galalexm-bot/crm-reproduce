// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Controllers.CrmSettingsModuleController
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Components;
using EleWise.ELMA.Web.Mvc.Models.Settings;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace EleWise.ELMA.CRM.Web.Controllers
{
  [Component(Order = 250)]
  public class CrmSettingsModuleController : 
    GlobalSettingsModuleControllerBase<CrmSettings, CrmSettingsModule>
  {
    public CrmSettingsModuleController(CrmSettingsModule module)
      : base(module)
    {
    }

    public override MvcHtmlString RenderDisplay(HtmlHelper html) => html.Action("View", "CrmSettings", (object) new
    {
      area = "EleWise.ELMA.CRM.Web"
    });

    public override MvcHtmlString RenderEdit(HtmlHelper html) => html.Action("Edit", "CrmSettings", (object) new
    {
      area = "EleWise.ELMA.CRM.Web"
    });
  }
}
