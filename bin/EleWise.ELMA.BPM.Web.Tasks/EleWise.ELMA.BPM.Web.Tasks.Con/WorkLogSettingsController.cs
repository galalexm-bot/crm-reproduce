using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.Tasks;
using EleWise.ELMA.Web.Mvc.Security;

namespace EleWise.ELMA.BPM.Web.Tasks.Controllers;

[Permission("7B1CC80C-1AD0-404A-8564-06DE4B269469")]
public class WorkLogSettingsController : BPMController
{
	public WorkLogSettingsModule SettingsModule { get; set; }

	public WorkLogSettings Settings => SettingsModule.Settings;

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
