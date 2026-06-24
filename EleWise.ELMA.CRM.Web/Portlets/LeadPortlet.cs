// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Portlets.LeadPortlet
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Portlets;
using System;
using System.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Portlets
{
  [Component]
  public class LeadPortlet : Portlet<LeadPortletPersonalization>
  {
    public static string UID_S = "{B4B77927-7767-422C-B80E-61FEA7E51A78}";
    public static Guid UID = new Guid(LeadPortlet.UID_S);
    private readonly PortletProfile _profile;

    public LeadPortlet()
    {
      if (!(this.Profile is PortletProfile profile))
        profile = PortletProfile.Default;
      this._profile = profile;
      this._profile.Customizable = true;
      this._profile.ImageUrl = "#user.svg";
    }

    public override Guid Uid => LeadPortlet.UID;

    public override string Category => EleWise.ELMA.SR.T("Работа с клиентами");

    public override string Name => EleWise.ELMA.SR.T("Возможности");

    public override string Description => EleWise.ELMA.SR.T("Портлет отображения возможностей");

    public override bool AllowMultipleInstance => true;

    public override MvcHtmlString Content(HtmlHelper html, LeadPortletPersonalization data) => this.RenderContentAction(html, nameof (LeadPortlet), "Lead", "EleWise.ELMA.CRM.Web", data);

    public override MvcHtmlString Settings(
      HtmlHelper html,
      LeadPortletPersonalization data,
      string path)
    {
      return this.RenderSettingsPartialView(html, "Lead/LeadPortletSettings", data);
    }

    public override void BeforeRender(HtmlHelper html, LeadPortletPersonalization data) => data.NameUrl = html.Url().Action("Index", "Lead", (object) new
    {
      area = "EleWise.ELMA.CRM.Web",
      FilterId = data.FilterId
    });

    protected override Permission PortletPermission() => CRMPermissionProvider.CRMAccessPermission;
  }
}
