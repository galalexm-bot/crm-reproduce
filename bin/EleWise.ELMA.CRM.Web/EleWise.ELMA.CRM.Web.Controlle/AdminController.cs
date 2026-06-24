using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.CRM.Web.Portlets;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.Security;

namespace EleWise.ELMA.CRM.Web.Controllers;

[Permission("7B1CC80C-1AD0-404A-8564-06DE4B269469")]
public class AdminController : BPMController<ISchedule, long>
{
	[ContentItem(Name = "SR.M('Клиенты')", Image24 = "#crm.svg")]
	[Permission("0B298062-9DE5-46E5-8D1D-C46B3680809A")]
	public ActionResult Index()
	{
		return (ActionResult)(object)((Controller)this).View("ModuleSettingsPage");
	}

	public PartialViewResult HomePortlet(CRMHomePortletPersonalization settings)
	{
		return ((Controller)this).PartialView("HomePortlet", (object)settings);
	}
}
