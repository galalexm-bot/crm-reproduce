// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Portlets.SalePortlet
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
  public class SalePortlet : Portlet<SalePortletPersonalization>
  {
    public static string UID_S = "{8325E479-2145-48EE-A2A3-D2334A233BE1}";
    public static Guid UID = new Guid(SalePortlet.UID_S);
    private readonly PortletProfile _profile;

    public SalePortlet()
    {
      if (!(this.Profile is PortletProfile profile))
        profile = PortletProfile.Default;
      this._profile = profile;
      this._profile.Customizable = true;
      this._profile.ImageUrl = "#deal.svg";
    }

    public override Guid Uid => SalePortlet.UID;

    public override string Category => EleWise.ELMA.SR.T("Работа с клиентами");

    public override string Name => EleWise.ELMA.SR.T("Сделки");

    public override string Description => EleWise.ELMA.SR.T("Портлет отображения сделок");

    public override bool AllowMultipleInstance => true;

    public override MvcHtmlString Content(HtmlHelper html, SalePortletPersonalization data) => this.RenderContentAction(html, nameof (SalePortlet), "Sale", "EleWise.ELMA.CRM.Web", data);

    public override MvcHtmlString Settings(
      HtmlHelper html,
      SalePortletPersonalization data,
      string path)
    {
      return this.RenderSettingsPartialView(html, "Sale/SalePortletSettings", data);
    }

    public override void BeforeRender(HtmlHelper html, SalePortletPersonalization data) => data.NameUrl = html.Url().Action("Index", "Sale", (object) new
    {
      area = "EleWise.ELMA.CRM.Web",
      FilterId = data.FilterId
    });

    protected override Permission PortletPermission() => CRMPermissionProvider.CRMAccessPermission;
  }
}
