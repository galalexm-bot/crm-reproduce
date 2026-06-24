// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Portlets.InpaymentPortlet
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
  public class InpaymentPortlet : Portlet<InpaymentPortletPersonalization>
  {
    public static string UID_S = "{7593418A-71E2-41B4-B274-5433A0B002A1}";
    public static Guid UID = new Guid(InpaymentPortlet.UID_S);
    private readonly PortletProfile _profile;

    public InpaymentPortlet()
    {
      if (!(this.Profile is PortletProfile profile))
        profile = PortletProfile.Default;
      this._profile = profile;
      this._profile.Customizable = true;
      this._profile.ImageUrl = "#portlet_inpayment.svg";
    }

    public override Guid Uid => InpaymentPortlet.UID;

    public override string Category => EleWise.ELMA.SR.T("Работа с клиентами");

    public override string Name => EleWise.ELMA.SR.T("План поступлений");

    public override string Description => EleWise.ELMA.SR.T("Портлет отображения плана поступлений");

    public override bool AllowMultipleInstance => true;

    public override MvcHtmlString Content(HtmlHelper html, InpaymentPortletPersonalization data) => this.RenderContentAction(html, nameof (InpaymentPortlet), "Inpayment", "EleWise.ELMA.CRM.Web", data);

    public override MvcHtmlString Settings(
      HtmlHelper html,
      InpaymentPortletPersonalization data,
      string path)
    {
      return this.RenderSettingsPartialView(html, "Inpayment/InpaymentPortletSettings", data);
    }

    public override void BeforeRender(HtmlHelper html, InpaymentPortletPersonalization data) => data.NameUrl = html.Url().Action("Index", "Inpayment", (object) new
    {
      area = "EleWise.ELMA.CRM.Web",
      FilterId = data.FilterId
    });

    protected override Permission PortletPermission() => CRMPermissionProvider.CRMAccessPermission;
  }
}
