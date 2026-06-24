using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.CRM.Components;
using EleWise.ELMA.Web.Mvc.Security;

namespace EleWise.ELMA.CRM.Web.Controllers;

[AnyPermission(new string[] { "7B1CC80C-1AD0-404A-8564-06DE4B269469" })]
public class CrmSettingsController : BPMController
{
	public CrmSettingsModule SettingsModule { get; set; }

	public CrmSettings Settings => SettingsModule.Settings;

	[HttpGet]
	public ActionResult View()
	{
		return (ActionResult)(object)((Controller)this).PartialView((object)Settings);
	}

	[HttpGet]
	public ActionResult Edit()
	{
		return (ActionResult)(object)((Controller)this).PartialView((object)Settings);
	}
}
