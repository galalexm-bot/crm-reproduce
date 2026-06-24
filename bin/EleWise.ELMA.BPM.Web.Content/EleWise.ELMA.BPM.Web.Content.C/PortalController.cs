using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Content.Portlets;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.Security;

namespace EleWise.ELMA.BPM.Web.Content.Controllers;

[Permission("F7B8B68B-FFD1-4211-ACDE-C60E2065E6A6")]
public class PortalController : BPMController
{
	[ContentItem(Name = "SR.M('Настройки портала')", Image24 = "~/Content/IconPack/setting.svg")]
	public ActionResult Index()
	{
		return (ActionResult)(object)((Controller)this).View();
	}

	public ActionResult PortalHomePortlet(PortalHomePortletPersonalization settings)
	{
		return (ActionResult)(object)((Controller)this).PartialView("PortalHomePortlet", (object)settings);
	}
}
