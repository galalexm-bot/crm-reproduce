using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security;
using EleWise.ELMA.Web.Mvc.Portlets;
using System;
using System.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Portlets
{
    [Component]
    public class CRMHomePortlet : Portlet<CRMHomePortletPersonalization>
    {
        public static string UID_S = "{1C2D3237-D272-45CA-B7BD-B60034A72B8A}";
        public static Guid UID = new Guid(CRMHomePortlet.UID_S);
        private readonly PortletProfile profile;

        public CRMHomePortlet()
        {
            if (!(base.Profile is PortletProfile profile))
                profile = PortletProfile.Default;
            this.profile = profile;
            this.profile.ImageUrl = "#user.svg";
            this.profile.Customizable = false;
        }

        public override Guid Uid => CRMHomePortlet.UID;

        public override MvcHtmlString Content(HtmlHelper html, CRMHomePortletPersonalization data) => this.RenderContentAction(html, "HomePortlet", "Admin", "EleWise.ELMA.CRM.Web", data);

        public override string Name => EleWise.ELMA.SR.T("Работа с клиентами");

        public override string Description => EleWise.ELMA.SR.T("Домашний портлет со ссылками на разделы администрирования модуля Работа с клиентами");

        public override IPortletProfile Profile => (IPortletProfile)this.profile;

        protected override Permission PortletPermission() => PermissionProvider.AccessManagmentPermission;

        public override bool AllowMultipleInstance => false;

        public override PortletPersonalization CreateDefaultSettings(string path)
        {
            CRMHomePortletPersonalization crmhomePortletPersonalization = base.CreateDefaultSettings(path) as CRMHomePortletPersonalization;
            if (crmhomePortletPersonalization != null)
            {
                crmhomePortletPersonalization.HeaderColor = "#A8DAFA";
                crmhomePortletPersonalization.Frame = PortletFrame.HeaderLine;
            }
            return crmhomePortletPersonalization;
        }
    }
}
